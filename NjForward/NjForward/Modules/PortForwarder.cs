using Renci.SshNet;
using System;
using System.Linq;

namespace NjForward.Modules {
    public class PortForwarder {

        private static SshClient client;

        public static SshClient GetClient() {
            return client;
        }

        public static int[] GetForwardedPorts() {
            return client.ForwardedPorts.Select(x => (int)((ForwardedPortRemote)x).BoundPort).ToArray();
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
        
        public static void Start(string host, string user, int sshPort, string password, int[] fwdPorts) {
            string localGateway = Network.GetLocalAddr();
            client = new SshClient(host, sshPort, user, password);
            client.ConnectionInfo.Timeout = TimeSpan.FromMilliseconds(2000);
            client.Connect();
            foreach (var port in fwdPorts)
                client.AddForwardedPort(new ForwardedPortRemote((uint)port, localGateway, (uint)port));
            foreach (var port in client.ForwardedPorts)
                port.Start();
        }

        public static void Stop() {
            if (client != null) {
                if (client.IsConnected) {
                    foreach (var port in client.ForwardedPorts.ToList()) {
                        client.RemoveForwardedPort(port);
                        port.Dispose();
                    }
                    client.Disconnect();
                    client.Dispose();
                }
                client = null;
            }
        }
    }
}