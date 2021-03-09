// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RecentlyUsedFilesViewModel.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Input;
using Catel;
using Catel.Data;
using Catel.MVVM;
using Catel.Services;
using Orc.FileSystem;
using Orchestra.Models;
using Orchestra.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.MVVM.ViewModels.Shell.HomePage;
using static WolvenKit.Functionality.WKitGlobal.Helpers.ProjectHelper;

namespace WolvenKit.MVVM.ViewModels.Shell.Backstage
{
    public class RecentlyUsedItemsViewModel : ViewModelBase
    {
        #region Fields

        public ObservableCollection<FancyProjectObject> BFancyProjectObjects = new ObservableCollection<FancyProjectObject>();
        private readonly IFileService _fileService;
        private readonly IMessageService _messageService;
        private readonly IProcessService _processService;
        private readonly IRecentlyUsedItemsService _recentlyUsedItemsService;

        #endregion Fields

        #region Constructors

        public RecentlyUsedItemsViewModel(IRecentlyUsedItemsService recentlyUsedItemsService, IFileService fileService,
            IMessageService messageService, IProcessService processService)
        {
            Argument.IsNotNull(() => recentlyUsedItemsService);
            Argument.IsNotNull(() => fileService);
            Argument.IsNotNull(() => messageService);
            Argument.IsNotNull(() => processService);

            _recentlyUsedItemsService = recentlyUsedItemsService;
            _fileService = fileService;
            _messageService = messageService;
            _processService = processService;

            SettingsCommand = new RelayCommand(ExecSC, CanSC);
            TutorialsCommand = new RelayCommand(ExecTC, CanTC);
            WikiCommand = new RelayCommand(ExecWC, CanWC);

            PinItem = new Command<string>(OnPinItemExecute);
            UnpinItem = new Command<string>(OnUnpinItemExecute);
            OpenInExplorer = new Command<string>(OnOpenInExplorerExecute);
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
        public List<RecentlyUsedItem> PinnedItems { get; private set; }
        public List<RecentlyUsedItem> RecentlyUsedItems { get; private set; }
        public ICommand SettingsCommand { get; private set; }
        public ICommand TutorialsCommand { get; private set; }
        public string TwitterLink => "https://twitter.com/ModdingRed";
        public Command<string> UnpinItem { get; private set; }
        public string VersionWkit => GetAssemblyVersion();
        public ICommand WikiCommand { get; private set; }

        #endregion Properties

        #region Methods

#pragma warning disable AsyncFixer03 // Avoid fire & forget async void methods
#pragma warning disable AvoidAsyncVoid

        private async void OnOpenInExplorerExecute(string parameter)
#pragma warning restore AsyncFixer03 // Avoid fire & forget async void methods
#pragma warning restore AvoidAsyncVoid
        {
            if (!_fileService.Exists(parameter))
            {
                await _messageService.ShowWarningAsync("The file doesn't seem to exist. Cannot open it in explorer.");
                return;
            }

            _processService.StartProcess("explorer.exe", $"/select, \"{parameter}\"");
        }

        public void ConvertRecentProjects() // Converts Recent projects for the homepage.
        {
            var RCUI = RecentlyUsedItems;
            foreach (var item in RCUI)
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
                    FancyProjects.Add(NewItem);
                }
                if (Path.GetExtension(item.Name).TrimStart('.') == EProjectType.w3modproj.ToString())
                {
                    if (!IsThere)
                    { newfi = "pack://application:,,,/Resources/Media/Images/Application/tw3proj.png"; }

                    NewItem = new FancyProjectObject(n, cd, "The Witcher 3", p, newfi);
                    FancyProjects.Add(NewItem);
                }
            }
        }

        public string GetAssemblyVersion() => GetType().Assembly.GetName().Version.ToString();

        protected override Task CloseAsync()
        {
            _recentlyUsedItemsService.Updated -= OnRecentlyUsedItemsServiceUpdated;

            return base.CloseAsync();
        }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            _recentlyUsedItemsService.Updated += OnRecentlyUsedItemsServiceUpdated;

            UpdateRecentlyUsedItems();
            UpdatePinnedItem();
        }

        private bool CanSC() => true;

        private bool CanTC() => true;

        private bool CanWC() => true;

        private void ExecSC()
        {
            HomePageViewModel.GlobalHomePageVM.SetCurrentPage("Settings");
        }

        private void ExecTC()
        {
            HomePageViewModel.GlobalHomePageVM.SetCurrentPage("Wiki");
        }

        private void ExecWC()
        {
            HomePageViewModel.GlobalHomePageVM.SetCurrentPage("Wiki");
        }

        private void OnPinItemExecute(string parameter)
        {
            Argument.IsNotNullOrWhitespace(() => parameter);

            _recentlyUsedItemsService.PinItem(parameter);
        }

        private void OnRecentlyUsedItemsServiceUpdated(object sender, EventArgs e)
        {
            UpdateRecentlyUsedItems();
            UpdatePinnedItem();
        }

        private void OnUnpinItemExecute(string parameter)
        {
            Argument.IsNotNullOrWhitespace(() => parameter);

            _recentlyUsedItemsService.UnpinItem(parameter);
        }

        private void UpdatePinnedItem() => PinnedItems = new List<RecentlyUsedItem>(_recentlyUsedItemsService.PinnedItems);

        private void UpdateRecentlyUsedItems()
        {
            RecentlyUsedItems = new List<RecentlyUsedItem>(_recentlyUsedItemsService.Items);
            ConvertRecentProjects();
        }

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
            }

            #endregion Constructors

            #region Properties

            public DateTime CreationDate { get; set; }
            public string Image { get; set; }
            public DateTime LastEditDate { get; set; }
            public string Name { get; set; }
            public string ProjectPath { get; set; }
            public string Type { get; set; }

            #endregion Properties
        }

        #endregion Classes
    }
}
