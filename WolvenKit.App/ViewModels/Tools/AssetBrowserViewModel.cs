using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Archive;

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

    public const int SEARCH_LIMIT = 1000;


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

    private readonly ReadOnlyObservableCollection<RedFileSystemModel> _boundRootNodes;

    private bool _manuallyLoading = false;


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
        IPluginService pluginService) : base(ToolTitle)
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

        ContentId = ToolContentId;

        State = DockState.Dock;
        SideInDockedMode = DockSide.Tabbed;

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

    private void OnNext(IChangeSet<RedFileSystemModel> obj) => 
        DispatcherHelper.RunOnMainThread(() => LeftItems = new ObservableCollection<RedFileSystemModel>(_boundRootNodes), DispatcherPriority.ContextIdle);

    private void CheckView()
    {
        ArchiveDirNotFound = _settings.CP77ExecutablePath == null;
        LoadVisibility = _archiveManager.IsManagerLoaded ? Visibility.Collapsed : Visibility.Visible;

        ShouldShowExecutablePathWarning = ArchiveDirNotFound;
        ShouldShowLoadButton = !_manuallyLoading && !_archiveManager.IsManagerLoaded && !_archiveManager.IsManagerLoading;
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
    private ObservableCollectionEx<IFileSystemViewModel> _rightItems = new();

    [ObservableProperty] 
    private string? _selectedClass;

    [ObservableProperty] 
    private string? _selectedExtension;

    [ObservableProperty] 
    private string? _searchBarText;

    [ObservableProperty] 
    private string? _optionsSearchBarText;

    [ObservableProperty] private bool? _isModBrowserEnabled;

    [ObservableProperty]
    private ObservableCollectionEx<IGameArchive> _addFromArchiveItems = new();

    #endregion properties

    #region commands

    [RelayCommand]
    private async Task<Unit> LoadAssetBrowser()
    {
        _manuallyLoading = true;
        ShouldShowLoadButton = !_manuallyLoading && !ProjectLoaded && !ArchiveDirNotFound;
        await _gameController.GetRed4Controller().HandleStartup();
        return Unit.Default;
    }

    [RelayCommand]
    private async Task OpenWolvenKitSettings()
    {
        await _appViewModel.ShowHomePage(EHomePage.Settings);
    }

    [RelayCommand]
    private void AddSearchKey(string value)
    {
        SearchBarText += $" {value}:";
    }

    [RelayCommand]
    private async Task FindUsing()
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
                    await _appViewModel.ShowHomePage(EHomePage.Plugins);
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
            using RedDBContext db = new();

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

                RightItems.Clear();
                RightItems.AddRange(list);
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
                    await _appViewModel.ShowHomePage(EHomePage.Plugins);
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
            using RedDBContext db = new();

            if (RightSelectedItem is RedFileViewModel file && db.Files is not null)
            {
                var hash = file.GetGameFile().Key;

#pragma warning disable CS8604 // Possible null reference argument.
                var uses = await db.Files.Include("Archive").Include("Uses")
                    .Where(x => x.Archive != null && x.Archive.Name == file.ArchiveName && x.Archive.Source == file.ArchiveSource.ToString() && x.Hash == hash)
                    .Where(x => x.Uses != null)
                    .Select(x => x.Uses.Select(y => y.Hash))
                    .ToListAsync();
#pragma warning restore CS8604 // Possible null reference argument.

                //add all found items to
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

            await Task.CompletedTask;
        });

        _progressService.IsIndeterminate = false;
    }

    public void UpdateSearchInArchives()
    {
        AddFromArchiveItems.Clear();
        
        if (RightSelectedItem is RedFileViewModel file)
        {
            var key = file.GetGameFile().Key;
            var archives = _archiveManager
                .Archives
                .Items
                .Where(_ => _.Files.ContainsKey(key));
            
            foreach (var archive in archives)
            {
                AddFromArchiveItems.Add(archive);
            }
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
        List<IGameFile> filesToAdd = new();
        foreach (var o in RightItems.Where(x => x.IsChecked))
        {
            switch (o)
            {
                case RedFileViewModel fileVm:
                    filesToAdd.Add(fileVm.GetGameFile());
                    break;
                case RedDirectoryViewModel dirVm:
                    GetFilesRecursive(dirVm.GetModel(), filesToAdd);
                    break;
                default:
                    break;
            }
        }

        // check against existing files
        List<IGameFile> existingFiles = new();
        if (_projectManager.ActiveProject is not null)
        {
            foreach (var gamefile in filesToAdd)
            {
                FileInfo diskPathInfo = new(Path.Combine(_projectManager.ActiveProject.ModDirectory, gamefile.Name));
                if (diskPathInfo.Exists)
                {
                    existingFiles.Add(gamefile);
                }
            }
        }

        // add files
        List<IGameFile> finalFilesToAdd = new();
        if (existingFiles.Count > 0)
        {
            var response = await Interactions.ShowMessageBoxAsync(
                $"{existingFiles.Count}/{filesToAdd.Count} Files exist in project. Overwrite existing files?",
                "Add selected files",
                WMessageBoxButtons.YesNoCancel);

            switch (response)
            {
                // Overwrite all
                case WMessageBoxResult.Yes:
                {
                    finalFilesToAdd = filesToAdd;
                    break;
                }

                // Skip existing files
                case WMessageBoxResult.No:
                {
                    foreach (var f in filesToAdd)
                    {
                        if (!existingFiles.Contains(f))
                        {
                            finalFilesToAdd.Add(f);
                        }
                    }
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
            finalFilesToAdd = filesToAdd;
        }

        foreach (var file in finalFilesToAdd)
        {
            await Task.Run(() => _gameController.GetController().AddToMod(file));
        }

        _loggerService.Success($"Added {finalFilesToAdd.Count} files to the project.");
    }
    private void GetFilesRecursive(RedFileSystemModel directory, List<IGameFile> files)
    {
        foreach (var (key, model) in directory.Directories)
        {
            GetFilesRecursive(model, files);
        }
        foreach (var file in directory.Files)
        {
            if (!files.Contains(file))
            {
                files.Add(file);
            }
        }
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
        if (!ProjectLoaded)
        {
            OpenFileOnly();
            return;
        }

        switch (RightSelectedItem)
        {
            case RedFileViewModel fileVm:
                await _gameController.GetController().AddFileToModModal(fileVm.GetGameFile());
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
            if (_settings.CP77ExecutablePath is null)
            {
                return;
            }
            _archiveManager.LoadModsArchives(new FileInfo(_settings.CP77ExecutablePath), _settings.AnalyzeModArchives);

            if (Directory.Exists(_settings.ExtraModDirPath))
            {
                _archiveManager.LoadAdditionalModArchives(_settings.ExtraModDirPath, _settings.AnalyzeModArchives);
            }

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
    private void TogglePreview()
    {
        PreviewWidth = PreviewWidth.GridUnitType != GridUnitType.Pixel
            ? new GridLength(0, GridUnitType.Pixel)
            : new GridLength(1, GridUnitType.Star);
    }

    /// <summary>
    /// Copies relative path of node.
    /// </summary>
    private bool CanCopyRelPath() => RightSelectedItem != null; // _projectManager.ActiveProject != null && RightSelectedItem != null;
    [RelayCommand(CanExecute = nameof(CanCopyRelPath))]
    private void CopyRelPath() => Clipboard.SetDataObject(RightSelectedItem.NotNull().FullName);

    private bool CanAddFromArchive() => RightSelectedItem is RedFileViewModel;
    [RelayCommand(CanExecute = nameof(CanAddFromArchive))]
    private void AddFromArchive(IGameArchive archive)
    {
        if (archive is ICyberGameArchive cyberArchive && RightSelectedItem is RedFileViewModel fileVm)
        {
            var realGameFile = cyberArchive.Files.First(_ => _.Value.Name == fileVm.GetGameFile().Name).Value; // must use "Value" here to force the exact archive
            _gameController.GetController().AddFileToModModal(realGameFile); 
        }
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

    /// <summary>
    /// Filters all game files by given keys or regex pattern
    /// </summary>
    /// <param name="query"></param>
    public async Task PerformSearch(string query)
    {
        _progressService.IsIndeterminate = true;

        try
        {
            await Task.Run(CyberEnhancedSearch);

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
                    _loggerService.Error($@"Search took too long! Try to simplify or use refinements? Careful with !. Error: {rex.Message}");
                }
                else
                {
                    _loggerService.Error($"Search error: {e.Message}");
                }
            }
        }

        _progressService.IsIndeterminate = false;
    }

    // Asset search impl

    // Safer regexps
    private static readonly RegexOptions RegexpOpts = RegexOptions.Compiled | RegexOptions.IgnoreCase;
    private static readonly TimeSpan RegexpSafetyTimeout = TimeSpan.FromSeconds(60);

    private enum TermType
    {
        Unknown,
        Include,
        Exclude,
    }

    private readonly record struct Term(TermType Type, string Pattern, string NegationPattern);

    // Refinement types
    private interface SearchRefinement { }
    private readonly record struct PatternRefinement(Term[] Terms) : SearchRefinement;
    private readonly record struct HashRefinement(ulong Hash) : SearchRefinement;
    private readonly record struct RegexRefinement(Regex Regex) : SearchRefinement;
    private readonly record struct ArchivePathRefinement(string ArchivePath) : SearchRefinement;
    private readonly record struct VerbatimRefinement(string Verbatim) : SearchRefinement;

    // Refinement type matchers
    private static readonly Regex RefinementSeparator = new("\\s+>\\s+", RegexpOpts, RegexpSafetyTimeout);
    private static readonly Regex IsHashRefinement = new("^h(?:ash)?:(?<numbers>\\d+)$", RegexpOpts, RegexpSafetyTimeout);
    private static readonly Regex IsRegexRefinement = new("^r(?:egexp?)?:(?<pattern>.*)$", RegexpOpts, RegexpSafetyTimeout);
    private static readonly Regex IsArchivePathRefinement = new Regex("^a(?:rchive)?:(?<archivepath>.*)$", RegexpOpts, RegexpSafetyTimeout);
    private static readonly Regex IsVerbatimRefinement = new("^(?:@:?|path:)(?<verbatim>.*)$", RegexpOpts, RegexpSafetyTimeout);

    private readonly record struct CyberSearch(Func<IGameFile, bool> Match, SearchRefinement SourceRefinement);

    // Term to refinement pattern conversion regexps

    private static readonly Regex Whitespace = new("\\s+", RegexpOpts, RegexpSafetyTimeout);
    private static readonly Regex PathSeparator = new("(^|\\G|\\w)(?:\\\\|/)(\\w+|$)", RegexpOpts, RegexpSafetyTimeout);
    private static readonly string PathNormalized = "$1\\\\$2";
    private static readonly Regex ExtensionDot = new("(^|\\G|\\||\\w)\\.(?<term>\\w+?)", RegexpOpts, RegexpSafetyTimeout);
    private static readonly string ExtensionDotEscaped = "$1\\.${term}";
    private static readonly Regex Or = new("\\|", RegexpOpts, RegexpSafetyTimeout);
    private static readonly Regex Negation = new("^(?'Open'\\(\\?:)*\\!(?<term>.+?)(?'Close-Open'\\))*$", RegexpOpts, RegexpSafetyTimeout);
    private static readonly Regex SquashExtraWilds = new("((\\(\\?:)?\\.\\*\\??\\)?){2,}", RegexpOpts, RegexpSafetyTimeout);

    private static readonly Func<Term, Term> NormalizePathSeparators =
        (term) =>
            term with
            {
                Pattern = PathSeparator.Replace(term.Pattern, PathNormalized)
            };

    private static readonly Func<Term, Term> PreserveExtensionDotMatch =
        (term) =>
            term with
            {
                Pattern = ExtensionDot.Replace(term.Pattern, ExtensionDotEscaped)
            };

    private static readonly Func<Term, Term> LimitOrToOneTermOnly =
        (term) =>
            Or.IsMatch(term.Pattern)
                ? term with
                {
                    Pattern = $"(?:{term.Pattern})"
                }
                : term;

    // Negative regexps are extremely fraught even when not synthesized,
    // so instead we simply fail on a negative match (with the corresponding
    // positive match so that we know the refinement is otherwise satisfied).
    private static readonly Func<Term, Term> AllowExcludingTerm = (term) =>
        !Negation.IsMatch(term.Pattern)
            ? term with { Type = TermType.Include }
            : term with
            {
                Type = TermType.Exclude,
                Pattern = Negation.Replace(term.Pattern, "(?:${term})"),
                NegationPattern = Negation.Replace(term.Pattern, "")
            };


    // Pipeline

    private static readonly Func<string, SearchRefinement> s_intoTypedRefinements = (refinementString) =>
    {
        var hashMatch = IsHashRefinement.Match(refinementString).Groups["numbers"].Value;

        if (!string.IsNullOrEmpty(hashMatch))
        {
            return new HashRefinement { Hash = ulong.Parse(hashMatch) };
        }

        var regexMatch = IsRegexRefinement.Match(refinementString).Groups["pattern"].Value;

        if (!string.IsNullOrEmpty(regexMatch))
        {
            return new RegexRefinement { Regex = new Regex(regexMatch, RegexpOpts, RegexpSafetyTimeout) };
        }

        var archivePathMatch = IsArchivePathRefinement.Match(refinementString).Groups["archivepath"].Value;

        if (!string.IsNullOrEmpty(archivePathMatch))
        {
            return new ArchivePathRefinement { ArchivePath = archivePathMatch };
        }

        var verbatimMatch = IsVerbatimRefinement.Match(refinementString).Groups["verbatim"].Value;

        return !string.IsNullOrEmpty(verbatimMatch)
            ? new VerbatimRefinement
            {
                Verbatim = verbatimMatch.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar)
            }
            : new PatternRefinement
            {
                Terms = Whitespace
                .Split(refinementString)
                .Select(term => new Term
                {
                    Type = TermType.Unknown,
                    Pattern = term
                })
                .Select(NormalizePathSeparators)
                .Select(PreserveExtensionDotMatch)
                .Select(LimitOrToOneTermOnly)
                .Select(AllowExcludingTerm)
                .ToArray()
            };
    };


    private static readonly Func<SearchRefinement, CyberSearch> s_refinementsIntoMatchFunctions =
        (searchRefinement) =>
        {
            switch (searchRefinement)
            {
                case HashRefinement hashRefinement:
                    return new CyberSearch
                    {
                        Match = (candidate) => candidate.Key == hashRefinement.Hash,
                        SourceRefinement = hashRefinement,
                    };

                case RegexRefinement regexRefinement:
                    return new CyberSearch
                    {
                        Match = (candidate) => regexRefinement.Regex.IsMatch(candidate.Name)
                    };

                case ArchivePathRefinement archivePathRefinement:
                    return new CyberSearch
                    {
                        Match = (candidate) => candidate.GetArchive().ArchiveRelativePath.Contains(archivePathRefinement.ArchivePath, StringComparison.CurrentCultureIgnoreCase)
                    };

                case VerbatimRefinement verbatimRefinement:
                    return new CyberSearch
                    {
                        Match = (candidate) => candidate.Name.Contains(verbatimRefinement.Verbatim)
                    };

                case PatternRefinement patternRefinement:
                    var searchContainsExclusion =
                        patternRefinement.Terms.Any(term => term.Type == TermType.Exclude);

                    var patternWithMaybeExtraWilds =
                        $"^.*?{string.Join(".*?", patternRefinement.Terms.Select(term => term.Pattern))}.*$";

                    var pattern =
                        SquashExtraWilds.Replace(patternWithMaybeExtraWilds, ".*?");

                    var exclusionPatternWithMaybeExtraWilds =
                        $"^.*?{string.Join(".*?", patternRefinement.Terms.Select(term => term.NegationPattern ?? term.Pattern))}.*$";

                    var patternWithoutExcludedTerms =
                        SquashExtraWilds.Replace(exclusionPatternWithMaybeExtraWilds, ".*?");

                    return new CyberSearch
                    {
                        Match =
                            searchContainsExclusion
                            ? (IGameFile candidate) =>
                                !Regex.IsMatch(candidate.Name, pattern, RegexpOpts, RegexpSafetyTimeout) &&
                                Regex.IsMatch(candidate.Name, patternWithoutExcludedTerms, RegexpOpts, RegexpSafetyTimeout)
                            : (IGameFile candidate) =>
                                Regex.IsMatch(candidate.Name, pattern, RegexpOpts, RegexpSafetyTimeout),

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

        var searchAsSequentialRefinements =
            RefinementSeparator
                .Split(SearchBarText)
                .Select(s_intoTypedRefinements)
                .Select(s_refinementsIntoMatchFunctions)
                .ToArray();

        var filesToSearch =
            _archiveManager.Archives
                .Items
                .Where(x => !_archiveManager.IsModBrowserActive || x.Source == EArchiveSource.Mod)
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


    private void SetLeftSelectedItem(string itemName)
    {
        if (LeftItems is null || LeftItems.Count == 0)
        {
            return;
        }

        LeftSelectedItem = LeftItems.ToList().FirstOrDefault((item) => item.Name.Contains(itemName));
    }
    #endregion methods
}
