using Catel;
using Catel.Fody;
using Catel.MVVM;
using WolvenKit.Functionality.Services;
using WolvenKit.Models.Wizards;

namespace WolvenKit.ViewModels.Wizards.FirstSetupWizard
{
    public class LocateGameDateViewModel : ViewModelBase
    {
        #region constructors

        public LocateGameDateViewModel(ISettingsManager settingsManager, FirstSetupWizardModel firstSetupWizardModel, FirstSetupWizardViewModel firstSetupWizardViewModel)
        {
            Argument.IsNotNull(() => settingsManager);
            Argument.IsNotNull(() => firstSetupWizardModel);
            Argument.IsNotNull(() => firstSetupWizardViewModel);

            SettingsManager = settingsManager;
            FirstSetupWizardModel = firstSetupWizardModel;
            FirstSetupWizardViewModel = firstSetupWizardViewModel;
        }

        #endregion constructors

        #region properties

        /// <summary>
        /// Gets or sets the FirstSetupWizardModel.
        /// </summary>
        [Model]
        [Expose("CreateModForW3")]
        [Expose("CreateModForCP77")]
        public FirstSetupWizardModel FirstSetupWizardModel { get; set; }

        /// <summary>
        /// Gets or sets the FirstSetupWizardViewModel.
        /// </summary>
        [Model]
        [Expose("W3ExePath")]
        [Expose("WccLitePath")]
        [Expose("CP77ExePath")]
        public FirstSetupWizardViewModel FirstSetupWizardViewModel { get; set; }

        /// <summary>
        /// Gets or sets the SettingsManager.
        /// </summary>
        [Model]
        [Expose("DepotPath")]
        public ISettingsManager SettingsManager { get; set; }

        #endregion properties
    }
}
