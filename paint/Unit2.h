//---------------------------------------------------------------------------

#ifndef Unit2H
#define Unit2H
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <Vcl.Controls.hpp>
#include <Vcl.StdCtrls.hpp>
#include <Vcl.Forms.hpp>
#include <System.ImageList.hpp>
#include <Vcl.Buttons.hpp>
#include <Vcl.ExtCtrls.hpp>
#include <Vcl.ImgList.hpp>
#include <Vcl.Menus.hpp>
#include <Vcl.Samples.Spin.hpp>
#include <Vcl.Dialogs.hpp>
//---------------------------------------------------------------------------
class TForm2 : public TForm
{
__published:	// IDE-managed Components
	TImage *Image1;
	TImageList *ImageList1;
	TMainMenu *MainMenu1;
	TPanel *Panel1;
	TSpeedButton *sbKarandash;
	TSpeedButton *sbLine;
	TSpeedButton *sbElipse;
	TSpeedButton *sbLastic;
	TSpeedButton *sbPipetka;
	TColorBox *ColorBox1;
	TShape *Shape1;
	TShape *Shape2;
	TSpinEdit *SpinEdit1;
	TComboBox *ComboBox1;
	TColorDialog *ColorDialog1;
	TComboBox *ComboBox2;
	TMenuItem *File1;
	TMenuItem *Save1;
	TMenuItem *Save2;
	TOpenDialog *OpenDialog1;
	TSaveDialog *SaveDialog1;
	TSpeedButton *sbZalivka;
	TCheckBox *CheckBox1;
	TSpeedButton *sbText;
	TButton *Button1;
	TEdit *Edit1;
	TFontDialog *FontDialog1;
	TPanel *Panel2;
	TButton *Button2;
	TLabel *Label1;
	TMenuItem *Edit2;
	TMenuItem *Edit3;
	TSpeedButton *sbVidilenie;
	TMenuItem *Copy1;
	TMenuItem *Copy2;
	TSpeedButton *sbKvadrat;
	TSpeedButton *sbTreugolnik;
	TSpeedButton *sbMoe;
	TButton *Button3;
	TButton *Button4;
	TPanel *Panel3;
	TButton *Button5;
	TButton *Button6;
	TButton *Button7;
	TButton *Button8;
	TButton *Button9;
	TButton *Button10;
	TMemo *Memo1;
	TMenuItem *Savevector1;
	TMenuItem *Savevector2;
	void __fastcall Image1MouseDown(TObject *Sender, TMouseButton Button, TShiftState Shift,
          int X, int Y);
	void __fastcall Image1MouseMove(TObject *Sender, TShiftState Shift, int X, int Y);
	void __fastcall Image1MouseUp(TObject *Sender, TMouseButton Button, TShiftState Shift,
          int X, int Y);
	void __fastcall ColorBox1Change(TObject *Sender);
	void __fastcall SpinEdit1Change(TObject *Sender);
	void __fastcall ComboBox1Change(TObject *Sender);
	void __fastcall Shape2MouseUp(TObject *Sender, TMouseButton Button, TShiftState Shift,
          int X, int Y);
	void __fastcall ComboBox2Change(TObject *Sender);
	void __fastcall Save1Click(TObject *Sender);
	void __fastcall Save2Click(TObject *Sender);
	void __fastcall CheckBox1Click(TObject *Sender);
	void __fastcall Button1Click(TObject *Sender);
	void __fastcall Edit1KeyUp(TObject *Sender, WORD &Key, TShiftState Shift);
	void __fastcall Button2Click(TObject *Sender);
	void __fastcall sbTextClick(TObject *Sender);
	void __fastcall Edit3Click(TObject *Sender);
	void __fastcall Copy2Click(TObject *Sender);
	void __fastcall Copy1Click(TObject *Sender);
	void __fastcall Button3Click(TObject *Sender);
	void __fastcall Button10Click(TObject *Sender);
	void __fastcall Button4Click(TObject *Sender);
	void __fastcall Button5Click(TObject *Sender);
	void __fastcall Button6Click(TObject *Sender);
	void __fastcall Button7Click(TObject *Sender);
	void __fastcall Button8Click(TObject *Sender);
	void __fastcall Button9Click(TObject *Sender);
	void __fastcall Savevector2Click(TObject *Sender);
	void __fastcall Savevector1Click(TObject *Sender);



private:	// User declarations
public:		// User declarations
	__fastcall TForm2(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm2 *Form2;
//---------------------------------------------------------------------------
#endif
