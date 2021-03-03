
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.Wizards
{
    public partial class InstallerWizardView
    {
        public InstallerWizardView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordHelper.SetDiscordRPCStatus("Installer Wizard");
            }
        }
    }
}
