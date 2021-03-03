
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Views.Wizards.WizardPages.PublishWizard;

namespace WolvenKit.Views.Wizards
{
    public partial class PublishWizardView
    {
        public PublishWizardView()
        {
            RSV = new RequiredSettingsView();
            OSV = new OptionalSettingsView();
            FSV = new FinalizeSetupView();

            InitializeComponent();
            ShowPage();
        }

        private RequiredSettingsView RSV;
        private OptionalSettingsView OSV;
        private FinalizeSetupView FSV;

        private void ShowPage()
        {
            switch (StepMain.StepIndex)
            {
                case 0:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(RSV);
                    break;
                case 1:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(OSV);
                    break;
                case 2:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(FSV);
                    break;
            }
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            StepMain.Next();
            ShowPage();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            StepMain.Prev();
            ShowPage();
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
