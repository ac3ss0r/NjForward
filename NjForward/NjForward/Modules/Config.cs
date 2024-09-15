
using Microsoft.Win32;
using System;
using System.Collections.Generic;

namespace NjForward.Modules {
    public class Config {

        // To software users: hardcode this manually, change this to be safe yo. Saving sensetive stuff on registry in plaintext is a BAD idea!
        // To stealer developers: KYS!!!
        private static string Key = "|'|'|"; 

        public static string XorStr(string str, string key) {
            char[] entryptionKey = key.ToCharArray(),
                   data = str.ToCharArray();
            for (int a = 0, b; a < data.Length; a += entryptionKey.Length)
                for (b = 0; b < key.Length && a + b < str.Length; b++)
                    data[a + b] ^= (key[b]);
            return new string(data);
        }

        private static RegistryKey GetOrCreateRoot() {
            // Safety and shit 
            var software = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
            if (software == null)
                software = Registry.CurrentUser.CreateSubKey("SOFTWARE");
            var njForward = software.OpenSubKey("NjForward", true);
            if (njForward == null)
                njForward = software.CreateSubKey("NjForward");
            return njForward;
        }

        public static List<Server> LoadServers() {
            var result = new List<Server>();
            var njForward = GetOrCreateRoot();
            foreach (var entry in njForward.GetSubKeyNames()) {
                var record = njForward.OpenSubKey(entry, true);
                var server = new Server();
                server.Guid = entry;
                server.Name = (string) record.GetValue("Name");
                server.Host = (string)record.GetValue("Host");
                server.SshPort = (int)record.GetValue("SshPort");
                server.User = (string)record.GetValue("User");
                server.Password = XorStr((string)record.GetValue("Password"), Key);
                result.Add(server);
            }

            return result;
        }

        public static void RemoveServerByGuid(string guid) {
            var njForward = GetOrCreateRoot();
            foreach (var entryName in njForward.GetSubKeyNames()) {
                if (entryName == guid)
                    njForward.DeleteSubKeyTree(entryName);
            }
        }

        public static void AddServer(Server server) {
            var njForward = GetOrCreateRoot();
            var entry = njForward.CreateSubKey(server.Guid);
            entry.SetValue("Name", server.Name);
            entry.SetValue("Host", server.Host);
            entry.SetValue("SshPort", server.SshPort);
            entry.SetValue("User", server.User);
            entry.SetValue("Password", XorStr(server.Password, Key));
        }
    }
}
