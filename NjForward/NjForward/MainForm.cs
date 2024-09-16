using NjForward.Modules;
using Renci.SshNet;
using Renci.SshNet.Common;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace NjForward {
    public partial class MainForm : Form {

        private static int ConnectedSeconds = 0;
        private Panel[] tabs;

        public MainForm() {
            InitializeComponent();
            tabs = new Panel[] {
                settings_Panel,
                fwdPorts_Panel,
                vpn_Panel,
                network_Panel,
                logs_Panel,
                about_Panel
            };
        }

        private void MainForm_Load(object sender, EventArgs e) {
            foreach (var server in Config.LoadServers())
                servers_ListBox.Items.Add(server);
            UpdateNetworkInfo();
        }

        private void check_Timer_Tick(object sender, EventArgs e) {
            this.Text = "NjForward"; // reset
            vpnStatus_Label.Text = string.Empty;
            portsStatus_Label.Text = string.Empty;

            if (VpnProvider.Enabled()) {
                this.Text += " [VPN Connected]";
                string encryption = VpnProvider.GetEncryption(),
                       compression = VpnProvider.GetCompression();
                vpnStatus_Label.Text = "Connected. Encryption: " + encryption + ", Compression: " + compression;
            }

            if (PortForwarder.Enabled()) {
                this.Text += " [Ports forwarded]";
                string encryption = PortForwarder.GetEncryption(),
                       compression = PortForwarder.GetCompression();
                portsStatus_Label.Text = "Connected. Encryption: " + encryption + ", Compression: " + compression;
            }

            if (VpnProvider.Enabled() || PortForwarder.Enabled()) {
                ConnectedSeconds += 1;
                int hours = ConnectedSeconds / 3600,
                    minutes = (ConnectedSeconds % 3600) / 60,
                    secs = ConnectedSeconds % 60;
                this.Text += " " + hours.ToString("D2") + ":" + minutes.ToString("D2") + ":" + secs.ToString("D2");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (PortForwarder.Enabled())
                PortForwarder.Stop();
            if (VpnProvider.Enabled())
                VpnProvider.Stop();
        }

        #region TABS

        /*
         * Look mate, I know tabs shouldn't be implemented like this. Nobody in the right mind would do that.
         * But I'm from the old days and I like to do it with class and style! 
         */

        private void SelectTab(string name) {
            foreach (var tab in tabs)
                if (tab.Name == name) tab.BringToFront();
        }

        private void onTabSelected(object sender, EventArgs e) {
            SelectTab(((ToolStripStatusLabel)sender).Tag as string);
        }

        #endregion

        #region SETTINGS

        private void save_Button_Click(object sender, EventArgs e) {
            try {
                Server s = new Server(); // Contructors are for the weak ones
                s.Name = name_Input.Text;
                s.Host = ip_Input.Text;
                s.SshPort = Int32.Parse(sshPort_Input.Text);
                s.Password = password_Input.Text;
                s.User = user_Input.Text;
                s.Guid = Guid.NewGuid().ToString();
                Config.AddServer(s);
                servers_ListBox.Items.Add(s);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void servers_ListBox_SelectedIndexChanged(object sender, EventArgs e) {
            var server = (Server)servers_ListBox.SelectedItem;
            if (server != null) {
                name_Input.Text = server.Name;
                ip_Input.Text = server.Host;
                sshPort_Input.Text = server.SshPort.ToString();
                password_Input.Text = server.Password;
                user_Input.Text = server.User;
            }
        }

        private void del_Button_Click(object sender, EventArgs e) {
            foreach (Server server in servers_ListBox.SelectedItems.Cast<Server>().ToList()) {
                Config.RemoveServerByGuid(server.Guid);
                servers_ListBox.Items.Remove(server);
            }
        }

        private void rebootServer_Button_Click(object sender, EventArgs e) {
            ThreadPool.QueueUserWorkItem(x => {
                rebootServer_Button.Invoke((MethodInvoker)delegate () { rebootServer_Button.Enabled = false; });
                try {
                    using (var client = new SshClient(ip_Input.Text, Int32.Parse(sshPort_Input.Text), user_Input.Text, password_Input.Text)) {
                        client.ConnectionInfo.Timeout = TimeSpan.FromMilliseconds(2000);
                        client.Connect();
                        client.CreateCommand("reboot").Execute();
                        client.Disconnect();
                    }
                    MessageBox.Show("Reboot request sent successfully. Wait a bit while your VPS restarts.");
                } catch (Exception ex) {
                    MessageBox.Show("Failed to send reboot request: " + ex.Message);
                }
                rebootServer_Button.Invoke((MethodInvoker)delegate () { rebootServer_Button.Enabled = true; });
            });
        }

        #endregion

        #region VPN

        private void vpn_Button_Click(object sender, EventArgs e) {
            ThreadPool.QueueUserWorkItem(x => {
                vpn_Button.Invoke((MethodInvoker)delegate () { vpn_Button.Enabled = false; });
                try {
                    if (!VpnProvider.Enabled()) {
                        NjLog("[i] Starting VPN...");
                        ConnectedSeconds = 0;
                        VpnProvider.Start(ip_Input.Text, user_Input.Text, password_Input.Text,
                                     Int32.Parse(sshPort_Input.Text), Int32.Parse(vpnPort_Input.Text));
                        VpnProvider.GetClient().ErrorOccurred += delegate (object s, ExceptionEventArgs ex) {
                            // Handle the case if your internet is aborted
                            NjLog("[i] Error occured on VPN: " + ex.Exception.Message +". Shutting down...");
                            VpnProvider.Stop();
                            vpn_Button.Invoke((MethodInvoker)delegate () { vpn_Button.Text = "Connect"; });
                            NjLog("[i] VPN shut down due to network error.");
                        };
                        vpn_Button.Invoke((MethodInvoker)delegate () { vpn_Button.Text = "Disconnect"; });
                        vpnStatus_Label.Invoke((MethodInvoker)delegate () {
                            vpnStatus_Label.Text += VpnProvider.GetCompression() + " " + VpnProvider.GetEncryption();
                        });
                        NjLog("[i] Successfully started VPN tunnel " + Network.GetLocalAddr() + " -> " + ip_Input.Text);
                    } else {
                        NjLog("[i] Stopping VPN...");
                        VpnProvider.Stop();
                        vpn_Button.Invoke((MethodInvoker)delegate () { vpn_Button.Text = "Connect"; });
                        NjLog("[i] Successfully closed VPN tunnel.");
                    }
                } catch (Exception ex) {
                    NjLog("[e] Failed to open VPN tunnel: " + ex.Message);
                    MessageBox.Show("Failed: " + ex.Message);
                }
                vpn_Button.Invoke((MethodInvoker)delegate () { vpn_Button.Enabled = true; });
            });
        }

        #endregion

        #region PORTS

        private void fwdPorts_Button_Click(object sender, EventArgs e) {
            ThreadPool.QueueUserWorkItem(x => {
                fwdPorts_Button.Invoke((MethodInvoker)delegate () { fwdPorts_Button.Enabled = false; });
                try {
                    if (!PortForwarder.Enabled()) {
                        NjLog("[i] Starting port forwarding on ports " + listFwdPorts_Input.Text);
                        ConnectedSeconds = 0;
                        int[] ports = listFwdPorts_Input.Text.Split(',').Select(s => int.Parse(s)).ToArray();
                        PortForwarder.Start(ip_Input.Text, user_Input.Text, int.Parse(sshPort_Input.Text),
                                                                            password_Input.Text, ports);
                        PortForwarder.GetClient().ErrorOccurred += delegate (object s, ExceptionEventArgs ex) {
                            // Handle the case if your internet is aborted
                            NjLog("[i] Error occured on port forwarding: " + ex.Exception.Message + ". Shutting down...");
                            fwdPorts_Button.Invoke((MethodInvoker)delegate () { fwdPorts_Button.Text = "Start forwarding"; });
                            PortForwarder.Stop();
                            NjLog("[i] Port forwarding shut down due to network error.");
                        };
                        fwdPorts_Button.Invoke((MethodInvoker)delegate () { fwdPorts_Button.Text = "Stop forwarding"; });
                        NjLog("[i] Port forwarding successful");
                    } else {
                        NjLog("[i] Shutting down all forwarded ports...");
                        fwdPorts_Button.Invoke((MethodInvoker)delegate () { fwdPorts_Button.Text = "Start forwarding"; });
                        PortForwarder.Stop();
                        NjLog("[i] Stopped successfully");
                    }
                } catch (Exception ex) {
                    NjLog("[e] Failed to forward ports: " + ex.Message);
                    MessageBox.Show("Failed: " + ex.Message);
                }
                fwdPorts_Button.Invoke((MethodInvoker)delegate () { fwdPorts_Button.Enabled = true; });
            });
        }

        #endregion

        #region NETWORK

        private void UpdateNetworkInfo() {
            ThreadPool.QueueUserWorkItem(x => {
                NjLog("[i] Getting network information...");
                this.Invoke((MethodInvoker)delegate () {
                    externalIp_Input.Text = Network.GetExternalAddr();
                    internalIp_Input.Text = Network.GetLocalAddr();
                    mac_Input.Text = Network.GetMacAddress();
                });
                NjLog("[i] OK.");
            });
        }

        private void updateInfo_Button_Click(object sender, EventArgs e) {
            UpdateNetworkInfo();
        }

        private void scanPorts_Button_Click(object sender, EventArgs e) {
            ThreadPool.QueueUserWorkItem(x => {
                scanPorts_Button.Invoke((MethodInvoker)delegate () { scanPorts_Button.Enabled = false; });
                scannedPorts_Box.Invoke((MethodInvoker)delegate () { scannedPorts_Box.Clear(); });
                try {
                    int[] scannablePorts = scanPorts_Input.Text.Split(',').Select(b => int.Parse(b)).ToArray();
                    int[] openedPorts = PortScanner.ScanPorts(scanHost_Input.Text, scannablePorts);

                    scannedPorts_Box.Invoke((MethodInvoker)delegate () {
                        scannedPorts_Box.Text += "Opened ports (" + openedPorts.Length + "): " + string.Join(",", openedPorts);
                    });
                } catch { } // aah
                scanPorts_Button.Invoke((MethodInvoker)delegate () { scanPorts_Button.Enabled = true; });
            });
        }

        #endregion

        #region LOGS

        public void NjLog(string text) {
            Logs_TextBox.Invoke((MethodInvoker)delegate () {
                if (Logs_TextBox.Lines.Length > 30) { // Limit line count
                    Logs_TextBox.Text = Logs_TextBox.Text.Remove(Logs_TextBox.GetFirstCharIndexFromLine(0), Logs_TextBox.Lines[0].Length + 1);
                }
                Logs_TextBox.AppendText(text + "\n");
            });
        }

        #endregion

        #region ABOUT

        private static void OpenBrowserSafe(string url) {
            try {
                Process.Start(url);
            } catch (Exception e) {
                Clipboard.Clear();
                Clipboard.SetText(url);
                MessageBox.Show("Your computer doesn't have a default browser selected. " +
                                "The URL was copied to your clipboard instead.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void acessor_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenBrowserSafe("https://t.me/ac3ss0r");
        }

        private void server_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenBrowserSafe("https://t.me/SystemAdminServer");
        }

        private void moreInfo_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenBrowserSafe("https://www.ssh.com/academy/ssh/tunneling-example");
        }

        #endregion
    }
}