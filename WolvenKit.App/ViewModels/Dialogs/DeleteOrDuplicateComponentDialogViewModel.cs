using System.Collections.Generic;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// Allows users to delete or rename components by name
/// </summary>
public partial class DeleteOrDuplicateComponentDialogViewModel() : ObservableObject
{
    [ObservableProperty] private Dictionary<string, string> _componentNames = [];

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

    /// <summary>
    /// remember values? (from dialog) 
    /// </summary>
    [ObservableProperty] private bool _isDeleting;

    public DeleteOrDuplicateComponentDialogViewModel(List<string> componentNames, bool isDeleting) : this()
    {
        foreach (var componentName in componentNames)
        {
            ComponentNames.Add(componentName, componentName);
        }

        OnPropertyChanged(nameof(ComponentNames));
        IsDeleting = isDeleting;
        OnPropertyChanged(nameof(IsDeleting));
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
        if (e.PropertyName is not nameof(ComponentName) || string.IsNullOrEmpty(ComponentName))
        {
            return;
        }

        NewComponentName = ComponentName;
        while (ComponentNames.ContainsKey(NewComponentName))
        {
            NewComponentName = $"{NewComponentName}_copy";
        } 
    }
}