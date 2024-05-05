using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Interaction;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel : ObservableObject
{
    #region properties

    /// <summary>
    /// If shift is not being held, show "Duplicate Selection"
    /// </summary>
    [ObservableProperty] private bool _shouldShowDuplicate;

    [ObservableProperty] private bool _shouldShowPasteIntoArray;

    [ObservableProperty] private bool _shouldShowOverwriteArray;

    [ObservableProperty] private bool _isMaterial;

    [ObservableProperty] private bool _isMaterialArray;
    [ObservableProperty] private bool _shouldShowCreateMatDef;
    [ObservableProperty] private bool _shouldShowCreateExternalMatDef;

    private bool IsShiftKeyPressed => _modifierViewStateService.IsShiftKeyPressed;
    private bool IsShiftKeyPressedOnly => _modifierViewStateService.IsShiftKeyPressedOnly;
    private bool IsCtrlKeyPressed => _modifierViewStateService.IsCtrlKeyPressed;

    [ObservableProperty] private bool _shouldShowDuplicateAsNew;

    #endregion

    /// <summary>
    /// Triggered externally from RedTreeView, since binding to the listener ourselves will cause an event avalanche
    /// </summary>
    public void RefreshContextMenuFlags()
    {
        ShouldShowPasteIntoArray = ShouldShowArrayOps && !IsShiftKeyPressedOnly;
        ShouldShowOverwriteArray = ShouldShowArrayOps && IsShiftKeyPressedOnly;

        IsMaterial = ResolvedData is CMaterialInstance or CResourceAsyncReference<IMaterial>;

        IsMaterialArray = ResolvedData is CArray<IMaterial> or CArray<CResourceAsyncReference<IMaterial>>;
   
        ShouldShowDuplicateAsNew =
            IsInArray && !IsShiftKeyPressedOnly &&
            ResolvedData is worldCompiledEffectPlacementInfo or CMeshMaterialEntry;

        ShouldShowDuplicate = !ShouldShowDuplicateAsNew && IsInArray;
    }


    #region methods

    [RelayCommand]
    private async Task<Task> RenameMaterial()
    {
        if (!IsMaterial)
        {
            return Task.CompletedTask;
        }

        var materialEntries = Parent?.Parent?.GetRootModel().GetModelFromPath("materialEntries");

        if (materialEntries?.ResolvedData is not CArray<CMeshMaterialEntry> array)
        {
            return Task.CompletedTask;
        }

        var isLocalMaterial = ResolvedData is CMaterialInstance;
        var entry = array.FirstOrDefault(e => e.IsLocalInstance == isLocalMaterial && e.Index == NodeIdxInParent);
        if (entry is null)
        {
            return Task.CompletedTask;
        }

        var newName = await Interactions.ShowInputBoxAsync(entry.Name.GetResolvedText() ?? "");

        entry.Name = newName;
        materialEntries.RecalculateProperties();
        CalculateDescriptor();
        return Task.CompletedTask;
    }

    [RelayCommand]
    private async Task<Task> AddMaterialAndDefinition()
    {
        var newName = await Interactions.ShowInputBoxAsync("");

        var materialEntries = Parent?.GetRootModel().GetModelFromPath("materialEntries");
        if (materialEntries?.ResolvedData is not CArray<CMeshMaterialEntry> array)
        {
            return Task.CompletedTask;
        }

        var isLocalInstance = Parent?.ResolvedData is meshMeshMaterialBuffer || Name == "PreloadLocalMaterials";

        // Add the material definition
        var lastIndex = array.LastOrDefault((e) => e.IsLocalInstance == isLocalInstance)?.Index ?? -1;
        array.Add(new CMeshMaterialEntry { Name = newName, IsLocalInstance = isLocalInstance, Index = (CUInt16)lastIndex + 1 });

        switch (ResolvedData)
        {
            case CArray<CMaterialInstance> matInstances:
                matInstances.Add(new CMaterialInstance()); 
                break;
            case CArray<IMaterial> matInstances:
                matInstances.Add(new CMaterialInstance());
                break;
            case CArray<CResourceAsyncReference<IMaterial>> externalMaterials:
                externalMaterials.Add(new CResourceAsyncReference<IMaterial>());
                break;
            default:
                break;
        }

        materialEntries.RecalculateProperties();
        RecalculateProperties();

        return Task.CompletedTask;
    }

    #endregion


}