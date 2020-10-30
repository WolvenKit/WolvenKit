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
using SearchOption = System.IO.SearchOption;
using System.IO.MemoryMappedFiles;
using Microsoft.VisualBasic.FileIO;
using WolvenKit.App.Model;

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
    using App;
    using App.Commands;
    using App.ViewModels;
    using Bundles;
    using Common.Extensions;
    using Common.Model;
    using Forms.MVVM;
    using Render;
    using Scaleform;
    using Wwise.Player;
    using Wwise.Wwise;
    using Enums = Enums;
    using WolvenKit.CR2W.Reflection;
    using Microsoft.WindowsAPICodePack.Dialogs;
    using System.Globalization;

    public partial class frmMain : Form
    {
        private readonly MainViewModel vm;

        #region Fields

        #region Forms
        //private List<IWolvenkitView> OpenDocuments { get; set; } = new List<IWolvenkitView>();
        private frmModExplorer ModExplorer { get; set; }
        private frmOutput Output { get; set; }
        private frmConsole Console { get; set; }
        private frmImportUtility ImportUtility { get; set; }


        private frmStringsGui StringsGui { get; set; }
        private frmWelcome Welcome { get; set; }
        private frmRadish RadishUtility { get; set; }
        private frmProgress ProgressForm { get; set; }
        private frmWcc FormModKit { get; set; }


        private frmScriptEditor ScriptPreview { get; set; }
        //private List<frmScriptEditor> OpenScripts { get; set; } = new List<frmScriptEditor>();
        private frmImagePreview ImagePreview { get; set; }
        private List<frmImagePreview> OpenImages { get; set; } = new List<frmImagePreview>();

        #endregion

        private const string BaseTitle = "Wolven kit";
        private static Task _packer;
        private readonly HotkeyCollection hotkeys;
        private readonly ToolStripRenderer toolStripRenderer = new ToolStripProfessionalRenderer();

        private delegate void StrDelegate(string t);
        private delegate void ColorDelegate(Color t);
        private delegate void LogDelegate(string t, Logtype type);
        private delegate void IntDelegate(int t);

        private readonly Queue<string> lastClosedTab = new Queue<string>();
        private DeserializeDockContent m_deserializeDockContent;
        private LoggerService Logger { get; set; }
        private static string Version => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

        #endregion

        #region Properties

        public EventHandler errored;
        //private IWolvenkitView _activedocument;
        //public IWolvenkitView ActiveDocument
        //{
        //    get => _activedocument;
        //    set
        //    {
        //        _activedocument = value;
        //        UpdateTitle();
        //    }
        //}
        public W3Mod ActiveMod
        {
            get => MainController.Get().ActiveMod;
            private set
            {
                MainController.Get().ActiveMod = value ?? throw new ArgumentNullException(nameof(value));
                UpdateTitle();
            }
        }

        #endregion

        #region Constructor
        public frmMain()
        {
            vm = MockKernel.Get().GetMainViewModel();
            vm.PropertyChanged += ViewModel_PropertyChanged;

            InitializeComponent();

            UpdateTitle();
            MainController.Get().PropertyChanged += MainControllerUpdated;

            
            hotkeys = new HotkeyCollection(Enums.Scope.Application);
            hotkeys.RegisterHotkey(Keys.Control | Keys.S, HKSave, "Save");
            hotkeys.RegisterHotkey(Keys.Control | Keys.Shift | Keys.S, HKSaveAll, "SaveAll");
            hotkeys.RegisterHotkey(Keys.F1, HKHelp, "Help");
            

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
            menuStrip1.Show();

            visualStudioToolStripExtender1.DefaultRenderer = toolStripRenderer;
            UIController.Get().ToolStripExtender = visualStudioToolStripExtender1;

            watcher.Error += Watcher_Error;
            filePaths = new List<string>();
            rwlock = new ReaderWriterLockSlim();

            this.toolStripDropDownButtonGit.Paint += toolStripDropDownButtonGit_Paint;
        }

        #endregion

        #region UI Methods
        #region Show Forms
        private IDockContent GetModExplorer()
        {
            if (ModExplorer == null || ModExplorer.IsDisposed)
                ModExplorer = new frmModExplorer();

            ModExplorer.RequestAssetBrowser += ModExplorer_RequestAssetBrowser;
            ModExplorer.RequestFileOpen += ModExplorer_RequestFileOpen;
            ModExplorer.RequestFileRename += ModExplorer_RequestFileRename;
            ModExplorer.RequestFileDelete += ModExplorer_RequestFileDelete;
            ModExplorer.RequestFastRender += ModExplorer_RequestFastRender;

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
                ScriptPreview = new frmScriptEditor(new ScriptDocumentViewModel());
                ScriptPreview.Show(dockPanel, DockState.Document);
            }

            ScriptPreview.Activate();
        }

        /// <summary>
        /// Initializes all dockwindows
        /// </summary>
        private void InitWindows()
        {
            GetModExplorer();
            GetConsole();
            GetOutput();
            GetImportUtility();
        }


        /// <summary>
        /// Closes all the "file documents", resets modexplorer and clears the output.
        /// </summary>
        public void ResetWindows()
        {
            if (isDockPanelInitialized)
                SaveDockPanelLayout();

            if (!CloseWindows()) return;

            InitDockPanel();

            //ClearOutput();
        }

        private bool CloseAllDocuments()
        {
            //if (ActiveMod == null) return false;
            if (vm.GetOpenDocuments().Count <= 0) return true;

            bool saveall;
            switch (MessageBox.Show(
                "This will close all open documents. You will loose any unsaved progress in open files. " +
                "Press Yes to save all open documents or No to continue without saving.",
                "Save Open Documents",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                default:
                    return false;
                case DialogResult.Yes:
                {
                    saveall = true;
                    break;
                }
                case DialogResult.No:
                {
                    saveall = false;
                    break;
                }
                case DialogResult.Cancel:
                {
                    return false;
                }
            }

            // close ViewModels and let the event close the Views
            foreach (var t in vm.GetOpenDocuments().Values.ToList())
            {
                if (saveall)
                    t.SaveFile();
                t.Close();
            }

            // close the Views directly
            //var opendocs = dockPanel.Documents
            //    .Where(_ => _.GetType() == typeof(frmCR2WDocument))
            //    .Cast<frmCR2WDocument>()
            //    .ToList();

            //foreach (var frmCr2WDocument in opendocs)
            //{
            //    if (saveall)
            //        frmCr2WDocument.GetViewModel().SaveFile();
            //    frmCr2WDocument.Close();
            //}

            return true;
        }

        /// <summary>
        /// Closes and saves all the "file documents", resets modexplorer.
        /// </summary>
        private bool CloseWindows()
        {
            if (!CloseAllDocuments()) return false;

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

            foreach (var t in OpenImages.ToList())
            {
                t.Close();
            }

            foreach (var window in dockPanel.FloatWindows.ToList())
            {
                window.Close();
                window.Dispose();
            }

            return true;
        }

        #endregion
        private void SaveDockPanelLayout() => dockPanel.SaveAsXml(Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "main_layout.xml"));
        private bool isDockPanelInitialized;
        private void InitDockPanel()
        {
            ApplyCustomTheme();
            string config = Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "main_layout.xml");
            if (System.IO.File.Exists(config))
            {
                try
                {
                    dockPanel.LoadFromXml(config, m_deserializeDockContent);
                    dockPanel.Theme.Extender.FloatWindowFactory = new CustomFloatWindowFactory();
                }
                catch (Exception exception)
                {
                    ShowWindows();
                    System.Console.WriteLine(exception);
                }
            }
            else
            {
                ShowWindows();
                SaveDockPanelLayout();
            }

            isDockPanelInitialized = true;

            void ShowWindows()
            {
                ShowModExplorer();
                ShowConsole();
                ShowOutput();
                ShowImportUtility();
            }
        }

        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(frmModExplorer).ToString())
                return GetModExplorer();
            else if (persistString == typeof(frmConsole).ToString())
                return GetConsole();
            else if (persistString == typeof(frmOutput).ToString())
                return GetOutput();
            //else if (persistString == typeof(frmWelcome).ToString())
            //    return GetWelcome();
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
            ResetWindows();
        }
        private void ApplyCustomTheme()
        {
            var theme = UIController.GetTheme();
            this.dockPanel.Theme = theme;
            visualStudioToolStripExtender1.SetStyle(menuStrip1, VisualStudioToolStripExtender.VsVersion.Vs2015, theme);

            //visualStudioToolStripExtender1.SetStyle(statusToolStrip, VisualStudioToolStripExtender.VsVersion.Vs2015, new VS2015LightTheme());
            //statusToolStrip.BackColor = SystemColors.HotTrack;

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
        //Func<object, object> workerCompletedAction;
        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bwAsync = sender as BackgroundWorker;
            e.Result = workerAction(sender, e);

            // add a result
            //e.Result
        }
        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressForm?.SetProgressBarValue(e.ProgressPercentage, e.UserState);
        }
        //IWolvenkitView HACK_bwform = null;
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // has errors
            if (e.Error != null)
            {
                // do not continue to the completed action
            }
            else // has completed successfully
            {
                //if (workerCompletedAction != null)
                //{
                //    HACK_bwform = (IWolvenkitView)workerCompletedAction(e.Result);
                //}
                //workerCompletedAction = null;
            }

            ProgressForm.Close();
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
            if (vm.ActiveDocument != null)
            {
                lastClosedTab.Enqueue(vm.ActiveDocument.FileName);
                vm.ActiveDocument.Close();
            }
            //if (ActiveDocument != null)
            //{
            //    lastClosedTab.Enqueue(ActiveDocument.FileName);
            //    ActiveDocument.Close();
            //}
        }
        private void HKReopenTab(HotKeyEventArgs e)
        {
            if (lastClosedTab.Count > 0)
            {
                string filetoopen = lastClosedTab.Dequeue();
                if (!string.IsNullOrEmpty(filetoopen))
                    LoadDocument(filetoopen);
            }
        }
        private void HKSave(HotKeyEventArgs e) => saveActiveFile();

        private void HKSaveAll(HotKeyEventArgs e) => vm.SaveAllFiles();

        private static void HKHelp(HotKeyEventArgs e) => Process.Start("https://github.com/Traderain/Wolven-kit/wiki");

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
            switch (e.PropertyName)
            {
                case "Log":
                    Invoke(new LogDelegate(AddOutput), ((LoggerService)sender).Log + "\n", ((LoggerService)sender).Logtype);
                    break;
                case "Progress":
                {
                    if (MainBackgroundWorker != null)
                    {
                        if (string.IsNullOrEmpty(Logger.Progress.Item2))
                            MainBackgroundWorker.ReportProgress((int)Logger.Progress.Item1);
                        else
                            MainBackgroundWorker.ReportProgress((int)Logger.Progress.Item1, Logger.Progress.Item2);
                    }

                    break;
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
            switch (e.PropertyName)
            {
                case "ProjectStatus":
                    switch (((MainController)sender).ProjectStatus)
                    {
                        
                        case EProjectStatus.Busy:
                            Invoke(new ColorDelegate(SetStatusBarColor), Color.FromArgb(202, 81, 0));
                            break;
                        case EProjectStatus.Errored:
                        case EProjectStatus.Idle:
                        case EProjectStatus.Ready:
                        default:
                            Invoke(new ColorDelegate(SetStatusBarColor), SystemColors.HotTrack);
                            break;
                    }
                    Invoke(new StrDelegate(SetStatusLabelText), ((MainController)sender).ProjectStatus.ToString());
                    break;
                case "LogMessage":
                    Invoke(new LogDelegate(AddOutput), ((MainController)sender).LogMessage.Key + "\n",
                        ((MainController)sender).LogMessage.Value);
                    break;
                case "StatusProgress":
                    Invoke(new IntDelegate(SetStatusProgressbarValue), ((MainController)sender).StatusProgress);
                    break;
            }

            void SetStatusLabelText(string text) => statusLBL.Text = text;
            void SetStatusProgressbarValue(int val) => toolStripProgressBar1.Value = val;
            void SetStatusBarColor(Color color) => this.statusToolStrip.BackColor = color;
        }

        private void Assetbrowser_FileAdd(object sender, AddFileArgs Details)
        {

            if (Process.GetProcessesByName("Witcher3").Length != 0)
            {
                MessageBox.Show(@"Please close The Witcher 3 before tinkering with the files!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MainController.Get().ProjectStatus = EProjectStatus.Busy;

            // Backgroundworker
            if (!MainBackgroundWorker.IsBusy)
            {
                PauseMonitoring();

                // progress bar
                ProgressForm = new frmProgress()
                {
                    Text = "Adding Assets",
                    StartPosition = FormStartPosition.CenterParent,
                };

                // background worker action
                workerAction = WorkerAssetBrowserAddFiles;
                MainBackgroundWorker.RunWorkerAsync(Details);

                // cancellation dialog
                DialogResult dr = ProgressForm.ShowDialog(this);
                switch (dr)
                {
                    case DialogResult.Cancel:
                        {
                            MainBackgroundWorker.CancelAsync();
                            ProgressForm.Cancel = true;
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
                ResumeMonitoring();
                vm.SaveMod();
                this.BringToFront();
                MainController.Get().ProjectStatus = EProjectStatus.Ready;
            }
            else
            {
                Logger.LogString("The background worker is currently busy.\r\n", Logtype.Error);
                MainController.Get().ProjectStatus = EProjectStatus.Errored;
            }

            

        }

        private object WorkerAssetBrowserAddFiles(object sender, DoWorkEventArgs e)
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
                if (bwAsync.CancellationPending || ProgressForm.Cancel)
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

        /// <summary>
        ///  Fires when the ModExplorer FilesystemWatcher triggers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFileChange(object sender, RequestFilesChangeArgs e)
        {
            // Trigger re-compilation of custom user classes
            if (e.Files.Any(_ => Path.GetExtension(_) == ".ws"))
                CR2WManager.ReloadAssembly();

            // Update the Import Utility
            MockKernel.Get().GetImportViewModel().UseLocalResourcesCommand.SafeExecute();
        }

        private void ModExplorer_RequestFileDelete(object sender, RequestFileDeleteArgs e)
        {
            PauseMonitoring();

            // ignore the main directories
            var deletablefiles = new List<string>();
            foreach (var item in e.Files)
            {
                if (!(item == ActiveMod.ModDirectory
                      || item == ActiveMod.DlcDirectory
                      || item == ActiveMod.RawDirectory
                      || item == ActiveMod.RadishDirectory
                      || item == ActiveMod.ModCookedDirectory
                      || item == ActiveMod.ModUncookedDirectory
                      || item == ActiveMod.DlcCookedDirectory
                      || item == ActiveMod.DlcUncookedDirectory
                    ))
                {
                    deletablefiles.Add(item);
                }
            }

            // delete the rest
            foreach (var filename in deletablefiles)
            {
                // Close open documents
                foreach (var t in vm.GetOpenDocuments().Values.Where(t => t.FileName == filename))
                {
                    t.Close();
                    break;
                }

                // Delete from file structure
                var fullpath = Path.Combine(ActiveMod.FileDirectory, filename);
                try
                {
                    if (File.Exists(fullpath))
                    {
                        FileSystem.DeleteFile(fullpath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                        //File.Delete(fullpath);
                    }
                    else
                    {
                        FileSystem.DeleteDirectory(fullpath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                        //Directory.Delete(fullpath, true);
                    }
                }
                catch (Exception)
                {
                    MainController.LogString("Failed to delete " + fullpath + "!\r\n", Logtype.Error);
                }
            }


            ResumeMonitoring();
            vm.SaveMod();
        }

        private void ModExplorer_RequestFileRename(object sender, RequestFileOpenArgs e)
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
        }

        private void ModExplorer_RequestFastRender(object sender, RequestFileOpenArgs e)
        {
            Render.FastRender.frmFastRender ren = new Render.FastRender.frmFastRender(e.File, Logger, ActiveMod);
            ren.Show(this.dockPanel, DockState.Document);
        }

        private void ModExplorer_RequestAssetBrowser(object sender, RequestFileOpenArgs e) => OpenAssetBrowser(false, e.File);

        private void ModExplorer_RequestFileOpen(object sender, RequestFileOpenArgs e)
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
                            var existing = TryOpenExisting(fullpath);
                            if (existing == null)
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
                case ".XCF":
                case ".PSD":
                case ".APB":
                case ".APX":
                case ".CTW":
                case ".BLEND":
                case ".ZIP":
                case ".RAR":
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
                try
                {
                    var proc = new ProcessStartInfo(path) {UseShellExecute = true};
                    Process.Start(proc);
                }
                catch (Win32Exception winex)
                {
                    // eat this: no default app set for filetype
                    Logger.LogString($"No default prgram set in Windows to open file extension {Path.GetExtension(path)}", Logtype.Error);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
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

            if (vm.ActiveDocument != null)
            {
                Text += Path.GetFileName(vm.ActiveDocument.FileName);
            }
        }

        private void ClearOutput()
        {
            if (Output != null && !Output.IsDisposed)
            {
                Output.Clear();
            }
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
            vm.ActiveDocument?.SaveFile();

        }

        private IWolvenkitView TryOpenExisting(string key)
        {
            // check if already open
            var opendocs2 = dockPanel.Documents
                .Where(_ => _ is IWolvenkitView);

            foreach (var dockContent in opendocs2)
            {
                if (dockContent is IWolvenkitView iview && iview.FileName == key)
                {
                    iview?.Activate();
                    return iview;
                }
            }

            // check on the viewmodel
            //foreach (var t in vm.GetOpenDocuments().Values.Where(_ => _.FileName == key))
            //{
            //    t.Activate();
            //    return true;
            //}

            return null;
        }

        /// <summary>
        /// Opens a document in the background
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="memoryStream"></param>
        /// <param name="suppressErrors"></param>
        public IWolvenkitView LoadDocument(string filename, MemoryStream memoryStream = null, bool suppressErrors = false)
        {
            if (memoryStream == null && !File.Exists(filename))
                return null;

            var existing = TryOpenExisting(filename);
            if (existing != null) return existing;


            // switch between cr2w files and non-cr2w files (e.g. srt)
            if (Path.GetExtension(filename) == ".srt")
            {
                var doc = new frmOtherDocument(new CommonDocumentViewModel());

                doc.Activated += doc_Activated;
                doc.Show(dockPanel, DockState.Document);
                doc.FormClosed += doc_FormClosed;

                return doc;
            }
            else
            {


                //var doc = Args.Doc;
                frmCR2WDocument doc = new frmCR2WDocument(new CR2WDocumentViewModel());
                doc.WorkerLoadFileSetup(new LoadFileArgs(filename, memoryStream));


                doc.Activated += doc_Activated;
                doc.Show(dockPanel, DockState.Document);
                doc.FormClosed += doc_FormClosed;

                doc.PostLoadFile(filename, bool.Parse(renderW2meshToolStripMenuItem.Tag.ToString()));

                vm.AddOpenDocument(doc.GetViewModel());

                return doc;
            }
        }

        #region Mod Utility

        private void PackProject()
        {
            if (ActiveMod == null)
            {
                MessageBox.Show(@"Please create a new mod project."
                    , "Missing Mod Project"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                return;
            }
            if (_packer != null && (_packer.Status == TaskStatus.Running || _packer.Status == TaskStatus.WaitingToRun || _packer.Status == TaskStatus.WaitingForActivation))
            {
                MessageBox.Show("Packing task already running. Please wait!", "WolvenKit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                _packer = PackAndInstallMod();
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
                MainController.Get().ProjectStatus = EProjectStatus.Busy;

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
                    if (StringsGui == null)
                        StringsGui = new frmStringsGui();
                    if (StringsGui.AreHashesDifferent())
                    {
                        var result = MessageBox.Show("There are no encoded CSV files in your mod, do you want to open Strings Encoder GUI?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                            StringsGui.ShowDialog();
                    }
                }

                // Cleanup Directories
                vm.CleanupDirectories();

                // Create Virtial Links
                vm.CreateVirtualLinks();

                // analyze files in dlc
                int statusanalyzedlc = -1;

                var seedfile = Path.Combine(ActiveMod.ProjectDirectory, @"cooked", $"seed_dlc{ActiveMod.Name}.files");

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

                        // We need to have the original soundcache's so we can rebuild them when packing the mod
                        foreach (var wem in Directory.GetFiles(soundmoddir, "*.wem", SearchOption.AllDirectories))
                        {
                            // Get the file id so we can search for the parent soundcache
                            var id = Path.GetFileNameWithoutExtension(SoundCache.GetIDFromPath(wem));

                            // Find the parent bank
                            foreach (var bnk in SoundCache.info.Banks)
                            {
                                if (bnk.IncludedFullFiles.Any(x => x.Id == id) || bnk.IncludedPrefetchFiles.Any(x => x.Id == id))
                                {
                                    if (!File.Exists(Path.Combine(soundmoddir, bnk.Path)))
                                    {
                                        var bytes = MainController.ImportFile(bnk.Path, MainController.Get().SoundManager);
                                        File.WriteAllBytes(Path.Combine(soundmoddir, bnk.Path), bytes[0].ToArray());
                                        MainController.Get().Logger.LogString("Imported " + bnk.Path + " for rebuilding with the modded wem files!");
                                    }
                                    break;
                                }
                            }
                        }

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
                MainController.Get().ProjectStatus = EProjectStatus.Ready;
                toolStripBtnPack.Enabled = true;
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Creates a new W3Mod
        /// </summary>
        /// <returns></returns>
        public W3Mod CreateNewMod()
        {
            if (!CloseAllDocuments()) return null;

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
                    return null;
                }

                ActiveMod = new W3Mod
                {
                    FileName = dlg.FileName,
                    Name = modname
                };
                // create default directories
                ActiveMod.CreateDefaultDirectories();
                watcher.Path = ActiveMod.FileDirectory;
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
                            return null;
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

            return ActiveMod;
        }
        
        /// <summary>
        /// Deserializes a w3modproj File and loads the W3mod
        /// </summary>
        /// <param name="file"></param>
        public void OpenMod(string file = "")
        {
            //Close all docs
            if (!CloseAllDocuments()) return;

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
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to upgrade the project!\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

            
            
            MainController.Get().Configuration.InitialModDirectory = Path.GetDirectoryName(file);

            // Loading the project
            var ser = new XmlSerializer(typeof(W3Mod));
            using (var modfile = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                ActiveMod = (W3Mod)ser.Deserialize(modfile);
                ActiveMod.FileName = file;
                ActiveMod.CreateDefaultDirectories();
                watcher.Path = ActiveMod.FileDirectory;
            }

            ResetWindows();
            Logger.LogString("\"" + ActiveMod.Name + "\" loaded successfully!\n", Logtype.Success);
            MainController.Get().ProjectStatus = EProjectStatus.Ready;

            #region upgrade from older mod projects
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


            #endregion

            // Hash all filepaths
            var relativepaths = ActiveMod.ModFiles
                .Select(_ => _.Substring(_.IndexOf(Path.DirectorySeparatorChar) + 1))
                .ToList();
            Cr2wResourceManager.Get().RegisterAndWriteCustomPaths(relativepaths);

            // register all custom classes
            CR2WManager.Init(ActiveMod.FileDirectory, MainController.Get().Logger);

            // update import
            MockKernel.Get().GetImportViewModel().UseLocalResourcesCommand.SafeExecute();

            RepopulateRecentFiles(file);

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
        /// <param name="manager"></param>
        /// <param name="skipping"></param>
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
                    newpath = addAsDLC 
                        ? Path.Combine(ActiveMod.DlcUncookedDirectory, $"dlc{ActiveMod.Name}", relativePath) 
                        : Path.Combine(ActiveMod.ModUncookedDirectory, relativePath);

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
            }
            #endregion

            
            if (manager != null && manager.Items.Any(x => x.Value.Any(y => y.Name == relativePath)))
            {
                var archives = manager.FileList
                    .Where(x => x.Name == relativePath)
                    .Select(y => new KeyValuePair<string, IWitcherFile>(y.Bundle.ArchiveAbsolutePath, y));
                //string newpath = "";


                #region Uncooking
                // Uncooked files go into the uncooked folders
                if (uncook)
                {
                    // copy to uncooked folder in mod project
                    var uncookTask = Task.Run(() => vm.UncookFileToPath(relativePath, addAsDLC));

                    Task.WaitAll(uncookTask);

                    var uncookedFilesCount = uncookTask.Result;

                    // return if any files have been uncooked, continue to extract otherwise
                    if (uncookedFilesCount > 0)
                    {
                        // Optionally Export 
                        string _newpath = addAsDLC
                            ? Path.Combine(ActiveMod.DlcUncookedDirectory, $"dlc{ActiveMod.Name}", relativePath)
                            : Path.Combine(ActiveMod.ModUncookedDirectory, relativePath);
                        if (export && File.Exists(_newpath))
                        {
                            var exportTask = Task.Run(() => vm.ExportFileToMod(_newpath));
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
                string newpath = "";
                switch (bundletype)
                {
                    // extract files from bundle to Cooked
                    case EBundleType.Bundle:
                        {
                            newpath = Path.Combine(ActiveMod.FileDirectory, addAsDLC
                                ? Path.Combine("DLC", EProjectFolders.Cooked.ToString(), $"dlc{ActiveMod.Name}", relativePath)
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
                                    ? Path.Combine("DLC", EProjectFolders.Uncooked.ToString(), $"dlc{ActiveMod.Name}", relativePath)
                                    : Path.Combine("Mod", EProjectFolders.Uncooked.ToString(), relativePath));
                            }
                            // all other textures and collision stuff goes into Raw (since they have to be imported first)
                            else
                                newpath = Path.Combine(ActiveMod.RawDirectory, addAsDLC
                                    ? Path.Combine("DLC", $"dlc{ActiveMod.Name}", relativePath)
                                    : Path.Combine("Mod", relativePath));
                        }
                        break;
                    // some special cases
                    case EBundleType.SoundCache:
                    case EBundleType.Speech:
                    case EBundleType.Shader:
                        {
                            newpath = Path.Combine(ActiveMod.FileDirectory, addAsDLC
                                ? Path.Combine("DLC", archives.First().Value.Bundle.TypeName.ToString(), $"dlc{ActiveMod.Name}", relativePath)
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
            var exit = false;
            while (!File.Exists(MainController.Get().Configuration.ExecutablePath))
            {
                var sets = new frmSettings();
                if (sets.ShowDialog() != DialogResult.OK)
                {
                    exit = true;
                    break;
                }
                else
                    MainController.Get().ProjectStatus = EProjectStatus.Ready;
            }

            if (exit)
            {
                Visible = false;
                Close();
            }

            //Start loading if everything is set up.
            using (var frmload = new frmLoading())
            {
                var result = frmload.ShowDialog();
            }

            Logger = MainController.Get().Logger;
            Logger.PropertyChanged += LoggerUpdated;


            // Initialize DockPanel
            InitWindows();

            //Update check should be after we are all set up. It goes on in the background.
            AutoUpdater.Start("https://raw.githubusercontent.com/Traderain/Wolven-kit/master/Update.xml");
            richpresenceworker.RunWorkerAsync();

            if (MainController.Get().Configuration.IsWelcomeFormDisabled) return;
            if (!string.IsNullOrEmpty(MainController.Get().InitialFilePath))
            {
                ResetWindows();
                return;
            }

            using (var frmwelcome = new frmWelcome(this))
            {
                var result = frmwelcome.ShowDialog();
                switch (result)
                {
                    case DialogResult.Abort:
                        Close();
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

            SaveDockPanelLayout();
            ToolStripManager.SaveSettings(this);

            foreach (var dc in dockPanel.DocumentsToArray())
            {
                dc.DockHandler.DockPanel = null;
                dc.DockHandler.Close();
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            var config = UIController.Get().Configuration;
            Size = config.MainSize;
            Location = config.MainLocation;
            WindowState = config.MainState;

            if (!string.IsNullOrEmpty(MainController.Get().InitialModProject))
            {
                OpenMod(MainController.Get().InitialModProject);
            }
            else if (!string.IsNullOrEmpty(MainController.Get().InitialWKP))
            {
                using (var pi = new frmInstallPackage(MainController.Get().InitialWKP))
                    pi.ShowDialog();
            }
            else if (!string.IsNullOrEmpty(MainController.Get().InitialFilePath))
            {
                OpenCr2wFile(MainController.Get().InitialFilePath);
            }
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (sender is IWolvenkitView)
            {
                doc_Activated(sender, e);
            }
        }

        private void dockPanel_ActiveDocumentChanged(object sender, EventArgs e)
        {
            if (dockPanel.ActiveDocument is IWolvenkitView)
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
            if (sender is IWolvenkitView doc)
            {
                vm.ActiveDocument = doc.GetViewModel();
            }
        }

        private void doc_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sender is IWolvenkitView doc)
            {
                lastClosedTab.Enqueue(doc.FileName);
                vm.RemoveOpenDocument(doc.FileName);
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

            saveToolStripMenuItem.Enabled = vm.ActiveDocument != null;
            saveAllToolStripMenuItem.Enabled = vm.GetOpenDocuments().Count > 0;

            RepopulateRecentFiles();
        }

        private void RepopulateRecentFiles(string file = "")
        {
            #region Load recent files into toolstrip

            // Update the recent files.
            recentFilesToolStripMenuItem.DropDownItems.Clear();
            var files = new List<string>();
            if (File.Exists("recent_files.xml"))
            {
                var doc = XDocument.Load("recent_files.xml");
                int maxRecentFiles = 10;

                if (!string.IsNullOrEmpty(file))
                    files.Add(file);
                foreach (var f in doc.Descendants("recentfile"))
                {
                    maxRecentFiles--;
                    if (maxRecentFiles <= 0) break;
                    if (File.Exists(f.Value))
                    {
                        files.Add(f.Value);
                        recentFilesToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem(f.Value, null, RecentFile_click));
                    }
                }
                recentFilesToolStripMenuItem.Enabled = files.Any();
            }
            else
            {
                recentFilesToolStripMenuItem.Enabled = false;
            }
            new XDocument(new XElement("RecentFiles", files.Distinct().Select(x => new XElement("recentfile", x)))).Save("recent_files.xml");
            #endregion
        }


        private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            //verifyFileToolStripMenuItem.Enabled = ActiveMod != null;
            //renderW2meshToolStripMenuItem.Enabled = ActiveMod != null;
        }

        private void toolsToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            packageInstallerToolStripMenuItem.Enabled = ActiveMod != null;
            stringsEncoderGUIToolStripMenuItem.Enabled = ActiveMod != null;
            menuCreatorToolStripMenuItem.Enabled = ActiveMod != null;
            bulkEditorToolStripMenuItem.Enabled = ActiveMod != null;
            cR2WToTextToolStripMenuItem.Enabled = ActiveMod != null;
            experimentalToolStripMenuItem.Enabled = ActiveMod != null;
            
            //launchModkitToolStripMenuItem.Enabled = ActiveMod != null;
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
                OpenCr2wFile(dlg.FileName);
            }
        }

        private void OpenCr2wFile(string path)
        {
            MainController.Get().Configuration.InitialFileDirectory = Path.GetDirectoryName(path);
            LoadDocument(path);
        }

        private void RecentFile_click(object sender, EventArgs e)
        {
            if (File.Exists(sender.ToString()))
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
                            MainController.Get().ProjectStatus = EProjectStatus.Busy;

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

                            MainController.Get().ProjectStatus = EProjectStatus.Ready;
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
                            MainController.Get().ProjectStatus = EProjectStatus.Busy;

                            try
                            {
                                ConvertAnimation anim = new ConvertAnimation();
                                anim.Load(new List<string>() { of.FileName }, sf.FileName);
                            }
                            catch (Exception ex)
                            {
                                Logger.LogString(ex.ToString() + "\n", Logtype.Error);
                            }

                            MainController.Get().ProjectStatus = EProjectStatus.Ready;
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
            if (ActiveMod == null) return;
            //Close all docs so they won't cause problems
            if (!CloseAllDocuments()) return;

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
                            PauseMonitoring();
                            
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
                    ResumeMonitoring();
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
            if (StringsGui == null)
            {
                StringsGui = new frmStringsGui();
                StringsGui.ShowDialog();
            }
            else
                StringsGui.ShowDialog();
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

            // check path length
            if (MainController.Get().Configuration.DepotPath.Length > 38)
            {
                MainController.LogString("Wcc probably does not support path lengths > 255. " +
                                         "Please move your wcc_lite Modkit directory closer to root, e.g. C:\\Modkit\\.", Logtype.Error);
                return;
            }

            // check free space
            var freespace = drive.AvailableFreeSpace / (1024 * 1024 * 1024);
            var totalsize = drive.TotalSize / (1024 * 1024 * 1024);
            bool overwrite;
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
                        switch (MessageBox.Show(
                            $"Would you like to overwrite existing files in the depot directory?",
                            "Overwrite Files",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            default:
                                return;
                            case DialogResult.Yes:
                            {
                                overwrite = true;
                                break;
                            }
                            case DialogResult.No:
                            {
                                overwrite = false;
                                break;
                            }
                        }


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
                ProgressForm = new frmProgress()
                {
                    Text = "Unbundling Game Assets",
                    StartPosition = FormStartPosition.CenterParent,
                };

                // background worker action
                workerAction = UnbundleGame;
                MainBackgroundWorker.RunWorkerAsync(new UnbundleGameArgs(overwrite));

                // cancellation dialog
                DialogResult dr = ProgressForm.ShowDialog(this);
                switch (dr)
                {
                    case DialogResult.Cancel:
                        {
                            MainBackgroundWorker.CancelAsync();
                            ProgressForm.Cancel = true;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private object UnbundleGame(object sender, DoWorkEventArgs e)
        {
            object arg = e.Argument;
            if (!(arg is UnbundleGameArgs))
                throw new NotImplementedException();
            var Details = (UnbundleGameArgs)arg;

            BackgroundWorker bwAsync = sender as BackgroundWorker;

            //Load MemoryMapped Bundles
            var memorymappedbundles = new Dictionary<string, MemoryMappedFile>();
            var bm = new BundleManager();
            bm.LoadAll(Path.GetDirectoryName(MainController.Get().Configuration.ExecutablePath));

 
            foreach (var b in bm.Bundles.Values)
            {
                var hash = b.ArchiveAbsolutePath.GetHashMD5();
                memorymappedbundles.Add(hash, MemoryMappedFile.CreateFromFile(b.ArchiveAbsolutePath, FileMode.Open, hash, 0, MemoryMappedFileAccess.Read));
            }

            var files = bm.FileList
                    .GroupBy(p => p.Name)
                    .Select(g => g.Last())
                    .ToList();

            var orderedList = files.OrderBy(_ => _.Name.Length).ToList();

            int finishedcount = 0;
            var count = files.Count;
            Parallel.For(0, count, new ParallelOptions { MaxDegreeOfParallelism = (int)(Environment.ProcessorCount * 0.8) + 1 }, i =>
            {
                if (bwAsync.CancellationPending || ProgressForm.Cancel)
                {
                    MainController.LogString("Background worker cancelled.\r\n", Logtype.Error);
                    e.Cancel = true;
                    return;
                }

                IWitcherFile f = orderedList[i];
                if (f is BundleItem bi)
                {
                    var newpath = Path.Combine(MainController.Get().Configuration.DepotPath, bi.Name);


                    // overwrite existing files
                    if (File.Exists(newpath))
                    {
                        if (Details.Overwrite)
                        {
                            File.Delete(newpath);

                            var fi = new FileInfo(newpath);
                            var newdir = Path.GetDirectoryName(newpath);
                            Directory.CreateDirectory(newdir);

                            using (var ms = new MemoryStream())
                            using (FileStream file = new FileStream(newpath, FileMode.Create, System.IO.FileAccess.Write))
                            {
                                try
                                {
                                    bi.ExtractExistingMMF(ms);
                                }
                                catch (Exception ex)
                                {
                                    foreach (var val in memorymappedbundles.Values)
                                        MainController.LogString(val.GetHashCode().ToString());
                                    MainController.LogString(ex.Message);
                                }

                                ms.Seek(0, SeekOrigin.Begin);

                                ms.CopyTo(file);
                                Interlocked.Increment(ref finishedcount);
                            }
                        }
                        else
                        {
                            MainController.LogString("tabernak");
                            // do nothing
                        }
                    }
                    else
                    {
                        var fi = new FileInfo(newpath);
                        var newdir = Path.GetDirectoryName(newpath);
                        Directory.CreateDirectory(newdir);

                        using (var ms = new MemoryStream())
                        using (FileStream file = new FileStream(fi.FullName, FileMode.Create, System.IO.FileAccess.Write))
                        {
                            bi.ExtractExistingMMF(ms);
                            ms.Seek(0, SeekOrigin.Begin);

                            ms.CopyTo(file);
                        }
                        Interlocked.Increment(ref finishedcount);
                    }



                    int percentprogress = (int)((float)finishedcount / (float)count * 100.0);
                    MainBackgroundWorker.ReportProgress(percentprogress, bi.Name);
                }
            });
            
            foreach(var val in memorymappedbundles.Values)
            {
                val.Dispose();
            }

            MainController.LogString($"Sucessfully unbundled {finishedcount} files to {MainController.Get().Configuration.DepotPath}", Logtype.Success);
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
            var dlg = new OpenFileDialog
            {
                Title = "Open CR2W File", InitialDirectory = MainController.Get().Configuration.InitialFileDirectory
            };
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
            MainController.Get().ProjectStatus = EProjectStatus.Busy;
            vm.SaveAllFiles();
            MainController.Get().ProjectStatus = EProjectStatus.Ready;
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

        private void ModchunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCustomCr2wFile(false);
        }

        private void DLCChunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCustomCr2wFile(true);
        }

        private CR2WFile CreateCustomCr2wFile(bool isDlc)
        {
            // ask user for type
            List<string> availableTypes = CR2WManager.GetAvailableTypes("CResource").Select(_ => _.Name).ToList();
            if (availableTypes.Count <= 0) return null;
            // remove abstract classes

            availableTypes = availableTypes
                .Select(_ => $"{REDReflection.GetREDExtensionFromREDType(_)} ({_})")
                .Where(_ => _.Split(' ').First() != "")
                .ToList();

            string newChunktypename = "";
            var redextension = "";
            using (var form = new frmAddChunk(availableTypes))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    newChunktypename = form.ChunkType.Split(' ').Last().TrimStart("(").TrimEnd(')');
                    redextension = form.ChunkType.Split(' ').First();
                }
                else
                {
                    return null;
                }
            }

            if (string.IsNullOrEmpty(redextension)) return null;

            // create cr2wfile
            var cr2w = new CR2WFile();
            var obj = CR2WTypeManager.Create(newChunktypename, newChunktypename, cr2w, null);
            if (!(obj is CResource resource)) return null;
            cr2w.FromCResource(resource);

            // write cr2wfile
            var initialDir = isDlc
                ? ActiveMod.DlcUncookedDirectory
                : ActiveMod.ModUncookedDirectory;
            
            if (string.IsNullOrEmpty(redextension)) return null;

            var filepath = Path.Combine(initialDir, $"{newChunktypename}.{redextension}");
            var newfilepath = filepath;
            var dlg = new frmRenameDialog() { FileName = filepath };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                newfilepath = dlg.FileName;
            }


            // create directory
            newfilepath.EnsureFolderExists();
            using (var fs = new FileStream(newfilepath, FileMode.Create, FileAccess.ReadWrite))
            using (var writer = new BinaryWriter(fs))
            {
                cr2w.Write(writer);
                MainController.LogString($"Succesfully created file {newfilepath}.", Logtype.Success);
            }

            return cr2w;
        }

        private void sceneViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new CommonOpenFileDialog {Title = "Select file", Multiselect = false};
            dlg.Filters.Add(new CommonFileDialogFilter("Files", ".w2w,.w2l"));
            dlg.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                // parse the w2w and provide information to the scene
                Render.frmLevelScene sceneView = new Render.frmLevelScene(dlg.FileName, MainController.Get().Configuration.DepotPath, MainController.Get().TextureManager);
                sceneView.Show(this.dockPanel, DockState.Document);
            }
        }

        void toolStripDropDownButtonGit_Paint(object sender, PaintEventArgs e)
        {
            if (toolStripDropDownButtonGit.Pressed)
            {
                //e.Graphics.FillRectangle(Brushes.Transparent, e.ClipRectangle);
            }
        }

        private async void backupModProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // check if there is a mod project loaded
            if (ActiveMod == null)
            {
                MainController.LogString($"No mod project loaded.", Logtype.Error);
                return;
            }

            // check if git is in PATH
            var mpath = System.Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine);
            var upath = System.Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);
            if (mpath == null && upath == null) 
                return;
            
            if ((mpath != null && !mpath.Split(';').Any(_ => _.Contains("\\Git\\"))) 
                && ((upath != null && !upath.Split(';').Any(_ => _.Contains("\\Git\\")))))
            {
                switch (MessageBox.Show(
                    "Git was not found in your PATH environmental variables, it may not be installed on your machine. " +
                    "Please install git to use the backup feature for WolvenKit.",
                    "Git installation not found.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning))
                {
                    default: 
                        //break;
                        return;
                    //case DialogResult.Yes:
                    //{
                    //    break;
                    //}
                    //case DialogResult.No:
                    //{
                    //    break;
                    //}
                }
            }

            // check if git version errors
            var trygetgit = await ProcessHelper.RunCommandLineAsync(Logger, "", "git --version");
            if (trygetgit != 0)
            {
                MainController.LogString($"Git is not installed, or is installed improperly. Aborting.", Logtype.Error);
                return;
            }

            MainController.Get().ProjectStatus = EProjectStatus.Busy;
            MainController.Get().StatusProgress = 0;
            MainController.LogString($"Backing up mod project. Please wait...", Logtype.Important);

            // create git repo - rerunning git init is safe
            //MainController.LogString($"Running git init command...", Logtype.Important);
            string templatedir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new InvalidOperationException(), "Resources/GitTemplateDir");
            var resultInit = await GitHelper.InitRepository(Logger, ActiveMod.ProjectDirectory, templatedir, ActiveMod.Author, ActiveMod.Email);
            if (resultInit)
            {
                MainController.Get().StatusProgress = 25;
                //MainController.LogString($"Created git repository for project ({ActiveMod.Name}) at {ActiveMod.ProjectDirectory}.", Logtype.Success);
            }
            else
            {
                MainController.Get().ProjectStatus = EProjectStatus.Ready;
                MainController.Get().StatusProgress = 100;
                MainController.LogString($"Error creating git repository for project {ActiveMod.Name}.", Logtype.Error);
                return;
            }

            string sysFormat = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.Replace("/", "-");
            string commitMessage = ActiveMod.Name + "_" + DateTime.Now.ToString(sysFormat + "_HH-mm-ss");
            string archiveName = commitMessage + ".zip";
            string archivePath = Path.Combine(ActiveMod.BackupDirectory, archiveName);


            // commit new files
            MainController.LogString($"Running git commit command...", Logtype.Important);
            var resultCommit = await GitHelper.Commit(Logger, ActiveMod.ProjectDirectory, commitMessage);
            if (resultCommit)
            {
                MainController.Get().StatusProgress = 50;
                MainController.LogString($"Successfully commited git repo for project {ActiveMod.Name}.",
                    Logtype.Success);
            }
            else
            {
                MainController.Get().ProjectStatus = EProjectStatus.Ready;
                MainController.Get().StatusProgress = 100;
                MainController.LogString($"Git repo failed to commit for project {ActiveMod.Name}.", Logtype.Error);
                return;
            }

            // git archive zip to ./_backups
            MainController.LogString($"Running git archive command...", Logtype.Important);
            var resultArchive = await GitHelper.Archive(Logger, ActiveMod.ProjectDirectory, archivePath);
            if (resultArchive)
            {
                MainController.Get().StatusProgress = 100;
                MainController.Get().ProjectStatus = EProjectStatus.Ready;
                MainController.LogString($"Successfully created git archive for project ({ActiveMod.Name}) at {archivePath}.", Logtype.Success);
            }
            else
            {
                MainController.Get().StatusProgress = 100;
                MainController.Get().ProjectStatus = EProjectStatus.Ready;
                MainController.LogString($"Error creating git archive for project {ActiveMod.Name}.", Logtype.Error);
                return;
            }
        }

        private void openBackupFolderToolStripMenuItem_Click(object sender, EventArgs e) => Commonfunctions.ShowFolderInExplorer(ActiveMod.BackupDirectory);

        private void commandPromptHereToolStripMenuItem_Click(object sender, EventArgs e) => Commonfunctions.OpenConsoleAtPath(ActiveMod.ProjectDirectory);
    }
}
