using CommunityToolkit.Mvvm.ComponentModel;


namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// A simple "search and replace" dialog. Needs to register in GenericHost via AddTransient.
/// </summary>
public partial class SearchAndReplaceDialogViewModel : ObservableObject
{
    public SearchAndReplaceDialogViewModel(bool isSearchOnly = false)
    {
        IsSearchOnly = isSearchOnly;
        if (isSearchOnly)
        {
            Title = "Search";
        }
    }

    /// <summary>
    /// Search text
    /// </summary>
    [ObservableProperty] private string? _searchText = "";

    /// <summary>
    /// Dialogue title
    /// </summary>
    [ObservableProperty] private string? _title = "Replace in Selection";

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
    /// Search dialogue only? (Hide "replace" box)
    /// </summary>
    [ObservableProperty] private bool _isSearchOnly;



    public void SwapFields() => (SearchText, ReplaceText) = (ReplaceText, SearchText);
}
