using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using Microsoft.EntityFrameworkCore;
using WolvenKit.App.Controllers;
using WolvenKit.App.Extensions;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.HomePage;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Database;
using WolvenKit.Common.Services;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Archive;
using Task = System.Threading.Tasks.Task;

namespace WolvenKit.App.ViewModels.Tools;

public partial class AssetBrowserViewModel : ToolViewModel
{
    #region constants

    /// <summary>
    /// Identifies the <see ref="ContentId"/> of this tool window.
    /// </summary>
    public const string ToolContentId = "AssetBrowser_Tool";

    /// <summary>
    /// Identifies the caption string used for this tool window.
    /// </summary>
    public const string ToolTitle = "Asset Browser";

    public enum ESearchKeys
    {
        Hash,
        Kind,
        Name,
        Limit,
    }

    public const int SearchLimit = 1000;


    #endregion constants

    #region fields

    private readonly INotificationService _notificationService;
    private readonly IGameControllerFactory _gameController;
    private readonly IAppArchiveManager _archiveManager;
    private readonly ISettingsManager _settings;
    private readonly IProjectManager _projectManager;
    private readonly IProgressService<double> _progressService;
    private readonly ILoggerService _loggerService;
    private readonly IPluginService _pluginService;
    private readonly AppViewModel _appViewModel;
    private readonly IModifierViewStateService _modifierViewSvc;

    private readonly ReadOnlyObservableCollection<RedFileSystemModel> _boundRootNodes;

    private bool _manuallyLoading;
    
    #endregion fields

    #region ctor

    public AssetBrowserViewModel(
        AppViewModel appViewModel,
        IProjectManager projectManager,
        INotificationService notificationService,
        IGameControllerFactory gameController,
        IAppArchiveManager archiveManager,
        ISettingsManager settings,
        IProgressService<double> progressService,
        ILoggerService loggerService,
        IPluginService pluginService,
        IModifierViewStateService viewSvc) : base(ToolTitle)
    {
        _projectManager = projectManager;
        _notificationService = notificationService;
        _gameController = gameController;
        _archiveManager = archiveManager;
        _settings = settings;
        _progressService = progressService;
        _pluginService = pluginService;
        _loggerService = loggerService;
        _appViewModel = appViewModel;
        _modifierViewSvc = viewSvc;
        
        ContentId = ToolContentId;

        State = DockState.Dock;
        SideInDockedMode = DockSide.Tabbed;

        IsModBrowserEnabled = false; 
        
        archiveManager.ConnectGameRoot()
            .Bind(out _boundRootNodes)
            .Subscribe(OnNext);

        _settings.PropertyChanged += Settings_PropertyChanged;
        if (!_archiveManager.IsManagerLoaded)
        {
            _archiveManager.PropertyChanged += ArchiveManager_PropertyChanged;
        }

        ProjectLoaded = _projectManager.IsProjectLoaded;
        _projectManager.PropertyChanged += ProjectManager_PropertyChanged;

        CheckView();
    }

    private string[] IgnoredArchives =>
        _settings.ArchiveNamesExcludeFromScan.Split(",", StringSplitOptions.RemoveEmptyEntries)
            .Select(archiveName => archiveName.Replace(".archive", "")).ToArray();

    
    private void OnNext(IChangeSet<RedFileSystemModel> obj) => 
        DispatcherHelper.RunOnMainThread(() => LeftItems = new ObservableCollection<RedFileSystemModel>(_boundRootNodes), DispatcherPriority.ContextIdle);

    private void CheckView()
    {
        ArchiveDirNotFound = _settings.CP77ExecutablePath == null;
        LoadVisibility = _archiveManager.IsManagerLoaded ? Visibility.Collapsed : Visibility.Visible;

        ShouldShowExecutablePathWarning = ArchiveDirNotFound;
        ShouldShowLoadButton = !_manuallyLoading && _archiveManager is { IsManagerLoaded: false, IsManagerLoading: false };
    }

    // if the game exe path changes
    private void Settings_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(ISettingsManager.CP77ExecutablePath))
        {
            CheckView();
        }
    }

    // if the mod is loaded
    private void ProjectManager_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(IProjectManager.IsProjectLoaded))
        {
            DispatcherHelper.RunOnMainThread(() => ProjectLoaded = _projectManager.IsProjectLoaded, DispatcherPriority.ContextIdle);
        }
    }

    // if the archive manager is loaded
    private void ArchiveManager_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName is nameof(IArchiveManager.IsManagerLoading) or nameof(IArchiveManager.IsManagerLoaded))
        {
            CheckView();
        }

        if (e.PropertyName is nameof(IArchiveManager.IsManagerLoaded))
        {
            _archiveManager.PropertyChanged -= ArchiveManager_PropertyChanged;
        }
    }

    #endregion ctor

    #region properties

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(AddSelectedCommand))]
    private bool _projectLoaded;

    [ObservableProperty]
    private bool _archiveDirNotFound = true;

    [ObservableProperty]
    private GridLength _previewWidth = new(0, GridUnitType.Pixel);

    [ObservableProperty]
    private Visibility _loadVisibility = Visibility.Visible;

    [ObservableProperty]
    private bool _shouldShowLoadButton;

    [ObservableProperty]
    private bool _shouldShowExecutablePathWarning = true;

    [ObservableProperty]
    private ObservableCollection<RedFileSystemModel> _leftItems = new();

    [ObservableProperty] 
    private object? _leftSelectedItem;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(BrowseToFolderCommand))]
    [NotifyCanExecuteChangedFor(nameof(OpenFileOnlyCommand))]
    [NotifyCanExecuteChangedFor(nameof(AddFromArchiveCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyRelPathCommand))]
    [NotifyPropertyChangedFor(nameof(AddFromArchiveItems))]
    private IFileSystemViewModel? _rightSelectedItem;

    [ObservableProperty]
    private ObservableCollection<object> _rightSelectedItems = new();

    [ObservableProperty]
    private ObservableCollectionEx<IFileSystemViewModel> _rightItems = new();

    [ObservableProperty] 
    private string? _selectedClass;

    [ObservableProperty] 
    private string? _selectedExtension;

    [ObservableProperty] 
    private string? _searchBarText;

    [ObservableProperty] 
    private string? _optionsSearchBarText;

    [ObservableProperty] private bool _isModBrowserEnabled;

    [ObservableProperty]
    private ObservableCollectionEx<IGameArchive> _addFromArchiveItems = new();


    [NotifyCanExecuteChangedFor(nameof(CopyRelPathCommand))]
    [NotifyCanExecuteChangedFor(nameof(CopyRelPathFileNameCommand))]
    [ObservableProperty]
    private bool _isShiftKeyDown;

    #endregion properties

    #region commands

    [RelayCommand]
    private async Task LoadAssetBrowser()
    {
        _manuallyLoading = true;
        ShouldShowLoadButton = !_manuallyLoading && !ProjectLoaded && !ArchiveDirNotFound;
        await _gameController.GetRed4Controller().HandleStartup();
    }

    [RelayCommand]
    private async Task OpenWolvenKitSettings() => await _appViewModel.ShowHomePageAsync(EHomePage.Settings);

    [RelayCommand]
    private void AddSearchKey(string value) => SearchBarText += $" {value}:";

    private async void InstallWolvenkitResources()
    {
        _loggerService.Warning("Wolvenkit-Resources plugin is not installed and is needed for this functionality.");

        var response = await Interactions.ShowMessageBoxAsync(
            "Wolvenkit-Resources plugin is not installed and is needed for this functionality. Would you like to install it now?",
            "Wolvenkit-Resources not found");
        switch (response)
        {
            case WMessageBoxResult.OK:
            case WMessageBoxResult.Yes:
            {
                await _appViewModel.ShowHomePageAsync(EHomePage.Plugins);
                break;
            }

            case WMessageBoxResult.None:
            case WMessageBoxResult.Cancel:
            case WMessageBoxResult.No:
            case WMessageBoxResult.Custom:
            default:
                break;
        }
    }

    
    [RelayCommand]
    private async Task FindUsing()
    {
        if (!_pluginService.IsInstalled(EPlugin.wolvenkit_resources))
        {
            InstallWolvenkitResources();
            return;
        }

        _progressService.IsIndeterminate = true;

        await Task.Run(async () =>
        {
            try
            {
                await using RedDBContext db = new();

                if (RightSelectedItem is RedFileViewModel file && db.Files is not null)
                {
                    var hash = file.GetGameFile().Key;

                    var usedBy = await db.Files.Include("Uses")
                        .Where(x => x.Uses != null && x.Uses.Any(y => y.Hash == hash))
                        .Select(x => x.Hash)
                        .ToListAsync();

                    //add all found items to
                    _archiveManager.Archives
                        .Connect()
                        .TransformMany(x => x.Files.Values, y => y.Key)
                        .Filter(x => usedBy.Contains(x.Key))
                        .Transform(x => new RedFileViewModel(x))
                        .Bind(out var list)
                        .Subscribe()
                        .Dispose();

                    // This will go into an endless refresh loop if SuppressNotification is not set, which 
                    // prevents the task from completing. 
                    RightItems.SuppressNotification = true;
                    RightItems.Clear();
                    RightItems.AddRange(list);
                    RightItems.SuppressNotification = false;
                }
            }
            catch (Exception e)
            {
                _progressService.IsIndeterminate = false;
                _loggerService.Error(e);
                throw new WolvenKitException(0x3002,
                    "Internal database query failed - try (re)installing the Wolvenkit Resources Plugin.");
            }

            await Task.CompletedTask;
        });

        _progressService.IsIndeterminate = false;
    }

    [RelayCommand]
    private async Task FindUses()
    {
        if (!_pluginService.IsInstalled(EPlugin.wolvenkit_resources))
        {
            _loggerService.Warning("Wolvenkit-Resources plugin is not installed and is needed for this functionality.");

            var response = await Interactions.ShowMessageBoxAsync("Wolvenkit-Resources plugin is not installed and is needed for this functionality. Would you like to install it now?", "Wolvenkit-Resources not found");

            switch (response)
            {
                case WMessageBoxResult.OK:
                case WMessageBoxResult.Yes:
                {
                    await _appViewModel.ShowHomePageAsync(EHomePage.Plugins);
                    break;
                }

                case WMessageBoxResult.None:
                case WMessageBoxResult.Cancel:
                case WMessageBoxResult.No:
                case WMessageBoxResult.Custom:
                default:
                    break;
            }

            return;
        }

        _progressService.IsIndeterminate = true;

        await Task.Run(async () =>
        {
            try
            {
                await using RedDBContext db = new();

                if (RightSelectedItem is RedFileViewModel file && db.Files is not null)
                {
                    var hash = file.GetGameFile().Key;

                    var uses = await db.Files.Include("Archive").Include("Uses")
                        .Where(x => x.Archive != null && x.Archive.Name == file.ArchiveName &&
                                    x.Archive.Source == file.ArchiveSource.ToString() && x.Hash == hash)
                        .Where(x => x.Uses != null)
                        .Select(x => x.Uses!.Select(y => y.Hash))
                        .ToListAsync();

                    //add all found items to asset browser
                    _archiveManager.Archives
                        .Connect()
                        .TransformMany(x => x.Files.Values, y => y.Key)
                        .Filter(x => uses.Any(y => y.Contains(x.Key)))
                        .Transform(x => new RedFileViewModel(x))
                        .Bind(out var list)
                        .Subscribe()
                        .Dispose();

                    RightItems.Clear();
                    RightItems.AddRange(list);
                }
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
                throw new WolvenKitException(0x3002,
                    "Internal database query failed - try (re)installing the Wolvenkit Resources Plugin.");       
            }
            await Task.CompletedTask;
        });

        _progressService.IsIndeterminate = false;
    }

    public void UpdateSearchInArchives()
    {
        AddFromArchiveItems.Clear();

        if (RightSelectedItem is not RedFileViewModel file)
        {
            return;
        }

        var key = file.GetGameFile().Key;
        var archives = _archiveManager
            .Archives
            .Items
            .Where(archive => archive.Files.ContainsKey(key));

        foreach (var archive in archives)
        {
            AddFromArchiveItems.Add(archive);
        }
    }

    /// <summary>
    /// Browse the left side folder tree to the folder containing the selected item. (e.g. for after searching)
    /// </summary>
    private bool CanBrowseToFolder() => RightSelectedItem is RedFileViewModel &&
                                        _archiveManager.GetGameFile(RightSelectedItem!.FullName, false, false) is not null;
    [RelayCommand(CanExecute = nameof(CanBrowseToFolder))]
    private void BrowseToFolder()
    {
        if (RightSelectedItem is not RedFileViewModel file ||
            _archiveManager.GetGameFile(RightSelectedItem!.FullName) is null)
        {
            return;
        }


        LeftSelectedItem = null;
        CancelPendingSearch();

        var fullPath = "";
        var parentDir = LeftItems.ElementAt(0);
        parentDir.IsExpanded = true;

        foreach (var dir in file.GetParentPath().Split(Path.DirectorySeparatorChar))
        {
            fullPath += dir;
            parentDir = parentDir.Directories
                .First(x => x.Key == fullPath)
                .Value;
            parentDir.IsExpanded = true;
            fullPath += Path.DirectorySeparatorChar;
        }

        MoveToFolder(parentDir);
        RightSelectedItem = RightItems.FirstOrDefault(x => x.FullName == file.FullName);
    }

    /// <summary>
    /// Add File to Project
    /// </summary>
    /// 
    private bool CanAddToProject() => ProjectLoaded;

    [RelayCommand(CanExecute = nameof(CanAddToProject))]
    private async Task AddSelectedAsync()
    {
        // get all selected files
        Dictionary<ulong, IGameFile> filesToAdd = new();
        foreach (var o in RightItems.Where(x => x.IsChecked))
        {
            switch (o)
            {
                case RedFileViewModel fileVm:
                    filesToAdd.Add(fileVm.GetGameFile().Key, fileVm.GetGameFile());
                    break;
                case RedDirectoryViewModel dirVm:
                    GetFilesRecursive(dirVm.GetModel(), filesToAdd);
                    break;
                default:
                    break;
            }
        }

        // check against existing files
        List<IGameFile> nonExistingFiles = new();
        if (_archiveManager.ProjectArchive is not null)
        {
            var projectHashes = _archiveManager.ProjectArchive.Files.Keys.ToList();
            foreach (var (hash, file) in filesToAdd)
            {
                if (!projectHashes.Contains(hash))
                {
                    nonExistingFiles.Add(file);
                }
            }
        }

        var existingFiles = filesToAdd.Count - nonExistingFiles.Count;

        // add files
        List<IGameFile> finalFilesToAdd;
        if (existingFiles > 0)
        {
            var response = await Interactions.ShowMessageBoxAsync(
                $"{existingFiles}/{filesToAdd.Count} Files exist in project. Overwrite existing files?",
                "Add selected files",
                WMessageBoxButtons.YesNoCancel);

            switch (response)
            {
                // Overwrite all
                case WMessageBoxResult.Yes:
                {
                    finalFilesToAdd = filesToAdd.Values.ToList();
                    break;
                }

                // Skip existing files
                case WMessageBoxResult.No:
                {
                    finalFilesToAdd = nonExistingFiles;
                    break;
                }
                // Rest cancels
                case WMessageBoxResult.None:
                case WMessageBoxResult.OK:
                case WMessageBoxResult.Cancel:
                case WMessageBoxResult.Custom:
                default:
                    return;
            }
        }
        else
        {
            finalFilesToAdd = filesToAdd.Values.ToList();
        }

        InternalAddFiles(finalFilesToAdd);
    }

    private void GetFilesRecursive(RedFileSystemModel directory, Dictionary<ulong, IGameFile> files)
    {
        foreach (var (_, model) in directory.Directories)
        {
            GetFilesRecursive(model, files);
        }
        foreach (var file in directory.Files)
        {
            files.TryAdd(file.Key, file);
        }
    }

    private async void InternalAddFiles(IList<IGameFile> files)
    {
        var progress = 0;

        _progressService.IsIndeterminate = false;
        _progressService.Report(0.1);

        await Parallel.ForEachAsync(files, async (file, token) =>
        {
            await Task.Run(() => { _gameController.GetController().AddToMod(file); }, token);

            Interlocked.Increment(ref progress);
            _progressService.Report(progress / (float)files.Count);
        });

        _progressService.Completed();

        _loggerService.Success($"Added {files.Count} files to the project.");
    }

    /// <summary>
    /// Open file without adding to project
    /// </summary>
    private bool CanOpenFileOnly() => RightSelectedItem is RedFileViewModel;
    [RelayCommand(CanExecute = nameof(CanOpenFileOnly))]
    private void OpenFileOnly()
    {
        if (RightSelectedItem is RedFileViewModel rfvm)
        {
            _appViewModel.OpenRedFileCommand.SafeExecute(rfvm.GetGameFile());
        }
    }

    /// <summary>
    /// Add file or go into directory
    /// </summary>
    [RelayCommand]
    private async Task OpenFileSystemItem()
    {
        if (!ProjectLoaded || ModifierViewStateService.IsShiftBeingHeld)
        {
            OpenFileOnly();
            return;
        }

        switch (RightSelectedItem)
        {
            case RedFileViewModel fileVm:
                await _gameController.GetController().AddFileToModModalAsync(fileVm.GetGameFile());
                break;
            case RedDirectoryViewModel dirVm:
                MoveToFolder(dirVm);
                break;
            default:
                break;
        }
    }

    public bool IsModBrowserActive() => _archiveManager.IsModBrowserActive;
    [RelayCommand]
    private void ToggleModBrowser()
    {
        if (!_archiveManager.IsModBrowserActive)
        {
            ScanModArchives(_settings.AnalyzeModArchives);
            LeftItems = new ObservableCollection<RedFileSystemModel>(_archiveManager.ModRoots);
        }
        else
        {
            LeftItems = new ObservableCollection<RedFileSystemModel>(_boundRootNodes);
        }

        RightItems = new ObservableCollectionEx<IFileSystemViewModel>();
        _archiveManager.IsModBrowserActive = !_archiveManager.IsModBrowserActive;
        IsModBrowserEnabled = _archiveManager.IsModBrowserActive;
    }

    [RelayCommand]
    private void TogglePreview() => PreviewWidth = PreviewWidth.GridUnitType != GridUnitType.Pixel
            ? new GridLength(0, GridUnitType.Pixel)
            : new GridLength(1, GridUnitType.Star);

    /// <summary>
    /// Copies relative path of node.
    /// </summary>
    private bool CanCopyRelPath() =>
        RightSelectedItem != null && !IsShiftKeyDown; // _projectManager.ActiveProject != null && RightSelectedItem != null;
    [RelayCommand(CanExecute = nameof(CanCopyRelPath))]
    private void CopyRelPath() => Clipboard.SetDataObject(RightSelectedItem.NotNull().FullName);

    /// <summary>
    /// Copies only file name of node.
    /// </summary>
    private bool CanCopyRelPathFileName() => RightSelectedItem != null && IsShiftKeyDown;

    [RelayCommand(CanExecute = nameof(CanCopyRelPathFileName))]
    private void CopyRelPathFileName()
    {
        var fileName = Path.GetFileName(RightSelectedItem.NotNull().FullName);
        if (ModifierViewStateService.IsCtrlBeingHeld)
        {
            fileName = fileName.Replace(Path.GetExtension(fileName), "");
        }

        Clipboard.SetDataObject(fileName);
    }

    private bool CanAddFromArchive() => RightSelectedItem is RedFileViewModel;
    [RelayCommand(CanExecute = nameof(CanAddFromArchive))]
    private async Task AddFromArchive(IGameArchive archive)
    {
        if (archive is not ICyberGameArchive cyberArchive || RightSelectedItem is not RedFileViewModel fileVm)
        {
            return;
        }

        // must use "Value" here to force the exact archive
        var realGameFile = cyberArchive.Files.First(_ => _.Value.Name == fileVm.GetGameFile().Name).Value;
        await _gameController.GetController().AddFileToModModalAsync(realGameFile);
    }

    #endregion commands

    #region methods

    private void MoveToFolder(RedFileSystemModel dir) => LeftSelectedItem = dir;

    private void MoveToFolder(RedDirectoryViewModel dir) => LeftSelectedItem = dir.GetModel();

    /// <summary>
    /// Navigates the Asset Browser to the existing file.
    /// </summary>
    /// <param name="file"></param>
    public void ShowFile(FileSystemModel file)
    {
        _archiveManager.Archives
            .Connect()
            .TransformMany(x => x.Files.Values, y => y.Key)
            .Filter(x => x.Key == file.Hash)
            .Transform(x => new RedFileViewModel(x))
            .Bind(out var list)
            .Subscribe()
            .Dispose();

        if (list.Count > 0)
        {
            RightSelectedItem = list.First();
            BrowseToFolder();
        }
        else
        {
            _notificationService.Warning("File not found in Asset Browser.");
        }

    }

    private CancellationTokenSource? _cancellationTokenSource;

    private void CancelPendingSearch() => _cancellationTokenSource?.Cancel();

    /// <summary>
    /// Filters all game files by given keys or regex pattern
    /// </summary>
    /// <param name="query"></param>
    public async Task PerformSearch(string query)
    {
        _progressService.IsIndeterminate = true;

        LeftSelectedItem = null;
        CancelPendingSearch();

        _cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = _cancellationTokenSource.Token;

        List<RedFileViewModel> foundFiles = [];

        try
        {
            foundFiles.AddRange(await Task.Run(CyberEnhancedSearchAsync, cancellationToken));
            ;
            
            // If the search includes an .archive file, let's select it
            if (s_SearchByArchiveNameRegex().Match(query) is { Success: true } m)
            {
                var archiveName = m.Groups[1].Value;
                SetLeftSelectedItem($"{archiveName}");
            }
        }
        catch (AggregateException ae)
        {
            foreach (var e in ae.Flatten().InnerExceptions)
            {
                if (e is RegexMatchTimeoutException rex)
                {
                    // C# heredoc pls
                    _loggerService.Error(
                        $@"Search took too long! Try to simplify or use refinements? Careful with !. Error: {rex.Message}");
                }
                else
                {
                    _loggerService.Error($"Search error: {e.Message}");
                }
            }
        }
        catch (OperationCanceledException)
        {
            _loggerService.Info("Search was canceled");
        }
        catch (Exception ex)
        {
            _loggerService.Error($"Search error: {ex.Message}");
        }
        finally
        {
            _cancellationTokenSource = null;
        }


        RightItems.SuppressNotification = true;
        RightItems.Clear();

        RightItems.AddRange(foundFiles);

        RightItems.SuppressNotification = false;

        _progressService.IsIndeterminate = false;
    }

    // Asset search impl

    // Safer regexps
    private const RegexOptions s_regexpOpts = RegexOptions.Compiled | RegexOptions.IgnoreCase;
    private static readonly TimeSpan s_regexpSafetyTimeout = TimeSpan.FromSeconds(60);

    private enum TermType
    {
        Unknown,
        Include,
        Exclude,
    }

    private readonly record struct Term(TermType Type, string Pattern, string NegationPattern);

    // Refinement types
    private interface ISearchRefinement
    {
    }

    private readonly record struct PatternRefinement(Term[] Terms) : ISearchRefinement;

    private readonly record struct HashRefinement(ulong Hash) : ISearchRefinement;

    private readonly record struct RegexRefinement(Regex Regex) : ISearchRefinement;

    private readonly record struct ArchivePathRefinement(string ArchivePath) : ISearchRefinement;

    private readonly record struct VerbatimRefinement(string Verbatim) : ISearchRefinement;

    private readonly record struct UsingRefinement(string FilePath) : ISearchRefinement;

    private readonly record struct UsedByRefinement(string FilePath) : ISearchRefinement;

    // Refinement type matchers
    private static readonly Regex s_refinementSeparator = new(@"\s*>\s*", s_regexpOpts, s_regexpSafetyTimeout);
    private static readonly Regex s_isHashRefinement = new("^h(?:ash)?:(?<numbers>\\d+)$", s_regexpOpts, s_regexpSafetyTimeout);
    private static readonly Regex s_isRegexRefinement = new("^r(?:egexp?)?:(?<pattern>.*)$", s_regexpOpts, s_regexpSafetyTimeout);

    private static readonly Regex s_isArchivePathRefinement = new("^a(?:rchive)?:(?<archivepath>.*)$", s_regexpOpts, s_regexpSafetyTimeout);
    private static readonly Regex s_isUsingRefinement = new("^u(?:sing)?:(?<filepath>.*)$", s_regexpOpts, s_regexpSafetyTimeout);
    private static readonly Regex s_isUsedByRefinement = new("^u(?:sed_by)?:(?<filepath>.*)$", s_regexpOpts, s_regexpSafetyTimeout);

    private static readonly Regex s_isVerbatimRefinement = new("^(?:@:?|path:)(?<verbatim>.*)$", s_regexpOpts, s_regexpSafetyTimeout);

    private readonly record struct CyberSearch(Func<IGameFile, bool> Match, ISearchRefinement SourceRefinement);

    // Term to refinement pattern conversion regexps

    private static readonly Regex s_whitespace = new("\\s+", s_regexpOpts, s_regexpSafetyTimeout);
    private static readonly Regex s_pathSeparator = new("(^|\\G|\\w)(?:\\\\|/)(\\w+|$)", s_regexpOpts, s_regexpSafetyTimeout);
    private static readonly string s_pathNormalized = "$1\\\\$2";
    private static readonly Regex s_extensionDot = new("(^|\\G|\\||\\w)\\.(?<term>\\w+?)", s_regexpOpts, s_regexpSafetyTimeout);
    private static readonly string s_extensionDotEscaped = "$1\\.${term}";
    private static readonly Regex s_or = new("\\|", s_regexpOpts, s_regexpSafetyTimeout);

    private static readonly Regex s_negation = new("^(?'Open'\\(\\?:)*\\!(?<term>.+?)(?'Close-Open'\\))*$", s_regexpOpts,
        s_regexpSafetyTimeout);

    private static readonly Regex s_squashExtraWilds = new("((\\(\\?:)?\\.\\*\\??\\)?){2,}", s_regexpOpts, s_regexpSafetyTimeout);

    private static readonly Func<Term, Term> s_normalizePathSeparators =
        term =>
            term with
            {
                Pattern = s_pathSeparator.Replace(term.Pattern, s_pathNormalized)
            };

    private static readonly Func<Term, Term> s_preserveExtensionDotMatch =
        term =>
            term with
            {
                Pattern = s_extensionDot.Replace(term.Pattern, s_extensionDotEscaped)
            };

    private static readonly Func<Term, Term> s_limitOrToOneTermOnly =
        term =>
            s_or.IsMatch(term.Pattern)
                ? term with
                {
                    Pattern = $"(?:{term.Pattern})"
                }
                : term;

    // Negative regexps are extremely fraught even when not synthesized,
    // so instead we simply fail on a negative match (with the corresponding
    // positive match so that we know the refinement is otherwise satisfied).
    private static readonly Func<Term, Term> s_allowExcludingTerm = term =>
        !s_negation.IsMatch(term.Pattern)
            ? term with { Type = TermType.Include }
            : term with
            {
                Type = TermType.Exclude,
                Pattern = s_negation.Replace(term.Pattern, "(?:${term})"),
                NegationPattern = s_negation.Replace(term.Pattern, "")
            };


    // Pipeline

    private static readonly Func<string, ISearchRefinement> s_intoTypedRefinements = refinementString =>
    {
        var hashMatch = s_isHashRefinement.Match(refinementString).Groups["numbers"].Value;

        if (!string.IsNullOrEmpty(hashMatch))
        {
            return new HashRefinement { Hash = ulong.Parse(hashMatch) };
        }

        var regexMatch = s_isRegexRefinement.Match(refinementString).Groups["pattern"].Value;

        if (!string.IsNullOrEmpty(regexMatch))
        {
            return new RegexRefinement { Regex = new Regex(regexMatch, s_regexpOpts, s_regexpSafetyTimeout) };
        }

        var archivePathMatch = s_isArchivePathRefinement.Match(refinementString).Groups["archivepath"].Value;

        if (!string.IsNullOrEmpty(archivePathMatch))
        {
            return new ArchivePathRefinement { ArchivePath = archivePathMatch };
        }

        var usingPathMatch = s_isUsingRefinement.Match(refinementString).Groups["archivepath"].Value;

        if (!string.IsNullOrEmpty(archivePathMatch))
        {
            return new UsingRefinement() { FilePath = usingPathMatch };
        }

        var usedByPathMatch = s_isUsedByRefinement.Match(refinementString).Groups["archivepath"].Value;

        if (!string.IsNullOrEmpty(archivePathMatch))
        {
            return new UsedByRefinement() { FilePath = usingPathMatch };
        }

        var verbatimMatch = s_isVerbatimRefinement.Match(refinementString).Groups["verbatim"].Value;

        return !string.IsNullOrEmpty(verbatimMatch)
            ? new VerbatimRefinement
            {
                Verbatim = verbatimMatch.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar)
            }
            : new PatternRefinement
            {
                Terms = s_whitespace
                .Split(refinementString)
                .Select(term => new Term
                {
                    Type = TermType.Unknown,
                    Pattern = term
                })
                .Select(s_normalizePathSeparators)
                .Select(s_preserveExtensionDotMatch)
                .Select(s_limitOrToOneTermOnly)
                .Select(s_allowExcludingTerm)
                .ToArray()
            };
    };


    private static readonly Func<ISearchRefinement, CyberSearch> s_refinementsIntoMatchFunctions =
        searchRefinement =>
        {
            switch (searchRefinement)
            {
                case HashRefinement hashRefinement:
                    return new CyberSearch
                    {
                        Match = candidate => candidate.Key == hashRefinement.Hash,
                        SourceRefinement = hashRefinement,
                    };

                case RegexRefinement regexRefinement:
                    return new CyberSearch
                    {
                        Match = candidate => regexRefinement.Regex.IsMatch(candidate.Name)
                    };

                case ArchivePathRefinement archivePathRefinement:
                    return new CyberSearch
                    {
                        Match = candidate =>
                            candidate.GetArchive().ArchiveRelativePath is string s && !string.IsNullOrEmpty(s) &&
                            s.Contains(archivePathRefinement.ArchivePath ?? "", StringComparison.CurrentCultureIgnoreCase)
                    };

                case VerbatimRefinement verbatimRefinement:
                    return new CyberSearch
                    {
                        Match = candidate => candidate.Name.Contains(verbatimRefinement.Verbatim)
                    };

                case PatternRefinement patternRefinement:
                    var searchContainsExclusion =
                        patternRefinement.Terms.Any(term => term.Type == TermType.Exclude);

                    var patternWithMaybeExtraWilds =
                        $"^.*?{string.Join(".*?", patternRefinement.Terms.Select(term => term.Pattern))}.*$";

                    var pattern =
                        s_squashExtraWilds.Replace(patternWithMaybeExtraWilds, ".*?");

                    var exclusionPatternWithMaybeExtraWilds =
                        $"^.*?{string.Join(".*?", patternRefinement.Terms.Select(term => term.NegationPattern ?? term.Pattern))}.*$";

                    var patternWithoutExcludedTerms =
                        s_squashExtraWilds.Replace(exclusionPatternWithMaybeExtraWilds, ".*?");

                    return new CyberSearch
                    {
                        Match =
                            searchContainsExclusion
                                ? candidate =>
                                    !Regex.IsMatch(candidate.Name, pattern, s_regexpOpts, s_regexpSafetyTimeout) &&
                                    Regex.IsMatch(candidate.Name, patternWithoutExcludedTerms, s_regexpOpts, s_regexpSafetyTimeout)
                                : candidate =>
                                    Regex.IsMatch(candidate.Name, pattern, s_regexpOpts, s_regexpSafetyTimeout),

                        SourceRefinement = patternRefinement
                    };

                default:
                    throw new ArgumentException($"Unknown refinement, shouldn't ever happen. Refinement: {searchRefinement}");
            }
        };


    // will match anything between archive: and either (.archive, word:searchString, $)
    [GeneratedRegex(@"archive:(.*?)(?=\.archive|\w+?:|$)")]
    private static partial Regex s_SearchByArchiveNameRegex();
    
    private void CyberEnhancedSearch()
    {
        if (string.IsNullOrWhiteSpace(SearchBarText))
        {
            RightItems.Clear();
            return;
        }

        try
        {
            SearchBarText = Regex.Replace(SearchBarText, s_refinementSeparator.ToString(), " > ");
        }
        catch
        {
            // if the thread is busy, I guess we aren't replacing anything
        }
        
        var searchAsSequentialRefinements =
            s_refinementSeparator
                .Split(SearchBarText)
                .Select(s_intoTypedRefinements)
                .Select(s_refinementsIntoMatchFunctions)
                .ToArray();

        var filesToSearch =
            _archiveManager.Archives
                .Items
                .Where(x => _archiveManager.IsModBrowserActive == (x.Source == EArchiveSource.Mod))
                .SelectMany(x => x.Files.Values)
                .Where(file => searchAsSequentialRefinements.All(refinement => refinement.Match(file)))
                .GroupBy(x => x.Key)
                .Select(x => x.First())
                .Select(matchingFile => new RedFileViewModel(matchingFile));

        // Should add an indicator here of failures and non-matches

        RightItems.SuppressNotification = true;
        RightItems.Clear();
        RightItems.AddRange(filesToSearch);
        RightItems.SuppressNotification = false;
    }

    private IEnumerable<RedFileViewModel> CyberEnhancedSearchAsync()
    {
        if (string.IsNullOrWhiteSpace(SearchBarText))
        {
            RightItems.Clear();
            return [];
        }

        try
        {
            SearchBarText = Regex.Replace(SearchBarText, s_refinementSeparator.ToString(), " > ");
        }
        catch
        {
            // if the thread is busy, I guess we aren't replacing anything
        }
        
        var searchAsSequentialRefinements =
            s_refinementSeparator
                .Split(SearchBarText)
                .Select(s_intoTypedRefinements)
                .Select(s_refinementsIntoMatchFunctions)
                .ToArray();

        var filesToSearch =
            _archiveManager.Archives
                .Items
                .Where(x => _archiveManager.IsModBrowserActive == (x.Source == EArchiveSource.Mod))
                .SelectMany(x => x.Files.Values)
                .Where(file => searchAsSequentialRefinements.All(refinement => refinement.Match(file)))
                .GroupBy(x => x.Key)
                .Select(x => x.First())
                .Select(matchingFile => new RedFileViewModel(matchingFile));

        return filesToSearch;
    }


    private void SetLeftSelectedItem(string itemName) =>
        LeftSelectedItem = LeftItems.ToList().FirstOrDefault(item => item.Name.Contains(itemName));

    public async void Refresh()
    {
        if (LeftSelectedItem is RedFileSystemModel left)
        {
            LeftSelectedItem = null;
            SetLeftSelectedItem(left.FullName);
        }

        if (SearchBarText is not null)
        {
            await PerformSearch(SearchBarText);
        }
    }

    // Force re-trigger
    public void RefreshModifierStates()
    {
        IsShiftKeyDown = false;
        IsShiftKeyDown = ModifierViewStateService.IsShiftBeingHeld;
    }

    #endregion methods

    // On initialization, scanArchives is read from the settings. On scan button click, we always want to scan.
    public void ScanModArchives(bool scanArchives, string? archiveName = null)
    {
        if (_settings.CP77ExecutablePath is null)
        {
            return;
        }


        var ignoredArchives = _settings.ArchiveNamesExcludeFromScan.Split(",", StringSplitOptions.RemoveEmptyEntries)
            .Select(name => name.Replace(".archive", "")).ToArray();

        
        if (archiveName is null)
        {
            _archiveManager.LoadModArchives(new FileInfo(_settings.CP77ExecutablePath), scanArchives, ignoredArchives);

            if (Directory.Exists(_settings.ExtraModDirPath))
            {
                _archiveManager.LoadAdditionalModArchives(_settings.ExtraModDirPath, scanArchives, ignoredArchives);
            }

            return;
        }

        List<string> archivesToScan = [];
        archivesToScan.AddRange(_archiveManager.GetModArchives()
            .Where(archive => archive.Name.Contains(archiveName, StringComparison.OrdinalIgnoreCase))
            .Select(gameArchive => gameArchive.ArchiveAbsolutePath)
            .Where(absolutePath => !ignoredArchives.Contains(Path.GetFileName(absolutePath).Replace(".archive", ""))));

        if (Directory.Exists(_settings.ExtraModDirPath))
        {
            archivesToScan.AddRange(Directory.GetFiles(_settings.ExtraModDirPath, archiveName, SearchOption.AllDirectories)
                .Where(absolutePath => !ignoredArchives.Contains(Path.GetFileName(absolutePath).Replace(".archive", ""))));
        }

        if (archivesToScan.Count > 0)
        {
            foreach (var absoluteFilepath in archivesToScan)
            {
                _archiveManager.LoadModArchive(absoluteFilepath, scanArchives, !scanArchives);
            }

            return;
        }

        // If no archives match the filter, scan all archives.
        _archiveManager.LoadModArchives(new FileInfo(_settings.CP77ExecutablePath), scanArchives, ignoredArchives);

        if (Directory.Exists(_settings.ExtraModDirPath))
        {
            _archiveManager.LoadAdditionalModArchives(_settings.ExtraModDirPath, scanArchives);
        }
    }
}
