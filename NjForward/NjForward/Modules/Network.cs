using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace NjForward.Modules {
    public class Network {

        public static string GetLocalAddr() {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            return "127.0.0.1";
        }

        public static string GetExternalAddr() {
            foreach (var str in new string[] { "http://ip-api.com/line/?fields=query", // at least one should work
                                               "http://icanhazip.com", "https://ipinfo.io/ip" }) {
                using (var client = new WebClient()) {
                    try {
                        var result = client.DownloadString(str).Trim(new char[] { '\n', '\r', ' ' });
                        return result;
                    } catch { }
                }
            }
            return "Unknown";
        }

        public static string GetMacAddress() {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in nics) {
                if (adapter.OperationalStatus == OperationalStatus.Up) {
                    byte[] macAddr = adapter.GetPhysicalAddress().GetAddressBytes();
                    return string.Join(":", macAddr.Select(b => b.ToString("X2")));
                }
            }
            return "Unknown";
        }
    }
}
