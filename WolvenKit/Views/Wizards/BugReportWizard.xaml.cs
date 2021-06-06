using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.Wizards
{
    public partial class BugReportWizard
    {
        #region Constructors

        public BugReportWizard()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
              ///  DiscordHelper.SetDiscordRPCStatus("Bug Report Wizard");
            }
        }

        #endregion Methods
    }
}
