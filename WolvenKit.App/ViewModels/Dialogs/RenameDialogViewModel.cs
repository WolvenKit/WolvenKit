using System.Reactive;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace WolvenKit.ViewModels.Dialogs
{
    public class RenameDialogViewModel : DialogViewModel
    {
        public RenameDialogViewModel()
        {
            CloseCommand = ReactiveCommand.Create(() => { });
            OkCommand = ReactiveCommand.Create(() =>
            {

            });
            CancelCommand = ReactiveCommand.Create(() =>
            {

            });

            Title = "";
        }
        [Reactive] public string Text { get; set; }

        public sealed override string Title { get; set; }

        public sealed override ReactiveCommand<Unit, Unit> CloseCommand { get; set; }
        public sealed override ReactiveCommand<Unit, Unit> CancelCommand { get; set; }
        public sealed override ReactiveCommand<Unit, Unit> OkCommand { get; set; }
    }
}
