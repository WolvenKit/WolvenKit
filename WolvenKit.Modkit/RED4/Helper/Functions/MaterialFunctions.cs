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
using WolvenKit.Modkit.RED4.MaterialSetupFile;
using SharpGLTF.IO;
using System.Threading;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Common.Model.Cr2w;
using Newtonsoft.Json;
using WolvenKit.Modkit.RED4.Materials;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.Common;

namespace WolvenKit.Modkit.RED4
{
    using Vec3 = System.Numerics.Vector3;
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
            DirectoryInfo outDir = new DirectoryInfo(Path.Combine(outfile.DirectoryName, Path.GetFileNameWithoutExtension(outfile.FullName)));

            MeshTools.MeshBones meshBones = new MeshTools.MeshBones();

            meshBones.boneCount = cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().First().BoneNames.Count;

            if (meshBones.boneCount != 0)    // for rigid meshes
            {
                meshBones.Names = RIG.GetboneNames(cr2w, "CMesh");
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

            if (!outDir.Exists)
            {
                Directory.CreateDirectory(outDir.FullName);
            }

            ParseMaterials(cr2w, meshStream, outDir, archives, matRepo, eUncookExtension);

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
        private void ParseMaterials(CR2WFile cr2w ,Stream meshStream, DirectoryInfo outDir, List<Archive> archives,string matRepo, EUncookExtension eUncookExtension = EUncookExtension.dds)
        {
            List<string> primaryDependencies = new List<string>();

            List<string> materialEntryNames = new List<string>();
            List<CMaterialInstance> materialEntries = new List<CMaterialInstance>();

            GetMateriaEntries(cr2w, meshStream, ref primaryDependencies, ref materialEntryNames, ref materialEntries, archives);

            List<string> mlSetupNames = new List<string>();
            List<Multilayer_Setup> mlSetups = new List<Multilayer_Setup>();

            List<string> mlTemplateNames = new List<string>();
            List<Multilayer_LayerTemplate> mlTemplates = new List<Multilayer_LayerTemplate>();

            List<HairProfile> HairProfiles = new List<HairProfile>();
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
                            if (!File.Exists(Path.Combine(matRepo, primaryDependencies[i].Replace("xbm",exportArgs.Get<XbmExportArgs>().UncookExtension.ToString()))))
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
                    if (!HairProfileNames.Contains(Path.GetFileName(primaryDependencies[i])))
                    {
                        HairProfileNames.Add(Path.GetFileName(primaryDependencies[i]));
                        ulong hash = FNV1A64HashAlgorithm.HashString(primaryDependencies[i]);
                        foreach (Archive ar in archives)
                        {
                            if (ar.Files.ContainsKey(hash))
                            {
                                var ms = new MemoryStream();
                                ExtractSingleToStream(ar, hash, ms);
                                var hp = _wolvenkitFileService.TryReadCr2WFile(ms);
                                HairProfiles.Add(new HairProfile(hp.Chunks[0].Data as CHairProfile, Path.GetFileName(primaryDependencies[i])));
                                break;
                            }
                        }
                    }
                }

                if (Path.GetExtension(primaryDependencies[i]) == ".mlsetup")
                {
                    ulong hash = FNV1A64HashAlgorithm.HashString(primaryDependencies[i]);
                    foreach (Archive ar in archives)
                    {
                        if(ar.Files.ContainsKey(hash))
                        {
                            var ms = new MemoryStream();
                            ExtractSingleToStream(ar, hash, ms);
                            var mls = _wolvenkitFileService.TryReadCr2WFile(ms);
                            mlSetupNames.Add(Path.GetFileName(primaryDependencies[i]));
                            mlSetups.Add(mls.Chunks[0].Data as Multilayer_Setup);

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
                                            if (!File.Exists(Path.Combine(matRepo, mls.Imports[e].DepotPathStr.Replace("xbm", exportArgs.Get<XbmExportArgs>().UncookExtension.ToString()))))
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
                                    ulong hash2 = FNV1A64HashAlgorithm.HashString(mls.Imports[e].DepotPathStr);
                                    foreach (Archive arr in archives)
                                    {
                                        if (arr.Files.ContainsKey(hash2))
                                        {
                                            var mss = new MemoryStream();
                                            ExtractSingleToStream(arr, hash2, mss);

                                            var mlt = _wolvenkitFileService.TryReadCr2WFile(mss);
                                            mlTemplateNames.Add(Path.GetFileName(mls.Imports[e].DepotPathStr));
                                            mlTemplates.Add(mlt.Chunks[0].Data as Multilayer_LayerTemplate);

                                            for (int eye = 0; eye < mlt.Imports.Count; eye++)
                                            {
                                                if (!TexturesList.Contains(mlt.Imports[eye].DepotPathStr))
                                                    TexturesList.Add(mlt.Imports[eye].DepotPathStr);

                                                ulong hash3 = FNV1A64HashAlgorithm.HashString(mlt.Imports[eye].DepotPathStr);
                                                foreach (Archive arrr in archives)
                                                {
                                                    if (arrr.Files.ContainsKey(hash3))
                                                    {
                                                        if (!File.Exists(Path.Combine(matRepo, mlt.Imports[eye].DepotPathStr.Replace("xbm", exportArgs.Get<XbmExportArgs>().UncookExtension.ToString()))))
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
                            break;
                        }
                    }
                }
            }

            List<RawMaterial> RawMaterials = new List<RawMaterial>();
            for (int i = 0; i < materialEntries.Count; i++)
            {
                RawMaterials.Add(ContainRawMaterial(materialEntries[i], materialEntryNames[i],archives));
            }

            List<Setup> MaterialSetups = new List<Setup>();
            for (int i = 0; i < mlSetups.Count; i++)
            {
                MaterialSetups.Add(new Setup(mlSetups[i], mlSetupNames[i]));
            }

            List<Template> MaterialTemplates = new List<Template>();
            for (int i = 0; i < mlTemplates.Count; i++)
            {
                MaterialTemplates.Add(new Template(mlTemplates[i], mlTemplateNames[i]));
            }
            var obj = new { MaterialRepo = matRepo, Materials = RawMaterials,HairProfiles = HairProfiles, MaterialSetups = MaterialSetups, MaterialTemplates = MaterialTemplates };

            var settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.Formatting = Formatting.Indented;

            string str = JsonConvert.SerializeObject(obj, settings);

            File.WriteAllLines(Path.Combine(outDir.FullName,"Textures.txt"), TexturesList);
            File.WriteAllText(Path.Combine(outDir.FullName,"Material.json"), str);

        }
        private RawMaterial ContainRawMaterial(CMaterialInstance cMaterialInstance, string Name, List<Archive> archives)
        {
            RawMaterial rawMaterial = new RawMaterial();

            rawMaterial.Name = Name;
            rawMaterial.BaseMaterial = cMaterialInstance.BaseMaterial.DepotPath;

            List<CMaterialInstance> BaseMaterials = new List<CMaterialInstance>();

            string path = cMaterialInstance.BaseMaterial.DepotPath;
            while (!Path.GetExtension(path).Contains("mt"))
            {
                ulong hash = FNV1A64HashAlgorithm.HashString(path);
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

            string type = Path.GetFileName(path);
            
            BaseMaterials.Reverse();
            for(int i = 0; i < BaseMaterials.Count; i++)
            {
                MATERIAL.ContainRawMaterialEnum(ref rawMaterial, BaseMaterials[i], type);
            }
            
            MATERIAL.ContainRawMaterialEnum(ref rawMaterial, cMaterialInstance, type);
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
        public void UnpackLocalBufferMaterials(Stream meshStream, DirectoryInfo unpackDir)
        {
            var cr2w = _wolvenkitFileService.TryReadRED4File(meshStream);
            var blob = cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().First();

            int Count = blob.LocalMaterialBuffer.RawDataHeaders.Count;
            if(Count == 0)
            {
                throw new Exception("Provided .mesh doesn't contain any local material buffer");
            }
            else
            {
                byte[] bytes = GetMaterialStream(meshStream, cr2w).ToArray();
                List<string> names = new List<string>();
                for(int i = 0; i < blob.MaterialEntries.Count; i++)
                {
                    if(blob.MaterialEntries[i].IsLocalInstance.Value)
                    {
                        names.Add(blob.MaterialEntries[i].Name.Value);
                    }
                }
                for (int i = 0; i < Count; i++)
                {
                    UInt32 offset = blob.LocalMaterialBuffer.RawDataHeaders[i].Offset.Value;
                    UInt32 size = blob.LocalMaterialBuffer.RawDataHeaders[i].Size.Value;
                    MemoryStream ms = new MemoryStream(bytes, (int)offset, (int)size);

                    File.WriteAllBytes(unpackDir.FullName + "\\" + names[i] + ".mi", ms.ToArray());
                }
            }
            meshStream.Dispose();
            meshStream.Close();
        }
        public void PackMaterialToLocalBuffer(DirectoryInfo packDir, Stream inmeshStream, FileInfo outMeshFile)
        {
            var cr2w = _wolvenkitFileService.TryReadCr2WFile(inmeshStream);
            var blob = cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().First();

            int Count = blob.LocalMaterialBuffer.RawDataHeaders.Count;
            if (Count == 0)
            {
                throw new Exception("Provided .mesh doesn't contain any local material buffer");
            }
            else
            {
                List<string> names = new List<string>();
                for (int i = 0; i < blob.MaterialEntries.Count; i++)
                {
                    if (blob.MaterialEntries[i].IsLocalInstance.Value)
                    {
                        names.Add(blob.MaterialEntries[i].Name.Value);
                    }
                }

                string[] mifiles = Directory.GetFiles(packDir.FullName, "*.mi");
                if (mifiles.Length != names.Count)
                {
                    throw new Exception("Provided .mi files doesn't match the number of local material entries in the provided mesh file");
                }
                MemoryStream buffer = new MemoryStream();
                BinaryWriter writer = new BinaryWriter(buffer);
                for (int i = 0; i < names.Count; i++)
                {
                    bool notfound = true;
                    for (int e = 0; e < mifiles.Length; e++)
                    {
                        if (Path.GetFileNameWithoutExtension(mifiles[e]) == names[i])
                        {
                            notfound = false;
                            blob.LocalMaterialBuffer.RawDataHeaders[i].Offset.Value = Convert.ToUInt32(buffer.Length);
                            byte[] bytes = File.ReadAllBytes(mifiles[e]);
                            writer.Write(bytes);
                            blob.LocalMaterialBuffer.RawDataHeaders[i].Size.Value = Convert.ToUInt32(bytes.Length);

                        }
                    }
                    if (notfound)
                    {
                        throw new Exception("One or more names of .mi files doesn't match the names of material enteries in provided mesh file");
                    }
                }

                UInt16 p = (blob.LocalMaterialBuffer.RawData.Buffer.Value);

                var compressed = new MemoryStream();
                using var buff = new BinaryWriter(compressed);
                var (zsize, crc) = buff.CompressAndWrite(buffer.ToArray());

                cr2w.Buffers[p - 1].DiskSize = zsize;
                cr2w.Buffers[p - 1].Crc32 = crc;
                cr2w.Buffers[p - 1].MemSize = (UInt32)buffer.Length;
                var off = cr2w.Buffers[p - 1].Offset;
                cr2w.Buffers[p - 1].Offset = 0;
                cr2w.Buffers[p - 1].ReadData(new BinaryReader(compressed));
                cr2w.Buffers[p - 1].Offset = off;


                MemoryStream ms = new MemoryStream();
                BinaryWriter bw = new BinaryWriter(ms);
                cr2w.Write(bw);

                File.WriteAllBytes(outMeshFile.FullName, ms.ToArray());
            }
            inmeshStream.Dispose();
            inmeshStream.Close();

        }
        public bool WriteMatToMesh(ref CR2WFile cr2w, string _matData, Archive ar)
        {
            if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any() || !cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any() || cr2w.Buffers.Count < 1)
            {
                return false;
            }

            ulong hash = FNV1A64HashAlgorithm.HashString("base\\characters\\common\\skin\\old_mat_instances\\skin_ma_a__head.mi");
            if (!ar.Files.ContainsKey(hash))
                return false;

            var ms = new MemoryStream();
            ModTools.ExtractSingleToStream(ar, hash, ms);
            _wolvenkitFileService.TryReadRED4File(ms);
            ms.Seek(0, SeekOrigin.Begin);

            var obj = JsonConvert.DeserializeObject<MatData>(_matData);

            var materialbuffer = new MemoryStream();
            List<UInt32> offsets = new List<UInt32>();
            List<UInt32> sizes = new List<UInt32>();
            List<string> names = new List<string>();

            if (obj.Materials.Count < 1)
                return false;

            for (int i = 0; i < obj.Materials.Count; i++)
            {
                var mat = obj.Materials[i];
                names.Add(mat.Name);
                var mi = _wolvenkitFileService.TryReadRED4File(ms);
                ms.Seek(0, SeekOrigin.Begin);
                MATERIAL.WriteMatToMeshEnum(ref mi, ref mat);
                (mi.Chunks[0].Data as CMaterialInstance).BaseMaterial.DepotPath = mat.BaseMaterial;

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
