using System.Reactive;
using System.Windows.Input;
using Newtonsoft.Json;
using ReactiveUI;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;

namespace WolvenKit.ViewModels.Dialogs
{
    public abstract class DialogViewModel : ReactiveObject
    {
        public delegate void DialogHandlerDelegate(DialogViewModel? sender);
        public DialogHandlerDelegate? DialogHandler { get; set; }

        public abstract ReactiveCommand<Unit, Unit> OkCommand { get; }
        public abstract ReactiveCommand<Unit, Unit> CancelCommand { get; }
    }

    public abstract class DialogWindowViewModel : ReactiveObject
    {

    }
}
