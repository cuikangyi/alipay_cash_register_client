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
    public class DeviceDAL : AlipayDAL
    {
        public string setDevice(){
            SortedDictionary<string, string> sParaTemp = new SortedDictionary<string, string>();
            string url = server_url + "YunfuApi/Alipay/verify";
            string result = Post(sParaTemp, url);

            return result;
        }


        private string path = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Yunfu";
        private string fname = "\\Device.xml";

        public DeviceModel getConfig()
        {
            DeviceModel device = new DeviceModel();

            if (File.Exists(path + fname))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(DeviceModel));
                Stream stream = new FileStream(path + fname, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                device = (DeviceModel)xmlSerializer.Deserialize(stream);
            }

            return device;
        }

        public void setConfig(DeviceModel device)
        {
            if (!Directory.Exists(path))//不存在path文件夹
            {
                Directory.CreateDirectory(path);//新建文件夹
            }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DeviceModel));
            Stream stream = new FileStream(path + fname, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            xmlSerializer.Serialize(stream, device);
            stream.Close();
        }
    }
}
