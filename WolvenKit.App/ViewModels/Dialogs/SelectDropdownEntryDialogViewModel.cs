using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class SelectDropdownEntryDialogViewModel : DialogViewModel
{
    [ObservableProperty] private string? _title;
    [ObservableProperty] private string? _text;
    [ObservableProperty] private bool _showText;
    [ObservableProperty] private bool _showInputBar;
    [ObservableProperty] private List<string>? _options;
    [ObservableProperty] private Dictionary<string, string>? _optionsDict;
    [ObservableProperty] private string _selectedOption;

    /// <summary>
    /// Set via <see cref="SetHelpLink(string)"/> to set the help link.
    /// </summary>
    [ObservableProperty] private bool _showHelpButton = false;

    public string HelpLink { get; private set; } = string.Empty;

    public SelectDropdownEntryDialogViewModel(List<string> list, string title = "Pick one!", string text = "",
        bool showInputBar = false)
    {
        Options = list;
        ShowInputBar = showInputBar;
        if (showInputBar)
        {
            SelectedOption = string.Empty;
        }
        else
        {
            SelectedOption = list.FirstOrDefault() ?? string.Empty;
        }
        
        Title = title;
        Text = text;
        ShowText = !string.IsNullOrEmpty(text);

        OptionsDict = list.ToDictionary(a => a, a => a);
    }

    public void SetHelpLink(string helpLink)
    {
        HelpLink = helpLink;
        ShowHelpButton = !string.IsNullOrEmpty(helpLink);
    } 
}