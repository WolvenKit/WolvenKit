using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using gpm.Installer;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.App.Commands.Base;
using WolvenKit.App.Controllers;
using WolvenKit.App.Functionality.ProjectManagement;
using WolvenKit.App.Functionality.ProjectManagement.Project;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.HomePage;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.App.ViewModels.Wizards;
using WolvenKit.Common;
using WolvenKit.Common.Exceptions;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;
using NativeMethods = WolvenKit.App.Functionality.Other.NativeWin.NativeMethods;

namespace WolvenKit.App.ViewModels.Shell
{
    public class AppViewModel : ReactiveObject/*, IAppViewModel*/
    {
        #region fields

        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;
        private readonly IGameControllerFactory _gameControllerFactory;
        private readonly ISettingsManager _settingsManager;
        private readonly INotificationService _notificationService;
        private readonly IRecentlyUsedItemsService _recentlyUsedItemsService;
        private readonly IProgressService<double> _progressService;
        private readonly IWatcherService _watcherService;
        private readonly AutoInstallerService _autoInstallerService;
        private readonly HomePageViewModel _homePageViewModel;

        #endregion fields

        #region constructors

        /// <summary>
        /// Class constructor
        /// </summary>
        public AppViewModel(
            IProjectManager projectManager,
            ILoggerService loggerService,
            IGameControllerFactory gameControllerFactory,
            ISettingsManager settingsManager,
            INotificationService notificationService,
            IRecentlyUsedItemsService recentlyUsedItemsService,
            IProgressService<double> progressService,
            IWatcherService watcherService,
            AutoInstallerService autoInstallerService
        )
        {
            _projectManager = projectManager;
            _loggerService = loggerService;
            _gameControllerFactory = gameControllerFactory;
            _settingsManager = settingsManager;
            _notificationService = notificationService;
            _recentlyUsedItemsService = recentlyUsedItemsService;
            _progressService = progressService;
            _watcherService = watcherService;
            _autoInstallerService = autoInstallerService;

            _homePageViewModel = Locator.Current.GetService<HomePageViewModel>();

            #region commands

            ShowLogCommand = new RelayCommand(ExecuteShowLog, CanShowLog);
            ShowProjectExplorerCommand = new RelayCommand(ExecuteShowProjectExplorer, CanShowProjectExplorer);
            //ShowImportUtilityCommand = new RelayCommand(ExecuteShowImportUtility, CanShowImportUtility);
            ShowPropertiesCommand = new RelayCommand(ExecuteShowProperties, CanShowProperties);
            ShowAssetsCommand = new RelayCommand(ExecuteAssetBrowser, CanShowAssetBrowser);
            //ShowVisualEditorCommand = new RelayCommand(ExecuteVisualEditor, CanShowVisualEditor);
            //ShowAudioToolCommand = new RelayCommand(ExecuteAudioTool, CanShowAudioTool);
            //ShowVideoToolCommand = new RelayCommand(ExecuteVideoTool, CanShowVideoTool);
            //ShowCodeEditorCommand = new RelayCommand(ExecuteCodeEditor, CanShowCodeEditor);

            ShowImportExportToolCommand = new RelayCommand(ExecuteImportExportTool, CanShowImportExportTool);
            //ShowPackageInstallerCommand = new RelayCommand(ExecuteShowInstaller, CanShowInstaller);

            ShowPluginCommand = new RelayCommand(ExecuteShowPlugin, CanShowPlugin);

            OpenFileCommand = new DelegateCommand<FileModel>(p => ExecuteOpenFile(p), CanOpenFile);
            OpenFileAsyncCommand = ReactiveCommand.CreateFromTask<FileModel, Unit>(OpenFileAsync);
            OpenRedFileAsyncCommand = ReactiveCommand.CreateFromTask<FileEntry, Unit>(OpenRedFileAsync);

            var canExecute = this.WhenAny(x => x._projectManager.ActiveProject, (p) => p != null);
            PackModCommand = ReactiveCommand.CreateFromTask(ExecutePackMod, canExecute);
            PackInstallModCommand = ReactiveCommand.CreateFromTask(ExecutePackInstallMod, canExecute);
            //BackupModCommand = new RelayCommand(ExecuteBackupMod, CanBackupMod);
            //PublishModCommand = new RelayCommand(ExecutePublishMod, CanPublishMod);

            NewFileCommand = new DelegateCommand<string>(ExecuteNewFile, CanNewFile);
            SaveFileCommand = new RelayCommand(ExecuteSaveFile, CanSaveFile);
            SaveAsCommand = new RelayCommand(ExecuteSaveAs, CanSaveFile);
            SaveAllCommand = new RelayCommand(ExecuteSaveAll, CanSaveAll);

            FileSelectedCommand = new DelegateCommand<FileModel>(async (p) => await ExecuteSelectFile(p), CanSelectFile);

            OpenProjectCommand = ReactiveCommand.CreateFromTask<string, Unit>(OpenProjectAsync);
            DeleteProjectCommand = ReactiveCommand.Create<string>(DeleteProject);
            NewProjectCommand = ReactiveCommand.Create(ExecuteNewProject);

            ShowHomePageCommand = new RelayCommand(ExecuteShowHomePage, CanShowHomePage);
            ShowSettingsCommand = new RelayCommand(ExecuteShowSettings, CanShowSettings);

            LaunchGameCommand = ReactiveCommand.CreateFromTask(ExecuteLaunchGame);

            CloseModalCommand = new RelayCommand(ExecuteCloseModal, CanCloseModal);
            CloseOverlayCommand = new RelayCommand(ExecuteCloseOverlay, CanCloseOverlay);
            CloseDialogCommand = new RelayCommand(ExecuteCloseDialog, CanCloseDialog);


            _ = OpenFileAsyncCommand.ThrownExceptions.Subscribe(ex => LogExtended(ex));
            _ = OpenRedFileAsyncCommand.ThrownExceptions.Subscribe(ex => LogExtended(ex));
            _ = PackModCommand.ThrownExceptions.Subscribe(ex => LogExtended(ex));
            _ = PackInstallModCommand.ThrownExceptions.Subscribe(ex => LogExtended(ex));
            _ = OpenProjectCommand.ThrownExceptions.Subscribe(ex => LogExtended(ex));

            #endregion commands

            UpdateTitle();

            if (!TryLoadingArguments())
            {
                SetActiveOverlay(_homePageViewModel);
            }

            OnStartup();

            DockedViews = new ObservableCollection<IDockElement> {
                Log,
                ProjectExplorer,
                PropertiesViewModel,
                AssetBrowserVM,
                ImportExportToolVM,
                TweakBrowserVM,
                LocKeyBrowserVM
            };

            // TweakDB when we're good and ready
            _ = _settingsManager
                .WhenAnyValue(x => x.CP77GameDirPath)
                .SkipWhile(x => string.IsNullOrWhiteSpace(x)) // -.-
                .Take(1)
                .Subscribe(x => LoadTweakDB(_settingsManager.GetRED4GameRootDir()));

            _ = _settingsManager
                .WhenAnyValue(x => x.UpdateChannel)
                .Subscribe(async x =>
                {
                    _ = _autoInstallerService.UseChannel(x.ToString());

                    // 1 API call
                    if (!(await _autoInstallerService.CheckForUpdate())
                        .Out(out var release))
                    {
                        return;
                    }

                    if (release.TagName.Equals(_settingsManager.GetVersionNumber()))
                    {
                        return;
                    }

                    _settingsManager.IsUpdateAvailable = true;
                    _loggerService.Success($"WolvenKit update available: {release.TagName}");
                });
        }

        #endregion constructors

        #region init

        private bool TryLoadingArguments()
        {
            var args = Environment.GetCommandLineArgs();

            if (args.Length != 2)
            {
                return false;
            }

            if (!File.Exists(args[1]))
            {
                var message = $"Sorry, '{args[1]}' could not be found";
                _loggerService.Error(message);
                _ = MessageBox.Show(message);
                return false;
            }

            if (Path.GetExtension(args[1]) == ".cpmodproj")
            {
                _ = OpenProjectAsync(args[1]);
                return true;
            }

            if (Enum.TryParse<ERedExtension>(Path.GetExtension(args[1])[1..], out _))
            {
                _ = OpenFileAsync(new FileModel(args[1], null));
                return true;
            }

            var message2 = $"Sorry, {Path.GetExtension(args[1])} files aren't supported by WolvenKit";
            _loggerService.Error(message2);
            _ = MessageBox.Show(message2);
            return false;
        }

        private void OnStartup()
        {
            InitUpdateService();

            ShowFirstTimeSetup();
        }


        private void InitUpdateService() => _autoInstallerService
               .UseWPF()
               .WithVersion(_settingsManager.GetVersionNumber())
               //.WithVersion("8.4.2") //DBG
               .WithRestart("WolvenKit.exe")
               .WithChannel(EUpdateChannel.Nightly.ToString(), "wolvenkit/wolvenkit-nightly-releases")
               .WithChannel(EUpdateChannel.Stable.ToString(), "wolvenkit/wolvenkit")
               .UseChannel(_settingsManager.UpdateChannel.ToString())
               .Build();


        private async void ShowFirstTimeSetup()
        {
            if (!_settingsManager.IsHealthy())
            {
                _ = await Interactions.ShowFirstTimeSetup.Handle(Unit.Default);
            }
        }

        private void LoadTweakDB(string gameDir)
        {
            var tweakdbService = Locator.Current.GetService<TweakDBService>();
            tweakdbService.LoadDB(Path.Combine(gameDir, "r6", "cache", "tweakdb.bin"));
        }

        #endregion init

        #region commands

        public ReactiveCommand<string, Unit> DeleteProjectCommand { get; }
        private void DeleteProject(string parameter)
        {
            try
            {
                var projectToDel = _recentlyUsedItemsService.Items.Items
                    .FirstOrDefault(project => project.Name == parameter);
                if (projectToDel != null)
                {
                    _recentlyUsedItemsService.RemoveItem(projectToDel);
                }
            }
            catch (Exception ex)
            {
                _loggerService.Error(ex.Message);
                _loggerService.Error("Failed to delete recent project");
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

                CloseModalCommand.Execute(null);

                _ = await _projectManager.LoadAsync(location);

                ActiveProject = _projectManager.ActiveProject;

                await _gameControllerFactory.GetController().HandleStartup().ContinueWith(_ =>
                {
                    UpdateTitle();
                    _notificationService.Success($"Project {Path.GetFileNameWithoutExtension(location)} loaded!");
                }, TaskContinuationOptions.OnlyOnRanToCompletion);
            }
            catch (Exception)
            {
                // TODO: Are we intentionally swallowing this?
                //Log.Error(ex, "Failed to open file");
            }

            return Unit.Default;
        }

        public ReactiveCommand<Unit, Unit> NewProjectCommand { get; }
        private void ExecuteNewProject() =>
            //IsOverlayShown = false;
            SetActiveDialog(new ProjectWizardViewModel
            {
                FileHandler = NewProject
            });
        private async Task NewProject(ProjectWizardViewModel project)
        {

            if (project == null)
            {
                CloseDialogCommand.Execute(null);
                return;
            }
            CloseModalCommand.Execute(null);
            await Task.Run(() => NewProjectTask(project)).ContinueWith((result) =>
            {
            });
        }

        private async Task NewProjectTask(ProjectWizardViewModel project)
        {
            try
            {
                var projectLocation = Path.Combine(project.ProjectPath, project.ProjectName, project.ProjectName + ".cpmodproj");
                var np = new Cp77Project(projectLocation)
                {
                    Name = project.ProjectName,
                    Author = project.Author,
                    Email = project.Email,
                    Version = project.Version
                };
                _projectManager.ActiveProject = np;
                _ = await _projectManager.SaveAsync();
                np.CreateDefaultDirectories();

                _ = await _projectManager.LoadAsync(projectLocation);

                DispatcherHelper.RunOnMainThread(() => ActiveProject = _projectManager.ActiveProject);

                await _gameControllerFactory.GetController().HandleStartup().ContinueWith(_ =>
                {
                    UpdateTitle();
                    _notificationService.Success("Project " + project.ProjectName + " loaded!");
                }, TaskContinuationOptions.OnlyOnRanToCompletion);
            }
            catch (Exception ex)
            {
                _loggerService.Error(ex.Message);
                _loggerService.Error("Failed to create a new project!");
            }

        }

        public ICommand FileSelectedCommand { get; set; }
        private bool CanSelectFile(FileModel model) => true;
        private async Task ExecuteSelectFile(FileModel model) => await PropertiesViewModel.ExecuteSelectFile(model);

        public ICommand SaveFileCommand { get; private set; }
        private bool CanSaveFile() => ActiveDocument != null; // _projectManager.ActiveProject != null &&
        private void ExecuteSaveFile() => Save(ActiveDocument);

        public ICommand SaveAsCommand { get; private set; }
        private void ExecuteSaveAs() => Save(ActiveDocument, true);

        public ICommand SaveAllCommand { get; private set; }
        private bool CanSaveAll() => OpenDocuments?.Count > 0; //  _projectManager.ActiveProject != null &&
        private void ExecuteSaveAll()
        {
            foreach (var file in OpenDocuments)
            {
                Save(file);
            }
        }

        //public ICommand BackupModCommand { get; private set; }
        //private bool CanBackupMod() => _projectManager.ActiveProject != null;
        //private void ExecuteBackupMod()
        //{
        //    // TODO: Implement this
        //}

        public ICommand ShowHomePageCommand { get; private set; }
        private bool CanShowHomePage() => !IsDialogShown;
        private void ExecuteShowHomePage()
        {
            _homePageViewModel.SelectedIndex = 0;
            SetActiveOverlay(_homePageViewModel);
        }

        public ICommand ShowSettingsCommand { get; private set; }
        private bool CanShowSettings() => !IsDialogShown;
        private void ExecuteShowSettings()
        {

            _homePageViewModel.SelectedIndex = 1;
            SetActiveOverlay(_homePageViewModel);
        }

        [Reactive] public int SelectedGameCommandIdx { get; set; }

        public record GameLaunchCommand(string Name, EGameLaunchCommand Command);
        public enum EGameLaunchCommand
        {
            Launch,
            SteamLaunch,
            PackInstallLaunch
        }
        [Reactive]
        public ObservableCollection<GameLaunchCommand> SelectedGameCommands { get; set; } = new()
        {
            new GameLaunchCommand("Launch Game", EGameLaunchCommand.Launch),
            new GameLaunchCommand("Launch Game with Steam", EGameLaunchCommand.SteamLaunch),
            new GameLaunchCommand("Pack, Install and Launch Game", EGameLaunchCommand.PackInstallLaunch)
        };

        public ReactiveCommand<Unit, Unit> LaunchGameCommand { get; private set; }
        private async Task ExecuteLaunchGame()
        {
            var command = SelectedGameCommands[SelectedGameCommandIdx].Command;
            switch (command)
            {
                case EGameLaunchCommand.Launch:
                    try
                    {
                        _ = Process.Start(new ProcessStartInfo
                        {
                            FileName = _settingsManager.GetRED4GameLaunchCommand(),
                            Arguments = _settingsManager.GetRED4GameLaunchOptions() ?? "",
                            ErrorDialog = true,
                            UseShellExecute = true,
                        });
                    }
                    catch (Exception ex)
                    {
                        _loggerService.Error("Launch: error launching game! Please check your executable path in Settings.");
                        _loggerService.Info($"Launch: error debug info: {ex.Message}");
                    }
                    break;
                case EGameLaunchCommand.SteamLaunch:
                    try
                    {
                        var steamrunid = "steam://rungameid/1091500";

                        _ = Process.Start(new ProcessStartInfo
                        {
                            FileName = steamrunid,
                            ErrorDialog = true,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        _loggerService.Error("Launch: Error! Please check if you have Steam installed, and a valid Steam installation of Cyberpunk 2077");
                        _loggerService.Info($"Launch: error debug info: {ex.Message}");
                    }
                    break;
                case EGameLaunchCommand.PackInstallLaunch:
                    try
                    {
                        if (await Task.Run(() => _gameControllerFactory.GetController().PackAndInstallProject()))
                        {
                            _ = Process.Start(new ProcessStartInfo
                            {
                                FileName = _settingsManager.GetRED4GameLaunchCommand(),
                                Arguments = _settingsManager.GetRED4GameLaunchOptions() ?? "",
                                ErrorDialog = true,
                                UseShellExecute = true,
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        _loggerService.Error("Launch: error launching game! Please check your executable path in Settings.");
                        _loggerService.Info($"Launch: error debug info: {ex.Message}");
                    }
                    break;
                default:
                    break;
            }

            _loggerService.Success("Game launching.");
        }

        public ICommand ShowPluginCommand { get; private set; }
        private bool CanShowPlugin() => !IsDialogShown;
        private void ExecuteShowPlugin() => SetActiveDialog(new PluginsToolViewModel
        {
            FileHandler = OpenFromNewFile
        });

        public ICommand NewFileCommand { get; private set; }
        private bool CanNewFile(string inputDir) => ActiveProject != null && !IsDialogShown;
        private void ExecuteNewFile(string inputDir) => SetActiveDialog(new NewFileViewModel
        {
            FileHandler = OpenFromNewFile
        });

        public async Task OpenFromNewFile(NewFileViewModel file)
        {
            CloseModalCommand.Execute(null);
            if (file == null)
            {
                return;
            }

            _watcherService.IsSuspended = true;
            _ = await Task.Run(() => OpenFromNewFileTask(file)).ContinueWith(async (result) =>
            {
                _watcherService.IsSuspended = false;
                await _watcherService.RefreshAsync(ActiveProject);
                await RequestFileOpen(file.FullPath);
            });
        }

        public async Task OpenFromNewFileTask(NewFileViewModel file)
        {
            Stream stream = null;
            switch (file.SelectedFile.Type)
            {
                case EWolvenKitFile.Redscript:
                case EWolvenKitFile.Tweak:
                    if (!string.IsNullOrEmpty(file.SelectedFile.Template))
                    {
                        await using var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream($"WolvenKit.App.Resources.{file.SelectedFile.Template}");
                        stream = new FileStream(file.FullPath, FileMode.Create, FileAccess.Write);
                        resource.CopyTo(stream);
                    }
                    else
                    {
                        stream = File.Create(file.FullPath);
                    }
                    break;
                case EWolvenKitFile.Cr2w:
                    var redType = file.SelectedFile.Name;
                    if (redType != "")
                    {
                        var cr2w = new CR2WFile()
                        {
                            RootChunk = RedTypeManager.Create(redType)
                        };
                        stream = new FileStream(file.FullPath, FileMode.Create, FileAccess.Write);
                        using var writer = new CR2WWriter(stream);
                        writer.WriteFile(cr2w);
                    }
                    break;
            }
            stream.Dispose();

            //return Task.CompletedTask;

            // Open file
            //await Locator.Current.GetService<AppViewModel>().RequestFileOpen(file.FullPath);


            //if (file != null)
            //{
            //    _progressService.IsIndeterminate = true;
            //    try
            //    {
            //        var fileViewModel = new RedDocumentViewModel(file.FileName);
            //        await using (var stream = new MemoryStream())
            //        {
            //            file.Extract(stream);
            //            fileViewModel.OpenStream(stream, null);
            //        }

            //        if (!DockedViews.Contains(fileViewModel))
            //            DockedViews.Add(fileViewModel);
            //        ActiveDocument = fileViewModel;
            //        UpdateTitle();
            //    }
            //    catch (Exception e)
            //    {
            //        _loggerService.Error(e.Message);
            //    }
            //    finally
            //    {
            //        _progressService.IsIndeterminate = false;
            //    }
            //}

        }

        public ICommand OpenFileCommand { get; private set; }
        private bool CanOpenFile(FileModel model) => true;
        private void ExecuteOpenFile(FileModel model)
        {
            if (model == null)
            {
                var dlg = new OpenFileDialog();
                if (dlg.ShowDialog().GetValueOrDefault())
                {
                    //model = new FileViewModel(new FileModel(new FileInfo(dlg.FileName)));
                    //TODO
                    //ActiveDocument = await OpenAsync(model.FullName);
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
                    _progressService.IsIndeterminate = true;

                    _ = RequestFileOpen(model.FullName);

                    _progressService.IsIndeterminate = false;
                }
            }
        }

        public ReactiveCommand<FileModel, Unit> OpenFileAsyncCommand { get; }
        private async Task<Unit> OpenFileAsync(FileModel model)
        {
            if (model == null)
            {
                var dlg = new OpenFileDialog();
                if (dlg.ShowDialog().GetValueOrDefault())
                {
                    //model = new FileViewModel(new FileModel(new FileInfo(dlg.FileName)));
                    //TODO
                    //ActiveDocument = await OpenAsync(model.FullName);
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
                    _progressService.IsIndeterminate = true;
                    try
                    {
                        await RequestFileOpen(model.FullName);
                    }
                    catch (Exception e)
                    {
                        _loggerService.Error(e.Message);
                    }
                    finally
                    {
                        _progressService.IsIndeterminate = false;
                    }
                }
            }

            return Unit.Default;
        }

        public ReactiveCommand<FileEntry, Unit> OpenRedFileAsyncCommand { get; }
        private async Task<Unit> OpenRedFileAsync(FileEntry file)
        {
            if (file != null)
            {
                _progressService.IsIndeterminate = true;
                try
                {
                    var fileViewModel = new RedDocumentViewModel(file.FileName);
                    await using (var stream = new MemoryStream())
                    {
                        file.Extract(stream);
                        _ = fileViewModel.OpenStream(stream, null);
                    }

                    if (!DockedViews.Contains(fileViewModel))
                    {
                        DockedViews.Add(fileViewModel);
                    }

                    ActiveDocument = fileViewModel;
                    UpdateTitle();
                }
                catch (Exception e)
                {
                    _loggerService.Error(e.Message);
                }
                finally
                {
                    _progressService.IsIndeterminate = false;
                }
            }

            return Unit.Default;
        }

        public void OpenFileFromDepotPath(string path) => OpenFileFromHash(FNV1A64HashAlgorithm.HashString(path));

        public void OpenFileFromHash(ulong hash)
        {
            if (hash != 0)
            {
                _progressService.IsIndeterminate = true;
                try
                {
                    var _archiveManager = Locator.Current.GetService<IArchiveManager>();
                    var file = _archiveManager.Lookup(hash);
                    if (file.HasValue && file.Value is FileEntry fe)
                    {
                        var fileViewModel = new RedDocumentViewModel(fe.FileName);
                        using (var stream = new MemoryStream())
                        {
                            fe.Extract(stream);
                            _ = fileViewModel.OpenStream(stream, null);
                        }
                        if (!DockedViews.Contains(fileViewModel))
                        {
                            DockedViews.Add(fileViewModel);
                        }

                        ActiveDocument = fileViewModel;
                        UpdateTitle();
                    }
                }
                catch (Exception e)
                {
                    _loggerService.Error(e.Message);
                }
                finally
                {
                    _progressService.IsIndeterminate = false;
                }
            }
        }

        public ReactiveCommand<Unit, Unit> PackModCommand { get; private set; }
        private async Task ExecutePackMod() => await _gameControllerFactory.GetController().PackProject();

        public ReactiveCommand<Unit, Unit> PackInstallModCommand { get; private set; }
        private async Task ExecutePackInstallMod() => await Task.Run(async () => await _gameControllerFactory.GetController().PackAndInstallProject());

        //public ICommand PublishModCommand { get; private set; }
        //private bool CanPublishMod() => _projectManager.ActiveProject != null;
        //private void ExecutePublishMod()
        //{                // #convert2MVVMSoon
        //    //  try
        //    //  {
        //    //      var vm = new UserControlHostWindowViewModel(new PublishWizardView(), 600, 1200);

        //    //      ServiceLocator.Default.ResolveType<IUIVisualizerService>().ShowDialogAsync(vm);
        //    // }
        //    //  catch (Exception ex)
        //    // {
        //    //      _loggerService.LogString(ex.Message, Logtype.Error);
        //    //     _loggerService.LogString("Failed to publish project!", Logtype.Error);
        //    //  }
        //}

        //public ICommand ShowAnimationToolCommand { get; private set; }

        public ICommand ShowAssetsCommand { get; private set; }
        private bool CanShowAssetBrowser() => true;//AssetBrowserVM != null && AssetBrowserVM.IsLoaded;
        private void ExecuteAssetBrowser() => AssetBrowserVM.IsVisible = !AssetBrowserVM.IsVisible;

        //public ICommand ShowAudioToolCommand { get; private set; }
        //private bool CanShowAudioTool() => _projectManager.ActiveProject != null;
        // public void ExecuteAudioTool() => AudioToolVM.IsVisible = !AudioToolVM.IsVisible;

        //public ICommand ShowVideoToolCommand { get; private set; }
        //private bool CanShowVideoTool() => _projectManager.ActiveProject != null;
        //public void ExecuteVideoTool()
        //{
        //    //var mediator = ServiceLocator.Default.ResolveType<IMessageMediator>();
        //    //mediator.SendMessage<int>(0);
        //    //mediator.SendMessage<bool>(true);
        //}

        public ICommand ShowImportExportToolCommand { get; private set; }
        private bool CanShowImportExportTool() => _projectManager.ActiveProject != null;
        private void ExecuteImportExportTool() => ImportExportToolVM.IsVisible = !ImportExportToolVM.IsVisible;

        public ICommand ShowLogCommand { get; private set; }
        private bool CanShowLog() => _projectManager.ActiveProject != null;
        private void ExecuteShowLog() => Log.IsVisible = !Log.IsVisible;

        //public ICommand ShowPackageInstallerCommand { get; private set; }
        //private bool CanShowInstaller() => false;
        //private void ExecuteShowInstaller()
        //{                // #convert2MVVMSoon
        //    //  var rpv = new InstallerWizardView();
        //    //  var zxc = new UserControlHostWindowViewModel(rpv);
        //    //  var uchwv = new UserControlHostWindowView(zxc);
        //    //  uchwv.Show();
        //}

        //public ICommand ShowPluginManagerCommand { get; private set; }
        //private bool CanShowPluginManagerTool() => false;


        public ICommand ShowProjectExplorerCommand { get; private set; }
        private bool CanShowProjectExplorer() => _projectManager.ActiveProject != null;
        private void ExecuteShowProjectExplorer() => ProjectExplorer.IsVisible = !ProjectExplorer.IsVisible;

        public ICommand ShowPropertiesCommand { get; private set; }
        private bool CanShowProperties() => _projectManager.ActiveProject != null;
        private void ExecuteShowProperties() => PropertiesViewModel.IsVisible = !PropertiesViewModel.IsVisible;

        //public ICommand ShowVisualEditorCommand { get; private set; }
        //private bool CanShowVisualEditor() => _projectManager.ActiveProject != null;
        //private void ExecuteVisualEditor() => VisualEditorVM.IsVisible = !VisualEditorVM.IsVisible;

        //public ICommand ShowCodeEditorCommand { get; private set; }
        //private bool CanShowCodeEditor() => _projectManager.ActiveProject != null;
        //private void ExecuteCodeEditor() => CodeEditorVM.IsVisible = !CodeEditorVM.IsVisible;

        public ICommand CloseModalCommand { get; private set; }
        private bool CanCloseModal() => IsDialogShown || IsOverlayShown;
        private void ExecuteCloseModal()
        {
            if (IsDialogShown)
            {
                ShouldDialogShow = false;
            }

            if (IsOverlayShown)
            {
                ShouldOverlayShow = false;
            }
        }
        public void FinishedClosingModal()
        {
            if (!ShouldDialogShow)
            {
                IsDialogShown = false;
            }

            if (!ShouldOverlayShow)
            {
                IsOverlayShown = false;
            }
        }
        public ICommand CloseOverlayCommand { get; private set; }
        private bool CanCloseOverlay() => IsOverlayShown;
        private void ExecuteCloseOverlay() => ShouldOverlayShow = false;
        public ICommand CloseDialogCommand { get; private set; }
        private bool CanCloseDialog() => IsDialogShown;
        private void ExecuteCloseDialog() => ShouldDialogShow = false;

        #endregion commands

        #region properties

        #region ToolViewModels

        private AssetBrowserViewModel _assetBrowserViewModel;
        public AssetBrowserViewModel AssetBrowserVM
        {
            get
            {
                _assetBrowserViewModel ??= Locator.Current.GetService<AssetBrowserViewModel>();
                return _assetBrowserViewModel;
            }
        }

        private ImportExportViewModel _importExportToolViewModel;
        public ImportExportViewModel ImportExportToolVM
        {
            get
            {
                _importExportToolViewModel ??= Locator.Current.GetService<ImportExportViewModel>();
                return _importExportToolViewModel;
            }
        }

        private LogViewModel _logViewModel;
        public LogViewModel Log
        {
            get
            {
                _logViewModel ??= Locator.Current.GetService<LogViewModel>();
                return _logViewModel;
            }
        }

        private ProjectExplorerViewModel _projectExplorerViewModel;
        public ProjectExplorerViewModel ProjectExplorer
        {
            get
            {
                _projectExplorerViewModel ??= Locator.Current.GetService<ProjectExplorerViewModel>();
                return _projectExplorerViewModel;
            }
        }

        private PropertiesViewModel _propertiesViewModel;
        public PropertiesViewModel PropertiesViewModel
        {
            get
            {
                _propertiesViewModel ??= Locator.Current.GetService<PropertiesViewModel>();
                return _propertiesViewModel;
            }
        }

        private TweakBrowserViewModel _tweakBrowserViewModel;
        public TweakBrowserViewModel TweakBrowserVM
        {
            get
            {
                _tweakBrowserViewModel ??= Locator.Current.GetService<TweakBrowserViewModel>();
                return _tweakBrowserViewModel;
            }
        }

        private LocKeyBrowserViewModel _locKeyBrowserViewModel;
        public LocKeyBrowserViewModel LocKeyBrowserVM
        {
            get
            {
                _locKeyBrowserViewModel ??= Locator.Current.GetService<LocKeyBrowserViewModel>();
                return _locKeyBrowserViewModel;
            }
        }

        //private VisualEditorViewModel _visualEditorVm;
        //public VisualEditorViewModel VisualEditorVM
        //{
        //    get
        //    {
        //        _visualEditorVm ??= Locator.Current.GetService<VisualEditorViewModel>();
        //        return _visualEditorVm;
        //    }
        //}

        //private CodeEditorViewModel _codeEditorVm;
        //public CodeEditorViewModel CodeEditorVM
        //{
        //    get
        //    {
        //        _codeEditorVm ??= Locator.Current.GetService<CodeEditorViewModel>();
        //        return _codeEditorVm;
        //    }
        //}

        #endregion ToolViewModels

        [Reactive] public string Status { get; set; }

        [Reactive] public string Title { get; set; }

        [Reactive] public bool ShouldDialogShow { get; set; }
        [Reactive] public bool ShouldOverlayShow { get; set; }
        [Reactive] public bool IsOverlayShown { get; set; }
        [Reactive] public bool IsDialogShown { get; set; }

        private void OnAfterOverlayRendered()
        {
            IsOverlayShown = true;
            ShouldOverlayShow = true;
        }
        private void OnAfterDialogRendered()
        {
            IsDialogShown = true;
            ShouldDialogShow = true;
        }

        [Reactive] public ReactiveObject ActiveOverlay { get; set; }

        public void SetActiveOverlay(ReactiveObject overlay)
        {
            ActiveOverlay = overlay;
            //Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Render, (Action)OnAfterRendered);
            _ = Task.Run(OnAfterOverlayRendered);
        }

        [Reactive] public DialogViewModel ActiveDialog { get; set; }
        public void SetActiveDialog(DialogViewModel modal)
        {
            ActiveDialog = modal;
            //Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Render, (Action)OnAfterRendered);
            _ = Task.Run(OnAfterDialogRendered);
        }

        [Reactive] public IDocumentViewModel ActiveDocument { get; set; }

        [Reactive] public EditorProject ActiveProject { get; set; }

        private List<IDocumentViewModel> OpenDocuments => DockedViews.OfType<IDocumentViewModel>().ToList();

        [Reactive] public ObservableCollection<IDockElement> DockedViews { get; set; }

        #endregion properties

        #region methods

        private void LogExtended(Exception ex) => _loggerService.Error($"Message: {ex.Message}\nSource: {ex.Source}\nStackTrace: {ex.StackTrace}");
        public void UpdateTitle()
        {
            var title = "";
            if (ActiveDocument != null)
            {
                title += ActiveDocument.Header + " - ";
            }

            if (_projectManager.ActiveProject != null)
            {
                title += _projectManager.ActiveProject.Name + " - ";
            }

            title += "WolvenKit";
            Title = title;
        }

        //private async Task RequestOpenFile(string fullPath)
        //{
        //    if (!File.Exists(fullPath))
        //    {
        //        _ = await Task.FromException<FileNotFoundException>(new FileNotFoundException(nameof(RequestOpenFile), fullPath));
        //    }
        //    // check if in
        //    await RequestFileOpen(fullPath);
        //}

        /// <summary>
        /// Open a file and return its content in a viewmodel.
        /// </summary>
        /// <returns></returns>
        private IDocumentViewModel Open(string fullPath, EWolvenKitFile type)
        {
            // Check if we have already loaded this file and return it if so
            var fileViewModel = OpenDocuments.FirstOrDefault(fm => fm.ContentId == fullPath);
            if (fileViewModel != null)
            {
                return fileViewModel;
            }

            // open file
            switch (type)
            {
                case EWolvenKitFile.Cr2w:
                    fileViewModel = new RedDocumentViewModel(fullPath);
                    break;
                case EWolvenKitFile.Redscript:
                    fileViewModel = new ScriptDocumentViewModel(fullPath);
                    break;
                case EWolvenKitFile.Tweak:
                    fileViewModel = Path.GetExtension(fullPath).ToUpper() == ".YAML"
                        ? new TweakXLDocumentViewModel(fullPath)
                        : new TweakDocumentViewModel(fullPath);
                    break;
                default:
                    break;
            }

            //var result = await fileViewModel.OpenFileAsync(fullPath);
            var result = fileViewModel.OpenFile(fullPath);


            if (result)
            {
                _loggerService.Success($"Opening File: {fullPath}");

                // TODO: this is not threadsafe
                //handler.Report(fileViewModel);

                //Dispatcher.CurrentDispatcher.Invoke(new Action(() =>
                //{
                //    addfiledel(fileViewModel);
                //}), DispatcherPriority.ContextIdle);

                return fileViewModel;
            }

            _loggerService.Warning($"Unable to open file: {fullPath}");
            return null;
        }

        /// <summary>
        /// Saves a document and resets the dirty flag.
        /// </summary>
        /// <param name="fileToSave"></param>
        /// <param name="saveAsDialogRequested"></param>
        public void Save(IDocumentViewModel fileToSave, bool saveAsDialogRequested = false)
        {
            var needSaveAsDialog =
                fileToSave switch
                {
                    RedDocumentViewModel red =>
                        saveAsDialogRequested ||
                        red.FilePath == null ||
                        !Directory.Exists(Path.GetDirectoryName(Path.Combine(_projectManager.ActiveProject.ModDirectory, red.RelativePath)))
                    ,
                    _ => false,
                };

            if (needSaveAsDialog)
            {
                var dlg = new SaveFileDialog();
                if (fileToSave.FilePath == null && fileToSave is RedDocumentViewModel red)
                {
                    var directory = Path.GetDirectoryName(Path.Combine(_projectManager.ActiveProject.ModDirectory, red.RelativePath));
                    if (!Directory.Exists(directory))
                    {
                        _ = Directory.CreateDirectory(directory);
                    }
                    dlg.FileName = Path.GetFileName(red.RelativePath);
                    dlg.InitialDirectory = directory;
                }
                else
                {
                    dlg.FileName = fileToSave.FilePath != null ? Path.GetFileName(fileToSave.FilePath) : Path.GetFileName(fileToSave.ContentId);
                    dlg.InitialDirectory = Path.GetDirectoryName(fileToSave.FilePath);
                }
                _watcherService.IsSuspended = true;
                if (dlg.ShowDialog().GetValueOrDefault())
                {
                    fileToSave.FilePath = dlg.FileName;
                    ActiveDocument.SaveCommand.SafeExecute();
                }
                _watcherService.IsSuspended = false;
                _ = _watcherService.RefreshAsync(ActiveProject);
            }
            else
            {
                ActiveDocument.SaveCommand.SafeExecute();
            }

        }

        private bool IsInRawFolder(FileModel model) => IsInRawFolder(model.FullName);
        private bool IsInRawFolder(string path) => _projectManager.ActiveProject != null &&
                                                       path.Contains(_projectManager.ActiveProject
                                                           .RawDirectory);

        public Task RequestFileOpen(string fullpath)
        {
            var ext = Path.GetExtension(fullpath).ToLower();

            // double click
            switch (ext)
            {
                // custom raw file extensions
                case $".{nameof(ERawFileFormat.masklist)}":

                // images
                case ".png":
                case ".jpg":
                case ".tga":
                case ".bmp":
                case ".jpeg":
                case ".dds":

                //text
                case ".xml":
                case ".txt":
                case ".ws":

                // other
                case ".mp3":
                case ".wav":
                case ".glb":
                case ".gltf":
                case ".fbx":
                case ".xcf":
                case ".psd":
                case ".apb":
                case ".apx":
                case ".ctw":
                case ".blend":
                case ".zip":
                case ".rar":
                case ".bat":
                case ".yml":
                case ".log":
                case ".ini":
                    ShellExecute();
                    break;

                // double file formats
                case ".csv":
                case ".json":
                    return IsInRawFolder(fullpath) ? Task.Run(() => ShellExecute()) : Task.Run(() => OpenRedengineFile());

                // VIDEO
                case ".bk2":
                    break;

                // AUDIO

                case ".wem":
                    return Task.Run(() => OpenAudioFile());

                case ".subs":
                    return Task.Run(() => PolymorphExecute(fullpath, ".txt"));

                case ".usm":
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
                case "":
                default:
                    return Task.Run(() => OpenRedengineFile());
            }

            return Task.Run(() => true);

            void OpenRedengineFile()
            {
                var trimmedExt = ext.TrimStart('.')?.ToUpper() ?? "";
                var type = EWolvenKitFile.Cr2w;

                var isRedEngineFile = Enum.GetNames<ERedExtension>().Any(x => x.ToUpper().Equals(trimmedExt, StringComparison.Ordinal)) || trimmedExt == "";
                if (isRedEngineFile)
                {
                    type = EWolvenKitFile.Cr2w;
                }
                var isRedscriptFile = Enum.GetNames<ERedScriptExtension>().Any(x => x.ToUpper().Equals(trimmedExt, StringComparison.Ordinal));
                if (isRedscriptFile)
                {
                    type = EWolvenKitFile.Redscript;
                }
                var isTweakFile = Enum.GetNames<ETweakExtension>().Any(x => x.ToUpper().Equals(trimmedExt, StringComparison.Ordinal));
                if (isTweakFile)
                {
                    type = EWolvenKitFile.Tweak;
                }

                if (isRedEngineFile || isRedscriptFile || isTweakFile)
                {
                    DispatcherHelper.RunOnMainThread(() =>
                    {
                        var document = Open(fullpath, type);
                        if (document != null)
                        {
                            if (!DockedViews.Contains(document))
                            {
                                DockedViews.Add(document);
                            }

                            ActiveDocument = document;
                            UpdateTitle();
                        }
                    });
                }
            }

            void OpenAudioFile()
            {
                // commented for testing

                //var z = (AudioToolViewModel)ServiceLocator.Default.ResolveType<AudioToolViewModel>();
                //ExecuteAudioTool();
                //z.AddAudioItem(full);
            }

            void ShellExecute()
            {
                try
                {
                    var proc = new ProcessStartInfo(fullpath.ToEscapedPath()) { UseShellExecute = true };
                    _ = Process.Start(proc);
                }
                catch (Win32Exception)
                {
                    // eat this: no default app set for filetype
                    _loggerService.Error($"No default prgram set in Windows to open file extension {Path.GetExtension(fullpath)}");
                }
            }

            void PolymorphExecute(string path, string extension)
            {
                File.WriteAllBytes(Path.GetTempPath() + "asd." + extension, new byte[] { 0x01 });
                var programname = new StringBuilder();
                _ = NativeMethods.FindExecutable("asd." + extension, Path.GetTempPath(), programname);
                _ = programname.ToString().ToUpper().Contains(".EXE")
                    ? Process.Start(programname.ToString(), path.ToEscapedPath())
                    : throw new InvalidFileTypeException("Invalid file type");
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
