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
            try
            {
                arpManager.BlockDevice(targetIP);
                Console.WriteLine($"Device {targetIP} has been blocked.");
            }
            catch (Exception ex)
            {
                FormHelpers.DisplayError($"Failed to block device: {ex.Message}");
            }
        }

        public void UnblockDevice(string targetIP)
        {
            try
            {
                arpManager.UnblockDevice(targetIP);
                Console.WriteLine($"Device {targetIP} has been unblocked.");
            }
            catch (Exception ex)
            {
                FormHelpers.DisplayError($"Failed to unblock device: {ex.Message}");
            }
        }
    }
}
