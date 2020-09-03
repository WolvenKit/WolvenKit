using AutoUpdaterDotNET;
using Dfust.Hotkeys;
using SharpPresence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Wwise.Wwise;
using SearchOption = System.IO.SearchOption;


namespace WolvenKit
{
    using Cache;
    using Common;
    using Common.Services;
    using Common.Wcc;
    using CR2W;
    using CR2W.Types;
    using Extensions;
    using Forms;
    using System.IO.MemoryMappedFiles;
    using System.Web.UI.Design;
    using WolvenKit.App;
    using WolvenKit.App.ViewModels;
    using WolvenKit.Bundles;
    using WolvenKit.Common.Extensions;
    using WolvenKit.Common.Model;
    using WolvenKit.Forms.MVVM;
    using WolvenKit.Render;
    using WolvenKit.Scaleform;
    using Wwise.Player;
    using Enums = Dfust.Hotkeys.Enums;

    public partial class frmMain : Form
    {
        private readonly MainViewModel vm;

        #region Fields

        #region Forms
        //private List<IWolvenkitDocument> OpenDocuments { get; set; } = new List<IWolvenkitDocument>();
        private frmModExplorer ModExplorer { get; set; }
        private frmStringsGui stringsGui { get; set; }
        private frmOutput Output { get; set; }
        private frmConsole Console { get; set; }
        private frmWelcome Welcome { get; set; }

        private frmImportUtility ImportUtility { get; set; }
        private frmRadish RadishUtility { get; set; }
        private frmProgress m_frmProgress { get; set; }
        private frmWcc FormModKit { get; set; }


        private frmScriptEditor ScriptPreview { get; set; }
        private List<frmScriptEditor> OpenScripts { get; set; } = new List<frmScriptEditor>();
        private frmImagePreview ImagePreview { get; set; }
        private List<frmImagePreview> OpenImages { get; set; } = new List<frmImagePreview>();

        #endregion

        private readonly string BaseTitle = "Wolven kit";
        public static Task Packer;
        private HotkeyCollection hotkeys;
        private readonly ToolStripRenderer toolStripRenderer = new ToolStripProfessionalRenderer();


        private WccLite WccHelper;

        private delegate void strDelegate(string t);
        private delegate void logDelegate(string t, Logtype type);

        private Queue<string> _lastClosedTab = new Queue<string>();
        private DeserializeDockContent m_deserializeDockContent;
        #endregion

        #region Properties

        public EventHandler errored;

        public LoggerService Logger { get; set; }

        private IWolvenkitDocument _activedocument;
        public IWolvenkitDocument ActiveDocument
        {
            get => _activedocument;
            set
            {
                _activedocument = value;
                UpdateTitle();
            }
        }
        public W3Mod ActiveMod
        {
            get => MainController.Get().ActiveMod;
            set
            {
                MainController.Get().ActiveMod = value;
                UpdateTitle();
            }
        }
        public string Version => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
        #endregion

        #region Constructor
        public frmMain()
        {
            vm = MockKernel.Get().GetMainViewModel();
            vm.PropertyChanged += ViewModel_PropertyChanged;

            InitializeComponent();


            this.dockPanel.Theme.Extender.FloatWindowFactory = new CustomFloatWindowFactory();
            visualStudioToolStripExtender1.DefaultRenderer = toolStripRenderer;
            UIController.Get().ToolStripExtender = visualStudioToolStripExtender1;
            ApplyCustomTheme();

            UpdateTitle();
            MainController.Get().PropertyChanged += MainControllerUpdated;

            #region Load recent files into toolstrip
            recentFilesToolStripMenuItem.DropDownItems.Clear();
            if (File.Exists("recent_files.xml"))
            {
                var doc = XDocument.Load("recent_files.xml");
                recentFilesToolStripMenuItem.Enabled = doc.Descendants("recentfile").Any();
                foreach (var f in doc.Descendants("recentfile"))
                {
                    recentFilesToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem(f.Value, null, RecentFile_click));
                }
            }
            else
            {
                recentFilesToolStripMenuItem.Enabled = false;
            }
            #endregion
            hotkeys = new HotkeyCollection(Enums.Scope.Application);
            hotkeys.RegisterHotkey(Keys.Control | Keys.S, HKSave, "Save");
            hotkeys.RegisterHotkey(Keys.Control | Keys.Shift | Keys.S, HKSaveAll, "SaveAll");
            hotkeys.RegisterHotkey(Keys.F1, HKHelp, "Help");
            hotkeys.RegisterHotkey(Keys.Control | Keys.C, HKCopy, "Copy");
            hotkeys.RegisterHotkey(Keys.Control | Keys.V, HKPaste, "Paste");

            hotkeys.RegisterHotkey(Keys.F5, HKRun, "Run");
            hotkeys.RegisterHotkey(Keys.Control | Keys.F5, HKRunAndLaunch, "RunAndLaunch");
            hotkeys.RegisterHotkey(Keys.Control | Keys.W, HKCloseTab, "CloseTab");
            hotkeys.RegisterHotkey(Keys.Control | Keys.Shift | Keys.T, HKReopenTab, "ReopenTab");

            UIController.InitForm(this);

            MainBackgroundWorker.WorkerReportsProgress = true;
            MainBackgroundWorker.WorkerSupportsCancellation = true;
            MainBackgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            MainBackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            MainBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);

            ToolStripManager.LoadSettings(this);
            m_deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);
            this.FormBorderStyle = FormBorderStyle.None;
        }

        #endregion

        #region UI Methods
        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(frmModExplorer).ToString())
                return GetModExplorer();
            else if (persistString == typeof(frmConsole).ToString())
                return GetConsole();
            else if (persistString == typeof(frmOutput).ToString())
                return GetOutput();
            else if (persistString == typeof(frmWelcome).ToString())
                return GetWelcome();
            if (persistString == typeof(frmImportUtility).ToString())
                return GetImportUtility();
            //else
            //{
            //    // DummyDoc overrides GetPersistString to add extra information into persistString.
            //    // Any DockContent may override this value to add any needed information for deserialization.

            //    string[] parsedStrings = persistString.Split(new char[] { ',' });
            //    if (parsedStrings.Length != 3)
            //        return null;

            //    if (parsedStrings[0] != typeof(DummyDoc).ToString())
            //        return null;

            //    DummyDoc dummyDoc = new DummyDoc();
            //    if (parsedStrings[1] != string.Empty)
            //        dummyDoc.FileName = parsedStrings[1];
            //    if (parsedStrings[2] != string.Empty)
            //        dummyDoc.Text = parsedStrings[2];

            //    return dummyDoc;
            //}
            else
                return null;
        }

        public void GlobalApplyTheme()
        {
            dockPanel.SaveAsXml(Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "main_layout.xml"));

            if (vm.OpenDocuments.Count == 0)
            {
                ApplyThemes();
            }
            else
            {
                switch (MessageBox.Show(
                        "This will close all windows. You will loose any unsaved progress in open files. " +
                        "Would you like to continue without saving?",
                        "Apply Theme",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    default:
                        return;
                    case DialogResult.Yes:
                        {
                            ApplyThemes();
                            break;
                        }
                    case DialogResult.No:
                        {
                            return;
                        }
                }
            }
            

            void ApplyThemes()
            {
                CloseWindows();

                this.ApplyCustomTheme();

                dockPanel.LoadFromXml(Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "main_layout.xml"), m_deserializeDockContent);

                ReopenWindows();
            }

        }
        private void ApplyCustomTheme()
        {
            var theme = UIController.GetTheme();
            this.dockPanel.Theme = theme;
            visualStudioToolStripExtender1.SetStyle(menuStrip1, VisualStudioToolStripExtender.VsVersion.Vs2015, theme);
            visualStudioToolStripExtender1.SetStyle(toolbarToolStrip, VisualStudioToolStripExtender.VsVersion.Vs2015, theme);
        }

        #region UI formborderstyle none

        private const long WS_SYSMENU = 0x00080000L;
        private const long WS_BORDER = 0x00800000L;
        private const long WS_SIZEBOX = 0x00040000L;
        private const long WS_CHILD = 0x40000000L;
        private const long WS_DLGFRAME = 0x00400000L;
        private const long WS_MAXIMIZEBOX = 0x00010000L;
        private const long WS_CAPTION = 0x00C00000L;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32")]
        internal static extern bool GetMonitorInfo(IntPtr hMonitor, MONITORINFO lpmi);

        [System.Runtime.InteropServices.DllImport("user32")]
        internal static extern IntPtr MonitorFromWindow(IntPtr handle, int flags);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                {
                    cp.Style |= (int)WS_BORDER;
                    cp.Style |= (int)WS_SYSMENU;
                    cp.Style |= (int)WS_SIZEBOX;
                }
                return cp;
            }
        }
        private void MinimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void RestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Screen screen = Screen.FromControl(this);
            //int x = screen.WorkingArea.X - screen.Bounds.X;
            //int y = screen.WorkingArea.Y - screen.Bounds.Y;
            //this.MaximizedBounds = new Rectangle(x, y,
            //    screen.WorkingArea.Width, screen.WorkingArea.Height);

            if (this.WindowState != FormWindowState.Maximized)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // https://stackoverflow.com/a/42806834
        protected override void WndProc(ref Message m)
        {
            Boolean handled = false;

            switch (m.Msg)
            {
                case 0x0024:
                    WmGetMinMaxInfo(m.HWnd, m.LParam);

                    handled = true;
                    break;
            }
            m.Result = IntPtr.Zero;
            if (handled) DefWndProc(ref m); else base.WndProc(ref m);
        }

        private const int WINDOW_BORDER_BUFFER = 10;
        private static void WmGetMinMaxInfo(IntPtr hwnd, IntPtr lParam)
        {
            MINMAXINFO mmi = (MINMAXINFO)Marshal.PtrToStructure(lParam, typeof(MINMAXINFO));
            int MONITOR_DEFAULTTONEAREST = 0x00000002;
            IntPtr monitor = MonitorFromWindow(hwnd, MONITOR_DEFAULTTONEAREST);
            if (monitor != IntPtr.Zero)
            {
                MONITORINFO monitorInfo = new MONITORINFO();
                GetMonitorInfo(monitor, monitorInfo);
                RECT rcWorkArea = monitorInfo.rcWork;
                RECT rcMonitorArea = monitorInfo.rcMonitor;
                mmi.ptMaxPosition.x = Math.Abs(rcWorkArea.left - rcMonitorArea.left) - WINDOW_BORDER_BUFFER;
                mmi.ptMaxPosition.y = Math.Abs(rcWorkArea.top - rcMonitorArea.top) - WINDOW_BORDER_BUFFER;
                mmi.ptMaxSize.x = Math.Abs(rcWorkArea.right - rcWorkArea.left) + (2 * WINDOW_BORDER_BUFFER);
                mmi.ptMaxSize.y = Math.Abs(rcWorkArea.bottom - rcWorkArea.top) + (2 * WINDOW_BORDER_BUFFER);
            }
            Marshal.StructureToPtr(mmi, lParam, true);
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            /// <summary>x coordinate of point.</summary>
            public int x;
            /// <summary>y coordinate of point.</summary>
            public int y;
            /// <summary>Construct a point of coordinates (x,y).</summary>
            public POINT(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MINMAXINFO
        {
            public POINT ptReserved;
            public POINT ptMaxSize;
            public POINT ptMaxPosition;
            public POINT ptMinTrackSize;
            public POINT ptMaxTrackSize;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public class MONITORINFO
        {
            public int cbSize = Marshal.SizeOf(typeof(MONITORINFO));
            public RECT rcMonitor = new RECT();
            public RECT rcWork = new RECT();
            public int dwFlags = 0;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 0)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
            public static readonly RECT Empty = new RECT();
            public int Width { get { return Math.Abs(right - left); } }
            public int Height { get { return bottom - top; } }
            public RECT(int left, int top, int right, int bottom)
            {
                this.left = left;
                this.top = top;
                this.right = right;
                this.bottom = bottom;
            }
            public RECT(RECT rcSrc)
            {
                left = rcSrc.left;
                top = rcSrc.top;
                right = rcSrc.right;
                bottom = rcSrc.bottom;
            }
            public bool IsEmpty { get { return left >= right || top >= bottom; } }
            public override string ToString()
            {
                if (this == Empty) { return "RECT {Empty}"; }
                return "RECT { left : " + left + " / top : " + top + " / right : " + right + " / bottom : " + bottom + " }";
            }
            public override bool Equals(object obj)
            {
                if (!(obj is System.Windows.Rect)) { return false; }
                return (this == (RECT)obj);
            }
            /// <summary>Return the HashCode for this struct (not garanteed to be unique)</summary>
            public override int GetHashCode() => left.GetHashCode() + top.GetHashCode() + right.GetHashCode() + bottom.GetHashCode();
            /// <summary> Determine if 2 RECT are equal (deep compare)</summary>
            public static bool operator ==(RECT rect1, RECT rect2) { return (rect1.left == rect2.left && rect1.top == rect2.top && rect1.right == rect2.right && rect1.bottom == rect2.bottom); }
            /// <summary> Determine if 2 RECT are different(deep compare)</summary>
            public static bool operator !=(RECT rect1, RECT rect2) { return !(rect1 == rect2); }
        }


        #endregion
        #endregion

        #region BackGroundWorker
        Func<object, DoWorkEventArgs, object> workerAction;
        Func<object, object> workerCompletedAction;
        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bwAsync = sender as BackgroundWorker;
            e.Result = workerAction(sender, e);

            // add a result
            //e.Result
        }
        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            m_frmProgress?.SetProgressBarValue(e.ProgressPercentage, e.UserState);
        }
        IWolvenkitDocument HACK_bwform = null;
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // has errors
            if (e.Error != null)
            {
                // do not continue to the completed action
            }
            else // has completed successfully
            {
                if (workerCompletedAction != null)
                {
                    HACK_bwform = (IWolvenkitDocument)workerCompletedAction(e.Result);
                }
                workerCompletedAction = null;
            }

            m_frmProgress.Close();
        }

        /// <summary>
        /// Setup the backgroundworker and progress forms (Main thread)
        /// </summary>
        /// <param name="args"></param>
        private void WorkerLoadFileSetup(LoadFileArgs args)
        {
            MainController.Get().ProjectStatus = "Busy";

            // Backgroundworker
            if (!MainBackgroundWorker.IsBusy)
            {

                m_frmProgress = new frmProgress()
                {
                    Text = "Loading File...",
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.None
                };

                workerAction = WorkerLoadFile;
                MainBackgroundWorker.RunWorkerAsync(args);
                DialogResult dr = m_frmProgress.ShowDialog(this);


            }
            else
                Logger.LogString("The background worker is currently busy.\r\n", Logtype.Error);

            MainController.Get().ProjectStatus = "Ready";
        }

        /// <summary>
        /// This runs on a worker thread in the background and 
        /// returns the LoadFileArgs it reveived if succesfull, null otherwise.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        protected private object WorkerLoadFile(object sender, DoWorkEventArgs e)
        {
            object arg = e.Argument;
            if (!(arg is LoadFileArgs))
                throw new NotImplementedException();
            var Args = (LoadFileArgs)arg;

            var doc = Args.ViewModel;
            var filename = Args.Filename;
            var suppressErrors = Args.SuppressErrors;

            try
            {
                if (Args.Stream != null)
                    doc.LoadFile(filename, Args.Stream, UIController.Get());
                else
                    doc.LoadFile(filename, UIController.Get());
            }
            catch (InvalidFileTypeException ex)
            {
                if (!suppressErrors)
                    MessageBox.Show(this, ex.Message, @"Error opening file.");

                vm.OpenDocuments.Remove(doc);
                //doc.Dispose();
                return null;
            }
            catch (MissingTypeException ex)
            {
                if (!suppressErrors)
                    MessageBox.Show(this, ex.Message, @"Error opening file.");

                vm.OpenDocuments.Remove(doc);
                //doc.Dispose();
                return null;
            }
            catch (FormatException ex)
            {
                if (!suppressErrors)
                    MessageBox.Show(this, ex.Message, @"Error opening file.");

                vm.OpenDocuments.Remove(doc);
                //doc.Dispose();
                throw ex;
                return null;
            }

            workerCompletedAction = WorkerLoadFileCompleted;
            return Args;
        }

        /// <summary>
        /// This is called if the backgroundworker has completed sucessfully. 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        protected private object WorkerLoadFileCompleted(object arg)
        {
            if (!(arg is LoadFileArgs))
                throw new NotImplementedException();
            var Args = (LoadFileArgs)arg;

            // switch between cr2w files and non-cr2w files (e.g. srt)
            var filename = Args.Filename;

            //switch extension
            if (Path.GetExtension(filename) == ".srt")
            {
                var doc = new frmOtherDocument(Args.ViewModel);



                doc.Activated += doc_Activated;
                doc.Show(dockPanel, DockState.Document);
                doc.FormClosed += doc_FormClosed;

                return doc;
            }
            else
            {
                //var doc = Args.Doc;
                frmCR2WDocument doc = new frmCR2WDocument(Args.ViewModel);


                #region SetupFile
                // Backgroundwork Start
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                switch (Path.GetExtension(filename))
                {
                    case ".w2scene":
                    case ".w2quest":
                    case ".w2phase":
                        {
                            doc.flowDiagram = new frmChunkFlowDiagram();
                            doc.flowDiagram.OnOutput += OnOutput;
                            doc.flowDiagram.File = doc.File;
                            doc.flowDiagram.DockAreas = DockAreas.Document;
                            doc.flowDiagram.OnSelectChunk += doc.frmCR2WDocument_OnSelectChunk;
                            doc.flowDiagram.Show(doc.FormPanel, DockState.Document);
                            break;
                        }

                    case ".journal":
                        {
                            doc.JournalEditor = new frmJournalEditor
                            {
                                File = doc.File,
                                DockAreas = DockAreas.Document
                            };
                            doc.JournalEditor.Show(doc.FormPanel, DockState.Document);
                            break;
                        }
                    case ".xbm":
                        {
                            doc.ImageViewer = new frmImagePreview
                            {
                                DockAreas = DockAreas.Document
                            };
                            doc.ImageViewer.Show(doc.FormPanel, DockState.Document);
                            CR2WExportWrapper imagechunk = doc.File?.chunks?.FirstOrDefault(_ => _.data.REDType.Contains("CBitmapTexture"));
                            doc.ImageViewer.SetImage(imagechunk);
                            break;
                        }
                    case ".redswf":
                        {
                            doc.ImageViewer = new frmImagePreview
                            {
                                DockAreas = DockAreas.Document
                            };
                            doc.ImageViewer.Show(doc.FormPanel, DockState.Document);
                            CR2WExportWrapper imagechunk = doc.File?.chunks?.FirstOrDefault(_ => _.data is CBitmapTexture);
                            doc.ImageViewer.SetImage(imagechunk);
                            break;
                        }
                    case ".w2mesh":
                        {
                            if (bool.Parse(renderW2meshToolStripMenuItem.Tag.ToString()))
                            {
                                try
                                {
                                    // add all dependencies
                                    vm.AddAllImportsToProject(filename);

                                    doc.RenderViewer = new Render.frmRender
                                    {
                                        LoadDocument = LoadDocumentAndGetFile,
                                        MeshFile = doc.File,
                                        DockAreas = DockAreas.Document,
                                        renderHelper = new Render.RenderHelper(MainController.Get().ActiveMod, MainController.Get().Logger)
                                    };
                                    doc.RenderViewer.Show(doc.FormPanel, DockState.Document);
                                }
                                catch (Exception ex)
                                {
                                    AddOutput(ex.ToString());
                                }
                            }
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                if (doc.File.embedded.Count > 0)
                {
                    doc.embeddedFiles = new frmEmbeddedFiles
                    {
                        File = doc.File,
                        DockAreas = DockAreas.Document
                    };
                    doc.embeddedFiles.Show(doc.FormPanel, DockState.Document);
                }
                doc.Activated += doc_Activated;
                doc.Show(dockPanel, DockState.Document);
                doc.FormClosed += doc_FormClosed;

                var output = new StringBuilder();

                if (doc.File.UnknownTypes.Any())
                {
                    ShowConsole();
                    ShowOutput();

                    output.Append(doc.FileName + ": contains " + doc.File.UnknownTypes.Count + " unknown type(s):\n");
                    foreach (var unk in doc.File.UnknownTypes)
                    {
                        output.Append("\"" + unk + "\", \n");
                    }

                    output.Append("-------\n\n");
                }

                var hasUnknownBytes = false;

                foreach (var t in doc.File.chunks.Where(t => t.unknownBytes?.Bytes != null && t.unknownBytes.Bytes.Length > 0))
                {
                    output.Append(t.REDName + " contains " + t.unknownBytes.Bytes.Length + " unknown bytes. \n");
                    hasUnknownBytes = true;
                }

                if (hasUnknownBytes)
                    output.Append("-------\n\n");

                output.Append($"File {filename} loaded in: {stopwatch.Elapsed}\n\n");
                stopwatch.Stop();

                AddOutput(output.ToString(), Logtype.Important);
                return doc;
                #endregion
            }

            CR2WFile LoadDocumentAndGetFile(string path)
            {
                foreach (var t in vm.OpenDocuments.Where(_ => _.File is CR2WFile).Where(t => t.FileName == path))
                    return t.File as CR2WFile;

                //var activedoc = vm.OpenDocuments.FirstOrDefault(d => d.IsActivated);
                var doc2 = LoadDocument(path) as frmCR2WDocument;
                //activedoc.Activate();
                return doc2?.File;
            }
        }
        #endregion

        #region HotKeys
        private void HKRun(HotKeyEventArgs e)
        {
            var pack = PackAndInstallMod();
            while (!pack.IsCompleted)
                Application.DoEvents();
        }
        private void HKRunAndLaunch(HotKeyEventArgs e)
        {
            var pack = PackAndInstallMod();
            while (!pack.IsCompleted)
                Application.DoEvents();

            if (!pack.Result)
                return;
            vm.executeGame();
        }
        private void HKCloseTab(HotKeyEventArgs e)
        {
            if (ActiveDocument != null)
            {
                _lastClosedTab.Enqueue(ActiveDocument.FileName);
                ActiveDocument.Close();
            }
        }
        private void HKReopenTab(HotKeyEventArgs e)
        {
            if (_lastClosedTab.Count > 0)
            {
                string filetoopen = _lastClosedTab.Dequeue();
                if (!string.IsNullOrEmpty(filetoopen))
                    LoadDocument(filetoopen);
            }
        }
        private void HKSave(HotKeyEventArgs e)
        {
            if (ActiveDocument != null)
                vm.SaveFile(ActiveDocument.GetViewModel());
        }
        private void HKSaveAll(HotKeyEventArgs e)
        {
            if (vm.OpenDocuments != null && vm.OpenDocuments.Count > 0)
                vm.SaveAllFiles();
        }
        private void HKHelp(HotKeyEventArgs e)
        {
            Process.Start("https://github.com/Traderain/Wolven-kit/wiki");
        }
        private void HKCopy(HotKeyEventArgs e)
        {
            if (ActiveDocument != null)
            {
                if (ActiveDocument is frmCR2WDocument cr2wdoc)
                {
                    if (cr2wdoc.chunkList.IsActivated)
                    {
                        cr2wdoc.chunkList.CopyChunks();
                        Logger.LogString("Selected chunk(s) copied!\n");
                    }
                    else if (cr2wdoc.propertyWindow.IsActivated)
                    {
                        cr2wdoc.propertyWindow.CopyVariable();
                        Logger.LogString("Selected propertie(s) copied!\n");
                    }
                }
            }
        }
        private void HKPaste(HotKeyEventArgs e)
        {
            if (ActiveDocument != null)
            {
                if (ActiveDocument is frmCR2WDocument cr2wdoc)
                {
                    if (cr2wdoc.chunkList.IsActivated)
                    {
                        cr2wdoc.chunkList.PasteChunks();
                        Logger.LogString("Copied chunk(s) pasted!\n");
                    }
                    else if (cr2wdoc.propertyWindow.IsActivated)
                    {
                        cr2wdoc.propertyWindow.PasteVariable();
                        Logger.LogString("Copied propertie(s) pasted!\n");
                    }
                }
            }
        }
        #endregion

        #region Events
        private void Welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Welcome = null;
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

        }

        /// <summary>
        /// Deprecated. Use MainController.QueueLog 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoggerUpdated(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Log")
            {
                Invoke(new logDelegate(AddOutput), ((LoggerService)sender).Log + "\n", ((LoggerService)sender).Logtype);
            }
            if (e.PropertyName == "Progress")
            {
                if (MainBackgroundWorker != null)
                {
                    if (string.IsNullOrEmpty(Logger.Progress.Item2))
                        MainBackgroundWorker.ReportProgress((int)Logger.Progress.Item1);
                    else
                        MainBackgroundWorker.ReportProgress((int)Logger.Progress.Item1, Logger.Progress.Item2);
                }
            }
        }

        /// <summary>
        /// Occurs when something in the maincontroller is updated that is INotifyProeprtyChanged
        /// Thread safe and always should be
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainControllerUpdated(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ProjectStatus")
                Invoke(new strDelegate(SetStatusLabelText), ((MainController)sender).ProjectStatus);
            if (e.PropertyName == "LogMessage")
                Invoke(new logDelegate(AddOutput), ((MainController)sender).LogMessage.Key + "\n",
                    ((MainController)sender).LogMessage.Value);

            void SetStatusLabelText(string text)
            {
                statusLBL.Text = text;
            }
        }

        public void Assetbrowser_FileAdd(object sender, AddFileArgs Details)
        {

            if (Process.GetProcessesByName("Witcher3").Length != 0)
            {
                MessageBox.Show(@"Please close The Witcher 3 before tinkering with the files!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MainController.Get().ProjectStatus = "Busy";

            // Backgroundworker
            if (!MainBackgroundWorker.IsBusy)
            {
                ModExplorer.PauseMonitoring();

                // progress bar
                m_frmProgress = new frmProgress()
                {
                    Text = "Adding Assets",
                    StartPosition = FormStartPosition.CenterParent,
                };

                // background worker action
                workerAction = WorkerAssetBrowserAddFiles;
                MainBackgroundWorker.RunWorkerAsync(Details);

                // cancellation dialog
                DialogResult dr = m_frmProgress.ShowDialog(this);
                switch (dr)
                {
                    case DialogResult.Cancel:
                        {
                            MainBackgroundWorker.CancelAsync();
                            m_frmProgress.Cancel = true;
                            break;
                        }
                    case DialogResult.None:
                    case DialogResult.OK:
                    case DialogResult.Abort:
                    case DialogResult.Retry:
                    case DialogResult.Ignore:
                    case DialogResult.Yes:
                    case DialogResult.No:
                    default:
                        break;
                }
                ModExplorer.ResumeMonitoring();
                vm.SaveMod();
                this.BringToFront();
            }
            else
                Logger.LogString("The background worker is currently busy.\r\n", Logtype.Error);

            MainController.Get().ProjectStatus = "Ready";

        }

        protected object WorkerAssetBrowserAddFiles(object sender, DoWorkEventArgs e)
        {
            object arg = e.Argument;
            if (!(arg is AddFileArgs))
                throw new NotImplementedException();
            var Details = (AddFileArgs)arg;
            BackgroundWorker bwAsync = sender as BackgroundWorker;

            // setup working dir
            if (Directory.Exists(Path.GetFullPath(MainController.WorkDir)))
                Directory.Delete(Path.GetFullPath(MainController.WorkDir), true);
            Directory.CreateDirectory(Path.GetFullPath(MainController.WorkDir));

            var skipping = false;
            var count = Details.SelectedPaths.Count;
            for (int i = 0; i < count; i++)
            {
                if (bwAsync.CancellationPending || m_frmProgress.Cancel)
                {
                    Logger.LogString("Background worker cancelled.\r\n", Logtype.Error);
                    e.Cancel = true;
                    return false;
                }

                WitcherListViewItem item = Details.SelectedPaths[i];
                IWitcherArchiveManager manager = Details.Managers.First(_ => _.TypeName == item.BundleType);

                skipping = AddToMod(item.RelativePath, manager, skipping, Details.AddAsDLC, Details.Uncook, Details.Export);

                int percentprogress = (int)((float)i / (float)count * 100.0);
                MainBackgroundWorker.ReportProgress(percentprogress, item.Text);
            }
            return true;
        }


        private void ModExplorer_RequestFileRename(object sender, RequestFileArgs e)
        {
            var filename = e.File;

            if (!File.Exists(filename))
                return;

            var dlg = new frmRenameDialog() { FileName = filename };
            if (dlg.ShowDialog() == DialogResult.OK && dlg.FileName != filename)
            {
                var newfullpath = Path.Combine(ActiveMod.FileDirectory, dlg.FileName);

                if (File.Exists(newfullpath))
                    return;

                // Rename file in file structure
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(newfullpath));
                }
                catch
                {
                }

                File.Move(filename, newfullpath);
            }
            MainController.Get().ProjectStatus = "File renamed";
        }

        private void ModExplorer_RequestFastRender(object sender, RequestFileArgs e)
        {
            Render.FastRender.frmFastRender ren = new Render.FastRender.frmFastRender(e.File, Logger, ActiveMod);
            ren.Show(this.dockPanel, DockState.Document);
        }

        private void ModExplorer_RequestAssetBrowser(object sender, RequestFileArgs e) => OpenAssetBrowser(false, e.File);

        private void ModExplorer_RequestFileOpen(object sender, RequestFileArgs e)
        {
            var fullpath = e.File;

            var ext = Path.GetExtension(fullpath).ToUpper();

            // click
            if (e.Inspect)
            {
                switch (ext)
                {
                    case ".CSV":
                    case ".XML":
                    case ".TXT":
                    case ".BAT":
                    case ".WS":
                    case ".YML":
                    case ".LOG":
                    case ".INI":
                        {
                            if (OpenScripts.Any(_ => _.FileName == Path.GetFileName(fullpath)))
                            {
                                OpenScripts.First(_ => _.FileName == Path.GetFileName(fullpath)).Activate();
                            }
                            else
                            {
                                ShowScriptPreview();
                                ScriptPreview.LoadFile(fullpath);
                            }
                            break;
                        }
                    case ".PNG":
                    case ".JPG":
                    case ".TGA":
                    case ".BMP":
                    case ".JPEG":
                    case ".DDS":
                        {
                            if (OpenImages.Any(_ => _.Text == Path.GetFileName(fullpath)))
                            {
                                OpenImages.First(_ => _.Text == Path.GetFileName(fullpath)).Activate();
                            }
                            else
                            {
                                ShowImagePreview();
                                ImagePreview.SetImage(fullpath);
                            }
                            break;
                            //if (OpenImages.Any(_ => _.Text == Path.GetFileName(fullpath)))
                            //{
                            //    OpenImages.First(_ => _.Text == Path.GetFileName(fullpath)).Activate();
                            //}
                            //else
                            //{
                            //    if (ImagePreview.Text == Path.GetFileName(fullpath))
                            //    {
                            //        ImagePreview.Close();
                            //    }
                            //    var dockedImage = new frmImagePreview();
                            //    dockedImage.Show(dockPanel, DockState.Document);
                            //    dockedImage.SetImage(fullpath);
                            //    OpenImages.Add(dockedImage);
                            //}
                            //break;
                        }
                    default:
                        break;
                }
                return;
            }

            // double click
            switch (ext)
            {
                // images
                case ".PNG":
                case ".JPG":
                case ".TGA":
                case ".BMP":
                case ".JPEG":
                case ".DDS":
                //text
                case ".CSV":
                case ".XML":
                case ".TXT":
                case ".WS":
                // other
                case ".FBX":
                case ".APB":
                case ".BAT":
                case ".YML":
                case ".LOG":
                case ".INI":
                    ShellExecute(fullpath);
                    break;

                case ".WEM":
                    {
                        using (var sp = new frmAudioPlayer(fullpath))
                        {
                            sp.ShowDialog();
                        }
                        break;
                    }
                case ".SUBS":
                    PolymorphExecute(fullpath, ".txt");
                    break;
                case ".USM":
                    LoadUsmFile(fullpath);
                    break;
                case ".BNK":
                    {
                        using (var sp = new frmAudioPlayer(fullpath))
                        {
                            sp.ShowDialog();
                        }
                        break;
                    }
                default:
                    LoadDocument(fullpath);
                    break;
            }

            void ShellExecute(string path)
            {
                var proc = new ProcessStartInfo(path) { UseShellExecute = true };
                Process.Start(proc);
            }

            void PolymorphExecute(string path, string extension)
            {
                File.WriteAllBytes(Path.GetTempPath() + "asd." + extension, new byte[] { 0x01 });
                var programname = new StringBuilder();
                NativeMethods.FindExecutable("asd." + extension, Path.GetTempPath(), programname);
                if (programname.ToString().ToUpper().Contains(".EXE"))
                {
                    Process.Start(programname.ToString(), path);
                }
                else
                {
                    throw new InvalidFileTypeException("Invalid file type");
                }
            }

            void LoadUsmFile(string path)
            {
                if (!File.Exists(path) || Path.GetExtension(path) != ".usm")
                    return;
                var usmplayer = new frmUsmPlayer(path);
                usmplayer.Show(dockPanel, DockState.Document);

            }
        }
        #endregion

        #region Methods

        private void UpdateTitle()
        {
            wkitVersionToolStripLabel.Text = $"v{Version}: {Assembly.GetExecutingAssembly().GetLinkerTime().ToString("yyyy MMMM dd")}";

            modNameToolStripLabel.Text = ActiveMod != null ? ActiveMod.Name : "No Mod Loaded!";

            Text = BaseTitle;
            if (ActiveMod != null)
            {
                Text += " [" + ActiveMod.Name + "] ";
            }

            if (ActiveDocument != null)
            {
                Text += Path.GetFileName(ActiveDocument.FileName);
            }
        }

        private void ClearOutput()
        {
            if (Output != null && !Output.IsDisposed)
            {
                Output.Clear();
            }
            MainController.Get().ProjectStatus = "Output cleared";
        }

        private void AddOutput(string text, Logtype type = Logtype.Normal)
        {
            if (Output != null && !Output.IsDisposed)
            {
                if (string.IsNullOrWhiteSpace(text))
                    return;

                Output.AddText(text, type);
            }
        }

        private void OnOutput(object sender, string output) => AddOutput(output);

        private void saveActiveFile()
        {
            if (ActiveMod == null)
            {
                return;
            }
            if (ActiveDocument != null && !ActiveDocument.GetIsDisposed())
            {
                vm.SaveFile(ActiveDocument.GetViewModel());
                Logger.LogString("Saved!\n", Logtype.Success);
            }

        }

        public void AddToOpenScripts(frmScriptEditor frmScriptEditor)
        {
            if (!OpenScripts.Any(_ => _.Text == frmScriptEditor.Text))
            {
                frmScriptEditor.Show(dockPanel, DockState.Document);
                OpenScripts.Add(frmScriptEditor);
                //ScriptPreview.Close();
                ScriptPreview = null;
            }
        }

        public void RemoveFromOpenScrips(frmScriptEditor frmScriptEditor)
        {
            if (OpenScripts.Any(_ => _.Text == frmScriptEditor.Text))
            {
                OpenScripts.Remove(frmScriptEditor);
            }
        }

        /// <summary>
        /// Opens a document in the background
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="memoryStream"></param>
        /// <param name="suppressErrors"></param>
        public IWolvenkitDocument LoadDocument(string filename, MemoryStream memoryStream = null, bool suppressErrors = false)
        {
            if (memoryStream == null && !File.Exists(filename))
                return null;

            foreach (var t in vm.OpenDocuments.Where(t => t.FileName == filename))
            {
                t.Activate();
                return null;
            }

            // check and register custom classes
            // we do it here because people might edit the .ws files at any time
            // todo: what do I do if the .ws file has been edited while the cr2w file is open?
            //vm.ScanAndRegisterCustomClasses();

            var doc = new DocumentViewModel();
            vm.OpenDocuments.Add(doc);

            WorkerLoadFileSetup(new LoadFileArgs(filename, doc, memoryStream, suppressErrors));

            // wait for the backgroundworker to finish
            // this is not good practice since I am blocking
            // but there are some functions (the renderer etc) that rely on a return document
            // also I am blocking with the progress form regardless so it's already bad
            if (MainBackgroundWorker.IsBusy)
            {
                throw new NotImplementedException();
            }
            else
            {

            }
            var ret = HACK_bwform;
            HACK_bwform = null;
            return ret;
        }




        #region Show Forms
        private IDockContent GetModExplorer()
        {
            if (ModExplorer == null || ModExplorer.IsDisposed)
                ModExplorer = new frmModExplorer();
            return ModExplorer;
        }
        private void ShowModExplorer()
        {
            if (ModExplorer == null || ModExplorer.IsDisposed)
            {
                GetModExplorer();
                ModExplorer.Show(dockPanel, DockState.DockLeft);

            }
            ModExplorer.Activate();


            ModExplorer.RequestAssetBrowser += ModExplorer_RequestAssetBrowser;


            ModExplorer.RequestFileOpen += ModExplorer_RequestFileOpen;
            ModExplorer.RequestFileRename += ModExplorer_RequestFileRename;

            ModExplorer.RequestFastRender += ModExplorer_RequestFastRender;
        }
        private IDockContent GetOutput()
        {
            if (Output == null || Output.IsDisposed)
                Output = new frmOutput();
            return Output;
        }
        private void ShowOutput()
        {
            if (Output == null || Output.IsDisposed)
            {
                GetOutput();
                Output.Show(dockPanel, DockState.DockBottom);
            }

            Output.Activate();
        }
        private IDockContent GetConsole()
        {
            if (Console == null || Console.IsDisposed)
                Console = new frmConsole();
            return Console;
        }
        private void ShowConsole()
        {
            if (Console == null || Console.IsDisposed)
            {
                GetConsole();
                Console.Show(dockPanel, DockState.DockBottom);
            }

            Console.Activate();
        }
        private IDockContent GetWelcome()
        {
            if (Welcome == null || Welcome.IsDisposed)
                Welcome = new frmWelcome(this);
            return Welcome;
        }
        private void ShowWelcome()
        {
            if (Welcome == null || Welcome.IsDisposed)
            {
                GetWelcome();
                Welcome.Show(dockPanel, DockState.Document);
            }

            Welcome.Activate();
        }
        private void ShowModKit()
        {
            if (FormModKit == null || FormModKit.IsDisposed)
            {
                FormModKit = new frmWcc();
                FormModKit.Show(dockPanel, DockState.Document);
            }

            FormModKit.Activate();
        }
        private IDockContent GetImportUtility()
        {
            if (ImportUtility == null || ImportUtility.IsDisposed)
                ImportUtility = new frmImportUtility();
            return ImportUtility;
        }
        private void ShowImportUtility()
        {
            if (ImportUtility == null || ImportUtility.IsDisposed)
            {
                ImportUtility = new frmImportUtility();
                ImportUtility.Show(dockPanel, DockState.DockRight);
            }

            ImportUtility.Activate();
        }
        private void ShowRadishUtility()
        {
            if (ActiveMod == null)
            {
                MessageBox.Show(@"Please create a new mod project."
                    , "Missing Mod Project"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                return;
            }
            var filedir = new DirectoryInfo(MainController.Get().ActiveMod.FileDirectory);
            var radishdir = filedir.GetFiles("*.bat", SearchOption.AllDirectories)?.FirstOrDefault(_ => _.Name == "_settings_.bat")?.Directory;
            if (radishdir == null)
            {
                Logger.LogString("ERROR! No radish mod directory found.\r\n", Logtype.Error);
                return;
            }

            if (RadishUtility == null || RadishUtility.IsDisposed)
            {
                RadishUtility = new frmRadish();
                RadishUtility.Show(dockPanel, DockState.Document);
            }

            RadishUtility.Activate();
        }
        private void ShowImagePreview()
        {
            if (ImagePreview == null || ImagePreview.IsDisposed)
            {
                ImagePreview = new frmImagePreview();
                ImagePreview.Show(dockPanel, DockState.Document);
            }
            ImagePreview.Activate();
        }
        private void ShowScriptPreview()
        {
            if (ScriptPreview == null || ScriptPreview.IsDisposed)
            {
                ScriptPreview = new frmScriptEditor();
                ScriptPreview.Show(dockPanel, DockState.Document);
            }

            ScriptPreview.Activate();
        }

        /// <summary>
        /// Closes all the "file documents", resets modexplorer and clears the output.
        /// </summary>
        private void ResetWindows()
        {
            CloseWindows();

            ShowModExplorer();
            ShowConsole();
            ShowOutput();
            ShowImportUtility();

            ClearOutput();
        }

        /// <summary>
        /// Closes and saves all the "file documents", resets modexplorer.
        /// </summary>
        private void CloseWindows()
        {
            if (ActiveMod != null)
            {
                foreach (var t in vm.OpenDocuments.ToList())
                {
                    t.SaveFile();
                    t.Close();
                    vm.OpenDocuments.Remove(t);
                }
            }
            ModExplorer?.Close();
            ModExplorer = null;
            Output?.Close();
            Output = null;
            Console?.Close();
            Console = null;
            if (Welcome != null)
            {
                Welcome?.Close();
                Welcome = new frmWelcome(this);
            }
            ImportUtility?.Close();
            ImportUtility = null;
            RadishUtility?.Close();
            RadishUtility = null;
            ScriptPreview?.Close();
            ScriptPreview = null;
            ImagePreview?.Close();
            ImagePreview = null;
            FormModKit?.Close();
            FormModKit = null;

            foreach (var t in OpenScripts.ToList())
            {
                t.SaveFile();
                t.Close();
            }
            foreach (var t in OpenImages.ToList())
            {
                t.Close();
            }

            foreach (var window in dockPanel.FloatWindows.ToList())
            {
                window.Dispose();
                window.Close();
            }
        }

        /// <summary>
        /// Closes and saves all the "file documents", resets modexplorer.
        /// </summary>
        private void ReopenWindows()
        {
            if (ActiveMod?.LastOpenedFiles != null)
            {
                foreach (var doc in ActiveMod.LastOpenedFiles)
                {
                    if (File.Exists(doc))
                    {
                        LoadDocument(doc);
                    }
                }
            }
            ShowModExplorer();
            ShowImportUtility();
            ShowConsole();
            ShowOutput();

            if (Welcome != null)
                Welcome.Show(dockPanel, DockState.Document);
        }
        #endregion

        #region Mod Utility
        public void PackProject()
        {
            if (ActiveMod == null)
            {
                MessageBox.Show(@"Please create a new mod project."
                    , "Missing Mod Project"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                return;
            }
            if (Packer != null && (Packer.Status == TaskStatus.Running || Packer.Status == TaskStatus.WaitingToRun || Packer.Status == TaskStatus.WaitingForActivation))
            {
                MessageBox.Show("Packing task already running. Please wait!", "WolvenKit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                Packer = PackAndInstallMod();
        }
        private void CreateInstaller()
        {
            var cif = new frmCreateInstaller();
            cif.ShowDialog();
        }
        public async Task<bool> PackAndInstallMod(bool install = true)
        {
            if (ActiveMod == null)
                return false;
            if (Process.GetProcessesByName("Witcher3").Length != 0)
            {
                Logger.LogString("Please close The Witcher 3 before tinkering with the files!", Logtype.Error);
                return false;
            }

            var packsettings = new frmPackSettings();
            if (packsettings.ShowDialog() == DialogResult.OK)
            {
                toolStripBtnPack.Enabled = false;
                ShowConsole();
                ShowOutput();
                ClearOutput();
                vm.SaveAllFiles();

                //Create the dirs. So script only mods don't die.
                Directory.CreateDirectory(ActiveMod.PackedModDirectory);
                if (!string.IsNullOrEmpty(ActiveMod.GetDLCName()))
                    Directory.CreateDirectory(ActiveMod.PackedDlcDirectory);


                //------------------------PRE COOKING------------------------------------//
                // have a check if somehow users forget to add a dlc fodler in their dlc :(
                // but have files inform them that it just not gonna work
                bool initialDlcCheck = true;
                if (ActiveMod.DLCFiles.Any() && string.IsNullOrEmpty(ActiveMod.GetDLCName()))
                {
                    Logger.LogString("Files in your dlc directory need to have the following structure: dlc\\DLCNAME\\files. Dlc will not be packed.", Logtype.Error);
                    initialDlcCheck = false;
                }

                #region Pre Cooking
                //Handle strings.
                if (packsettings.Strings.Item1 || packsettings.Strings.Item2)
                {
                    if (stringsGui == null)
                        stringsGui = new frmStringsGui();
                    if (stringsGui.AreHashesDifferent())
                    {
                        var result = MessageBox.Show("There are no encoded CSV files in your mod, do you want to open Strings Encoder GUI?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                            stringsGui.ShowDialog();
                    }
                }

                // Cleanup Directories
                vm.CleanupDirectories();

                // Create Virtial Links
                vm.CreateVirtualLinks();

                // analyze files in dlc
                int statusanalyzedlc = -1;

                var seedfile = Path.Combine(ActiveMod.ProjectDirectory, @"cooked", $"seed.dlc{ActiveMod.Name}.files");

                if (initialDlcCheck)
                {
                    if (Directory.GetFiles(ActiveMod.DlcDirectory, "*", SearchOption.AllDirectories).Any())
                    {
                        Logger.LogString($"======== Analyzing dlc files ======== \n", Logtype.Important);
                        if (Directory.GetFiles(ActiveMod.DlcDirectory, "*.reddlc", SearchOption.AllDirectories).Any())
                        {
                            var reddlcfile = Directory.GetFiles(ActiveMod.DlcDirectory, "*.reddlc", SearchOption.AllDirectories).FirstOrDefault();
                            var analyze = new Wcc_lite.analyze()
                            {
                                Analyzer = analyzers.r4dlc,
                                Out = seedfile,
                                reddlc = reddlcfile
                            };
                            statusanalyzedlc *= await Task.Run(() => MainController.Get().WccHelper.RunCommand(analyze));

                            if (statusanalyzedlc == 0)
                            {
                                Logger.LogString("Analyzing dlc failed, creating fallback seedfiles. \n", Logtype.Error);
                                vm.CreateFallBackSeedFile(seedfile);
                            }
                        }
                        else
                        {
                            Logger.LogString("No reddlc found, creating fallback seedfiles. \n", Logtype.Error);
                            vm.CreateFallBackSeedFile(seedfile);
                        }
                    }
                }
                #endregion

                //------------------------- COOKING -------------------------------------//
                #region Cooking
                int statusCook = -1;

                // cook uncooked files
                var taskCookCol = Task.Run(() => vm.Cook());
                await taskCookCol.ContinueWith(antecedent =>
                {
                    //Logger.LogString($"Cooking Collision ended with status: {antecedent.Result}", Logtype.Important);
                    statusCook = antecedent.Result;
                });
                if (statusCook == 0)
                    Logger.LogString("Cooking collision finished with errors. \n", Logtype.Error);

                #endregion

                //------------------------- POST COOKING --------------------------------//
                #region Copy Cooked Files
                // copy mod files from Bundle (cooked files) to \cooked
                if (Directory.GetFiles(ActiveMod.ModCookedDirectory, "*", SearchOption.AllDirectories).Any())
                {
                    Logger.LogString($"======== Adding cooked mod files ======== \n", Logtype.Important);
                    try
                    {
                        var di = new DirectoryInfo(ActiveMod.ModCookedDirectory);
                        var files = di.GetFiles("*", SearchOption.AllDirectories);
                        Logger.LogString($"Found {files.Length} files in {di.FullName}. \n");
                        foreach (var fi in files)
                        {
                            string relpath = fi.FullName.Substring(ActiveMod.ModCookedDirectory.Length + 1);
                            string newpath = Path.Combine(ActiveMod.CookedModDirectory, relpath);

                            if (File.Exists(newpath))
                            {
                                Logger.LogString($"Duplicate cooked file found {newpath}. Overwriting. \n", Logtype.Important);
                                File.Delete(newpath);
                            }

                            fi.CopyToAndCreate(newpath);
                            Logger.LogString($"Copied file to cooked directory: {fi.FullName}. \n", Logtype.Normal);
                        }
                    }
                    catch (Exception)
                    {
                        Logger.LogString("Copying cooked mod files finished with errors. \n", Logtype.Error);
                    }
                    finally
                    {
                        Logger.LogString("Finished succesfully. \n", Logtype.Success);
                    }
                }

                // copy dlc files from Bundle (cooked files) to \cooked
                if (Directory.GetFiles(ActiveMod.DlcCookedDirectory, "*", SearchOption.AllDirectories).Any())
                {
                    Logger.LogString($"======== Adding cooked dlc files ======== \n", Logtype.Important);
                    try
                    {
                        var di = new DirectoryInfo(ActiveMod.DlcCookedDirectory);
                        var files = di.GetFiles("*", SearchOption.AllDirectories);
                        Logger.LogString($"Found {files.Length} files in {di.FullName}. \n");
                        foreach (var fi in files)
                        {
                            string relpath = fi.FullName.Substring(ActiveMod.DlcCookedDirectory.Length + 1);
                            string newpath = Path.Combine(ActiveMod.CookedDlcDirectory, relpath);

                            if (File.Exists(newpath))
                            {
                                Logger.LogString($"Duplicate cooked file found {newpath}. Overwriting. \n", Logtype.Important);
                                File.Delete(newpath);
                            }

                            fi.CopyToAndCreate(newpath);
                            Logger.LogString($"Copied file to cooked directory: {fi.FullName}. \n", Logtype.Normal);
                        }
                    }
                    catch (Exception)
                    {
                        Logger.LogString("Copying cooked dlc files finished with errors. \n", Logtype.Error);
                    }
                    finally
                    {
                        Logger.LogString("Finished succesfully. \n", Logtype.Success);
                    }
                }
                #endregion

                //------------------------- PACKING -------------------------------------//
                #region Packing
                int statusPack = -1;

                //Handle bundle packing.
                if (packsettings.PackBundles.Item1 || packsettings.PackBundles.Item2)
                {
                    // packing
                    //if (statusCookCol * statusCookTex != 0)
                    {
                        var t = Task.Run(() => vm.Pack(packsettings.PackBundles.Item1, packsettings.PackBundles.Item2));
                        await t.ContinueWith(antecedent =>
                        {
                            //Logger.LogString($"Packing Bundles ended with status: {antecedent.Result}", Logtype.Important);
                            statusPack = antecedent.Result;
                        });
                        if (statusPack == 0)
                            Logger.LogString("Packing bundles finished with errors. \n", Logtype.Error);
                    }
                    //else
                    //    Logger.LogString("Cooking assets failed. No bundles will be packed!\n", Logtype.Error);
                }
                #endregion

                //------------------------ METADATA -------------------------------------//
                #region Metadata
                //Handle metadata generation.
                int statusMetaData = -1;

                if (packsettings.GenMetadata.Item1 || packsettings.GenMetadata.Item2)
                {
                    if (statusPack == 1)
                    {
                        var t = Task.Run(() => vm.CreateMetaData(packsettings.GenMetadata.Item1, packsettings.GenMetadata.Item2));
                        await t.ContinueWith(antecedent =>
                        {
                            statusMetaData = antecedent.Result;
                            //Logger.LogString($"Creating metadata ended with status: {statusMetaData}", Logtype.Important);
                        });
                        if (statusMetaData == 0)
                            Logger.LogString("Creating metadata finished with errors. \n", Logtype.Error);
                    }
                    else
                        Logger.LogString("Packing bundles failed. No metadata will be created!\n", Logtype.Error);
                }
                #endregion

                //------------------------ POST COOKING ---------------------------------//

                //---------------------------- CACHES -----------------------------------//
                #region Buildcache
                int statusCol = -1;
                int statusTex = -1;

                //Generate collision cache
                if (packsettings.GenCollCache.Item1 || packsettings.GenCollCache.Item2)
                {
                    var t = Task.Run(() => vm.GenerateCache(EBundleType.CollisionCache, packsettings.GenCollCache.Item1, packsettings.GenCollCache.Item2));
                    await t.ContinueWith(antecedent =>
                    {
                        statusCol = antecedent.Result;
                        //Logger.LogString($"Building collision cache ended with status: {statusCol}", Logtype.Important);
                    });
                    if (statusCol == 0)
                        Logger.LogString("Building collision cache finished with errors. \n", Logtype.Error);
                }

                //Handle texture caching
                if (packsettings.GenTexCache.Item1 || packsettings.GenTexCache.Item2)
                {
                    var t = Task.Run(() => vm.GenerateCache(EBundleType.TextureCache, packsettings.GenTexCache.Item1, packsettings.GenTexCache.Item2));
                    await t.ContinueWith(antecedent =>
                    {
                        statusTex = antecedent.Result;
                        //Logger.LogString($"Building texture cache ended with status: {statusTex}", Logtype.Important);
                    });
                    if (statusTex == 0)
                        Logger.LogString("Building texture cache finished with errors. \n", Logtype.Error);
                }


                //Handle sound caching
                if (packsettings.Sound.Item1 || packsettings.Sound.Item2)
                {
                    if (packsettings.Sound.Item1)
                    {
                        var soundmoddir = Path.Combine(ActiveMod.ModDirectory, EBundleType.SoundCache.ToString());

                        foreach (var bnk in Directory.GetFiles(soundmoddir, "*.bnk", SearchOption.AllDirectories))
                        {
                            Soundbank bank = new Soundbank(bnk);
                            bank.readFile();
                            bank.read_wems(soundmoddir);
                            bank.rebuild_data();
                            File.Delete(bnk);
                            bank.build_bnk(bnk);
                            Logger.LogString("Rebuilt modded bnk " + bnk, Logtype.Success);
                        }

                        //Create mod soundspc.cache
                        if (Directory.Exists(soundmoddir) &&
                        new DirectoryInfo(soundmoddir)
                        .GetFiles("*.*", SearchOption.AllDirectories)
                        .Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk")).Any())
                        {
                            SoundCache.Write(
                                new DirectoryInfo(soundmoddir)
                                    .GetFiles("*.*", SearchOption.AllDirectories)
                                    .Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk"))
                                    .ToList().Select(x => x.FullName).ToList(),
                                    Path.Combine(ActiveMod.PackedModDirectory, @"soundspc.cache"));
                            Logger.LogString("Mod soundcache generated!\n", Logtype.Important);
                        }
                        else
                        {
                            Logger.LogString("Mod soundcache wasn't generated!\n", Logtype.Important);
                        }
                    }

                    if (packsettings.Sound.Item2)
                    {
                        var sounddlcdir = Path.Combine(ActiveMod.DlcDirectory, EBundleType.SoundCache.ToString());

                        //Create dlc soundspc.cache
                        if (Directory.Exists(sounddlcdir) && new DirectoryInfo(sounddlcdir)
                            .GetFiles("*.*", SearchOption.AllDirectories)
                            .Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk")).Any())
                        {
                            SoundCache.Write(
                                new DirectoryInfo(sounddlcdir)
                                    .GetFiles("*.*", SearchOption.AllDirectories)
                                    .Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk")).ToList().Select(x => x.FullName).ToList(),
                                Path.Combine(ActiveMod.PackedDlcDirectory, @"soundspc.cache"));
                            Logger.LogString("DLC soundcache generated!\n", Logtype.Important);
                        }
                        else
                        {
                            Logger.LogString("DLC soundcache wasn't generated!\n", Logtype.Important);
                        }
                    }
                }
                #endregion

                //---------------------------- SCRIPTS ----------------------------------//
                #region Scripts
                (bool packscriptsMod, bool packscriptsdlc) = packsettings.Scripts;
                //Handle mod scripts
                if (packscriptsMod && Directory.Exists(Path.Combine(ActiveMod.ModDirectory, "scripts")) && Directory.GetFiles(Path.Combine(ActiveMod.ModDirectory, "scripts"), "*.*", SearchOption.AllDirectories).Any())
                {
                    if (!Directory.Exists(Path.Combine(ActiveMod.ModDirectory, "scripts")))
                        Directory.CreateDirectory(Path.Combine(ActiveMod.ModDirectory, "scripts"));
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(Path.Combine(ActiveMod.ModDirectory, "scripts"), "*.*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(Path.Combine(ActiveMod.ModDirectory, "scripts"), Path.Combine(ActiveMod.PackedModDirectory, "scripts")));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(Path.Combine(ActiveMod.ModDirectory, "scripts"), "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(Path.Combine(ActiveMod.ModDirectory, "scripts"), Path.Combine(ActiveMod.PackedModDirectory, "scripts")), true);
                }

                //Handle the DLC scripts
                if (packscriptsdlc && Directory.Exists(Path.Combine(ActiveMod.DlcDirectory, "scripts")) && Directory.GetFiles(Path.Combine(ActiveMod.DlcDirectory, "scripts"), "*.*", SearchOption.AllDirectories).Any())
                {
                    if (!Directory.Exists(Path.Combine(ActiveMod.DlcDirectory, "scripts")))
                        Directory.CreateDirectory(Path.Combine(ActiveMod.DlcDirectory, "scripts"));
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(Path.Combine(ActiveMod.DlcDirectory, "scripts"), "*.*",
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(Path.Combine(ActiveMod.DlcDirectory, "scripts"), Path.Combine(ActiveMod.PackedDlcDirectory, "scripts")));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(Path.Combine(ActiveMod.DlcDirectory, "scripts"), "*.*",
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(Path.Combine(ActiveMod.DlcDirectory, "scripts"), Path.Combine(ActiveMod.PackedDlcDirectory, "scripts")), true);
                }
                #endregion

                //---------------------------- STRINGS ----------------------------------//
                #region Strings
                //Copy the generated w3strings
                if (packsettings.Strings.Item1 || packsettings.Strings.Item2)
                {
                    var files = Directory.GetFiles((ActiveMod.ProjectDirectory + "\\strings")).Where(s => Path.GetExtension(s) == ".w3strings").ToList();

                    if (packsettings.Strings.Item1)
                        files.ForEach(x => File.Copy(x, Path.Combine(ActiveMod.PackedDlcDirectory, Path.GetFileName(x))));
                    if (packsettings.Strings.Item2)
                        files.ForEach(x => File.Copy(x, Path.Combine(ActiveMod.PackedModDirectory, Path.GetFileName(x))));
                }
                #endregion

                //---------------------------- FINALIZE ---------------------------------//


                //Install the mod
                if (install)
                    vm.InstallMod();

                //Report that we are done
                MainController.Get().ProjectStatus = install ? "Mod Packed&Installed" : "Mod packed!";
                toolStripBtnPack.Enabled = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CreateNewMod()
        {
            var dlg = new SaveFileDialog
            {
                Title = @"Create Witcher 3 Mod Project",
                Filter = @"Witcher 3 Mod|*.w3modproj",
                InitialDirectory = MainController.Get().Configuration.InitialModDirectory
            };

            while (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.FileName.Contains(' '))
                {
                    MessageBox.Show(
                        @"The mod path should not contain spaces because wcc_lite.exe will have trouble with that.",
                        "Invalid path");
                    continue;
                }

                MainController.Get().Configuration.InitialModDirectory = Path.GetDirectoryName(dlg.FileName);
                var modname = Path.GetFileNameWithoutExtension(dlg.FileName);
                var dirname = Path.GetDirectoryName(dlg.FileName);

                var moddir = Path.Combine(dirname, modname);
                try
                {
                    Directory.CreateDirectory(moddir);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to create mod directory: \n" + moddir + "\n\n" + ex.Message);
                    return;
                }

                ActiveMod = new W3Mod
                {
                    FileName = dlg.FileName,
                    Name = modname
                };
                // create default directories
                ActiveMod.CreateDefaultDirectories();
                ResetWindows();

                // detect if radish-mod
                var filedir = new DirectoryInfo(MainController.Get().ActiveMod.ProjectDirectory).Parent;
                var radishdir = filedir.GetFiles("*.bat", SearchOption.AllDirectories)?.FirstOrDefault(_ => _.Name == "_settings_.bat")?.Directory;
                if (radishdir != null)
                {
                    switch (MessageBox.Show(
                        "WolvenKit detected a radish mod project installation in this directory. Would you like to add the radish files to the Mod Project?",
                        "Radish Tool Integration",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        default:
                            return;
                        case DialogResult.Yes:
                            {
                                if (!Directory.Exists(ActiveMod.RadishDirectory))
                                    Directory.CreateDirectory(ActiveMod.RadishDirectory);
                                //move radish files into Modfiledir
                                foreach (var file in radishdir.GetFiles("*", SearchOption.TopDirectoryOnly))
                                {
                                    File.Move(file.FullName, Path.Combine(ActiveMod.RadishDirectory, file.Name));
                                }
                                foreach (var dir in radishdir.GetDirectories("*", SearchOption.TopDirectoryOnly))
                                {
                                    if (dir.FullName == ActiveMod.ProjectDirectory)
                                        continue;
                                    Directory.Move(dir.FullName, Path.Combine(ActiveMod.RadishDirectory, dir.Name));
                                }
                                break;
                            }
                        case DialogResult.No:
                            {
                                break;
                            }
                    }
                }
                vm.SaveMod();
                Logger.LogString("\"" + ActiveMod.Name + "\" sucesfully created and loaded!\n", Logtype.Success);
                break;
            }
        }
        public void OpenMod(string file = "")
        {
            try
            {
                //Opening the file from a dialog
                if (string.IsNullOrEmpty(file))
                {
                    var dlg = new OpenFileDialog
                    {
                        Title = "Open Witcher 3 Mod Project",
                        Filter = "Witcher 3 Mod|*.w3modproj",
                        InitialDirectory = MainController.Get().Configuration.InitialModDirectory
                    };
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        file = dlg.FileName;
                    }
                    else
                    {
                        return;
                    }
                }

                var old = XDocument.Load(file);
                #region Upgrade from w3edit
                if (old.Descendants("InstallAsDLC").Any())
                {
                    //This is an old "Sarcen's W3Edit"-project. We need to upgrade it.
                    //Put the files into their respective folder.
                    switch (MessageBox.Show(
                        "The project you are opening has been made with an older version of Wolven Kit or Sarcen's Witcher 3 Edit.\n" +
                        "It needs to be upgraded for use with Wolvenkit.\n" +
                        "To load as a mod please press yes. To load as a DLC project please press no.\n" +
                        "You can manually do the upgrade if you check the project structure: https://github.com/Traderain/Wolven-kit/wiki/Project-structure press cancel if you desire to do so. This may not always work but I tried my best.",
                        "Out of date project", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        default:
                            return;
                        case DialogResult.Yes:
                            {
                                Commonfunctions.DirectoryMove(Path.Combine(Path.GetDirectoryName(file), old.Root.Element("Name").Value, "files"),
                                    Path.Combine(Path.GetDirectoryName(file), old.Root.Element("Name").Value, "files", "Mod", EBundleType.Bundle.ToString()));
                                break;
                            }
                        case DialogResult.No:
                            {
                                Commonfunctions.DirectoryMove(Path.Combine(Path.GetDirectoryName(file), old.Root.Element("Name").Value, "files"),
                                    Path.Combine(Path.GetDirectoryName(file), old.Root.Element("Name").Value, "files", "DLC", EBundleType.Bundle.ToString()));
                                break;
                            }

                    }
                    //Upgrade the project xml
                    var nw = new W3Mod
                    {
                        Name = old.Root.Element("Name")?.Value,
                        FileName = file,
                    };

                    File.Delete(file);
                    XmlSerializer xs = new XmlSerializer(typeof(W3Mod));
                    var mf = new FileStream(file, FileMode.Create);
                    xs.Serialize(mf, nw);
                    mf.Close();
                }
                #endregion



                //Close all docs
                vm.OpenDocuments.ToList().ForEach(x => x.Close());
                MainController.Get().Configuration.InitialModDirectory = Path.GetDirectoryName(file);


                // Loading the project
                var ser = new XmlSerializer(typeof(W3Mod));
                var modfile = new FileStream(file, FileMode.Open, FileAccess.Read);
                ActiveMod = (W3Mod)ser.Deserialize(modfile);
                ActiveMod.FileName = file;
                ActiveMod.CreateDefaultDirectories();
                modfile.Close();
                ResetWindows();
                Logger.LogString("\"" + ActiveMod.Name + "\" loaded successfully!\n", Logtype.Success);
                MainController.Get().ProjectStatus = "Ready";


                // upgrade from older mod projects
                if (!old.Descendants("Version").Any() || (old.Descendants("Version").Any() 
                    && int.TryParse(old.Descendants("Version").First().Value, out int version) 
                    && version < 0.62))
                {
                    MessageBox.Show(
                        "The project you are opening has been made with an older version of Wolven Kit.\n" +
                        "Some folder names have changed:\n" +
                        "CollisionCache and TextureCache have been unified into one Uncooked directory.\n" +
                        "Bundle has been renamed to Cooked",
                        "Out of date project", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    // check if any directories are misnamed
                    // remap CollisionCache ===> Uncooked
                    // remap TextureCache   ===> Uncooked
                    // remap Bundle         ===> Cooked
                    // mod
                    MoveFiles(EBundleType.CollisionCache, EProjectFolders.Uncooked);
                    MoveFiles(EBundleType.TextureCache, EProjectFolders.Uncooked);
                    MoveFiles(EBundleType.Bundle, EProjectFolders.Cooked);

                    // dlc
                    MoveFiles(EBundleType.CollisionCache, EProjectFolders.Uncooked, true);
                    MoveFiles(EBundleType.TextureCache, EProjectFolders.Uncooked, true);
                    MoveFiles(EBundleType.Bundle, EProjectFolders.Cooked, true);


                    //Upgrade the project xml
                    File.Delete(file);
                    XmlSerializer xs = new XmlSerializer(typeof(W3Mod));
                    var mf = new FileStream(file, FileMode.Create);
                    xs.Serialize(mf, ActiveMod);
                    mf.Close();
                }



                // Hash all filepaths
                var relativepaths = ActiveMod.ModFiles
                    .Select(_ => _.Substring(_.IndexOf(Path.DirectorySeparatorChar) + 1))
                    .ToList();
                Cr2wResourceManager.Get().RegisterAndWriteCustomPaths(relativepaths);

                // Update the recent files.
                var files = new List<string>();
                if (File.Exists("recent_files.xml"))
                {
                    var doc = XDocument.Load("recent_files.xml");
                    files.AddRange(doc.Descendants("recentfile").Take(4).Select(x => x.Value));
                }
                files.Add(file);
                new XDocument(new XElement("RecentFiles", files.Distinct().Select(x => new XElement("recentfile", x)))).Save("recent_files.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to upgrade the project!\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ActiveMod?.LastOpenedFiles != null)
            {
                foreach (var doc in ActiveMod.LastOpenedFiles)
                {
                    if (File.Exists(doc))
                    {
                        LoadDocument(doc);
                    }
                }
            }


            void MoveFiles(EBundleType oldtype, EProjectFolders newtype, bool isDlc = false)
            {
                var di = new DirectoryInfo(Path.Combine(isDlc ? ActiveMod.DlcDirectory : ActiveMod.ModDirectory, oldtype.ToString()));
                if (di.Exists && di.GetFiles("*", SearchOption.AllDirectories).Any())
                {
                    // move all files from old folders to new
                    foreach (var fi in di.GetFiles("*", SearchOption.AllDirectories))
                    {
                        try
                        {
                            var relpath = fi.FullName.Substring(di.FullName.Length + 1);
                            var newpath = Path.Combine(isDlc ? ActiveMod.DlcDirectory : ActiveMod.ModDirectory, newtype.ToString(), relpath);
                            if (!File.Exists(newpath))
                            {
                                Directory.CreateDirectory(new FileInfo(newpath).Directory.FullName);
                                File.Move(fi.FullName, newpath);
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.LogString($"Couldn't move file {fi.FullName}. Please manually upgrade your mod project.", Logtype.Error);
                        }
                    }
                }
                // delete old directories
                if (di.Exists && !di.GetFiles("*", SearchOption.AllDirectories).Any())
                {
                    di.Delete(true);
                }
            }
        }




        /// <summary>
        /// Scans the depot and the given archivemanagers for a file. If found, extracts it to the project.
        /// Supports Uncooking and exporting with wcc_lite
        /// </summary>
        /// <param name="relativePath"></param>
        /// <param name="depotpath"></param>
        /// <param name="skipping"></param>
        /// <param name="managers"></param>
        /// <param name="addAsDLC"></param>
        /// <param name="uncook"></param>
        /// <param name="export"></param>
        /// <returns></returns>
        private bool AddToMod(string relativePath, IWitcherArchiveManager manager, bool skipping, bool addAsDLC, bool uncook = false, bool export = false)
        {
            bool skip = skipping;
            string extension = Path.GetExtension(relativePath);
            string filename = Path.GetFileName(relativePath);
            

            // always uncook xbms, w2mesh, redcloth and redapex in Bundle
            //if ((extension == ".xbm" /*|| Enum.GetNames(typeof(EExportable)).Contains(extension.TrimStart('.'))*/) && manager.TypeName == EBundleType.Bundle)
            //    uncook = true;

            #region Check Existing Files in Working Dir
            // if uncooking check first if the file isn't already in the working depot or the r4depot
            if (uncook)
            {
                var newpath = "";
                // Working Depot
                var fi = new FileInfo(Path.Combine(Path.GetFullPath(MainController.WorkDir), relativePath));
                if (fi.Exists)
                {
                    // copy to uncooked folder in mod project
                    if (addAsDLC)
                        newpath = Path.Combine(ActiveMod.DlcUncookedDirectory, $"dlc{ActiveMod.Name}", relativePath);
                    else
                        newpath = Path.Combine(ActiveMod.ModUncookedDirectory, relativePath);

                    fi.CopyToAndCreate(newpath, true);
                    Logger.LogString($"Added {filename} from depot.", Logtype.Success);

                    // Optionally Export 
                    if (export && File.Exists(newpath))
                    {
                        var task = Task.Run(() => vm.ExportFileToMod(newpath));
                        Task.WaitAll(task);
                    }

                    return skip;
                }
                // NOTE: disable searching through the r4depot
                //else
                //{
                //    // get the file from the uncookedDepot
                //    fi = new FileInfo(Path.Combine(MainController.Get().Configuration.DepotPath, relativePath));
                //    if (fi.Exists)
                //    {
                //        var cacheDir = REDTypes.REDExtensionToCacheType(extension);

                //        newpath = Path.Combine(ActiveMod.FileDirectory, addAsDLC
                //            ? Path.Combine("DLC", cacheDir, "dlc", $"dlc{ActiveMod.Name}", relativePath)
                //            : Path.Combine("Mod", cacheDir, relativePath));

                //        fi.CopyToAndCreate(newpath, true);
                //        Logger.LogString($"Added {filename} from depot.", Logtype.Success);

                //        // Optionally Export 
                //        if (export && File.Exists(newpath))
                //        {
                //            var task = Task.Run(() => vm.ExportFileToMod(newpath));
                //            Task.WaitAll(task);
                //        }

                //        return skip;
                //    }
                //}

            }
            #endregion

            
            if (manager != null && manager.Items.Any(x => x.Value.Any(y => y.Name == relativePath)))
            {
                var archives = manager.FileList
                    .Where(x => x.Name == relativePath)
                    .Select(y => new KeyValuePair<string, IWitcherFile>(y.Bundle.FileName, y));
                string newpath = "";


                #region Uncooking
                // Uncooked files go into the uncooked folders
                if (uncook)
                {
                    // copy to uncooked folder in mod project
                    if (addAsDLC)
                        newpath = Path.Combine(ActiveMod.DlcUncookedDirectory, $"dlc{ActiveMod.Name}", relativePath);
                    else
                        newpath = Path.Combine(ActiveMod.ModUncookedDirectory, relativePath);
                    

                    var indir = Path.GetFullPath(MainController.Get().Configuration.GameRootDir);

                    var uncookTask = Task.Run(() => vm.UncookFileToMod(relativePath, newpath, indir));

                    Task.WaitAll(uncookTask);

                    var uncookedFilesCount = uncookTask.Result;

                    // return if any files have been uncooked, continue to extract otherwise
                    if (uncookedFilesCount > 0)
                    {
                        // Optionally Export 
                        if (export && File.Exists(newpath))
                        {
                            var exportTask = Task.Run(() => vm.ExportFileToMod(newpath));
                            Task.WaitAll(exportTask);
                        }

                        return skip;
                    }
                    else
                        Logger.LogString($"Could not uncook {filename}, trying to extract file instead of uncooking.", Logtype.Important);
                }
                #endregion

                #region Unbundling
                var bundletype = archives.First().Value.Bundle.TypeName;

                switch (bundletype)
                {
                    // extract files from bundle to Cooked
                    case EBundleType.Bundle:
                        {
                            newpath = Path.Combine(ActiveMod.FileDirectory, addAsDLC
                                ? Path.Combine("DLC", EProjectFolders.Cooked.ToString(), "dlc", ActiveMod.Name, relativePath)
                                : Path.Combine( "Mod", EProjectFolders.Cooked.ToString(), relativePath));
                        }
                        break;
                    // extract files from Collision and Texture caches to Raw (except for pngs etc)
                    case EBundleType.CollisionCache:
                    case EBundleType.TextureCache:
                        {
                            // add pngs, jpgs and dds directly to Uncooked (not Raw, since they don't get imported)
                            if (extension == ".png" || extension == ".jpg" || extension == ".dds")
                            {
                                newpath = Path.Combine(ActiveMod.FileDirectory, addAsDLC
                                    ? Path.Combine("DLC", EProjectFolders.Uncooked.ToString(), "dlc", ActiveMod.Name, relativePath)
                                    : Path.Combine("Mod", EProjectFolders.Uncooked.ToString(), relativePath));
                            }
                            // all other textures and collision stuff goes into Raw (since they have to be imported first)
                            else
                                newpath = Path.Combine(ActiveMod.RawDirectory, addAsDLC
                                    ? Path.Combine("DLC", "dlc", ActiveMod.Name, relativePath)
                                    : Path.Combine("Mod", relativePath));
                        }
                        break;
                    // some special cases
                    case EBundleType.SoundCache:
                    case EBundleType.Speech:
                    case EBundleType.Shader:
                        {
                            newpath = Path.Combine(ActiveMod.FileDirectory, addAsDLC
                                ? Path.Combine("DLC", archives.First().Value.Bundle.TypeName.ToString(), "dlc", ActiveMod.Name, relativePath)
                                : Path.Combine("Mod", archives.First().Value.Bundle.TypeName.ToString(), relativePath));
                        }
                        break;
                    case EBundleType.ANY:
                    default:
                        throw new NotImplementedException();
                        break;
                }


                // more than one archive
                if (archives.Count() > 1)
                {
                    var dlg = new frmExtractAmbigious(archives.Select(x => x.Key).ToList());
                    if (!skip)
                    {
                        var res = dlg.ShowDialog();
                        skip = dlg.Skip;
                        if (res == DialogResult.Cancel)
                        {
                            return skip;
                        }
                    }
                    var selectedBundle = archives.FirstOrDefault(x => x.Key == dlg.SelectedBundle).Value;
                    try
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(newpath));
                        if (File.Exists(newpath))
                        {
                            File.Delete(newpath);
                        }

                        selectedBundle.Extract(new BundleFileExtractArgs(newpath, MainController.Get().Configuration.UncookExtension));
                    }
                    catch { }
                    return skip;
                }

                // Extract
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(newpath));
                    if (File.Exists(newpath))
                    {
                        File.Delete(newpath);
                    }

                    archives.FirstOrDefault().Value.Extract(new BundleFileExtractArgs(newpath, MainController.Get().Configuration.UncookExtension));

                    Logger.LogString($"Succesfully extracted {filename}.", Logtype.Success);
                }
                catch (Exception ex)
                {
                    Logger.LogString(ex.ToString(), Logtype.Error);
                }
                #endregion

                return skip;
            }

            return skip;
        }

        /// <summary>
        /// Opens the asset browser in the background
        /// </summary>
        /// <param name="loadmods">Load the mod files</param>
        /// <param name="browseToPath">The path to browse to</param>
        private void OpenAssetBrowser(bool loadmods, string browseToPath = "")
        {
            if (ActiveMod == null)
            {
                MessageBox.Show(@"Please create a new mod project."
                    , "Missing Mod Project"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                return;
            }
            if (Application.OpenForms.OfType<frmAssetBrowser>().Any())
            {
                var frm = Application.OpenForms.OfType<frmAssetBrowser>().First();
                if (!string.IsNullOrEmpty(browseToPath))
                    frm.OpenPath(browseToPath);
                frm.WindowState = FormWindowState.Minimized;
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
                return;
            }
            var managers = MainController.Get().GetManagers(loadmods);

            //if (MainController.Get().ModCollisionManager != null) managers.Add(MainController.Get().ModCollisionManager);

            var explorer = new frmAssetBrowser(managers);
            explorer.RequestFileAdd += Assetbrowser_FileAdd;
            explorer.OpenPath(browseToPath);
            Point location = dockPanel.Location;
            location.X += (dockPanel.Size.Width / 2 - explorer.Size.Width / 2);
            location.Y += (dockPanel.Size.Height / 2 - explorer.Size.Height / 2);
            Rectangle floatWindowBounds = new Rectangle() { Location = location, Width = 827, Height = 564 };
            explorer.Show(dockPanel, floatWindowBounds);

        }

        #endregion

        #endregion

        #region UI Events
        private void frmMain_Load(object sender, EventArgs e)
        {
            //Load/Setup the config
            var Exit = false;
            while (!File.Exists(MainController.Get().Configuration.ExecutablePath))
            {
                var sets = new frmSettings();
                if (sets.ShowDialog() != DialogResult.OK)
                {
                    Exit = true;
                    break;
                }
                else
                    MainController.Get().ProjectStatus = "Ready";
            }

            if (Exit)
            {
                Visible = false;
                Close();
            }

            //Start loading if everything is set up.


            var frmload = new frmLoading();
            frmload.ShowDialog();

            WccHelper = MainController.Get().WccHelper;
            Logger = MainController.Get().Logger;
            Logger.PropertyChanged += LoggerUpdated;

            //Update check should be after we are all set up. It goes on in the background.
            AutoUpdater.Start("https://raw.githubusercontent.com/Traderain/Wolven-kit/master/Update.xml");
            richpresenceworker.RunWorkerAsync();

            if (!MainController.Get().Configuration.IsWelcomeFormDisabled)
            {
                var frmwelcome = new frmWelcome(this);
                frmwelcome.ShowDialog();
                switch (frmwelcome.DialogResult)
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
                        Close();
                        break;
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            richpresenceworker.CancelAsync();
            if (MainController.Get().ProjectUnsaved)
            {
                var res = MessageBox.Show("There are unsaved changes in your project. Would you like to save them?", "WolvenKit",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    vm.SaveAllFiles();
                    vm.SaveMod();
                }
                else if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {

                }
            }

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            var config = UIController.Get().Configuration;

            config.MainState = WindowState;

            WindowState = FormWindowState.Normal;
            config.MainSize = Size;
            config.MainLocation = Location;

            dockPanel.SaveAsXml(Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "main_layout.xml"));
            ToolStripManager.SaveSettings(this);
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            ResetWindows();     //remove this when dockpanel deserialisation works
            var config = UIController.Get().Configuration;
            Size = config.MainSize;
            Location = config.MainLocation;
            WindowState = config.MainState;

            try
            {
                dockPanel.LoadFromXml(
                    Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "main_layout.xml"),
                    m_deserializeDockContent);
            }
            catch
            {
                // ignored
            }

            if (!string.IsNullOrEmpty(MainController.Get().InitialModProject))
                OpenMod(MainController.Get().InitialModProject);
            else if (!string.IsNullOrEmpty(MainController.Get().InitialWKP))
            {
                using (var pi = new frmInstallPackage(MainController.Get().InitialWKP))
                    pi.ShowDialog();
            }
            else
            {
                //if (!MainController.Get().Configuration.IsWelcomeFormDisabled)
                //{
                //    Welcome = new frmWelcome(this);
                //    Welcome.Show(dockPanel, DockState.Document);
                //    Welcome.FormClosed += Welcome_FormClosed;
                //}
            }
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (sender is IWolvenkitDocument)
            {
                doc_Activated(sender, e);
            }
        }

        private void dockPanel_ActiveDocumentChanged(object sender, EventArgs e)
        {
            if (dockPanel.ActiveDocument is IWolvenkitDocument)
            {
                doc_Activated(dockPanel.ActiveDocument, e);
            }
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void menuStrip1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        #region Discord
        private void richpresenceworker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string project = "non";

            Discord.EventHandlers handlers = new Discord.EventHandlers();
            Discord.Initialize("482179494862651402", handlers);
            while (!richpresenceworker.CancellationPending)
            {
                Thread.Sleep(1000);
                if (MainController.Get().ActiveMod != null)
                {
                    if (project != MainController.Get().ActiveMod.Name.ToString())
                    {
                        project = MainController.Get().ActiveMod.Name.ToString();
                        Discord.RichPresence rp = new Discord.RichPresence();
                        rp.state = "";
                        rp.details = "Developing " + project;
                        rp.largeImageKey = "logo_wkit";
                        Discord.UpdatePresence(rp);
                    }
                }
            }
        }

        private void richpresenceworker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

        }

        private void richpresenceworker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

        }
        #endregion

        private void doc_Activated(object sender, EventArgs e)
        {
            ActiveDocument = (IWolvenkitDocument)sender;
        }

        private void doc_FormClosed(object sender, FormClosedEventArgs e)
        {
            _lastClosedTab.Enqueue(((IWolvenkitDocument)sender).FileName);
            var doc = (IWolvenkitDocument)sender;
            vm.OpenDocuments.Remove(doc.GetViewModel());

            if (doc == ActiveDocument)
            {
                ActiveDocument = null;
            }
        }


        #endregion

        #region MenuStrip
        private void iconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmLoading().Show();
        }

        #region Context menus
        private void modToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            packAndInstallModToolStripMenuItem.Enabled = ActiveMod != null;
            createPackedInstallerToolStripMenuItem.Enabled = ActiveMod != null;
            reloadProjectToolStripMenuItem.Enabled = ActiveMod != null;
            settingsToolStripMenuItem.Enabled = ActiveMod != null;
        }

        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            exportToolStripMenuItem.Enabled = ActiveMod != null;
            importToolStripMenuItem.Enabled = ActiveMod != null;

            newFileToolStripMenuItem.Enabled = ActiveMod != null;
            addFileFromBundleToolStripMenuItem.Enabled = ActiveMod != null;
            addFileFromOtherModToolStripMenuItem.Enabled = ActiveMod != null;
            addFileToolStripMenuItem.Enabled = ActiveMod != null;

            saveToolStripMenuItem.Enabled = ActiveMod != null;
            saveAllToolStripMenuItem.Enabled = ActiveMod != null;
        }

        private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            verifyFileToolStripMenuItem.Enabled = ActiveMod != null;
            renderW2meshToolStripMenuItem.Enabled = ActiveMod != null;
        }

        private void toolsToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            packageInstallerToolStripMenuItem.Enabled = ActiveMod != null;
            stringsEncoderGUIToolStripMenuItem.Enabled = ActiveMod != null;
            menuCreatorToolStripMenuItem.Enabled = ActiveMod != null;
            bulkEditorToolStripMenuItem.Enabled = ActiveMod != null;
            cR2WToTextToolStripMenuItem.Enabled = ActiveMod != null;
            experimentalToolStripMenuItem.Enabled = ActiveMod != null;
            launchModkitToolStripMenuItem.Enabled = ActiveMod != null;
        }

        private void viewToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            radishUtilitytoolStripMenuItem.Enabled = ActiveMod != null;
            //importUtilityToolStripMenuItem.Enabled = ActiveMod != null;
        }

        private void gameToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            GameDebuggerToolStripMenuItem.Enabled = ActiveMod != null;
            saveExplorerToolStripMenuItem.Enabled = ActiveMod != null;
        }

        #endregion

        #region File
        private void tbtNewMod_Click(object sender, EventArgs e)
        {
            CreateNewMod();
        }

        private void tbtOpenMod_Click(object sender, EventArgs e)
        {
            OpenMod();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog() { Title = "Open CR2W File" };
            dlg.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MainController.Get().Configuration.InitialFileDirectory = Path.GetDirectoryName(dlg.FileName);
                LoadDocument(dlg.FileName);
            }
        }

        private void RecentFile_click(object sender, EventArgs e)
        {
            OpenMod(sender.ToString());
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sf = new SaveFileDialog())
            {
                sf.Title = "Please select a location to save the json dump of the cr2w file";
                sf.Filter = "JSON Files | *.json";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    throw new NotImplementedException("TODO");
                }
            }
        }

        private void extractCollisioncacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var of = new OpenFileDialog())
            {
                of.Title = "Please select the collision.cache file to extract";
                of.Filter = "Collision caches | collision.cache";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    using (var sf = new FolderBrowserDialog())
                    {
                        sf.Description = "Please specify a location to save the extracted files";
                        if (sf.ShowDialog() == DialogResult.OK)
                        {
                            var ccf = new Cache.CollisionCache(of.FileName);
                            var outdir = sf.SelectedPath.EndsWith("\\") ? sf.SelectedPath : sf.SelectedPath + "\\";
                            foreach (var f in ccf.Files)
                            {
                                string extractedfilename = Path.ChangeExtension(Path.Combine(outdir, f.Name), "apb");
                                f.Extract(new BundleFileExtractArgs(extractedfilename, MainController.Get().Configuration.UncookExtension));
                                Logger.LogString($"Extracted {extractedfilename}.\n");
                            }
                        }
                    }
                }
            }
        }

        private async void fbxWithCollisionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"For this to work make sure your model has either of both of these layers:
_tri - trimesh
_col - for simple stuff like boxes and spheres", "Information about importing models", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (var of = new OpenFileDialog())
            {
                of.Title = "Please select your fbx file with _col or _tri layers";
                of.Filter = "FBX files | *.fbx";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    using (var sf = new SaveFileDialog())
                    {
                        sf.Filter = "Witcher 3 mesh file | *.w2mesh";
                        sf.Title = "Please specify a location to save the imported file";
                        sf.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
                        if (sf.ShowDialog() == DialogResult.OK)
                        {
                            await vm.ImportFile(of.FileName, sf.FileName);
                        }
                    }
                }
            }
        }

        private async void nvidiaClothFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var of = new OpenFileDialog())
            {
                of.Title = "Please select your cloth file for importing";
                of.Filter = "APB files | *.apb";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    using (var sf = new SaveFileDialog())
                    {
                        sf.Filter = "Witcher 3 cloth file | *.redcloth";
                        sf.Title = "Please specify a location to save the imported file";
                        sf.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
                        if (sf.ShowDialog() == DialogResult.OK)
                        {
                            await vm.ImportFile(of.FileName, sf.FileName);
                        }
                    }
                }
            }
        }

        private void w2rigjsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(@"Select w2rig JSON.", "Information about importing rigs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (var of = new OpenFileDialog())
            {
                of.Title = "Please select your w2rig.json file";
                of.Filter = "w2rig JSON files | *w2rig.json";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    using (var sf = new SaveFileDialog())
                    {
                        sf.Filter = "Witcher 3 rig file | *.w2rig";
                        sf.Title = "Please specify a location to save the imported file";
                        sf.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
                        sf.FileName = of.FileName;
                        if (sf.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                ConvertRig rig = new ConvertRig();
                                rig.Load(of.FileName);
                                rig.SaveToFile(sf.FileName);
                            }
                            catch (Exception ex)
                            {
                                Logger.LogString(ex.ToString() + "\n", Logtype.Error);
                            }

                            MainController.Get().ProjectStatus = "File imported succesfully!";
                        }
                    }
                }
            }
        }

        private void w2animsjsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(@"Select w2anims JSON.", "Information about importing rigs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (var of = new OpenFileDialog())
            {
                of.Title = "Please select your w2anims.json file";
                of.Filter = "anims JSON files | *w2anims.json";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    using (var sf = new SaveFileDialog())
                    {
                        sf.Filter = "Witcher 3 w2anims file | *.w2anims";
                        sf.Title = "Please specify a location to save the imported file";
                        sf.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
                        sf.FileName = of.FileName;
                        if (sf.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                ConvertAnimation anim = new ConvertAnimation();
                                anim.Load(new List<string>() { of.FileName }, sf.FileName);
                            }
                            catch (Exception ex)
                            {
                                Logger.LogString(ex.ToString() + "\n", Logtype.Error);
                            }

                            MainController.Get().ProjectStatus = "File imported succesfully!";
                        }
                    }
                }
            }
        }

        private void DLCScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMod == null)
                return;

            var scriptsdirectory = (ActiveMod.DlcDirectory + "\\scripts\\local");
            if (!Directory.Exists(scriptsdirectory))
            {
                Directory.CreateDirectory(scriptsdirectory);
            }
            var fullPath = scriptsdirectory + "\\" + "blank_script.ws";
            var count = 1;
            var fileNameOnly = Path.GetFileNameWithoutExtension(fullPath);
            var extension = Path.GetExtension(fullPath);
            var path = Path.GetDirectoryName(fullPath);
            var newFullPath = fullPath;
            while (File.Exists(newFullPath))
            {
                string tempFileName = $"{fileNameOnly}({count++})";
                if (path != null) newFullPath = Path.Combine(path, tempFileName + extension);
            }
            File.WriteAllLines(newFullPath, new[] { @"/*", $"Wolven kit - {Version}", DateTime.Now.ToString("d"), @"*/" });
        }

        private void ModscriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMod == null)
                return;

            var scriptsdirectory = (ActiveMod.ModDirectory + "\\scripts\\local");
            if (!Directory.Exists(scriptsdirectory))
            {
                Directory.CreateDirectory(scriptsdirectory);
            }
            var fullPath = scriptsdirectory + "\\" + "blank_script.ws";
            var count = 1;
            var fileNameOnly = Path.GetFileNameWithoutExtension(fullPath);
            var extension = Path.GetExtension(fullPath);
            var path = Path.GetDirectoryName(fullPath);
            var newFullPath = fullPath;
            while (File.Exists(newFullPath))
            {
                string tempFileName = $"{fileNameOnly}({count++})";
                if (path != null) newFullPath = Path.Combine(path, tempFileName + extension);
            }
            File.WriteAllLines(newFullPath, new[] { @"/*", $"Wolven kit - {Version}", DateTime.Now.ToString("d"), @"*/" });
        }

        private void ModWwiseNew_Click(object sender, EventArgs e)
        {
            using (var of = new OpenFileDialog())
            {
                of.Multiselect = true;
                of.Filter = "Wwise files | *.wem;*.bnk";
                of.Title = "Please select the wwise bank and sound files for importing them into your mod";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    foreach (var f in of.FileNames)
                    {
                        var newfilepath = Path.Combine(ActiveMod.ModDirectory, EBundleType.SoundCache.ToString(), Path.GetFileName(f));
                        //Create the directory because it will crash if it doesn't exist.
                        Directory.CreateDirectory(Path.GetDirectoryName(newfilepath));
                        File.Copy(f, newfilepath, true);
                    }
                }
            }
        }

        private void DLCWwise_Click(object sender, EventArgs e)
        {
            using (var of = new OpenFileDialog())
            {
                of.Multiselect = true;
                of.Filter = "Wwise files | *.wem;*.bnk";
                of.Title = "Please select the wwise bank and sound files for importing them into your DLC";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    foreach (var f in of.FileNames)
                    {
                        var newfilepath = Path.Combine(ActiveMod.DlcDirectory, EBundleType.SoundCache.ToString(), "dlc", ActiveMod.Name, Path.GetFileName(f));
                        //Create the directory because it will crash if it doesn't exist.
                        Directory.CreateDirectory(Path.GetDirectoryName(newfilepath));
                        File.Copy(f, newfilepath, true);
                    }
                }
            }
        }

        private void OpenDepotAssetBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAssetBrowser(false);
        }

        private void OpenModAssetBrowserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenAssetBrowser(true);
        }

        private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog() { Title = "Add File to Project" };
            dlg.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MainController.Get().Configuration.InitialFileDirectory = Path.GetDirectoryName(dlg.FileName);
                try
                {
                    FileInfo fi = new FileInfo(dlg.FileName);
                    var newfilepath = Path.Combine(ActiveMod.FileDirectory, fi.Name);
                    if (File.Exists(newfilepath))
                        newfilepath = $"{newfilepath.TrimEnd(fi.Extension.ToCharArray())} - copy{fi.Extension}";

                    fi.CopyToAndCreate(newfilepath, false);
                }
                catch (Exception)
                {
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveActiveFile();
        }

        private void SaveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vm.SaveAllFiles();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Project
        private void createPackedInstallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateInstaller();
        }

        private void ReloadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(MainController.Get().ActiveMod?.FileName))
            {
                OpenMod(MainController.Get().ActiveMod?.FileName);
            }
        }

        private void modSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMod == null)
                return;
            //With this cloned it won't get modified when we change it in dlg
            var oldmod = (W3Mod)ActiveMod.Clone();
            using (var dlg = new frmModSettings())
            {
                dlg.Mod = ActiveMod;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (oldmod.Name != dlg.Mod.Name)
                    {
                        try
                        {
                            ModExplorer?.StopMonitoringDirectory();
                            //Close all docs so they won't cause problems
                            vm.OpenDocuments.ToList().ForEach(x => x.Close());
                            //Move the files directory
                            Directory.Move(oldmod.ProjectDirectory, Path.Combine(Path.GetDirectoryName(oldmod.ProjectDirectory), dlg.Mod.Name));
                            //Delete the old directory
                            if (Directory.Exists(oldmod.ProjectDirectory))
                                Commonfunctions.DeleteFilesAndFoldersRecursively(oldmod.ProjectDirectory);
                            //Delete the old mod project file
                            if (File.Exists(oldmod.FileName))
                                File.Delete(oldmod.FileName);
                        }
                        catch (System.IO.IOException ex)
                        {
                            MessageBox.Show("Please check that you don't have Windows Explorer open at the old mod's path and that no folder/mod with that name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    //Save the new settings and update the title
                    UpdateTitle();
                    vm.SaveMod();
                    if (File.Exists(MainController.Get().ActiveMod?.FileName))
                    {
                        OpenMod(MainController.Get().ActiveMod?.FileName);
                    }
                    CommonUIFunctions.SendNotification("Succesfully updated mod settings!");
                }
            }
        }

        #endregion

        #region Tools
        private void packageInstallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var of = new OpenFileDialog())
            {
                of.Filter = "WolvenKit Package | *.wkp";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    using (var pi = new frmInstallPackage(of.FileName))
                        pi.ShowDialog();
                }
                else
                    CommonUIFunctions.SendNotification("Invalid file!");
            }
        }

        private void StringsGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stringsGui == null)
            {
                stringsGui = new frmStringsGui();
                stringsGui.ShowDialog();
            }
            else
                stringsGui.ShowDialog();
        }

        private void menuCreatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fmc = new frmMenuCreator())
            {
                fmc.ShowDialog();
            }
        }

        private void renderW2meshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bool.Parse(renderW2meshToolStripMenuItem.Tag.ToString()))
            {
                renderW2meshToolStripMenuItem.Tag = false;
                renderW2meshToolStripMenuItem.Image = Properties.Resources.ui_check_box_uncheck;
            }
            else
            {
                renderW2meshToolStripMenuItem.Tag = true;
                renderW2meshToolStripMenuItem.Image = Properties.Resources.ui_check_box;
            }
        }

        private void cR2WToTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fctt = new frmCR2WtoText();
            fctt.ShowDialog();
        }

        private void verifyFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var of = new OpenFileDialog())
            {
                of.Multiselect = true;
                of.Filter = "Cr2w files | *.*";
                of.Title = "Please select the Cr2w files for verifying.";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    foreach (var f in of.FileNames)
                    {
                        CR2WVerify.VerifyFile(f);
                    }
                }
            }
        }

        private void terrainViewerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Render.frmTerrain ter = new Render.frmTerrain();
            ter.Show(this.dockPanel, DockState.Document);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settings = new frmSettings();
            //settings.RequestApplyTheme += GlobalApplyTheme;
            settings.ShowDialog();
        }

        private void witcher3ModkitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowModKit();
        }

        private void bulkEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var be = new frmBulkEditor();
            be.ShowDialog();
        }
        #endregion

        #region View
        private void modExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowModExplorer();
        }

        private void OutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOutput();
        }

        private void consoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowConsole();
        }

        private void importUtilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowImportUtility();
        }

        private void RadishUtilitytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRadishUtility();
        }

        private void scriptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Game
        private void unbundleGameToolStripMenuItem_Click(object sender, EventArgs e) => SetupUnbundling();

        private void SetupUnbundling()
        {
            // Backgroundworker
            if (MainBackgroundWorker.IsBusy)
            {
                return;
            }

            // query free disk space
            DriveInfo drive = new DriveInfo(new DirectoryInfo(MainController.Get().Configuration.DepotPath).Root.FullName);
            if (!drive.IsReady)
                return;
            var freespace = drive.AvailableFreeSpace / (1024 * 1024 * 1024);
            var totalsize = drive.TotalSize / (1024 * 1024 * 1024);
            switch (MessageBox.Show(
                        $"Unbundling the game will take about {30}GB of space, available space: {freespace}GB on drive {drive.Name}.\n" +
                        $"Depot directory: {MainController.Get().Configuration.DepotPath}\n\n" +
                        $"Would you like to continue?",
                        "Unbundle Game Files",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                default:
                    return;
                case DialogResult.Yes:
                    {
                        break;
                    }
                case DialogResult.No:
                    {
                        return;
                    }
            }


            // Backgroundworker
            if (!MainBackgroundWorker.IsBusy)
            {
                // progress bar
                m_frmProgress = new frmProgress()
                {
                    Text = "Unbundling Game Assets",
                    StartPosition = FormStartPosition.CenterParent,
                };

                // background worker action
                workerAction = UnbundleGame;
                MainBackgroundWorker.RunWorkerAsync();

                // cancellation dialog
                DialogResult dr = m_frmProgress.ShowDialog(this);
                switch (dr)
                {
                    case DialogResult.Cancel:
                        {
                            MainBackgroundWorker.CancelAsync();
                            m_frmProgress.Cancel = true;
                            break;
                        }
                    case DialogResult.None:
                    case DialogResult.OK:
                    case DialogResult.Abort:
                    case DialogResult.Retry:
                    case DialogResult.Ignore:
                    case DialogResult.Yes:
                    case DialogResult.No:
                    default:
                        break;
                }


                this.BringToFront();
            }
            else
                Logger.LogString("The background worker is currently busy.\r\n", Logtype.Error);
        }

        protected object UnbundleGame(object sender, DoWorkEventArgs e)
        {
            object arg = e.Argument;

            BackgroundWorker bwAsync = sender as BackgroundWorker;

            var memorymappedbundles = new Dictionary<string, MemoryMappedFile>();
            var bm = new BundleManager();
            bm.LoadAll(MainController.Get().Configuration.ExecutablePath);

            //Load MemoryMapped Bundles
            foreach (var b in bm.Bundles.Values)
            {
                var hash = b.FileName.GetHashMD5();
                memorymappedbundles.Add(hash, MemoryMappedFile.CreateFromFile(b.FileName, FileMode.Open, hash, 0, MemoryMappedFileAccess.Read));
            }

            var files = bm.FileList
                    .GroupBy(p => p.Name)
                    .Select(g => g.Last())
                    .ToList();
            var count = files.Count;
            int finished = 0;
            Parallel.For(0, count, new ParallelOptions { MaxDegreeOfParallelism = (int)(Environment.ProcessorCount * 0.8) + 1 }, i =>
            {
                if (bwAsync.CancellationPending || m_frmProgress.Cancel)
                {
                    Logger.LogString("Background worker cancelled.\r\n", Logtype.Error);
                    e.Cancel = true;
                    //return false;
                }

                IWitcherFile f = files[i];
                if (f is BundleItem bi)
                {
                    var newpath = Path.Combine(MainController.Get().Configuration.DepotPath, bi.Name);

                    // overwrite existing files
                    if (File.Exists(newpath))
                        File.Delete(newpath);
                    else
                    {
                        var fi = new FileInfo(newpath);
                        var newdir = Path.GetDirectoryName(newpath);
                        Directory.CreateDirectory(newdir);
                    }

                    using (var ms = new MemoryStream())
                    using (FileStream file = new FileStream(newpath, FileMode.Create, System.IO.FileAccess.Write))
                    {
                        bi.ExtractExistingMMF(ms);
                        ms.Seek(0, SeekOrigin.Begin);

                        ms.CopyTo(file);
                    }

                    finished += 1;
                    int percentprogress = (int)((float)finished / (float)count * 100.0);
                    MainBackgroundWorker.ReportProgress(percentprogress, bi.Name);
                }
            });

            return true;

        }

        private async void uncookGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // query free disk space
            DriveInfo drive = new DriveInfo(new DirectoryInfo(MainController.Get().Configuration.DepotPath).Root.FullName);
            if (!drive.IsReady)
                return;
            var freespace = drive.AvailableFreeSpace / (1024 * 1024 * 1024);
            var totalsize = drive.TotalSize / (1024 * 1024 * 1024);
            switch (MessageBox.Show(
                        $"Uncooking the game takes a very long time and is usually not needed, consider unbundling the game instead.\n\n" +
                        $"Uncooking the game will take about {60}GB of space, available space: {freespace}GB on drive {drive.Name}.\n" +
                        $"Depot directory: {MainController.Get().Configuration.DepotPath}\n\n" +
                        $"Click Yes to unbundle or click No to continue uncooking.",
                        "Uncook Game Files",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                default:
                    return;
                case DialogResult.Yes:
                    {
                        SetupUnbundling();
                        return;
                    }
                case DialogResult.No:
                    {
                        // Not implemented
                        await SetupUncooking();
                        return;
                    }
                case DialogResult.Cancel:
                    {
                        return;
                    }
            }
        }

        private async Task SetupUncooking()
        {
            var content = Path.Combine(new FileInfo(MainController.Get().Configuration.ExecutablePath).Directory.Parent.Parent.FullName, "content");
            await UncookInternal(content).ContinueWith(antecedent =>
            {

            });
            var dlc = Path.Combine(new FileInfo(MainController.Get().Configuration.ExecutablePath).Directory.Parent.Parent.FullName, "DLC");
            string[] vanillaDLClist = new string[] { "DLC1", "DLC2", "DLC3", "DLC4", "DLC5", "DLC6", "DLC7", "DLC8", "DLC9", "DLC10", "DLC11", "DLC12", "DLC13", "DLC14", "DLC15", "DLC16", "bob", "ep1" };
            foreach (var item in vanillaDLClist)
            {
                var dlcdir = Path.Combine(dlc, item);
                await UncookInternal(dlcdir).ContinueWith(antecedent =>
                {

                });
            }



            async Task UncookInternal(string inputpath)
            {
                var depot = MainController.Get().Configuration.DepotPath;

                var cmd = new Wcc_lite.uncook()
                {
                    InputDirectory = inputpath,
                    OutputDirectory = depot,
                    Imgfmt = imageformat.tga,
                    Skiperrors = true,
                    Dumpswf = true
                };
                //var cmd = new Wcc_lite.unbundle()
                //{
                //    InputDirectory = inputpath,
                //    OutputDirectory = depot,
                //};
                await Task.Run(() => MainController.Get().WccHelper.RunCommand(cmd));
            }


        }

        private void openUncookedFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commonfunctions.ShowFileInExplorer(MainController.Get().Configuration.DepotPath);
        }

        private void saveExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sef = new frmSaveEditor())
                sef.ShowDialog();
        }

        private void GameDebuggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gdb = new frmDebug();
            Rectangle floatWindowBounds = new Rectangle() { Width = 827, Height = 564 };
            gdb.Show(dockPanel, floatWindowBounds);
        }

        #endregion

        #region Help
        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! Every last bit helps and everything donated is distributed between the core developers evenly.", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("https://www.patreon.com/bePatron?u=5458437");
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var cf = new frmAbout())
                cf.ShowDialog();
        }

        private void joinOurDiscordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you would like to join the modding discord?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Process.Start("https://discord.gg/KnPMmBz");
        }

        private void WitcherScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://witcherscript.readthedocs.io");
        }

        private void witcherIIIModdingToolLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var wcclicense = new frmWCCLicense();
            wcclicense.Show();
        }

        private void RecordStepsToReproduceBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"This will launch an app that will help you record the steps needed to reproduce the bug/problem.
After its done it saves a zip file.
Please send that to hambalko.bence@gmail.com with a short description about the problem.
Would you like to open the problem steps recorder?", "Bug reporting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start("psr.exe");
            }
        }

        private void ReportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When reporting a bug please create a reproducion file at Help->Record steps to reproduce.",
                "Bug reporting",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start($"mailto:{"hambalko.bence@gmail.com"}?Subject={"WolvenKit bug report"}&Body={"Short description of bug:"}");
        }
        #endregion
        #endregion

        #region ToolBar
        private void newModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewMod();
        }

        private void openModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMod();
        }

        private void tbtOpen_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog() { Title = "Open CR2W File" };
            dlg.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MainController.Get().Configuration.InitialFileDirectory = Path.GetDirectoryName(dlg.FileName);
                LoadDocument(dlg.FileName);
            }
        }

        private void tbtSave_Click(object sender, EventArgs e)
        {
            saveActiveFile();
        }

        private void tbtSaveAll_Click(object sender, EventArgs e)
        {
            if (ActiveMod == null)
            {
                return;
            }
            vm.SaveAllFiles();
            MainController.Get().ProjectStatus = "Item saved";
            Logger.LogString("Saved!\n", Logtype.Success);
        }



        private void toolStripBtnPack_Click(object sender, EventArgs e)
        {
            PackProject();
        }

        private void toolStripButtonRadishUtil_Click(object sender, EventArgs e)
        {
            ShowRadishUtility();
        }

        private void toolStripButtonImportUtil_Click(object sender, EventArgs e)
        {
            ShowImportUtility();
        }

        private void launchWithCostumParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var getparams = new Input("Please give the commands to launch the game with!");
            if (getparams.ShowDialog() == DialogResult.OK)
            {
                vm.executeGame(getparams.Resulttext);
            }
        }

        private void LaunchGameForDebuggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vm.executeGame();
        }

        private void packProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pack = PackAndInstallMod();
            while (!pack.IsCompleted)
                Application.DoEvents();
        }

        private void packProjectAndLaunchGameCustomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pack = PackAndInstallMod();
            while (!pack.IsCompleted)
                Application.DoEvents();

            if (!pack.Result)
                return;

            var getparams = new Input("Please give the commands to launch the game with!");
            if (getparams.ShowDialog() == DialogResult.OK)
            {
                vm.executeGame(getparams.Resulttext);
            }
        }

        private void PackProjectAndRunGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pack = PackAndInstallMod();
            while (!pack.IsCompleted)
                Application.DoEvents();

            if (!pack.Result)
                return;
            vm.executeGame();
        }


        #endregion

    }
}
