unit comsdktest;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, OleCtrls, zkemkeeper_TLB, Menus, Buttons, Grids,
  ValEdit, ExtCtrls;

type
  TForm1 = class(TForm)
    CZKEM1: TCZKEM;
    Label1: TLabel;
    btnConnect: TButton;
    Memo1: TMemo;
    SaveDialog1: TSaveDialog;
    gbOP: TGroupBox;
    btnSetTime: TButton;
    vleDevInfo: TValueListEditor;
    btnLoadDevInfo: TBitBtn;
    btnSaveDevInfo: TBitBtn;
    Button3: TButton;
    GroupBox1: TGroupBox;
    btnClearData: TButton;
    Button5: TButton;
    Button6: TButton;
    btnBackupUser: TButton;
    btnRestore: TButton;
    Button9: TButton;
    OpenDialog1: TOpenDialog;
    btnDeleteUser: TButton;
    btnSetName: TButton;
    Button10: TButton;
    btnAutoTest: TButton;
    edtNetAddress: TLabeledEdit;
    edtNetPort: TLabeledEdit;
    edtBaudRate: TEdit;
    sbtnRS232: TSpeedButton;
    sbtnTCPIP: TSpeedButton;
    Label5: TLabel;
    btnACUnlock: TButton;
    edtPassword: TEdit;
    Label2: TLabel;
    chkEnabled: TCheckBox;
    Button7: TButton;
    Button8: TButton;
    Button12: TButton;
    Button11: TButton;
    Button14: TButton;
    Button13: TButton;
    Button15: TButton;
    Button16: TButton;
    Button17: TButton;
    Button18: TButton;
    Button19: TButton;
    Button20: TButton;
    btnSMS: TButton;
    Button1: TButton;
    SaveDialog2: TSaveDialog;
    OpenDialog2: TOpenDialog;
    Button2: TButton;
    procedure FormCreate(Sender: TObject);
    procedure btnConnectClick(Sender: TObject);
    procedure btnLoadDevInfoClick(Sender: TObject);
    procedure btnSaveDevInfoClick(Sender: TObject);
    procedure btnSetTimeClick(Sender: TObject);
    procedure btnClearDataClick(Sender: TObject);
    procedure Button5Click(Sender: TObject);
    procedure Button6Click(Sender: TObject);
    procedure Button9Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure btnBackupUserClick(Sender: TObject);
    procedure btnRestoreClick(Sender: TObject);
    procedure vleDevInfoValidate(Sender: TObject; ACol, ARow: Integer;
      const KeyName, KeyValue: String);
    procedure btnSetNameClick(Sender: TObject);
    procedure btnDeleteUserClick(Sender: TObject);
    procedure btnAutoTestClick(Sender: TObject);
    procedure sbtnRS232Click(Sender: TObject);
    procedure sbtnTCPIPClick(Sender: TObject);
    procedure btnACUnlockClick(Sender: TObject);
    procedure chkEnabledClick(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure Button4Click(Sender: TObject);
    procedure btnSMSClick(Sender: TObject);
    procedure Button7Click(Sender: TObject);
    procedure Button8Click(Sender: TObject);
    procedure Button12Click(Sender: TObject);
    procedure Button11Click(Sender: TObject);
    procedure Button14Click(Sender: TObject);
    procedure Button13Click(Sender: TObject);
    procedure Button15Click(Sender: TObject);
    procedure Button16Click(Sender: TObject);
    procedure Button17Click(Sender: TObject);
    procedure Button18Click(Sender: TObject);
    procedure CZKEM1FingerFeature(ASender: TObject; Score: Integer);
    procedure CZKEM1Verify(ASender: TObject; UserID: Integer);
    procedure Button19Click(Sender: TObject);
    procedure Button20Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    //procedure GroupBox1Click(Sender: TObject);
  private
    { Private declarations }
    DevID: integer;
    Commport: integer;
    Modified: string;
    AppPath:string;
    procedure AddInfo(const s: string);
    procedure ReadDeviceStatus;
    procedure BackupUser(const fn: string);
    procedure RestoreUser(const fn: string);
    function SaveGLogs(const fn: string): integer;
    function BTimeEncode(MinuteSecond: integer): string;
    function BTimeDecode(const TimeStr: string): integer;
    function BNetSpeedEncode(speed: integer): string;
    function BNetSpeedDecode(const speed: string): integer;
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
function decodedata(const s: string): string;
function encodedata(const BinData; size: integer): string;
function LoadFile(const fn: string): string;
procedure SaveFileData(const fn: string; const Data; size: integer);
procedure SaveFile(const fn: string; Data: string);

implementation
uses inifiles, uUser;
{$R *.dfm}
const
  HexOfNum: array[0..15] of char=('0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F');

  StatusNames: array[1..12] of string=(
    'Tatal administrator',
    'Tatal users',
    'Tatal FP',
    'Tatal Password',
    'Tatal manage record',
    'Tatal In and out record',
    'Nominal FP number',
    'Nominal user number',
    'Nominal In and out record number',
    'Remain FP number',
    'Remain user number',
    'Remain In and out record number');
  Languages: array[0..2] of string=(
    'English',
    'Simplified Chinese',
    'Traditional Chinese');
  BaudRates: array[0..6] of string=(
    '1200 bps',
    '2400 bps',
    '4800 bps',
    '9600 bps',
    '19200 bps',
    '38400 bps',
    '115200 bps');
  CRCs: array[0..2] of string=(
    'Nothing',
    'Even',
    'Odd');
  StopBits: array[0..1] of string=(
    'One',
    'Two');
  DateSps: array[0..1] of string=(
    '"/"',
    '"-"');
  MSpeeds: array[0..2] of string=(
    'Low speed',
    'High speed',
    'Auto');
  OnOffs: array[0..1] of string=(
    'Off',
    'On');
  YesNos: array[0..1] of string=(
    'No',
    'Yes');
  DateFormats: array[0..9] of string=(
    'YY-MM-DD','YY/MM/DD','YY.MM.DD',
    'MM-DD-YY','MM/DD/YY','MM.DD.YY',
    'DD-MM-YY','DD/MM/YY','DD.MM.YY',
    'YYYYMMDD');
  NetSpeeds: array[0..4] of string=
    ('10M_H','100M_H','10M_F','100M_F','AUTO');
  NetSpeedValues: array[0..4] of integer=(0,1,4,5,8);

procedure TForm1.FormCreate(Sender: TObject);
var
  s: widestring;
  i,j: integer;
begin

  AppPath:= ExtractFilePath(application.exename);
  CZKEM1.GetSDKVersion(s);
  label1.Caption := s;

  vleDevInfo.ItemProps[2].EditStyle := esPickList;
  for i:=0 to length(Languages)-1 do
    vleDevInfo.ItemProps[2].PickList.Add(Languages[i]);

   vleDevInfo.ItemProps[8].EditStyle := esPickList;
  for i:=0 to length(BaudRates)-1 do
    vleDevInfo.ItemProps[8].PickList.Add(BaudRates[i]);

  vleDevInfo.ItemProps[9].EditStyle := esPickList;
  for i:=0 to length(CRCs)-1 do
    vleDevInfo.ItemProps[9].PickList.Add(CRCs[i]);

  vleDevInfo.ItemProps[10].EditStyle := esPickList;
  for i:=0 to length(StopBits)-1 do
    vleDevInfo.ItemProps[10].PickList.Add(StopBits[i]);

  vleDevInfo.ItemProps[11].EditStyle := esPickList;
  for i:=0 to length(DateSps)-1 do
    vleDevInfo.ItemProps[11].PickList.Add(DateSps[i]);

  for j := 12 to 15 do
  begin
    vleDevInfo.ItemProps[j].EditStyle := esPickList;
    for i:=0 to length(OnOffs)-1 do
      vleDevInfo.ItemProps[j].PickList.Add(OnOffs[i]);
  end;

  vleDevInfo.ItemProps[16].EditStyle := esPickList;
  for i:=0 to length(MSpeeds)-1 do
    vleDevInfo.ItemProps[16].PickList.Add(MSpeeds[i]);
end;

function LoadFile(const fn: string): string;
var
  f: tmemorystream;
begin
  result := '';
  f := tmemorystream.Create;
  try
    f.LoadFromFile(fn);
    f.Position := 0;
    if f.Size>0 then
    begin
      setlength(result, f.size);
      f.Read(result[1], length(result));
    end;
  finally
    f.Free;
  end;
end;

procedure SaveFile(const fn: string; Data: string);
var
  f: tmemorystream;
begin
  f := tmemorystream.Create;
  try
    if length(data)>0 then
      f.Write(Data[1], length(data));
    f.Position := 0;
    f.SaveToFile(fn);
  finally
    f.Free;
  end;
end;

procedure SaveFileData(const fn: string; const Data; size: integer);
var
  f: tmemorystream;
begin
  f := tmemorystream.Create;
  try
    if size>0 then
      f.Write(Data, size);
    f.Position := 0;
    f.SaveToFile(fn);
  finally
    f.Free;
  end;
end;

procedure TForm1.btnConnectClick(Sender: TObject);
var
  ErrorCode: integer;
  c: boolean;
begin
  if btnConnect.Tag = 1 then
  begin
    CZKEM1.RefreshData(DevId);
    CZKEM1.EnableDevice(DevId, TRUE);
    CZKEM1.Disconnect;
    btnConnect.Tag := 0;
    btnConnect.Caption := 'Connect';
  end
  else
  begin
    devid:=strtoint(edtNetPort.Text);
    if edtPassword.Text>'' then
      CZKEM1.SetCommPassword(strtoint(edtPassword.Text));
    if pos('COM', uppercase(edtNetAddress.text))=1 then
    begin
      commport:=ord(edtNetAddress.text[4])-ord('0');
      CZKEM1.CommPort := commport;
      c:=CZKEM1.Connect_Com( commport, DevID, strtoint(edtBaudRate.text));
    end
    else
    begin
      c:=CZKEM1.Connect_net(edtNetAddress.text, Devid);
      Devid:=1;
    end;                                                                    
    if c then
    begin
      AddInfo('Device Connected.');
      ReadDeviceStatus;
      btnConnect.Tag := 1;
      btnConnect.Caption := 'Disconnect';
    end
    else
    begin
      CZKEM1.GetLastError(ErrorCode);
      AddInfo(format('! ConnectDevice ErrorNo.=%d',[ErrorCode]));
    end;
    AddInfo(' ');
  end;
end;

procedure TForm1.AddInfo(const s: string);
begin
  memo1.Lines.Add(s);
  memo1.Refresh;
end;

procedure TForm1.btnLoadDevInfoClick(Sender: TObject);
var
  ErrorCode, Value, i: integer;
begin
  for i:=1 to vleDevInfo.RowCount-1 do
  if CZKEM1.GetDeviceInfo(devid, i, value) then
  begin
    if i=29 then
    begin
      vleDevInfo.Strings.ValueFromIndex[i-1]:=BNetSpeedEncode(Value);
    end
    else if vleDevInfo.ItemProps[i-1].HasPickList then
    begin
      if (value>=0) and (value<vleDevInfo.ItemProps[i-1].PickList.Count) then
        vleDevInfo.Strings.ValueFromIndex[i-1]:=vleDevInfo.ItemProps[i-1].PickList[value]
      else
        vleDevInfo.Strings.ValueFromIndex[i-1]:=inttostr(Value);
    end
    else if (i>=19) and (i<=22) then
      vleDevInfo.Strings.ValueFromIndex[i-1]:=BTimeEncode(Value)
    else
      vleDevInfo.Strings.ValueFromIndex[i-1]:=inttostr(Value);
  end
  else
  begin
    CZKEM1.GetLastError(ErrorCode);
    AddInfo(format('! GetDeviceInfo(%d) ErrorNo.=%d',[i, ErrorCode]));
  end;
  Modified:=stringofchar(#0,100);
  
{
  Modified:=stringofchar(#0,100);
  for i:=1 to 17 do
  if CZKEM1.GetDeviceInfo(devid, i, value) then
  begin
    if vleDevInfo.ItemProps[i-1].HasPickList then
    begin
      if (value>=0) and (value<vleDevInfo.ItemProps[i-1].PickList.Count) then
        vleDevInfo.Strings.ValueFromIndex[i-1]:=vleDevInfo.ItemProps[i-1].PickList[value]
      else
        vleDevInfo.Strings.ValueFromIndex[i-1]:=inttostr(Value);
    end
    else
      vleDevInfo.Strings.ValueFromIndex[i-1]:=inttostr(Value);
  end
  else
  begin
    CZKEM1.GetLastError(ErrorCode);
    AddInfo(format('! GetDeviceInfo(%d) ErrorNo.=%d',[i, ErrorCode]));
  end;
}
end;

procedure TForm1.btnSaveDevInfoClick(Sender: TObject);
var
  ErrorCode, Value, i: integer;
begin
  for i:=1 to vleDevInfo.RowCount-1 do
  if Modified[i]='1' then
  begin
    if i=29 then
    begin
      Value := BNetSpeedDecode(vleDevInfo.Strings.ValueFromIndex[i-1]);
    end
    else if vleDevInfo.ItemProps[i-1].HasPickList then
    begin
      for value:=0 to vleDevInfo.ItemProps[i-1].PickList.Count-1 do
      if vleDevInfo.ItemProps[i-1].PickList[value]=vleDevInfo.Strings.ValueFromIndex[i-1] then
        break;
      if value>=vleDevInfo.ItemProps[i-1].PickList.Count then
        value:=0;
    end
    else if (i>=19) and (i<=22) then
      Value := BTimeDecode(vleDevInfo.Strings.ValueFromIndex[i-1])
    else
      value:=strtoint(vleDevInfo.Strings.ValueFromIndex[i-1]);
    if not CZKEM1.SetDeviceInfo(devid, i, value) then
    begin
      CZKEM1.GetLastError(ErrorCode);
      AddInfo(format('! SetDeviceInfo(%d) ErrorNo.=%d',[i, ErrorCode]));
      exit;
    end
    else
      Modified[i]:=#0;
    if i=2 then
    begin
      edtNetAddress.Text := vleDevInfo.Strings.ValueFromIndex[i-1];
      DevId:=value;
    end;
  end;
  AddInfo('SetDeviceInfo OK');

end;

procedure TForm1.btnSetTimeClick(Sender: TObject);
var
  ErrorCode,
  dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond: integer;
begin
  if CZKEM1.SetDeviceTime(devid) then
  begin
    AddInfo('SetDeviceTime OK.');
    if CZKEM1.GetDeviceTime(devid, dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond) then
      AddInfo(Format('DeviceTime=%d-%d-%d %d:%d:%d',[dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond]))
    else
    begin
      CZKEM1.GetLastError(ErrorCode);
      AddInfo(format('! GetDeviceTime ErrorNo.=%d',[ErrorCode]));
    end;
  end
  else
  begin
    CZKEM1.GetLastError(ErrorCode);
    AddInfo(format('! SetDeviceTime ErrorNo.=%d',[ErrorCode]));
  end;
end;

procedure TForm1.btnClearDataClick(Sender: TObject);
begin
  CZKEM1.ClearKeeperData(devid);
end;

procedure TForm1.Button5Click(Sender: TObject);
begin
  CZKEM1.ClearGLog(devid);
end;

procedure TForm1.Button6Click(Sender: TObject);
begin
  CZKEM1.ClearAdministrators(DevId);
end;

procedure TForm1.Button9Click(Sender: TObject);
var
  dwTMachine, dwEnrollNumber,dwEMachineNumber,dwVerifyMode: Integer;
  dwInOutMode,dwYear,dwMonth,dwDay,dwHour,dwMinute: Integer;
  s: string;
  f: tfilestream;
begin
  if SaveDialog1.Execute then
  begin
    f:=tfilestream.Create(SaveDialog1.FileName, fmOpenWrite or fmCreate);
    try
    if CZKEM1.ReadGeneralLogData(DevId) then
    while CZKEM1.GetGeneralLogData(DevId,dwTMachine, dwEnrollNumber,dwEMachineNumber,dwVerifyMode,
      dwInOutMode,dwYear,dwMonth,dwDay,dwHour,dwMinute) do
    begin
      s:=format('%5d %d %d %4d-%2d-%2d %2d:%2d'#13#10, [dwEnrollNumber,dwVerifyMode,
        dwInOutMode,dwYear,dwMonth,dwDay,dwHour,dwMinute]);
      f.Write(s[1],length(s));
    end;
    finally
      f.Free;
    end;
  end;
end;

function NumOfHex(c: Char): integer;
begin
  result := 0;
  if c>='a' then result := ord(c)-ord('a')+10
  else if c>='A' then result := ord(c)-ord('A')+10
  else if c>='0' then result := ord(c)-ord('0');
  if result>16 then
    raise exception.Create('Error of Integer: '+c);
end;

type
  TByteArray=array[0..0] of byte;
  PByteArray=^TByteArray;

function encodedata(const BinData; size: integer): string;
var
  i: integer;
  da: pbytearray;
begin
  setlength(result, size*2);
  da:=@BinData;
  for i:= 0 to size-1 do
  begin
    result[i*2+1]:=HexOfNum[da[i] div 16];
    result[i*2+2]:=HexOfNum[da[i] mod 16];
  end;
end;

function decodedata(const s: string): string;
var
  i: integer;
  da: pbytearray;
begin
  setlength(result, length(s) div 2);
  for i:= 1 to length(result) do
  begin
    result[i]:=char(NumOfHex(s[i*2-1])*16+NumOfHex(s[i*2]));
  end;
end;

procedure TForm1.Button3Click(Sender: TObject);
begin
  CZKEM1.PowerOffDevice(DevID);
end;

procedure TForm1.BackupUser(const fn: string);
var
  f: tinifile;
  dwEnrollNumber,dwBackupNumber,Password,
  dwMachinePrivilege,i,c,Len: integer;
  EnrollData: array[0..2047] of byte;
  s: string;
  Enable: WordBool;
  UName, UPwd: widestring;
begin
  DeleteFile(fn);
  f := tinifile.Create(fn);
  try
    if CZKEM1.ReadAllUserID(DevID) then
    begin
      c:=0;
      while CZKEM1.GetAllUserInfo(DevID, dwEnrollNumber, UName, UPwd,
        dwMachinePrivilege, Enable) do
      begin
        s:=format('Users_%d',[dwEnrollNumber]);
        f.WriteInteger(s,'Privilege',dwMachinePrivilege);
        f.WriteBool(s,'Enabled', Enable);
        f.WriteString(s, 'Name', UName);
        f.WriteString(s, 'Password', UPwd);
        //Try get every fingerprint template
        for i:=0 to 9 do
        begin
          zeromemory(@EnrollData[0], 2048);
          Len:=2048;
          if CZKEM1.GetUserTmp(DevId, dwEnrollNumber, i, EnrollData[0], Len) then
            f.WriteString(s, 'FPT_'+inttostr(i), encodedata(EnrollData[0], Len));
        end;
        inc(c);
      end;

    end;
  finally
    f.Free;
  end;
end;

procedure TForm1.ReadDeviceStatus;
var
  s: widestring;
  ErrorCode, Value, i,
  dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond: integer;
begin
  if CZKEM1.GetFirmwareVersion(devid, s) then
    AddInfo('Firmware Version: '+s)
  else
  begin
    CZKEM1.GetLastError(ErrorCode);
    AddInfo(format('! GetFirmwareVersion ErrorNo.=%d',[ErrorCode]));
  end;
  if CZKEM1.GetSerialNumber(devid, s) then
    AddInfo('Serial Number: '+s)
  else
  begin
    CZKEM1.GetLastError(ErrorCode);
    AddInfo(format('! GetSerialNumber ErrorNo.=%d',[ErrorCode]));
  end;

  if CZKEM1.GetProductCode(devid, s) then
    AddInfo('ProductCode: '+s)
  else
  begin
    CZKEM1.GetLastError(ErrorCode);
    AddInfo(format('! GetProductCode ErrorNo.=%d',[ErrorCode]));
  end;

  if CZKEM1.GetDeviceTime(devid, dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond) then
    AddInfo(Format('DeviceTime=%d-%d-%d %d:%d:%d',[dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond]))
  else
  begin
    CZKEM1.GetLastError(ErrorCode);
    AddInfo(format('! GetDeviceTime ErrorNo.=%d',[ErrorCode]));
  end;

  for i:=1 to length(StatusNames) do
  if CZKEM1.GetDeviceStatus(devid, i, value) then
    AddInfo(format('%s: %d', [StatusNames[i],value]))
  else
  begin
    CZKEM1.GetLastError(ErrorCode);
    AddInfo(format('! GetDeviceStatus(%d) ErrorNo.=%d',[i, ErrorCode]));
  end;
end;

procedure TForm1.RestoreUser(const fn: string);
var
  f: tinifile;
  eno,i: integer;
  dwEnrollNumber,dwBackupNumber,Password,
  dwMachinePrivilege, dwEnable, c: integer;
  fpt, s, UName, UPwd: string;
  Sections: Tstrings;
begin
    f:=tinifile.Create(fn);
    try
    Sections := tstringlist.Create;
      try
        f.ReadSections(Sections);
        for i:=1 to 65534 do
        begin
          s:=format('Users_%d',[i]);
          if Sections.IndexOf(s)>=0 then
          begin
            Application.ProcessMessages;
            dwMachinePrivilege := f.ReadInteger(s, 'Privilege', 0);
            dwEnable := f.ReadInteger(s, 'Enabled', 1);
            UPwd := f.ReadString(s, 'Password', '');
            if UPwd='-1' then
              UPwd:='';
            UName := f.ReadString(s, 'Name','');
            CZKEM1.SetUserInfo(DevId, i, UName, UPwd, dwMachinePrivilege, dwEnable<>0);
            for dwBackupNumber:=0 to 9 do
            begin
              fpt:=f.ReadString(s, 'FPT_'+inttostr(dwBackupNumber), '');
              if fpt>'' then
              begin
                fpt:=decodedata(fpt);
                if CZKEM1.SetUserTmp(DevId, i, dwBackupNumber, pbyte(@fpt[1])^) then
                  AddInfo(format('SetEnrollData OK: User=%d,FP=%d', [i,dwBackupNumber]))
                else
                begin
                  CZKEM1.GetLastError(eno);
                  AddInfo(format('SetEnrollData Fail: User=%d,FP=%d, Error=%d', [i,dwBackupNumber,eno]));
                end;
              end;
            end;

          end;
        end;
      finally
        sections.Free;
      end;
    finally
      f.free;
    end;
end;

procedure TForm1.vleDevInfoValidate(Sender: TObject; ACol, ARow: Integer;
  const KeyName, KeyValue: String);
begin
  Modified[ARow] := '1';
end;

procedure TForm1.btnSetNameClick(Sender: TObject);
begin
  ShowUserForm(CZKEM1, DevID);
end;

procedure TForm1.btnDeleteUserClick(Sender: TObject);
begin
  CZKEM1.DeleteEnrollData(DevId, 69, DevId, 0);
  CZKEM1.DeleteEnrollData(DevId, 69, DevId, 1);
end;

var
  Testing: Boolean=false;

procedure TForm1.btnAutoTestClick(Sender: TObject);
var
  i: integer;
begin
  Testing:=not Testing;
  if Testing then
    btnAutoTest.Caption := 'End Test'
  else
    btnAutoTest.Caption := 'Start Test';
  i:=0;
  while Testing do
  begin
    AddInfo(Format('-----------Testing %d--------',[i]));
    inc(i);
    btnConnect.Click;
    if btnConnect.Tag=0 then
    begin
      Testing:=not Testing;
      if Testing then
        btnAutoTest.Caption := 'End Test'
      else
        btnAutoTest.Caption := 'Start Test';
      break;
    end;
//    sleep(1000);
    Addinfo('Clear Data...');
    btnClearData.Click;
    if FileExists(OpenDialog1.FileName) then
      RestoreUser(OpenDialog1.FileName);
    Application.ProcessMessages;
    Addinfo('Delete User 69...');
    btnDeleteUser.Click;
    Sleep(2000);
    ReadDeviceStatus;
    Application.ProcessMessages;
    if FileExists(OpenDialog1.FileName) then
      RestoreUser(OpenDialog1.FileName);
    ReadDeviceStatus;
    Addinfo('Clear Data...');
    btnClearData.Click;
    Addinfo('Disconnect...');
    btnConnect.Click;
    Application.ProcessMessages;
  end;
end;

procedure TForm1.btnBackupUserClick(Sender: TObject);
begin
  if savedialog1.Execute then
    BackupUser(savedialog1.FileName);
end;

procedure TForm1.btnRestoreClick(Sender: TObject);
begin
  if OpenDialog1.Execute then
    RestoreUser(OpenDialog1.FileName);
end;

procedure TForm1.sbtnRS232Click(Sender: TObject);
begin
  edtnetAddress.EditLabel.Caption := 'Com Port:';
  edtNetPort.EditLabel.Caption := 'Device ID:';
  edtnetAddress.Text := 'COM1';
  edtNetPort.Text := '1';

end;

procedure TForm1.sbtnTCPIPClick(Sender: TObject);
begin
  edtnetAddress.EditLabel.Caption := 'IP Address:';
  edtNetPort.EditLabel.Caption := 'Port Number:';
  edtnetAddress.Text := '192.168.1.201';
  edtNetPort.Text := '$1112';
end;

procedure TForm1.btnACUnlockClick(Sender: TObject);
begin
  CZKem1.ACUnlock(DevId,200)
end;

procedure TForm1.chkEnabledClick(Sender: TObject);
begin
  CZKEM1.EnableDevice(DevID, chkEnabled.Checked);
end;
const
 TEMP1='A1CA268296295AA10B50AA604009469950016A41194E3C514A3754D318D6B94D4019DDBE7A' +
       '0312DCC078000EE52277F10735AF7A780D44A24FA30B4FB92BB80A819468610C221250401A' +
       '071C7A93092B8A6C400E18147DF109249C53B81740A747F30CC8945FBC12258D42540FDFA4' +
       '39FC10B9867CD20714993DB409C71C26330B453341BC10778873F40788B461B410C6BF4FA3' +
       '09E9B418382C9B266B930740BD5D78136AA73F323DC1283D405FB52D12220739A587380A31' +
       'AB2ED116263F293C0B7A46140614C334EA0F10117E4C56A5A8BACEFFFBEC12C0434C55A299' +
       'AACE6E76A2FCECA846A2FF99995D656F7707A1DFC9184BA2AE799958616D010A12A1EA994B' +
       'A19E6881545C6C0313A1FBA81F48A3BB7688BF5D1521248343A3CC8667AC49392FA1776728' +
       '42A7BC8467BB5215656742A79C6558CC7535556641A28A5646404BA3842663663FA2796521' +
       '3A51A3734545363DA16A312418086E57A2433343383E3A38231A120C026F5CA23454413D39' +
       '3314A227543061A244655246382104A2BA652164A2586454517E2A05A498656448A2615F57' +
       '54C207A4565A978AA2704B43C476A29AA8BD0FE0317773';
  TEMP2='ocoqgo5BMsMGAcUxvArqwlMxCOlEWfwM6qEuYQs4OTSAEHuUQ4EZOKhGQAyTETuTDUYqLABqNQM9wxNhDxUABMcRS/FQJChldAyKtSsjEQIjQ/gOnyYoIRhOKj7AEpQRSJNlMokb'+
        'AAVSrlTxDYAfNwAJLxErMwxKmQ88BcUbINQLSZMVfAZPk1zSBZoiafQMmK9tMwV+C2l8BJmEUzQOhjdctAl4sRdjC9I7SzgIdQt0swomn3Z4B5undLIQijUaQA/gFH9iA521brgI'+
        'dwhXkROGwmF8Cu4pVEQSX4BKCxARfk5Woau7aXQHFKH8qSPAR6L+qrpkcQYWof2agUeiz6mJXGkFGCGhuZgmR6LOiIdUXQscofyYgUqjq4ZmkiWiTKl5KEqjuWRWUS2hKZiCSqap'+
        'YkYyE3h5gUmnqlMzMiRniXhLoZpSPjWkAVVXiHdNoapjPi0hozd1d3YRTqG8eEkapEaGVnh4S6Hvnm4HpOeGZniJRU5cYGdzA6PIhneHgT9LYmhudqLahmWCd3d+Q2qmzMyXV2eY'+
        'lMJzpaqmh3d6hl/DA6Rmd4iXmGPAxAWiVIiageD/';

procedure TForm1.Button1Click(Sender: TObject);
var
  i: integer;
begin
  i:= CZKEM1.GetFPTempLengthStr(TEMP2);
  Memo1.lines.add(format('FPTempLength=%d',[i]));

  if CZKEM1.SetEnrollDataStr(devid, 1, devid, 0, 1, TEMP2, 0) then
    Memo1.lines.add('SetEnrollDataStr OK')
  else
    Memo1.lines.add('SetEnrollDataStr Fail.');
end;

function TForm1.BTimeDecode(const TimeStr: string): integer;
var
  p,m,s: integer;
begin
  p := pos(':', TimeStr);
  m:=strtointdef(copy(TimeStr,1,p-1),-1);
  s:=strtointdef(copy(TimeStr,p+1,100),-1);
  if (m<0) or (s<0) or (m>255) or (s>255) then result := 255;
  result := m *256+s;
end;

function TForm1.BTimeEncode(MinuteSecond: integer): string;
var
  m,s: integer;
begin
  m:=MinuteSecond div 256;
  s:=MinuteSecond mod 256;
  if (MinuteSecond<0) or (m>59) or (s>59) then
    result := 'No'
  else
    result := format('%d:%d', [m,s]);
end;

function TForm1.BNetSpeedDecode(const speed: string): integer;
var
  i: integer;
begin
  result := NetSpeedValues[0];
  for i := 0 to length(NetSpeeds)-1 do
  if speed=NetSpeeds[i] then
  begin
    result := NetSpeedValues[i];
    exit;
  end;
end;

function TForm1.BNetSpeedEncode(speed: integer): string;
var
  i: integer;
begin
  result := NetSpeeds[0];
  for i := 0 to length(NetSpeeds)-1 do
  if speed=NetSpeedValues[i] then
  begin
    result := NetSpeeds[i];
    exit;
  end;
end;

procedure TForm1.Button4Click(Sender: TObject);
begin
  if SaveDialog1.Execute then
    SaveGLogs(SaveDialog1.filename);
end;

function TForm1.SaveGLogs(const fn: string): integer;
var
  dwEnrollNumber, dwSEnrollNumber, Params3,
    Params0, Params1, dwManipulation, Params2, dwYear,
    dwMonth, dwDay, dwHour, dwMinute: Integer;
  s: string;
  f: tfilestream;
begin
  result := 0;
  f:=tfilestream.Create(fn, fmOpenWrite or fmCreate);
  try
  if CZKEM1.ReadSuperLogData(DevId) then
  while CZKEM1.GetSuperLogData(DevId, dwEnrollNumber, dwSEnrollNumber, Params3,
    Params0, Params1, dwManipulation, Params2, dwYear,
    dwMonth, dwDay, dwHour, dwMinute) do
  begin
    s:=format('%5d %5d %5d %5d %5d %5d %d-%d-%d %d:%d'#13#10,[dwSEnrollNumber, dwManipulation,
      Params0, Params1, Params2, Params3,
      dwYear, dwMonth, dwDay, dwHour, dwMinute]);
    f.Write(s[1],length(s));
    inc(result);
  end;
  finally
    f.Free;
  end;
end;

procedure TForm1.btnSMSClick(Sender: TObject);
begin
  if btnSMS.Tag=0 then
  begin
    //CZKEM1.SetSMS(0, 4, 'Welcome to ZK');
   // CZKEM1.SetSMS(1, 2, 'Meet at 10:00');
   // CZKEM1.SetSMS(2, 3, 'Write a report for C12 item');
    //btnSMS.Caption := 'Clear SMS';
    //btnSMS.Tag:=1;
  end
  else
  begin
   // CZKEM1.SetSMS(0, 0, '');
    //CZKEM1.SetSMS(1, 0, '');
   // CZKEM1.SetSMS(2, 0, '');
   // btnSMS.Caption := 'Set SMS';
   // btnSMS.Tag:=0;
  end;
end;

procedure TForm1.Button7Click(Sender: TObject);
var
  w,h: integer;
  image: array of byte;
begin
  setlength(image, 1024*512);
  w := 80;
  if CZKEM1.CaptureImage(TRUE, w, h, Image[0], 'fp.bmp') then
  begin
    addinfo('Captured an image.');
  end
  else
    addinfo('Capture image fail.');
end;

procedure TForm1.Button8Click(Sender: TObject);
begin
  if CZKEM1.UpdateFirmware('emfw.cfg') then
  begin
    addinfo('UpdateFirmware success.pls restart the devie.');
  end
  else
    addinfo('UpdateFirmware fail.');
end;

procedure TForm1.Button12Click(Sender: TObject);
begin
  CZKEM1.clearLCd;
end;

procedure TForm1.Button11Click(Sender: TObject);
begin
  czkem1.EnableClock(0);
  czkem1.WriteLCD(0,0,'        ***          ');
  czkem1.WriteLCD(1,0,'Welcome to ZK');
  czkem1.WriteLCD(2,0,'        ***          ');
  czkem1.WriteLCD(3,0,'        ');
  MessageDlg('Close this window to restore lcd display', mtInformation, [mbOK], 0);
  czkem1.EnableClock(1);
end;

procedure TForm1.Button14Click(Sender: TObject);
begin
  czkem1.Beep(1000);
end;

procedure TForm1.Button13Click(Sender: TObject);
var
  i: integer;
begin
  for i:=0 to 9 do
  begin
    czkem1.PlayVoiceByIndex(i);
    if MessageDlg('Continue next voice?', mtConfirmation, [mbYes,mbNo], 0) <> mrYes then
      exit;
  end;
  czkem1.PlayVoice(30,29);
end;

procedure TForm1.Button15Click(Sender: TObject);
var
  ErrorCode: integer;
begin
  CZkEM1.CancelOperation;
  CZkEM1.DelUserTmp(1, 65530, 0);
  if CZkEM1.StartEnroll(65530, 0) then
    AddInfo('Start Enroll a user, UserID=65530, FingerID=0')
  else
  begin
    CZkEM1.GetLastError(ErrorCode);
    AddInfo('StartEnroll Error, Code='+inttostr(ErrorCode));
  end;
end;

procedure TForm1.Button16Click(Sender: TObject);
var
  ErrorCode: integer;
begin
  CZkEM1.CancelOperation;
  if CZkEM1.StartVerify(65530, 0) then
    AddInfo('Start Verify a user, UserID=65530, FingerID=0')
  else
  begin
    CZkEM1.GetLastError(ErrorCode);
    AddInfo('StartVerify Error, Code='+inttostr(ErrorCode));
  end;
end;

procedure TForm1.Button17Click(Sender: TObject);
var
  ErrorCode: integer;
begin
  CZkEM1.CancelOperation;
  if CZkEM1.StartIdentify then
    AddInfo('StartIdentify user.')
  else
  begin
    CZkEM1.GetLastError(ErrorCode);
    AddInfo('StartIdentify Error, Code='+inttostr(ErrorCode));
  end;
end;

procedure TForm1.Button18Click(Sender: TObject);
var
  ErrorCode: integer;
begin
  if CZkEM1.CancelOperation then
    AddInfo('CancelOperation OK.')
  else
  begin
    CZkEM1.GetLastError(ErrorCode);
    AddInfo('CancelOperation Error, Code='+inttostr(ErrorCode));
  end;
end;

procedure TForm1.CZKEM1FingerFeature(ASender: TObject; Score: Integer);
begin
  AddInfo(format('Finger Feature: %d',[Score]));
end;

procedure TForm1.CZKEM1Verify(ASender: TObject; UserID: Integer);
begin
  AddInfo(format('User Verified: %d',[UserID]));
end;

procedure TForm1.Button19Click(Sender: TObject);
var
  ErrorCode: integer;
begin
  if SaveDialog2.Execute then
  begin
    if CZKEM1.BackupData(SaveDialog2.FileName) then
    begin
      AddInfo('Backup Data to File: "'+SaveDialog2.FileName+'" OK.');
      if OpenDialog2.FileName='' then
        OpenDialog2.FileName := SaveDialog2.FileName;
    end
    else
    begin
      CZkEM1.GetLastError(ErrorCode);
      AddInfo('CancelOperation Error, Code='+inttostr(ErrorCode));
    end;
  end;
end;

procedure TForm1.Button20Click(Sender: TObject);
var
  ErrorCode: integer;
begin
  if OpenDialog2.Execute then
  begin
    if CZKEM1.RestoreData(OpenDialog2.FileName) then
      AddInfo('Restore Data from File: "'+OpenDialog2.FileName+'" OK.')
    else
    begin
      CZkEM1.GetLastError(ErrorCode);
      AddInfo('RestoreData Error, Code='+inttostr(ErrorCode));
    end;
  end;

end;


procedure TForm1.Button2Click(Sender: TObject);
var
  name : string;
  template: widestring;
  pass : string;
  machinenum,EnrollNum,pri1,fingerIndex: integer;
  fL: integer;
  pri,xx : boolean;
  cc : integer;
begin
    name :='aaa';
    pass := '';
    machinenum := 1;
    EnrollNum := 1;
    pri := true;
    pri1 := 0;
    fingerIndex:=0;
    fL :=2048;
 {   template := 'A1CA1C83A04029823D23442FC3177E292C422156AE22421242B554020F3D4' +
                 'B4F8204DDB62AC21031B41E020B43B135C21326964CC207169F5D83061E9F3A'+
                 'C20B153364820A2BCA684206CF2228C21465231BC30E5BB75AC20C38C724421C'+
                 'E04038421190353F820E9CAA18C20B4D273CC21585BC22021441334583139F1B4902068B'+
                 '13194208718A2CC3087CBB4482538A26646B0C9D840E12ADB8700A1115C304A2ACB98A12C0C2'+
                 '00A3BBCAA99B15C0C175A4ABBCBA9BAB18C0C176A49ABCCABBAA19C07E72A59ABBCDBBBAAAC0'+
                 '7E6EA5ABCCCDCCAAAA1BC07E69A5ADDDDDDDAA991CC07E64A5CCEEFFECB9991EC07E6062666C75'+
                 '060F17A1CBA881C07E5A5B5E646F05121BA2CAA877C07E525254596607171FA2CB887724C07E4D81'+
                 '4C4725A33CCB777625C07E4B4A4843382BA32CDC646627C07E4948453D332A242935A2C43466C07E'+
                 '4948443B2F251E2342A2901466C07E4A49463E2E1F1506574B413B3735C0C14B4A462A120B736155'+
                 '4B443E3CC0C14F50556D07047065A1112248C0C2575E6B00016FA1134459C0C76BA156555DC0C96A6'+
                 '967E00000';  }
                 template := 'A1CA20839C26602F0C3CA9652F083ABF462E0978C349ED0C7420396B3A43B8282C11D3C2'+
                 '552C0569AD2B6C1142BF212A11DB4034EA0A01A7316C0C352340AC172A1148ED12162570ED0A2D3C722E0AD1'+
                 'C33A2E0872373FAB0C80A7516A18A32E4FA84989A849E8119F25296809449F2DA811459C24E80E501523E70E5B1'+
                 '949A215870B5255188A9435C210681A393A1F5A387E7B1FC2B240FB0F942F803C1334A03EC0552426E4470FA00'+
                 '46B14AE108D0C1011C503060709C0C477A2CBBADDC0C373A3ADDBCFD91CC0C36FA4CFDCFFCA9AC0C265686E750'+
                 '50B14A2EBCA89C0C25F5F6470020C18A2FAAA99C0C15657575B64750F1CA1F9AA82C150A1979B6D1CA3EDAA877'+
                 '8C14CA187443628A37EA976587E4B8147423A31292931A2D844477E4B81463F352D252739A2F34335C14B4B473F'+
                 '33261D194BA2511435C14D4D4B442F1B1305615248A11546C14F505254760E09776A5C53A10357C1535559617104'+
                 '04746BA2032589C1575B606972A4F812355799C260A5DEEB7446757865C369A4CCA764676766E0FFFFFF';
//    xx := czkem1.GetUserTmpStr(machinenum,EnrollNum,fingerIndex,template,fingerLen);
       // czkem1.GetUserTmpStr(machinenum,EnrollNum,fingerIndex,template,fL);
    xx := czkem1.setUserInfo(machinenum,EnrollNum,name,pass,pri1,pri);
    xx := czkem1.SetUserTmpStr(machinenum,EnrollNum,fingerIndex,template);
end;

end.
