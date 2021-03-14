using Catel.MVVM;

namespace WolvenKit.ViewModels.Wizards.PublishWizard
{
    public class W3PackSettingsViewModel : ViewModelBase
    {
        #region Properties

        public string[] PackerSource => new string[] { "DLC", "MOD" };

        #endregion Properties
    }
}
