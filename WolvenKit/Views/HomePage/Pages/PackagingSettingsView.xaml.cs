using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class PackagingSettingsView
    {
        #region Constructors

        public PackagingSettingsView()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
             //   DiscordHelper.SetDiscordRPCStatus("Setting - Packaging");
            }
        }

        #endregion Methods
    }
}
