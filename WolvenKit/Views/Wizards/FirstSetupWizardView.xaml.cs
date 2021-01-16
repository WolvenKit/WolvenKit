
using WolvenKit.Views.Wizards.WizardPages.FirstSetupWizard;

namespace WolvenKit.Views.Wizards
{
    public partial class FirstSetupWizardView
    {
        public FirstSetupWizardView()
        {
            InitializeComponent();
            ShowPage();
        }

        private void ShowPage()
        {
            switch (StepMain.StepIndex)
            {
                case 0:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(new CreateUserView());
                    break;
                case 1:
                    PageGrid.Children.Clear();
                    PageGrid.Children.Add(new SelectThemeView());
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
