using Catel;
using Catel.Data;
using Catel.Fody;
using Catel.IoC;
using Catel.MVVM;
using WolvenKit.Functionality.Services;

namespace WolvenKit.MVVM.ViewModels.Shell.HomePage.Pages.SettingsPages.SubPages.Editor
{
    public class CompatibilitySubSettingsViewModel : ViewModelBase
    {
        #region constructors

        public CompatibilitySubSettingsViewModel(IServiceLocator serviceLocator)
        {
            Argument.IsNotNull(() => serviceLocator);

            SettingsManager = serviceLocator.ResolveType<ISettingsManager>();
        }

        #endregion constructors

        #region properties

        /// <summary>
        /// Register the SettingsManagerProperty property so it is known in the class.
        /// </summary>
        public static readonly PropertyData SettingsManagerProperty = RegisterProperty("SettingsManager", typeof(ISettingsManager));

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
            get => GetValue<ISettingsManager>(SettingsManagerProperty);
            set => SetValue(SettingsManagerProperty, value);
        }

        #endregion properties
    }
}
