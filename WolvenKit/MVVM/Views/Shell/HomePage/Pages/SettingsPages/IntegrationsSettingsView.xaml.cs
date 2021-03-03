
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.SettingsPages
{
    public partial class IntegrationsSettingsView
    {
        public IntegrationsSettingsView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordHelper.SetDiscordRPCStatus("Setting - Integrations");
            }
        }
    }
}
