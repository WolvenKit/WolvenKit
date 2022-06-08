using ReactiveUI;

namespace WolvenKit.App.ViewModels.Dialogs
{
    public abstract class DialogViewModel : ReactiveObject
    {
        public delegate void DialogHandlerDelegate(DialogViewModel sender);
        public DialogHandlerDelegate DialogHandler { get; set; }
    }
}
