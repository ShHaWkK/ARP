using System;
using System.Net;
using SharpPcap;

namespace NetControlApp
{
    public class DeviceBlocker
    {
        private ARPManager arpManager;

        public DeviceBlocker(ARPManager arpManager)
        {
            this.arpManager = arpManager;
        }

        public void BlockDevice(string targetIP)
        {
            // Utiliser ARPManager pour bloquer l'appareil
            arpManager.BlockDevice(targetIP);
            Console.WriteLine($"Device {targetIP} has been blocked.");
        }

        public void UnblockDevice(string targetIP)
        {
            // Utiliser ARPManager pour débloquer l'appareil
            arpManager.UnblockDevice(targetIP);
            Console.WriteLine($"Device {targetIP} has been unblocked.");
        }
    }
}
