using System;
using System.Net;
using System.Net.NetworkInformation;
using SharpPcap;
using PacketDotNet;

namespace NetControlApp
{
    public class ARPManager
    {
        private ICaptureDevice device;

        public ARPManager(ICaptureDevice device)
        {
            this.device = device;
            this.device.Open(DeviceMode.Promiscuous);
        }

        public void SendSpoofedARP(string targetIP, string targetMAC, string spoofedIP)
        {
            EthernetPacket ethernetPacket = new EthernetPacket(device.MacAddress, PhysicalAddress.Parse(targetMAC), EthernetType.Arp);
            ARPPacket arpPacket = new ARPPacket(ARPOperation.Reply, device.MacAddress, IPAddress.Parse(spoofedIP), PhysicalAddress.Parse(targetMAC), IPAddress.Parse(targetIP));
            
            ethernetPacket.PayloadPacket = arpPacket;
            device.SendPacket(ethernetPacket);
        }

        public void BlockDevice(string targetIP)
        {
            SendSpoofedARP(targetIP, "00:00:00:00:00:00", targetIP); // Envoie une adresse MAC invalide
        }

        public void UnblockDevice(string targetIP)
        {
            // Logic to restore the device to its original state
            Console.WriteLine($"Unblocking device with IP: {targetIP}");
            // Send normal ARP to reset ARP table
            SendSpoofedARP(targetIP, "Original_MAC_Address", "Original_Router_IP");
        }

        public void Stop()
        {
            device.Close();
        }
    }
}
