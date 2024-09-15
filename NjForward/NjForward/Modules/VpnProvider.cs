using Microsoft.Win32;
using Renci.SshNet;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace NjForward.Modules {
    public class VpnProvider {

        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int lpdwBufferLength);

        private static SshClient SshClient;

        public static string GetEncryption() {
            return SshClient.ConnectionInfo.CurrentClientEncryption;
        }

        public static string GetCompression() {
            return SshClient.ConnectionInfo.CurrentClientCompressionAlgorithm;
        }

        public static bool Enabled() {
            return SshClient != null && SshClient.IsConnected;
        }

        public static void Start(string host, string user, string password, int sshPort, int vpnPort) {

            InternetSetOption(IntPtr.Zero, 39, IntPtr.Zero, 0); // INTERNET_OPTION_SETTINGS_CHANGED
            InternetSetOption(IntPtr.Zero, 37, IntPtr.Zero, 0); // INTERNET_OPTION_REFRESH
            // Dynamic forward port VPN
            SshClient = new SshClient(host, sshPort, user, password);

            /*
            var arcfour = SshClient.ConnectionInfo.Encryptions["arcfour"];
            SshClient.ConnectionInfo.Encryptions.Clear();
            SshClient.ConnectionInfo.Encryptions.Add("arcfour", arcfour);
            var none = SshClient.ConnectionInfo.CompressionAlgorithms["none"];
            SshClient.ConnectionInfo.CompressionAlgorithms.Clear();
            SshClient.ConnectionInfo.CompressionAlgorithms.Add("none", none);
            */

            var Port = new ForwardedPortDynamic((uint)vpnPort);
            SshClient.Connect();
            SshClient.AddForwardedPort(Port);
            Port.Start();

            // Enable windows proxy
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            registry.SetValue("ProxyEnable", 1);
            registry.SetValue("ProxyServer", "socks5://127.0.0.1:" + vpnPort);
        }
        public static void Stop() {
            // Stop forwarding
            if (SshClient != null) {
                foreach (var port in SshClient.ForwardedPorts.ToList())
                    port.Dispose();
                SshClient.Dispose();
                SshClient = null;
            }
            // Disable proxy
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            registry.SetValue("ProxyEnable", 0);
            registry.SetValue("ProxyServer", "");
        }
    }
}
