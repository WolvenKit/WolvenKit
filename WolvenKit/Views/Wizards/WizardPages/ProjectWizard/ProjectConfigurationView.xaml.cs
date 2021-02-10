
using Catel.IoC;
using Catel.Services;
using WolvenKit.ViewModels.Wizards.WizardPages.ProjectWizard;

namespace WolvenKit.Views.Wizards.WizardPages.ProjectWizard
{
    public partial class ProjectConfigurationView
    {
        private readonly ISelectDirectoryService _selectDirectoryService;

        public ProjectConfigurationView()
        {
            InitializeComponent();

            _selectDirectoryService = ServiceLocator.Default.ResolveType<ISelectDirectoryService>();
        }

        private async void ProjectPathBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var result = await _selectDirectoryService.DetermineDirectoryAsync(
                new DetermineDirectoryContext()
            );
            if (result.Result)
                (ViewModel as ProjectConfigurationViewModel).ProjectWizardModel.ProjectPath = result.DirectoryName;
        }

        private HandyControl.Data.OperationResult<bool> VerifyFolder(string str)
        {
            return System.IO.Directory.Exists(str)
                ? HandyControl.Data.OperationResult.Success()
                : HandyControl.Data.OperationResult.Failed("WolvenKit path does not exist");
        }
    }
}
