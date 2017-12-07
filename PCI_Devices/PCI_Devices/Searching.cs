using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Management;

namespace PCI_Devices
{
    class Searching
    {
        public ManagementObjectSearcher Searcher { get; }

        private static readonly SelectQuery Query = new SelectQuery("SELECT * FROM Win32_PnPEntity");
        private static readonly Regex DevRegex = new Regex("DEV_.{4}");
        private static readonly Regex VenRegex = new Regex("VEN_.{4}");

        public Searching()
        {
            var scope = new ManagementScope();
            Searcher = new ManagementObjectSearcher(scope, Query);
        }

        public List<Device> DevicesOnComputer()
        {
            var DevicesList = new List<Device>();
            foreach (var device in Searcher.Get())
            {
                var description = device["DeviceID"].ToString();
                if (description.Contains("PCI"))
                    DevicesList.Add(new Device(DevRegex.Match(description).Value.Substring(4).ToLower(),
                        VenRegex.Match(description).Value.Substring(4).ToLower()));
            }
            return DevicesList;
        }
    }
}
