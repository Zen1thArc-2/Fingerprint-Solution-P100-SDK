object frmUser: TfrmUser
  Left = 562
  Top = 191
  BorderStyle = bsDialog
  Caption = 'User Data Managment'
  ClientHeight = 429
  ClientWidth = 517
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  OnClose = FormClose
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 8
    Top = 8
    Width = 69
    Height = 13
    Caption = 'Enroll Number:'
  end
  object edtPIN: TEdit
    Left = 8
    Top = 24
    Width = 73
    Height = 21
    TabOrder = 0
  end
  object GroupBox1: TGroupBox
    Left = 8
    Top = 48
    Width = 342
    Height = 65
    Caption = ' User Information '
    TabOrder = 1
    object Label2: TLabel
      Left = 16
      Top = 21
      Width = 31
      Height = 13
      Caption = 'Name:'
    end
    object Label3: TLabel
      Left = 16
      Top = 43
      Width = 49
      Height = 13
      Caption = 'Password:'
    end
    object Label4: TLabel
      Left = 152
      Top = 17
      Width = 43
      Height = 13
      Caption = 'Privilege:'
    end
    object edtPwd: TEdit
      Left = 72
      Top = 38
      Width = 57
      Height = 21
      TabOrder = 0
    end
    object chkEnabled: TCheckBox
      Left = 208
      Top = 38
      Width = 89
      Height = 17
      Caption = 'Enabled'
      TabOrder = 1
    end
    object cboPrivilege: TComboBox
      Left = 208
      Top = 15
      Width = 97
      Height = 21
      ItemHeight = 13
      TabOrder = 2
      Items.Strings = (
        #26222#36890#29992#25143
        #30331#35760#21592
        #31649#29702#21592
        #36229#32423#31649#29702#21592)
    end
    object edtName: TEdit
      Left = 72
      Top = 16
      Width = 57
      Height = 21
      TabOrder = 3
    end
  end
  object GroupBox2: TGroupBox
    Left = 8
    Top = 120
    Width = 342
    Height = 233
    Caption = ' Fingerprint Templates '
    TabOrder = 2
    object Label5: TLabel
      Left = 240
      Top = 16
      Width = 32
      Height = 13
      Caption = 'Label5'
    end
    object vleTemps: TValueListEditor
      Left = 8
      Top = 16
      Width = 216
      Height = 212
      Strings.Strings = (
        '0='
        '1='
        '2='
        '3='
        '4='
        '5='
        '6='
        '7='
        '8='
        '9=')
      TabOrder = 0
      TitleCaptions.Strings = (
        'Finger'
        'Template')
      ColWidths = (
        33
        177)
    end
    object Button7: TButton
      Left = 237
      Top = 154
      Width = 97
      Height = 19
      Caption = 'Save Binary'
      TabOrder = 1
      OnClick = Button7Click
    end
    object Button8: TButton
      Left = 237
      Top = 172
      Width = 97
      Height = 19
      Caption = 'Load Binary'
      TabOrder = 2
    end
    object Button9: TButton
      Left = 237
      Top = 190
      Width = 97
      Height = 19
      Caption = 'Del On Device'
      TabOrder = 3
      OnClick = Button9Click
    end
    object Button10: TButton
      Left = 237
      Top = 208
      Width = 97
      Height = 19
      Caption = 'Append To Dev'
      TabOrder = 4
      OnClick = Button10Click
    end
  end
  object btnLoadDev: TButton
    Left = 133
    Top = 6
    Width = 97
    Height = 15
    Caption = 'Load From Device'
    TabOrder = 3
    OnClick = btnLoadDevClick
  end
  object btnSaveDev: TButton
    Left = 133
    Top = 20
    Width = 97
    Height = 15
    Caption = 'Save to Device'
    TabOrder = 4
    OnClick = btnSaveDevClick
  end
  object btnDelDev: TButton
    Left = 133
    Top = 34
    Width = 97
    Height = 15
    Caption = 'Del On Device'
    TabOrder = 5
    OnClick = btnDelDevClick
  end
  object btnLoadFile: TButton
    Left = 253
    Top = 5
    Width = 97
    Height = 15
    Caption = 'Load From File'
    TabOrder = 6
  end
  object btnSaveFile: TButton
    Left = 253
    Top = 19
    Width = 97
    Height = 15
    Caption = 'Save to File'
    TabOrder = 7
  end
  object btnDelFile: TButton
    Left = 253
    Top = 33
    Width = 97
    Height = 15
    Caption = 'Del On File'
    TabOrder = 8
  end
  object OpenDialog1: TOpenDialog
    Left = 248
    Top = 224
  end
  object SaveDialog1: TSaveDialog
    Left = 288
    Top = 184
  end
end
