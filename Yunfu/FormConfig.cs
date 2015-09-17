using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using YunfuBLL;
using YunfuModel;

namespace Yunfu
{
    public partial class FormConfig : Form
    {
        private Point mypoint;

        private ConfigBLL cb = new ConfigBLL();

        public FormConfig()
        {
            InitializeComponent();
            lblMsg.Text = "";
            printSet();
            lptPrintSet();

            PrintDocument print = new PrintDocument();
            string sDefault = StaticData.Config.printerName;//默认打印机名
            
            foreach (string sPrint in PrinterSettings.InstalledPrinters)//获取所有打印机名称
            {
                lstPrinter.Items.Add(sPrint);
                if (sPrint == sDefault)
                {
                    lstPrinter.SelectedIndex = lstPrinter.Items.IndexOf(sPrint);
                }
            }
            lstLpt.Items.Add("Lpt1");
            lstLpt.Items.Add("Lpt3");
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            this.cbIsPrint.Checked = StaticData.Config.isPrint == "1";
            this.cbIsVoice.Checked = StaticData.Config.isVoice == "1";
            this.cbDual.Checked = StaticData.Config.dualPrint == "1";
            this.cbUseLptPrint.Checked = StaticData.Config.userLptPrint == "1";
            this.lstLpt.Text = StaticData.Config.LptName;
        }

        private void picBg_MouseDown(object sender, MouseEventArgs e)
        {
            mypoint = new Point(-e.X, -e.Y);
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            StaticData.Config.isVoice = this.cbIsVoice.Checked ? "1" : "0";
            StaticData.Config.isPrint = this.cbIsPrint.Checked ? "1" : "0";
            StaticData.Config.dualPrint = this.cbDual.Checked ? "1" : "0";
            StaticData.Config.printerName = this.lstPrinter.Text.Trim();
            StaticData.Config.userLptPrint = this.cbUseLptPrint.Checked ? "1" : "0";
            StaticData.Config.LptName = this.lstLpt.Text.Trim();
            cb.setConfig(StaticData.Config);
            lblMsg.Text = "配置成功";
            
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDevice frmDevice = new FormDevice();
            frmDevice.ShowDialog();
            frmDevice.Dispose();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (StaticData.Config.userLptPrint == "1")
            {
                LPTPrinter lptPrinter = new LPTPrinter();
                lptPrinter.printOrder(new OrderModel());
            }
            else
            {
                PrintOrder printOrder = new PrintOrder();
                printOrder.ShowDialog();
                printOrder.Dispose();
            }
        }

        private void chbIsPrint_CheckedChanged(object sender, EventArgs e)
        {
            printSet();
        }

        private void printSet()
        {
            if (cbIsPrint.Checked)
            {
                this.cbDual.Enabled = true;
                this.lstPrinter.Enabled = true;
                this.lstLpt.Enabled = true;
                this.cbUseLptPrint.Enabled = true;
                lptPrintSet();
            }
            else
            {
                this.lstLpt.Enabled = false;
                this.cbDual.Enabled = false;
                this.lstPrinter.Enabled = false;
                this.cbUseLptPrint.Enabled = false;
            }
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            linkLabel2.Visible = true;
        }

        private void cmbUseLptPrint_CheckedChanged(object sender, EventArgs e)
        {
            lptPrintSet();
        }

        private void lptPrintSet()
        {
            if (cbUseLptPrint.Checked)
            {
                this.lstLpt.Enabled = true;
                this.lstPrinter.Enabled = false;
            }
            else
            {
                this.lstLpt.Enabled = false;
                this.lstPrinter.Enabled = true;
            }
        }
    }
}
