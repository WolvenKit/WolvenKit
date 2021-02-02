
namespace WolvenKit.Views.Wizards
{
    public partial class FeedbackWizardView
    {
        public FeedbackWizardView()
        {
            InitializeComponent();
            ShowPage();
        }

   

        private void ShowPage()
        {
            switch (StepMain.StepIndex)
            {
                case 0:
                
                    break;
                case 1:
      
                    break;
                case 2:
          
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
