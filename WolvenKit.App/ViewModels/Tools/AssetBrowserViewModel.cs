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

        [Reactive] public bool IsRegexSearchEnabled { get; set; }

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

                if (RightSelectedItem is RedFileViewModel { } file)
                {
                    var hash = file.GetGameFile().Key;
                    var item = db.Find(typeof(RedFile), hash);
                    if (item is RedFile redfile)
                    {
                        var usedby = await db.Files.AsQueryable()
                            .Where(delegate (RedFile x)
                            {
                                return x.Uses != null && x.Uses.Contains(hash);
                            })
                            .Select(x => x.RedFileId)
                            .ToAsyncEnumerable()
                            .ToListAsync();

                        //add all found items to
                        _archiveManager.Archives
                            .Connect()
                            .TransformMany(x => x.Files.Values, y => y.Key)
                            .Filter(x => usedby.Contains(x.Key))
                            .Transform(x => new RedFileViewModel(x))
                            .Bind(out var list)
                            .Subscribe()
                            .Dispose();

                        RightItems.Clear();
                        RightItems.AddRange(list);
                    }
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

            await Task.Run(() =>
            {
                try {
                    CyberEnhancedSearch();
                } catch (RegexMatchTimeoutException ex) {
                    // C# heredoc pls
                    _loggerService.Log($@"Search took too long! Try to simplify or use refinements? Careful with !. Error: {ex.Message}", Logtype.Error);
                } catch (Exception ex) {
                    _loggerService.Log($"Search error: {ex.Message}", Logtype.Error);
                }

                /*
                if (IsRegexSearchEnabled)
                {
                    RegexSearch();
                }
                else
                {
                    KeywordSearch();
                }
                */
            });

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
        private static readonly Regex Negation = new("^\\!(?<term>.+)$", RegexpOpts, RegexpSafetyTimeout);
        private static readonly Regex Or = new("\\|", RegexpOpts, RegexpSafetyTimeout);

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
                            NegationPattern = Negation.Replace(term.Pattern,"(?:.*)")
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

                        var pattern =
                            $"^.*{string.Join(".*?", patternRefinement.Terms.Select(term => term.Pattern))}.*$";
                        var patternWithExclusionsNegated =
                            $"^.*{string.Join(".*?", patternRefinement.Terms.Select(term => term.NegationPattern ?? term.Pattern))}.*$";

                        return new CyberSearch
                        {
                            Match =
                                searchContainsExclusion
                                ? (IGameFile candidate) => (!Regex.IsMatch(candidate.Name, pattern) && Regex.IsMatch(candidate.Name, patternWithExclusionsNegated))
                                : (IGameFile candidate) => Regex.IsMatch(candidate.Name, pattern),

                            SourceRefinement = patternRefinement
                        };

                    default:
                        throw new ArgumentException($"Unknown refinement, shouldn't ever happen. Refinement: {searchRefinement}");
                };
            };

        private void CyberEnhancedSearch()
        {
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
                    .Select(archive =>
                    archive)
                    .ToArray();

            // Maybe we could avoid reconnecting every time? Dunno if it makes a difference
            var gameFiles =
                _archiveManager
                    .Archives
                    .Connect()
                    .Select(archive =>
                    archive)
                    .TransformMany((archive => archive.Files.Values), (fileInArchive => fileInArchive.Key));

            var filesMatchingQuery =
                gameFiles
                    .Filter((file) =>
                        searchAsSequentialRefinements.All(refinement => refinement.Match(file)));

            // Should add an indicator here of the failure

            var viewableFileList =
                filesMatchingQuery
                    .Transform(matchingFile => new RedFileViewModel(matchingFile))
                    .Bind(out var list);

            viewableFileList
                .Subscribe()
                .Dispose();

            RightItems.Clear();
            RightItems.AddRange(list);
        }

        /// <summary>
        /// Parses the search bar and filters all game files by given regex pattern
        /// Glob patterns from the additional search bar are evaluated first
        /// Sets the right hand filelist to the result
        /// </summary>
        private void RegexSearch()
        {
            var matcher = new Matcher();
            matcher.AddInclude(OptionsSearchBarText);

            var rx = new Regex(SearchBarText,
                RegexOptions.Compiled | RegexOptions.IgnoreCase);

            _archiveManager.Archives
                .Connect()
                .TransformMany(x => x.Files.Values, y => y.Key)
                .Filter(x => string.IsNullOrEmpty(OptionsSearchBarText) || matcher.Match(x.Name).HasMatches)
                .Filter(x => rx.IsMatch(x.Name))
                .Transform(x => new RedFileViewModel(x))
                .Bind(out var list)
                .Subscribe()
                .Dispose();

            RightItems.Clear();
            RightItems.AddRange(list);
        }

        /// <summary>
        /// Parses the search bar and filters all game files by given search keys
        /// Glob patterns from the additional search bar are evaluated first
        /// Sets the right hand filelist to the result
        /// </summary>
        private void KeywordSearch()
        {
            if (string.IsNullOrEmpty(SearchBarText))
            {
                return;
            }

            var inputs = SearchBarText.Split(' ');
            var keyDict = Enum
                .GetValues<ESearchKeys>()
                .ToDictionary(key => key, _ => new List<string>());
            keyDict[ESearchKeys.Limit] = new List<string>() { SEARCH_LIMIT.ToString() };

            // e.g. judy ext:mesh,ent test:xxx whatever
            // Name < judy,whatever
            // Ext < mesh,ent
            foreach (var item in inputs)
            {
                //check if keyword
                if (item.Contains(':'))
                {
                    var split = item.Split(':');
                    if (split.Length != 2)
                    {
                        // incorrect format -> disregard
                        continue;
                    }

                    var key = split[0].ToLower();
                    var value = split[1];
                    var names = Enum.GetNames<ESearchKeys>().Select(x => x.ToLower());
                    if (names.Contains(key))
                    {
                        var ekey = (ESearchKeys)Enum.Parse(typeof(ESearchKeys), key, true);
                        // get multiple
                        var multiple = value.Split(',').ToList();
                        // add to query
                        keyDict[ekey] = multiple;
                    }
                }
                else
                {
                    // default to filename search term
                    keyDict[ESearchKeys.Name].Add(item);
                }
            }


            // order from most specific to least
            // 0. Glob

            var matcher = new Matcher();
            matcher.AddInclude(OptionsSearchBarText);
            //var allfiles = _managers.First().Items
            //    .KeyValues.Select(x => x.Value.Name);
            //var match = matcher.Match(allfiles);
            //var debugresult = match.Files.Select(x => x.Path);

            // 1. Hash
            var qhashes = keyDict[ESearchKeys.Hash]
                .Where(x => ulong.TryParse(x, out _))
                .Select(ulong.Parse);
            // 2. Extension
            var qextensions = keyDict[ESearchKeys.Kind]
                .Where(x => Enum.TryParse<ERedExtension>(x, true, out _))
                .Select(x => $".{x}");
            // 3. Name
            var qnames = keyDict[ESearchKeys.Name];
            // 4. Limit
            if (!int.TryParse(keyDict[ESearchKeys.Limit].First(), out var limit))
            {
                limit = SEARCH_LIMIT;
            }

            _archiveManager.Archives
                .Connect()
                .TransformMany(x => x.Files.Values, y => y.Key)
                .Filter(x => string.IsNullOrEmpty(OptionsSearchBarText) || matcher.Match(x.Name).HasMatches)
                .Filter(x =>
                {
                    var enumerable = qhashes as ulong[] ?? qhashes.ToArray();
                    return !enumerable.Any() || enumerable.Contains(x.Key);
                })
                .Filter(x =>
                {
                    var enumerable = qextensions as string[] ?? qextensions.ToArray();
                    return !enumerable.Any() ||
                           enumerable.Any(y => y.Equals(x.Extension, StringComparison.OrdinalIgnoreCase));
                })
                .Filter(x => !qnames.Any() || qnames.Any(y => x.Name.Contains(y, StringComparison.OrdinalIgnoreCase)))
                .LimitSizeTo(limit)
                .Transform(x => new RedFileViewModel(x))
                .Bind(out var list)
                .Subscribe()
                .Dispose();

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
