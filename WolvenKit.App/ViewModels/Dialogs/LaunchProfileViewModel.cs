using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using WolvenKit.App.Models;

namespace WolvenKit.ViewModels.Dialogs
{
    public class LaunchProfileViewModel : ReactiveObject
    {
        [Reactive] public bool IsEditable { get; set; }
        [Reactive] public bool IsNotEditable { get; set; } = true;
        public string Name { get; set; }

        public LaunchProfile Profile { get; set; }

        public void SetEditable(bool v)
        {
            IsEditable = v;
            IsNotEditable = !v;
        }
    }
}
