using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.Common;
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
    [ObservableProperty] private bool _shouldShowPasteOverwrite;

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
        ShouldShowPasteOverwrite = ShouldShowArrayOps && IsShiftKeyPressedOnly && Tab?.SelectedChunk is not null;
        ShouldShowOverwriteArray = ShouldShowArrayOps && IsCtrlKeyPressed && !ShouldShowPasteOverwrite;
        ShouldShowPasteIntoArray = ShouldShowArrayOps && !ShouldShowPasteOverwrite && !ShouldShowOverwriteArray;

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

        var oldName = entry.Name;
        var newName = await Interactions.ShowInputBoxAsync("Rename material", entry.Name.GetResolvedText() ?? "");

        entry.Name = (CName)newName;

        Tab?.Parent?.SetIsDirty(true);
        
        materialEntries.RecalculateProperties();
        CalculateDescriptor();

        // now rename the chunks

        var appCvm = Parent?.Parent?.GetRootModel().GetModelFromPath("appearances");
        if (appCvm?.ResolvedData is not CArray<CHandle<meshMeshAppearance>> appearances)
        {
            return Task.CompletedTask;
        }

        foreach (var appearanceHandle in appearances)
        {
            if (appearanceHandle.GetValue() is not meshMeshAppearance appearance)
            {
                continue;
            }

            for (var i = 0; i < appearance.ChunkMaterials.Count; i++)
            {
                if (appearance.ChunkMaterials[i] == oldName)
                {
                    appearance.ChunkMaterials[i] = (CName)newName;
                }
            }
        }

        foreach (var prop in appCvm.DisplayProperties)
        {
            prop.RecalculateProperties();
            prop.CalculateValue();
        }

        appCvm.RecalculateProperties();
        appCvm.CalculateValue();
        
        return Task.CompletedTask;
    }

    /// <summary>
    /// Called from RedDocumentViewToolbar: returns all material dependencies in an array for adding them to the current project
    /// </summary>
    public async Task<HashSet<ResourcePath>> GetMaterialDependenciesOutsideOfProject()
    {
        HashSet<ResourcePath> ret = [];
        _modifierViewStateService.RefreshModifierStates();

        switch (GetRootModel().ResolvedData)
        {
            case CMaterialInstance mi:
                foreach (var value in (mi.Values ?? []).OfType<CKeyValuePair>())
                {
                    switch (value.Value)
                    {
                        case IRedResourceReference rRef:
                            AddRefPath(rRef.DepotPath);
                            break;
                        case IRedResourceAsyncReference raRef:
                            AddRefPath(raRef.DepotPath);
                            break;
                        default:
                            break;
                    }
                }

                break;
            case CMesh mesh:
                if (mesh.PreloadExternalMaterials.Count > 0 || mesh.PreloadLocalMaterialInstances.Count > 0)
                {
                    GetRootModel().ConvertPreloadMaterials();
                }

                foreach (var externalMaterial in mesh.ExternalMaterials)
                {
                    await Task.Run(() => AddRefPath(externalMaterial.DepotPath));
                }

                foreach (var localMaterial in (mesh.LocalMaterialBuffer?.Materials ?? []).OfType<CMaterialInstance>())
                {
                    await Task.Run(() => AddRefPath(localMaterial.BaseMaterial.DepotPath));
                    foreach (var value in localMaterial.Values)
                    {
                        switch (value.Value)
                        {
                            case IRedResourceReference rRef:
                                AddRefPath(rRef.DepotPath);
                                break;
                            case IRedResourceAsyncReference raRef:
                                AddRefPath(raRef.DepotPath);
                                break;
                            default:
                                break;
                        }
                    }
                }

                break;
            default:
                break;
        }
        
       
        return ret;

        void AddRefPath(ResourcePath refPath)
        {
            var refPathHash = HashHelper.CalculateDepotPathHash(refPath);
            // empty depot path
            if (refPathHash is 0)
            {
                return;
            }

            if (_projectManager.ActiveProject?.Files is not null && _projectManager.ActiveProject.Files.Contains(refPath!))
            {
                return;
            }

            if (_archiveManager.Lookup(refPathHash, ArchiveManagerScope.Mods).HasValue)
            {
                ret.Add(refPath);
                return;
            }

            // base game file: Only add those if shift is down
            if (_modifierViewStateService.IsShiftKeyPressed
                && _archiveManager.Lookup(refPathHash, ArchiveManagerScope.Basegame).HasValue)
            {
                ret.Add(refPath);
            }
        }
    }

    [RelayCommand]
    private void ScrollToMaterial()
    {
        if (GetRootModel() is not { ResolvedData: CMesh mesh } rootModel || Tab is null)
        {
            return;
        }

        if (mesh.PreloadExternalMaterials.Count > 0 || mesh.PreloadLocalMaterialInstances.Count > 0)
        {
            rootModel.ConvertPreloadMaterials();
        }

        if (ResolvedData is CName data && Parent?.Name == "chunkMaterials" &&
            data.GetResolvedText() is string materialName &&
            GetRootModel().FindPropertyNode("materialEntries") is
                { ResolvedData: CArray<CMeshMaterialEntry> ary } materialEntries)
        {
            if (ary.FirstOrDefault(e => e.Name == materialName) is not CMeshMaterialEntry matDef)
            {
                return;
            }

            var mat = FindMaterialDefinition(matDef.IsLocalInstance, matDef.Name, matDef.Index);
            mat?.ScrollToMaterial();
            return;
        }

        if (ResolvedData is not CMeshMaterialEntry entry)
        {
            return;
        }

        if (entry.IsLocalInstance && FindLocalMaterial(entry.Index) is ChunkViewModel localMaterial)
        {
            Tab.ScrollToNode(localMaterial);
            return;
        }

        if (!entry.IsLocalInstance && FindExternalMaterial(entry.Index) is ChunkViewModel externalMaterial)
        {
            Tab.ScrollToNode(externalMaterial);
        }
    }

    [RelayCommand]
    private async Task<Task> AddMaterialAndDefinition()
    {
        var newName = await Interactions.ShowInputBoxAsync("New material name", "");

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