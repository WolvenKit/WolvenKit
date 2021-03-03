
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.Wizards
{
    public partial class UserWizardView
    {
        public UserWizardView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordHelper.SetDiscordRPCStatus("User Wizard");
            }
        }
    }
}
