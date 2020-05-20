using BrightIdeasSoftware;
using ScintillaNET;
using ScintillaNET_FindReplaceDialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App;
using WolvenKit.Common.Services;
using WolvenKit.Radish.Model;
using WolvenKit.Services;

namespace WolvenKit.Forms
{



    public partial class frmRadish : DockContent, IThemedContent
    {
        private readonly List<BatFile> filelist = new List<BatFile>();
        private readonly LoggerService logger;

        private RadishConfig Config { get; set; } 
        private RadishWorkflow CurrentWorkflow { get; set; }
        private readonly DirectoryInfo radishdir;

        private const string settingsnotfoundmsg = "ERROR! _settings_.bat was not found!\r\n" +
            "1. rename _settings_.bat-template from project template to _settings_.bat\r\n" +
            "2. make sure _settings_.bat is in the root folder of the new project\r\n" +
            "3. adjust the paths in the _settings_.bat\r\n" +
            "4. run this script again";

        // Scintilla
        private const bool CodeFoldingCircular = true;
        private readonly FindReplace ScintillaFindReplace;
        public string autocompletelist = "array< PushBack string int integer bool float name range event function abstract const final private protected public theGame theInput thePlayer theSound enum struct state array false NULL true out inlined autobind editable entry exec hint import latent optional out quest saved statemachine timer break case continue else for if return switch while";

        public string FilePath { get; set; }

        public frmRadish()
        {
            InitializeComponent();
            ApplyCustomTheme();

            Config = new RadishConfig();
            logger = UIController.Get().Window.Logger;

            var filedir = new DirectoryInfo(MainController.Get().ActiveMod.FileDirectory);
            radishdir = filedir.GetFiles("*.bat", SearchOption.AllDirectories)?.FirstOrDefault(_ => _.Name == "_settings_.bat")?.Directory;
            if (radishdir == null)
            {
                logger.LogString("ERROR! No radish mod directory found.\r\n", Logtype.Error);
                this.Close();
                return;
            }


            // load bats
            List<string> interactivebats = new List<string>() { "_createLinks_.bat" };
            var batlist = radishdir.GetFiles("*.bat*", SearchOption.AllDirectories)
                .ToList();
            foreach (var path in batlist)
            {
                var bat = new BatFile(path.FullName);
                bat.Interactive = interactivebats.Contains(bat.Name);
                filelist.Add(bat);
            }
            objectListView.SetObjects(filelist);

            // Scintilla
            ScintillaFindReplace = new FindReplace(scintillaControl);
            ScintillaFindReplace.KeyPressed += ScintillaFindReplaceOnKeyPressed;
            ConfigureScintilla();
            scintillaControl.ScrollWidth = 0;
            scintillaControl.ScrollWidthTracking = true;
            scintillaControl.KeyDown += ScintillaControlOnKeyDown;

            RecreateLinks();

            // initialize workflows
            Config = RadishConfig.Load();

            if (!Config.Workflows.Any(_ => _.Name == "All"))
                Config.Workflows.Add(new RadishWorkflow("All")
            {
                Cleanup_folder = true,

                ENCODE_WORLD = true,
                ENCODE_ENVS = true,
                ENCODE_SCENES = true,
                ENCODE_QUEST = true,
                ENCODE_STRINGS = true,
                ENCODE_SPEECH = true,
                ENCODE_HAIRWORKS = true,

                WCC_IMPORT_MODELS = true,
                WCC_IMPORT_TEXTURES = true,
                WCC_COOK = true,
                WCC_NAVDATA = true,
                WCC_TEXTURECACHE = true,
                WCC_COLLISIONCACHE = true,
                WCC_ANALYZE = true,
                WCC_ANALYZE_WORLD = true,

                WCC_REPACK_DLC = true,
                WCC_REPACK_MOD = true,
                DEPLOY_SCRIPTS = true,
                DEPLOY_TMP_SCRIPTS = true,
            });
            if (!Config.Workflows.Any(_ => _.Name == "Rebuild until pack"))
                Config.Workflows.Add(new RadishWorkflow("Rebuild until pack")
            { 
                Cleanup_folder = true,
                //PATCH_MODE = false,

                ENCODE_WORLD = true,
                ENCODE_ENVS = true,
                ENCODE_SCENES = true,
                ENCODE_QUEST = true,
                ENCODE_STRINGS = true,
                ENCODE_SPEECH = true,
                ENCODE_HAIRWORKS = true,

                WCC_IMPORT_MODELS = true,
                WCC_IMPORT_TEXTURES = true,
                //WCC_COOK = false,
                //WCC_NAVDATA = false,
                //WCC_TEXTURECACHE = false,
                //WCC_COLLISIONCACHE = false,
                //WCC_ANALYZE = false,
                //WCC_ANALYZE_WORLD = false,
            });
            if (!Config.Workflows.Any(_ => _.Name == "Pack"))
                Config.Workflows.Add(new RadishWorkflow("Pack")
            {
                WCC_REPACK_DLC = true,
                WCC_REPACK_MOD = true,
                DEPLOY_SCRIPTS = true,
                DEPLOY_TMP_SCRIPTS = true,
            });

            WorkflowobjectListView.SetObjects(Config.Workflows);
            CurrentWorkflow = (RadishWorkflow)WorkflowobjectListView.Objects.Cast<RadishWorkflow>().First();
            PropertyGrid.SelectedObject = CurrentWorkflow;
        }

        #region Scintilla
        private void LoadScintilla(string filePath)
        {
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
            File.WriteAllText(FilePath, "");
            using (var streamWriter = File.AppendText(FilePath))
            {
                streamWriter.Write(scintillaControl.Text);
            }
            UIController.Get().QueueLog(FilePath + " saved!", Common.Services.Logtype.Normal);

            // register all new classes
            UIController.Get().Window.ScanAndRegisterCustomClasses();
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
            else if (e.Control && e.KeyCode == Keys.Space)
            {
                scintilla_CharAdded(this, new CharAddedEventArgs(0));
            }
        }

        private void ScintillaFindReplaceOnKeyPressed(object sender, KeyEventArgs e)
        {
            ScintillaControlOnKeyDown(sender, e);
        }
        #endregion

        #region Methods
        public void ApplyCustomTheme()
        {
            var theme = UIController.Get().GetTheme();
            UIController.Get().ToolStripExtender.SetStyle(toolStrip, VisualStudioToolStripExtender.VsVersion.Vs2015, theme);

            // objectListView
            this.objectListView.BackColor = theme.ColorPalette.ToolWindowTabSelectedInactive.Background;
            this.objectListView.AlternateRowBackColor = theme.ColorPalette.OverflowButtonHovered.Background;
            this.objectListView.ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text;
            HeaderFormatStyle hfs = new HeaderFormatStyle()
            {
                Normal = new HeaderStateStyle()
                {
                    BackColor = theme.ColorPalette.DockTarget.Background,
                    ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text,
                },
                Hot = new HeaderStateStyle()
                {
                    BackColor = theme.ColorPalette.OverflowButtonHovered.Background,
                    ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text,
                },
                Pressed = new HeaderStateStyle()
                {
                    BackColor = theme.ColorPalette.CommandBarToolbarButtonPressed.Background,
                    ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text,
                }
            };
            this.objectListView.HeaderFormatStyle = hfs;
            objectListView.UnfocusedSelectedBackColor = theme.ColorPalette.CommandBarToolbarButtonPressed.Background;

            // WorkflowobjectListView
            this.WorkflowobjectListView.BackColor = theme.ColorPalette.ToolWindowTabSelectedInactive.Background;
            this.WorkflowobjectListView.AlternateRowBackColor = theme.ColorPalette.OverflowButtonHovered.Background;
            this.WorkflowobjectListView.ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text;
            this.WorkflowobjectListView.HeaderFormatStyle = hfs;
            WorkflowobjectListView.UnfocusedSelectedBackColor = theme.ColorPalette.CommandBarToolbarButtonPressed.Background;
        }

        private void UpdateSettings()
        {

        }

        private void TryRunRadishBat(string name)
        {
            try
            {
                RunRadishBat(filelist.First(_ => _.Name == name));
            }
            catch (Exception)
            {
                logger.LogString($"Bat file not found: {name}", Logtype.Error);
            }
        }
        private void RunRadishBat(BatFile bat)
        {
            if (bat == null)
                logger.LogString($"Bat file not found: {bat.Name}", Logtype.Error);

            string path = bat.Path;

            if (bat.Interactive)
            {
                using (Process p = new Process())
                {
                    p.StartInfo.UseShellExecute = true;
                    p.StartInfo.FileName = path;
                    p.StartInfo.WorkingDirectory = Path.GetDirectoryName(path);

                    p.Start();
                }
            }
            else
            {
                using (Process p = new Process())
                {
                    p.StartInfo.RedirectStandardError = true;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.CreateNoWindow = true;

                    p.StartInfo.FileName = path;
                    p.StartInfo.WorkingDirectory = Path.GetDirectoryName(path);

                    p.OutputDataReceived += new DataReceivedEventHandler((s, ev) =>
                    {
                        if (ev.Data != null)
                        {
                            if (ev.Data.StartsWith("WARN"))
                                logger.LogString(ev.Data, Logtype.Important);
                            else if (ev.Data.StartsWith("ERROR"))
                                logger.LogString(ev.Data, Logtype.Error);
                            else if (ev.Data.StartsWith("INFO"))
                                logger.LogString(ev.Data, Logtype.Normal);
                            else
                                logger.LogString(ev.Data);
                        }
                    });
                    p.ErrorDataReceived += new DataReceivedEventHandler((s, ev) =>
                    {
                        logger.LogString(ev.Data, Logtype.Error);
                    });

                    p.Start();
                    p.BeginOutputReadLine();
                    p.BeginErrorReadLine();
                }
            }
        }

        private void RecreateLinks()
        {
            // read settings
            #region read settings
            var settingsbat = filelist.First(_ => _.Name == "_settings_.bat");
            if (settingsbat == null)
            {
                logger.LogString(settingsnotfoundmsg, Logtype.Error);
                return;
            }
            string modkitdir = "";
            string modname = "";
            using (var fs = new FileStream(settingsbat.Path, FileMode.Open, FileAccess.Read))
            using (var sr = new StreamReader(fs, Encoding.Default))
            {
                string line = String.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    // set DIR_MODKIT=E:\MODKIT
                    if (line.StartsWith("set DIR_MODKIT="))
                    {
                        modkitdir = line.Substring("set DIR_MODKIT=".Length);
                    }
                    if (line.StartsWith("set MODNAME="))
                    {
                        modname = line.Substring("set MODNAME=".Length);
                    }
                }
            }
            var modkitInfo = new DirectoryInfo(modkitdir);
            if (!modkitInfo.Exists)
            {
                logger.LogString("ERROR! Modkit was not found! adjust the paths in the _settings_.bat\r\n", Logtype.Error);
                return;
            }
            if (string.IsNullOrEmpty(modname))
            {
                logger.LogString("ERROR! ModName was not found! adjust the name in the _settings_.bat\r\n", Logtype.Error);
                return;
            }
            #endregion

            // write and call temp bat file
            #region create new links
            string tempbatpath = Path.Combine(radishdir.FullName, "wkit_radish_temp.bat");
            WriteLinksBat(tempbatpath);
            RunRadishBat(new BatFile(tempbatpath));
            #endregion

        }

        private void WriteRadishBat(string tempbatpath, RadishWorkflow radishsettings)
        {
            //gather dependencies
            if (!radishsettings.PATCH_MODE)
                SetDependencies(radishsettings);


            if (File.Exists(tempbatpath))
                File.Delete(tempbatpath);

            using (var fs = new FileStream(tempbatpath, FileMode.Create, FileAccess.Write))
            using (var sr = new StreamWriter(fs, Encoding.Default))
            {
                string header =
                        "@echo off\r\n" +
                        "call _settings_.bat\r\n" +
                        "SET INTERACTIVE_BUILD = 0\r\n" +
                        "SET PATCH_MODE = 1\r\n" +
                        "SET FULL_REBUILD = 0\r\n";
                sr.Write(header);

                if (radishsettings.ENCODE_WORLD) sr.WriteLine($"SET ENCODE_WORLD=1");
                if (radishsettings.ENCODE_ENVS) sr.WriteLine($"SET ENCODE_ENVS=1");
                if (radishsettings.ENCODE_SCENES) sr.WriteLine($"SET ENCODE_SCENES=1");
                if (radishsettings.ENCODE_QUEST) sr.WriteLine($"SET ENCODE_QUEST=1");
                if (radishsettings.ENCODE_STRINGS) sr.WriteLine($"SET ENCODE_STRINGS=1");
                if (radishsettings.ENCODE_SPEECH) sr.WriteLine($"SET ENCODE_SPEECH=1");
                if (radishsettings.ENCODE_HAIRWORKS) sr.WriteLine($"SET ENCODE_HAIRWORKS=1");

                if (radishsettings.WCC_IMPORT_MODELS) sr.WriteLine($"SET WCC_IMPORT_MODELS=1");
                if (radishsettings.WCC_IMPORT_TEXTURES) sr.WriteLine($"SET WCC_IMPORT_TEXTURES=1");
                if (radishsettings.WCC_COOK) sr.WriteLine($"SET WCC_COOK=1");
                if (radishsettings.WCC_NAVDATA) sr.WriteLine($"SET WCC_NAVDATA=1");
                if (radishsettings.WCC_TEXTURECACHE) sr.WriteLine($"SET WCC_TEXTURECACHE=1");
                if (radishsettings.WCC_COLLISIONCACHE) sr.WriteLine($"SET WCC_COLLISIONCACHE=1");

                if (radishsettings.WCC_ANALYZE) sr.WriteLine($"SET WCC_ANALYZE=1");
                if (radishsettings.WCC_ANALYZE_WORLD) sr.WriteLine($"SET WCC_ANALYZE_WORLD=1");

                if (radishsettings.WCC_REPACK_DLC) sr.WriteLine($"SET WCC_REPACK_DLC=1");
                if (radishsettings.WCC_REPACK_MOD) sr.WriteLine($"SET WCC_REPACK_MOD=1");

                if (radishsettings.DEPLOY_SCRIPTS) sr.WriteLine($"SET DEPLOY_SCRIPTS=1");
                if (radishsettings.DEPLOY_TMP_SCRIPTS) sr.WriteLine($"SET DEPLOY_TMP_SCRIPTS=1");
                if (radishsettings.START_GAME) sr.WriteLine($"SET START_GAME=1");

                // hack to call pre-cleanup because build.bat makes this dependent on full-rebuild = true
                // and we do it in patch mode
                if (radishsettings.Cleanup_folder)
                {
                    sr.WriteLine("CALL \"%DIR_PROJECT_BIN%\\_cleanup.folder.bat\"");
                    sr.WriteLine("IF %ERRORLEVEL% NEQ 0 GOTO SomeError");
                }

                sr.WriteLine("call \"%DIR_PROJECT_BIN%\\build.bat\"");
            }

            void SetDependencies(RadishWorkflow settings)
            {
                if (settings.ENCODE_HAIRWORKS)
                {
                    var di = new DirectoryInfo(Path.Combine(radishdir.FullName, "definition.hairworks"));
                    if (di.GetFiles("fur.*.apx", SearchOption.AllDirectories).Length > 0)
                    {
                        settings.WCC_COOK = true;
                    }
                }
                if (settings.ENCODE_QUEST)
                {
                    var di = new DirectoryInfo(Path.Combine(radishdir.FullName, "uncooked"));
                    if (di.GetFiles("*.w2quest", SearchOption.AllDirectories).Length > 0)
                    {
                        settings.ENCODE_STRINGS = true;
                        settings.WCC_ANALYZE = true;
                        settings.WCC_COOK = true;
                    }
                }
                if (settings.ENCODE_SCENES)
                {
                    var di = new DirectoryInfo(Path.Combine(radishdir.FullName, "definition.scenes"));
                    if (di.GetFiles("scene.*.yml", SearchOption.AllDirectories).Length > 0)
                    {
                        settings.ENCODE_STRINGS = true;
                        settings.WCC_COOK = true;
                    }
                }
                if (settings.WCC_IMPORT_MODELS)
                {
                    var di = new DirectoryInfo(Path.Combine(radishdir.FullName, "definition.world"));
                    if (di.GetFiles("world.*.yml", SearchOption.AllDirectories).Length > 0)
                    {
                        settings.WCC_NAVDATA = true;
                    }
                    di = new DirectoryInfo(Path.Combine(radishdir.FullName, "models"));
                    if (di.GetFiles("model.*.fbx", SearchOption.AllDirectories).Length > 0)
                    {
                        settings.WCC_ANALYZE = true;
                        settings.WCC_COLLISIONCACHE = true;
                        settings.WCC_COOK = true;
                    }
                }
                if (settings.ENCODE_WORLD)
                {
                    var di = new DirectoryInfo(Path.Combine(radishdir.FullName, "definition.world"));
                    if (di.GetFiles("world.*.yml", SearchOption.AllDirectories).Length > 0)
                    {
                        settings.WCC_ANALYZE = true;
                        settings.WCC_ANALYZE_WORLD = true;
                        settings.WCC_COOK = true;
                        settings.WCC_NAVDATA = true;
                        settings.WCC_TEXTURECACHE = true;
                        settings.WCC_COLLISIONCACHE = true;
                        settings.WCC_COOK = true;
                    }
                }
            }
        }

        private void WriteLinksBat(string tempbatpath)
        {

            if (File.Exists(tempbatpath))
                File.Delete(tempbatpath);

            using (var fs = new FileStream(tempbatpath, FileMode.Create, FileAccess.Write))
            using (var sr = new StreamWriter(fs, Encoding.Default))
            {
                string header =
                        "@echo off\r\n" +
                        "call _settings_.bat\r\n";
                sr.Write(header);

                //delete old links
                sr.WriteLine("rd /s /q \"%DIR_MODKIT_DEPOT%\\dlc\\dlc%MODNAME%\"");
                sr.WriteLine("rd /s /q \"%DIR_MODKIT_DEPOT%\\scripts\\dlc%MODNAME%\"");
                sr.WriteLine("echo old links successfully deleted.");

                // relink
                sr.WriteLine("mklink / J \"%DIR_MODKIT_DEPOT%\\dlc\\dlc%MODNAME%\" \"%DIR_UNCOOKED%\\dlc\\dlc%MODNAME%\"");
                sr.WriteLine("echo.");

                sr.WriteLine("mklink / J \"%DIR_MODKIT_DEPOT%\\scripts\\dlc%MODNAME%\" \"%DIR_MOD_SCRIPTS%\"");
                sr.WriteLine("echo.");
                
                sr.WriteLine("echo links successfully created.");
            }
        }
        #endregion


        private void objectListView_SelectionChanged(object sender, EventArgs e)
        {
            BatFile selectedfile = (BatFile)objectListView.SelectedObject;
            if (selectedfile != null)
                LoadScintilla(selectedfile.Path);
        }



        private void tsb_LaunchQuestEditor_Click(object sender, EventArgs e)
        {
            TryRunRadishBat("launchQuestEditor.bat");
        }

        private void tsb_FullRebuild_Click(object sender, EventArgs e)
        {
            TryRunRadishBat("full.rebuild.bat");
        }

        private void tsb_RunSelected_Click(object sender, EventArgs e)
        {
            //TryRunRadishBat(((BatFile)objectListView.SelectedObject).Name);

            // write and call temp bat file
            var settings = CurrentWorkflow;
            string tempbatpath = Path.Combine(radishdir.FullName, "wkit_radish_temp.bat");
            WriteRadishBat(tempbatpath, settings);
            RunRadishBat(new BatFile(tempbatpath));
        }

        private void tsb_BuildUntilPack_Click(object sender, EventArgs e)
        {
            // write temp bat file
            var settings = Config.Workflows.First(_ => _.Name == "Rebuild until pack");
            string tempbatpath = Path.Combine(radishdir.FullName, "wkit_radish_temp.bat");
            WriteRadishBat(tempbatpath, settings);


            // call temp bat file
            RunRadishBat(new BatFile(tempbatpath));
        }

        private void tsb_Pack_Click(object sender, EventArgs e)
        {
            // write temp bat file
            var settings = Config.Workflows.First(_ => _.Name == "Pack");
            string tempbatpath = Path.Combine(radishdir.FullName, "wkit_radish_temp.bat");
            WriteRadishBat(tempbatpath, settings);


            // call temp bat file
            RunRadishBat(new BatFile(tempbatpath));
        }

        private void tsb_ReCreateLinks_Click(object sender, EventArgs e)
        {
            RecreateLinks();
        }

        private void tsb_StartGame_Click(object sender, EventArgs e)
        {
            // write and call temp bat file
            var settings = new RadishWorkflow("_")
            {
                START_GAME = true
            };
            string tempbatpath = Path.Combine(radishdir.FullName, "wkit_radish_temp.bat");
            WriteRadishBat(tempbatpath, settings);
            RunRadishBat(new BatFile(tempbatpath));
        }

        private void WorkflowobjectListView_SelectionChanged(object sender, EventArgs e)
        {
            var selectedItem = (RadishWorkflow)WorkflowobjectListView.SelectedObject;
            if (selectedItem != null)
            {
                CurrentWorkflow = selectedItem;
                PropertyGrid.SelectedObject = CurrentWorkflow;
            }
        }

        private void AddtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newworkflow = new RadishWorkflow("New Workflow");
            Config.Workflows.Add(newworkflow);
            WorkflowobjectListView.SetObjects(Config.Workflows);

            WorkflowobjectListView.SelectedObject = newworkflow;
            CurrentWorkflow = newworkflow;
            PropertyGrid.SelectedObject = newworkflow;
        }

        private void RemovetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = (RadishWorkflow)WorkflowobjectListView.SelectedObject;
            if (selectedItem != null)
            {
                Config.Workflows.Remove(selectedItem);
                WorkflowobjectListView.SetObjects(Config.Workflows);
            }
        }

        private void frmRadish_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.Save();
        }

        private void WorkflowcontextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            var selectedItem = (RadishWorkflow)WorkflowobjectListView.SelectedObject;
            if (selectedItem != null)
            {
                RemovetoolStripMenuItem.Enabled = !(selectedItem.Name == "All" ||
                    selectedItem.Name == "Rebuild until pack" ||
                    selectedItem.Name == "Pack");
            }  
        }
    }
}
