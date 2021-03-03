
using Catel.IoC;
using WolvenKit.MVVM.ViewModels.Components.Wizards;

namespace WolvenKit.MVVM.Views.Components.Wizards.WizardPages.FirstSetupWizard
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
