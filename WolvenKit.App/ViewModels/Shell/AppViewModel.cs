using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using DynamicData;
using DynamicData.Binding;
using Microsoft.WindowsAPICodePack.Dialogs;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.Exceptions;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Services;
using WolvenKit.Functionality;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.ProjectManagement;
using WolvenKit.Functionality.Services;
using WolvenKit.Interaction;
using WolvenKit.Models;
using WolvenKit.Models.Docking;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.ViewModels.Editor;
using WolvenKit.ViewModels.Wizards;
using WolvenManager.Installer.Services;
using NativeMethods = WolvenKit.Functionality.NativeWin.NativeMethods;
using WolvenKit.Common.Model;

namespace WolvenKit.ViewModels.Shell
{
    public class AppViewModel : ReactiveObject, IAppViewModel
    {
        #region fields

        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;
        private readonly IGameControllerFactory _gameControllerFactory;
        private readonly IUpdateService _updateService;
        private readonly ISettingsManager _settingsManager;
        private readonly INotificationService _notificationService;
        private readonly IRecentlyUsedItemsService _recentlyUsedItemsService;

        
        

        
        


        #endregion fields

        #region constructors

        /// <summary>
        /// Class constructor
        /// </summary>
        public AppViewModel(
            IProjectManager projectManager,
            ILoggerService loggerService,
            IGameControllerFactory gameControllerFactory,
            IUpdateService updateService,
            ISettingsManager settingsManager,
            INotificationService notificationService,
            IRecentlyUsedItemsService recentlyUsedItemsService
        )
        {
            _updateService = updateService;
            _projectManager = projectManager;
            _loggerService = loggerService;
            _gameControllerFactory = gameControllerFactory;
            _settingsManager = settingsManager;
            _notificationService = notificationService;
            _recentlyUsedItemsService = recentlyUsedItemsService;

            #region commands

            ShowLogCommand = new RelayCommand(ExecuteShowLog, CanShowLog);
            ShowProjectExplorerCommand = new RelayCommand(ExecuteShowProjectExplorer, CanShowProjectExplorer);
            //ShowImportUtilityCommand = new RelayCommand(ExecuteShowImportUtility, CanShowImportUtility);
            ShowPropertiesCommand = new RelayCommand(ExecuteShowProperties, CanShowProperties);
            ShowAssetsCommand = new RelayCommand(ExecuteAssetBrowser, CanShowAssetBrowser);
            ShowVisualEditorCommand = new RelayCommand(ExecuteVisualEditor, CanShowVisualEditor);
            //ShowAudioToolCommand = new RelayCommand(ExecuteAudioTool, CanShowAudioTool);
            ShowVideoToolCommand = new RelayCommand(ExecuteVideoTool, CanShowVideoTool);
            ShowCodeEditorCommand = new RelayCommand(ExecuteCodeEditor, CanShowCodeEditor);

            ShowImportExportToolCommand = new RelayCommand(ExecuteImportExportTool, CanShowImportExportTool);
            ShowPackageInstallerCommand = new RelayCommand(ExecuteShowInstaller, CanShowInstaller);

            OpenFileCommand = new DelegateCommand<FileModel>(async (p) => await ExecuteOpenFile(p), CanOpenFile);

            PackModCommand = new RelayCommand(ExecutePackMod, CanPackMod);
            BackupModCommand = new RelayCommand(ExecuteBackupMod, CanBackupMod);
            PublishModCommand = new RelayCommand(ExecutePublishMod, CanPublishMod);

            NewFileCommand = new DelegateCommand<string>(ExecuteNewFile, CanNewFile);
            SaveFileCommand = new RelayCommand(ExecuteSaveFile, CanSaveFile);
            SaveAllCommand = new RelayCommand(ExecuteSaveAll, CanSaveAll);

            FileSelectedCommand = new DelegateCommand<FileModel>(async (p) => await ExecuteSelectFile(p), CanSelectFile);

            OpenProjectCommand = ReactiveCommand.CreateFromTask<string, Unit>(OpenProjectAsync);
            DeleteProjectCommand = ReactiveCommand.Create<string>(DeleteProject);
            NewProjectCommand = ReactiveCommand.CreateFromTask(NewProjectAsync);

            #endregion commands

            OnStartup();

            DockedViews = new ObservableCollection<IDockElement> {
                Log,
                ProjectExplorer,
                PropertiesViewModel,
                AssetBrowserVM,
                ImportExportToolVM,

                //ImportViewModel,
                //CodeEditorVM,
                //VisualEditorVM,

            };

            OpenDocuments
                .ToObservableChangeSet()
                .AutoRefreshOnObservable(document => document.Close)
                .Select(_ => WhenAnyDocumentClosed())
                .Switch()
                .Subscribe(x => OpenDocuments.Remove(x));

            _settingsManager
                .WhenAnyValue(x => x.UpdateChannel)
                .Subscribe(b =>
                {
                    _updateService.SetUpdateChannel(_settingsManager.UpdateChannel);
                    Task.Run(() => _updateService.CheckForUpdatesAsync());
                });
        }


        IObservable<DocumentViewModel> WhenAnyDocumentClosed() =>
            OpenDocuments
                .Select(x => x.Close.Select(_ => x))
                .Merge();

        #endregion constructors

        #region init

        private async void OnStartup()
        {
            _updateService.SetUpdateChannel(_settingsManager.UpdateChannel);
            _updateService.Init(new string[] { Constants.UpdateUrl, Constants.UpdateUrlNightly },
                Constants.AssemblyName,
            delegate (FileInfo path, bool isManaged)
            {
                if (isManaged)
                {
                    _ = Process.Start(path.FullName, "/SILENT /NOCANCEL");      //INNO
                    //_ = Process.Start(path.FullName, "/qr");                  //Advanced Installer
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

            try
            {
                await _updateService.CheckForUpdatesAsync();
            }
            catch (Exception e)
            {
                _loggerService.Error(e.Message);
            }

            ShowFirstTimeSetup();
        }

        private async void ShowFirstTimeSetup()
        {
            var messages = _settingsManager.IsHealthy();
            if (!messages.Any())
            {
                return;
            }

            //foreach (var message in messages)
            //{
            //    _notificationService.Error(message);
            //}

            var result = await Interactions.ShowFirstTimeSetup.Handle(Unit.Default);
        }

        //private static void OnToolViewModelPropertyChanged(object sender, PropertyChangedEventArgs args)
        //{
        //    // executes a global command that can be subscribed to from any viewmodel
        //    // passes the currently active viewmodel
        //    if (args.PropertyName == "IsActive" && sender is PaneViewModel panevm)
        //    {
        //        //ServiceLocator.Default.ResolveType<ICommandManager>()
        //        //    .GetCommand(AppCommands.Application.ViewSelected)
        //        //    .SafeExecute(new Tuple<PaneViewModel, bool>(panevm, panevm.IsActive));
        //    }
        //}

        #endregion init

        #region commands

        public ReactiveCommand<string, Unit> DeleteProjectCommand { get; }
        private void DeleteProject(string parameter)
        {
            try
            {
                var projectToDel = _recentlyUsedItemsService.Items.Items
                    .FirstOrDefault(project => project.Name == parameter?.ToString());
                if (projectToDel != null)
                {
                    _recentlyUsedItemsService.RemoveItem(projectToDel);
                }
            }
            catch (Exception ex)
            {
                _loggerService.LogString(ex.Message, Logtype.Error);
                _loggerService.LogString("Failed to delete recent project", Logtype.Error);
            }
        }

        public ReactiveCommand<string, Unit> OpenProjectCommand { get; }
        private async Task<Unit> OpenProjectAsync(string location)
        {
            // switch from one active project to another

            if (_projectManager.ActiveProject != null && !string.IsNullOrEmpty(location))
            {
                if (_projectManager.ActiveProject.Location == location)
                {
                    return Unit.Default;
                }
            }

            try
            {

                if (string.IsNullOrWhiteSpace(location) || !File.Exists(location))
                {
                    // file was moved or deleted
                    if (_recentlyUsedItemsService.Items.Items.Any(_ => _.Name == location))
                    {
                        // would you like to locate it?
                        //TODO
                        //location = await ProjectHelpers.LocateMissingProjectAsync(location);
                        //location = "";
                        //if (string.IsNullOrEmpty(location))
                        {
                            // user canceled locating a project
                            DeleteProject(location);
                            return Unit.Default;
                        }
                    }
                    // open an existing project
                    else
                    {
                        var dlg = new CommonOpenFileDialog
                        {
                            AllowNonFileSystemItems = false,
                            Multiselect = false,
                            IsFolderPicker = false,
                            Title = "Locate the WolvenKit project"
                        };
                        dlg.Filters.Add(new CommonFileDialogFilter("Cyberpunk 2077 Project", "*.cpmodproj"));

                        if (dlg.ShowDialog() != CommonFileDialogResult.Ok)
                        {
                            return Unit.Default;
                        }

                        var result = dlg.FileName;
                        if (string.IsNullOrEmpty(result))
                        {
                            return Unit.Default;
                        }

                        location = result;
                    }
                }

                // one last check
                if (!File.Exists(location))
                {
                    return Unit.Default;
                }

                var ribbon = Locator.Current.GetService<RibbonViewModel>();
                ribbon.StartScreenShown = false;
                ribbon.BackstageIsOpen = false;

                await _projectManager.LoadAsync(location);
                switch (Path.GetExtension(location))
                {
                    case ".w3modproj":
                        await _gameControllerFactory.GetController().HandleStartup().ContinueWith(t =>
                        {
                            _notificationService.Success(
                                "Project " + Path.GetFileNameWithoutExtension(location) +
                                " loaded!");

                        }, TaskContinuationOptions.OnlyOnRanToCompletion);
                        break;
                    case ".cpmodproj":
                        await _gameControllerFactory.GetController().HandleStartup().ContinueWith(
                            t =>
                            {
                                _notificationService.Success("Project " +
                                                             Path.GetFileNameWithoutExtension(location) +
                                                             " loaded!");

                            },
                            TaskContinuationOptions.OnlyOnRanToCompletion);
                        break;
                    default:
                        break;
                }

            }
            catch (Exception)
            {
                // TODO: Are we intentionally swallowing this?
                //Log.Error(ex, "Failed to open file");
            }

            return Unit.Default;
        }

        public ReactiveCommand<Unit, Unit> NewProjectCommand { get; }
        private async Task<Unit> NewProjectAsync()
        {
            try
            {
                var location = await Interactions.NewProjectInteraction.Handle(Unit.Default);

                if (string.IsNullOrWhiteSpace(location))
                {
                    return Unit.Default;
                }

                var ribbon = Locator.Current.GetService<RibbonViewModel>();
                ribbon.StartScreenShown = false;
                ribbon.BackstageIsOpen = false;

                //using (_pleaseWaitService.PushInScope())
                {
                    switch (Path.GetExtension(location))
                    {
                        case ".w3modproj":
                        {
                            //var np = new Tw3Project(location)
                            //{
                            //    Name = Path.GetFileNameWithoutExtension(location),
                            //    Author = "WolvenKit",
                            //    Email = "",
                            //    Version = "1.0"

                            //};
                            //_projectManager.ActiveProject = np;
                            //await _projectManager.SaveAsync();
                            //np.CreateDefaultDirectories();
                            ////saveProjectImg(location);
                            break;
                        }
                        case ".cpmodproj":
                        {
                            var np = new Cp77Project(location)
                            {
                                Name = Path.GetFileNameWithoutExtension(location),
                                Author = "WolvenKit",
                                Email = "",
                                Version = "1.0"
                            };
                            _projectManager.ActiveProject = np;
                            await _projectManager.SaveAsync();
                            np.CreateDefaultDirectories();
                            //saveProjectImg(location);
                            break;
                        }
                        default:
                            _loggerService.LogString("Invalid project path!", Logtype.Error);
                            break;
                    }
                }

                await _projectManager.LoadAsync(location);
                switch (Path.GetExtension(location))
                {
                    case ".w3modproj":
                        await _gameControllerFactory.GetController().HandleStartup().ContinueWith(t =>
                        {
                            _notificationService.Success(
                                "Project " + Path.GetFileNameWithoutExtension(location) +
                                " loaded!");

                        }, TaskContinuationOptions.OnlyOnRanToCompletion);
                        break;
                    case ".cpmodproj":
                        await _gameControllerFactory.GetController().HandleStartup().ContinueWith(
                            t =>
                            {
                                _notificationService.Success("Project " +
                                                             Path.GetFileNameWithoutExtension(location) +
                                                             " loaded!");

                            },
                            TaskContinuationOptions.OnlyOnRanToCompletion);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                _loggerService.LogString(ex.Message, Logtype.Error);
                _loggerService.LogString("Failed to create a new project!", Logtype.Error);
            }

            return Unit.Default;

        }








        public ICommand FileSelectedCommand { get; set; }

        private bool CanSelectFile(FileModel model) => true;

        private async Task ExecuteSelectFile(FileModel model) => await PropertiesViewModel.ExecuteSelectFile(model);

        /// <summary>
        /// Saves the active Documents
        /// </summary>
        public ICommand SaveFileCommand { get; private set; }

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
        private bool CanNewFile(string inputDir) => true;
        private async void ExecuteNewFile(string inputDir)
        {
            var (model, file) = await Interactions.AddNewFile.Handle(Unit.Default);
            if (file == null || string.IsNullOrEmpty(file))
            {
                return;
            }

            var filename = $"{Path.GetFileNameWithoutExtension(file)}.{model.Extension.ToLower()}";

            var fullPath = string.IsNullOrEmpty(inputDir)
            ? Path.Combine(GetDefaultDir(model.Type), filename)
            : Path.Combine(inputDir, filename);

            // move file to location
            if (File.Exists(fullPath))
            {
                MessageBox.Show($"A file with name {filename} is already part of your mod. Please give a unique name to the item you are adding, or delete the existing item first.",
                    "WolvenKit", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            switch (model.Type)
            {
                case EWolvenKitFile.Redscript:
                case EWolvenKitFile.TweakDelta:
                    File.Create(fullPath);
                    break;
                case EWolvenKitFile.Cr2w:
                    CreateCr2wFile(model);
                    break;
                default:
                    break;
            }

            // Open file
            await RequestOpenFile(fullPath);


            string GetDefaultDir(EWolvenKitFile type)
            {
                var project = _projectManager.ActiveProject as Cp77Project;
                return type switch
                {
                    EWolvenKitFile.Redscript => project.ScriptDirectory,
                    EWolvenKitFile.TweakDelta => project.TweakDirectory,
                    EWolvenKitFile.Cr2w => project.ModDirectory,
                    _ => throw new ArgumentOutOfRangeException(nameof(type)),
                };
            }

        }

        private void CreateCr2wFile(AddFileModel model)
        {
            //TODO
        }

        private async Task RequestOpenFile(string fullPath)
        {
            if (!File.Exists(fullPath))
            {
                _ = await Task.FromException<FileNotFoundException>(new FileNotFoundException(nameof(RequestOpenFile), fullPath));
            }
            // check if in 
            await RequestFileOpen(fullPath);
        }

        /// <summary>
        /// Opens a physical file in WolvenKit.
        /// </summary>
        public ICommand OpenFileCommand { get; private set; }
        private async Task ExecuteOpenFile(FileModel model)
        {
            if (model == null)
            {
                var dlg = new OpenFileDialog();
                if (dlg.ShowDialog().GetValueOrDefault())
                {
                    //model = new FileViewModel(new FileModel(new FileInfo(dlg.FileName)));
                    //TODO
                    ActiveDocument = await OpenAsync(model.FullName);
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
                    await RequestFileOpen(model.FullName);
                }
            }
        }


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
        //public ICommand ShowImportUtilityCommand { get; private set; }

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
            //var mediator = ServiceLocator.Default.ResolveType<IMessageMediator>();
            //mediator.SendMessage<int>(0);
            //mediator.SendMessage<bool>(true);
        }

        private void ExecutePackMod() => _gameControllerFactory.GetController().PackAndInstallProject();

        private bool CanBackupMod() => _projectManager.ActiveProject != null;

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

        //private bool CanShowImportUtility() => _projectManager.ActiveProject != null;

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

        //private void ExecuteShowImportUtility() => ImportViewModel.IsVisible = !ImportViewModel.IsVisible;

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


        private bool CanSaveAll() => _projectManager.ActiveProject != null && OpenDocuments?.Count > 0;

        private void ExecuteSaveAll()
        {
            foreach (var file in OpenDocuments)
            {
                Save(file);
            }
        }

        private bool CanSaveFile() => _projectManager.ActiveProject != null && ActiveDocument != null;

        private void ExecuteSaveFile() => Save(ActiveDocument);

        #endregion command implementation

        #region properties

        #region ToolViewModels


        private AssetBrowserViewModel _assetBrowserViewModel;

        private CodeEditorViewModel _codeEditorVm;

        private ImportExportViewModel _importExportToolViewModel;


        //private ImportViewModel _importViewModel = null;

        private LogViewModel _logViewModel;

        private ProjectExplorerViewModel _projectExplorerViewModel;

        private PropertiesViewModel _propertiesViewModel;



        private VisualEditorViewModel _visualEditorVm;



        public AssetBrowserViewModel AssetBrowserVM
        {
            get
            {
                _assetBrowserViewModel ??= Locator.Current.GetService<AssetBrowserViewModel>();
                //_assetBrowserViewModel.PropertyChanged += OnToolViewModelPropertyChanged;
                return _assetBrowserViewModel;
            }
        }

        public CodeEditorViewModel CodeEditorVM
        {
            get
            {
                _codeEditorVm ??= Locator.Current.GetService<CodeEditorViewModel>();
                //_codeEditorVm.PropertyChanged += OnToolViewModelPropertyChanged;
                return _codeEditorVm;
            }
        }


        public ImportExportViewModel ImportExportToolVM
        {
            get
            {
                _importExportToolViewModel ??= Locator.Current.GetService<ImportExportViewModel>();
                //_importExportToolViewModel.PropertyChanged += OnToolViewModelPropertyChanged;
                return _importExportToolViewModel;
            }
        }


        //public ImportViewModel ImportViewModel
        //{
        //    get
        //    {
        //        _importViewModel ??= ServiceLocator.Default.RegisterTypeAndInstantiate<ImportViewModel>();
        //        return _importViewModel;
        //    }
        //}



        public LogViewModel Log //=> _logViewModel ??= new LogViewModel();
        {
            get
            {
                _logViewModel ??= Locator.Current.GetService<LogViewModel>();
                return _logViewModel;
            }
        }


        public ProjectExplorerViewModel ProjectExplorer
        {
            get
            {
                _projectExplorerViewModel ??= Locator.Current.GetService<ProjectExplorerViewModel>();
                //_projectExplorerViewModel.PropertyChanged += OnToolViewModelPropertyChanged;
                return _projectExplorerViewModel;
            }
        }

        public PropertiesViewModel PropertiesViewModel
        {
            get
            {
                _propertiesViewModel ??= Locator.Current.GetService<PropertiesViewModel>();
                return _propertiesViewModel;
            }
        }

        public VisualEditorViewModel VisualEditorVM
        {
            get
            {
                _visualEditorVm ??= Locator.Current.GetService<VisualEditorViewModel>();
                //_visualEditorVm.PropertyChanged += OnToolViewModelPropertyChanged;
                return _visualEditorVm;
            }
        }



        #endregion ToolViewModels

        ///// <summary>
        ///// Event is raised when AvalonDock (or the user) selects a new document.
        ///// </summary>
        //public event EventHandler ActiveDocumentChanged;

        /// <summary>
        /// Gets/Sets the currently active document.
        /// </summary>
        [Reactive] public DocumentViewModel ActiveDocument { get; set; }

        /// <summary>
        /// Gets a collection of all currently available document viewmodels
        /// </summary>
        [Reactive] public ObservableCollection<DocumentViewModel> OpenDocuments { get; protected set; } = new();
        //public List<DocumentViewModel> Files => Tools
        //    .OfType<DocumentViewModel>()
        //    .Where(_ => _.State == DockState.Document)
        //    .ToList();

        /// <summary>
        /// Gets an enumeration of all currently available tool window viewmodels.
        /// </summary>
        public ObservableCollection<IDockElement> DockedViews { get; set; }

        #endregion properties

        #region methods

        /// <summary>
        /// Add a new document viewmodel into the collection of files.
        /// </summary>
        /// <param name="fileToAdd"></param>
        //public void AddFile(DocumentViewModel fileToAdd)
        //{
        //    if (fileToAdd == null)
        //    {
        //        return;
        //    }

        //    // Don't add this twice
        //    if (OpenDocuments.Any(f => f.ContentId == fileToAdd.ContentId))
        //    {
        //        return;
        //    }

        //    DockedViews.Add(fileToAdd);
        //}

        /// <summary>
        /// Checks if a document can be closed and asks the user whether
        /// to save before closing if the document appears to be dirty.
        /// </summary>
        /// <param name="fileToClose"></param>
        //public void Close(DocumentViewModel fileToClose)
        //{
        //    if (fileToClose.IsDirty)
        //    {
        //        var res = MessageBox.Show($"Save changes for file '{fileToClose.FileName}'?", "AvalonDock Test App", MessageBoxButton.YesNoCancel);
        //        if (res == MessageBoxResult.Cancel)
        //        {
        //            return;
        //        }

        //        if (res == MessageBoxResult.Yes)
        //        {
        //            Save(fileToClose);
        //        }
        //    }

        //    DockedViews.Remove(fileToClose);
        //}

        /// <summary>Closing all documents without user interaction to support reload of layout via menu.</summary>
        //public void CloseAllDocuments()
        //{
        //    ActiveDocument = null;
        //    foreach (var documentViewModel in OpenDocuments)
        //    {
        //        DockedViews.Remove(documentViewModel);
        //    }
        //}

        /// <summary>
        /// Open a file and return its content in a viewmodel.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<DocumentViewModel> OpenAsync(string fullPath)
        {
            // Check if we have already loaded this file and return it if so
            var fileViewModel = OpenDocuments.FirstOrDefault(fm => fm.ContentId == fullPath);
            if (fileViewModel != null)
            {
                return fileViewModel;
            }

            // open file
            fileViewModel = new DocumentViewModel(fullPath);
            var result = await fileViewModel.OpenFileAsync(fullPath);

            if (result)
            {
                // TODO: this is not threadsafe
                DockedViews.Add(fileViewModel);

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

        private async Task RequestFileOpen(string fullpath)
        {
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
                    ActiveDocument = await OpenAsync(fullpath);
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

        //private void OpenVideoFile(string fullpath)
        //{
        //    var mediator = ServiceLocator.Default.ResolveType<IMessageMediator>();
        //    mediator.SendMessage<int>(0);

        //    mediator.SendMessage<bool>(true);

        //    mediator.SendMessage<string>(fullpath);
        //}

        #endregion methods
    }
}
