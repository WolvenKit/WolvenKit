// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RecentlyUsedFilesViewModel.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace WolvenKit.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Threading;
    using Catel;
    using Catel.Data;
    using Catel.IoC;
    using Catel.MVVM;
    using Catel.Services;
    using Orc.FileSystem;
    using Orchestra.Models;
    using Orchestra.Services;
    using WolvenKit.WKitGlobal;
    using static WolvenKit.WKitGlobal.ProjectHelper;

    public class RecentlyUsedItemsViewModel : ViewModelBase
    {
        private readonly IRecentlyUsedItemsService _recentlyUsedItemsService;
        private readonly IFileService _fileService;
        private readonly IMessageService _messageService;
        private readonly IProcessService _processService;

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

            PinItem = new Command<string>(OnPinItemExecute);
            UnpinItem = new Command<string>(OnUnpinItemExecute);
            OpenInExplorer = new Command<string>(OnOpenInExplorerExecute);
        }

        public List<RecentlyUsedItem> RecentlyUsedItems { get; private set; }
        public List<RecentlyUsedItem> PinnedItems { get; private set; }

        #region Commands
        public Command<string> PinItem { get; private set; }

        private void OnPinItemExecute(string parameter)
        {
            Argument.IsNotNullOrWhitespace(() => parameter);

            _recentlyUsedItemsService.PinItem(parameter);
        }

        public Command<string> UnpinItem { get; private set; }

        private void OnUnpinItemExecute(string parameter)
        {
            Argument.IsNotNullOrWhitespace(() => parameter);

            _recentlyUsedItemsService.UnpinItem(parameter);
        }

        public Command<string> OpenInExplorer { get; private set; }

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
        #endregion

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            _recentlyUsedItemsService.Updated += OnRecentlyUsedItemsServiceUpdated;

            UpdateRecentlyUsedItems();
            UpdatePinnedItem();
        }

        protected override Task CloseAsync()
        {
            _recentlyUsedItemsService.Updated -= OnRecentlyUsedItemsServiceUpdated;

            return base.CloseAsync();
        }

        private void OnRecentlyUsedItemsServiceUpdated(object sender, EventArgs e)
        {
            UpdateRecentlyUsedItems();
            UpdatePinnedItem();
        }

        private void UpdateRecentlyUsedItems()
        {
            RecentlyUsedItems = new List<RecentlyUsedItem>(_recentlyUsedItemsService.Items);
            ConvertRecentProjects();
        }

        private void UpdatePinnedItem()
        {
            PinnedItems = new List<RecentlyUsedItem>(_recentlyUsedItemsService.PinnedItems);
        }

        public ObservableCollection<FancyProjectObject> BFancyProjectObjects = new ObservableCollection<FancyProjectObject>();
        public ObservableCollection<FancyProjectObject> FancyProjects { get { return BFancyProjectObjects; }

            set
            {
                BFancyProjectObjects = value;
            }

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
                    { newfi = "pack://application:,,,/Resources/Icons/CpProj.png"; }
                    NewItem = new FancyProjectObject(fi.Name, cd, "Cyberpunk 2077", p, newfi);
                    Application.Current.Dispatcher.BeginInvoke(
                                            DispatcherPriority.Background,
                                            new Action(() =>
                                            {
                                                FancyProjects.Add(NewItem);
                                            }));
                }
                if (Path.GetExtension(item.Name).TrimStart('.') == EProjectType.w3modproj.ToString())
                {
                    if (!IsThere)
                    { newfi = "pack://application:,,,/Resources/Icons/tw3proj.png"; }

                    NewItem = new FancyProjectObject(n, cd, "The Witcher 3", p, newfi);
                    Application.Current.Dispatcher.BeginInvoke(
                                           DispatcherPriority.Background,
                                           new Action(() =>
                                           {
                                               FancyProjects.Add(NewItem);
                                           }));
                }
            }
        }

        public string VersionWkit { get { return GetAssemblyVersion(); } }
        public string GetAssemblyVersion()
        {
            return GetType().Assembly.GetName().Version.ToString();
        }


        public string DiscordLink { get { return "https://discord.gg/tKZXma5SaA"; } }
        public string PatreonLink { get { return "https://www.patreon.com/m/RedModdingTools"; } }
        public string OpenCollectiveLink { get { return "https://opencollective.com/redmodding"; } }
        public string TwitterLink { get { return "https://twitter.com/ModdingRed"; } }

        public class FancyProjectObject : ObservableObject
        {
            public string Name { get; set; }
            public DateTime CreationDate { get; set; }
            public DateTime LastEditDate { get; set; }
            public string Type { get; set; }
            public string ProjectPath { get; set; }
            public string Image { get; set; }

            public FancyProjectObject(string name, DateTime createdate,string type, string path ,string image)
            {
                Name = name;
                CreationDate = createdate;
                Type = type;
                ProjectPath = path;
                Image = image;
               
            }
        }
    }

   
}
