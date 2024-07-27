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
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using Semver;
using Microsoft.VisualBasic.FileIO; 
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
using WolvenKit.App.ViewModels.Scripting;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Exceptions;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Helpers;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using FileSystem = Microsoft.VisualBasic.FileIO.FileSystem;
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
        IPluginService pluginService,
        IArchiveManager archiveManager,
        IHashService hashService,
        ITweakDBService tweakDBService,
        Red4ParserService parserService,
        AppScriptService scriptService)
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
        _pluginService = pluginService;
        _archiveManager = archiveManager;
        _hashService = hashService;
        _tweakDBService = tweakDBService;
        _parser = parserService;
        _scriptService = scriptService;

        _fileValidationScript = _scriptService.GetScripts(ISettingsManager.GetWScriptDir()).ToList()
            .Where(s => s.Name == "run_FileValidation_on_active_tab")
            .Select(s => new ScriptFileViewModel(_settingsManager, ScriptSource.User, s))
            .FirstOrDefault();
        
        if (_hashService is HashServiceExt hashServiceExt)
        {
            hashServiceExt.LoadGlobalCache();
        }
        
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

        if (e.NewItems == null)
        {
            return;
        }

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

    public class DockedViewVisibleChangedEventArgs(IDockElement element)
    {
        public IDockElement Element { get; } = element;
    }

    public event EventHandler<DockedViewVisibleChangedEventArgs>? DockedViewVisibleChanged;

    private void DockedView_OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName != "IsVisible" || sender is not IDockElement dockElement)
        {
            return;
        }

        DockedViewVisibleChanged?.Invoke(sender, new DockedViewVisibleChangedEventArgs(dockElement));
    }

    private void ProgressService_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName != nameof(IProgressService<double>.Status))
        {
            return;
        }

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
        if (!OpenFileFromLaunchArgs())
        {
            ShowHomePageSync();
        }    

        CheckForUpdatesCommand.SafeExecute(true);
        CheckForScriptUpdatesCommand.SafeExecute();
        CheckForLongPathSupport();
    }

    public bool AddDockedPane(string paneString)
    {
        if (!Enum.TryParse<EDockedViews>(paneString, out var pane))
        {
            return false;
        }

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

        return false;
    }

    private bool OpenFileFromLaunchArgs()
    {
        var args = Environment.GetCommandLineArgs().Skip(1).ToArray();

        var ret = false;
        string? projectPathToOpen = null;

        // Will be overwritten if the launch args contain a project path
        if (args.Contains("-reopenProject") && _settingsManager.LastUsedProjectPath is string projectPath)
        {
            projectPathToOpen = projectPath;
        }

        List<string> invalidFilePaths = new();

        foreach (var filePath in args.Where(f => !string.IsNullOrEmpty(Path.GetExtension(f))))
        {
            if (!File.Exists(filePath))
            {
                invalidFilePaths.Add($"  not found:     {filePath}");
                continue;
            }

            if (Path.GetExtension(filePath) == Cp77Project.ProjectFileExtension)
            {
                projectPathToOpen = filePath;
            }

            // open files
            if (Enum.TryParse<ERedExtension>(Path.GetExtension(filePath)[1..], out var _))
            {
                _ = RequestFileOpen(filePath); // TODO
                ret = true;
            }
            else
            {
                invalidFilePaths.Add($"  not supported: {filePath}");
            }
        }
        
        if (projectPathToOpen is not null)
        {
            _ = OpenProjectAsync(projectPathToOpen);
            ret = true;
        }

        if (invalidFilePaths.Count <= 0)
        {
            return ret;
        }

        var message = $"Not all file paths from the command line could be processed:\n\t{string.Join("\n\t", invalidFilePaths)}";
        _loggerService.Error(message);
        MessageBox.Show(message);

        return ret;
    }

    private void ShowFirstTimeSetup()
    {
        if (_settingsManager.IsHealthy())
        {
            return;
        }

        if (!Interactions.ShowFirstTimeSetup())
        {
            _loggerService.Debug(
                "Setup failed. Please create a ticket under https://github.com/WolvenKit/WolvenKit/issues to help us solve this.");
        }
    }

    private static void CheckForLongPathSupport()
    {
        if (Core.NativeMethods.RtlAreLongPathsEnabled() != 0)
        {
            return;
        }

        var text = "Long path support is disabled in your OS!" + Environment.NewLine +
                   "Please do so to ensure that WolvenKit works properly." + Environment.NewLine + Environment.NewLine +
                   "For more information:" + Environment.NewLine +
                   "https://wiki.redmodding.org/wolvenkit/help/faq/long-file-path-support";

        DispatcherHelper.RunOnMainThread(() => Interactions.ShowConfirmation((text, "Long path support", WMessageBoxImage.Warning, WMessageBoxButtons.Ok)));
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
    [NotifyCanExecuteChangedFor(nameof(ScanForBrokenReferencePathsCommand))]
    [NotifyCanExecuteChangedFor(nameof(FindUnusedFilesCommand))]
    [NotifyCanExecuteChangedFor(nameof(ImportFromEntitySpawnerCommand))]
    [NotifyCanExecuteChangedFor(nameof(RunFileValidationOnProjectCommand))]
    [NotifyCanExecuteChangedFor(nameof(CheckForScriptUpdatesCommand))]
    private EStatus _taskStatus;

    private bool CanStartTask() => TaskStatus == EStatus.Ready && ActiveProject is not null;

    [RelayCommand(CanExecute = nameof(CanStartTask))]
    private async Task PackMod() => await LaunchAsync(new LaunchProfile() { CreateZipFile = true });

    [RelayCommand(CanExecute = nameof(CanStartTask))]
    private async Task PackRedMod() => await LaunchAsync(new LaunchProfile() { CreateZipFile = true, IsRedmod = true });

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
        HttpClient client = new();
        var hashUrl = $@"https://wolvenkit.github.io/Wolvenkit-Resources/hash.txt";
        var response = await client.GetAsync(new Uri(hashUrl));

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
            localHash = await File.ReadAllTextAsync(hashPath.FullName);
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
        response = await client.GetAsync(new Uri(contentUrl));
        try
        {
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException ex)
        {
            _loggerService.Warning($"Failed update scripts from {contentUrl}");
            _loggerService.Warning($"\t{ex.Message}");
            return;
        }

        var zip = await response.Content.ReadAsStreamAsync();
        zip.Seek(0, SeekOrigin.Begin);
        ZipArchive zipArchive = new(zip);
        zipArchive.ExtractToDirectory(resourceDir.FullName, true);

        await File.WriteAllTextAsync(hashPath.FullName, remoteHash);
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
        var githubUrl = $@"https://github.com/{owner}/{name}/releases/latest";
        try
        {
            HttpClient client = new();
            var response = await client.GetAsync(new Uri(githubUrl));
            response.EnsureSuccessStatusCode();
            if (response.RequestMessage?.RequestUri is null)
            {
                return;
            }
            var version = response.RequestMessage.RequestUri.LocalPath.Split('/').Last();
            remoteVersion = SemVersion.Parse(version, SemVersionStyles.OptionalMinorPatch);
        }
        catch (HttpRequestException ex)
        {
            _loggerService.Error($"Failed to respond to updater url: {githubUrl}");
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
        if (string.IsNullOrEmpty(location))
        {
            return;
        }

        if (_projectManager.ActiveProject?.Location == location)
        {
            CloseModal();
            return;
        }

        // switch from one active project to another
        try
        {

            if (string.IsNullOrWhiteSpace(location) || !File.Exists(location))
            {
                // file was moved or deleted
                if (_recentlyUsedItemsService.Items.Items.Any(x => x.Name == location))
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
            await LoadProjectFromPath(location);
        }
        catch (Exception e)
        {
            // TODO: Are we intentionally swallowing this?
            //Log.Error(ex, "Failed to open file");
            _loggerService.Error(e);
        }
    }

    public event EventHandler? OnInitialProjectLoaded;

    private async Task LoadProjectFromPath(string location)
    {
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
            OnInitialProjectLoaded?.Invoke(this, EventArgs.Empty);
        }, TaskContinuationOptions.OnlyOnRanToCompletion);
    }

    [RelayCommand]
    private async Task NewProject() =>
        //IsOverlayShown = false;
        await SetActiveDialog(new ProjectWizardViewModel(_settingsManager)
        {
            FileHandler = NewProject
        });

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
            var projectLocation = Path.Combine(project.ProjectPath.NotNull(), newProjectName, newProjectName,
                Cp77Project.ProjectFileExtension);
            Cp77Project np = new(projectLocation, newProjectName, newModName)
            {
                Author = project.Author,
                Email = project.Email,
                Version = project.Version
            };

            _projectManager.ActiveProject = np;
            _archiveManager.ProjectArchive = np.AsArchive();

            await _projectManager.SaveAsync();
            np.CreateDefaultDirectories();

            await LoadProjectFromPath(projectLocation);
        }
        catch (Exception ex)
        {
            _loggerService.Error("Failed to create a new project!");
            _loggerService.Error(ex);
        }
    }

    [RelayCommand]
    private void SelectFile(FileSystemModel model) => GetToolViewModel<PropertiesViewModel>().ExecuteSelectFile(model);

    private bool CanSaveFile() => ActiveDocument is not null;
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
    private void SaveAs()
    {
        if (_projectManager.ActiveProject is null)
        {
            Interactions.ShowConfirmation((s_noProjectText, s_noProjectTitle, WMessageBoxImage.Warning, WMessageBoxButtons.Ok));
            return;
        }

        Save(ActiveDocument.NotNull(), true);
    }

    private bool CanSaveAll() => CanSaveFile() || DockedViews.OfType<IDocumentViewModel>().Any();
    [RelayCommand(CanExecute = nameof(CanSaveAll))]
    private void SaveAll()
    {
        if (_projectManager.ActiveProject is null)
        {
            Interactions.ShowConfirmation((s_noProjectText, s_noProjectTitle, WMessageBoxImage.Warning, WMessageBoxButtons.Ok));
            return;
        }
        
        foreach (var file in DockedViews.OfType<IDocumentViewModel>().Where(f => f.IsDirty))
        {
            Save(file);
        }
    }

    public async Task<bool> AreDirtyFilesHandledBeforeLaunch()
    {
        var dirtyFiles = DockedViews.OfType<IDocumentViewModel>().Where(tab => tab.IsDirty).ToList();
        if (dirtyFiles.Count == 0)
        {
            return true;
        }

        var response = await Interactions.ShowMessageBoxAsync(
            "You have un-saved files. Save them before installing mod?",
            "Save changes?",
            WMessageBoxButtons.YesNoCancel);
        switch (response)
        {
            case WMessageBoxResult.Cancel:
                return false;
            case WMessageBoxResult.No:
            case WMessageBoxResult.Custom:
            case WMessageBoxResult.None:
                break;
            case WMessageBoxResult.OK:
            case WMessageBoxResult.Yes:
            default:
                SaveAll();
                break;
        }

        return true;
    }

    private bool CanShowHomePage() => !IsDialogShown;
    [RelayCommand(CanExecute = nameof(CanShowHomePage))]
    private async Task ShowHomePage() => await ShowHomePage(EHomePage.Welcome);

    private bool CanShowSettings() => !IsDialogShown;
    [RelayCommand(CanExecute = nameof(CanShowSettings))]
    private async Task ShowSettings() => await ShowHomePage(EHomePage.Settings);

    private bool CanShowProjectActions() =>
        !IsDialogShown && ActiveProject is not null && Status != EAppStatus.Busy && Status is EAppStatus.Ready;

    [RelayCommand(CanExecute = nameof(CanShowProjectActions))]
    private async Task ScanForBrokenReferencePaths()
    {
        _loggerService.Info($"Scanning {ActiveProject!.ModFiles.Count} files. Please wait...");
        _progressService.IsIndeterminate = true;
        var brokenReferences = await ActiveProject!.ScanForBrokenReferencePathsAsync(_archiveManager, _loggerService, _progressService);

        if (brokenReferences.Keys.Count == 0)
        {
            _notificationService.ShowNotification("No broken references in project... that we can find", ENotificationType.Success,
                ENotificationCategory.App);
            return;
        }
        
        Interactions.ShowBrokenReferencesList(("Broken references", brokenReferences));
    }

    private readonly ScriptFileViewModel? _fileValidationScript;

    [RelayCommand(CanExecute = nameof(CanShowProjectActions))]
    private async Task RunFileValidationOnProject()
    {
        if (_fileValidationScript is null || !File.Exists(_fileValidationScript.Path) ||
            _archiveManager.ProjectArchive is not FileSystemArchive projArchive)
        {
            return;
        }

        var result = Interactions.ShowConfirmation((
            $"This will analyse {ActiveProject!.Files.Count} files. This can take up to several minutes. Do you want to proceed?",
            "Really run file validation?",
            WMessageBoxImage.Question,
            WMessageBoxButtons.YesNo));

        if (result != WMessageBoxResult.Yes)
        {
            return;
        }

        var code = await File.ReadAllTextAsync(_fileValidationScript.Path);

        foreach (var (_, file) in projArchive.Files)
        {
            if (GetRedFile(file) is not { } fileViewModel)
            {
                continue;
            }

            _loggerService.Info($"Scanning {ActiveProject.GetRelativePath(file.FileName)}");
            ActiveDocument = fileViewModel;
            await _scriptService.ExecuteAsync(code);
        }

        // This should never happen, but better safe than sorry
        if (FileHelper.GetMostRecentlyChangedFile(Path.Combine(ISettingsManager.GetAppData(), "Logs"), "*.txt") is not FileInfo fI)
        {
            _loggerService.Info("Done.");
            return;
        }

        _loggerService.Info($"Done. The most recent log file is {fI.FullName}.");

        try
        {
            Process.Start(new ProcessStartInfo(fI.FullName) { UseShellExecute = true });
        }
        catch (Exception ex)
        {
            _loggerService.Error($"Failed to open log file: {ex.Message}");
        }
    }
    
    [RelayCommand(CanExecute = nameof(CanShowProjectActions))]
    private async Task FindUnusedFiles()
    {
        _loggerService.Info($"Scanning {ActiveProject!.ModFiles.Count} files. Please wait...");

        var allReferencePaths = await ActiveProject!.GetAllReferences(_progressService);
        _loggerService.Info($"Scanning {ActiveProject!.Files.Count(f => f.StartsWith("archive"))} files. Please wait...");
        
        var referencesHashSet = new HashSet<string>(allReferencePaths.SelectMany((r) => r.Value));

        var potentiallyUnusedFiles = ActiveProject!.ModFiles
            .Where(f => !referencesHashSet.Contains(ActiveProject.GetRelativePath(f))) // they're used
            .Where(f => !_archiveManager.Lookup(f, ArchiveManagerScope.Basegame).HasValue) // they overwrite basegame files
            .Where(f => !ActiveProject.GetRelativePath(f)
                .StartsWith(@"base\characters\appearances\main_npc\npv")) // npv apps
            .ToList();

        if (potentiallyUnusedFiles.Count == 0)
        {
            _notificationService.ShowNotification("No un-used files in project", ENotificationType.Success, ENotificationCategory.App);
            return;
        }

        // Filter out files by type

        // potentiallyUnusedFiles.Where(f => _archiveManager.Lookup(f, ArchiveManagerScope.LocalProject).)


        _progressService.Completed();
        var (deleteFiles, _) =
            Interactions.ShowDeleteOrMoveFilesList(("Delete or move un-used files?", potentiallyUnusedFiles, ActiveProject));

        if (deleteFiles.Count == 0)
        {
            _notificationService.ShowNotification("No un-used files in project", ENotificationType.Success, ENotificationCategory.App);
            return;
        }
        
        List<string> failedDeletions = [];
        foreach (var filePath in deleteFiles)
        {
            try
            {
                var absolutePath = ActiveProject.GetAbsolutePath(filePath);
                FileSystem.DeleteFile(absolutePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);

                while (Path.GetDirectoryName(absolutePath) is string parentDir && !Directory.EnumerateFileSystemEntries(parentDir).Any())
                {
                    Directory.Delete(parentDir);
                    absolutePath = parentDir;
                }
            }
            catch
            {
                failedDeletions.Add(filePath);
            }
        }

        if (failedDeletions.Count == 0)
        {
            _loggerService.Info($"Deleted {deleteFiles.Count} files.");
            return;
        }

        _loggerService.Warning($"Deleted {deleteFiles.Count - failedDeletions.Count} files. The following files failed to delete:");
        foreach (var failedDeletion in failedDeletions)
        {
            _loggerService.Warning($"  {failedDeletion}");
        }
    }

    [RelayCommand(CanExecute = nameof(CanShowProjectActions))]
    private async Task ShowProjectSettings()
    {
        CloseModalCommand.Execute(null);
        await SetActiveDialog(new ProjectSettingsDialogViewModel(_projectManager, _pluginService, this));
    }

    [RelayCommand]
    private void OpenLogs() => Commonfunctions.ShowFolderInExplorer(ISettingsManager.GetAppData());

    [ObservableProperty]
    private int? _selectedGameCommandIdx;

    public enum EGameLaunchCommand
    {
        Launch,
        SteamLaunch
    }

    [RelayCommand]
    private void LaunchGame(string strIdx)
    {
        if (!int.TryParse(strIdx, out var idx))
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
                        Arguments = _settingsManager.GetRED4GameLaunchOptions(),
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
                    var steamRunId = "steam://rungameid/1091500";

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = steamRunId,
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

    private async Task OpenSoundModdingView(SoundModdingViewModel? file)
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
    private async Task ShowPlugin() => await ShowHomePage(EHomePage.Plugins);

    private bool CanShowModsView() => !IsDialogShown;
    [RelayCommand(CanExecute = nameof(CanShowModsView))]
    private async Task ShowModsView() => await ShowHomePage(EHomePage.Mods);

    private bool CanNewFile(string inputDir) => ActiveProject is not null && !IsDialogShown;
    [RelayCommand(CanExecute = nameof(CanNewFile))]
    private async Task NewFile(string? inputDir)
    {
        if (_dialogViewModelFactory.NewFileViewModel() is NewFileViewModel vm)
        {
            vm.FileHandler = OpenFromNewFile;
            await SetActiveDialog(vm);
        }
        //SetActiveDialog(new NewFileViewModel
        //{
        //    FileHandler = OpenFromNewFile
        //});
    }

    private bool CanImportArchive(string inputDir) => ActiveProject is not null && !IsDialogShown;

    [RelayCommand(CanExecute = nameof(CanImportArchive))]
    private async Task<Task> ImportArchive(string? inputDir)
    {
        var vm = new OpenFileViewModel(_settingsManager, _projectManager, _loggerService)
        {
            Title = "Import .archive", Filter = "Archive files (*.archive)|*.archive"
        };

        if (await vm.OpenFile() is not string result)
        {
            return Task.CompletedTask;
        }

        var assetBrowser = GetToolViewModel<AssetBrowserViewModel>();

        if (!assetBrowser.IsVisible)
        {
            assetBrowser.IsVisible = true;
        }

        if (!assetBrowser.IsModBrowserActive())
        {
            assetBrowser.ToggleModBrowserCommand.Execute(null);
        }
        else
        {
            await assetBrowser.LoadAssetBrowserCommand.ExecuteAsync(null);
        }

        assetBrowser.SearchBarText = $"archive:{result}";
        await assetBrowser.PerformSearch($"archive:{result}");

        return Task.CompletedTask;
    }

    private async Task OpenFromNewFile(NewFileViewModel? file)
    {
        CloseModalCommand.Execute(null);
        if (file == null)
        {
            return;
        }

        await Task.Run(() => OpenFromNewFileTask(file)).ContinueWith(async (_) =>
        {
            if (file.FullPath is not null)
            {
                await RequestFileOpen(file.FullPath);
            }
        });
    }

    private static async Task OpenFromNewFileTask(NewFileViewModel file)
    {
        if (file.SelectedFile is null || file.FullPath is null)
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
                    await resource.CopyToAsync(stream);
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
                    await resource.CopyToAsync(stream);
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
                    CR2WFile cr2W = new()
                    {
                        RootChunk = RedTypeManager.Create(redType)
                    };
                    stream = new FileStream(file.FullPath, FileMode.Create, FileAccess.Write);
                    using CR2WWriter writer = new(stream);
                    writer.WriteFile(cr2W);
                }
                break;
            case EWolvenKitFile.WScript:
                throw new NotImplementedException();
            default:
                break;
        }

        if (stream is not null)
        {
            await stream.DisposeAsync();
        }
    }

    [RelayCommand]
    public async Task OpenFileAsync(FileSystemModel model)
    {
        if (model.IsDirectory)
        {
            return;
        }

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

    public bool ShowConfirmationDialog(string dialogMessage, string dialogTitle = "")
    {
        var result = Interactions.ShowConfirmation((dialogMessage, dialogTitle,
            WMessageBoxImage.Question,
            WMessageBoxButtons.YesNo));

        return result == WMessageBoxResult.Yes;
    }

    public void ReloadChangedFiles()
    {
        for (var i = DockedViews.Count - 1; i >= 0; i--)
        {
            if (DockedViews[i] is not IDocumentViewModel documentViewModel || !File.Exists(documentViewModel.FilePath) ||
                File.GetLastWriteTime(documentViewModel.FilePath) <= documentViewModel.LastWriteTime)
            {
                continue;
            }

            var result = Interactions.ShowConfirmation((
                $"The file {documentViewModel.FilePath} has been modified externally. Do you want to reload it?",
                "File Modified",
                WMessageBoxImage.Question,
                WMessageBoxButtons.YesNo));

            if (result == WMessageBoxResult.Yes)
            {
                documentViewModel.Reload(true);
            }
        }
    }

    [RelayCommand]
    private async Task OpenRedFileAsync(FileEntry? file)
    {
        if (file is null)
        {
            return;
        }

        _progressService.IsIndeterminate = true;
        try
        {
            await using MemoryStream stream = new();
            await file.ExtractAsync(stream);
            if (OpenStream(stream, file.FileName, out var redfile))
            {
                var fileViewModel =
                    _documentViewmodelFactory.RedDocumentViewModel(redfile, file.FileName, this, file.Archive is not FileSystemArchive);
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

    private bool OpenFileFromProject(ResourcePath path)
    {
        if (path == 0 || _archiveManager.ProjectArchive is not FileSystemArchive projArchive)
        {
            return false;
        }

        foreach (var (hash, file) in projArchive.Files)
        {
            if (path != hash || GetRedFile(file) is not { } fileViewModel)
            {
                continue;
            }

            if (!DockedViews.Contains(fileViewModel))
            {
                DockedViews.Add(fileViewModel);
            }

            ActiveDocument = fileViewModel;
            UpdateTitle();

            return true;

        }

        return false;
    }

    private RedDocumentViewModel? GetRedFile(IGameFile file)
    {
        if (_archiveManager.ProjectArchive is not FileSystemArchive projArchive)
        {
            return null;
        }

        using MemoryStream stream = new();
        file.Extract(stream);

        if (OpenStream(stream, file.FileName, out var redfile))
        {
            return _documentViewmodelFactory.RedDocumentViewModel(redfile, Path.Combine(projArchive.Project.ModDirectory, file.FileName),
                this, false);
        }

        return null;
    }

    public void OpenFileFromDepotPath(ResourcePath path)
    {
        foreach (var file in DockedViews.OfType<IDocumentViewModel>())
        {
            if (file.FilePath is null || file.FilePath != path)
            {
                continue;
            }

            ActiveDocument = file;
            UpdateTitle();
            return;
        }

        if (OpenFileFromProject(path))
        {
            return;
        }

        OpenFileFromHash(path);
    }

    private void OpenFileFromHash(ResourcePath hash)
    {
        if (hash == 0)
        {
            return;
        }

        _progressService.IsIndeterminate = true;

        using MemoryStream stream = new();
        try
        {
            var file = _archiveManager.Lookup(hash);
            if (file is not { HasValue: true, Value: FileEntry fe })
            {
                return;
            }

            fe.Extract(stream);

            if (!OpenStream(stream, fe.FileName, out var redfile))
            {
                return;
            }

            var resourcePath = hash.GetResolvedText() ?? $"{Path.GetFileNameWithoutExtension(fe.FileName)}{fe.Extension}";
            var fileViewModel = _documentViewmodelFactory.RedDocumentViewModel(redfile, resourcePath, this, true);
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
            stream.Close();
        }
    }

    public bool HasActiveProject() => ActiveProject is not null;

    [RelayCommand]
    private Task CleanAllAsync() => Task.Run(() => _gameControllerFactory.GetController().CleanAll());

    private async Task LaunchAsync(LaunchProfile profile)
    {
        if (!await AreDirtyFilesHandledBeforeLaunch())
        {
            return;
        }

        await _gameControllerFactory.GetController().LaunchProject(profile);
    }

    [RelayCommand]
    private Task HotInstallModAsync() => _gameControllerFactory.GetController().InstallProjectHot();

    [RelayCommand]
    private void LaunchOptions() => Interactions.ShowLaunchProfilesView();

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

        var newVm = typeof(T) switch
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

        DockedViews.Add(newVm);
        return newVm;
      
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
        CloseDialog();
        CloseOverlay();
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
    [NotifyCanExecuteChangedFor(nameof(SaveAllCommand))]
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

    // TODO: Fix installer
    /*
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
    */

    private void ShowHomePageSync(EHomePage page = EHomePage.Welcome)
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

    private void OnAfterOverlayRendered() => DispatcherHelper.RunOnMainThread(() =>
        {
            IsOverlayShown = true;
            ShouldOverlayShow = true;
        }, DispatcherPriority.Render);

    private void OnAfterDialogRendered() => DispatcherHelper.RunOnMainThread(() =>
        {
            IsDialogShown = true;
            ShouldDialogShow = true;
        }, DispatcherPriority.Render);

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


    private const string s_noProjectText = "You need to have a Wolvenkit project to save files. See the wiki for more detes:\n" +
                                           "https://wiki.redmodding.org/wolvenkit/wolvenkit-app/usage/wolvenkit-projects";

    private const string s_noProjectTitle = "No Wolvenkit project";
    
    /// <summary>
    /// Saves a document and resets the dirty flag.
    /// </summary>
    /// <param name="fileToSave"></param>
    /// <param name="saveAsDialogRequested"></param>
    private void Save(IDocumentViewModel fileToSave, bool saveAsDialogRequested = false)
    {
        if (_projectManager.ActiveProject is null)
        {
            Interactions.ShowConfirmation((s_noProjectText, s_noProjectTitle, WMessageBoxImage.Warning, WMessageBoxButtons.Ok));
            return;
        }

        if (fileToSave is RedDocumentViewModel && _projectManager.ActiveProject is null)
        {
            return;
        }

        var needSaveAsDialog =
            fileToSave switch
            {
                RedDocumentViewModel red =>
                    saveAsDialogRequested ||
                    string.IsNullOrEmpty(red.FilePath) ||
                    !Directory.Exists(Path.GetDirectoryName(Path.Combine(_projectManager.ActiveProject!.ModDirectory, red.RelativePath)))
                ,
                WScriptDocumentViewModel wScript =>
                    saveAsDialogRequested ||
                    string.IsNullOrEmpty(wScript.FilePath) ||
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

            if (dlg.ShowDialog().GetValueOrDefault())
            {
                fileToSave.FilePath = dlg.FileName;
                fileToSave.SaveCommand.SafeExecute();
            }
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
                default:
                    return Task.Run(OpenRedengineFile);
            }
        }

        return Task.Run(() => true);

        void OpenRedengineFile()
        {
            var trimmedExt = ext.TrimStart('.').ToUpper();
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

            if (!isRedEngineFile)
            {
                return;
            }

            DispatcherHelper.RunOnMainThread(async () =>
            {
                if (await Open(fullpath, type) is not IDocumentViewModel document)
                {
                    return;
                }

                if (!DockedViews.Contains(document))
                {
                    DockedViews.Add(document);
                }

                ActiveDocument = document;
                UpdateTitle();
            });
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
                _loggerService.Error($"No default program set in Windows to open file extension {Path.GetExtension(fullpath)}");
            }
        }

        void PolymorphExecute(string path, string extension)
        {
            File.WriteAllBytes(Path.GetTempPath() + "asd." + extension, new byte[] { 0x01 });
            StringBuilder programName = new();
            _ = NativeMethods.FindExecutable("asd." + extension, Path.GetTempPath(), programName);
            if (programName.ToString().ToUpper().Contains(".EXE"))
            {
                Process.Start(programName.ToString(), path.ToEscapedPath());
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
        _settingsManager.LaunchProfiles.Clear();
        var profiles = launchProfiles
            .Where(item => !_settingsManager.LaunchProfiles.ContainsKey(item.Name))
            .ToDictionary(item => item.Name, item => item.Profile);

        _settingsManager.LaunchProfiles = profiles;
        _settingsManager.Save();

    }

    #endregion methods
}
