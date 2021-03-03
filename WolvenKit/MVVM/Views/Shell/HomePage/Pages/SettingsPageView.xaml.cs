
using System.Windows;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class SettingsPageView
    {
        public SettingsPageView()
        {
            InitializeComponent();
        }

        private void TabControlDemo_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // I wanted to add logic that the selected tab item moves to be the first in the row but I am not sure it works with the HC tabcontrol. If someone feels liek testing this later go ahead :D


        }


        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordHelper.SetDiscordRPCStatus("Settings");
            }

        }
    }
}
