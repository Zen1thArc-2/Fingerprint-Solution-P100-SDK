object Form1: TForm1
  Left = 297
  Top = 232
  BorderStyle = bsDialog
  Caption = 'Transaction Logs Reader'
  ClientHeight = 371
  ClientWidth = 234
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  OnCloseQuery = FormCloseQuery
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 240
    Top = 8
    Width = 241
    Height = 25
    AutoSize = False
    Caption = 
      'This program is a demo for multi-thread. It start some backgroun' +
      'd work threads to read the logs of BioClock Devices periodically' +
      '.'
    Visible = False
    WordWrap = True
  end
  object Label2: TLabel
    Left = 208
    Top = 48
    Width = 75
    Height = 13
    Caption = 'Read Period(S):'
    Visible = False
  end
  object Label3: TLabel
    Left = 232
    Top = 104
    Width = 26
    Height = 13
    Caption = 'Logs:'
    Visible = False
  end
  object lblTimer: TLabel
    Left = 272
    Top = 80
    Width = 62
    Height = 21
    Caption = '12:23:59'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Times New Roman'
    Font.Style = []
    ParentFont = False
    Visible = False
  end
  object memLogs: TMemo
    Left = 232
    Top = 128
    Width = 201
    Height = 81
    Lines.Strings = (
      'Memo1')
    TabOrder = 0
    Visible = False
  end
  object spePeriod: TSpinEdit
    Left = 288
    Top = 45
    Width = 65
    Height = 22
    MaxValue = 1000
    MinValue = 3
    TabOrder = 1
    Value = 3
    Visible = False
    OnChange = spePeriodChange
  end
  object btnCount: TButton
    Left = 272
    Top = 104
    Width = 75
    Height = 17
    Caption = 'Count'
    TabOrder = 2
    Visible = False
    OnClick = btnCountClick
  end
  object clbDevices: TCheckListBox
    Left = 24
    Top = 56
    Width = 185
    Height = 297
    OnClickCheck = clbDevicesClickCheck
    ItemHeight = 16
    Style = lbOwnerDrawFixed
    TabOrder = 3
    OnDrawItem = clbDevicesDrawItem
  end
  object btnAddDevice: TButton
    Left = 40
    Top = 32
    Width = 69
    Height = 24
    Caption = 'Add Device'
    TabOrder = 4
    OnClick = btnAddDeviceClick
  end
  object btnDelDevice: TButton
    Left = 120
    Top = 32
    Width = 69
    Height = 24
    Caption = 'Del Device'
    TabOrder = 5
    OnClick = btnDelDeviceClick
  end
  object CheckBox1: TCheckBox
    Left = 16
    Top = 8
    Width = 145
    Height = 17
    Caption = 'Sync time when  start'
    TabOrder = 6
    OnClick = CheckBox1Click
  end
  object Timer1: TTimer
    Enabled = False
    OnTimer = Timer1Timer
    Left = 240
    Top = 72
  end
end
