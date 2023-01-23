using System.Reactive;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.App.ViewModels.Dialogs
{
    public class RenameDialogViewModel : DialogWindowViewModel
    {
        public RenameDialogViewModel() => Title = "Rename";
        [Reactive] public string? Text { get; set; }

        public string Title { get; set; }
    }
}
