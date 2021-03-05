using Catel;
using Catel.Data;
using Catel.Fody;
using Catel.IoC;
using Catel.MVVM;
using WolvenKit.MVVM.Model.Wizards;

namespace WolvenKit.MVVM.ViewModels.Components.Wizards.WizardPages.ProjectWizard
{
    /// <summary>
    /// The ProjectConfigurationViewModel implements project wizard configuration window's viewmodel.
    /// </summary>
    internal class ProjectConfigurationViewModel : ViewModelBase
    {
        #region constructors

        public ProjectConfigurationViewModel(IServiceLocator serviceLocator)
        {
            Argument.IsNotNull(() => serviceLocator);

            ProjectWizardModel = serviceLocator.ResolveType<ProjectWizardModel>();
        }

        #endregion constructors

        #region properties

        /// <summary>
        /// Register the ProjectWizardModel property so it is known in the class.
        /// </summary>
        public static readonly PropertyData ProjectWizardModelProperty = RegisterProperty("ProjectWizardModel", typeof(ProjectWizardModel));

        /// <summary>
        /// Gets or sets the projectWizardModel.
        /// </summary>
        [Model]
        [Expose("ProjectName")]
        [Expose("ProjectPath")]
        public ProjectWizardModel ProjectWizardModel
        {
            get => GetValue<ProjectWizardModel>(ProjectWizardModelProperty);
            set => SetValue(ProjectWizardModelProperty, value);
        }

        #endregion properties
    }
}
