using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace NjForward.Modules {
    public class PortScanner {

        public static int[] ScanPorts(string host, int[] ports) {
            var scanResult = new List<int>();
            var tasks = new List<Task>();
            foreach (var port in ports) {
                tasks.Add(Task.Run(() => {
                    using (var client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)) {
                        try {
                            client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 1000);
                            client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, 1000);
                            var result = client.BeginConnect(host, port, null, null);
                            bool success = result.AsyncWaitHandle.WaitOne(1000);

                            if (success && client.Connected) {
                                scanResult.Add(port);
                            }
                        } catch { } // Failed for whatever reason
                    }
                }));
            }

            Task.WaitAll(tasks.ToArray());
            return scanResult.ToArray();
        }

    }
}
