
using ReactiveUI;
using WolvenKit.Functionality.Services;
using WolvenKit.Common.Model;
using WolvenKit.Models.Wizards;
using WolvenKit.MVVM.Model.ProjectManagement.Project;

namespace WolvenKit.ViewModels.Wizards.PublishWizard
{
    public class RequiredSettingsViewModel : ReactiveObject
    {
        #region constructors

        public RequiredSettingsViewModel(
            IProjectManager projectManager)
        {

            if (projectManager.ActiveProject is EditorProject ep)
            {
                EditorProject = ep;
            }

            PublishWizardModel = serviceLocator.ResolveType<PublishWizardModel>();
        }

        #endregion constructors

        #region properties

        /// <summary>
        /// Gets or sets the EditorProject.
        /// </summary>
        public EditorProject EditorProject { get; set; }

        /// <summary>
        /// Gets or sets the PublishWizardModel.
        /// </summary>
        [Model]
        [Expose("Description")]
        public PublishWizardModel PublishWizardModel { get; set; }

        #endregion properties
    }
}
