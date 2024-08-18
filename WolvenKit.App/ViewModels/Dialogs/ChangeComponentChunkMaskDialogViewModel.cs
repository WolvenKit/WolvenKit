using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.RED4.Types;


namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// Asks user for a component name and a chunk mask
/// </summary>
public partial class ChangeComponentChunkMaskDialogViewModel() : ObservableObject
{
    /// <summary>
    /// Name of the component 
    /// </summary>
    [ObservableProperty] private string? _componentName = "";

    /// <summary>
    /// The chunk mask
    /// </summary>
    [ObservableProperty] private IRedPrimitive<ulong> _chunkMask = (CUInt64)18446744073709551615;

    /// <summary>
    /// Remember the last selection
    /// </summary>
    [ObservableProperty] private bool _rememberValues = false;
}