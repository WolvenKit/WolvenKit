using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.Wizards
{
    public partial class FeedbackWizardView
    {
        #region Constructors

        public FeedbackWizardView()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Feedback Wizard");
            }
        }

        #endregion Methods
    }
}
