using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using WolvenKit.App.Models;

namespace WolvenKit.ViewModels.Dialogs
{
    public record LaunchProfileViewModel(string Name, LaunchProfile Profile);
}
