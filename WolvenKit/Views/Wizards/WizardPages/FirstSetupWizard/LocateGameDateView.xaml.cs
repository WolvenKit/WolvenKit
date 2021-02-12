using Catel.IoC;
using Catel.Services;
using WolvenKit.Services;
using WolvenKit.ViewModels.Wizards;

namespace WolvenKit.Views.Wizards.WizardPages.FirstSetupWizard
{
    public partial class LocateGameDateView
    {
        private readonly ISettingsManager _settingsManager;
        private readonly FirstSetupWizardViewModel _firstSetupWizardViewModel;
        private readonly IOpenFileService _openFileService;
        private readonly ISelectDirectoryService _selectDirectoryService;

        public LocateGameDateView()
        {
            InitializeComponent();

            _settingsManager = ServiceLocator.Default.ResolveType<ISettingsManager>();
            _firstSetupWizardViewModel = ServiceLocator.Default.ResolveType<FirstSetupWizardViewModel>();
            _openFileService = ServiceLocator.Default.ResolveType<IOpenFileService>();
            _selectDirectoryService = ServiceLocator.Default.ResolveType<ISelectDirectoryService>();
        }

        private void CP77ExecutablePathBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (_firstSetupWizardViewModel.OpenCP77GamePathCommand.CanExecute(null))
            {
                _firstSetupWizardViewModel.OpenCP77GamePathCommand.Execute(null);
            }
        }

        private void W3ExecutablePathBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (_firstSetupWizardViewModel.OpenW3GamePathCommand.CanExecute(null))
            {
                _firstSetupWizardViewModel.OpenW3GamePathCommand.Execute(null);
            }
        }

        private void WccLitePathBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (_firstSetupWizardViewModel.OpenWccPathCommand.CanExecute(null))
            {
                _firstSetupWizardViewModel.OpenWccPathCommand.Execute(null);
            }
        }

        private async void DepotPathBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var result = await _selectDirectoryService.DetermineDirectoryAsync(
                new DetermineDirectoryContext()
            );
            if (result.Result)
                _settingsManager.DepotPath = result.DirectoryName;
        }

        private HandyControl.Data.OperationResult<bool> VerifyFolder(string str)
        {
            return System.IO.Directory.Exists(str)
                ? HandyControl.Data.OperationResult.Success()
                : HandyControl.Data.OperationResult.Failed();
        }

        private HandyControl.Data.OperationResult<bool> VerifyFile(string str)
        {
            return System.IO.File.Exists(str)
                ? HandyControl.Data.OperationResult.Success()
                : HandyControl.Data.OperationResult.Failed();
        }
    }
}
