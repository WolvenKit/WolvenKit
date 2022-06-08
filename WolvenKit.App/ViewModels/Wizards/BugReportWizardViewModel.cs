using System.Reactive;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.App.ViewModels.Wizards
{
    public class BugReportWizardViewModel : DialogViewModel
    {
        public BugReportWizardViewModel()
        {
            CloseCommand = ReactiveCommand.Create(() => { });
            OkCommand = ReactiveCommand.Create(() => { });
            CancelCommand = ReactiveCommand.Create(() => { });

            Title = "Bug Report";
        }

        public string Title { get; set; }

        public ReactiveCommand<Unit, Unit> CloseCommand { get; set; }
        public ReactiveCommand<Unit, Unit> CancelCommand { get; set; }
        public ReactiveCommand<Unit, Unit> OkCommand { get; set; }
    }
}
