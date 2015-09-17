using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Xml;
using YunfuBLL;
using YunfuModel;
using YunfuTools;

namespace Yunfu
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            lblMsg.Text = "";
            BindCashier();
        }
        private void BindCashier()
        {
            CashierBLL cb = new CashierBLL();
            string xml = cb.getCashiers();

            ArrayList cashiers = new ArrayList();
            try
            {
                XmlNodeList nodelists = XMLStrHelper.GetXmlNodeListByXpath(xml, "Alipay/item");
                int selIndex = 0;
                if (nodelists.Count > 0)
                {
                    for (int i = 0; i < nodelists.Count; i++)
                    {
                        string cashier_name = nodelists.Item(i).InnerText;
                        cashiers.Add(cashier_name);
                        if (cashier_name == StaticData.Cashier.cashier_name)
                        {
                            selIndex = i;
                        }
                    }

                    cmbUsername.DataSource = cashiers;
                    cmbUsername.SelectedIndex = selIndex;
                }
                else
                {
                    lblMsg.Text = "您还未添加收银员请到服务端添加";
                    lblMsg.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = "异常：" + ex.Message;
                lblMsg.Visible = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string cashier_name = cmbUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if(password == ""){
                lblMsg.Text = "密码不能为空";
                lblMsg.Visible = true;
                return;
            }
            CashierBLL cb = new CashierBLL();
            string xml = cb.cashierLogin(cashier_name, password);
            try
            {
                string is_success = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/is_success").InnerText;

                if (is_success == "T")
                {
                    CashierBLL cashierBll = new CashierBLL();
                    StaticData.Cashier.cashier_id = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/cashier_id").InnerText;
                    StaticData.Cashier.cashier_no = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/cashier_no").InnerText;
                    StaticData.Cashier.cashier_name = cmbUsername.Text;
                    cashierBll.setConfig(StaticData.Cashier);

                    lblMsg.Text = "登录成功";
                    lblMsg.Visible = true;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (is_success == "F")
                {
                    string error_msg = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/error_msg").InnerText;
                    lblMsg.Text = error_msg;
                    lblMsg.Visible = true;
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

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(13))
            {
                e.Handled = true;
                this.btnOK_Click(sender, e);
            }
        }

        private void linklblPsd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelPsd.Visible = true;
        }

        private void linkLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelPsd.Visible = false;
        }
        /// <summary>  
        /// 获取可用的端口  
        /// </summary>  
        /// <returns></returns>   
        public List<string> GetComList()
        {
            List<string> ComList = new List<string>();
            Microsoft.VisualBasic.Devices.Computer pc = new Microsoft.VisualBasic.Devices.Computer();
            foreach (string s in pc.Ports.SerialPortNames)
            {
                ComList.Add(s);
            }
            return ComList;
        }  

        private void btmPsd_Click(object sender, EventArgs e)
        {
            string cashier_name = cmbUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string newpassword = txtPsd.Text.Trim();
            string repassword = txtRePsd.Text.Trim();
            if(password == ""){
                lblPsdMsg.Text = "密码不能为空";
                lblPsdMsg.Visible = true;
                return;
            }
            if (newpassword != repassword)
            {
                lblPsdMsg.Text = "两次密码不一致";
                lblPsdMsg.Visible = true;
                return;
            }
            CashierBLL cb = new CashierBLL();
            string xml = cb.cashierChangePsd(cashier_name, password, newpassword, repassword);
            try
            {
                string is_success = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/is_success").InnerText;

                if (is_success == "T")
                {
                    panelPsd.Visible = false;
                    lblMsg.Text = "密码修改成功";
                    lblMsg.Visible = true;
                    txtPassword.Text = "";
                }
                else if (is_success == "F")
                {
                    string error_msg = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/error_msg").InnerText;
                    lblPsdMsg.Text = error_msg;
                    lblPsdMsg.Visible = true;
                }
                else
                {
                    string error_msg = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/error_msg").InnerText;
                    lblPsdMsg.Text = error_msg;
                    lblPsdMsg.Visible = true;
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
