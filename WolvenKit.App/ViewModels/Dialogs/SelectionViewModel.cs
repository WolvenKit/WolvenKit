using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Options;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class SelectionViewModel : DialogViewModel
{
    [ObservableProperty] private string? _text;
    [ObservableProperty] private string _title;

    [ObservableProperty] private IList<string> _options;
    [ObservableProperty] private IList<string> _selectedOptions;
    [ObservableProperty] private string? _selectedOption;

    [ObservableProperty] private bool _allowMultiSelect = false;

    [ObservableProperty] private bool _showText;

    public SelectionViewModel(IList<string> options, string? title, string? text)
    {
        Text = text;
        Title = string.IsNullOrEmpty(title) ? "Select an item" : title;
        Options = options;

        SelectedOptions = [];
        ShowText = !string.IsNullOrEmpty(text);
    }
}