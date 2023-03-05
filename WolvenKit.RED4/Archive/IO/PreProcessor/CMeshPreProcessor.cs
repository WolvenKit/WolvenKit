using WolvenKit.Core.Interfaces;
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

        // make sure that the mesh is using either localMaterials or preloadLocalMaterials
        if (mesh.ExternalMaterials.Count > 0 && mesh.PreloadExternalMaterials.Count > 0)
        {
            _loggerService.Warning($"Your mesh is trying to use both externalMaterials and preloadExternalMaterials. " +
                                   $"To avoid unspecified behaviour, use only one of the lists.");
        }

        // make sure that the mesh is using either localMaterialBuffer.materials or preloadLocalMaterialInstances
        if (mesh.LocalMaterialBuffer is { Materials: { } } && mesh.LocalMaterialBuffer.Materials.Count > 0 && mesh.PreloadLocalMaterialInstances.Count > 0)
        {
            _loggerService.Warning($"Your mesh is trying to use both localMaterialBuffer.materials and preloadLocalMaterialInstances. " +
                                   $"To avoid unspecified behaviour, use only one of the lists.");
        }

        var sumOfLocal = mesh.LocalMaterialInstances.Count + mesh.PreloadLocalMaterialInstances.Count;
        if (mesh.LocalMaterialBuffer is { Materials: { } })
        {
            sumOfLocal += mesh.LocalMaterialBuffer.Materials.Count;
        }
        var sumOfExternal = mesh.ExternalMaterials.Count + mesh.PreloadExternalMaterials.Count;

        var localIndexList = new Dictionary<ushort, int>();

        var materialNames = new List<string>();

        for (var i = 0; i < mesh.MaterialEntries.Count; i++)
        {
            var materialEntry = mesh.MaterialEntries[i];
            ArgumentNullException.ThrowIfNull(materialEntry);

            // Put all material names into a list - we'll use it to verify the appearances later
            var name = materialEntry.Name.ToString() ?? "";
            materialNames.Add(name);
            
            if (materialEntry.IsLocalInstance)
            {
                if (materialEntry.Index >= sumOfLocal)
                {
                    _loggerService.Warning($"materialEntries[{i}] ({materialEntry.Name}) is trying to access a local material with the index " +
                                           $"{materialEntry.Index}, but there are only {sumOfExternal -1} entries.");
                }

                if (localIndexList.ContainsKey(materialEntry.Index))
                {
                    _loggerService.Warning($"materialEntries[{i}] ({materialEntry.Name}) is overwriting an already-defined " +
                                           $"material index: {materialEntry.Index}. Your material assignments might not work as expected.");
                }
                localIndexList.Add(materialEntry.Index, i);
            }
            else
            {
                
                if (materialEntry.Index >= sumOfExternal)
                {
                    _loggerService.Warning($"materialEntries[{i}] ({materialEntry.Name}) is trying to access an external material with the index " +
                                           $"{materialEntry.Index}, but there are only {sumOfExternal -1} entries.");
                }
            }
        }

        var materialIdx = 0; 
        
        if (mesh.LocalMaterialBuffer is { Materials: { } localMaterials })
        {
            foreach (var material in localMaterials)
            {
                if (material == null)
                {
                    continue;
                } 
                
                var materialName = "unknown";
                var matDefinition = mesh.MaterialEntries[materialIdx];
                if (null != matDefinition)
                {
                    materialName = $"({matDefinition.Name})";
                }

                
                CheckMaterialProperties((CMaterialInstance)material, materialName);
                materialIdx += 1;
            }
        }
        
        materialIdx = 0;
        foreach (var handle in mesh.PreloadLocalMaterialInstances)
        {
            if (handle is not { Chunk: { } material })
            {
                continue;
            }
            var materialName = "unknown";
            var matDefinition = mesh.MaterialEntries[materialIdx];
            if (null != matDefinition)
            {
                materialName = $"{matDefinition.Name}";
            }

            CheckMaterialProperties((CMaterialInstance)material, materialName);
            materialIdx += 1;
        }

        // TODO: Set this to the real value, but I don't know how
        var numSubmeshes = 0;
        
        CheckAppearances(mesh.Appearances);
        
        
        // 
        void CheckAppearances(CArray<CHandle<meshMeshAppearance>> meshAppearances)
        {
            foreach (var appearanceDefinition in meshAppearances)
            {
                if (appearanceDefinition is not { Chunk: { } appearance })
                {
                    continue;
                }

                if (numSubmeshes >= appearance.ChunkMaterials.Count)
                {
                    _loggerService.Warning($"Appearance {appearance.Name} has only {appearance.ChunkMaterials.Count} of {numSubmeshes} submesh " +
                                           $"appearances assigned. Meshes without appearances will render as invisible.");
                }

                foreach (var chunkName in appearance.ChunkMaterials)
                {
                    var assignedMaterialName = chunkName.GetString();
                    if (null != assignedMaterialName && !materialNames.Contains(assignedMaterialName))
                    {
                        _loggerService.Warning($"Appearance {appearance.Name}: Chunk material {assignedMaterialName} doesn't exist, " +
                                               $"submesh will render as invisible.");
                    }
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

            var index = 0;
            foreach (var entry in material.Values)
            {
                if (entry == null)
                {
                    index += 1;
                    continue;
                }

                // make sure it's not null so we can check if it's invalid. Can probably be done better.
                // TODO: Properly resolve this - I don't know how. We want to check if the DepotPath value is set and
                // ends with an invalid file extension. 
                var value = entry.Value.ToString() ?? "";

                // Compiler didn't like me putting this directly into the switch statement.
                var key = entry.Key.ToString();
                
                switch(key)
                {
                    case "MultilayerSetup":
                        if (value != "" && !value.EndsWith(".mlsetup"))
                        {
                            _loggerService.Warning($"{materialName}.values[{index}]: Multilayersetup doesn't end in .mlsetup. This might cause crashes.");
                        }
                        break;
                    case "MultilayerMask":
                        if (value != "" && !value.EndsWith(".mlkasm"))
                        {
                            _loggerService.Warning($"{materialName}.values[{index}]: MultilayerMask doesn't end in .mlmask. This might cause crashes.");
                        }
                        break;
                    case "BaseColor":
                    case "Metalness":
                    case "Roughness":
                    case "Normal":
                    case "GlobalNormal":
                        if (value != "" && !value.EndsWith(".xbm"))
                        {
                            _loggerService.Warning($"{materialName}.values[{index}]: {key} doesn't end in .xbm. This might cause crashes.");
                        }
                        break;
                }
                index += 1;
            }
        }
    }
}