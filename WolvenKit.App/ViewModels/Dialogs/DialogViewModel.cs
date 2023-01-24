using System.Reactive;
using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;

namespace WolvenKit.ViewModels.Dialogs
{
    public abstract class DialogViewModel : ObservableObject
    {
        public delegate void DialogHandlerDelegate(DialogViewModel? sender);
        public DialogHandlerDelegate? DialogHandler { get; set; }

        public abstract ReactiveCommand<Unit, Unit> OkCommand { get; }
        public abstract ReactiveCommand<Unit, Unit> CancelCommand { get; }
    }

    public abstract class DialogWindowViewModel : ObservableObject
    {

    }
}
