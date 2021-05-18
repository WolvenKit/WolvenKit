using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Catel;
using Catel.Services;
using Feather.Commands;
using Feather.Controls;
using HandyControl.Data;
using Orchestra.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
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

        private List<IGameArchiveManager> Managers { get; set; }
        private ITreeNode<GameFileTreeNode> _currentNode;

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

            SelectedFiles = new List<IGameFile>();

            SetupToolDefaults();
            ReInit(false);
        }

        #endregion ctor

        #region properties

        public List<string> Classes { get; set; }
        public GameFileTreeNode CurrentNode { get; set; } = new GameFileTreeNode();
        public List<AssetBrowserData> CurrentNodeFiles { get; set; } = new List<AssetBrowserData>();
        public List<string> Extensions { get; set; }
        public string Folder { get; set; }
        public ImageSource Image { get; set; }
        public bool IsLoaded { get; set; }

        // binding properties. do not make private
        // ReSharper disable MemberCanBePrivate.Global
        public bool PreviewVisible { get; set; }

        public System.Windows.GridLength PreviewWidth { get; set; } = new(0, System.Windows.GridUnitType.Pixel);

        private Visibility _loadVisibility = Visibility.Visible;

        public Visibility LoadVisibility
        {
            get => _loadVisibility;
            set
            {
                _loadVisibility = value;
                RaisePropertyChanged(() => LoadVisibility);
            }
        }

        public GameFileTreeNode RootNode { get; set; }

        public string SelectedClass { get; set; }
        public string SelectedExtension { get; set; }
        public List<IGameFile> SelectedFiles { get; set; }
        public AssetBrowserData SelectedNode { get; set; }
        public List<AssetBrowserData> SelectedNodes { get; set; }
        // ReSharper restore MemberCanBePrivate.Global

        public ICommand SetCurrentNodeCommand { get; set; }

        public ICommand OpenDirectoryCommand { get; set; }

        public ITreeNode<GameFileTreeNode> BreadCrumbCurrentNode
        {
            get => _currentNode;
            set
            {
                _currentNode = value;
                RaisePropertyChanged(() => BreadCrumbCurrentNode);
            }
        }

        #endregion properties

        #region commands

        public ICommand HomeCommand { get; private set; }

        public ICommand ImportFileCommand { get; private set; }

        public ICommand SearchStartedCommand { get; private set; }

        public ICommand TogglePreviewCommand { get; private set; }

        private bool CanHome() => true;

        private bool CanImportFile() => SelectedNode != null;

        private bool CanSearchStartedCommand(object arg) => true;

        private bool CanTogglePreview() => true;

        private void ExecuteHome()
        {
            CurrentNode = RootNode;
            CurrentNodeFiles = RootNode.ToAssetBrowserData();
        }

        private void ExecuteImportFile() => ImportFile(SelectedNode);




        private void ExecuteSearchStartedCommand(object arg)
        {

            if (arg is FunctionEventArgs<string> e)
            {
                PerformSearch(e.Info);
            }
        }

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

        #endregion commands

        #region methods

        public async Task SetCurrentNodeAsync(LazyObservableTreeNode<GameFileTreeNode> node)
        {
            BreadCrumbCurrentNode = node;
            UpdateCurrentNode(node.Content);
            //await InitializeCurrentNodeAsync(node.Content);
            await node.RefreshAsync();
        }

        private void UpdateCurrentNode(GameFileTreeNode node)
        {
            CurrentNode = node;
            CurrentNodeFiles = node.ToAssetBrowserData();
        }

        private async Task InitializeCurrentNodeAsync(GameFileTreeNode rnode)
        {
            var rootNode = new LazyObservableTreeNode<GameFileTreeNode>(rnode)
            {
                ChildrenProvider = content => Task.Run(() =>
                {
                    if (content is GameFileTreeNode gfi)
                    {
                        return (IEnumerable<GameFileTreeNode>)content.SubDirectories.ToList();
                    }

                    return null;
                }),
                StringFormat = content => content.Name.Replace("\\", "").Replace("/", "")
            };

            await rootNode.RefreshAsync();

            BreadCrumbCurrentNode = rootNode;


            await ((IRefreshable)CurrentNode).RefreshAsync();
        }

        /// <summary>
        /// Initializes the Asset Browser and populates the data nodes.
        /// </summary>
        public void ReInit(bool loadmods)
        {
            LoadVisibility = Visibility.Visible;
            SetCurrentNodeCommand = new RelayCommand<LazyObservableTreeNode<GameFileTreeNode>>(
                async node => await SetCurrentNodeAsync(node));

            OpenDirectoryCommand = new RelayCommand<GameFileTreeNode>(async info =>
            {
                var node = (LazyObservableTreeNode<GameFileTreeNode>)BreadCrumbCurrentNode.Children.First(item => item.Content.FullPath == info.FullPath);
                await SetCurrentNodeAsync(node);
            });

            
            Managers = _gameController.GetController().GetArchiveManagersManagers(loadmods);

            CurrentNode = new GameFileTreeNode(EArchiveType.ANY) { Name = "Depot" };
            foreach (var mngr in Managers)
            {
                if (mngr.RootNode != null)
                {
                    mngr.RootNode.Parent = CurrentNode;
                    CurrentNode.Directories.Add(mngr.TypeName.ToString(), mngr.RootNode);
                }
            }

            CurrentNodeFiles = CurrentNode.ToAssetBrowserData();
            RootNode = CurrentNode;
            Extensions = _gameController
                .GetController()
                .GetArchiveManagersManagers(loadmods)
                .SelectMany(x => x.Extensions)
                .ToList();
            Classes = _gameController
                .GetController()
                .GetAvaliableClasses();
            PreviewVisible = false;

            IsLoaded = true;

            _notificationService.Success($"Asset Browser is initialized");
            LoadVisibility = Visibility.Collapsed;

            _ = InitializeCurrentNodeAsync(RootNode);
        }

        public void NavigateTo(string path)
        {
            SetCurrentNodeCommand.Execute(RootNode);
            var split = path.Split("\\");
            if (split.Length > 1)
            {
                foreach (var part in split.Skip(1))
                {
                    OpenDirectoryCommand.Execute(BreadCrumbCurrentNode.Children.First(x => x.Content.Name == part));
                }
            }
        }

        protected override Task CloseAsync() =>
            // TODO: Unsubscribe from events

            base.CloseAsync();

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

        private void ImportFile(AssetBrowserData item)
        {
            switch (item.Type)
            {
                case EntryType.Directory:
                {
                    CurrentNode = item.Children;
                    CurrentNode.Parent = item.This;
                    CurrentNodeFiles = item.Children.ToAssetBrowserData();
                    //NavigateTo(CurrentNode.FullPath);
                    break;
                }
                case EntryType.File:
                {
                    Task.Run(new Action(() =>
                    {
                        if (item.This != null)
                        {
                            if (item.This.Files.Count > 0)
                            {
                                if (item.This.Files.ContainsKey(item.Name))
                                {
                                    var it = item.This.Files.FirstOrDefault(x => x.Key == item.Name);
                                    if (it.Value.Count > 0)
                                        _gameController.GetController().AddToMod(it.Value.First());
                                }
                            }
                        }
                    }));

                    break;
                }
                case EntryType.MoveUP:
                {
                    if (item.Parent != null)
                    {
                        CurrentNode = item.Parent;
                        CurrentNodeFiles = item.Parent.ToAssetBrowserData();
                        //NavigateTo(CurrentNode.FullPath);
                    }
                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void PerformSearch(string query)
        {
            var newnode = new GameFileTreeNode()
            {
                Name = "",
                Parent = CurrentNode,
                Directories = new Dictionary<string, GameFileTreeNode>(),
                Files = new Dictionary<string, List<IGameFile>>()
            };
            newnode.Files = Managers.
                SelectMany(_ => CollectFiles(query, _))
                .GroupBy(x => x.Name)
                .Select(x => x.First())
                .Select(f => new KeyValuePair<string, List<IGameFile>>(f.Name, new List<IGameFile>() { f }))
                .ToDictionary(x => x.Key, x => x.Value);
            CurrentNode = newnode;
            CurrentNodeFiles = CurrentNode.ToAssetBrowserData();
        }

        private void SetupToolDefaults()
        {
            ContentId = ToolContentId;

        }        // Define a unique contentid for this toolwindow//BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow//bi.BeginInit();//bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");//bi.EndInit();//IconSource = bi;

        #endregion methods
    }

    public class FolderItem
    {
        #region Constructors

        public FolderItem()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public string Folder { get; set; }
        public ImageSource Image { get; set; }

        #endregion Properties
    }

    public abstract class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
                return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public interface IRefreshable
    {
        Task<bool> RefreshAsync();
    }

    public class LazyObservableTreeNode<T> : BindableBase, ITreeNode<T>, IRefreshable
    {
        private bool _isRefreshing;
        private Func<T, Task<IEnumerable<T>>> _childrenProvider;
        private Func<T, string> _stringFormat;
        private IEnumerable<ITreeNode<T>> _children;

        public LazyObservableTreeNode(T content) => Content = content;

        public virtual Func<T, Task<IEnumerable<T>>> ChildrenProvider
        {
            get => _childrenProvider ??= ((LazyObservableTreeNode<T>)Parent)?.ChildrenProvider;
            set => _childrenProvider = value;
        }

        public Func<T, string> StringFormat
        {
            get => _stringFormat ??= ((LazyObservableTreeNode<T>)Parent).StringFormat;
            set => _stringFormat = value;
        }

        public T Content { get; }

        public virtual ITreeNode<T> Parent { get; protected set; }

        public virtual IEnumerable<ITreeNode<T>> Children
        {
            get => _children;
            protected set => SetProperty(ref _children, value);
        }

        public virtual async Task<bool> RefreshAsync()
        {
            if (_isRefreshing)
                return false;
            _isRefreshing = true;

            if (ChildrenProvider == null)
                return AbortRefresh();
            var enumerable = await ChildrenProvider(Content);
            if (enumerable == null)
                return AbortRefresh();

            var collection = enumerable.ToList();
            if (!collection.Any())
                return AbortRefresh();

            var children = collection.Select(GenerateLazyTreeNode).ToList();
            children.ForEach(item => item.Parent = this);

            SetChildrenCache(children.AsReadOnly());

            _isRefreshing = false;
            return true;
        }

        protected virtual LazyObservableTreeNode<T> GenerateLazyTreeNode(T content) => new LazyObservableTreeNode<T>(content);

        protected virtual void SetChildrenCache(IReadOnlyList<ITreeNode<T>> childrenCache) => Children = childrenCache;

        private bool AbortRefresh()
        {
            Children = null;
            _isRefreshing = false;
            return false;
        }

        public override string ToString() => StringFormat?.Invoke(Content) ?? Content.ToString();
    }

    public class BoolToVisConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                var v = (bool)value;
                return v ? Visibility.Visible : Visibility.Collapsed;
            }
            catch (InvalidCastException)
            {
                return Visibility.Collapsed;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    public class HierarchyItem
    {
        public string ContentString { get; set; }
        public HierarchyItem(string content, params HierarchyItem[] myItems)
        {
            this.ContentString = content;
            itemsObservableCollection = new ObservableCollection<HierarchyItem>();
            foreach (var item in myItems)
            {
                itemsObservableCollection.Add(item);
            }
            HierarchyItems = itemsObservableCollection;
        }
        private ObservableCollection<HierarchyItem> itemsObservableCollection;
        public ObservableCollection<HierarchyItem> HierarchyItems
        {
            get { return itemsObservableCollection; }
            set
            {
                if (itemsObservableCollection != value)
                {
                    itemsObservableCollection = value;
                }
            }
        }
    }
}
