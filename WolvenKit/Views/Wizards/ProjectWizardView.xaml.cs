
using WolvenKit.Views.Wizards.WizardPages.ProjectWizard;

namespace WolvenKit.Views.Wizards
{
    public partial class ProjectWizardView
    {
        public ProjectWizardView()
        {
            InitializeComponent();
            ShowPage();
        }

        private void ShowPage()
        {
            switch(StepMain.StepIndex)
            {
                case 0:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(new SelectProjectTypeView());
                    break;
                case 1:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(new ProjectConfigurationView());
                    break;
                case 2:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(new FinalizeSetupView());
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
    }
}
