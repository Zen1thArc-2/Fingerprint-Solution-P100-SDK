unit Unit3;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Buttons, ExtCtrls;

type
  TForm3 = class(TForm)
    rgrpConnect: TRadioGroup;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    BitBtn1: TBitBtn;
    BitBtn2: TBitBtn;
    procedure rgrpConnectClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form3: TForm3;

implementation

{$R *.dfm}

procedure TForm3.rgrpConnectClick(Sender: TObject);
begin
  if rgrpConnect.ItemIndex =0 then
  begin
    Label1.Caption := 'COM Port:';
    Label2.Caption := 'Device ID:';
    edit1.Text := 'COM1';
    edit2.Text := '1';
    Label3.Visible := true;
    edit3.Visible := true;
  end
  else
  begin
    Label1.Caption := 'IPAddress:';
    Label2.Caption := 'Port Number:';
    edit1.Text := '192.168.1.201';
    edit2.Text := '4370';
    Label3.Visible := false;
    edit3.Visible := false;
  end;

end;

end.
