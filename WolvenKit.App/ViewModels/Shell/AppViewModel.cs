using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents.DocumentStructures;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using Semver;
using SharpGLTF.Schema2;
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
using WolvenKit.App.ViewModels.Exporters;
using WolvenKit.App.ViewModels.HomePage;
using WolvenKit.App.ViewModels.Importers;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Exceptions;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model.Database;
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
    private readonly AppScriptService _scriptService;

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
        Red4ParserService parserService,
        AppScriptService scriptService
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
        _scriptService = scriptService;

        _scriptService.SetAppViewModel(this);

        _progressService.PropertyChanged += ProgressService_PropertyChanged;

        UpdateTitle();

        ShowFirstTimeSetup();

        DockedViews.CollectionChanged += DockedViews_OnCollectionChanged;
    }

    private void DockedViews_OnCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        if (e.OldItems != null)
        {
            foreach (var item in e.OldItems)
            {
                if (item is not IDockElement dockElement)
                {
                    continue;
                }

                dockElement.PropertyChanged -= DockedView_OnPropertyChanged;
                DockedViewVisibleChanged?.Invoke(sender, new DockedViewVisibleChangedEventArgs(dockElement));
            }
        }

        if (e.NewItems != null)
        {
            foreach (var item in e.NewItems)
            {
                if (item is not IDockElement dockElement)
                {
                    continue;
                }

                DockedViewVisibleChanged?.Invoke(sender, new DockedViewVisibleChangedEventArgs(dockElement));
                dockElement.PropertyChanged += DockedView_OnPropertyChanged;
            }
        }
    }

    public class DockedViewVisibleChangedEventArgs
    {
        public DockedViewVisibleChangedEventArgs(IDockElement element)
        {
            Element = element;
        }

        public IDockElement Element { get; }
    }

    public event EventHandler<DockedViewVisibleChangedEventArgs>? DockedViewVisibleChanged;

    private void DockedView_OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "IsVisible")
        {
            if (sender is not IDockElement dockElement)
            {
                return;
            }

            DockedViewVisibleChanged?.Invoke(sender, new DockedViewVisibleChangedEventArgs(dockElement));
        }
    }

    private void ProgressService_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(IProgressService<double>.Status))
        {
            DispatcherHelper.RunOnMainThread(() =>
            {
                TaskStatus = _progressService.Status;
                switch (TaskStatus)
                {
                    case EStatus.Running:
                        Status = EAppStatus.Busy;
                        break;
                    case EStatus.Ready:
                        Status = EAppStatus.Ready;
                        break;
                    default:
                        break;
                }
            }, DispatcherPriority.ContextIdle);
        }
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

        CheckForUpdatesCommand.SafeExecute(true);
        CheckForScriptUpdatesCommand.SafeExecute();
    }

    public bool AddDockedPane(string paneString)
    {
        if (Enum.TryParse<EDockedViews>(paneString, out var pane))
        {
            switch (pane)
            {
                case EDockedViews.LogViewModel:
                    DockedViews.Add(_paneViewModelFactory.LogViewModel());
                    return true;
                case EDockedViews.ProjectExplorerViewModel:
                    DockedViews.Add(_paneViewModelFactory.ProjectExplorerViewModel(this));
                    return true;
                case EDockedViews.PropertiesViewModel:
                    DockedViews.Add(_paneViewModelFactory.PropertiesViewModel());
                    return true;
                case EDockedViews.AssetBrowserViewModel:
                    DockedViews.Add(_paneViewModelFactory.AssetBrowserViewModel(this));
                    return true;
                case EDockedViews.TweakBrowserViewModel:
                    DockedViews.Add(_paneViewModelFactory.TweakBrowserViewModel(this));
                    return true;
                case EDockedViews.LocKeyBrowserViewModel:
                    DockedViews.Add(_paneViewModelFactory.LocKeyBrowserViewModel());
                    return true;
                case EDockedViews.ImportViewModel:
                {
                    var vm = _paneViewModelFactory.ImportViewModel(this);
                    vm.State = DockState.Dock;
                    vm.SideInDockedMode = DockSide.Right;
                    DockedViews.Add(vm);
                    return true;
                }
                case EDockedViews.ExportViewModel:
                {
                    var vm = _paneViewModelFactory.ExportViewModel(this);
                    vm.State = DockState.Dock;
                    vm.SideInDockedMode = DockSide.Right;
                    DockedViews.Add(vm);
                    return true;
                }
                case EDockedViews.HashToolViewModel:
                {
                    var vm = _paneViewModelFactory.HashToolViewModel();
                    vm.State = DockState.Dock;
                    vm.SideInDockedMode = DockSide.Right;
                    DockedViews.Add(vm);
                    return true;
                }
                default:
                    break;
            }
        }

        return false;
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
            _ = OpenFileAsync(FileModel.Create(filePath, ActiveProject.NotNull())); // TODO
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

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(PackModCommand))]
    [NotifyCanExecuteChangedFor(nameof(PackRedModCommand))]
    [NotifyCanExecuteChangedFor(nameof(PackInstallModCommand))]
    [NotifyCanExecuteChangedFor(nameof(PackInstallRedModCommand))]
    [NotifyCanExecuteChangedFor(nameof(PackInstallModCommand))]
    [NotifyCanExecuteChangedFor(nameof(PackInstallRunCommand))]
    [NotifyCanExecuteChangedFor(nameof(PackInstallRedModRunCommand))]
    private EStatus _taskStatus;
    private bool CanStartTask() => TaskStatus == EStatus.Ready;

    [RelayCommand(CanExecute = nameof(CanStartTask))]
    private async Task PackMod() => await LaunchAsync(new LaunchProfile() { CreateBackup = true });

    [RelayCommand(CanExecute = nameof(CanStartTask))]
    private async Task PackRedMod() => await LaunchAsync(new LaunchProfile() { CreateBackup = true, IsRedmod = true });

    [RelayCommand(CanExecute = nameof(CanStartTask))]
    private async Task PackInstallMod() => await LaunchAsync(new LaunchProfile() { Install = true });

    [RelayCommand(CanExecute = nameof(CanStartTask))]
    private async Task PackInstallRedMod() => await LaunchAsync(new LaunchProfile() { Install = true, IsRedmod = true });

    [RelayCommand(CanExecute = nameof(CanStartTask))]
    private async Task PackInstallRun() => await LaunchAsync(new LaunchProfile() { Install = true, LaunchGame = true });

    [RelayCommand(CanExecute = nameof(CanStartTask))]
    private async Task PackInstallRedModRun() => await LaunchAsync(new LaunchProfile() { Install = true, LaunchGame = true, IsRedmod = true, DeployWithRedmod = true });


    [RelayCommand]
    private async Task CheckForScriptUpdates()
    {
        // check remote version (no github API call)
        HttpClient _client = new();
        var hashUrl = $@"https://wolvenkit.github.io/Wolvenkit-Resources/hash.txt";
        var response = await _client.GetAsync(new Uri(hashUrl));

        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException ex)
        {
            _loggerService.Error($"Failed to respond to url: {hashUrl}");
            _loggerService.Error(ex);
            return;
        }

        var localHash = "";
        var resourceDir = new DirectoryInfo(Path.Combine("Resources", "Scripts"));
        FileInfo hashPath = new(Path.Combine("Resources", "scripthash.txt"));
        if (hashPath.Exists)
        {
            localHash = File.ReadAllText(hashPath.FullName);
        }

        // check hash
        using var ms = new MemoryStream();
        await response.Content.CopyToAsync(ms);
        ms.Seek(0, SeekOrigin.Begin);
        using var reader = new StreamReader(ms, Encoding.UTF8);
        var remoteHash = await reader.ReadToEndAsync();
        remoteHash = remoteHash.TrimEnd('\r', '\n');
        if (localHash == remoteHash)
        {
            // early out
            return;
        }

        // clean
        if (resourceDir.Exists)
        {
            resourceDir.Delete(true);
        }
        Directory.CreateDirectory(resourceDir.FullName);

        // download zipfile
        var contentUrl = $@"https://wolvenkit.github.io/Wolvenkit-Resources/scripts.zip";
        response = await _client.GetAsync(new Uri(contentUrl));
        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException ex)
        {
            _loggerService.Error($"Failed to respond to url: {contentUrl}");
            _loggerService.Error(ex);
            return;
        }

        var zip = await response.Content.ReadAsStreamAsync();
        zip.Seek(0, SeekOrigin.Begin);
        ZipArchive zipArchive = new(zip);
        zipArchive.ExtractToDirectory(resourceDir.FullName, true);

        File.WriteAllText(hashPath.FullName, remoteHash);
        _scriptService.RefreshUIScripts();
    }

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
                    var dlg = new OpenFileDialog
                    {
                        Multiselect = false,
                        Title = "Locate the WolvenKit project",
                        Filter = "Cyberpunk 2077 Project|*.cpmodproj"
                    };

                    if (dlg.ShowDialog() != true)
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
        await SetActiveDialog(new ProjectWizardViewModel(_settingsManager)
        {
            FileHandler = NewProject
        });
    }

    private async Task NewProject(ProjectWizardViewModel? project)
    {

        if (project == null)
        {
            CloseDialog();
            return;
        }
        CloseModal();
        await NewProjectTask(project);
        UpdateTitle();
    }

    private async Task NewProjectTask(ProjectWizardViewModel project)
    {
        try
        {
            var newProjectName = project.ProjectName.NotNull().Trim();
            var newModName = project.ModName.NotNull().Trim();
            var projectLocation = Path.Combine(project.ProjectPath.NotNull(), newProjectName, newProjectName + ".cpmodproj");
            Cp77Project np = new(projectLocation, newProjectName, newModName, _hashService)
            {
                Author = project.Author,
                Email = project.Email,
                Version = project.Version
            };

            _projectManager.ActiveProject = np;
            _archiveManager.ProjectArchive = np.AsArchive();

            await _projectManager.SaveAsync();
            np.CreateDefaultDirectories();

            await _projectManager.LoadAsync(projectLocation);

            DispatcherHelper.RunOnMainThread(() => ActiveProject = _projectManager.ActiveProject);

            // If the assets can't be found, stop here and notify the user in the log
            if (!File.Exists(_settingsManager.CP77ExecutablePath))
            {
                _loggerService.Warning($"Cyberpunk 2077 executable path is not set. Asset browser disabled.");
            }
            else
            {
                await _gameControllerFactory.GetController().HandleStartup();
                _notificationService.Success("Project " + project.ProjectName + " loaded!");
            }
        }
        catch (Exception ex)
        {
            _loggerService.Error("Failed to create a new project!");
            _loggerService.Error(ex);
        }
    }

    [RelayCommand]
    private void SelectFile(FileModel model) => GetToolViewModel<PropertiesViewModel>().ExecuteSelectFile(model);

    private bool CanSaveFile() => ActiveDocument is not null && !ActiveDocument.IsReadOnly;
    [RelayCommand(CanExecute = nameof(CanSaveFile))]
    private void SaveFile() => Save(ActiveDocument.NotNull());

    private bool CanReloadFile() => ActiveDocument is not null;
    [RelayCommand(CanExecute = nameof(CanReloadFile))]
    private void ReloadFile()
    {
        if (ActiveDocument == null)
        {
            return;
        }

        if (ActiveDocument is DocumentViewModel { IsDirty: true })
        {
            var result = Interactions.ShowConfirmation(($"The file {ActiveDocument.FilePath} has unsaved changes. Do you want to reload it?",
                "File Modified",
                WMessageBoxImage.Question,
                WMessageBoxButtons.YesNo));

            if (result == WMessageBoxResult.No)
            {
                return;
            }
        }
        
        ActiveDocument.Reload(true);
    }

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
        await SetActiveDialog(new ScriptManagerViewModel(this, _scriptService, _settingsManager, _loggerService));
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
            {
                //prep the subdirs
                var tweakDirName = Path.GetDirectoryName(file.FullPath).NotNull();
                Directory.CreateDirectory(tweakDirName);
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
            }
            case EWolvenKitFile.RedScript:
            case EWolvenKitFile.CETLua:
            {
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
            }  
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

    public void SaveFile(string fileName)
    {
        foreach (var dockElement in DockedViews)
        {
            if (dockElement is not RedDocumentViewModel redDocumentViewModel)
            {
                continue;
            }

            if (redDocumentViewModel.FilePath == fileName && redDocumentViewModel.IsDirty)
            {
                var result = Interactions.ShowConfirmation(($"The file {redDocumentViewModel.FilePath} has unsaved changes. Do you want to save it?",
                    "File Modified",
                    WMessageBoxImage.Question,
                    WMessageBoxButtons.YesNo));

                if (result == WMessageBoxResult.Yes)
                {
                    redDocumentViewModel.SaveCommand.SafeExecute();
                }
            }
        }
    }

    public void ReloadChangedFiles()
    {
        for (var i = DockedViews.Count - 1; i >= 0; i--)
        {
            if (DockedViews[i] is not IDocumentViewModel documentViewModel)
            {
                continue;
            }

            if (File.Exists(documentViewModel.FilePath) &&
                File.GetLastWriteTime(documentViewModel.FilePath) > documentViewModel.LastWriteTime)
            {
                var result = Interactions.ShowConfirmation(($"The file {documentViewModel.FilePath} has been modified externally. Do you want to reload it?",
                    "File Modified",
                    WMessageBoxImage.Question,
                    WMessageBoxButtons.YesNo));

                if (result == WMessageBoxResult.Yes)
                {
                    documentViewModel.Reload(true);
                }
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
                await file.ExtractAsync(stream);
                if (OpenStream(stream, file.FileName, out var redfile))
                {
                    var fileViewModel = _documentViewmodelFactory.RedDocumentViewModel(redfile, file.FileName, this, file.Archive is not FileSystemArchive);
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

    public bool OpenFileFromProject(ResourcePath path)
    {
        if (path == 0)
        {
            return false;
        }

        if (_archiveManager.ProjectArchive is not FileSystemArchive projArchive)
        {
            return false;
        }

        foreach (var (hash, file) in projArchive.Files)
        {
            if (path != hash)
            {
                continue;
            }

            using MemoryStream stream = new();
            file.Extract(stream);

            if (OpenStream(stream, file.FileName, out var redfile))
            {
                var fileViewModel = _documentViewmodelFactory.RedDocumentViewModel(redfile, Path.Combine(projArchive.Project.ModDirectory, file.FileName), this, false);
                if (!DockedViews.Contains(fileViewModel))
                {
                    DockedViews.Add(fileViewModel);
                }

                ActiveDocument = fileViewModel;
                UpdateTitle();

                return true;
            }
        }

        return false;
    }

    public void OpenFileFromDepotPath(ResourcePath path)
    {
        foreach (var file in DockedViews.OfType<IDocumentViewModel>())
        {
            if (file.FilePath == path)
            {
                ActiveDocument = file;
                UpdateTitle();
                return;
            }
        }

        if (OpenFileFromProject(path))
        {
            return;
        }

        // it should be resolved by this point, but check just in case
        if (!_hashService.Contains(path) && !ResourcePath.IsNullOrEmpty(path))
        {
            _hashService.AddCustom(path.GetResolvedText().NotNull());
        }

        OpenFileFromHash(path);
    }

    public void OpenFileFromHash(ResourcePath hash)
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
                        var resourcePath = hash.GetResolvedText() ?? $"{Path.GetFileNameWithoutExtension(fe.FileName)}{fe.Extension}";
                        var fileViewModel = _documentViewmodelFactory.RedDocumentViewModel(redfile, resourcePath, this, true);
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
        _watcherService.QueueRefresh();
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
        var vm = _paneViewModelFactory.ImportViewModel(this);
        vm.State = DockState.Float;
        DockedViews.Add(vm);
    }

    [RelayCommand]
    private void ShowTextureExporter()
    {
        var vm = _paneViewModelFactory.ExportViewModel(this);
        vm.State = DockState.Float;
        DockedViews.Add(vm);
    }

    [RelayCommand]
    private void ShowHashTool()
    {
        var vm = _paneViewModelFactory.HashToolViewModel();
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
            var newvm = typeof(T) switch
            {
                Type t when t == typeof(LogViewModel) => (T)(_paneViewModelFactory.LogViewModel() as IDockElement),
                Type t when t == typeof(ProjectExplorerViewModel) => (T)(_paneViewModelFactory.ProjectExplorerViewModel(this) as IDockElement),
                Type t when t == typeof(PropertiesViewModel) => (T)(_paneViewModelFactory.PropertiesViewModel() as IDockElement),
                Type t when t == typeof(AssetBrowserViewModel) => (T)(_paneViewModelFactory.AssetBrowserViewModel(this) as IDockElement),
                Type t when t == typeof(TweakBrowserViewModel) => (T)(_paneViewModelFactory.TweakBrowserViewModel(this) as IDockElement),
                Type t when t == typeof(LocKeyBrowserViewModel) => (T)(_paneViewModelFactory.LocKeyBrowserViewModel() as IDockElement),

                Type t when t == typeof(ImportViewModel) => (T)(_paneViewModelFactory.LogViewModel() as IDockElement),
                Type t when t == typeof(ExportViewModel) => (T)(_paneViewModelFactory.LogViewModel() as IDockElement),

                _ => throw new NotImplementedException(),
            };

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
        DispatcherHelper.RunOnMainThread(() =>
        {
            IsOverlayShown = true;
            ShouldOverlayShow = true;
        }, DispatcherPriority.Render);
    }
    private void OnAfterDialogRendered()
    {
        DispatcherHelper.RunOnMainThread(() =>
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

        var dbPath = Path.Combine(_settingsManager.GetRED4GameRootDir(), "r6", "cache", "tweakdb_ep1.bin");
        if (!File.Exists(dbPath))
        {
            dbPath = Path.Combine(_settingsManager.GetRED4GameRootDir(), "r6", "cache", "tweakdb.bin");
        }

        await _tweakDBService.LoadDB(dbPath);
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
                    fileViewModel = _documentViewmodelFactory.RedDocumentViewModel(file, fullPath, this, false);
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
        if (fileToSave is RedDocumentViewModel && _projectManager.ActiveProject is null)
        {
            return;
        }

        var needSaveAsDialog =
            fileToSave switch
            {
                RedDocumentViewModel red =>
                    saveAsDialogRequested ||
                    red.FilePath == null ||
                    !Directory.Exists(Path.GetDirectoryName(Path.Combine(_projectManager.ActiveProject!.ModDirectory, red.RelativePath)))
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
                var directory = Path.GetDirectoryName(Path.Combine(_projectManager.ActiveProject!.ModDirectory, red.RelativePath)).NotNull();
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
                fileToSave.SaveCommand.SafeExecute();
            }
            _watcherService.IsSuspended = false;
            _watcherService.QueueRefresh();
        }
        else
        {
            fileToSave.SaveCommand.SafeExecute();
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

    public void CloseFile(IDocumentViewModel documentViewModel) => DockedViews.Remove(documentViewModel);

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
