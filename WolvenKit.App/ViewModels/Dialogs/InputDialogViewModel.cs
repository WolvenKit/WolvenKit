using CommunityToolkit.Mvvm.ComponentModel;


namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// Implements the viewmodel that drives the log view.
/// </summary>
public partial class InputDialogViewModel(string title = "") : DialogViewModel
{
    /// <summary>
    /// The application log.
    /// Bound to the logview, implements OnPropertyRaised
    /// </summary>
    [ObservableProperty] private string? _text;

    public string Title { get; set; } = title;
}
