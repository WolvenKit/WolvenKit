using System.Reactive;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace WolvenKit.App.ViewModels.Dialogs
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

            Title = "Rename";
        }
        [Reactive] public string Text { get; set; }

        public string Title { get; set; }

        public ReactiveCommand<Unit, Unit> CloseCommand { get; set; }
        public ReactiveCommand<Unit, Unit> CancelCommand { get; set; }
        public ReactiveCommand<Unit, Unit> OkCommand { get; set; }
    }
}
