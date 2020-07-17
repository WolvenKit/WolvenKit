using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text;
using ScintillaNET;
using ScintillaNET_FindReplaceDialog;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App;

namespace WolvenKit.Forms
{
    public partial class frmScriptEditor : DockContent
    {
        private const bool CodeFoldingCircular = true;
        private readonly FindReplace ScintillaFindReplace;

        public string autocompletelist = "array< PushBack string int integer bool float name range event function abstract const final private protected public theGame theInput thePlayer theSound enum struct state array false NULL true out inlined autobind editable entry exec hint import latent optional out quest saved statemachine timer break case continue else for if return switch while";
        public bool IsUnsaved { get; set; }


        public frmScriptEditor()
        {
            InitializeComponent();

            ScintillaFindReplace = new FindReplace(scintillaControl);
            ScintillaFindReplace.KeyPressed += ScintillaFindReplaceOnKeyPressed;
            this.ShowIcon = false;

            ConfigureScintilla();
            scintillaControl.ScrollWidth = 0;
            scintillaControl.ScrollWidthTracking = true;
            scintillaControl.KeyDown += ScintillaControlOnKeyDown;
        }

        private string FilePath;
        public string FileName => Path.GetFileName(FilePath);
        public void LoadFile(string filePath)
        {
            this.Text = /*"Witcherscript editor - " + */Path.GetFileName(filePath);
            
            FilePath = filePath;
            scintillaControl.Text = File.ReadAllText(FilePath);
        }

        private void ConfigureScintilla()
        {
            //Initialize colors
            scintillaControl.SetSelectionBackColor(true, Color.FromArgb(47, 49, 66));
            SetupSyntaxHighlighting();
            SetupNumberMargins();
            SetupCodeFolding();
            ClearUsedHotKeys();
            scintillaControl.CharAdded += scintilla_CharAdded;
        }

        private void scintilla_CharAdded(object sender, CharAddedEventArgs e)
        {
            // Find the word start
            var currentPos = scintillaControl.CurrentPosition;
            var wordStartPos = scintillaControl.WordStartPosition(currentPos, true);

            // Display the autocompletion list
            var lenEntered = currentPos - wordStartPos;
            if (lenEntered > 0)
            {
                if (!scintillaControl.AutoCActive)
                    scintillaControl.AutoCShow(lenEntered, autocompletelist);
            }

            // notify unsaved
            IsUnsaved = true;
            this.Text = $"{Path.GetFileName(FilePath)}*";
            UIController.Get().Window.AddToOpenScripts(this);
        }


        private void SetupSyntaxHighlighting()
        {
            //Configure syntax highlighting
            scintillaControl.StyleResetDefault();
            scintillaControl.Styles[Style.Default].Font = "Consolas";
            scintillaControl.Styles[Style.Default].Size = 10;
            scintillaControl.Styles[Style.Default].BackColor = Color.FromArgb(68, 71, 90);
            scintillaControl.Styles[Style.Default].ForeColor = Color.White;
            scintillaControl.CaretLineBackColor = Color.FromArgb(47, 49, 66);
            scintillaControl.StyleClearAll();

            //Configure the C++ (Witcher Script) lexer styles
            scintillaControl.Styles[Style.Cpp.Identifier].ForeColor = IntToColor(0xD0DAE2);
            scintillaControl.Styles[Style.Cpp.Comment].ForeColor = IntToColor(0xBD758B);
            scintillaControl.Styles[Style.Cpp.CommentLine].ForeColor = IntToColor(0x40BF57);
            scintillaControl.Styles[Style.Cpp.CommentDoc].ForeColor = IntToColor(0x2FAE35);
            scintillaControl.Styles[Style.Cpp.Number].ForeColor = IntToColor(0xFFFF00);
            scintillaControl.Styles[Style.Cpp.String].ForeColor = IntToColor(0xFFFF00);
            scintillaControl.Styles[Style.Cpp.Character].ForeColor = IntToColor(0xE95454);
            scintillaControl.Styles[Style.Cpp.Preprocessor].ForeColor = IntToColor(0x8AAFEE);
            scintillaControl.Styles[Style.Cpp.Operator].ForeColor = IntToColor(0xDB1212);
            scintillaControl.Styles[Style.Cpp.Regex].ForeColor = IntToColor(0xff00ff);
            scintillaControl.Styles[Style.Cpp.CommentLineDoc].ForeColor = IntToColor(0x77A7DB);
            scintillaControl.Styles[Style.Cpp.Word].ForeColor = IntToColor(0x48A8EE);
            scintillaControl.Styles[Style.Cpp.Word2].ForeColor = IntToColor(0xF98906);
            scintillaControl.Styles[Style.Cpp.CommentDocKeyword].ForeColor = IntToColor(0xB3D991);
            scintillaControl.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = IntToColor(0xFF0000);
            scintillaControl.Styles[Style.Cpp.GlobalClass].ForeColor = IntToColor(0x48A8EE);


            scintillaControl.Lexer = Lexer.Cpp;

            scintillaControl.SetKeywords(0,
                "private protected public default event enum struct editable function super parent statemachine class extends latent");
            scintillaControl.SetKeywords(1, "var this new import hint final timer return break exec");
            scintillaControl.SetKeywords(2,
                "int bool name float string String vector Vector out saved optional void array CEntityTemplate CR4Player W3IgniProjectile W3DamageAction SAbilityAttributeValue CEntity");
            scintillaControl.SetKeywords(3, "true false in");
            scintillaControl.SetKeywords(4, "if else for switch case while do");
        }

        private void SetupNumberMargins()
        {
            //Initialize Number Margins
            scintillaControl.Styles[Style.LineNumber].BackColor = IntToColor(0x2A211C);
            scintillaControl.Styles[Style.LineNumber].ForeColor = IntToColor(0xB7B7B7);
            scintillaControl.Styles[Style.IndentGuide].BackColor = IntToColor(0x2A211C);
            scintillaControl.Styles[Style.IndentGuide].BackColor = IntToColor(0xB7B7B7);

            var numbers = scintillaControl.Margins[1];
            numbers.Width = 30;
            numbers.Type = MarginType.Number;
            numbers.Sensitive = true;
            numbers.Mask = 0;
        }
        private void SetupCodeFolding()
        {
            //Styles code folding
            scintillaControl.SetFoldMarginColor(true, IntToColor(0x2A211C));
            scintillaControl.SetFoldMarginHighlightColor(true, IntToColor(0x2A211C));
            //Enables code folding
            scintillaControl.SetProperty("fold", "1");
            scintillaControl.SetProperty("fold.compact", "1");
            //Configure margin to display folding symbols
            scintillaControl.Margins[3].Type = MarginType.Symbol;
            scintillaControl.Margins[3].Mask = Marker.MaskFolders;
            scintillaControl.Margins[3].Sensitive = true;
            scintillaControl.Margins[3].Width = 20;
            //Set colors for all folding markers
            for (var i = 23; i <= 31; i++)
            {
                scintillaControl.Markers[i].SetForeColor(IntToColor(0x2A211C));
                scintillaControl.Markers[i].SetBackColor(IntToColor(0xB7B7B7));
            }

            //Set folding markers with respective symbols
            scintillaControl.Markers[Marker.Folder].Symbol =
                CodeFoldingCircular ? MarkerSymbol.CirclePlus : MarkerSymbol.BoxPlus;
            scintillaControl.Markers[Marker.FolderOpen].Symbol =
                CodeFoldingCircular ? MarkerSymbol.CircleMinus : MarkerSymbol.BoxMinus;
            scintillaControl.Markers[Marker.FolderEnd].Symbol = CodeFoldingCircular
                ? MarkerSymbol.CirclePlusConnected
                : MarkerSymbol.BoxPlusConnected;
            scintillaControl.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintillaControl.Markers[Marker.FolderOpenMid].Symbol = CodeFoldingCircular
                ? MarkerSymbol.CircleMinusConnected
                : MarkerSymbol.BoxMinusConnected;
            scintillaControl.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintillaControl.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            scintillaControl.AutomaticFold = AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change;
        }
        private void ClearUsedHotKeys()
        {
            //Clear hot keys that conflict with the ones that have just been assigned.
            scintillaControl.ClearCmdKey(Keys.Control | Keys.F);
            scintillaControl.ClearCmdKey(Keys.Control | Keys.H);
            scintillaControl.ClearCmdKey(Keys.Control | Keys.S);
        }

        public void SaveFile()
        {
            // encode in UTF-16LE
            Encoding enc = Encoding.Unicode;

            File.WriteAllText(FilePath, "", enc);

            using (var streamWriter = File.AppendText(FilePath))
            {
                streamWriter.Write(scintillaControl.Text);
            }
            MainController.LogString(FilePath + " saved!", Common.Services.Logtype.Normal);

            // register all new classes
            MockKernel.Get().GetMainViewModel().ScanAndRegisterCustomClasses();

            IsUnsaved = false;
            this.Text = Path.GetFileName(FilePath);
        }

        private Color IntToColor(int rgbValue)
        {
            return Color.FromArgb(255, (byte)(rgbValue >> 16), (byte)(rgbValue >> 8), (byte)rgbValue);
        }

        private void ShowGoToDialog()
        {
            var goToDialog = new GoTo(scintillaControl);
            goToDialog.ShowGoToDialog();
        }

        private void ScintillaControlOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveFile();
                e.SuppressKeyPress = true;
            }
            else if (e.Shift && e.KeyCode == Keys.F3)
            {
                ScintillaFindReplace.Window.FindPrevious();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F3)
            {
                ScintillaFindReplace.Window.FindNext();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.F)
            {
                ScintillaFindReplace.ShowFind();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.H)
            {
                ScintillaFindReplace.ShowReplace();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.I)
            {
                ScintillaFindReplace.ShowIncrementalSearch();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.G)
            {
                ShowGoToDialog();
                e.SuppressKeyPress = true;
            }
            else if(e.Control && e.KeyCode == Keys.Space)
            {
                scintilla_CharAdded(this, new CharAddedEventArgs(0));
            }
        }

        private void ScintillaFindReplaceOnKeyPressed(object sender, KeyEventArgs e)
        {
            ScintillaControlOnKeyDown(sender, e);
        }

        private void frmScriptEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsUnsaved)
            {
                var res = MessageBox.Show($"{FileName} has been modified, save changes?", "Save Changes?",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    SaveFile();
                    UIController.Get().Window.RemoveFromOpenScrips(this);
                }
                else if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    UIController.Get().Window.RemoveFromOpenScrips(this);
                }
            }
            

        }
    }
}
