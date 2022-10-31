using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reactive;
using System.Reactive.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using Prism.Commands;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Semver;
using Splat;
using WolvenKit.App.Models;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Common;
using WolvenKit.Common.Exceptions;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.ProjectManagement;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.Interaction;
using WolvenKit.Models;
using WolvenKit.Models.Docking;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Documents;
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.Tools;
using static Microsoft.WindowsAPICodePack.PortableDevices.PropertySystem.Properties;
using static WolvenKit.Common.Wcc.Wcc_lite;
using NativeMethods = WolvenKit.Functionality.NativeWin.NativeMethods;

namespace WolvenKit.ViewModels.Shell
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
        private readonly IPluginService _pluginService;
        private readonly TweakDBService _tweakDBService;
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
            IPluginService pluginService,
            TweakDBService tweakDBService
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
            _pluginService = pluginService;
            _tweakDBService = tweakDBService;

            _homePageViewModel = Locator.Current.GetService<HomePageViewModel>();

            #region commands

            CheckForUpdatesCommand = ReactiveCommand.CreateFromTask<bool>(async x => await CheckForUpdate(x));

            ShowLogCommand = new DelegateCommand(ExecuteShowLog, CanShowLog).ObservesProperty(() => ActiveProject);
            ShowProjectExplorerCommand = new DelegateCommand(ExecuteShowProjectExplorer, CanShowProjectExplorer).ObservesProperty(() => ActiveProject);
            ShowPropertiesCommand = new DelegateCommand(ExecuteShowProperties, CanShowProperties).ObservesProperty(() => ActiveProject);
            ShowAssetsCommand = new DelegateCommand(ExecuteAssetBrowser, CanShowAssetBrowser);

            ShowImportExportToolCommand = new DelegateCommand(ExecuteImportExportTool, CanShowImportExportTool).ObservesProperty(() => ActiveProject);

            ShowSoundModdingToolCommand = new DelegateCommand(ExecuteShowSoundModdingTool, CanShowSoundModdingTool).ObservesProperty(() => IsDialogShown);
            ShowModsViewCommand = new DelegateCommand(ExecuteShowModsView, CanShowModsView).ObservesProperty(() => IsDialogShown);
            ShowPluginCommand = new DelegateCommand(ExecuteShowPlugin, CanShowPlugin).ObservesProperty(() => IsDialogShown);
            ShowScriptManagerCommand = new DelegateCommand(ExecuteShowScriptManager, CanShowScriptManager).ObservesProperty(() => IsDialogShown);

            OpenFileCommand = ReactiveCommand.CreateFromTask<FileModel>(async (m) => await OpenFileAsync(m));
            OpenRedFileCommand = ReactiveCommand.CreateFromTask<FileEntry, Unit>(OpenRedFileAsync);

            // Build
            PackModCommand = ReactiveCommand.CreateFromTask(async () => await LaunchAsync(new LaunchProfile()
            {
                CreateBackup = true
            }));
            PackRedModCommand = ReactiveCommand.CreateFromTask(async () => await LaunchAsync(new LaunchProfile()
            {
                CreateBackup = true,
                IsRedmod = true
            }));

            PackInstallModCommand = ReactiveCommand.CreateFromTask(async () => await LaunchAsync(new LaunchProfile()
            {
                Install = true
            }));
            PackInstallRedModCommand = ReactiveCommand.CreateFromTask(async () => await LaunchAsync(new LaunchProfile()
            {
                Install = true,
                IsRedmod = true,
            }));

            PackInstallRunCommand = ReactiveCommand.CreateFromTask(async () => await LaunchAsync(new LaunchProfile()
            {
                Install = true,
                LaunchGame = true
            }));
            PackInstallRedModRunCommand = ReactiveCommand.CreateFromTask(async () => await LaunchAsync(new LaunchProfile()
            {
                Install = true,
                IsRedmod = true,
                DeployWithRedmod = true,
                LaunchGame = true
            }));

            HotInstallModCommand = ReactiveCommand.CreateFromTask(HotInstallModAsync);

            LaunchOptionsCommand = ReactiveCommand.Create(LaunchOptions);

            NewFileCommand = new DelegateCommand<string>(ExecuteNewFile, CanNewFile).ObservesProperty(() => ActiveProject).ObservesProperty(() => IsDialogShown);

            // File
            SaveFileCommand = new DelegateCommand(ExecuteSaveFile, CanSaveFile).ObservesProperty(() => ActiveDocument);
            SaveAsCommand = new DelegateCommand(ExecuteSaveAs, CanSaveFile).ObservesProperty(() => ActiveDocument);
            SaveAllCommand = new DelegateCommand(ExecuteSaveAll, CanSaveAll).ObservesProperty(() => DockedViews);

            FileSelectedCommand = new DelegateCommand<FileModel>(ExecuteSelectFile, CanSelectFile);

            OpenProjectCommand = ReactiveCommand.CreateFromTask<string, Unit>(OpenProjectAsync);
            DeleteProjectCommand = ReactiveCommand.Create<string>(DeleteProject);
            NewProjectCommand = ReactiveCommand.Create(ExecuteNewProject);

            ShowHomePageCommand = new DelegateCommand(ExecuteShowHomePage, CanShowHomePage).ObservesProperty(() => IsDialogShown);
            ShowSettingsCommand = new DelegateCommand(ExecuteShowSettings, CanShowSettings).ObservesProperty(() => IsDialogShown);
            ShowProjectSettingsCommand = new DelegateCommand(ExecuteShowProjectSettings, CanShowProjectSettings).ObservesProperty(() => IsDialogShown).ObservesProperty(() => ActiveProject);
            OpenLogsCommand = new DelegateCommand(ExecuteOpenLogs);

            LaunchGameCommand = ReactiveCommand.Create<string>(ExecuteLaunchGame);

            CloseModalCommand = new DelegateCommand(ExecuteCloseModal, CanCloseModal).ObservesProperty(() => IsDialogShown).ObservesProperty(() => IsOverlayShown);
            CloseOverlayCommand = new DelegateCommand(ExecuteCloseOverlay, CanCloseOverlay).ObservesProperty(() => IsOverlayShown);
            CloseDialogCommand = new DelegateCommand(ExecuteCloseDialog, CanCloseDialog).ObservesProperty(() => IsDialogShown);


            OpenFileCommand.ThrownExceptions.Subscribe(ex => LogExtended(ex));
            OpenRedFileCommand.ThrownExceptions.Subscribe(ex => LogExtended(ex));
            OpenProjectCommand.ThrownExceptions.Subscribe(ex => LogExtended(ex));

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
            _settingsManager
                .WhenAnyValue(x => x.CP77ExecutablePath)
                .SkipWhile(x => string.IsNullOrWhiteSpace(x) || !File.Exists(x)) // -.-
                .Take(1)
                .Subscribe(x => _pluginService.Init());

            this
                .WhenAnyValue(x => x.Status)
                .Where(x => x == EAppStatus.Loaded)
                .Subscribe(x => HandleActivation());
        }

        #endregion constructors

        #region init

        private void HandleActivation()
        {
            var thisVersion = WolvenKit.Core.CommonFunctions.GetAssemblyVersion(WolvenKit.Functionality.Constants.AssemblyName);
            if (thisVersion.ToString().Contains("nightly") && _settingsManager.UpdateChannel != EUpdateChannel.Nightly)
            {
                _settingsManager.UpdateChannel = EUpdateChannel.Nightly;
            }

            Observable.Start(() => CheckForUpdatesCommand.Execute(true).Subscribe())
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe();
        }

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
                MessageBox.Show(message);
                return false;
            }

            if (Path.GetExtension(args[1]) == ".cpmodproj")
            {
                _ = OpenProjectAsync(args[1]);
                return true;
            }

            if (Enum.TryParse<ERedExtension>(Path.GetExtension(args[1])[1..], out var _))
            {
                _ = OpenFileAsync(new FileModel(args[1], null));
                return true;
            }

            var message2 = $"Sorry, {Path.GetExtension(args[1])} files aren't supported by WolvenKit";
            _loggerService.Error(message2);
            MessageBox.Show(message2);
            return false;
        }

        private async void OnStartup() => await ShowFirstTimeSetup();

        private async Task ShowFirstTimeSetup()
        {
            if (!_settingsManager.IsHealthy())
            {
                var setupWasOk = await Interactions.ShowFirstTimeSetup.Handle(Unit.Default);
                if (setupWasOk)
                {
                    _pluginService.Init();
                }
            }
        }

        #endregion init

        #region commands

        public ReactiveCommand<bool, Unit> CheckForUpdatesCommand { get; }
        private async Task CheckForUpdate(bool checkForCheckForUpdates)
        {
            if (checkForCheckForUpdates)
            {
                if (_settingsManager.SkipUpdateCheck)
                {
                    return;
                }
            }

            var owner = "WolvenKit";
            var name = "WolvenKit";

            switch (_settingsManager.UpdateChannel)
            {
                case EUpdateChannel.Nightly:
                    name = "WolvenKit-nightly-releases";
                    break;
                case EUpdateChannel.Stable:
                default:
                    break;
            }

            // get remote version without GitHub API calls
            SemVersion remoteVersion;
            var githuburl = $@"https://github.com/{owner}/{name}/releases/latest";
            try
            {
                HttpClient _client = new();
                var response = await _client.GetAsync(new Uri(githuburl));
                response.EnsureSuccessStatusCode();

                var version = response.RequestMessage.RequestUri.LocalPath.Split('/').Last();
                remoteVersion = SemVersion.Parse(version, SemVersionStyles.OptionalMinorPatch);
            }
            catch (HttpRequestException ex)
            {
                _loggerService.Error($"Failed to respond to url: {githuburl}");
                _loggerService.Error(ex);
                return;
            }

            var thisVersion = WolvenKit.Core.CommonFunctions.GetAssemblyVersion(WolvenKit.Functionality.Constants.AssemblyName);

            if (remoteVersion.CompareSortOrderTo(thisVersion) > 0)
            {
                var url = $"https://github.com/{owner}/{name}/releases/latest";
                var res = await Interactions.ShowMessageBoxAsync($"Update available: {remoteVersion}\nYou are on the {_settingsManager.UpdateChannel} release channel.\n\nVisit {url} ?", name, WMessageBoxButtons.OkCancel);
                if (res == WMessageBoxResult.OK)
                {
                    Process.Start("explorer", url);
                }
            }
            else
            {
                if (!checkForCheckForUpdates)
                {
                    var res = await Interactions.ShowMessageBoxAsync($"No update available. You are on the latest version.", name, WMessageBoxButtons.Ok);
                }
            }
        }

        public ReactiveCommand<string, Unit> DeleteProjectCommand { get; }
        private void DeleteProject(string parameter)
        {
            try
            {
                var projectToDel = _recentlyUsedItemsService.Items.Items
                    .FirstOrDefault(project => project.Name == parameter);
                if (projectToDel is not null)
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

            if (_projectManager.ActiveProject is not null && !string.IsNullOrEmpty(location))
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
                        CommonOpenFileDialog dlg = new()
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

                await _projectManager.LoadAsync(location);

                ActiveProject = _projectManager.ActiveProject;

                // If the assets can't be found, stop here and notify the user in the log
                if (!File.Exists(_settingsManager.CP77ExecutablePath))
                {
                    UpdateTitle();
                    _loggerService.Warning($"Cyberpunk 2077 executable path is not set. Asset browser disabled.");
                    return Unit.Default;
                }

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
                var newProjectname = project.ProjectName.Trim();
                var projectLocation = Path.Combine(project.ProjectPath, newProjectname, newProjectname + ".cpmodproj");
                Cp77Project np = new(projectLocation)
                {
                    Name = newProjectname,
                    Author = project.Author,
                    Email = project.Email,
                    Version = project.Version
                };

                _projectManager.ActiveProject = np;
                await _projectManager.SaveAsync();
                np.CreateDefaultDirectories();

                await _projectManager.LoadAsync(projectLocation);

                DispatcherHelper.RunOnMainThread(() => ActiveProject = _projectManager.ActiveProject);

                // If the assets can't be found, stop here and notify the user in the log
                if (!File.Exists(_settingsManager.CP77ExecutablePath))
                {
                    UpdateTitle();
                    _loggerService.Warning($"Cyberpunk 2077 executable path is not set. Asset browser disabled.");
                }
                else
                {
                    await _gameControllerFactory.GetController().HandleStartup().ContinueWith(_ =>
                    {
                        UpdateTitle();
                        _notificationService.Success("Project " + project.ProjectName + " loaded!");
                    }, TaskContinuationOptions.OnlyOnRanToCompletion);
                }
            }
            catch (Exception ex)
            {
                _loggerService.Error(ex.Message);
                _loggerService.Error("Failed to create a new project!");
            }

        }

        public ICommand FileSelectedCommand { get; set; }
        private bool CanSelectFile(FileModel model) => true;
        private void ExecuteSelectFile(FileModel model) => PropertiesViewModel.ExecuteSelectFile(model);

        public ICommand SaveFileCommand { get; private set; }
        private bool CanSaveFile() => ActiveDocument is not null; // _projectManager.ActiveProject != null &&
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
            _homePageViewModel.NavigateTo(EHomePage.Welcome);
            SetActiveOverlay(_homePageViewModel);
        }

        public ICommand ShowSettingsCommand { get; private set; }
        private bool CanShowSettings() => !IsDialogShown;
        private void ExecuteShowSettings()
        {

            _homePageViewModel.NavigateTo(EHomePage.Settings);
            SetActiveOverlay(_homePageViewModel);
        }

        public ICommand ShowProjectSettingsCommand { get; private set; }
        private bool CanShowProjectSettings() => !IsDialogShown && ActiveProject != null;
        private void ExecuteShowProjectSettings()
        {
            CloseModalCommand.Execute(null);
            SetActiveDialog(new ProjectSettingsDialogViewModel());
        }

        public ICommand OpenLogsCommand { get; private set; }
        private void ExecuteOpenLogs() => Commonfunctions.ShowFolderInExplorer(ISettingsManager.GetAppData());

        [Reactive] public int SelectedGameCommandIdx { get; set; }

        public record GameLaunchCommand(string Name, EGameLaunchCommand Command);
        public enum EGameLaunchCommand
        {
            Launch,
            SteamLaunch
        }

        public ReactiveCommand<string, Unit> LaunchGameCommand { get; private set; }
        private void ExecuteLaunchGame(string stridx)
        {
            if (!int.TryParse(stridx, out var idx))
            {
                return;
            }

            var command = (EGameLaunchCommand)idx;
            switch (command)
            {
                case EGameLaunchCommand.Launch:
                    try
                    {
                        Process.Start(new ProcessStartInfo
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

                        Process.Start(new ProcessStartInfo
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

                default:
                    break;
            }

            _loggerService.Success("Game launching.");
        }

        public ICommand ShowSoundModdingToolCommand { get; private set; }
        private bool CanShowSoundModdingTool() => !IsDialogShown && ActiveProject != null;
        private void ExecuteShowSoundModdingTool() => SetActiveDialog(new SoundModdingViewModel
        {
            FileHandler = OpenSoundModdingView
        });

        public async Task OpenSoundModdingView(SoundModdingViewModel file)
        {
            CloseModalCommand.Execute(null);
            if (file == null)
            {
                return;
            }
            await Task.CompletedTask;
        }

        public ICommand ShowScriptManagerCommand { get; private set; }
        private bool CanShowScriptManager() => !IsDialogShown;
        private void ExecuteShowScriptManager()
        {
            CloseModalCommand.Execute(null);
            SetActiveDialog(new ScriptManagerViewModel());
        }

        public ICommand ShowPluginCommand { get; private set; }
        private bool CanShowPlugin() => !IsDialogShown;
        private void ExecuteShowPlugin()
        {
            _homePageViewModel.NavigateTo(EHomePage.Plugins);
            SetActiveOverlay(_homePageViewModel);
        }

        public ICommand ShowModsViewCommand { get; private set; }
        private bool CanShowModsView() => !IsDialogShown;
        private void ExecuteShowModsView()
        {
            _homePageViewModel.NavigateTo(EHomePage.Mods);
            SetActiveOverlay(_homePageViewModel);
        }

        public ICommand NewFileCommand { get; private set; }
        private bool CanNewFile(string inputDir) => ActiveProject is not null && !IsDialogShown;
        private void ExecuteNewFile(string inputDir) => SetActiveDialog(new NewFileViewModel
        {
            FileHandler = OpenFromNewFile
        });

        private async Task OpenFromNewFile(NewFileViewModel file)
        {
            CloseModalCommand.Execute(null);
            if (file == null)
            {
                return;
            }

            _watcherService.IsSuspended = true;
            await Task.Run(() => OpenFromNewFileTask(file)).ContinueWith(async (result) =>
            {
                _watcherService.IsSuspended = false;
                await _watcherService.RefreshAsync(ActiveProject);
                await RequestFileOpen(file.FullPath);
            });
        }

        private static async Task OpenFromNewFileTask(NewFileViewModel file)
        {
            Stream stream = null;
            switch (file.SelectedFile.Type)
            {
                case EWolvenKitFile.ArchiveXl:
                case EWolvenKitFile.TweakXl:
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
                        CR2WFile cr2w = new()
                        {
                            RootChunk = RedTypeManager.Create(redType)
                        };
                        stream = new FileStream(file.FullPath, FileMode.Create, FileAccess.Write);
                        using CR2WWriter writer = new(stream);
                        writer.WriteFile(cr2w);
                    }
                    break;
            }
            stream.Dispose();
        }

        public ReactiveCommand<FileModel, Unit> OpenFileCommand { get; }
        private async Task OpenFileAsync(FileModel model)
        {
            if (model == null)
            {
                OpenFileDialog dlg = new();
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
        }

        public ReactiveCommand<FileEntry, Unit> OpenRedFileCommand { get; }
        private async Task<Unit> OpenRedFileAsync(FileEntry file)
        {
            if (file is not null)
            {
                _progressService.IsIndeterminate = true;
                try
                {
                    RedDocumentViewModel fileViewModel = new(file.FileName);
                    await using (MemoryStream stream = new())
                    {
                        file.Extract(stream);
                        fileViewModel.OpenStream(stream, null);
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
                        RedDocumentViewModel fileViewModel = new(fe.FileName);
                        using (MemoryStream stream = new())
                        {
                            fe.Extract(stream);
                            fileViewModel.OpenStream(stream, null);
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

        public bool HasActiveProject() => ActiveProject is not null;


        // Pack mod
        public ReactiveCommand<Unit, Unit> PackModCommand { get; private set; }
        public ReactiveCommand<Unit, Unit> PackRedModCommand { get; private set; }
        public ReactiveCommand<Unit, Unit> PackInstallModCommand { get; private set; }
        public ReactiveCommand<Unit, Unit> PackInstallRedModCommand { get; private set; }
        public ReactiveCommand<Unit, Unit> PackInstallRunCommand { get; private set; }
        public ReactiveCommand<Unit, Unit> PackInstallRedModRunCommand { get; private set; }

        private async Task LaunchAsync(LaunchProfile profile)
        {
            _watcherService.IsSuspended = true;
            await _gameControllerFactory.GetController().LaunchProject(profile);
            _watcherService.IsSuspended = false;
            await _watcherService.RefreshAsync(ActiveProject);
        }

        public ReactiveCommand<Unit, Unit> HotInstallModCommand { get; private set; }
        private Task HotInstallModAsync() => Task.Run(() => _gameControllerFactory.GetController().PackProjectHot());

        public ReactiveCommand<Unit, Unit> LaunchOptionsCommand { get; }
        private async void LaunchOptions() => await Interactions.ShowLaunchProfilesView.Handle(Unit.Default);

        public string CyberpunkBlenderAddonLink = "https://github.com/WolvenKit/Cyberpunk-Blender-add-on";
        public string WolvenKitSetupLink = "https://wiki.redmodding.org/wolvenkit/getting-started/setup";
        public string WolvenKitCreatingAModLink = "https://wiki.redmodding.org/wolvenkit/getting-started/creating-a-mod";
        public string DiscordInvitationLink = "https://discord.gg/Epkq79kd96";
        public string AboutWolvenKitLink = "https://wiki.redmodding.org/wolvenkit/about";


        public ReactiveCommand<string, Unit> OpenExternalLinkCommand = ReactiveCommand.Create<string>(
            link =>
            {
                var ps = new ProcessStartInfo(link)
                {
                    UseShellExecute = true,
                    Verb = "open"
                };
                Process.Start(ps);
            });

        public ICommand ShowAssetsCommand { get; private set; }
        private bool CanShowAssetBrowser() => true;//AssetBrowserVM != null && AssetBrowserVM.IsLoaded;
        private void ExecuteAssetBrowser() => AssetBrowserVM.IsVisible = !AssetBrowserVM.IsVisible;

        public ICommand ShowImportExportToolCommand { get; private set; }
        private bool CanShowImportExportTool() => ActiveProject is not null;
        private void ExecuteImportExportTool() => ImportExportToolVM.IsVisible = !ImportExportToolVM.IsVisible;

        public ICommand ShowLogCommand { get; private set; }
        private bool CanShowLog() => ActiveProject is not null;
        private void ExecuteShowLog() => Log.IsVisible = !Log.IsVisible;

        public ICommand ShowProjectExplorerCommand { get; private set; }
        private bool CanShowProjectExplorer() => ActiveProject is not null;
        private void ExecuteShowProjectExplorer() => ProjectExplorer.IsVisible = !ProjectExplorer.IsVisible;

        public ICommand ShowPropertiesCommand { get; private set; }
        private bool CanShowProperties() => ActiveProject is not null;
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

        [Reactive] public EAppStatus Status { get; set; }

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
            Task.Run(OnAfterOverlayRendered);
        }

        [Reactive] public DialogViewModel ActiveDialog { get; set; }
        public void SetActiveDialog(DialogViewModel modal)
        {
            ActiveDialog = modal;
            //Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Render, (Action)OnAfterRendered);
            Task.Run(OnAfterDialogRendered);
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
            if (ActiveDocument is not null)
            {
                title += ActiveDocument.Header + " - ";
            }

            if (_projectManager.ActiveProject is not null)
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
            if (fileViewModel is not null)
            {
                return fileViewModel;
            }

            // open file
            switch (type)
            {
                case EWolvenKitFile.Cr2w:
                    fileViewModel = new RedDocumentViewModel(fullPath);
                    break;
                case EWolvenKitFile.TweakXl:
                    fileViewModel = new TweakXLDocumentViewModel(fullPath);
                    break;
                case EWolvenKitFile.WScript:
                    fileViewModel = new WScriptDocumentViewModel(fullPath);
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
                SaveFileDialog dlg = new();
                if (fileToSave.FilePath == null && fileToSave is RedDocumentViewModel red)
                {
                    var directory = Path.GetDirectoryName(Path.Combine(_projectManager.ActiveProject.ModDirectory, red.RelativePath));
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }
                    dlg.FileName = Path.GetFileName(red.RelativePath);
                    dlg.InitialDirectory = directory;
                }
                else
                {
                    dlg.FileName = fileToSave.FilePath is not null ? Path.GetFileName(fileToSave.FilePath) : Path.GetFileName(fileToSave.ContentId);
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

        private bool IsInRawFolder(string path) => _projectManager.ActiveProject is not null &&
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
                    //case ".yaml":
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

                var isTweakFile = Enum.GetNames<ETweakExtension>().Any(x => x.ToUpper().Equals(trimmedExt, StringComparison.Ordinal));
                if (isTweakFile)
                {
                    type = EWolvenKitFile.TweakXl;
                    isRedEngineFile = true;
                }

                var isWScriptFile = Enum.GetNames<EWScriptExtension>().Any(x => x.ToUpper().Equals(trimmedExt, StringComparison.Ordinal));
                if (isWScriptFile)
                {
                    type = EWolvenKitFile.WScript;
                    isRedEngineFile = true;
                }

                if (isRedEngineFile)
                {
                    DispatcherHelper.RunOnMainThread(() =>
                    {
                        var document = Open(fullpath, type);
                        if (document is not null)
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
                    ProcessStartInfo proc = new(fullpath.ToEscapedPath()) { UseShellExecute = true };
                    Process.Start(proc);
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
                StringBuilder programname = new();
                _ = NativeMethods.FindExecutable("asd." + extension, Path.GetTempPath(), programname);
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

        public void SetStatusReady() => Status = EAppStatus.Loaded;
        public void SetLaunchProfiles(ObservableCollection<LaunchProfileViewModel> launchProfiles)
        {
            _settingsManager.LaunchProfiles.Clear();
            var _launchProfiles = new Dictionary<string, LaunchProfile>();

            foreach (var item in launchProfiles)
            {
                if (!_settingsManager.LaunchProfiles.ContainsKey(item.Name))
                {
                    _launchProfiles.Add(item.Name, item.Profile);
                }
            }

            _settingsManager.LaunchProfiles = _launchProfiles;
            _settingsManager.Save();

        }

        #endregion methods
    }
}
