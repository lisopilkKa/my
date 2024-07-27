object Form2: TForm2
  Left = 0
  Top = 0
  Caption = 'Form2'
  ClientHeight = 507
  ClientWidth = 755
  Color = clBtnFace
  DoubleBuffered = True
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  Menu = MainMenu1
  OldCreateOrder = False
  WindowState = wsMaximized
  PixelsPerInch = 96
  TextHeight = 13
  object Image1: TImage
    Left = 0
    Top = 57
    Width = 755
    Height = 450
    Align = alClient
    OnMouseDown = Image1MouseDown
    OnMouseMove = Image1MouseMove
    OnMouseUp = Image1MouseUp
    ExplicitTop = 48
    ExplicitWidth = 370
    ExplicitHeight = 393
  end
  object Panel1: TPanel
    Left = 0
    Top = 0
    Width = 755
    Height = 57
    Align = alTop
    TabOrder = 0
    object sbKarandash: TSpeedButton
      Left = 0
      Top = 0
      Width = 25
      Height = 25
      GroupIndex = 1
      Caption = 'S'
    end
    object sbLine: TSpeedButton
      Left = 31
      Top = 0
      Width = 25
      Height = 25
      GroupIndex = 1
      Caption = '\'
    end
    object sbElipse: TSpeedButton
      Left = 62
      Top = 0
      Width = 25
      Height = 25
      GroupIndex = 1
      Caption = 'O'
    end
    object sbLastic: TSpeedButton
      Left = 181
      Top = 3
      Width = 25
      Height = 25
      GroupIndex = 1
      Caption = 'L'
    end
    object sbPipetka: TSpeedButton
      Left = 212
      Top = 3
      Width = 25
      Height = 25
      GroupIndex = 1
      Caption = 'P'
    end
    object Shape1: TShape
      Left = 368
      Top = 3
      Width = 25
      Height = 26
      Brush.Color = clBlack
    end
    object Shape2: TShape
      Left = 399
      Top = 3
      Width = 25
      Height = 26
      OnMouseUp = Shape2MouseUp
    end
    object sbZalivka: TSpeedButton
      Left = 243
      Top = 3
      Width = 25
      Height = 25
      GroupIndex = 1
      Caption = 'Z'
    end
    object sbText: TSpeedButton
      Left = 181
      Top = 26
      Width = 25
      Height = 25
      GroupIndex = 1
      Caption = 'T'
      OnClick = sbTextClick
    end
    object sbVidilenie: TSpeedButton
      Left = 212
      Top = 26
      Width = 25
      Height = 25
      GroupIndex = 1
      Caption = 'V'
    end
    object sbKvadrat: TSpeedButton
      Left = 0
      Top = 26
      Width = 25
      Height = 25
      GroupIndex = 1
      Caption = 'K'
    end
    object sbTreugolnik: TSpeedButton
      Left = 31
      Top = 26
      Width = 25
      Height = 25
      GroupIndex = 1
      Caption = 'Tr'
    end
    object sbMoe: TSpeedButton
      Left = 62
      Top = 26
      Width = 25
      Height = 25
      GroupIndex = 1
      Caption = 'M'
    end
    object ColorBox1: TColorBox
      Left = 430
      Top = 3
      Width = 81
      Height = 22
      TabOrder = 0
      OnChange = ColorBox1Change
    end
    object ComboBox1: TComboBox
      Left = 517
      Top = 3
      Width = 73
      Height = 21
      ItemIndex = 0
      TabOrder = 1
      Text = 'psSolid'
      OnChange = ComboBox1Change
      Items.Strings = (
        'psSolid'
        'psDash'
        'psDot'
        'psDashDot'
        'psDashDotDot'
        'psClear')
    end
    object ComboBox2: TComboBox
      Left = 517
      Top = 31
      Width = 73
      Height = 21
      ItemIndex = 0
      TabOrder = 2
      Text = 'bsSolid'
      OnChange = ComboBox2Change
      Items.Strings = (
        'bsSolid'
        'bsClear'
        'bsHorizontal'
        'bsVertical'
        'bsFDiagonal'
        'bsBDiagonal'
        'bsCross'
        'bsDiagCross')
    end
    object CheckBox1: TCheckBox
      Left = 274
      Top = 5
      Width = 79
      Height = 17
      Caption = 'fsBorder'
      TabOrder = 3
      OnClick = CheckBox1Click
    end
    object Button1: TButton
      Left = 704
      Top = 2
      Width = 51
      Height = 19
      Caption = 'clear'
      TabOrder = 4
      OnClick = Button1Click
    end
    object SpinEdit1: TSpinEdit
      Left = 430
      Top = 29
      Width = 49
      Height = 22
      MaxValue = 10
      MinValue = 1
      TabOrder = 5
      Value = 1
      OnChange = SpinEdit1Change
    end
    object Panel2: TPanel
      Left = 430
      Top = 2
      Width = 160
      Height = 54
      TabOrder = 6
      Visible = False
      object Label1: TLabel
        Left = 96
        Top = 10
        Width = 26
        Height = 13
        Caption = 'Shrift'
      end
      object Button2: TButton
        Left = 8
        Top = 5
        Width = 75
        Height = 25
        Caption = 'Shrift'
        TabOrder = 0
        OnClick = Button2Click
      end
    end
    object Button3: TButton
      Left = 596
      Top = 1
      Width = 45
      Height = 24
      Caption = 'moe'
      TabOrder = 7
      OnClick = Button3Click
    end
    object Panel3: TPanel
      Left = 430
      Top = 2
      Width = 166
      Height = 53
      TabOrder = 8
      Visible = False
      object Button4: TButton
        Left = 29
        Top = 1
        Width = 25
        Height = 20
        Caption = '^'
        TabOrder = 0
        OnClick = Button4Click
      end
      object Button5: TButton
        Left = 55
        Top = 18
        Width = 25
        Height = 20
        Caption = '>'
        TabOrder = 1
        OnClick = Button5Click
      end
      object Button6: TButton
        Left = 8
        Top = 18
        Width = 25
        Height = 20
        Caption = '<'
        TabOrder = 2
        OnClick = Button6Click
      end
      object Button7: TButton
        Left = 31
        Top = 36
        Width = 25
        Height = 20
        Caption = 'v'
        TabOrder = 3
        OnClick = Button7Click
      end
      object Button8: TButton
        Left = 111
        Top = 18
        Width = 25
        Height = 20
        Caption = '+'
        TabOrder = 4
        OnClick = Button8Click
      end
      object Button9: TButton
        Left = 86
        Top = 18
        Width = 25
        Height = 20
        Caption = '-'
        TabOrder = 5
        OnClick = Button9Click
      end
      object Button10: TButton
        Left = 145
        Top = 3
        Width = 15
        Height = 13
        Caption = 'x'
        TabOrder = 6
        OnClick = Button10Click
      end
    end
  end
  object Edit1: TEdit
    Left = 390
    Top = 144
    Width = 121
    Height = 21
    TabOrder = 1
    TextHint = 'Input text here'
    Visible = False
    OnKeyUp = Edit1KeyUp
  end
  object Memo1: TMemo
    Left = 0
    Top = 57
    Width = 193
    Height = 304
    TabOrder = 2
  end
  object ImageList1: TImageList
    Left = 248
    Top = 424
  end
  object MainMenu1: TMainMenu
    Left = 376
    Top = 416
    object File1: TMenuItem
      Caption = 'File'
      object Save1: TMenuItem
        Caption = 'Save'
        OnClick = Save1Click
      end
      object Save2: TMenuItem
        Caption = 'Open'
        OnClick = Save2Click
      end
      object Savevector1: TMenuItem
        Caption = 'Save vector'
        OnClick = Savevector1Click
      end
      object Savevector2: TMenuItem
        Caption = 'Open vector'
        OnClick = Savevector2Click
      end
    end
    object Edit2: TMenuItem
      Caption = 'Edit'
      object Edit3: TMenuItem
        Caption = 'Cancel'
        ShortCut = 16474
        OnClick = Edit3Click
      end
      object Copy1: TMenuItem
        Caption = 'Copy'
        OnClick = Copy1Click
      end
      object Copy2: TMenuItem
        Caption = 'Paste'
        OnClick = Copy2Click
      end
    end
  end
  object ColorDialog1: TColorDialog
    Left = 368
    Top = 256
  end
  object OpenDialog1: TOpenDialog
    Left = 280
    Top = 312
  end
  object SaveDialog1: TSaveDialog
    Left = 456
    Top = 288
  end
  object FontDialog1: TFontDialog
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = []
    Left = 296
    Top = 200
  end
end
