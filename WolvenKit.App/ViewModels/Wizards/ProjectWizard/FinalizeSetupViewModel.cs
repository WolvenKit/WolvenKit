using Catel;
using Catel.Data;
using Catel.Fody;
using Catel.IoC;
using Catel.MVVM;
using WolvenKit.Models.Wizards;

namespace WolvenKit.ViewModels.Wizards.ProjectWizard
{
    /// <summary>
    /// The FinalizeSetupViewModel implements the project's finalize setup wizard's window viewmodel.
    /// </summary>
    public class FinalizeSetupViewModel : ViewModelBase
    {
        #region constructors

        public FinalizeSetupViewModel(IServiceLocator serviceLocator)
        {
            Argument.IsNotNull(() => serviceLocator);

            ProjectWizardModel = serviceLocator.ResolveType<ProjectWizardModel>();
        }

        #endregion constructors

        #region properties

        /// <summary>
        /// Register the ProjectWizardModel property so it is known in the class.
        /// </summary>
        public static readonly PropertyData ProjectWizardModelProperty = RegisterProperty(nameof(ProjectWizardModel), typeof(ProjectWizardModel));

        /// <summary>
        /// Gets or sets the projectWizardModel.
        /// </summary>
        [Model]
        [Expose("ProjectName")]
        [Expose("ProjectPath")]
        [Expose("ProjectType")]
        [Expose("ProjectTypeAndPath")]
        public ProjectWizardModel ProjectWizardModel
        {
            get => GetValue<ProjectWizardModel>(ProjectWizardModelProperty);
            set => SetValue(ProjectWizardModelProperty, value);
        }

        #endregion properties
    }
}
