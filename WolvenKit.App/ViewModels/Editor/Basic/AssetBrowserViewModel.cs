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
using RelayCommand = WolvenKit.Functionality.Commands.RelayCommand;

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

        [Reactive] public bool StillLoading { get; set; }

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

            SearchStartedCommand = new DelegateCommand<object>(ExecuteSearchStartedCommand, CanSearchStartedCommand);
            TogglePreviewCommand = new RelayCommand(ExecuteTogglePreview, CanTogglePreview);
            ImportFileCommand = new RelayCommand(ExecuteImportFile, CanImportFile);

            AddSelectedCommand = new RelayCommand(ExecuteAddSelected, CanAddSelected);

            SetupToolDefaults();

            var controller = _gameController.GetRed4Controller();
            controller.ConnectHierarchy()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _boundRootNodes)
                .Subscribe(OnRootNodesUpdated);

            controller
                .WhenAnyValue(x => x.IsManagerLoaded)
                .Subscribe(b =>
                {
                    LoadVisibility = b ? Visibility.Collapsed : Visibility.Visible;
                });


            ExpandAll = ReactiveCommand.Create(() => { });
            CollapseAll = ReactiveCommand.Create(() => { });
            Collapse = ReactiveCommand.Create(() => { });
            Expand = ReactiveCommand.Create(() => { });

        }

        private void OnRootNodesUpdated(IChangeSet<GameFileTreeNode, string> obj) => LeftItems = new ObservableCollection<GameFileTreeNode>(_boundRootNodes);

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
        [Reactive] public IEnumerable<FileEntryViewModel> RightItems { get; set; }

        /// <summary>
        /// Selected Files in right navigaiton
        /// </summary>
        [Reactive] public ObservableCollection<object> RightSelectedItems { get; set; }

        [Reactive] public List<string> Extensions { get; set; }
        [Reactive] public List<string> Classes { get; set; }
        [Reactive] public string SelectedClass { get; set; }
        [Reactive] public string SelectedExtension { get; set; }

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

        public ICommand SearchStartedCommand { get; private set; }

        private bool CanSearchStartedCommand(object arg) => true;

        private void ExecuteSearchStartedCommand(object arg)
        {
            if (arg is FunctionEventArgs<string> e)
            {
                PerformSearch(e.Info);
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

        private static IEnumerable<IGameFile> CollectFiles(string searchkeyword, IGameArchiveManager root)
        {
            var ret = new Dictionary<string, IGameFile>();
            foreach (var f in root.FileList)
            {
                if (f.Name.Contains(searchkeyword, StringComparison.OrdinalIgnoreCase))
                {
                    if (!ret.ContainsKey(f.Name))
                    {
                        ret.TryAdd(f.Name, f);
                    }
                }
            }
            return ret.Values.ToList();
        }

        private void AddFile(FileEntryViewModel item)
        {
            if (item != null)
            {
                Task.Run(() => _gameController.GetController().AddToMod(item.GetGameFile()));
            }
        }

        private void PerformSearch(string query)
        {
            var files = _managers.
                SelectMany(_ => CollectFiles(query, _))
                .GroupBy(x => x.Name)
                .Select(x => x.First())
                ;
            RightItems = files
                .Select(_ => new FileEntryViewModel(_));
        }

        private void SetupToolDefaults()
        {
            ContentId = ToolContentId;
        }        // Define a unique contentid for this toolwindow//BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow//bi.BeginInit();//bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");//bi.EndInit();//IconSource = bi;

        #endregion methods
    }
}
