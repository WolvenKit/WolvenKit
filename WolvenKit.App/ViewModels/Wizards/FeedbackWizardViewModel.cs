using System.Reactive;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.App.ViewModels.Wizards
{
    public class FeedbackWizardViewModel : DialogViewModel
    {
        public FeedbackWizardViewModel()
        {
            CloseCommand = ReactiveCommand.Create(() => { });
            OkCommand = ReactiveCommand.Create(() => { });
            CancelCommand = ReactiveCommand.Create(() => { });

            Title = "Feedback";
        }

        public string Title { get; set; }

        public ReactiveCommand<Unit, Unit> CloseCommand { get; set; }
        public ReactiveCommand<Unit, Unit> CancelCommand { get; set; }
        public ReactiveCommand<Unit, Unit> OkCommand { get; set; }
    }
}
