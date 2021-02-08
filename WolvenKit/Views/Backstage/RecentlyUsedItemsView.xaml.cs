// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RecentlyUsedFilesView.xaml.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace WolvenKit.Views
{
    public partial class RecentlyUsedItemsView
    {
        #region Constructors
        public RecentlyUsedItemsView()
        {
            InitializeComponent();
        }
        #endregion

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordRPCHelper.WhatAmIDoing("BackStage - Recently Used");
            }
        }
    }
}