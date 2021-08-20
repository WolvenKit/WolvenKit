using System;
using System.Threading.Tasks;
using ReactiveUI;
using WolvenKit.Functionality.Services;
using WolvenKit.Common.Model;
using WolvenKit.MVVM.Model.ProjectManagement.Project;

namespace WolvenKit.ViewModels.Wizards.PublishWizard
{
    public class W3PackSettingsViewModel : ReactiveObject
    {
        public W3PackSettingsViewModel(
            IProjectManager projectManager)
        {

            if (projectManager?.ActiveProject is Tw3Project tw3p)
            {
                WitcherPackSettings = tw3p.PackSettings;
            }

            AllModChanged = new TaskCommand<bool>(AllModChangedExecutedAsync);
            AllDlcChanged = new TaskCommand<bool>(AllDlcChangedExecutedAsync);
        }

        #region Properties

        public string[] PackerSource => new string[] { "DLC", "MOD" };

        /// <summary>
        /// Gets or sets the WitcherPackSettings.
        /// </summary>
        [Model]
        [Expose("dlcGenCollCache")]
        [Expose("dlcGenMetadata")]
        [Expose("dlcGenTexCache")]
        [Expose("dlcInstallProject")]
        [Expose("dlcPackBundles")]
        [Expose("dlcScripts")]
        [Expose("dlcSound")]
        [Expose("dlcStrings")]
        [Expose("dlcShaderCache")]
        [Expose("dlcDeprecationCache")]
        [Expose("dlcSpeech")]
        [Expose("modGenCollCache")]
        [Expose("modGenMetadata")]
        [Expose("modGenTexCache")]
        [Expose("modInstallProject")]
        [Expose("modPackBundles")]
        [Expose("modScripts")]
        [Expose("modSound")]
        [Expose("modStrings")]
        [Expose("modShaderCache")]
        [Expose("modDeprecationCache")]
        [Expose("modSpeech")]
        public WitcherPackSettings WitcherPackSettings { get; set; }

        #endregion Properties

        #region Commands

        public TaskCommand<bool> AllModChanged { get; }

        public TaskCommand<bool> AllDlcChanged { get; }

        private Task AllModChangedExecutedAsync(bool value)
        {
            foreach (var property in WitcherPackSettings.GetType().GetProperties())
            {
                if (property.Name.StartsWith("mod", StringComparison.InvariantCultureIgnoreCase))
                {
                    property.SetValue(WitcherPackSettings, value);
                }
            }
            RaisePropertyChanged(nameof(WitcherPackSettings));
            return Task.CompletedTask;
        }

        private Task AllDlcChangedExecutedAsync(bool value)
        {
            foreach (var property in WitcherPackSettings.GetType().GetProperties())
            {
                if (property.Name.StartsWith("dlc", StringComparison.InvariantCultureIgnoreCase))
                {
                    property.SetValue(WitcherPackSettings, value);
                }
            }
            RaisePropertyChanged(nameof(WitcherPackSettings));
            return Task.CompletedTask;
        }

        #endregion Commands
    }
}
