using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class IntegrationsSettingsView
    {
        #region Constructors

        public IntegrationsSettingsView()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
              //  DiscordHelper.SetDiscordRPCStatus("Setting - Integrations");
            }
        }

        #endregion Methods
    }
}
