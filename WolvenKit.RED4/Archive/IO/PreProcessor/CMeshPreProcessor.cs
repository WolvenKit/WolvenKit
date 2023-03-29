using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO.PreProcessor;

public class CMeshPreProcessor : IPreProcessor
{
    private readonly ILoggerService? _loggerService;

    public CMeshPreProcessor(ILoggerService? loggerService) => _loggerService = loggerService;

    public void Process(RedBaseClass cls)
    {
        if (_loggerService == null)
        {
            return;
        }

        var mesh = (CMesh)cls;

        // Need to create LocalMaterialBuffer.RawData else the materials won't get written
        if (mesh.LocalMaterialBuffer.Materials is { Count: > 0 } &&
            mesh.LocalMaterialBuffer.RawData?.Buffer.Data == null)
        {
            mesh.LocalMaterialBuffer.RawData = new DataBuffer
            {
                Buffer =
                {
                    Data = new CR2WList(), 
                    Parent = mesh.LocalMaterialBuffer
                }
            };
        }

        // make sure that the mesh is using either localMaterials or preloadLocalMaterials
        if (mesh.ExternalMaterials.Count > 0 && mesh.PreloadExternalMaterials.Count > 0)
        {
            _loggerService.Warning("Your mesh is trying to use both externalMaterials and preloadExternalMaterials. " +
                                   "To avoid unspecified behaviour, use only one of the lists.");
        }

        // make sure that the mesh is using either localMaterialBuffer.materials or preloadLocalMaterialInstances
        if (mesh.LocalMaterialBuffer is { Materials.Count: > 0 } && mesh.PreloadLocalMaterialInstances.Count > 0)
        {
            _loggerService.Warning("Your mesh is trying to use both localMaterialBuffer.materials and preloadLocalMaterialInstances. " +
                                 "To avoid unspecified behaviour, use only one of the lists.");
        }

        var sumOfLocal = mesh.LocalMaterialInstances.Count + mesh.PreloadLocalMaterialInstances.Count;
        if (mesh.LocalMaterialBuffer is { Materials: { } })
        {
            sumOfLocal += mesh.LocalMaterialBuffer.Materials.Count;
        }
        var sumOfExternal = mesh.ExternalMaterials.Count + mesh.PreloadExternalMaterials.Count;

        var usedLocalIndices = new HashSet<ushort>();
        var materialNames = new List<string>();

        for (var i = 0; i < mesh.MaterialEntries.Count; i++)
        {
            var materialEntry = mesh.MaterialEntries[i];

            // Put all material names into a list - we'll use it to verify the appearances later
            var name = materialEntry.Name.ToString() ?? "";
            materialNames.Add(name);
            
            if (materialEntry.IsLocalInstance)
            {
                if (materialEntry.Index >= sumOfLocal)
                {
                    _loggerService.Warning($"materialEntries[{i}] ({materialEntry.Name}) is trying to access a local material with the index " +
                                           $"{materialEntry.Index}, but there are only {sumOfLocal} entries.");
                }

                if (!usedLocalIndices.Add(materialEntry.Index))
                {
                    _loggerService.Warning($"materialEntries[{i}] ({materialEntry.Name}) is overwriting an already-defined " +
                                           $"material index: {materialEntry.Index}. Your material assignments might not work as expected.");
                }
            }
            else
            {
                if (materialEntry.Index >= sumOfExternal)
                {
                    _loggerService.Warning($"materialEntries[{i}] ({materialEntry.Name}) is trying to access an external material with the index " +
                                           $"{materialEntry.Index}, but there are only {sumOfExternal} entries.");
                }
            }
        }

        if (mesh.LocalMaterialBuffer is { Materials: { } localMaterials })
        {
            for (var i = 0; i < localMaterials.Count; i++)
            {
                if (localMaterials[i] is not { } material)
                {
                    continue;
                }

                var materialName = "unknown";

                // Add a warning here???
                if (i < mesh.MaterialEntries.Count && mesh.MaterialEntries[i] == null)
                {
                    materialName = $"{mesh.MaterialEntries[i].Name}";
                }

                CheckMaterialProperties((CMaterialInstance)material, materialName);
            }
        }

        for (var i = 0; i < mesh.PreloadLocalMaterialInstances.Count; i++)
        {
            if (mesh.PreloadLocalMaterialInstances[i] is not { Chunk: { } material })
            {
                continue;
            }

            var materialName = "unknown";

            // Add a warning here???
            if (i < mesh.MaterialEntries.Count && mesh.MaterialEntries[i] == null)
            {
                materialName = $"{mesh.MaterialEntries[i].Name}";
            }

            CheckMaterialProperties((CMaterialInstance)material, materialName);
        }

        var numSubMeshes = 0;
        // Create RenderResourceBlob if it doesn't exists?
        if (mesh.RenderResourceBlob?.Chunk is rendRenderMeshBlob blob)
        {
            numSubMeshes = blob.Header.RenderChunkInfos.Count;
        }

        foreach (var appearanceDefinition in mesh.Appearances)
        {
            if (appearanceDefinition is not { Chunk: { } appearance })
            {
                continue;
            }

            if (numSubMeshes > appearance.ChunkMaterials.Count)
            {
                _loggerService.Warning($"Appearance {appearance.Name} has only {appearance.ChunkMaterials.Count} of {numSubMeshes} submesh " +
                                       "appearances assigned. Meshes without appearances will render as invisible.");
            }

            foreach (var chunkName in appearance.ChunkMaterials)
            {
                if (chunkName.GetResolvedText() is {} assignedMaterialName && !materialNames.Contains(assignedMaterialName))
                {
                    _loggerService.Warning($"Appearance {appearance.Name}: Chunk material {assignedMaterialName} doesn't exist, " +
                                           "submesh will render as invisible.");
                }
            }
        }


        void CheckMaterialProperties(CMaterialInstance material, string materialName)
        {
            // TODO: Make null-proof and use, or delete :D
            var shaderName = material.BaseMaterial.DepotPath.ToString();
            // We could have a dictionary like
            // {
            //    "metal_base.remt": {
            //        "BaseColor": ".xbm", 
            //     },
            //    "multilayered.mt": {
            //        "MultilayerSetup": ".mlsetup", 
            //     },
            //}
            // and then check for keys/values in the list, but it's honestly beyond me right now.

            for (var i = 0; i < material.Values.Count; i++)
            {
                var entry = material.Values[i];
                if (entry == null)
                {
                    continue;
                }

                if (entry.Key.GetResolvedText() is not { } key)
                {
                    continue;
                }

                if (entry.Value is not IRedRef resource || resource.DepotPath.GetResolvedText() is not { } path)
                {
                    continue;
                }

                switch (key)
                {
                    case "MultilayerSetup":
                        if (!path.EndsWith(".mlsetup"))
                        {
                            _loggerService.Warning($"{materialName}.values[{i}]: Multilayersetup doesn't end in .mlsetup. This might cause crashes.");
                        }
                        break;

                    case "MultilayerMask":
                        if (!path.EndsWith(".mlmask"))
                        {
                            _loggerService.Warning($"{materialName}.values[{i}]: MultilayerMask doesn't end in .mlmask. This might cause crashes.");
                        }
                        break;
                    case "BaseColor":
                    case "Metalness":
                    case "Roughness":
                    case "Normal":
                    case "GlobalNormal":
                        if (!path.EndsWith(".xbm"))
                        {
                            _loggerService.Warning($"{materialName}.values[{i}]: {key} doesn't end in .xbm. This might cause crashes.");
                        }
                        break;
                }
            }
        }
    }
}