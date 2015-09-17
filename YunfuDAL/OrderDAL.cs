using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using YunfuModel;
using YunfuTools;

namespace YunfuDAL
{
    public class OrderDAL : AlipayDAL
    {

        /// <summary>
        /// 获取本机订单总数量
        /// </summary>
        /// <returns></returns>
        public string getOrderCount()
        {
            SortedDictionary<string, string> sParaTemp = new SortedDictionary<string, string>();

            string url = server_url + "YunfuApi/Order/getOrderCount";
            string result = Post(sParaTemp, url);
            return result;
        }

        /// <summary>
        /// 获取本机订单列表
        /// </summary>
        /// <param name="selPageSize">每页的数量</param>
        /// <param name="selPageIndex">页码</param>
        /// <returns></returns>
        public DataSet getOrderList(int selPageSize, int selPageIndex)
        {
            SortedDictionary<string, string> sParaTemp = new SortedDictionary<string, string>();
            sParaTemp.Add("selPageSize", selPageSize.ToString());
            sParaTemp.Add("selPageIndex", selPageIndex.ToString());

            string url = server_url + "YunfuApi/Order/getOrderLists";
            string result = Post(sParaTemp, url);

            return Utils.XmlToDataTable(result);
        }

        public string getOrderDetail(string out_trade_no)
        {
            SortedDictionary<string, string> sParaTemp = new SortedDictionary<string, string>();
            sParaTemp.Add("out_trade_no", out_trade_no);

            string url = server_url + "YunfuApi/Order/getOrderDetail";
            string result = Post(sParaTemp, url);
            return result;
        } 
    }
}
