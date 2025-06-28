using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class SelectDropdownEntryDialogViewModel : DialogViewModel
{
    [ObservableProperty] private string? _title;
    [ObservableProperty] private string? _text;
    [ObservableProperty] private bool _showText;
    [ObservableProperty] private List<string>? _options;
    [ObservableProperty] private string _selectedOption;

    public SelectDropdownEntryDialogViewModel(List<string> list, string title = "Pick one!", string text = "")
    {
        Options = list;
        SelectedOption = list.FirstOrDefault() ?? string.Empty;
        Title = title;
        Text = text;
        ShowText = !string.IsNullOrEmpty(text);
    }
}