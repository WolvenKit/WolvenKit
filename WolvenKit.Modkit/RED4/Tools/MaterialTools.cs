using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CP77.CR2W;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W.Archive;
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
                throw new Exception("Material Repository Path is not set, Please select a folder in the Material Repository Settings where your textures will output, Generating the complete dump is not required.");
            }

            var cr2w = _wolvenkitFileService.TryReadRed4File(meshStream);
            if (cr2w == null || cr2w.RootChunk is not CMesh cMesh || cMesh.RenderResourceBlob.Chunk is not rendRenderMeshBlob rendblob)
            {
                return false;
            }

            using var ms = new MemoryStream(rendblob.RenderBuffer.Buffer.GetBytes());

            var meshesinfo = MeshTools.GetMeshesinfo(rendblob, cr2w);

            var expMeshes = MeshTools.ContainRawMesh(ms, meshesinfo, LodFilter);
            MeshTools.UpdateSkinningParamCloth(ref expMeshes, meshStream, cr2w);

            var Rig = MeshTools.GetOrphanRig(rendblob, cr2w);

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

                        var isResource = _wolvenkitFileService.IsCr2wFile(ms);
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

                        var isResource = _wolvenkitFileService.IsCr2wFile(ms);
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

            var isbuffered = true;
            if (cmesh.LocalMaterialBuffer.RawDataHeaders.Count == 0)
            {
                isbuffered = false;
            }

            if (isbuffered)
            {
                var materialStream = GetMaterialStream(meshStream, cr2w);
                var bytes = materialStream.ToArray();
                for (var i = 0; i < cmesh.LocalMaterialBuffer.RawDataHeaders.Count; i++)
                {
                    uint offset = cmesh.LocalMaterialBuffer.RawDataHeaders[i].Offset;
                    uint size = cmesh.LocalMaterialBuffer.RawDataHeaders[i].Size;

                    var ms = new MemoryStream(bytes, (int)offset, (int)size);

                    var isResource = _wolvenkitFileService.IsCr2wFile(ms);
                    if (!isResource)
                    {
                        throw new InvalidParsingException("not a cr2w file");
                    }

                    using var reader = new CR2WReader(ms);
                    _ = reader.ReadFile(out var mi, false);

                    //MemoryStream ms = new MemoryStream(bytes, (int)offset, (int)size);
                    //var mi = _wolvenkitFileService.TryReadRed4File(ms);

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

                //throw new TodoException("get import info from cr2w file?");

                /*foreach (var import in cr2w.Debug.ImportInfos)
                {

                    if (!primaryDependencies.Contains(import.DepotPath))
                    {
                        primaryDependencies.Add(import.DepotPath);
                    }
                }*/
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

                            var isResource = _wolvenkitFileService.IsCr2wFile(ms);
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

                        var isResource = _wolvenkitFileService.IsCr2wFile(ms);
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
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented };

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
                    new MlmaskExportArgs() { UncookExtension = eUncookExtension }
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
                                HairProfileNames.Add(primaryDependencies[i]);
                                var path = Path.Combine(matRepo, Path.ChangeExtension(primaryDependencies[i], ".hp.json"));
                                if (!File.Exists(path))
                                {
                                    if (!new FileInfo(path).Directory.Exists)
                                    {
                                        Directory.CreateDirectory(new FileInfo(path).Directory.FullName);
                                    }
                                    var hp = _wolvenkitFileService.TryReadRed4File(ms);
                                    //hp.FileName = primaryDependencies[i];
                                    var dto = new RedFileDto(hp);
                                    var doc = JsonConvert.SerializeObject(dto, settings);
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

                                var isResource = _wolvenkitFileService.IsCr2wFile(ms);
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
                                    var doc = JsonConvert.SerializeObject(dto, settings);
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

                                                    var mlt = _wolvenkitFileService.TryReadRed4File(mss);
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
                                                        var doc1 = JsonConvert.SerializeObject(dto1, settings);
                                                        File.WriteAllText(path1, doc1);
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
                        var refer = item.Chunk;
                        var inst = (CMaterialParameter)RedTypeManager.Create(refer.GetType());

                        rawMat.Data.Add(refer.ParameterName, GetMaterialParameter(inst));
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

            var str = JsonConvert.SerializeObject(matData, settings);

            File.WriteAllText(Path.ChangeExtension(outfile.FullName, ".Material.json"), str);

        }

        private void SetMaterialParameter(CMaterialParameter materialParameter, object value)
        {
            if (materialParameter is CMaterialParameterColor col)
            {
                var cVal = ((JObject)value).ToObject<Dictionary<string, byte>>();

                col.Color.Red = cVal["Red"];
                col.Color.Green = cVal["Green"];
                col.Color.Blue = cVal["Blue"];
                col.Color.Alpha = cVal["Alpha"];
            }

            if (materialParameter is CMaterialParameterCpuNameU64 cpu)
            {
                cpu.Name = (string)value;
            }

            if (materialParameter is CMaterialParameterCube cub)
            {
                cub.Texture.DepotPath = (string)value;
            }

            if (materialParameter is CMaterialParameterFoliageParameters fol)
            {
                fol.FoliageProfile.DepotPath = (string)value;
            }

            if (materialParameter is CMaterialParameterGradient gra)
            {
                gra.Gradient.DepotPath = (string)value;
            }

            if (materialParameter is CMaterialParameterHairParameters hai)
            {
                hai.HairProfile.DepotPath = (string)value;
            }

            if (materialParameter is CMaterialParameterMultilayerMask mulm)
            {
                mulm.Mask.DepotPath = (string)value;
            }

            if (materialParameter is CMaterialParameterMultilayerSetup muls)
            {
                muls.Setup.DepotPath = (string)value;
            }

            if (materialParameter is CMaterialParameterScalar sca)
            {
                sca.Scalar = Convert.ToSingle(value);
            }

            if (materialParameter is CMaterialParameterSkinParameters ski)
            {
                ski.SkinProfile.DepotPath = (string)value;
            }

            if (materialParameter is CMaterialParameterStructBuffer str)
            {
                throw new TodoException(nameof(CMaterialParameterStructBuffer));
            }

            if (materialParameter is CMaterialParameterTerrainSetup ter)
            {
                ter.Setup.DepotPath = (string)value;
            }

            if (materialParameter is CMaterialParameterTexture tex)
            {
                tex.Texture.DepotPath = (string)value;
            }

            if (materialParameter is CMaterialParameterTextureArray texa)
            {
                texa.Texture.DepotPath = (string)value;
            }

            if (materialParameter is CMaterialParameterVector vec)
            {
                var cVal = ((JObject)value).ToObject<Dictionary<string, float>>();

                vec.Vector.X = cVal["X"];
                vec.Vector.Y = cVal["Y"];
                vec.Vector.Z = cVal["Z"];
                vec.Vector.W = cVal["W"];
            }
        }

        public object GetMaterialParameter(CMaterialParameter materialParameter)
        {
            if (materialParameter is CMaterialParameterColor col)
            {
                return new Dictionary<string, byte>
                {
                    {"Red", col.Color.Red},
                    {"Green", col.Color.Green},
                    {"Blue", col.Color.Blue},
                    {"Alpha", col.Color.Alpha},
                };
            }

            if (materialParameter is CMaterialParameterCpuNameU64 cpu)
            {
                return (string)cpu.Name ?? "";
            }

            if (materialParameter is CMaterialParameterCube cub)
            {
                return (string)cub.Texture.DepotPath ?? "";
            }

            if (materialParameter is CMaterialParameterFoliageParameters fol)
            {
                return (string)fol.FoliageProfile.DepotPath ?? "";
            }

            if (materialParameter is CMaterialParameterGradient gra)
            {
                return (string)gra.Gradient.DepotPath ?? "";
            }

            if (materialParameter is CMaterialParameterHairParameters hai)
            {
                return (string)hai.HairProfile.DepotPath ?? "";
            }

            if (materialParameter is CMaterialParameterMultilayerMask mulm)
            {
                return (string)mulm.Mask.DepotPath ?? "";
            }

            if (materialParameter is CMaterialParameterMultilayerSetup muls)
            {
                return (string)muls.Setup.DepotPath ?? "";
            }

            if (materialParameter is CMaterialParameterScalar sca)
            {
                return (float)sca.Scalar;
            }

            if (materialParameter is CMaterialParameterSkinParameters ski)
            {
                return (string)ski.SkinProfile.DepotPath ?? "";
            }

            if (materialParameter is CMaterialParameterStructBuffer str)
            {
                throw new TodoException(nameof(CMaterialParameterStructBuffer));
            }

            if (materialParameter is CMaterialParameterTerrainSetup ter)
            {
                return (string)ter.Setup.DepotPath ?? "";
            }

            if (materialParameter is CMaterialParameterTexture tex)
            {
                return (string)tex.Texture.DepotPath ?? "";
            }

            if (materialParameter is CMaterialParameterTextureArray texa)
            {
                return (string)texa.Texture.DepotPath ?? "";
            }

            if (materialParameter is CMaterialParameterVector vec)
            {
                return new Dictionary<string, float>
                {
                    {"X", vec.Vector.X},
                    {"Y", vec.Vector.Y},
                    {"Z", vec.Vector.Z},
                    {"W", vec.Vector.W},
                };
            }

            throw new NotImplementedException(materialParameter.GetType().Name);
        }

        private RawMaterial ContainRawMaterial(CMaterialInstance cMaterialInstance, string Name, List<Archive> archives, ref Dictionary<string, CMaterialTemplate> mts)
        {
            var rawMaterial = new RawMaterial
            {
                Name = Name,
                BaseMaterial = cMaterialInstance.BaseMaterial.DepotPath
            };

            var BaseMaterials = new List<CMaterialInstance>();

            string path = cMaterialInstance.BaseMaterial.DepotPath;
            var hash = FNV1A64HashAlgorithm.HashString(path);
            while (!Path.GetExtension(path).Contains("mt"))
            {
                hash = FNV1A64HashAlgorithm.HashString(path);
                foreach (var ar in archives)
                {
                    if (ar.Files.ContainsKey(hash))
                    {
                        var ms = new MemoryStream();
                        ModTools.ExtractSingleToStream(ar, hash, ms);
                        var mi = _wolvenkitFileService.TryReadRed4File(ms);
                        BaseMaterials.Add(mi.RootChunk as CMaterialInstance);
                        path = (mi.RootChunk as CMaterialInstance).BaseMaterial.DepotPath;
                        break;
                    }
                }
            }
            BaseMaterials.Reverse();

            CMaterialTemplate mt = null;
            if (mts.ContainsKey(path))
            {
                mt = mts[path];
            }
            else
            {
                hash = FNV1A64HashAlgorithm.HashString(path);
                foreach (var ar in archives)
                {
                    if (ar.Files.ContainsKey(hash))
                    {
                        var ms = new MemoryStream();
                        ModTools.ExtractSingleToStream(ar, hash, ms);
                        mt = (CMaterialTemplate)_wolvenkitFileService.TryReadRed4File(ms).RootChunk;
                        mts.Add(path, mt);
                        break;
                    }
                }
            }
            rawMaterial.MaterialTemplate = path;

            rawMaterial.Data = new Dictionary<string, object>();
            for (var i = 0; i < mt.UsedParameters[2].Count; i++)
            {
                for (var e = 0; e < mt.Parameters[2].Count; e++)
                {
                    var refer = mt.Parameters[2][e].Chunk;
                    if (refer.ParameterName == mt.UsedParameters[2][i].Name)
                    {
                        rawMaterial.Data.Add(mt.UsedParameters[2][i].Name, GetMaterialParameter(refer));
                    }
                }
            }

            BaseMaterials.Add(cMaterialInstance);
            foreach (var mi in BaseMaterials)
            {
                foreach (var kvp in mi.Values)
                {
                    if (kvp.Value is CColor col)
                    {
                        var col_ = new CColor
                        {
                            Red = col.Red,
                            Green = col.Green,
                            Blue = col.Blue,
                            Alpha = col.Alpha
                        };

                        if (rawMaterial.Data.ContainsKey(kvp.Key))
                        {
                            rawMaterial.Data[kvp.Key] = col_.ToObject();
                        }
                        else
                        {
                            rawMaterial.Data.Add(kvp.Key, col_.ToObject());
                        }
                    }
                    else
                    {
                        if (rawMaterial.Data.ContainsKey(kvp.Key))
                        {
                            rawMaterial.Data[kvp.Key] = kvp.Value.ToObject();
                        }
                        else
                        {
                            rawMaterial.Data.Add(kvp.Key, kvp.Value.ToObject());
                        }
                    }
                }
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
            var matData = JsonConvert.DeserializeObject<MatData>(_matData);

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
                    //chunk.CMaterialInstanceData = new CArray<CVariantSizeNameType>();

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
                                ModTools.ExtractSingleToStream(ar, hash, ms);
                                mt = (CMaterialTemplate)_wolvenkitFileService.TryReadRed4File(ms).RootChunk;
                                mts.Add(mat.MaterialTemplate, mt);
                                break;
                            }
                        }
                    }
                    var keys = matData.Materials[i].Data.Keys.ToList();
                    if (mt != null)
                    {
                        for (var j = 0; j < keys.Count; j++)
                        {
                            for (var k = 0; k < mt.Parameters[2].Count; k++)
                            {
                                var refer = mt.Parameters[2][k].Chunk;
                                if (refer.ParameterName == keys[j])
                                {
                                    SetMaterialParameter(refer, matData.Materials[i].Data[keys[j]]);
                                }
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
