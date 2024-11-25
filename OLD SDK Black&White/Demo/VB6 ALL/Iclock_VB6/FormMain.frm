VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "Comdlg32.ocx"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{FE9DED34-E159-408E-8490-B720A5E632C7}#1.0#0"; "zkemkeeper.dll"
Begin VB.Form FormMain 
   Caption         =   "Sample program"
   ClientHeight    =   8310
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   10740
   LinkTopic       =   "Form1"
   ScaleHeight     =   8310
   ScaleWidth      =   10740
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command3 
      Caption         =   "GetGeneralExtLogData"
      Height          =   375
      Left            =   2760
      TabIndex        =   112
      Top             =   3240
      Width           =   2175
   End
   Begin zkemkeeperCtl.CZKEM CZKEM1 
      Height          =   375
      Left            =   9840
      OleObjectBlob   =   "FormMain.frx":0000
      TabIndex        =   111
      Top             =   240
      Width           =   495
   End
   Begin VB.Frame WorkCode 
      Caption         =   "WorkCode(Only support some custom-made machine)"
      Height          =   860
      Left            =   4920
      TabIndex        =   101
      Top             =   3060
      Width           =   5595
      Begin VB.CommandButton cmdSSR_ClearWorkCode 
         Caption         =   "SSR_ClearWorkCode"
         Height          =   300
         Left            =   3600
         TabIndex        =   109
         Top             =   480
         Width           =   1815
      End
      Begin VB.CommandButton cmdSSR_DeleteWorkCode 
         Caption         =   "SSR_DeleteWorkCode"
         Height          =   300
         Left            =   3600
         TabIndex        =   108
         Top             =   180
         Width           =   1935
      End
      Begin VB.TextBox TextName 
         Height          =   285
         Left            =   840
         TabIndex        =   105
         Top             =   520
         Width           =   1095
      End
      Begin VB.TextBox TextWorkCode 
         Height          =   285
         Left            =   840
         TabIndex        =   104
         Top             =   240
         Width           =   1095
      End
      Begin VB.CommandButton cmdSSR_SetWorkCode 
         Caption         =   "SSR_SetWorkCode"
         Height          =   300
         Left            =   1980
         TabIndex        =   103
         Top             =   500
         Width           =   1600
      End
      Begin VB.CommandButton cmdSSR_GetWorkCode 
         Caption         =   "SSR_GetWorkCode"
         Height          =   300
         Left            =   1980
         TabIndex        =   102
         Top             =   180
         Width           =   1600
      End
      Begin VB.Label Label23 
         Caption         =   "Name"
         Height          =   255
         Left            =   240
         TabIndex        =   107
         Top             =   520
         Width           =   975
      End
      Begin VB.Label Label24 
         Caption         =   "WorkCode"
         Height          =   255
         Left            =   50
         TabIndex        =   106
         Top             =   240
         Width           =   855
      End
   End
   Begin VB.Frame Frame7 
      Caption         =   "O_Other"
      Height          =   855
      Left            =   240
      TabIndex        =   92
      Top             =   6720
      Width           =   4455
      Begin VB.CommandButton cmdWriteCustData 
         Caption         =   "WriteCustData"
         Height          =   255
         Left            =   1440
         TabIndex        =   99
         Top             =   520
         Width           =   1335
      End
      Begin VB.CommandButton cmdReadCustData 
         Caption         =   "ReadCustData"
         Height          =   255
         Left            =   120
         TabIndex        =   98
         Top             =   520
         Width           =   1335
      End
      Begin VB.TextBox textCustData 
         Height          =   270
         Left            =   120
         TabIndex        =   97
         Top             =   220
         Width           =   2055
      End
      Begin VB.CommandButton cmdUpdateFirmware 
         Caption         =   "UpdateFirmware"
         Height          =   285
         Left            =   3000
         TabIndex        =   93
         Top             =   480
         Width           =   1440
      End
   End
   Begin VB.Frame Frame6 
      Caption         =   "X_Access Control"
      Height          =   915
      Left            =   4920
      TabIndex        =   70
      Top             =   3960
      Width           =   5595
      Begin VB.CommandButton cmdAC 
         Caption         =   "All"
         Height          =   255
         Left            =   2280
         TabIndex        =   94
         Top             =   600
         Width           =   1215
      End
      Begin VB.CommandButton cmdSetTimeZones 
         Caption         =   "SetTimeZones"
         Height          =   285
         Left            =   3780
         TabIndex        =   78
         Top             =   570
         Width           =   1545
      End
      Begin VB.TextBox TextTZ1 
         Height          =   285
         Left            =   930
         TabIndex        =   76
         Text            =   "1"
         Top             =   540
         Width           =   735
      End
      Begin VB.TextBox textGroup 
         Height          =   285
         Left            =   2580
         TabIndex        =   74
         Text            =   "1"
         Top             =   240
         Width           =   735
      End
      Begin VB.CommandButton Command1 
         Caption         =   "SetGroup"
         Height          =   285
         Left            =   3780
         TabIndex        =   73
         Top             =   240
         Width           =   1095
      End
      Begin VB.TextBox textUserID 
         Height          =   285
         Left            =   930
         TabIndex        =   71
         Text            =   "1"
         Top             =   240
         Width           =   735
      End
      Begin VB.Label Label19 
         Caption         =   "TimeZones:"
         Height          =   255
         Left            =   150
         TabIndex        =   77
         Top             =   540
         Width           =   735
      End
      Begin VB.Label Label18 
         Caption         =   "Group:"
         Height          =   255
         Left            =   1800
         TabIndex        =   75
         Top             =   240
         Width           =   735
      End
      Begin VB.Label Label17 
         Caption         =   "User ID:"
         Height          =   255
         Left            =   180
         TabIndex        =   72
         Top             =   270
         Width           =   735
      End
   End
   Begin VB.TextBox txtMahcineNum 
      Height          =   285
      Left            =   3120
      TabIndex        =   68
      Text            =   "1"
      Top             =   180
      Width           =   495
   End
   Begin VB.TextBox txtBaudRate 
      Height          =   285
      Left            =   3690
      TabIndex        =   67
      Text            =   "115200"
      Top             =   180
      Width           =   735
   End
   Begin VB.OptionButton OptionEthernet 
      Caption         =   "Ethernet"
      Height          =   195
      Left            =   180
      TabIndex        =   66
      Top             =   360
      Value           =   -1  'True
      Width           =   1125
   End
   Begin VB.OptionButton OptionCom 
      Caption         =   "Serial Port"
      Height          =   195
      Left            =   180
      TabIndex        =   65
      Top             =   60
      Width           =   1365
   End
   Begin VB.Frame Frame5 
      Caption         =   "Log"
      Height          =   585
      Left            =   4920
      TabIndex        =   55
      Top             =   2430
      Width           =   5595
      Begin VB.CommandButton Command2 
         Caption         =   "ReadExitingData"
         Height          =   315
         Left            =   3960
         TabIndex        =   110
         Top             =   240
         Width           =   1575
      End
      Begin VB.CommandButton cmdClearGLog 
         Caption         =   "ClearGLogData"
         Height          =   285
         Left            =   2400
         TabIndex        =   79
         Top             =   240
         Width           =   1575
      End
      Begin VB.CommandButton cmdSSR_ReadAllGLogData 
         Caption         =   "SSR_GetGeneralLogData"
         Height          =   285
         Left            =   240
         TabIndex        =   57
         Top             =   240
         Width           =   2055
      End
   End
   Begin VB.Frame Frame4 
      Caption         =   "X_Reader Operation"
      Height          =   945
      Left            =   4920
      TabIndex        =   54
      Top             =   4920
      Width           =   5595
      Begin VB.TextBox TxtFingerID 
         Height          =   285
         Left            =   2760
         TabIndex        =   90
         Text            =   "1"
         Top             =   240
         Width           =   735
      End
      Begin VB.TextBox TxtUserID1 
         Height          =   285
         Left            =   870
         TabIndex        =   88
         Text            =   "1"
         Top             =   240
         Width           =   735
      End
      Begin VB.CommandButton cmdIdentify 
         Caption         =   "Identify"
         Height          =   285
         Left            =   2760
         TabIndex        =   87
         Top             =   600
         Width           =   1335
      End
      Begin VB.CommandButton cmdCancel 
         Caption         =   "Cancel Option"
         Height          =   285
         Left            =   4080
         TabIndex        =   86
         Top             =   600
         Width           =   1335
      End
      Begin VB.CommandButton cmdVerify 
         Caption         =   "Verify"
         Height          =   285
         Left            =   1440
         TabIndex        =   85
         Top             =   600
         Width           =   1335
      End
      Begin VB.CommandButton cmdStartEnroll 
         Caption         =   "Enroll Finger"
         Height          =   285
         Left            =   120
         TabIndex        =   84
         Top             =   600
         Width           =   1335
      End
      Begin VB.Label Label22 
         Caption         =   "Finger ID:"
         Height          =   255
         Left            =   1680
         TabIndex        =   91
         Top             =   270
         Width           =   975
      End
      Begin VB.Label Label21 
         Caption         =   "User ID:"
         Height          =   255
         Left            =   120
         TabIndex        =   89
         Top             =   270
         Width           =   735
      End
   End
   Begin VB.Frame Frame3 
      Caption         =   "O_Options"
      Height          =   3195
      Left            =   210
      TabIndex        =   33
      Top             =   3420
      Width           =   4515
      Begin VB.TextBox Text1 
         Height          =   270
         Left            =   120
         TabIndex        =   96
         Top             =   2760
         Width           =   495
      End
      Begin VB.CommandButton cmdGetVerifyMode 
         Caption         =   "Get verify Mode"
         Height          =   285
         Left            =   720
         TabIndex        =   95
         Top             =   2760
         Width           =   1800
      End
      Begin VB.CommandButton cmdGetCardFun 
         Caption         =   "GetCardFun"
         Height          =   285
         Left            =   2640
         TabIndex        =   83
         Top             =   2760
         Width           =   1800
      End
      Begin VB.TextBox txtYear 
         Height          =   285
         Left            =   120
         TabIndex        =   48
         Text            =   "2005"
         Top             =   480
         Width           =   735
      End
      Begin VB.TextBox txtMonth 
         Height          =   285
         Left            =   960
         TabIndex        =   47
         Text            =   "2"
         Top             =   480
         Width           =   615
      End
      Begin VB.TextBox txtDay 
         Height          =   285
         Left            =   1680
         TabIndex        =   46
         Text            =   "12"
         Top             =   480
         Width           =   615
      End
      Begin VB.CommandButton cmdSetDeviceTime 
         Caption         =   "SetDeviceTime2"
         Enabled         =   0   'False
         Height          =   285
         Left            =   120
         TabIndex        =   45
         Top             =   840
         Width           =   1815
      End
      Begin VB.TextBox txtHour 
         Height          =   285
         Left            =   2400
         TabIndex        =   44
         Text            =   "12"
         Top             =   480
         Width           =   495
      End
      Begin VB.TextBox txtMinute 
         Height          =   285
         Left            =   3000
         TabIndex        =   43
         Text            =   "20"
         Top             =   480
         Width           =   615
      End
      Begin VB.TextBox txtSecond 
         Height          =   285
         Left            =   3720
         TabIndex        =   42
         Text            =   "0"
         Top             =   480
         Width           =   615
      End
      Begin VB.TextBox txt11Threshold 
         Height          =   285
         Left            =   1560
         TabIndex        =   41
         Text            =   "18"
         Top             =   2040
         Width           =   735
      End
      Begin VB.TextBox txt1NThreshold 
         Height          =   285
         Left            =   240
         TabIndex        =   40
         Text            =   "34"
         Top             =   2040
         Width           =   735
      End
      Begin VB.CommandButton cmdDateFormat 
         Caption         =   "Change Date Format and Delimiter"
         Enabled         =   0   'False
         Height          =   495
         Left            =   2400
         TabIndex        =   39
         Top             =   1200
         Width           =   1815
      End
      Begin VB.ComboBox cmbDateFormats 
         Height          =   300
         ItemData        =   "FormMain.frx":0024
         Left            =   60
         List            =   "FormMain.frx":0046
         Style           =   2  'Dropdown List
         TabIndex        =   38
         Top             =   1440
         Width           =   2055
      End
      Begin VB.CommandButton cmdThreshold 
         Caption         =   "Set Match Threshold"
         Enabled         =   0   'False
         Height          =   495
         Left            =   2880
         TabIndex        =   37
         Top             =   1800
         Width           =   1455
      End
      Begin VB.CommandButton cmd1To1Mode 
         Caption         =   "Set 1:1 Mode"
         Enabled         =   0   'False
         Height          =   285
         Left            =   720
         TabIndex        =   36
         Top             =   2400
         Width           =   1800
      End
      Begin VB.CommandButton cmd1ToNMode 
         Caption         =   "Set 1:N Mode"
         Enabled         =   0   'False
         Height          =   285
         Left            =   2640
         TabIndex        =   35
         Top             =   2400
         Width           =   1800
      End
      Begin VB.CommandButton cmdGetTime 
         Caption         =   "GetDeviceTime"
         Height          =   285
         Left            =   2280
         TabIndex        =   34
         Top             =   840
         Width           =   1815
      End
      Begin VB.Label Label1 
         Caption         =   "Year     Month    Day"
         Height          =   255
         Left            =   120
         TabIndex        =   52
         Top             =   240
         Width           =   2295
      End
      Begin VB.Label Label2 
         Caption         =   "Hour  Minute  Second"
         Height          =   255
         Left            =   2400
         TabIndex        =   51
         Top             =   240
         Width           =   1935
      End
      Begin VB.Label Label4 
         Caption         =   "Date Format and Delimiter"
         Height          =   255
         Left            =   60
         TabIndex        =   50
         Top             =   1200
         Width           =   2295
      End
      Begin VB.Label Label5 
         Caption         =   "1:N threshold   1:1 threshold"
         Height          =   255
         Left            =   120
         TabIndex        =   49
         Top             =   1800
         Width           =   3135
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Users"
      BeginProperty Font 
         Name            =   "ËÎÌå"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2685
      Left            =   240
      TabIndex        =   25
      Top             =   600
      Width           =   4455
      Begin VB.CommandButton cmdSSR_DeleteEnrollData 
         Caption         =   "SSR_DeleteEnrollData"
         Height          =   285
         Left            =   2280
         TabIndex        =   100
         Top             =   2280
         Width           =   1770
      End
      Begin VB.TextBox textCardNumber1 
         Height          =   285
         Left            =   2400
         TabIndex        =   82
         Top             =   960
         Width           =   1275
      End
      Begin VB.TextBox textCardNumber0 
         Height          =   285
         Left            =   1020
         TabIndex        =   80
         Top             =   960
         Width           =   1275
      End
      Begin VB.CommandButton cmdSSR_GetUserInfo 
         Caption         =   "SSR_GetUserInfo"
         Height          =   285
         Left            =   450
         TabIndex        =   69
         Top             =   1260
         Width           =   1605
      End
      Begin VB.TextBox TextEnable 
         Height          =   285
         Left            =   3870
         TabIndex        =   63
         Top             =   690
         Width           =   555
      End
      Begin VB.CommandButton cmdReadUserInfo 
         Caption         =   "ReadUserInfo"
         Height          =   285
         Left            =   2280
         TabIndex        =   62
         Top             =   1550
         Width           =   1605
      End
      Begin VB.TextBox textPrivilege 
         Height          =   285
         Left            =   2850
         TabIndex        =   60
         Top             =   690
         Width           =   285
      End
      Begin VB.TextBox textPassword 
         Height          =   285
         IMEMode         =   3  'DISABLE
         Left            =   1020
         PasswordChar    =   "*"
         TabIndex        =   58
         Top             =   660
         Width           =   735
      End
      Begin VB.CommandButton cmdReadAllUser 
         Caption         =   "ReadAllUserID"
         Height          =   285
         Left            =   2280
         TabIndex        =   56
         Top             =   1260
         Width           =   1605
      End
      Begin VB.CommandButton cmdSSR_GetUserTmpStr 
         Caption         =   "SSR_GetUserTmpStr"
         Height          =   285
         Left            =   360
         TabIndex        =   53
         Top             =   1995
         Width           =   1725
      End
      Begin VB.CommandButton cmdSSR_DelUserTmp 
         Caption         =   "SSR_DelUserTmp"
         Enabled         =   0   'False
         Height          =   285
         Left            =   2280
         TabIndex        =   32
         Top             =   1995
         Width           =   1605
      End
      Begin VB.CommandButton cmdSSR_SetUserTmpStr 
         Caption         =   "SSR_SetUserTmpStr"
         Enabled         =   0   'False
         Height          =   285
         Left            =   360
         TabIndex        =   31
         Top             =   2280
         Width           =   1725
      End
      Begin VB.CommandButton cmdSSR_SetUserInfo 
         Caption         =   "SSR_SetUserInfo"
         Height          =   285
         Left            =   450
         TabIndex        =   30
         Top             =   1550
         Width           =   1605
      End
      Begin VB.TextBox txtUserID 
         Height          =   285
         Left            =   1020
         TabIndex        =   27
         Text            =   "1"
         Top             =   270
         Width           =   735
      End
      Begin VB.TextBox textUserName 
         Height          =   285
         Left            =   2850
         TabIndex        =   26
         Top             =   300
         Width           =   1275
      End
      Begin VB.Label Label20 
         Caption         =   "CardNumber:"
         Height          =   255
         Left            =   120
         TabIndex        =   81
         Top             =   960
         Width           =   915
      End
      Begin VB.Label Label16 
         Caption         =   "Enable:"
         Height          =   255
         Left            =   3210
         TabIndex        =   64
         Top             =   720
         Width           =   675
      End
      Begin VB.Label Label15 
         Caption         =   "Privilege:"
         Height          =   255
         Left            =   1980
         TabIndex        =   61
         Top             =   720
         Width           =   735
      End
      Begin VB.Label Label14 
         Caption         =   "Password:"
         Height          =   255
         Left            =   240
         TabIndex        =   59
         Top             =   690
         Width           =   735
      End
      Begin VB.Label Label3 
         Caption         =   "User ID:"
         Height          =   255
         Left            =   270
         TabIndex        =   29
         Top             =   300
         Width           =   735
      End
      Begin VB.Label Label13 
         Caption         =   "User Name:"
         Height          =   255
         Left            =   1950
         TabIndex        =   28
         Top             =   300
         Width           =   915
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "SMS"
      Height          =   1800
      Left            =   4920
      TabIndex        =   5
      Top             =   5895
      Width           =   5625
      Begin VB.CommandButton cmdSSR_SetUserSMS 
         Caption         =   "SSR_SetUserSMS"
         Height          =   405
         Left            =   1200
         TabIndex        =   24
         Top             =   1320
         Width           =   1575
      End
      Begin VB.CommandButton cmdSSR_DeleteUserSMS 
         Caption         =   "SSR_DeleteUserSMS"
         Height          =   405
         Left            =   2760
         TabIndex        =   23
         Top             =   1320
         Width           =   1425
      End
      Begin VB.CommandButton cmdClearUserSMS 
         Caption         =   "Clear UserSMS"
         Height          =   405
         Left            =   4200
         TabIndex        =   22
         Top             =   1320
         Width           =   1395
      End
      Begin VB.CommandButton cmdClearSMS 
         Caption         =   "Clear SMS"
         Height          =   285
         Left            =   4200
         TabIndex        =   21
         Top             =   870
         Width           =   1005
      End
      Begin VB.CommandButton cmdGetSMS 
         Caption         =   "Get SMS"
         Height          =   285
         Left            =   180
         TabIndex        =   20
         Top             =   870
         Width           =   1275
      End
      Begin VB.CommandButton cmdSetSMS 
         Caption         =   "Set SMS"
         Height          =   285
         Left            =   1440
         TabIndex        =   19
         Top             =   870
         Width           =   1275
      End
      Begin VB.CommandButton cmdDeleteSMS 
         Caption         =   "DeleteSMS"
         Height          =   285
         Left            =   2760
         TabIndex        =   18
         Top             =   870
         Width           =   1335
      End
      Begin VB.TextBox textEnrollNumber 
         Height          =   285
         Left            =   180
         TabIndex        =   15
         Text            =   "1"
         Top             =   1380
         Width           =   975
      End
      Begin VB.TextBox textStartTime 
         Height          =   285
         Left            =   4140
         TabIndex        =   14
         Top             =   480
         Width           =   1215
      End
      Begin VB.TextBox textTag 
         Height          =   285
         Left            =   2550
         TabIndex        =   11
         Top             =   480
         Width           =   615
      End
      Begin VB.TextBox textValidTime 
         Height          =   285
         Left            =   3330
         TabIndex        =   10
         Top             =   480
         Width           =   615
      End
      Begin VB.TextBox textID 
         Height          =   285
         Left            =   210
         TabIndex        =   7
         Text            =   "1"
         Top             =   480
         Width           =   615
      End
      Begin VB.TextBox textContent 
         Height          =   285
         Left            =   990
         TabIndex        =   6
         Top             =   480
         Width           =   1395
      End
      Begin VB.Label Label11 
         Caption         =   "StartTime"
         Height          =   195
         Left            =   4440
         TabIndex        =   17
         Top             =   225
         Width           =   1215
      End
      Begin VB.Label Label12 
         Caption         =   "User ID"
         Height          =   225
         Left            =   180
         TabIndex        =   16
         Top             =   1200
         Width           =   1185
      End
      Begin VB.Label Label9 
         Caption         =   "SMSTag"
         Height          =   225
         Left            =   2520
         TabIndex        =   13
         Top             =   225
         Width           =   675
      End
      Begin VB.Label Label10 
         Caption         =   "ValidMinutes"
         Height          =   255
         Left            =   3300
         TabIndex        =   12
         Top             =   225
         Width           =   825
      End
      Begin VB.Label Label7 
         Caption         =   "SMSID"
         Height          =   255
         Left            =   210
         TabIndex        =   9
         Top             =   210
         Width           =   615
      End
      Begin VB.Label Label8 
         Caption         =   "SMS content"
         Height          =   225
         Left            =   1200
         TabIndex        =   8
         Top             =   225
         Width           =   1155
      End
   End
   Begin MSAdodcLib.Adodc adodc1 
      Height          =   375
      Left            =   7560
      Top             =   0
      Visible         =   0   'False
      Width           =   1875
      _ExtentX        =   3307
      _ExtentY        =   661
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   8
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   ""
      OLEDBString     =   ""
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   ""
      Caption         =   "adodc1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   6840
      Top             =   0
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      CancelError     =   -1  'True
      DefaultExt      =   "cfg"
      DialogTitle     =   "Select The Firmware File"
      FileName        =   "emfw.cfg"
      Filter          =   "Firmware File|*.cfg"
   End
   Begin VB.TextBox txtEvent 
      Height          =   1725
      Left            =   4920
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   3
      Text            =   "FormMain.frx":00AE
      Top             =   720
      Width           =   5565
   End
   Begin VB.CommandButton cmdConnect 
      Caption         =   "Connect"
      Height          =   375
      Left            =   4830
      TabIndex        =   2
      Top             =   120
      Width           =   1815
   End
   Begin VB.TextBox txtIP 
      Height          =   285
      Left            =   1710
      TabIndex        =   1
      Text            =   "192.168.1.201"
      Top             =   180
      Width           =   1335
   End
   Begin VB.Label Label6 
      Caption         =   "Label6"
      Height          =   255
      Left            =   6840
      TabIndex        =   4
      Top             =   480
      Width           =   3735
   End
   Begin VB.Label lblInfo 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Information"
      Height          =   300
      Left            =   150
      TabIndex        =   0
      Top             =   7800
      Width           =   10395
   End
End
Attribute VB_Name = "FormMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
'Updates to the SDK need to address:
'
'   Function for setting date time - 'SetDeviceTime2'
'
'    Fix for 'SetEnrollmentData' returning ¡°ERR_INVALID_PARAM¡±
'    Programming samples with sample function arguments to verify performance of these three functions:
'            SetEnrollDataStr
'            SetUserTmp,
'            SetUserTmpStr
'
'    Documentation on SLog records.
'
'    How to change the Date Delimiter using the SetDeviceInfo command
'
'    How to program the "Match Threshold" value in the clock
'
'    How to program the clock for 1:1 or 1:x biometrics
'
'    How to program the 1:1 threshold value
'
'    How to program the date time display format on the clock to Month, Day, Year (U.S. format)
Private Declare Function GetTickCount Lib "kernel32" () As Long

Const sSampleTemplate1 = "A1CA1E81AF384F2118ACBA4B4026A7BD48D434AB2540800D56A645D414513760BC09463A58A30F53AB500060302C4E713F3926507C260DAE7982092DA45B40151D3974910940864DFC04038D7152080BA565D40E20B66902083E8E69F8057E3564940AAF0F62B8040811312408DD954D780A72AC5B01122CB347400A31AC3892114794370004688B4E340677053180126A0572910484375BBC0DB63AB4EA131011C35D6069A3FEBA9A99C0C26181A4EFFDA8B897C0C265A586CDEDD9A9A80BC269A466BBEEDBB80B81C267A5789CDEEBDA890EC365A589BDFECDB899C363A187BD7303A2DDCA89C3608162687102A2EFCA99C35EA1789D6F030D15A1BA8AC358825C690716A1E9B922C354A177684E26A24B8898C34CA177563F34A2197787C445A4664568667731C442A46539AC647737C440A4636EF965563BC53E3D414BA2E354653FC5434B5BA393345545C65DA3D6314655E0"
Const sSampleTemplate2 = "A1CA1482AF114AA1464C134C00234712629418392B5C0008539B5454094A2B40BC165F2256E30A4F1C37003DCF9739F114C91A5EBC07B6264482106411470031549C4D510F54A02AFC2E09A51E1223942C5D5409C3955B42093C314FB808CE0E4E544727222EB8129053040413B914670C1011C6465248C0C5575C616713C0C353A18EDD72182027C0C24DA2A9DEBB27272A28C0C249A18ACD554937333433C0C243A289DF91413E3B3DC0C142A1569F52A2931478C0C1403A352C695EA2131468C0C13D332310016A5BA1034545C0C2170F09016B5DA1133445C0C20C0A090264A122434CC0C20C090803675EA15364C0C308050170635E5958C0C403017469625DE2CC47434040CC484640E0"
Const sSampleTemplate3 = "A1CA0F819B3A3FE11431BB3CC0143EAD46D40A48B56DC00A24C151540A9E4245BC12A1403FE32D1DB8580008ADB23A310745216CFC1277AA59C2124CBE35401154C13BD14E441F4EFC095C2B35920D5125D44B1A1011C03735C03B3DC03B40C03A3FC46269C174A1AB9BC03B3DC362A38B8CFCBC0AC0C455A1E8BA636DA1FECE0EC458A278ACBF72040B1114C458A2578CDF70040F1618C352A29967AD606E04141A1BC34EA2A587AA586A07181D1DC350A3756687B41D1D2122C350A36445678129222324C352A5450438730198C3514F4940A31386324A25C355524C3E33A3166355FBC3595B543428A3478446FBC46162102082A1456EE0"
Const sSampleTemplate4 = "A1CA1A82982C456107C4AF3CC00FC93046D415CD3E51400CD84154140DDC1C58BC1D369B332305CFA96D00144A9E4E712D4F236CFC0E3F2472C20A33A554000EC0A350D114523731FC0DD833689209D54160140CE1BE18420BE5331DF80ED73B481405D9A71C3808C9154DE41DE71E18380558922F0103CF0A41C00BDD11249207CBAF64800AC853F46614AEC06B1D1011C556575F6E7709C0C453585B636F740819C0C353A1ABDF6D7508181C21C0C24FA1BBBC626A750D1C212326C0C251A1AAAC5F69021521A1E9AAC152A2899BAC66051F28A1B889C151A289A99B5C2CA26C9678C151A298999A514035A186552BC151A6A7A88820145326C152A6B7978754351105C154A4A98769765444392D287E4755A4B9A6697776504126237E455BA4B87878876A5D68131A7E4463A2977677825F656F060FC16BA4867556879B69710105C171A6774658688BEDDBC176A667366A678ADBA9C277A56277A6889BA9E0"


Const sSampleTemplate = _
        "A1CA168293AF5A613A3A2F5DC02B343C591413BCBE54C01FBA3E49143CB33F4BFC59C" + _
        "03E56E31C613158801244316B710B35BD5F3C0D51A866C2261A3C6E400B46B7375109" + _
        "44AC41FC0D4EA043521460245C940C6CAD5C827E25AE5978424CBE79140A44C144B83" + _
        "E9DA36BA40D10456138115B3A44EB16B2D40F121011E3C863646C7273C0C767A28CFB" + _
        "CAC0C664A2D9ECAC03C0C561A39BBEEBCB0CC0C560A179BE7177050D1318C456A1B8A" + _
        "C646F030F171C20C454A1988B5C6A141D232627C450814F504E3E2AA189A8C44DA365" + _
        "77520682C448A4566867576635C447A4228CB9756539C53F3436414AA2874367C52E1" + _
        "70C655B52A1253540C605036D6054A11545E0"

'Public vMachineNumber
Dim lngErrorCode As Long
Dim bConnected As Boolean
Dim connFP As New ADODB.Connection
Dim recFP As New ADODB.Recordset
Dim OnFingerTime As Long
Dim VerifyTime As Long

Function Str2Byte(s As String, Index As Integer) As Byte
    Dim b1 As Byte, b2 As Byte
    Dim s1 As String, s2 As String
    
    s1 = Mid(s, Index * 2 + 1, 1)
    s2 = Mid(s, Index * 2 + 2, 1)
    If s1 >= "A" Then
        b1 = Asc(s1) - Asc("A") + 10
    Else
        b1 = Asc(s1) - Asc("0")
    End If
    If s2 >= "A" Then
        b2 = Asc(s2) - Asc("A") + 10
    Else
        b2 = Asc(s2) - Asc("0")
    End If
    Str2Byte = b1 * 16 + b2
End Function

Function Str2ByteArray(s As String, b() As Byte) As Integer
    Dim i As Integer
    Dim l As Integer
    l = Len(s) / 2
    For i = 0 To l - 1 Step 1
        b(i) = Str2Byte(s, i)
    Next
    Str2ByteArray = l
End Function

Function Str2LongArray(s As String, ldata() As Long) As Integer
    Dim i As Integer
    Dim lbyte As Integer, llong As Integer, l As Long
    Dim b(1024 * 4) As Byte
    lbyte = Str2ByteArray(s, b)
    llong = lbyte / 4
    If llong * 4 < lbyte Then llong = llong + 1
    For i = 0 To llong - 1 Step 1
        l = b(i * 4 + 3)
        If l > 127 Then
            l = (((l - 128) * 256 + b(i * 4 + 2)) * 256 + b(i * 4 + 1)) * 256 + b(i * 4)
            l = l - 2147483647
            l = l - 1
        Else
            l = ((l * 256 + b(i * 4 + 2)) * 256 + b(i * 4 + 1)) * 256 + b(i * 4)
        End If
        ldata(i) = l
    Next
    Str2LongArray = llong
End Function


Private Sub cmd1To1Mode_Click()
    If CZKEM1.SetDeviceInfo(vMachineNumber, 35, 1) Then
        lblInfo.Caption = "Set 1:1 Mode OK"
    Else
        lblInfo.Caption = "Set 1:1 Mode Fail"
    End If
End Sub

Private Sub cmd1ToNMode_Click()
    If CZKEM1.SetDeviceInfo(vMachineNumber, 35, 0) Then
        lblInfo.Caption = "Set 1:N Mode OK"
    Else
        lblInfo.Caption = "Set 1:N Mode Fail"
    End If

End Sub

Sub ShowButtonState()
    cmdSetDeviceTime.Enabled = bConnected
    cmdThreshold.Enabled = bConnected
    cmdSSR_DelUserTmp.Enabled = bConnected
    cmdSSR_SetUserTmpStr.Enabled = bConnected
    cmdDateFormat.Enabled = bConnected
    cmd1To1Mode.Enabled = bConnected
    cmd1ToNMode.Enabled = bConnected
    cmdUpdateFirmware.Enabled = bConnected
    cmdSSR_GetUserTmpStr.Enabled = bConnected
    
    cmdSSR_DeleteEnrollData.Enabled = bConnected
End Sub


Private Sub cmdAC_Click()
    formAC.Show
    
End Sub

Private Sub cmdCancel_Click()
    If CZKEM1.CancelOperation Then
        txtEvent.Text = "CancelOperation" & Chr(13) & Chr(10) & txtEvent
    Else
        CZKEM1.GetLastError lngErrorCode
        txtEvent.Text = "CancelOperation failed [" & lngErrorCode & "]" & Chr(13) & Chr(10) & txtEvent
    End If
End Sub

Private Sub cmdClearGLog_Click()
    If CZKEM1.ClearGLog(vMachineNumber) Then
        lblInfo.Caption = "ClearGLog OK"
    Else
        lblInfo.Caption = "ClearGLog fail"
    End If
End Sub

Private Sub cmdClearSMS_Click()
    If CZKEM1.ClearSMS(vMachineNumber) Then
        lblInfo.Caption = "ClearSMS OK"
    Else
        lblInfo.Caption = "ClearSMS fail"
    End If
End Sub

Private Sub cmdClearUserSMS_Click()
    If CZKEM1.ClearUserSMS(vMachineNumber) Then
        lblInfo.Caption = "ClearUserSMS OK"
    Else
        lblInfo.Caption = "ClearUserSMS fail"
    End If
End Sub
Function ConnectDevice()
    Dim ver As String
    Dim com
    Dim baudrate
    
    If bConnected Then
        CZKEM1.Disconnect
    Else
        If OptionEthernet.Value Then
            If CZKEM1.Connect_Net(txtIP.Text, 4370) Then
                If CZKEM1.GetFirmwareVersion(vMachineNumber, ver) Then
                    lblInfo.Caption = "Version=""" & ver & """"
                    If CZKEM1.GetDeviceIP(vMachineNumber, ver) Then
                        lblInfo.Caption = lblInfo.Caption & ", IP=" & ver
                       CZKEM1.RegEvent vMachineNumber, 32767
                    End If
                End If
            Else
                Beep
                lblInfo.Caption = "Connect fail."
            End If
        Else
            vMachineNumber = CLng(txtMahcineNum)
            com = CLng(Mid(txtIP.Text, 4, Len(txtIP.Text) - 3))
            baudrate = CLng(txtBaudRate)
            If CZKEM1.Connect_Com(com, vMachineNumber, baudrate) Then
                If CZKEM1.GetFirmwareVersion(vMachineNumber, ver) Then
                    lblInfo.Caption = "Version=""" & ver & """"
                    If CZKEM1.GetDeviceIP(vMachineNumber, ver) Then
                        lblInfo.Caption = lblInfo.Caption & ", IP=" & ver
                        CZKEM1.RegEvent vMachineNumber, 32767
                    End If
                End If
            Else
                Beep
                lblInfo.Caption = "Connect fail."
            End If
        End If
    End If
End Function

Private Sub cmdSSR_ClearWorkCode_Click()
    If CZKEM1.SSR_ClearWorkCode() Then
        lblInfo.Caption = "ClearWorkCode OK"
    Else
        lblInfo.Caption = "ClearWorkCode Fail"
    End If
    TextWorkCode.Text = ""
End Sub

Private Sub cmdConnect_Click()
    ConnectDevice
End Sub

Private Sub cmdDateFormat_Click()
    If CZKEM1.SetDeviceInfo(vMachineNumber, 34, cmbDateFormats.ListIndex) Then
        lblInfo.Caption = "Set Date Format OK"
    Else
        lblInfo.Caption = "Set Date Format Fail"
    End If
End Sub

Private Sub cmdDeleteSMS_Click()
    Dim b As Boolean
    
    If CZKEM1.DeleteSMS(vMachineNumber, val(textID.Text)) Then
        lblInfo.Caption = "DeleteSMS OK"
    Else
        lblInfo.Caption = "DeleteSMS fail"
    End If
End Sub

Private Sub cmdSSR_DeleteWorkCode_Click()
    If StrComp(TextWorkCode.Text, "") Then
        If CZKEM1.SSR_DeleteWorkCode(val(TextWorkCode.Text)) Then
            CZKEM1.RefreshData vMachineNumber
            lblInfo.Caption = "DeleteWorkCode OK"
        Else
            lblInfo.Caption = "DeleteWorkCode fail"
        End If
    Else
        lblInfo.Caption = "DeleteWorkCode fail"
    End If
    TextWorkCode.Text = ""
End Sub

Private Sub cmdSSR_GetWorkCode_Click()
    Dim WorkCode
    Dim Name As String
    WorkCode = val(TextWorkCode.Text)
    
    If StrComp(TextWorkCode.Text, "") Then
        If CZKEM1.SSR_GetWorkCode(WorkCode, Name) Then
            TextName.Text = Name
            MsgBox "GetWorkCode:  " + Name + "  success"
            lblInfo.Caption = "GetWorkCode OK"
        Else
            TextWorkCode.Text = ""
            lblInfo.Caption = "GetWorkCode fail"
        End If
    Else
        lblInfo.Caption = "GetWorkCode fail"
    End If
End Sub

Private Sub cmdSSR_SetWorkCode_Click()
    Dim WorkCode As Long
    If (StrComp(TextName.Text, "") And StrComp(TextWorkCode.Text, "")) Then
        WorkCode = val(TextWorkCode.Text)
        If CZKEM1.SSR_SetWorkCode(val(WorkCode), TextName.Text) Then
            CZKEM1.RefreshData vMachineNumber
            lblInfo.Caption = "SetWorkCode OK"
            MsgBox "SetWorkCode  " + TextName.Text + "  success"
        Else
            lblInfo.Caption = "SetWorkCode fail"
        End If
    Else
        lblInfo.Caption = "SetWorkCode fail"
    End If
End Sub

Private Sub cmdSSR_DeleteEnrollData_Click()
    Dim EnrollNumber, iBackupNumber
    EnrollNumber = txtUserID.Text
    
    iBackupNumber = 12
        If CZKEM1.SSR_DeleteEnrollData(vMachineNumber, EnrollNumber, iBackupNumber) Then
            lblInfo.Caption = "SSR_DeleteEnrollData OK"
        Else
            lblInfo.Caption = "SSR_DeleteEnrollData fail"
        End If
End Sub

Private Sub cmdSSR_DeleteUserSMS_Click()
    Dim b As Boolean
    If CZKEM1.SSR_DeleteUserSMS(vMachineNumber, textEnrollNumber.Text, CLng(textID.Text)) Then
        lblInfo.Caption = "SSR_DeleteUserSMS OK"
    Else
        lblInfo.Caption = "SSR_DeleteUserSMS fail"
    End If
End Sub

Private Sub cmdGetCardFun_Click()
    Dim CardFun As Long
    If CZKEM1.GetCardFun(vMachineNumber, CardFun) Then
        MsgBox CStr(CardFun)
    End If
End Sub

Private Sub cmdGetSMS_Click()
    Dim Tag As Long
    Dim ValidMinutes As Long
    Dim StartTime As String
    Dim Content As String
    If CZKEM1.GetSMS(vMachineNumber, val(textID.Text), Tag, ValidMinutes, StartTime, Content) Then
        textContent.Text = Content
        textTag.Text = Tag
        textValidTime.Text = ValidMinutes
        textStartTime.Text = StartTime
        lblInfo.Caption = "GetSMS OK"
    Else
        lblInfo.Caption = "GetSMS Fail"
    End If
    
End Sub

Private Sub cmdGetTime_Click()
   Dim iYear As Long, iMonth As Long, iDay As Long, iHour As Long, iMinute As Long, iSecond As Long
   
   If CZKEM1.GetDeviceTime(vMachineNumber, iYear, iMonth, iDay, iHour, iMinute, iSecond) Then
        lblInfo.Caption = "Device Time is " & iYear & "-" & iMonth & "-" & iDay & " " & iHour & ":" & iMinute & ":" & iSecond
   Else
        lblInfo.Caption = "GetDeviceTime fail"
   End If
End Sub
Private Sub cmdSSR_GetUserInfo_Click()
    Dim iEnrollNumber
    iEnrollNumber = txtUserID.Text
    Dim sUserName As String
    Dim sPassword As String
    Dim dwPrivilege As Long
    Dim bEnable As Boolean
    CZKEM1.ReadAllUserID (vMachineNumber)
    If CZKEM1.SSR_GetUserInfo(vMachineNumber, iEnrollNumber, sUserName, sPassword, dwPrivilege, bEnable) Then
        lblInfo.Caption = "SSR_GetUserInfo OK"
        textUserName.Text = sUserName
        textPassword.Text = sPassword
        textPrivilege.Text = CStr(dwPrivilege)
        TextEnable.Text = CStr(bEnable)
        textCardNumber0.Text = CZKEM1.CardNumber(0)
        textCardNumber1.Text = CZKEM1.CardNumber(1)
    Else
        lblInfo.Caption = "SSR_GetUserInfo fail"
    End If
End Sub

Private Sub cmdSSR_GetUserTmpStr_Click()
    Dim iEnrollNumber, iBackupNumber
    Dim sTmpData As String
    Dim tmpLength As Long
    iEnrollNumber = txtUserID.Text
    iBackupNumber = 0
    If CZKEM1.SSR_GetUserTmpStr(vMachineNumber, iEnrollNumber, iBackupNumber, sTmpData, tmpLength) Then
        lblInfo.Caption = "SSR_GetUserTmpStr OK"
        recFP.Open "select * from fptable", connFP, adOpenKeyset, adLockOptimistic
        recFP.AddNew
        recFP.Fields("EnrollNumber") = iEnrollNumber
        recFP.Fields("FingerNumber") = iBackupNumber
        recFP.Fields("Template") = sTmpData
        recFP.Update
        recFP.Close
        MsgBox sTmpData, , "Template" & iBackupNumber & " of " & iEnrollNumber
        
    Else
        lblInfo.Caption = "SSR_GetUserTmpStr Fail"
    End If
End Sub

Private Sub cmdGetVerifyMode_Click()
    Dim val As Integer
    If CZKEM1.GetDeviceInfo(vMachineNumber, 35, val) Then
        Text1.Text = val
    Else
        lblInfo.Caption = "GetDeviceInfo failed!"
    End If
End Sub

Private Sub cmdIdentify_Click()
    If CZKEM1.StartIdentify Then
        txtEvent.Text = "StartIdentify" & Chr(13) & Chr(10) & txtEvent
    Else
        CZKEM1.GetLastError lngErrorCode
        txtEvent.Text = "StartIdentify failed [" & lngErrorCode & "]" & Chr(13) & Chr(10) & txtEvent
    End If
End Sub

Private Sub cmdSSR_ReadAllGLogData_Click()
    Dim EnrollNumber As String
    Dim dwVerifyMode As Long
    Dim dwInOutMode As Long
    Dim timeStr As String
    Dim dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond, dwWorkcode, dwReserved As Long
    
    cmdSSR_ReadAllGLogData.Enabled = False
   ' If CZKEM1.ReadGeneralLogData(vMachineNumber) Then
     If CZKEM1.ReadAllGLogData(vMachineNumber) Then
        lblInfo.Caption = "ReadAllGLogData OK"
        While CZKEM1.SSR_GetGeneralLogData(vMachineNumber, EnrollNumber, dwVerifyMode, dwInOutMode, dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond, dwWorkcode)
            txtEvent.Text = EnrollNumber & "," & dwVerifyMode & "," & dwInOutMode & "," & dwWorkcode & "," & dwYear & "-" & dwMonth & "-" & dwDay & "," & dwHour & ":" & dwMinute & ":" & dwSecond & Chr(13) & Chr(10) & txtEvent.Text
        Wend
    Else
        lblInfo.Caption = "ReadAllGLogData fail"
    End If
    cmdSSR_ReadAllGLogData.Enabled = True
    
End Sub

Private Sub cmdReadAllUser_Click()
    cmdReadAllUser.Enabled = False
    If CZKEM1.ReadAllUserID(vMachineNumber) Then
        lblInfo.Caption = "ReadAllUserID OK"
    Else
        lblInfo.Caption = "ReadAllUserID fail"
    End If
    cmdReadAllUser.Enabled = True
   
End Sub


Private Sub cmdReadCustData_Click()
    Dim custData As String
    If CZKEM1.ReadCustData(vMachineNumber, custData) Then
        textCustData.Text = custData
        lblInfo.Caption = "ReadCustData OK"
    Else
        lblInfo.Caption = "ReadCustData Fail"
    End If
End Sub

Private Sub cmdReadUserInfo_Click()
    Dim iEnrollNumber, iBackupNumber
    Dim sTmpData As String
    Dim tmpLength As Long
    Dim sName As String
    Dim dwPrivilege As Long
    Dim bEnable As Boolean
    Dim sPassword As String
   
    iEnrollNumber = txtUserID.Text
    iBackupNumber = 0
    If CZKEM1.SSR_GetUserInfo(vMachineNumber, iEnrollNumber, sName, sPassword, dwPrivilege, bEnable) Then
        lblInfo.Caption = "GetUserInfo OK"
        textUserName.Text = sName
        textPassword.Text = sPassword
        textPrivilege.Text = CStr(dwPrivilege)
        TextEnable.Text = CStr(bEnable)
    Else
        lblInfo.Caption = "GetUserInfo Fail"
    End If


End Sub

Private Sub cmdSetDeviceTime_Click()
    Dim iYear, iMonth, iDay, iHour, iMinute, iSecond
    iYear = CLng(txtYear.Text)
    iMonth = CLng(txtMonth.Text)
    iDay = CLng(txtDay.Text)
    iHour = CLng(txtHour.Text)
    iMinute = CLng(txtMinute.Text)
    iSecond = CLng(txtSecond.Text)
    If Not CZKEM1.SetDeviceTime2(vMachineNumber, iYear, iMonth, iDay, iHour, iMinute, iSecond) Then
        lblInfo.Caption = "SetDeviceTime2 fail"
    Else
        lblInfo.Caption = "SetDeviceTime2 OK"
    End If
End Sub



Private Sub cmdSetSMS_Click()
    Dim SMSID
    Dim SmsTag
    Dim ValidMinutes
    Dim StartTime
    Dim Content
    Dim b
    SMSID = val(textID.Text)
    Content = textContent.Text
    SmsTag = val(textTag.Text)
    ValidMinutes = val(textValidTime.Text)
    StartTime = textStartTime.Text
    If CZKEM1.SetSMS(vMachineNumber, SMSID, SmsTag, ValidMinutes, StartTime, Content) Then
        lblInfo.Caption = "Set SMS OK"
    Else
        lblInfo.Caption = "Set SMS fail"
    End If
End Sub

Private Sub cmdSetTimeZones_Click()
    Dim tzs(3) As Long
    tzs(1) = 0
    If CZKEM1.SetUserTZs(vMachineNumber, CLng(textUserID.Text), tzs(1)) Then
        lblInfo.Caption = "SetUserTZs OK"
    End If
End Sub


Private Sub cmdSSR_SetUserInfo_Click()
    Dim iEnrollNumber
    Dim bEnrollData(1024) As Byte
    iEnrollNumber = txtUserID.Text
    If textCardNumber0.Text <> "" Then
        CZKEM1.CardNumber(0) = CLng(textCardNumber0.Text)
        CZKEM1.CardNumber(1) = CLng(textCardNumber1.Text)
    End If
    If CZKEM1.SSR_SetUserInfo(vMachineNumber, iEnrollNumber, textUserName.Text, textPassword.Text, 0, True) Then
        lblInfo.Caption = "SSR_SetUserInfo OK"
        CZKEM1.RefreshData (vMachineNumber)
    Else
        lblInfo.Caption = "SSR_SetUserInfo fail"
    End If
End Sub

Private Sub cmdSSR_SetUserSMS_Click()
    Dim b
    CZKEM1.SetSMS vMachineNumber, val(textID.Text), 254, val(textValidTime.Text), textStartTime.Text, textContent.Text
    If CZKEM1.SSR_SetUserSMS(vMachineNumber, textEnrollNumber.Text, CLng(textID.Text)) Then
        lblInfo.Caption = "SSR_SetUserSMS OK"
    Else
        lblInfo.Caption = "SSR_SetUserSMS fail"
    End If
    
End Sub

Private Sub cmdSSR_DelUserTmp_Click()
    Dim iEnrollNumber, iBackupNumber
    iEnrollNumber = txtUserID.Text
    Dim flag As Integer
    flag = 0
    For iBackupNumber = 0 To 9
        If CZKEM1.SSR_DelUserTmp(vMachineNumber, iEnrollNumber, iBackupNumber) Then
            flag = flag + 1
        End If
    Next iBackupNumber
    If flag Then
        lblInfo.Caption = "SSR_DelUserTmp OK"
    Else
        lblInfo.Caption = "SSR_DelUserTmp fail"
    End If
End Sub

Private Sub cmdSSR_SetUserTmpStr_Click()
    Dim iEnrollNumber, iEMachineNumber, iBackupNumber
    Dim sEnrollData
    iEnrollNumber = txtUserID.Text
    iEMachineNumber = 1
    iBackupNumber = 0
    sEnrollData = sSampleTemplate3
    If CZKEM1.SSR_SetUserTmpStr(vMachineNumber, iEnrollNumber, iBackupNumber, sEnrollData) Then
        lblInfo.Caption = "SSR_SetUserTmpStr OK"
    Else
        CZKEM1.GetLastError lngErrorCode
        lblInfo.Caption = "SSR_SetUserTmpStr fail [" & lngErrorCode & "]"
    End If
End Sub


Private Sub cmdStartEnroll_Click()
    If CZKEM1.StartEnroll(CLng(TxtUserID1.Text), CLng(TxtFingerID.Text)) Then
        txtEvent.Text = "Start Enroll,Please palce your finger" & Chr(13) & Chr(10) & txtEvent.Text
    Else
        CZKEM1.GetLastError lngErrorCode
        txtEvent.Text = "Start Enroll failed [" & lngErrorCode & "]" & Chr(13) & Chr(10) & txtEvent.Text
    End If
End Sub

Private Sub cmdThreshold_Click()
    If CZKEM1.SetDeviceInfo(vMachineNumber, 23, CLng(txt1NThreshold.Text)) Then
        lblInfo.Caption = "Set 1:N Threshold OK"
    Else
        lblInfo.Caption = "Set 1:N Threshold Fail"
    End If
    If CZKEM1.SetDeviceInfo(vMachineNumber, 25, CLng(txt11Threshold.Text)) Then
        lblInfo.Caption = "Set 1:1 Threshold OK"
    Else
        lblInfo.Caption = "Set 1:1 Threshold Fail"
    End If
End Sub


Private Sub cmdUpdateFirmware_Click()
    Dim sFile
    On Error GoTo cancelline
    CommonDialog1.ShowOpen
    
    sFile = CommonDialog1.FileName
    'Disbale device to speed up firmware transfer
    CZKEM1.DisableDeviceWithTimeOut vMachineNumber, 10
    If CZKEM1.UpdateFirmware(sFile) Then
        lblInfo.Caption = "Update Firmware success."
    Else
        lblInfo.Caption = "Update Firmware fail."
    End If
cancelline:
End Sub

Private Sub cmdVerify_Click()
    If CZKEM1.StartVerify(CLng(TxtUserID1.Text), CLng(TxtFingerID.Text)) Then
        txtEvent.Text = "StartVerify" & Chr(13) & Chr(10) & txtEvent
    Else
        CZKEM1.GetLastError lngErrorCode
        txtEvent.Text = "StartVerify failed [" & lngErrorCode & "]" & Chr(13) & Chr(10) & txtEvent
    End If
End Sub

Private Sub cmdWriteCustData_Click()
    Dim custData
    custData = textCustData.Text
    If CZKEM1.WriteCustData(vMachineNumber, custData) Then
        lblInfo.Caption = "WriteCustData OK"
    Else
        lblInfo.Caption = "WriteCustData Fail"
    End If
End Sub

Private Sub Command1_Click()

    If CZKEM1.SetUserGroup(vMachineNumber, CLng(textUserID.Text), CLng(textGroup.Text)) Then
        lblInfo.Caption = "SetUserGroup OK"
    End If
End Sub



Private Sub Command2_Click()
  ReadExitingData (1)
End Sub

Private Sub Command3_Click()
Dim dwEnrollNumber As Long

    Dim dwVerifyMode As Long

    Dim dwInOutMode As Long

    Dim timeStr As String

    Dim i As Long

    Dim dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond, dwWorkcode, dwReserved As Long

    

    '2006-4-24 henry modify.

    Dim fso, txtfile

    Dim LogStr As String

 

'    lvX.Refresh

'    lvX.ListItems.Clear

    If CZKEM1.ReadGeneralLogData(1) Then

        
      End If
'        CZKEM1.ReadAllUserID 1

        While CZKEM1.GetGeneralExtLogData(1, dwEnrollNumber, dwVerifyMode, dwInOutMode, dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond, dwWorkcode, dwReserved)

               ' lvX.ListItems.Add i, , dwEnrollNumber

              '  With lvX.ListItems(i)

                    timeStr = CStr(dwYear) + "-" + CStr(dwMonth) + "-" + CStr(dwDay) + "  " + CStr(dwHour) + ":" + CStr(dwMinute) + ":" + CStr(dwSecond)

'                    .SubItems(1) = IIf(IsNull(dwVerifyMode), "", dwVerifyMode)
'
'                    .SubItems(2) = IIf(IsNull(dwInOutMode), "", dwInOutMode)
'
'                    .SubItems(3) = IIf(IsNull(timeStr), "", timeStr)
'
'                    .SubItems(4) = dwWorkcode

                 '   DoEvents

              ' End With
                txtEvent.Text = timeStr + "  workcode=" + CStr(dwWorkcode) & Chr(13) & Chr(10) & txtEvent.Text
                

        Wend

    

End Sub

Private Sub CZKEM1_OnAlarm(ByVal AlarmType As Long, ByVal EnrollNumber As Long, ByVal Verified As Long)
     txtEvent.Text = "OnAlarm(" & AlarmType & "," & EnrollNumber & "," & Verified & ")" & Chr(13) & Chr(10) & txtEvent.Text
End Sub

'Private Sub CZKEM1_OnAlarm(ByVal AlarmType As Long, ByVal Verified As Long)
'    txtEvent.Text = "OnAlarm(" & AlarmType & "," & CStr(Verified) & ")" & Chr(13) & Chr(10) & txtEvent.Text
'End Sub

Private Sub CZKEM1_OnAttTransaction(ByVal EnrollNumber As Long, ByVal IsInValid As Long, _
    ByVal AttState As Long, ByVal VerifyMethod As Long, ByVal Year As Long, ByVal Month As Long, _
    ByVal Day As Long, ByVal Hour As Long, ByVal Minute As Long, ByVal Second As Long)
    txtEvent.Text = "OnAttTransaction(ID=" & EnrollNumber & ",IsInValid=" & _
        IsInValid & ",State=" & AttState & ",VM=" & VerifyMethod & _
        "," & Year & "-" & Month & "-" & Day & " " & Hour & ":" & Minute & ":" & Second & Chr(13) & Chr(10) & txtEvent.Text
End Sub

Private Sub CZKEM1_OnAttTransactionEx(ByVal EnrollNumber As String, ByVal IsInValid As Long, ByVal AttState As Long, ByVal VerifyMethod As Long, ByVal Year As Long, ByVal Month As Long, ByVal Day As Long, ByVal Hour As Long, ByVal Minute As Long, ByVal Second As Long, ByVal WorkCode As Long)

    txtEvent.Text = "OnAttTransactionEx(ID=" & EnrollNumber & ",IsInValid=" & _
        IsInValid & ",State=" & AttState & ",VM=" & VerifyMethod & _
        "," & Year & "-" & Month & "-" & Day & " " & Hour & ":" & Minute & ":" & Second & ",WorkCode=" & WorkCode & Chr(13) & Chr(10) & txtEvent.Text
End Sub

Private Sub CZKEM1_OnConnected()
    Dim i As Integer
    Dim var1 As String
    txtEvent.Text = "OnConnected" & Chr(13) & Chr(10) & txtEvent.Text
    bConnected = True
    cmdConnect.Caption = "Disconnect"
    lblInfo.Caption = "Connected to device."
    ShowButtonState

   '  ReadExitingData (1)
End Sub

Private Sub CZKEM1_OnDisConnected()
    txtEvent.Text = "OnDisConnected" & Chr(13) & Chr(10) & txtEvent.Text
    bConnected = False
    cmdConnect.Caption = "Connect"
    lblInfo.Caption = "Disconnected from device."
    ShowButtonState
End Sub

Private Sub CZKEM1_OnDoor(ByVal EventType As Long)
     txtEvent.Text = "OnDoor(" & EventType & ")" & Chr(13) & Chr(10) & txtEvent.Text
End Sub

Private Sub CZKEM1_OnEnrollFinger(ByVal EnrollNumber As Long, ByVal FingerIndex As Long, ByVal ActionResult As Long, ByVal TemplateLength As Long)
    If ActionResult = 0 Then
        txtEvent.Text = "OnEnrollFinger(" & EnrollNumber & "," & FingerIndex & "," & ActionResult & "," & TemplateLength & ")" & Chr(13) & Chr(10) & txtEvent.Text
    Else
        txtEvent.Text = "Enroll failed! OnEnrollFinger(" & EnrollNumber & "," & FingerIndex & "," & ActionResult & "," & TemplateLength & ")" & Chr(13) & Chr(10) & txtEvent.Text
    End If
End Sub

Private Sub CZKEM1_OnFinger()
    OnFingerTime = GetTickCount
    txtEvent.Text = "OnFinger" & Chr(13) & Chr(10) & txtEvent.Text
    
End Sub

Private Sub CZKEM1_OnFingerFeature(ByVal Score As Long)
    txtEvent.Text = "OnFingerFeature(" & Score & ")" & Chr(13) & Chr(10) & txtEvent.Text

End Sub


Private Sub CZKEM1_OnHIDNum(ByVal CardNumber As Long)
    txtEvent.Text = "OnHIDNum(" & CardNumber & ")" & Chr(13) & Chr(10) & txtEvent.Text
End Sub

Private Sub CZKEM1_OnKeyPress(ByVal Key As Long)
    txtEvent.Text = "OnKeyPress(" & Key & ")" & Chr(13) & Chr(10) & txtEvent.Text
End Sub

Private Sub CZKEM1_OnNewUser(ByVal EnrollNumber As Long)
    txtEvent.Text = "OnNewUser(" & EnrollNumber & ")" & Chr(13) & Chr(10) & txtEvent.Text

End Sub

Private Sub CZKEM1_OnVerify(ByVal UserID As Long)
    VerifyTime = GetTickCount - OnFingerTime
    txtEvent.Text = "OnVerify(" & UserID & ")" & "¡¾" & VerifyTime & "¡¿" & Chr(13) & Chr(10) & txtEvent.Text

End Sub

Private Sub Form_Load()
    Dim s As String
    cmbDateFormats.ListIndex = 0
    bConnected = False
    ShowButtonState
    CZKEM1.BASE64 = 0
    vMachineNumber = 1
    connFP.Open "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "FPData.mdb;Persist Security Info=False"
    CZKEM1.GetSDKVersion s
    Label6.Caption = "SDK Version:" & s
End Sub

Private Sub OptionCom_Click()
    txtIP.Text = "COM1"
End Sub

Private Sub OptionEthernet_Click()
    txtIP.Text = "192.168.1.201"
End Sub

Public Function ReadExitingData(Index As Integer) As Long
        Dim dwEnrollNumber As Long
        Dim dwEnrollNumberStr As String
        Dim dwVerifyMode As Long
        Dim dwInOutMode As Long
        Dim WorkCode As Long
        Dim Res As Long
        Dim YYYY As Long, MM As Long, DD As Long, HH As Long, MN As Long, SS As Long
        Dim timeStr As String
        Dim i As Long
       ' ShowBusy "Reading Logs from machine : " & GetMachineName(Index), True
        Dim StartTime As Long
        Dim defMachineNo As Integer
        defMachineNo = 1
        CZKEM1.EnableDevice defMachineNo, False
        
        CZKEM1.ReadAllGLogData defMachineNo
      '  CZKEM1.ClearGLog defMachineNo
      '  CZKEM1.EnableDevice defMachineNo, True
        
        Dim J As Long
            
        Debug.Print "ReadAll:"; Timer - StartTime
        'Dim OutputFields As clsOutputFields
        Dim TransDate As String

'        If CZKEM1.IsTFTMachine(defMachineNo) Then
'         Do While CZKEM1.SSR_GetGeneralLogData(defMachineNo, dwEnrollNumberStr, dwVerifyMode, dwInOutMode, YYYY, MM, DD, HH, MN, SS, WorkCode)
'            Set OutputFields = New clsOutputFields
'            timeStr = PadData(YYYY, 4) & " " & PadData(MM, 2) & " " & PadData(DD, 2) & " " & PadData(HH, 2) & " " & PadData(MN, 2) & " " & PadData(SS, 2)
'            YYYY = Mid(timeStr, 1, 4)
'            MM = Mid(timeStr, 6, 2)
'            DD = Mid(timeStr, 9, 2)
'            HH = Mid(timeStr, 12, 2)
'            MN = Mid(timeStr, 15, 2)
'            SS = Mid(timeStr, 18, 2)
'            TransDate = DD & " " & MonthName(MM) & " " & YYYY & " " & HH & ":" & MN & ":" & SS
'            With OutputFields
'                .Add "Machineno", AllDevices(Index).MachineNo
'                .Add "LocationName", AllDevices(Index).LocationName
'                .Add "EnrollNumber", val(dwEnrollNumberStr)
'                .Add "AttState", dwInOutMode
'                .Add "VerifyMethod", dwVerifyMode
'                .Add "TransDate", TransDate
'                .Add "YYYY", YYYY
'                .Add "YY", PadData(Right(YYYY, 2))
'                .Add "MM", PadData(MM)
'                .Add "MMM", MonthName(MM, True)
'                .Add "DD", PadData(DD)
'                .Add "HH", PadData(HH)
'                .Add "MN", PadData(MN)
'                .Add "SS", PadData(SS)
'                .Add "WorkCode", PadData(WorkCode)
'            End With
'  txtEvent.Text = dwEnrollNumberStr & "," & dwVerifyMode & "," & dwInOutMode & "," & WorkCode & "," & YYYY & "-" & MM & "-" & DD & "," & HH & ":" & MN & ":" & SS & Chr(13) & Chr(10) & txtEvent.Text
            
           ' StoreData Index, OutputFields
           ' ShowInTable Index, OutputFields
           ' SendToClients Index, OutputFields
            
'            CNAttLogs.Execute "INSERT INTO Logs (MachineNo, LocationName, EnrollNumber, IsInValid, AttState, VerifyMethod, YYYY, MM, DD, HH, MN, SS,Exported,WorkCode) " & _
'                " Values('" & AllDevices(Index).MachineNo & "','" & AllDevices(Index).LocationName & "'," & dwEnrollNumber & "," & 0 & "," & dwInOutMode & "," & dwVerifyMode & "," & YYYY & "," & MM & "," & DD & "," & HH & "," & MN & "," & SS & ",False," & WorkCode & ")"
'            If GetParam("ExportEnable", "FALSE") = "TRUE" Then
'                frmExportData.cmdExport_Click
'            End If
'
'            I = I + 1
'            ShowBusy "Reading " & I & " Logs from machine : " & GetMachineName(Index), True
'         Loop
'         End If
'        Else
         Do While CZKEM1.GetGeneralExtLogData(defMachineNo, dwEnrollNumber, dwVerifyMode, dwInOutMode, YYYY, MM, DD, HH, MN, SS, WorkCode, Res)   'CZKEM(Index).GetGeneralLogDataStr(defMachineNo, dwEnrollNumber, dwVerifyMode, dwInOutMode, timeStr)
'            Set OutputFields = New clsOutputFields
            timeStr = PadData(YYYY, 4) & " " & PadData(MM, 2) & " " & PadData(DD, 2) & " " & PadData(HH, 2) & " " & PadData(MN, 2) & " " & PadData(SS, 2)
            YYYY = Mid(timeStr, 1, 4)
            MM = Mid(timeStr, 6, 2)
            DD = Mid(timeStr, 9, 2)
            HH = Mid(timeStr, 12, 2)
            MN = Mid(timeStr, 15, 2)
            SS = Mid(timeStr, 18, 2)
            TransDate = DD & " " & MonthName(MM) & " " & YYYY & " " & HH & ":" & MN & ":" & SS
            With OutputFields
                .Add "Machineno", AllDevices(Index).MachineNo
                .Add "LocationName", AllDevices(Index).LocationName
                .Add "EnrollNumber", dwEnrollNumber
                .Add "AttState", dwInOutMode
                .Add "VerifyMethod", dwVerifyMode
                .Add "TransDate", TransDate
                .Add "YYYY", YYYY
                .Add "YY", PadData(Right(YYYY, 2))
                .Add "MM", PadData(MM)
                .Add "MMM", MonthName(MM, True)
                .Add "DD", PadData(DD)
                .Add "HH", PadData(HH)
                .Add "MN", PadData(MN)
                .Add "SS", PadData(SS)
                .Add "WorkCode", PadData(WorkCode)
            End With

            StoreData Index, OutputFields
            ShowInTable Index, OutputFields
            SendToClients Index, OutputFields

            CNAttLogs.Execute "INSERT INTO Logs (MachineNo, LocationName, EnrollNumber, IsInValid, AttState, VerifyMethod, YYYY, MM, DD, HH, MN, SS,Exported,WorkCode) " & _
                " Values('" & AllDevices(Index).MachineNo & "','" & AllDevices(Index).LocationName & "'," & dwEnrollNumber & "," & 0 & "," & dwInOutMode & "," & dwVerifyMode & "," & YYYY & "," & MM & "," & DD & "," & HH & "," & MN & "," & SS & ",False," & WorkCode & ")"
            If GetParam("ExportEnable", "FALSE") = "TRUE" Then
                frmExportData.cmdExport_Click
            End If

            i = i + 1
           ShowBusy "Reading " & i & " Logs from machine : " & GetMachineName(Index), True
         Loop
        End If

        Debug.Print "End :"; Timer - StartTime

        ShowBusy "", False
        ReadExitingData = i
        If bFromSheduler Then End
    End Function
