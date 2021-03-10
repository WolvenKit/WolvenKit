using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class PackagingSettingsView
    {
        public PackagingSettingsView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Setting - Packaging");
            }
        }
    }
}
