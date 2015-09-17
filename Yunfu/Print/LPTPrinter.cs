using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using YunfuModel;
using YunfuBLL;
using YunfuTools;

namespace Yunfu
{
    class LPTPrinter
    {
        const int OPEN_EXISTING = 3;
        string prnPort = "LPT1";
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr CreateFile(string lpFileName,
                int dwDesiredAccess,
                int dwShareMode,
                int lpSecurityAttributes,
                int dwCreationDisposition,
                int dwFlagsAndAttributes,
                int hTemplateFile
            );
        public LPTPrinter()
        {
            this.prnPort = StaticData.Config.LptName;//打印机端口
        }

        public void printOrder(OrderModel order)
        {
            if (StaticData.Config.dualPrint == "1")
            {
                this.PrintLine(order);
            }
            this.PrintLine(order);
        }

        private void PrintLine(OrderModel order)
        {
            IntPtr iHandle = CreateFile(prnPort, 0x50000000, 0, 0, OPEN_EXISTING, 0, 0);
            if (iHandle.ToInt32() == -1)
            {
                Console.WriteLine(iHandle.ToString());
                MessageHelper.ShowTips("没有连接打印机或者打印机端口不正确");
            }
            else
            {
                Console.WriteLine(iHandle.ToString());
                FileStream fs = new FileStream(iHandle, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
                sw.WriteLine();
                sw.WriteLine("        支付宝收款单");
                sw.WriteLine();
                sw.WriteLine("支付宝账户：");
                sw.WriteLine(order.Buyer_email);
                sw.WriteLine("订单号：");
                sw.WriteLine(order.Out_trade_no);
                sw.WriteLine("支付宝交易号：");
                sw.WriteLine(order.Trade_no);
                sw.WriteLine();
                sw.WriteLine("交易金额：");
                sw.WriteLine(" RMB："+order.Total_fee);
                sw.WriteLine("日期/时间：");
                sw.WriteLine(order.Gmt_payment);
                sw.WriteLine();
                sw.WriteLine("设备名称：  " + StaticData.Device.device_name);
                sw.WriteLine("收银员编号：" + StaticData.Cashier.cashier_no);
                sw.WriteLine("商户名称:   " + StaticData.Device.pname);
                sw.WriteLine();
                sw.WriteLine();
                sw.WriteLine("---------------------------");
                sw.WriteLine();

                sw.Close();
                fs.Close();
            }
        }
    }
}
