using Renci.SshNet;
using System.Linq;

namespace NjForward.Modules {
    public class PortForwarder {

        private static SshClient SshClient;

        public static int[] GetForwardedPorts() {
            return SshClient.ForwardedPorts.Select(x => (int)((ForwardedPortRemote)x).BoundPort).ToArray();
        }

        public static string GetEncryption() {
            return SshClient.ConnectionInfo.CurrentClientEncryption;
        }

        public static string GetCompression() {
            return SshClient.ConnectionInfo.CurrentClientCompressionAlgorithm;
        }

        public static bool Enabled() {
            return SshClient != null && SshClient.IsConnected;
        }
        
        public static void Start(string host, string user, int sshPort, string password, int[] fwdPorts) {
            string localGateway = Network.GetLocalAddr();
            SshClient = new SshClient(host, sshPort, user, password);
            SshClient.Connect();
            foreach (var port in fwdPorts)
                SshClient.AddForwardedPort(new ForwardedPortRemote((uint)port, localGateway, (uint)port));
            foreach (var port in SshClient.ForwardedPorts)
                port.Start();
        }

        public static void Stop() {
            if (SshClient != null) {
                foreach (var port in SshClient.ForwardedPorts.ToList()) {
                    SshClient.RemoveForwardedPort(port);
                    port.Dispose();
                }
                SshClient.Dispose();
                SshClient = null;
            }
        }
    }
}