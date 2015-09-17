using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YunfuModel;
using YunfuDAL;

namespace YunfuBLL
{
    public class ConfigBLL
    {
        private ConfigDAL cd = new ConfigDAL();
        public ConfigModel getConfig()
        {
            return cd.getConfig();
        }
        public void setConfig(ConfigModel config)
        {
            cd.setConfig(config);
        }
    }
}
