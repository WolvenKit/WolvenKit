using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Catel;
using Catel.Data;
using Catel.MVVM;
using Catel.Services;
using DynamicData;
using DynamicData.Binding;
using HandyControl.Tools;
using ReactiveUI;
using WolvenKit.Functionality.ProjectManagement;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.ViewModels.HomePage;
using RelayCommand = WolvenKit.Functionality.Commands.RelayCommand;

namespace WolvenKit.ViewModels.Shared
{
    public class RecentlyUsedItemsViewModel : ViewModelBase
    {
        #region Fields

        public ObservableCollection<FancyProjectObject> BFancyProjectObjects = new ObservableCollection<FancyProjectObject>();
        private readonly IMessageService _messageService;
        private readonly IProcessService _processService;
        private readonly IRecentlyUsedItemsService _recentlyUsedItemsService;
        private readonly IOpenFileService _openFileService;
        private readonly ReadOnlyObservableCollection<RecentlyUsedItemModel> _recentlyUsedItems;

        #endregion Fields

        #region Constructors

        public RecentlyUsedItemsViewModel(
            IRecentlyUsedItemsService recentlyUsedItemsService,
            IMessageService messageService,
            IProcessService processService,
            IOpenFileService openFileService)
        {
            Argument.IsNotNull(() => recentlyUsedItemsService);
            Argument.IsNotNull(() => messageService);
            Argument.IsNotNull(() => processService);
            Argument.IsNotNull(() => openFileService);

            _recentlyUsedItemsService = recentlyUsedItemsService;
            _messageService = messageService;
            _processService = processService;
            _openFileService = openFileService;

            SettingsCommand = new RelayCommand(ExecSC, CanSC);
            TutorialsCommand = new RelayCommand(ExecTC, CanTC);
            WikiCommand = new RelayCommand(ExecWC, CanWC);

            PinItem = new Command<string>(OnPinItemExecute);
            UnpinItem = new Command<string>(OnUnpinItemExecute);
            OpenInExplorer = new Command<string>(OnOpenInExplorerExecute);

            recentlyUsedItemsService.Items
                .Connect()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _recentlyUsedItems)
                .Subscribe(OnRecentlyUsedItemsChanged);
        }

        private void OnRecentlyUsedItemsChanged(IChangeSet<RecentlyUsedItemModel, string> obj)
        {

            ConvertRecentProjects();
        }

        #endregion Constructors

        #region Properties

        public string DiscordLink => "https://discord.gg/tKZXma5SaA";

        public ObservableCollection<FancyProjectObject> FancyProjects
        {
            get => BFancyProjectObjects;

            set => BFancyProjectObjects = value;
        }

        public string OpenCollectiveLink => "https://opencollective.com/redmodding";
        public Command<string> OpenInExplorer { get; private set; }
        public string PatreonLink => "https://www.patreon.com/m/RedModdingTools";
        public Command<string> PinItem { get; private set; }
        public List<RecentlyUsedItemModel> PinnedItems { get; private set; }
        //public List<RecentlyUsedItem> RecentlyUsedItems { get; private set; }
        public ICommand SettingsCommand { get; private set; }
        public ICommand TutorialsCommand { get; private set; }
        public string TwitterLink => "https://twitter.com/ModdingRed";
        public Command<string> UnpinItem { get; private set; }
        

        public ICommand WikiCommand { get; private set; }

        #endregion Properties

        #region Methods

#pragma warning disable AsyncFixer03 // Avoid fire & forget async void methods
#pragma warning disable AvoidAsyncVoid

        private async void OnOpenInExplorerExecute(string parameter)
#pragma warning restore AsyncFixer03 // Avoid fire & forget async void methods
#pragma warning restore AvoidAsyncVoid
        {
            if (!File.Exists(parameter))
            {
                parameter = await ProjectHelpers.LocateMissingProjectAsync(parameter);
            }

            if (string.IsNullOrEmpty(parameter))
            {
                return;
            }

            _processService.StartProcess("explorer.exe", $"/select, \"{parameter}\"");
        }

        private void ConvertRecentProjects() // Converts Recent projects for the homepage.
        {
            //DispatcherHelper.RunOnMainThread(() =>
            //           {
            //               FancyProjects.Clear();
            //           });
            FancyProjects.Clear();

            foreach (var item in _recentlyUsedItems)
            {
                var fi = new FileInfo(item.Name);

                var n = item.Name;
                var cd = item.DateTime;
                var p = item.Name;

                var newfo = fi.Name.Split('.');
                var newfi = fi.Directory + "\\" + newfo[0] + "\\" + "img.png";

                var IsThere = File.Exists(newfi);

                FancyProjectObject NewItem;
                if (Path.GetExtension(item.Name).TrimStart('.') == EProjectType.cpmodproj.ToString())
                {
                    if (!IsThere)
                    { newfi = "pack://application:,,,/Resources/Media/Images/Application/CpProj.png"; }
                    NewItem = new FancyProjectObject(fi.Name, cd, "Cyberpunk 2077", p, newfi);
                    DispatcherHelper.RunOnMainThread(() =>
                    {
                        FancyProjects.Add(NewItem);
                    });
                }
                if (Path.GetExtension(item.Name).TrimStart('.') == EProjectType.w3modproj.ToString())
                {
                    if (!IsThere)
                    { newfi = "pack://application:,,,/Resources/Media/Images/Application/tw3proj.png"; }

                    NewItem = new FancyProjectObject(n, cd, "The Witcher 3", p, newfi);
                    DispatcherHelper.RunOnMainThread(() =>
                    {
                        FancyProjects.Add(NewItem);
                    });
                }
            }
        }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            //UpdateRecentlyUsedItems();
            //UpdatePinnedItem();
        }

        private bool CanSC() => true;

        private bool CanTC() => true;

        private bool CanWC() => true;

        private void ExecSC() => HomePageViewModel.GlobalHomePageVM.SetCurrentPage("Settings");

        private void ExecTC() => HomePageViewModel.GlobalHomePageVM.SetCurrentPage("Wiki");

        private void ExecWC() => HomePageViewModel.GlobalHomePageVM.SetCurrentPage("Wiki");

        private void OnPinItemExecute(string parameter)
        {
            Argument.IsNotNullOrWhitespace(() => parameter);

            _recentlyUsedItemsService.PinItem(parameter);
        }

        //private void OnRecentlyUsedItemsServiceUpdated(object sender, EventArgs e)
        //{
        //    UpdateRecentlyUsedItems();
        //    UpdatePinnedItem();
        //}

        private void OnUnpinItemExecute(string parameter)
        {
            //Argument.IsNotNullOrWhitespace(() => parameter);

            //_recentlyUsedItemsService.UnpinItem(parameter);
        }

        //private void UpdatePinnedItem() => PinnedItems = new List<RecentlyUsedItem>(_recentlyUsedItemsService.PinnedItems);

        //private void UpdateRecentlyUsedItems()
        //{
        //    //RecentlyUsedItems = new List<RecentlyUsedItem>(_recentlyUsedItemsService.Items);
        //    //ConvertRecentProjects();
        //}

        #endregion Methods

        #region Classes

        public class FancyProjectObject : ObservableObject
        {
            #region Constructors

            public FancyProjectObject(string name, DateTime createdate, string type, string path, string image)
            {
                Name = name;
                CreationDate = createdate;
                Type = type;
                ProjectPath = path;
                Image = image;
                SafeName = Path.GetFileNameWithoutExtension(name);
            }

            #endregion Constructors

            #region Properties

            public DateTime CreationDate { get; set; }
            public string Image { get; set; }
            public DateTime LastEditDate { get; set; }
            public string Name { get; set; }


            public string SafeName { get; set; }
            public string ProjectPath { get; set; }
            public string Type { get; set; }

            #endregion Properties
        }

        #endregion Classes
    }
}
