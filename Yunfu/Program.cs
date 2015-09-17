using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;
using YunfuModel;
using YunfuBLL;
using YunfuTools;

namespace Yunfu
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigBLL configBll = new ConfigBLL();
            CashierBLL cashierBll = new CashierBLL();
            DeviceBLL deviceBll = new DeviceBLL();

            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Yunfu";

            //第一次启动
            if (!Directory.Exists(path))//不存在path路径
            {
                Directory.CreateDirectory(path);
            }
            if (!File.Exists(path + "\\Cashier.xml"))
            {
                StaticData.Cashier.cashier_id = "0";
                cashierBll.setConfig(StaticData.Cashier);
            }
            if (!File.Exists(path + "\\Device.xml"))
            {
                deviceBll.setConfig(StaticData.Device);
            }
            if (!File.Exists(path + "\\Config.xml"))
            {
                StaticData.Config.isPrint = "0";
                StaticData.Config.isVoice = "1";
                StaticData.Config.dualPrint = "1";
                StaticData.Config.userLptPrint = "0";
                StaticData.Config.LptName = "LPT1";
                StaticData.Config.printerName = new PrintDocument().PrinterSettings.PrinterName;
                configBll.setConfig(StaticData.Config);
            }    
               
            StaticData.Device = deviceBll.getConfig();
            StaticData.Config = configBll.getConfig();
            StaticData.Cashier = cashierBll.getConfig();

            AlipayBLL ab = new AlipayBLL();
            string xml = ab.verify();

            try
            {
                string is_success = XMLStrHelper.GetXmlNodeByXpath(xml,"Alipay/is_success").InnerText;
                if (is_success == "T")
                {
                    FormLogin frmLogin = new FormLogin();
                    frmLogin.ShowDialog();
                    if (frmLogin.DialogResult == DialogResult.OK)
                    {
                        Application.Run(new FormMain());
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    try
                    {
                        string error_msg = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/error_msg").InnerText;
                        FormDevice frmDevice = new FormDevice(error_msg);
                        frmDevice.ShowDialog();
                    }
                    catch(Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowError("异常" + ex.Message);
            }
        }
        
    }
}
