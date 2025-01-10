using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;
using WolvenKit.RED4.Types;


namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// Asks user for a component name and a chunk mask
/// </summary>
public partial class ChangeComponentPropertiesDialogViewModel : ObservableObject
{
    public ChangeComponentPropertiesDialogViewModel(List<string> componentNames)
    {
        ComponentNames.Add("All", "*");
        componentNames.Where(s => !DocumentTools.PlaceholderRegex.IsMatch(s)).ToList()
            .ForEach(c => ComponentNames.Add(c, c));
        OnPropertyChanged(nameof(ComponentNames));
    }

    /// <summary>
    /// Name of the component 
    /// </summary>
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
    /// Name of the component 
    /// </summary>
    [ObservableProperty] private string? _depotPath = "";

    /// <summary>
    /// Name of the component 
    /// </summary>
    [ObservableProperty] private string? _meshAppearance = "";

    /// <summary>
    /// The chunk mask
    /// </summary>
    [ObservableProperty] private IRedPrimitive<ulong>? _chunkMask;

    /// <summary>
    /// Remember the last selection
    /// </summary>
    [ObservableProperty] private bool _rememberValues = false;
}