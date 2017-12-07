using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace PCI_Devices
{
    class ParseDevices
    {
        public void Parse(List<Device> Devices)
        {
            foreach (var device in Devices)
            {
                var file = new StreamReader("pci-ids.txt");
                var vendorReg = new Regex("^" + device.VendorID + "  ");
                var deviceReg = new Regex("^\\t" + device.DeviceID + "  ");
                while (!file.EndOfStream)
                {
                    var vendorText = file.ReadLine();
                    if (vendorText != null && vendorReg.Match(vendorText).Success)
                    {
                        while (!file.EndOfStream)
                        {
                            var deviceText = file.ReadLine();
                            if (deviceText != null && deviceReg.Match(deviceText).Success)
                            {
                                device.VenDescript = vendorText.Substring(6);
                                device.DevDescript = deviceText.Substring(7);
                                break;
                            }
                        }
                    }
                }
            }
            foreach (var device in Devices)
            {
                Console.WriteLine("VENDOR: {0} \n" +
                                  "DEVICE: {1}\n", device.VenDescript, device.DevDescript);
            }
        }
    }
}
