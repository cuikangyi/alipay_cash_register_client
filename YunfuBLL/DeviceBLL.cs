using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YunfuDAL;
using YunfuModel;

namespace YunfuBLL
{
    public class DeviceBLL
    {
        private DeviceDAL dd = new DeviceDAL();

        public string setDevice()
        {
            return dd.setDevice();
        }

        public DeviceModel getConfig() 
        {
            return dd.getConfig();
        }

        public void setConfig(DeviceModel device) 
        {
            dd.setConfig(device);
        }
    }
}
