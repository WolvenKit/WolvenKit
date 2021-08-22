using System.Diagnostics;
using System.Reactive;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using ReactiveUI;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.ViewModels.Wizards
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

        public sealed override string Title { get; set; }

        public sealed override ReactiveCommand<Unit, Unit> CloseCommand { get; set; }
        public sealed override ReactiveCommand<Unit, Unit> CancelCommand { get; set; }
        public sealed override ReactiveCommand<Unit, Unit> OkCommand { get; set; }
    }
}
