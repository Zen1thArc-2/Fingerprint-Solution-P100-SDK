using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace AXPRJLite
{
	/// <summary>
	/// Summary description for WinForm.
	/// </summary>
	public class WinForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Panel panel1;
		private AxZKFPEngXControl.AxZKFPEngX axZKFPEngX1;
		private System.Windows.Forms.StatusBar statusBar1;
		 int FMatchType;
		 bool isConnected;
		 int fpcHandle;
		 int FID;
		 Object RegTemplate;
		 Object VerTemplate;
		 String tempstr;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		public WinForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

		 fpcHandle=axZKFPEngX1.CreateFPCacheDB();
		 FID=0;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(WinForm));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.axZKFPEngX1 = new AxZKFPEngXControl.AxZKFPEngX();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axZKFPEngX1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(16, 120);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Init Sensor";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(16, 168);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Save Image";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(16, 216);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(88, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Register";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new System.Drawing.Point(16, 256);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(88, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "Verify1:1";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Location = new System.Drawing.Point(128, 256);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(80, 23);
			this.button5.TabIndex = 4;
			this.button5.Text = "Verify1:N";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Sensor count";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(152, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Current";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "Sensor SN";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(88, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(56, 21);
			this.textBox1.TabIndex = 8;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(208, 8);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(48, 21);
			this.textBox2.TabIndex = 9;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(16, 56);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(240, 21);
			this.textBox3.TabIndex = 10;
			this.textBox3.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(216, 216);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(40, 21);
			this.textBox4.TabIndex = 11;
			this.textBox4.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(112, 152);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(144, 48);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "format";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(80, 16);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(56, 24);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "JPG";
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(8, 16);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(64, 24);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Bitmap";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(336, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 240);
			this.panel1.TabIndex = 13;
			// 
			// axZKFPEngX1
			// 
			this.axZKFPEngX1.Enabled = true;
			this.axZKFPEngX1.Location = new System.Drawing.Point(272, 104);
			this.axZKFPEngX1.Name = "axZKFPEngX1";
			this.axZKFPEngX1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axZKFPEngX1.OcxState")));
			this.axZKFPEngX1.Size = new System.Drawing.Size(24, 24);
			this.axZKFPEngX1.TabIndex = 14;
			this.axZKFPEngX1.OnEnroll += new AxZKFPEngXControl.IZKFPEngXEvents_OnEnrollEventHandler(this.axZKFPEngX1_OnEnroll);
			this.axZKFPEngX1.OnFeatureInfo += new AxZKFPEngXControl.IZKFPEngXEvents_OnFeatureInfoEventHandler(this.axZKFPEngX1_OnFeatureInfo);
			this.axZKFPEngX1.OnCapture += new AxZKFPEngXControl.IZKFPEngXEvents_OnCaptureEventHandler(this.axZKFPEngX1_OnCapture);
			this.axZKFPEngX1.OnImageReceived += new AxZKFPEngXControl.IZKFPEngXEvents_OnImageReceivedEventHandler(this.axZKFPEngX1_OnImageReceived);
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 295);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
						this.statusBarPanel1});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(552, 22);
			this.statusBar1.TabIndex = 15;
			// 
			// statusBarPanel1
			// 
			this.statusBarPanel1.Width = 500;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(120, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 16);
			this.label4.TabIndex = 16;
			this.label4.Text = "Threshold";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(184, 120);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(72, 21);
			this.textBox5.TabIndex = 17;
			this.textBox5.Text = "10";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(120, 216);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 16);
			this.label5.TabIndex = 18;
			this.label5.Text = "Finger Number";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 16);
			this.label6.TabIndex = 19;
			this.label6.Text = "Image Width";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(144, 88);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 16);
			this.label7.TabIndex = 20;
			this.label7.Text = "Image Height";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(88, 88);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(40, 21);
			this.textBox6.TabIndex = 21;
			this.textBox6.Text = "";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(224, 88);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(32, 21);
			this.textBox7.TabIndex = 22;
			this.textBox7.Text = "";
			// 
			// WinForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(552, 317);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.statusBar1);
			this.Controls.Add(this.axZKFPEngX1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "WinForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Biokey DEMO-C#";
			this.Closed += new System.EventHandler(this.WinForm_Closed);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axZKFPEngX1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			this.ResumeLayout(false);
		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.Run(new WinForm());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(axZKFPEngX1.InitEngine()==0)
			{
			statusBar1.Panels[0].Text="Sensor Connected";
			textBox1.Text=axZKFPEngX1.SensorCount.ToString();
			textBox2.Text=axZKFPEngX1.SensorIndex.ToString();
			textBox3.Text=axZKFPEngX1.SensorSN;
			textBox6.Text=axZKFPEngX1.ImageWidth.ToString();
			textBox7.Text=axZKFPEngX1.ImageHeight.ToString();
			FMatchType=0;
			isConnected=true;
			}
		  else
		  {
		  statusBar1.Panels[0].Text="Sensor Disconneted";
		  textBox1.Text="";
		  textBox2.Text="";
		  textBox3.Text="";
          isConnected=false;
		  }
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
		if (!isConnected) return; 
		if (radioButton1.Checked)
		axZKFPEngX1.SaveBitmap("c:\\fingerprint.bmp");
		else
        axZKFPEngX1.SaveJPG("c:\\fingerprint.jpg");
		MessageBox.Show("Save Success","Warn",MessageBoxButtons.OK);

		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			if (axZKFPEngX1.IsRegister) axZKFPEngX1.CancelEnroll();
			   axZKFPEngX1.BeginEnroll();
		}

		private void axZKFPEngX1_OnImageReceived(object sender, AxZKFPEngXControl.IZKFPEngXEvents_OnImageReceivedEvent e)
		{

			Graphics canvas=panel1.CreateGraphics();
			axZKFPEngX1.PrintImageAt(canvas.GetHdc().ToInt32(),0,0,panel1.Width,panel1.Height );
			canvas.Dispose();

		}

		private void axZKFPEngX1_OnEnroll(object sender, AxZKFPEngXControl.IZKFPEngXEvents_OnEnrollEvent e)
		{
			if(e.actionResult)
			{
			FID++;
			RegTemplate=e.aTemplate;
			axZKFPEngX1.AddRegTemplateToFPCacheDB(fpcHandle,FID,e.aTemplate);
			textBox4.Text=FID.ToString();
			MessageBox.Show("Register Success","Warn",MessageBoxButtons.OK);

			}
		}

		private void axZKFPEngX1_OnCapture(object sender, AxZKFPEngXControl.IZKFPEngXEvents_OnCaptureEvent e)
		{
		if (e.actionResult)
		{
		VerTemplate=e.aTemplate;
		int score=0,processedFPNumber=0;
		int ID;

		 axZKFPEngX1.OneToOneThreshold=Int32.Parse(textBox5.Text);
		axZKFPEngX1.Threshold=Int32.Parse(textBox5.Text);
		if (FMatchType==1)
		{
		bool b=false;
		if (axZKFPEngX1.VerFinger(ref RegTemplate,e.aTemplate,false,ref b))
		  {
		   tempstr="Verify Success! FingerNum is "+FID.ToString();
			MessageBox.Show(tempstr,"Warn",MessageBoxButtons.OK);
		  }
		  else
					MessageBox.Show("Verify failed","Warn",MessageBoxButtons.OK);
		}
		else if(FMatchType==2)
		{

		ID=axZKFPEngX1.IdentificationInFPCacheDB(fpcHandle,e.aTemplate,ref score,ref processedFPNumber);
		   tempstr="Verify Success! FingerNum is "+ID.ToString();
			MessageBox.Show(tempstr,"Warn",MessageBoxButtons.OK);
		}



		 }
		}
		
		private void button4_Click(object sender, System.EventArgs e)
		{
			if(axZKFPEngX1.IsRegister) axZKFPEngX1.CancelEnroll();
			axZKFPEngX1.BeginCapture();
			FMatchType=1;
		}
		
		private void button5_Click(object sender, System.EventArgs e)
		{
		if(axZKFPEngX1.IsRegister) axZKFPEngX1.CancelEnroll();
			axZKFPEngX1.BeginCapture();
			FMatchType=2;
		}
		
		private void axZKFPEngX1_OnFeatureInfo(object sender, AxZKFPEngXControl.IZKFPEngXEvents_OnFeatureInfoEvent e)
		{
		String sTemp="";
		int j=0;
		if (axZKFPEngX1.IsRegister)
		{
		j=axZKFPEngX1.EnrollIndex-1;
		sTemp="Register status: still press finger " + j.ToString() + " times!";
		}
	 sTemp=sTemp + " Fingerprint quality";
  if (e.aQuality!=0)
	 sTemp=sTemp+ " not good";
  else
	 sTemp=sTemp+" good";

			statusBar1.Panels[0].Text=sTemp;
		}

		private void WinForm_Closed(object sender, System.EventArgs e)
		{
			axZKFPEngX1.FreeFPCacheDB(fpcHandle);
		}

			}
}
