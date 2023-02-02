using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class RenameDialogViewModel : DialogWindowViewModel
{
    public RenameDialogViewModel() => Title = "Rename";
    [ObservableProperty] private string? _text;

    public string Title { get; set; }
}
