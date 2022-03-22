using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.Modkit.RED4
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public partial class ModTools
    {
        public bool ExportMeshWithMaterials(Stream meshStream, FileInfo outfile, List<Archive> archives, string matRepo, EUncookExtension eUncookExtension = EUncookExtension.dds, bool isGLBinary = true, bool LodFilter = true)
        {
            if (matRepo == null)
            {
                throw new Exception("Depot path is not set: Choose a Depot location within Settings for generating materials.");
            }

            var cr2w = _wolvenkitFileService.ReadRed4File(meshStream);
            if (cr2w == null || cr2w.RootChunk is not CMesh cMesh || cMesh.RenderResourceBlob.Chunk is not rendRenderMeshBlob rendblob)
            {
                return false;
            }

            using var ms = new MemoryStream(rendblob.RenderBuffer.Buffer.GetBytes());

            var meshesinfo = MeshTools.GetMeshesinfo(rendblob, cr2w.RootChunk as CMesh);

            var expMeshes = MeshTools.ContainRawMesh(ms, meshesinfo, LodFilter);
            MeshTools.UpdateSkinningParamCloth(ref expMeshes, meshStream, cr2w);

            var Rig = MeshTools.GetOrphanRig(cMesh);

            var model = MeshTools.RawMeshesToGLTF(expMeshes, Rig);

            ParseMaterials(cr2w, meshStream, outfile, archives, matRepo, eUncookExtension);

            if (isGLBinary)
            {
                model.SaveGLB(outfile.FullName);
            }
            else
            {
                model.SaveGLTF(outfile.FullName);
            }

            meshStream.Dispose();
            meshStream.Close();

            return true;
        }
        private void GetMateriaEntries(CR2WFile cr2w, Stream meshStream, ref List<string> primaryDependencies, ref List<string> materialEntryNames, ref List<CMaterialInstance> materialEntries, List<Archive> archives)
        {
            var cmesh = cr2w.RootChunk as CMesh;

            var ExternalMaterial = new List<CMaterialInstance>();

            for (var i = 0; i < cmesh.ExternalMaterials.Count; i++)
            {
                string path = cmesh.ExternalMaterials[i].DepotPath;

                var hash = FNV1A64HashAlgorithm.HashString(path);
                foreach (var ar in archives)
                {
                    if (ar.Files.ContainsKey(hash))
                    {
                        var ms = new MemoryStream();
                        ExtractSingleToStream(ar, hash, ms);
                        ms.Seek(0, SeekOrigin.Begin);

                        var isResource = _wolvenkitFileService.IsCR2WFile(ms);
                        if (!isResource)
                        {
                            throw new InvalidParsingException("not a cr2w file");
                        }

                        using var reader = new CR2WReader(ms);
                        _ = reader.ReadFile(out var mi, false);

                        ExternalMaterial.Add(mi.RootChunk as CMaterialInstance);

                        foreach (var import in reader.ImportsList)
                        {
                            if (!primaryDependencies.Contains(import.DepotPath))
                            {
                                primaryDependencies.Add(import.DepotPath);
                            }
                        }

                        break;
                    }
                }
            }
            for (var i = 0; i < cmesh.PreloadExternalMaterials.Count; i++)
            {
                string path = cmesh.PreloadExternalMaterials[i].DepotPath;

                var hash = FNV1A64HashAlgorithm.HashString(path);
                foreach (var ar in archives)
                {
                    if (ar.Files.ContainsKey(hash))
                    {
                        var ms = new MemoryStream();
                        ExtractSingleToStream(ar, hash, ms);
                        ms.Seek(0, SeekOrigin.Begin);

                        var isResource = _wolvenkitFileService.IsCR2WFile(ms);
                        if (!isResource)
                        {
                            throw new InvalidParsingException("not a cr2w file");
                        }

                        using var reader = new CR2WReader(ms);
                        _ = reader.ReadFile(out var mi, false);

                        ExternalMaterial.Add(mi.RootChunk as CMaterialInstance);

                        foreach (var import in reader.ImportsList)
                        {
                            if (!primaryDependencies.Contains(import.DepotPath))
                            {
                                primaryDependencies.Add(import.DepotPath);
                            }
                        }

                        break;
                    }
                }
            }

            var LocalMaterial = new List<CMaterialInstance>();

            if (cmesh.LocalMaterialBuffer.RawDataHeaders.Count != 0)
            {
                var materialStream = GetMaterialStream(meshStream, cr2w);
                var bytes = materialStream.ToArray();
                for (var i = 0; i < cmesh.LocalMaterialBuffer.RawDataHeaders.Count; i++)
                {
                    uint offset = cmesh.LocalMaterialBuffer.RawDataHeaders[i].Offset;
                    uint size = cmesh.LocalMaterialBuffer.RawDataHeaders[i].Size;

                    var ms = new MemoryStream(bytes, (int)offset, (int)size);

                    var isResource = _wolvenkitFileService.IsCR2WFile(ms);
                    if (!isResource)
                    {
                        throw new InvalidParsingException("not a cr2w file");
                    }

                    using var reader = new CR2WReader(ms);
                    _ = reader.ReadFile(out var mi, false);

                    //MemoryStream ms = new MemoryStream(bytes, (int)offset, (int)size);
                    //var mi = _wolvenkitFileService.ReadRed4File(ms);

                    foreach (var import in reader.ImportsList)
                    {
                        if (!primaryDependencies.Contains(import.DepotPath))
                        {
                            primaryDependencies.Add(import.DepotPath);
                        }
                    }

                    LocalMaterial.Add(mi.RootChunk as CMaterialInstance);
                }
            }
            else
            {


                foreach (var handle in cmesh.PreloadLocalMaterialInstances)
                {
                    if (handle.Chunk is CMaterialInstance mi1)
                    {
                        LocalMaterial.Add(mi1);
                    }
                }

                foreach (var import in cr2w.Info.GetImports())
                {
                    if (!primaryDependencies.Contains(import))
                    {
                        primaryDependencies.Add(import);
                    }
                }
            }

            var Count = cmesh.MaterialEntries.Count;
            for (var i = 0; i < Count; i++)
            {
                var Entry = cmesh.MaterialEntries[i];
                materialEntryNames.Add(Entry.Name);
                if (Entry.IsLocalInstance)
                {
                    materialEntries.Add(LocalMaterial[Entry.Index]);
                }
                else
                {
                    materialEntries.Add(ExternalMaterial[Entry.Index]);
                }
            }
            foreach (var m in materialEntries)
            {
                string path = m.BaseMaterial.DepotPath;
                while (!Path.GetExtension(path).Contains("mt"))
                {
                    var hash = FNV1A64HashAlgorithm.HashString(path);
                    foreach (var ar in archives)
                    {
                        if (ar.Files.ContainsKey(hash))
                        {
                            var ms = new MemoryStream();
                            ExtractSingleToStream(ar, hash, ms);
                            ms.Seek(0, SeekOrigin.Begin);

                            var isResource = _wolvenkitFileService.IsCR2WFile(ms);
                            if (!isResource)
                            {
                                throw new InvalidParsingException("not a cr2w file");
                            }

                            using var reader = new CR2WReader(ms);
                            _ = reader.ReadFile(out var mi, false);

                            path = (mi.RootChunk as CMaterialInstance).BaseMaterial.DepotPath;

                            foreach (var import in reader.ImportsList)
                            {
                                if (!primaryDependencies.Contains(import.DepotPath))
                                {
                                    primaryDependencies.Add(import.DepotPath);
                                }
                            }
                            break;
                        }
                    }
                }
                var mt = FNV1A64HashAlgorithm.HashString(path);
                foreach (var ar in archives)
                {
                    if (ar.Files.ContainsKey(mt))
                    {
                        var ms = new MemoryStream();
                        ExtractSingleToStream(ar, mt, ms);
                        ms.Seek(0, SeekOrigin.Begin);

                        var isResource = _wolvenkitFileService.IsCR2WFile(ms);
                        if (!isResource)
                        {
                            throw new InvalidParsingException("not a cr2w file");
                        }
                        using var reader = new CR2WReader(ms);
                        _ = reader.ReadFile(out var mi, false);


                        foreach (var import in reader.ImportsList)
                        {
                            if (!primaryDependencies.Contains(import.DepotPath))
                            {
                                primaryDependencies.Add(import.DepotPath);
                            }
                        }
                        break;
                    }
                }
            }
        }
        private void ParseMaterials(CR2WFile cr2w, Stream meshStream, FileInfo outfile, List<Archive> archives, string matRepo, EUncookExtension eUncookExtension = EUncookExtension.dds)
        {
            var primaryDependencies = new List<string>();

            var materialEntryNames = new List<string>();
            var materialEntries = new List<CMaterialInstance>();

            GetMateriaEntries(cr2w, meshStream, ref primaryDependencies, ref materialEntryNames, ref materialEntries, archives);

            var mlSetupNames = new List<string>();

            var mlTemplateNames = new List<string>();

            var HairProfileNames = new List<string>();

            var TexturesList = new List<string>();

            var exportArgs =
                new GlobalExportArgs().Register(
                    new XbmExportArgs() { UncookExtension = eUncookExtension },
                    new MlmaskExportArgs() { UncookExtension = eUncookExtension.ToMlmaskUncookExtension() }
                );

            for (var i = 0; i < primaryDependencies.Count; i++)
            {

                if (Path.GetExtension(primaryDependencies[i]) == ".xbm")
                {
                    if (!TexturesList.Contains(primaryDependencies[i]))
                    {
                        TexturesList.Add(primaryDependencies[i]);
                    }

                    var hash = FNV1A64HashAlgorithm.HashString(primaryDependencies[i]);
                    foreach (var ar in archives)
                    {
                        if (ar.Files.ContainsKey(hash))
                        {
                            if (!File.Exists(Path.Combine(matRepo, Path.ChangeExtension(primaryDependencies[i], "." + exportArgs.Get<XbmExportArgs>().UncookExtension.ToString()))))
                            {
                                if (Directory.Exists(matRepo))
                                {
                                    UncookSingle(ar, hash, new DirectoryInfo(matRepo), exportArgs);
                                }
                            }
                            break;
                        }

                    }
                }
                if (Path.GetExtension(primaryDependencies[i]) == ".mlmask")
                {
                    if (!TexturesList.Contains(primaryDependencies[i]))
                    {
                        TexturesList.Add(primaryDependencies[i]);
                    }

                    var hash = FNV1A64HashAlgorithm.HashString(primaryDependencies[i]);
                    foreach (var ar in archives)
                    {
                        if (ar.Files.ContainsKey(hash))
                        {
                            if (!File.Exists(Path.Combine(matRepo, primaryDependencies[i].Replace(".mlmask", $"_0.{exportArgs.Get<XbmExportArgs>().UncookExtension.ToString()}"))))
                            {
                                if (Directory.Exists(matRepo))
                                {
                                    exportArgs.Get<MlmaskExportArgs>().AsList = false;
                                    UncookSingle(ar, hash, new DirectoryInfo(matRepo), exportArgs);
                                }
                            }
                            break;
                        }
                    }

                }

                if (Path.GetExtension(primaryDependencies[i]) == ".hp")
                {
                    if (!HairProfileNames.Contains(primaryDependencies[i]))
                    {
                        var hash = FNV1A64HashAlgorithm.HashString(primaryDependencies[i]);
                        foreach (var ar in archives)
                        {
                            if (ar.Files.ContainsKey(hash))
                            {
                                var ms = new MemoryStream();
                                ExtractSingleToStream(ar, hash, ms);
                                ms.Seek(0, SeekOrigin.Begin);

                                HairProfileNames.Add(primaryDependencies[i]);
                                var path = Path.Combine(matRepo, Path.ChangeExtension(primaryDependencies[i], ".hp.json"));
                                if (!File.Exists(path))
                                {
                                    if (!new FileInfo(path).Directory.Exists)
                                    {
                                        Directory.CreateDirectory(new FileInfo(path).Directory.FullName);
                                    }
                                    var hp = _wolvenkitFileService.ReadRed4File(ms);
                                    //hp.FileName = primaryDependencies[i];
                                    var dto = new RedFileDto(hp);
                                    var doc = RedJsonSerializer.Serialize(dto);
                                    File.WriteAllText(path, doc);
                                }
                                break;
                            }
                        }
                    }
                }

                if (Path.GetExtension(primaryDependencies[i]) == ".mlsetup")
                {
                    if (!mlSetupNames.Contains(primaryDependencies[i]))
                    {
                        var hash = FNV1A64HashAlgorithm.HashString(primaryDependencies[i]);
                        foreach (var ar in archives)
                        {
                            if (ar.Files.ContainsKey(hash))
                            {
                                var ms = new MemoryStream();
                                ExtractSingleToStream(ar, hash, ms);
                                ms.Seek(0, SeekOrigin.Begin);

                                var isResource = _wolvenkitFileService.IsCR2WFile(ms);
                                if (!isResource)
                                {
                                    throw new InvalidParsingException("not a cr2w file");
                                }
                                using var reader = new CR2WReader(ms);
                                _ = reader.ReadFile(out var mls, false);

                                mlSetupNames.Add(primaryDependencies[i]);

                                var path = Path.Combine(matRepo, Path.ChangeExtension(primaryDependencies[i], ".mlsetup.json"));
                                if (!File.Exists(path))
                                {
                                    if (!new FileInfo(path).Directory.Exists)
                                    {
                                        Directory.CreateDirectory(new FileInfo(path).Directory.FullName);
                                    }
                                    //mls.FileName = primaryDependencies[i];
                                    var dto = new RedFileDto(mls);
                                    var doc = RedJsonSerializer.Serialize(dto);
                                    File.WriteAllText(path, doc);
                                }

                                for (var e = 0; e < reader.ImportsList.Count; e++)
                                {
                                    if (Path.GetExtension(reader.ImportsList[e].DepotPath) == ".xbm")
                                    {
                                        if (!TexturesList.Contains(reader.ImportsList[e].DepotPath))
                                        {
                                            TexturesList.Add(reader.ImportsList[e].DepotPath);
                                        }

                                        var hash1 = FNV1A64HashAlgorithm.HashString(reader.ImportsList[e].DepotPath);
                                        foreach (var arr in archives)
                                        {
                                            if (arr.Files.ContainsKey(hash1))
                                            {
                                                if (!File.Exists(Path.Combine(matRepo, Path.ChangeExtension(reader.ImportsList[e].DepotPath, "." + exportArgs.Get<XbmExportArgs>().UncookExtension.ToString()))))
                                                {
                                                    if (Directory.Exists(matRepo))
                                                    {
                                                        UncookSingle(arr, hash1, new DirectoryInfo(matRepo), exportArgs);
                                                    }
                                                }
                                                break;
                                            }
                                        }
                                    }
                                    if (Path.GetExtension(reader.ImportsList[e].DepotPath) == ".mltemplate")
                                    {
                                        if (!mlTemplateNames.Contains(reader.ImportsList[e].DepotPath))
                                        {
                                            var hash2 = FNV1A64HashAlgorithm.HashString(reader.ImportsList[e].DepotPath);
                                            foreach (var arr in archives)
                                            {
                                                if (arr.Files.ContainsKey(hash2))
                                                {
                                                    var mss = new MemoryStream();
                                                    ExtractSingleToStream(arr, hash2, mss);
                                                    mss.Seek(0, SeekOrigin.Begin);

                                                    var mlt = _wolvenkitFileService.ReadRed4File(mss);
                                                    mlTemplateNames.Add(reader.ImportsList[e].DepotPath);

                                                    var path1 = Path.Combine(matRepo, Path.ChangeExtension(reader.ImportsList[e].DepotPath, ".mltemplate.json"));
                                                    if (!File.Exists(path1))
                                                    {
                                                        if (!new FileInfo(path1).Directory.Exists)
                                                        {
                                                            Directory.CreateDirectory(new FileInfo(path1).Directory.FullName);
                                                        }
                                                        //mlt.FileName = mls.Imports[e].DepotPath;
                                                        var dto1 = new RedFileDto(mlt);
                                                        var doc1 = RedJsonSerializer.Serialize(dto1);
                                                        File.WriteAllText(path1, doc1);

                                                        // import all textures included in the mltemplate
                                                        var mlTemplateMats = dto1.Data.RootChunk.FindType(typeof(CResourceReference<CBitmapTexture>));

                                                        for (var eye = 0; eye < mlTemplateMats.Count; eye++)
                                                        {
                                                            var mat = (CResourceReference<CBitmapTexture>)mlTemplateMats[eye].Value;
                                                            if (!TexturesList.Contains(mat.DepotPath))
                                                            {
                                                                TexturesList.Add(mat.DepotPath);
                                                            }

                                                            var hash3 = FNV1A64HashAlgorithm.HashString(mat.DepotPath);
                                                            foreach (var arrr in archives)
                                                            {
                                                                if (arrr.Files.ContainsKey(hash3))
                                                                {
                                                                    if (!File.Exists(Path.Combine(matRepo, Path.ChangeExtension(mat.DepotPath, "." + exportArgs.Get<XbmExportArgs>().UncookExtension.ToString()))))
                                                                    {
                                                                        if (Directory.Exists(matRepo))
                                                                        {
                                                                            UncookSingle(arrr, hash3, new DirectoryInfo(matRepo), exportArgs);
                                                                        }
                                                                    }
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }

                                                    for (var eye = 0; eye < reader.ImportsList.Count; eye++)
                                                    {
                                                        if (!TexturesList.Contains(reader.ImportsList[eye].DepotPath))
                                                        {
                                                            TexturesList.Add(reader.ImportsList[eye].DepotPath);
                                                        }

                                                        var hash3 = FNV1A64HashAlgorithm.HashString(reader.ImportsList[eye].DepotPath);
                                                        foreach (var arrr in archives)
                                                        {
                                                            if (arrr.Files.ContainsKey(hash3))
                                                            {
                                                                if (!File.Exists(Path.Combine(matRepo, Path.ChangeExtension(reader.ImportsList[eye].DepotPath, "." + exportArgs.Get<XbmExportArgs>().UncookExtension.ToString()))))
                                                                {
                                                                    if (Directory.Exists(matRepo))
                                                                    {
                                                                        UncookSingle(arrr, hash3, new DirectoryInfo(matRepo), exportArgs);
                                                                    }
                                                                }
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    break;
                                                }
                                            }
                                        }
                                    }

                                }
                                break;
                            }
                        }
                    }
                }

                if (Path.GetExtension(primaryDependencies[i]) == ".gradient")
                {
                    if (!TexturesList.Contains(primaryDependencies[i]))
                    {
                        var hash = FNV1A64HashAlgorithm.HashString(primaryDependencies[i]);
                        foreach (var ar in archives)
                        {
                            if (ar.Files.ContainsKey(hash))
                            {
                                var ms = new MemoryStream();
                                ExtractSingleToStream(ar, hash, ms);
                                ms.Seek(0, SeekOrigin.Begin);

                                TexturesList.Add(primaryDependencies[i]);
                                var path = Path.Combine(matRepo, Path.ChangeExtension(primaryDependencies[i], ".gradient.json"));
                                if (!File.Exists(path))
                                {
                                    if (!new FileInfo(path).Directory.Exists)
                                    {
                                        Directory.CreateDirectory(new FileInfo(path).Directory.FullName);
                                    }
                                    var hp = _wolvenkitFileService.ReadRed4File(ms);
                                    var dto = new RedFileDto(hp);
                                    var doc = RedJsonSerializer.Serialize(dto);
                                    File.WriteAllText(path, doc);
                                }
                                break;
                            }
                        }
                    }
                }
            }



            var RawMaterials = new List<RawMaterial>();
            var usedMts = new Dictionary<string, CMaterialTemplate>();
            for (var i = 0; i < materialEntries.Count; i++)
            {
                RawMaterials.Add(ContainRawMaterial(materialEntries[i], materialEntryNames[i], archives, ref usedMts));
            }

            var matTemplates = new List<RawMaterial>();
            {
                var keys = usedMts.Keys.ToList();
                for (var i = 0; i < keys.Count; i++)
                {
                    var rawMat = new RawMaterial
                    {
                        Name = keys[i],
                        Data = new Dictionary<string, object>()
                    };

                    foreach (var item in usedMts[keys[i]].Parameters[2])
                    {
                        rawMat.Data.Add(item.Chunk.ParameterName, GetSerializableValue(item.Chunk));
                    }

                    matTemplates.Add(rawMat);
                }
            }

            var matData = new MatData
            {
                MaterialRepo = matRepo,
                Materials = RawMaterials,
                TexturesList = TexturesList,
                MaterialTemplates = matTemplates
            };

            var str = RedJsonSerializer.Serialize(matData);

            File.WriteAllText(Path.ChangeExtension(outfile.FullName, ".Material.json"), str);
        }



        private IRedType GetMaterialParameterValue(Type materialParameterType, object obj)
        {
            if (materialParameterType == typeof(CMaterialParameterColor))
            {
                if (obj is not JsonElement value)
                {
                    return null;
                }

                var dict = value.Deserialize<Dictionary<string, byte>>();

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

                return (CName)value.GetString();
            }

            if (materialParameterType == typeof(CMaterialParameterCube))
            {
                string path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<ITexture>
                {
                    DepotPath = path,
                    Flags = InternalEnums.EImportFlags.Default
                };
            }

            if (materialParameterType == typeof(CMaterialParameterFoliageParameters))
            {
                string path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<CFoliageProfile>
                {
                    DepotPath = path,
                    Flags = InternalEnums.EImportFlags.Default
                };
            }

            if (materialParameterType == typeof(CMaterialParameterGradient))
            {
                string path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<CGradient>
                {
                    DepotPath = path,
                    Flags = InternalEnums.EImportFlags.Default
                };
            }

            if (materialParameterType == typeof(CMaterialParameterHairParameters))
            {
                string path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<CHairProfile>
                {
                    DepotPath = path,
                    Flags = InternalEnums.EImportFlags.Default
                };
            }

            if (materialParameterType == typeof(CMaterialParameterMultilayerMask))
            {
                string path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<Multilayer_Mask>
                {
                    DepotPath = path,
                    Flags = InternalEnums.EImportFlags.Default
                };
            }

            if (materialParameterType == typeof(CMaterialParameterMultilayerSetup))
            {
                string path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<Multilayer_Setup>
                {
                    DepotPath = path,
                    Flags = InternalEnums.EImportFlags.Default
                };
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
                string path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<CSkinProfile>
                {
                    DepotPath = path,
                    Flags = InternalEnums.EImportFlags.Default
                };
            }

            if (materialParameterType == typeof(CMaterialParameterStructBuffer))
            {
                return null;
            }

            if (materialParameterType == typeof(CMaterialParameterTerrainSetup))
            {
                string path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<CTerrainSetup>
                {
                    DepotPath = path,
                    Flags = InternalEnums.EImportFlags.Default
                };
            }

            if (materialParameterType == typeof(CMaterialParameterTexture))
            {
                string path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<ITexture>
                {
                    DepotPath = path,
                    Flags = InternalEnums.EImportFlags.Default
                };
            }

            if (materialParameterType == typeof(CMaterialParameterTextureArray))
            {
                string path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<ITexture>
                {
                    DepotPath = path,
                    Flags = InternalEnums.EImportFlags.Default
                };
            }

            if (materialParameterType == typeof(CMaterialParameterVector))
            {
                if (obj is not JsonElement value)
                {
                    return null;
                }

                var dict = value.Deserialize<Dictionary<string, float>>();

                return new Vector4
                {
                    X = dict["X"],
                    Y = dict["Y"],
                    Z = dict["Z"],
                    W = dict["W"]
                };
            }

            throw new NotImplementedException(materialParameterType.Name);
        }

        private object GetSerializableValue(IRedType value)
        {
            if (value is CColor col)
            {
                return new Dictionary<string, byte>
                {
                    {nameof(col.Red), col.Red},
                    {nameof(col.Green), col.Green},
                    {nameof(col.Blue), col.Blue},
                    {nameof(col.Alpha), col.Alpha},
                };
            }

            if (value is CName cName)
            {
                return (string)cName;
            }

            if (value is CFloat cFloat)
            {
                return (float)cFloat;
            }

            if (value is Vector4 vec)
            {
                return new Dictionary<string, float>
                {
                    {nameof(vec.X), vec.X},
                    {nameof(vec.Y), vec.Y},
                    {nameof(vec.Z), vec.Z},
                    {nameof(vec.W), vec.W},
                };
            }

            if (value is IRedResourceReference rRef)
            {
                return (string)rRef.DepotPath;
            }

            throw new NotImplementedException(value.GetType().Name);
        }

        private object GetSerializableValue(CMaterialParameter materialParameter)
        {
            if (materialParameter is CMaterialParameterColor col)
            {
                return GetSerializableValue(col.Color);
            }

            if (materialParameter is CMaterialParameterCpuNameU64 cpu)
            {
                return GetSerializableValue(cpu.Name);
            }

            if (materialParameter is CMaterialParameterCube cub)
            {
                return GetSerializableValue(cub.Texture);
            }

            if (materialParameter is CMaterialParameterFoliageParameters fol)
            {
                return GetSerializableValue(fol.FoliageProfile);
            }

            if (materialParameter is CMaterialParameterGradient gra)
            {
                return GetSerializableValue(gra.Gradient);
            }

            if (materialParameter is CMaterialParameterHairParameters hai)
            {
                return GetSerializableValue(hai.HairProfile);
            }

            if (materialParameter is CMaterialParameterMultilayerMask mulm)
            {
                return GetSerializableValue(mulm.Mask);
            }

            if (materialParameter is CMaterialParameterMultilayerSetup muls)
            {
                return GetSerializableValue(muls.Setup);
            }

            if (materialParameter is CMaterialParameterScalar sca)
            {
                return GetSerializableValue(sca.Scalar);
            }

            if (materialParameter is CMaterialParameterSkinParameters ski)
            {
                return GetSerializableValue(ski.SkinProfile);
            }

            if (materialParameter is CMaterialParameterStructBuffer str)
            {
                // TODO: Is there something I'm missing here?
                return null;
            }

            if (materialParameter is CMaterialParameterTerrainSetup ter)
            {
                return GetSerializableValue(ter.Setup);
            }

            if (materialParameter is CMaterialParameterTexture tex)
            {
                return GetSerializableValue(tex.Texture);
            }

            if (materialParameter is CMaterialParameterTextureArray texa)
            {
                return GetSerializableValue(texa.Texture);
            }

            if (materialParameter is CMaterialParameterVector vec)
            {
                return GetSerializableValue(vec.Vector);
            }

            throw new NotImplementedException(materialParameter.GetType().Name);
        }

        private IRedType GetMaterialParameterValue(CMaterialParameter materialParameter)
        {
            if (materialParameter is CMaterialParameterColor col)
            {
                return col.Color;
            }

            if (materialParameter is CMaterialParameterCpuNameU64 cpu)
            {
                return cpu.Name;
            }

            if (materialParameter is CMaterialParameterCube cub)
            {
                return cub.Texture;
            }

            if (materialParameter is CMaterialParameterFoliageParameters fol)
            {
                return fol.FoliageProfile;
            }

            if (materialParameter is CMaterialParameterGradient gra)
            {
                return gra.Gradient;
            }

            if (materialParameter is CMaterialParameterHairParameters hai)
            {
                return hai.HairProfile;
            }

            if (materialParameter is CMaterialParameterMultilayerMask mulm)
            {
                return mulm.Mask;
            }

            if (materialParameter is CMaterialParameterMultilayerSetup muls)
            {
                return muls.Setup;
            }

            if (materialParameter is CMaterialParameterScalar sca)
            {
                return sca.Scalar;
            }

            if (materialParameter is CMaterialParameterSkinParameters ski)
            {
                return ski.SkinProfile;
            }

            if (materialParameter is CMaterialParameterStructBuffer str)
            {
                // TODO: Is there something I'm missing here?
                return null;
            }

            if (materialParameter is CMaterialParameterTerrainSetup ter)
            {
                return ter.Setup;
            }

            if (materialParameter is CMaterialParameterTexture tex)
            {
                return tex.Texture;
            }

            if (materialParameter is CMaterialParameterTextureArray texa)
            {
                return texa.Texture;
            }

            if (materialParameter is CMaterialParameterVector vec)
            {
                return vec.Vector;
            }

            throw new NotImplementedException(materialParameter.GetType().Name);
        }

        private CR2WFile LoadFile(string path, List<Archive> archives)
        {
            var hash = FNV1A64HashAlgorithm.HashString(path);
            foreach (var ar in archives)
            {
                if (ar.Files.ContainsKey(hash))
                {
                    var ms = new MemoryStream();
                    ExtractSingleToStream(ar, hash, ms);
                    ms.Seek(0, SeekOrigin.Begin);

                    if (!_wolvenkitFileService.TryReadRed4File(ms, out var file))
                    {
                        throw new Exception("Invalid CR2W file");
                    }

                    return file;
                }
            }

            throw new FileNotFoundException(path);
        }

        private (string materialTemplate, Dictionary<string, object> valueDict) GetMaterialChain(CMaterialInstance cMaterialInstance, List<Archive> archives, ref Dictionary<string, CMaterialTemplate> mts)
        {
            var resultDict = new Dictionary<string, object>();

            var baseMaterials = new List<CMaterialInstance>();

            string path = cMaterialInstance.BaseMaterial.DepotPath;
            while (!Path.GetExtension(path).Contains("mt"))
            {
                var file = LoadFile(path, archives);
                if (file.RootChunk is not CMaterialInstance mi)
                {
                    throw new Exception("Invalid .mi file");
                }

                baseMaterials.Add(mi);
                path = mi.BaseMaterial.DepotPath;
            }
            baseMaterials.Reverse();

            CMaterialTemplate mt;
            if (mts.ContainsKey(path))
            {
                mt = mts[path];
            }
            else
            {
                var file = LoadFile(path, archives);
                mt = (CMaterialTemplate)file.RootChunk;
                mts.Add(path, mt);
            }

            foreach (var usedParameter in mt.UsedParameters[2])
            {
                foreach (var parameterHandle in mt.Parameters[2])
                {
                    var refer = parameterHandle.Chunk;
                    if (refer.ParameterName == usedParameter.Name)
                    {
                        resultDict.Add(refer.ParameterName, GetMaterialParameterValue(refer));
                    }
                }
            }

            baseMaterials.Add(cMaterialInstance);
            foreach (var mi in baseMaterials)
            {
                foreach (var kvp in mi.Values)
                {
                    object value = null;
                    foreach (var handle in mt.Parameters[2])
                    {
                        if (Equals(handle.Chunk.ParameterName, kvp.Key))
                        {
                            value = kvp.Value;
                        }
                    }

                    if (value == null)
                    {
                        value = new MaterialValueWrapper { Type = kvp.Value.RedType, Value = kvp.Value };
                    }

                    if (resultDict.ContainsKey(kvp.Key))
                    {
                        resultDict[kvp.Key] = value;
                    }
                    else
                    {
                        resultDict.Add(kvp.Key, value);
                    }
                }
            }

            return (path, resultDict);
        }

        private RawMaterial ContainRawMaterial(CMaterialInstance cMaterialInstance, string name, List<Archive> archives, ref Dictionary<string, CMaterialTemplate> mts)
        {
            var (materialTemplatePath, valueDict) = GetMaterialChain(cMaterialInstance, archives, ref mts);

            var rawMaterial = new RawMaterial
            {
                Name = name,
                BaseMaterial = cMaterialInstance.BaseMaterial.DepotPath,
                MaterialTemplate = materialTemplatePath,
                Data = new Dictionary<string, object>()
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

        public bool WriteMatToMesh(ref CR2WFile cr2w, string _matData, List<Archive> archives)
        {
            if (cr2w == null || cr2w.RootChunk is not CMesh cMesh || cMesh.RenderResourceBlob.Chunk is not rendRenderMeshBlob)
            {
                return false;
            }

            var matData = RedJsonSerializer.Deserialize<MatData>(_matData);

            var materialbuffer = new MemoryStream();
            var offsets = new List<uint>();
            var sizes = new List<uint>();
            var names = new List<string>();

            if (matData.Materials.Count < 1)
            {
                return false;
            }

            var mts = new Dictionary<string, CMaterialTemplate>();
            for (var i = 0; i < matData.Materials.Count; i++)
            {
                var mat = matData.Materials[i];
                names.Add(mat.Name);
                var mi = new CR2WFile();
                {
                    var chunk = RedTypeManager.Create<CMaterialInstance>();
                    chunk.CookingPlatform = Enums.ECookingPlatform.PLATFORM_PC;
                    chunk.EnableMask = true;
                    chunk.ResourceVersion = 4;
                    chunk.BaseMaterial = new CResourceReference<IMaterial>() { DepotPath = mat.BaseMaterial };
                    chunk.Values = new CArray<CKeyValuePair>();

                    CMaterialTemplate mt = null;
                    if (mts.ContainsKey(mat.MaterialTemplate))
                    {
                        mt = mts[mat.MaterialTemplate];
                    }
                    else
                    {
                        var hash = FNV1A64HashAlgorithm.HashString(mat.MaterialTemplate);
                        foreach (var ar in archives)
                        {
                            if (ar.Files.ContainsKey(hash))
                            {
                                var ms = new MemoryStream();
                                ExtractSingleToStream(ar, hash, ms);
                                ms.Seek(0, SeekOrigin.Begin);

                                mt = (CMaterialTemplate)_wolvenkitFileService.ReadRed4File(ms).RootChunk;
                                mts.Add(mat.MaterialTemplate, mt);
                                break;
                            }
                        }
                    }

                    var fakeMaterialInstance = new CMaterialInstance()
                    {
                        BaseMaterial = new CResourceReference<IMaterial> { DepotPath = mat.BaseMaterial },
                        Values = new CArray<CKeyValuePair>()
                    };
                    var orgChain = GetMaterialChain(fakeMaterialInstance, archives, ref mts);

                    if (mt != null)
                    {
                        foreach (var (key, value) in matData.Materials[i].Data)
                        {
                            var found = false;

                            for (var k = 0; k < mt.Parameters[2].Count; k++)
                            {
                                var refer = mt.Parameters[2][k].Chunk;

                                if (refer.ParameterName == key)
                                {
                                    found = true;

                                    object convValue = GetMaterialParameterValue(refer.GetType(), value);
                                    if (orgChain.valueDict.ContainsKey(refer.ParameterName) && !Equals(orgChain.valueDict[refer.ParameterName], convValue))
                                    {
                                        chunk.Values.Add(new CKeyValuePair(refer.ParameterName, (IRedType)convValue));
                                    }
                                }
                            }

                            if (!found)
                            {
                                var wrapper = ((JsonElement)value).Deserialize<MaterialValueWrapper>();
                                var (type, _) = RedReflection.GetCSTypeFromRedType(wrapper.Type);

                                var nValue = ((JsonElement)wrapper.Value).Deserialize(type, RedJsonSerializer.Options);
                                chunk.Values.Add(new CKeyValuePair(key, (IRedType)nValue));
                            }
                        }
                    }

                    mi.RootChunk = chunk;
                }

                offsets.Add((uint)materialbuffer.Position);

                using var m = new MemoryStream();
                using var writer = new CR2WWriter(m);
                writer.WriteFile(mi);

                materialbuffer.Write(m.ToArray(), 0, (int)m.Length);
                sizes.Add((uint)m.Length);
            }

            var blob = (CMesh)cr2w.RootChunk;

            // remove existing data
            while (blob.MaterialEntries.Count != 0)
            {
                blob.MaterialEntries.Remove(blob.MaterialEntries[^1]);
            }
            while (blob.LocalMaterialBuffer.RawDataHeaders.Count != 0)
            {
                blob.LocalMaterialBuffer.RawDataHeaders.Remove(blob.LocalMaterialBuffer.RawDataHeaders[^1]);
            }
            while (blob.PreloadLocalMaterialInstances.Count != 0)
            {
                blob.PreloadLocalMaterialInstances.Remove(blob.PreloadLocalMaterialInstances[^1]);
            }
            while (blob.PreloadExternalMaterials.Count != 0)
            {
                blob.PreloadExternalMaterials.Remove(blob.PreloadExternalMaterials[^1]);
            }
            while (blob.ExternalMaterials.Count != 0)
            {
                blob.ExternalMaterials.Remove(blob.ExternalMaterials[^1]);
            }
            while (blob.LocalMaterialInstances.Count != 0)
            {
                blob.LocalMaterialInstances.Remove(blob.LocalMaterialInstances[^1]);
            }

            for (var i = 0; i < names.Count; i++)
            {
                var entry = RedTypeManager.Create<CMeshMaterialEntry>();
                entry.IsLocalInstance = true;
                entry.Name = names[i];
                entry.Index = (ushort)i;
                blob.MaterialEntries.Add(entry);

                var header = RedTypeManager.Create<meshLocalMaterialHeader>();
                header.Offset = offsets[i];
                header.Size = sizes[i];
                blob.LocalMaterialBuffer.RawDataHeaders.Add(header);
            }

            if (blob.LocalMaterialBuffer.RawData == null)
            {
                blob.LocalMaterialBuffer.RawData = new DataBuffer(materialbuffer.ToArray());
            }
            else
            {
                blob.LocalMaterialBuffer.RawData.Buffer.SetBytes(materialbuffer.ToArray());
            }

            return true;
        }
    }
}
