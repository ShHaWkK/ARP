using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;

namespace NetControlApp
{
    public class PcList : IDisposable
    {
        private List<PC> devices;
        private readonly object lockObject = new object();

        public PcList()
        {
            devices = new List<PC>();
        }

        public void AddDevice(PC pc)
        {
            lock (lockObject)
            {
                if (!devices.Exists(d => d.IP.Equals(pc.IP)))
                {
                    devices.Add(pc);
                    Console.WriteLine($"Device {pc.IP} added to the list.");
                }
            }
        }

        public void RemoveDevice(IPAddress ip)
        {
            lock (lockObject)
            {
                var device = devices.Find(d => d.IP.Equals(ip));
                if (device != null)
                {
                    devices.Remove(device);
                    Console.WriteLine($"Device {ip} removed from the list.");
                }
            }
        }

        public PC GetDeviceByIP(IPAddress ip)
        {
            lock (lockObject)
            {
                return devices.Find(d => d.IP.Equals(ip));
            }
        }

        public void ResetAllPacketsCount()
        {
            lock (lockObject)
            {
                foreach (var device in devices)
                {
                    device.NbPacketReceivedSinceLastReset = 0;
                    device.NbPacketSentSinceLastReset = 0;
                }
            }
        }

        public void Dispose()
        {
            lock (lockObject)
            {
                devices.Clear();
            }
        }
    }
}
