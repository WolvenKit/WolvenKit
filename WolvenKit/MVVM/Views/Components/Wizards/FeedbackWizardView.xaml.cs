
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Views.Wizards.WizardPages.FeedbackWizard;

namespace WolvenKit.Views.Wizards
{
    public partial class FeedbackWizardView
    {
        public FeedbackWizardView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordHelper.SetDiscordRPCStatus("Feedback Wizard");
            }
        }
    }
}
