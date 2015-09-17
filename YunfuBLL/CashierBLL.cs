using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YunfuDAL;
using YunfuModel;

namespace YunfuBLL
{
    public class CashierBLL
    {
        CashierDAL cd = new CashierDAL();

        public string getCashiers()
        {
            return cd.getCashiers();
        }

        public string cashierLogin(string cashier_name, string password)
        {
            return cd.cashierLogin(cashier_name, password);
        }

        public string cashierChangePsd(string cashier_name, string password, string newpassword, string repassword) 
        {
            return cd.cashierChangePsd(cashier_name, password, newpassword, repassword);
        }

        public CashierModel getConfig()
        {
            return cd.getConfig();
        }

        public void setConfig(CashierModel cashier)
        {
            cd.setConfig(cashier);
        }
    }
}
