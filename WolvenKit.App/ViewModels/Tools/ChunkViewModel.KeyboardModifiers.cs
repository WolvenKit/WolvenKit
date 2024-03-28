using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel : ObservableObject
{
    /// <summary>
    /// Triggered externally from RedTreeView, since binding to the listener ourselves will cause an event avalanche
    /// </summary>
    public void RefreshContextMenuFlags()
    {
        ShouldShowPasteIntoArray = ShouldShowArrayOps && !IsShiftKeyPressedOnly;
        ShouldShowOverwriteArray = ShouldShowArrayOps && IsShiftKeyPressedOnly;
        
        ShouldShowDuplicateAsNew =
            IsInArray && !IsShiftKeyPressedOnly &&
            ResolvedData is worldCompiledEffectPlacementInfo or CMeshMaterialEntry;

        ShouldShowDuplicate = !ShouldShowDuplicateAsNew && IsInArray;
    }

    private bool IsShiftKeyPressed => _modifierViewStateService.IsShiftKeyPressed;
    private bool IsShiftKeyPressedOnly => _modifierViewStateService.IsShiftKeyPressedOnly;
    private bool IsCtrlKeyPressed => _modifierViewStateService.IsCtrlKeyPressed;

    [ObservableProperty] private bool _shouldShowDuplicateAsNew;


    /// <summary>
    /// If shift is not being held, show "Duplicate Selection"
    /// </summary>
    [ObservableProperty] private bool _shouldShowDuplicate;

    [ObservableProperty] private bool _shouldShowPasteIntoArray;

    [ObservableProperty] private bool _shouldShowOverwriteArray;
}