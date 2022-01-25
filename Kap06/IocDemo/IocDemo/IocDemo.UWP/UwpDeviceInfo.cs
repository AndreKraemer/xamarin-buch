using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.Connectivity;

namespace IocDemo.UWP
{
    public class UwpDeviceInfo : IDeviceInfo
    {
        public string GetName()
        {
            var hostNames = NetworkInformation.GetHostNames();
            var hostName = hostNames.FirstOrDefault();
            return hostName.DisplayName;
        }
    }
}
