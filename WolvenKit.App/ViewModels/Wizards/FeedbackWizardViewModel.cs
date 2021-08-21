using System.Reactive;
using ReactiveUI;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.ViewModels.Wizards
{
    public class FeedbackWizardViewModel : DialogViewModel
    {
        public FeedbackWizardViewModel()
        {
            CloseCommand = ReactiveCommand.Create(() => { });
            OkCommand = ReactiveCommand.Create(() => { });
            CancelCommand = ReactiveCommand.Create(() => { });

            Title = "";
        }

        public sealed override string Title { get; set; }

        public sealed override ReactiveCommand<Unit, Unit> CloseCommand { get; set; }
        public sealed override ReactiveCommand<Unit, Unit> CancelCommand { get; set; }
        public sealed override ReactiveCommand<Unit, Unit> OkCommand { get; set; }
    }
}
