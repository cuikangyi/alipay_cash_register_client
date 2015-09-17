using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Threading;
using System.Reflection;
using System.Text.RegularExpressions;
using YunfuTools;
using YunfuModel;
using YunfuBLL;

namespace Yunfu
{
    public partial class FormMain : Form
    {
        private Point mypoint;

        private static OrderModel ORDER = null;

        private static int WaiteMM = 0;
        private static int ESC1MM = 80;
        private static string Trade_status;
        private static ConfigModel config = new ConfigModel();

        public FormMain()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            lblInfo.Text = "商户名称：" + StaticData.Device.pname + "|设备名称：" + StaticData.Device.device_name + "|收银员：" + StaticData.Cashier.cashier_name;
            lblVersion.Text = AssemblyFileVersion();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            payFinish();
        }

        private string AssemblyFileVersion()
        {
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false);
            if (attributes.Length == 0)
            {
                return "";
            }
            else
            {
                return ((AssemblyFileVersionAttribute)attributes[0]).Version;
            }
        }

        private void txtTotal_fee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != '.')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }  

            if (e.KeyChar == System.Convert.ToChar(13))
            {
                e.Handled = true;
                btnOK_Click(sender, e);
            }
        }

        private void txtDynamic_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }  

            if (this.txtDynamic_id.Text.Trim() == "")
            {
                this.txtDynamic_id.Focus();
                this.lblMsg2.Text = "请扫描...";
            }
            else
            {
                this.lblMsg2.Text = "提交中...";
            }
            if (e.KeyChar == System.Convert.ToChar(13))
            {
                e.Handled = true;
                if (txtDynamic_id.Text.Trim() == "")
                {
                    this.txtDynamic_id.Focus();
                    this.lblMsg2.Text = "请扫描...";
                }
                else
                {
                    this.txtDynamic_id.Enabled = false;
                    this.payProcess();
                }
            }
            if (e.KeyChar == System.Convert.ToChar(27))
            {
                e.Handled = true;
                this.lblMsg1.Text = "";
                this.lblTotal_fee.Visible = false;
                this.lblMsg2.Visible = false;
                this.picBg2.Visible = false;
                this.txtDynamic_id.Visible = false;
                this.btnOK.Enabled = true;
                this.txtTotal_fee.Focus();
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtTotal_fee.Text.Trim() != "")
            {
                if (!IsNumber(this.txtTotal_fee.Text.Trim().Replace("\r", "").Replace("\n", "")))
                {
                    this.btnOK.Enabled = true;
                    this.txtTotal_fee.Text = "";
                    this.lblMsg1.Text = "必须为数字,并最多保留2位小数...";
                }
                else
                {
                    decimal d = Convert.ToDecimal(this.txtTotal_fee.Text.Trim());
                    if (d < 0m || d > 1000000000)
                    {
                        this.btnOK.Enabled = true;
                        this.txtTotal_fee.Text = "";
                        this.lblMsg1.Text = "请输入正确的金额...";
                    }
                    else
                    {
                        this.btnOK.Enabled = false;
                        this.lblMsg2.Visible = true;
                        this.lblMsg1.Text = "";
                        this.lblMsg2.Text = "请扫描...";
                        this.lblTotal_fee.Text = this.txtTotal_fee.Text.Trim();
                        this.lblTotal_fee.Visible = true;
                        this.picBg2.Visible = true;
                        this.txtDynamic_id.Enabled = true;
                        this.txtDynamic_id.Visible = true;
                        this.txtDynamic_id.Text = "";
                        this.txtDynamic_id.Focus();
                        if (this.txtDynamic_id.Text.Trim() == "")
                        {
                            this.lblMsg2.Text = "请扫描...";
                        }
                        else
                        {
                            this.lblMsg2.Text = "";
                        }
                    }
                }
            }
            else
            {
                this.txtTotal_fee.Focus();
                this.lblMsg1.Text = "请输入金额...";
            }
        }

        private static bool RegexOperation(string syllable, string regex)
        {
            RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace;
            Regex regex2 = new Regex(regex, options);
            return regex2.IsMatch(syllable);
        }
        private static bool IsNumber(string syllable)
        {
            string reg = "^(([1-9]{1}\\d*)|([0]{1}))(\\.(\\d){1,2})?$";
            return RegexOperation(syllable, reg);
        }

        private void payProcess()
        {
            ORDER = new OrderModel();
            string total_fee = txtTotal_fee.Text.Trim();
            string dym_id = txtDynamic_id.Text.Trim();
            ORDER.Total_fee = Convert.ToDecimal(total_fee);
            AlipayBLL ab = new AlipayBLL();

            string xml = ab.pay(dym_id,total_fee);

            try
            {
                string is_success = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/is_success").InnerText;
                if (is_success == "T")
                {
                    string result_code = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/result_code").InnerText;
                    ORDER.Out_trade_no = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/out_trade_no").InnerText;
                    ORDER.Buyer_email = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/buyer_email").InnerText;

                    if (result_code == "ORDER_SUCCESS_PAY_SUCCESS")
                    {
                        paySuccess();
                    }
                    else if (result_code == "ORDER_SUCCESS_PAY_INPROCESS")
                    {
                        WaiteMM = 0;
                        ESC1MM = 60;
                        this.timer1.Enabled = true;
                        this.btnClear.Enabled = false;
                        this.lblMsg2.Text = "待支付中...10秒后可按Esc退出";
                        Thread thread = new Thread(this.waitPay);
                        thread.IsBackground = true;
                        thread.Start(ORDER);
                        //payFinish();
                    }
                }
                else
                {
                    string error_msg = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/error_msg").InnerText;
                    MessageHelper.ShowWarning("失败：" + error_msg);
                    payFinish();
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError("异常：" + ex.Message);
                payFinish();
            }            
        }

        private void paySuccess()
        {
            //显示成功窗体
            FormPaySuccess paySuccess = new FormPaySuccess(ORDER);
            paySuccess.ShowDialog();
            paySuccess.Dispose();
            printOrder();
            payFinish();
        }

        private void printOrder()
        {
            PrintUtils.printOrder(ORDER);
        }

        private void payFinish()
        {
            timer1.Enabled = false;
            this.lblMsg1.Text = "";
            this.lblTotal_fee.Visible = false;
            this.lblMsg2.Visible = false;
            this.picBg2.Visible = false;
            this.txtDynamic_id.Enabled = false;
            this.txtDynamic_id.Visible = false;
            this.txtTotal_fee.Text = "";
            this.txtDynamic_id.Text = "";
            this.btnOK.Enabled = true;
            this.btnClear.Enabled = true;
            this.txtTotal_fee.Focus();
        }


        private void waitPay(object ParObject)
        {
            OrderModel om = (OrderModel)ParObject;
            AlipayBLL ab = new AlipayBLL();
            for (int i = 0; i < 60; i++)
            {
                WaiteMM++;
                string xml = ab.paystatus(om.Out_trade_no);
                try
                {
                    string is_success = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/is_success").InnerText;
                    if (is_success == "T")
                    {
                        Trade_status = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/trade_code").InnerText;

                        if (Trade_status == "success")
                        {
                            this.lblMsg1.Text = "请输入金额...";
                            this.btnOK.Enabled = true;
                            this.btnClear.Enabled = true;
                            this.timer1.Enabled = false;
                            this.paySuccess();
                            break;
                        }
                        if (i >= ESC1MM)
                        {
                            this.btnOK.Enabled = true;
                            this.timer1.Enabled = false;
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    this.lblMsg1.Text = "异常：" + ex.Message;
                }
                finally
                {
                    Thread.Sleep(1000);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ConfirmYesNo("将退出系统，确定吗？\n确定—退出系统，否—最小化到通知栏"))
            {
                Application.Exit();
            }
            else
            {
                this.btnMin_Click(sender, e);
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.notifyIcon1.Visible = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            base.Show();
            base.WindowState = FormWindowState.Normal;
            base.Activate();
            txtTotal_fee.Focus();
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            FormConfig formConfig = new FormConfig();
            formConfig.ShowDialog();
            formConfig.Dispose();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FormOrderList orderList = new FormOrderList();
            orderList.ShowDialog();
            orderList.Dispose();
        }


        private void picBg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myposition = Control.MousePosition;
                myposition.Offset(mypoint.X, mypoint.Y);
                this.DesktopLocation = myposition;
            }
        }

        private void picBg_MouseDown(object sender, MouseEventArgs e)
        {
            mypoint = new Point(-e.X, -e.Y);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            payFinish();
        }

        private void linkLabelYunfuInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://YOUR DOMAINS");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (10 - WaiteMM > 0)
            {
                this.lblMsg2.Text = "支付中...10秒后可按Esc取消:" + (10 - WaiteMM);
            }
            else
            {
                if (WaiteMM > 0)
                {
                    this.lblMsg2.Text = "可按Esc取消或继续等待支付...";
                    this.btnClear.Enabled = true;
                    if (WaiteMM >= 59)
                    {
                        this.timer1.Enabled = false;
                        if (Trade_status == "" || Trade_status == "WAIT_BUYER_PAY")
                        {
                            this.btnOK.Enabled = true;
                            this.lblMsg2.Text = "扫码收款，等待超时！";
                        }
                        else
                        {
                            this.btnOK.Enabled = true;
                            this.lblMsg2.Text = "扫码收款," + Trade_status;
                        }
                    }
                }
            }
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                this.Dispose();

                this.Close();

            }
        }
    }
}
