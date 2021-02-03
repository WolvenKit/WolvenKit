
using Catel.IoC;
using Catel.Services;
using WolvenKit.Model.Wizards;

namespace WolvenKit.Views.Wizards.WizardPages.ProjectWizard
{
    public partial class ProjectConfigurationView
    {
        private readonly IOpenFileService _openFileService;
        private readonly ProjectWizardModel _pwm;

        public ProjectConfigurationView()
        {
            InitializeComponent();

            _openFileService = ServiceLocator.Default.ResolveType<IOpenFileService>();
            _pwm = ServiceLocator.Default.ResolveType<ProjectWizardModel>();
        }

        private async void ProjectPathBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var result = await _openFileService.DetermineFileAsync(new DetermineOpenFileContext() {
                Filter = "Exe files|*.exe"
            });
            if (result.Result)
                _pwm.ProjectPath = result.FileName;
        }
    }
}
