using CommunityToolkit.Mvvm.ComponentModel;


namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// A simple "search and replace" dialog.
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
    [ObservableProperty] private bool _ignoreCase = false;
}