using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ReactiveUI.Fody.Helpers;
using DynamicData;
using HandyControl.Data;
using ReactiveUI;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using DynamicData.Binding;
using Microsoft.Extensions.FileSystemGlobbing;
using WolvenKit.Common.FNV1A;
using System.IO;
using System.Text.RegularExpressions;

namespace WolvenKit.ViewModels.Editor
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

        private readonly ILoggerService _loggerService;
        private readonly INotificationService _notificationService;
        private readonly IProjectManager _projectManager;
        private readonly IGameControllerFactory _gameController;

        private List<IGameArchiveManager> _managers;
        private readonly ReadOnlyObservableCollection<GameFileTreeNode> _boundRootNodes;


        #endregion fields

        #region ctor

        public AssetBrowserViewModel(
            IProjectManager projectManager,
            ILoggerService loggerService,
            INotificationService notificationService,
            IGameControllerFactory gameController
        ) : base(ToolTitle)
        {
            _projectManager = projectManager;
            _loggerService = loggerService;
            _notificationService = notificationService;
            _gameController = gameController;

            ContentId = ToolContentId;

            TogglePreviewCommand = new RelayCommand(ExecuteTogglePreview, CanTogglePreview);
            ImportFileCommand = new RelayCommand(ExecuteImportFile, CanImportFile);
            AddSelectedCommand = new RelayCommand(ExecuteAddSelected, CanAddSelected);
            OpenFileLocationCommand = new RelayCommand(ExecuteOpenFileLocationCommand, CanOpenFileLocationCommand);

            ExpandAll = ReactiveCommand.Create(() => { });
            CollapseAll = ReactiveCommand.Create(() => { });
            Collapse = ReactiveCommand.Create(() => { });
            Expand = ReactiveCommand.Create(() => { });

            AddSearchKeyCommand = ReactiveCommand.Create<string>(x => SearchBarText += $" {x}:");

            var controller = _gameController.GetRed4Controller();
            controller.ConnectHierarchy()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _boundRootNodes)
                .Subscribe(
                _ =>
                {
                    // binds only the root node
                    LeftItems = new ObservableCollection<GameFileTreeNode>(_boundRootNodes);
                });

            controller
                .WhenAnyValue(x => x.IsManagerLoaded)
                .Subscribe(b =>
                {
                    LoadVisibility = b ? Visibility.Collapsed : Visibility.Visible;
                    if (b)
                    {
                        ReInit(false);
                    }
                });


           
        }

        #endregion ctor

        #region properties

        // binding properties. do not make private
        [Reactive] public bool PreviewVisible { get; set; }

        [Reactive] public GridLength PreviewWidth { get; set; } = new(0, GridUnitType.Pixel);

        [Reactive] public Visibility LoadVisibility { get; set; } = Visibility.Visible;

        /// <summary>
        /// Bound RootNodes to left navigation
        /// </summary>
        [Reactive] public ObservableCollection<GameFileTreeNode> LeftItems { get; set; } = new();

        /// <summary>
        /// Selected Root node in left navigation
        /// </summary>
        [Reactive] public object LeftSelectedItem { get; set; }

        /// <summary>
        /// Selected File in right navigaiton
        /// </summary>
        [Reactive] public FileEntryViewModel RightSelectedItem { get; set; }

        /// <summary>
        /// Items (Files) inside a Node (Folder) bound to right navigation
        /// </summary>
        [Reactive] public ObservableCollection<FileEntryViewModel> RightItems { get; set; } = new();

        /// <summary>
        /// Selected Files in right navigaiton
        /// </summary>
        [Reactive] public ObservableCollection<object> RightSelectedItems { get; set; } = new();

        [Reactive] public List<string> Extensions { get; set; }
        [Reactive] public List<string> Classes { get; set; }
        [Reactive] public string SelectedClass { get; set; }
        [Reactive] public string SelectedExtension { get; set; }

        [Reactive] public string SearchBarText { get; set; }
        [Reactive] public string OptionsSearchBarText { get; set; }

        [Reactive] public bool IsRegexSearchEnabled { get; set; }

        #endregion properties

        #region commands

        public ReactiveCommand<string, Unit> AddSearchKeyCommand { get; set; }

        public ICommand AddSelectedCommand { get; private set; }
        private bool CanAddSelected() => RightSelectedItems != null && RightSelectedItems.Any();
        private void ExecuteAddSelected()
        {
            foreach (var o in RightSelectedItems)
            {
                if (o is FileEntryViewModel fileVm)
                {
                    AddFile(fileVm);
                }
            }
        }

        public ICommand OpenFileLocationCommand { get; private set; }
        private bool CanOpenFileLocationCommand() => RightSelectedItems != null && RightSelectedItems.Any();
        private void ExecuteOpenFileLocationCommand()
        {
            if (RightSelectedItems.First() is FileEntryViewModel fileVm)
            {
                var parentHash = fileVm.GetParentHash();
                if (parentHash == 0)
                {

                }
                else
                {
                    if (LeftItems.Any(_ => _.Hash == parentHash))
                    {
                        var parent = LeftItems.First(_ => _.Hash == parentHash);
                        LeftSelectedItem = parent;
                    }
                }
            }
        }

        public ICommand TogglePreviewCommand { get; private set; }
        private bool CanTogglePreview() => true;
        private void ExecuteTogglePreview()
        {
            if (PreviewWidth.GridUnitType != System.Windows.GridUnitType.Pixel)
            {
                PreviewWidth = new System.Windows.GridLength(0, System.Windows.GridUnitType.Pixel);
                PreviewVisible = true;
            }
            else
            {
                PreviewWidth = new System.Windows.GridLength(1, System.Windows.GridUnitType.Star);
                PreviewVisible = false;
            }
        }

        public ICommand ImportFileCommand { get; private set; }
        private bool CanImportFile() => /*CurrentNode != null*/ true;
        private void ExecuteImportFile() => AddFile(RightSelectedItem);

        public ReactiveCommand<Unit, Unit> ExpandAll { get; set; }
        public ReactiveCommand<Unit, Unit> CollapseAll { get; set; }
        public ReactiveCommand<Unit, Unit> Expand { get; set; }
        public ReactiveCommand<Unit, Unit> Collapse { get; set; }

        #endregion commands

        #region methods

        /// <summary>
        /// Initializes the Asset Browser and populates the data nodes.
        /// Optionally load mods
        /// </summary>
        /// <param name="loadmods"></param>
        public void ReInit(bool loadmods)
        {
            _managers = _gameController.GetController().GetArchiveManagers(loadmods);

            Extensions = _gameController
                .GetController()
                .GetArchiveManagers(loadmods)
                .SelectMany(x => x.Extensions)
                .ToList();
            Classes = _gameController
                .GetController()
                .GetAvaliableClasses();
            PreviewVisible = false;

            _notificationService.Success($"Asset Browser is initialized");
        }

        private void AddFile(FileEntryViewModel item)
        {
            if (item != null)
            {
                Task.Run(() => _gameController.GetController().AddToMod(item.GetGameFile()));
            }
        }

        /// <summary>
        /// Filters all game files by given keys or regex pattern
        /// </summary>
        /// <param name="query"></param>
        public void PerformSearch(string query)
        {
            if (IsRegexSearchEnabled)
            {
                RegexSearch();
            }
            else
            {
                KeywordSearch();
            }
        }

        /// <summary>
        /// Parses the search bar and filters all game files by given regex pattern
        /// Glob patterns from the additional search bar are evaluated first
        /// Sets the right hand filelist to the result 
        /// </summary>
        public void RegexSearch()
        {
            var matcher = new Matcher();
            matcher.AddInclude(OptionsSearchBarText);

            Regex rx = new Regex(SearchBarText,
                RegexOptions.Compiled | RegexOptions.IgnoreCase);

            ReadOnlyObservableCollection<FileEntryViewModel> list;
            _managers.First().Items
                .Connect()
                .Filter(x => string.IsNullOrEmpty(OptionsSearchBarText) || matcher.Match(x.Name).HasMatches)
                .Filter(x => rx.IsMatch(x.Name))
                .Transform(x => new FileEntryViewModel(x))
                .Bind(out list)
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
        public void KeywordSearch()
        {
            if (string.IsNullOrEmpty(SearchBarText))
            {
                return;
            }

            var inputs = SearchBarText.Split(' ');
            Dictionary<ESearchKeys, List<string>> KeyDict = Enum
                .GetValues<ESearchKeys>()
                .ToDictionary(key => key, key => new List<string>());
            KeyDict[ESearchKeys.Limit] = new List<string>() { SEARCH_LIMIT.ToString() };

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
                        KeyDict[ekey] = multiple;
                    }
                }
                else
                {
                    // default to filename search term
                    KeyDict[ESearchKeys.Name].Add(item);
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
            var qhashes = KeyDict[ESearchKeys.Hash]
                .Where(x => ulong.TryParse(x, out _))
                .Select(ulong.Parse);
            // 2. Extension
            var qextensions = KeyDict[ESearchKeys.Kind]
                .Where(x => Enum.TryParse<ERedExtension>(x, true, out _))
                .Select(x => $".{x}");
            // 3. Name
            var qnames = KeyDict[ESearchKeys.Name];
            // 4. Limit
            if (!int.TryParse(KeyDict[ESearchKeys.Limit].First(), out var limit))
            {
                limit = SEARCH_LIMIT;
            }

            ReadOnlyObservableCollection<FileEntryViewModel> list;
            _managers.First().Items
                .Connect()
                .Filter(x => string.IsNullOrEmpty(OptionsSearchBarText) || matcher.Match(x.Name).HasMatches)
                .Filter(x => !qhashes.Any() || qhashes.Contains(x.Key))
                .Filter(x => !qextensions.Any() || qextensions.Any(y => y.Equals(x.Extension, StringComparison.OrdinalIgnoreCase)))
                .Filter(x => !qnames.Any() || qnames.Any(y => x.Name.Contains(y, StringComparison.OrdinalIgnoreCase)))
                .LimitSizeTo(limit)
                .Transform(x => new FileEntryViewModel(x))
                .Bind(out list)
                .Subscribe()
                .Dispose();

            RightItems.Clear();
            RightItems.AddRange(list);
        }

        #endregion methods
    }
}
