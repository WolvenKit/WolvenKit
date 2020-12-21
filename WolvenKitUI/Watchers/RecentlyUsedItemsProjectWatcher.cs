// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RecentlyUsedItemsProjectWatcher.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace WolvenKitUI
{
    using System;
    using System.Threading.Tasks;
    using Catel;
    using Orc.ProjectManagement;
    using Orchestra.Models;
    using Orchestra.Services;

    public class RecentlyUsedItemsProjectWatcher : ProjectWatcherBase
    {
        #region Fields
        private readonly IRecentlyUsedItemsService _recentlyUsedItemsService;
        #endregion

        #region Constructors
        public RecentlyUsedItemsProjectWatcher(IProjectManager projectManager, IRecentlyUsedItemsService recentlyUsedItemsService)
            : base(projectManager)
        {
            Argument.IsNotNull(() => recentlyUsedItemsService);

            _recentlyUsedItemsService = recentlyUsedItemsService;
        }
        #endregion

        #region Methods
        protected override Task OnLoadedAsync(IProject project)
        {
            _recentlyUsedItemsService.AddItem(new RecentlyUsedItem(project.Location, DateTime.Now));

            return base.OnLoadedAsync(project);
        }
        #endregion
    }
}