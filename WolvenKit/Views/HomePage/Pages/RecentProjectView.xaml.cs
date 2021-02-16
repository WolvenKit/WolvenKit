
using System.Windows;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class RecentProjectView
    {
        public RecentProjectView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordRPCHelper.WhatAmIDoing("Recent Projects");
            }

        }
    }
}
