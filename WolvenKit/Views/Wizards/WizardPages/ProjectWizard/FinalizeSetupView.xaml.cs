
using Catel.IoC;
using WolvenKit.ViewModels.Wizards;

namespace WolvenKit.Views.Wizards.WizardPages.ProjectWizard
{
    public partial class FinalizeSetupView
    {
        ProjectWizardView _pwv;

        public FinalizeSetupView(ProjectWizardView pwv)
        {
            InitializeComponent();

            _pwv = pwv;
            var command = ServiceLocator.Default.ResolveType<ApplicationCreateNewProjectCommandContainer>();
            command.OnCommandCompleted += () => CancelProjectBtn_Click(null, null);
        }

        private void CancelProjectBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            (_pwv.ViewModel as ProjectWizardViewModel).Close();
        }
    }
}
