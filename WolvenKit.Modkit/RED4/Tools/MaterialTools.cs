using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using WolvenKit.Common;
using WolvenKit.Core.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public partial class ModTools
    {
        private MatData SetupMaterial(CR2WFile cr2w, string matRepo, MeshesInfo info, EUncookExtension eUncookExtension = EUncookExtension.dds, bool experimentUseNewMeshExporter = false)
        {
            var exportArgs =
                new GlobalExportArgs().Register(
                    new XbmExportArgs() { UncookExtension = eUncookExtension },
                    new MlmaskExportArgs() { UncookExtension = eUncookExtension }
                );

            var matData = new MaterialExtractor(this, _archiveManager, matRepo, exportArgs).GenerateMaterialData(cr2w);
            matData.Appearances = info.appearances;

            return matData;
        }

        private void SaveMaterials(FileInfo outfile, List<MatData> mats)
        {
            var consMatData = new MatData(mats[0].MaterialRepo, new List<RawMaterial>(), new List<string>(), new List<RawMaterial>(), new());

            foreach (var matData in mats)
            {
                matData.Materials.ForEach(m => consMatData.Materials.Add(m));
                matData.TexturesList.ForEach(m => consMatData.TexturesList.Add(m));
                matData.MaterialTemplates.ForEach(m => consMatData.MaterialTemplates.Add(m));
                foreach (var app in matData.Appearances)
                {
                    consMatData.Appearances.TryAdd(app.Key, app.Value);
                }
            }

            var str = RedJsonSerializer.Serialize(consMatData);

            File.WriteAllText(Path.ChangeExtension(outfile.FullName, ".Material.json"), str);

        }

        private void ParseMaterials(CR2WFile cr2w, FileInfo outfile, string matRepo, MeshesInfo info, EUncookExtension eUncookExtension = EUncookExtension.dds)
        {
            var matData = SetupMaterial(cr2w, matRepo, info, eUncookExtension);
            var str = RedJsonSerializer.Serialize(matData);
            File.WriteAllText(Path.ChangeExtension(outfile.FullName, ".Material.json"), str);
        }

        private IRedType? GetMaterialParameterValue(Type materialParameterType, object? obj)
        {
            if (materialParameterType == typeof(CMaterialParameterColor))
            {
                if (obj is not JsonElement value)
                {
                    return null;
                }

                var dict = value.Deserialize<Dictionary<string, byte>>().NotNull();

                return new CColor
                {
                    Red = dict["Red"],
                    Green = dict["Green"],
                    Blue = dict["Blue"],
                    Alpha = dict["Alpha"],
                };
            }

            if (materialParameterType == typeof(CMaterialParameterCpuNameU64))
            {
                if (obj is not JsonElement value)
                {
                    return RedTypeManager.CreateRedType(typeof(CName));
                }

                switch (value.ValueKind)
                {
                    case JsonValueKind.String:
                        return (CName)value.GetString().NotNull();
                    case JsonValueKind.Number:
                        return (CName)value.GetUInt64();
                    case JsonValueKind.Object:
                        if (value.GetProperty("$storage").GetString() == "string")
                        {
                            return (CName)value.GetProperty("$value").GetString()!;
                        }
                        else if (value.GetProperty("$storage").GetString() == "uint64")
                        {
                            return (CName)ulong.Parse(value.GetProperty("$value").GetString()!);
                        }
                        throw new NotSupportedException($"Invalid storage type: {value.GetProperty("$storage")}");
                    case JsonValueKind.Undefined:
                    case JsonValueKind.Array:
                    case JsonValueKind.True:
                    case JsonValueKind.False:
                    case JsonValueKind.Null:
                    default:
                        throw new NotSupportedException($"Invalid element type: {value.ValueKind}");
                }
            }

            if (materialParameterType == typeof(CMaterialParameterCube))
            {
                return ReadPath<ITexture>();
            }

            if (materialParameterType == typeof(CMaterialParameterFoliageParameters))
            {
                return ReadPath<CFoliageProfile>();
            }

            if (materialParameterType == typeof(CMaterialParameterGradient))
            {
                return ReadPath<CGradient>();
            }

            if (materialParameterType == typeof(CMaterialParameterHairParameters))
            {
                return ReadPath<CHairProfile>();
            }

            if (materialParameterType == typeof(CMaterialParameterMultilayerMask))
            {
                return ReadPath<Multilayer_Mask>();
            }

            if (materialParameterType == typeof(CMaterialParameterMultilayerSetup))
            {
                return ReadPath<Multilayer_Setup>();
            }

            if (materialParameterType == typeof(CMaterialParameterScalar))
            {
                if (obj is not JsonElement value)
                {
                    return RedTypeManager.CreateRedType(typeof(CFloat));
                }

                return (CFloat)value.GetSingle();
            }

            if (materialParameterType == typeof(CMaterialParameterSkinParameters))
            {
                return ReadPath<CSkinProfile>();
            }

            if (materialParameterType == typeof(CMaterialParameterStructBuffer))
            {
                // TODO: What is this for?
                return null;
            }

            if (materialParameterType == typeof(CMaterialParameterTerrainSetup))
            {
                return ReadPath<CTerrainSetup>();
            }

            if (materialParameterType == typeof(CMaterialParameterTexture))
            {
                return ReadPath<ITexture>();
            }

            if (materialParameterType == typeof(CMaterialParameterTextureArray))
            {
                return ReadPath<ITexture>();
            }

            if (materialParameterType == typeof(CMaterialParameterVector))
            {
                if (obj is not JsonElement value)
                {
                    return null;
                }

                var dict = value.Deserialize<Dictionary<string, float>>().NotNull();

                return new Vector4
                {
                    X = dict["X"],
                    Y = dict["Y"],
                    Z = dict["Z"],
                    W = dict["W"]
                };
            }

            if (materialParameterType == typeof(CMaterialParameterDynamicTexture))
            {
                return ReadPath<ITexture>();
            }

            throw new NotImplementedException(materialParameterType.Name);

            CResourceReference<T> ReadPath<T>() where T : CResource
            {
                if (obj is not JsonElement value)
                {
                    throw new NotSupportedException();
                }

                switch (value.ValueKind)
                {
                    case JsonValueKind.String:
                        return new CResourceReference<T>(value.GetString().NotNull());
                    case JsonValueKind.Number:
                        return new CResourceReference<T>(value.GetUInt64());
                    case JsonValueKind.Object:
                        if (value.GetProperty("$storage").GetString() == "string")
                        {
                            return new CResourceReference<T>(value.GetProperty("$value").GetString()!);
                        }
                        else if (value.GetProperty("$storage").GetString() == "uint64")
                        {
                            return new CResourceReference<T>(ulong.Parse(value.GetProperty("$value").GetString()!));
                        }
                        throw new NotSupportedException($"Invalid storage type: {value.GetProperty("$storage")}");
                    case JsonValueKind.Undefined:
                    case JsonValueKind.Array:
                    case JsonValueKind.True:
                    case JsonValueKind.False:
                    case JsonValueKind.Null:
                    default:
                        throw new NotSupportedException($"Invalid element type: {value.ValueKind}");
                }
            }
        }

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

        private CR2WFile LoadFile(string path)
        {
            var hash = FNV1A64HashAlgorithm.HashString(path);

            var status = TryFindFile(hash, out var result);
            switch (status)
            {
                case FindFileResult.NoError:
                    return result.File!;
                case FindFileResult.FileNotFound:
                    throw new FileNotFoundException(path);
                case FindFileResult.NoCR2W:
                    throw new Exception("Invalid CR2W file");
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private (string? materialTemplate, Dictionary<string, object?> valueDict, bool enableMask) GetMaterialChain(CMaterialInstance cMaterialInstance, ref Dictionary<string, CMaterialTemplate> mts)
        {
            var resultDict = new Dictionary<string, object?>();

            var baseMaterials = new List<CMaterialInstance>();

            var path = cMaterialInstance.BaseMaterial.DepotPath;
            if (path == ResourcePath.Empty)
            {
                return (null, resultDict, cMaterialInstance.EnableMask);
            }

            while (!Path.GetExtension(path).Contains("mt"))
            {
                if (path == ResourcePath.Empty)
                {
                    return (null, resultDict, cMaterialInstance.EnableMask);
                }

                var file = LoadFile(path.ToString().NotNull());
                if (file.RootChunk is not CMaterialInstance mi)
                {
                    throw new Exception("Invalid .mi file");
                }

                baseMaterials.Add(mi);
                path = mi.BaseMaterial.DepotPath;
            }
            baseMaterials.Reverse();

            var spath = path.ToString().NotNull();
            CMaterialTemplate mt;
            if (mts.TryGetValue(spath, out var mt1))
            {
                mt = mt1;
            }
            else
            {
                var file = LoadFile(spath);
                mt = (CMaterialTemplate)file.RootChunk;
                mts.Add(spath, mt);
            }

            foreach (var usedParameter in mt.UsedParameters[2].NotNull())
            {
                foreach (var parameterHandle in mt.Parameters[2].NotNull())
                {
                    var refer = parameterHandle.NotNull().Chunk.NotNull();
                    if (refer.ParameterName == usedParameter.NotNull().Name)
                    {
                        resultDict.Add(refer.ParameterName.ToString().NotNull(), GetMaterialParameterValue(refer));
                    }
                }
            }

            baseMaterials.Add(cMaterialInstance);
            foreach (var kvp in baseMaterials.SelectMany(mi => mi.Values))
            {
                ArgumentNullException.ThrowIfNull(kvp);
                object? value = null;
                foreach (var handle in mt.Parameters[2].NotNull())
                {
                    if (Equals(handle.NotNull().Chunk.NotNull().ParameterName, kvp.NotNull().Key))
                    {
                        value = kvp.Value;
                    }
                }

                value ??= new MaterialValueWrapper { Type = kvp.Value.RedType, Value = kvp.Value };

                if (resultDict.ContainsKey(kvp.Key.ToString().NotNull()))
                {
                    resultDict[kvp.Key.ToString().NotNull()] = value;
                }
                else
                {
                    resultDict.Add(kvp.Key.ToString().NotNull(), value);
                }
            }

            return (path, resultDict, mt.CanBeMasked && cMaterialInstance.EnableMask);
        }

        private RawMaterial ContainRawMaterial(CMaterialInstance cMaterialInstance, string name, ref Dictionary<string, CMaterialTemplate> mts)
        {
            var (materialTemplatePath, valueDict, enableMask) = GetMaterialChain(cMaterialInstance, ref mts);
            if (materialTemplatePath == null)
            {
                _loggerService.Warning($"Missing path in \"{name}\"");
            }

            var rawMaterial = new RawMaterial
            {
                Name = name,
                BaseMaterial = cMaterialInstance.BaseMaterial.DepotPath,
                MaterialTemplate = materialTemplatePath,
                EnableMask = enableMask,
                Data = new Dictionary<string, object?>()
            };

            foreach (var pair in valueDict)
            {
                var value = pair.Value;
                if (value is IRedType redValue)
                {
                    value = GetSerializableValue(redValue);
                }

                rawMaterial.Data.Add(pair.Key, value);
            }

            return rawMaterial;
        }

        private static MemoryStream GetMaterialStream(Stream ms, CR2WFile cr2w)
        {
            var blob = (CMesh)cr2w.RootChunk;

            var b = blob.LocalMaterialBuffer.RawData.Buffer;

            return new MemoryStream(b.GetBytes());
        }

        private static Dictionary<string, CMaterialTemplate> GetEmbeddedMaterialTemplates(ref CR2WFile cr2w)
        {
            var materialTemplates = new Dictionary<string, CMaterialTemplate>();
            foreach (var file in cr2w.EmbeddedFiles)
            {
                if (Path.GetExtension(file.FileName).Contains("mt"))
                {
                    if (file.Content is CMaterialTemplate mt)
                    {
                        materialTemplates.Add(file.FileName.GetResolvedText()!, mt);
                    }
                }
            }

            return materialTemplates;
        }

        public bool WriteMatToMesh(ref CR2WFile cr2w, string _matData)
        {
            if (cr2w.RootChunk is not CMesh { RenderResourceBlob.Chunk: rendRenderMeshBlob } cMesh)
            {
                return false;
            }

            var matData = RedJsonSerializer.Deserialize<MatData>(_matData).NotNull();

            ArgumentNullException.ThrowIfNull(matData.Materials);

            if (matData.Materials.Count < 1)
            {
                return false;
            }

            var blob = cMesh;
            blob.MaterialEntries.Clear();
            blob.LocalMaterialBuffer = new meshMeshMaterialBuffer
            {
                Materials = new CArray<IMaterial>()
            };
            blob.PreloadLocalMaterialInstances.Clear();
            blob.PreloadExternalMaterials.Clear();
            blob.ExternalMaterials.Clear();
            blob.LocalMaterialInstances.Clear();

            var mts = new Dictionary<string, CMaterialTemplate>();
            for (var i = 0; i < matData.Materials.Count; i++)
            {
                var mat = matData.Materials[i];

                ArgumentNullException.ThrowIfNull(mat.Name);
                ArgumentNullException.ThrowIfNull(mat.MaterialTemplate);

                blob.MaterialEntries.Add(new CMeshMaterialEntry
                {
                    IsLocalInstance = true,
                    Name = mat.Name,
                    Index = (ushort)i
                });

                var chunk = new CMaterialInstance
                {
                    CookingPlatform = Enums.ECookingPlatform.PLATFORM_PC,
                    EnableMask = mat.EnableMask!.Value,
                    ResourceVersion = 4,
                    BaseMaterial = new CResourceReference<IMaterial>(mat.BaseMaterial.NotNull()),
                    Values = new CArray<CKeyValuePair>()
                };

                CMaterialTemplate? mt = null;
                if (mts.TryGetValue(mat.MaterialTemplate, out var mt1))
                {
                    mt = mt1;
                }
                else
                {
                    var hash = FNV1A64HashAlgorithm.HashString(mat.MaterialTemplate);
                    if (TryFindFile(hash, out var result) == FindFileResult.NoError && result.File!.RootChunk is CMaterialTemplate _mt)
                    {
                        mt = _mt;
                        mts.Add(mat.MaterialTemplate, mt);
                    }
                }

                var fakeMaterialInstance = new CMaterialInstance()
                {
                    BaseMaterial = new CResourceReference<IMaterial>(mat.BaseMaterial),
                    Values = new CArray<CKeyValuePair>()
                };
                var (materialTemplate, valueDict, enableMask) = GetMaterialChain(fakeMaterialInstance, ref mts);

                if (mt != null)
                {
                    var list = matData.Materials[i].Data;
                    if (list is not null)
                    {
                        foreach (var (key, value) in list)
                        {
                            var found = false;
                            var param = mt.Parameters[2].NotNull();
                            foreach (var matParam in param)
                            {
                                var refer = matParam.NotNull().Chunk.NotNull();

                                if (refer.ParameterName == key)
                                {
                                    found = true;

                                    var convValue = GetMaterialParameterValue(refer.GetType(), value);
                                    if (valueDict.ContainsKey(refer.ParameterName.ToString().NotNull()) && !Equals(valueDict[refer.ParameterName.ToString().NotNull()], convValue))
                                    {
                                        chunk.Values.Add(new CKeyValuePair(refer.ParameterName.ToString().NotNull(), convValue.NotNull()));
                                    }
                                }
                            }

                            if (!found && value != null)
                            {
                                var wrapper = ((JsonElement)value).Deserialize<MaterialValueWrapper>().NotNull();
                                var (type, _) = RedReflection.GetCSTypeFromRedType(wrapper.Type.NotNull());

                                if (wrapper.Value is JsonElement e)
                                {
                                    var nValue = RedJsonSerializer.Deserialize(type, e);
                                    if (nValue is IRedType rt)
                                    {
                                        chunk.Values.Add(new CKeyValuePair(key, rt));
                                    }
                                    else
                                    {
                                        throw new ArgumentException();
                                    }
                                }
                            }
                        }
                    }
                }

                blob.LocalMaterialBuffer.Materials.Add(chunk);
            }

            return true;
        }
    }
}
