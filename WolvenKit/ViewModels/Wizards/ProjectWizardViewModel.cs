using Catel.Data;
using Catel.Fody;
using Catel.IoC;
using Catel.MVVM;
using WolvenKit.Model.Wizards;

namespace WolvenKit.ViewModels.Wizards
{
    class ProjectWizardViewModel : ViewModelBase
    {
        #region constructors
        public ProjectWizardViewModel()
        {
            ProjectWizardModel = ServiceLocator.Default.ResolveType<ProjectWizardModel>();
        }
        #endregion

        #region properties
        /// <summary>
        /// Gets or sets the projectWizardModel.
        /// </summary>
        [Model]
        [Expose("ProjectName")]
        [Expose("ProjectPath")]
        private ProjectWizardModel ProjectWizardModel
        {
            get { return GetValue<ProjectWizardModel>(ProjectWizardModelProperty); }
            set { SetValue(ProjectWizardModelProperty, value); }
        }


        /// <summary>
        /// Register the ProjectWizardModel property so it is known in the class.
        /// </summary>
        public static readonly PropertyData ProjectWizardModelProperty = RegisterProperty("ProjectWizardModel", typeof(ProjectWizardModel));
        #endregion properties
    }
}
