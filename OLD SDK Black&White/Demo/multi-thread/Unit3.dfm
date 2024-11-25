object Form3: TForm3
  Left = 295
  Top = 155
  BorderStyle = bsDialog
  Caption = 'Connect to Device'
  ClientHeight = 148
  ClientWidth = 298
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poMainFormCenter
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 16
    Top = 76
    Width = 49
    Height = 13
    Caption = 'COM Port:'
  end
  object Label2: TLabel
    Left = 16
    Top = 100
    Width = 51
    Height = 13
    Caption = 'Device ID:'
  end
  object Label3: TLabel
    Left = 16
    Top = 124
    Width = 54
    Height = 13
    Caption = 'Baud Rate:'
  end
  object rgrpConnect: TRadioGroup
    Left = 16
    Top = 8
    Width = 161
    Height = 57
    Caption = ' Connect Method '
    ItemIndex = 0
    Items.Strings = (
      'COM Port(RS232/RS485)'
      'Ethernet')
    TabOrder = 0
    OnClick = rgrpConnectClick
  end
  object Edit1: TEdit
    Left = 76
    Top = 72
    Width = 102
    Height = 21
    TabOrder = 1
    Text = 'COM1'
  end
  object Edit2: TEdit
    Left = 76
    Top = 96
    Width = 102
    Height = 21
    TabOrder = 2
    Text = '1'
  end
  object Edit3: TEdit
    Left = 76
    Top = 120
    Width = 102
    Height = 21
    TabOrder = 3
    Text = '115200'
  end
  object BitBtn1: TBitBtn
    Left = 208
    Top = 16
    Width = 75
    Height = 25
    TabOrder = 4
    Kind = bkOK
  end
  object BitBtn2: TBitBtn
    Left = 208
    Top = 56
    Width = 75
    Height = 25
    TabOrder = 5
    Kind = bkCancel
  end
end
