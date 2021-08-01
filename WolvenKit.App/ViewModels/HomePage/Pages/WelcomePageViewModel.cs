using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using DotNetHelper.FastMember.Extension.Helpers;
using DynamicData;
using Microsoft.WindowsAPICodePack.Dialogs;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.ProjectManagement;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal;
using WolvenKit.Interaction;
using WolvenKit.ViewModels.HomePage;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.Shared
{
    public class WelcomePageViewModel : PageViewModel
    {
        #region Fields

        private readonly IRecentlyUsedItemsService _recentlyUsedItemsService;
        private readonly IProjectManager _projectManager;
        private readonly WorkSpaceViewModel _mainViewModel;

        private readonly ReadOnlyObservableCollection<RecentlyUsedItemModel> _recentlyUsedItems;

        #endregion Fields

        #region Constructors

        public WelcomePageViewModel(
            IRecentlyUsedItemsService recentlyUsedItemsService,
            IProjectManager projectManager
            )
        {

            _mainViewModel = Locator.Current.GetService<WorkSpaceViewModel>();

            _projectManager = projectManager;
            _recentlyUsedItemsService = recentlyUsedItemsService;


            SettingsCommand = new RelayCommand(ExecSC, CanSC);
            TutorialsCommand = new RelayCommand(ExecTC, CanTC);
            WikiCommand = new RelayCommand(ExecWC, CanWC);

            PinItem = new DelegateCommand<string>(OnPinItemExecute);
            UnpinItem = new DelegateCommand<string>(OnUnpinItemExecute);
            OpenInExplorer = new DelegateCommand<string>(OnOpenInExplorerExecute);

            OpenProjectCommand = ReactiveCommand.Create<string>(s =>
            {
                _mainViewModel.OpenProjectCommand.Execute(s).Subscribe();
            });
            DeleteProjectCommand = ReactiveCommand.Create<string>(s =>
            {
                _mainViewModel.DeleteProjectCommand.Execute(s).Subscribe();
            });
            NewProjectCommand = ReactiveCommand.Create(() =>
            {
                _mainViewModel.NewProjectCommand.Execute().Subscribe();
            });

            recentlyUsedItemsService.Items
                .Connect()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _recentlyUsedItems)
                .Subscribe(OnRecentlyUsedItemsChanged);
        }

        private void OnRecentlyUsedItemsChanged(IChangeSet<RecentlyUsedItemModel, string> obj) => ConvertRecentProjects();

        #endregion Constructors

        #region Properties


        public string DiscordLink = "https://discord.gg/tKZXma5SaA";
        public string OpenCollectiveLink = "https://opencollective.com/redmodding";
        public string PatreonLink = "https://www.patreon.com/m/RedModdingTools";
        public string TwitterLink = "https://twitter.com/ModdingRed";


        [Reactive] public ObservableCollection<FancyProjectObject> FancyProjects { get; set; } = new();

        [Reactive] public List<RecentlyUsedItemModel> PinnedItems { get; private set; } = new();

        public ReactiveCommand<string, Unit> OpenProjectCommand { get; }
        public ReactiveCommand<string, Unit> DeleteProjectCommand { get; }
        public ReactiveCommand<Unit, Unit> NewProjectCommand { get; }
        public ICommand OpenInExplorer { get; private set; }
        public ICommand PinItem { get; private set; }
        public ICommand SettingsCommand { get; private set; }
        public ICommand TutorialsCommand { get; private set; }
        public ICommand UnpinItem { get; private set; }
        public ICommand WikiCommand { get; private set; }
        public readonly ReactiveCommand<string, Unit> OpenLinkCommand = ReactiveCommand.Create<string>(
            link =>
            {
                var ps = new ProcessStartInfo(link)
                {
                    UseShellExecute = true,
                    Verb = "open"
                };
                Process.Start(ps);
            });


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
                parameter = await LocateMissingProjectAsync(parameter);
            }

            if (string.IsNullOrEmpty(parameter))
            {
                return;
            }

            Process.Start("explorer.exe", $"/select, \"{parameter}\"");
        }


        private async Task<string> LocateMissingProjectAsync(string parameter)
        {
            var delete = await Interactions.Confirm.Handle(parameter);
            if (!delete)
            {
                var items = _recentlyUsedItemsService.Items.Items
                    .Where(_ => _.Name == parameter)
                    .ToList();
                if (items.Count > 0)
                {
                    _recentlyUsedItemsService.RemoveItem(items.FirstOrDefault());
                }
                return "";
            }
            else
            {
                var dlg = new CommonOpenFileDialog
                {
                    AllowNonFileSystemItems = false,
                    Multiselect = false,
                    IsFolderPicker = false,
                    Title = "Locate the WolvenKit project"
                };
                dlg.Filters.Add(new CommonFileDialogFilter("Cyberpunk 2077 Project", "*.cpmodproj"));

                if (dlg.ShowDialog() != CommonFileDialogResult.Ok)
                {
                    return "";
                }

                var result = dlg.FileName;
                if (string.IsNullOrEmpty(result))
                {
                    return "";
                }

                parameter = result;

                var items = _recentlyUsedItemsService.Items.Items
                    .Where(_ => Path.GetFileName(_.Name) == Path.GetFileName(parameter))
                    .ToList();
                if (items.Count > 0)
                {
                    var item = items.First();
                    _recentlyUsedItemsService.AddItem(new RecentlyUsedItemModel(parameter, item.DateTime));
                    _recentlyUsedItemsService.RemoveItem(item);
                    return parameter;
                }
            }

            return "";
        }

        private void ConvertRecentProjects() // Converts Recent projects for the homepage.
        {
            HandyControl.Tools.DispatcherHelper.RunOnMainThread(() =>
            {
                FancyProjects.Clear();
            });

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
                    HandyControl.Tools.DispatcherHelper.RunOnMainThread(() =>
                    {
                        FancyProjects.Add(NewItem);
                    });
                }
                if (Path.GetExtension(item.Name).TrimStart('.') == EProjectType.w3modproj.ToString())
                {
                    if (!IsThere)
                    { newfi = "pack://application:,,,/Resources/Media/Images/Application/tw3proj.png"; }

                    NewItem = new FancyProjectObject(n, cd, "The Witcher 3", p, newfi);
                    HandyControl.Tools.DispatcherHelper.RunOnMainThread(() =>
                    {
                        FancyProjects.Add(NewItem);
                    });
                }
            }
        }

        private bool CanSC() => true;

        private bool CanTC() => true;

        private bool CanWC() => true;

        private void ExecSC() => Locator.Current.GetService<HomePageViewModel>()?.SetCurrentPage("Settings");

        private void ExecTC() => Locator.Current.GetService<HomePageViewModel>()?.SetCurrentPage("Wiki");

        private void ExecWC() => Locator.Current.GetService<HomePageViewModel>()?.SetCurrentPage("Wiki");

        private void OnPinItemExecute(string parameter)
        {
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

        public class FancyProjectObject : ReactiveObject
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
