using System;
using ReactiveUI;
using WolvenKit.App.Models;

namespace WolvenKit.ViewModels.Dialogs
{
    public record LaunchProfileViewModel(string Name, LaunchProfile Profile);
}
