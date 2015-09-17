using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YunfuModel;
using YunfuBLL;
using YunfuTools;

namespace Yunfu
{
    public partial class FormDevice : Form
    {
        public FormDevice()
        {
            InitializeComponent();
            lblMsg.Text = "";
        }
        public FormDevice(string error_msg)
        {
            InitializeComponent();
            lblMsg.Text = error_msg;
            lblMsg.Visible = true;
        }

        private void FormDevice_Load(object sender, EventArgs e)
        {
            StringBuilder StrB = new StringBuilder();
            StrB.Append("请将您云付(http://YOUR DOMAINS/yunfu)下的添加的机器号填入设备号中。\n");

            rtxtHelpMsg.Text = StrB.ToString();

            txtDevice_no.Text = StaticData.Device.device_no;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DeviceBLL devBll = new DeviceBLL();
            StaticData.Device.device_no = txtDevice_no.Text.Trim();
            devBll.setConfig(StaticData.Device);

            string xml = devBll.setDevice();
            try
            {
                string is_success = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/is_success").InnerText;
                if (is_success == "T")
                {
                    StaticData.Device.device_name = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/device_name").InnerText;
                    StaticData.Device.username = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/username").InnerText;
                    StaticData.Device.pname = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/pname").InnerText;

                    StringBuilder strB = new StringBuilder();
                    strB.Append("请确认这是你添加的设备：\n");
                    strB.Append("用户名：" + StaticData.Device.username + "\n");
                    strB.Append("商户名称："+ StaticData.Device.pname +"\n");
                    strB.Append("设备名称：" + StaticData.Device.device_name + "\n");
                    strB.Append("确认后所有款项都将会进入此账户下.\n");

                    DialogResult result = MessageBox.Show(strB.ToString(), "信息确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        //确定按钮的方法
                        devBll.setConfig(StaticData.Device);
                        Application.Restart();
                    }
                    else
                    {
                        //取消按钮的方法
                    }
                }
                else
                {
                    string error_msg = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/error_msg").InnerText;
                    lblMsg.Text = error_msg;
                    lblMsg.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = "异常：" + ex.Message;
                lblMsg.Visible = true;
            }
        }
    }
}
