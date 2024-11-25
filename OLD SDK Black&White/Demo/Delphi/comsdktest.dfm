object Form1: TForm1
  Left = 176
  Top = 153
  Width = 790
  Height = 535
  Caption = 'Bioclock'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 240
    Top = 2
    Width = 32
    Height = 13
    Caption = 'Label1'
  end
  object sbtnRS232: TSpeedButton
    Left = 8
    Top = 27
    Width = 18
    Height = 17
    GroupIndex = 1
    Down = True
    Flat = True
    Glyph.Data = {
      F6000000424DF600000000000000760000002800000010000000100000000100
      04000000000080000000C40E0000C40E00001000000000000000000000000000
      8000008000000080800080000000800080008080000080808000C0C0C0000000
      FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00330333333333
      3333333000333333333333333303333333333333333033333333333333707733
      333333333000007333333333088888073333333308FFFF073333333308FFFF07
      3333333708FFFF07773330000000000000730077070707077007077777777777
      7707077070707070770730000000000000733333333333333333}
    OnClick = sbtnRS232Click
  end
  object sbtnTCPIP: TSpeedButton
    Left = 8
    Top = 9
    Width = 18
    Height = 17
    GroupIndex = 1
    Flat = True
    Glyph.Data = {
      36050000424D3605000000000000360400002800000010000000100000000100
      08000000000000010000030F0000030F00000001000000010000A5390000AD39
      0000AD4200006B4A0000B54A0000C65A0000CE5A000031630000296B0000BD6B
      00000073000021730000C6730000007B0000BD7B0000D67B0000008400003184
      0000C68400006B8C0000848C0000B58C0000E78C0000F78C000039940000A539
      0800086B0800C68408007B940800FF9C0800BD521000426B1000FFA51000A542
      1800B5421800C65A180029A51800D6AD18008C5221007363210031AD2100BD52
      2900636B29005A7B2900D6B5290084423100845A310039B53100BD5A3900BD63
      3900CE6339004AB5390031BD3900735242009C524200C6634200D69C4200BD73
      4A0010C64A00FFCE5A009C636300A57B630031CE630052CE630084736B007BCE
      6B0084C6730042D67300AD847B00A5947B0063DE7B00A5D684005ADE8400ADC6
      8C0094DE8C00D6E79400A5E79C00BDF7AD00A5F7B500D6FFBD00FF00FF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFF
      FF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00FFFFFF00505050505050
      5050505050505050505050505050505050505050505050505050505050505050
      45443C3950505050505050505050503D31373736405050505050505050503923
      21262229322D50505050505050391E0002070301193035505050505039360206
      090D0B0504272E35505050503936060F1418120E0B1A2A395050505039360C24
      28251D16110A1F2A5050505036391C3A3E413B20131008085050505045393443
      4C4E4B2C15112B4550505050504542464D4F482F171B45505050505050504549
      474A3F3338455050505050505050504545444545455050505050505050505050
      5050505050505050505050505050505050505050505050505050}
    OnClick = sbtnTCPIPClick
  end
  object Label5: TLabel
    Left = 144
    Top = 8
    Width = 45
    Height = 13
    Caption = 'BautRate'
  end
  object Label2: TLabel
    Left = 90
    Top = 54
    Width = 49
    Height = 13
    Caption = 'Password:'
  end
  object CZKEM1: TCZKEM
    Left = 72
    Top = 64
    Width = 49
    Height = 41
    TabOrder = 0
    Visible = False
    ControlData = {10070000100500003D040000}
  end
  object btnConnect: TButton
    Left = 8
    Top = 48
    Width = 73
    Height = 25
    Caption = 'Connect'
    TabOrder = 1
    OnClick = btnConnectClick
  end
  object Memo1: TMemo
    Left = 8
    Top = 104
    Width = 217
    Height = 393
    ImeName = #20013#25991' ('#31616#20307') - '#24494#36719#25340#38899#36755#20837#27861' 3.0'
    TabOrder = 2
  end
  object gbOP: TGroupBox
    Left = 248
    Top = 16
    Width = 417
    Height = 481
    TabOrder = 3
    object btnSetTime: TButton
      Left = 296
      Top = 16
      Width = 105
      Height = 25
      Caption = 'Set Device Time'
      TabOrder = 0
      OnClick = btnSetTimeClick
    end
    object vleDevInfo: TValueListEditor
      Left = 8
      Top = 40
      Width = 281
      Height = 433
      DefaultColWidth = 160
      FixedCols = 1
      Font.Charset = GB2312_CHARSET
      Font.Color = clWindowText
      Font.Height = -12
      Font.Name = #23435#20307
      Font.Style = []
      ParentFont = False
      Strings.Strings = (
        'Registrable administrators number='
        'Device ID='
        'Languages='
        'Auto power off time='
        'Lock control delay(20ms)='
        'In and out record warning='
        'manage record warning='
        'Confirm interval time='
        'Baud Rate='
        'Even and Odd='
        'Stop bit='
        'Date list separator='
        'Network='
        'RS232='
        'RS485='
        'Voice='
        'Identification speed='
        'idle='
        'Shutdown time='
        'PowerOn time='
        'Sleep time='
        'Auto Bell='
        'Match threshold='
        'Register threshold='
        '1:1 threshold='
        'Show score='
        'Unlock person count='
        'Only verify number card='
        'Net Speed='
        'Must registe card='
        'Time out of temp state keep='
        'Time out of input number='
        'Time out of menu keep='
        'Date formate='
        'Only 1:1=')
      TabOrder = 1
      TitleCaptions.Strings = (
        'Item'
        'Value')
      OnValidate = vleDevInfoValidate
      ColWidths = (
        160
        99)
      RowHeights = (
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18
        18)
    end
    object btnLoadDevInfo: TBitBtn
      Left = 8
      Top = 16
      Width = 97
      Height = 25
      Caption = 'Load Device Info'
      TabOrder = 2
      OnClick = btnLoadDevInfoClick
    end
    object btnSaveDevInfo: TBitBtn
      Left = 118
      Top = 16
      Width = 97
      Height = 25
      Caption = 'Save Device Info'
      TabOrder = 3
      OnClick = btnSaveDevInfoClick
    end
    object Button3: TButton
      Left = 296
      Top = 48
      Width = 105
      Height = 25
      Caption = 'Power Off Device'
      TabOrder = 4
      OnClick = Button3Click
    end
    object GroupBox1: TGroupBox
      Left = 296
      Top = 88
      Width = 105
      Height = 385
      Caption = 'Data Manager'
      TabOrder = 5
      object btnClearData: TButton
        Left = 16
        Top = 24
        Width = 75
        Height = 16
        Caption = 'Clear Data'
        TabOrder = 0
        OnClick = btnClearDataClick
      end
      object Button5: TButton
        Left = 16
        Top = 40
        Width = 75
        Height = 16
        Caption = 'Clear Att Log'
        TabOrder = 1
        OnClick = Button5Click
      end
      object Button6: TButton
        Left = 16
        Top = 56
        Width = 75
        Height = 16
        Caption = 'Clear Admin'
        TabOrder = 2
        OnClick = Button6Click
      end
      object btnBackupUser: TButton
        Left = 16
        Top = 80
        Width = 75
        Height = 16
        Caption = 'Backup Users'
        TabOrder = 3
        OnClick = btnBackupUserClick
      end
      object btnRestore: TButton
        Left = 16
        Top = 96
        Width = 75
        Height = 16
        Caption = 'Restore Users'
        TabOrder = 4
        OnClick = btnRestoreClick
      end
      object Button9: TButton
        Left = 16
        Top = 112
        Width = 75
        Height = 16
        Caption = 'Read Att Log'
        TabOrder = 5
        OnClick = Button9Click
      end
      object btnSetName: TButton
        Left = 16
        Top = 168
        Width = 75
        Height = 16
        Caption = 'Set Name'
        TabOrder = 7
        OnClick = btnSetNameClick
      end
      object btnDeleteUser: TButton
        Left = 16
        Top = 184
        Width = 75
        Height = 16
        Caption = 'Delete Users'
        TabOrder = 6
        OnClick = btnDeleteUserClick
      end
      object Button10: TButton
        Left = 16
        Top = 200
        Width = 75
        Height = 16
        Caption = 'Delete FP'
        TabOrder = 8
      end
      object btnAutoTest: TButton
        Left = 16
        Top = 224
        Width = 75
        Height = 16
        Caption = 'Start Test'
        TabOrder = 9
        OnClick = btnAutoTestClick
      end
      object btnACUnlock: TButton
        Left = 16
        Top = 240
        Width = 75
        Height = 17
        Caption = 'ACUnlock'
        TabOrder = 10
        OnClick = btnACUnlockClick
      end
      object btnSMS: TButton
        Left = 16
        Top = 328
        Width = 75
        Height = 20
        Caption = 'Set SMS'
        TabOrder = 11
        OnClick = btnSMSClick
      end
      object Button1: TButton
        Left = 16
        Top = 296
        Width = 75
        Height = 25
        Caption = 'SetEnrollDataStr'
        TabOrder = 12
      end
    end
  end
  object edtNetAddress: TLabeledEdit
    Left = 28
    Top = 24
    Width = 77
    Height = 21
    EditLabel.Width = 54
    EditLabel.Height = 13
    EditLabel.Caption = 'IP Address:'
    ImeName = #20013#25991' ('#31616#20307') - '#24494#36719#25340#38899
    TabOrder = 4
    Text = 'COM1'
  end
  object edtNetPort: TLabeledEdit
    Left = 104
    Top = 24
    Width = 41
    Height = 21
    EditLabel.Width = 22
    EditLabel.Height = 13
    EditLabel.Caption = 'Port:'
    ImeName = #20013#25991' ('#31616#20307') - '#24494#36719#25340#38899
    TabOrder = 5
    Text = '1'
  end
  object edtBaudRate: TEdit
    Left = 146
    Top = 24
    Width = 49
    Height = 21
    ImeName = #20013#25991' ('#31616#20307') - '#24494#36719#25340#38899#36755#20837#27861' 3.0'
    TabOrder = 6
    Text = '115200'
  end
  object edtPassword: TEdit
    Left = 144
    Top = 51
    Width = 73
    Height = 21
    ImeName = #20013#25991' ('#31616#20307') - '#26234#33021' ABC'
    TabOrder = 7
  end
  object chkEnabled: TCheckBox
    Left = 144
    Top = 80
    Width = 68
    Height = 17
    Caption = 'Enabled'
    TabOrder = 8
    OnClick = chkEnabledClick
  end
  object Button7: TButton
    Left = 688
    Top = 24
    Width = 87
    Height = 16
    Caption = 'Capture Image'
    TabOrder = 9
    OnClick = Button7Click
  end
  object Button8: TButton
    Left = 688
    Top = 40
    Width = 87
    Height = 16
    Caption = 'Update firmware'
    TabOrder = 10
    OnClick = Button8Click
  end
  object Button12: TButton
    Left = 688
    Top = 64
    Width = 87
    Height = 16
    Caption = 'Clear LCD'
    TabOrder = 11
    OnClick = Button12Click
  end
  object Button11: TButton
    Left = 688
    Top = 80
    Width = 87
    Height = 16
    Caption = 'WriteLCD'
    TabOrder = 12
    OnClick = Button11Click
  end
  object Button14: TButton
    Left = 688
    Top = 96
    Width = 87
    Height = 16
    Caption = 'Beep'
    TabOrder = 13
    OnClick = Button14Click
  end
  object Button13: TButton
    Left = 688
    Top = 112
    Width = 87
    Height = 16
    Caption = 'Play Vioce'
    TabOrder = 14
  end
  object Button15: TButton
    Left = 688
    Top = 136
    Width = 87
    Height = 16
    Caption = 'Start Enroll'
    TabOrder = 15
  end
  object Button16: TButton
    Left = 688
    Top = 152
    Width = 87
    Height = 16
    Caption = 'Start Verify'
    TabOrder = 16
  end
  object Button17: TButton
    Left = 688
    Top = 168
    Width = 87
    Height = 16
    Caption = 'Start Identify'
    TabOrder = 17
  end
  object Button18: TButton
    Left = 688
    Top = 184
    Width = 87
    Height = 16
    Caption = 'Cancel Operation'
    TabOrder = 18
  end
  object Button19: TButton
    Left = 688
    Top = 208
    Width = 87
    Height = 16
    Caption = 'Backup Data'
    TabOrder = 19
  end
  object Button20: TButton
    Left = 688
    Top = 224
    Width = 87
    Height = 16
    Caption = 'Restore Data'
    TabOrder = 20
  end
  object Button2: TButton
    Left = 696
    Top = 360
    Width = 65
    Height = 25
    Caption = 'Button2'
    TabOrder = 21
    OnClick = Button2Click
  end
  object SaveDialog1: TSaveDialog
    FileName = 'D:\backup11b.dat'
    FilterIndex = 0
    Left = 432
    Top = 8
  end
  object OpenDialog1: TOpenDialog
    FileName = 'D:\backup148.dat'
    FilterIndex = 0
    Left = 392
    Top = 8
  end
  object SaveDialog2: TSaveDialog
    DefaultExt = 'dbin'
    Left = 704
    Top = 312
  end
  object OpenDialog2: TOpenDialog
    Left = 752
    Top = 312
  end
end
