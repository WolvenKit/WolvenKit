using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class RenameDialogViewModel : DialogViewModel
{
    [ObservableProperty] private string? _text;
    [ObservableProperty] private bool? _enableRefactoring;

    public string Title { get; set; } = "Rename";
}
