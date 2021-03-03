using System;
using System.Windows;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.MVVM.Views.Shell.HomePage.Pages
{
    public partial class UserPageView
    {
        public UserPageView()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {



		}


        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordHelper.SetDiscordRPCStatus("User Page");
            }

        }


    }
}
