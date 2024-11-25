VERSION 5.00
Object = "{FE9DED34-E159-408E-8490-B720A5E632C7}#6.0#0"; "zkemkeeper.dll"
Begin VB.Form frm2 
   Caption         =   "Demo"
   ClientHeight    =   6015
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   11580
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   6015
   ScaleWidth      =   11580
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command3 
      Caption         =   "Clear Log in Device"
      Height          =   375
      Left            =   6360
      TabIndex        =   18
      Top             =   3360
      Width           =   2175
   End
   Begin VB.TextBox Text1 
      Height          =   3975
      Left            =   240
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   17
      Top             =   1560
      Width           =   5895
   End
   Begin zkemkeeperCtl.CZKEM CZKEM1 
      Height          =   615
      Left            =   0
      OleObjectBlob   =   "Formx.frx":0000
      TabIndex        =   15
      Top             =   0
      Width           =   615
   End
   Begin VB.CommandButton Command1 
      Caption         =   "DownLoad From Device"
      Height          =   375
      Left            =   6360
      TabIndex        =   13
      Top             =   2880
      Width           =   2175
   End
   Begin VB.CommandButton cmdConnect 
      Caption         =   "Connect"
      Height          =   375
      Left            =   9720
      TabIndex        =   12
      Top             =   720
      Width           =   1815
   End
   Begin VB.TextBox txtRate 
      Height          =   375
      Left            =   7320
      TabIndex        =   11
      Text            =   "115200"
      Top             =   600
      Width           =   2175
   End
   Begin VB.TextBox txtMachNum 
      Height          =   375
      Left            =   5400
      TabIndex        =   9
      Text            =   "1"
      Top             =   600
      Width           =   1095
   End
   Begin VB.TextBox txtComNum 
      Height          =   375
      Left            =   3240
      TabIndex        =   7
      Text            =   "1"
      Top             =   600
      Width           =   495
   End
   Begin VB.TextBox txtPort 
      Height          =   405
      Left            =   6960
      TabIndex        =   5
      Text            =   "4370"
      Top             =   120
      Width           =   2535
   End
   Begin VB.TextBox txtIP 
      Height          =   375
      Left            =   3240
      TabIndex        =   3
      Text            =   "192.168.1.201"
      Top             =   120
      Width           =   2655
   End
   Begin VB.OptionButton optCom 
      Caption         =   "ComConnect"
      Height          =   255
      Left            =   720
      TabIndex        =   1
      Top             =   720
      Width           =   1335
   End
   Begin VB.OptionButton optNetconncet 
      Caption         =   "NetConnect"
      Height          =   375
      Left            =   720
      TabIndex        =   0
      Top             =   120
      Width           =   1215
   End
   Begin VB.Label Label3 
      Caption         =   "UserID   Verify-Mode   InOut-Mode   Time"
      Height          =   255
      Left            =   240
      TabIndex        =   20
      Top             =   1320
      Width           =   4335
   End
   Begin VB.Label Label2 
      Caption         =   "After Download, Log data also be save in data.txt"
      Height          =   255
      Left            =   240
      TabIndex        =   19
      Top             =   5640
      Width           =   4335
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      Caption         =   "Label1"
      Height          =   255
      Left            =   9600
      TabIndex        =   16
      Top             =   360
      Width           =   1935
   End
   Begin VB.Label labSDK 
      Height          =   255
      Left            =   9720
      TabIndex        =   14
      Top             =   0
      Width           =   1695
   End
   Begin VB.Label labRare 
      Caption         =   "Rate"
      Height          =   255
      Left            =   6720
      TabIndex        =   10
      Top             =   720
      Width           =   495
   End
   Begin VB.Label labMachNum 
      Caption         =   "MachineNumber"
      Height          =   375
      Left            =   3960
      TabIndex        =   8
      Top             =   720
      Width           =   1335
   End
   Begin VB.Label labCom 
      Caption         =   "ComNumber"
      Height          =   255
      Left            =   2160
      TabIndex        =   6
      Top             =   720
      Width           =   975
   End
   Begin VB.Label labPort 
      Caption         =   "port"
      Height          =   255
      Left            =   6240
      TabIndex        =   4
      Top             =   240
      Width           =   375
   End
   Begin VB.Label labIP 
      Caption         =   "IP"
      Height          =   255
      Left            =   2160
      TabIndex        =   2
      Top             =   240
      Width           =   255
   End
End
Attribute VB_Name = "frm2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'**********************************************
'author: Fr3                                  *
'**********************************************

Private Sub cmdConnect_Click()
    Dim bconn As Boolean
    Dim mint As Integer
    Dim SDKVersion As String
    Dim strVersion As String

    CZKEM1.BASE64 = 1
    bconn = False
    CZKEM1.GetSDKVersion SDKVersion
    labSDK.Caption = "SDKVersion:" + SDKVersion
    
    If cmdConnect.Caption = "DisConnect" Then
        CZKEM1.Beep 150
        DoEvents
        CZKEM1.Disconnect
        
        cmdConnect.Caption = "Connect"
        Label1.Caption = "DisConnect"
        Exit Sub
    End If
    
    If optNetconncet.Value = True Then
        If txtPort.Text = "" Then Exit Sub
        bconn = CZKEM1.Connect_Net(CStr(txtIP.Text), CLng(txtPort.Text))
        If bconn Then
            cmdConnect.Caption = "DisConnect"
            Label1.Caption = "connect successful"
            CZKEM1.Beep 150
        Else
            Label1.Caption = "connect fail"
        End If
    End If
    
    If optCom.Value = True Then
        CZKEM1.BASE64 = 1
        bconn = CZKEM1.Connect_Com(CLng(txtComNum.Text), CLng(txtMachNum.Text), CLng(txtRate.Text))
        If bconn Then
            cmdConnect.Caption = "DisConnect"
            StatusBar1.Panels(1).Text = "connect successful"
            CZKEM1.Beep 150
            CZKEM1.GetFirmwareVersion CInt(txtMacNum.Text), strVersion
            labFirmV.Caption = strVersion
        Else
           Label1.Caption = "connect fail"
        End If
    End If
End Sub
Private Sub Command1_Click()
    Dim dwEnrollNumber As Long
    Dim dwVerifyMode As Long
    Dim dwInOutMode As Long
    Dim timeStr As String
    
    
    Open App.Path & "\data.txt" For Output As #1
    
    Text1.Text = ""
    If CZKEM1.ReadGeneralLogData(CInt(txtMachNum.Text)) Then
        Do While CZKEM1.GetGeneralLogDataStr(CInt(txtMachNum.Text), dwEnrollNumber, dwVerifyMode, dwInOutMode, timeStr)
            Text1.Text = Text1.Text & dwEnrollNumber & " " & dwVerifyMode & " " & dwInOutMode & " " & timeStr & vbCrLf
            Print #1, dwEnrollNumber & " " & dwVerifyMode & " " & dwInOutMode & " " & timeStr
        Loop
    End If
    
    Close #1
End Sub

Private Sub Command2_Click()

End Sub

Private Sub Command3_Click()
CZKEM1.ClearGLog CInt(txtMachNum.Text)
MsgBox "Data Clear"
End Sub
