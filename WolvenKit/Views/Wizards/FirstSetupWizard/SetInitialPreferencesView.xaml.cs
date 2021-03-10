using Catel.IoC;
using WolvenKit.ViewModels.Wizards;

namespace WolvenKit.Views.Wizards.WizardPages.FirstSetupWizard
{
    public partial class SetInitialPreferencesView
    {
        #region Fields

        private FirstSetupWizardViewModel _fswvm;

        #endregion Fields

        #region Constructors

        public SetInitialPreferencesView()
        {
            InitializeComponent();

            _fswvm = ServiceLocator.Default.ResolveType<FirstSetupWizardViewModel>();
        }

        #endregion Constructors

        #region Methods

        private void CheckBox_Checked(object sender, System.Windows.RoutedEventArgs e) => _fswvm.AllFieldIsValid = w3Checkbox.IsChecked == true || cp77Checkbox.IsChecked == true;

        #endregion Methods
    }
}
