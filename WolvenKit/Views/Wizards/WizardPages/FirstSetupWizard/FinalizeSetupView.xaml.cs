
using Catel.IoC;
using WolvenKit.Services;
using WolvenKit.ViewModels.Wizards;

namespace WolvenKit.Views.Wizards.WizardPages.FirstSetupWizard
{
    public partial class FinalizeSetupView
    {
        private readonly ISettingsManager _settingsManager;
        private readonly FirstSetupWizardViewModel _firstSetupWizardViewModel;

        public FinalizeSetupView()
        {
            InitializeComponent();

            _settingsManager = ServiceLocator.Default.ResolveType<ISettingsManager>();
            _firstSetupWizardViewModel = ServiceLocator.Default.ResolveType<FirstSetupWizardViewModel>();
        }

        private void ConfirmSettings_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _settingsManager.Save();
            _firstSetupWizardViewModel.CloseViewModelAsync(null);
        }

        private void CancelSettings_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _firstSetupWizardViewModel.CloseViewModelAsync(null);
        }
    }
}
