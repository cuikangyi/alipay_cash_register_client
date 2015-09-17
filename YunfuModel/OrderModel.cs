using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunfuModel
{
    public class OrderModel
    {
        private string seller_email;
        private string partner;
        private string out_trade_no;
        private string subject;
        private decimal total_fee;       
        private string result_code;       
        private string trade_no;
        private string trade_status;
        private string buyer_email;
        private string buyer_id;    
        private string gmt_create;    
        private string gmt_payment;
        private int cashier_id;

        public string Seller_email
        {
            get { return seller_email; }
            set { seller_email = value; }
        }
        public string Partner
        {
            get { return partner; }
            set { partner = value; }
        }
        public string Out_trade_no
        {
            get { return out_trade_no; }
            set { out_trade_no = value; }
        }
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public decimal Total_fee
        {
            get { return total_fee; }
            set { total_fee = value; }
        }
        public string Result_code
        {
            get { return result_code; }
            set { result_code = value; }
        }
        public string Trade_no
        {
            get { return trade_no; }
            set { trade_no = value; }
        }
        public string Trade_status
        {
            get { return trade_status; }
            set { trade_status = value; }
        }
        public string Buyer_email
        {
            get { return buyer_email; }
            set { buyer_email = value; }
        }
        public string Buyer_id
        {
            get { return buyer_id; }
            set { buyer_id = value; }
        }
        public string Gmt_create
        {
            get { return gmt_create; }
            set { gmt_create = value; }
        }
        public string Gmt_payment
        {
            get { return gmt_payment; }
            set { gmt_payment = value; }
        }
        public int Cashier_id
        {
            get { return cashier_id; }
            set { cashier_id = value; }
        }
    }
}
