using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class SelectDropdownEntryDialogViewModel : DialogViewModel
{
    public const string ButtonClickResult = "FROM_BUTTON_CLICK"; 
    
    [ObservableProperty] private string? _title;
    [ObservableProperty] private string? _text;
    [ObservableProperty] private bool _showText;
    [ObservableProperty] private bool _showInputBar;
    [ObservableProperty] private List<string>? _options;
    [ObservableProperty] private Dictionary<string, string>? _optionsDict;
    [ObservableProperty] private string _selectedOption;

    /// <summary>
    /// Set <see cref="HelpLink"/> to not null or empty to show the help button
    /// </summary>
    [ObservableProperty] private bool _showHelpButton = false;

    private string _helpLink = string.Empty;

    public string HelpLink
    {
        get => _helpLink;
        set
        {
            _helpLink = value;
            ShowHelpButton = !string.IsNullOrEmpty(_helpLink);
        }
    }

    /// <summary>
    /// Set <see cref="ButtonText"/> to not null or empty to show the help button
    /// </summary>
    [ObservableProperty] private bool _showButton = false;

    private string _buttonText = string.Empty;

    public string ButtonText
    {
        get => _buttonText;
        set
        {
            _buttonText = value;
            ShowButton = !string.IsNullOrEmpty(_buttonText);
        }
    }

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