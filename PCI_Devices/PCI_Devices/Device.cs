using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI_Devices
{
    public class Device
    {
        public string DeviceID { get; }

        public string DevDescript { get; set; }

        public string VendorID { get; }

        public string VenDescript { get; set; }

        public Device(string deviceId, string vendorId)
        {
            DeviceID = deviceId;
            VendorID = vendorId;
        }
    }
}
