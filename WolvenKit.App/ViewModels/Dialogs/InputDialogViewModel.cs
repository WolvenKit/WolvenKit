using CommunityToolkit.Mvvm.ComponentModel;


namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// Implements the viewmodel that drives the log view.
/// </summary>
public partial class InputDialogViewModel : DialogViewModel
{
    public InputDialogViewModel(string title = "", string text = "")
    {
        Title = title;
        Text = text;
    }

    /// <summary>
    /// The application log.
    /// Bound to the logview, implements OnPropertyRaised
    /// </summary>
    [ObservableProperty] private string? _text;

    public string Title { get; set; }
}
