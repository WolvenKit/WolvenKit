using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// ViewModel for unified scene input dialog that handles actors, props, dialogue lines, and choice options
/// </summary>
public partial class SceneInputDialogViewModel : DialogViewModel
{
    public SceneInputDialogViewModel(
        string title = "Scene Input", 
        string primaryLabel = "Value:", 
        string primaryDefaultValue = "",
        bool showSecondaryInput = false,
        string secondaryLabel = "Secondary:",
        string checkboxText = "Enable secondary input")
    {
        Title = title;
        PrimaryLabel = primaryLabel;
        PrimaryInputValue = primaryDefaultValue;
        ShowSecondaryInput = showSecondaryInput;
        SecondaryLabel = secondaryLabel;
        CheckboxText = checkboxText;
    }

    /// <summary>
    /// The primary input value (always visible)
    /// </summary>
    [ObservableProperty] private string? _primaryInputValue = "";

    /// <summary>
    /// Whether to show the secondary input section
    /// </summary>
    [ObservableProperty] private bool _showSecondaryInput;

    /// <summary>
    /// Whether the secondary input checkbox is checked
    /// </summary>
    [ObservableProperty] private bool _enableSecondaryInput;

    /// <summary>
    /// The secondary input value (conditionally visible)
    /// </summary>
    [ObservableProperty] private string? _secondaryInputValue = "";

    /// <summary>
    /// The label text for the primary input field
    /// </summary>
    public string PrimaryLabel { get; set; }

    /// <summary>
    /// The label text for the secondary input field
    /// </summary>
    public string SecondaryLabel { get; set; }

    /// <summary>
    /// The checkbox text
    /// </summary>
    public string CheckboxText { get; set; }

    /// <summary>
    /// The dialog title
    /// </summary>
    public string Title { get; set; }
}
