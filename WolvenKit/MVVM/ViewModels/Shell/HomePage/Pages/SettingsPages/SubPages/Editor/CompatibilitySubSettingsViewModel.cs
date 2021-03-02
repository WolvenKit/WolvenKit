using Catel;
using Catel.Data;
using Catel.Fody;
using Catel.IoC;
using Catel.MVVM;
using WolvenKit.Functionality.Services;

namespace WolvenKit.ViewModels.SettingsPages.SubPages.Editor
{
    class CompatibilitySubSettingsViewModel : ViewModelBase
    {
        #region constructors
        public CompatibilitySubSettingsViewModel(IServiceLocator serviceLocator)
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
        [Expose("CP77ExecutablePath")]
        [Expose("WccLitePath")]
        [Expose("DepotPath")]
        private ISettingsManager SettingsManager
        {
            get { return GetValue<ISettingsManager>(SettingsManagerProperty); }
            set { SetValue(SettingsManagerProperty, value); }
        }

        /// <summary>
        /// Register the SettingsManagerProperty property so it is known in the class.
        /// </summary>
        public static readonly PropertyData SettingsManagerProperty = RegisterProperty("SettingsManager", typeof(ISettingsManager));
        #endregion properties
    }
}
