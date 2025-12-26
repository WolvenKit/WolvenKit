using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using DynamicData;


namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// A simple "search and replace" dialog. Needs to register in GenericHost via AddTransient.
/// </summary>
public partial class SearchAndReplaceDialogViewModel() : ObservableObject
{

    /// <summary>
    /// Search text
    /// </summary>
    [ObservableProperty] private string? _searchText = "";

    /// <summary>
    /// Replace text
    /// </summary>
    [ObservableProperty] private string? _replaceText = "";

    /// <summary>
    ///Ignore case
    /// </summary>
    [ObservableProperty] private bool _rememberValues;

    /// <summary>
    /// Whole word only?
    /// </summary>
    [ObservableProperty] private bool _isWholeWord;

    /// <summary>
    /// Regular expression?
    /// </summary>
    [ObservableProperty] private bool _isRegex;

    /// <summary>
    /// Dialogue title/message
    /// </summary>
    [ObservableProperty] private string _message = "";

    /// <summary>
    /// Dialogue message
    /// </summary>
    [ObservableProperty] private bool _showMessage;

    /// <summary>
    /// multiple entries?
    /// </summary>
    [ObservableProperty] private bool _hasMultipleEntries;

    /// <summary>
    /// multiple entries?
    /// </summary>
    [ObservableProperty] private bool _showSearchDropdown;

    /// <summary>
    /// multiple entries?
    /// </summary>
    [ObservableProperty] private Dictionary<string, string> _dropdownOptions = [];

    public SearchAndReplaceDialogViewModel(string message, bool replaceMultiples, List<string> existingOptions) : this()
    {
        Message = message;
        ShowMessage = !string.IsNullOrEmpty(Message);

        existingOptions = existingOptions.Distinct().Where(s => !string.IsNullOrEmpty(s)).ToList();
        HasMultipleEntries = replaceMultiples;

        if (existingOptions.Count > 1)
        {
            ShowSearchDropdown = true;
            DropdownOptions = existingOptions.ToDictionary(x => x, x => x);
        }
        else if (existingOptions.Count == 1)
        {
            SearchText = existingOptions.First();
        }
    }

    public void SwapFields() => (SearchText, ReplaceText) = (ReplaceText, SearchText);
}
