using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace WolvenKit.App.ViewModels.Dialogs
{
    public class DialogHostViewModel : ReactiveObject
    {
        [Reactive] public DialogViewModel HostedViewModel { get; set; }
    }
}
