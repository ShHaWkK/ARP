using System;
using SharpPcap;
using PacketDotNet;

namespace NetControlApp
{
    public class NetworkMonitor
    {
        private ICaptureDevice device;

        public NetworkMonitor(ICaptureDevice device)
        {
            this.device = device;
            this.device.OnPacketArrival += new PacketArrivalEventHandler(OnPacketArrival);
            this.device.Open(DeviceMode.Promiscuous);
        }

        public void StartMonitoring()
        {
            device.StartCapture();
        }

        public void StopMonitoring()
        {
            device.StopCapture();
        }

        private void OnPacketArrival(object sender, CaptureEventArgs e)
        {
            var packet = PacketDotNet.Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);
            var arpPacket = packet.Extract<ARPPacket>();

            if (arpPacket != null)
            {
                Console.WriteLine($"Detected ARP packet from: {arpPacket.SenderProtocolAddress} ({arpPacket.SenderHardwareAddress})");
                // Traitez les paquets ARP ici
            }
        }

        //Method to filter ARP packets
        public bool IsArpPacket(Packet packet)
        {
            return packet.Extract<ARPPacket>() != null;
        }
    }
}
