using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_PCI_Devices
{
    public class PciDevice
    {
        public string DeviceId { get; }

        public string DeviceDescription { get; set; }

        public string VendorId { get; }

        public string VendorDescription { get; set; }

        public PciDevice(string deviceId, string vendorId)
        {
            DeviceId = deviceId;
            VendorId = vendorId;
        }
    }
}
