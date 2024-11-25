program emsdktst;

uses
  Forms,
  comsdktest in 'comsdktest.pas' {Form1},
  zkemkeeper_TLB in 'C:\Program Files\Borland\Delphi7\Imports\zkemkeeper_TLB.pas',
  uUser in 'uUser.pas' {frmUser},
  uSelOne in 'uSelOne.pas' {frmSelOne};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
