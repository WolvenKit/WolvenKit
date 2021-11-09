using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Windows.Media;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.HomePage;

namespace WolvenKit.ViewModels
{
    public class SettingsPageViewModel : PageViewModel
    {
        
        public SettingsPageViewModel(
            ISettingsManager settingsManager
        )
        {
            Settings = settingsManager;
        }


        public ISettingsManager Settings { get; set; }
    }
}
