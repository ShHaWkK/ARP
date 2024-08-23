using System.Net;
using System.Net.NetworkInformation;

namespace NetControlApp
{
    public static class NetworkUtils
    {
        public static IPAddress GetIPAddress(string ipString)
        {
            IPAddress ip;
            if (IPAddress.TryParse(ipString, out ip))
            {
                return ip;
            }
            throw new ArgumentException("Invalid IP address format.");
        }

        public static PhysicalAddress GetMacAddress(string macString)
        {
            return PhysicalAddress.Parse(macString.Replace(":", "-"));
        }
    }
}
