using Catel;
using Catel.Fody;
using Catel.MVVM;
using WolvenKit.Models.Wizards;

namespace WolvenKit.ViewModels.Wizards.FirstSetupWizard
{
    public class SetInitialPreferencesViewModel : ViewModelBase
    {
        #region constructors

        public SetInitialPreferencesViewModel(FirstSetupWizardModel firstSetupWizardModel)
        {
            Argument.IsNotNull(() => firstSetupWizardModel);

            FirstSetupWizardModel = firstSetupWizardModel;
        }

        #endregion constructors

        #region properties

        /// <summary>
        /// Gets or sets the FirstSetupWizardModel.
        /// </summary>
        [Model]
        [Expose("CreateModForW3")]
        [Expose("CreateModForCP77")]
        [Expose("AutoInstallMods")]
        [Expose("AutoUpdatesEnabled")]
        public FirstSetupWizardModel FirstSetupWizardModel { get; set; }

        #endregion properties
    }
}
