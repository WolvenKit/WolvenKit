using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.MVVM.Views.Components.Wizards.WizardPages.PublishWizard;

namespace WolvenKit.MVVM.Views.Components.Wizards
{
    public partial class PublishWizardView
    {
        #region Fields

        private FinalizeSetupView FSV;

        private OptionalSettingsView OSV;

        private RequiredSettingsView RSV;

        #endregion Fields

        #region Constructors

        public PublishWizardView()
        {
            RSV = new RequiredSettingsView();
            OSV = new OptionalSettingsView();
            FSV = new FinalizeSetupView();

            InitializeComponent();
            ShowPage();
        }

        #endregion Constructors

        #region Methods

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
