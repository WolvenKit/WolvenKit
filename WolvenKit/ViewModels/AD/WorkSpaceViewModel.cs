using Catel.Services;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Catel.MVVM;
using Catel;
using Catel.IoC;
using Orc.ProjectManagement;
using WolvenKit.Views.Wizards;
using NativeMethods = WolvenKit.NativeWin.NativeMethods;

namespace WolvenKit.ViewModels
{
    using Model;
    using Commands;
    using Common.Services;
    using CR2W;
    using WolvenKit.Views;
    using WolvenKit.ViewModels.AssetBrowser;
    using WolvenKit.Views.AssetBrowser;
    using WolvenKit.ViewModels.CodeEditor;
    using WolvenKit.ViewModels.CsvEditor;
    using WolvenKit.ViewModels.HexEditor;
    using WolvenKit.ViewModels.AudioTool;
    using WolvenKit.ViewModels.VisualEditor;
    using WolvenKit.ViewModels.JournalEditor;
    using WolvenKit.ViewModels.WccTool;
    using WolvenKit.ViewModels.RadishTool;
    using WolvenKit.ViewModels.CR2WToTextTool;
    using WolvenKit.ViewModels.GameDebuggerTool;
    using WolvenKit.ViewModels.PluginManager;
    using WolvenKit.ViewModels.ImporterTool;
    using WolvenKit.ViewModels.Tools.MenuTool;

    /// <summary>
    /// The WorkSpaceViewModel implements AvalonDock demo specific properties, events and methods.
    /// </summary>
    public class WorkSpaceViewModel : ViewModelBase, IWorkSpaceViewModel
    {
        #region fields
        private readonly ObservableCollection<DocumentViewModel> _files = new ObservableCollection<DocumentViewModel>();
        private ToolViewModel[] _tools = null;

        private DocumentViewModel _activeDocument = null;

        private readonly IMessageService _messageService;
        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;

        private delegate void DocumentViewModelDelegate(DocumentViewModel value);

        private readonly DocumentViewModelDelegate addfiledel;
        #endregion fields

        #region constructors
        /// <summary>
        /// Class constructor
        /// </summary>
        public WorkSpaceViewModel(
            IProjectManager projectManager,
            ILoggerService loggerService,
            IMessageService messageService,
            ICommandManager commandManager
            )
        {
            #region dependency injection

            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => messageService);
            Argument.IsNotNull(() => commandManager);
            Argument.IsNotNull(() => loggerService);

            _projectManager = projectManager;
            _loggerService = loggerService;
            _messageService = messageService;

            #endregion

            #region commands

            ShowLogCommand = new RelayCommand(ExecuteShowLog, CanShowLog);
            ShowProjectExplorerCommand = new RelayCommand(ExecuteShowProjectExplorer, CanShowProjectExplorer);
            ShowImportUtilityCommand = new RelayCommand(ExecuteShowImportUtility, CanShowImportUtility);
            ShowPropertiesCommand = new RelayCommand(ExecuteShowProperties, CanShowProperties);
            ShowAssetsCommand = new RelayCommand(ExecuteAssetBrowser, CanShowAssetBrowser);
            ShowBulkEditorCommand = new RelayCommand(ExecuteBulkEditor, CanShowBulkEditor);
            ShowCsvEditorCommand = new RelayCommand(ExecuteCsvEditor, CanShowCsvEditor);
            ShowHexEditorCommand = new RelayCommand(ExecuteHexEditor, CanShowHexEditor);
            ShowJournalEditorCommand = new RelayCommand(ExecuteJournalEditor, CanShowJournalEditor);
            ShowVisualEditorCommand = new RelayCommand(ExecuteVisualEditor, CanShowVisualEditor);
          //  ShowAnimationToolCommand = new RelayCommand(ExecuteAnimationTool, CanShowAnimationTool);
            ShowAudioToolCommand = new RelayCommand(ExecuteAudioTool, CanShowAudioTool);
            ShowImporterToolCommand = new RelayCommand(ExecuteImporterTool, CanShowImporterTool);
            ShowCR2WToTextToolCommand = new RelayCommand(ExecuteCR2WToTextTool, CanShowCR2WToTextTool);
            ShowGameDebuggerToolCommand = new RelayCommand(ExecuteGameDebuggerTool, CanShowGameDebuggerTool);
            ShowMenuCreatorToolCommand = new RelayCommand(ExecuteMenuCreatorTool, CanShowMenuCreatorTool);
            ShowPluginManagerCommand = new RelayCommand(ExecutePluginManagerTool, CanShowPluginManagerTool);
            ShowRadishToolCommand = new RelayCommand(ExecuteRadishTool, CanShowRadishTool);
            ShowWccToolCommand = new RelayCommand(ExecuteWccTool, CanShowWccTool);

            ShowPackageInstallerCommand = new RelayCommand(ExecuteShowInstaller, CanShowInstaller);

            OpenFileCommand = new DelegateCommand<FileSystemInfoModel>(
                async (p) => await ExecuteOpenFile(p),
                (p) => CanOpenFile(p));
            NewFileCommand = new RelayCommand(ExecuteNewFile, CanNewFile);

            PackModCommand = new RelayCommand(ExecutePackMod, CanPackMod);
            BackupModCommand = new RelayCommand(ExecuteBackupMod, CanBackupMod);
            PublishModCommand = new RelayCommand(ExecutePublishMod, CanPublishMod);


            addfiledel = vm => _files.Add(vm);


            // register as application-wide commands
            RegisterCommands(commandManager);

            #endregion

            #region events



            #endregion

        }
        #endregion constructors

        #region init

        private void RegisterCommands(ICommandManager commandManager)
        {
            // View Tab
            commandManager.RegisterCommand(AppCommands.Application.ShowLog, ShowLogCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowProjectExplorer, ShowProjectExplorerCommand,
                this);

            commandManager.RegisterCommand(AppCommands.Application.ShowImportUtility, ShowImportUtilityCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowProperties, ShowPropertiesCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowAssetBrowser, ShowAssetsCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowBulkEditor, ShowBulkEditorCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowCsvEditor, ShowCsvEditorCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowHexEditor, ShowHexEditorCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowJournalEditor, ShowJournalEditorCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowVisualEditor, ShowVisualEditorCommand, this);
        //    commandManager.RegisterCommand(AppCommands.Application.ShowAnimationTool, ShowAnimationToolCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowAudioTool, ShowAudioToolCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowImporterTool, ShowImporterToolCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowCR2WToTextTool, ShowCR2WToTextToolCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowGameDebuggerTool, ShowGameDebuggerToolCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowMenuCreatorTool, ShowMenuCreatorToolCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowPluginManager, ShowPluginManagerCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowRadishTool, ShowRadishToolCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowWccTool, ShowWccToolCommand, this);




            // Home Tab
            commandManager.RegisterCommand(AppCommands.Application.OpenFile, OpenFileCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.NewFile, NewFileCommand, this);

            commandManager.RegisterCommand(AppCommands.Application.PackMod, PackModCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.BackupMod, BackupModCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.PublishMod, PublishModCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowPackageInstaller, ShowPackageInstallerCommand, this);



        }


        private void OnProjectExplorerOnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            // executes a global command that can be subscribed to from any viewmodel
            // passes the currently active viewmodel
            if (args.PropertyName == "IsActive" && sender is PaneViewModel panevm)
                ServiceLocator.Default.ResolveType<ICommandManager>()
                    .GetCommand(AppCommands.Application.ViewSelected)
                    .SafeExecute(new Tuple<PaneViewModel, bool>(panevm, panevm.IsActive));
        }

        protected override async Task InitializeAsync()
        {
            _projectManager.ProjectActivationAsync += OnProjectActivationAsync;

            await base.InitializeAsync();
        }

        protected override Task OnClosingAsync()
        {
            _projectManager.ProjectActivationAsync -= OnProjectActivationAsync;
            RaisePropertyChanged(nameof(SaveLayout));

            return base.OnClosingAsync();
        }

        protected override Task CloseAsync()
        {
            // TODO: Unsubscribe from events


            return base.CloseAsync();
        }
        #endregion

        #region commands
        /// <summary>
        /// Displays the Project Installer.
        /// </summary>
        public ICommand ShowPackageInstallerCommand { get; private set; }
        private bool CanShowInstaller() => true;
        private void ExecuteShowInstaller()
        {
            Views.Wizards.InstallerWizardView rpv = new Views.Wizards.InstallerWizardView();
            UserControlHostWindowViewModel zxc = new UserControlHostWindowViewModel(rpv);
            UserControlHostWindowView uchwv = new UserControlHostWindowView(zxc);
            uchwv.Show();
        }


        /// <summary>
        /// Displays the BulkEditor.
        /// </summary>
        public ICommand ShowBulkEditorCommand { get; private set; }
        private bool CanShowBulkEditor() => true;
        private void ExecuteBulkEditor() => BulkEditorVM.IsVisible = !BulkEditorVM.IsVisible;

        /// <summary>
        /// Displays the CsvEditor.
        /// </summary>
        public ICommand ShowCsvEditorCommand { get; private set; }
        private bool CanShowCsvEditor() => true;
        private void ExecuteCsvEditor() => CsvEditorVM.IsVisible = !CsvEditorVM.IsVisible;

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowHexEditorCommand { get; private set; }
        private bool CanShowHexEditor() => true;
        private void ExecuteHexEditor() => HexEditorVM.IsVisible = !HexEditorVM.IsVisible;

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowJournalEditorCommand { get; private set; }
        private bool CanShowJournalEditor() => true;
        private void ExecuteJournalEditor() => JournalEditorVM.IsVisible = !JournalEditorVM.IsVisible;

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowVisualEditorCommand { get; private set; }
        private bool CanShowVisualEditor() => true;
        private void ExecuteVisualEditor() => VisualEditorVM.IsVisible = !VisualEditorVM.IsVisible;

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
     //   public ICommand ShowAnimationToolCommand { get; private set; }
     //   private bool CanShowAnimationTool() => true;
      //  private void ExecuteAnimationTool() => AnimationTool.IsVisible = !AnimationTool.IsVisible;

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowAudioToolCommand { get; private set; }
        private bool CanShowAudioTool() => true;
        private void ExecuteAudioTool() => AudioToolVM.IsVisible = !AudioToolVM.IsVisible;

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowImporterToolCommand { get; private set; }
        private bool CanShowImporterTool() => true;
        private void ExecuteImporterTool() => ImporterToolVM.IsVisible = !ImporterToolVM.IsVisible;

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowCR2WToTextToolCommand { get; private set; }
        private bool CanShowCR2WToTextTool() => true;
        private void ExecuteCR2WToTextTool() => CR2WToTextToolVM.IsVisible = !CR2WToTextToolVM.IsVisible;

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowGameDebuggerToolCommand { get; private set; }
        private bool CanShowGameDebuggerTool() => true;
        private void ExecuteGameDebuggerTool() => GameDebuggerToolVM.IsVisible = !GameDebuggerToolVM.IsVisible;

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowMenuCreatorToolCommand { get; private set; }
        private bool CanShowMenuCreatorTool() => true;
        private void ExecuteMenuCreatorTool() => MenuCreatorToolVM.IsVisible = !MenuCreatorToolVM.IsVisible;

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowPluginManagerCommand { get; private set; }
        private bool CanShowPluginManagerTool() => true;
        private void ExecutePluginManagerTool() => PluginManagerVM.IsVisible = !PluginManagerVM.IsVisible;

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowRadishToolCommand { get; private set; }
        private bool CanShowRadishTool() => true;
        private void ExecuteRadishTool() => RadishToolVM.IsVisible = !RadishToolVM.IsVisible;

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowWccToolCommand { get; private set; }
        private bool CanShowWccTool() => true;
        private void ExecuteWccTool() => WccToolVM.IsVisible = !WccToolVM.IsVisible;






        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowAssetsCommand { get; private set; }
        private bool CanShowAssetBrowser() => true;
        private void ExecuteAssetBrowser() => AssetBrowserVM.IsVisible = !AssetBrowserVM.IsVisible;


        /// <summary>
        /// Displays the LogView.
        /// </summary>
        public ICommand ShowLogCommand { get; private set; }
        private bool CanShowLog() => true;
        private void ExecuteShowLog() => Log.IsVisible = !Log.IsVisible;

        /// <summary>
        /// Displays the Project Explorer View.
        /// </summary>
        public ICommand ShowProjectExplorerCommand { get; private set; }
        private bool CanShowProjectExplorer() => true;
        private void ExecuteShowProjectExplorer() => ProjectExplorer.IsVisible = !ProjectExplorer.IsVisible;

        /// <summary>
        /// Displays the Import Utility View
        /// </summary>
        public ICommand ShowImportUtilityCommand { get; private set; }
        private bool CanShowImportUtility() => true;
        private void ExecuteShowImportUtility() => ImportViewModel.IsVisible = !ImportViewModel.IsVisible;

        /// <summary>
        /// Displays the Properties View
        /// </summary>
        public ICommand ShowPropertiesCommand { get; private set; }
        private bool CanShowProperties() => true;
        private void ExecuteShowProperties() => PropertiesViewModel.IsVisible = !PropertiesViewModel.IsVisible;

        /// <summary>
        /// Opens a physical file in WolvenKit.
        /// </summary>
        public ICommand OpenFileCommand { get; private set; }
        private bool CanOpenFile(FileSystemInfoModel model) => true;
        private async Task ExecuteOpenFile(FileSystemInfoModel model)
        {
            if (model == null)
            {
                var dlg = new OpenFileDialog();
                if (dlg.ShowDialog().GetValueOrDefault())
                {
                    model = new FileSystemInfoModel(new FileInfo(dlg.FileName), null);
                    ActiveDocument = await OpenAsync(model);
                }
            }
            else
            {
                if (model.IsDirectory)
                    model.IsExpanded = !model.IsExpanded;
                else if (model.IsFile)
                {
                    // TODO: make this a background task
                    await RequestFileOpen(model);
                    //await Task.Run(() => RequestFileOpen(model));
                }
            }

        }



        /// <summary>
        /// Creates a new cr2w file in WolvenKit.
        /// </summary>
        public ICommand NewFileCommand { get; private set; }
        private bool CanNewFile() => true;
        private void ExecuteNewFile()
        {
            //TODO
        }

        /// <summary>
        /// Packs the current mod project.
        /// </summary>
        public ICommand PackModCommand { get; private set; }
        private bool CanPackMod() => _projectManager.ActiveProject is EditorProject proj;
        private void ExecutePackMod()
        {
            MainController.Get().GetGame().PackAndInstallProject();
        }

        /// <summary>
        /// Git-backup current mod project
        /// </summary>
        public ICommand BackupModCommand { get; private set; }
        private bool CanBackupMod() => _projectManager.ActiveProject is EditorProject;
        private void ExecuteBackupMod()
        {
            // TODO: Implement this
        }

        public ICommand PublishModCommand { get; private set; }
        private bool CanPublishMod() => _projectManager.ActiveProject is EditorProject;
        private void ExecutePublishMod()
        {
            try
            {
                var vm = new UserControlHostWindowViewModel(new PublishWizardView(), 600, 1200);

                ServiceLocator.Default.ResolveType<IUIVisualizerService>().ShowDialogAsync(vm);

            }
            catch (Exception ex)
            {
                _loggerService.LogString(ex.Message, Logtype.Error);
                _loggerService.LogString("Failed to publish project!", Logtype.Error);
            }
        }




        #endregion

        #region properties

        /// <summary>
        /// Event is raised when AvalonDock (or the user) selects a new document.
        /// </summary>
        public event EventHandler ActiveDocumentChanged;

        public EditorProject EditorProject { get; set; }

        public bool SaveLayout { get; set; }

        /// <summary>
        /// Gets/Sets the currently active document.
        /// </summary>
        public DocumentViewModel ActiveDocument
        {
            get => _activeDocument;
            set             // This can also be set by the user via the view
            {
                if (_activeDocument != value)
                {
                    _activeDocument = value;
                    RaisePropertyChanged(nameof(ActiveDocument));

                    ActiveDocumentChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Gets a collection of all currently available document viewmodels
        /// </summary>
        public IEnumerable<DocumentViewModel> Files => _files;

        /// <summary>
        /// Gets an enumeration of all currently available tool window viewmodels.
        /// </summary>
        public IEnumerable<ToolViewModel> Tools => _tools ??= new ToolViewModel[]
        {
                Log,
                ProjectExplorer,
                PropertiesViewModel,
                ImportViewModel,
                AssetBrowserVM,
            BulkEditorVM,
            CsvEditorVM,
            HexEditorVM,
            CodeEditorVM,
            JournalEditorVM,
             VisualEditorVM,
            // AnimationToolVM,
             AudioToolVM,
             ImporterToolVM,
             CR2WToTextToolVM,
             GameDebuggerToolVM,
             MenuCreatorToolVM,
             PluginManagerVM,
             RadishToolVM,
             WccToolVM,
        };

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private CodeEditorViewModel _CodeEditorVM = null;
        public CodeEditorViewModel CodeEditorVM
        {
            get
            {
                _CodeEditorVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<CodeEditorViewModel>();
                _CodeEditorVM.PropertyChanged += OnProjectExplorerOnPropertyChanged;
                return _CodeEditorVM;
            }
        }


        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private WolvenKit.ViewModels.BulkEditor.BulkEditorViewModel _BulkEditorVM = null;
        public BulkEditor.BulkEditorViewModel BulkEditorVM
        {
            get
            {
                _BulkEditorVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<BulkEditor.BulkEditorViewModel>();
                _BulkEditorVM.PropertyChanged += OnProjectExplorerOnPropertyChanged;
                return _BulkEditorVM;
            }
        }

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private CsvEditorViewModel _CsvEditorVM = null;
        public CsvEditorViewModel CsvEditorVM
        {
            get
            {
                _CsvEditorVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<CsvEditorViewModel>();
                _CsvEditorVM.PropertyChanged += OnProjectExplorerOnPropertyChanged;
                return _CsvEditorVM;
            }
        }

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private HexEditorViewModel _HexEditorVM = null;
        public HexEditorViewModel HexEditorVM
        {
            get
            {
                _HexEditorVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<HexEditorViewModel>();
                _HexEditorVM.PropertyChanged += OnProjectExplorerOnPropertyChanged;
                return _HexEditorVM;
            }
        }

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private AudioToolViewModel _AudioToolVM = null;
        public AudioToolViewModel AudioToolVM
        {
            get
            {
                _AudioToolVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<AudioToolViewModel>();
                _AudioToolVM.PropertyChanged += OnProjectExplorerOnPropertyChanged;
                return _AudioToolVM;
            }
        }

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private JournalEditorViewModel _JournalEditorVM = null;
        public JournalEditorViewModel JournalEditorVM
        {
            get
            {
                _JournalEditorVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<JournalEditorViewModel>();
                _JournalEditorVM.PropertyChanged += OnProjectExplorerOnPropertyChanged;
                return _JournalEditorVM;
            }
        }

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private VisualEditorViewModel _VisualEditorVM = null;
        public VisualEditorViewModel VisualEditorVM
        {
            get
            {
                _VisualEditorVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<VisualEditorViewModel>();
                _VisualEditorVM.PropertyChanged += OnProjectExplorerOnPropertyChanged;
                return _VisualEditorVM;
            }
        }

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        ///
        //private AnimationTool.AnimsViewModel _AnimationToolVM = null;
        //public ProjectExplorerViewModel AnimationToolVM
        //{
        //    get
        //    {
        //        _AnimationToolVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<ProjectExplorerViewModel>();
        //        _AnimationToolVM.PropertyChanged += OnProjectExplorerOnPropertyChanged;
        //        return _AnimationToolVM;
        //    }
        //}/// </summary>

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private ImporterToolViewModel _ImporterToolVM = null;
        public ImporterToolViewModel ImporterToolVM
        {
            get
            {
                _ImporterToolVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<ImporterToolViewModel>();
                _ImporterToolVM.PropertyChanged += OnProjectExplorerOnPropertyChanged;
                return _ImporterToolVM;
            }
        }

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private CR2WToTextToolViewModel _CR2WToTextToolVM = null;
        public CR2WToTextToolViewModel CR2WToTextToolVM
        {
            get
            {
                _CR2WToTextToolVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<CR2WToTextToolViewModel>();
                _CR2WToTextToolVM.PropertyChanged += OnProjectExplorerOnPropertyChanged;
                return _CR2WToTextToolVM;
            }
        }

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private GameDebuggerToolViewModel _GameDebuggerToolVM = null;
        public GameDebuggerToolViewModel GameDebuggerToolVM
        {
            get
            {
                _GameDebuggerToolVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<GameDebuggerToolViewModel>();
                _GameDebuggerToolVM.PropertyChanged += OnProjectExplorerOnPropertyChanged;
                return _GameDebuggerToolVM;
            }
        }

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private MenuCreatorToolViewModel _MenuCreatorToolVM = null;
        public MenuCreatorToolViewModel MenuCreatorToolVM
        {
            get
            {
                _MenuCreatorToolVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<MenuCreatorToolViewModel>();
                _MenuCreatorToolVM.PropertyChanged += OnProjectExplorerOnPropertyChanged;
                return _MenuCreatorToolVM;
            }
        }

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private PluginManagerViewModel _PluginManagerVM = null;
        public PluginManagerViewModel PluginManagerVM
        {
            get
            {
                _PluginManagerVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<PluginManagerViewModel>();
                _PluginManagerVM.PropertyChanged += OnProjectExplorerOnPropertyChanged;
                return _PluginManagerVM;
            }
        }

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private RadishToolViewModel _RadishToolVM = null;
        public RadishToolViewModel RadishToolVM
        {
            get
            {
                _RadishToolVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<RadishToolViewModel>();
                _RadishToolVM.PropertyChanged += OnProjectExplorerOnPropertyChanged;
                return _RadishToolVM;
            }
        }

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private WccToolViewModel _WccToolVM = null;
        public WccToolViewModel WccToolVM
        {
            get
            {
                _WccToolVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<WccToolViewModel>();
                _WccToolVM.PropertyChanged += OnProjectExplorerOnPropertyChanged;
                return _WccToolVM;
            }
        }




        /// <summary>
        /// Gets an instance of the LogViewModel.
        /// </summary>
        private LogViewModel _logViewModel = null;
        public LogViewModel Log => _logViewModel ??= new LogViewModel();

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private ProjectExplorerViewModel _projectExplorerViewModel = null;
        public ProjectExplorerViewModel ProjectExplorer
        {
            get
            {
                _projectExplorerViewModel ??= ServiceLocator.Default.RegisterTypeAndInstantiate<ProjectExplorerViewModel>();
                _projectExplorerViewModel.PropertyChanged += OnProjectExplorerOnPropertyChanged;
                return _projectExplorerViewModel;
            }
        }

        /// <summary>
        /// Gets an instance of the AssetBrowserViewModel.
        /// </summary>
        private AssetBrowserViewModel _AssetBrowserViewModel = null;
        public AssetBrowserViewModel AssetBrowserVM
        {
            get
            {

                _AssetBrowserViewModel ??= ServiceLocator.Default.RegisterTypeAndInstantiate<AssetBrowserViewModel>();
                //_AssetBrowserViewModel.PropertyChanged += OnProjectExplorerOnPropertyChanged;
                return _AssetBrowserViewModel;
            }
        }

        /// <summary>
        /// Gets an instance of the ImportViewModel.
        /// </summary>
        private ImportViewModel _importViewModel = null;
        public ImportViewModel ImportViewModel
        {
            get
            {
                _importViewModel ??= ServiceLocator.Default.RegisterTypeAndInstantiate<ImportViewModel>();
                return _importViewModel;
            }
        }

        /// <summary>
        /// Gets an instance of the PropertiesViewModel.
        /// </summary>
        private PropertiesViewModel _propertiesViewModel = null;
        public PropertiesViewModel PropertiesViewModel
        {
            get
            {
                _propertiesViewModel ??= ServiceLocator.Default.RegisterTypeAndInstantiate<PropertiesViewModel>();
                return _propertiesViewModel;
            }
        }





        #endregion Properties

        #region methods

        private async Task RequestFileOpen(FileSystemInfoModel model)
        {
            var fullpath = model.FullName;

            var ext = Path.GetExtension(fullpath).ToUpper();

            #region inspect on single click

            //// click
            //if (e.Inspect)
            //{
            //    switch (ext)
            //    {
            //        case ".CSV":
            //        case ".XML":
            //        case ".TXT":
            //        case ".BAT":
            //        case ".WS":
            //        case ".YML":
            //        case ".LOG":
            //        case ".INI":
            //            {
            //                var existing = TryOpenExisting(fullpath);
            //                if (existing == null)
            //                {
            //                    MockKernel.Get().ShowScriptPreview().LoadFile(fullpath);
            //                }
            //                break;
            //            }
            //        case ".PNG":
            //        case ".JPG":
            //        case ".TGA":
            //        case ".BMP":
            //        case ".JPEG":
            //        case ".DDS":
            //            {
            //                //TODO: unused
            //                //if (OpenImages.Any(_ => _.Text == Path.GetFileName(fullpath)))
            //                //{
            //                //    OpenImages.First(_ => _.Text == Path.GetFileName(fullpath)).Activate();
            //                //}
            //                //else
            //                {
            //                    MockKernel.Get().ShowImagePreview().SetImage(fullpath);
            //                }
            //                break;
            //            }
            //        default:
            //            break;
            //    }
            //    return;
            //}

            #endregion

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
                case ".BNK":
                case ".WEM":
                {
                    // TODO: port winforms
                    //using (var sp = new frmAudioPlayer(fullpath))
                    //{
                    //    sp.ShowDialog();
                    //}
                    break;
                }
                case ".SUBS":
                    PolymorphExecute(fullpath, ".txt");
                    break;
                case ".USM":
                {
                    // TODO: port winforms
                    //if (!File.Exists(fullpath) || Path.GetExtension(fullpath) != ".usm")
                    //    return;
                    //var usmplayer = new frmUsmPlayer(fullpath);
                    //usmplayer.Show(dockPanel, DockState.Document);
                    break;
                }

                default:
                    ActiveDocument = await OpenAsync(model);
                    break;
            }

            void ShellExecute(string path)
            {
                try
                {
                    var proc = new ProcessStartInfo(path) { UseShellExecute = true };
                    Process.Start(proc);
                }
                catch (Win32Exception)
                {
                    // eat this: no default app set for filetype
                    _loggerService.LogString($"No default prgram set in Windows to open file extension {Path.GetExtension(path)}", Logtype.Error);
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
        }

        private Task OnProjectActivationAsync(object sender, ProjectUpdatingCancelEventArgs e)
        {
            var newProject = (EditorProject)e.NewProject;
            if (newProject is not null)
                EditorProject = newProject;

            return Task.CompletedTask;
        }

        //
        // https://github.com/Dirkster99/AvalonDock/blob/5032524bae6e342dbb648a4c1d3fc3264f449db9/source/MLibTest/MLibTest/Demos/ViewModels/WorkSpaceViewModel.cs
        // 


        /// <summary>Closing all documents without user interaction to support reload of layout via menu.</summary>
        public void CloseAllDocuments()
        {
            ActiveDocument = null;
            _files.Clear();
        }

        /// <summary>
        /// Checks if a document can be closed and asks the user whether
        /// to save before closing if the document appears to be dirty.
        /// </summary>
        /// <param name="fileToClose"></param>
        public void Close(DocumentViewModel fileToClose)
        {
            if (fileToClose.IsDirty)
            {
                var res = MessageBox.Show($"Save changes for file '{fileToClose.FileName}'?", "AvalonDock Test App", MessageBoxButton.YesNoCancel);
                if (res == MessageBoxResult.Cancel)
                    return;

                if (res == MessageBoxResult.Yes)
                {
                    Save(fileToClose);
                }
            }

            _files.Remove(fileToClose);
        }

        /// <summary>
        /// Add a new document viewmodel into the collection of files.
        /// </summary>
        /// <param name="fileToAdd"></param>
        public void AddFile(DocumentViewModel fileToAdd)
        {
            if (fileToAdd == null)
                return;

            // Don't add this twice
            if (_files.Any(f => f.ContentId == fileToAdd.ContentId))
                return;

            _files.Add(fileToAdd);
        }

        /// <summary>
        /// Saves a document and resets the dirty flag.
        /// </summary>
        /// <param name="fileToSave"></param>
        /// <param name="saveAsFlag"></param>
        public void Save(DocumentViewModel fileToSave, bool saveAsFlag = false)
        {
            if (fileToSave.FilePath == null || saveAsFlag)
            {
                var dlg = new SaveFileDialog();
                if (dlg.ShowDialog().GetValueOrDefault())
                    fileToSave.FilePath = dlg.SafeFileName;
            }

            // TODO



            ActiveDocument.IsDirty = false;
        }



        /// <summary>
        /// Open a file and return its content in a viewmodel.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<DocumentViewModel> OpenAsync(FileSystemInfoModel model)
        {
            // Check if we have already loaded this file and return it if so
            var fileViewModel = _files.FirstOrDefault(fm => fm.ContentId == model.FullName);
            if (fileViewModel != null)
                return fileViewModel;

            // open file
            fileViewModel = new DocumentViewModel(this as IWorkSpaceViewModel, model, true);
            bool result = await fileViewModel.OpenFileAsync(model.FullName);

            if (result)
            {
                // TODO: this is not threadsafe
                _files.Add(fileViewModel);

                //Dispatcher.CurrentDispatcher.Invoke(new Action(() =>
                //{
                //    addfiledel(fileViewModel);
                //}), DispatcherPriority.ContextIdle);

                return fileViewModel;
            }

            return null;
        }

        #region NewCommand
        /// <summary>
        /// Determines if application can currently create a new document or not.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        private bool CanNew(object parameter) => true;

        private void OnNew(object parameter)
        {
            //TODO
            //string path = string.Format("Untitled{0}.txt", _newDocumentCounter++);

            //var newFile = new DocumentViewModel(this as IWorkSpaceViewModel, path, false);
            //_files.Add(newFile);
            //ActiveDocument = newFile;
        }

        #endregion
        #endregion methods
    }
}
