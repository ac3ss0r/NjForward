using Microsoft.Win32;
using Renci.SshNet;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace NjForward.Modules {
    public class VpnProvider {

        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int lpdwBufferLength);

        private static SshClient client;

        public static SshClient GetClient() {
            return client;
        }

        public static string GetEncryption() {
            return client.ConnectionInfo.CurrentClientEncryption;
        }

        public static string GetCompression() {
            return client.ConnectionInfo.CurrentClientCompressionAlgorithm;
        }

        public static bool Enabled() {
            return client != null && client.IsConnected;
        }

        public static void Start(string host, string user, string password, int sshPort, int vpnPort) {

            InternetSetOption(IntPtr.Zero, 39, IntPtr.Zero, 0); // INTERNET_OPTION_SETTINGS_CHANGED
            InternetSetOption(IntPtr.Zero, 37, IntPtr.Zero, 0); // INTERNET_OPTION_REFRESH
            // Dynamic forward port VPN
            client = new SshClient(host, sshPort, user, password);
            client.ConnectionInfo.Timeout = TimeSpan.FromMilliseconds(2000);
            /*
            var arcfour = SshClient.ConnectionInfo.Encryptions["arcfour"];
            SshClient.ConnectionInfo.Encryptions.Clear();
            SshClient.ConnectionInfo.Encryptions.Add("arcfour", arcfour);
            var none = SshClient.ConnectionInfo.CompressionAlgorithms["none"];
            SshClient.ConnectionInfo.CompressionAlgorithms.Clear();
            SshClient.ConnectionInfo.CompressionAlgorithms.Add("none", none);
            */

            var Port = new ForwardedPortDynamic((uint)vpnPort);
            client.Connect();
            client.AddForwardedPort(Port);
            Port.Start();

            // Enable windows proxy
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            registry.SetValue("ProxyEnable", 1);
            registry.SetValue("ProxyServer", "socks5://127.0.0.1:" + vpnPort);
        }
        public static void Stop() {
            // Stop forwarding
            if (client != null) {
                if (client.IsConnected) {
                    client.Disconnect();
                    foreach (var port in client.ForwardedPorts.ToList())
                        port.Dispose();
                    client.Dispose();
                }
                client = null;
            }
            // Disable proxy
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            registry.SetValue("ProxyEnable", 0);
            registry.SetValue("ProxyServer", "");
        }
    }
}
