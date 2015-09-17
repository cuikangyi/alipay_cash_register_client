using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using YunfuModel;
using YunfuTools;

namespace YunfuDAL
{
    public class AlipayDAL
    {
        protected string server_url = "http://YOUR DOMAINS/yunfu/index.php/";

        /// <summary>
        /// 公共方法，组装参数
        /// </summary>
        /// <param name="data"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        protected string Post(SortedDictionary<string, string> sParaTemp, string url) 
        {
            CashierModel cashier = new CashierDAL().getConfig();
            DeviceModel device = new DeviceDAL().getConfig();

            sParaTemp.Add("device_no", device.device_no);
            sParaTemp.Add("cashier_id", cashier.cashier_id);

            string result = PostData.BuildRequest(sParaTemp,url);
            return result;
        }

        /// <summary>
        /// 验证
        /// </summary>
        /// <returns></returns>
        public string verify()
        {
            string url = server_url + "YunfuApi/Alipay/verify";
            SortedDictionary<string, string> sParaTemp = new SortedDictionary<string, string>();
            return Post(sParaTemp, url);
        }

        /// <summary>
        /// 付款接口
        /// </summary>
        /// <param name="dym_id"></param>
        /// <param name="total_fee"></param>
        /// <returns></returns>
        public string pay(string dym_id, string total_fee)
        {
            SortedDictionary<string, string> sParaTemp = new SortedDictionary<string, string>();
            sParaTemp.Add("dym_id", dym_id);
            sParaTemp.Add("total_fee", total_fee);

            string url = server_url + "YunfuApi/Alipay/pay";
            string result = Post(sParaTemp,url);
            return result;
        }

        /// <summary>
        /// 获取付款状态
        /// </summary>
        /// <param name="orderid"></param>
        /// <returns></returns>
        public string paystatus(string out_trade_no)
        {
            SortedDictionary<string, string> sParaTemp = new SortedDictionary<string, string>();
            sParaTemp.Add("out_trade_no", out_trade_no);

            string url = server_url + "YunfuApi/Alipay/getPayStatus";
            string result = Post(sParaTemp, url);
            return result;
        }

    }
}
