using System;
using System.Collections.Generic;
using PacketDotNet;

namespace NetControlApp
{
    public class BandwidthController
    {
        private Dictionary<string, int> bandwidthUsage;
        private int bandwidthLimit;

        public BandwidthController(int limit)
        {
            bandwidthLimit = limit;
            bandwidthUsage = new Dictionary<string, int>();
        }

        public void MonitorTraffic(Packet packet)
        {
            var ipPacket = packet.Extract<IPPacket>();
            if (ipPacket != null)
            {
                string sourceIP = ipPacket.SourceAddress.ToString();
                int packetSize = ipPacket.TotalLength;

                if (!bandwidthUsage.ContainsKey(sourceIP))
                    bandwidthUsage[sourceIP] = 0;

                bandwidthUsage[sourceIP] += packetSize;

                if (bandwidthUsage[sourceIP] > bandwidthLimit)
                {
                    // Bloquer l'appareil ou prendre d'autres mesures
                    Console.WriteLine($"Blocking traffic from {sourceIP} due to exceeded bandwidth limit.");
                }
            }
        }
    }
}
