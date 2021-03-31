using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Catel;
using Catel.IoC;
using Catel.Messaging;
using Catel.MVVM;
using Catel.Services;
using Microsoft.Win32;
using Orc.ProjectManagement;
using WolvenKit.Common.Services;
using WolvenKit.CR2W;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.Models;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.ViewModels.Editor;
using NativeMethods = WolvenKit.Functionality.NativeWin.NativeMethods;

namespace WolvenKit.ViewModels.Shell
{
    /// <summary>
    /// The WorkSpaceViewModel implements AvalonDock demo specific properties, events and methods.
    /// </summary>
    public class WorkSpaceViewModel : ViewModelBase, IWorkSpaceViewModel
    {
        #region fields

        private readonly ObservableCollection<DocumentViewModel> _files = new();

        private readonly ILoggerService _loggerService;
        private readonly IMessageService _messageService;
        private readonly IProjectManager _projectManager;
        private readonly DocumentViewModelDelegate addfiledel;
        private DocumentViewModel _activeDocument = null;

        private delegate void DocumentViewModelDelegate(DocumentViewModel value);

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

            #endregion dependency injection

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
            ShowAnimationToolCommand = new RelayCommand(ExecuteAnimationTool, CanShowAnimationTool);
            ShowMimicsToolCommand = new RelayCommand(ExecuteMimicsTool, CanShowMimicsTool);
            ShowAudioToolCommand = new RelayCommand(ExecuteAudioTool, CanShowAudioTool);
            ShowVideoToolCommand = new RelayCommand(ExecuteVideoTool, CanShowVideoTool);

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

            SaveFileFileCommand = new RelayCommand(ExecuteSaveFile, CanSaveFile);
            SaveAllCommand = new RelayCommand(ExecuteSaveAll, CanSaveAll);

            addfiledel = vm => _files.Add(vm);

            // register as application-wide commands
            RegisterCommands(commandManager);

            #endregion commands

            Tools = new ObservableCollection<ToolViewModel> {
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
                AnimationToolVM,
                AudioToolVM,
                ImporterToolVM,
                CR2WToTextToolVM,
                GameDebuggerToolVM,
                MenuCreatorToolVM,
                PluginManagerVM,
                RadishToolVM,
                WccToolVM,
                MimicsToolVM,
            };
        }

        #endregion constructors

        #region init

        protected override async Task InitializeAsync()
        {
            _projectManager.ProjectActivationAsync += OnProjectActivationAsync;

            await base.InitializeAsync();
        }

        protected override Task OnClosingAsync()
        {
            _projectManager.ProjectActivationAsync -= OnProjectActivationAsync;

            return base.OnClosingAsync();
        }

        private static void OnToolViewModelPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            // executes a global command that can be subscribed to from any viewmodel
            // passes the currently active viewmodel
            if (args.PropertyName == "IsActive" && sender is PaneViewModel panevm)
            {
                ServiceLocator.Default.ResolveType<ICommandManager>()
                    .GetCommand(AppCommands.Application.ViewSelected)
                    .SafeExecute(new Tuple<PaneViewModel, bool>(panevm, panevm.IsActive));
            }
        }

        private void RegisterCommands(ICommandManager commandManager)
        {
            // View Tab
            commandManager.RegisterCommand(AppCommands.Application.ShowLog, ShowLogCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowProjectExplorer, ShowProjectExplorerCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowImportUtility, ShowImportUtilityCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowProperties, ShowPropertiesCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowAssetBrowser, ShowAssetsCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowBulkEditor, ShowBulkEditorCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowCsvEditor, ShowCsvEditorCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowHexEditor, ShowHexEditorCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowJournalEditor, ShowJournalEditorCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowVisualEditor, ShowVisualEditorCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowAnimationTool, ShowAnimationToolCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowMimicsTool, ShowMimicsToolCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowAudioTool, ShowAudioToolCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowVideoTool, ShowVideoToolCommand, this);

            commandManager.RegisterCommand(AppCommands.Application.ShowImporterTool, ShowImporterToolCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowCR2WToTextTool, ShowCR2WToTextToolCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowGameDebuggerTool, ShowGameDebuggerToolCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowMenuCreatorTool, ShowMenuCreatorToolCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowPluginManager, ShowPluginManagerCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowRadishTool, ShowRadishToolCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowWccTool, ShowWccToolCommand, this);

            // Home Tab
            commandManager.RegisterCommand(AppCommands.Application.SaveFile, SaveFileFileCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.SaveAll, SaveAllCommand, this);

            commandManager.RegisterCommand(AppCommands.Application.OpenFile, OpenFileCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.NewFile, NewFileCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.PackMod, PackModCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.BackupMod, BackupModCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.PublishMod, PublishModCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowPackageInstaller, ShowPackageInstallerCommand, this);
        }

        #endregion init

        #region commands

        /// <summary>
        /// Saves the active Documents
        /// </summary>
        public ICommand SaveFileFileCommand { get; private set; }

        /// <summary>
        /// Saves all open Documents
        /// </summary>
        public ICommand SaveAllCommand { get; private set; }

        /// <summary>
        /// Git-backup current mod project
        /// </summary>
        public ICommand BackupModCommand { get; private set; }

        /// <summary>
        /// Creates a new cr2w file in WolvenKit.
        /// </summary>
        public ICommand NewFileCommand { get; private set; }

        /// <summary>
        /// Opens a physical file in WolvenKit.
        /// </summary>
        public ICommand OpenFileCommand { get; private set; }

        /// <summary>
        /// Packs the current mod project.
        /// </summary>
        public ICommand PackModCommand { get; private set; }

        /// <summary>
        /// ???
        /// </summary>
        public ICommand PublishModCommand { get; private set; }

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowAnimationToolCommand { get; private set; }

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowAssetsCommand { get; private set; }

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowAudioToolCommand { get; private set; }
        public ICommand ShowVideoToolCommand { get; private set; }


        /// <summary>
        /// Displays the BulkEditor.
        /// </summary>
        public ICommand ShowBulkEditorCommand { get; private set; }

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowCR2WToTextToolCommand { get; private set; }

        /// <summary>
        /// Displays the CsvEditor.
        /// </summary>
        public ICommand ShowCsvEditorCommand { get; private set; }

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowGameDebuggerToolCommand { get; private set; }

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowHexEditorCommand { get; private set; }

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowImporterToolCommand { get; private set; }

        /// <summary>
        /// Displays the Import Utility View
        /// </summary>
        public ICommand ShowImportUtilityCommand { get; private set; }

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowJournalEditorCommand { get; private set; }

        /// <summary>
        /// Displays the LogView.
        /// </summary>
        public ICommand ShowLogCommand { get; private set; }

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowMenuCreatorToolCommand { get; private set; }

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowMimicsToolCommand { get; private set; }

        /// <summary>
        /// Displays the Project Installer.
        /// </summary>
        public ICommand ShowPackageInstallerCommand { get; private set; }

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowPluginManagerCommand { get; private set; }

        /// <summary>
        /// Displays the Project Explorer View.
        /// </summary>
        public ICommand ShowProjectExplorerCommand { get; private set; }

        /// <summary>
        /// Displays the Properties View
        /// </summary>
        public ICommand ShowPropertiesCommand { get; private set; }

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowRadishToolCommand { get; private set; }

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowVisualEditorCommand { get; private set; }

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowWccToolCommand { get; private set; }

        #endregion

        #region command implementation

        public void ExecuteAudioTool() => AudioToolVM.IsVisible = !AudioToolVM.IsVisible;

        public void ExecuteVideoTool()
        {
            var mediator = ServiceLocator.Default.ResolveType<IMessageMediator>();
            mediator.SendMessage<bool>(true);
        }


        private static void ExecutePackMod() => MainController.GetGame().PackAndInstallProject();

        private bool CanBackupMod() => _projectManager.ActiveProject is EditorProject;

        private bool CanNewFile() => true;

        private bool CanOpenFile(FileSystemInfoModel model) => true;

        private bool CanPackMod() => _projectManager.ActiveProject is EditorProject proj;

        private bool CanPublishMod() => _projectManager.ActiveProject is EditorProject;

        private bool CanShowAnimationTool() => false;

        private bool CanShowAssetBrowser() => AssetBrowserVM != null && AssetBrowserVM.IsLoaded;

        private bool CanShowAudioTool() => _projectManager.ActiveProject is EditorProject;
        private bool CanShowVideoTool() => _projectManager.ActiveProject is EditorProject;


        private bool CanShowBulkEditor() => false;

        private bool CanShowCR2WToTextTool() => false;

        private bool CanShowCsvEditor() => _projectManager.ActiveProject is EditorProject;

        private bool CanShowGameDebuggerTool() => false;

        private bool CanShowHexEditor() => false;

        private bool CanShowImporterTool() => false;

        private bool CanShowImportUtility() => _projectManager.ActiveProject is EditorProject;

        private bool CanShowInstaller() => false;

        private bool CanShowJournalEditor() => false;

        private bool CanShowLog() => _projectManager.ActiveProject is EditorProject;

        private bool CanShowMenuCreatorTool() => false;

        private bool CanShowMimicsTool() => false;

        private bool CanShowPluginManagerTool() => false;

        private bool CanShowProjectExplorer() => _projectManager.ActiveProject is EditorProject;

        private bool CanShowProperties() => _projectManager.ActiveProject is EditorProject;

        private bool CanShowRadishTool() => false;

        private bool CanShowVisualEditor() => false;

        private bool CanShowWccTool() => false;

        private void ExecuteAnimationTool() => AnimationToolVM.IsVisible = false;

        private void ExecuteAssetBrowser() => AssetBrowserVM.IsVisible = !AssetBrowserVM.IsVisible;

        private void ExecuteBackupMod()
        {
            // TODO: Implement this
        }

        private void ExecuteBulkEditor() => BulkEditorVM.IsVisible = false;

        private void ExecuteCR2WToTextTool() => CR2WToTextToolVM.IsVisible = false;

        private void ExecuteCsvEditor() => CsvEditorVM.IsVisible = !CsvEditorVM.IsVisible;

        private void ExecuteGameDebuggerTool() => GameDebuggerToolVM.IsVisible = false;

        private void ExecuteHexEditor() => HexEditorVM.IsVisible = false;

        private void ExecuteImporterTool() => ImporterToolVM.IsVisible = false;

        private void ExecuteJournalEditor() => JournalEditorVM.IsVisible = false;

        private void ExecuteMenuCreatorTool() => MenuCreatorToolVM.IsVisible = false;

        private void ExecuteMimicsTool() => MimicsToolVM.IsVisible = false;

        private void ExecuteNewFile()
        {
            //TODO
        }

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
                {
                    model.IsExpanded = !model.IsExpanded;
                }
                else if (model.IsFile)
                {
                    // TODO: make this a background task
                    await RequestFileOpen(model);
                    //await Task.Run(() => RequestFileOpen(model));
                }
            }
        }

        private void ExecutePluginManagerTool() => PluginManagerVM.IsVisible = !PluginManagerVM.IsVisible;

        private void ExecutePublishMod()
        {                // #convert2MVVMSoon
            //  try
            //  {
            //      var vm = new UserControlHostWindowViewModel(new PublishWizardView(), 600, 1200);

            //      ServiceLocator.Default.ResolveType<IUIVisualizerService>().ShowDialogAsync(vm);
            // }
            //  catch (Exception ex)
            // {
            //      _loggerService.LogString(ex.Message, Logtype.Error);
            //     _loggerService.LogString("Failed to publish project!", Logtype.Error);
            //  }
        }

        private void ExecuteRadishTool() => RadishToolVM.IsVisible = !RadishToolVM.IsVisible;

        private void ExecuteShowImportUtility() => ImportViewModel.IsVisible = !ImportViewModel.IsVisible;

        private void ExecuteShowInstaller()
        {                // #convert2MVVMSoon
            //  var rpv = new InstallerWizardView();
            //  var zxc = new UserControlHostWindowViewModel(rpv);
            //  var uchwv = new UserControlHostWindowView(zxc);
            //  uchwv.Show();
        }

        private void ExecuteShowLog() => Log.IsVisible = !Log.IsVisible;

        private void ExecuteShowProjectExplorer() => ProjectExplorer.IsVisible = !ProjectExplorer.IsVisible;

        private void ExecuteShowProperties() => PropertiesViewModel.IsVisible = !PropertiesViewModel.IsVisible;

        private void ExecuteVisualEditor() => VisualEditorVM.IsVisible = !VisualEditorVM.IsVisible;

        private void ExecuteWccTool() => WccToolVM.IsVisible = !WccToolVM.IsVisible;

        private bool CanSaveAll() => _projectManager.ActiveProject is EditorProject proj
                                     && Files?.Count > 0;
        private void ExecuteSaveAll()
        {
            foreach (var file in Files)
            {
                Save(file);
            }
        }

        private bool CanSaveFile() => _projectManager.ActiveProject is EditorProject proj
                                      && ActiveDocument != null;
        private void ExecuteSaveFile() => Save(ActiveDocument);

        #endregion commands

        #region properties

        #region ToolViewModels

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private AnimsViewModel _AnimationToolVM = null;

        /// <summary>
        /// Gets an instance of the AssetBrowserViewModel.
        /// </summary>
        private AssetBrowserViewModel _AssetBrowserViewModel = null;

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private AudioToolViewModel _AudioToolVM = null;

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private BulkEditorViewModel _BulkEditorVM = null;

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private CodeEditorViewModel _CodeEditorVM = null;

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private CR2WToTextToolViewModel _CR2WToTextToolVM = null;

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private CsvEditorViewModel _CsvEditorVM = null;

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private GameDebuggerToolViewModel _GameDebuggerToolVM = null;

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private HexEditorViewModel _HexEditorVM = null;

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private ImporterToolViewModel _ImporterToolVM = null;

        /// <summary>
        /// Gets an instance of the ImportViewModel.
        /// </summary>
        private ImportViewModel _importViewModel = null;

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private JournalEditorViewModel _JournalEditorVM = null;

        /// <summary>
        /// Gets an instance of the LogViewModel.
        /// </summary>
        private LogViewModel _logViewModel = null;

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private MenuCreatorToolViewModel _MenuCreatorToolVM = null;

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        ///
        private MimicsViewModel _MimicsToolVM = null;

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private PluginManagerViewModel _PluginManagerVM = null;

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private ProjectExplorerViewModel _projectExplorerViewModel = null;

        /// <summary>
        /// Gets an instance of the PropertiesViewModel.
        /// </summary>
        private PropertiesViewModel _propertiesViewModel = null;

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private RadishToolViewModel _RadishToolVM = null;

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private VisualEditorViewModel _VisualEditorVM = null;

        /// <summary>
        /// Gets an instance of the ProjectExplorerViewModer.
        /// </summary>
        private WccToolViewModel _WccToolVM = null;

        public AnimsViewModel AnimationToolVM
        {
            get
            {
                _AnimationToolVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<AnimsViewModel>();
                _AnimationToolVM.PropertyChanged += OnToolViewModelPropertyChanged;
                return _AnimationToolVM;
            }
        }

        public AssetBrowserViewModel AssetBrowserVM
        {
            get
            {
                _AssetBrowserViewModel ??= ServiceLocator.Default.RegisterTypeAndInstantiate<AssetBrowserViewModel>();
                _AssetBrowserViewModel.PropertyChanged += OnToolViewModelPropertyChanged;
                return _AssetBrowserViewModel;
            }
        }

        public AudioToolViewModel AudioToolVM
        {
            get
            {
                _AudioToolVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<AudioToolViewModel>();
                _AudioToolVM.PropertyChanged += OnToolViewModelPropertyChanged;
                return _AudioToolVM;
            }
        }

        public BulkEditorViewModel BulkEditorVM
        {
            get
            {
                _BulkEditorVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<BulkEditorViewModel>();
                _BulkEditorVM.PropertyChanged += OnToolViewModelPropertyChanged;
                return _BulkEditorVM;
            }
        }

        public CodeEditorViewModel CodeEditorVM
        {
            get
            {
                _CodeEditorVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<CodeEditorViewModel>();
                _CodeEditorVM.PropertyChanged += OnToolViewModelPropertyChanged;
                return _CodeEditorVM;
            }
        }

        public CR2WToTextToolViewModel CR2WToTextToolVM
        {
            get
            {
                _CR2WToTextToolVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<CR2WToTextToolViewModel>();
                _CR2WToTextToolVM.PropertyChanged += OnToolViewModelPropertyChanged;
                return _CR2WToTextToolVM;
            }
        }

        public CsvEditorViewModel CsvEditorVM
        {
            get
            {
                _CsvEditorVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<CsvEditorViewModel>();
                _CsvEditorVM.PropertyChanged += OnToolViewModelPropertyChanged;
                return _CsvEditorVM;
            }
        }

        public GameDebuggerToolViewModel GameDebuggerToolVM
        {
            get
            {
                _GameDebuggerToolVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<GameDebuggerToolViewModel>();
                _GameDebuggerToolVM.PropertyChanged += OnToolViewModelPropertyChanged;
                return _GameDebuggerToolVM;
            }
        }

        public HexEditorViewModel HexEditorVM
        {
            get
            {
                _HexEditorVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<HexEditorViewModel>();
                _HexEditorVM.PropertyChanged += OnToolViewModelPropertyChanged;
                return _HexEditorVM;
            }
        }

        /// </summary>
        public ImporterToolViewModel ImporterToolVM
        {
            get
            {
                _ImporterToolVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<ImporterToolViewModel>();
                _ImporterToolVM.PropertyChanged += OnToolViewModelPropertyChanged;
                return _ImporterToolVM;
            }
        }

        public ImportViewModel ImportViewModel
        {
            get
            {
                _importViewModel ??= ServiceLocator.Default.RegisterTypeAndInstantiate<ImportViewModel>();
                return _importViewModel;
            }
        }

        public JournalEditorViewModel JournalEditorVM
        {
            get
            {
                _JournalEditorVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<JournalEditorViewModel>();
                _JournalEditorVM.PropertyChanged += OnToolViewModelPropertyChanged;
                return _JournalEditorVM;
            }
        }

        public LogViewModel Log => _logViewModel ??= new LogViewModel();

        public MenuCreatorToolViewModel MenuCreatorToolVM
        {
            get
            {
                _MenuCreatorToolVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<MenuCreatorToolViewModel>();
                _MenuCreatorToolVM.PropertyChanged += OnToolViewModelPropertyChanged;
                return _MenuCreatorToolVM;
            }
        }

        public MimicsViewModel MimicsToolVM
        {
            get
            {
                _MimicsToolVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<MimicsViewModel>();
                _MimicsToolVM.PropertyChanged += OnToolViewModelPropertyChanged;
                return _MimicsToolVM;
            }
        }

        public PluginManagerViewModel PluginManagerVM
        {
            get
            {
                _PluginManagerVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<PluginManagerViewModel>();
                _PluginManagerVM.PropertyChanged += OnToolViewModelPropertyChanged;
                return _PluginManagerVM;
            }
        }

        public ProjectExplorerViewModel ProjectExplorer
        {
            get
            {
                _projectExplorerViewModel ??= ServiceLocator.Default.RegisterTypeAndInstantiate<ProjectExplorerViewModel>();
                _projectExplorerViewModel.PropertyChanged += OnToolViewModelPropertyChanged;
                return _projectExplorerViewModel;
            }
        }

        public PropertiesViewModel PropertiesViewModel
        {
            get
            {
                _propertiesViewModel ??= ServiceLocator.Default.RegisterTypeAndInstantiate<PropertiesViewModel>();
                return _propertiesViewModel;
            }
        }

        public RadishToolViewModel RadishToolVM
        {
            get
            {
                _RadishToolVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<RadishToolViewModel>();
                _RadishToolVM.PropertyChanged += OnToolViewModelPropertyChanged;
                return _RadishToolVM;
            }
        }

        public VisualEditorViewModel VisualEditorVM
        {
            get
            {
                _VisualEditorVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<VisualEditorViewModel>();
                _VisualEditorVM.PropertyChanged += OnToolViewModelPropertyChanged;
                return _VisualEditorVM;
            }
        }

        public WccToolViewModel WccToolVM
        {
            get
            {
                _WccToolVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<WccToolViewModel>();
                _WccToolVM.PropertyChanged += OnToolViewModelPropertyChanged;
                return _WccToolVM;
            }
        }
        #endregion

        /// <summary>
        /// Event is raised when AvalonDock (or the user) selects a new document.
        /// </summary>
        public event EventHandler ActiveDocumentChanged;

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
        public ObservableCollection<DocumentViewModel> Files => _files;

        public EditorProject EditorProject { get; set; }


        /// <summary>
        /// Gets an enumeration of all currently available tool window viewmodels.
        /// </summary>
        public ObservableCollection<ToolViewModel> Tools { get; set; }

        #endregion properties

        #region methods

        /// <summary>
        /// Add a new document viewmodel into the collection of files.
        /// </summary>
        /// <param name="fileToAdd"></param>
        public void AddFile(DocumentViewModel fileToAdd)
        {
            if (fileToAdd == null)
            {
                return;
            }

            // Don't add this twice
            if (_files.Any(f => f.ContentId == fileToAdd.ContentId))
            {
                return;
            }

            _files.Add(fileToAdd);
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
                {
                    return;
                }

                if (res == MessageBoxResult.Yes)
                {
                    Save(fileToClose);
                }
            }

            _files.Remove(fileToClose);
        }

        /// <summary>Closing all documents without user interaction to support reload of layout via menu.</summary>
        public void CloseAllDocuments()
        {
            ActiveDocument = null;
            _files.Clear();
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
            {
                return fileViewModel;
            }

            // open file
            fileViewModel = new DocumentViewModel(this as IWorkSpaceViewModel, model, true);
            var result = await fileViewModel.OpenFileAsync(model.FullName);

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

        /// <summary>
        /// Saves a document and resets the dirty flag.
        /// </summary>
        /// <param name="fileToSave"></param>
        /// <param name="saveAsFlag"></param>
        public void Save(DocumentViewModel fileToSave, bool saveAsFlag = false)
        {
            // remove this?
            if (fileToSave.FilePath == null || saveAsFlag)
            {
                var dlg = new SaveFileDialog();
                if (dlg.ShowDialog().GetValueOrDefault())
                {
                    fileToSave.FilePath = dlg.SafeFileName;
                }
            }

            ActiveDocument.SaveCommand.SafeExecute();
            ActiveDocument.SetIsDirty(false);
        }

        private Task OnProjectActivationAsync(object sender, ProjectUpdatingCancelEventArgs e)
        {
            var newProject = (EditorProject)e.NewProject;
            if (newProject is not null)
            {
                EditorProject = newProject;
            }

            return Task.CompletedTask;
        }

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

            #endregion inspect on single click

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




                // VIDEO
                case ".BK2":
                    OpenVideoFile(fullpath);
                    break;





                // AUDIO

                case ".BNK":
                // TODO SPLIT WEMS TO PLAYLIST FROM BNK
                case ".WEM":
                    OpenAudioFile(fullpath);
                    break;
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

            void OpenAudioFile(string full)
            {



                var z = (AudioToolViewModel)ServiceLocator.Default.ResolveType<AudioToolViewModel>();
                ExecuteAudioTool();
                z.AddAudioItem(full);
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

        private void OpenVideoFile(string fullpath)
        {

            var mediator = ServiceLocator.Default.ResolveType<IMessageMediator>();
            mediator.SendMessage<string>(fullpath);
            mediator.SendMessage<bool>(true);



        }





        #endregion methods
    }
}
