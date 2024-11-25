#pragma once


namespace vc {

	using namespace System;
	using namespace System::IO ;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::Text ;
	

	/// <summary>
	/// Form1 摘要
	///
	/// 警告: 如果更改此类的名称，则需要更改
	///          与此类所依赖的所有 .resx 文件关联的托管资源编译器工具的
	///          “资源文件名”属性。否则，
	///          设计器将不能与此窗体的关联
	///          本地化资源正确交互。
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: 在此处添加构造函数代码
			//
		}

	protected:
		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TextBox^  textBox1;
	protected: 
	private: System::Windows::Forms::Button^  button1;
	private: Axzkemkeeper::AxCZKEM^  axCZKEM1;
	private:bool connect1;
	private: System::Windows::Forms::Label^  label1;

	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::TextBox^  textBox2;
	private: System::Windows::Forms::RadioButton^  radioButton1;
	private: System::Windows::Forms::RadioButton^  radioButton2;
	private: System::Windows::Forms::ComboBox^  comboBox1;
	private: System::Windows::Forms::ComboBox^  comboBox2;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::StatusStrip^  statusStrip1;
	private: System::Windows::Forms::ToolStripStatusLabel^  toolStripStatusLabel1;
	private: System::Windows::Forms::ToolStripStatusLabel^  toolStripStatusLabel2;
	private: System::Windows::Forms::TabControl^  tabControl1;
	private: System::Windows::Forms::TabPage^  tabPage1;
	private: System::Windows::Forms::TabPage^  tabPage2;
	private: System::Windows::Forms::TabPage^  tabPage3;
	private: System::Windows::Forms::ListView^  listView1;
	private: System::Windows::Forms::GroupBox^  groupBox1;
	private: System::Windows::Forms::Button^  button3;
	private: System::Windows::Forms::Button^  button2;
	private: System::Windows::Forms::Button^  button4;
	private: System::Windows::Forms::GroupBox^  groupBox2;
	private: System::Windows::Forms::Label^  label7;
	private: System::Windows::Forms::Label^  label6;
	private: System::Windows::Forms::Label^  label5;
	private: System::Windows::Forms::TextBox^  textBox5;
	private: System::Windows::Forms::TextBox^  textBox4;
	private: System::Windows::Forms::TextBox^  textBox3;
	private: System::Windows::Forms::ColumnHeader^  columnHeader1;
	private: System::Windows::Forms::ListView^  listView2;
	private: System::Windows::Forms::GroupBox^  groupBox3;
	private: System::Windows::Forms::Label^  label11;
	private: System::Windows::Forms::Label^  label10;
	private: System::Windows::Forms::Label^  label9;
	private: System::Windows::Forms::Label^  label8;
	private: System::Windows::Forms::CheckBox^  checkBox1;
	private: System::Windows::Forms::ComboBox^  comboBox3;
	private: System::Windows::Forms::TextBox^  textBox8;
	private: System::Windows::Forms::TextBox^  textBox7;
	private: System::Windows::Forms::TextBox^  textBox6;
	private: System::Windows::Forms::PictureBox^  pictureBox1;
	private: System::Windows::Forms::Button^  button10;
	private: System::Windows::Forms::Button^  button9;
	private: System::Windows::Forms::Button^  button8;
	private: System::Windows::Forms::Button^  button7;
	private: System::Windows::Forms::Button^  button6;
	private: System::Windows::Forms::Button^  button5;
	private: System::Windows::Forms::GroupBox^  groupBox6;
	private: System::Windows::Forms::GroupBox^  groupBox5;
	private: System::Windows::Forms::GroupBox^  groupBox4;
	private: System::Windows::Forms::Label^  label13;
	private: System::Windows::Forms::Label^  label12;
	private: System::Windows::Forms::TextBox^  textBox9;
	private: System::Windows::Forms::ComboBox^  comboBox4;
	private: System::Windows::Forms::Label^  label17;
	private: System::Windows::Forms::Button^  button12;
	private: System::Windows::Forms::TextBox^  textBox13;
	private: System::Windows::Forms::TextBox^  textBox12;
	private: System::Windows::Forms::Label^  label16;
	private: System::Windows::Forms::Label^  label15;
	private: System::Windows::Forms::Button^  button11;
	private: System::Windows::Forms::TextBox^  textBox11;
	private: System::Windows::Forms::TextBox^  textBox10;
	private: System::Windows::Forms::Label^  label14;
	private: System::Windows::Forms::TextBox^  textBox19;
	private: System::Windows::Forms::TextBox^  textBox18;
	private: System::Windows::Forms::TextBox^  textBox17;
	private: System::Windows::Forms::TextBox^  textBox16;
	private: System::Windows::Forms::TextBox^  textBox15;
	private: System::Windows::Forms::TextBox^  textBox14;
	private: System::Windows::Forms::Label^  label22;
	private: System::Windows::Forms::Label^  label21;
	private: System::Windows::Forms::Label^  label20;
	private: System::Windows::Forms::Label^  label19;
	private: System::Windows::Forms::Label^  label18;
private: System::Windows::Forms::Button^  button16;
private: System::Windows::Forms::Button^  button15;
private: System::Windows::Forms::Button^  button14;
private: System::Windows::Forms::Button^  button13;
private: System::Windows::Forms::ColumnHeader^  columnHeader2;
private: System::Windows::Forms::ColumnHeader^  columnHeader3;
private: System::Windows::Forms::ColumnHeader^  columnHeader4;
private: System::Windows::Forms::ColumnHeader^  columnHeader5;
private: System::Windows::Forms::ColumnHeader^  columnHeader6;

private:bool _settingChanged;
private:bool _ipAddressChanged;
private:bool		_deviceTimeChanged;
private: System::Windows::Forms::OpenFileDialog^  openFileDialog1;
private: System::Windows::Forms::TabPage^  tabPage4;
private: System::Windows::Forms::Button^  button17;
private: System::Windows::Forms::Button^  button18;
private: System::Windows::Forms::TextBox^  textBox20;
private: System::Windows::Forms::Button^  button19;
private: System::Windows::Forms::Button^  button20;
private: System::Windows::Forms::Button^  button21;
private: System::Windows::Forms::Button^  button22;
private: System::Windows::Forms::GroupBox^  groupBox7;
private: System::Windows::Forms::GroupBox^  groupBox8;
private: System::Windows::Forms::Button^  button23;













	private:
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(Form1::typeid));
			System::Windows::Forms::ListViewGroup^  listViewGroup1 = (gcnew System::Windows::Forms::ListViewGroup(L"ListViewGroup", System::Windows::Forms::HorizontalAlignment::Left));
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->axCZKEM1 = (gcnew Axzkemkeeper::AxCZKEM());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->radioButton1 = (gcnew System::Windows::Forms::RadioButton());
			this->radioButton2 = (gcnew System::Windows::Forms::RadioButton());
			this->comboBox1 = (gcnew System::Windows::Forms::ComboBox());
			this->comboBox2 = (gcnew System::Windows::Forms::ComboBox());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->statusStrip1 = (gcnew System::Windows::Forms::StatusStrip());
			this->toolStripStatusLabel1 = (gcnew System::Windows::Forms::ToolStripStatusLabel());
			this->toolStripStatusLabel2 = (gcnew System::Windows::Forms::ToolStripStatusLabel());
			this->tabControl1 = (gcnew System::Windows::Forms::TabControl());
			this->tabPage1 = (gcnew System::Windows::Forms::TabPage());
			this->groupBox2 = (gcnew System::Windows::Forms::GroupBox());
			this->textBox5 = (gcnew System::Windows::Forms::TextBox());
			this->textBox4 = (gcnew System::Windows::Forms::TextBox());
			this->textBox3 = (gcnew System::Windows::Forms::TextBox());
			this->label7 = (gcnew System::Windows::Forms::Label());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->groupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->button4 = (gcnew System::Windows::Forms::Button());
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->listView1 = (gcnew System::Windows::Forms::ListView());
			this->columnHeader1 = (gcnew System::Windows::Forms::ColumnHeader());
			this->tabPage2 = (gcnew System::Windows::Forms::TabPage());
			this->groupBox3 = (gcnew System::Windows::Forms::GroupBox());
			this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			this->button10 = (gcnew System::Windows::Forms::Button());
			this->button9 = (gcnew System::Windows::Forms::Button());
			this->button8 = (gcnew System::Windows::Forms::Button());
			this->button7 = (gcnew System::Windows::Forms::Button());
			this->button6 = (gcnew System::Windows::Forms::Button());
			this->button5 = (gcnew System::Windows::Forms::Button());
			this->checkBox1 = (gcnew System::Windows::Forms::CheckBox());
			this->comboBox3 = (gcnew System::Windows::Forms::ComboBox());
			this->textBox8 = (gcnew System::Windows::Forms::TextBox());
			this->textBox7 = (gcnew System::Windows::Forms::TextBox());
			this->textBox6 = (gcnew System::Windows::Forms::TextBox());
			this->label11 = (gcnew System::Windows::Forms::Label());
			this->label10 = (gcnew System::Windows::Forms::Label());
			this->label9 = (gcnew System::Windows::Forms::Label());
			this->label8 = (gcnew System::Windows::Forms::Label());
			this->listView2 = (gcnew System::Windows::Forms::ListView());
			this->columnHeader2 = (gcnew System::Windows::Forms::ColumnHeader());
			this->columnHeader3 = (gcnew System::Windows::Forms::ColumnHeader());
			this->columnHeader4 = (gcnew System::Windows::Forms::ColumnHeader());
			this->columnHeader5 = (gcnew System::Windows::Forms::ColumnHeader());
			this->columnHeader6 = (gcnew System::Windows::Forms::ColumnHeader());
			this->tabPage3 = (gcnew System::Windows::Forms::TabPage());
			this->button16 = (gcnew System::Windows::Forms::Button());
			this->button15 = (gcnew System::Windows::Forms::Button());
			this->button14 = (gcnew System::Windows::Forms::Button());
			this->button13 = (gcnew System::Windows::Forms::Button());
			this->groupBox6 = (gcnew System::Windows::Forms::GroupBox());
			this->textBox19 = (gcnew System::Windows::Forms::TextBox());
			this->textBox18 = (gcnew System::Windows::Forms::TextBox());
			this->textBox17 = (gcnew System::Windows::Forms::TextBox());
			this->textBox16 = (gcnew System::Windows::Forms::TextBox());
			this->textBox15 = (gcnew System::Windows::Forms::TextBox());
			this->textBox14 = (gcnew System::Windows::Forms::TextBox());
			this->label22 = (gcnew System::Windows::Forms::Label());
			this->label21 = (gcnew System::Windows::Forms::Label());
			this->label20 = (gcnew System::Windows::Forms::Label());
			this->label19 = (gcnew System::Windows::Forms::Label());
			this->label18 = (gcnew System::Windows::Forms::Label());
			this->label17 = (gcnew System::Windows::Forms::Label());
			this->groupBox5 = (gcnew System::Windows::Forms::GroupBox());
			this->button12 = (gcnew System::Windows::Forms::Button());
			this->textBox13 = (gcnew System::Windows::Forms::TextBox());
			this->textBox12 = (gcnew System::Windows::Forms::TextBox());
			this->label16 = (gcnew System::Windows::Forms::Label());
			this->label15 = (gcnew System::Windows::Forms::Label());
			this->groupBox4 = (gcnew System::Windows::Forms::GroupBox());
			this->button11 = (gcnew System::Windows::Forms::Button());
			this->textBox11 = (gcnew System::Windows::Forms::TextBox());
			this->textBox10 = (gcnew System::Windows::Forms::TextBox());
			this->label14 = (gcnew System::Windows::Forms::Label());
			this->label13 = (gcnew System::Windows::Forms::Label());
			this->label12 = (gcnew System::Windows::Forms::Label());
			this->textBox9 = (gcnew System::Windows::Forms::TextBox());
			this->comboBox4 = (gcnew System::Windows::Forms::ComboBox());
			this->tabPage4 = (gcnew System::Windows::Forms::TabPage());
			this->groupBox8 = (gcnew System::Windows::Forms::GroupBox());
			this->textBox20 = (gcnew System::Windows::Forms::TextBox());
			this->button19 = (gcnew System::Windows::Forms::Button());
			this->button18 = (gcnew System::Windows::Forms::Button());
			this->groupBox7 = (gcnew System::Windows::Forms::GroupBox());
			this->button23 = (gcnew System::Windows::Forms::Button());
			this->button17 = (gcnew System::Windows::Forms::Button());
			this->button21 = (gcnew System::Windows::Forms::Button());
			this->button22 = (gcnew System::Windows::Forms::Button());
			this->button20 = (gcnew System::Windows::Forms::Button());
			this->openFileDialog1 = (gcnew System::Windows::Forms::OpenFileDialog());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->axCZKEM1))->BeginInit();
			this->statusStrip1->SuspendLayout();
			this->tabControl1->SuspendLayout();
			this->tabPage1->SuspendLayout();
			this->groupBox2->SuspendLayout();
			this->groupBox1->SuspendLayout();
			this->tabPage2->SuspendLayout();
			this->groupBox3->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox1))->BeginInit();
			this->tabPage3->SuspendLayout();
			this->groupBox6->SuspendLayout();
			this->groupBox5->SuspendLayout();
			this->groupBox4->SuspendLayout();
			this->tabPage4->SuspendLayout();
			this->groupBox8->SuspendLayout();
			this->groupBox7->SuspendLayout();
			this->SuspendLayout();
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(198, 12);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(100, 21);
			this->textBox1->TabIndex = 0;
			this->textBox1->Text = L"192.168.1.225";
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(470, 12);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(116, 52);
			this->button1->TabIndex = 1;
			this->button1->Text = L"Connect";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Form1::button1_Click);
			// 
			// axCZKEM1
			// 
			this->axCZKEM1->Enabled = true;
			this->axCZKEM1->Location = System::Drawing::Point(539, 55);
			this->axCZKEM1->Name = L"axCZKEM1";
			this->axCZKEM1->OcxState = (cli::safe_cast<System::Windows::Forms::AxHost::State^  >(resources->GetObject(L"axCZKEM1.OcxState")));
			this->axCZKEM1->Size = System::Drawing::Size(48, 41);
			this->axCZKEM1->TabIndex = 2;
			this->axCZKEM1->Visible = false;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(121, 15);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(71, 12);
			this->label1->TabIndex = 3;
			this->label1->Text = L"IP Address:";
			this->label1->Click += gcnew System::EventHandler(this, &Form1::label1_Click);
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(305, 15);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(41, 12);
			this->label3->TabIndex = 5;
			this->label3->Text = L"Port：";
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(369, 12);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(82, 21);
			this->textBox2->TabIndex = 6;
			this->textBox2->Text = L"4370";
			// 
			// radioButton1
			// 
			this->radioButton1->AutoSize = true;
			this->radioButton1->Checked = true;
			this->radioButton1->Location = System::Drawing::Point(12, 12);
			this->radioButton1->Name = L"radioButton1";
			this->radioButton1->Size = System::Drawing::Size(71, 16);
			this->radioButton1->TabIndex = 7;
			this->radioButton1->TabStop = true;
			this->radioButton1->Text = L"Ethernet";
			this->radioButton1->UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this->radioButton2->AutoSize = true;
			this->radioButton2->Location = System::Drawing::Point(12, 44);
			this->radioButton2->Name = L"radioButton2";
			this->radioButton2->Size = System::Drawing::Size(89, 16);
			this->radioButton2->TabIndex = 8;
			this->radioButton2->Text = L"Com Connect";
			this->radioButton2->UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this->comboBox1->FormattingEnabled = true;
			this->comboBox1->Items->AddRange(gcnew cli::array< System::Object^  >(4) {L"1", L"2", L"3", L"4"});
			this->comboBox1->Location = System::Drawing::Point(198, 44);
			this->comboBox1->Name = L"comboBox1";
			this->comboBox1->Size = System::Drawing::Size(100, 20);
			this->comboBox1->TabIndex = 9;
			this->comboBox1->Text = L"1";
			// 
			// comboBox2
			// 
			this->comboBox2->FormattingEnabled = true;
			this->comboBox2->Items->AddRange(gcnew cli::array< System::Object^  >(8) {L"1200", L"2400", L"4800", L"9600", L"19200", L"38400", 
				L"57600", L"115200"});
			this->comboBox2->Location = System::Drawing::Point(369, 44);
			this->comboBox2->Name = L"comboBox2";
			this->comboBox2->Size = System::Drawing::Size(82, 20);
			this->comboBox2->TabIndex = 10;
			this->comboBox2->Text = L"115200";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(121, 48);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(71, 12);
			this->label2->TabIndex = 11;
			this->label2->Text = L"Com Number:";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(305, 48);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(59, 12);
			this->label4->TabIndex = 12;
			this->label4->Text = L"BaudRate:";
			// 
			// statusStrip1
			// 
			this->statusStrip1->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(2) {this->toolStripStatusLabel1, 
				this->toolStripStatusLabel2});
			this->statusStrip1->Location = System::Drawing::Point(0, 390);
			this->statusStrip1->Name = L"statusStrip1";
			this->statusStrip1->Size = System::Drawing::Size(595, 24);
			this->statusStrip1->TabIndex = 13;
			this->statusStrip1->Text = L"statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this->toolStripStatusLabel1->Font = (gcnew System::Drawing::Font(L"Tahoma", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point, 
				static_cast<System::Byte>(0)));
			this->toolStripStatusLabel1->ForeColor = System::Drawing::Color::Red;
			this->toolStripStatusLabel1->Name = L"toolStripStatusLabel1";
			this->toolStripStatusLabel1->Size = System::Drawing::Size(158, 19);
			this->toolStripStatusLabel1->Text = L"toolStripStatusLabel1";
			// 
			// toolStripStatusLabel2
			// 
			this->toolStripStatusLabel2->Name = L"toolStripStatusLabel2";
			this->toolStripStatusLabel2->Size = System::Drawing::Size(0, 19);
			// 
			// tabControl1
			// 
			this->tabControl1->Controls->Add(this->tabPage1);
			this->tabControl1->Controls->Add(this->tabPage2);
			this->tabControl1->Controls->Add(this->tabPage3);
			this->tabControl1->Controls->Add(this->tabPage4);
			this->tabControl1->Location = System::Drawing::Point(0, 81);
			this->tabControl1->Name = L"tabControl1";
			this->tabControl1->SelectedIndex = 0;
			this->tabControl1->Size = System::Drawing::Size(593, 306);
			this->tabControl1->TabIndex = 14;
			this->tabControl1->SelectedIndexChanged += gcnew System::EventHandler(this, &Form1::tab_selectedIndexChanged);
			// 
			// tabPage1
			// 
			this->tabPage1->Controls->Add(this->groupBox2);
			this->tabPage1->Controls->Add(this->groupBox1);
			this->tabPage1->Controls->Add(this->listView1);
			this->tabPage1->Location = System::Drawing::Point(4, 21);
			this->tabPage1->Name = L"tabPage1";
			this->tabPage1->Padding = System::Windows::Forms::Padding(3);
			this->tabPage1->Size = System::Drawing::Size(585, 281);
			this->tabPage1->TabIndex = 0;
			this->tabPage1->Text = L"Data Collection";
			this->tabPage1->UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this->groupBox2->Controls->Add(this->textBox5);
			this->groupBox2->Controls->Add(this->textBox4);
			this->groupBox2->Controls->Add(this->textBox3);
			this->groupBox2->Controls->Add(this->label7);
			this->groupBox2->Controls->Add(this->label6);
			this->groupBox2->Controls->Add(this->label5);
			this->groupBox2->Location = System::Drawing::Point(255, 139);
			this->groupBox2->Name = L"groupBox2";
			this->groupBox2->Size = System::Drawing::Size(311, 136);
			this->groupBox2->TabIndex = 2;
			this->groupBox2->TabStop = false;
			this->groupBox2->Text = L"Transaction Information";
			// 
			// textBox5
			// 
			this->textBox5->Location = System::Drawing::Point(119, 90);
			this->textBox5->Name = L"textBox5";
			this->textBox5->Size = System::Drawing::Size(173, 21);
			this->textBox5->TabIndex = 7;
			// 
			// textBox4
			// 
			this->textBox4->Location = System::Drawing::Point(119, 57);
			this->textBox4->Name = L"textBox4";
			this->textBox4->Size = System::Drawing::Size(142, 21);
			this->textBox4->TabIndex = 6;
			// 
			// textBox3
			// 
			this->textBox3->Location = System::Drawing::Point(119, 20);
			this->textBox3->Name = L"textBox3";
			this->textBox3->Size = System::Drawing::Size(111, 21);
			this->textBox3->TabIndex = 3;
			// 
			// label7
			// 
			this->label7->AutoSize = true;
			this->label7->Location = System::Drawing::Point(6, 99);
			this->label7->Name = L"label7";
			this->label7->Size = System::Drawing::Size(107, 12);
			this->label7->TabIndex = 5;
			this->label7->Text = L"Transaction Date:";
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Location = System::Drawing::Point(6, 60);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(89, 12);
			this->label6->TabIndex = 4;
			this->label6->Text = L"Verify Method:";
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(6, 27);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(53, 12);
			this->label5->TabIndex = 3;
			this->label5->Text = L"User ID:";
			// 
			// groupBox1
			// 
			this->groupBox1->Controls->Add(this->button4);
			this->groupBox1->Controls->Add(this->button3);
			this->groupBox1->Controls->Add(this->button2);
			this->groupBox1->Location = System::Drawing::Point(255, 18);
			this->groupBox1->Name = L"groupBox1";
			this->groupBox1->Size = System::Drawing::Size(311, 115);
			this->groupBox1->TabIndex = 1;
			this->groupBox1->TabStop = false;
			this->groupBox1->Text = L"Data Collection Controls";
			// 
			// button4
			// 
			this->button4->Location = System::Drawing::Point(176, 70);
			this->button4->Name = L"button4";
			this->button4->Size = System::Drawing::Size(116, 23);
			this->button4->TabIndex = 3;
			this->button4->Text = L"Clear Data";
			this->button4->UseVisualStyleBackColor = true;
			this->button4->Click += gcnew System::EventHandler(this, &Form1::button4_Click);
			// 
			// button3
			// 
			this->button3->Location = System::Drawing::Point(29, 70);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(116, 23);
			this->button3->TabIndex = 2;
			this->button3->Text = L"Clear Punches";
			this->button3->UseVisualStyleBackColor = true;
			this->button3->Click += gcnew System::EventHandler(this, &Form1::button3_Click);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(29, 29);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(116, 23);
			this->button2->TabIndex = 0;
			this->button2->Text = L"Upload Punches";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &Form1::button2_Click);
			// 
			// listView1
			// 
			this->listView1->Columns->AddRange(gcnew cli::array< System::Windows::Forms::ColumnHeader^  >(1) {this->columnHeader1});
			listViewGroup1->Header = L"ListViewGroup";
			listViewGroup1->Name = L"listViewGroup1";
			this->listView1->Groups->AddRange(gcnew cli::array< System::Windows::Forms::ListViewGroup^  >(1) {listViewGroup1});
			this->listView1->Location = System::Drawing::Point(6, 6);
			this->listView1->Name = L"listView1";
			this->listView1->Size = System::Drawing::Size(243, 269);
			this->listView1->TabIndex = 0;
			this->listView1->UseCompatibleStateImageBehavior = false;
			this->listView1->View = System::Windows::Forms::View::Details;
			this->listView1->SelectedIndexChanged += gcnew System::EventHandler(this, &Form1::listView1_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this->columnHeader1->Text = L"Transaction Data";
			this->columnHeader1->Width = 5000;
			// 
			// tabPage2
			// 
			this->tabPage2->Controls->Add(this->groupBox3);
			this->tabPage2->Controls->Add(this->listView2);
			this->tabPage2->Location = System::Drawing::Point(4, 21);
			this->tabPage2->Name = L"tabPage2";
			this->tabPage2->Padding = System::Windows::Forms::Padding(3);
			this->tabPage2->Size = System::Drawing::Size(585, 281);
			this->tabPage2->TabIndex = 1;
			this->tabPage2->Text = L"User Management";
			this->tabPage2->UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this->groupBox3->Controls->Add(this->pictureBox1);
			this->groupBox3->Controls->Add(this->button10);
			this->groupBox3->Controls->Add(this->button9);
			this->groupBox3->Controls->Add(this->button8);
			this->groupBox3->Controls->Add(this->button7);
			this->groupBox3->Controls->Add(this->button6);
			this->groupBox3->Controls->Add(this->button5);
			this->groupBox3->Controls->Add(this->checkBox1);
			this->groupBox3->Controls->Add(this->comboBox3);
			this->groupBox3->Controls->Add(this->textBox8);
			this->groupBox3->Controls->Add(this->textBox7);
			this->groupBox3->Controls->Add(this->textBox6);
			this->groupBox3->Controls->Add(this->label11);
			this->groupBox3->Controls->Add(this->label10);
			this->groupBox3->Controls->Add(this->label9);
			this->groupBox3->Controls->Add(this->label8);
			this->groupBox3->Location = System::Drawing::Point(294, 6);
			this->groupBox3->Name = L"groupBox3";
			this->groupBox3->Size = System::Drawing::Size(285, 272);
			this->groupBox3->TabIndex = 1;
			this->groupBox3->TabStop = false;
			this->groupBox3->Text = L"User Information";
			// 
			// pictureBox1
			// 
			this->pictureBox1->Location = System::Drawing::Point(144, 151);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(133, 115);
			this->pictureBox1->TabIndex = 15;
			this->pictureBox1->TabStop = false;
			// 
			// button10
			// 
			this->button10->Location = System::Drawing::Point(173, 80);
			this->button10->Name = L"button10";
			this->button10->Size = System::Drawing::Size(104, 43);
			this->button10->TabIndex = 14;
			this->button10->Text = L"Capture Fingerprint";
			this->button10->UseVisualStyleBackColor = true;
			this->button10->Click += gcnew System::EventHandler(this, &Form1::button10_Click);
			// 
			// button9
			// 
			this->button9->Location = System::Drawing::Point(174, 48);
			this->button9->Name = L"button9";
			this->button9->Size = System::Drawing::Size(104, 23);
			this->button9->TabIndex = 13;
			this->button9->Text = L"Delete User";
			this->button9->UseVisualStyleBackColor = true;
			this->button9->Click += gcnew System::EventHandler(this, &Form1::button9_Click);
			// 
			// button8
			// 
			this->button8->Location = System::Drawing::Point(173, 15);
			this->button8->Name = L"button8";
			this->button8->Size = System::Drawing::Size(104, 23);
			this->button8->TabIndex = 12;
			this->button8->Text = L"Set User Info";
			this->button8->UseVisualStyleBackColor = true;
			this->button8->Click += gcnew System::EventHandler(this, &Form1::button8_Click);
			// 
			// button7
			// 
			this->button7->Location = System::Drawing::Point(10, 237);
			this->button7->Name = L"button7";
			this->button7->Size = System::Drawing::Size(115, 23);
			this->button7->TabIndex = 11;
			this->button7->Text = L"Delete Templates";
			this->button7->UseVisualStyleBackColor = true;
			this->button7->Click += gcnew System::EventHandler(this, &Form1::button7_Click);
			// 
			// button6
			// 
			this->button6->Location = System::Drawing::Point(10, 195);
			this->button6->Name = L"button6";
			this->button6->Size = System::Drawing::Size(115, 23);
			this->button6->TabIndex = 10;
			this->button6->Text = L"Load Template";
			this->button6->UseVisualStyleBackColor = true;
			this->button6->Click += gcnew System::EventHandler(this, &Form1::button6_Click);
			// 
			// button5
			// 
			this->button5->Location = System::Drawing::Point(11, 151);
			this->button5->Name = L"button5";
			this->button5->Size = System::Drawing::Size(115, 23);
			this->button5->TabIndex = 9;
			this->button5->Text = L"Upload Template";
			this->button5->UseVisualStyleBackColor = true;
			this->button5->Click += gcnew System::EventHandler(this, &Form1::button5_Click);
			// 
			// checkBox1
			// 
			this->checkBox1->AutoSize = true;
			this->checkBox1->Location = System::Drawing::Point(166, 129);
			this->checkBox1->Name = L"checkBox1";
			this->checkBox1->Size = System::Drawing::Size(84, 16);
			this->checkBox1->TabIndex = 8;
			this->checkBox1->Text = L"Show Image";
			this->checkBox1->UseVisualStyleBackColor = true;
			// 
			// comboBox3
			// 
			this->comboBox3->FormattingEnabled = true;
			this->comboBox3->Items->AddRange(gcnew cli::array< System::Object^  >(4) {L"General User", L"Admin 1", L"Admin 2", L"Admin 3"});
			this->comboBox3->Location = System::Drawing::Point(68, 107);
			this->comboBox3->Name = L"comboBox3";
			this->comboBox3->Size = System::Drawing::Size(99, 20);
			this->comboBox3->TabIndex = 7;
			// 
			// textBox8
			// 
			this->textBox8->Location = System::Drawing::Point(67, 75);
			this->textBox8->Name = L"textBox8";
			this->textBox8->Size = System::Drawing::Size(100, 21);
			this->textBox8->TabIndex = 6;
			// 
			// textBox7
			// 
			this->textBox7->Location = System::Drawing::Point(67, 45);
			this->textBox7->Name = L"textBox7";
			this->textBox7->Size = System::Drawing::Size(100, 21);
			this->textBox7->TabIndex = 5;
			// 
			// textBox6
			// 
			this->textBox6->BackColor = System::Drawing::Color::Gainsboro;
			this->textBox6->Enabled = false;
			this->textBox6->ForeColor = System::Drawing::SystemColors::MenuText;
			this->textBox6->Location = System::Drawing::Point(66, 14);
			this->textBox6->Name = L"textBox6";
			this->textBox6->Size = System::Drawing::Size(101, 21);
			this->textBox6->TabIndex = 4;
			// 
			// label11
			// 
			this->label11->AutoSize = true;
			this->label11->Location = System::Drawing::Point(6, 109);
			this->label11->Name = L"label11";
			this->label11->Size = System::Drawing::Size(65, 12);
			this->label11->TabIndex = 3;
			this->label11->Text = L"Privilege:";
			// 
			// label10
			// 
			this->label10->AutoSize = true;
			this->label10->Location = System::Drawing::Point(6, 80);
			this->label10->Name = L"label10";
			this->label10->Size = System::Drawing::Size(59, 12);
			this->label10->TabIndex = 2;
			this->label10->Text = L"Password:";
			// 
			// label9
			// 
			this->label9->AutoSize = true;
			this->label9->Location = System::Drawing::Point(6, 51);
			this->label9->Name = L"label9";
			this->label9->Size = System::Drawing::Size(35, 12);
			this->label9->TabIndex = 1;
			this->label9->Text = L"Name:";
			// 
			// label8
			// 
			this->label8->AutoSize = true;
			this->label8->Location = System::Drawing::Point(6, 21);
			this->label8->Name = L"label8";
			this->label8->Size = System::Drawing::Size(53, 12);
			this->label8->TabIndex = 0;
			this->label8->Text = L"User ID:";
			// 
			// listView2
			// 
			this->listView2->Columns->AddRange(gcnew cli::array< System::Windows::Forms::ColumnHeader^  >(5) {this->columnHeader2, this->columnHeader3, 
				this->columnHeader4, this->columnHeader5, this->columnHeader6});
			this->listView2->Location = System::Drawing::Point(0, 3);
			this->listView2->Name = L"listView2";
			this->listView2->Size = System::Drawing::Size(291, 275);
			this->listView2->TabIndex = 0;
			this->listView2->UseCompatibleStateImageBehavior = false;
			this->listView2->View = System::Windows::Forms::View::Details;
			this->listView2->SelectedIndexChanged += gcnew System::EventHandler(this, &Form1::listView2_SelectedIndexChanged);
			// 
			// columnHeader2
			// 
			this->columnHeader2->Text = L"User ID";
			this->columnHeader2->Width = 59;
			// 
			// columnHeader3
			// 
			this->columnHeader3->Text = L"Name";
			this->columnHeader3->Width = 38;
			// 
			// columnHeader4
			// 
			this->columnHeader4->Text = L"PassWord";
			// 
			// columnHeader5
			// 
			this->columnHeader5->Text = L"Privilege";
			this->columnHeader5->Width = 69;
			// 
			// columnHeader6
			// 
			this->columnHeader6->Text = L"Enabled";
			// 
			// tabPage3
			// 
			this->tabPage3->Controls->Add(this->button16);
			this->tabPage3->Controls->Add(this->button15);
			this->tabPage3->Controls->Add(this->button14);
			this->tabPage3->Controls->Add(this->button13);
			this->tabPage3->Controls->Add(this->groupBox6);
			this->tabPage3->Controls->Add(this->groupBox5);
			this->tabPage3->Controls->Add(this->groupBox4);
			this->tabPage3->Location = System::Drawing::Point(4, 21);
			this->tabPage3->Name = L"tabPage3";
			this->tabPage3->Size = System::Drawing::Size(585, 281);
			this->tabPage3->TabIndex = 2;
			this->tabPage3->Text = L"Terminal Information";
			this->tabPage3->UseVisualStyleBackColor = true;
			// 
			// button16
			// 
			this->button16->Location = System::Drawing::Point(444, 210);
			this->button16->Name = L"button16";
			this->button16->Size = System::Drawing::Size(133, 23);
			this->button16->TabIndex = 4;
			this->button16->Text = L"Clear Administrators";
			this->button16->UseVisualStyleBackColor = true;
			this->button16->Click += gcnew System::EventHandler(this, &Form1::button16_Click);
			// 
			// button15
			// 
			this->button15->Location = System::Drawing::Point(445, 246);
			this->button15->Name = L"button15";
			this->button15->Size = System::Drawing::Size(133, 23);
			this->button15->TabIndex = 3;
			this->button15->Text = L"Clear Terminal";
			this->button15->UseVisualStyleBackColor = true;
			this->button15->Click += gcnew System::EventHandler(this, &Form1::button15_Click);
			// 
			// button14
			// 
			this->button14->Location = System::Drawing::Point(304, 246);
			this->button14->Name = L"button14";
			this->button14->Size = System::Drawing::Size(127, 23);
			this->button14->TabIndex = 2;
			this->button14->Text = L"Restore Terminal";
			this->button14->UseVisualStyleBackColor = true;
			this->button14->Click += gcnew System::EventHandler(this, &Form1::button14_Click);
			// 
			// button13
			// 
			this->button13->Location = System::Drawing::Point(305, 209);
			this->button13->Name = L"button13";
			this->button13->Size = System::Drawing::Size(127, 23);
			this->button13->TabIndex = 1;
			this->button13->Text = L"Backup Terminal";
			this->button13->UseVisualStyleBackColor = true;
			this->button13->Click += gcnew System::EventHandler(this, &Form1::button13_Click);
			// 
			// groupBox6
			// 
			this->groupBox6->Controls->Add(this->textBox19);
			this->groupBox6->Controls->Add(this->textBox18);
			this->groupBox6->Controls->Add(this->textBox17);
			this->groupBox6->Controls->Add(this->textBox16);
			this->groupBox6->Controls->Add(this->textBox15);
			this->groupBox6->Controls->Add(this->textBox14);
			this->groupBox6->Controls->Add(this->label22);
			this->groupBox6->Controls->Add(this->label21);
			this->groupBox6->Controls->Add(this->label20);
			this->groupBox6->Controls->Add(this->label19);
			this->groupBox6->Controls->Add(this->label18);
			this->groupBox6->Controls->Add(this->label17);
			this->groupBox6->Location = System::Drawing::Point(312, 3);
			this->groupBox6->Name = L"groupBox6";
			this->groupBox6->Size = System::Drawing::Size(257, 194);
			this->groupBox6->TabIndex = 0;
			this->groupBox6->TabStop = false;
			this->groupBox6->Text = L"Totals";
			// 
			// textBox19
			// 
			this->textBox19->BackColor = System::Drawing::Color::Gainsboro;
			this->textBox19->Enabled = false;
			this->textBox19->Location = System::Drawing::Point(111, 162);
			this->textBox19->Name = L"textBox19";
			this->textBox19->Size = System::Drawing::Size(100, 21);
			this->textBox19->TabIndex = 12;
			// 
			// textBox18
			// 
			this->textBox18->BackColor = System::Drawing::Color::Gainsboro;
			this->textBox18->Enabled = false;
			this->textBox18->Location = System::Drawing::Point(111, 133);
			this->textBox18->Name = L"textBox18";
			this->textBox18->Size = System::Drawing::Size(100, 21);
			this->textBox18->TabIndex = 11;
			// 
			// textBox17
			// 
			this->textBox17->BackColor = System::Drawing::Color::Gainsboro;
			this->textBox17->Enabled = false;
			this->textBox17->Location = System::Drawing::Point(111, 102);
			this->textBox17->Name = L"textBox17";
			this->textBox17->Size = System::Drawing::Size(100, 21);
			this->textBox17->TabIndex = 10;
			// 
			// textBox16
			// 
			this->textBox16->BackColor = System::Drawing::Color::Gainsboro;
			this->textBox16->Enabled = false;
			this->textBox16->Location = System::Drawing::Point(111, 70);
			this->textBox16->Name = L"textBox16";
			this->textBox16->Size = System::Drawing::Size(100, 21);
			this->textBox16->TabIndex = 9;
			// 
			// textBox15
			// 
			this->textBox15->BackColor = System::Drawing::Color::Gainsboro;
			this->textBox15->Enabled = false;
			this->textBox15->Location = System::Drawing::Point(111, 41);
			this->textBox15->Name = L"textBox15";
			this->textBox15->Size = System::Drawing::Size(100, 21);
			this->textBox15->TabIndex = 8;
			// 
			// textBox14
			// 
			this->textBox14->BackColor = System::Drawing::Color::Gainsboro;
			this->textBox14->Enabled = false;
			this->textBox14->Location = System::Drawing::Point(111, 12);
			this->textBox14->Name = L"textBox14";
			this->textBox14->Size = System::Drawing::Size(100, 21);
			this->textBox14->TabIndex = 7;
			// 
			// label22
			// 
			this->label22->AutoSize = true;
			this->label22->Location = System::Drawing::Point(6, 167);
			this->label22->Name = L"label22";
			this->label22->Size = System::Drawing::Size(77, 12);
			this->label22->TabIndex = 6;
			this->label22->Text = L"Transactions";
			// 
			// label21
			// 
			this->label21->AutoSize = true;
			this->label21->Location = System::Drawing::Point(6, 139);
			this->label21->Name = L"label21";
			this->label21->Size = System::Drawing::Size(65, 12);
			this->label21->TabIndex = 5;
			this->label21->Text = L"Admin Logs";
			// 
			// label20
			// 
			this->label20->AutoSize = true;
			this->label20->Location = System::Drawing::Point(6, 109);
			this->label20->Name = L"label20";
			this->label20->Size = System::Drawing::Size(59, 12);
			this->label20->TabIndex = 4;
			this->label20->Text = L"Passwords";
			// 
			// label19
			// 
			this->label19->AutoSize = true;
			this->label19->Location = System::Drawing::Point(6, 78);
			this->label19->Name = L"label19";
			this->label19->Size = System::Drawing::Size(59, 12);
			this->label19->TabIndex = 3;
			this->label19->Text = L"Templates";
			// 
			// label18
			// 
			this->label18->AutoSize = true;
			this->label18->Location = System::Drawing::Point(6, 49);
			this->label18->Name = L"label18";
			this->label18->Size = System::Drawing::Size(35, 12);
			this->label18->TabIndex = 2;
			this->label18->Text = L"Users";
			// 
			// label17
			// 
			this->label17->AutoSize = true;
			this->label17->Location = System::Drawing::Point(6, 17);
			this->label17->Name = L"label17";
			this->label17->Size = System::Drawing::Size(89, 12);
			this->label17->TabIndex = 1;
			this->label17->Text = L"Administrators";
			// 
			// groupBox5
			// 
			this->groupBox5->Controls->Add(this->button12);
			this->groupBox5->Controls->Add(this->textBox13);
			this->groupBox5->Controls->Add(this->textBox12);
			this->groupBox5->Controls->Add(this->label16);
			this->groupBox5->Controls->Add(this->label15);
			this->groupBox5->Location = System::Drawing::Point(8, 148);
			this->groupBox5->Name = L"groupBox5";
			this->groupBox5->Size = System::Drawing::Size(292, 130);
			this->groupBox5->TabIndex = 0;
			this->groupBox5->TabStop = false;
			this->groupBox5->Text = L"Device Information";
			// 
			// button12
			// 
			this->button12->Location = System::Drawing::Point(118, 98);
			this->button12->Name = L"button12";
			this->button12->Size = System::Drawing::Size(154, 26);
			this->button12->TabIndex = 4;
			this->button12->Text = L"Update Firmware";
			this->button12->UseVisualStyleBackColor = true;
			this->button12->Click += gcnew System::EventHandler(this, &Form1::button12_Click);
			// 
			// textBox13
			// 
			this->textBox13->Location = System::Drawing::Point(118, 71);
			this->textBox13->Name = L"textBox13";
			this->textBox13->Size = System::Drawing::Size(154, 21);
			this->textBox13->TabIndex = 3;
			// 
			// textBox12
			// 
			this->textBox12->Location = System::Drawing::Point(118, 28);
			this->textBox12->Name = L"textBox12";
			this->textBox12->Size = System::Drawing::Size(154, 21);
			this->textBox12->TabIndex = 2;
			// 
			// label16
			// 
			this->label16->AutoSize = true;
			this->label16->Location = System::Drawing::Point(6, 73);
			this->label16->Name = L"label16";
			this->label16->Size = System::Drawing::Size(101, 12);
			this->label16->TabIndex = 1;
			this->label16->Text = L"Firmware Version";
			// 
			// label15
			// 
			this->label15->AutoSize = true;
			this->label15->Location = System::Drawing::Point(6, 32);
			this->label15->Name = L"label15";
			this->label15->Size = System::Drawing::Size(83, 12);
			this->label15->TabIndex = 0;
			this->label15->Text = L"Serial Number";
			// 
			// groupBox4
			// 
			this->groupBox4->Controls->Add(this->button11);
			this->groupBox4->Controls->Add(this->textBox11);
			this->groupBox4->Controls->Add(this->textBox10);
			this->groupBox4->Controls->Add(this->label14);
			this->groupBox4->Controls->Add(this->label13);
			this->groupBox4->Controls->Add(this->label12);
			this->groupBox4->Controls->Add(this->textBox9);
			this->groupBox4->Controls->Add(this->comboBox4);
			this->groupBox4->Location = System::Drawing::Point(8, 3);
			this->groupBox4->Name = L"groupBox4";
			this->groupBox4->Size = System::Drawing::Size(292, 139);
			this->groupBox4->TabIndex = 0;
			this->groupBox4->TabStop = false;
			this->groupBox4->Text = L"Terminal Setup";
			// 
			// button11
			// 
			this->button11->Location = System::Drawing::Point(124, 108);
			this->button11->Name = L"button11";
			this->button11->Size = System::Drawing::Size(143, 23);
			this->button11->TabIndex = 8;
			this->button11->Text = L"Update Terminal";
			this->button11->UseVisualStyleBackColor = true;
			this->button11->Click += gcnew System::EventHandler(this, &Form1::button11_Click);
			// 
			// textBox11
			// 
			this->textBox11->Location = System::Drawing::Point(83, 80);
			this->textBox11->Name = L"textBox11";
			this->textBox11->Size = System::Drawing::Size(184, 21);
			this->textBox11->TabIndex = 7;
			this->textBox11->TextChanged += gcnew System::EventHandler(this, &Form1::textBox11_TextChanged);
			// 
			// textBox10
			// 
			this->textBox10->Location = System::Drawing::Point(83, 50);
			this->textBox10->Name = L"textBox10";
			this->textBox10->Size = System::Drawing::Size(184, 21);
			this->textBox10->TabIndex = 6;
			this->textBox10->TextChanged += gcnew System::EventHandler(this, &Form1::textBox10_TextChanged);
			// 
			// label14
			// 
			this->label14->AutoSize = true;
			this->label14->Location = System::Drawing::Point(6, 88);
			this->label14->Name = L"label14";
			this->label14->Size = System::Drawing::Size(65, 12);
			this->label14->TabIndex = 5;
			this->label14->Text = L"IP Address";
			// 
			// label13
			// 
			this->label13->AutoSize = true;
			this->label13->Location = System::Drawing::Point(6, 55);
			this->label13->Name = L"label13";
			this->label13->Size = System::Drawing::Size(71, 12);
			this->label13->TabIndex = 4;
			this->label13->Text = L"Device Time";
			// 
			// label12
			// 
			this->label12->AutoSize = true;
			this->label12->Location = System::Drawing::Point(6, 23);
			this->label12->Name = L"label12";
			this->label12->Size = System::Drawing::Size(47, 12);
			this->label12->TabIndex = 3;
			this->label12->Text = L"Setting";
			// 
			// textBox9
			// 
			this->textBox9->Location = System::Drawing::Point(209, 20);
			this->textBox9->Name = L"textBox9";
			this->textBox9->Size = System::Drawing::Size(77, 21);
			this->textBox9->TabIndex = 2;
			this->textBox9->TextChanged += gcnew System::EventHandler(this, &Form1::textBox9_TextChanged);
			// 
			// comboBox4
			// 
			this->comboBox4->FormattingEnabled = true;
			this->comboBox4->Items->AddRange(gcnew cli::array< System::Object^  >(35) {L"Max Administrators", L"Machine Number", L"Language", 
				L"Auto Shutdown Time", L"Lock Open Control", L"Transaction Alarm", L"Admin Log Alarm", L"Minimum Log Interval", L"Baud Rate", 
				L"Parity", L"Stop Bits", L"Date Delimeter", L"Network Enabled", L"RS232 Enabled", L"RS485 Enabled", L"Voice Enabled", L"Identification Speed", 
				L"Idle Time", L"Shutdown Time", L"Power On Time", L"Sleep Time", L"Auto Bell", L"Match Threshold", L"Register Threshold", L"1:1 Threshold", 
				L"Show Score", L"Unlock Person Count", L"Only Verify Card", L"Net Speed", L"Must Register Card", L"Temp State Timeout", L"Input Number Timeout", 
				L"Menu Timeout", L"Date Format", L"Only 1:1"});
			this->comboBox4->Location = System::Drawing::Point(59, 20);
			this->comboBox4->Name = L"comboBox4";
			this->comboBox4->Size = System::Drawing::Size(144, 20);
			this->comboBox4->TabIndex = 1;
			this->comboBox4->SelectedIndexChanged += gcnew System::EventHandler(this, &Form1::comboBox4_SelectedIndexChanged);
			// 
			// tabPage4
			// 
			this->tabPage4->Controls->Add(this->groupBox8);
			this->tabPage4->Controls->Add(this->groupBox7);
			this->tabPage4->Location = System::Drawing::Point(4, 21);
			this->tabPage4->Name = L"tabPage4";
			this->tabPage4->Padding = System::Windows::Forms::Padding(3);
			this->tabPage4->Size = System::Drawing::Size(585, 281);
			this->tabPage4->TabIndex = 3;
			this->tabPage4->Text = L"  Options  ";
			this->tabPage4->UseVisualStyleBackColor = true;
			// 
			// groupBox8
			// 
			this->groupBox8->Controls->Add(this->textBox20);
			this->groupBox8->Controls->Add(this->button19);
			this->groupBox8->Controls->Add(this->button18);
			this->groupBox8->Location = System::Drawing::Point(245, 6);
			this->groupBox8->Name = L"groupBox8";
			this->groupBox8->Size = System::Drawing::Size(332, 269);
			this->groupBox8->TabIndex = 8;
			this->groupBox8->TabStop = false;
			this->groupBox8->Text = L"WriteLCD";
			// 
			// textBox20
			// 
			this->textBox20->Location = System::Drawing::Point(32, 27);
			this->textBox20->Multiline = true;
			this->textBox20->Name = L"textBox20";
			this->textBox20->Size = System::Drawing::Size(266, 151);
			this->textBox20->TabIndex = 3;
			this->textBox20->Text = L"A-B-C-D-E-F";
			// 
			// button19
			// 
			this->button19->Location = System::Drawing::Point(178, 198);
			this->button19->Name = L"button19";
			this->button19->Size = System::Drawing::Size(107, 46);
			this->button19->TabIndex = 2;
			this->button19->Text = L"WriteLCD";
			this->button19->UseVisualStyleBackColor = true;
			this->button19->Click += gcnew System::EventHandler(this, &Form1::button19_Click);
			// 
			// button18
			// 
			this->button18->Location = System::Drawing::Point(52, 198);
			this->button18->Name = L"button18";
			this->button18->Size = System::Drawing::Size(107, 46);
			this->button18->TabIndex = 1;
			this->button18->Text = L"ClearLCD";
			this->button18->UseVisualStyleBackColor = true;
			this->button18->Click += gcnew System::EventHandler(this, &Form1::button18_Click);
			// 
			// groupBox7
			// 
			this->groupBox7->Controls->Add(this->button23);
			this->groupBox7->Controls->Add(this->button17);
			this->groupBox7->Controls->Add(this->button21);
			this->groupBox7->Controls->Add(this->button22);
			this->groupBox7->Controls->Add(this->button20);
			this->groupBox7->Location = System::Drawing::Point(3, 3);
			this->groupBox7->Name = L"groupBox7";
			this->groupBox7->Size = System::Drawing::Size(233, 272);
			this->groupBox7->TabIndex = 7;
			this->groupBox7->TabStop = false;
			this->groupBox7->Text = L"Test Option";
			// 
			// button23
			// 
			this->button23->Location = System::Drawing::Point(45, 80);
			this->button23->Name = L"button23";
			this->button23->Size = System::Drawing::Size(95, 24);
			this->button23->TabIndex = 7;
			this->button23->Text = L"ClockOff";
			this->button23->UseVisualStyleBackColor = true;
			this->button23->Click += gcnew System::EventHandler(this, &Form1::button23_Click);
			// 
			// button17
			// 
			this->button17->Location = System::Drawing::Point(45, 33);
			this->button17->Name = L"button17";
			this->button17->Size = System::Drawing::Size(75, 23);
			this->button17->TabIndex = 0;
			this->button17->Text = L"Beep";
			this->button17->UseVisualStyleBackColor = true;
			this->button17->Click += gcnew System::EventHandler(this, &Form1::button17_Click);
			// 
			// button21
			// 
			this->button21->Location = System::Drawing::Point(45, 224);
			this->button21->Name = L"button21";
			this->button21->Size = System::Drawing::Size(116, 23);
			this->button21->TabIndex = 5;
			this->button21->Text = L"PlayVoice";
			this->button21->UseVisualStyleBackColor = true;
			this->button21->Click += gcnew System::EventHandler(this, &Form1::button21_Click);
			// 
			// button22
			// 
			this->button22->Location = System::Drawing::Point(45, 174);
			this->button22->Name = L"button22";
			this->button22->Size = System::Drawing::Size(116, 23);
			this->button22->TabIndex = 6;
			this->button22->Text = L"RestartDevice";
			this->button22->UseVisualStyleBackColor = true;
			this->button22->Click += gcnew System::EventHandler(this, &Form1::button22_Click);
			// 
			// button20
			// 
			this->button20->Location = System::Drawing::Point(45, 126);
			this->button20->Name = L"button20";
			this->button20->Size = System::Drawing::Size(116, 23);
			this->button20->TabIndex = 4;
			this->button20->Text = L"PowerOffDevice";
			this->button20->UseVisualStyleBackColor = true;
			this->button20->Click += gcnew System::EventHandler(this, &Form1::button20_Click);
			// 
			// openFileDialog1
			// 
			this->openFileDialog1->FileName = L"openFileDialog1";
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 12);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(595, 414);
			this->Controls->Add(this->axCZKEM1);
			this->Controls->Add(this->tabControl1);
			this->Controls->Add(this->statusStrip1);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->comboBox2);
			this->Controls->Add(this->comboBox1);
			this->Controls->Add(this->radioButton2);
			this->Controls->Add(this->radioButton1);
			this->Controls->Add(this->textBox2);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->textBox1);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::FixedDialog;
			this->Icon = (cli::safe_cast<System::Drawing::Icon^  >(resources->GetObject(L"$this.Icon")));
			this->MaximizeBox = false;
			this->Name = L"Form1";
			this->Text = L"ZKemsdk Sample Application";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->axCZKEM1))->EndInit();
			this->statusStrip1->ResumeLayout(false);
			this->statusStrip1->PerformLayout();
			this->tabControl1->ResumeLayout(false);
			this->tabPage1->ResumeLayout(false);
			this->groupBox2->ResumeLayout(false);
			this->groupBox2->PerformLayout();
			this->groupBox1->ResumeLayout(false);
			this->tabPage2->ResumeLayout(false);
			this->groupBox3->ResumeLayout(false);
			this->groupBox3->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox1))->EndInit();
			this->tabPage3->ResumeLayout(false);
			this->groupBox6->ResumeLayout(false);
			this->groupBox6->PerformLayout();
			this->groupBox5->ResumeLayout(false);
			this->groupBox5->PerformLayout();
			this->groupBox4->ResumeLayout(false);
			this->groupBox4->PerformLayout();
			this->tabPage4->ResumeLayout(false);
			this->groupBox8->ResumeLayout(false);
			this->groupBox8->PerformLayout();
			this->groupBox7->ResumeLayout(false);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
				 //textBox1->Text ="JWD";
				  //(LPSTR)(LPCTSTR)textBox2->Text;
				// ::CString   str;
				// str=(char*)textBox2->Text;
				// int a;
				// string str = textBox1->Text; 
                  //   char   *buf=str.GetBuffer(20); atoi((LPCTSTR)textBox2->Text)
				// a=atoi(buf.c_str());
				// System::String   *str;
				 
				// str = System::Convert(textBox2->Text);

        if(button1->Text == "Disconnect")
		    {
			axCZKEM1->Disconnect();
		    button1->Text="Connect";
            toolStripStatusLabel1->Text ="NO Connect";
			connect1 = 0;
			return;
		    }

         if(radioButton1->Checked )
		 {

			connect1 =	 axCZKEM1->Connect_Net(textBox1->Text ,System::Convert::ToInt32(textBox2->Text));
			if (connect1)
			{
				System::String^  str;
				//MessageBox::Show ("Connect Failed","information",MessageBoxButtons::OK, MessageBoxIcon::Exclamation );
				MessageBox::Show( "Connect Successed","information");
			 toolStripStatusLabel1->Text ="Connect Successed ...";
			 button1->Text ="Disconnect";
			 axCZKEM1->GetSDKVersion(str);
			 toolStripStatusLabel2->Text = "SDKVersion : " + str;
			}
			else
			{
				MessageBox::Show( "Connect Failed","information");
			toolStripStatusLabel1->Text ="Connect Failed ...";
			}
		}
		 else

		 {
			 connect1=axCZKEM1->Connect_Com(System::Convert::ToInt32(comboBox1->Text),1,System::Convert ::ToInt32(comboBox2->Text));
		 
			 if (connect1)
			    {
				MessageBox::Show( "Connect Successed","information");
			    toolStripStatusLabel1->Text ="Connect Successed ...";
				}
			else
		        {

				MessageBox::Show( "Connect Failed","information");
			 	toolStripStatusLabel1->Text ="Connect Failed ...";
				}
		 }

          


			
			 }
	private: System::Void Form1_Load(System::Object^  sender, System::EventArgs^  e) {


				 toolStripStatusLabel1->Text ="NO Connect";


			 }
	private: System::Void label1_Click(System::Object^  sender, System::EventArgs^  e) {


			 }
private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) {


 // StringBuilder -data;
			 System::Text::StringBuilder  _data;

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

if( axCZKEM1->ReadGeneralLogData(1) )	// The sample application assumes a machine number of 1
			{
				// After a successful call to ReadGeneralLogData, multiple calls to GetGeneralLogData
				// will return the transaction data from the terminal

				//LvTransactions.Items.Clear();
				listView1->Items->Clear ();
				listView1->BeginUpdate();

				axCZKEM1->GetLastError(_errorCode);

				while( _errorCode != 0 )
				{
					if( axCZKEM1->GetGeneralLogData(1,_machineNumber,_enrollNumber,_enrollMachineNumber,
						_verifyMode,_inOutMode,_year, _month,_day,_hour,_minute) )
					{
						_data.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7}",_enrollNumber,
							_verifyMode,_inOutMode,_year,_month,_day,_hour,_minute);

						//listView1->Items->Add(System::Convert::ToString (_enrollNumber),
							//System::Convert::ToString (_verifyMode));
						listView1->Items->Add(_data.ToString());
						_data.Remove(0,_data.Length);
					}

					axCZKEM1->GetLastError(_errorCode);
				}
                
				listView1->EndUpdate();
			//	Cursor = Cursors.Default;
            } //end if( CtrlBioComm.ReadGeneralLogData(1) )
else
			{
				//Cursor = Cursors.Default;
				axCZKEM1->GetLastError(_errorCode);

				if( _errorCode != 0 )
					MessageBox::Show("Unable to collect data from terminal,  Error Code: " + _errorCode);
				else
					MessageBox::Show("Terminal is empty");
			}




		 }
private: System::Void listView1_SelectedIndexChanged(System::Object^  sender, System::EventArgs^  e) {


			 System::String^ _transaction = "";
			 array<String^>^ _data;
			System::DateTime  _date;

			// Parse the transaction data and display the information to the user

			if( listView1->SelectedItems->Count>= 1 )
			{
				_transaction = listView1->SelectedItems[0]->Text;
				_data = _transaction->Split(',');

				textBox3->Text = _data[0]->ToString();
				textBox4->Text = _data[1]->ToString();
			
				
			
				if( _data->Length  == 8 ) 
				{
					_date =  DateTime(System::Convert::ToInt32(_data[3]),System::Convert::ToInt32(_data[4]),System::Convert::ToInt32(_data[5]),
						System::Convert::ToInt32(_data[6]),System::Convert::ToInt32(_data[7]),0);
				}
				else
				{
					_date =  DateTime(System::Convert::ToInt32(_data[3]),System::Convert::ToInt32(_data[4]),System::Convert::ToInt32(_data[5]),
						System::Convert::ToInt32(_data[6]),System::Convert::ToInt32(_data[7]),System::Convert::ToInt32(_data[8]));
				}

				textBox5->Text  = System::Convert::ToString(_date.ToString());	


			}

		 }
private: System::Void button4_Click(System::Object^  sender, System::EventArgs^  e) {
			 listView1->Items->Clear();
		 }
private: System::Void button3_Click(System::Object^  sender, System::EventArgs^  e) {


			 int _errorCode = 0;

			// Purge any punch data from the terminal

		//	Cursor = Cursors.WaitCursor;

			if( axCZKEM1->ClearGLog(1) )
				MessageBox::Show("Data has been cleared from the terminal");
			else
			{
				axCZKEM1->GetLastError(_errorCode);
				MessageBox::Show("Unable clear data from terminal,  Error Code: " + _errorCode.ToString());
			}

			listView1->Items->Clear();
			//Cursor = Cursors.Default;
		 }
private: System::Void tab_selectedIndexChanged(System::Object^  sender, System::EventArgs^  e) {

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
			System::String^ _firmwareVersion = "";
			System::String^ _serialNumber = "";
			System::String^ _ipAddress = "";
			System::String^ _password = "";				// Password if used by the user
			System::String^ _name = "";					// User name stored in terminal
			System::String^ _privileges = "";
			bool _enabled = false;
			//ListView^ _item = gcnew ListView;
ListViewItem^ _item = gcnew ListViewItem( "item1",0 );
         
	      if(button1->Text == "Connect")
		  {
				return;
		  }
			

		  	switch( tabControl1->SelectedIndex )
			{
				case 1:	// User management selected so upload users from terminal
				{
					listView2->Items->Clear();

					if( axCZKEM1->ReadAllUserID(1) )	// Put all users into the buffer at the terminal
					{
						listView2->BeginUpdate();
						axCZKEM1->GetLastError(_errorCode);

						while( _errorCode != 0 )
						{
							// Now collect all the users from the terminal

							if( axCZKEM1->GetAllUserID(1,_enrollNumber,_enrollMachineNumber,
								_backupNumber,_machinePrivilege,_enable) )
							{
								axCZKEM1->GetUserInfo(1,_enrollNumber,_name,_password,
									_machinePrivilege,_enabled);

								_item=listView2->Items->Add(_enrollNumber.ToString());
								_item->SubItems->Add(_name->ToString());
								_item->SubItems->Add(_password->ToString());

								switch(_machinePrivilege)
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

								_item->SubItems->Add(_privileges);

								if( _enable == 1 )
									_item->SubItems->Add("Y");
								else
									_item->SubItems->Add("N");
							}

							axCZKEM1->GetLastError(_errorCode);
						}

						listView2->EndUpdate();
					}
					else
					{
						axCZKEM1->GetLastError(_errorCode);

						if( _errorCode != 0 )
							MessageBox::Show("Unable to read user id's from terminal,  Error Code: " + _errorCode.ToString());
					}
					
					break;
				}
			case 2:	// User selected terminal information so upload terminal configuration
				{
					if( axCZKEM1->GetDeviceStatus(1,1,_value) ) // Admin count
						textBox14->Text = _value.ToString();
					else
						textBox14->Text = "N/A";

					if(axCZKEM1->GetDeviceStatus(1,2,_value) ) // User count
						textBox15->Text = _value.ToString();
					else
						textBox15->Text = "N/A";

					if( axCZKEM1->GetDeviceStatus(1,3,_value) ) // Template count
						textBox16->Text = _value.ToString();
					else
						textBox16->Text = "N/A";

					if(axCZKEM1->GetDeviceStatus(1,4,_value) ) // Password count
						textBox17->Text = _value.ToString();
					else
						textBox17->Text = "N/A";

					if( axCZKEM1->GetDeviceStatus(1,5,_value) ) // Admin Logs
						textBox18->Text = _value.ToString();
					else
						textBox18->Text = "N/A";

					if( axCZKEM1->GetDeviceStatus(1,6,_value) )
						// Transaction count
					{
						textBox19->Text = _value.ToString();
					 _settingChanged=false;
					}
					else
						textBox19->Text = "N/A";

					// Get the device time of the terminal and the ip address

					if( axCZKEM1->GetDeviceIP(1,_ipAddress) )
					{
						textBox11->Text = _ipAddress;
					 _ipAddressChanged=false;
					}
					else
						textBox11->Text = "N/A";

					if( axCZKEM1->GetDeviceTime(1,_year,_month,_day,_hour,_minute,_dayOfWeek) )
					{
						textBox10->Text = DateTime(_year,_month,_day,_hour,_minute,0,0).ToString();
					_deviceTimeChanged=false;
					}
					else
						textBox10->Text = "N/A";

					// Finally get the device firmware and serial number
                    //string ccdd;
                    if (axCZKEM1->GetSerialNumber(1,_serialNumber))
						textBox12->Text = _serialNumber;
					else
						textBox12->Text = "N/A";

					if( axCZKEM1->GetFirmwareVersion(1,_firmwareVersion) )

						textBox13->Text = _firmwareVersion;
					// _settingChanged=true;

					else
					{
						textBox13->Text = "N/A";


					}

                   //'axCZKEM1->GetDeviceInfo(1, 1,_value);
			      // 'textBox9->Text = _value.ToString();

					break;

				}



		}		








				
}

		 
private: System::Void listView2_SelectedIndexChanged(System::Object^  sender, System::EventArgs^  e) {



if( listView2->SelectedItems->Count >= 1 )
			{
				// Collect information for selected user from the listview

				textBox6->Text = listView2->SelectedItems[0]->Text;
				textBox7->Text = listView2->SelectedItems[0]->SubItems[1]->Text;
				textBox8->Text = listView2->SelectedItems[0]->SubItems[2]->Text;

				// Setup combo box to display current privilege for selected user

				if( listView2->SelectedItems[0]->SubItems[3]->Text == "General User" )
					comboBox3->SelectedIndex = 0;
				else if( listView2->SelectedItems[0]->SubItems[3]->Text == "Admin Level 1" )
					comboBox3->SelectedIndex = 1;
				else if( listView2->SelectedItems[0]->SubItems[3]->Text == "Admin Level 2" )
					comboBox3->SelectedIndex = 2;
				else
					comboBox3->SelectedIndex  = 3;

				// If the user is enabled than set the check box

				if( listView2->SelectedItems[0]->SubItems[4]->Text == "Y" )
					checkBox1->Checked = true;
				else
					checkBox1->Checked = false;
			}





		 }
private: System::Void comboBox4_SelectedIndexChanged(System::Object^  sender, System::EventArgs^  e) {


			 int _value = 0;

			// Get the value of the setting being chosen and display

			axCZKEM1->GetDeviceInfo(1,comboBox4->SelectedIndex + 1,_value);
			textBox9->Text = _value.ToString();
			_settingChanged = false;
		 }
private: System::Void button8_Click(System::Object^  sender, System::EventArgs^  e) {


            bool _enabled = true;
			int _errorCode = 0;

			// Ensure that a valid user id has been selected

			if( textBox6->Text == "" )
			{
				MessageBox::Show("Please select a user");
				return;
			}

			axCZKEM1->EnableDevice(1,false);		// Lock terminal to prevent activity during delete
			//Cursor = Cursors.WaitCursor;

			if(checkBox1->Checked)	// Check if the user is enabled in the terminal
				_enabled = true;
			
			else
				_enabled = false;

			// Set the collected user information to the terminal

			if( axCZKEM1->SetUserInfo(1,System::Convert::ToInt32(textBox6->Text),textBox7->Text,textBox8->Text,
				comboBox3->SelectedIndex,_enabled) )
			{
				MessageBox::Show("User information updated");
			}
			else
			{
				axCZKEM1->GetLastError(_errorCode);
				MessageBox::Show("Unable to update user information,  Error Code: " + _errorCode.ToString());
			}

			// Refresh the list view

			//System::tab_selectedIndexChanged(this,new System.EventArgs());
			
			System::Void tab_selectedIndexChanged(System::Object^  sender, System::EventArgs^  e);

	    	axCZKEM1->EnableDevice(1,true);	// Unlock the terminal
			//Cursor = Cursors.Default;			


		 }
private: System::Void button9_Click(System::Object^  sender, System::EventArgs^  e) {



            int _errorCode = 0;

			// Ensure that a valid user id has been selected

			if( textBox6->Text == "" )
			{
				MessageBox::Show("Please select a user");
				return;
			}

			axCZKEM1->EnableDevice(1,false);		// Lock terminal to prevent activity during delete
			//Cursor = Cursors.WaitCursor;

			// Delete the user completely from the terminal
			// Passing a 12 for backupNumber will erase all fingerprints and passwords for the user
			// Passing an 11 will only remove all the fingerprints for the user

			if( axCZKEM1->DeleteEnrollData(1,System::Convert::ToInt32(textBox6->Text),1,12) )
				MessageBox::Show("User removed from terminal");
			else
			{
				axCZKEM1->GetLastError(_errorCode);
				MessageBox::Show("Unable to delete user from terminal,  Error Code: " + _errorCode.ToString());
			}

			// Refresh the list view

			System::Void tab_selectedIndexChanged(System::Object^  sender, System::EventArgs^  e);

			axCZKEM1->EnableDevice(1,true);	// Unlock the terminal
		//	Cursor = Cursors.Default;



		 }
private: System::Void button5_Click(System::Object^  sender, System::EventArgs^  e) {


            // int _enrollData[73];	
			 // Templates are 73 ints in length
			// int^ a[100];
			// array <int>^ _enrollData;
          // int _enrollData[] = new int[73];
			
			 
			 //array<int> myAr
				// new 
			 //int _enrollData[73];
			//_enrollData  = gcnew array<int>^ [73];
			  array<int> ^ _enrollData = gcnew array<int>(73);
			int _password = 0;
			int _machinePrivilege = 0;
			System::IO::FileStream^ _stream ;
			System::IO::BinaryWriter^ _writer;

			// Ensure that a valid user id has been selected
 
			if( textBox6->Text == "" )
			{
				MessageBox::Show("Please select a user");
				return;
			}

			axCZKEM1->EnableDevice(1,false);		// Lock terminal to prevent activity during delete
			//Cursor = Cursors.WaitCursor;

			// Upload all available templates for the selected user
			// Templates will be stored in a file called Template_N.dat where N is the finger index

			for( int _fingerIndex = 0; _fingerIndex < 10; _fingerIndex++ )
			{
				if( axCZKEM1->GetEnrollData(1,System::Convert::ToInt32(textBox6->Text),1,_fingerIndex,
					_machinePrivilege,_enrollData[0],_password ) )
				{	
					// Template was successfully uploaded for this finger index
					// Store the template in the file

					_stream = gcnew FileStream("Template_" + _fingerIndex.ToString() + ".dat", FileMode::Create);
					_writer = gcnew BinaryWriter(_stream);

					for( int _index = 0; _index <_enrollData->Length ; _index++ )

						_writer->Write(System::Convert::ToSingle (_enrollData[_index]));

					_stream->Close();
					_writer->Close();
				}
			}

			MessageBox::Show("Templates have been uploaded");
			//Cursor = Cursors.Default;
			axCZKEM1->EnableDevice(1,true);		// Unlock terminal






		 }
private: System::Void button6_Click(System::Object^  sender, System::EventArgs^  e) {


			// Byte _enrollData[292]={NULL};
			//array<Byte>
		    array<Byte> ^ _enrollData = gcnew array<Byte>(292);
			int _errorCode = 0;
			//FileStream _stream = null;
			System::IO::FileStream^ _stream ;
			//BinaryReader _reader = null;
			System::IO::BinaryReader^ _reader;

			// Ensure that a valid user id has been selected

			if( textBox6->Text == "" )
			{
				MessageBox::Show("Please select a user");
				return;
			}

			// Ask the user to provide a template file to load
			openFileDialog1->Filter = "Template Files (.dat)|*.dat";
                openFileDialog1->Title = "Select a Template Files";
				openFileDialog1->FileName ="Template_0.dat";


			if( openFileDialog1->ShowDialog() == System::Windows::Forms::DialogResult::Cancel )
				return;

			axCZKEM1->EnableDevice(1,false);		// Lock terminal to prevent activity during delete
			//Cursor = Cursors.WaitCursor;

			_stream =(FileStream^) openFileDialog1->OpenFile();	// Open and read the template file
			_reader = gcnew BinaryReader(_stream);

			for( int _index = 0; _index < _stream->Length; _index++ )
			{
				if( _reader->PeekChar() != -1 )
					_enrollData[_index] = _reader->ReadByte();
			}

			_reader->Close();
			_stream->Close();

			// Send the template data to the terminal
			// The sample here will always load the template as finger index 0

			if( axCZKEM1->SetUserTmp(1,System::Convert::ToInt32(textBox6->Text),0,_enrollData[0]) )
			{
				MessageBox::Show("Template successfully loaded to terminal");
			}
			else
			{
				axCZKEM1->GetLastError(_errorCode);
				MessageBox::Show("Unable to load template to terminal,  Error Code: " + _errorCode.ToString());
			}

			axCZKEM1->EnableDevice(1,true);	// Unlock the terminal
			//Cursor = Cursors.Default;	





		 }
private: System::Void button7_Click(System::Object^  sender, System::EventArgs^  e) {


           if( textBox6->Text == "" )
			{
				MessageBox::Show("Please select a user");
				return;
			}

			axCZKEM1->EnableDevice(1,false);		// Lock terminal to prevent activity during delete
			//Cursor = Cursors.WaitCursor;

			// Remove all templates from the terminal for the selected user

			for( int _fingerIndex = 0; _fingerIndex < 10; _fingerIndex++ )
				axCZKEM1->DelUserTmp(1,System::Convert::ToInt32(textBox6->Text),_fingerIndex);

			MessageBox::Show("Templates deleted from terminal");

			axCZKEM1->EnableDevice(1,true);		// Unlock terminal
			//Cursor = Cursors.Default;





		 }
private: System::Void button11_Click(System::Object^  sender, System::EventArgs^  e) {


            //DateTime _date;
			 System::DateTime _date;
			int _errorCode = 0;

			// Update the currently selected setting, as well as the IP address
			// and device time if they have been changed

			if( _ipAddressChanged )
				axCZKEM1->SetDeviceIP(1,textBox11->Text);

			if( _deviceTimeChanged)//_deviceTimeChanged
			{
				try
				{
					if(textBox10->Text !="")
						_date = System::Convert::ToDateTime (textBox10->Text);
					//else
						//return;
				}
				//System::InvalidCastException Exception
				catch(System::String^ str)
				{
					System::String^ _message = str->ToString();
					MessageBox::Show("Invalid date/time format");
					return;
					
				}

				axCZKEM1->SetDeviceTime2(1,_date.Year,_date.Month,_date.Day,_date.Hour,_date.Minute,_date.Second);
			}

			// Now update the currently selected setting if it has been changed

			if( _settingChanged )
				axCZKEM1->SetDeviceInfo(1,comboBox4->SelectedIndex + 1,System::Convert::ToInt32(textBox9->Text));

			axCZKEM1->GetLastError(_errorCode);

			if( _errorCode != 1 )
				MessageBox::Show("Unable to update terminal settings,  Error Code: " + _errorCode.ToString());	
			else
				MessageBox::Show("Terminal settings updated");




		 }
private: System::Void textBox11_TextChanged(System::Object^  sender, System::EventArgs^  e) {

      _ipAddressChanged=true;
		 }
private: System::Void textBox10_TextChanged(System::Object^  sender, System::EventArgs^  e) {
_deviceTimeChanged=true;
		 }
private: System::Void textBox9_TextChanged(System::Object^  sender, System::EventArgs^  e) {
			 _settingChanged=true;
		 }
private: System::Void button12_Click(System::Object^  sender, System::EventArgs^  e) {


			 int _errorCode = 0;

			// Ask the user to provide a firmware file to load

			 openFileDialog1->Filter = "Terminal Firmware Files (.cfg)|*.cfg";
                openFileDialog1->Title = "Select a Firmware Files";
				openFileDialog1->FileName ="";

			if( openFileDialog1->ShowDialog() == System::Windows::Forms::DialogResult::Cancel )
				return;

			// Load the firmware file to the terminal

			if( axCZKEM1->UpdateFirmware(openFileDialog1->FileName ) )
				MessageBox::Show("Terminal firmware loaded, Please reset terminal");
			else
			{
				axCZKEM1->GetLastError(_errorCode);
				MessageBox::Show("Unable to load terminal firmware, Error Code: " + _errorCode.ToString());
			}		
		 }
private: System::Void button15_Click(System::Object^  sender, System::EventArgs^  e) {


             int _errorCode = 0;

			// Clear all users,templates,passwords,administrators,logs, and transactions from the terminal
			// This method will wipe out the entire contents of the terminal

			if( axCZKEM1->ClearKeeperData(1) )
				MessageBox::Show("All information cleared from terminal");
			else
			{
				axCZKEM1->GetLastError(_errorCode);
				MessageBox::Show("Unable to clear terminal information,  Error Code: " + _errorCode.ToString());
			}

		 }
private: System::Void button16_Click(System::Object^  sender, System::EventArgs^  e) {



			 int _errorCode = 0;

			// Clear all administrators from the terminal

			if( axCZKEM1->ClearAdministrators(1) )
				MessageBox::Show("Administrators cleared from terminal");
			else
			{
				axCZKEM1->GetLastError(_errorCode);
				MessageBox::Show("Unable to clear administrators,  Error Code: " + _errorCode.ToString());
			}
		 }
private: System::Void button14_Click(System::Object^  sender, System::EventArgs^  e) {



			 int _errorCode = 0;

			// Ask the user to provide a backup file to load
			  openFileDialog1->Filter = "Terminal Backup Files (.bak)|*.bak";
                openFileDialog1->Title = "Select a Backup Files";
				openFileDialog1->FileName ="";

			if( openFileDialog1->ShowDialog() == System::Windows::Forms::DialogResult::Cancel )
				return;

			// Restore the terminal backup file

			if( axCZKEM1->RestoreData(openFileDialog1->FileName) )
				MessageBox::Show("Terminal data has been restored");
			else
			{
				axCZKEM1->GetLastError(_errorCode);
				MessageBox::Show("Unable to restore terminal data,  Error Code: " + _errorCode.ToString());
			}
		 }
private: System::Void button13_Click(System::Object^  sender, System::EventArgs^  e) {


             int _errorCode = 0;

			// Save the entire contents of the terminal to a backup file
			 // openFileDialog1->Filter = "Terminal Backup Files (.bak)|*.bak";
               // openFileDialog1->Title = "Select a Backup Files";
				//openFileDialog1->FileName ="";

			if( axCZKEM1->BackupData("terminal.bak") )
				MessageBox::Show("Terminal information saved to backup.dat");
			else
			{
				axCZKEM1->GetLastError(_errorCode);
				MessageBox::Show("Unable to backup terminal data,  Error Code: " + _errorCode.ToString());
			}

		 }
private: System::Void button10_Click(System::Object^  sender, System::EventArgs^  e) {

             int _width=100;
			 int _height=100;
			 int _errorCode=0;
			// Byte _image[83512];
			 System::String^ _imageFile = "Image.bmp";
			 bool Bsensor;
			  array<Byte> ^ _image = gcnew array<Byte>(83512);

			
		//	 System::IO ::FileStream^ _stream;
			// System::Drawing::Image^ _Image;
			  if(button1->Text =="Disconnect")
			  {
			 axCZKEM1->EnableDevice (1,false); 
			 MessageBox::Show("Place finger on sensor");
			  }

			  else
			  {
				  MessageBox::Show("Connect Failed");
				  return;
			  }

             Bsensor  =   axCZKEM1->CaptureImage(false ,_width ,_height ,_image[0],_imageFile);

			 if(Bsensor)
			     {
				
				// MessageBox::Show("指纹信息");

					 MessageBox::Show("Remove finger from sensor");

				      axCZKEM1->EnableDevice(1,true);
					  
			      }
			 else
			     {
                  axCZKEM1->GetLastError(_errorCode);

			      MessageBox::Show("Unable to capture fingerprint,  Error Code:" + _errorCode.ToString() );
			      }


			if(checkBox1->Checked )

				  ShowMyImage(_imageFile,120,100);

				//pictureBox1->Image ="Image.bmp";


		 }



	System::Drawing ::Bitmap^ MyImage;


public:   void ShowMyImage( String^ fileToDisplay, int xSize, int ySize )
   {
      
      // Sets up an image object to be displayed.
      if ( MyImage != nullptr )
      {
         delete MyImage;
      }

      
      // Stretches the image to fit the pictureBox.
      pictureBox1->SizeMode = PictureBoxSizeMode::StretchImage;
      MyImage = gcnew Bitmap( fileToDisplay );
      pictureBox1->ClientSize = System::Drawing::Size( xSize, ySize );
      pictureBox1->Image = dynamic_cast<Image^>(MyImage);

   }





private: System::Void button17_Click(System::Object^  sender, System::EventArgs^  e) {

			bool beept;
           //if(connect1)
			//{
			if(connect1)
			{
				
  
			     beept= axCZKEM1->Beep(150);

			     if(beept)
				   MessageBox::Show("Beep","information");
			    else
				    MessageBox::Show ("No Beep","information");
			}
			else
			{
				MessageBox::Show ("Connect Failed","information",MessageBoxButtons::OK, MessageBoxIcon::Exclamation );
				return;
			}

		//	{
			
		//	else


			//{
				//MessageBox::Show ("Connect Failed");
				//return;
			
		//	}

		 }
private: System::Void button18_Click(System::Object^  sender, System::EventArgs^  e) {

                 if(connect1)
				 {
		         axCZKEM1->EnableClock(false);	
			     axCZKEM1->ClearLCD();
				 }
				 else
				 {
					 MessageBox::Show ("Connect Failed","information",MessageBoxButtons::OK, MessageBoxIcon::Exclamation );
					 return;
				 }
		
			
			
		 }
private: System::Void button19_Click(System::Object^  sender, System::EventArgs^  e) {
			if(connect1)

			     axCZKEM1->WriteLCD(1,1,textBox20->Text );

			else
			 {

                    MessageBox::Show ("Connect Failed","information",MessageBoxButtons::OK, MessageBoxIcon::Exclamation );
				 return;

			  }
		 }
private: System::Void button20_Click(System::Object^  sender, System::EventArgs^  e) {
           
			
			 if(connect1)

			    axCZKEM1->PowerOffDevice(1);

			else

			 {

				MessageBox::Show ("Connect Failed","information",MessageBoxButtons::OK, MessageBoxIcon::Exclamation );
			 	 return;


			   }
		 }
private: System::Void button21_Click(System::Object^  sender, System::EventArgs^  e) {

			
			if(connect1)

			     axCZKEM1->PlayVoiceByIndex(0);
			 else
			   {
				  MessageBox::Show ("Connect Failed","information",MessageBoxButtons::OK, MessageBoxIcon::Exclamation );
				  return;
			   }
			// axCZKEM1->PlayVoice(2,5000);
		 }
private: System::Void button22_Click(System::Object^  sender, System::EventArgs^  e) {
			 
			
			 if(connect1)

			      axCZKEM1->RestartDevice(1);
			 else

			 {
				MessageBox::Show ("Connect Failed","information",MessageBoxButtons::OK, MessageBoxIcon::Exclamation );
				 return;
			
			}

		 }
private: System::Void button23_Click(System::Object^  sender, System::EventArgs^  e) {
			
			
			if(connect1)

			{
				
                 if(button23->Text =="ClockOff")
			      {

			         axCZKEM1->EnableClock(false);
			         button23->Text ="ClockOn";
			      }
			   else
			      {
                     axCZKEM1->EnableClock(true);
			         button23->Text ="ClockOff";
			       }
			}

			else
			
			{
				MessageBox::Show ("Connect Failed","information",MessageBoxButtons::OK, MessageBoxIcon::Exclamation );
				 return;
			
			 }

			 

		 }




};
}

