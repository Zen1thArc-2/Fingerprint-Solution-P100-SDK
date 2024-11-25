unit Unit2;

interface
{$define onlysynctime}
uses
  Classes, windows, SysUtils, OleCtrls, zkemkeeper_TLB;

type
  TLogReader = class(TThread)
  private
    { Private declarations }
    NewLogs: tstrings;
    FActive: boolean;
    FPeriod: integer;
    FConnected: boolean;
    CZKEM1: TCZKEM;
    DevID: integer;
    IPAddress: string;
    BaudRate, PortNo: integer;

    procedure UpdateList;
    procedure UpdateState;
    function Connect: boolean;
    procedure DisConnnect;
    function ReadLogs: integer;
    function SyncTime:integer;
    procedure ClearLogs;
    procedure SetActive(const Value: boolean);
    procedure SetPeriod(const Value: integer);
  protected
    procedure Execute; override;
  public
    constructor Create(AIPAddress: string; APortNumber: integer=4370); overload;
    constructor Create(APortNo: integer; ADevID: integer=1; ABaudRate: integer=115200); overload;
    destructor Destroy; override;

    property Connected: boolean read FConnected;
    property Active: boolean read FActive write SetActive;
    property Period: integer read FPeriod write SetPeriod;
  end;

implementation
uses unit1;

{ TLogReader }

procedure TLogReader.ClearLogs;
begin
  CZKEM1.ClearGLog(DevID);
end;

function TLogReader.Connect: boolean;
begin
  if not Connected then
  begin
    if IPAddress='' then
      FConnected := CZKEM1.Connect_Com(PortNo, DevID, BaudRate)
    else
      FConnected := CZKEM1.Connect_Net(IPAddress, PortNo);
    {$ifdef onlysynctime}
    SyncTime;
    {$endif}
    if Connected then Synchronize(UpdateState);
  end;
  result := Connected;
end;

constructor TLogReader.Create(AIPAddress: string; APortNumber: integer);
begin
  inherited Create(true);
  Period := 5;
  NewLogs := tstringlist.Create;
  IPAddress := AIPAddress;
  PortNo := APortNumber;
  DevID := 1;
  CZKEM1:= TCZKEM.Create(nil);
  resume;
end;

constructor TLogReader.Create(APortNo, ADevID, ABaudRate: integer);
begin
  inherited Create(true);
  Period := 5;
  NewLogs := tstringlist.Create;
  IPAddress := '';
  PortNo := APortNo;
  DevID := ADevID;
  BaudRate := ABaudRate;
  CZKEM1:= TCZKEM.Create(nil);
  resume;
end;

destructor TLogReader.Destroy;
begin
  CZKEM1.Free;
  NewLogs.free;
  inherited;
end;

procedure TLogReader.DisConnnect;
begin
  if Connected then
  begin
    CZKEM1.Disconnect;
    FConnected := false;
    Synchronize(UpdateState);
  end;
end;

procedure TLogReader.Execute;
var
  i: integer;
  OldActive: boolean;
begin
  while true do
  begin
    if FActive then
    begin
      if Connect then
      begin
        {$ifndef onlysynctime}
        if ReadLogs>0 then
        begin
          ClearLogs;
          Synchronize(UpdateList);
        end;
        {$endif}

      end;
    end
    else
      DisConnnect;
    OldActive := FActive;

    //Sleep Period
    i := 0;
    while i<FPeriod*2-1 do
    begin
      //sleep 500ms
      WaitForSingleObject(GetCurrentThread(), 500);
      if Terminated then exit;
      if OldActive xor FActive then break;
      inc(i);
    end;
  end;
end;

function TLogReader.ReadLogs: integer;
var
  dwTMachine, dwEnrollNumber,dwEMachineNumber,dwVerifyMode: Integer;
  dwInOutMode,dwYear,dwMonth,dwDay,dwHour,dwMinute: Integer;
  s: string;
  TimeStr: WideString;
  f: tfilestream;
begin
  NewLogs.Clear;
  result := 0;
  if CZKEM1.ReadGeneralLogData(DevID) then
    while CZKEM1.GetGeneralLogDataStr(DevID, dwEnrollNumber, dwVerifyMode,
      dwInOutMode,TimeStr) do
    begin
      s:=format('%5d %d %d %s', [dwEnrollNumber, dwVerifyMode, dwInOutMode,TimeStr]);
      NewLogs.Add(s);
      inc(result);
    end;
end;

procedure TLogReader.SetActive(const Value: boolean);
begin
  FActive := Value;
end;

procedure TLogReader.SetPeriod(const Value: integer);
begin
  FPeriod := Value;
end;

function TLogReader.SyncTime: integer;
begin
  //
  CZKEM1.SetDeviceTime(DevID);
end;

procedure TLogReader.UpdateList;
begin
  Form1.AddLogs(NewLogs);
end;

procedure TLogReader.UpdateState;
begin
  form1.UpdateState(self, FConnected);
end;

end.
