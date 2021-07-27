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
using Catel.IoC;
using Catel.Messaging;
using Catel.MVVM;
using Catel.Services;
using Microsoft.Win32;
using ReactiveUI;
using WolvenKit.Common;
using WolvenKit.Common.Exceptions;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Services;
using WolvenKit.Functionality;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.Models;
using WolvenKit.Models.Docking;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.ViewModels.Editor;
using WolvenManager.Installer.Services;
using NativeMethods = WolvenKit.Functionality.NativeWin.NativeMethods;

namespace WolvenKit.ViewModels.Shell
{
    public class WorkSpaceViewModel : ViewModelBase, IWorkSpaceViewModel
    {
        #region fields

        private readonly ILoggerService _loggerService;
        private readonly IMessageService _messageService;
        private readonly IProjectManager _projectManager;
        private readonly IGameControllerFactory _gameControllerFactory;
        private readonly IUpdateService _updateService;

        private DocumentViewModel _activeDocument;

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
            ICommandManager commandManager,
            IGameControllerFactory gameControllerFactory,
            IUpdateService updateService
        )
        {
            _updateService = updateService;
            _projectManager = projectManager;
            _loggerService = loggerService;
            _messageService = messageService;
            _gameControllerFactory = gameControllerFactory;

            #region commands

            ShowLogCommand = new RelayCommand(ExecuteShowLog, CanShowLog);
            ShowProjectExplorerCommand = new RelayCommand(ExecuteShowProjectExplorer, CanShowProjectExplorer);
            ShowImportUtilityCommand = new RelayCommand(ExecuteShowImportUtility, CanShowImportUtility);
            ShowPropertiesCommand = new RelayCommand(ExecuteShowProperties, CanShowProperties);
            ShowAssetsCommand = new RelayCommand(ExecuteAssetBrowser, CanShowAssetBrowser);
            ShowVisualEditorCommand = new RelayCommand(ExecuteVisualEditor, CanShowVisualEditor);
            //ShowAudioToolCommand = new RelayCommand(ExecuteAudioTool, CanShowAudioTool);
            ShowVideoToolCommand = new RelayCommand(ExecuteVideoTool, CanShowVideoTool);
            ShowCodeEditorCommand = new RelayCommand(ExecuteCodeEditor, CanShowCodeEditor);

            ShowImportExportToolCommand = new RelayCommand(ExecuteImportExportTool, CanShowImportExportTool);



            ShowPackageInstallerCommand = new RelayCommand(ExecuteShowInstaller, CanShowInstaller);

            OpenFileCommand = new DelegateCommand<FileModel>(async (p) => await ExecuteOpenFile(p), CanOpenFile);
            NewFileCommand = new RelayCommand(ExecuteNewFile, CanNewFile);

            PackModCommand = new RelayCommand(ExecutePackMod, CanPackMod);
            BackupModCommand = new RelayCommand(ExecuteBackupMod, CanBackupMod);
            PublishModCommand = new RelayCommand(ExecutePublishMod, CanPublishMod);

            SaveFileFileCommand = new RelayCommand(ExecuteSaveFile, CanSaveFile);
            SaveAllCommand = new RelayCommand(ExecuteSaveAll, CanSaveAll);

            FileSelectedCommand = new DelegateCommand<FileModel>(async (p) => await ExecuteSelectFile(p), CanSelectFile);

            // register as application-wide commands
            RegisterCommands(commandManager);

            #endregion commands

            Tools = new ObservableCollection<IDockElement> {
                Log,
                ProjectExplorer,
                PropertiesViewModel,
                AssetBrowserVM,
                ImportExportToolVM,

                ImportViewModel,
                //CodeEditorVM,
                //VisualEditorVM,

            };

            OnStartup();
        }

        #endregion constructors

        #region init

        private async void OnStartup()
        {
            _updateService.Init(Constants.UpdateUrl, Constants.AssemblyName, delegate (FileInfo path, bool isManaged)
            {
                if (isManaged)
                {
                    _ = Process.Start(path.FullName, "/SILENT /NOCANCEL");    //INNO
                    //_ = Process.Start(path.FullName, "/qr");            //Advanced Installer
                }
                else
                {
                    // move installer helper
                    var basedir = new DirectoryInfo(Path.GetDirectoryName(System.AppContext.BaseDirectory));
                    var shippedInstaller = new FileInfo(Path.Combine(basedir.FullName, "lib", Constants.UpdaterName));
                    var newPath = Path.Combine(ISettingsManager.GetAppData(), Constants.UpdaterName);
                    try
                    {
                        shippedInstaller.MoveTo(newPath, true);
                    }
                    catch (Exception)
                    {
                        _loggerService.Error("Could not initialize auto-installer.");
                        return;
                    }

                    // start installer helper
                    var psi = new ProcessStartInfo
                    {
                        FileName = "CMD.EXE",
                        Arguments = $"/K {newPath} install -i \"{path}\" -o \"{basedir.FullName}\" -r {Constants.AppName}"
                    };
                    var p = Process.Start(psi);
                }

                Application.Current.Shutdown();
            });

            await _updateService.CheckForUpdatesAsync();
        }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();
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
            commandManager.RegisterCommand(AppCommands.Application.ShowVisualEditor, ShowVisualEditorCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowImportExportTool, ShowImportExportToolCommand, this);

            commandManager.RegisterCommand(AppCommands.Application.ShowCodeEditor, ShowCodeEditorCommand, this);


            // Home Tab
            commandManager.RegisterCommand(AppCommands.Application.SaveFile, SaveFileFileCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.SaveAll, SaveAllCommand, this);

            commandManager.RegisterCommand(AppCommands.Application.OpenFile, OpenFileCommand, this);
            //commandManager.RegisterCommand(AppCommands.Application.FileSelected, OpenFileCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.NewFile, NewFileCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.PackMod, PackModCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.BackupMod, BackupModCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.PublishMod, PublishModCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowPackageInstaller, ShowPackageInstallerCommand, this);

            // global commands
            commandManager.RegisterCommand(AppCommands.Application.FileSelected, FileSelectedCommand, this);
        }

        #endregion init

        #region commands

        public ICommand FileSelectedCommand { get; private set; }

        private bool CanSelectFile(FileModel model) => true;

        private async Task ExecuteSelectFile(FileModel model) => await PropertiesViewModel.ExecuteSelectFile(model);

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

        public ICommand ShowCodeEditorCommand { get; private set; }

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

        public ICommand ShowImportExportToolCommand { get; private set; }

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
        //public ICommand ShowRadishToolCommand { get; private set; }

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowVisualEditorCommand { get; private set; }

        /// <summary>
        /// Displays the AssetBrowser.
        /// </summary>
        public ICommand ShowWccToolCommand { get; private set; }

        #endregion commands

        #region command implementation

        // public void ExecuteAudioTool() => AudioToolVM.IsVisible = !AudioToolVM.IsVisible;

        public void ExecuteVideoTool()
        {
            var mediator = ServiceLocator.Default.ResolveType<IMessageMediator>();
            mediator.SendMessage<int>(0);
            mediator.SendMessage<bool>(true);
        }

        private void ExecutePackMod() => _gameControllerFactory.GetController().PackAndInstallProject();

        private bool CanBackupMod() => _projectManager.ActiveProject != null;

        private bool CanNewFile() => true;

        private bool CanOpenFile(FileModel model) => true;

        private bool CanPackMod() => _projectManager.ActiveProject != null;

        private bool CanPublishMod() => _projectManager.ActiveProject != null;

        private bool CanShowAnimationTool() => false;

        private bool CanShowAssetBrowser() => true;//AssetBrowserVM != null && AssetBrowserVM.IsLoaded;

        private bool CanShowAudioTool() => _projectManager.ActiveProject != null;

        private bool CanShowVideoTool() => _projectManager.ActiveProject != null;

        private bool CanShowBulkEditor() => false;

        private bool CanShowCR2WToTextTool() => false;

        private bool CanShowCsvEditor() => _projectManager.ActiveProject != null;

        private bool CanShowCodeEditor() => _projectManager.ActiveProject != null;

        private bool CanShowGameDebuggerTool() => false;

        private bool CanShowHexEditor() => false;

        private bool CanShowImporterTool() => false;

        private bool CanShowImportUtility() => _projectManager.ActiveProject != null;

        private bool CanShowInstaller() => false;

        private bool CanShowJournalEditor() => false;

        private bool CanShowLog() => _projectManager.ActiveProject != null;

        private bool CanShowMenuCreatorTool() => false;

        private bool CanShowMimicsTool() => false;

        private bool CanShowPluginManagerTool() => false;

        private bool CanShowProjectExplorer() => _projectManager.ActiveProject != null;

        private bool CanShowProperties() => _projectManager.ActiveProject != null;

        //private bool CanShowRadishTool() => false;

        private bool CanShowVisualEditor() => _projectManager.ActiveProject != null;

        private bool CanShowWccTool() => false;

        private bool CanShowImportExportTool() => _projectManager.ActiveProject != null;

        private void ExecuteImportExportTool() => ImportExportToolVM.IsVisible = !ImportExportToolVM.IsVisible;


        private void ExecuteAssetBrowser() => AssetBrowserVM.IsVisible = !AssetBrowserVM.IsVisible;

        private void ExecuteBackupMod()
        {
            // TODO: Implement this
        }

        private void ExecuteCodeEditor() => CodeEditorVM.IsVisible = !CodeEditorVM.IsVisible;


        private void ExecuteNewFile()
        {
            //TODO
        }

        private async Task ExecuteOpenFile(FileModel model)
        {
            if (model == null)
            {
                var dlg = new OpenFileDialog();
                if (dlg.ShowDialog().GetValueOrDefault())
                {
                    //model = new FileViewModel(new FileModel(new FileInfo(dlg.FileName)));
                    //TODO
                    ActiveDocument = await OpenAsync(model);
                }
            }
            else
            {
                if (model.IsDirectory)
                {
                    model.IsExpanded = !model.IsExpanded;
                }
                else if (!model.IsDirectory)
                {
                    // TODO: make this a background task
                    await RequestFileOpen(model);
                }
            }
        }


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

        #endregion command implementation

        #region properties

        #region ToolViewModels


        private AssetBrowserViewModel _AssetBrowserViewModel = null;

        private CodeEditorViewModel _CodeEditorVM = null;

        private ImportExportViewModel _importExportToolViewModel = null;


        private ImportViewModel _importViewModel = null;

        private LogViewModel _logViewModel = null;

        private ProjectExplorerViewModel _projectExplorerViewModel = null;

        private PropertiesViewModel _propertiesViewModel = null;



        private VisualEditorViewModel _VisualEditorVM = null;



        public AssetBrowserViewModel AssetBrowserVM
        {
            get
            {
                _AssetBrowserViewModel ??= ServiceLocator.Default.RegisterTypeAndInstantiate<AssetBrowserViewModel>();
                _AssetBrowserViewModel.PropertyChanged += OnToolViewModelPropertyChanged;
                return _AssetBrowserViewModel;
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


        public ImportExportViewModel ImportExportToolVM
        {
            get
            {
                _importExportToolViewModel ??= ServiceLocator.Default.RegisterTypeAndInstantiate<ImportExportViewModel>();
                _importExportToolViewModel.PropertyChanged += OnToolViewModelPropertyChanged;
                return _importExportToolViewModel;
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



        public LogViewModel Log => _logViewModel ??= new LogViewModel();



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

        public VisualEditorViewModel VisualEditorVM
        {
            get
            {
                _VisualEditorVM ??= ServiceLocator.Default.RegisterTypeAndInstantiate<VisualEditorViewModel>();
                _VisualEditorVM.PropertyChanged += OnToolViewModelPropertyChanged;
                return _VisualEditorVM;
            }
        }



        #endregion ToolViewModels

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
        public List<DocumentViewModel> Files => Tools
            .OfType<DocumentViewModel>()
            .Where(_ => _.State == DockState.Document)
            .ToList();

        /// <summary>
        /// Gets an enumeration of all currently available tool window viewmodels.
        /// </summary>
        public ObservableCollection<IDockElement> Tools { get; set; }

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
            if (Files.Any(f => f.ContentId == fileToAdd.ContentId))
            {
                return;
            }

            Tools.Add(fileToAdd);
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

            Tools.Remove(fileToClose);
        }

        /// <summary>Closing all documents without user interaction to support reload of layout via menu.</summary>
        public void CloseAllDocuments()
        {
            ActiveDocument = null;
            foreach (var documentViewModel in Files)
            {
                Tools.Remove(documentViewModel);
            }
        }

        /// <summary>
        /// Open a file and return its content in a viewmodel.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<DocumentViewModel> OpenAsync(FileModel model)
        {
            // Check if we have already loaded this file and return it if so
            var fileViewModel = Files.FirstOrDefault(fm => fm.ContentId == model.FullName);
            if (fileViewModel != null)
            {
                return fileViewModel;
            }

            // open file
            fileViewModel = new DocumentViewModel(this, model, true);
            var result = await fileViewModel.OpenFileAsync(model.FullName);

            if (result)
            {
                // TODO: this is not threadsafe
                Tools.Add(fileViewModel);

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

        private async Task RequestFileOpen(FileModel model)
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
                case ".MP3":
                case ".WAV":
                case ".GLB":
                case ".GLTF":
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
                    break;

                // AUDIO

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
                //case ".BNK":
                // TODO SPLIT WEMS TO PLAYLIST FROM BNK

                default:
                    ActiveDocument = await OpenAsync(model);
                    break;
            }

            void OpenAudioFile(string full)
            {
                // commented for testing

                //var z = (AudioToolViewModel)ServiceLocator.Default.ResolveType<AudioToolViewModel>();
                //ExecuteAudioTool();
                //z.AddAudioItem(full);
            }

            void ShellExecute(string path)
            {
                try
                {
                    var proc = new ProcessStartInfo(path.ToEscapedPath()) { UseShellExecute = true };
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
                    Process.Start(programname.ToString(), path.ToEscapedPath());
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
            mediator.SendMessage<int>(0);

            mediator.SendMessage<bool>(true);

            mediator.SendMessage<string>(fullpath);
        }

        #endregion methods
    }
}
