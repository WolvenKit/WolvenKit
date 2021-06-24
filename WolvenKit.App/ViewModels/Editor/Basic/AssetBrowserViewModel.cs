using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Catel;
using Catel.Services;
using DynamicData;
using HandyControl.Data;
using Orchestra.Services;
using ReactiveUI;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
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
        private readonly IMessageService _messageService;
        private readonly IGrowlNotificationService _notificationService;
        private readonly IProjectManager _projectManager;
        private readonly IGameControllerFactory _gameController;

        private List<IGameArchiveManager> _managers;
        private readonly ReadOnlyObservableCollection<GameFileTreeNode> _boundRootNodes;


        private bool _stillLoading;

        public bool StillLoading
        {
            get => _stillLoading;
            set
            {
                _stillLoading = value;
                RaisePropertyChanged(() => StillLoading);
            }
        }

        #endregion fields

        #region ctor

        public AssetBrowserViewModel(
            IProjectManager projectManager,
            ILoggerService loggerService,
            IMessageService messageService,
            IGrowlNotificationService notificationService,
            IGameControllerFactory gameController
        ) : base(ToolTitle)
        {
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => messageService);
            Argument.IsNotNull(() => loggerService);
            Argument.IsNotNull(() => notificationService);
            Argument.IsNotNull(() => gameController);

            _projectManager = projectManager;
            _loggerService = loggerService;
            _messageService = messageService;
            _notificationService = notificationService;
            _gameController = gameController;

            SearchStartedCommand = new DelegateCommand<object>(ExecuteSearchStartedCommand, CanSearchStartedCommand);
            TogglePreviewCommand = new RelayCommand(ExecuteTogglePreview, CanTogglePreview);
            ImportFileCommand = new RelayCommand(ExecuteImportFile, CanImportFile);
            HomeCommand = new RelayCommand(ExecuteHome, CanHome);

            AddSelectedCommand = new RelayCommand(ExecuteAddSelected, CanAddSelected);


            SetupToolDefaults();
            ReInit(false);

            var controller = _gameController.GetRed4Controller();
            var disposable = controller.ConnectHierarchy()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _boundRootNodes)
                .Subscribe(OnRootNodesUpdated);
        }

        private void OnRootNodesUpdated(IChangeSet<GameFileTreeNode, string> obj) => BoundRootNodes = new ObservableCollection<GameFileTreeNode>(_boundRootNodes);

        #endregion ctor

        #region properties

        // binding properties. do not make private
        // ReSharper disable MemberCanBePrivate.Global
        public bool PreviewVisible { get; set; }
        public bool IsLoaded { get; set; }
        public GridLength PreviewWidth { get; set; } = new(0, System.Windows.GridUnitType.Pixel);
        public Visibility LoadVisibility { get; set; } = Visibility.Visible;


        /// <summary>
        /// Bound RootNodes to left navigation
        /// </summary>
        public ObservableCollection<GameFileTreeNode> BoundRootNodes { get; set; } = new();

        /// <summary>
        /// Selected Root node in left navigation
        /// </summary>
        public /*GameFileTreeNode*/ object SelectedNode { get; set; }

        /// <summary>
        /// Items (Files) inside a Node (Folder) bound to right navigation
        /// </summary>
        public IEnumerable<FileEntryViewModel> CurrentNodeFiles { get; set; }

        /// <summary>
        /// Selected File in right navigaiton
        /// </summary>
        public FileEntryViewModel SelectedFile { get; set; }
        /// <summary>
        /// Selected Files in right navigaiton
        /// </summary>
        public ObservableCollection<object> SelectedFiles { get; set; }


        public List<string> Extensions { get; set; }
        public List<string> Classes { get; set; }
        public string SelectedClass { get; set; }
        public string SelectedExtension { get; set; }

        public ICommand SetCurrentNodeCommand { get; set; }



        #endregion properties

        #region commands

        public ICommand AddSelectedCommand { get; private set; }

        private bool CanAddSelected() => SelectedFiles != null && SelectedFiles.Any();

        private void ExecuteAddSelected()
        {
            foreach (var o in SelectedFiles)
            {
                if (o is FileEntryViewModel fileVm)
                {
                    AddFile(fileVm);
                }
            }
        }

        public ICommand HomeCommand { get; private set; }
        private bool CanHome() => true;
        private void ExecuteHome()
        {
            SelectedNode = BoundRootNodes.FirstOrDefault();
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
        private void ExecuteImportFile() => AddFile(SelectedFile);

        #endregion commands

        #region methods

        /// <summary>
        /// Initializes the Asset Browser and populates the data nodes.
        /// </summary>
        public void ReInit(bool loadmods)
        {
            LoadVisibility = Visibility.Visible;

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

            IsLoaded = true;

            _notificationService.Success($"Asset Browser is initialized");
            LoadVisibility = Visibility.Collapsed;

            RaisePropertyChanged(nameof(BoundRootNodes));
        }

        protected override async Task InitializeAsync() => await base.InitializeAsync();// TODO: Write initialization code here and subscribe to events

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

        private void AddFile(FileEntryViewModel item) => Task.Run(() => _gameController.GetController().AddToMod(item.GetGameFile()));

        private void PerformSearch(string query)
        {
            var files = _managers.
                SelectMany(_ => CollectFiles(query, _))
                .GroupBy(x => x.Name)
                .Select(x => x.First())
                ;
            CurrentNodeFiles = files
                .Select(_ => new FileEntryViewModel(_));
        }


        private void PreformFolderSearch(string query)
        {

        }

        private void SetupToolDefaults()
        {
            ContentId = ToolContentId;

        }        // Define a unique contentid for this toolwindow//BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow//bi.BeginInit();//bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");//bi.EndInit();//IconSource = bi;

        #endregion methods
    }
}
