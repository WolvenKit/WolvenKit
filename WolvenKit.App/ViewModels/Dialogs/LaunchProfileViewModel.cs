using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using WolvenKit.App.Models;

namespace WolvenKit.ViewModels.Dialogs
{
    public class LaunchProfileViewModel
    {
        public string Name { get; set; }

        public LaunchProfile Profile { get; set; }
    }
}
