using System.Collections.Generic;

namespace WolvenKit.App.ViewModels.Dialogs;

// This file collects dialogue argument option classes for <see cref="Interaction"/>.
// It's much nicer than having a million tuples, and it allows more fine-grained and optional arguments.

/// <summary>
/// Input parameters for <see cref="ShowChecklistDialogViewModel"/>
/// </summary>
public class ChecklistDialogOptions
{
    public ChecklistDialogOptions(Dictionary<string, bool> options,
        string title,
        string text = "",
        string inputFieldLabel = "",
        string inputFieldDefaultValue = "",
        string filterDefaultValue = "")
    {
        ChecklistOptions = options;
        Title = title;
        Text = text;
        InputFieldLabel = inputFieldLabel;
        InputFieldDefaultValue = inputFieldDefaultValue;
        FilterDefaultValue = filterDefaultValue;
        ShowInputField = !string.IsNullOrEmpty(inputFieldLabel);
    }

    public Dictionary<string, bool> ChecklistOptions { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }

    public string FilterDefaultValue { get; set; }
    public string InputFieldLabel { get; set; }
    public string InputFieldDefaultValue { get; set; }

    public bool ShowInputField { get; set; } = false;
}

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

/// <summary>
/// Input parameters for <see cref="ShowDictionaryForCopyDialogViewModel"/>
/// </summary>
public class ShowDictAsCopyableListDialogOptions
{
    public ShowDictAsCopyableListDialogOptions(
        string title,
        string text,
        IDictionary<string, List<string>> dictionary,
        bool isExperimental = false)
    {
        Title = title;
        Text = text;
        ValueDictionary = dictionary;
        IsExperimental = isExperimental;
    }

    public string Title { get; set; }
    public string Text { get; set; }

    public IDictionary<string, List<string>> ValueDictionary { get; set; }
    public bool IsExperimental { get; set; }
}
