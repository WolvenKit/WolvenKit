using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.Wizards
{
    public partial class UserWizardView
    {
        #region Constructors

        public UserWizardView()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("User Wizard");
            }
        }

        #endregion Methods
    }
}
