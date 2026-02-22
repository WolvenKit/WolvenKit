using System.Collections.Generic;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.App.Interaction.Options;

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
