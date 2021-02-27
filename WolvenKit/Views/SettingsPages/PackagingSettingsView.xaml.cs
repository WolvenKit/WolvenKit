
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
                WKitGlobal.DiscordHelper.SetDiscordRPCStatus("Setting - Packaging");
            }
        }
    }
}
