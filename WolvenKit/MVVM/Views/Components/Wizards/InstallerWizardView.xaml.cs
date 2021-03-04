using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.MVVM.Views.Components.Wizards
{
    public partial class InstallerWizardView
    {
        #region Constructors

        public InstallerWizardView()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Installer Wizard");
            }
        }

        #endregion Methods
    }
}
