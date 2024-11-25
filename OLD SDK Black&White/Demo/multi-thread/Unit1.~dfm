object Form1: TForm1
  Left = 350
  Top = 169
  BorderStyle = bsDialog
  Caption = 'Transaction Logs Reader'
  ClientHeight = 405
  ClientWidth = 499
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
    Left = 16
    Top = 8
    Width = 465
    Height = 25
    AutoSize = False
    Caption = 
      'This program is a demo for multi-thread. It start some backgroun' +
      'd work threads to read the logs of BioClock Devices periodically' +
      '.'
    WordWrap = True
  end
  object Label2: TLabel
    Left = 16
    Top = 48
    Width = 75
    Height = 13
    Caption = 'Read Period(S):'
  end
  object Label3: TLabel
    Left = 184
    Top = 80
    Width = 26
    Height = 13
    Caption = 'Logs:'
  end
  object lblTimer: TLabel
    Left = 416
    Top = 48
    Width = 62
    Height = 21
    Caption = '12:23:59'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Times New Roman'
    Font.Style = []
    ParentFont = False
  end
  object memLogs: TMemo
    Left = 176
    Top = 96
    Width = 305
    Height = 297
    Lines.Strings = (
      'Memo1')
    TabOrder = 0
  end
  object spePeriod: TSpinEdit
    Left = 96
    Top = 45
    Width = 65
    Height = 22
    MaxValue = 1000
    MinValue = 3
    TabOrder = 1
    Value = 3
    OnChange = spePeriodChange
  end
  object btnCount: TButton
    Left = 224
    Top = 80
    Width = 75
    Height = 17
    Caption = 'Count'
    TabOrder = 2
    OnClick = btnCountClick
  end
  object clbDevices: TCheckListBox
    Left = 16
    Top = 96
    Width = 150
    Height = 297
    OnClickCheck = clbDevicesClickCheck
    ItemHeight = 16
    Style = lbOwnerDrawFixed
    TabOrder = 3
    OnDrawItem = clbDevicesDrawItem
  end
  object btnAddDevice: TButton
    Left = 16
    Top = 79
    Width = 69
    Height = 17
    Caption = 'Add Device'
    TabOrder = 4
    OnClick = btnAddDeviceClick
  end
  object btnDelDevice: TButton
    Left = 96
    Top = 79
    Width = 69
    Height = 17
    Caption = 'Del Device'
    TabOrder = 5
    OnClick = btnDelDeviceClick
  end
  object Timer1: TTimer
    OnTimer = Timer1Timer
    Left = 384
    Top = 40
  end
end
