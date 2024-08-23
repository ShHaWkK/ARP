using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace NetControlApp
{
    public static class Utils
    {
        public static IPAddress ParseIPAddress(string ipAddress)
        {
            if (IPAddress.TryParse(ipAddress, out IPAddress ip))
            {
                return ip;
            }
            throw new FormatException("Invalid IP address format.");
        }

        public static string FormatBytesToReadableSize(long bytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            int order = 0;
            double len = bytes;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }

            return $"{len:0.##} {sizes[order]}";
        }

        public static PhysicalAddress ParseMacAddress(string mac)
        {
            try
            {
                return PhysicalAddress.Parse(mac.Replace(":", "-"));
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid MAC address format.");
            }
        }
    }
}
