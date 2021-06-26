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

        public LocateGameDateViewModel(FirstSetupWizardModel firstSetupWizardModel, FirstSetupWizardViewModel firstSetupWizardViewModel)
        {
            Argument.IsNotNull(() => firstSetupWizardModel);
            Argument.IsNotNull(() => firstSetupWizardViewModel);

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

        #endregion properties
    }
}
