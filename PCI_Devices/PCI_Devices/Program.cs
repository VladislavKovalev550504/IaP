using System;
using System.Collections.Generic;
using System.Management;
using System.Text.RegularExpressions;

namespace PCI_Devices
{
    class Program
    {
        static void Main(string[] args)
        {
            var searchingManager = new Searching();
            var pciDevices = searchingManager.DevicesOnComputer();
            var customParser = new ParseDevices();
            customParser.Parse(pciDevices);
        }
    }
}
