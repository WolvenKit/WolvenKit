using Catel;
using Catel.Data;
using Catel.Fody;
using Catel.IoC;
using Catel.MVVM;
using Orc.ProjectManagement;
using WolvenKit.Common.Model;
using WolvenKit.Models.Wizards;
using WolvenKit.MVVM.Model.ProjectManagement.Project;

namespace WolvenKit.ViewModels.Wizards.PublishWizard
{
    public class RequiredSettingsViewModel : ViewModelBase
    {
        #region constructors

        public RequiredSettingsViewModel(
            IServiceLocator serviceLocator,
            IProjectManager projectManager)
        {
            Argument.IsNotNull(() => serviceLocator);
            Argument.IsNotNull(() => projectManager);

            if (projectManager.ActiveProject is EditorProject ep)
            {
                EditorProject = ep;
                EditorProjectData = ep.Data;
            }

            PublishWizardModel = serviceLocator.ResolveType<PublishWizardModel>();
        }

        #endregion constructors

        #region properties

        /// <summary>
        /// Gets or sets the EditorProjectData.
        /// </summary>
        [Model]
        [Expose("Name")]
        [Expose("Version")]
        [Expose("Author")]
        public EditorProjectData EditorProjectData { get; set; }

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
