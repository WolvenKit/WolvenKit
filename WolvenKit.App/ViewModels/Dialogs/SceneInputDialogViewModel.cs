using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.Interaction.Options;

namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// ViewModel for unified scene input dialog that handles actors, props, dialogue lines, and choice options
/// </summary>
public partial class SceneInputDialogViewModel : DialogViewModel
{
    public SceneInputDialogViewModel(SceneInputDialogOptions dialogOptions)
    {
        Title = dialogOptions.Title;
        PrimaryLabel = dialogOptions.PrimaryLabel;
        PrimaryInputValue = dialogOptions.PrimaryDefault;
        ShowSecondaryInput = dialogOptions.ShowSecondary;
        SecondaryLabel = dialogOptions.SecondaryLabel;
        CheckboxText = dialogOptions.CheckboxText;
        ShowDropdown = dialogOptions.ShowDropdown;
        DropdownLabel = dialogOptions.DropdownLabel;

        if (dialogOptions.DropdownOptions != null)
        {
            DropdownOptions = dialogOptions.DropdownOptions.ToList();
            SelectedDropdownValue = dialogOptions.DefaultDropdownValue ?? DropdownOptions.FirstOrDefault();
        }
        else
        {
            DropdownOptions = new List<string>();
        }
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
    /// Whether to show the dropdown section
    /// </summary>
    [ObservableProperty] private bool _showDropdown;

    /// <summary>
    /// The selected dropdown value
    /// </summary>
    [ObservableProperty] private string? _selectedDropdownValue;

    /// <summary>
    /// The available dropdown options
    /// </summary>
    public List<string> DropdownOptions { get; set; } = new();

    /// <summary>
    /// The label text for the primary input field
    /// </summary>
    public string PrimaryLabel { get; set; }

    /// <summary>
    /// The label text for the secondary input field
    /// </summary>
    public string SecondaryLabel { get; set; }

    /// <summary>
    /// The label text for the dropdown field
    /// </summary>
    public string DropdownLabel { get; set; }

    /// <summary>
    /// The checkbox text
    /// </summary>
    public string CheckboxText { get; set; }

    /// <summary>
    /// The dialog title
    /// </summary>
    public string Title { get; set; }
}
