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
}