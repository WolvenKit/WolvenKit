using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WolvenKit.App.Extensions;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

public class CvmMaterialTools
{
    private readonly ILoggerService _loggerService;
    private readonly INotificationService _notificationService;

    public CvmMaterialTools(
        ILoggerService loggerService,
        INotificationService notificationService
    )
    {
        _notificationService = notificationService;
        _loggerService = loggerService;
    }

    #region convert between preload and regular

    public void ConvertMaterialsFromPreload(ChunkViewModel? cvm)
    {
        var resolvedData = cvm?.ResolvedData is CMesh ? cvm.ResolvedData : cvm?.GetRootModel().ResolvedData;
        if (cvm is null || resolvedData is not CMesh mesh ||
            (mesh.LocalMaterialBuffer.Materials.Count > 0 && mesh.ExternalMaterials.Count > 0))
        {
            return;
        }

        SetLocalMaterials(mesh, GetLocalMaterials(mesh), false);
        mesh.PreloadLocalMaterialInstances.Clear();

        SetExternalMaterials(mesh, GetExternalMaterials(mesh), false);
        mesh.PreloadExternalMaterials.Clear();

        RecalculateMaterialProperties(cvm, true);
        cvm.CalculateEditorDifficultyVisibility();
        cvm.Tab?.Parent.SetIsDirty(true);
    }

    public void ConvertMaterialsToPreload(ChunkViewModel? cvm)
    {
        var resolvedData = cvm?.ResolvedData is CMesh ? cvm.ResolvedData : cvm?.GetRootModel().ResolvedData;
        if (cvm is null || resolvedData is not CMesh mesh ||
            (mesh.LocalMaterialBuffer.Materials.Count == 0 && mesh.ExternalMaterials.Count == 0))
        {
            return;
        }

        SetLocalMaterials(mesh, GetLocalMaterials(mesh), true);
        mesh.LocalMaterialBuffer.Materials.Clear();

        SetExternalMaterials(mesh, GetExternalMaterials(mesh), true);
        mesh.ExternalMaterials.Clear();

        RecalculateMaterialProperties(cvm, true);
        cvm.CalculateEditorDifficultyVisibility();
        cvm.Tab?.Parent.SetIsDirty(true);
    }

    #endregion

    #region helper methods and convenience

    private static void RecalculateMaterialProperties(ChunkViewModel cvm, bool refreshAll = false)
    {
        cvm.GetPropertyChild("materialEntries")?.RecalculateProperties();

        if (refreshAll || HasPreloadMaterials(cvm))
        {
            cvm.GetPropertyChild("preloadLocalMaterialInstances")?.RecalculateProperties();
            cvm.GetPropertyChild("preloadExternalMaterials")?.RecalculateProperties();
            if (!refreshAll)
            {
                return;
            }
        }

        cvm.GetPropertyChild("localMaterialBuffer")?.GetPropertyChild("materials")?.RecalculateProperties();
        cvm.GetPropertyChild("localMaterialBuffer")?.RecalculateProperties();
        cvm.GetPropertyChild("externalMaterials")?.RecalculateProperties();
    }

    public static bool HasPreloadMaterials(ChunkViewModel cvm) =>
        cvm.GetRootModel() is { ResolvedData: CMesh mesh } && HasPreloadMaterials(mesh);

    private static bool HasPreloadMaterials(CMesh mesh) =>
        mesh.PreloadExternalMaterials.Count > 0 || mesh.PreloadLocalMaterialInstances.Count > 0;

    # endregion

    private static List<IMaterial> GetLocalMaterials(CMesh mesh)
    {
        if (HasPreloadMaterials(mesh))
        {
            return mesh.PreloadLocalMaterialInstances.Select(r => r.Chunk).OfType<IMaterial>().ToList();
        }

        return mesh.LocalMaterialBuffer.Materials.ToList();
    }

    private static void SetLocalMaterials(CMesh mesh, List<IMaterial> materials, bool isPreload)
    {
        if (isPreload)
        {
            mesh.PreloadLocalMaterialInstances.Clear();
            mesh.PreloadLocalMaterialInstances.AddRange(materials.Select(m => new CHandle<IMaterial>() { Chunk = m }));
            return;
        }

        mesh.LocalMaterialBuffer.Materials.Clear();
        mesh.LocalMaterialBuffer.Materials.AddRange(materials.Cast<CMaterialInstance>());
    }

    private static List<IRedRef> GetExternalMaterials(CMesh mesh)
    {
        if (HasPreloadMaterials(mesh))
        {
            return mesh.PreloadExternalMaterials.Cast<IRedRef>().ToList();
        }

        return mesh.ExternalMaterials.Cast<IRedRef>().ToList();
    }

    /// <summary>
    /// Sets a mesh file's external materials to the provided list of materials.
    /// </summary>
    /// <param name="mesh">The mesh file</param>
    /// <param name="materials">Can be CResourceReference or CResourceAsyncReference, method will convert.</param>
    /// <param name="isPreload">Picks destination lists and sets target type for conversion of materials.</param>
    private static void SetExternalMaterials(CMesh mesh, List<IRedRef> materials, bool isPreload)
    {
        if (isPreload)
        {
            mesh.PreloadExternalMaterials.Clear();
            mesh.PreloadExternalMaterials.AddRange(
                // make sure all materials are CResourceReference
                materials.Select(m =>
                {
                    if (m is CResourceReference<IMaterial> reference)
                    {
                        return reference;
                    }

                    return new CResourceReference<IMaterial>(m.DepotPath, m.Flags);
                }));

            return;
        }

        mesh.ExternalMaterials.Clear();
        mesh.ExternalMaterials.AddRange(
            // make sure all materials are CResourceAsyncReference
            materials.Select(m =>
            {
                if (m is CResourceAsyncReference<IMaterial> reference)
                {
                    return reference;
                }

                return new CResourceAsyncReference<IMaterial>(m.DepotPath, m.Flags);
            }));
    }

    public void DeleteUnusedMaterials(ChunkViewModel cvm, AppViewModel? appViewModel = null,
        bool suppressLogOutput = false)
    {
        if (cvm.GetRootModel() is not { ResolvedData: CMesh mesh } rootChunk)
        {
            return;
        }

        // Support auto-generated chunk material names (psiberx magic)
        var appearances = CreateAutoGeneratedChunkMaterials(mesh.Appearances);

        // Collect material names from appearance chunk materials
        var appearanceChunkMaterialNames = appearances
            .SelectMany(mA => mA!.ChunkMaterials.Select(chunkMaterial => chunkMaterial.GetResolvedText()).ToArray())
            .Where(n => n is not null)
            .Select(n => n!.Contains('@') ? $"@{n.Split('@').Last()}" : n) // dynamic
            .ToList();

        var localMatIdxList = mesh.MaterialEntries.Where((mE) =>
            mE.IsLocalInstance && mE.Name.GetResolvedText() is string s &&
            appearanceChunkMaterialNames.Contains(s, StringComparer.OrdinalIgnoreCase)
        ).Select(me => (int)me.Index).ToList();

        var externalMatIdxList = mesh.MaterialEntries.Where((mE) =>
            !mE.IsLocalInstance && mE.Name.GetResolvedText() is string s &&
            appearanceChunkMaterialNames.Contains(s, StringComparer.OrdinalIgnoreCase)
        ).Select(me => (int)me.Index).ToList();

        var numUnusedMaterials = mesh.MaterialEntries.Count - (localMatIdxList.Count + externalMatIdxList.Count);
        var numTemplateProperties = 0;

        var keepLocal = GetLocalMaterials(mesh)
            .Where((_, i) => localMatIdxList.Contains(i))
            .Select(DeleteTemplatePaths)
            .ToList();

        var isPreload = HasPreloadMaterials(mesh);

        if (numTemplateProperties > 0)
        {
            SetLocalMaterials(mesh, keepLocal, isPreload);
            RecalculateMaterialProperties(rootChunk);
            rootChunk.Tab?.Parent.SetIsDirty(true);

            _loggerService.Success($"Deleted {numTemplateProperties} properties from outdated templates.");
            _notificationService.Success($"Deleted {numTemplateProperties} properties from outdated templates.");
        }

        // If we don't have unused materials, check if we need to clean up template properties
        if (numUnusedMaterials == 0)
        {
            if (suppressLogOutput)
            {
                return;
            }

            _loggerService.Info("No unused materials in current mesh.");
            _notificationService.Info("No unused materials in current mesh.");

            return;
        }

        var keepExternal = GetExternalMaterials(mesh).Where((_, i) => localMatIdxList.Contains(i)).ToList();

        var usedMaterialDefinitions = mesh.MaterialEntries.Where(me =>
            (me.IsLocalInstance && localMatIdxList.Contains(me.Index)) ||
            (!me.IsLocalInstance && externalMatIdxList.Contains(me.Index))
        ).ToArray();

        if (appViewModel is not null && keepLocal.Count + keepExternal.Count != usedMaterialDefinitions.Length &&
            !appViewModel.ShowConfirmationDialog(
                "Not all remaining materials match up. This might break your materials or even your file! (Run file validation to find out what's wrong)",
                "Really delete materials?"))
        {
            return;
        }

        // recreate material definition
        mesh.MaterialEntries.Clear();
        var localMaterialIdx = 0;
        var externalMaterialIdx = 0;
        for (var i = 0; i < usedMaterialDefinitions.Length; i++)
        {
            var t = usedMaterialDefinitions[i];
            if (t.IsLocalInstance)
            {
                t.Index = (CUInt16)localMaterialIdx;
                localMaterialIdx += 1;
            }
            else
            {
                t.Index = (CUInt16)externalMaterialIdx;
                externalMaterialIdx += 1;
            }

            t.Index = (CUInt16)i;
            mesh.MaterialEntries.Add(t);
        }

        if (numUnusedMaterials > 0)
        {
            _loggerService.Info($"Deleted {numUnusedMaterials} unused materials.");
            _notificationService.Info($"Deleted {numUnusedMaterials} unused materials.");
        }

        SetLocalMaterials(mesh, keepLocal, isPreload);
        SetExternalMaterials(mesh, keepExternal, isPreload);

        RecalculateMaterialProperties(rootChunk);
        rootChunk.Tab?.Parent.SetIsDirty(true);

        return;

        // Clean up paths from ancient templates >.<
        IMaterial DeleteTemplatePaths(IMaterial material)
        {
            if (material is not CMaterialInstance matInstance)
            {
                return material;
            }

            CArray<CKeyValuePair> values = [];
            foreach (var cKeyValuePair in matInstance.Values)
            {
                if (cKeyValuePair.Value is not IRedRef reference || reference.DepotPath.GetResolvedText()?.Contains(
                        "this_is_an_extra_long_path_so_you_can_better_use_010_editor_to_custom_path") is not true)
                {
                    values.Add(cKeyValuePair);
                }
                else
                {
                    numTemplateProperties += 1;
                }
            }

            matInstance.Values = values;

            return matInstance;
        }
    }

    #region ArchiveXL

    public static IEnumerable<meshMeshAppearance?> CreateAutoGeneratedChunkMaterials(
        CArray<CHandle<meshMeshAppearance>> appearanceHandles)
    {
        var appearances = appearanceHandles.Select((handle) => handle.GetValue() as meshMeshAppearance)
            .Where((i) => i != null).ToList();
        if (appearances.Count == 0)
        {
            return appearances;
        }

        var firstChunkMaterials = appearances[0]!.ChunkMaterials;
        var firstAppearanceName = appearances[0]!.Name.GetResolvedText() ?? "INVALID";
        for (var i = 1; i < appearances.Count; i++)
        {
            var appearance = appearances[i];
            if (appearance is null || appearance.ChunkMaterials.Count > 0)
            {
                continue;
            }

            var appearanceName = appearance.Name.GetResolvedText() ?? "INVALID";
            appearance.ChunkMaterials ??= [];
            for (var j = 0; j < firstChunkMaterials.Count; j++)
            {
                var newChunkMaterial =
                    (firstChunkMaterials[j].GetResolvedText() ?? "").Replace(firstAppearanceName, appearanceName);
                appearance.ChunkMaterials.Insert(j, newChunkMaterial);
            }
        }

        return appearances;
    }

    #endregion

    #region generate_missing_materials

    public void GenerateMissingMaterials(ChunkViewModel cvm, string baseMaterial, bool isLocal,
        bool resolveSubstitutions)
    {
        GenerateMissingMaterialDefinitions(cvm, isLocal);
        GenerateMissingMaterialInstances(cvm, baseMaterial, isLocal, resolveSubstitutions);
    }

    private void GenerateMissingMaterialDefinitions(ChunkViewModel cvm, bool isLocal)
    {
        if (cvm.ResolvedData is not CMesh mesh)
        {
            return;
        }

        var definedMaterialNames = mesh.MaterialEntries.Select(mat => mat.Name).ToList();

        // Collect material names from appearance chunk materials
        var undefinedMaterialNames = CreateAutoGeneratedChunkMaterials(mesh.Appearances)
            .SelectMany(mA =>
                mA!.ChunkMaterials.Select(chunkMaterial => chunkMaterial.GetResolvedText() ?? "").ToArray())
            .Select((materialName) =>
                materialName.Contains('@') ? $"@{materialName.Split('@').Last()}" : materialName) // dynamic
            .Where((chunkMaterialName) => !definedMaterialNames.Contains(chunkMaterialName))
            .ToHashSet().ToList();

        if (undefinedMaterialNames.Count == 0)
        {
            _notificationService.Success("No undefined materials - nothing was generated!");
            _loggerService.Success("No undefined materials - nothing was generated!");
            return;
        }

        var matIdx = mesh.MaterialEntries.LastOrDefault(mat => mat.IsLocalInstance == isLocal)?.Index ?? -1;

        // Create material definitions
        foreach (var materialName in undefinedMaterialNames)
        {
            matIdx += 1;
            var material = new CMeshMaterialEntry()
            {
                Name = materialName, Index = (CUInt16)matIdx, IsLocalInstance = isLocal
            };
            mesh.MaterialEntries.Add(material);
        }

        cvm.GetPropertyChild("materialEntries")?.RecalculateProperties();
    }


    private void GenerateMissingMaterialInstances(ChunkViewModel cvm, string baseMaterial, bool isLocal,
        bool resolveSubstitutions)
    {
        if (cvm.ResolvedData is not CMesh mesh || mesh.MaterialEntries.Count == 0)
        {
            return;
        }

        var numDefinedMaterials = isLocal ? mesh.LocalMaterialBuffer.Materials.Count : mesh.ExternalMaterials.Count;

        var matDefsWithoutEntry = mesh.MaterialEntries
            .Where(entry => entry.IsLocalInstance == isLocal && entry.Index >= numDefinedMaterials).ToList();

        if (matDefsWithoutEntry.Count == 0)
        {
            return;
        }

        var usePreload = HasPreloadMaterials(cvm);

        List<IRedRef> externalMaterials = [..GetExternalMaterials(mesh)];
        List<IMaterial> localMaterials = [..GetLocalMaterials(mesh)];

        foreach (var baseMaterialPath in matDefsWithoutEntry
                     .Select(mat => resolveSubstitutions
                         ? baseMaterial.Replace(@"{material}", mat.Name).Replace("*", "")
                         : baseMaterial))
        {
            if (isLocal)
            {
                localMaterials.Add(new CMaterialInstance()
                {
                    BaseMaterial = new CResourceReference<IMaterial>(baseMaterialPath)
                });
            }
            else
            {
                externalMaterials.Add(new CResourceReference<IMaterial>(baseMaterialPath));
            }
        }

        SetExternalMaterials(mesh, externalMaterials, usePreload);
        SetLocalMaterials(mesh, localMaterials, usePreload);

        RecalculateMaterialProperties(cvm);
    }

    #endregion

    public void AdjustSubmeshCount(ChunkViewModel cvm)
    {
        if (cvm.ResolvedData is not CMesh mesh || mesh.Appearances.Count == 0 ||
            mesh.RenderResourceBlob.GetValue() is not rendRenderMeshBlob blob)
        {
            return;
        }

        List<rendChunk> filteredRenderChunkInfos = new();
        List<CUInt8> filteredRenderChunks = new();

        for (var i = 0; i < blob.Header.RenderChunkInfos.Count; i++)
        {
            var renderChunkInfo = blob.Header.RenderChunkInfos[i];
            // <4 vertices: an "invisible" mesh that we want to get rid of
            if (renderChunkInfo.NumVertices <= 3)
            {
                continue;
            }

            filteredRenderChunkInfos.Add(renderChunkInfo);
            if (blob.Header.RenderChunks.Count > i)
            {
                filteredRenderChunks.Add(blob.Header.RenderChunks[i]);
            }
        }

        blob.Header.RenderChunkInfos = [];
        blob.Header.RenderChunks = [];

        foreach (var renderChunkInfo in filteredRenderChunkInfos)
        {
            blob.Header.RenderChunkInfos.Add(renderChunkInfo);
        }

        foreach (var renderChunkInfo in filteredRenderChunks)
        {
            blob.Header.RenderChunks.Add(renderChunkInfo);
        }

        // Find out how many chunk meshes we have
        var numSubmeshes = blob.Header.RenderChunkInfos.Count;
        var wasDeleted = false;
        var wasAdded = false;
        foreach (var appearance in mesh.Appearances.Select(a => a.GetValue()).OfType<meshMeshAppearance>())
        {
            if (appearance.ChunkMaterials.Count == numSubmeshes || appearance.ChunkMaterials.Count == 0)
            {
                continue;
            }

            var newMaterials = appearance.ChunkMaterials.Where((_, i) => i < numSubmeshes).ToList();
            if (newMaterials.Count < numSubmeshes)
            {
                var sequenceIndex =
                    GetIndexOfFirstNonRepeatingMaterial(newMaterials.Select(m => m.GetResolvedText() ?? "").ToList());

                while (newMaterials.Count < numSubmeshes && sequenceIndex < newMaterials.Count + 1)
                {
                    newMaterials.Add(newMaterials[sequenceIndex]);
                    wasAdded = true;
                    sequenceIndex = (sequenceIndex + 1) % newMaterials.Count;
                }
            }

            appearance.ChunkMaterials = new CArray<CName>();
            foreach (var t in newMaterials)
            {
                appearance.ChunkMaterials.Add(t);
            }

            wasDeleted = true;
        }


        if (wasAdded || wasDeleted)
        {
            cvm.GetPropertyChild("appearances")?.RecalculateProperties();
            _loggerService.Success("Chunk material counts were adjusted. You can now delete unused materials.");
            _notificationService.Success("Chunk material counts were adjusted. You can now delete unused materials.");
            cvm.Tab?.Parent.SetIsDirty(true);
        }
        else if (!wasDeleted)
        {
            _loggerService.Info("Submesh counts are fine, nothing to do");
            _notificationService.Info("Submesh counts are fine, nothing to do");
        }

        return;

        int GetIndexOfFirstNonRepeatingMaterial(List<string> materials)
        {
            var numMaterials = materials.Count;

            var materialCounts = new Dictionary<string, int>();
            foreach (var material in materials.Where(material => !materialCounts.TryAdd(material, 1)))
            {
                materialCounts[material]++;
            }

            var startIndex = 0;
            for (var i = 0; i < numMaterials; i++)
            {
                if (materialCounts[materials[i]] != 1)
                {
                    continue;
                }

                startIndex = i;
                break;
            }

            return startIndex;
        }
    }

    public void UnDynamifyMaterials(ChunkViewModel? cvm)
    {
        if (cvm?.ResolvedData is not CMesh mesh ||
            cvm.GetPropertyChild("appearances") is not ChunkViewModel appearances)
        {
            return;
        }

        appearances.CalculatePropertiesRecursive();

        var templatesAndValues = ArchiveXlHelper.GetMaterialSubstitutionMap(mesh.Appearances);

        // nothing to do here
        if (templatesAndValues.Count == 0)
        {
            return;
        }

        var expandedData = ArchiveXlHelper.ExpandAppearanceTemplate(mesh.Appearances);
        appearances.Data = ArchiveXlHelper.UnDynamifyChunkNames(expandedData);

        appearances.RecalculateProperties();

        cvm.GetPropertyChild("materials")?.CalculateProperties();
        cvm.GetPropertyChild("localMaterialBuffer", "materials")?.CalculateProperties();
        cvm.GetPropertyChild("preloadLocalMaterialInstances")?.CalculateProperties();

        var hasPreload = CvmMaterialTools.HasPreloadMaterials(cvm);

        // iterate over dictionary and create new materials
        foreach (var (matName, resolvedMatNames) in templatesAndValues)
        {
            var material = mesh.MaterialEntries.FirstOrDefault(m => m.Name == $"@{matName}");
            if (material is null || GetMaterialInstance(material.Index) is not CMaterialInstance matInstance)
            {
                _loggerService.Warning($"Can't un-dynamify material: Failed to resolve {matName}");
                continue;
            }

            var baseMaterialPath = matInstance.BaseMaterial.DepotPath.GetResolvedText() ?? "";

            var maxIndex = mesh.MaterialEntries.Where(m => m.IsLocalInstance.Equals(material.IsLocalInstance))
                .Select(m => m.Index).Max();

            foreach (var newMatName in resolvedMatNames.Distinct())
            {
                maxIndex += 1;
                mesh.MaterialEntries.Add(new CMeshMaterialEntry()
                {
                    Name = $"{matName}_{newMatName}", Index = maxIndex, IsLocalInstance = material.IsLocalInstance
                });

                var newMaterialInstance = new CMaterialInstance()
                {
                    BaseMaterial = new CResourceReference<IMaterial>(
                        baseMaterialPath.Replace("{material}", newMatName).Replace("*", ""),
                        InternalEnums.EImportFlags.Default),
                };

                foreach (var cvp in matInstance.Values)
                {
                    var value = ArchiveXlHelper.UnDynamifyResourceReference(cvp.Value, newMatName);

                    newMaterialInstance.Values.Add(new CKeyValuePair(cvp.Key, value));
                }

                mesh.LocalMaterialBuffer.Materials.Add(newMaterialInstance);
            }
        }

        cvm.GetPropertyChild("materialEntries")?.RecalculateProperties();
        cvm.GetPropertyChild("localMaterialBuffer", "materials")?.RecalculateProperties();

        DeleteUnusedMaterials(cvm, null, true);
        cvm.Tab?.Parent.SetIsDirty(true);

        return;

        IMaterial? GetMaterialInstance(int idx)
        {
            return hasPreload switch
            {
                true when mesh.PreloadLocalMaterialInstances.Count > idx =>
                    mesh.PreloadLocalMaterialInstances[idx].Chunk,
                false when mesh.LocalMaterialBuffer.Materials.Count > idx =>
                    mesh.LocalMaterialBuffer.Materials[idx],
                _ => null
            };
        }
    }

    /// <summary>
    /// Called from <see cref="ChunkViewModel.AddMaterialAndDefinition"/>
    /// </summary>
    public void AddMaterialAndDefinition(ChunkViewModel cvm, string newName)
    {
        var materialEntries = cvm.Parent?.GetRootModel().GetPropertyChild("materialEntries");
        if (materialEntries?.ResolvedData is not CArray<CMeshMaterialEntry> array)
        {
            return;
        }

        var isLocalInstance = cvm.Parent!.ResolvedData is meshMeshMaterialBuffer ||
                              cvm.Name == ChunkViewModel.PreloadMaterialPath;

        // Add the material definition
        var lastIndex = array.LastOrDefault((e) => e.IsLocalInstance == isLocalInstance)?.Index ?? -1;
        array.Add(new CMeshMaterialEntry
        {
            Name = newName, IsLocalInstance = isLocalInstance, Index = (CUInt16)lastIndex + 1
        });

        switch (materialEntries.ResolvedData)
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
        cvm.RecalculateProperties();
    }

    public static async Task<HashSet<ResourcePath>> GetMaterialRefsFromFile(ChunkViewModel cvm,
        IProjectManager? projectManager = null)
    {
        HashSet<ResourcePath> ret = [];

        switch (cvm.GetRootModel().ResolvedData)
        {
            case CMaterialInstance mi:
                // ReSharper disable once NullCoalescingConditionIsAlwaysNotNullAccordingToAPIContract api contract is more of a suggestion here
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
                // Async as a workaround for editor freezes if the lists get very long
                foreach (var externalMaterial in mesh.ExternalMaterials)
                {
                    await Task.Run(() => ret.Add(externalMaterial.DepotPath));
                }

                foreach (var externalMaterial in mesh.PreloadExternalMaterials)
                {
                    await Task.Run(() => ret.Add(externalMaterial.DepotPath));
                }

                List<CMaterialInstance> localMaterials = [];
                localMaterials.AddRange((mesh.LocalMaterialBuffer?.Materials ?? []).OfType<CMaterialInstance>());
                localMaterials.AddRange((mesh.PreloadLocalMaterialInstances ?? []).Select(h => h.Chunk)
                    .OfType<CMaterialInstance>());

                foreach (var localMaterial in localMaterials)
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

        if (projectManager?.ActiveProject?.Files is not null)
        {
            ret = ret.Where(p => !projectManager.ActiveProject.Files.Contains(p!)).ToHashSet();
        }

        return ret;
    }

    public int FindHighestMaterialIndex(ChunkViewModel? materialDefinitionArray, bool isLocalInstance)
    {
        if (materialDefinitionArray?.ResolvedData is not CArray<CMeshMaterialEntry> array || array.Count == 0)
        {
            return -1;
        }

        return FindHighestMaterialIndex(array, isLocalInstance);
    }

    private int FindHighestMaterialIndex(CArray<CMeshMaterialEntry> array, bool isLocalInstance)
    {
        if (array.Count == 0)
        {
            return -1;
        }

        List<int> indices = [];
        // ReSharper disable once ForCanBeConvertedToForeach - can't LINQ here
        // ReSharper disable once LoopCanBeConvertedToQuery - will throw NoElementsException
        for (var i = 0; i < array.Count; i++)
        {
            if (array[i].IsLocalInstance == isLocalInstance)
            {
                indices.Add(array[i].Index);
            }
        }

        return indices.Count == 0 ? -1 : indices.Max();
    }

    public void AddTagsToMeshAppearances(List<ChunkViewModel> chunks, List<string> tagList)
    {
        if (tagList.Count == 0 || chunks.Count == 0)
        {
            return;
        }
        List<meshMeshAppearance> appearances = [];
        List<ChunkViewModel> appearanceChunks = [];
        foreach (var cvm in chunks)
        {
            switch (cvm.ResolvedData)
            {
                case CArray<CHandle<meshMeshAppearance>> appearanceHandles:
                    appearances.AddRange(appearanceHandles.Select(h => h.GetValue()).OfType<meshMeshAppearance>());
                    appearanceChunks.AddRange(cvm.GetPropertyChild("appearances")?.GetAllProperties() ?? []);
                    break;
                case meshMeshAppearance singleAppearance:
                    appearances.Add(singleAppearance);
                    appearanceChunks.Add(cvm);
                    break;
            }
        }

        if (appearances.Count == 0)
        {
            return;
        }

        foreach (var appearance in appearances)
        {
            foreach (var tag in tagList.Where(tag => !appearance.Tags.Contains(tag)))
            {
                appearance.Tags.Add(tag);
            }
        }

        foreach (var cvm in appearanceChunks)
        {
            cvm.RecalculateProperties();
        }

        appearanceChunks.First().Tab?.Parent.SetIsDirty(true);
    }

    private static readonly Dictionary<string, List<CKeyValuePair>> s_materialValuesByPath = [];

    /// <summary>
    /// Reads a material's properties into a map for quick lookup. This includes shader properties and parameters.
    /// </summary>
    /// <param name="relativeBasePath"></param>
    /// <param name="archiveManager"></param>
    /// <param name="previousPaths">Array of previous paths - will append current base material and return</param>
    /// <returns></returns>
    private List<string> ReadMaterialValuesRecursive(ResourcePath relativeBasePath, IAppArchiveManager archiveManager,
        List<string> previousPaths)
    {
        while (relativeBasePath.GetResolvedText() is string relPath && !previousPaths.Contains(relPath))
        {
            previousPaths.Add(relPath);

            if (s_materialValuesByPath.TryGetValue(relPath, out var values) ||
                archiveManager.GetCR2WFile(relativeBasePath, true, true) is not CR2WFile file)
            {
                break;
            }

            switch (file.RootChunk)
            {
                case CMaterialInstance matInstance:
                    s_materialValuesByPath[relPath] = matInstance.Values.ToList();
                    relativeBasePath = matInstance.BaseMaterial.DepotPath;
                    continue;

                case CMaterialTemplate shader:
                {
                    var shaderParamList = shader.Parameters[^1];
                    s_materialValuesByPath[relPath] = shaderParamList.Select(p => p.Chunk)
                        .OfType<CMaterialParameter>()
                        .Select(CKeyValuePairFactory.Create)
                        .ToList();

                    break;
                }
            }
        }

        return previousPaths;
    }

    private void ConvertExternalMaterials(CMesh mesh)
    {
        if (mesh.MaterialEntries.Count == 0)
        {
            _loggerService.Error("No materials defined in current mesh");
            return;
        }

        var idx = FindHighestMaterialIndex(mesh.MaterialEntries, true);
        // have to append those
        var highestLocalIdx = Math.Max(idx, 0);

        var isPreload = HasPreloadMaterials(mesh);
        var localMaterials = GetLocalMaterials(mesh);
        var externalMaterials = GetExternalMaterials(mesh);

        var materialEntries = mesh.MaterialEntries.ToList();
        for (var i = 0; i < materialEntries.Count; i++)
        {
            var matDef = materialEntries[i];
            if (matDef.IsLocalInstance)
            {
                continue;
            }

            highestLocalIdx += 1;
            matDef.Index = (CUInt16)highestLocalIdx;
            matDef.IsLocalInstance = true;
            if (i >= externalMaterials.Count)
            {
                continue;
            }

            var mat = externalMaterials[i];
            localMaterials.Add(new CMaterialInstance()
            {
                BaseMaterial = new CResourceReference<IMaterial>(mat.DepotPath)
            });
        }

        // now sort them by index
        materialEntries.Sort((a, b) => b.Index - a.Index);

        mesh.MaterialEntries.Clear();
        foreach (var entry in materialEntries)
        {
            mesh.MaterialEntries.Add(entry);
        }

        SetLocalMaterials(mesh, localMaterials, isPreload);
        SetExternalMaterials(mesh, [], isPreload);
    }

    public void FlattenMiChain(ChunkViewModel? cvm, IAppArchiveManager archiveManager, Cp77Project? project)
    {
        if (cvm is null || project is null)
        {
            return;
        }

        // empty cache
        s_materialValuesByPath.Clear();
        var isDirty = false;

        var cvmRelativePath = project.GetRelativePath(cvm.Tab?.FilePath ?? "invalid");

        switch (cvm.ResolvedData)
        {
            case CMaterialInstance mi:
                FlattenMiChainInMaterial(mi, cvmRelativePath);
                cvm.RecalculateProperties();
                break;
            case CMesh mesh:
                FlattenMeshMaterials(mesh);
                RecalculateMaterialProperties(cvm, true);
                break;

            // this will run on the selected cvm, so might have to use whatever node. Let's check if it's inside a .mi
            default:
                if (cvm.GetRootModel() is { ResolvedData: CMaterialInstance miParent } root)
                {
                    FlattenMiChainInMaterial(miParent, cvmRelativePath);
                    root.RecalculateProperties();
                }

                if (cvm.GetRootModel() is { ResolvedData: CMesh mesh2 } root2)
                {
                    FlattenMeshMaterials(mesh2);
                    RecalculateMaterialProperties(cvm, true);
                }

                break;
        }

        if (isDirty)
        {
            cvm.Tab?.Parent.SetIsDirty(true);
        }

        return;

        void FlattenMeshMaterials(CMesh mesh)
        {
            if (mesh.ExternalMaterials.Count > 0 || mesh.PreloadExternalMaterials.Count > 0)
            {
                ConvertExternalMaterials(mesh);
            }

            var idx = 0;
            foreach (var material in mesh.LocalMaterialBuffer.Materials.OfType<CMaterialInstance>())
            {
                FlattenMiChainInMaterial(material, "localMaterialBuffer/materials[" + idx + "]");
                cvm.GetPropertyChild("localMaterialBuffer", "materials")?.RecalculateProperties();
                idx += 1;
            }


            idx = 0;
            foreach (var material in mesh.PreloadLocalMaterialInstances.Select(h => h.Chunk)
                         .OfType<CMaterialInstance>())
            {
                FlattenMiChainInMaterial(material, "preloadLocalMaterialInstances[" + idx + "]");
                cvm.GetPropertyChild("preloadLocalMaterialInstances")?.RecalculateProperties();
                idx += 1;
            }
        }

        void FlattenMiChainInMaterial(CMaterialInstance inst, string relativePath)
        {
            s_materialValuesByPath[relativePath] = inst.Values.ToList();

            // first, read the entire material chain into the cache
            var baseMaterialChain =
                ReadMaterialValuesRecursive(inst.BaseMaterial.DepotPath, archiveManager, [relativePath]);

            if (baseMaterialChain.Count == 1)
            {
                // only contains self, nothing to do
                return;
            }

            List<CKeyValuePair> values = [];
            var q = new Queue<string>(baseMaterialChain); // O(n) to build, then O(1) per item
            var baseMaterial = "";

            while (q.Count > 0)
            {
                baseMaterial = q.Dequeue();
                if (!s_materialValuesByPath.TryGetValue(baseMaterial, out var valuesArray) ||
                    !baseMaterial.EndsWith(".mi"))
                {
                    continue;
                }

                values.AddRange(valuesArray.Where(f => !values.Contains(f)));
            }

            // nothing has changed
            if (inst.BaseMaterial.DepotPath == baseMaterial && values.All(v => inst.Values.Contains(v)))
            {
                return;
            }

            isDirty = true;
            inst.BaseMaterial = new CResourceReference<IMaterial>(baseMaterial);
            inst.Values.Clear();
            List<CKeyValuePair> shaderProperties = [];
            if (s_materialValuesByPath.TryGetValue(baseMaterial, out var shaderValues))
            {
                shaderProperties.AddRange(shaderValues);
            }

            // can't LINQ here because CArray doesn't like it
            foreach (var cKeyValuePair in values.Where(cKeyValuePair => !shaderProperties.Contains(cKeyValuePair)))
            {
                inst.Values.Add(cKeyValuePair);
            }
        }
    }
}
