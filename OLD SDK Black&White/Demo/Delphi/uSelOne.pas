unit uSelOne;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TfrmSelOne = class(TForm)
    ListBox1: TListBox;
    Button1: TButton;
    Button2: TButton;
  private
    { Private declarations }
  public
    { Public declarations }
  end;


function SelectItem(Items: tstrings; var Selected: integer): string;

implementation

{$R *.dfm}

function SelectItem(Items: tstrings; var Selected: integer): string;
var
  frmSelOne: TfrmSelOne;
begin
  frmSelOne:= TfrmSelOne.Create(application);
  try
    frmSelOne.ListBox1.Items.Assign(Items);
    if (Selected>=0) and (Selected<frmSelOne.ListBox1.Items.Count) then
      frmSelOne.ListBox1.ItemIndex:=Selected;
    if frmSelOne.ShowModal=mrok then
    begin
      selected := frmSelOne.ListBox1.ItemIndex;
      if selected>=0 then
        result := frmSelOne.ListBox1.Items[selected];
    end;
  finally
    frmSelOne.Free;
  end;
end;

end.
