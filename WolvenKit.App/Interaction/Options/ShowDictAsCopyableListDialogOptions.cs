using System.Collections.Generic;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.App.Interaction.Options;

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
