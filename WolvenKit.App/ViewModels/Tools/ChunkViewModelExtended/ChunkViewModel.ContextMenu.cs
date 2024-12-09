using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel
{
    #region properties

    [NotifyCanExecuteChangedFor(nameof(DuplicateChunkCommand))]
    [NotifyCanExecuteChangedFor(nameof(DuplicateAsNewChunkCommand))]
    [NotifyCanExecuteChangedFor(nameof(ToggleEnableMaskedCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertPreloadMaterialsCommand))]
    [NotifyCanExecuteChangedFor(nameof(DeleteUnusedMaterialsCommand))]
    [NotifyCanExecuteChangedFor(nameof(ClearMaterialsCommand))]
    [ObservableProperty] private bool _isShiftKeyPressed;
    
    [ObservableProperty] private bool _isCtrlKeyPressed;
    [ObservableProperty] private bool _isAltKeyPressed;
    
    [ObservableProperty] private bool _isMaterial;

    [ObservableProperty] private bool _isMaterialArray;
    [ObservableProperty] private bool _shouldShowCreateMatDef;
    [ObservableProperty] private bool _shouldShowCreateExternalMatDef;

    [ObservableProperty] private bool _duplicatesAsNew;

    [ObservableProperty] private bool _isMultipleItemsSelected;
    [ObservableProperty] private bool _isMultipleItemsCopied;

    #endregion

    #region methods

    public void RefreshContextMenuFlags()
    {
        IsShiftKeyPressed = ModifierViewStateService.IsShiftBeingHeld;
        IsCtrlKeyPressed = ModifierViewStateService.IsCtrlBeingHeld;
        IsAltKeyPressed = ModifierViewStateService.IsAltBeingHeld;

        IsMaterial = ResolvedData is CMaterialInstance or CResourceAsyncReference<IMaterial>;

        IsMaterialArray = ResolvedData is CArray<IMaterial> or CArray<CResourceAsyncReference<IMaterial>>;

        DuplicatesAsNew = ResolvedData is worldCompiledEffectPlacementInfo or CMeshMaterialEntry;

        IsMultipleItemsSelected = Parent?.Tab?.SelectedChunks is ObservableCollection<object> chunks && chunks.Count > 1;
    }

    public void RefreshCommandStatus()
    {
        GenerateChildCruidsCommand.NotifyCanExecuteChanged();
        CopyChildNamesCommand.NotifyCanExecuteChanged();
        ReindexChildDataIndexPropertiesCommand.NotifyCanExecuteChanged();
    }

    public bool IsMaterialDefinition() => ResolvedData is CArray<CMeshMaterialEntry> || Parent?.ResolvedData is CArray<CMeshMaterialEntry>;

    [RelayCommand(CanExecute = nameof(IsMaterialDefinition))]
    private void ToggleMaterialDefinitionIsExternal()
    {
        if (ResolvedData is not CMeshMaterialEntry entry)
        {
            return;
        }

        entry.IsLocalInstance = !entry.IsLocalInstance;
        RecalculateProperties();
    }

    [RelayCommand]
    private async Task<Task> RenameMaterial()
    {
        if (!IsMaterial)
        {
            return Task.CompletedTask;
        }

        var materialEntries = Parent?.Parent?.GetRootModel().GetPropertyFromPath("materialEntries");

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
        var appCvm = Parent?.Parent?.GetRootModel().GetPropertyFromPath("appearances");
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
    public async Task<HashSet<ResourcePath>> GetMaterialRefsFromFile()
    {
        HashSet<ResourcePath> ret = [];

        switch (GetRootModel().ResolvedData)
        {
            case CMaterialInstance mi:
                foreach (var value in (mi.Values ?? []).OfType<CKeyValuePair>())
                {
                    switch (value.Value)
                    {
                        case IRedResourceReference rRef:
                            ret.Add(rRef.DepotPath);
                            break;
                        case IRedResourceAsyncReference raRef:
                            ret.Add(raRef.DepotPath);
                            break;
                        default:
                            break;
                    }
                }

                break;
            case Multilayer_Setup mlsetup:
                foreach (var layer in mlsetup.Layers)
                {
                    ret.Add(layer.Material.DepotPath);
                    ret.Add(layer.Microblend.DepotPath);
                }

                break;
            case CMesh mesh:
                if (mesh.PreloadExternalMaterials.Count > 0 || mesh.PreloadLocalMaterialInstances.Count > 0)
                {
                    GetRootModel().ConvertPreloadMaterials();
                }

                foreach (var externalMaterial in mesh.ExternalMaterials)
                {
                    await Task.Run(() => ret.Add(externalMaterial.DepotPath));
                }

                foreach (var localMaterial in (mesh.LocalMaterialBuffer?.Materials ?? []).OfType<CMaterialInstance>())
                {
                    ret.Add(localMaterial.BaseMaterial.DepotPath);
                    foreach (var value in localMaterial.Values)
                    {
                        switch (value.Value)
                        {
                            case IRedResourceReference rRef:
                                ret.Add(rRef.DepotPath);
                                break;
                            case IRedResourceAsyncReference raRef:
                                ret.Add(raRef.DepotPath);
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

        if (_projectManager.ActiveProject?.Files is not null)
        {
            ret = ret.Where(p => !_projectManager.ActiveProject.Files.Contains(p!)).ToHashSet();
        }
        return ret;
    }

    private bool CanCopyChildNames() => IsArray;

    [RelayCommand(CanExecute = nameof(CanCopyChildNames))]
    private void CopyChildNames()
    {
        var names = Properties.Select(prop => prop.Descriptor).Where(s => !string.IsNullOrEmpty(s)).ToList();
        if (names.Count == 0)
        {
            return;
        }

        System.Windows.Clipboard.SetText(string.Join("\n", names));
    }

    private bool CanGenerateCruids() => IsArray && Name == "components";

    [RelayCommand(CanExecute = nameof(CanGenerateCruids))]
    private void GenerateChildCruids()
    {
        var hasChange = false;
        foreach (var child in Properties)
        {
            child.CalculateProperties();
            foreach (var grandChild in child.Properties.Where(c => c.ResolvedData is CRUID))
            {
                hasChange = true;
                grandChild.GenerateCRUID();
                grandChild.RecalculateProperties();
                grandChild.CalculateDescriptor();
            }
        }

        if (hasChange)
        {
            Tab?.Parent.SetIsDirty(true);
        }
    }
    
    private bool CanScrollToMaterial() => ShowScrollToMaterial || GetRootModel().ShowScrollToMaterial;

    [RelayCommand(CanExecute = nameof(CanScrollToMaterial))]
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
            GetRootModel().GetPropertyFromPath("materialEntries") is
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

    private bool CanToggleMask() => IsMaterialArray || IsMaterial;

    [RelayCommand(CanExecute = nameof(CanToggleMask))]
    private void ToggleEnableMasked()
    {
        switch (ResolvedData)
        {
            case CMaterialInstance material:
                material.EnableMask = !material.EnableMask;
                break;
            case CArray<CMeshMaterialEntry>:
            {
                foreach (var property in TVProperties.Where(p => p.ResolvedData is CMaterialInstance))
                {
                    property.ToggleEnableMaskedCommand.Execute(null);
                }

                break;
            }
            default:
                return;
        }

        RecalculateProperties();
        Tab?.Parent.SetIsDirty(true);
    }


    [RelayCommand]
    private async Task<Task> AddMaterialAndDefinition()
    {
        var newName = await Interactions.ShowInputBoxAsync("New material name", "");

        var materialEntries = Parent?.GetRootModel().GetPropertyFromPath("materialEntries");
        if (materialEntries?.ResolvedData is not CArray<CMeshMaterialEntry> array)
        {
            return Task.CompletedTask;
        }

        var isLocalInstance = Parent?.ResolvedData is meshMeshMaterialBuffer || Name == PreloadMaterialPath;

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

    public void ReplaceMeshComponentProperties(string componentName, IRedPrimitive<ulong>? chunkMask, string? depotPath,
        string? meshAppearance)
    {
        var hasChanges = false;

        switch (ResolvedData)
        {
            case appearanceAppearanceResource { Appearances.Count: > 0 } appearanceResource:
            {
                var appearanceChild = GetPropertyChild("appearances");
                foreach (var appearanceNode in appearanceChild?.Properties ?? [])
                {
                    appearanceNode.ReplaceMeshComponentProperties(componentName, chunkMask, depotPath, meshAppearance);
                }
                break;
            }
            case appearanceAppearanceDefinition appearance:
                SetAppearanceChunkMask(appearance);
                var componentsAryCvm = GetPropertyChild("components");
                componentsAryCvm?.CalculateProperties();
                var matchingComponents = componentsAryCvm?.Properties.Where(comp =>
                    comp.ResolvedData is entMeshComponent m && (componentName == "*" || m.Name == componentName)) ?? [];
                foreach (var componentCvm in matchingComponents)
                {
                    componentCvm.RecalculateProperties();
                    componentCvm.CalculateDescriptor();
                    componentCvm.CalculateValue();
                    componentCvm.CalculateIsDefault();
                }
                break;
            default:
                if (Parent is not null)
                {
                    GetRootModel().ReplaceMeshComponentProperties(componentName, chunkMask, depotPath, meshAppearance);
                }
                break;
        }

        if (hasChanges)
        {
            Tab?.Parent.SetIsDirty(true);
        }

        return;

        void SetAppearanceChunkMask(appearanceAppearanceDefinition appDef)
        {
            foreach (var component in appDef.Components.Where(comp => componentName == "*" || comp.Name == componentName))
            {
                if (component is not IRedMeshComponent meshComponent || (chunkMask is null && depotPath is null && meshAppearance is null))
                {
                    continue;
                }

                hasChanges = true;

                if (chunkMask is CUInt64 value)
                {
                    meshComponent.ChunkMask = value;
                }


                if (!string.IsNullOrEmpty(depotPath))
                {
                    if (appDef.Components.FirstOrDefault(comp => comp.Name == depotPath) is IRedMeshComponent siblingComponent)
                    {
                        meshComponent.Mesh = new CResourceAsyncReference<CMesh>(siblingComponent.Mesh.DepotPath);
                    }
                    else
                    {
                        meshComponent.Mesh = new CResourceAsyncReference<CMesh>((ResourcePath)depotPath);
                    }
                }

                if (!string.IsNullOrEmpty(meshAppearance))
                {
                    if (appDef.Components.FirstOrDefault(comp => comp.Name == meshAppearance) is IRedMeshComponent siblingComponent)
                    {
                        meshComponent.MeshAppearance = siblingComponent.MeshAppearance;
                    }
                    else
                    {
                        meshComponent.MeshAppearance = meshAppearance;
                    }
                }

                hasChanges = true;
            }
        }
    }
    #endregion


}