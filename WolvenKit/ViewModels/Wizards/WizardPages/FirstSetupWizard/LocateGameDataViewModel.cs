using Catel;
using Catel.Data;
using Catel.Fody;
using Catel.IoC;
using Catel.MVVM;
using WolvenKit.Services;

namespace WolvenKit.ViewModels.Wizards.WizardPages.FirstSetupWizard
{
    class LocateGameDataViewModel : ViewModelBase
    {
        #region constructors
        public LocateGameDataViewModel(IServiceLocator serviceLocator)
        {
            Argument.IsNotNull(() => serviceLocator);

            SettingsManager = serviceLocator.ResolveType<ISettingsManager>();
        }
        #endregion

        #region properties
        /// <summary>
        /// Gets or sets the SettingsManager.
        /// </summary>
        [Model]
        [Expose("W3ExecutablePath")]
        [Expose("WccLitePath")]
        [Expose("DepotPath")]
        [Expose("CP77ExecutablePath")]
        public ISettingsManager SettingsManager
        {
            get { return GetValue<ISettingsManager>(SettingsManagerProperty); }
            set { SetValue(SettingsManagerProperty, value); }
        }


        /// <summary>
        /// Register the SettingsManager property so it is known in the class.
        /// </summary>
        public static readonly PropertyData SettingsManagerProperty = RegisterProperty("SettingsManager", typeof(ISettingsManager));
        #endregion properties
    }
}
