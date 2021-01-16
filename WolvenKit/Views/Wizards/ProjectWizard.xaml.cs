
namespace WolvenKit.Views.Wizards
{
    public partial class ProjectWizard
    {
        public ProjectWizard()
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
