using Catel;
using Catel.Data;
using Catel.Fody;
using Catel.IoC;
using Catel.MVVM;
using WolvenKit.Model.Wizards;

namespace WolvenKit.ViewModels.Wizards.WizardPages.ProjectWizard
{
    /// <summary>
    /// The SelectProjectTypeViewModel implements project selection wizard's window viewmodel.
    /// </summary>
    class SelectProjectTypeViewModel : ViewModelBase
    {
        #region constructors
        public SelectProjectTypeViewModel(IServiceLocator serviceLocator)
        {
            Argument.IsNotNull(() => serviceLocator);

            ProjectWizardModel = serviceLocator.ResolveType<ProjectWizardModel>();
        }
        #endregion

        #region properties
        /// <summary>
        /// Gets or sets the projectWizardModel.
        /// </summary>
        [Model]
        [Expose("WitcherChecked")]
        [Expose("CyberpunkChecked")]
        [Expose("WitcherGameName")]
        [Expose("CyberpunkGameName")]
        public ProjectWizardModel ProjectWizardModel
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
