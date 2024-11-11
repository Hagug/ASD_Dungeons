using System.Net.Sockets;
using System.Net;
using Google.Protobuf.Protocol;
namespace Server
{
    public static class Utils
    {
        public static long TickCount { get { return 0; } } // System.Environment.TickCount64; } }

		public static IPAddress GetLocalIP()
		{
			var ipHost = Dns.GetHostEntry(Dns.GetHostName());

			foreach (IPAddress ip in ipHost.AddressList)
			{
				if (ip.AddressFamily == AddressFamily.InterNetwork)
				{
					return ip;
				}
			}

			return IPAddress.Loopback;
		}
	}
}
