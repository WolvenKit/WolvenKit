using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.RED4.Types;


namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// Allows users to delete or rename components by name
/// </summary>
public partial class DeleteOrDuplicateComponentDialogViewModel() : ObservableObject
{
    [ObservableProperty] private List<string> _componentNames = [];

    /// <summary>
    /// Name of the component 
    /// </summary>
    [ObservableProperty] private string? _componentName = "";

    /// <summary>
    /// Name of the component 
    /// </summary>
    [ObservableProperty] private string? _newComponentName = "";

    /// <summary>
    /// remember values? (from dialog) 
    /// </summary>
    [ObservableProperty] private bool _rememberValues;
}