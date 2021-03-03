using Catel.MVVM;

namespace WolvenKit.MVVM.ViewModels.Components.Wizards.WizardPages.PublishWizard
{
    class W3PackSettingsViewModel : ViewModelBase
    {

        public string[] PackerSource
        {
            get
            {
                return new string[] { "DLC", "MOD" };
            }
        }
          
    }
}
