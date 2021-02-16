
using System.Windows;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class WikiPageView
    {
        public WikiPageView()
        {
            InitializeComponent(); 

        }

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordRPCHelper.WhatAmIDoing("Wiki");
            }

        }
    }
}
