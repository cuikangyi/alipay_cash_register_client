using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using YunfuModel;
using YunfuTools;


namespace YunfuDAL
{
    public class ConfigDAL
    {
        private string path = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Yunfu";
        private string fname = "\\Config.xml";

        public ConfigModel getConfig()
        {
            ConfigModel config = new ConfigModel();

            if (File.Exists(path + fname))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ConfigModel));
                Stream stream = new FileStream(path + fname, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                config = (ConfigModel)xmlSerializer.Deserialize(stream);
            }

            return config;
        }

        public void setConfig(ConfigModel config)
        {
            if (!Directory.Exists(path))//不存在path文件夹
            {
                Directory.CreateDirectory(path);//新建文件夹
            }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ConfigModel));
            Stream stream = new FileStream(path + fname, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            xmlSerializer.Serialize(stream, config);
            stream.Close();
        }
    }
}
