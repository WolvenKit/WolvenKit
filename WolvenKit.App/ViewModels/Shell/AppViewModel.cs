using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using Semver;
using WolvenKit.App.Controllers;
using WolvenKit.App.Extensions;
using WolvenKit.App.Factories;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.Models.ProjectManagement;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.HomePage;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Exceptions;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using NativeMethods = WolvenKit.App.Helpers.NativeMethods;

namespace WolvenKit.App.ViewModels.Shell;

public partial class AppViewModel : ObservableObject/*, IAppViewModel*/
{
    private readonly IDocumentViewmodelFactory _documentViewmodelFactory;
    private readonly IPaneViewModelFactory _paneViewModelFactory;
    private readonly IDialogViewModelFactory _dialogViewModelFactory;
    private readonly IPageViewModelFactory _pageViewModelFactory;

    private readonly ILoggerService _loggerService;
    private readonly IProjectManager _projectManager;
    private readonly IGameControllerFactory _gameControllerFactory;
    private readonly ISettingsManager _settingsManager;
    private readonly INotificationService _notificationService;
    private readonly IRecentlyUsedItemsService _recentlyUsedItemsService;
    private readonly IProgressService<double> _progressService;
    private readonly IWatcherService _watcherService;
    private readonly IPluginService _pluginService;
    private readonly IArchiveManager _archiveManager;
    private readonly IHashService _hashService;
    private readonly ITweakDBService _tweakDBService;
    private readonly Red4ParserService _parser;

    /// <summary>
    /// Class constructor
    /// </summary>
    public AppViewModel(
        IDocumentViewmodelFactory documentViewmodelFactory,
        IPaneViewModelFactory paneViewModelFactory,
        IDialogViewModelFactory dialogViewModelFactory,
        IPageViewModelFactory pageViewModelFactory,
        IProjectManager projectManager,
        ILoggerService loggerService,
        IGameControllerFactory gameControllerFactory,
        ISettingsManager settingsManager,
        INotificationService notificationService,
        IRecentlyUsedItemsService recentlyUsedItemsService,
        IProgressService<double> progressService,
        IWatcherService watcherService,
        IPluginService pluginService,
        IArchiveManager archiveManager,
        IHashService hashService,
        ITweakDBService tweakDBService,
        Red4ParserService parserService
    )
    {
        _documentViewmodelFactory = documentViewmodelFactory;
        _paneViewModelFactory = paneViewModelFactory;
        _dialogViewModelFactory = dialogViewModelFactory;
        _pageViewModelFactory = pageViewModelFactory;
        _projectManager = projectManager;
        _loggerService = loggerService;
        _gameControllerFactory = gameControllerFactory;
        _settingsManager = settingsManager;
        _notificationService = notificationService;
        _recentlyUsedItemsService = recentlyUsedItemsService;
        _progressService = progressService;
        _watcherService = watcherService;
        _pluginService = pluginService;
        _archiveManager = archiveManager;
        _hashService = hashService;
        _tweakDBService = tweakDBService;
        _parser = parserService;

        UpdateTitle();

        ShowFirstTimeSetup();
    }

    #region init

    partial void OnStatusChanged(EAppStatus? value)
    {
        if (value == EAppStatus.Loaded)
        {
            HandleActivation();
        }
    }

    private void HandleActivation()
    {
        var thisVersion = Core.CommonFunctions.GetAssemblyVersion(Constants.AssemblyName);
        if (thisVersion.ToString().Contains("nightly") && _settingsManager.UpdateChannel != EUpdateChannel.Nightly)
        {
            _settingsManager.UpdateChannel = EUpdateChannel.Nightly;
        }

        _pluginService.Init();
        if (!TryLoadingArguments())
        {
            ShowHomePageSync();
        }

        AddDockedPanes();       

        CheckForUpdatesCommand.SafeExecute(true);
    }

    private void AddDockedPanes()
    {
        // only add existing docked views
        if (File.Exists(Path.Combine(ISettingsManager.GetAppData(), "DockPanes.txt")))
        {
            var savedPanes = File.ReadLines(Path.Combine(ISettingsManager.GetAppData(), "DockPanes.txt"));
            foreach (var paneString in savedPanes)
            {
                if (Enum.TryParse<EDockedViews>(paneString, out var pane))
                {
                    switch (pane)
                    {
                        case EDockedViews.LogViewModel:
                            DockedViews.Add(_paneViewModelFactory.LogViewModel());
                            break;
                        case EDockedViews.ProjectExplorerViewModel:
                            DockedViews.Add(_paneViewModelFactory.ProjectExplorerViewModel(this));
                            break;
                        case EDockedViews.PropertiesViewModel:
                            DockedViews.Add(_paneViewModelFactory.PropertiesViewModel());
                            break;
                        case EDockedViews.AssetBrowserViewModel:
                            DockedViews.Add(_paneViewModelFactory.AssetBrowserViewModel(this));
                            break;
                        case EDockedViews.TweakBrowserViewModel:
                            DockedViews.Add(_paneViewModelFactory.TweakBrowserViewModel(this));
                            break;
                        case EDockedViews.LocKeyBrowserViewModel:
                            DockedViews.Add(_paneViewModelFactory.LocKeyBrowserViewModel());
                            break;
                        case EDockedViews.TextureImportViewModel:
                        {
                            var vm = _paneViewModelFactory.TextureImportViewModel();
                            vm.State = DockState.Dock;
                            vm.SideInDockedMode = DockSide.Right;
                            DockedViews.Add(vm);
                            break;
                        }
                        case EDockedViews.TextureExportViewModel:
                        {
                            var vm = _paneViewModelFactory.TextureExportViewModel();
                            vm.State = DockState.Dock;
                            vm.SideInDockedMode = DockSide.Right;
                            DockedViews.Add(vm);
                            break;
                        }
                        default:
                            break;
                    }
                }
            }
        }
        else
        {
            DockedViews = new ObservableCollection<IDockElement> {
                _paneViewModelFactory.LogViewModel(),
                _paneViewModelFactory.ProjectExplorerViewModel(this),
                _paneViewModelFactory.PropertiesViewModel(),
                _paneViewModelFactory.AssetBrowserViewModel(this),
                _paneViewModelFactory.TweakBrowserViewModel(this),
                _paneViewModelFactory.LocKeyBrowserViewModel()
            };
        }
    }


    private bool TryLoadingArguments()
    {
        var args = Environment.GetCommandLineArgs();

        if (args.Length != 2)
        {
            return false;
        }

        var filePath = args[1];

        if (!File.Exists(filePath))
        {
            var message = $"Sorry, '{filePath}' could not be found";
            _loggerService.Error(message);
            MessageBox.Show(message);
            return false;
        }

        if (Path.GetExtension(filePath) == ".cpmodproj")
        {
            _ = OpenProjectAsync(filePath);
            return true;
        }

        // open files
        if (Enum.TryParse<ERedExtension>(Path.GetExtension(filePath)[1..], out var _))
        {
            _ = OpenFileAsync(new FileModel(filePath, ActiveProject.NotNull())); // TODO
            return true;
        }

        var message2 = $"Sorry, {Path.GetExtension(filePath)} files aren't supported by WolvenKit";
        _loggerService.Error(message2);
        MessageBox.Show(message2);
        return false;
    }

    private void ShowFirstTimeSetup()
    {
        if (!_settingsManager.IsHealthy())
        {
            var setupWasOk = Interactions.ShowFirstTimeSetup();
        }
    }

    #endregion init

    #region commands

    [RelayCommand] private async Task PackMod() => await LaunchAsync(new LaunchProfile() { CreateBackup = true });
    [RelayCommand] private async Task PackRedMod() => await LaunchAsync(new LaunchProfile() { CreateBackup = true, IsRedmod = true });
    [RelayCommand] private async Task PackInstallMod() => await LaunchAsync(new LaunchProfile() { Install = true });
    [RelayCommand] private async Task PackInstallRedMod() => await LaunchAsync(new LaunchProfile() { Install = true, IsRedmod = true });
    [RelayCommand] private async Task PackInstallRun() => await LaunchAsync(new LaunchProfile() { Install = true, LaunchGame = true });
    [RelayCommand] private async Task PackInstallRedModRun() => await LaunchAsync(new LaunchProfile() { Install = true, LaunchGame = true, IsRedmod = true, DeployWithRedmod = true });

    [RelayCommand]
    private async Task CheckForUpdates(bool checkForCheckForUpdates)
    {
        if (DesktopBridgeHelper.IsRunningAsPackage())
        {
            // don't check for updates for packaged apps
            return;
        }

        if (checkForCheckForUpdates)
        {
            if (_settingsManager.SkipUpdateCheck)
            {
                return;
            }
        }

        // check if installer is installed
        await InstallInstaller();

        // get remote version without GitHub API calls
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

        SemVersion remoteVersion;
        var githuburl = $@"https://github.com/{owner}/{name}/releases/latest";
        try
        {
            HttpClient _client = new();
            var response = await _client.GetAsync(new Uri(githuburl));
            response.EnsureSuccessStatusCode();
            if (response?.RequestMessage?.RequestUri is null)
            {
                return;
            }
            var version = response.RequestMessage.RequestUri.LocalPath.Split('/').Last();
            remoteVersion = SemVersion.Parse(version, SemVersionStyles.OptionalMinorPatch);
        }
        catch (HttpRequestException ex)
        {
            _loggerService.Error($"Failed to respond to updater url: {githuburl}");
            _loggerService.Error(ex);
            return;
        }

        var thisVersion = Core.CommonFunctions.GetAssemblyVersion(Constants.AssemblyName);

        // if remoteVersion is later than thisVersion
        if (remoteVersion.CompareSortOrderTo(thisVersion) <= 0)
        {
            if (!checkForCheckForUpdates)
            {
                await Interactions.ShowMessageBoxAsync($"No update available. You are on the latest version.", name, WMessageBoxButtons.Ok);
            }
        }
        else
        {
            if (DesktopBridgeHelper.IsWindows10OrHigher() && DesktopBridgeHelper.PowershellExists())
            {
                // win10 updater app
                var res = await Interactions.ShowMessageBoxAsync($"Update available: {remoteVersion}\nYou are on the {_settingsManager.UpdateChannel} release channel.\n\nUpdate now?", name, WMessageBoxButtons.OkCancel);
                if (res == WMessageBoxResult.OK)
                {
                    // run installer app
                    (_, var location) = GetInstallerPackage();
                    if (!string.IsNullOrEmpty(location))
                    {
                        var executable = Path.Combine(location, "Wolvenkit.Installer.exe");
                        if (File.Exists(executable))
                        {
                            var id = name;
                            if (thisVersion.ToString().Contains("nightly"))
                            {
                                id = "WolvenKit Nightly";
                            }
                            var thisLocation = AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar).TrimEnd(Path.AltDirectorySeparatorChar);

                            var process = new Process();
                            process.StartInfo.FileName = executable;
                            var args = $"-t \"{thisLocation}\" -i \"{id}\" -v {thisVersion}";
                            process.StartInfo.Arguments = args;
                            process.Start();
                        }
                    }
                }
            }
            else
            {
                // old style update
                // TODO use inno
                var url = $"https://github.com/{owner}/{name}/releases/latest";
                var res = await Interactions.ShowMessageBoxAsync($"Update available: {remoteVersion}\nYou are on the {_settingsManager.UpdateChannel} release channel.\n\nVisit {url} ?", name, WMessageBoxButtons.OkCancel);
                if (res == WMessageBoxResult.OK)
                {
                    Process.Start("explorer", url);
                }
            }

        }

    }

    private async Task InstallInstaller()
    {
        if (!DesktopBridgeHelper.IsWindows10OrHigher())
        {
            _loggerService.Warning("The auto-update feature is only supported for Windows 10 or later");
            return;
        }

        if (!DesktopBridgeHelper.PowershellExists())
        {
            _loggerService.Warning("The auto-update feature requires powershell to be installed");
            return;
        }

        string location;

        // only check if installer has been installed.
        (var localInstallerVersion, location) = GetInstallerPackage();
        // and check if version is > 0.2.2

        var minVersion = SemVersion.Parse("0.2.2", SemVersionStyles.OptionalMinorPatch);

        // if not installed or installed version is lower than minversion
        if (string.IsNullOrEmpty(location) || localInstallerVersion is not null && localInstallerVersion.CompareSortOrderTo(minVersion) <= 0)
        {
            if (await Interactions.ShowMessageBoxAsync($"WolvenKit will install a helper tool to check for updates.", "WolvenKit.Installer", WMessageBoxButtons.OkCancel) == WMessageBoxResult.OK)
            {
                var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Wolvenkit.Installer.Package.appinstaller");

                try
                {
                    using var p = new Process();
                    p.StartInfo.FileName = "powershell.exe";
                    p.StartInfo.Arguments = $"Add-AppxPackage -AppInstallerFile '{fileName}'";
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.Start();

                    var output = p.StandardOutput.ReadToEnd();

                    p.WaitForExit();

                    _loggerService.Info("Wolvenkit.Installer was installed");
                    _loggerService.Info(output);
                }
                catch (Exception ex)
                {
                    _loggerService.Success("Error installing Wolvenkit.Installer");
                    _loggerService.Error(ex);
                }
            }
        }
    }

    [RelayCommand]
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

    [RelayCommand]
    private async Task OpenProjectAsync(string location)
    {
        // switch from one active project to another

        if (_projectManager.ActiveProject is not null && !string.IsNullOrEmpty(location))
        {
            if (_projectManager.ActiveProject.Location == location)
            {
                return;
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
                        return;
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
                        return;
                    }

                    var result = dlg.FileName;
                    if (string.IsNullOrEmpty(result))
                    {
                        return;
                    }

                    location = result;
                }
            }

            // one last check
            if (!File.Exists(location))
            {
                return;
            }

            CloseModalCommand.SafeExecute(null);

            var p = await _projectManager.LoadAsync(location);
            if (p is null)
            {
                return;
            }
            ActiveProject = p;

            // If the assets can't be found, stop here and notify the user in the log
            if (!File.Exists(_settingsManager.CP77ExecutablePath))
            {
                UpdateTitle();
                _loggerService.Warning($"Cyberpunk 2077 executable path is not set. Asset browser disabled.");
                return;
            }

            await _gameControllerFactory.GetController().HandleStartup().ContinueWith(_ =>
            {
                UpdateTitle();
                _notificationService.Success($"Project {Path.GetFileNameWithoutExtension(location)} loaded!");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);
        }
        catch (Exception e)
        {
            // TODO: Are we intentionally swallowing this?
            //Log.Error(ex, "Failed to open file");
            _loggerService.Error(e);
        }

        return;
    }

    [RelayCommand]
    private async Task NewProject()
    {
        //IsOverlayShown = false;
        await SetActiveDialog(new ProjectWizardViewModel
        {
            FileHandler = NewProject
        });
    }

    private async Task NewProject(ProjectWizardViewModel? project)
    {

        if (project == null)
        {
            CloseDialogCommand.Execute(null);
            return;
        }
        CloseModalCommand.Execute(null);
        await Task.Run(() => NewProjectTask(project));
    }

    private async Task NewProjectTask(ProjectWizardViewModel project)
    {
        try
        {
            var newProjectname = project.ProjectName.NotNull().Trim();
            var projectLocation = Path.Combine(project.ProjectPath.NotNull(), newProjectname, newProjectname + ".cpmodproj");
            Cp77Project np = new(projectLocation, newProjectname)
            {
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

    [RelayCommand]
    private void SelectFile(FileModel model) => GetToolViewModel<PropertiesViewModel>().ExecuteSelectFile(model);

    private bool CanSaveFile() => ActiveDocument is not null;
    [RelayCommand(CanExecute = nameof(CanSaveFile))]
    private void SaveFile() => Save(ActiveDocument.NotNull());

    [RelayCommand(CanExecute = nameof(CanSaveFile))]
    private void SaveAs() => Save(ActiveDocument.NotNull(), true);

    private bool CanSaveAll() => DockedViews.OfType<IDocumentViewModel>().Count() > 0;
    [RelayCommand(CanExecute = nameof(CanSaveAll))]
    private void SaveAll()
    {
        foreach (var file in DockedViews.OfType<IDocumentViewModel>())
        {
            Save(file);
        }
    }

    private bool CanShowHomePage() => !IsDialogShown;
    [RelayCommand(CanExecute = nameof(CanShowHomePage))]
    private async Task ShowHomePage()
    {
        await ShowHomePage(EHomePage.Welcome);
    }

    private bool CanShowSettings() => !IsDialogShown;
    [RelayCommand(CanExecute = nameof(CanShowSettings))]
    private async Task ShowSettings()
    {
        await ShowHomePage(EHomePage.Settings);
    }

    private bool CanShowProjectSettings() => !IsDialogShown && ActiveProject != null;
    [RelayCommand(CanExecute = nameof(CanShowProjectSettings))]
    private async Task ShowProjectSettings()
    {
        CloseModalCommand.Execute(null);
        await SetActiveDialog(new ProjectSettingsDialogViewModel(_projectManager, _pluginService, this));
    }

    [RelayCommand]
    private void OpenLogs() => Commonfunctions.ShowFolderInExplorer(ISettingsManager.GetAppData());

    [ObservableProperty]
    private int? _selectedGameCommandIdx;

    public record GameLaunchCommand(string Name, EGameLaunchCommand Command);
    public enum EGameLaunchCommand
    {
        Launch,
        SteamLaunch
    }

    [RelayCommand]
    private void LaunchGame(string stridx)
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

    private bool CanShowSoundModdingTool() => !IsDialogShown && ActiveProject != null;
    [RelayCommand(CanExecute = nameof(CanShowSoundModdingTool))]
    private async Task ShowSoundModdingTool()
    {
        var vm = _dialogViewModelFactory.SoundModdingViewModel();
        if (vm != null)
        {
            vm.FileHandler = OpenSoundModdingView;
            await SetActiveDialog(vm);
        }

        //var vm = new SoundModdingViewModel
        //{
        //    FileHandler = OpenSoundModdingView
        //};
    }

    public async Task OpenSoundModdingView(SoundModdingViewModel? file)
    {
        CloseModalCommand.Execute(null);
        if (file == null)
        {
            return;
        }
        await Task.CompletedTask;
    }

    private bool CanShowScriptManager() => !IsDialogShown;
    [RelayCommand(CanExecute = nameof(CanShowScriptManager))]
    private async Task ShowScriptManager()
    {
        CloseModalCommand.Execute(null);
        await SetActiveDialog(new ScriptManagerViewModel(this));
    }

    private bool CanShowPlugin() => !IsDialogShown;
    [RelayCommand(CanExecute = nameof(CanShowPlugin))]
    private async Task ShowPlugin()
    {
        await ShowHomePage(EHomePage.Plugins);
    }

    private bool CanShowModsView() => !IsDialogShown;
    [RelayCommand(CanExecute = nameof(CanShowModsView))]
    private async Task ShowModsView()
    {
        await ShowHomePage(EHomePage.Mods);
    }

    private bool CanNewFile(string inputDir) => ActiveProject is not null && !IsDialogShown;
    [RelayCommand(CanExecute = nameof(CanNewFile))]
    private async Task NewFile(string? inputDir)
    {
        var vm = _dialogViewModelFactory.NewFileViewModel();
        if (vm != null)
        {
            vm.FileHandler = OpenFromNewFile;
            await SetActiveDialog(vm);
        }
        //SetActiveDialog(new NewFileViewModel
        //{
        //    FileHandler = OpenFromNewFile
        //});
    }

    private async Task OpenFromNewFile(NewFileViewModel? file)
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
            if (file.FullPath is not null)
            {
                await RequestFileOpen(file.FullPath);
            }
        });
    }

    private static async Task OpenFromNewFileTask(NewFileViewModel file)
    {
        if (file.SelectedFile is null)
        {
            return;
        }
        if (file.FullPath is null)
        {
            return;
        }

        Stream? stream = null;
        switch (file.SelectedFile.Type)
        {
            case EWolvenKitFile.ArchiveXl:
            case EWolvenKitFile.TweakXl:
                if (!string.IsNullOrEmpty(file.SelectedFile.Template))
                {
                    await using var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream($"WolvenKit.App.Resources.{file.SelectedFile.Template}").NotNull();
                    stream = new FileStream(file.FullPath, FileMode.Create, FileAccess.Write);
                    resource.CopyTo(stream);
                }
                else
                {
                    stream = File.Create(file.FullPath);
                }
                break;
            case EWolvenKitFile.RedScript:
            case EWolvenKitFile.CETLua:
                //prep the subdirs
                var scriptDirName = Path.GetDirectoryName(file.FullPath).NotNull();
                Directory.CreateDirectory(scriptDirName);
                if (!string.IsNullOrEmpty(file.SelectedFile.Template))
                {
                    await using var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream($"WolvenKit.App.Resources.{file.SelectedFile.Template}").NotNull();
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
                if (!string.IsNullOrEmpty(redType))
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
            case EWolvenKitFile.WScript:
                throw new NotImplementedException();
            default:
                break;
        }

        stream?.Dispose();
    }

    [RelayCommand]
    public async Task OpenFileAsync(FileModel model)
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

    [RelayCommand]
    private async Task OpenRedFileAsync(FileEntry file)
    {
        if (file is not null)
        {
            _progressService.IsIndeterminate = true;
            try
            {
                await using MemoryStream stream = new();
                file.Extract(stream);
                if (OpenStream(stream, file.FileName, out var redfile))
                {
                    RedDocumentViewModel fileViewModel = _documentViewmodelFactory.RedDocumentViewModel(redfile, file.FileName, this);
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

    public void OpenFileFromDepotPath(ResourcePath path)
    {
        // it should be resolved by this point, but check just in case
        if (!_hashService.Contains(path) && !ResourcePath.IsNullOrEmpty(path))
        {
            _hashService.AddCustom(path.GetResolvedText().NotNull());
        }

        OpenFileFromHash(path);
    }

    public void OpenFileFromHash(ulong hash)
    {
        if (hash != 0)
        {
            _progressService.IsIndeterminate = true;
            try
            {
                var file = _archiveManager.Lookup(hash);
                if (file.HasValue && file.Value is FileEntry fe)
                {
                    using MemoryStream stream = new();
                    fe.Extract(stream);

                    if (OpenStream(stream, fe.FileName, out var redfile))
                    {
                        var fileNameWithExt = $"{Path.GetFileNameWithoutExtension(fe.FileName)}{fe.Extension}";
                        RedDocumentViewModel fileViewModel = _documentViewmodelFactory.RedDocumentViewModel(redfile, fileNameWithExt, this);
                        if (!DockedViews.Contains(fileViewModel))
                        {
                            DockedViews.Add(fileViewModel);
                        }

                        ActiveDocument = fileViewModel;
                        UpdateTitle();

                    }
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


    [RelayCommand]
    private Task CleanAllAsync() => Task.Run(() => _gameControllerFactory.GetController().CleanAll());

    private async Task LaunchAsync(LaunchProfile profile)
    {
        _watcherService.IsSuspended = true;
        await _gameControllerFactory.GetController().LaunchProject(profile);
        _watcherService.IsSuspended = false;
        await _watcherService.RefreshAsync(ActiveProject);
    }

    [RelayCommand]
    private Task HotInstallModAsync() => Task.Run(() => _gameControllerFactory.GetController().PackProjectHot());

    [RelayCommand]
    private void LaunchOptions()
    {
        Interactions.ShowLaunchProfilesView();
    }

    [RelayCommand]
    private void ShowTextureImporter()
    {
        var vm = _paneViewModelFactory.TextureImportViewModel();
        vm.State = DockState.Float;
        DockedViews.Add(vm);
    }

    [RelayCommand]
    private void ShowTextureExporter()
    {
        var vm = _paneViewModelFactory.TextureExportViewModel();
        vm.State = DockState.Float;
        DockedViews.Add(vm);
    }

    public string CyberpunkBlenderAddonLink = "https://github.com/WolvenKit/Cyberpunk-Blender-add-on";
    public string WolvenKitSetupLink = "https://wiki.redmodding.org/wolvenkit/getting-started/setup";
    public string WolvenKitCreatingAModLink = "https://wiki.redmodding.org/wolvenkit/getting-started/creating-a-mod";
    public string DiscordInvitationLink = "https://discord.gg/Epkq79kd96";
    public string AboutWolvenKitLink = "https://wiki.redmodding.org/wolvenkit/about";


    [RelayCommand]
    private void OpenExternalLink(string link)
    {
        var ps = new ProcessStartInfo(link)
        {
            UseShellExecute = true,
            Verb = "open"
        };
        Process.Start(ps);
    }

    public T GetToolViewModel<T>() where T : IDockElement
    {
        var vm = DockedViews.FirstOrDefault(x => x is T);
        if (vm is T result)
        {
            return result;
        }
        else
        {
            var newvm = _paneViewModelFactory.GetToolViewModel<T>();
            DockedViews.Add(newvm);
            return newvm;
        }
    }


    [RelayCommand]
    private void ShowAssetBrowser() => GetToolViewModel<AssetBrowserViewModel>().IsVisible = !GetToolViewModel<AssetBrowserViewModel>().IsVisible;

    private bool CanShowLog() => ActiveProject is not null;
    [RelayCommand(CanExecute = nameof(CanShowLog))]
    private void ShowLog() => GetToolViewModel<LogViewModel>().IsVisible = !GetToolViewModel<LogViewModel>().IsVisible;

    private bool CanShowProjectExplorer() => ActiveProject is not null;
    [RelayCommand(CanExecute = nameof(CanShowProjectExplorer))]
    private void ShowProjectExplorer() => GetToolViewModel<ProjectExplorerViewModel>().IsVisible = !GetToolViewModel<ProjectExplorerViewModel>().IsVisible;

    private bool CanShowProperties() => ActiveProject is not null;
    [RelayCommand(CanExecute = nameof(CanShowProperties))]
    private void ShowProperties() => GetToolViewModel<PropertiesViewModel>().IsVisible = !GetToolViewModel<PropertiesViewModel>().IsVisible;

    //private bool CanCloseModal() => IsDialogShown || IsOverlayShown;
    [RelayCommand]
    private void CloseModal()
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

    private bool CanCloseOverlay() => IsOverlayShown;
    [RelayCommand(CanExecute = nameof(CanCloseOverlay))]
    private void CloseOverlay() => ShouldOverlayShow = false;

    private bool CanCloseDialog() => IsDialogShown;
    [RelayCommand(CanExecute = nameof(CanCloseDialog))]
    private void CloseDialog() => ShouldDialogShow = false;

    #endregion commands

    #region properties

    public bool IsUpdateAvailable { get; set; }

    [ObservableProperty]
    private EAppStatus? _status;

    [ObservableProperty]
    private string? _title;

    [ObservableProperty]
    private bool _shouldDialogShow;

    [ObservableProperty]
    private bool _shouldOverlayShow;

    [ObservableProperty]
    //[NotifyCanExecuteChangedFor(nameof(CloseModalCommand))]
    [NotifyCanExecuteChangedFor(nameof(CloseOverlayCommand))]
    private bool _isOverlayShown;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(ShowHomePageCommand))]
    [NotifyCanExecuteChangedFor(nameof(ShowSettingsCommand))]
    [NotifyCanExecuteChangedFor(nameof(ShowProjectSettingsCommand))]
    [NotifyCanExecuteChangedFor(nameof(ShowSoundModdingToolCommand))]
    [NotifyCanExecuteChangedFor(nameof(ShowScriptManagerCommand))]
    [NotifyCanExecuteChangedFor(nameof(ShowPluginCommand))]
    [NotifyCanExecuteChangedFor(nameof(ShowModsViewCommand))]
    [NotifyCanExecuteChangedFor(nameof(NewFileCommand))]
    //[NotifyCanExecuteChangedFor(nameof(CloseModalCommand))]
    [NotifyCanExecuteChangedFor(nameof(CloseDialogCommand))]
    private bool _isDialogShown;

    [ObservableProperty]
    private ObservableObject? _activeOverlay;

    [ObservableProperty] 
    private DialogViewModel? _activeDialog;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(SaveFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(SaveAsCommand))]
    private IDocumentViewModel? _activeDocument;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(ShowProjectSettingsCommand))]
    [NotifyCanExecuteChangedFor(nameof(ShowSoundModdingToolCommand))]
    [NotifyCanExecuteChangedFor(nameof(NewFileCommand))]
    [NotifyCanExecuteChangedFor(nameof(ShowLogCommand))]
    [NotifyCanExecuteChangedFor(nameof(ShowProjectExplorerCommand))]
    [NotifyCanExecuteChangedFor(nameof(ShowPropertiesCommand))]
    private Cp77Project? _activeProject;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(SaveAllCommand))]
    private ObservableCollection<IDockElement> _dockedViews = new();

    #endregion properties

    #region methods

    private static (SemVersion?, string) GetInstallerPackage()
    {
        using var p = new Process();
        p.StartInfo.FileName = "powershell.exe";
        p.StartInfo.Arguments = $"Get-AppxPackage -Name \"*WolvenKit.Installer*\" | ft Version, InstallLocation -AutoSize -HideTableHeaders";
        p.StartInfo.UseShellExecute = false;
        p.StartInfo.CreateNoWindow = true;
        p.StartInfo.RedirectStandardOutput = true;
        p.Start();

        var output = p.StandardOutput.ReadToEnd();

        p.WaitForExit();

        SemVersion? semVersion = null;
        var path = "";

        if (!string.IsNullOrEmpty(output))
        {
            output = output.Replace("\r\n", string.Empty).Trim();
            var pieces = output.Split(new[] { ' ' }, 2);
            var version = pieces[0];
            semVersion = string.IsNullOrEmpty(version) ? null : SemVersion.Parse(version.TrimEnd('0').TrimEnd('.'), SemVersionStyles.OptionalMinorPatch);
            path = pieces[1];
        }
        return (semVersion, path);
    }
    public void ShowHomePageSync(EHomePage page = EHomePage.Welcome)
    {
        var homePage = _pageViewModelFactory.HomePageViewModel(this);
        homePage.SelectedIndex = (int)page;

        ActiveOverlay = homePage;
        IsOverlayShown = true;
        ShouldOverlayShow = true;
    }

    public async Task ShowHomePage(EHomePage page)
    {
        var homePage = _pageViewModelFactory.HomePageViewModel(this);
        homePage.SelectedIndex = (int)page;

        ActiveOverlay = homePage;

        await Task.Run(OnAfterOverlayRendered);
    }

    public async Task SetActiveDialog(DialogViewModel modal)
    {
        ActiveDialog = modal;
        await Task.Run(OnAfterDialogRendered);
    }

    private void OnAfterOverlayRendered()
    {
        Application.Current.Dispatcher.Invoke(() =>
        {
            IsOverlayShown = true;
            ShouldOverlayShow = true;
        }, DispatcherPriority.Render);
    }
    private void OnAfterDialogRendered()
    {
        Application.Current.Dispatcher.Invoke(() =>
        {
            IsDialogShown = true;
            ShouldDialogShow = true;
        }, DispatcherPriority.Render);
    }

    private void LogExtended(Exception ex) => _loggerService.Error($"Message: {ex.Message}\nSource: {ex.Source}\nStackTrace: {ex.StackTrace}");

    [MemberNotNull(nameof(Title))]
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

    private bool OpenStream(Stream stream, string path, [NotNullWhen(true)] out CR2WFile? file)
    {
        using var reader = new BinaryReader(stream);

        if (!_parser.TryReadRed4File(reader, out file))
        {
            _loggerService.Error($"Failed to read cr2w file {path}");
            return false;
        }

        return true;
    }

    private bool OpenFile(string path, [NotNullWhen(true)] out CR2WFile? file)
    {
        file = null;
        try
        {
            using var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            if (OpenStream(stream, path, out file))
            {
                return true;
            }
        }
        catch (Exception e)
        {
            _loggerService.Error(e);
        }

        return false;
    }



    private async Task LoadTweakDB()
    {
        if (_tweakDBService.IsLoaded)
        {
            return;
        }

        await _tweakDBService.LoadDB(Path.Combine(_settingsManager.GetRED4GameRootDir(), "r6", "cache", "tweakdb.bin"));
    }

    /// <summary>
    /// Open a file and return its content in a viewmodel.
    /// </summary>
    /// <returns></returns>
    private async Task<IDocumentViewModel?> Open(string fullPath, EWolvenKitFile type)
    {
        var result = false;

        // Check if we have already loaded this file and return it if so
        var fileViewModel = DockedViews.OfType<IDocumentViewModel>().FirstOrDefault(fm => fm.ContentId == fullPath);
        if (fileViewModel is not null)
        {
            return fileViewModel;
        }

        // open file
        switch (type)
        {
            case EWolvenKitFile.Cr2w:
                if (OpenFile(fullPath, out var file))
                {
                    fileViewModel = _documentViewmodelFactory.RedDocumentViewModel(file, fullPath, this);
                    result = fileViewModel.IsInitialized();
                }
                break;
            case EWolvenKitFile.TweakXl:
                await LoadTweakDB();
                fileViewModel = _documentViewmodelFactory.TweakXLDocumentViewModel(fullPath);
                result = fileViewModel.IsInitialized();
                break;
            case EWolvenKitFile.WScript:
                fileViewModel = _documentViewmodelFactory.WScriptDocumentViewModel(fullPath);
                result = fileViewModel.IsInitialized();
                break;
            case EWolvenKitFile.ArchiveXl:
            case EWolvenKitFile.RedScript:
            case EWolvenKitFile.CETLua:
            default:
                break;
        }

        if (result)
        {
            _loggerService.Success($"Opening File: {fullPath}");
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
        if (_projectManager.ActiveProject is null)
        {
            return;
        }

        var needSaveAsDialog =
            fileToSave switch
            {
                RedDocumentViewModel red =>
                    saveAsDialogRequested ||
                    red.FilePath == null ||
                    !Directory.Exists(Path.GetDirectoryName(Path.Combine(_projectManager.ActiveProject.ModDirectory, red.RelativePath)))
                ,
                WScriptDocumentViewModel wScript =>
                    saveAsDialogRequested ||
                    wScript.FilePath == null ||
                    !Directory.Exists(ISettingsManager.GetWScriptDir()),
                _ => false,
            };

        if (needSaveAsDialog)
        {
            SaveFileDialog dlg = new();
            if (fileToSave.FilePath == null && fileToSave is RedDocumentViewModel red)
            {
                var directory = Path.GetDirectoryName(Path.Combine(_projectManager.ActiveProject.ModDirectory, red.RelativePath)).NotNull();
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
                ActiveDocument?.SaveCommand.SafeExecute();
            }
            _watcherService.IsSuspended = false;
            _ = _watcherService.RefreshAsync(ActiveProject);
        }
        else
        {
            ActiveDocument?.SaveCommand.SafeExecute();
        }

    }

    private bool IsInRawFolder(string path) => _projectManager.ActiveProject is not null && path.Contains(_projectManager.ActiveProject.RawDirectory);
    private bool IsInResourceFolder(string path) => _projectManager.ActiveProject is not null && path.Contains(_projectManager.ActiveProject.ResourcesDirectory);

    public Task RequestFileOpen(string fullpath)
    {
        var ext = Path.GetExtension(fullpath).ToLower();

        // everything in ignoredExtensions is delegated to the System viewer
        var delimiter = "|";
        //string[] ignoredExtensions = _settingsManager.TreeViewIgnoredExtensions.ToLower().Split(delimiter);
        //bool isAnIgnoredExtension = Array.Exists(ignoredExtensions, extension => extension.Equals(ext));
        var isAnIgnoredExtension = (_settingsManager.TreeViewIgnoredExtensions ?? "").Split(delimiter).Any(entry => entry.ToLower().Trim().Equals(ext));
        if (isAnIgnoredExtension)
        {
            ShellExecute();
        }
        // double click
        else
        {
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
                case ".lua":

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
                case ".xl":
                case ".reds":
                case ".yaml":
                case ".tweak":
                    ShellExecute();
                    break;

                // double file formats
                case ".csv":
                case ".json":
                    return (IsInRawFolder(fullpath) || IsInResourceFolder(fullpath) ) ? Task.Run(ShellExecute) : Task.Run(OpenRedengineFile);

                // VIDEO
                case ".bk2":
                    break;

                // AUDIO

                case ".wem":
                    return Task.Run(OpenAudioFile);

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
                    return Task.Run(OpenRedengineFile);
            }
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
                DispatcherHelper.RunOnMainThread(async () =>
                {
                    var document = await Open(fullpath, type);
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

    public void SetStatusReady()
    {
        Status = EAppStatus.Loaded;
        _progressService.Completed();
    }

    public void SetLaunchProfiles(ObservableCollection<LaunchProfileViewModel> launchProfiles)
    {
        _settingsManager.LaunchProfiles ??= new();

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
