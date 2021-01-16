
namespace WolvenKit.Views.Wizards
{
    public partial class ProjectWizardView
    {
        public ProjectWizardView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            StepMain.Next();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            StepMain.Prev();
        }
    }
}
