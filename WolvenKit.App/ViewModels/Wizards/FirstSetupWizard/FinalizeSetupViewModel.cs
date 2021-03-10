using Catel;
using Catel.Data;
using Catel.Fody;
using Catel.IoC;
using Catel.MVVM;
using WolvenKit.Functionality.Services;
using WolvenKit.MVVM.Model.Wizards;

namespace WolvenKit.ViewModels.Wizards.FirstSetupWizard
{
    public class FinalizeSetupViewModel : ViewModelBase
    {
        #region constructors

        public FinalizeSetupViewModel(IServiceLocator serviceLocator)
        {
            Argument.IsNotNull(() => serviceLocator);

            FirstSetupWizardModel = serviceLocator.ResolveType<FirstSetupWizardModel>();
            FirstSetupWizardViewModel = serviceLocator.ResolveType<FirstSetupWizardViewModel>();
            SettingsManager = serviceLocator.ResolveType<ISettingsManager>();
        }

        #endregion constructors

        #region properties

        /// <summary>
        /// Register the FirstSetupWizardViewModel property so it is known in the class.
        /// </summary>
        public static readonly PropertyData FirstSetupWizardViewModelProperty = RegisterProperty("FirstSetupWizardViewModel", typeof(FirstSetupWizardViewModel));

        /// <summary>
        /// Register the FirstSetupWizardModel property so it is known in the class.
        /// </summary>
        public static readonly PropertyData ProjectWizardModelProperty = RegisterProperty("FirstSetupWizardModel", typeof(FirstSetupWizardModel));

        /// <summary>
        /// Register the SettingsManager property so it is known in the class.
        /// </summary>
        public static readonly PropertyData SettingsManagerProperty = RegisterProperty("SettingsManager", typeof(ISettingsManager));

        /// <summary>
        /// Gets or sets the FirstSetupWizardModel.
        /// </summary>
        [Model]
        [Expose("Author")]
        [Expose("SelectedGames")]
        [Expose("AutoInstallMods")]
        [Expose("AutoUpdatesEnabled")]
        [Expose("CreateModForW3")]
        [Expose("CreateModForCP77")]
        public FirstSetupWizardModel FirstSetupWizardModel
        {
            get => GetValue<FirstSetupWizardModel>(ProjectWizardModelProperty);
            set => SetValue(ProjectWizardModelProperty, value);
        }

        /// <summary>
        /// Gets or sets the FirstSetupWizardViewModel.
        /// </summary>
        [Model]
        [Expose("W3ExePath")]
        [Expose("WccLitePath")]
        [Expose("CP77ExePath")]
        public FirstSetupWizardViewModel FirstSetupWizardViewModel
        {
            get => GetValue<FirstSetupWizardViewModel>(FirstSetupWizardViewModelProperty);
            set => SetValue(FirstSetupWizardViewModelProperty, value);
        }

        /// <summary>
        /// Gets or sets the SettingsManager.
        /// </summary>
        [Model]
        [Expose("DepotPath")]
        public ISettingsManager SettingsManager
        {
            get => GetValue<ISettingsManager>(SettingsManagerProperty);
            set => SetValue(SettingsManagerProperty, value);
        }

        #endregion properties
    }
}
