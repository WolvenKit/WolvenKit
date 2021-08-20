using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace WolvenKit.ViewModels.Dialogs
{
    public class RenameDialogViewModel : ReactiveObject
    {
        public RenameDialogViewModel()
        {
            
        }
        [Reactive] public string Text { get; set; }


    }
}
