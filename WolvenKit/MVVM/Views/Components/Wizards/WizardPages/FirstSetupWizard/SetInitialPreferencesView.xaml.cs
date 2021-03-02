
using Catel.IoC;
using WolvenKit.ViewModels.Wizards;

namespace WolvenKit.Views.Wizards.WizardPages.FirstSetupWizard
{
    public partial class SetInitialPreferencesView
    {
        FirstSetupWizardViewModel _fswvm;
        public SetInitialPreferencesView()
        {
            InitializeComponent();

            _fswvm = ServiceLocator.Default.ResolveType<FirstSetupWizardViewModel>();
        }

        private void CheckBox_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            _fswvm.AllFieldIsValid = w3Checkbox.IsChecked == true || cp77Checkbox.IsChecked == true;
        }
    }
}
