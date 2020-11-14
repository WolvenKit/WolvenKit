using System.Collections.Generic;
using WolvenKit.App.ViewModels;
using WolvenKit.Common;
using WolvenKit.App;
using WolvenKit.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WolvenKit
{
    /// <summary>
    /// View models
    /// </summary>
    public class MockKernel : ObservableObject
    {
        private static MockKernel kernel;
        private MockKernel() { }

        public static MockKernel Get()
        {
            if (kernel == null)
            {
                kernel = new MockKernel();
                kernel.Window = new frmMain();
            }
            return kernel;
        }

        // Singletons
        private ViewModel MainVM { get; set; }
        private ViewModel RadishVM { get; set; }
        private BulkEditorViewModel BulkEditVM { get; set; }
        private ModkitViewModel ModkitVM { get; set; }
        private ViewModel ImportVM { get; set; }
        private ViewModel ModExplorertVM { get; set; }

        // Forms
        public frmMain Window { get; private set; }
        public frmStringsGui StringsGui { get; set; }
        private frmConsole Console { get; set; }
        private frmOutput Output { get; set; }
        private frmModExplorer ModExplorer { get; set; }
        private frmImportUtility ImportUtility { get; set; }



        private frmWelcome Welcome { get; set; }
        private frmRadish RadishUtility { get; set; }
        
        private frmWcc FormModKit { get; set; }


        private frmScriptEditor ScriptPreview { get; set; }
        private frmImagePreview ImagePreview { get; set; }

        #region ViewModels
        public MainViewModel GetMainViewModel()
        {
            if ((MainViewModel)MainVM == null)
                MainVM = new MainViewModel(UIController.Get().WindowFactory);
            return (MainViewModel)MainVM;
        }

        public BulkEditorViewModel GetBulkEditorViewModel()
        {
            if ((BulkEditorViewModel)BulkEditVM == null)
                BulkEditVM = new BulkEditorViewModel(UIController.Get().WindowFactory, GetMainViewModel());
            return (BulkEditorViewModel)BulkEditVM;
        }

        public ModkitViewModel GetModkitViewModel()
        {
            if ((ModkitViewModel)ModkitVM == null)
                ModkitVM = new ModkitViewModel(UIController.Get().WindowFactory);
            return (ModkitViewModel)ModkitVM;
        }

        public RadishViewModel GetRadishViewModel()
        {
            if ((RadishViewModel)RadishVM == null)
                RadishVM = new RadishViewModel(UIController.Get().WindowFactory);
            return (RadishViewModel)RadishVM;
        }

        public ImportViewModel GetImportViewModel()
        {
            if ((ImportViewModel)ImportVM == null)
                ImportVM = new ImportViewModel(UIController.Get().WindowFactory);
            return (ImportViewModel)ImportVM;
        }

        public ModExplorerViewModel GetModExplorerModel()
        {
            if ((ModExplorerViewModel)ModExplorertVM == null)
                ModExplorertVM = new ModExplorerViewModel(UIController.Get().WindowFactory, GetMainViewModel());
            return (ModExplorerViewModel)ModExplorertVM;
        }

        private Dictionary<string, ViewModel> DocumentViewModels { get; set; } = new Dictionary<string, ViewModel>();
        #endregion

        private static DockPanel dockPanel => MockKernel.Get().Window.GetDockPanel();
        #region Forms
        public IDockContent GetContentFromPersistString(string persistString)
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
        /// <summary>
        /// Initializes all dockwindows
        /// </summary>
        public void InitWindows()
        {
            GetModExplorer();
            GetConsole();
            GetOutput();
            GetImportUtility();
        }
        public void ShowWindows()
        {
            ShowModExplorer();
            ShowConsole();
            ShowOutput();
            ShowImportUtility();
        }
        public void CloseMainWindows()
        {
            ModExplorer?.Close();
            ModExplorer = null;
            Output?.Close();
            Output = null;
            Console?.Close();
            Console = null;
            if (Welcome != null)
            {
                Welcome?.Close();
                Welcome = new frmWelcome(Window);
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
        }


        public void ShowConsole()
        {
            if (Console == null || Console.IsDisposed)
            {
                GetConsole();
                Console.Show(MockKernel.Get().Window.GetDockPanel(), WeifenLuo.WinFormsUI.Docking.DockState.DockBottom);
            }

            Console.Activate();
        }
        public void ShowOutput()
        {
            if (Output == null || Output.IsDisposed)
            {
                GetOutput();
                Output.Show(MockKernel.Get().Window.GetDockPanel(), WeifenLuo.WinFormsUI.Docking.DockState.DockBottom);
            }

            Output.Activate();
        }
        public void ShowModExplorer()
        {
            if (ModExplorer == null || ModExplorer.IsDisposed)
            {
                GetModExplorer();
                ModExplorer.Show(dockPanel, DockState.DockLeft);

            }
            ModExplorer.Activate();

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
        public void ShowModKit()
        {
            if (FormModKit == null || FormModKit.IsDisposed)
            {
                FormModKit = new frmWcc();
                FormModKit.Show(dockPanel, DockState.Document);
            }

            FormModKit.Activate();
        }
        public void ShowImportUtility()
        {
            if (ImportUtility == null || ImportUtility.IsDisposed)
            {
                ImportUtility = new frmImportUtility();
                ImportUtility.Show(dockPanel, DockState.DockRight);
            }

            ImportUtility.Activate();
        }
        public void ShowRadishUtility()
        {
            if (MainController.Get().ActiveMod == null)
            {
                MessageBox.Show(@"Please create a new mod project."
                    , "Missing Mod Project"
                    , System.Windows.Forms.MessageBoxButtons.OK
                    , System.Windows.Forms.MessageBoxIcon.Information);
                return;
            }
            var filedir = new DirectoryInfo(MainController.Get().ActiveMod.FileDirectory);
            var radishdir = filedir.GetFiles("*.bat", SearchOption.AllDirectories)?.FirstOrDefault(_ => _.Name == "_settings_.bat")?.Directory;
            if (radishdir == null)
            {
                MainController.LogString("ERROR! No radish mod directory found.\r\n", WolvenKit.Common.Services.Logtype.Error);
                return;
            }

            if (RadishUtility == null || RadishUtility.IsDisposed)
            {
                RadishUtility = new frmRadish();
                RadishUtility.Show(dockPanel, DockState.Document);
            }

            RadishUtility.Activate();
        }
        public frmImagePreview ShowImagePreview()
        {
            if (ImagePreview == null || ImagePreview.IsDisposed)
            {
                ImagePreview = new frmImagePreview();
                ImagePreview.Show(dockPanel, DockState.Document);
            }
            ImagePreview.Activate();
            return ImagePreview;
        }
        public frmScriptEditor ShowScriptPreview()
        {
            if (ScriptPreview == null || ScriptPreview.IsDisposed)
            {
                ScriptPreview = new frmScriptEditor(new ScriptDocumentViewModel(UIController.Get().WindowFactory));
                ScriptPreview.Show(dockPanel, DockState.Document);
            }

            ScriptPreview.Activate();
            return ScriptPreview;
        }

        private IDockContent GetImportUtility()
        {
            if (ImportUtility == null || ImportUtility.IsDisposed)
                ImportUtility = new frmImportUtility();
            return ImportUtility;
        }
        private IDockContent GetWelcome()
        {
            if (Welcome == null || Welcome.IsDisposed)
                Welcome = new frmWelcome(Window);
            return Welcome;
        }
        public IDockContent GetModExplorer()
        {
            if (ModExplorer == null || ModExplorer.IsDisposed)
                ModExplorer = new frmModExplorer();

            ModExplorer.RequestAssetBrowser += Window.ModExplorer_RequestAssetBrowser;
            ModExplorer.RequestFileOpen += Window.ModExplorer_RequestFileOpen;
            ModExplorer.RequestFileRename += Window.ModExplorer_RequestFileRename;
            ModExplorer.RequestFileDelete += Window.ModExplorer_RequestFileDelete;
            ModExplorer.RequestFastRender += Window.ModExplorer_RequestFastRender;

            return ModExplorer;
        }
        private IDockContent GetConsole()
        {
            if (Console == null || Console.IsDisposed)
                Console = new frmConsole();
            return Console;
        }
        public IDockContent GetOutput()
        {
            if (Output == null || Output.IsDisposed)
                Output = new frmOutput();
            return Output;
        }

        #endregion



    }
}
