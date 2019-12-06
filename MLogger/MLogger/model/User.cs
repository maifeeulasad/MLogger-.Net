using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLogger.model
{
    class User
    {
        String macAddress;
        String systemInfo;
        String timeStamp;

        public User()
        {
            macAddress = SystemDetails.GetMAC();
            systemInfo = SystemDetails.GetSystemInfo();
            timeStamp = DateTime.UtcNow.ToString();
        }

    }
}
