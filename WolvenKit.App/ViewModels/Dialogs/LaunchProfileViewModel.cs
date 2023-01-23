using System;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.App.Models;

namespace WolvenKit.ViewModels.Dialogs
{
    public record LaunchProfileViewModel(string Name, LaunchProfile Profile);
}
