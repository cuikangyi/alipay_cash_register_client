using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using YunfuDAL;
using YunfuModel;

namespace YunfuBLL
{
    public class OrderBLL
    {
        private OrderDAL od = new OrderDAL();

        public string getOrderCount()
        {
            return od.getOrderCount();
        }

        public string getOrderDetail(string out_trade_no)
        {
            return od.getOrderDetail(out_trade_no);
        }

        public DataTable getOrderList(int selPageSize, int selPageIndex)
        {
            DataSet ds = od.getOrderList(selPageSize, selPageIndex);
            DataTable dt = new DataTable();
            if (ds != null)
            {
                try
                {
                    dt = ds.Tables[0];
                    foreach (DataRow dr in dt.Rows)
                    {
                        string result_code = dr["result_code"].ToString();
                        string trade_status = dr["trade_status"].ToString();
                        string buyer_email = dr["buyer_email"].ToString();
                        dr["buyer_email"] = buyer_email.Replace(buyer_email.Substring(3, 4), "****");
                        
                        if(result_code == "REFUND_SUCCESS"){
                            dr["trade_status"] = "已退款";
                        }
                        else if(result_code == "ORDER_FAIL")
                        {
                            dr["trade_status"] = "下单失败";
                        }
                        else if(result_code == "ORDER_SUCCESS_PAY_SUCCESS")
                        {
                             dr["trade_status"] = "已支付";
                        }
                        else
                        {
                            if (trade_status == "TRADE_SUCCESS" || trade_status == "TRADE_FINISHED")
                            {
                                dr["trade_status"] = "已支付";
                            }
                            else if (trade_status == "")
                            {
                                dr["trade_status"] = "未付款";
                            }
                            else
                            {
                                dr["trade_status"] = "其他";
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    return null;
                }
            }
            return dt;
        }
    }
}
