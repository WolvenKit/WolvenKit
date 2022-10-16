using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Joins;
using System.Reactive.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DynamicData;
using Microsoft.EntityFrameworkCore;
using Prism.Commands;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Database;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Interaction;
using WolvenKit.Models;
using WolvenKit.Models.Docking;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.Tools
{
    public class AssetBrowserViewModel : ToolViewModel
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
        private readonly IArchiveManager _archiveManager;
        private readonly ISettingsManager _settings;
        private readonly IProjectManager _projectManager;
        private readonly IProgressService<double> _progressService;

        private readonly ILoggerService _loggerService;
        private readonly IPluginService _pluginService;
        private readonly IWatcherService _watcherService;
        private readonly ReadOnlyObservableCollection<RedFileSystemModel> _boundRootNodes;
        private bool _manuallyLoading = false;
        [Reactive] private bool _projectLoaded { get; set; } = false;
        [Reactive] private bool _archiveDirNotFound { get; set; } = true;

        #endregion fields

        #region ctor

        public AssetBrowserViewModel(
            IProjectManager projectManager,
            INotificationService notificationService,
            IGameControllerFactory gameController,
            IArchiveManager archiveManager,
            ISettingsManager settings,
            IProgressService<double> progressService,
            ILoggerService loggerService,
            IPluginService pluginService,
            IWatcherService watcherService
        ) : base(ToolTitle)
        {
            _projectManager = projectManager;
            _notificationService = notificationService;
            _gameController = gameController;
            _archiveManager = archiveManager;
            _settings = settings;
            _progressService = progressService;
            _pluginService = pluginService;
            _watcherService = watcherService;
            _loggerService = loggerService;

            ContentId = ToolContentId;

            State = DockState.Dock;
            SideInDockedMode = DockSide.Tabbed;

            TogglePreviewCommand = new DelegateCommand(ExecuteTogglePreview, CanTogglePreview);
            ToggleModBrowserCommand = new DelegateCommand(ExecuteToggleModBrowser, CanToggleModBrowser);
            CopyRelPathCommand = new DelegateCommand(ExecuteCopyRelPath, CanCopyRelPath).ObservesProperty(() => RightSelectedItem);

            OpenFileOnlyCommand = new DelegateCommand(ExecuteOpenFileOnly, CanOpenFileOnly).ObservesProperty(() => RightSelectedItem);
            AddSelectedCommand = ReactiveCommand.CreateFromTask(AddSelectedAsync);

            OpenFileSystemItemCommand = ReactiveCommand.CreateFromTask(ExecuteOpenFileAsync);

            ExpandAll = ReactiveCommand.Create(() => { });
            CollapseAll = ReactiveCommand.Create(() => { });
            Collapse = ReactiveCommand.Create(() => { });
            Expand = ReactiveCommand.Create(() => { });

            AddSearchKeyCommand = ReactiveCommand.Create<string>(x => SearchBarText += $" {x}:");
            FindUsesCommand = ReactiveCommand.CreateFromTask(FindUses);
            FindUsingCommand = ReactiveCommand.CreateFromTask(FindUsing);
            BrowseToFolderCommand = new DelegateCommand(BrowseToFolder, CanBrowseToFolder).ObservesProperty(() => RightSelectedItem);
            LoadAssetBrowserCommand = ReactiveCommand.CreateFromTask(LoadAssetBrowser);

            OpenWolvenKitSettingsCommand = new DelegateCommand(OpenWolvenKitSettings, CanOpenWolvenKitSettings);

            archiveManager.ConnectGameRoot()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _boundRootNodes)
                .Subscribe(
                _ =>
                    // binds only the root node
                    LeftItems = new ObservableCollection<RedFileSystemModel>(_boundRootNodes));

            _archiveManager
                .WhenAnyValue(x => x.IsManagerLoaded)
                .Subscribe(loaded =>
                {
                    LoadVisibility = loaded ? Visibility.Collapsed : Visibility.Visible;
                    if (loaded)
                    {
                        _notificationService.Success($"Asset Browser is initialized");
                        NoProjectBorderVisibility = Visibility.Collapsed;
                    }
                });

            _projectManager
                .WhenAnyValue(_ => _.IsProjectLoaded)
                .Subscribe(loaded =>
                {
                    _projectLoaded = loaded;
                    ShouldShowLoadButton = !_manuallyLoading && !_projectLoaded && !_archiveDirNotFound;
                });

            _settings
                .WhenAnyValue(_ => _.CP77ExecutablePath)
                .Subscribe(execPath =>
                {
                    if (string.IsNullOrEmpty(execPath))
                    {
                        _archiveDirNotFound = true;
                    }
                    else
                    {
                        DirectoryInfo execDirInfo = new(Path.GetDirectoryName(execPath));

                        _archiveDirNotFound = execDirInfo.Parent.Parent.GetDirectories("archive").Length == 0;
                    }
                    ShouldShowExecutablePathWarning = _archiveDirNotFound;
                    ShouldShowLoadButton = !_manuallyLoading && !_projectLoaded && !_archiveDirNotFound;
                });


            //Classes = _gameController
            //    .GetController()
            //    .GetAvaliableClasses();
        }

        #endregion ctor

        #region properties

        // [Reactive] public string Extension { get; set; } = "reds";

        [Reactive] public GridLength PreviewWidth { get; set; } = new(0, GridUnitType.Pixel);

        [Reactive] public Visibility LoadVisibility { get; set; } = Visibility.Visible;

        [Reactive] public Visibility NoProjectBorderVisibility { get; set; } = Visibility.Visible;

        [Reactive] public bool ShouldShowLoadButton { get; set; }
        [Reactive] public bool ShouldShowExecutablePathWarning { get; set; } = true;

        [Reactive] public ObservableCollection<RedFileSystemModel> LeftItems { get; set; } = new();

        [Reactive] public object LeftSelectedItem { get; set; }

        [Reactive] public IFileSystemViewModel RightSelectedItem { get; set; }

        [Reactive] public ObservableCollectionEx<IFileSystemViewModel> RightItems { get; set; } = new();

        //[Reactive] public ObservableCollection<object> RightSelectedItems { get; set; } = new();

        //[Reactive] public List<string> Classes { get; set; }

        [Reactive] public string SelectedClass { get; set; }

        [Reactive] public string SelectedExtension { get; set; }

        [Reactive] public string SearchBarText { get; set; }

        [Reactive] public string OptionsSearchBarText { get; set; }

        #endregion properties

        #region commands

        public ReactiveCommand<Unit, Unit> LoadAssetBrowserCommand { get; }
        private async Task<Unit> LoadAssetBrowser()
        {
            _manuallyLoading = true;
            ShouldShowLoadButton = !_manuallyLoading && !_projectLoaded && !_archiveDirNotFound;
            await _gameController.GetRed4Controller().HandleStartup();
            return Unit.Default;
        }

        private bool CanOpenWolvenKitSettings() => true;
        public ICommand OpenWolvenKitSettingsCommand { get; private set; }
        private void OpenWolvenKitSettings()
        {
            var homepageViewModel = Locator.Current.GetService<HomePage.HomePageViewModel>();
            var appViewModel = Locator.Current.GetService<AppViewModel>();

            homepageViewModel.SelectedIndex = 1;
            appViewModel.SetActiveOverlay(homepageViewModel);
        }

        public ReactiveCommand<string, Unit> AddSearchKeyCommand { get; set; }
        public ReactiveCommand<Unit, Unit> FindUsingCommand { get; }
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
                        var homepage = Locator.Current.GetService<HomePageViewModel>();
                        var appViewModel = Locator.Current.GetService<AppViewModel>();

                        homepage.NavigateTo(EHomePage.Plugins);
                        appViewModel.SetActiveOverlay(homepage);
                    }

                    break;
                }

                return;
            }

            _progressService.IsIndeterminate = true;

            await Task.Run(async () =>
            {
                using RedDBContext db = new();

                if (RightSelectedItem is RedFileViewModel file)
                {
                    var hash = file.GetGameFile().Key;

                    var usedBy = await db.Files.Include("Uses")
                        .Where(x => x.Uses.Any(y => y.Hash == hash))
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

        public ReactiveCommand<Unit, Unit> FindUsesCommand { get; }
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
                        var homepage = Locator.Current.GetService<HomePageViewModel>();
                        var appViewModel = Locator.Current.GetService<AppViewModel>();

                        homepage.NavigateTo(EHomePage.Plugins);
                        appViewModel.SetActiveOverlay(homepage);
                    }

                    break;
                }

                return;
            }

            _progressService.IsIndeterminate = true;

            await Task.Run(async () =>
            {
                using RedDBContext db = new();

                if (RightSelectedItem is RedFileViewModel file)
                {
                    var hash = file.GetGameFile().Key;

                    var uses = await db.Files.Include("Archive").Include("Uses")
                        .Where(x => x.Archive.Name == file.ArchiveName && x.Hash == hash)
                        .Select(x => x.Uses.Select(y => y.Hash))
                        .ToListAsync();

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

        /// <summary>
        /// Browse the left side folder tree to the folder containing the selected item. (e.g. for after searching)
        /// </summary>
        public ICommand BrowseToFolderCommand { get; private set; }
        private bool CanBrowseToFolder() => RightSelectedItem is RedFileViewModel;
        private void BrowseToFolder()
        {
            if (RightSelectedItem is RedFileViewModel file)
            {
                var fullPath = "";
                var parentDir = LeftItems.ElementAt(0);
                parentDir.IsExpanded = true;

                foreach (var dir in file.GetParentPath().Split(Path.DirectorySeparatorChar))
                {
                    fullPath += dir;
                    parentDir = parentDir.Directories
                        .Where(x => x.Key == fullPath)
                        .First()
                        .Value;
                    parentDir.IsExpanded = true;
                    fullPath += Path.DirectorySeparatorChar;
                }
                MoveToFolder(parentDir);
                RightSelectedItem = RightItems.Where(x => x.FullName == file.FullName).First();
            }
        }

        /// <summary>
        /// Add File to Project
        /// </summary>
        public ReactiveCommand<Unit, Unit> AddSelectedCommand { get; private set; }
        private async Task AddSelectedAsync()
        {
            _watcherService.IsSuspended = true;

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
                }
            }

            // check against existing files
            List<IGameFile> existingFiles = new();
            foreach (var gamefile in filesToAdd)
            {
                FileInfo diskPathInfo = new(Path.Combine(_projectManager.ActiveProject.ModDirectory, gamefile.Name));
                if (diskPathInfo.Exists)
                {
                    existingFiles.Add(gamefile);
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

            _watcherService.IsSuspended = false;
            await _watcherService.RefreshAsync(_projectManager.ActiveProject);
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
        public ICommand OpenFileOnlyCommand { get; private set; }
        private bool CanOpenFileOnly() => RightSelectedItem is RedFileViewModel;
        private void ExecuteOpenFileOnly()
        {
            if (RightSelectedItem is RedFileViewModel rfvm)
            {
                Locator.Current.GetService<AppViewModel>().OpenRedFileCommand.SafeExecute(rfvm.GetGameFile());
            }
        }

        /// <summary>
        /// Add file or go into directory
        /// </summary>
        public ReactiveCommand<Unit, Unit> OpenFileSystemItemCommand { get; private set; }
        private async Task ExecuteOpenFileAsync()
        {
            switch (RightSelectedItem)
            {
                case RedFileViewModel fileVm:
                    await _gameController.GetController().AddFileToModModal(fileVm.GetGameFile());
                    break;
                case RedDirectoryViewModel dirVm:
                    MoveToFolder(dirVm);
                    break;
            }
        }

        public ICommand ToggleModBrowserCommand { get; private set; }
        public bool IsModBrowserActive() => _archiveManager.IsModBrowserActive;
        private bool CanToggleModBrowser() => true;//_archiveManager.IsManagerLoaded;
        private void ExecuteToggleModBrowser()
        {
            if (!_archiveManager.IsModBrowserActive)
            {
                _archiveManager.LoadModsArchives(new FileInfo(_settings.CP77ExecutablePath));
                LeftItems = new ObservableCollection<RedFileSystemModel>(_archiveManager.ModRoots);
            }
            else
            {
                LeftItems = new ObservableCollection<RedFileSystemModel>(_boundRootNodes);
            }

            RightItems = new ObservableCollectionEx<IFileSystemViewModel>();
            _archiveManager.IsModBrowserActive = !_archiveManager.IsModBrowserActive;
        }

        public ICommand TogglePreviewCommand { get; private set; }
        private bool CanTogglePreview() => true;
        private void ExecuteTogglePreview() =>
            PreviewWidth = PreviewWidth.GridUnitType != System.Windows.GridUnitType.Pixel
                ? new System.Windows.GridLength(0, System.Windows.GridUnitType.Pixel)
                : new System.Windows.GridLength(1, System.Windows.GridUnitType.Star);

        /// <summary>
        /// Copies relative path of node.
        /// </summary>
        public ICommand CopyRelPathCommand { get; private set; }
        private bool CanCopyRelPath() => RightSelectedItem != null; // _projectManager.ActiveProject != null && RightSelectedItem != null;
        private void ExecuteCopyRelPath() => Clipboard.SetDataObject(RightSelectedItem.FullName);
        public ReactiveCommand<Unit, Unit> ExpandAll { get; set; }
        public ReactiveCommand<Unit, Unit> CollapseAll { get; set; }
        public ReactiveCommand<Unit, Unit> Expand { get; set; }
        public ReactiveCommand<Unit, Unit> Collapse { get; set; }

        #endregion commands

        #region methods

        private void MoveToFolder(RedFileSystemModel dir) => LeftSelectedItem = dir;

        private void MoveToFolder(RedDirectoryViewModel dir) => LeftSelectedItem = dir.GetModel();

        /// <summary>
        /// Navigates the Asset Browser to the existing file.
        /// </summary>
        /// <param name="file"></param>
        public void ShowFile(FileModel file)
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
                await Task.Run(() => CyberEnhancedSearch());
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
        private readonly record struct VerbatimRefinement(string Verbatim) : SearchRefinement;

        // Refinement type matchers
        private static readonly Regex RefinementSeparator = new("\\s+>\\s+", RegexpOpts, RegexpSafetyTimeout);
        private static readonly Regex IsHashRefinement = new("^h(?:ash)?:(?<numbers>\\d+)$", RegexpOpts, RegexpSafetyTimeout);
        private static readonly Regex IsRegexRefinement = new("^r(?:egexp?)?:(?<pattern>.*)$", RegexpOpts, RegexpSafetyTimeout);
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
            (Term term) =>
                term with
                {
                    Pattern = PathSeparator.Replace(term.Pattern, PathNormalized)
                };

        private static readonly Func<Term, Term> PreserveExtensionDotMatch =
            (Term term) =>
                term with
                {
                    Pattern = ExtensionDot.Replace(term.Pattern, ExtensionDotEscaped)
                };

        private static readonly Func<Term, Term> LimitOrToOneTermOnly =
            (Term term) =>
                Or.IsMatch(term.Pattern)
                    ? term with
                    {
                        Pattern = $"(?:{term.Pattern})"
                    }
                    : term;

        // Negative regexps are extremely fraught even when not synthesized,
        // so instead we simply fail on a negative match (with the corresponding
        // positive match so that we know the refinement is otherwise satisfied).
        private static readonly Func<Term, Term> AllowExcludingTerm = (Term term) =>
            !Negation.IsMatch(term.Pattern)
                ? term with { Type = TermType.Include }
                : term with
                {
                    Type = TermType.Exclude,
                    Pattern = Negation.Replace(term.Pattern, "(?:${term})"),
                    NegationPattern = Negation.Replace(term.Pattern, "")
                };


        // Pipeline

        private static readonly Func<string, SearchRefinement> s_intoTypedRefinements = (string refinementString) =>
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
            (SearchRefinement searchRefinement) =>
            {
                switch (searchRefinement)
                {
                    case HashRefinement hashRefinement:
                        return new CyberSearch
                        {
                            Match = (IGameFile candidate) => candidate.Key == hashRefinement.Hash,
                            SourceRefinement = hashRefinement,
                        };

                    case RegexRefinement regexRefinement:
                        return new CyberSearch
                        {
                            Match = (IGameFile candidate) => regexRefinement.Regex.IsMatch(candidate.Name)
                        };

                    case VerbatimRefinement verbatimRefinement:
                        return new CyberSearch
                        {
                            Match = (IGameFile candidate) => candidate.Name.Contains(verbatimRefinement.Verbatim)
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

        private void CyberEnhancedSearch()
        {
            // Exceptions - this is bananatown you can't put this outside the func, but otherwise we're repeating the types all over the place
            IObservable<IChangeSet<RedFileViewModel, ulong>> LogExceptionAndReturnEmpty(Exception ex)
            {
                _loggerService.Error($"Error performing search: {ex.Message}");
                return Observable.Empty<IChangeSet<RedFileViewModel, ulong>>();
            }

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

            var gameFilesOrMods =
                _archiveManager.IsModBrowserActive
                ? _archiveManager.ModArchives
                : _archiveManager.Archives;

            var filesToSearch =
                gameFilesOrMods
                    .Connect()   // Maybe we could avoid reconnecting every time? Dunno if it makes a difference
                    .TransformMany(archive => archive.Files.Values, fileInArchive => fileInArchive.Key);

            var filesMatchingQuery =
                filesToSearch
                    .Filter((file) =>
                        searchAsSequentialRefinements.All(refinement => refinement.Match(file)));

            var viewableFileList =
                filesMatchingQuery
                    .Transform(matchingFile => new RedFileViewModel(matchingFile))
                    .Catch((Func<Exception, IObservable<IChangeSet<RedFileViewModel, ulong>>>)LogExceptionAndReturnEmpty)
                    .Bind(out var list);

            viewableFileList
                .Subscribe()
                .Dispose();

            // Should add an indicator here of failures and non-matches

            RightItems.SuppressNotification = true;
            RightItems.Clear();
            RightItems.AddRange(list);
            RightItems.SuppressNotification = false;
        }

        #endregion methods
    }
}
