unit Unit1;

interface
{$define onlysynctime}
uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, Spin, StdCtrls, ExtCtrls, unit2, OleCtrls, zkemkeeper_TLB,
  CheckLst, iniFiles,strutils;
const CfgFn='DevList.cfg';
type
  TForm1 = class(TForm)
    Label1: TLabel;
    Timer1: TTimer;
    memLogs: TMemo;
    Label2: TLabel;
    Label3: TLabel;
    spePeriod: TSpinEdit;
    lblTimer: TLabel;
    btnCount: TButton;
    clbDevices: TCheckListBox;
    btnAddDevice: TButton;
    btnDelDevice: TButton;
    CheckBox1: TCheckBox;
    procedure Timer1Timer(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure spePeriodChange(Sender: TObject);
    procedure btnCountClick(Sender: TObject);
    procedure btnAddDeviceClick(Sender: TObject);
    procedure btnDelDeviceClick(Sender: TObject);
    procedure clbDevicesDrawItem(Control: TWinControl; Index: Integer;
      Rect: TRect; State: TOwnerDrawState);
    procedure clbDevicesClickCheck(Sender: TObject);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
    procedure FormDestroy(Sender: TObject);
    procedure CheckBox1Click(Sender: TObject);
  private
    { Private declarations }
    Connected: array[0..1000] of boolean;
    cfgFile:TiniFile;
    cfn:string;
    function SaveCfg():boolean;
  public
    { Public declarations }
    procedure AddLogs(logs: tstrings);
    procedure UpdateState(obj: tobject; Connect: Boolean);
  end;
  
var
  Form1: TForm1;
implementation
uses unit3;

{$R *.dfm}

procedure TForm1.AddLogs(logs: tstrings);
begin
  memLogs.Lines.AddStrings(logs);
end;

procedure TForm1.Timer1Timer(Sender: TObject);
begin
  lblTimer.Caption := timetostr(now);
end;

procedure TForm1.FormCreate(Sender: TObject);
var
  LogReader: TLogReader;
  i: integer;
  SectionList:TStrings;
  s,sTemp,par1,par2,par3:string;
begin
  {$ifdef onlysynctime}
  Form1.Caption := 'Sync time for BioClock';
  {$endif}
  memLogs.Lines.Clear;

  for i := 0 to 1000 do
    Connected[i]:= false;
  cfn := ExtractFilePath(Application.ExeName) + CfgFn;
  if FileExists(cfn) then
  begin
    CfgFile:= tinifile.Create(cfn);
  end;

  CheckBox1.Checked := False;
  if cfgFile.ReadString('Options','SyncOnStart','') = 'T' then
    CheckBox1.Checked := true;
  SectionList := TStringList.Create;
  CfgFile.ReadSection('DevList',SectionList);
  with clbDevices do
  begin
    for i:= 0 to SectionList.Count-1 do
    begin
      s:=CfgFile.ReadString('DevList',SectionList.Strings[i],'');
      if s<> '' then
      begin
        sTemp := s;
        par1 := leftstr(sTemp,pos(':',s)-1);

        sTemp := rightstr(sTemp,length(sTemp)-length(par1)-1);
        if pos(':',sTemp)>0 then
        begin
          par2 := leftstr(sTemp,pos(':',sTemp)-1);
        end
        else
          Par2 := sTemp;
        sTemp := rightstr(sTemp,length(sTemp)-length(par2)-1);
        par3 := sTemp;
      end;
      if (par1='') or (par2='') then exit;
      if pos('COM',uppercase(s))=0 then
      begin
        LogReader:= TLogReader.Create(par1,strtoint(par2) );
      end
      else
        LogReader:= TLogReader.Create(strtoint(copy(par1, 4,2)),
        strtoint(par2), strtoint(par3));
      LogReader.Period := spePeriod.Value;
      clbDevices.AddItem(s, LogReader);

      if CheckBox1.Checked then
      begin
        clbDevices.Checked[clbDevices.Items.Count-1]:=true;
        LogReader.Active := true;
      end;
    end;
  end;

end;

procedure TForm1.spePeriodChange(Sender: TObject);
var
  i: integer;
begin
  for i := 0 to clbDevices.Items.Count-1 do
    (clbDevices.Items.Objects[i] as TLogReader).Period := spePeriod.Value;
end;

procedure TForm1.btnCountClick(Sender: TObject);
begin
  MessageDlg(format('There are %d transaction logs.',
    [memLogs.Lines.Count]), mtInformation, [mbOK], 0);
end;

procedure TForm1.UpdateState(obj: tobject; Connect: Boolean);
var
  i: integer;
begin
  for i := 0 to clbDevices.Items.Count -1 do
  begin
    //clbDevices.item
    if clbDevices.Items.Objects[i]=obj then
    begin
      Connected[i] := Connect;
      clbDevices.Invalidate;
      {$ifdef onlysynctime}
      if obj=nil then exit;
      if (obj as TLogReader).Active then
        (obj as TLogReader).terminate;
      //Wait for the reader thread terminated.
      //WaitForSingleObject((obj as TLogReader).Handle, (spePeriod.Value+1)*1000);
      //(obj as TLogReader).Free;
      {$endif}
      break;
    end;
  end;
end;

procedure TForm1.btnAddDeviceClick(Sender: TObject);
var
  LogReader: TLogReader;
  i: integer;
  s:string;
begin
  form3 := tform3.create(self);
  try
    if form3.ShowModal=mrok then
    begin
      if clbDevices.Items.IndexOf(form3.Edit1.Text+':'+form3.Edit2.Text)>=0 then
        MessageDlg('Device in the list already.', mtWarning, [mbCancel], 0)
      else
      begin
        if form3.rgrpConnect.itemindex=0 then
        begin
          LogReader:= TLogReader.Create(strtoint(copy(form3.Edit1.Text, 4,2)),
            strtoint(form3.Edit2.Text), strtoint(form3.Edit3.Text));
        end
        else
          LogReader:= TLogReader.Create(form3.Edit1.Text,
            strtoint(form3.Edit2.Text));
        s :=  form3.Edit1.Text+':'+form3.Edit2.Text;
        if form3.rgrpConnect.itemindex=0 then
          s:= s+ ':' + form3.Edit3.Text;
        //asgDevList.row
        LogReader.Period := spePeriod.Value;
        clbDevices.AddItem(s, LogReader);
        clbDevices.Checked[clbDevices.Items.Count-1]:=true;
        LogReader.Active := true;
        SaveCfg;
      end;
    end;
  finally
    form3.Free;
  end;
end;

procedure TForm1.btnDelDeviceClick(Sender: TObject);
var
  LogReader: TLogReader;
begin
  if clbDevices.ItemIndex<0 then
  begin
    MessageDlg('Select a device please.', mtWarning, [mbCancel], 0);
    exit;
  end;
   
  LogReader := TLogReader(clbDevices.Items.Objects[clbDevices.ItemIndex]);
  if LogReader=nil then exit;

  LogReader.Terminate;
  //Wait for the reader thread terminated.
  WaitForSingleObject(LogReader.Handle, (spePeriod.Value+1)*1000);

  LogReader.Free;

  clbDevices.Items.Delete(clbDevices.ItemIndex);
  SaveCfg;
end;

procedure TForm1.clbDevicesDrawItem(Control: TWinControl; Index: Integer;
  Rect: TRect; State: TOwnerDrawState);
var
	Offset: Integer;      { text offset width }
begin


	with (Control as TCheckListBox).Canvas do  { draw on control canvas, not on the form }
	begin
    if Connected[Index] then
      Font.Color := clGreen
    else
      Font.Color := clRed;
    FillRect(Rect);       { clear the rectangle }
    Offset := 2;          { provide default offset }
    TextOut(Rect.Left + Offset, Rect.Top, (Control as TCheckListBox).Items[Index])  { display the text }
	end;
end;

procedure TForm1.clbDevicesClickCheck(Sender: TObject);
var
  i: integer;
begin
  for i := 0 to clbDevices.Items.Count-1 do
    (clbDevices.Items.Objects[i] as TLogReader).Active := clbDevices.Checked[i];
end;

procedure TForm1.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
var
  LogReader: TLogReader;
  i: integer;
begin
  for i := 0 to clbDevices.Items.Count-1 do
  begin
    LogReader := TLogReader(clbDevices.Items.Objects[i]);
    if LogReader<>nil then LogReader.Terminate;
  end;
  CfgFile.Free;
end;

procedure TForm1.FormDestroy(Sender: TObject);
var
  LogReader: TLogReader;
begin
  while clbDevices.Items.Count>0 do
  begin
    LogReader := TLogReader(clbDevices.Items.Objects[0]);
    //Wait for the reader thread terminated.
    WaitForSingleObject(LogReader.Handle, (spePeriod.Value+1)*1000);
    LogReader.Free;
    clbDevices.Items.Delete(0);
  end;
end;

function TForm1.SaveCfg: boolean;
var i:integer;
begin
  CfgFile.EraseSection('DevList');
  for i:= 0 to clbDevices.Items.Count -1 do
  begin
    CfgFile.WriteString('DevList','Dev' + inttostr(i),clbDevices.Items.Strings[i]);
  end;
end;

procedure TForm1.CheckBox1Click(Sender: TObject);
begin
  if CheckBox1.Checked then
    cfgFile.WriteString('Options','SyncOnStart','T')
  else
    cfgFile.WriteString('Options','SyncOnStart','F')
end;

end.
