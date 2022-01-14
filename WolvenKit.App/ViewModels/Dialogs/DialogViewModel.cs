using ReactiveUI;

namespace WolvenKit.ViewModels.Dialogs
{
    public abstract class DialogViewModel : ReactiveObject
    {
        public delegate void DialogHandlerDelegate(DialogViewModel sender);
        public DialogHandlerDelegate DialogHandler { get; set; }
    }
}
