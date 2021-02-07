
using System.Windows;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class GithubPageView
    {
        public GithubPageView()
        {
            InitializeComponent();
        }
        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordRPCHelper.WhatAmIDoing("Github Viewer");
            }

        }
    }
}
