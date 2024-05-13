using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.Resources;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;
using EFileReadErrorCodes = WolvenKit.RED4.Archive.IO.EFileReadErrorCodes;

namespace WolvenKit.Modkit.RED4.GeneralStructs;

public class MaterialExtractor
{
    private readonly ModTools _modTools;
    private readonly IArchiveManager _archiveManager;

    private readonly string _materialRepositoryPath;
    private readonly GlobalExportArgs _globalExportArgs;
    private readonly ILoggerService _loggerService;

    private readonly List<string> _textureList = new();

    public MaterialExtractor(ModTools modTools, IArchiveManager archiveManager, string materialRepositoryPath,
        GlobalExportArgs globalExportArgs, ILoggerService loggerService)
    {
        _modTools = modTools;
        
        _archiveManager = archiveManager;
        _materialRepositoryPath = materialRepositoryPath;
        _globalExportArgs = globalExportArgs;
        _loggerService = loggerService;
    }

    public MatData GenerateMaterialData(CR2WFile mainFile)
    {
        if (mainFile.RootChunk is not CMesh cMesh)
        {
            throw new ArgumentException(nameof(mainFile));
        }

        var materialData = new MatData
        {
            MaterialRepo = _materialRepositoryPath,
            TexturesList = _textureList
        };

        // collect dynamic chunks - unique material names
        var dynamicChunks = cMesh.Appearances
            .Select(app => app.GetValue())
            .OfType<meshMeshAppearance>()
            .SelectMany(cMeshAppearance => cMeshAppearance.ChunkMaterials)
            .Where(chunkMaterial => (chunkMaterial.GetResolvedText() ?? "").Contains('@'))
            .ToHashSet();

        var materialDict = new Dictionary<string, string>();
        var materialInstanceList = new Dictionary<string, bool>();

        if (cMesh.ExternalMaterials.Count > 0 && cMesh.PreloadExternalMaterials.Count > 0)
        {
            _loggerService.Warning(
                "You're using both ExternalMaterials and PreloadExternalMaterials in the same mesh. This is not supported.");
        }

        var externalMaterials = cMesh.ExternalMaterials.ToList();
        var preloadExternalMaterials = cMesh.PreloadExternalMaterials.ToList();
        var preloadLocalMaterials = cMesh.PreloadLocalMaterialInstances.ToList();
        var localMaterials = (cMesh.LocalMaterialBuffer.Materials ?? []).ToList();

        // Collect material entries. Consider ArchiveXL dynamic materials.
        foreach (var materialEntry in cMesh.MaterialEntries)
        {
            var materialName = materialEntry.Name.GetResolvedText()!;
            var indexName = materialEntry.IsLocalInstance ? $"l_{materialEntry.Index}" : $"e_{materialEntry.Index}";

            if (materialDict.TryGetValue(indexName, out var oldValue))
            {
                if (oldValue != materialName)
                {
                    _loggerService.Warning($"Duplicated materialEntry \"{indexName}\" found (First name \"{oldValue}\"| Current name \"{materialName}\"). Skipping!");
                }
                
                continue;
            }

            // Normal materials
            if (!materialName.Contains('@'))
            {
                materialInstanceList[materialName] = materialEntry.IsLocalInstance;
                continue;
            }

            /*
             * dynamic materials. Jesus fuck.
             */

            var materialIndex = -1;

            // Remove the original, and create a copy for every placeholder material
            var localMaterial = cMesh.LocalMaterialBuffer.Materials!.ToList().ElementAtOrDefault(materialEntry.Index);
            var preloadLocalMaterial = cMesh.PreloadLocalMaterialInstances.ToList().ElementAtOrDefault(materialEntry.Index);

            CResourceAsyncReference<IMaterial>? externalMaterial = cMesh.ExternalMaterials.ElementAtOrDefault(materialEntry.Index);
            CResourceReference<IMaterial>? preloadExternalMaterial = cMesh.PreloadExternalMaterials.ElementAtOrDefault(materialEntry.Index);

            if (materialEntry.IsLocalInstance && localMaterial is not null && localMaterials.IndexOf(localMaterial) is var idx and >= 0)
            {
                materialIndex = idx;
            }
            else if (materialEntry.IsLocalInstance && preloadLocalMaterial is not null &&
                     preloadLocalMaterials.IndexOf(preloadLocalMaterial) is var preIdx and >= 0)
            {
                materialIndex = preIdx;
            }
            else if (!materialEntry.IsLocalInstance && externalMaterial is { } external &&
                     externalMaterials.IndexOf(external) is var extIdx and >= 0)
            {
                materialIndex = extIdx;
            }
            else if (!materialEntry.IsLocalInstance && preloadExternalMaterial is { } pExternal &&
                     preloadExternalMaterials.IndexOf(pExternal) is var pExtIdx and >= 0)
            {
                materialIndex = pExtIdx;
            }

            if (materialIndex < 0)
            {
                throw new Exception("hi");
            }

            if (materialEntry.IsLocalInstance)
            {
                if (preloadLocalMaterials.Count > materialIndex)
                {
                    preloadLocalMaterials.RemoveAt(materialIndex);
                }
                else if (localMaterials.Count > materialIndex)
                {
                    localMaterials.RemoveAt(materialIndex);
                }
            }
            else
            {
                if (preloadExternalMaterials.Count > materialIndex)
                {
                    preloadExternalMaterials.RemoveAt(materialIndex);
                }
                else if (externalMaterials.Count > materialIndex)
                {
                    externalMaterials.RemoveAt(materialIndex);
                }
            }

            // dynamic materials
            foreach (var dynamicMaterialName in dynamicChunks
                         .Where(name => name.GetResolvedText()?.EndsWith(materialName) == true)
                         .Select(dynamicName => dynamicName!.GetResolvedText()!))
            {
                materialInstanceList[dynamicMaterialName] = materialEntry.IsLocalInstance;
                if (materialEntry.IsLocalInstance)
                {
                    if (localMaterial is not null)
                    {
                        localMaterials.Insert(materialIndex, (IMaterial)localMaterial.DeepCopy());
                    }

                    if (preloadLocalMaterial is not null)
                    {
                        preloadLocalMaterials.Insert(materialIndex, (CHandle<IMaterial>)preloadLocalMaterial.DeepCopy());
                    }
                }
                else
                {
                    if (externalMaterial is { } notNull)
                    {
                        externalMaterials.Insert(materialIndex, notNull);
                    }

                    if (preloadExternalMaterial is { } preloadNotNull)
                    {
                        preloadExternalMaterials.Insert(materialIndex, preloadNotNull!);
                    }
                }
            }
        }

        // Now, put them into the correct list
        foreach (var (kvp, index) in materialInstanceList.Select((kvp, index) => (Value: kvp, Index: index)))
        {
            var indexName = kvp.Value ? $"l_{index}" : $"e_{index}";
            materialDict[indexName] = kvp.Key;
        }

        for (var i = 0; i < externalMaterials.Count; i++)
        {
            TryFindMaterial(mainFile, externalMaterials[i], out var result);

            var (mergedMaterial, template) =
                MergeMaterialChain(result.IsEmbedded ? mainFile : result.File!, (IMaterial)result.File!.RootChunk, materialDict[$"e_{i}"]);

            materialData.Materials.Add(mergedMaterial);
            materialData.MaterialTemplates.Add(template);
        }

        for (var i = 0; i < preloadExternalMaterials.Count; i++)
        {
            TryFindMaterial(mainFile, preloadExternalMaterials[i], out var result);

            var (mergedMaterial, template) =
                MergeMaterialChain(result.IsEmbedded ? mainFile : result.File!, (IMaterial)result.File!.RootChunk, materialDict[$"e_{i}"]);

            materialData.Materials.Add(mergedMaterial);
            materialData.MaterialTemplates.Add(template);
        }

        if (cMesh.LocalMaterialBuffer is { Materials: not null })
        {
            for (var i = 0; i < localMaterials.Count; i++)
            {
                var (mergedMaterial, template) = MergeMaterialChain(mainFile, localMaterials[i], materialDict[$"l_{i}"]);

                materialData.Materials.Add(mergedMaterial);
                materialData.MaterialTemplates.Add(template);
            }
        }

        // TODO: Is this ever used?
        for (var i = 0; i < cMesh.LocalMaterialInstances.Count; i++)
        {
            var (mergedMaterial, template) = MergeMaterialChain(mainFile, cMesh.LocalMaterialInstances[i].Chunk!, materialDict[$"l_{i}"]);

            materialData.Materials.Add(mergedMaterial);
            materialData.MaterialTemplates.Add(template);
        }

        for (var i = 0; i < preloadLocalMaterials.Count; i++)
        {
            var (mergedMaterial, template) = MergeMaterialChain(mainFile, preloadLocalMaterials[i].Chunk!, materialDict[$"l_{i}"]);

            materialData.Materials.Add(mergedMaterial);
            materialData.MaterialTemplates.Add(template);
        }

        return materialData;
    }


    private const string s_materialWildcard = "{material}";

    private (RawMaterial mergedMaterial, RawMaterial template) MergeMaterialChain(CR2WFile parentFile, IMaterial material,
        string dynamicMaterialName)
    {
        RawMaterial mergedMaterial = null!, template = null!;
        var materialName = dynamicMaterialName.Split('@').FirstOrDefault() ?? dynamicMaterialName;

        switch (material)
        {
            case CMaterialInstance cMaterialInstance:
            {
                // If material is empty, invalid, or if it's using a "none" material (for file validation), 
                // fall back to default material
                if (cMaterialInstance.BaseMaterial.DepotPath == ResourcePath.Empty)
                {
                    cMaterialInstance.BaseMaterial = new CResourceReference<IMaterial>(DefaultMaterials.DefaultMiPath);
                }
                // ArchiveXL dynamic material
                else if (cMaterialInstance.BaseMaterial.DepotPath.GetResolvedText() is string depotPath && depotPath.StartsWith('*'))
                {
                    // replace {material} with dynamic material name and cut off leading *
                    cMaterialInstance.BaseMaterial =
                        new CResourceReference<IMaterial>(depotPath.Replace(s_materialWildcard, materialName)[1..]);
                }
                
                var status = TryFindFile2(parentFile, cMaterialInstance.BaseMaterial, out var result);
                if (status is FindFileResult.NoCR2W or FindFileResult.FileNotFound || result.File!.RootChunk is not IMaterial childMaterial)
                {
                    // If there's anything wrong with the file, we're falling back to the default material 
                    (mergedMaterial, template) =
                        MergeMaterialChain(DefaultMaterials.DefaultMaterialTemplateFile, DefaultMaterials.DefaultMaterialInstance,
                            materialName);
                }
                else
                {
                    (mergedMaterial, template) = MergeMaterialChain(result.IsEmbedded ? parentFile : result.File, childMaterial,
                        materialName);
                }

                mergedMaterial.BaseMaterial = cMaterialInstance.BaseMaterial.DepotPath.GetResolvedText()!;
                mergedMaterial.EnableMask = (bool)template.EnableMask! && (bool)cMaterialInstance.EnableMask;
                mergedMaterial.Name = materialName;
                mergedMaterial.Data ??= [];

                foreach (var pair in cMaterialInstance.Values)
                {
                    var key = pair.Key.GetResolvedText()!;

                    if (pair.Value is not IRedRef resourceReference)
                    {
                        mergedMaterial.Data[key] = GetSerializableValue(pair.Value);
                        continue;
                    }

                    // could compare if it differs but meh
                    try
                    {
                        mergedMaterial.Data[key] = ExtractResource(resourceReference, materialName);
                    }
                    catch
                    {
                        // If we ran into an exception when parsing a key/value pair, fall back to default values
                        if (Enum.TryParse<MaterialResourcePathKey>(key, out var enumValue))
                        {
                            ExtractResource(DefaultMaterials.GetResourceReference(enumValue), "");
                            mergedMaterial.Data![key] = DefaultMaterials.FilePaths[enumValue];
                        }
                        else
                        {
                            mergedMaterial.Data![key] = "";
                        }
                    }
                    
                }

                return (mergedMaterial, template);
            }
            case CMaterialTemplate cMaterialTemplate:
            {
                var fileName = (parentFile.MetaData.FileName ?? string.Empty).ToLower().Replace("none", "");
                if (fileName == string.Empty)
                {
                    fileName = DefaultMaterials.DefaultMiPath;
                }

                mergedMaterial = new RawMaterial
                {
                    BaseMaterial = fileName, MaterialTemplate = fileName, Data = new Dictionary<string, object?>()
                };

                template = new RawMaterial
                {
                    Name = fileName,
                    Data = new Dictionary<string, object?>(),
                    EnableMask = cMaterialTemplate.CanBeMasked
                };

                var usedParameterNames = cMaterialTemplate.UsedParameters[2]
                    .Select(usedParameter => usedParameter.Name.GetResolvedText() ?? "INVALID_PARAMETER")
                    .ToList();

                foreach (var parameterHandle in cMaterialTemplate.Parameters[2].NotNull())
                {
                    var refer = parameterHandle.Chunk!;
                    var parameterName = refer.ParameterName.GetResolvedText()!;
                    if (usedParameterNames.Contains(parameterName))
                    {
                        object? value = GetMaterialParameterValue(refer);
                        try
                        {
                            if (value is IRedRef resourceReference)
                            {
                                value = ExtractResource(resourceReference, materialName);
                            }

                            if (value is IRedType redValue)
                            {
                                value = GetSerializableValue(redValue);
                            }

                            mergedMaterial.Data.Add(parameterName, value);
                            template.Data.Add(parameterName, value);
                        }
                        catch (Exception ex)
                        {
                            _loggerService.Warning(
                                $"Skipped extraction of material parameter {refer.ParameterName.GetResolvedText()}");
                            _loggerService.Warning($"\t{ex.Message}");
                        }
                    }
                }

                return (mergedMaterial, template);
            }
        }

        throw new Exception("???");

        string ExtractResource(IRedRef resourceReference, string dynamicMaterialName)
        {
            if (resourceReference.DepotPath == ResourcePath.Empty)
            {
                return "";
            }
            
            if (dynamicMaterialName is not "" && resourceReference.DepotPath.GetResolvedText() is string depotPath &&
                depotPath.StartsWith('*'))
            {
                resourceReference =
                    new CResourceAsyncReference<IMaterial>(depotPath.Replace(s_materialWildcard, dynamicMaterialName)[1..]);
            }
            
            var status = TryFindFile2(parentFile, resourceReference, out var result);
            if (status == FindFileResult.NoCR2W)
            {
                throw new Exception($"Error while parsing the file: {resourceReference.DepotPath.GetResolvedText()}");
            }
            if (status == FindFileResult.FileNotFound)
            {
                throw new Exception($"Error while finding the file: {resourceReference.DepotPath.GetResolvedText()}");
            }

            ArgumentNullException.ThrowIfNull(result.File);

            var relativePath = GetRelativePath();
            var fullPath = new FileInfo(Path.Combine(_materialRepositoryPath, relativePath));

            if (_modTools.IsUncooked(_materialRepositoryPath, fullPath.FullName, relativePath))
            {
                return relativePath;
            }

            var imports = result.File.Info.Imports;
            if (result.IsEmbedded)
            {
                imports = parentFile.Info.Imports;
            }

            switch (result.File.RootChunk)
            {
                case CBitmapTexture cBitmapTexture:
                    fullPath.Directory?.Create();
                    ExtractXBM(cBitmapTexture, fullPath.FullName);

                    _textureList.Add(relativePath);
                    break;
                case CCubeTexture cCubeTexture:
                    break;
                case CTextureArray cTextureArray:
                    break;
                case CFoliageProfile cFoliageProfile:
                    break;
                case CGradient:
                    fullPath.Directory?.Create();
                    ExtractToJson(result.File, imports, fullPath.FullName, false);

                    _textureList.Add(relativePath);
                    break;
                case CHairProfile:
                    fullPath.Directory?.Create();
                    ExtractToJson(result.File, imports, fullPath.FullName, false);
                    break;
                case Multilayer_Mask multilayerMask:
                    fullPath.Directory?.Create();
                    ExtractMultilayerMask(multilayerMask, fullPath.FullName);

                    _textureList.Add(relativePath);
                    break;
                case Multilayer_Setup:
                    fullPath.Directory?.Create();
                    ExtractToJson(result.File, imports, fullPath.FullName, true);
                    break;
                case Multilayer_LayerTemplate:
                    fullPath.Directory?.Create();
                    ExtractToJson(result.File, imports, fullPath.FullName, true);
                    break;
                case CSkinProfile cSkinProfile:
                    break;
                case CTerrainSetup cTerrainSetup:
                    break;
                default:
                    break;
            }

            return relativePath;

            string GetRelativePath()
            {
                if (result.IsEmbedded)
                {
                    var fileName = $"{FNV1A64HashAlgorithm.HashString(result.File.MetaData.FileName!)}.{FileTypeHelper.GetFileExtensions(result.File)[0]}";

                    return Path.Combine($"{parentFile.MetaData.FileName}_embedded", fileName);
                }
                else
                {
                    return result.File.MetaData.FileName!;
                }
            }
        }

        void ExtractXBM(CBitmapTexture cBitmapTexture, string destFileName)
        {
            _modTools.UncookXBM(cBitmapTexture, new FileInfo(destFileName), _globalExportArgs);
        }

        void ExtractMultilayerMask(Multilayer_Mask multilayerMask, string destFileName)
        {
            _modTools.UncookMlmask(multilayerMask, new FileInfo(destFileName), _globalExportArgs.Get<MlmaskExportArgs>());
        }

        void ExtractToJson(CR2WFile file, List<ICR2WImport> imports, string destFileName, bool extractImports)
        {
            destFileName += ".json";

            var dto = new RedFileDto(file);
            var doc = RedJsonSerializer.Serialize(dto);
            File.WriteAllText(destFileName, doc);

            foreach (var import in imports)
            {
                ExtractResource(new CResourceReference<CResource>(import.DepotPath, import.Flags), "");
            }
        }
    }

    private FindFileResult TryFindMaterial(CR2WFile parent, IRedRef resourceReference, out FindFileRecord result, bool excludeCustomArchives = false)
    {
        var status = TryFindFile2(parent, resourceReference, out result);
        if (status == FindFileResult.NoCR2W)
        {
            throw new Exception($"Error while parsing the file: {resourceReference.DepotPath.GetResolvedText()}");
        }
        if (status == FindFileResult.FileNotFound)
        {
            throw new Exception($"Error while finding the file: {resourceReference.DepotPath.GetResolvedText()}");
        }

        if (result.File!.RootChunk is not IMaterial childMaterial)
        {
            throw new Exception("???");
        }

        return status;
    }

    private FindFileResult TryFindFile2(CR2WFile parent, IRedRef resourceReference, out FindFileRecord result, bool excludeCustomArchives = false)
    {
        CR2WFile? tmp;

        if (resourceReference.Flags == InternalEnums.EImportFlags.Embedded)
        {
            if (parent == null)
            {
                throw new Exception("No CR2W file provided while looking for embedded files!");
            }

            var embeddedFile = parent.EmbeddedFiles.FirstOrDefault(x => x.FileName == resourceReference.DepotPath);
            if (embeddedFile == null)
            {
                result = new FindFileRecord(null, null, null);
                return FindFileResult.FileNotFound;
            }

            tmp = new CR2WFile
            {
                RootChunk = embeddedFile.Content,
                MetaData = new CR2WMetaData { FileName = embeddedFile.FileName }
            };

            result = new FindFileRecord(null, tmp, new List<IRedImport>(), true); // TODO[ModKit]: new List / parent.Imports?
            return FindFileResult.NoError;
        }

        var gameFile = _archiveManager.GetGameFile(resourceReference.DepotPath, true, !excludeCustomArchives);
        if (gameFile == null)
        {
            result = new FindFileRecord(null, null, null);
            return FindFileResult.FileNotFound;
        }

        using var ms = new MemoryStream();
        gameFile.Extract(ms);
        ms.Position = 0;

        using var reader = new CR2WReader(ms);
        reader.ParsingError += args => args is InvalidDefaultValueEventArgs;

        if (reader.ReadFile(out tmp) != EFileReadErrorCodes.NoError)
        {
            result = new FindFileRecord(null, null, null);
            return FindFileResult.NoCR2W;
        }

        tmp!.MetaData.FileName = resourceReference.DepotPath.GetResolvedText()!;

        result = new FindFileRecord((ICyberGameArchive?)gameFile.GetArchive(), tmp, reader.ImportsList);
        return FindFileResult.NoError;
    }

    private IRedType? GetMaterialParameterValue(CMaterialParameter materialParameter) =>
        materialParameter switch
        {
            CMaterialParameterColor col => col.Color,
            CMaterialParameterCpuNameU64 cpu => cpu.Name,
            CMaterialParameterCube cub => cub.Texture,
            CMaterialParameterFoliageParameters fol => fol.FoliageProfile,
            CMaterialParameterGradient gra => gra.Gradient,
            CMaterialParameterHairParameters hai => hai.HairProfile,
            CMaterialParameterMultilayerMask mulm => mulm.Mask,
            CMaterialParameterMultilayerSetup muls => muls.Setup,
            CMaterialParameterScalar sca => sca.Scalar,
            CMaterialParameterSkinParameters ski => ski.SkinProfile,
            CMaterialParameterStructBuffer str => null,
            CMaterialParameterTerrainSetup ter => ter.Setup,
            CMaterialParameterTexture tex => tex.Texture,
            CMaterialParameterTextureArray texa => texa.Texture,
            CMaterialParameterVector vec => vec.Vector,
            CMaterialParameterDynamicTexture dyn => dyn.Texture,
            _ => throw new NotImplementedException(materialParameter.GetType().Name)
        };

    private object? GetSerializableValue(CMaterialParameter materialParameter) =>
        materialParameter switch
        {
            CMaterialParameterColor col => GetSerializableValue(col.Color),
            CMaterialParameterCpuNameU64 cpu => GetSerializableValue(cpu.Name),
            CMaterialParameterCube cub => GetSerializableValue(cub.Texture),
            CMaterialParameterFoliageParameters fol => GetSerializableValue(fol.FoliageProfile),
            CMaterialParameterGradient gra => GetSerializableValue(gra.Gradient),
            CMaterialParameterHairParameters hai => GetSerializableValue(hai.HairProfile),
            CMaterialParameterMultilayerMask mulm => GetSerializableValue(mulm.Mask),
            CMaterialParameterMultilayerSetup muls => GetSerializableValue(muls.Setup),
            CMaterialParameterScalar sca => GetSerializableValue(sca.Scalar),
            CMaterialParameterSkinParameters ski => GetSerializableValue(ski.SkinProfile),
            CMaterialParameterStructBuffer str => null,
            CMaterialParameterTerrainSetup ter => GetSerializableValue(ter.Setup),
            CMaterialParameterTexture tex => GetSerializableValue(tex.Texture),
            CMaterialParameterTextureArray texa => GetSerializableValue(texa.Texture),
            CMaterialParameterVector vec => GetSerializableValue(vec.Vector),
            CMaterialParameterDynamicTexture dyn => GetSerializableValue(dyn.Texture),
            _ => throw new NotImplementedException(materialParameter.GetType().Name)
        };

    private object GetSerializableValue(IRedType value) =>
        value switch
        {
            CColor col => new Dictionary<string, byte>
            {
                { nameof(col.Red), col.Red },
                { nameof(col.Green), col.Green },
                { nameof(col.Blue), col.Blue },
                { nameof(col.Alpha), col.Alpha },
            },
            CName cName => cName,
            CFloat cFloat => cFloat,
            Vector4 vec => new Dictionary<string, float>
            {
                { nameof(vec.X), vec.X },
                { nameof(vec.Y), vec.Y },
                { nameof(vec.Z), vec.Z },
                { nameof(vec.W), vec.W },
            },
            IRedResourceReference rRef when rRef.DepotPath == ResourcePath.Empty => "",
            IRedResourceReference { DepotPath.IsResolvable: true } rRef => rRef.DepotPath.GetResolvedText()!,
            IRedResourceReference rRef => rRef.DepotPath,
            _ => throw new NotImplementedException(value.GetType().Name)
        };
}