using System;
using System.Net;
using System.Net.NetworkInformation;

namespace NetControlApp
{
    public static class NetworkUtils
    {
        public static IPAddress ParseIPAddress(string ipAddress)
        {
            if (IPAddress.TryParse(ipAddress, out IPAddress ip))
            {
                return ip;
            }
            throw new FormatException("Invalid IP address format.");
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

        public static string MacAddressToString(PhysicalAddress mac)
        {
            byte[] bytes = mac.GetAddressBytes();
            return string.Join(":", bytes.Select(b => b.ToString("X2")));
        }

        public static bool ValidateIPAddress(string ip)
        {
            return IPAddress.TryParse(ip, out _);
        }

        public static bool ValidateMacAddress(string mac)
        {
            return PhysicalAddress.TryParse(mac.Replace(":", "-"), out _);
        }
    }
}
