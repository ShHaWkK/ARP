using PacketDotNet;
using SharpPcap;
using System;
using System.Collections.Generic;

namespace NetControlApp
{
    public class PacketHandler
    {
        private ICaptureDevice device;
        private Dictionary<string, PC> monitoredDevices;

        public PacketHandler(ICaptureDevice device, Dictionary<string, PC> monitoredDevices)
        {
            this.device = device;
            this.monitoredDevices = monitoredDevices;
            this.device.OnPacketArrival += new PacketArrivalEventHandler(OnPacketArrival);
            this.device.Open(DeviceMode.Promiscuous);
        }

        public void StartCapturing()
        {
            device.StartCapture();
        }

        public void StopCapturing()
        {
            device.StopCapture();
        }

        private void OnPacketArrival(object sender, CaptureEventArgs e)
        {
            var packet = Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);
            var ipPacket = packet.Extract<IPPacket>();

            if (ipPacket != null)
            {
                string sourceIP = ipPacket.SourceAddress.ToString();
                if (monitoredDevices.ContainsKey(sourceIP))
                {
                    PC pc = monitoredDevices[sourceIP];
                    pc.TotalPacketReceived++;
                    Console.WriteLine($"Packet received from {sourceIP} - Total received: {pc.TotalPacketReceived}");
                }
            }
        }
    }
}
