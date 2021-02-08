
using System.Windows;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class WebsitePageView
    {
        public WebsitePageView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordRPCHelper.WhatAmIDoing("Website Viewer");
            }

        }
    }
}
