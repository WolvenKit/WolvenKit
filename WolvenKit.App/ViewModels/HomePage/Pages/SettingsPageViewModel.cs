using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Windows.Media;
using Catel.MVVM;
using WolvenKit.Functionality.Services;

namespace WolvenKit.ViewModels.HomePage.Pages
{
    public class SettingsPageViewModel : ViewModelBase
    {
        ISettingsManager _settingsManager;

        public SettingsPageViewModel(
            ISettingsManager settingsManager
        )
        {
            _settingsManager = settingsManager;
        }

        public GeneralSettingsPGModel generalSettingsPGModel
        {
            get { return new GeneralSettingsPGModel(_settingsManager); }
            set { }
        }
        public CP77SettingsPGModel cp77SettingsPGModel
        {
            get { return new CP77SettingsPGModel(_settingsManager); }
            set { }
        }
        public TW3SettingsPGModel tw3SettingsPGModel
        {
            get { return new TW3SettingsPGModel(_settingsManager); }
            set { }
        }






    }

    public class CP77SettingsPGModel
    {
        ISettingsManager _settingsManager;

        public CP77SettingsPGModel(ISettingsManager settingsManager)
        {
            _settingsManager = settingsManager;
        }

        [Category("General")]
        public string Game_Executable_Path
        {
            get => _settingsManager.CP77ExecutablePath;
            set
            {
                _settingsManager.CP77ExecutablePath = value;
                _settingsManager.Save();
            }
        }
    }

    public class TW3SettingsPGModel
    {
        ISettingsManager _settingsManager;

        public TW3SettingsPGModel(ISettingsManager settingsManager)
        {
            _settingsManager = settingsManager;
        }

        [Category("General")]
        public string Game_Executable_Path
        {
            get => _settingsManager.W3ExecutablePath;
            set
            {
                _settingsManager.W3ExecutablePath = value;
                _settingsManager.Save();
            }
        }
        public string Modkit_Path { get; set; }
        public string Uncooked_Depot_Path { get; set; }

    }


    public class GeneralSettingsPGModel
    {
        ISettingsManager _settingsManager;

        public GeneralSettingsPGModel(ISettingsManager settingsManager)
        {
            _settingsManager = settingsManager;
        }

        [Category("General")]
        public ApplicationLanguage Language { get; set; }
        //public bool Desktop_Notifications { get; set; }  // Doesn't work yet I think?
        [Category("Updates")]
        [Display(Name = "Receive Auto updates?")]
        public bool ReceiveAutoUpdates { get; set; }
        [Category("Updates")]
        [Display(Name = "Set auto update channel.")]
        public AutoUpdateChannel UpdateChannel { get; set; }
        [Category("Mods")]
        [Display(Name = "Automatically install mods.")]
        public bool AutoInstallMods { get; set; }
        [Category("Mods")]
        [Display(Name = "Material depot path.")]
        public string MaterialDepotPath { get; set; }


        [Editable(false)]
        [Category("Theme")]
        [Display(Name = "Application theme accent.")]
        public Brush BrushProperty { get; set; }
    }
    public enum AutoUpdateChannel
    {
        Global,
    }
    public enum ApplicationLanguage
    {
        English,
    }
}
