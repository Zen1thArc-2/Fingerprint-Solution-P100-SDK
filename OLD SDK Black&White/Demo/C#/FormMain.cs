using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ZKEmSampleApp
{
	/// <summary>
	/// Summary description for FormMain.
	/// </summary>
	/// 
	public class FrmMain : System.Windows.Forms.Form
	{
		#region Windows Forms Controls 

        private System.Windows.Forms.OpenFileDialog DlgOpenBackup;
        private System.Windows.Forms.OpenFileDialog DlgOpenFirmware;
		/// <summary>
		/// Required designer variable.
		/// </summary>
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.OpenFileDialog DlgOpenTemplate;
		#endregion
		
		private bool _collectLiveData = false;
		private bool _ipAddressChanged = false;
		private bool _deviceTimeChanged = false;
        private bool _settingChanged = false;
        private Panel PanelTop;
        private GroupBox groupBox1;
        private RadioButton RdbEthernet;
        private RadioButton RdbSerial;
        private Panel PanelEthernet;
        private Label label2;
        private TextBox TxtPort;
        private Label label1;
        private TextBox TxtIP;
        private Button BtnConnect;
        private Panel PanelSerial;
        private Button BtnConnectSerial;
        private ComboBox CboBaudRate;
        private Label label5;
        private ComboBox CboComPort;
        private Button button2;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel PanelBottom;
        private TabControl TbcMain;
        private TabPage tabPage1;
        private GroupBox groupBox4;
        private TextBox TxtTransactionDate;
        private TextBox TxtVerifyMethod;
        private TextBox TxtUserID;
        private Label label8;
        private Label label7;
        private Label label6;
        private GroupBox groupBox3;
        private Button BtnCollectLiveData;
        private Button BtnClearPunches;
        private Button BtnCollect;
        private ListView LvTransactions;
        private ColumnHeader ColTransaction;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private CheckBox ChkEnabled;
        private Button BtnDeleteTemplates;
        private Button BtnDeleteUser;
        private Label Privilege;
        private ComboBox CboPrivilege;
        private Button BtnSetUserInfo;
        private TextBox TxtPassword;
        private Label label11;
        private TextBox TxtName;
        private Label label10;
        private Button BtnCaptureFinger;
        private Button BtnLoadTemplate;
        private Button BtnUploadTemplate;
        private PictureBox PicFinger;
        private TextBox TxtUser;
        private Label label9;
        private ListView LvUsers;
        private ColumnHeader ColUserID;
        private ColumnHeader ColName;
        private ColumnHeader ColPassword;
        private ColumnHeader ColPrivilege;
        private ColumnHeader ColEnable;
        private TabPage tabPage3;
        private GroupBox groupBox7;
        private Button BtnUpdateFirmware;
        private TextBox TxtFirmware;
        private Label label21;
        private TextBox TxtSerial;
        private Label label20;
        private Button BtnRestore;
        private Button BtnBackup;
        private Button BtnClearTerminal;
        private Button BtnClearAdmin;
        private GroupBox groupBox6;
        private TextBox TxtTerminalIP;
        private Label label19;
        private TextBox TxtDeviceTime;
        private Label label18;
        private Button BtnUpdateComm;
        private TextBox TxtValue;
        private ComboBox CboSettings;
        private Label label17;
        private GroupBox groupBox5;
        private TextBox TxtTransactions;
        private Label label16;
        private TextBox TxtAdminLogs;
        private Label label15;
        private TextBox TxtPasswords;
        private Label label14;
        private TextBox TxtTemplates;
        private Label label13;
        private TextBox TxtUsers;
        private Label label12;
        private TextBox TxtAdmins;
        private Label label3;
        private Label label22;
        private Label label24;
        private GroupBox groupBox8;
        private Label label23;
        private Axzkemkeeper.AxCZKEM CtrlBioComm;
        private TabPage tabPage4;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private GroupBox groupBox10;
        private Button button8;
        private Button button7;
        private TextBox textBox1;
        private GroupBox groupBox9;
        //private Axzkemkeeper.AxCZKEM axCZKEM1;
        bool _connected = false;
		private bool _firstTime = true;

		public FrmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.DlgOpenTemplate = new System.Windows.Forms.OpenFileDialog();
            this.DlgOpenBackup = new System.Windows.Forms.OpenFileDialog();
            this.DlgOpenFirmware = new System.Windows.Forms.OpenFileDialog();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CtrlBioComm = new Axzkemkeeper.AxCZKEM();
            this.RdbEthernet = new System.Windows.Forms.RadioButton();
            this.RdbSerial = new System.Windows.Forms.RadioButton();
            this.PanelEthernet = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.PanelSerial = new System.Windows.Forms.Panel();
            this.BtnConnectSerial = new System.Windows.Forms.Button();
            this.CboBaudRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CboComPort = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.TbcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtTransactionDate = new System.Windows.Forms.TextBox();
            this.TxtVerifyMethod = new System.Windows.Forms.TextBox();
            this.TxtUserID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnCollectLiveData = new System.Windows.Forms.Button();
            this.BtnClearPunches = new System.Windows.Forms.Button();
            this.BtnCollect = new System.Windows.Forms.Button();
            this.LvTransactions = new System.Windows.Forms.ListView();
            this.ColTransaction = new System.Windows.Forms.ColumnHeader();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChkEnabled = new System.Windows.Forms.CheckBox();
            this.BtnDeleteTemplates = new System.Windows.Forms.Button();
            this.BtnDeleteUser = new System.Windows.Forms.Button();
            this.Privilege = new System.Windows.Forms.Label();
            this.CboPrivilege = new System.Windows.Forms.ComboBox();
            this.BtnSetUserInfo = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnCaptureFinger = new System.Windows.Forms.Button();
            this.BtnLoadTemplate = new System.Windows.Forms.Button();
            this.BtnUploadTemplate = new System.Windows.Forms.Button();
            this.PicFinger = new System.Windows.Forms.PictureBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LvUsers = new System.Windows.Forms.ListView();
            this.ColUserID = new System.Windows.Forms.ColumnHeader();
            this.ColName = new System.Windows.Forms.ColumnHeader();
            this.ColPassword = new System.Windows.Forms.ColumnHeader();
            this.ColPrivilege = new System.Windows.Forms.ColumnHeader();
            this.ColEnable = new System.Windows.Forms.ColumnHeader();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BtnUpdateFirmware = new System.Windows.Forms.Button();
            this.TxtFirmware = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.TxtSerial = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.BtnRestore = new System.Windows.Forms.Button();
            this.BtnBackup = new System.Windows.Forms.Button();
            this.BtnClearTerminal = new System.Windows.Forms.Button();
            this.BtnClearAdmin = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TxtTerminalIP = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtDeviceTime = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.BtnUpdateComm = new System.Windows.Forms.Button();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.CboSettings = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TxtTransactions = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtAdminLogs = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtPasswords = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtTemplates = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtUsers = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtAdmins = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.PanelTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlBioComm)).BeginInit();
            this.PanelEthernet.SuspendLayout();
            this.PanelSerial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.PanelBottom.SuspendLayout();
            this.TbcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFinger)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // DlgOpenTemplate
            // 
            this.DlgOpenTemplate.DefaultExt = "dat";
            this.DlgOpenTemplate.Filter = "Template Files (.dat)|*.dat";
            this.DlgOpenTemplate.Title = "Select template file to load";
            this.DlgOpenTemplate.FileOk += new System.ComponentModel.CancelEventHandler(this.DlgOpenTemplate_FileOk);
            // 
            // DlgOpenBackup
            // 
            this.DlgOpenBackup.DefaultExt = "bak";
            this.DlgOpenBackup.Filter = "Terminal Backup Files (.bak)|*.bak";
            this.DlgOpenBackup.Title = "Select terminal backup file";
            // 
            // DlgOpenFirmware
            // 
            this.DlgOpenFirmware.DefaultExt = "cfg";
            this.DlgOpenFirmware.Filter = "Terminal Firmware Files (.cfg)|*.cfg";
            this.DlgOpenFirmware.Title = "Select firmware file to load";
            // 
            // PanelTop
            // 
            this.PanelTop.AutoSize = true;
            this.PanelTop.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelTop.Controls.Add(this.groupBox1);
            this.PanelTop.Controls.Add(this.pictureBox1);
            this.PanelTop.Controls.Add(this.groupBox8);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(771, 482);
            this.PanelTop.TabIndex = 7;
            this.PanelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTop_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CtrlBioComm);
            this.groupBox1.Controls.Add(this.RdbEthernet);
            this.groupBox1.Controls.Add(this.RdbSerial);
            this.groupBox1.Controls.Add(this.PanelEthernet);
            this.groupBox1.Controls.Add(this.PanelSerial);
            this.groupBox1.Location = new System.Drawing.Point(226, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 133);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terminal Setup";
            // 
            // CtrlBioComm
            // 
            this.CtrlBioComm.Enabled = true;
            this.CtrlBioComm.Location = new System.Drawing.Point(16, 94);
            this.CtrlBioComm.Name = "CtrlBioComm";
            this.CtrlBioComm.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("CtrlBioComm.OcxState")));
            this.CtrlBioComm.Size = new System.Drawing.Size(87, 43);
            this.CtrlBioComm.TabIndex = 8;
            this.CtrlBioComm.Visible = false;
            this.CtrlBioComm.OnAttTransaction += new Axzkemkeeper._IZKEMEvents_OnAttTransactionEventHandler(this.CtrlBioComm_OnAttTransaction_2);
            // 
            // RdbEthernet
            // 
            this.RdbEthernet.Checked = true;
            this.RdbEthernet.Location = new System.Drawing.Point(16, 25);
            this.RdbEthernet.Name = "RdbEthernet";
            this.RdbEthernet.Size = new System.Drawing.Size(87, 26);
            this.RdbEthernet.TabIndex = 4;
            this.RdbEthernet.TabStop = true;
            this.RdbEthernet.Text = "Ethernet";
            this.RdbEthernet.CheckedChanged += new System.EventHandler(this.RdbEthernet_CheckedChanged);
            // 
            // RdbSerial
            // 
            this.RdbSerial.Location = new System.Drawing.Point(17, 62);
            this.RdbSerial.Name = "RdbSerial";
            this.RdbSerial.Size = new System.Drawing.Size(67, 26);
            this.RdbSerial.TabIndex = 3;
            this.RdbSerial.Text = "Serial";
            this.RdbSerial.CheckedChanged += new System.EventHandler(this.RdbSerial_CheckedChanged);
            // 
            // PanelEthernet
            // 
            this.PanelEthernet.Controls.Add(this.label2);
            this.PanelEthernet.Controls.Add(this.TxtPort);
            this.PanelEthernet.Controls.Add(this.label1);
            this.PanelEthernet.Controls.Add(this.TxtIP);
            this.PanelEthernet.Controls.Add(this.BtnConnect);
            this.PanelEthernet.Location = new System.Drawing.Point(112, 12);
            this.PanelEthernet.Name = "PanelEthernet";
            this.PanelEthernet.Size = new System.Drawing.Size(282, 115);
            this.PanelEthernet.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(58, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(115, 52);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(77, 21);
            this.TxtPort.TabIndex = 2;
            this.TxtPort.Text = "4370";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address";
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(106, 8);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(120, 21);
            this.TxtIP.TabIndex = 0;
            this.TxtIP.Text = "192.168.1.225";
            // 
            // BtnConnect
            // 
            this.BtnConnect.BackColor = System.Drawing.SystemColors.Control;
            this.BtnConnect.Font = new System.Drawing.Font("ËÎÌו", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConnect.Location = new System.Drawing.Point(171, 79);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(90, 25);
            this.BtnConnect.TabIndex = 8;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = false;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // PanelSerial
            // 
            this.PanelSerial.Controls.Add(this.BtnConnectSerial);
            this.PanelSerial.Controls.Add(this.CboBaudRate);
            this.PanelSerial.Controls.Add(this.label5);
            this.PanelSerial.Controls.Add(this.CboComPort);
            this.PanelSerial.Controls.Add(this.button2);
            this.PanelSerial.Controls.Add(this.label4);
            this.PanelSerial.Location = new System.Drawing.Point(109, 9);
            this.PanelSerial.Name = "PanelSerial";
            this.PanelSerial.Size = new System.Drawing.Size(282, 118);
            this.PanelSerial.TabIndex = 7;
            this.PanelSerial.Visible = false;
            // 
            // BtnConnectSerial
            // 
            this.BtnConnectSerial.BackColor = System.Drawing.SystemColors.Control;
            this.BtnConnectSerial.Font = new System.Drawing.Font("ËÎÌו", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConnectSerial.Location = new System.Drawing.Point(144, 75);
            this.BtnConnectSerial.Name = "BtnConnectSerial";
            this.BtnConnectSerial.Size = new System.Drawing.Size(90, 25);
            this.BtnConnectSerial.TabIndex = 9;
            this.BtnConnectSerial.Text = "Connect";
            this.BtnConnectSerial.UseVisualStyleBackColor = false;
            this.BtnConnectSerial.Click += new System.EventHandler(this.BtnConnectSerial_Click);
            // 
            // CboBaudRate
            // 
            this.CboBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.CboBaudRate.Location = new System.Drawing.Point(96, 43);
            this.CboBaudRate.Name = "CboBaudRate";
            this.CboBaudRate.Size = new System.Drawing.Size(106, 20);
            this.CboBaudRate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Baud Rate";
            // 
            // CboComPort
            // 
            this.CboComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboComPort.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CboComPort.Location = new System.Drawing.Point(96, 9);
            this.CboComPort.Name = "CboComPort";
            this.CboComPort.Size = new System.Drawing.Size(58, 20);
            this.CboComPort.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "Connect";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Com Port";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label22);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Location = new System.Drawing.Point(633, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(133, 133);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("ËÎÌו", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.ForeColor = System.Drawing.Color.IndianRed;
            this.label22.Location = new System.Drawing.Point(20, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 16);
            this.label22.TabIndex = 6;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Gray;
            this.label24.Location = new System.Drawing.Point(92, 25);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 12);
            this.label24.TabIndex = 10;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 20);
            this.label23.TabIndex = 9;
            this.label23.Text = "SDKVersion:";
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.Transparent;
            this.PanelBottom.Controls.Add(this.TbcMain);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 146);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(771, 336);
            this.PanelBottom.TabIndex = 6;
            // 
            // TbcMain
            // 
            this.TbcMain.Controls.Add(this.tabPage1);
            this.TbcMain.Controls.Add(this.tabPage2);
            this.TbcMain.Controls.Add(this.tabPage3);
            this.TbcMain.Controls.Add(this.tabPage4);
            this.TbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbcMain.Location = new System.Drawing.Point(0, 0);
            this.TbcMain.Name = "TbcMain";
            this.TbcMain.SelectedIndex = 0;
            this.TbcMain.Size = new System.Drawing.Size(771, 336);
            this.TbcMain.TabIndex = 8;
            this.TbcMain.SelectedIndexChanged += new System.EventHandler(this.TbcMain_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.LvTransactions);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(763, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data Collection";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.TxtTransactionDate);
            this.groupBox4.Controls.Add(this.TxtVerifyMethod);
            this.groupBox4.Controls.Add(this.TxtUserID);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(334, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 146);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transaction Information";
            // 
            // TxtTransactionDate
            // 
            this.TxtTransactionDate.Location = new System.Drawing.Point(154, 103);
            this.TxtTransactionDate.Name = "TxtTransactionDate";
            this.TxtTransactionDate.ReadOnly = true;
            this.TxtTransactionDate.Size = new System.Drawing.Size(182, 21);
            this.TxtTransactionDate.TabIndex = 5;
            // 
            // TxtVerifyMethod
            // 
            this.TxtVerifyMethod.Location = new System.Drawing.Point(154, 69);
            this.TxtVerifyMethod.Name = "TxtVerifyMethod";
            this.TxtVerifyMethod.ReadOnly = true;
            this.TxtVerifyMethod.Size = new System.Drawing.Size(182, 21);
            this.TxtVerifyMethod.TabIndex = 4;
            // 
            // TxtUserID
            // 
            this.TxtUserID.Location = new System.Drawing.Point(154, 34);
            this.TxtUserID.Name = "TxtUserID";
            this.TxtUserID.ReadOnly = true;
            this.TxtUserID.Size = new System.Drawing.Size(76, 21);
            this.TxtUserID.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(19, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Verify Method";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(19, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Transaction Date";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "User ID";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.BtnCollectLiveData);
            this.groupBox3.Controls.Add(this.BtnClearPunches);
            this.groupBox3.Controls.Add(this.BtnCollect);
            this.groupBox3.Location = new System.Drawing.Point(334, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 112);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Collection Controls";
            // 
            // BtnCollectLiveData
            // 
            this.BtnCollectLiveData.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCollectLiveData.Location = new System.Drawing.Point(140, 30);
            this.BtnCollectLiveData.Name = "BtnCollectLiveData";
            this.BtnCollectLiveData.Size = new System.Drawing.Size(144, 35);
            this.BtnCollectLiveData.TabIndex = 13;
            this.BtnCollectLiveData.Text = "Collect Live Data";
            this.BtnCollectLiveData.UseVisualStyleBackColor = false;
            this.BtnCollectLiveData.Click += new System.EventHandler(this.BtnCollectLiveData_Click);
            // 
            // BtnClearPunches
            // 
            this.BtnClearPunches.BackColor = System.Drawing.SystemColors.Control;
            this.BtnClearPunches.Location = new System.Drawing.Point(19, 69);
            this.BtnClearPunches.Name = "BtnClearPunches";
            this.BtnClearPunches.Size = new System.Drawing.Size(115, 26);
            this.BtnClearPunches.TabIndex = 12;
            this.BtnClearPunches.Text = "Clear Punches";
            this.BtnClearPunches.UseVisualStyleBackColor = false;
            this.BtnClearPunches.Click += new System.EventHandler(this.BtnClearPunches_Click);
            // 
            // BtnCollect
            // 
            this.BtnCollect.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCollect.Location = new System.Drawing.Point(19, 34);
            this.BtnCollect.Name = "BtnCollect";
            this.BtnCollect.Size = new System.Drawing.Size(115, 26);
            this.BtnCollect.TabIndex = 11;
            this.BtnCollect.Text = "Upload Punches";
            this.BtnCollect.UseVisualStyleBackColor = false;
            this.BtnCollect.Click += new System.EventHandler(this.BtnCollect_Click);
            // 
            // LvTransactions
            // 
            this.LvTransactions.BackColor = System.Drawing.Color.Gainsboro;
            this.LvTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColTransaction});
            this.LvTransactions.Dock = System.Windows.Forms.DockStyle.Left;
            this.LvTransactions.FullRowSelect = true;
            this.LvTransactions.Location = new System.Drawing.Point(0, 0);
            this.LvTransactions.MultiSelect = false;
            this.LvTransactions.Name = "LvTransactions";
            this.LvTransactions.Size = new System.Drawing.Size(308, 311);
            this.LvTransactions.TabIndex = 7;
            this.LvTransactions.UseCompatibleStateImageBehavior = false;
            this.LvTransactions.View = System.Windows.Forms.View.Details;
            this.LvTransactions.SelectedIndexChanged += new System.EventHandler(this.LvTransactions_SelectedIndexChanged);
            // 
            // ColTransaction
            // 
            this.ColTransaction.Text = "Transaction Data";
            this.ColTransaction.Width = 450;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.LvUsers);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(763, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.ChkEnabled);
            this.groupBox2.Controls.Add(this.BtnDeleteTemplates);
            this.groupBox2.Controls.Add(this.BtnDeleteUser);
            this.groupBox2.Controls.Add(this.Privilege);
            this.groupBox2.Controls.Add(this.CboPrivilege);
            this.groupBox2.Controls.Add(this.BtnSetUserInfo);
            this.groupBox2.Controls.Add(this.TxtPassword);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TxtName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.BtnCaptureFinger);
            this.groupBox2.Controls.Add(this.BtnLoadTemplate);
            this.groupBox2.Controls.Add(this.BtnUploadTemplate);
            this.groupBox2.Controls.Add(this.PicFinger);
            this.groupBox2.Controls.Add(this.TxtUser);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(418, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 311);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Information";
            // 
            // ChkEnabled
            // 
            this.ChkEnabled.BackColor = System.Drawing.Color.Transparent;
            this.ChkEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkEnabled.Location = new System.Drawing.Point(63, 164);
            this.ChkEnabled.Name = "ChkEnabled";
            this.ChkEnabled.Size = new System.Drawing.Size(105, 26);
            this.ChkEnabled.TabIndex = 17;
            this.ChkEnabled.Text = "Enabled                                                        ";
            this.ChkEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkEnabled.UseVisualStyleBackColor = false;
            // 
            // BtnDeleteTemplates
            // 
            this.BtnDeleteTemplates.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDeleteTemplates.Location = new System.Drawing.Point(19, 267);
            this.BtnDeleteTemplates.Name = "BtnDeleteTemplates";
            this.BtnDeleteTemplates.Size = new System.Drawing.Size(125, 25);
            this.BtnDeleteTemplates.TabIndex = 16;
            this.BtnDeleteTemplates.Text = "Delete Templates";
            this.BtnDeleteTemplates.UseVisualStyleBackColor = false;
            this.BtnDeleteTemplates.Click += new System.EventHandler(this.BtnDeleteTemplates_Click);
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDeleteUser.Location = new System.Drawing.Point(220, 80);
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.Size = new System.Drawing.Size(96, 25);
            this.BtnDeleteUser.TabIndex = 15;
            this.BtnDeleteUser.Text = "Delete User";
            this.BtnDeleteUser.UseVisualStyleBackColor = false;
            this.BtnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // Privilege
            // 
            this.Privilege.Location = new System.Drawing.Point(19, 129);
            this.Privilege.Name = "Privilege";
            this.Privilege.Size = new System.Drawing.Size(67, 25);
            this.Privilege.TabIndex = 14;
            this.Privilege.Text = "Privilege";
            // 
            // CboPrivilege
            // 
            this.CboPrivilege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPrivilege.Items.AddRange(new object[] {
            "General User",
            "Admin 1",
            "Admin 2",
            "Admin 3"});
            this.CboPrivilege.Location = new System.Drawing.Point(89, 126);
            this.CboPrivilege.Name = "CboPrivilege";
            this.CboPrivilege.Size = new System.Drawing.Size(115, 20);
            this.CboPrivilege.TabIndex = 13;
            // 
            // BtnSetUserInfo
            // 
            this.BtnSetUserInfo.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSetUserInfo.Location = new System.Drawing.Point(220, 26);
            this.BtnSetUserInfo.Name = "BtnSetUserInfo";
            this.BtnSetUserInfo.Size = new System.Drawing.Size(98, 25);
            this.BtnSetUserInfo.TabIndex = 12;
            this.BtnSetUserInfo.Text = "Set User Info";
            this.BtnSetUserInfo.UseVisualStyleBackColor = false;
            this.BtnSetUserInfo.Click += new System.EventHandler(this.BtnSetUserInfo_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(89, 95);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(115, 21);
            this.TxtPassword.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(19, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Password";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(89, 57);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(115, 21);
            this.TxtName.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(19, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Name";
            // 
            // BtnCaptureFinger
            // 
            this.BtnCaptureFinger.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCaptureFinger.Location = new System.Drawing.Point(222, 111);
            this.BtnCaptureFinger.Name = "BtnCaptureFinger";
            this.BtnCaptureFinger.Size = new System.Drawing.Size(98, 43);
            this.BtnCaptureFinger.TabIndex = 7;
            this.BtnCaptureFinger.Text = "Capture Fingerprint";
            this.BtnCaptureFinger.UseVisualStyleBackColor = false;
            this.BtnCaptureFinger.Click += new System.EventHandler(this.BtnCaptureFinger_Click);
            // 
            // BtnLoadTemplate
            // 
            this.BtnLoadTemplate.BackColor = System.Drawing.SystemColors.Control;
            this.BtnLoadTemplate.Location = new System.Drawing.Point(19, 233);
            this.BtnLoadTemplate.Name = "BtnLoadTemplate";
            this.BtnLoadTemplate.Size = new System.Drawing.Size(125, 24);
            this.BtnLoadTemplate.TabIndex = 6;
            this.BtnLoadTemplate.Text = "Load Template";
            this.BtnLoadTemplate.UseVisualStyleBackColor = false;
            this.BtnLoadTemplate.Click += new System.EventHandler(this.BtnLoadTemplate_Click);
            // 
            // BtnUploadTemplate
            // 
            this.BtnUploadTemplate.BackColor = System.Drawing.SystemColors.Control;
            this.BtnUploadTemplate.Location = new System.Drawing.Point(19, 198);
            this.BtnUploadTemplate.Name = "BtnUploadTemplate";
            this.BtnUploadTemplate.Size = new System.Drawing.Size(125, 25);
            this.BtnUploadTemplate.TabIndex = 5;
            this.BtnUploadTemplate.Text = "Upload Template";
            this.BtnUploadTemplate.UseVisualStyleBackColor = false;
            this.BtnUploadTemplate.Click += new System.EventHandler(this.BtnUploadTemplate_Click);
            // 
            // PicFinger
            // 
            this.PicFinger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicFinger.Location = new System.Drawing.Point(184, 160);
            this.PicFinger.Name = "PicFinger";
            this.PicFinger.Size = new System.Drawing.Size(153, 138);
            this.PicFinger.TabIndex = 4;
            this.PicFinger.TabStop = false;
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(89, 23);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.ReadOnly = true;
            this.TxtUser.Size = new System.Drawing.Size(115, 21);
            this.TxtUser.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(19, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "User ID";
            // 
            // LvUsers
            // 
            this.LvUsers.BackColor = System.Drawing.Color.Gainsboro;
            this.LvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColUserID,
            this.ColName,
            this.ColPassword,
            this.ColPrivilege,
            this.ColEnable});
            this.LvUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.LvUsers.FullRowSelect = true;
            this.LvUsers.Location = new System.Drawing.Point(0, 0);
            this.LvUsers.MultiSelect = false;
            this.LvUsers.Name = "LvUsers";
            this.LvUsers.Size = new System.Drawing.Size(418, 311);
            this.LvUsers.TabIndex = 2;
            this.LvUsers.UseCompatibleStateImageBehavior = false;
            this.LvUsers.View = System.Windows.Forms.View.Details;
            this.LvUsers.SelectedIndexChanged += new System.EventHandler(this.LvUsers_SelectedIndexChanged);
            // 
            // ColUserID
            // 
            this.ColUserID.Text = "User ID";
            this.ColUserID.Width = 98;
            // 
            // ColName
            // 
            this.ColName.Text = "Name";
            this.ColName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColName.Width = 88;
            // 
            // ColPassword
            // 
            this.ColPassword.Text = "Password";
            this.ColPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColPassword.Width = 74;
            // 
            // ColPrivilege
            // 
            this.ColPrivilege.Text = "Privilege";
            this.ColPrivilege.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColPrivilege.Width = 91;
            // 
            // ColEnable
            // 
            this.ColEnable.Text = "Enabled";
            this.ColEnable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColEnable.Width = 69;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.BtnRestore);
            this.tabPage3.Controls.Add(this.BtnBackup);
            this.tabPage3.Controls.Add(this.BtnClearTerminal);
            this.tabPage3.Controls.Add(this.BtnClearAdmin);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(763, 311);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Terminal Information";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.BtnUpdateFirmware);
            this.groupBox7.Controls.Add(this.TxtFirmware);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.TxtSerial);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Location = new System.Drawing.Point(10, 155);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(326, 138);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Device Information";
            // 
            // BtnUpdateFirmware
            // 
            this.BtnUpdateFirmware.BackColor = System.Drawing.SystemColors.Control;
            this.BtnUpdateFirmware.Location = new System.Drawing.Point(182, 103);
            this.BtnUpdateFirmware.Name = "BtnUpdateFirmware";
            this.BtnUpdateFirmware.Size = new System.Drawing.Size(135, 25);
            this.BtnUpdateFirmware.TabIndex = 14;
            this.BtnUpdateFirmware.Text = "Update Firmware";
            this.BtnUpdateFirmware.UseVisualStyleBackColor = false;
            this.BtnUpdateFirmware.Click += new System.EventHandler(this.BtnUpdateFirmware_Click);
            // 
            // TxtFirmware
            // 
            this.TxtFirmware.Location = new System.Drawing.Point(154, 69);
            this.TxtFirmware.Name = "TxtFirmware";
            this.TxtFirmware.ReadOnly = true;
            this.TxtFirmware.Size = new System.Drawing.Size(163, 21);
            this.TxtFirmware.TabIndex = 13;
            this.TxtFirmware.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(19, 69);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(125, 25);
            this.label21.TabIndex = 12;
            this.label21.Text = "Firmware Version";
            // 
            // TxtSerial
            // 
            this.TxtSerial.Location = new System.Drawing.Point(154, 34);
            this.TxtSerial.Name = "TxtSerial";
            this.TxtSerial.ReadOnly = true;
            this.TxtSerial.Size = new System.Drawing.Size(163, 21);
            this.TxtSerial.TabIndex = 11;
            this.TxtSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(19, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 25);
            this.label20.TabIndex = 10;
            this.label20.Text = "Serial Number";
            // 
            // BtnRestore
            // 
            this.BtnRestore.Location = new System.Drawing.Point(448, 252);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.Size = new System.Drawing.Size(135, 25);
            this.BtnRestore.TabIndex = 5;
            this.BtnRestore.Text = "Restore Terminal";
            this.BtnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // BtnBackup
            // 
            this.BtnBackup.Location = new System.Drawing.Point(448, 218);
            this.BtnBackup.Name = "BtnBackup";
            this.BtnBackup.Size = new System.Drawing.Size(135, 25);
            this.BtnBackup.TabIndex = 4;
            this.BtnBackup.Text = "Backup Terminal";
            this.BtnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // BtnClearTerminal
            // 
            this.BtnClearTerminal.Location = new System.Drawing.Point(602, 252);
            this.BtnClearTerminal.Name = "BtnClearTerminal";
            this.BtnClearTerminal.Size = new System.Drawing.Size(135, 25);
            this.BtnClearTerminal.TabIndex = 3;
            this.BtnClearTerminal.Text = "Clear Terminal";
            this.BtnClearTerminal.Click += new System.EventHandler(this.BtnClearTerminal_Click);
            // 
            // BtnClearAdmin
            // 
            this.BtnClearAdmin.Location = new System.Drawing.Point(602, 218);
            this.BtnClearAdmin.Name = "BtnClearAdmin";
            this.BtnClearAdmin.Size = new System.Drawing.Size(135, 25);
            this.BtnClearAdmin.TabIndex = 2;
            this.BtnClearAdmin.Text = "Clear Administrators";
            this.BtnClearAdmin.Click += new System.EventHandler(this.BtnClearAdmin_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.TxtTerminalIP);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.TxtDeviceTime);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.BtnUpdateComm);
            this.groupBox6.Controls.Add(this.TxtValue);
            this.groupBox6.Controls.Add(this.CboSettings);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Location = new System.Drawing.Point(10, 9);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(441, 129);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Terminal Setup";
            // 
            // TxtTerminalIP
            // 
            this.TxtTerminalIP.Location = new System.Drawing.Point(125, 95);
            this.TxtTerminalIP.Name = "TxtTerminalIP";
            this.TxtTerminalIP.Size = new System.Drawing.Size(145, 21);
            this.TxtTerminalIP.TabIndex = 9;
            this.TxtTerminalIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtTerminalIP.TextChanged += new System.EventHandler(this.TxtTerminalIP_TextChanged);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(19, 95);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 25);
            this.label19.TabIndex = 8;
            this.label19.Text = "IP Address";
            // 
            // TxtDeviceTime
            // 
            this.TxtDeviceTime.Location = new System.Drawing.Point(125, 58);
            this.TxtDeviceTime.Name = "TxtDeviceTime";
            this.TxtDeviceTime.Size = new System.Drawing.Size(201, 21);
            this.TxtDeviceTime.TabIndex = 7;
            this.TxtDeviceTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDeviceTime.TextChanged += new System.EventHandler(this.TxtDeviceTime_TextChanged);
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(19, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 25);
            this.label18.TabIndex = 6;
            this.label18.Text = "Device Time";
            // 
            // BtnUpdateComm
            // 
            this.BtnUpdateComm.BackColor = System.Drawing.SystemColors.Control;
            this.BtnUpdateComm.Location = new System.Drawing.Point(298, 94);
            this.BtnUpdateComm.Name = "BtnUpdateComm";
            this.BtnUpdateComm.Size = new System.Drawing.Size(134, 24);
            this.BtnUpdateComm.TabIndex = 5;
            this.BtnUpdateComm.Text = "Update Terminal";
            this.BtnUpdateComm.UseVisualStyleBackColor = false;
            this.BtnUpdateComm.Click += new System.EventHandler(this.BtnUpdateComm_Click);
            // 
            // TxtValue
            // 
            this.TxtValue.Location = new System.Drawing.Point(336, 27);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(96, 21);
            this.TxtValue.TabIndex = 2;
            this.TxtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtValue_KeyDown);
            // 
            // CboSettings
            // 
            this.CboSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSettings.Items.AddRange(new object[] {
            "Max Administrators",
            "Machine Number",
            "Language",
            "Auto Shutdown Time",
            "Lock Open Control",
            "Transaction Alarm",
            "Admin Log Alarm",
            "Minimum Log Interval",
            "Baud Rate",
            "Parity",
            "Stop Bits",
            "Date Delimeter",
            "Network Enabled",
            "RS232 Enabled",
            "RS485 Enabled",
            "Voice Enabled",
            "Identification Speed",
            "Idle Time",
            "Shutdown Time",
            "Power On Time",
            "Sleep Time",
            "Auto Bell",
            "Match Threshold",
            "Register Threshold",
            "1:1 Threshold",
            "Show Score",
            "Unlock Person Count",
            "Only Verify Card",
            "Net Speed",
            "Must Register Card",
            "Temp State Timeout",
            "Input Number Timeout",
            "Menu Timeout",
            "Date Format",
            "Only 1:1"});
            this.CboSettings.Location = new System.Drawing.Point(125, 27);
            this.CboSettings.Name = "CboSettings";
            this.CboSettings.Size = new System.Drawing.Size(201, 20);
            this.CboSettings.TabIndex = 1;
            this.CboSettings.SelectedIndexChanged += new System.EventHandler(this.CboSettings_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(19, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "Setting";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox5.Controls.Add(this.TxtTransactions);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.TxtAdminLogs);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.TxtPasswords);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.TxtTemplates);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.TxtUsers);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.TxtAdmins);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(457, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 189);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Totals";
            // 
            // TxtTransactions
            // 
            this.TxtTransactions.Location = new System.Drawing.Point(163, 155);
            this.TxtTransactions.Name = "TxtTransactions";
            this.TxtTransactions.ReadOnly = true;
            this.TxtTransactions.Size = new System.Drawing.Size(67, 21);
            this.TxtTransactions.TabIndex = 11;
            this.TxtTransactions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(19, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 25);
            this.label16.TabIndex = 10;
            this.label16.Text = "Transactions";
            // 
            // TxtAdminLogs
            // 
            this.TxtAdminLogs.Location = new System.Drawing.Point(163, 129);
            this.TxtAdminLogs.Name = "TxtAdminLogs";
            this.TxtAdminLogs.ReadOnly = true;
            this.TxtAdminLogs.Size = new System.Drawing.Size(67, 21);
            this.TxtAdminLogs.TabIndex = 9;
            this.TxtAdminLogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(19, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 25);
            this.label15.TabIndex = 8;
            this.label15.Text = "Admin Logs";
            // 
            // TxtPasswords
            // 
            this.TxtPasswords.Location = new System.Drawing.Point(163, 103);
            this.TxtPasswords.Name = "TxtPasswords";
            this.TxtPasswords.ReadOnly = true;
            this.TxtPasswords.Size = new System.Drawing.Size(67, 21);
            this.TxtPasswords.TabIndex = 7;
            this.TxtPasswords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(19, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 25);
            this.label14.TabIndex = 6;
            this.label14.Text = "Passwords";
            // 
            // TxtTemplates
            // 
            this.TxtTemplates.Location = new System.Drawing.Point(163, 79);
            this.TxtTemplates.Name = "TxtTemplates";
            this.TxtTemplates.ReadOnly = true;
            this.TxtTemplates.Size = new System.Drawing.Size(67, 21);
            this.TxtTemplates.TabIndex = 5;
            this.TxtTemplates.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(19, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 24);
            this.label13.TabIndex = 4;
            this.label13.Text = "Templates";
            // 
            // TxtUsers
            // 
            this.TxtUsers.Location = new System.Drawing.Point(163, 53);
            this.TxtUsers.Name = "TxtUsers";
            this.TxtUsers.ReadOnly = true;
            this.TxtUsers.Size = new System.Drawing.Size(67, 21);
            this.TxtUsers.TabIndex = 3;
            this.TxtUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(19, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 24);
            this.label12.TabIndex = 2;
            this.label12.Text = "Users";
            // 
            // TxtAdmins
            // 
            this.TxtAdmins.Location = new System.Drawing.Point(163, 27);
            this.TxtAdmins.Name = "TxtAdmins";
            this.TxtAdmins.ReadOnly = true;
            this.TxtAdmins.Size = new System.Drawing.Size(67, 21);
            this.TxtAdmins.TabIndex = 1;
            this.TxtAdmins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Administrators";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage4.Controls.Add(this.groupBox10);
            this.tabPage4.Controls.Add(this.groupBox9);
            this.tabPage4.Location = new System.Drawing.Point(4, 21);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(763, 311);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "  Options  ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.button8);
            this.groupBox10.Controls.Add(this.button7);
            this.groupBox10.Controls.Add(this.textBox1);
            this.groupBox10.Location = new System.Drawing.Point(308, 17);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(437, 286);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "WriteLCD";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(253, 220);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 35);
            this.button8.TabIndex = 2;
            this.button8.Text = "WriteLCD";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(86, 220);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 35);
            this.button7.TabIndex = 1;
            this.button7.Text = "ClearLCD";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 165);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "A-B-C-D-E-F-G";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button1);
            this.groupBox9.Controls.Add(this.button6);
            this.groupBox9.Controls.Add(this.button3);
            this.groupBox9.Controls.Add(this.button5);
            this.groupBox9.Controls.Add(this.button4);
            this.groupBox9.Location = new System.Drawing.Point(3, 17);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(299, 286);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Test Option";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Beep";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(87, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 35);
            this.button6.TabIndex = 4;
            this.button6.Text = "PlayVoice";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "ClockOff";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(87, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 35);
            this.button5.TabIndex = 3;
            this.button5.Text = "RestartDevice";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(87, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 35);
            this.button4.TabIndex = 2;
            this.button4.Text = "PowerOffDevice";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(771, 482);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZKemsdk Sample Application";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.PanelTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CtrlBioComm)).EndInit();
            this.PanelEthernet.ResumeLayout(false);
            this.PanelEthernet.PerformLayout();
            this.PanelSerial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.PanelBottom.ResumeLayout(false);
            this.TbcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFinger)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FrmMain());
		}

		#region Main Control Handlers
		private void BtnConnectSerial_Click(object sender, System.EventArgs e)
		{
			BtnConnect_Click(this,new System.EventArgs());
		}

		private void BtnConnect_Click(object sender, System.EventArgs e)
		{
			
			int _errorCode = 0;
			string  aa;

			// If the user has already connected to the unit than disconnect

			Cursor = Cursors.WaitCursor;
			aa="";
            

			if( BtnConnect.Text == "Disconnect" )
			{
				CtrlBioComm.Disconnect();
				BtnConnect.Text = "Connect";
				Cursor = Cursors.Default;
                label22.Text = "NO Connect ";
               
				return;
			}

			/* Attempt to connect to the Terminal
			/ Connect_Net is used to connect to ethernet connected devices
			/ while Connect_Com is used for serial devices */

            if (RdbEthernet.Checked)
            {
                _connected = CtrlBioComm.Connect_Net(TxtIP.Text, Convert.ToInt32(TxtPort.Text));
                CtrlBioComm.GetSDKVersion(ref aa);
                string bb;
                bb = "Connect 'OK'   SDKVersion : " + aa;


                if (_connected)
                {
                    label22.Text = "Connect ...";
                    label24.Text = aa;
                    MessageBox.Show(bb);

                 // '  int _value = 0;

                   // CtrlBioComm.GetDeviceInfo(1, 1, ref _value);
                   // TxtValue.Text = _value.ToString();
                }
                  

                
            }
            else
            {
                _connected = CtrlBioComm.Connect_Com(Convert.ToInt32(CboComPort.Text), 1,
                    Convert.ToInt32(CboBaudRate.Text));

                if (_connected)
                {
                    CtrlBioComm.GetSDKVersion(ref aa);
                    label24.Text = aa;
                    label22.Text = "Connect ...";

                    int _value = 0;

                    CtrlBioComm.GetDeviceInfo(1, 1, ref _value);
                    TxtValue.Text = _value.ToString();

                }
             
            }
			
			if( _connected )
			{
				BtnConnect.Text  = "Disconnect";
				BtnConnect.Refresh() ;
			}
			else
			{

				// When errors occur a call to GetLastError will return the reason for the error
				// In cases where a connection to the terminal cannot be made GetLastError may return 0

				CtrlBioComm.GetLastError(ref _errorCode);
				MessageBox.Show("Unable to connect to device, Error Code: " + _errorCode.ToString());
			}

			Cursor = Cursors.Default;
		}

		private void RdbEthernet_CheckedChanged(object sender, System.EventArgs e)
		{
			// If user selects an ethernet connection than hide the serial settings panel
			// and display the ethernet settings panel

			PanelSerial.Visible = false;
			PanelEthernet.Visible = true;
		}

		private void RdbSerial_CheckedChanged(object sender, System.EventArgs e)
		{
			// If user selects an serial connection than hide the ethernet settings panel
			// and display the serial settings panel

			PanelEthernet.Visible = false;
			PanelSerial.Visible = true;
			
			CboComPort.SelectedIndex = 0;
			CboBaudRate.SelectedIndex = 0;
		}

		private void TbcMain_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			int _errorCode = 0;
			int _enrollNumber = 0;				// User ID
			int _enrollMachineNumber = 0;		// Terminal that user enrolled at
			int _backupNumber = 0;				// Index of finger enrolled
			int _machinePrivilege = 0;			// Privileges of the user
			int _enable = 0;					// Determines if the user is enabled at the terminal
			int _value = 0;
			int _year = 0;
			int _month = 0;
			int _day = 0;
			int _hour = 0;
			int _minute = 0;
			int _dayOfWeek = 0;
			string _firmwareVersion = "";
			string _serialNumber = "";
			string _ipAddress = "";
			string _password = "";				// Password if used by the user
			string _name = "";					// User name stored in terminal
			string _privileges = "";
			bool _enabled = false;
			ListViewItem _item = null;

			// Don't attempt to collect any terminal or user information unless connected to terminal

			if( (BtnConnectSerial.Text == "Connect") && (BtnConnect.Text == "Connect") )
			{
				//MessageBox.Show("Please connect to the terminal");
				return;
			}

			Cursor = Cursors.WaitCursor;

			switch( TbcMain.SelectedIndex )
			{
				case 1:	// User management selected so upload users from terminal
				{
					LvUsers.Items.Clear();

					if( CtrlBioComm.ReadAllUserID(1) )	// Put all users into the buffer at the terminal
					{
						LvUsers.BeginUpdate();
						CtrlBioComm.GetLastError(ref _errorCode);

						while( _errorCode != 0 )
						{
							// Now collect all the users from the terminal

							if( CtrlBioComm.GetAllUserID(1,ref _enrollNumber,ref _enrollMachineNumber,
								ref _backupNumber,ref _machinePrivilege,ref _enable) )
							{
								CtrlBioComm.GetUserInfo(1,_enrollNumber,ref _name,ref _password,
									ref _machinePrivilege,ref _enabled);

								_item = LvUsers.Items.Add(_enrollNumber.ToString());
								_item.SubItems.Add(_name.ToString());
								_item.SubItems.Add(_password.ToString());

								switch( _machinePrivilege )
								{
									case 0:
									{
										_privileges = "General User";
										break;
									}
									case 1:
									{
										_privileges = "Admin Level 1";
										break;
									}
									case 2:
									{
										_privileges = "Admin Level 2";
										break;
									}
									case 3:
									{
										_privileges = "Admin Level 3";
										break;
									}
									default:
									{
										_privileges = "Unknown";
										break;
									}
								}

								_item.SubItems.Add(_privileges);

								if( _enable == 1 )
									_item.SubItems.Add("Y");
								else
									_item.SubItems.Add("N");
							}

							CtrlBioComm.GetLastError(ref _errorCode);
						}

						LvUsers.EndUpdate();
					}
					else
					{
						CtrlBioComm.GetLastError(ref _errorCode);

						if( _errorCode != 0 )
							MessageBox.Show("Unable to read user id's from terminal,  Error Code: " + _errorCode.ToString());
					}
					
					break;
				}
				case 2:	// User selected terminal information so upload terminal configuration
				{
					if( CtrlBioComm.GetDeviceStatus(1,1,ref _value) ) // Admin count
						TxtAdmins.Text = _value.ToString();
					else
						TxtAdmins.Text = "N/A";

					if( CtrlBioComm.GetDeviceStatus(1,2,ref _value) ) // User count
						TxtUsers.Text = _value.ToString();
					else
						TxtUsers.Text = "N/A";

					if( CtrlBioComm.GetDeviceStatus(1,3,ref _value) ) // Template count
						TxtTemplates.Text = _value.ToString();
					else
						TxtTemplates.Text = "N/A";

					if( CtrlBioComm.GetDeviceStatus(1,4,ref _value) ) // Password count
						TxtPasswords.Text = _value.ToString();
					else
						TxtPasswords.Text = "N/A";

					if( CtrlBioComm.GetDeviceStatus(1,5,ref _value) ) // Admin Logs
						TxtAdminLogs.Text = _value.ToString();
					else
						TxtAdminLogs.Text = "N/A";

					if( CtrlBioComm.GetDeviceStatus(1,6,ref _value) ) // Transaction count
						TxtTransactions.Text = _value.ToString();
					else
						TxtTransactions.Text = "N/A";

					// Get the device time of the terminal and the ip address

					if( CtrlBioComm.GetDeviceIP(1,ref _ipAddress) )
						TxtTerminalIP.Text = _ipAddress;
					else
						TxtTerminalIP.Text = "N/A";

					if( CtrlBioComm.GetDeviceTime(1,ref _year,ref _month,ref _day,ref _hour,ref _minute,ref _dayOfWeek) )
						TxtDeviceTime.Text = new DateTime(_year,_month,_day,_hour,_minute,0,0).ToString();
					else
						TxtDeviceTime.Text = "N/A";

					// Finally get the device firmware and serial number
                    //string ccdd;
                    if (CtrlBioComm.GetSerialNumber(1, out _serialNumber))
						TxtSerial.Text = _serialNumber;
					else
						TxtSerial.Text = "N/A";

					if( CtrlBioComm.GetFirmwareVersion(1,ref _firmwareVersion) )
						TxtFirmware.Text = _firmwareVersion;
					else
						TxtFirmware.Text = "N/A";
                  //  CtrlBioComm.RegEvent(

					break;
				}
			}

			Cursor = Cursors.Default;
		}
		#endregion

		#region Data Collection Tab
		private void CtrlBioComm_OnAttTransaction(object sender, Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent e)
		{
			// This event is fired when a transaction occurs at the terminal
			// The sample application will only add the transaction to the list
			// if the user has selected collect live data mode

		//	if( _collectLiveData == false )
			//	return;

		//	StringBuilder _data = new StringBuilder();

			//_data.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7},{8}",e.enrollNumber,
			//	e.verifyMethod,e.isInValid,e.year,e.month,e.day,e.hour,e.minute,e.second);
			//LvTransactions.Items.Add(_data.ToString());
		}

		private void BtnCollectLiveData_Click(object sender, System.EventArgs e)
		{
			// Disable all data collection buttons and start listening for live data

			LvTransactions.Items.Clear();

			if( BtnCollectLiveData.Text == "Stop Collecting" ) 
			{
				BtnClearPunches.Enabled = true;
				BtnCollect.Enabled = true;
				BtnCollectLiveData.Text = "Collect Live Data";

				_collectLiveData = false;
				return;
			}

			BtnClearPunches.Enabled = false;
			BtnCollect.Enabled = false;

			BtnCollectLiveData.Text = "Stop Collecting";
			_collectLiveData = true;
		}

		private void LvTransactions_ItemActivate(object sender, System.EventArgs e)
		{
			string _transaction = "";
			string[] _data = null;
			DateTime _date;

			// Parse the transaction data and display the information to the user

			_transaction = LvTransactions.SelectedItems[0].Text;
			_data = _transaction.Split(',');

			TxtUserID.Text = _data[0].ToString();
			TxtVerifyMethod.Text = _data[1].ToString();

			if( _data.Length == 8 ) 
			{
				_date = new DateTime(Convert.ToInt32(_data[3]),Convert.ToInt32(_data[4]),Convert.ToInt32(_data[5]),
					Convert.ToInt32(_data[6]),Convert.ToInt32(_data[7]),0);
			}
			else
			{
				_date = new DateTime(Convert.ToInt32(_data[3]),Convert.ToInt32(_data[4]),Convert.ToInt32(_data[5]),
					Convert.ToInt32(_data[6]),Convert.ToInt32(_data[7]),Convert.ToInt32(_data[8]));
			}

			TxtTransactionDate.Text = _date.ToString();		
		}

		private void LvTransactions_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string _transaction = "";
			string[] _data = null;
			DateTime _date;

			// Parse the transaction data and display the information to the user

			if( LvTransactions.SelectedItems.Count >= 1 )
			{
				_transaction = LvTransactions.SelectedItems[0].Text;
				_data = _transaction.Split(',');

				TxtUserID.Text = _data[0].ToString();
				TxtVerifyMethod.Text = _data[1].ToString();

				if( _data.Length == 8 ) 
				{
					_date = new DateTime(Convert.ToInt32(_data[3]),Convert.ToInt32(_data[4]),Convert.ToInt32(_data[5]),
						Convert.ToInt32(_data[6]),Convert.ToInt32(_data[7]),0);
				}
				else
				{
					_date = new DateTime(Convert.ToInt32(_data[3]),Convert.ToInt32(_data[4]),Convert.ToInt32(_data[5]),
						Convert.ToInt32(_data[6]),Convert.ToInt32(_data[7]),Convert.ToInt32(_data[8]));
				}

				TxtTransactionDate.Text = _date.ToString();	
			}
		}

		private void BtnCollect_Click(object sender, System.EventArgs e)
		{
			int _errorCode = 0;
			int _machineNumber = 0;
			int _enrollNumber = 0;
			int _enrollMachineNumber = 0;
			int _verifyMode = 0;
			int _inOutMode = 0;
			int _year = 0;
			int _month = 0;
			int _day = 0;
			int _hour = 0;
			int _minute = 0;
            //int _workcode = 0;
           // int _Reserved = 0;
			StringBuilder _data = new StringBuilder();

			// Upload all the available punch data from the terminal
			// ReadGeneralLogData will fill the terminals internal buffer with 
			// all available transactions that have been stored at the unit
			// GetGeneralLogData will return that buffer to the caller

			Cursor = Cursors.WaitCursor;

			if( CtrlBioComm.ReadGeneralLogData(1) )	// The sample application assumes a machine number of 1
			{
				// After a successful call to ReadGeneralLogData, multiple calls to GetGeneralLogData
				// will return the transaction data from the terminal

				LvTransactions.Items.Clear();
				LvTransactions.BeginUpdate();

				CtrlBioComm.GetLastError(ref _errorCode);

				while( _errorCode != 0 )
				{
					if( CtrlBioComm.GetGeneralLogData(1,ref _machineNumber,ref _enrollNumber,ref _enrollMachineNumber,
						ref _verifyMode,ref _inOutMode,ref _year,ref _month,ref _day,ref _hour,ref _minute) )
					{
						_data.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7}",_enrollNumber,
							_verifyMode,_inOutMode,_year,_month,_day,_hour,_minute);

						LvTransactions.Items.Add(_data.ToString());
						_data.Remove(0,_data.Length);
					}

					CtrlBioComm.GetLastError(ref _errorCode);
				}
                
				LvTransactions.EndUpdate();
				Cursor = Cursors.Default;
            } //end if( CtrlBioComm.ReadGeneralLogData(1) )
			else
			{
				Cursor = Cursors.Default;
				CtrlBioComm.GetLastError(ref _errorCode);

				if( _errorCode != 0 )
					MessageBox.Show("Unable to collect data from terminal,  Error Code: " + _errorCode.ToString());
				else
					MessageBox.Show("Terminal is empty");
			}
         
		}

		private void BtnClearPunches_Click(object sender, System.EventArgs e)
		{
			int _errorCode = 0;

			// Purge any punch data from the terminal

			Cursor = Cursors.WaitCursor;

			if( CtrlBioComm.ClearGLog(1) )
				MessageBox.Show("Data has been cleared from the terminal");
			else
			{
				CtrlBioComm.GetLastError(ref _errorCode);
				MessageBox.Show("Unable clear data from terminal,  Error Code: " + _errorCode.ToString());
			}

			LvTransactions.Items.Clear();
			Cursor = Cursors.Default;
		}
		#endregion

		#region User Management Tab
		private void BtnDeleteUser_Click(object sender, System.EventArgs e)
		{
			int _errorCode = 0;

			// Ensure that a valid user id has been selected

			if( TxtUser.Text == "" )
			{
				MessageBox.Show("Please select a user");
				return;
			}

			CtrlBioComm.EnableDevice(1,false);		// Lock terminal to prevent activity during delete
			Cursor = Cursors.WaitCursor;

			// Delete the user completely from the terminal
			// Passing a 12 for backupNumber will erase all fingerprints and passwords for the user
			// Passing an 11 will only remove all the fingerprints for the user

			if( CtrlBioComm.DeleteEnrollData(1,Convert.ToInt32(TxtUser.Text),1,12) )
				MessageBox.Show("User removed from terminal");
			else
			{
				CtrlBioComm.GetLastError(ref _errorCode);
				MessageBox.Show("Unable to delete user from terminal,  Error Code: " + _errorCode.ToString());
			}

			// Refresh the list view

			TbcMain_SelectedIndexChanged(this,new System.EventArgs());

			CtrlBioComm.EnableDevice(1,true);	// Unlock the terminal
			Cursor = Cursors.Default;
		}

		private void BtnCaptureFinger_Click(object sender, System.EventArgs e)
		{
			int _width = 0;
			int _height = 0;
			int _errorCode = 0;
			byte[] _image = new byte[83512];	// Image is 640x480
			string _imageFile = "Image.bmp";
			FileStream _stream = null;

			// Capture the fingerprint of the user and display the image

			Cursor = Cursors.WaitCursor;
			CtrlBioComm.EnableDevice(1,false);
			MessageBox.Show("Place finger on sensor");

			if( CtrlBioComm.CaptureImage(false,ref _width,ref _height,ref _image[0],_imageFile) )
			{
				_stream = new FileStream("Image.bmp", FileMode.Open);
				PicFinger.Image = FixedSize(Image.FromStream(_stream),PicFinger.Width,PicFinger.Height);
			}
			else
			{
				CtrlBioComm.GetLastError(ref _errorCode);
				MessageBox.Show("Unable to capture fingerprint,  Error Code: " + _errorCode.ToString());
			}

			MessageBox.Show("Remove finger from sensor");
			CtrlBioComm.EnableDevice(1,true);
			Cursor = Cursors.Default;
		}

		private void LvUsers_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if( LvUsers.SelectedItems.Count >= 1 )
			{
				// Collect information for selected user from the listview

				TxtUser.Text = LvUsers.SelectedItems[0].Text;
				TxtName.Text = LvUsers.SelectedItems[0].SubItems[1].Text;
				TxtPassword.Text = LvUsers.SelectedItems[0].SubItems[2].Text;

				// Setup combo box to display current privilege for selected user

				if( LvUsers.SelectedItems[0].SubItems[3].Text == "General User" )
					CboPrivilege.SelectedIndex = 0;
				else if( LvUsers.SelectedItems[0].SubItems[3].Text == "Admin Level 1" )
					CboPrivilege.SelectedIndex = 1;
				else if( LvUsers.SelectedItems[0].SubItems[3].Text == "Admin Level 2" )
					CboPrivilege.SelectedIndex = 2;
				else
					CboPrivilege.SelectedIndex = 3;

				// If the user is enabled than set the check box

				if( LvUsers.SelectedItems[0].SubItems[4].Text == "Y" )
					ChkEnabled.Checked = true;
				else
					ChkEnabled.Checked = false;
			}
		}

		private void BtnUploadTemplate_Click(object sender, System.EventArgs e)
		{
			int[] _enrollData = new int[73];		// Templates are 73 ints in length
			int _password = 0;
			int _machinePrivilege = 0;
			FileStream _stream = null;
			BinaryWriter _writer = null;

			// Ensure that a valid user id has been selected

			if( TxtUser.Text == "" )
			{
				MessageBox.Show("Please select a user");
				return;
			}

			CtrlBioComm.EnableDevice(1,false);		// Lock terminal to prevent activity during delete
			Cursor = Cursors.WaitCursor;

			// Upload all available templates for the selected user
			// Templates will be stored in a file called Template_N.dat where N is the finger index

			for( int _fingerIndex = 0; _fingerIndex < 10; _fingerIndex++ )
			{
				if( CtrlBioComm.GetEnrollData(1,Convert.ToInt32(TxtUser.Text),1,_fingerIndex,
					ref _machinePrivilege,ref _enrollData[0],ref _password) )
				{
					// Template was successfully uploaded for this finger index
					// Store the template in the file

					_stream = new FileStream("Template_" + _fingerIndex.ToString() + ".dat", FileMode.Create);
					_writer = new BinaryWriter(_stream);

					for( int _index = 0; _index < _enrollData.Length; _index++ )
						_writer.Write(_enrollData[_index]);

					_stream.Close();
					_writer.Close();
				}
			}

			MessageBox.Show("Templates have been uploaded");
			Cursor = Cursors.Default;
			CtrlBioComm.EnableDevice(1,true);		// Unlock terminal
		}

		private void BtnLoadTemplate_Click(object sender, System.EventArgs e)
		{
			byte[] _enrollData = new byte[292];
			int _errorCode = 0;
			FileStream _stream = null;
			BinaryReader _reader = null;

			// Ensure that a valid user id has been selected

			if( TxtUser.Text == "" )
			{
				MessageBox.Show("Please select a user");
				return;
			}

			// Ask the user to provide a template file to load

			if( DlgOpenTemplate.ShowDialog() == DialogResult.Cancel )
				return;

			CtrlBioComm.EnableDevice(1,false);		// Lock terminal to prevent activity during delete
			Cursor = Cursors.WaitCursor;

			_stream = (FileStream)DlgOpenTemplate.OpenFile();	// Open and read the template file
			_reader = new BinaryReader(_stream);

			for( int _index = 0; _index < _stream.Length; _index++ )
			{
				if( _reader.PeekChar() != -1 )
					_enrollData[_index] = _reader.ReadByte();
			}

			_reader.Close();
			_stream.Close();

			// Send the template data to the terminal
			// The sample here will always load the template as finger index 0

			if( CtrlBioComm.SetUserTmp(1,Convert.ToInt32(TxtUser.Text),0,ref _enrollData[0]) )
			{
				MessageBox.Show("Template successfully loaded to terminal");
			}
			else
			{
				CtrlBioComm.GetLastError(ref _errorCode);
				MessageBox.Show("Unable to load template to terminal,  Error Code: " + _errorCode.ToString());
			}

			CtrlBioComm.EnableDevice(1,true);	// Unlock the terminal
			Cursor = Cursors.Default;	
		}

		private void BtnSetUserInfo_Click(object sender, System.EventArgs e)
		{
			bool _enabled = true;
			int _errorCode = 0;

			// Ensure that a valid user id has been selected

			if( TxtUser.Text == "" )
			{
				MessageBox.Show("Please select a user");
				return;
			}

			CtrlBioComm.EnableDevice(1,false);		// Lock terminal to prevent activity during delete
			Cursor = Cursors.WaitCursor;

			if( ChkEnabled.Checked )	// Check if the user is enabled in the terminal
				_enabled = true;
			else
				_enabled = false;

			// Set the collected user information to the terminal

			if( CtrlBioComm.SetUserInfo(1,Convert.ToInt32(TxtUser.Text),TxtName.Text,TxtPassword.Text,
				CboPrivilege.SelectedIndex,_enabled) )
			{
				MessageBox.Show("User information updated");
			}
			else
			{
				CtrlBioComm.GetLastError(ref _errorCode);
				MessageBox.Show("Unable to update user information,  Error Code: " + _errorCode.ToString());
			}

			// Refresh the list view

			TbcMain_SelectedIndexChanged(this,new System.EventArgs());

			CtrlBioComm.EnableDevice(1,true);	// Unlock the terminal
			Cursor = Cursors.Default;			
		}

		private void BtnDeleteTemplates_Click(object sender, System.EventArgs e)
		{
			// Ensure that a valid user id has been selected

			if( TxtUser.Text == "" )
			{
				MessageBox.Show("Please select a user");
				return;
			}

			CtrlBioComm.EnableDevice(1,false);		// Lock terminal to prevent activity during delete
			Cursor = Cursors.WaitCursor;

			// Remove all templates from the terminal for the selected user

			for( int _fingerIndex = 0; _fingerIndex < 10; _fingerIndex++ )
				CtrlBioComm.DelUserTmp(1,Convert.ToInt32(TxtUser.Text),_fingerIndex);

			MessageBox.Show("Templates deleted from terminal");

			CtrlBioComm.EnableDevice(1,true);		// Unlock terminal
			Cursor = Cursors.Default;
		}
		#endregion

		#region Terminal Information Tab
		private void BtnClearAdmin_Click(object sender, System.EventArgs e)
		{
			int _errorCode = 0;

			// Clear all administrators from the terminal

			if( CtrlBioComm.ClearAdministrators(1) )
				MessageBox.Show("Administrators cleared from terminal");
			else
			{
				CtrlBioComm.GetLastError(ref _errorCode);
				MessageBox.Show("Unable to clear administrators,  Error Code: " + _errorCode.ToString());
			}
		}

		private void BtnClearTerminal_Click(object sender, System.EventArgs e)
		{
			int _errorCode = 0;

			// Clear all users,templates,passwords,administrators,logs, and transactions from the terminal
			// This method will wipe out the entire contents of the terminal

			if( CtrlBioComm.ClearKeeperData(1) )
				MessageBox.Show("All information cleared from terminal");
			else
			{
				CtrlBioComm.GetLastError(ref _errorCode);
				MessageBox.Show("Unable to clear terminal information,  Error Code: " + _errorCode.ToString());
			}
		}

		private void BtnBackup_Click(object sender, System.EventArgs e)
		{
			int _errorCode = 0;

			// Save the entire contents of the terminal to a backup file

			if( CtrlBioComm.BackupData("terminal.bak") )
				MessageBox.Show("Terminal information saved to backup.dat");
			else
			{
				CtrlBioComm.GetLastError(ref _errorCode);
				MessageBox.Show("Unable to backup terminal data,  Error Code: " + _errorCode.ToString());
			}
		}

		private void BtnRestore_Click(object sender, System.EventArgs e)
		{
			int _errorCode = 0;

			// Ask the user to provide a backup file to load

			if( DlgOpenBackup.ShowDialog() == DialogResult.Cancel )
				return;

			// Restore the terminal backup file

			if( CtrlBioComm.RestoreData(DlgOpenBackup.FileName) )
				MessageBox.Show("Terminal data has been restored");
			else
			{
				CtrlBioComm.GetLastError(ref _errorCode);
				MessageBox.Show("Unable to restore terminal data,  Error Code: " + _errorCode.ToString());
			}
		}

		private void CboSettings_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			int _value = 0;

			// Get the value of the setting being chosen and display

			CtrlBioComm.GetDeviceInfo(1,CboSettings.SelectedIndex + 1,ref _value);
			TxtValue.Text = _value.ToString();
			_settingChanged = false;
		}

		private void TxtDeviceTime_TextChanged(object sender, System.EventArgs e)
		{
			if( _firstTime == false )
				_deviceTimeChanged = true;
			else
				_firstTime = false;
		}

		private void TxtTerminalIP_TextChanged(object sender, System.EventArgs e)
		{
			if( _firstTime == false )
				_ipAddressChanged = true;
			else
				_firstTime = false;
		}

		private void BtnUpdateComm_Click(object sender, System.EventArgs e)
		{
			DateTime _date;
			int _errorCode = 0;

			// Update the currently selected setting, as well as the IP address
			// and device time if they have been changed

			if( _ipAddressChanged )
				CtrlBioComm.SetDeviceIP(1,TxtTerminalIP.Text);

			if( _deviceTimeChanged )
			{
				try
				{
					_date = Convert.ToDateTime(TxtDeviceTime.Text);
				}
				catch(System.InvalidCastException Exception)
				{
					string _message = Exception.Message;
					MessageBox.Show("Invalid date/time format");
					return;
				}

				CtrlBioComm.SetDeviceTime2(1,_date.Year,_date.Month,_date.Day,_date.Hour,_date.Minute,_date.Second);
			}

			// Now update the currently selected setting if it has been changed

			if( _settingChanged )
				CtrlBioComm.SetDeviceInfo(1,CboSettings.SelectedIndex + 1,Convert.ToInt32(TxtValue.Text));

			CtrlBioComm.GetLastError(ref _errorCode);

			if( _errorCode != 1 )
				MessageBox.Show("Unable to update terminal settings,  Error Code: " + _errorCode.ToString());	
			else
				MessageBox.Show("Terminal settings updated");
		}

		private void TxtValue_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			_settingChanged = true;
		}

		private void BtnUpdateFirmware_Click(object sender, System.EventArgs e)
		{
			int _errorCode = 0;

			// Ask the user to provide a firmware file to load

			if( DlgOpenFirmware.ShowDialog() == DialogResult.Cancel )
				return;

			// Load the firmware file to the terminal

			if( CtrlBioComm.UpdateFirmware(DlgOpenFirmware.FileName) )
				MessageBox.Show("Terminal firmware loaded, Please reset terminal");
			else
			{
				CtrlBioComm.GetLastError(ref _errorCode);
				MessageBox.Show("Unable to load terminal firmware, Error Code: " + _errorCode.ToString());
			}		
		}
		#endregion

		#region External Helper Functions
		/// <summary>
		/// Helper function to scale the fingerprint image to the size of the picture box
		/// </summary>
		/// <param name="imgPhoto">Image to scale</param>
		/// <param name="Width">New width to scale to</param>
		/// <param name="Height">New height to scale to</param>
		/// <returns>Newly sized image</returns>
		/// 
		private Image FixedSize(Image imgPhoto, int Width, int Height)
		{
			int sourceWidth = imgPhoto.Width;
			int sourceHeight = imgPhoto.Height;
			int sourceX = 0;
			int sourceY = 0;
			int destX = 0;
			int destY = 0; 

			float nPercent = 0;
			float nPercentW = 0;
			float nPercentH = 0;

			nPercentW = ((float)Width/(float)sourceWidth);
			nPercentH = ((float)Height/(float)sourceHeight);
			if(nPercentH < nPercentW)
			{
				nPercent = nPercentH;
				destX = System.Convert.ToInt16((Width - 
					(sourceWidth * nPercent))/2);
			}
			else
			{
				nPercent = nPercentW;
				destY = System.Convert.ToInt16((Height - 
					(sourceHeight * nPercent))/2);
			}

			int destWidth  = (int)(sourceWidth * nPercent);
			int destHeight = (int)(sourceHeight * nPercent);

			Bitmap bmPhoto = new Bitmap(Width, Height, 
				System.Drawing.Imaging.PixelFormat.Format24bppRgb);
			bmPhoto.SetResolution(imgPhoto.HorizontalResolution, 
				imgPhoto.VerticalResolution);

			Graphics grPhoto = Graphics.FromImage(bmPhoto);
			grPhoto.Clear(Color.White);
			grPhoto.InterpolationMode =	System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

			grPhoto.DrawImage(imgPhoto, 
				new Rectangle(destX,destY,destWidth,destHeight),
				new Rectangle(sourceX,sourceY,sourceWidth,sourceHeight),
				GraphicsUnit.Pixel);

			grPhoto.Dispose();
			return bmPhoto;
		}
		#endregion

		private void DlgOpenTemplate_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
		}

		private void PanelTop_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		}

        private void CtrlBioComm_OnAttTransaction_1(object sender, Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {


        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            label22.Text = "NO Connect";
          //  CboSettings.Text = "Max Administrators";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool beept;
           //if(connect1)
			//{
			if(_connected)
			{
  
			     beept=  CtrlBioComm.Beep(150);

			     if(beept)
				   MessageBox.Show ("Beep","information");
			    else
				    MessageBox.Show ("No Beep","information");
			}
			else
			{
				MessageBox.Show ("Connect Failed","information",MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
				return;
			}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            	if(_connected)
			{
                 if(button3.Text =="ClockOff")
			      {

			         CtrlBioComm.EnableClock(0);
			         button3.Text ="ClockOn";
			      }
			   else
			      {
                     CtrlBioComm.EnableClock(1);
			         button3.Text ="ClockOff";
			       }
			}

			else
			
			{
				MessageBox.Show ("Connect Failed","information",MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
				 return;
			
			 }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (_connected)

			    CtrlBioComm.PowerOffDevice(1);

			else

			 {

				MessageBox.Show ("Connect Failed","information",MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
			 	 return;


			   }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (_connected)

			        CtrlBioComm.RestartDevice(1);
			 else

			 {
				MessageBox.Show ("Connect Failed","information",MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
				 return;
			
			}
        }

        private void button6_Click(object sender, EventArgs e)
        {
            	
			if(_connected)

			    CtrlBioComm.PlayVoiceByIndex(0);
			 else
			   {
				  MessageBox.Show ("Connect Failed","information",MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
				  return;
			   }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(_connected)
				 {
		         CtrlBioComm.EnableClock(0);	
			     CtrlBioComm.ClearLCD();
				 }
				 else
				 {
					 MessageBox.Show ("Connect Failed","information",MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
					 return;
				 }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(_connected)

			     CtrlBioComm.WriteLCD(1,1,textBox1.Text );

			else
			 {

                    MessageBox.Show ("Connect Failed","information",MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
				 return;

			  }
        }

        private void CtrlBioComm_OnAttTransaction_2(object sender, Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent e)
        {
          //  if (_collectLiveData == false)
                //return;
            //
            StringBuilder _data = new StringBuilder();

            _data.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7},{8}", e.enrollNumber,
                e.verifyMethod, e.isInValid, e.year, e.month, e.day, e.hour, e.minute, e.second);
            LvTransactions.Items.Add(_data.ToString());
            LvTransactions.Update();
        }
	}
}
