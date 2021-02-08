
namespace WolvenKit.Views.HomePage.Pages
{
    public partial class AboutPageView
    {
        public AboutPageView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordRPCHelper.WhatAmIDoing("About Page");
            }
        }
    }
}
