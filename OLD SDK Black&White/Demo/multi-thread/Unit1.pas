unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, Spin, StdCtrls, ExtCtrls, unit2, OleCtrls,  CheckLst;

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
  private
    { Private declarations }
    Connected: array[0..1000] of boolean;
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
  i: integer;
begin
  memLogs.Lines.Clear;
  application.ProcessMessages;
  for i := 0 to 1000 do
    Connected[i]:= false;
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
    if clbDevices.Items.Objects[i]=obj then
    begin
      Connected[i] := Connect;
      clbDevices.Invalidate;
      break;
    end;
  end;
end;

procedure TForm1.btnAddDeviceClick(Sender: TObject);
var
  LogReader: TLogReader;
  i: integer;
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
          LogReader:= TLogReader.Create(strtoint(copy(form3.Edit1.Text, 4,2)),
            strtoint(form3.Edit2.Text), strtoint(form3.Edit3.Text))
        else
          LogReader:= TLogReader.Create(form3.Edit1.Text,
            strtoint(form3.Edit2.Text));
        LogReader.Period := spePeriod.Value;
        clbDevices.AddItem(form3.Edit1.Text+':'+form3.Edit2.Text, LogReader);
        clbDevices.Checked[clbDevices.Items.Count-1]:=true;
        LogReader.Active := true;
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

end.
