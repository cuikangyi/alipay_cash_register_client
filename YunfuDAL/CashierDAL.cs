using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using YunfuModel;
using YunfuTools;

namespace YunfuDAL
{
    public class CashierDAL : AlipayDAL
    {
        public string getCashiers()
        {
            SortedDictionary<string, string> sParaTemp = new SortedDictionary<string, string>();

            string url = server_url + "YunfuApi/Cashier/getAllCashiers";
            string result = Post(sParaTemp, url);
            return result;
        }

        public string cashierLogin(string cashier_name, string password)
        {
            SortedDictionary<string, string> sParaTemp = new SortedDictionary<string, string>();
            sParaTemp.Add("cashier_name", cashier_name);
            sParaTemp.Add("password", password);
            string url = server_url + "YunfuApi/Cashier/login";
            string result = Post(sParaTemp, url);
            return result;
        }

        public string cashierChangePsd(string cashier_name, string password, string newpassword, string repassword)
        {
            SortedDictionary<string, string> sParaTemp = new SortedDictionary<string, string>();
            sParaTemp.Add("cashier_name", cashier_name);
            sParaTemp.Add("password", password);
            sParaTemp.Add("newpassword", newpassword);
            sParaTemp.Add("repassword", repassword);
            string url = server_url + "YunfuApi/Cashier/update";
            string result = Post(sParaTemp, url);
            return result;
        }

        private string path = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Yunfu";
        private string fname = "\\Cashier.xml";

        public CashierModel getConfig()
        {
            CashierModel cashier = new CashierModel();

            if (File.Exists(path + fname))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(CashierModel));
                Stream stream = new FileStream(path + fname, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                cashier = (CashierModel)xmlSerializer.Deserialize(stream);
            }

            return cashier;
        }

        public void setConfig(CashierModel cashier)
        {
            if (!Directory.Exists(path))//不存在path文件夹
            {
                Directory.CreateDirectory(path);//新建文件夹
            }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CashierModel));
            Stream stream = new FileStream(path + fname, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            xmlSerializer.Serialize(stream, cashier);
            stream.Close();
        }
    }
}
