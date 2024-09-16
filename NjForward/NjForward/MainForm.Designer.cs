
namespace NjForward
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.settings_Item = new System.Windows.Forms.ToolStripStatusLabel();
            this.vpn_Item = new System.Windows.Forms.ToolStripStatusLabel();
            this.portFwd_Item = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.logs_Item = new System.Windows.Forms.ToolStripStatusLabel();
            this.about_Item = new System.Windows.Forms.ToolStripStatusLabel();
            this.vpn_Panel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.vpnStatus_Label = new System.Windows.Forms.Label();
            this.vpn_Button = new System.Windows.Forms.Button();
            this.vpnPort_Input = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fwdPorts_Panel = new System.Windows.Forms.Panel();
            this.portsStatus_Label = new System.Windows.Forms.Label();
            this.fwdPorts_Button = new System.Windows.Forms.Button();
            this.listFwdPorts_Input = new System.Windows.Forms.TextBox();
            this.listPorts_Label = new System.Windows.Forms.Label();
            this.logs_Panel = new System.Windows.Forms.Panel();
            this.Logs_TextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.user_Input = new System.Windows.Forms.TextBox();
            this.password_Input = new System.Windows.Forms.TextBox();
            this.user_Label = new System.Windows.Forms.Label();
            this.pass_Label = new System.Windows.Forms.Label();
            this.port_Label = new System.Windows.Forms.Label();
            this.name_Input = new System.Windows.Forms.TextBox();
            this.sshPort_Input = new System.Windows.Forms.TextBox();
            this.name_Label = new System.Windows.Forms.Label();
            this.ip_Label = new System.Windows.Forms.Label();
            this.ip_Input = new System.Windows.Forms.TextBox();
            this.presets_Label = new System.Windows.Forms.Label();
            this.save_Button = new System.Windows.Forms.Button();
            this.del_Button = new System.Windows.Forms.Button();
            this.servers_ListBox = new System.Windows.Forms.ListBox();
            this.settings_Panel = new System.Windows.Forms.Panel();
            this.check_Timer = new System.Windows.Forms.Timer(this.components);
            this.network_Panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.scannedPorts_Box = new System.Windows.Forms.RichTextBox();
            this.scanPorts_Button = new System.Windows.Forms.Button();
            this.scanPorts_Input = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.scanHost_Input = new System.Windows.Forms.TextBox();
            this.mac_Input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.internalIp_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateInfo_Button = new System.Windows.Forms.Button();
            this.externalIp_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.about_Panel = new System.Windows.Forms.Panel();
            this.moreInfo_Link = new System.Windows.Forms.LinkLabel();
            this.Info_Label3 = new System.Windows.Forms.Label();
            this.server_Link = new System.Windows.Forms.LinkLabel();
            this.Info_Label2 = new System.Windows.Forms.Label();
            this.Info_Label1 = new System.Windows.Forms.Label();
            this.acessor_Link = new System.Windows.Forms.LinkLabel();
            this.logo_Image = new System.Windows.Forms.PictureBox();
            this.about_Text = new System.Windows.Forms.Label();
            this.rebootServer_Button = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.vpn_Panel.SuspendLayout();
            this.fwdPorts_Panel.SuspendLayout();
            this.logs_Panel.SuspendLayout();
            this.settings_Panel.SuspendLayout();
            this.network_Panel.SuspendLayout();
            this.about_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settings_Item,
            this.vpn_Item,
            this.portFwd_Item,
            this.toolStripStatusLabel1,
            this.logs_Item,
            this.about_Item});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // settings_Item
            // 
            this.settings_Item.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.settings_Item.ForeColor = System.Drawing.Color.White;
            this.settings_Item.IsLink = true;
            this.settings_Item.LinkColor = System.Drawing.Color.White;
            this.settings_Item.Name = "settings_Item";
            this.settings_Item.Size = new System.Drawing.Size(62, 17);
            this.settings_Item.Tag = "settings_Panel";
            this.settings_Item.Text = "[Settings]";
            this.settings_Item.Click += new System.EventHandler(this.onTabSelected);
            // 
            // vpn_Item
            // 
            this.vpn_Item.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.vpn_Item.ForeColor = System.Drawing.Color.White;
            this.vpn_Item.IsLink = true;
            this.vpn_Item.LinkColor = System.Drawing.Color.White;
            this.vpn_Item.Name = "vpn_Item";
            this.vpn_Item.Size = new System.Drawing.Size(39, 17);
            this.vpn_Item.Tag = "vpn_Panel";
            this.vpn_Item.Text = "[VPN]";
            this.vpn_Item.Click += new System.EventHandler(this.onTabSelected);
            // 
            // portFwd_Item
            // 
            this.portFwd_Item.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.portFwd_Item.ForeColor = System.Drawing.Color.White;
            this.portFwd_Item.IsLink = true;
            this.portFwd_Item.LinkColor = System.Drawing.Color.White;
            this.portFwd_Item.Name = "portFwd_Item";
            this.portFwd_Item.Size = new System.Drawing.Size(104, 17);
            this.portFwd_Item.Tag = "fwdPorts_Panel";
            this.portFwd_Item.Text = "[Port forwarding]";
            this.portFwd_Item.Click += new System.EventHandler(this.onTabSelected);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.LinkColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabel1.Tag = "network_Panel";
            this.toolStripStatusLabel1.Text = "[Network utils]";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.onTabSelected);
            // 
            // logs_Item
            // 
            this.logs_Item.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.logs_Item.ForeColor = System.Drawing.Color.White;
            this.logs_Item.IsLink = true;
            this.logs_Item.LinkColor = System.Drawing.Color.White;
            this.logs_Item.Name = "logs_Item";
            this.logs_Item.Size = new System.Drawing.Size(43, 17);
            this.logs_Item.Tag = "logs_Panel";
            this.logs_Item.Text = "[Logs]";
            this.logs_Item.Click += new System.EventHandler(this.onTabSelected);
            // 
            // about_Item
            // 
            this.about_Item.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.about_Item.ForeColor = System.Drawing.Color.White;
            this.about_Item.IsLink = true;
            this.about_Item.LinkColor = System.Drawing.Color.White;
            this.about_Item.Name = "about_Item";
            this.about_Item.Size = new System.Drawing.Size(48, 17);
            this.about_Item.Tag = "about_Panel";
            this.about_Item.Text = "[About]";
            this.about_Item.Click += new System.EventHandler(this.onTabSelected);
            // 
            // vpn_Panel
            // 
            this.vpn_Panel.Controls.Add(this.label8);
            this.vpn_Panel.Controls.Add(this.vpnStatus_Label);
            this.vpn_Panel.Controls.Add(this.vpn_Button);
            this.vpn_Panel.Controls.Add(this.vpnPort_Input);
            this.vpn_Panel.Controls.Add(this.label6);
            this.vpn_Panel.Location = new System.Drawing.Point(0, 0);
            this.vpn_Panel.Name = "vpn_Panel";
            this.vpn_Panel.Size = new System.Drawing.Size(582, 236);
            this.vpn_Panel.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(12, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(567, 49);
            this.label8.TabIndex = 32;
            this.label8.Text = "Warning: SSH tunnel-based VPN can be slow compared to regular VPN. To increase sp" +
    "eeds enable arcfour/blowfish encryption or disable encryption completetly. Also " +
    "enable forced compression on the server";
            // 
            // vpnStatus_Label
            // 
            this.vpnStatus_Label.BackColor = System.Drawing.Color.Transparent;
            this.vpnStatus_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.vpnStatus_Label.ForeColor = System.Drawing.Color.LightGray;
            this.vpnStatus_Label.Location = new System.Drawing.Point(195, 155);
            this.vpnStatus_Label.Name = "vpnStatus_Label";
            this.vpnStatus_Label.Size = new System.Drawing.Size(201, 37);
            this.vpnStatus_Label.TabIndex = 31;
            this.vpnStatus_Label.Text = "Status: Disconnected";
            this.vpnStatus_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // vpn_Button
            // 
            this.vpn_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vpn_Button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vpn_Button.ForeColor = System.Drawing.Color.White;
            this.vpn_Button.Location = new System.Drawing.Point(194, 102);
            this.vpn_Button.Name = "vpn_Button";
            this.vpn_Button.Size = new System.Drawing.Size(202, 50);
            this.vpn_Button.TabIndex = 28;
            this.vpn_Button.Text = "Enable VPN";
            this.vpn_Button.UseVisualStyleBackColor = true;
            this.vpn_Button.Click += new System.EventHandler(this.vpn_Button_Click);
            // 
            // vpnPort_Input
            // 
            this.vpnPort_Input.BackColor = System.Drawing.Color.Black;
            this.vpnPort_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vpnPort_Input.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vpnPort_Input.ForeColor = System.Drawing.Color.LightGray;
            this.vpnPort_Input.Location = new System.Drawing.Point(308, 75);
            this.vpnPort_Input.Name = "vpnPort_Input";
            this.vpnPort_Input.Size = new System.Drawing.Size(88, 20);
            this.vpnPort_Input.TabIndex = 29;
            this.vpnPort_Input.Text = "1984";
            this.vpnPort_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(191, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Port used for VPN:";
            // 
            // fwdPorts_Panel
            // 
            this.fwdPorts_Panel.Controls.Add(this.portsStatus_Label);
            this.fwdPorts_Panel.Controls.Add(this.fwdPorts_Button);
            this.fwdPorts_Panel.Controls.Add(this.listFwdPorts_Input);
            this.fwdPorts_Panel.Controls.Add(this.listPorts_Label);
            this.fwdPorts_Panel.Location = new System.Drawing.Point(0, 0);
            this.fwdPorts_Panel.Name = "fwdPorts_Panel";
            this.fwdPorts_Panel.Size = new System.Drawing.Size(584, 236);
            this.fwdPorts_Panel.TabIndex = 33;
            // 
            // portsStatus_Label
            // 
            this.portsStatus_Label.BackColor = System.Drawing.Color.Transparent;
            this.portsStatus_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.portsStatus_Label.ForeColor = System.Drawing.Color.LightGray;
            this.portsStatus_Label.Location = new System.Drawing.Point(195, 155);
            this.portsStatus_Label.Name = "portsStatus_Label";
            this.portsStatus_Label.Size = new System.Drawing.Size(199, 34);
            this.portsStatus_Label.TabIndex = 31;
            this.portsStatus_Label.Text = "Status: Disconnected";
            this.portsStatus_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fwdPorts_Button
            // 
            this.fwdPorts_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fwdPorts_Button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fwdPorts_Button.ForeColor = System.Drawing.Color.White;
            this.fwdPorts_Button.Location = new System.Drawing.Point(194, 102);
            this.fwdPorts_Button.Name = "fwdPorts_Button";
            this.fwdPorts_Button.Size = new System.Drawing.Size(202, 50);
            this.fwdPorts_Button.TabIndex = 28;
            this.fwdPorts_Button.Text = "Start forwarding";
            this.fwdPorts_Button.UseVisualStyleBackColor = true;
            this.fwdPorts_Button.Click += new System.EventHandler(this.fwdPorts_Button_Click);
            // 
            // listFwdPorts_Input
            // 
            this.listFwdPorts_Input.BackColor = System.Drawing.Color.Black;
            this.listFwdPorts_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listFwdPorts_Input.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listFwdPorts_Input.ForeColor = System.Drawing.Color.LightGray;
            this.listFwdPorts_Input.Location = new System.Drawing.Point(269, 73);
            this.listFwdPorts_Input.Name = "listFwdPorts_Input";
            this.listFwdPorts_Input.Size = new System.Drawing.Size(127, 20);
            this.listFwdPorts_Input.TabIndex = 29;
            this.listFwdPorts_Input.Text = "9922, 1024";
            this.listFwdPorts_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listPorts_Label
            // 
            this.listPorts_Label.AutoSize = true;
            this.listPorts_Label.BackColor = System.Drawing.Color.Black;
            this.listPorts_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listPorts_Label.ForeColor = System.Drawing.Color.LightGray;
            this.listPorts_Label.Location = new System.Drawing.Point(191, 75);
            this.listPorts_Label.Name = "listPorts_Label";
            this.listPorts_Label.Size = new System.Drawing.Size(72, 15);
            this.listPorts_Label.TabIndex = 30;
            this.listPorts_Label.Text = "List port(s):";
            // 
            // logs_Panel
            // 
            this.logs_Panel.Controls.Add(this.Logs_TextBox);
            this.logs_Panel.Location = new System.Drawing.Point(0, 0);
            this.logs_Panel.Name = "logs_Panel";
            this.logs_Panel.Size = new System.Drawing.Size(584, 236);
            this.logs_Panel.TabIndex = 34;
            // 
            // Logs_TextBox
            // 
            this.Logs_TextBox.BackColor = System.Drawing.Color.Black;
            this.Logs_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Logs_TextBox.DetectUrls = false;
            this.Logs_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Logs_TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.Logs_TextBox.HideSelection = false;
            this.Logs_TextBox.Location = new System.Drawing.Point(0, 0);
            this.Logs_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Logs_TextBox.Name = "Logs_TextBox";
            this.Logs_TextBox.ReadOnly = true;
            this.Logs_TextBox.Size = new System.Drawing.Size(574, 236);
            this.Logs_TextBox.TabIndex = 3;
            this.Logs_TextBox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // user_Input
            // 
            this.user_Input.BackColor = System.Drawing.Color.Black;
            this.user_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_Input.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_Input.ForeColor = System.Drawing.Color.LightGray;
            this.user_Input.Location = new System.Drawing.Point(91, 118);
            this.user_Input.Name = "user_Input";
            this.user_Input.Size = new System.Drawing.Size(161, 20);
            this.user_Input.TabIndex = 19;
            this.user_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password_Input
            // 
            this.password_Input.BackColor = System.Drawing.Color.Black;
            this.password_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_Input.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_Input.ForeColor = System.Drawing.Color.LightGray;
            this.password_Input.Location = new System.Drawing.Point(91, 144);
            this.password_Input.Name = "password_Input";
            this.password_Input.PasswordChar = '*';
            this.password_Input.Size = new System.Drawing.Size(161, 20);
            this.password_Input.TabIndex = 20;
            this.password_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // user_Label
            // 
            this.user_Label.AutoSize = true;
            this.user_Label.BackColor = System.Drawing.Color.Black;
            this.user_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_Label.ForeColor = System.Drawing.Color.LightGray;
            this.user_Label.Location = new System.Drawing.Point(23, 119);
            this.user_Label.Name = "user_Label";
            this.user_Label.Size = new System.Drawing.Size(37, 15);
            this.user_Label.TabIndex = 18;
            this.user_Label.Text = "User:";
            // 
            // pass_Label
            // 
            this.pass_Label.AutoSize = true;
            this.pass_Label.BackColor = System.Drawing.Color.Black;
            this.pass_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_Label.ForeColor = System.Drawing.Color.LightGray;
            this.pass_Label.Location = new System.Drawing.Point(23, 145);
            this.pass_Label.Name = "pass_Label";
            this.pass_Label.Size = new System.Drawing.Size(68, 15);
            this.pass_Label.TabIndex = 21;
            this.pass_Label.Text = "Password:";
            // 
            // port_Label
            // 
            this.port_Label.AutoSize = true;
            this.port_Label.BackColor = System.Drawing.Color.Black;
            this.port_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.port_Label.ForeColor = System.Drawing.Color.LightGray;
            this.port_Label.Location = new System.Drawing.Point(23, 94);
            this.port_Label.Name = "port_Label";
            this.port_Label.Size = new System.Drawing.Size(61, 15);
            this.port_Label.TabIndex = 17;
            this.port_Label.Text = "SSH Port:";
            // 
            // name_Input
            // 
            this.name_Input.BackColor = System.Drawing.Color.Black;
            this.name_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_Input.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_Input.ForeColor = System.Drawing.Color.LightGray;
            this.name_Input.Location = new System.Drawing.Point(91, 39);
            this.name_Input.Name = "name_Input";
            this.name_Input.Size = new System.Drawing.Size(161, 20);
            this.name_Input.TabIndex = 22;
            this.name_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sshPort_Input
            // 
            this.sshPort_Input.BackColor = System.Drawing.Color.Black;
            this.sshPort_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sshPort_Input.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sshPort_Input.ForeColor = System.Drawing.Color.LightGray;
            this.sshPort_Input.Location = new System.Drawing.Point(91, 92);
            this.sshPort_Input.Name = "sshPort_Input";
            this.sshPort_Input.Size = new System.Drawing.Size(161, 20);
            this.sshPort_Input.TabIndex = 16;
            this.sshPort_Input.Text = "22";
            this.sshPort_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.BackColor = System.Drawing.Color.Black;
            this.name_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_Label.ForeColor = System.Drawing.Color.LightGray;
            this.name_Label.Location = new System.Drawing.Point(23, 41);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(43, 15);
            this.name_Label.TabIndex = 23;
            this.name_Label.Text = "Name:";
            // 
            // ip_Label
            // 
            this.ip_Label.AutoSize = true;
            this.ip_Label.BackColor = System.Drawing.Color.Black;
            this.ip_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ip_Label.ForeColor = System.Drawing.Color.LightGray;
            this.ip_Label.Location = new System.Drawing.Point(23, 68);
            this.ip_Label.Name = "ip_Label";
            this.ip_Label.Size = new System.Drawing.Size(62, 15);
            this.ip_Label.TabIndex = 15;
            this.ip_Label.Text = "Server IP:";
            // 
            // ip_Input
            // 
            this.ip_Input.BackColor = System.Drawing.Color.Black;
            this.ip_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ip_Input.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ip_Input.ForeColor = System.Drawing.Color.LightGray;
            this.ip_Input.Location = new System.Drawing.Point(91, 66);
            this.ip_Input.Name = "ip_Input";
            this.ip_Input.Size = new System.Drawing.Size(161, 20);
            this.ip_Input.TabIndex = 14;
            this.ip_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // presets_Label
            // 
            this.presets_Label.AutoSize = true;
            this.presets_Label.BackColor = System.Drawing.Color.Black;
            this.presets_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.presets_Label.ForeColor = System.Drawing.Color.LightGray;
            this.presets_Label.Location = new System.Drawing.Point(259, 40);
            this.presets_Label.Name = "presets_Label";
            this.presets_Label.Size = new System.Drawing.Size(55, 15);
            this.presets_Label.TabIndex = 25;
            this.presets_Label.Text = "Servers:";
            // 
            // save_Button
            // 
            this.save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_Button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_Button.ForeColor = System.Drawing.Color.White;
            this.save_Button.Location = new System.Drawing.Point(120, 170);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(110, 27);
            this.save_Button.TabIndex = 13;
            this.save_Button.Text = "Save";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // del_Button
            // 
            this.del_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_Button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_Button.ForeColor = System.Drawing.Color.White;
            this.del_Button.Location = new System.Drawing.Point(236, 170);
            this.del_Button.Name = "del_Button";
            this.del_Button.Size = new System.Drawing.Size(110, 27);
            this.del_Button.TabIndex = 26;
            this.del_Button.Text = "Delete";
            this.del_Button.UseVisualStyleBackColor = true;
            this.del_Button.Click += new System.EventHandler(this.del_Button_Click);
            // 
            // servers_ListBox
            // 
            this.servers_ListBox.BackColor = System.Drawing.Color.Black;
            this.servers_ListBox.ForeColor = System.Drawing.Color.White;
            this.servers_ListBox.FormattingEnabled = true;
            this.servers_ListBox.Location = new System.Drawing.Point(320, 39);
            this.servers_ListBox.Name = "servers_ListBox";
            this.servers_ListBox.Size = new System.Drawing.Size(241, 121);
            this.servers_ListBox.TabIndex = 24;
            this.servers_ListBox.SelectedIndexChanged += new System.EventHandler(this.servers_ListBox_SelectedIndexChanged);
            // 
            // settings_Panel
            // 
            this.settings_Panel.Controls.Add(this.rebootServer_Button);
            this.settings_Panel.Controls.Add(this.servers_ListBox);
            this.settings_Panel.Controls.Add(this.del_Button);
            this.settings_Panel.Controls.Add(this.save_Button);
            this.settings_Panel.Controls.Add(this.presets_Label);
            this.settings_Panel.Controls.Add(this.ip_Input);
            this.settings_Panel.Controls.Add(this.ip_Label);
            this.settings_Panel.Controls.Add(this.name_Label);
            this.settings_Panel.Controls.Add(this.sshPort_Input);
            this.settings_Panel.Controls.Add(this.name_Input);
            this.settings_Panel.Controls.Add(this.port_Label);
            this.settings_Panel.Controls.Add(this.pass_Label);
            this.settings_Panel.Controls.Add(this.user_Label);
            this.settings_Panel.Controls.Add(this.password_Input);
            this.settings_Panel.Controls.Add(this.user_Input);
            this.settings_Panel.Location = new System.Drawing.Point(0, 0);
            this.settings_Panel.Name = "settings_Panel";
            this.settings_Panel.Size = new System.Drawing.Size(582, 236);
            this.settings_Panel.TabIndex = 27;
            this.settings_Panel.Tag = "";
            // 
            // check_Timer
            // 
            this.check_Timer.Enabled = true;
            this.check_Timer.Interval = 1000;
            this.check_Timer.Tick += new System.EventHandler(this.check_Timer_Tick);
            // 
            // network_Panel
            // 
            this.network_Panel.Controls.Add(this.label4);
            this.network_Panel.Controls.Add(this.scannedPorts_Box);
            this.network_Panel.Controls.Add(this.scanPorts_Button);
            this.network_Panel.Controls.Add(this.scanPorts_Input);
            this.network_Panel.Controls.Add(this.label7);
            this.network_Panel.Controls.Add(this.label5);
            this.network_Panel.Controls.Add(this.scanHost_Input);
            this.network_Panel.Controls.Add(this.mac_Input);
            this.network_Panel.Controls.Add(this.label3);
            this.network_Panel.Controls.Add(this.internalIp_Input);
            this.network_Panel.Controls.Add(this.label2);
            this.network_Panel.Controls.Add(this.updateInfo_Button);
            this.network_Panel.Controls.Add(this.externalIp_Input);
            this.network_Panel.Controls.Add(this.label1);
            this.network_Panel.Location = new System.Drawing.Point(0, 0);
            this.network_Panel.Name = "network_Panel";
            this.network_Panel.Size = new System.Drawing.Size(584, 236);
            this.network_Panel.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(300, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 46;
            this.label4.Text = "Result:";
            // 
            // scannedPorts_Box
            // 
            this.scannedPorts_Box.BackColor = System.Drawing.Color.Black;
            this.scannedPorts_Box.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scannedPorts_Box.ForeColor = System.Drawing.Color.White;
            this.scannedPorts_Box.Location = new System.Drawing.Point(347, 85);
            this.scannedPorts_Box.Name = "scannedPorts_Box";
            this.scannedPorts_Box.ReadOnly = true;
            this.scannedPorts_Box.Size = new System.Drawing.Size(167, 80);
            this.scannedPorts_Box.TabIndex = 45;
            this.scannedPorts_Box.Text = "";
            // 
            // scanPorts_Button
            // 
            this.scanPorts_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanPorts_Button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scanPorts_Button.ForeColor = System.Drawing.Color.White;
            this.scanPorts_Button.Location = new System.Drawing.Point(363, 173);
            this.scanPorts_Button.Name = "scanPorts_Button";
            this.scanPorts_Button.Size = new System.Drawing.Size(126, 34);
            this.scanPorts_Button.TabIndex = 44;
            this.scanPorts_Button.Text = "Scan ports";
            this.scanPorts_Button.UseVisualStyleBackColor = true;
            this.scanPorts_Button.Click += new System.EventHandler(this.scanPorts_Button_Click);
            // 
            // scanPorts_Input
            // 
            this.scanPorts_Input.BackColor = System.Drawing.Color.Black;
            this.scanPorts_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scanPorts_Input.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scanPorts_Input.ForeColor = System.Drawing.Color.LightGray;
            this.scanPorts_Input.Location = new System.Drawing.Point(347, 56);
            this.scanPorts_Input.Name = "scanPorts_Input";
            this.scanPorts_Input.Size = new System.Drawing.Size(167, 20);
            this.scanPorts_Input.TabIndex = 43;
            this.scanPorts_Input.Text = "22, 80, 443";
            this.scanPorts_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(300, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "Ports:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(300, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "HOST:";
            // 
            // scanHost_Input
            // 
            this.scanHost_Input.BackColor = System.Drawing.Color.Black;
            this.scanHost_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scanHost_Input.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scanHost_Input.ForeColor = System.Drawing.Color.LightGray;
            this.scanHost_Input.Location = new System.Drawing.Point(347, 28);
            this.scanHost_Input.Name = "scanHost_Input";
            this.scanHost_Input.Size = new System.Drawing.Size(167, 20);
            this.scanHost_Input.TabIndex = 40;
            this.scanHost_Input.Text = "ya.ru";
            this.scanHost_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mac_Input
            // 
            this.mac_Input.BackColor = System.Drawing.Color.Black;
            this.mac_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mac_Input.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mac_Input.ForeColor = System.Drawing.Color.LightGray;
            this.mac_Input.Location = new System.Drawing.Point(119, 85);
            this.mac_Input.Name = "mac_Input";
            this.mac_Input.ReadOnly = true;
            this.mac_Input.Size = new System.Drawing.Size(167, 20);
            this.mac_Input.TabIndex = 36;
            this.mac_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(47, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "MAC:";
            // 
            // internalIp_Input
            // 
            this.internalIp_Input.BackColor = System.Drawing.Color.Black;
            this.internalIp_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.internalIp_Input.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.internalIp_Input.ForeColor = System.Drawing.Color.LightGray;
            this.internalIp_Input.Location = new System.Drawing.Point(119, 56);
            this.internalIp_Input.Name = "internalIp_Input";
            this.internalIp_Input.ReadOnly = true;
            this.internalIp_Input.Size = new System.Drawing.Size(167, 20);
            this.internalIp_Input.TabIndex = 34;
            this.internalIp_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(47, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Internal IP:";
            // 
            // updateInfo_Button
            // 
            this.updateInfo_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateInfo_Button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateInfo_Button.ForeColor = System.Drawing.Color.White;
            this.updateInfo_Button.Location = new System.Drawing.Point(119, 173);
            this.updateInfo_Button.Name = "updateInfo_Button";
            this.updateInfo_Button.Size = new System.Drawing.Size(126, 34);
            this.updateInfo_Button.TabIndex = 31;
            this.updateInfo_Button.Text = "Update info";
            this.updateInfo_Button.UseVisualStyleBackColor = true;
            this.updateInfo_Button.Click += new System.EventHandler(this.updateInfo_Button_Click);
            // 
            // externalIp_Input
            // 
            this.externalIp_Input.BackColor = System.Drawing.Color.Black;
            this.externalIp_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.externalIp_Input.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.externalIp_Input.ForeColor = System.Drawing.Color.LightGray;
            this.externalIp_Input.Location = new System.Drawing.Point(119, 28);
            this.externalIp_Input.Name = "externalIp_Input";
            this.externalIp_Input.ReadOnly = true;
            this.externalIp_Input.Size = new System.Drawing.Size(167, 20);
            this.externalIp_Input.TabIndex = 32;
            this.externalIp_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Extenal IP:";
            // 
            // about_Panel
            // 
            this.about_Panel.Controls.Add(this.moreInfo_Link);
            this.about_Panel.Controls.Add(this.Info_Label3);
            this.about_Panel.Controls.Add(this.server_Link);
            this.about_Panel.Controls.Add(this.Info_Label2);
            this.about_Panel.Controls.Add(this.Info_Label1);
            this.about_Panel.Controls.Add(this.acessor_Link);
            this.about_Panel.Controls.Add(this.logo_Image);
            this.about_Panel.Controls.Add(this.about_Text);
            this.about_Panel.Location = new System.Drawing.Point(0, 3);
            this.about_Panel.Name = "about_Panel";
            this.about_Panel.Size = new System.Drawing.Size(579, 233);
            this.about_Panel.TabIndex = 47;
            // 
            // moreInfo_Link
            // 
            this.moreInfo_Link.AutoSize = true;
            this.moreInfo_Link.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.moreInfo_Link.Location = new System.Drawing.Point(155, 64);
            this.moreInfo_Link.Name = "moreInfo_Link";
            this.moreInfo_Link.Size = new System.Drawing.Size(314, 15);
            this.moreInfo_Link.TabIndex = 8;
            this.moreInfo_Link.TabStop = true;
            this.moreInfo_Link.Text = "https://www.ssh.com/academy/ssh/tunneling-example";
            this.moreInfo_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.moreInfo_Link_LinkClicked);
            // 
            // Info_Label3
            // 
            this.Info_Label3.AutoSize = true;
            this.Info_Label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Info_Label3.ForeColor = System.Drawing.Color.LightGray;
            this.Info_Label3.Location = new System.Drawing.Point(12, 64);
            this.Info_Label3.Name = "Info_Label3";
            this.Info_Label3.Size = new System.Drawing.Size(137, 15);
            this.Info_Label3.TabIndex = 7;
            this.Info_Label3.Text = "About port forwarding: ";
            // 
            // server_Link
            // 
            this.server_Link.AutoSize = true;
            this.server_Link.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.server_Link.Location = new System.Drawing.Point(155, 45);
            this.server_Link.Name = "server_Link";
            this.server_Link.Size = new System.Drawing.Size(124, 15);
            this.server_Link.TabIndex = 6;
            this.server_Link.TabStop = true;
            this.server_Link.Text = "SystemAdminServer";
            this.server_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.server_Link_LinkClicked);
            // 
            // Info_Label2
            // 
            this.Info_Label2.AutoSize = true;
            this.Info_Label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Info_Label2.ForeColor = System.Drawing.Color.LightGray;
            this.Info_Label2.Location = new System.Drawing.Point(133, 45);
            this.Info_Label2.Name = "Info_Label2";
            this.Info_Label2.Size = new System.Drawing.Size(23, 15);
            this.Info_Label2.TabIndex = 5;
            this.Info_Label2.Text = "for";
            // 
            // Info_Label1
            // 
            this.Info_Label1.AutoSize = true;
            this.Info_Label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Info_Label1.ForeColor = System.Drawing.Color.LightGray;
            this.Info_Label1.Location = new System.Drawing.Point(12, 45);
            this.Info_Label1.Name = "Info_Label1";
            this.Info_Label1.Size = new System.Drawing.Size(68, 15);
            this.Info_Label1.TabIndex = 4;
            this.Info_Label1.Text = "Created by";
            // 
            // acessor_Link
            // 
            this.acessor_Link.AutoSize = true;
            this.acessor_Link.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.acessor_Link.Location = new System.Drawing.Point(78, 45);
            this.acessor_Link.Name = "acessor_Link";
            this.acessor_Link.Size = new System.Drawing.Size(55, 15);
            this.acessor_Link.TabIndex = 3;
            this.acessor_Link.TabStop = true;
            this.acessor_Link.Text = "Acessor";
            this.acessor_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.acessor_Link_LinkClicked);
            // 
            // logo_Image
            // 
            this.logo_Image.Image = global::NjForward.Properties.Resources.logo;
            this.logo_Image.Location = new System.Drawing.Point(227, 93);
            this.logo_Image.Name = "logo_Image";
            this.logo_Image.Size = new System.Drawing.Size(119, 124);
            this.logo_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_Image.TabIndex = 1;
            this.logo_Image.TabStop = false;
            // 
            // about_Text
            // 
            this.about_Text.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.about_Text.ForeColor = System.Drawing.Color.LightGray;
            this.about_Text.Location = new System.Drawing.Point(12, 11);
            this.about_Text.Name = "about_Text";
            this.about_Text.Size = new System.Drawing.Size(560, 34);
            this.about_Text.TabIndex = 0;
            this.about_Text.Text = "NjForward is a multitool to create network tunnels & forward ports on windows. Ca" +
    "n be used for malware, games and any other needs.\r\n";
            // 
            // rebootServer_Button
            // 
            this.rebootServer_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rebootServer_Button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rebootServer_Button.ForeColor = System.Drawing.Color.White;
            this.rebootServer_Button.Location = new System.Drawing.Point(352, 170);
            this.rebootServer_Button.Name = "rebootServer_Button";
            this.rebootServer_Button.Size = new System.Drawing.Size(110, 27);
            this.rebootServer_Button.TabIndex = 27;
            this.rebootServer_Button.Text = "Reboot server";
            this.rebootServer_Button.UseVisualStyleBackColor = true;
            this.rebootServer_Button.Click += new System.EventHandler(this.rebootServer_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.settings_Panel);
            this.Controls.Add(this.about_Panel);
            this.Controls.Add(this.logs_Panel);
            this.Controls.Add(this.network_Panel);
            this.Controls.Add(this.fwdPorts_Panel);
            this.Controls.Add(this.vpn_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "MainForm";
            this.Text = "NjForward";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.vpn_Panel.ResumeLayout(false);
            this.vpn_Panel.PerformLayout();
            this.fwdPorts_Panel.ResumeLayout(false);
            this.fwdPorts_Panel.PerformLayout();
            this.logs_Panel.ResumeLayout(false);
            this.settings_Panel.ResumeLayout(false);
            this.settings_Panel.PerformLayout();
            this.network_Panel.ResumeLayout(false);
            this.network_Panel.PerformLayout();
            this.about_Panel.ResumeLayout(false);
            this.about_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel about_Item;
        private System.Windows.Forms.ToolStripStatusLabel settings_Item;
        private System.Windows.Forms.ToolStripStatusLabel portFwd_Item;
        private System.Windows.Forms.ToolStripStatusLabel vpn_Item;
        private System.Windows.Forms.Panel vpn_Panel;
        private System.Windows.Forms.Button vpn_Button;
        private System.Windows.Forms.TextBox vpnPort_Input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel fwdPorts_Panel;
        private System.Windows.Forms.Button fwdPorts_Button;
        private System.Windows.Forms.TextBox listFwdPorts_Input;
        private System.Windows.Forms.Label listPorts_Label;
        private System.Windows.Forms.Panel logs_Panel;
        private System.Windows.Forms.RichTextBox Logs_TextBox;
        private System.Windows.Forms.ToolStripStatusLabel logs_Item;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox user_Input;
        private System.Windows.Forms.TextBox password_Input;
        private System.Windows.Forms.Label user_Label;
        private System.Windows.Forms.Label pass_Label;
        private System.Windows.Forms.Label port_Label;
        private System.Windows.Forms.TextBox name_Input;
        private System.Windows.Forms.TextBox sshPort_Input;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.Label ip_Label;
        private System.Windows.Forms.TextBox ip_Input;
        private System.Windows.Forms.Label presets_Label;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button del_Button;
        private System.Windows.Forms.ListBox servers_ListBox;
        private System.Windows.Forms.Panel settings_Panel;
        private System.Windows.Forms.Timer check_Timer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel network_Panel;
        private System.Windows.Forms.Button updateInfo_Button;
        private System.Windows.Forms.TextBox externalIp_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox internalIp_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mac_Input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scanPorts_Input;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox scanHost_Input;
        private System.Windows.Forms.Button scanPorts_Button;
        private System.Windows.Forms.RichTextBox scannedPorts_Box;
        private System.Windows.Forms.Label vpnStatus_Label;
        private System.Windows.Forms.Label portsStatus_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel about_Panel;
        private System.Windows.Forms.Label about_Text;
        private System.Windows.Forms.PictureBox logo_Image;
        private System.Windows.Forms.LinkLabel server_Link;
        private System.Windows.Forms.Label Info_Label2;
        private System.Windows.Forms.Label Info_Label1;
        private System.Windows.Forms.LinkLabel acessor_Link;
        private System.Windows.Forms.Label Info_Label3;
        private System.Windows.Forms.LinkLabel moreInfo_Link;
        private System.Windows.Forms.Button rebootServer_Button;
    }
}

