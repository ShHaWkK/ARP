using System.Net;
using System.Net.NetworkInformation;

namespace NetControlApp
{
    public class PC
    {
        public IPAddress IP { get; set; }
        public PhysicalAddress Mac { get; set; }
        public string Name { get; set; }
        public bool IsGateway { get; set; }
        public bool IsLocalPc { get; set; }
        public int CapDown { get; set; }
        public int CapUp { get; set; }
        public bool Redirect { get; set; }
        public int TotalPacketSent { get; set; }
        public int TotalPacketReceived { get; set; }
        public int NbPacketSentSinceLastReset { get; set; }
        public int NbPacketReceivedSinceLastReset { get; set; }
        public ValueType TimeSinceLastRarp { get; set; }
    }
}
