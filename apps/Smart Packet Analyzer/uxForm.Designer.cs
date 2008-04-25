namespace SmartPacketAnalyzer
{
    partial class uxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uxStart = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.uxPacketList = new System.Windows.Forms.ListView();
            this.Time = new System.Windows.Forms.ColumnHeader();
            this.Source = new System.Windows.Forms.ColumnHeader();
            this.Destination = new System.Windows.Forms.ColumnHeader();
            this.PacketType = new System.Windows.Forms.ColumnHeader();
            this.uxPacketDisplay = new System.Windows.Forms.TextBox();
            this.uxPacketMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenToInt = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxClearPackets = new System.Windows.Forms.Button();
            this.uxTimerShort = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uxLogClient = new System.Windows.Forms.CheckBox();
            this.uxLogServer = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxSendToServer = new System.Windows.Forms.Button();
            this.uxSendToClient = new System.Windows.Forms.Button();
            this.tbPkt = new System.Windows.Forms.TextBox();
            this.uxHeaderByte = new System.Windows.Forms.TextBox();
            this.uxLogHeader = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uxAddAddress = new System.Windows.Forms.Button();
            this.uxClearAddresses = new System.Windows.Forms.Button();
            this.uxMemoryList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.uxMemoryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uxMemoryDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMemoryEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.uxPacketMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.uxMemoryMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxStart
            // 
            this.uxStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxStart.Location = new System.Drawing.Point(396, 423);
            this.uxStart.Name = "uxStart";
            this.uxStart.Size = new System.Drawing.Size(150, 30);
            this.uxStart.TabIndex = 1;
            this.uxStart.Text = "Stop Packet Logging";
            this.uxStart.UseVisualStyleBackColor = true;
            this.uxStart.Click += new System.EventHandler(this.uxStart_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(396, 11);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.uxPacketList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.uxPacketDisplay);
            this.splitContainer1.Size = new System.Drawing.Size(383, 406);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 7;
            // 
            // uxPacketList
            // 
            this.uxPacketList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Source,
            this.Destination,
            this.PacketType});
            this.uxPacketList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxPacketList.FullRowSelect = true;
            this.uxPacketList.GridLines = true;
            this.uxPacketList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.uxPacketList.Location = new System.Drawing.Point(0, 0);
            this.uxPacketList.MultiSelect = false;
            this.uxPacketList.Name = "uxPacketList";
            this.uxPacketList.Size = new System.Drawing.Size(383, 168);
            this.uxPacketList.TabIndex = 8;
            this.uxPacketList.UseCompatibleStateImageBehavior = false;
            this.uxPacketList.View = System.Windows.Forms.View.Details;
            this.uxPacketList.SelectedIndexChanged += new System.EventHandler(this.uxPacketList_SelectedIndexChanged);
            // 
            // Time
            // 
            this.Time.Text = "Received";
            this.Time.Width = 145;
            // 
            // Source
            // 
            this.Source.Text = "Source";
            this.Source.Width = 71;
            // 
            // Destination
            // 
            this.Destination.Text = "Destination";
            this.Destination.Width = 72;
            // 
            // PacketType
            // 
            this.PacketType.Text = "PacketType";
            this.PacketType.Width = 71;
            // 
            // uxPacketDisplay
            // 
            this.uxPacketDisplay.ContextMenuStrip = this.uxPacketMenu;
            this.uxPacketDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxPacketDisplay.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPacketDisplay.Location = new System.Drawing.Point(0, 0);
            this.uxPacketDisplay.Multiline = true;
            this.uxPacketDisplay.Name = "uxPacketDisplay";
            this.uxPacketDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxPacketDisplay.Size = new System.Drawing.Size(383, 234);
            this.uxPacketDisplay.TabIndex = 7;
            // 
            // uxPacketMenu
            // 
            this.uxPacketMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenToInt,
            this.convertToStringToolStripMenuItem});
            this.uxPacketMenu.Name = "ctxMenuPacket";
            this.uxPacketMenu.Size = new System.Drawing.Size(168, 48);
            // 
            // MenToInt
            // 
            this.MenToInt.Name = "MenToInt";
            this.MenToInt.Size = new System.Drawing.Size(167, 22);
            this.MenToInt.Text = "Convert To Int";
            this.MenToInt.Click += new System.EventHandler(this.MenToInt_Click);
            // 
            // convertToStringToolStripMenuItem
            // 
            this.convertToStringToolStripMenuItem.Name = "convertToStringToolStripMenuItem";
            this.convertToStringToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.convertToStringToolStripMenuItem.Text = "Convert To String";
            this.convertToStringToolStripMenuItem.Click += new System.EventHandler(this.convertToStringToolStripMenuItem_Click);
            // 
            // uxClearPackets
            // 
            this.uxClearPackets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxClearPackets.Location = new System.Drawing.Point(701, 423);
            this.uxClearPackets.Name = "uxClearPackets";
            this.uxClearPackets.Size = new System.Drawing.Size(78, 30);
            this.uxClearPackets.TabIndex = 8;
            this.uxClearPackets.Text = "Clear Log";
            this.uxClearPackets.UseVisualStyleBackColor = true;
            this.uxClearPackets.Click += new System.EventHandler(this.uxClear_Click);
            // 
            // uxTimerShort
            // 
            this.uxTimerShort.Interval = 300;
            this.uxTimerShort.Tick += new System.EventHandler(this.uxTimerShort_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uxLogClient);
            this.groupBox1.Controls.Add(this.uxLogServer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.uxSendToServer);
            this.groupBox1.Controls.Add(this.uxSendToClient);
            this.groupBox1.Controls.Add(this.tbPkt);
            this.groupBox1.Controls.Add(this.uxHeaderByte);
            this.groupBox1.Controls.Add(this.uxLogHeader);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 183);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Packets";
            // 
            // uxLogClient
            // 
            this.uxLogClient.AutoSize = true;
            this.uxLogClient.Checked = true;
            this.uxLogClient.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uxLogClient.Location = new System.Drawing.Point(10, 42);
            this.uxLogClient.Name = "uxLogClient";
            this.uxLogClient.Size = new System.Drawing.Size(78, 17);
            this.uxLogClient.TabIndex = 31;
            this.uxLogClient.Text = "From Client";
            this.uxLogClient.UseVisualStyleBackColor = true;
            // 
            // uxLogServer
            // 
            this.uxLogServer.AutoSize = true;
            this.uxLogServer.Checked = true;
            this.uxLogServer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uxLogServer.Location = new System.Drawing.Point(10, 19);
            this.uxLogServer.Name = "uxLogServer";
            this.uxLogServer.Size = new System.Drawing.Size(83, 17);
            this.uxLogServer.TabIndex = 30;
            this.uxLogServer.Text = "From Server";
            this.uxLogServer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Send Packet";
            // 
            // uxSendToServer
            // 
            this.uxSendToServer.Location = new System.Drawing.Point(297, 151);
            this.uxSendToServer.Name = "uxSendToServer";
            this.uxSendToServer.Size = new System.Drawing.Size(75, 26);
            this.uxSendToServer.TabIndex = 28;
            this.uxSendToServer.Text = "To Server";
            this.uxSendToServer.UseVisualStyleBackColor = true;
            // 
            // uxSendToClient
            // 
            this.uxSendToClient.Location = new System.Drawing.Point(216, 151);
            this.uxSendToClient.Name = "uxSendToClient";
            this.uxSendToClient.Size = new System.Drawing.Size(75, 26);
            this.uxSendToClient.TabIndex = 27;
            this.uxSendToClient.Text = "To Client";
            this.uxSendToClient.UseVisualStyleBackColor = true;
            // 
            // tbPkt
            // 
            this.tbPkt.Location = new System.Drawing.Point(10, 88);
            this.tbPkt.Multiline = true;
            this.tbPkt.Name = "tbPkt";
            this.tbPkt.Size = new System.Drawing.Size(362, 57);
            this.tbPkt.TabIndex = 26;
            // 
            // uxHeaderByte
            // 
            this.uxHeaderByte.Location = new System.Drawing.Point(123, 63);
            this.uxHeaderByte.MaxLength = 2;
            this.uxHeaderByte.Name = "uxHeaderByte";
            this.uxHeaderByte.Size = new System.Drawing.Size(41, 20);
            this.uxHeaderByte.TabIndex = 25;
            // 
            // uxLogHeader
            // 
            this.uxLogHeader.AutoSize = true;
            this.uxLogHeader.Location = new System.Drawing.Point(10, 65);
            this.uxLogHeader.Name = "uxLogHeader";
            this.uxLogHeader.Size = new System.Drawing.Size(110, 17);
            this.uxLogHeader.TabIndex = 24;
            this.uxLogHeader.Text = "Only With Header";
            this.uxLogHeader.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.uxAddAddress);
            this.groupBox2.Controls.Add(this.uxClearAddresses);
            this.groupBox2.Controls.Add(this.uxMemoryList);
            this.groupBox2.Location = new System.Drawing.Point(13, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 252);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Memory";
            // 
            // uxAddAddress
            // 
            this.uxAddAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxAddAddress.Location = new System.Drawing.Point(12, 217);
            this.uxAddAddress.Name = "uxAddAddress";
            this.uxAddAddress.Size = new System.Drawing.Size(123, 26);
            this.uxAddAddress.TabIndex = 30;
            this.uxAddAddress.Text = "Add Address";
            this.uxAddAddress.UseVisualStyleBackColor = true;
            this.uxAddAddress.Click += new System.EventHandler(this.uxAddAddress_Click);
            // 
            // uxClearAddresses
            // 
            this.uxClearAddresses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxClearAddresses.Location = new System.Drawing.Point(262, 217);
            this.uxClearAddresses.Name = "uxClearAddresses";
            this.uxClearAddresses.Size = new System.Drawing.Size(109, 26);
            this.uxClearAddresses.TabIndex = 29;
            this.uxClearAddresses.Text = "Clear Addresses";
            this.uxClearAddresses.UseVisualStyleBackColor = true;
            // 
            // uxMemoryList
            // 
            this.uxMemoryList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.uxMemoryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.uxMemoryList.ContextMenuStrip = this.uxMemoryMenu;
            this.uxMemoryList.FullRowSelect = true;
            this.uxMemoryList.GridLines = true;
            this.uxMemoryList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.uxMemoryList.Location = new System.Drawing.Point(9, 19);
            this.uxMemoryList.MultiSelect = false;
            this.uxMemoryList.Name = "uxMemoryList";
            this.uxMemoryList.Size = new System.Drawing.Size(362, 192);
            this.uxMemoryList.TabIndex = 9;
            this.uxMemoryList.UseCompatibleStateImageBehavior = false;
            this.uxMemoryList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Description";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Address";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type";
            this.columnHeader4.Width = 52;
            // 
            // uxMemoryMenu
            // 
            this.uxMemoryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxMemoryEdit,
            this.uxMemoryDelete});
            this.uxMemoryMenu.Name = "uxMemoryMenu";
            this.uxMemoryMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // uxMemoryDelete
            // 
            this.uxMemoryDelete.Name = "uxMemoryDelete";
            this.uxMemoryDelete.Size = new System.Drawing.Size(107, 22);
            this.uxMemoryDelete.Text = "Delete";
            this.uxMemoryDelete.Click += new System.EventHandler(this.uxMemoryDelete_Click);
            // 
            // uxMemoryEdit
            // 
            this.uxMemoryEdit.Name = "uxMemoryEdit";
            this.uxMemoryEdit.Size = new System.Drawing.Size(107, 22);
            this.uxMemoryEdit.Text = "Edit";
            // 
            // uxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uxClearPackets);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.uxStart);
            this.Name = "uxForm";
            this.Text = "Smart Packet Analyzer";
            this.Load += new System.EventHandler(this.uxForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.uxPacketMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.uxMemoryMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxStart;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox uxPacketDisplay;
        private System.Windows.Forms.Button uxClearPackets;
        private System.Windows.Forms.ContextMenuStrip uxPacketMenu;
        private System.Windows.Forms.ToolStripMenuItem MenToInt;
        private System.Windows.Forms.ToolStripMenuItem convertToStringToolStripMenuItem;
        private System.Windows.Forms.Timer uxTimerShort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox uxLogClient;
        private System.Windows.Forms.CheckBox uxLogServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxSendToServer;
        private System.Windows.Forms.Button uxSendToClient;
        private System.Windows.Forms.TextBox tbPkt;
        private System.Windows.Forms.TextBox uxHeaderByte;
        private System.Windows.Forms.CheckBox uxLogHeader;
        private System.Windows.Forms.ListView uxPacketList;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Source;
        private System.Windows.Forms.ColumnHeader Destination;
        private System.Windows.Forms.ColumnHeader PacketType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView uxMemoryList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button uxAddAddress;
        private System.Windows.Forms.Button uxClearAddresses;
        private System.Windows.Forms.ContextMenuStrip uxMemoryMenu;
        private System.Windows.Forms.ToolStripMenuItem uxMemoryEdit;
        private System.Windows.Forms.ToolStripMenuItem uxMemoryDelete;
    }
}

