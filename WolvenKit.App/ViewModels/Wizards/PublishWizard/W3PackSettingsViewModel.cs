using Catel.MVVM;

namespace WolvenKit.MVVM.ViewModels.Components.Wizards.WizardPages.PublishWizard
{
    public class W3PackSettingsViewModel : ViewModelBase
    {
        #region Properties

        public string[] PackerSource => new string[] { "DLC", "MOD" };

        #endregion Properties
    }
}
