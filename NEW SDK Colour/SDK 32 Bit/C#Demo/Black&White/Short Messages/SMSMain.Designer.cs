﻿namespace ShortMessages
{
    partial class SMSMain
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
            this.cbSMSID = new System.Windows.Forms.ComboBox();
            this.btnGetSMS = new System.Windows.Forms.Button();
            this.cbTag = new System.Windows.Forms.ComboBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtValidMins = new System.Windows.Forms.TextBox();
            this.btnSetSMS = new System.Windows.Forms.Button();
            this.btnSetUserSMS = new System.Windows.Forms.Button();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cbID2 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnDeleteSMS = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btnDeleteUserSMS = new System.Windows.Forms.Button();
            this.btnClearSMS = new System.Windows.Forms.Button();
            this.btnClearUserSMS = new System.Windows.Forms.Button();
            this.cbUserID = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMachineSN = new System.Windows.Forms.TextBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRsConnect = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbVUSB = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMachineSN2 = new System.Windows.Forms.TextBox();
            this.btnUSBConnect = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rbUSB = new System.Windows.Forms.RadioButton();
            this.lblState = new System.Windows.Forms.Label();
            this.UserIDTimer = new System.Windows.Forms.Timer(this.components);
            this.cbUserID2 = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSMSID
            // 
            this.cbSMSID.FormattingEnabled = true;
            this.cbSMSID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbSMSID.Location = new System.Drawing.Point(59, 19);
            this.cbSMSID.Name = "cbSMSID";
            this.cbSMSID.Size = new System.Drawing.Size(39, 20);
            this.cbSMSID.TabIndex = 13;
            this.cbSMSID.Text = "1";
            // 
            // btnGetSMS
            // 
            this.btnGetSMS.Location = new System.Drawing.Point(305, 75);
            this.btnGetSMS.Name = "btnGetSMS";
            this.btnGetSMS.Size = new System.Drawing.Size(62, 23);
            this.btnGetSMS.TabIndex = 2;
            this.btnGetSMS.Text = "GetSMS";
            this.btnGetSMS.UseVisualStyleBackColor = true;
            this.btnGetSMS.Click += new System.EventHandler(this.btnGetSMS_Click);
            // 
            // cbTag
            // 
            this.cbTag.FormattingEnabled = true;
            this.cbTag.Items.AddRange(new object[] {
            "253.Public",
            "254.Personal",
            "255.Reserved"});
            this.cbTag.Location = new System.Drawing.Point(133, 20);
            this.cbTag.Name = "cbTag";
            this.cbTag.Size = new System.Drawing.Size(88, 20);
            this.cbTag.TabIndex = 12;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(87, 46);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(181, 21);
            this.txtStartTime.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 12);
            this.label18.TabIndex = 11;
            this.label18.Text = "Content";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 12);
            this.label17.TabIndex = 10;
            this.label17.Text = "StartTime";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 12);
            this.label16.TabIndex = 9;
            this.label16.Text = "SMSID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(104, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 12);
            this.label15.TabIndex = 8;
            this.label15.Text = "Tag";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(227, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 7;
            this.label14.Text = "ValidMinutes";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(87, 75);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(182, 21);
            this.txtContent.TabIndex = 6;
            // 
            // txtValidMins
            // 
            this.txtValidMins.Location = new System.Drawing.Point(316, 19);
            this.txtValidMins.Name = "txtValidMins";
            this.txtValidMins.Size = new System.Drawing.Size(51, 21);
            this.txtValidMins.TabIndex = 4;
            this.txtValidMins.Text = "1";
            // 
            // btnSetSMS
            // 
            this.btnSetSMS.Location = new System.Drawing.Point(306, 45);
            this.btnSetSMS.Name = "btnSetSMS";
            this.btnSetSMS.Size = new System.Drawing.Size(61, 23);
            this.btnSetSMS.TabIndex = 0;
            this.btnSetSMS.Text = "SetSMS";
            this.btnSetSMS.UseVisualStyleBackColor = true;
            this.btnSetSMS.Click += new System.EventHandler(this.btnSetSMS_Click);
            // 
            // btnSetUserSMS
            // 
            this.btnSetUserSMS.Location = new System.Drawing.Point(290, 21);
            this.btnSetUserSMS.Name = "btnSetUserSMS";
            this.btnSetUserSMS.Size = new System.Drawing.Size(77, 23);
            this.btnSetUserSMS.TabIndex = 1;
            this.btnSetUserSMS.Text = "SetUserSMS";
            this.btnSetUserSMS.UseVisualStyleBackColor = true;
            this.btnSetUserSMS.Click += new System.EventHandler(this.btnSetUserSMS_Click);
            // 
            // cbID
            // 
            this.cbID.FormattingEnabled = true;
            this.cbID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbID.Location = new System.Drawing.Point(59, 22);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(39, 20);
            this.cbID.TabIndex = 43;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 12);
            this.label22.TabIndex = 39;
            this.label22.Text = "SMSID";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(105, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 12);
            this.label23.TabIndex = 38;
            this.label23.Text = "EnrollNumber";
            // 
            // cbID2
            // 
            this.cbID2.FormattingEnabled = true;
            this.cbID2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbID2.Location = new System.Drawing.Point(50, 23);
            this.cbID2.Name = "cbID2";
            this.cbID2.Size = new System.Drawing.Size(52, 20);
            this.cbID2.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(108, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 12);
            this.label21.TabIndex = 39;
            this.label21.Text = "EnrollNumber";
            // 
            // btnDeleteSMS
            // 
            this.btnDeleteSMS.Location = new System.Drawing.Point(267, 22);
            this.btnDeleteSMS.Name = "btnDeleteSMS";
            this.btnDeleteSMS.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSMS.TabIndex = 7;
            this.btnDeleteSMS.Text = "DeleteSMS";
            this.btnDeleteSMS.UseVisualStyleBackColor = true;
            this.btnDeleteSMS.Click += new System.EventHandler(this.btnDeleteSMS_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 12);
            this.label20.TabIndex = 10;
            this.label20.Text = "SMSID";
            // 
            // btnDeleteUserSMS
            // 
            this.btnDeleteUserSMS.Location = new System.Drawing.Point(348, 22);
            this.btnDeleteUserSMS.Name = "btnDeleteUserSMS";
            this.btnDeleteUserSMS.Size = new System.Drawing.Size(99, 23);
            this.btnDeleteUserSMS.TabIndex = 6;
            this.btnDeleteUserSMS.Text = "DeleteUserSMS";
            this.btnDeleteUserSMS.UseVisualStyleBackColor = true;
            this.btnDeleteUserSMS.Click += new System.EventHandler(this.btnDeleteUserSMS_Click);
            // 
            // btnClearSMS
            // 
            this.btnClearSMS.Location = new System.Drawing.Point(23, 15);
            this.btnClearSMS.Name = "btnClearSMS";
            this.btnClearSMS.Size = new System.Drawing.Size(74, 23);
            this.btnClearSMS.TabIndex = 9;
            this.btnClearSMS.Text = "ClearSMS";
            this.btnClearSMS.UseVisualStyleBackColor = true;
            this.btnClearSMS.Click += new System.EventHandler(this.btnClearSMS_Click);
            // 
            // btnClearUserSMS
            // 
            this.btnClearUserSMS.Location = new System.Drawing.Point(175, 15);
            this.btnClearUserSMS.Name = "btnClearUserSMS";
            this.btnClearUserSMS.Size = new System.Drawing.Size(94, 23);
            this.btnClearUserSMS.TabIndex = 8;
            this.btnClearUserSMS.Text = "ClearUserSMS";
            this.btnClearUserSMS.UseVisualStyleBackColor = true;
            this.btnClearUserSMS.Click += new System.EventHandler(this.btnClearUserSMS_Click);
            // 
            // cbUserID
            // 
            this.cbUserID.FormattingEnabled = true;
            this.cbUserID.Location = new System.Drawing.Point(185, 22);
            this.cbUserID.Name = "cbUserID";
            this.cbUserID.Size = new System.Drawing.Size(84, 20);
            this.cbUserID.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShortMessages.Properties.Resources.top;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(872, 30);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Controls.Add(this.lblState);
            this.groupBox2.Location = new System.Drawing.Point(6, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 146);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication with Device";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 102);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.txtIP);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.txtPort);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(441, 77);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TCP/IP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(118, 14);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(95, 21);
            this.txtIP.TabIndex = 6;
            this.txtIP.Text = "192.168.1.201";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(183, 47);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(300, 14);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(53, 21);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "4370";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.btnRsConnect);
            this.tabPage2.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(441, 77);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RS232/485";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbBaudRate);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtMachineSN);
            this.groupBox5.Controls.Add(this.cbPort);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(17, -1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(406, 40);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(187, 14);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(65, 20);
            this.cbBaudRate.TabIndex = 6;
            this.cbBaudRate.Text = "115200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Port";
            // 
            // txtMachineSN
            // 
            this.txtMachineSN.Location = new System.Drawing.Point(337, 14);
            this.txtMachineSN.Name = "txtMachineSN";
            this.txtMachineSN.Size = new System.Drawing.Size(56, 21);
            this.txtMachineSN.TabIndex = 10;
            this.txtMachineSN.Text = "1";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cbPort.Location = new System.Drawing.Point(52, 14);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(56, 20);
            this.cbPort.TabIndex = 5;
            this.cbPort.Text = "COM1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "MachineSN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "BaudRate";
            // 
            // btnRsConnect
            // 
            this.btnRsConnect.Location = new System.Drawing.Point(183, 47);
            this.btnRsConnect.Name = "btnRsConnect";
            this.btnRsConnect.Size = new System.Drawing.Size(75, 23);
            this.btnRsConnect.TabIndex = 11;
            this.btnRsConnect.Text = "Connect";
            this.btnRsConnect.UseVisualStyleBackColor = true;
            this.btnRsConnect.Click += new System.EventHandler(this.btnRsConnect_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.btnUSBConnect);
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(441, 77);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "USBClient";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbVUSB);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.txtMachineSN2);
            this.groupBox7.Location = new System.Drawing.Point(23, -1);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(235, 38);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            // 
            // rbVUSB
            // 
            this.rbVUSB.AutoSize = true;
            this.rbVUSB.Checked = true;
            this.rbVUSB.Location = new System.Drawing.Point(8, 15);
            this.rbVUSB.Name = "rbVUSB";
            this.rbVUSB.Size = new System.Drawing.Size(125, 16);
            this.rbVUSB.TabIndex = 3;
            this.rbVUSB.TabStop = true;
            this.rbVUSB.Text = "Virtual USBClient";
            this.rbVUSB.UseVisualStyleBackColor = true;
            this.rbVUSB.Click += new System.EventHandler(this.rbVUSB_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "MachineSN";
            // 
            // txtMachineSN2
            // 
            this.txtMachineSN2.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMachineSN2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMachineSN2.Location = new System.Drawing.Point(199, 12);
            this.txtMachineSN2.Name = "txtMachineSN2";
            this.txtMachineSN2.Size = new System.Drawing.Size(27, 21);
            this.txtMachineSN2.TabIndex = 4;
            this.txtMachineSN2.Text = "1";
            // 
            // btnUSBConnect
            // 
            this.btnUSBConnect.Location = new System.Drawing.Point(183, 47);
            this.btnUSBConnect.Name = "btnUSBConnect";
            this.btnUSBConnect.Size = new System.Drawing.Size(75, 23);
            this.btnUSBConnect.TabIndex = 0;
            this.btnUSBConnect.Text = "Connect";
            this.btnUSBConnect.UseVisualStyleBackColor = true;
            this.btnUSBConnect.Click += new System.EventHandler(this.btnUSBConnect_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rbUSB);
            this.groupBox8.Location = new System.Drawing.Point(24, 37);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(89, 31);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            // 
            // rbUSB
            // 
            this.rbUSB.AutoSize = true;
            this.rbUSB.Location = new System.Drawing.Point(7, 11);
            this.rbUSB.Name = "rbUSB";
            this.rbUSB.Size = new System.Drawing.Size(77, 16);
            this.rbUSB.TabIndex = 2;
            this.rbUSB.Text = "USBClient";
            this.rbUSB.UseVisualStyleBackColor = true;
            this.rbUSB.Click += new System.EventHandler(this.rbUSB_CheckedChanged);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.ForeColor = System.Drawing.Color.Crimson;
            this.lblState.Location = new System.Drawing.Point(150, 125);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(161, 12);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Current State:Disconnected";
            // 
            // UserIDTimer
            // 
            this.UserIDTimer.Enabled = true;
            this.UserIDTimer.Tick += new System.EventHandler(this.UserIDTimer_Tick);
            // 
            // cbUserID2
            // 
            this.cbUserID2.FormattingEnabled = true;
            this.cbUserID2.Location = new System.Drawing.Point(191, 23);
            this.cbUserID2.Name = "cbUserID2";
            this.cbUserID2.Size = new System.Drawing.Size(70, 20);
            this.cbUserID2.TabIndex = 40;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cbUserID2);
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Controls.Add(this.cbID2);
            this.groupBox9.Controls.Add(this.btnDeleteUserSMS);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Controls.Add(this.btnDeleteSMS);
            this.groupBox9.Location = new System.Drawing.Point(6, 187);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(461, 60);
            this.groupBox9.TabIndex = 44;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Delete SMS or User\'s SMS";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnClearSMS);
            this.groupBox10.Controls.Add(this.btnClearUserSMS);
            this.groupBox10.Location = new System.Drawing.Point(473, 140);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(388, 43);
            this.groupBox10.TabIndex = 45;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Clear";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cbSMSID);
            this.groupBox11.Controls.Add(this.cbTag);
            this.groupBox11.Controls.Add(this.label16);
            this.groupBox11.Controls.Add(this.label15);
            this.groupBox11.Controls.Add(this.btnGetSMS);
            this.groupBox11.Controls.Add(this.label17);
            this.groupBox11.Controls.Add(this.btnSetSMS);
            this.groupBox11.Controls.Add(this.label14);
            this.groupBox11.Controls.Add(this.label18);
            this.groupBox11.Controls.Add(this.txtValidMins);
            this.groupBox11.Controls.Add(this.txtContent);
            this.groupBox11.Controls.Add(this.txtStartTime);
            this.groupBox11.Location = new System.Drawing.Point(473, 35);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(388, 105);
            this.groupBox11.TabIndex = 46;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Get or Set Short Messages";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUserID);
            this.groupBox1.Controls.Add(this.btnSetUserSMS);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.cbID);
            this.groupBox1.Location = new System.Drawing.Point(473, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 60);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Users\' Short Messages";
            // 
            // SMSMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(871, 254);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SMSMain";
            this.Text = "Short Messages";
            this.Load += new System.EventHandler(this.SMSMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClearUserSMS;
        private System.Windows.Forms.Button btnDeleteSMS;
        private System.Windows.Forms.Button btnDeleteUserSMS;
        private System.Windows.Forms.ComboBox cbID2;
        private System.Windows.Forms.Button btnGetSMS;
        private System.Windows.Forms.Button btnSetUserSMS;
        private System.Windows.Forms.Button btnSetSMS;
        private System.Windows.Forms.Button btnClearSMS;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtValidMins;
        private System.Windows.Forms.ComboBox cbTag;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbSMSID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMachineSN;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRsConnect;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbVUSB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMachineSN2;
        private System.Windows.Forms.Button btnUSBConnect;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton rbUSB;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Timer UserIDTimer;
        private System.Windows.Forms.ComboBox cbUserID;
        private System.Windows.Forms.ComboBox cbUserID2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

