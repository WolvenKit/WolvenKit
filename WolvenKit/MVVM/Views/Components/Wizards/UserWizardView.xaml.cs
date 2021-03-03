using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.MVVM.Views.Components.Wizards
{
    public partial class UserWizardView
    {
        public UserWizardView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("User Wizard");
            }
        }
    }
}
