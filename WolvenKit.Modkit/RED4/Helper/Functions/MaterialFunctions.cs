using System;
using System.IO;
using CP77.CR2W;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.Common.Oodle;
using System.Collections.Generic;
using System.Linq;
using SharpGLTF.Schema2;
using WolvenKit.Common.DDS;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Common.FNV1A;
using SharpGLTF.IO;
using System.Diagnostics;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Tools;
using Newtonsoft.Json;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.Common;

namespace WolvenKit.Modkit.RED4
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public partial class ModTools
    {
        public bool ExportMeshWithMaterials(Stream meshStream, FileInfo outfile, List<Archive> archives,string matRepo, EUncookExtension eUncookExtension = EUncookExtension.dds, bool isGLBinary = true, bool LodFilter = true)
        {
            if (matRepo == null)
                throw new Exception("Material Repository Path is not set, Please select a folder in the Material Repository Settings where your textures will output, Generating the complete dump is not required.");

            var cr2w = _wolvenkitFileService.TryReadRED4File(meshStream);
            if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any() || !cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
            {
                return false;
            }

            MeshTools.MeshBones meshBones = new MeshTools.MeshBones();

            meshBones.boneCount = cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().First().BoneNames.Count;

            if (meshBones.boneCount != 0)    // for rigid meshes
            {
                meshBones.Names = RIG.GetboneNames(cr2w);
                meshBones.WorldPosn = MeshTools.GetMeshBonesPosn(cr2w);
            }
            RawArmature Rig = MeshTools.GetNonParentedRig(meshBones);

            MemoryStream ms = MeshTools.GetMeshBufferStream(meshStream, cr2w);
            MeshesInfo meshinfo = MeshTools.GetMeshesinfo(cr2w);

            List<RawMeshContainer> expMeshes = MeshTools.ContainRawMesh(ms, meshinfo, LodFilter);
            if (meshBones.boneCount == 0)    // for rigid meshes
            {
                for (int i = 0; i < expMeshes.Count; i++)
                    expMeshes[i].weightcount = 0;
            }
            MeshTools.UpdateMeshJoints(ref expMeshes, Rig, meshBones);

            ModelRoot model = MeshTools.RawMeshesToGLTF(expMeshes, Rig);

            ParseMaterials(cr2w, meshStream, outfile, archives, matRepo, eUncookExtension);

            if (isGLBinary)
                model.SaveGLB(outfile.FullName);
            else
                model.SaveGLTF(outfile.FullName);

            meshStream.Dispose();
            meshStream.Close();

            return true;
        }
        private void GetMateriaEntries(CR2WFile cr2w, Stream meshStream, ref List<string> primaryDependencies,ref List<string> materialEntryNames, ref List<CMaterialInstance> materialEntries, List<Archive> archives)
        {
            var cmesh = cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().First();

            List<CMaterialInstance> ExternalMaterial = new List<CMaterialInstance>();

            for (int i = 0; i < cmesh.ExternalMaterials.Count; i++)
            {
                string path = cmesh.ExternalMaterials[i].DepotPath;

                ulong hash = FNV1A64HashAlgorithm.HashString(path);
                foreach (Archive ar in archives)
                {
                    if(ar.Files.ContainsKey(hash))
                    {
                        var ms = new MemoryStream();
                        ExtractSingleToStream(ar, hash, ms);

                        var mi = _wolvenkitFileService.TryReadCr2WFile(ms);
                        ExternalMaterial.Add(mi.Chunks[0].Data as CMaterialInstance);

                        for (int t = 0; t < mi.Imports.Count; t++)
                        {
                            if (!primaryDependencies.Contains(mi.Imports[t].DepotPathStr))
                            {
                                primaryDependencies.Add(mi.Imports[t].DepotPathStr);
                            }
                        }
                        break;
                    }
                }
            }
            for (int i = 0; i < cmesh.PreloadExternalMaterials.Count; i++)
            {
                string path = cmesh.PreloadExternalMaterials[i].DepotPath;

                ulong hash = FNV1A64HashAlgorithm.HashString(path);
                foreach (Archive ar in archives)
                {
                    if (ar.Files.ContainsKey(hash))
                    {
                        var ms = new MemoryStream();
                        ExtractSingleToStream(ar, hash, ms);

                        var mi = _wolvenkitFileService.TryReadCr2WFile(ms);
                        ExternalMaterial.Add(mi.Chunks[0].Data as CMaterialInstance);

                        for (int t = 0; t < mi.Imports.Count; t++)
                        {
                            if (!primaryDependencies.Contains(mi.Imports[t].DepotPathStr))
                            {
                                primaryDependencies.Add(mi.Imports[t].DepotPathStr);
                            }
                        }
                        break;
                    }
                }
            }
            List<CMaterialInstance> LocalMaterial = new List<CMaterialInstance>();

            bool isbuffered = true;
            if (cmesh.LocalMaterialBuffer.RawDataHeaders.Count == 0)
                isbuffered = false;

            if (isbuffered)
            {
                MemoryStream materialStream = GetMaterialStream(meshStream, cr2w);
                byte[] bytes = materialStream.ToArray();
                for (int i = 0; i < cmesh.LocalMaterialBuffer.RawDataHeaders.Count; i++)
                {
                    UInt32 offset = cmesh.LocalMaterialBuffer.RawDataHeaders[i].Offset.Value;
                    UInt32 size = cmesh.LocalMaterialBuffer.RawDataHeaders[i].Size.Value;

                    MemoryStream ms = new MemoryStream(bytes, (int)offset, (int)size);
                    var mi = _wolvenkitFileService.TryReadCr2WFile(ms);

                    for (int e = 0; e < mi.Imports.Count; e++)
                    {
                        if (!primaryDependencies.Contains(mi.Imports[e].DepotPathStr))
                        {
                            primaryDependencies.Add(mi.Imports[e].DepotPathStr);
                        }
                    }
                    LocalMaterial.Add(mi.Chunks[0].Data as CMaterialInstance);

                }
            }
            else
            {
                for (int i = 0; i < cr2w.Chunks.Count; i++)
                {
                    if (cr2w.Chunks[i].REDType == "CMaterialInstance")
                    {
                        LocalMaterial.Add(cr2w.Chunks[i].Data as CMaterialInstance);
                    }
                }
                for (int i = 0; i < cr2w.Imports.Count; i++)
                {
                    if (!primaryDependencies.Contains(cr2w.Imports[i].DepotPathStr))
                    {
                        primaryDependencies.Add(cr2w.Imports[i].DepotPathStr);
                    }
                }
            }

            int Count = cmesh.MaterialEntries.Count;
            for (int i = 0; i < Count; i++)
            {
                var Entry = cmesh.MaterialEntries[i];
                materialEntryNames.Add(Entry.Name.Value);
                if (Entry.IsLocalInstance.Value)
                    materialEntries.Add(LocalMaterial[Entry.Index.Value]);
                else
                    materialEntries.Add(ExternalMaterial[Entry.Index.Value]);
            }
            foreach(var m in materialEntries)
            {
                string path = m.BaseMaterial.DepotPath;
                while(!Path.GetExtension(path).Contains("mt"))
                {
                    ulong hash = FNV1A64HashAlgorithm.HashString(path);
                    foreach (Archive ar in archives)
                    {
                        if (ar.Files.ContainsKey(hash))
                        {
                            var ms = new MemoryStream();
                            ExtractSingleToStream(ar, hash, ms);

                            var mi = _wolvenkitFileService.TryReadCr2WFile(ms);
                            path = (mi.Chunks[0].Data as CMaterialInstance).BaseMaterial.DepotPath;
                            for (int t = 0; t < mi.Imports.Count; t++)
                            {
                                if (!primaryDependencies.Contains(mi.Imports[t].DepotPathStr))
                                {
                                    primaryDependencies.Add(mi.Imports[t].DepotPathStr);
                                }
                            }
                            break;
                        }
                    }
                }
                ulong mt = FNV1A64HashAlgorithm.HashString(path);
                foreach (Archive ar in archives)
                {
                    if (ar.Files.ContainsKey(mt))
                    {
                        var ms = new MemoryStream();
                        ExtractSingleToStream(ar, mt, ms);

                        var mi = _wolvenkitFileService.TryReadCr2WFile(ms);
                        for (int t = 0; t < mi.Imports.Count; t++)
                        {
                            if (!primaryDependencies.Contains(mi.Imports[t].DepotPathStr))
                            {
                                primaryDependencies.Add(mi.Imports[t].DepotPathStr);
                            }
                        }
                        break;
                    }
                }
            }
        }
        private void ParseMaterials(CR2WFile cr2w ,Stream meshStream, FileInfo outfile, List<Archive> archives,string matRepo, EUncookExtension eUncookExtension = EUncookExtension.dds)
        {
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented };

            List<string> primaryDependencies = new List<string>();

            List<string> materialEntryNames = new List<string>();
            List<CMaterialInstance> materialEntries = new List<CMaterialInstance>();

            GetMateriaEntries(cr2w, meshStream, ref primaryDependencies, ref materialEntryNames, ref materialEntries, archives);

            List<string> mlSetupNames = new List<string>();

            List<string> mlTemplateNames = new List<string>();

            List<string> HairProfileNames = new List<string>();

            List<string> TexturesList = new List<string>();

            var exportArgs =
                new GlobalExportArgs().Register(
                    new XbmExportArgs() { UncookExtension = eUncookExtension },
                    new MlmaskExportArgs() { UncookExtension = eUncookExtension }
                );

            for (int i = 0; i < primaryDependencies.Count; i++)
            {

                if (Path.GetExtension(primaryDependencies[i]) == ".xbm")
                {
                    if(!TexturesList.Contains(primaryDependencies[i]))
                        TexturesList.Add(primaryDependencies[i]);

                    ulong hash = FNV1A64HashAlgorithm.HashString(primaryDependencies[i]);
                    foreach (Archive ar in archives)
                    {
                        if (ar.Files.ContainsKey(hash))
                        {
                            if (!File.Exists(Path.Combine(matRepo, Path.ChangeExtension(primaryDependencies[i],"." + exportArgs.Get<XbmExportArgs>().UncookExtension.ToString()))))
                            {
                                if (Directory.Exists(matRepo))
                                    UncookSingle(ar, hash, new DirectoryInfo(matRepo), exportArgs);
                            }
                            break;
                        }

                    }
                }
                if (Path.GetExtension(primaryDependencies[i]) == ".mlmask")
                {
                    if (!TexturesList.Contains(primaryDependencies[i]))
                        TexturesList.Add(primaryDependencies[i]);
                    ulong hash = FNV1A64HashAlgorithm.HashString(primaryDependencies[i]);
                    foreach (Archive ar in archives)
                    {
                        if (ar.Files.ContainsKey(hash))
                        {
                            if(!File.Exists(Path.Combine(matRepo, primaryDependencies[i].Replace(".mlmask",$"_0.{exportArgs.Get<XbmExportArgs>().UncookExtension.ToString()}"))))
                            {
                                if (Directory.Exists(matRepo))
                                    UncookSingle(ar, hash, new DirectoryInfo(matRepo), exportArgs);
                            }
                            break;
                        }
                    }

                }

                if (Path.GetExtension(primaryDependencies[i]) == ".hp")
                {
                    if (!HairProfileNames.Contains(primaryDependencies[i]))
                    {
                        ulong hash = FNV1A64HashAlgorithm.HashString(primaryDependencies[i]);
                        foreach (Archive ar in archives)
                        {
                            if (ar.Files.ContainsKey(hash))
                            {
                                var ms = new MemoryStream();
                                ExtractSingleToStream(ar, hash, ms);
                                HairProfileNames.Add(primaryDependencies[i]);
                                string path = Path.Combine(matRepo, Path.ChangeExtension(primaryDependencies[i], ".hp.json"));
                                if (!File.Exists(path))
                                {
                                    if (!new FileInfo(path).Directory.Exists)
                                    {
                                        Directory.CreateDirectory(new FileInfo(path).Directory.FullName);
                                    }
                                    var hp = _wolvenkitFileService.TryReadCr2WFile(ms);
                                    hp.FileName = primaryDependencies[i];
                                    var dto = new Red4W2rcFileDto(hp);
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
                    if(!mlSetupNames.Contains(primaryDependencies[i]))
                    {
                        ulong hash = FNV1A64HashAlgorithm.HashString(primaryDependencies[i]);
                        foreach (Archive ar in archives)
                        {
                            if (ar.Files.ContainsKey(hash))
                            {
                                var ms = new MemoryStream();
                                ExtractSingleToStream(ar, hash, ms);
                                var mls = _wolvenkitFileService.TryReadCr2WFile(ms);
                                mlSetupNames.Add(primaryDependencies[i]);

                                string path = Path.Combine(matRepo, Path.ChangeExtension(primaryDependencies[i], ".mlsetup.json"));
                                if (!File.Exists(path))
                                {
                                    if (!new FileInfo(path).Directory.Exists)
                                    {
                                        Directory.CreateDirectory(new FileInfo(path).Directory.FullName);
                                    }
                                    mls.FileName = primaryDependencies[i];
                                    var dto = new Red4W2rcFileDto(mls);
                                    var doc = JsonConvert.SerializeObject(dto, settings);
                                    File.WriteAllText(path, doc);
                                }

                                for (int e = 0; e < mls.Imports.Count; e++)
                                {
                                    if (Path.GetExtension(mls.Imports[e].DepotPathStr) == ".xbm")
                                    {
                                        if (!TexturesList.Contains(mls.Imports[e].DepotPathStr))
                                            TexturesList.Add(mls.Imports[e].DepotPathStr);

                                        ulong hash1 = FNV1A64HashAlgorithm.HashString(mls.Imports[e].DepotPathStr);
                                        foreach (Archive arr in archives)
                                        {
                                            if (arr.Files.ContainsKey(hash1))
                                            {
                                                if (!File.Exists(Path.Combine(matRepo, Path.ChangeExtension(mls.Imports[e].DepotPathStr,"." + exportArgs.Get<XbmExportArgs>().UncookExtension.ToString()))))
                                                {
                                                    if (Directory.Exists(matRepo))
                                                        UncookSingle(arr, hash1, new DirectoryInfo(matRepo), exportArgs);
                                                }
                                                break;
                                            }
                                        }
                                    }
                                    if (Path.GetExtension(mls.Imports[e].DepotPathStr) == ".mltemplate")
                                    {
                                        if (!mlTemplateNames.Contains(mls.Imports[e].DepotPathStr))
                                        {
                                            ulong hash2 = FNV1A64HashAlgorithm.HashString(mls.Imports[e].DepotPathStr);
                                            foreach (Archive arr in archives)
                                            {
                                                if (arr.Files.ContainsKey(hash2))
                                                {
                                                    var mss = new MemoryStream();
                                                    ExtractSingleToStream(arr, hash2, mss);

                                                    var mlt = _wolvenkitFileService.TryReadCr2WFile(mss);
                                                    mlTemplateNames.Add(mls.Imports[e].DepotPathStr);

                                                    string path1 = Path.Combine(matRepo, Path.ChangeExtension(mls.Imports[e].DepotPathStr, ".mltemplate.json"));
                                                    if (!File.Exists(path1))
                                                    {
                                                        if (!new FileInfo(path1).Directory.Exists)
                                                        {
                                                            Directory.CreateDirectory(new FileInfo(path1).Directory.FullName);
                                                        }
                                                        mlt.FileName = mls.Imports[e].DepotPathStr;
                                                        var dto1 = new Red4W2rcFileDto(mlt);
                                                        var doc1 = JsonConvert.SerializeObject(dto1, settings);
                                                        File.WriteAllText(path1, doc1);
                                                    }

                                                    for (int eye = 0; eye < mlt.Imports.Count; eye++)
                                                    {
                                                        if (!TexturesList.Contains(mlt.Imports[eye].DepotPathStr))
                                                            TexturesList.Add(mlt.Imports[eye].DepotPathStr);

                                                        ulong hash3 = FNV1A64HashAlgorithm.HashString(mlt.Imports[eye].DepotPathStr);
                                                        foreach (Archive arrr in archives)
                                                        {
                                                            if (arrr.Files.ContainsKey(hash3))
                                                            {
                                                                if (!File.Exists(Path.Combine(matRepo, Path.ChangeExtension(mlt.Imports[eye].DepotPathStr,"." + exportArgs.Get<XbmExportArgs>().UncookExtension.ToString()))))
                                                                {
                                                                    if (Directory.Exists(matRepo))
                                                                        UncookSingle(arrr, hash3, new DirectoryInfo(matRepo), exportArgs);
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



            List<RawMaterial> RawMaterials = new List<RawMaterial>();
            Dictionary<string, CMaterialTemplate> usedMts = new Dictionary<string, CMaterialTemplate>();
            for (int i = 0; i < materialEntries.Count; i++)
            {
                RawMaterials.Add(ContainRawMaterial(materialEntries[i], materialEntryNames[i],archives, ref usedMts));
            }
            
            List<RawMaterial> matTemplates = new List<RawMaterial>();
            {
                var keys = usedMts.Keys.ToList();
                for (int i = 0; i < keys.Count; i++)
                {
                    var rawMat = new RawMaterial();
                    rawMat.Name = keys[i];
                    rawMat.Data = new Dictionary<string, object>();
                    for (int e = 0; e < usedMts[keys[i]].Parameters[2].Count; e++)
                    {
                        var refer = usedMts[keys[i]].Parameters[2][e].GetReference().Data;
                        if (refer.ChildrEditableVariables.Count > 2)
                        {
                            if(refer.ChildrEditableVariables[2] is Vector4 vec)
                            {
                                vec.X.Value = 0f;
                                vec.Y.Value = 0f;
                                vec.Z.Value = 0f;
                                vec.W.Value = 0f;
                                vec.X.IsSerialized = true;
                                vec.Y.IsSerialized = true;
                                vec.Z.IsSerialized = true;
                                vec.W.IsSerialized = true;
                            }
                            if (refer.ChildrEditableVariables[2] is CFloat flo)
                            {
                                flo.Value = 0f;
                                flo.IsSerialized = true;
                            }
                            if (refer.ChildrEditableVariables[2] is CColor col)
                            {
                                col.Red.Value = 0;
                                col.Green.Value = 0;
                                col.Blue.Value = 0;
                                col.Alpha.Value = 0;
                                col.Red.IsSerialized = true;
                                col.Green.IsSerialized = true;
                                col.Blue.IsSerialized = true;
                                col.Alpha.IsSerialized = true;
                            }
                            if (refer.ChildrEditableVariables[2] is IREDRef dep)
                            {
                                dep.DepotPath = "";
                                dep.IsSerialized = true;
                            }
                            refer.ChildrEditableVariables[2].IsSerialized = true;
                            rawMat.Data.Add((refer.ChildrEditableVariables[0] as CName).Value, refer.ChildrEditableVariables[2].ToObject());
                        }
                    }
                    matTemplates.Add(rawMat);
                }
            }
            
            var obj = new { MaterialRepo = matRepo, Materials = RawMaterials, Info = "Following data is for reference only, has no impact on imports",
                TexturesList, MaterialTemplates = matTemplates };

            string str = JsonConvert.SerializeObject(obj, settings);

            File.WriteAllText(Path.ChangeExtension(outfile.FullName,".Material.json"), str);

        }
        private RawMaterial ContainRawMaterial(CMaterialInstance cMaterialInstance, string Name, List<Archive> archives, ref Dictionary<string, CMaterialTemplate> mts)
        {
            RawMaterial rawMaterial = new RawMaterial();

            rawMaterial.Name = Name;
            rawMaterial.BaseMaterial = cMaterialInstance.BaseMaterial.DepotPath;

            List<CMaterialInstance> BaseMaterials = new List<CMaterialInstance>();

            string path = cMaterialInstance.BaseMaterial.DepotPath;
            ulong hash = FNV1A64HashAlgorithm.HashString(path);
            while (!Path.GetExtension(path).Contains("mt"))
            {
                hash = FNV1A64HashAlgorithm.HashString(path);
                foreach (Archive ar in archives)
                {
                    if (ar.Files.ContainsKey(hash))
                    {
                        var ms = new MemoryStream();
                        ModTools.ExtractSingleToStream(ar, hash, ms);
                        var mi = _wolvenkitFileService.TryReadCr2WFile(ms);
                        BaseMaterials.Add(mi.Chunks[0].Data as CMaterialInstance);
                        path = (mi.Chunks[0].Data as CMaterialInstance).BaseMaterial.DepotPath;
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
                foreach (Archive ar in archives)
                {
                    if (ar.Files.ContainsKey(hash))
                    {
                        var ms = new MemoryStream();
                        ModTools.ExtractSingleToStream(ar, hash, ms);
                        mt = _wolvenkitFileService.TryReadRED4File(ms).Chunks.Select(_ => _.Data).OfType<CMaterialTemplate>().First();
                        mts.Add(path, mt);
                        break;
                    }
                }
            }
            rawMaterial.MaterialTemplate = path;

            rawMaterial.Data = new Dictionary<string, object>();
            for (int i = 0; i < mt.UsedParameters[2].Count; i++)
            {
                for (int e = 0; e < mt.Parameters[2].Count; e++)
                {
                    var refer = mt.Parameters[2][e].GetReference().Data;
                    if((refer.ChildrEditableVariables[0] as CName).Value == mt.UsedParameters[2][i].Name.Value)
                    {
                        // childreditablevars indexing is dangerous(what if someone changes order of vars), just works :D
                        if(refer.ChildrEditableVariables.Count > 2 && refer.ChildrEditableVariables[2].IsSerialized)
                        {
                            rawMaterial.Data.Add(mt.UsedParameters[2][i].Name.Value, refer.ChildrEditableVariables[2].ToObject());
                        }
                    }
                }
            }

            BaseMaterials.Add(cMaterialInstance);
            for (int i = 0; i < BaseMaterials.Count; i++)
            {
                for (int e = 0; e < BaseMaterials[i].CMaterialInstanceData.Count; e++)
                {
                    if (rawMaterial.Data.ContainsKey(BaseMaterials[i].CMaterialInstanceData[e].REDName))
                    {
                        rawMaterial.Data[BaseMaterials[i].CMaterialInstanceData[e].REDName] = BaseMaterials[i].CMaterialInstanceData[e].Variant.ToObject();
                    }
                    else
                    {
                        rawMaterial.Data.Add(BaseMaterials[i].CMaterialInstanceData[e].REDName, BaseMaterials[i].CMaterialInstanceData[e].Variant.ToObject());
                    }
                }
            }

            return rawMaterial;
        }
        private static MemoryStream GetMaterialStream(Stream ms, CR2WFile cr2w)
        {
            var blob = cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().First();

            UInt16 p = blob.LocalMaterialBuffer.RawData.Buffer.Value;
            var b = cr2w.Buffers[p - 1];
            ms.Seek(b.Offset, SeekOrigin.Begin);
            MemoryStream materialStream = new MemoryStream();
            ms.DecompressAndCopySegment(materialStream, b.DiskSize, b.MemSize);
            return materialStream;
        }
        public bool WriteMatToMesh(ref CR2WFile cr2w, string _matData, List<Archive> archives)
        {
            if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any() || !cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any() || cr2w.Buffers.Count < 1)
            {
                return false;
            }
            var obj = JsonConvert.DeserializeObject<MatData>(_matData);

            var materialbuffer = new MemoryStream();
            List<UInt32> offsets = new List<UInt32>();
            List<UInt32> sizes = new List<UInt32>();
            List<string> names = new List<string>();

            if (obj.Materials.Count < 1)
                return false;

            Dictionary<string, CMaterialTemplate> mts = new Dictionary<string, CMaterialTemplate>();
            for (int i = 0; i < obj.Materials.Count; i++)
            {
                var mat = obj.Materials[i];
                names.Add(mat.Name);
                CR2WFile mi = new CR2WFile();
                {
                    var chunk = new CMaterialInstance(mi, null, "CMaterialInstance") { IsSerialized = true };
                    chunk.CookingPlatform = new CEnum<Enums.ECookingPlatform>(mi, chunk, "cookingPlatform") { IsSerialized = true, Value = Enums.ECookingPlatform.PLATFORM_PC };
                    chunk.CookingPlatform.EnumValueList.Add("PLATFORM_PC");
                    chunk.ResourceVersion = new CUInt8(mi, chunk, "resourceVersion") { IsSerialized = true, Value = 4 };
                    chunk.BaseMaterial = new rRef<IMaterial>(mi, chunk, "baseMaterial") { IsSerialized = true, DepotPath = mat.BaseMaterial };
                    chunk.CMaterialInstanceData = new CArray<CVariantSizeNameType>(mi, chunk, "CMaterialInstanceData") { IsSerialized = true };

                    CMaterialTemplate mt = null;
                    if (mts.ContainsKey(mat.MaterialTemplate))
                    {
                        mt = mts[mat.MaterialTemplate];
                    }
                    else
                    {
                        ulong hash = FNV1A64HashAlgorithm.HashString(mat.MaterialTemplate);
                        foreach (Archive ar in archives)
                        {
                            if (ar.Files.ContainsKey(hash))
                            {
                                var ms = new MemoryStream();
                                ModTools.ExtractSingleToStream(ar, hash, ms);
                                mt = _wolvenkitFileService.TryReadRED4File(ms).Chunks.Select(_ => _.Data).OfType<CMaterialTemplate>().First();
                                mts.Add(mat.MaterialTemplate, mt);
                                break;
                            }
                        }
                    }
                    var keys = obj.Materials[i].Data.Keys.ToList();
                    if (mt != null)
                    {
                        for (int j = 0; j < keys.Count; j++)
                        {
                            string typename = null;
                            for (int k = 0; k < mt.Parameters[2].Count; k++)
                            {
                                var refer = mt.Parameters[2][k].GetReference().Data;
                                if((refer.ChildrEditableVariables[0] as CName).Value == keys[j])
                                {
                                    if (refer.ChildrEditableVariables.Count > 2)
                                    {
                                        typename = refer.ChildrEditableVariables[2].REDType;
                                    }
                                }
                            }
                            if(typename != null)
                            {
                                var variant = new CVariantSizeNameType(mi, chunk.CMaterialInstanceData, keys[j]);
                                var value = CR2WTypeManager.Create(typename, keys[j], mi, variant);
                                value.IsSerialized = true;
                                value.SetFromJObject(obj.Materials[i].Data[keys[j]]);
                                variant.SetVariant(value);
                                chunk.CMaterialInstanceData.Add(variant);
                            }
                        }
                    }


                    mi.CreateChunk(chunk, 0);
                }

                offsets.Add((UInt32)materialbuffer.Position);
                var m = new MemoryStream();
                var b = new BinaryWriter(m);
                mi.Write(b);
                materialbuffer.Write(m.ToArray(), 0, (int)m.Length);
                sizes.Add((UInt32)m.Length);
            }

            var blob = cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().First();

            // remove existing data
            while (blob.MaterialEntries.Count != 0)
            {
                blob.MaterialEntries.Remove(blob.MaterialEntries[blob.MaterialEntries.Count - 1]);
            }
            while (blob.LocalMaterialBuffer.RawDataHeaders.Count != 0)
            {
                blob.LocalMaterialBuffer.RawDataHeaders.Remove(blob.LocalMaterialBuffer.RawDataHeaders[blob.LocalMaterialBuffer.RawDataHeaders.Count - 1]);
            }
            while (blob.PreloadLocalMaterialInstances.Count != 0)
            {
                blob.PreloadLocalMaterialInstances.Remove(blob.PreloadLocalMaterialInstances[blob.PreloadLocalMaterialInstances.Count - 1]);
            }
            while (blob.PreloadExternalMaterials.Count != 0)
            {
                blob.PreloadExternalMaterials.Remove(blob.PreloadExternalMaterials[blob.PreloadExternalMaterials.Count - 1]);
            }
            while (blob.ExternalMaterials.Count != 0)
            {
                blob.ExternalMaterials.Remove(blob.ExternalMaterials[blob.ExternalMaterials.Count - 1]);
            }
            while (blob.LocalMaterialInstances.Count != 0)
            {
                blob.LocalMaterialInstances.Remove(blob.LocalMaterialInstances[blob.LocalMaterialInstances.Count - 1]);
            }
            //
            for (int i = 0; i < names.Count; i++)
            {
                var c = new CMeshMaterialEntry(cr2w, blob.MaterialEntries, Convert.ToString(i)) { IsSerialized = true, };
                c.IsLocalInstance = new CBool(cr2w, c, "isLocalInstance") { Value = true, IsSerialized = true };
                c.Name = new CName(cr2w, c, "name") { Value = names[i], IsSerialized = true };
                c.Index = new CUInt16(cr2w, c, "index") { Value = (UInt16)i, IsSerialized = true };
                blob.MaterialEntries.Add(c);

                var m = new meshLocalMaterialHeader(cr2w, blob.LocalMaterialBuffer.RawDataHeaders, Convert.ToString(i)) { IsSerialized = true };
                m.Offset = new CUInt32(cr2w, m, "offset") { Value = offsets[i], IsSerialized = true };
                m.Size = new CUInt32(cr2w, m, "size") { Value = sizes[i], IsSerialized = true };
                blob.LocalMaterialBuffer.RawDataHeaders.Add(m);
            }

            var compressed = new MemoryStream();
            using var buff = new BinaryWriter(compressed);
            var (zsize, crc) = buff.CompressAndWrite(materialbuffer.ToArray());

            bool check = false;
            check = blob.LocalMaterialBuffer.RawData.IsSerialized;
            if (!check)
            {
                blob.LocalMaterialBuffer.RawData = new DataBuffer(cr2w, blob.LocalMaterialBuffer, "rawData") { IsSerialized = true };
                blob.LocalMaterialBuffer.RawData.Buffer = new CUInt16(cr2w, blob.LocalMaterialBuffer.RawData, "Buffer") { Value = (UInt16)(cr2w.Buffers.Count + 1), IsSerialized = true};

                uint idx = (uint)cr2w.Buffers.Count;
                cr2w.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()
                {
                    flags = 0,
                    index = idx,
                    offset = 0,
                    diskSize = zsize,
                    memSize = (UInt32)materialbuffer.Length,
                    crc32 = crc
                }));

                cr2w.Buffers[(int)idx].ReadData(new BinaryReader(compressed));
                cr2w.Buffers[(int)idx].Offset = cr2w.Buffers[(int)idx - 1].Offset + cr2w.Buffers[(int)idx - 1].DiskSize;
            }
            else
            {
                UInt16 p = (blob.LocalMaterialBuffer.RawData.Buffer.Value);
                cr2w.Buffers[p - 1].DiskSize = zsize;
                cr2w.Buffers[p - 1].Crc32 = crc;
                cr2w.Buffers[p - 1].MemSize = (UInt32)materialbuffer.Length;
                var off = cr2w.Buffers[p - 1].Offset;
                cr2w.Buffers[p - 1].Offset = 0;
                cr2w.Buffers[p - 1].ReadData(new BinaryReader(compressed));
                cr2w.Buffers[p - 1].Offset = off;
            }

            return true;
        }
    }
}
