using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YunfuDAL;
using YunfuModel;

namespace YunfuBLL
{
    public class AlipayBLL
    {
        private AlipayDAL ad = new AlipayDAL();

        public string verify()
        {
            return ad.verify();
        }

        public string pay(string dym_id, string total_fee)
        {
            return ad.pay(dym_id, total_fee);
        }

        public string paystatus(string out_trade_no)
        {
            return ad.paystatus(out_trade_no);
        }
    }
}
