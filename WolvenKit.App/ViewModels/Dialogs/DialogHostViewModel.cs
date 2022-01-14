using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace WolvenKit.ViewModels.Dialogs
{
    public class DialogHostViewModel : ReactiveObject
    {
        [Reactive] public DialogViewModel HostedViewModel { get; set; }
    }
}
