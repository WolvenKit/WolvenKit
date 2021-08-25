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

            TogglePreviewCommand = new RelayCommand(ExecuteTogglePreview, CanTogglePreview);
            ImportFileCommand = new RelayCommand(ExecuteImportFile, CanImportFile);

            AddSelectedCommand = new RelayCommand(ExecuteAddSelected, CanAddSelected);

            SetupToolDefaults();

            var controller = _gameController.GetRed4Controller();
            controller.ConnectHierarchy()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _boundRootNodes)
                .Subscribe(
                _ =>
                {
                    LeftItems = new ObservableCollection<GameFileTreeNode>(_boundRootNodes);
                });

            controller
                .WhenAnyValue(x => x.IsManagerLoaded)
                .Subscribe(b =>
                {
                    LoadVisibility = b ? Visibility.Collapsed : Visibility.Visible;
                    if (b)
                        ReInit(false);
                });


            ExpandAll = ReactiveCommand.Create(() => { });
            CollapseAll = ReactiveCommand.Create(() => { });
            Collapse = ReactiveCommand.Create(() => { });
            Expand = ReactiveCommand.Create(() => { });

        }

        #endregion ctor

        #region properties

        public ReactiveCommand<Unit, Unit> ExpandAll { get; set; }
        public ReactiveCommand<Unit, Unit> CollapseAll { get; set; }
        public ReactiveCommand<Unit, Unit> Expand { get; set; }
        public ReactiveCommand<Unit, Unit> Collapse { get; set; }

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

        #endregion properties

        #region commands

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

        //public ReactiveCommand<string, Unit> SearchStartedCommand { get; private set; }

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

        #endregion commands

        #region methods

        /// <summary>
        /// Initializes the Asset Browser and populates the data nodes.
        /// </summary>
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

        public enum ESearchKeys
        {
            Hash,
            Ext,
            Name,
            Limit,
        }
        public const int SEARCH_LIMIT = 1000;

        public void PerformSearch(string query)
        {
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
            // 1. Hash
            var qhashes = KeyDict[ESearchKeys.Hash]
                .Where(x => ulong.TryParse(x, out _))
                .Select(ulong.Parse);
            // 2. Extension
            var qextensions = KeyDict[ESearchKeys.Ext]
                .Where(x => Enum.TryParse<ERedExtension>(x, true, out _))
                .Select(x => $".{x}");
            // 3. Name
            var qnames = KeyDict[ESearchKeys.Name];
            // 4. Limit
            if (!int.TryParse(KeyDict[ESearchKeys.Limit].First(), out var limit))
            {
                limit = SEARCH_LIMIT;
            }

            var result = _managers.First().Items.KeyValues
                .Where(x => !qhashes.Any() || qhashes.Contains(x.Key))
                .Where(x => !qextensions.Any() || qextensions.Any(y => y.Equals(x.Value.Extension, StringComparison.OrdinalIgnoreCase)))
                .Where(x => !qnames.Any() || qnames.Any(y => x.Value.Name.Contains(y, StringComparison.OrdinalIgnoreCase)))
                .Take(limit)
                .Select(x => new FileEntryViewModel(x.Value));

            RightItems.Clear();
            RightItems.AddRange(result);




            //ReadOnlyObservableCollection<string> allFiles;
            //var disposable1 = _managers.First().Items
            //    .Connect()
            //    .LimitSizeTo(limit)
            //    .Transform(x => x.Name)
            //    .Bind(out allFiles)
            //    .Subscribe();





            //var matcher = new Matcher();
            //matcher.AddInclude($"*{SearchBarText}*");   //matches word
            ////matcher.AddInclude(OptionsSearchBarText);   //matches pattern

            //var allfilesList = allFiles.ToList(); // tolist?
            //var match = matcher.Match(allfilesList);
            //var debugresult = match.Files.Select(x => x.Path);
            //var results = debugresult.Select(x => FNV1A64HashAlgorithm.HashString(x)).ToList(); // to list here? or defer?

            //ReadOnlyObservableCollection<FileEntryViewModel> list;
            //var disposable2 = _managers.First().Items
            //    .Connect()
            //    .Filter(x => results.Contains(x.Key)) // bad
            //    .LimitSizeTo(1000)
            //    .Transform(x => new FileEntryViewModel(x))
            //    .Bind(out list)
            //    .Subscribe();

            //RightItems.Clear();
            //RightItems.AddRange(list);
        }

        private void SetupToolDefaults()
        {
            ContentId = ToolContentId;
        }        // Define a unique contentid for this toolwindow//BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow//bi.BeginInit();//bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");//bi.EndInit();//IconSource = bi;

        #endregion methods
    }
}
