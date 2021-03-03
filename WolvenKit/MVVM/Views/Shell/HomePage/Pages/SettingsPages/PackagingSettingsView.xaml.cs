
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.SettingsPages
{
    public partial class PackagingSettingsView
    {
        public PackagingSettingsView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordHelper.SetDiscordRPCStatus("Setting - Packaging");
            }
        }
    }
}
