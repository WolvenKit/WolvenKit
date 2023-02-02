using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Dialogs;

public abstract class DialogViewModel : ObservableObject
{
    public delegate void DialogHandlerDelegate(DialogViewModel? sender);
    public DialogHandlerDelegate? DialogHandler { get; set; }

    //public abstract ICommand OkCommand { get; }
    //public abstract ICommand CancelCommand { get; }
}

public abstract class DialogWindowViewModel : ObservableObject
{

}
