using Catel;
using Catel.Fody;
using Catel.IoC;
using Catel.MVVM;
using Orc.ProjectManagement;
using WolvenKit.Common.Model;
using WolvenKit.Models.Wizards;
using WolvenKit.MVVM.Model.ProjectManagement.Project;

namespace WolvenKit.ViewModels.Wizards.PublishWizard
{
    public class FinalizeSetupViewModel : ViewModelBase
    {
        #region constructors

        public FinalizeSetupViewModel(
            IServiceLocator serviceLocator,
            IProjectManager projectManager)
        {
            Argument.IsNotNull(() => serviceLocator);
            Argument.IsNotNull(() => projectManager);

            if (projectManager.ActiveProject is EditorProject ep)
            {
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
    }
}
