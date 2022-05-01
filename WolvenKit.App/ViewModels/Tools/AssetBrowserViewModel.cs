using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DynamicData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing;
using MoreLinq;
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
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.Models.Docking;
using WolvenKit.RED4.Archive;
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

        private readonly ReadOnlyObservableCollection<RedFileSystemModel> _boundRootNodes;
        private bool _manuallyLoading = false;
        private bool _projectLoaded = false;

        #endregion fields

        #region ctor

        public AssetBrowserViewModel(
            IProjectManager projectManager,
            INotificationService notificationService,
            IGameControllerFactory gameController,
            IArchiveManager archiveManager,
            ISettingsManager settings,
            IProgressService<double> progressService
        ) : base(ToolTitle)
        {
            _projectManager = projectManager;
            _notificationService = notificationService;
            _gameController = gameController;
            _archiveManager = archiveManager;
            _settings = settings;
            _progressService = progressService;

            _loggerService = Splat.Locator.Current.GetService<ILoggerService>();

            ContentId = ToolContentId;

            State = DockState.Dock;
            SideInDockedMode = DockSide.Tabbed;

            TogglePreviewCommand = new RelayCommand(ExecuteTogglePreview, CanTogglePreview);
            OpenFileSystemItemCommand = new RelayCommand(ExecuteOpenFile, CanOpenFile);
            ToggleModBrowserCommand = new RelayCommand(ExecuteToggleModBrowser, CanToggleModBrowser);
            OpenFileLocationCommand = new RelayCommand(ExecuteOpenFileLocationCommand, CanOpenFileLocationCommand);
            CopyRelPathCommand = new RelayCommand(ExecuteCopyRelPath, CanCopyRelPath);

            OpenFileOnlyCommand = new RelayCommand(ExecuteOpenFileOnly, CanOpenFileOnly);
            AddSelectedCommand = new RelayCommand(ExecuteAddSelected, CanAddSelected);

            ExpandAll = ReactiveCommand.Create(() => { });
            CollapseAll = ReactiveCommand.Create(() => { });
            Collapse = ReactiveCommand.Create(() => { });
            Expand = ReactiveCommand.Create(() => { });

            AddSearchKeyCommand = ReactiveCommand.Create<string>(x => SearchBarText += $" {x}:");
            FindUsesCommand = ReactiveCommand.CreateFromTask(FindUses);
            FindUsingCommand = ReactiveCommand.CreateFromTask(FindUsing);
            LoadAssetBrowserCommand = ReactiveCommand.CreateFromTask(LoadAssetBrowser);

            archiveManager.ConnectGameRoot()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _boundRootNodes)
                .Subscribe(
                _ =>
                {
                    // binds only the root node
                    LeftItems = new ObservableCollection<RedFileSystemModel>(_boundRootNodes);
                });

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
                    ShouldShowLoadButton = !_manuallyLoading && !_projectLoaded;
                });


            //Classes = _gameController
            //    .GetController()
            //    .GetAvaliableClasses();
        }

        #endregion ctor

        #region properties

        [Reactive] public string Extension { get; set; } = "reds";

        [Reactive] public GridLength PreviewWidth { get; set; } = new(0, GridUnitType.Pixel);

        [Reactive] public Visibility LoadVisibility { get; set; } = Visibility.Visible;

        [Reactive] public Visibility NoProjectBorderVisibility { get; set; } = Visibility.Visible;

        [Reactive] public bool ShouldShowLoadButton { get; set; }

        [Reactive] public ObservableCollection<RedFileSystemModel> LeftItems { get; set; } = new();

        [Reactive] public object LeftSelectedItem { get; set; }

        [Reactive] public IFileSystemViewModel RightSelectedItem { get; set; }

        [Reactive] public ObservableCollection<IFileSystemViewModel> RightItems { get; set; } = new();

        [Reactive] public ObservableCollection<object> RightSelectedItems { get; set; } = new();

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
            ShouldShowLoadButton = !_manuallyLoading && !_projectLoaded;
            await _gameController.GetRed4Controller().HandleStartup();
            return Unit.Default;
        }

        public ReactiveCommand<string, Unit> AddSearchKeyCommand { get; set; }
        public ReactiveCommand<Unit, Unit> FindUsingCommand { get; }
        private async Task FindUsing()
        {
            _progressService.IsIndeterminate = true;

            await Task.Run(async () =>
            {
                using var db = new RedDBContext();

                if (RightSelectedItem is RedFileViewModel file)
                {
                    var hash = file.GetGameFile().Key;

                    var usedBy = await db.Files.Include("Uses")
                        .Where(x => x.Uses.Any(y => y.Hash == hash))
                        .Select(x => x.Hash)
                        .ToAsyncEnumerable()
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
            _progressService.IsIndeterminate = true;

            await Task.Run(async () =>
            {
                using var db = new RedDBContext();

                if (RightSelectedItem is RedFileViewModel file)
                {
                    var hash = file.GetGameFile().Key;

                    var uses = await db.Files.Include("Archive").Include("Uses")
                        .Where(x => x.Archive.Name == file.ArchiveName && x.Hash == hash)
                        .Select(x => x.Uses.Select(y => y.Hash))
                        .ToAsyncEnumerable()
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

        public ICommand AddSelectedCommand { get; private set; }
        private bool CanAddSelected() => RightSelectedItems != null && RightSelectedItems.Any() && _projectLoaded;
        private void ExecuteAddSelected()
        {
            foreach (var o in RightSelectedItems)
            {
                switch (o)
                {
                    case RedFileViewModel fileVm:
                        AddFile(fileVm);
                        break;
                    case RedDirectoryViewModel dirVm:
                        AddFolderRecursive(dirVm.GetModel());
                        break;
                }
            }
        }

        public ICommand OpenFileOnlyCommand { get; private set; }
        private bool CanOpenFileOnly() => RightSelectedItems != null && RightSelectedItem is RedFileViewModel;
        private void ExecuteOpenFileOnly()
        {
            if (RightSelectedItem is RedFileViewModel rfvm)
            {
                Locator.Current.GetService<AppViewModel>().OpenRedFileAsyncCommand.SafeExecute(rfvm.GetGameFile());
            }
        }

        public ICommand ToggleModBrowserCommand { get; private set; }
        public bool IsModBrowserActive() => _archiveManager.IsModBrowserActive;
        private bool CanToggleModBrowser() => true;//_archiveManager.IsManagerLoaded;
        private void ExecuteToggleModBrowser()
        {
            if (!_archiveManager.IsModBrowserActive)
            {
                _archiveManager.LoadModsArchives(new DirectoryInfo(_settings.GetRED4GameModDir()), null);
                LeftItems = new ObservableCollection<RedFileSystemModel>(_archiveManager.ModRoots);
            }
            else
            {
                LeftItems = new ObservableCollection<RedFileSystemModel>(_boundRootNodes);
            }

            RightItems = new ObservableCollection<IFileSystemViewModel>();
            _archiveManager.IsModBrowserActive = !_archiveManager.IsModBrowserActive;
        }

        public ICommand OpenFileLocationCommand { get; private set; }
        private bool CanOpenFileLocationCommand() => RightSelectedItems != null && RightSelectedItems.OfType<RedFileViewModel>().Any();
        private void ExecuteOpenFileLocationCommand()
        {
            if (RightSelectedItems.First() is not RedFileViewModel fileVm)
            {
                return;
            }

            var parentPath = fileVm.GetParentPath();
            var dir = _archiveManager.LookupDirectory(parentPath, true);
            if (dir != null)
            {
                MoveToFolder(dir);
            }
        }

        public ICommand TogglePreviewCommand { get; private set; }
        private bool CanTogglePreview() => true;
        private void ExecuteTogglePreview() =>
            PreviewWidth = PreviewWidth.GridUnitType != System.Windows.GridUnitType.Pixel
                ? new System.Windows.GridLength(0, System.Windows.GridUnitType.Pixel)
                : new System.Windows.GridLength(1, System.Windows.GridUnitType.Star);

        public ICommand OpenFileSystemItemCommand { get; private set; }
        private bool CanOpenFile() => true;
        private void ExecuteOpenFile()
        {
            if (CanAddSelected())
            {
                switch (RightSelectedItem)
                {
                    case RedFileViewModel fileVm:
                        AddFile(fileVm);
                        break;
                    case RedDirectoryViewModel dirVm:
                        MoveToFolder(dirVm);
                        break;
                }
            }
            else if (CanOpenFileOnly())
            {
                ExecuteOpenFileOnly();
            }
        }
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

        private void AddFile(RedFileViewModel item) => Task.Run(() => _gameController.GetController().AddToMod(item.GetGameFile().Key));

        private void AddFile(ulong hash) => Task.Run(() => _gameController.GetController().AddToMod(hash));

        private void AddFolderRecursive(RedFileSystemModel item)
        {
            foreach (var (key, dir) in item.Directories)
            {
                AddFolderRecursive(dir);
            }
            foreach (var file in item.Files)
            {
                AddFile(file);
            }
        }

        /// <summary>
        /// Navigates the right-side of the browser to the existing file
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

            RightItems.Clear();
            RightItems.AddRange(list);
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
                await Task.Run(() =>
                {
                    CyberEnhancedSearch();
                });
            }
            catch (AggregateException ae)
            {
                foreach (var e in ae.Flatten().InnerExceptions)
                {
                    if (e is RegexMatchTimeoutException rex)
                    {
                        // C# heredoc pls
                        _loggerService.Log($@"Search took too long! Try to simplify or use refinements? Careful with !. Error: {rex.Message}", Logtype.Error);
                    }
                    else
                    {
                        _loggerService.Log($"Search error: {e.Message}", Logtype.Error);
                    }
                }
            }

            _progressService.IsIndeterminate = false;
        }

        private enum TermType
        {
            Unknown,
            Include,
            Exclude,
            Hash,
        }

        private readonly record struct Term(TermType Type, string Pattern, string NegationPattern);

        private interface SearchRefinement {}
        private readonly record struct PatternRefinement(Term[] Terms) : SearchRefinement;
        private readonly record struct HashRefinement(ulong Hash) : SearchRefinement;

        private readonly record struct CyberSearch(Func<IGameFile, bool> Match, SearchRefinement SourceRefinement);

        private static readonly RegexOptions RegexpOpts = RegexOptions.Compiled | RegexOptions.IgnoreCase;
        private static readonly TimeSpan RegexpSafetyTimeout = TimeSpan.FromSeconds(60);

        private static readonly Regex RefinementSeparator = new("\\s+>\\s+", RegexpOpts, RegexpSafetyTimeout);
        private static readonly Regex Hash = new("^(hash:)?(?<num>\\d+)$", RegexpOpts, RegexpSafetyTimeout);
        private static readonly Regex Whitespace = new("\\s+", RegexpOpts, RegexpSafetyTimeout);
        private static readonly Regex Or = new("\\|", RegexpOpts, RegexpSafetyTimeout);
        private static readonly Regex Negation = new("^(?'Open'\\(\\?:)*\\!(?<term>.+?)(?'Close-Open'\\))*$", RegexpOpts, RegexpSafetyTimeout);
        private static readonly Regex SquashExtraWilds = new("((\\(\\?:)?\\.\\*\\??\\)?){2,}", RegexpOpts, RegexpSafetyTimeout);

        private static readonly Func<string, SearchRefinement> IntoTypedRefinementsAndTerms =
            (string refinementString) =>
                Hash.Match(refinementString).Groups["num"].Value switch {
                    "" =>
                        new PatternRefinement
                            {
                                Terms = Whitespace.Split(refinementString).Select(term => new Term { Type = TermType.Unknown, Pattern = term }).ToArray(),
                            },
                    string num =>
                        // let it fail, caught at the top
                        new HashRefinement { Hash = ulong.Parse(num) },
                };

        private static readonly Func<Term, Term> HonorFileExtension =
            (Term term) =>
                term with { Pattern = Regex.Replace(term.Pattern, "(^|\\W)\\.(?<term>\\w+?)", "$1\\.${term}") };

        private static readonly Func<Term, Term> DropUnnecessaryGlobStars =
            (Term term) => term;

        private static readonly Func<Term, Term> LimitOrToOneTerm =
            (Term term) =>
                Or.IsMatch(term.Pattern)
                ? term with { Pattern = $"(?:{term.Pattern})" }
                : term;

        // Negative regexps are extremely fraught even when not synthesized,
        // so instead we simply fail on a negative match (with the corresponding
        // positive match so that we know the refinement is otherwise satisfied).
        private static readonly Func<Term, Term> AllowExcludingTerm =
            (Term term) =>
                !Negation.IsMatch(term.Pattern)
                    ? term with { Type = TermType.Include }
                    : term with
                        {
                            Type = TermType.Exclude,
                            Pattern = Negation.Replace(term.Pattern, "(?:${term})"),
                            NegationPattern = Negation.Replace(term.Pattern,"")
                        };

        private static readonly Func<SearchRefinement, CyberSearch> AsMatchFunctions =
            (SearchRefinement searchRefinement) => {
                switch (searchRefinement) {
                    case HashRefinement hashRefinement:
                        return new CyberSearch {
                            Match = (IGameFile candidate) => candidate.Key == hashRefinement.Hash,
                            SourceRefinement = hashRefinement,
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
                                    (!Regex.IsMatch(candidate.Name, pattern, RegexpOpts, RegexpSafetyTimeout) &&
                                    Regex.IsMatch(candidate.Name, patternWithoutExcludedTerms, RegexpOpts, RegexpSafetyTimeout))
                                : (IGameFile candidate) =>
                                    Regex.IsMatch(candidate.Name, pattern, RegexpOpts, RegexpSafetyTimeout),

                            SourceRefinement = patternRefinement
                        };

                    default:
                        throw new ArgumentException($"Unknown refinement, shouldn't ever happen. Refinement: {searchRefinement}");
                };
            };

        private void CyberEnhancedSearch()
        {
            // Exceptions - this is bananatown but otherwise we're repeating the types all over the place
            Func<Exception, IObservable<IChangeSet<RedFileViewModel, ulong>>> LogExceptionAndReturnEmpty =
                ex =>
                {
                    _loggerService.Error($"Error performing search: {ex.Message}");
                    return Observable.Empty<IChangeSet<RedFileViewModel, ulong>>();
                };

            var searchAsSequentialRefinements =
                RefinementSeparator
                    .Split(SearchBarText)
                    .Select(IntoTypedRefinementsAndTerms)
                    .Select(searchRefinement => searchRefinement switch {
                        PatternRefinement patternRefinement =>
                            patternRefinement with
                            {
                                Terms = patternRefinement.Terms
                                    .Select(HonorFileExtension)
                                    .Select(DropUnnecessaryGlobStars)
                                    .Select(LimitOrToOneTerm)
                                    .Select(AllowExcludingTerm)
                                    .ToArray()
                            },
                        _ => searchRefinement
                    })
                    .Select(AsMatchFunctions)
                    .ToArray();

            var gameFilesOrMods =
                _archiveManager.IsModBrowserActive
                ? _archiveManager.ModArchives
                : _archiveManager.Archives;

            var filesToSearch =
                gameFilesOrMods
                    .Connect()   // Maybe we could avoid reconnecting every time? Dunno if it makes a difference
                    .TransformMany((archive => archive.Files.Values), (fileInArchive => fileInArchive.Key));

            var filesMatchingQuery =
                filesToSearch
                    .Filter((file) =>
                        searchAsSequentialRefinements.All(refinement => refinement.Match(file)));

            var viewableFileList =
                filesMatchingQuery
                    .Transform(matchingFile => new RedFileViewModel(matchingFile))
                    .Catch(LogExceptionAndReturnEmpty)
                    .Bind(out var list);

            viewableFileList
                .Subscribe()
                .Dispose();

            // Should add an indicator here of failures and non-matches

            RightItems.Clear();
            RightItems.AddRange(list);
        }

        public IGameFile LookupGameFile(ulong hash)
        {
            var f = _archiveManager.Lookup(hash);
            return f.HasValue ? f.Value : null;
        }

        #endregion methods
    }
}
