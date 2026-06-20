using System.Collections.Generic;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.App.Interaction.Options;

/// <summary>
/// Input parameters for <see cref="SceneInputDialogViewModel"/>
/// </summary>
public class SceneInputDialogOptions
{
    public SceneInputDialogOptions(
        string title, string primaryLabel,
        string primaryDefault = "",
        bool showSecondary = false,
        string secondaryLabel = "",
        string checkboxText = "",
        bool showDropdown = false,
        string dropdownLabel = "",
        IEnumerable<string>? dropdownOptions = null,
        string? defaultDropdownValue = null
    )
    {
        Title = title;
        PrimaryLabel = primaryLabel;
        PrimaryDefault = primaryDefault;
        ShowSecondary = showSecondary;
        SecondaryLabel = secondaryLabel;
        CheckboxText = checkboxText;
        ShowDropdown = showDropdown;
        DropdownLabel = dropdownLabel;
        DropdownOptions = dropdownOptions;
        DefaultDropdownValue = defaultDropdownValue;
    }

    public string Title { get; init; }
    public string PrimaryLabel { get; init; }
    public string PrimaryDefault { get; init; }
    public bool ShowSecondary { get; init; } = false;
    public string SecondaryLabel { get; init; }
    public string CheckboxText { get; init; }
    public bool ShowDropdown { get; init; } = false;
    public string DropdownLabel { get; init; }
    public IEnumerable<string>? DropdownOptions { get; init; } = null;
    public string? DefaultDropdownValue { get; init; } = null;
}
