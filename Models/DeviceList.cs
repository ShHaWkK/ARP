using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace NetControlApp
{
    public class DeviceList
    {
        private List<PC> devices;

        public DeviceList()
        {
            devices = new List<PC>();
        }

        public void AddDevice(PC device)
        {
            if (!devices.Exists(d => d.IP.Equals(device.IP)))
            {
                devices.Add(device);
                Console.WriteLine($"Device {device.IP} added to the list.");
            }
        }

        public void RemoveDevice(IPAddress ip)
        {
            var device = devices.Find(d => d.IP.Equals(ip));
            if (device != null)
            {
                devices.Remove(device);
                Console.WriteLine($"Device {ip} removed from the list.");
            }
        }

        public PC GetDeviceByIP(IPAddress ip)
        {
            return devices.Find(d => d.IP.Equals(ip));
        }
    }
}
