// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RecentlyUsedFilesViewModel.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace WolvenKit.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Catel;
    using Catel.MVVM;
    using Catel.Services;
    using Orc.FileSystem;
    using Orchestra.Models;
    using Orchestra.Services;

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
                await _messageService.ShowWarningAsync("File does not exist. Cannot be opened in File Explorer.");
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
        }

        private void UpdatePinnedItem()
        {
            PinnedItems = new List<RecentlyUsedItem>(_recentlyUsedItemsService.PinnedItems);
        }
    }
}
