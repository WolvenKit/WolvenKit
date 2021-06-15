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
using WolvenKit.Modkit.RED4.Materials.Types;
using WolvenKit.Common.DDS;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Common.FNV1A;
using WolvenKit.Modkit.RED4.MaterialSetupFile;
using SharpGLTF.IO;
using System.Threading;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using Newtonsoft.Json;

namespace WolvenKit.Modkit.RED4
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public partial class ModTools
    {
        public bool ExportMeshWithMaterials(Stream meshStream, FileInfo outfile, List<Archive> archives, EUncookExtension eUncookExtension = EUncookExtension.dds, bool isGLBinary = true, bool LodFilter = true)
        {
            var cr2w = _wolvenkitFileService.TryReadRED4File(meshStream);
            if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any() || !cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
            {
                return false;
            }
            DirectoryInfo outDir = new DirectoryInfo(Path.Combine(outfile.DirectoryName, Path.GetFileNameWithoutExtension(outfile.FullName)));

            MemoryStream ms = MeshTools.GetMeshBufferStream(meshStream, cr2w);
            MeshesInfo meshinfo = MeshTools.GetMeshesinfo(cr2w);

            List<RawMeshContainer> expMeshes = MeshTools.ContainRawMesh(ms, meshinfo, LodFilter);

            ModelRoot model = MeshTools.RawMeshesToGLTF(expMeshes,null);

            if (!outDir.Exists)
            {
                Directory.CreateDirectory(outDir.FullName);
            }

            ParseMaterials(cr2w, meshStream, outDir, archives, eUncookExtension);

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
        }
        private void ParseMaterials(CR2WFile cr2w ,Stream meshStream, DirectoryInfo outDir, List<Archive> archives, EUncookExtension eUncookExtension = EUncookExtension.dds)
        {
            List<string> primaryDependencies = new List<string>();

            List<string> materialEntryNames = new List<string>();
            List<CMaterialInstance> materialEntries = new List<CMaterialInstance>();

            GetMateriaEntries(cr2w, meshStream, ref primaryDependencies, ref materialEntryNames, ref materialEntries, archives);

            List<string> mlSetupNames = new List<string>();
            List<Multilayer_Setup> mlSetups = new List<Multilayer_Setup>();

            List<string> mlTemplateNames = new List<string>();
            List<Multilayer_LayerTemplate> mlTemplates = new List<Multilayer_LayerTemplate>();

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
                            UncookSingle(ar, hash, outDir, exportArgs);
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
                            UncookSingle(ar, hash, outDir, exportArgs);
                            break;
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
                                            UncookSingle(arr, hash1, outDir, exportArgs);
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
                                                        UncookSingle(arrr, hash3, outDir, exportArgs);
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
                RawMaterials.Add(ContainRawMaterial(materialEntries[i], materialEntryNames[i]));
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
            var obj = new { RawMaterials = RawMaterials, MaterialSetups = MaterialSetups, MaterialTemplates = MaterialTemplates };

            var settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.Formatting = Formatting.Indented;

            string str = JsonConvert.SerializeObject(obj, settings);

            File.WriteAllLines(Path.Combine(outDir.FullName,"Textures.txt"), TexturesList);
            File.WriteAllText(Path.Combine(outDir.FullName,"Material.json"), str);

        }
        private static RawMaterial ContainRawMaterial(CMaterialInstance cMaterialInstance, string Name)
        {
            RawMaterial rawMaterial = new RawMaterial();

            rawMaterial.Name = Name;

                rawMaterial.BaseMaterial = cMaterialInstance.BaseMaterial.DepotPath;
                rawMaterial.MaterialInstanceData = new MaterialInstanceData(cMaterialInstance);

                if (Path.GetFileNameWithoutExtension(cMaterialInstance.BaseMaterial.DepotPath) == "multilayered")
                    rawMaterial.MaterialType = MaterialType.MultiLayered;

                if (Path.GetFileNameWithoutExtension(cMaterialInstance.BaseMaterial.DepotPath) == "mesh_decal")
                    rawMaterial.MaterialType = MaterialType.MeshDecal;

                if (cMaterialInstance.BaseMaterial.DepotPath.Contains("skin"))
                    rawMaterial.MaterialType = MaterialType.HumanSkin;

                if (Path.GetFileNameWithoutExtension(cMaterialInstance.BaseMaterial.DepotPath) == "metal_base")
                    rawMaterial.MaterialType = MaterialType.MetalBase;

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
    }
    public partial class ModTools
    {
        public Thread GenerateMaterialRepo(DirectoryInfo gameArchiveDir, DirectoryInfo materialRepoDir, EUncookExtension texturesExtension)
        {
            GameArchiveDir = gameArchiveDir;
            MaterialRepoDir = materialRepoDir;
            TexturesExtension = texturesExtension;

            var thread = new Thread(GenerateInBG) {IsBackground = true};
            thread.Start();
            return thread;
        }

        private void GenerateInBG()
        {
            var filenames = Directory.GetFiles(GameArchiveDir.FullName, "*.archive", SearchOption.AllDirectories);
            var archives = new List<Archive>();

            for (int i = 0; i < filenames.Length; i++)
            {
                archives.Add(Red4ParserServiceExtensions.ReadArchive(filenames[i], _hashService));
            }

            var exportArgs =
                new GlobalExportArgs().Register(
                    new XbmExportArgs() { UncookExtension = TexturesExtension },
                    new MlmaskExportArgs() { UncookExtension = TexturesExtension }
                );

            foreach (var ar in archives)
            {
                ExtractAll(ar, MaterialRepoDir, "*.gradient");
                ExtractAll(ar, MaterialRepoDir, "*.w2mi");
                ExtractAll(ar, MaterialRepoDir, "*.matlib");
                ExtractAll(ar, MaterialRepoDir, "*.remt");
                ExtractAll(ar, MaterialRepoDir, "*.sp");
                ExtractAll(ar, MaterialRepoDir, "*.hp");
                ExtractAll(ar, MaterialRepoDir, "*.fp");
                ExtractAll(ar, MaterialRepoDir, "*.mi");
                ExtractAll(ar, MaterialRepoDir, "*.mt");
                ExtractAll(ar, MaterialRepoDir, "*.mlsetup");
                ExtractAll(ar, MaterialRepoDir, "*.mltemplate");
                ExtractAll(ar, MaterialRepoDir, "*.texarray");

                UncookAll(ar, MaterialRepoDir, exportArgs, false, "*.xbm", "" );
                UncookAll(ar, MaterialRepoDir, exportArgs, false, "*.mlmask", "");
                // try catch the decode in mlmask.cs for now
            }
        }
        static DirectoryInfo GameArchiveDir;
        static DirectoryInfo MaterialRepoDir;
        static EUncookExtension TexturesExtension;
    }
}
