unit uUser;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Grids, ValEdit,zkemkeeper_TLB;

type
  TfrmUser = class(TForm)
    edtPIN: TEdit;
    Label1: TLabel;
    GroupBox1: TGroupBox;
    Label2: TLabel;
    Label3: TLabel;
    edtPwd: TEdit;
    chkEnabled: TCheckBox;
    cboPrivilege: TComboBox;
    Label4: TLabel;
    edtName: TEdit;
    GroupBox2: TGroupBox;
    vleTemps: TValueListEditor;
    Button7: TButton;
    Button8: TButton;
    Label5: TLabel;
    btnLoadDev: TButton;
    btnSaveDev: TButton;
    btnDelDev: TButton;
    btnLoadFile: TButton;
    btnSaveFile: TButton;
    btnDelFile: TButton;
    Button9: TButton;
    Button10: TButton;
    OpenDialog1: TOpenDialog;
    SaveDialog1: TSaveDialog;
    procedure btnLoadDevClick(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
    procedure btnSaveDevClick(Sender: TObject);
    procedure btnDelDevClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Button10Click(Sender: TObject);
    procedure Button7Click(Sender: TObject);
    procedure Button9Click(Sender: TObject);
  private
    Users: tstrings;
    function LoadDevUsers(Users: tstrings): integer;
    { Private declarations }
  public
    { Public declarations }
    CZKEM1: TCZKEM;
    DevID: integer;
  end;

function ShowUserForm(CZKEM1: TCZKEM; DevID: integer):TfrmUser;

implementation
uses uselone,comsdktest;
{$R *.dfm}

function ShowUserForm(CZKEM1: TCZKEM; DevID: integer): TfrmUser;
var
  frmUser: TfrmUser;
begin
  frmUser:= TfrmUser.Create(Application);
  result := frmUser;
  frmUser.CZKEM1 := CZKEM1;
  frmUser.DevID := DevId;
  result.ShowModal;
end;

function TfrmUser.LoadDevUsers(Users: tstrings): integer;
var
  dwEnrollNumber, dwMachinePrivilege: integer;
  Enable: WordBool;
  UName, UPwd: widestring;
begin
  Users.clear;
  result:=0;
  if CZKEM1.ReadAllUserID(DevID) then
  begin
    while CZKEM1.GetAllUserInfo(DevID, dwEnrollNumber, UName, UPwd,
      dwMachinePrivilege, Enable) do
    begin
      Users.Add(format('%-5d  %s',[dwEnrollNumber, UName]));
      inc(result);
    end;
  end;
end;

procedure TfrmUser.btnLoadDevClick(Sender: TObject);
var
  uEnabled: WordBool;
  UName, UPwd: widestring;
  uPrivilege, i, len: integer;
  tmp: array[0..2047]of byte;
begin
  if trim(edtPIN.Text)='' then
  begin
    i := LoadDevUsers(Users);
    if i>0 then
    begin
      i := 0;
      edtPIN.Text:=SelectItem(Users, i);
    end;    
  end;
  edtPIN.Text := trim(copy(edtPIN.Text,1,5));
  if edtPIN.Text='' then exit;
  CZKEM1.GetUserInfo(DevID, StrToInt(edtPIN.Text),
    UName, UPwd, uPrivilege, uEnabled);
  edtName.Text := UName;
  edtPwd.Text := UPwd;
  cboPrivilege.ItemIndex := uPrivilege mod cboPrivilege.Items.Count;
  chkEnabled.Checked := uEnabled;

  for i := 0 to 9 do
  begin
    Len:=0;
    zeromemory(@tmp[0],2048);
    len := 2048;
    if CZKEM1.GetUserTmp(DevId, StrToInt(edtPIN.Text), i, Tmp[0], Len) then
    begin
      vleTemps.Values[inttostr(i)]:=EncodeData(Tmp[0], Len);
    end;
  end;

end;

procedure TfrmUser.FormClose(Sender: TObject; var Action: TCloseAction);
begin
  Action := caFree;
end;

procedure TfrmUser.btnSaveDevClick(Sender: TObject);
begin
  CZKEM1.SetUserInfo(DevId, StrToInt(edtPin.Text), edtName.Text,
    edtPwd.Text, cboPrivilege.ItemIndex, chkEnabled.Checked);
end;

procedure TfrmUser.btnDelDevClick(Sender: TObject);
begin
  CZKEM1.DeleteEnrollData(DevId, strToInt(edtPin.Text), DevId, 12);
end;

procedure TfrmUser.FormCreate(Sender: TObject);
begin
  Users := tstringlist.Create;
end;

procedure TfrmUser.Button10Click(Sender: TObject);
var
  tmp: string;
  errno: integer;
begin
  if OpenDialog1.Execute then
  begin
    tmp:=LoadFile(OpenDialog1.Files[0]);
    if (length(tmp)>100) and (length(tmp)<2048) then
    begin
      if not CZKEM1.SetUserTmp(DevID, StrToInt(edtPIN.Text), vleTemps.Row-1, pbyte(@tmp[1])^) then
      begin
        CZKEM1.GetLastError(errno);
        MessageDlg(Format('Error to %s : %d!',['SetUserTmp', ErrNo]), mtError, [mbCancel], 0);
      end;
    end;
  end;
end;

procedure TfrmUser.Button7Click(Sender: TObject);
var
  Data, Data2: string;
  Size: integer;
begin
  if not SaveDialog1.Execute then exit;
  Data := vleTemps.Cells[1,vleTemps.Row];
  if Data='' then exit;
  Data := decodedata(Data);
  SaveFile(SaveDialog1.Files[0], Data);
  data2 := stringofchar(#0, 2048);
  if CZKEM1.FPTempConvert(pbyte(@Data[1])^, Pbyte(@Data2[1])^, Size) then
  begin
    setlength(Data2, Size);
    SaveFile(SaveDialog1.Files[0]+'.old', Data2);
  end;
end;

procedure TfrmUser.Button9Click(Sender: TObject);
begin
  CZKEM1.DelUserTmp(DevId, StrToInt(edtPIN.Text), vleTemps.Row-1)
end;

end.
