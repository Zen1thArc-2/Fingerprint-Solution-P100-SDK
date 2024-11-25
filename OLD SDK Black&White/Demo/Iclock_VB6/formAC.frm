VERSION 5.00
Begin VB.Form formAC 
   Caption         =   "Form2"
   ClientHeight    =   4395
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6660
   LinkTopic       =   "Form2"
   ScaleHeight     =   4395
   ScaleWidth      =   6660
   StartUpPosition =   3  '´°¿ÚÈ±Ê¡
   Begin VB.TextBox TextMSG 
      BackColor       =   &H80000000&
      Height          =   270
      Left            =   120
      TabIndex        =   3
      Top             =   4065
      Width           =   6375
   End
   Begin VB.CommandButton cmdGetWiegandFmt 
      Caption         =   "GetWiegandFmt"
      Height          =   375
      Left            =   840
      TabIndex        =   2
      Top             =   720
      Width           =   1815
   End
   Begin VB.CommandButton cmdSetWiegandFmt 
      Caption         =   "SetWiegandFmt"
      Height          =   375
      Left            =   3360
      TabIndex        =   1
      Top             =   720
      Width           =   1815
   End
   Begin VB.TextBox TextWiegandFmt 
      Height          =   375
      Left            =   360
      TabIndex        =   0
      Top             =   120
      Width           =   5175
   End
End
Attribute VB_Name = "formAC"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdGetWiegandFmt_Click()
    Dim s As String
    If FormMain.CZKEM1.GetWiegandFmt(vMachineNumber, s) Then
        TextWiegandFmt.Text = s
    Else
        TextMSG.Text = "GetWiegandFmt Failed"
    End If
    
End Sub

Private Sub cmdSetWiegandFmt_Click()
    If FormMain.CZKEM1.SetWiegandFmt(vMachineNumber, TextWiegandFmt.Text) Then
        TextMSG.Text = "SetWiegandFmt Success"
    Else
        TextMSG.Text = "SetWiegandFmt Failed"
    End If
End Sub

