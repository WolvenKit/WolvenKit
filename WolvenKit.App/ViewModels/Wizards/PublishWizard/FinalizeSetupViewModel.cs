using System.Threading.Tasks;

using Catel.Fody;



using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Common.Model;
using WolvenKit.Models.Wizards;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.ViewModels.Others;

namespace WolvenKit.ViewModels.Wizards.PublishWizard
{
    public class FinalizeSetupViewModel : ViewModelBase
    {
        #region fields

        private readonly IOpenFileService _openFileService;
        private readonly IGameControllerFactory _gameControllerFactory;
        private readonly IProjectManager _projectManager;


        #endregion fields

        #region constructors

        public FinalizeSetupViewModel(
            IServiceLocator serviceLocator,
            IProjectManager projectManager,
            IOpenFileService openFileService,
            IGameControllerFactory gameControllerFactory
        )
        {
            Argument.IsNotNull(() => serviceLocator);
            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => openFileService);

            _projectManager = projectManager;
            _gameControllerFactory = gameControllerFactory;
            _openFileService = openFileService;

            PublishWizardModel = serviceLocator.ResolveType<PublishWizardModel>();

            PublishProject = new TaskCommand(PublishProjectExecuteAsync);
            Cancel = new TaskCommand(CancelExecuteAsync);
        }

        #endregion constructors

        #region properties

        /// <summary>
        /// Gets or sets the PublishWizardModel.
        /// </summary>
        [Model]
        [Expose("YoutubeLink")]
        [Expose("TwitchLink")]
        [Expose("TwitterLink")]
        [Expose("FacebookLink")]
        [Expose("DiscordLink")]
        [Expose("WebsiteLink")]
        [Expose("DonateLink")]
        [Expose("License")]
        [Expose("Description")]
        [Expose("LargeDescription")]
        [Expose("HeaderBackground")]
        [Expose("IconBackground")]
        [Expose("UseBlackText")]
        public PublishWizardModel PublishWizardModel { get; set; }

        #endregion properties

        #region commands

        public TaskCommand PublishProject { get; }

        public TaskCommand Cancel { get; }

        private async Task PublishProjectExecuteAsync()
        {
            var dofc = new DetermineOpenFileContext()
            {
                Filter = "WolvenKit Package | *.wkp | Zip file | *.zip",
                IsMultiSelect = false,
                Title = "Please select where to save the WolvenKit package."
            };
            var result = await _openFileService.DetermineFileAsync(dofc);
            if (result.Result)
            {
                //result.DirectoryName;
                await _gameControllerFactory.GetController().PackAndInstallProject();
                await _gameControllerFactory.GetController().PackageMod();
                var host = ServiceLocator.Default.ResolveType<UserControlHostWindowViewModel>();
                host?.CloseViewModelAsync(true);
            }
        }

        private Task CancelExecuteAsync()
        {
            var host = ServiceLocator.Default.ResolveType<UserControlHostWindowViewModel>();
            host?.CloseViewModelAsync(true);
            return Task.CompletedTask;
        }

        #endregion commands
    }
}
