using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YunfuBLL;
using YunfuModel;
using YunfuTools;

namespace Yunfu
{
    public static class PrintUtils
    {
        public static void printOrder(OrderModel order)
        {
            order = getOrderDetail(order);

            if (StaticData.Config.isPrint == "1")
            {
                if (StaticData.Config.userLptPrint == "1")
                {
                    LPTPrinter lptPrinter = new LPTPrinter();
                    lptPrinter.printOrder(order);
                }
                else
                {
                    PrintOrder printOrder = new PrintOrder(order);
                    printOrder.Show();
                    printOrder.print();
                }
            }
        }

        private static OrderModel getOrderDetail(OrderModel order)
        {
            OrderBLL ob = new OrderBLL();
            string xml = ob.getOrderDetail(order.Out_trade_no);
            try
            {
                string is_success = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/is_success").InnerText;
                if (is_success == "T")
                {
                    //order.Out_trade_no = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/order/out_trade_no").InnerText;
                    order.Subject = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/order/subject").InnerText;
                    order.Total_fee = Convert.ToDecimal(XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/order/total_fee").InnerText);
                    //order.Buyer_email = om.Buyer_email;
                    order.Trade_no = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/order/trade_no").InnerText;
                    order.Gmt_create = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/order/gmt_create").InnerText;
                    order.Gmt_payment = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/order/gmt_payment").InnerText;
                    return order;
                }
                else
                {
                    return order;
                }
            }
            catch (Exception ex)
            {
                return order;
            }
        }
    }
}
