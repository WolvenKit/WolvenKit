using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;
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

    private readonly List<string> _textureList = new();

    public MaterialExtractor(ModTools modTools, IArchiveManager archiveManager, string materialRepositoryPath, GlobalExportArgs globalExportArgs)
    {
        _modTools = modTools;
        _archiveManager = archiveManager;
        _materialRepositoryPath = materialRepositoryPath;
        _globalExportArgs = globalExportArgs;
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

        var materialDict = new Dictionary<string, string>();

        foreach (var materialEntry in cMesh.MaterialEntries)
        {
            materialDict.Add(materialEntry.IsLocalInstance ? $"l_{materialEntry.Index}" : $"e_{materialEntry.Index}", materialEntry.Name.GetResolvedText()!);
        }

        for (var i = 0; i < cMesh.ExternalMaterials.Count; i++)
        {
            TryFindMaterial(mainFile, cMesh.ExternalMaterials[i], out var result);

            var (mergedMaterial, template) = MergeMaterialChain(result.IsEmbedded ? mainFile : result.File!, (IMaterial)result.File!.RootChunk);

            mergedMaterial.Name = materialDict[$"e_{i}"];

            materialData.Materials.Add(mergedMaterial);
            materialData.MaterialTemplates.Add(template);
        }

        for (var i = 0; i < cMesh.PreloadExternalMaterials.Count; i++)
        {
            TryFindMaterial(mainFile, cMesh.PreloadExternalMaterials[i], out var result);

            var (mergedMaterial, template) = MergeMaterialChain(result.IsEmbedded ? mainFile : result.File!, (IMaterial)result.File!.RootChunk);

            mergedMaterial.Name = materialDict[$"e_{i}"];

            materialData.Materials.Add(mergedMaterial);
            materialData.MaterialTemplates.Add(template);
        }

        if (cMesh.LocalMaterialBuffer is { Materials: not null })
        {
            for (var i = 0; i < cMesh.LocalMaterialBuffer.Materials.Count; i++)
            {
                var (mergedMaterial, template) = MergeMaterialChain(mainFile, cMesh.LocalMaterialBuffer.Materials[i]);

                mergedMaterial.Name = materialDict[$"l_{i}"];

                materialData.Materials.Add(mergedMaterial);
                materialData.MaterialTemplates.Add(template);
            }
        }

        for (var i = 0; i < cMesh.LocalMaterialInstances.Count; i++)
        {
            var (mergedMaterial, template) = MergeMaterialChain(mainFile, cMesh.LocalMaterialInstances[i].Chunk!);

            mergedMaterial.Name = materialDict[$"l_{i}"];

            materialData.Materials.Add(mergedMaterial);
            materialData.MaterialTemplates.Add(template);
        }

        for (var i = 0; i < cMesh.PreloadLocalMaterialInstances.Count; i++)
        {
            var (mergedMaterial, template) = MergeMaterialChain(mainFile, cMesh.PreloadLocalMaterialInstances[i].Chunk!);

            mergedMaterial.Name = materialDict[$"l_{i}"];

            materialData.Materials.Add(mergedMaterial);
            materialData.MaterialTemplates.Add(template);
        }

        return materialData;
    }

    private (RawMaterial mergedMaterial, RawMaterial template) MergeMaterialChain(CR2WFile parentFile, IMaterial material)
    {
        RawMaterial mergedMaterial = null!, template = null!;

        if (material is CMaterialInstance cMaterialInstance)
        {
            if (cMaterialInstance.BaseMaterial.DepotPath != ResourcePath.Empty)
            {
                var status = TryFindFile2(parentFile, cMaterialInstance.BaseMaterial, out var result);
                if (status == FindFileResult.NoCR2W)
                {
                    throw new Exception($"Error while parsing the file: {cMaterialInstance.BaseMaterial.DepotPath.GetResolvedText()}");
                }
                if (status == FindFileResult.FileNotFound)
                {
                    throw new Exception($"Error while finding the file: {cMaterialInstance.BaseMaterial.DepotPath.GetResolvedText()}");
                }

                if (result.File!.RootChunk is not IMaterial childMaterial)
                {
                    throw new Exception("???");
                }

                (mergedMaterial, template) = MergeMaterialChain(result.File, childMaterial);
            }

            mergedMaterial.BaseMaterial = cMaterialInstance.BaseMaterial.DepotPath.GetResolvedText()!;
            mergedMaterial.EnableMask = (bool)template.EnableMask! && (bool)cMaterialInstance.EnableMask;

            foreach (var pair in cMaterialInstance.Values)
            {
                // could compare if it differs but meh
                if (pair.Value is IRedRef resourceReference && resourceReference.DepotPath != ResourcePath.Empty)
                {
                    mergedMaterial.Data![pair.Key.GetResolvedText()!] = ExtractResource(resourceReference);
                }
                else
                {
                    mergedMaterial.Data![pair.Key.GetResolvedText()!] = GetSerializableValue(pair.Value);
                }
            }

            return (mergedMaterial, template);
        }

        if (material is CMaterialTemplate cMaterialTemplate)
        {
            mergedMaterial = new RawMaterial
            {
                BaseMaterial = parentFile.MetaData.FileName,
                MaterialTemplate = parentFile.MetaData.FileName,
                Data = new Dictionary<string, object?>()
            };

            template = new RawMaterial
            {
                Name = parentFile.MetaData.FileName,
                Data = new Dictionary<string, object?>(),
                EnableMask = cMaterialTemplate.CanBeMasked
            };

            var usedParameterNames = new List<string>();
            foreach (var usedParameter in cMaterialTemplate.UsedParameters[2])
            {
                usedParameterNames.Add(usedParameter.Name.GetResolvedText()!);
            }

            foreach (var parameterHandle in cMaterialTemplate.Parameters[2].NotNull())
            {
                var refer = parameterHandle.Chunk!;
                if (usedParameterNames.Contains(refer.ParameterName.GetResolvedText()!))
                {
                    object? value = GetMaterialParameterValue(refer);

                    if (value is IRedRef resourceReference && resourceReference.DepotPath != ResourcePath.Empty)
                    {
                        value = ExtractResource(resourceReference);
                    }

                    if (value is IRedType redValue)
                    {
                        value = GetSerializableValue(redValue);
                    }

                    mergedMaterial.Data.Add(refer.ParameterName.GetResolvedText()!, value);
                    template.Data.Add(refer.ParameterName.GetResolvedText()!, value);
                }
            }

            return (mergedMaterial, template);
        }

        throw new Exception("???");

        string ExtractResource(IRedRef resourceReference)
        {
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
                ExtractResource(new CResourceReference<CResource>(import.DepotPath, import.Flags));
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
            IRedResourceReference { DepotPath.IsResolvable: true } rRef => rRef.DepotPath.GetResolvedText()!,
            IRedResourceReference rRef => rRef.DepotPath,
            _ => throw new NotImplementedException(value.GetType().Name)
        };
}