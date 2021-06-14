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
using WolvenKit.Modkit.RED4.MeshFile;
using WolvenKit.Modkit.RED4.Materials.Types;
using WolvenKit.Common.DDS;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Common.FNV1A;
using WolvenKit.Modkit.RED4.MaterialSetupFile;
using SharpGLTF.IO;
using System.Threading;
using Catel.IoC;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Modkit.RED4;

namespace WolvenKit.Modkit.RED4
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public partial class ModTools
    {
        static string cacheDir = Path.GetTempPath() + "WolvenKit\\Material\\Temp\\";
        public bool ExportMeshWithMaterialsUsingAssetLib(Stream meshStream, DirectoryInfo assetLib, FileInfo outfile, bool isGLBinary = true, bool copyTextures = false, EUncookExtension eUncookExtension = EUncookExtension.dds, bool LodFilter = true)
        {
            Directory.CreateDirectory(cacheDir);
            var mesh_cr2w = _wolvenkitFileService.TryReadRED4File(meshStream);
            if (mesh_cr2w == null || !mesh_cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any())
            {
                return false;
            }

            if (!mesh_cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
            {
                var tempmodel = (new SharpGLTF.Scenes.SceneBuilder()).ToGltf2();
                DirectoryInfo dir = new DirectoryInfo(outfile.DirectoryName + "\\" + Path.GetFileNameWithoutExtension(outfile.FullName) + "_Textures\\");
                ParseMaterialsUsingAssetLib(meshStream, ref tempmodel, dir, assetLib, copyTextures, eUncookExtension);
                if (isGLBinary)
                    tempmodel.SaveGLB(outfile.FullName);
                else
                    tempmodel.SaveGLTF(outfile.FullName);
                return true;
            }


            MemoryStream ms = MeshTools.GetMeshBufferStream(meshStream, mesh_cr2w);
            MeshesInfo meshinfo = MeshTools.GetMeshesinfo(mesh_cr2w);

            List<RawMeshContainer> expMeshes = MeshTools.ContainRawMesh(ms, meshinfo, LodFilter);

            ModelRoot model = MeshTools.RawMeshesToGLTF(expMeshes,null);

            DirectoryInfo outDir = new DirectoryInfo(outfile.DirectoryName + "\\" + Path.GetFileNameWithoutExtension(outfile.FullName) + "_Textures\\");
            Directory.CreateDirectory(outDir.FullName);

            ParseMaterialsUsingAssetLib(meshStream, ref model, outDir, assetLib, copyTextures, eUncookExtension);

            if (isGLBinary)
                model.SaveGLB(outfile.FullName);
            else
                model.SaveGLTF(outfile.FullName);

            Directory.Delete(cacheDir, true);

            meshStream.Dispose();
            meshStream.Close();

            return true;
        }

        public bool ExportMeshWithMaterialsUsingArchives(Stream meshStream, FileInfo outfile, List<Archive> archives, bool isGLBinary = true, EUncookExtension eUncookExtension = EUncookExtension.dds, bool LodFilter = true)
        {
            Directory.CreateDirectory(cacheDir);
            var mesh_cr2w = _wolvenkitFileService.TryReadRED4File(meshStream);
            if (mesh_cr2w == null || !mesh_cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any())
            {
                return false;
            }

            if (!mesh_cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
            {
                var tempmodel = (new SharpGLTF.Scenes.SceneBuilder()).ToGltf2();
                DirectoryInfo dir = new DirectoryInfo(outfile.DirectoryName + "\\" + Path.GetFileNameWithoutExtension(outfile.FullName) + "_Textures\\");
                if (!dir.Exists)
                {
                    Directory.CreateDirectory(dir.FullName);
                }
                ParseMaterialsUsingArchives(meshStream, ref tempmodel, dir, archives, eUncookExtension);
                if (isGLBinary)
                    tempmodel.SaveGLB(outfile.FullName);
                else
                    tempmodel.SaveGLTF(outfile.FullName);
                return true;
            }

            MemoryStream ms = MeshTools.GetMeshBufferStream(meshStream, mesh_cr2w);
            MeshesInfo meshinfo = MeshTools.GetMeshesinfo(mesh_cr2w);

            List<RawMeshContainer> expMeshes = MeshTools.ContainRawMesh(ms, meshinfo, LodFilter);

            ModelRoot model = MeshTools.RawMeshesToGLTF(expMeshes,null);

            DirectoryInfo outDir = new DirectoryInfo(outfile.DirectoryName + "\\" + Path.GetFileNameWithoutExtension(outfile.FullName) + "_Textures\\");
            if (!outDir.Exists)
            {
                Directory.CreateDirectory(outDir.FullName);
            }

            ParseMaterialsUsingArchives(meshStream, ref model, outDir, archives, eUncookExtension);

            if (isGLBinary)
                model.SaveGLB(outfile.FullName);
            else
                model.SaveGLTF(outfile.FullName);

            Directory.Delete(cacheDir, true);
            meshStream.Dispose();
            meshStream.Close();

            return true;
        }

        private void GetMateriaEntries(Stream meshStream, ref List<string> primaryDependencies,ref List<string> materialEntryNames, ref List<CMaterialInstance> materialEntries, DirectoryInfo assetLib, bool useAssetLib, List<Archive> archives)
        {
            var cr2w = _wolvenkitFileService.TryReadRED4File(meshStream);

            int index = 0;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "CMesh")
                {
                    index = i;
                }
            }

            List<CMaterialInstance> ExternalMaterial = new List<CMaterialInstance>();
            for (int i = 0; i < (cr2w.Chunks[index].Data as CMesh).ExternalMaterials.Count; i++)
            {
                if (useAssetLib)
                {
                    string path = assetLib.FullName + "\\" + (cr2w.Chunks[index].Data as CMesh).ExternalMaterials[i].DepotPath;
                    if(File.Exists(path))
                    {
                        FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                        var micr2w = _wolvenkitFileService.TryReadCr2WFile(fs);
                        ExternalMaterial.Add(micr2w.Chunks[0].Data as CMaterialInstance);

                        for (int t = 0; t < micr2w.Imports.Count; t++)
                        {
                            bool notFound = true;
                            for (int e = 0; e < primaryDependencies.Count; e++)
                            {
                                if (primaryDependencies[e] == micr2w.Imports[t].DepotPathStr)
                                    notFound = false;
                            }
                            if (notFound)
                                primaryDependencies.Add(micr2w.Imports[t].DepotPathStr);
                        }
                        fs.Dispose();
                        fs.Close();
                    }
                }
                else
                {
                    string path = (cr2w.Chunks[index].Data as CMesh).ExternalMaterials[i].DepotPath;

                    ulong hash = FNV1A64HashAlgorithm.HashString(path);
                    foreach (Archive ar in archives)
                    {
                        if(ar.Files.ContainsKey(hash))
                            ExtractSingle(ar, hash, new DirectoryInfo(cacheDir));
                    }

                    path = cacheDir + (cr2w.Chunks[index].Data as CMesh).ExternalMaterials[i].DepotPath;

                    if (File.Exists(path))
                    {
                        FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                        var micr2w = _wolvenkitFileService.TryReadCr2WFile(fs);
                        ExternalMaterial.Add(micr2w.Chunks[0].Data as CMaterialInstance);

                        for (int t = 0; t < micr2w.Imports.Count; t++)
                        {
                            bool notFound = true;
                            for (int e = 0; e < primaryDependencies.Count; e++)
                            {
                                if (primaryDependencies[e] == micr2w.Imports[t].DepotPathStr)
                                    notFound = false;
                            }
                            if (notFound)
                                primaryDependencies.Add(micr2w.Imports[t].DepotPathStr);
                        }
                        fs.Dispose();
                        fs.Close();
                    }
                }
            }
            List<CMaterialInstance> LocalMaterial = new List<CMaterialInstance>();

            bool isbuffered = true;
            if ((cr2w.Chunks[index].Data as CMesh).LocalMaterialBuffer.RawDataHeaders.Count == 0)
                isbuffered = false;

            if (isbuffered)
            {
                MemoryStream materialStream = GetMaterialStream(meshStream, cr2w);
                byte[] bytes = materialStream.ToArray();
                for (int i = 0; i < (cr2w.Chunks[index].Data as CMesh).LocalMaterialBuffer.RawDataHeaders.Count; i++)
                {
                    UInt32 offset = (cr2w.Chunks[index].Data as CMesh).LocalMaterialBuffer.RawDataHeaders[i].Offset.Value;
                    UInt32 size = (cr2w.Chunks[index].Data as CMesh).LocalMaterialBuffer.RawDataHeaders[i].Size.Value;

                    MemoryStream ms = new MemoryStream(bytes, (int)offset, (int)size);
                    var mtcr2w = _wolvenkitFileService.TryReadCr2WFile(ms);

                    string path = (mtcr2w.Chunks[0].Data as CMaterialInstance).BaseMaterial.DepotPath;

                    for (int e = 0; e < mtcr2w.Imports.Count; e++)
                    {
                        bool notFound = true;
                        for (int eye = 0; eye < primaryDependencies.Count; eye++)
                        {
                            if (primaryDependencies[eye] == mtcr2w.Imports[e].DepotPathStr)
                                notFound = false;
                        }
                        if (notFound)
                            primaryDependencies.Add(mtcr2w.Imports[e].DepotPathStr);
                    }

                    LocalMaterial.Add(mtcr2w.Chunks[0].Data as CMaterialInstance);
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
                    bool notFound = true;
                    for (int e = 0; e < primaryDependencies.Count; e++)
                    {
                        if (primaryDependencies[e] == cr2w.Imports[i].DepotPathStr)
                            notFound = false;
                    }
                    if (notFound)
                        primaryDependencies.Add(cr2w.Imports[i].DepotPathStr);
                }
            }

            int Count = (cr2w.Chunks[index].Data as CMesh).MaterialEntries.Count;
            for (int i = 0; i < Count; i++)
            {
                var Entry = (cr2w.Chunks[index].Data as CMesh).MaterialEntries[i];
                materialEntryNames.Add(Entry.Name.Value);
                if (Entry.IsLocalInstance.Value)
                    materialEntries.Add(LocalMaterial[Entry.Index.Value]);
                else
                    materialEntries.Add(ExternalMaterial[Entry.Index.Value]);
            }
        }
        private void ParseMaterialsUsingAssetLib(Stream meshStream, ref ModelRoot model, DirectoryInfo outDir, DirectoryInfo AssetLib, bool CopyTextures = false, EUncookExtension eUncookExtension = EUncookExtension.dds)
        {
            List<string> primaryDependencies = new List<string>();

            List<string> materialEntryNames = new List<string>();
            List<CMaterialInstance> materialEntries = new List<CMaterialInstance>();

            GetMateriaEntries(meshStream, ref primaryDependencies, ref materialEntryNames, ref materialEntries, AssetLib, true, null);

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
                    TexturesList.Add(primaryDependencies[i]);
                    if (File.Exists(AssetLib.FullName + "\\" + primaryDependencies[i]))
                    {
                        if (CopyTextures)
                        {
                            File.Copy(AssetLib.FullName + "\\" + primaryDependencies[i], cacheDir + Path.GetFileName(primaryDependencies[i]), true);
                            Export(new FileInfo(cacheDir + Path.GetFileName(primaryDependencies[i])), exportArgs);
                        }
                    }
                }
                if (Path.GetExtension(primaryDependencies[i]) == ".mlmask")
                {
                    TexturesList.Add(primaryDependencies[i]);
                    if (File.Exists(AssetLib.FullName + "\\" + primaryDependencies[i]))
                    {
                        if (CopyTextures)
                        {
                            File.Copy(AssetLib.FullName + "\\" + primaryDependencies[i], cacheDir + Path.GetFileName(primaryDependencies[i]), true);
                            Export(new FileInfo(cacheDir + Path.GetFileName(primaryDependencies[i])), exportArgs);
                        }
                    }
                }

                if (Path.GetExtension(primaryDependencies[i]) == ".mlsetup")
                    if (File.Exists(AssetLib.FullName + "\\" + primaryDependencies[i]))
                    {
                        FileStream setupFs = new FileStream((AssetLib.FullName + "\\" + primaryDependencies[i]), FileMode.Open, FileAccess.Read);
                        var cr2w = _wolvenkitFileService.TryReadCr2WFile(setupFs);
                        mlSetupNames.Add(Path.GetFileName(primaryDependencies[i]));
                        mlSetups.Add(cr2w.Chunks[0].Data as Multilayer_Setup);

                        setupFs.Dispose();
                        setupFs.Close();
                        for (int e = 0; e < cr2w.Imports.Count; e++)
                        {
                            if (Path.GetExtension(cr2w.Imports[e].DepotPathStr) == ".xbm")
                            {
                                TexturesList.Add(cr2w.Imports[e].DepotPathStr);
                                if (File.Exists(AssetLib.FullName + "\\" + cr2w.Imports[e].DepotPathStr))
                                {
                                    if (CopyTextures)
                                    {
                                        File.Copy(AssetLib.FullName + "\\" + cr2w.Imports[e].DepotPathStr, cacheDir + Path.GetFileName(cr2w.Imports[e].DepotPathStr), true);
                                        Export(new FileInfo(cacheDir + Path.GetFileName(cr2w.Imports[e].DepotPathStr)), exportArgs);
                                    }
                                }
                            }
                            if (Path.GetExtension(cr2w.Imports[e].DepotPathStr) == ".mltemplate")
                            {
                                if (File.Exists(AssetLib.FullName + "\\" + cr2w.Imports[e].DepotPathStr))
                                {
                                    FileStream templateFs = new FileStream((AssetLib.FullName + "\\" + cr2w.Imports[e].DepotPathStr), FileMode.Open, FileAccess.Read);
                                    var mlTempcr2w = _wolvenkitFileService.TryReadCr2WFile(templateFs);
                                    mlTemplateNames.Add(Path.GetFileName(cr2w.Imports[e].DepotPathStr));
                                    mlTemplates.Add(mlTempcr2w.Chunks[0].Data as Multilayer_LayerTemplate);

                                    templateFs.Dispose();
                                    templateFs.Close();
                                    for (int eye = 0; eye < mlTempcr2w.Imports.Count; eye++)
                                    {
                                        TexturesList.Add(mlTempcr2w.Imports[eye].DepotPathStr);
                                        if (File.Exists(AssetLib.FullName + "\\" + mlTempcr2w.Imports[eye].DepotPathStr))
                                        {
                                            if (CopyTextures)
                                            {
                                                File.Copy(AssetLib.FullName + "\\" + mlTempcr2w.Imports[eye].DepotPathStr, cacheDir + Path.GetFileName(mlTempcr2w.Imports[eye].DepotPathStr), true);
                                                Export(new FileInfo(cacheDir + Path.GetFileName(mlTempcr2w.Imports[eye].DepotPathStr)), exportArgs);
                                            }
                                        }
                                    }
                                }
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

                if (RawMaterials.Count > 0)
                {
                    if (MaterialSetups.Count > 0)
                    {
                        if (MaterialTemplates.Count > 0)
                        {
                            var obj = new { AssetLib = AssetLib.FullName, CopyTextures, ValueToBeIgnored = 9999, RawMaterials, MaterialSetups, MaterialTemplates };
                            model.Extras = JsonContent.Serialize(obj);
                            File.WriteAllText(outDir.FullName + "Material.json", JsonContent.Serialize(obj).ToJson());
                        }
                        else
                        {
                            var obj = new { AssetLib = AssetLib.FullName, CopyTextures, ValueToBeIgnored = 9999, RawMaterials, MaterialSetups };
                            model.Extras = JsonContent.Serialize(obj);
                            File.WriteAllText(outDir.FullName + "Material.json", JsonContent.Serialize(obj).ToJson());
                        }
                    }
                    else
                    {
                        var obj = new { AssetLib = AssetLib.FullName, CopyTextures, ValueToBeIgnored = 9999, RawMaterials };
                        model.Extras = JsonContent.Serialize(obj);
                        File.WriteAllText(outDir.FullName + "Material.json", JsonContent.Serialize(obj).ToJson());
                    }
                }

            File.WriteAllLines(outDir.FullName + "Textures List.txt", TexturesList);


            string ext = "*.dds";
            if (eUncookExtension == EUncookExtension.png)
                ext = "*.png";
            if (eUncookExtension == EUncookExtension.bmp)
                ext = "*.bmp";
            if (eUncookExtension == EUncookExtension.jpeg)
                ext = "*.jpeg";
            if (eUncookExtension == EUncookExtension.jpg)
                ext = "*.jpg";
            if (eUncookExtension == EUncookExtension.tga)
                ext = "*.tga";

            string[] files = Directory.GetFiles(cacheDir, ext);

            for (int i = 0; i < files.Length; i++)
            {
                string path = outDir.FullName + files[i].Replace(cacheDir, string.Empty);
                Directory.CreateDirectory(path.Replace(Path.GetFileName(files[i]), string.Empty));
                File.Move(files[i], path, true);
            }
        }
        private void ParseMaterialsUsingArchives(Stream meshStream, ref ModelRoot model, DirectoryInfo outDir, List<Archive> archives, EUncookExtension eUncookExtension = EUncookExtension.dds)
        {
            List<string> primaryDependencies = new List<string>();

            List<string> materialEntryNames = new List<string>();
            List<CMaterialInstance> materialEntries = new List<CMaterialInstance>();

            GetMateriaEntries(meshStream, ref primaryDependencies, ref materialEntryNames, ref materialEntries, new DirectoryInfo(cacheDir), false, archives);

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
                    TexturesList.Add(primaryDependencies[i]);

                    ulong hash = FNV1A64HashAlgorithm.HashString(primaryDependencies[i]);
                    foreach (Archive ar in archives)
                        UncookSingle(ar, hash, new DirectoryInfo(cacheDir), exportArgs);
                }
                if (Path.GetExtension(primaryDependencies[i]) == ".mlmask")
                {
                    TexturesList.Add(primaryDependencies[i]);
                    ulong hash = FNV1A64HashAlgorithm.HashString(primaryDependencies[i]);
                    foreach (Archive ar in archives)
                        UncookSingle(ar, hash, new DirectoryInfo(cacheDir), exportArgs);

                }

                if (Path.GetExtension(primaryDependencies[i]) == ".mlsetup")
                {
                    ulong hash = FNV1A64HashAlgorithm.HashString(primaryDependencies[i]);
                    foreach (Archive ar in archives)
                    {
                        if(ar.Files.ContainsKey(hash))
                            ExtractSingle(ar, hash, new DirectoryInfo(cacheDir));
                    }

                    if (File.Exists(cacheDir + primaryDependencies[i]))
                    {
                        FileStream setupFs = new FileStream((cacheDir + primaryDependencies[i]), FileMode.Open, FileAccess.Read);
                        var cr2w = _wolvenkitFileService.TryReadCr2WFile(setupFs);
                        mlSetupNames.Add(Path.GetFileName(primaryDependencies[i]));
                        mlSetups.Add(cr2w.Chunks[0].Data as Multilayer_Setup);

                        setupFs.Dispose();
                        setupFs.Close();

                        for (int e = 0; e < cr2w.Imports.Count; e++)
                        {
                            if (Path.GetExtension(cr2w.Imports[e].DepotPathStr) == ".xbm")
                            {
                                TexturesList.Add(cr2w.Imports[e].DepotPathStr);

                                ulong hash1 = FNV1A64HashAlgorithm.HashString(cr2w.Imports[e].DepotPathStr);
                                foreach (Archive ar in archives)
                                    UncookSingle(ar, hash1, new DirectoryInfo(cacheDir), exportArgs);
                            }
                            if (Path.GetExtension(cr2w.Imports[e].DepotPathStr) == ".mltemplate")
                            {
                                ulong hash2 = FNV1A64HashAlgorithm.HashString(cr2w.Imports[e].DepotPathStr);
                                foreach (Archive ar in archives)
                                {
                                    if(ar.Files.ContainsKey(hash2))
                                        ExtractSingle(ar, hash2, new DirectoryInfo(cacheDir));
                                }

                                if (File.Exists(cacheDir + cr2w.Imports[e].DepotPathStr))
                                {
                                    FileStream templateFs = new FileStream((cacheDir + cr2w.Imports[e].DepotPathStr), FileMode.Open, FileAccess.Read);
                                    var mlTempcr2w = _wolvenkitFileService.TryReadCr2WFile(templateFs);
                                    mlTemplateNames.Add(Path.GetFileName(cr2w.Imports[e].DepotPathStr));
                                    mlTemplates.Add(mlTempcr2w.Chunks[0].Data as Multilayer_LayerTemplate);

                                    templateFs.Dispose();
                                    templateFs.Close();

                                    for (int eye = 0; eye < mlTempcr2w.Imports.Count; eye++)
                                    {
                                        TexturesList.Add(mlTempcr2w.Imports[eye].DepotPathStr);

                                        ulong hash3 = FNV1A64HashAlgorithm.HashString(mlTempcr2w.Imports[eye].DepotPathStr);
                                        foreach (Archive ar in archives)
                                            UncookSingle(ar, hash3, new DirectoryInfo(cacheDir), exportArgs);
                                    }
                                }
                            }

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

                if (RawMaterials.Count > 0)
                {
                    if (MaterialSetups.Count > 0)
                    {
                        if (MaterialTemplates.Count > 0)
                        {
                            var obj = new { AssetLib = "", CopyTextures = true, ValueToBeIgnored = 9999, RawMaterials, MaterialSetups, MaterialTemplates };
                            model.Extras = JsonContent.Serialize(obj);
                            File.WriteAllText(outDir.FullName + "Material.json", JsonContent.Serialize(obj).ToJson());
                        }
                        else
                        {
                            var obj = new { AssetLib = "", CopyTextures = true, ValueToBeIgnored = 9999, RawMaterials, MaterialSetups };
                            model.Extras = JsonContent.Serialize(obj);
                            File.WriteAllText(outDir.FullName + "Material.json", JsonContent.Serialize(obj).ToJson());
                        }
                    }
                    else
                    {
                        var obj = new { AssetLib = "", CopyTextures = true, ValueToBeIgnored = 9999, RawMaterials };
                        model.Extras = JsonContent.Serialize(obj);
                        File.WriteAllText(outDir.FullName + "Material.json", JsonContent.Serialize(obj).ToJson());
                    }
                }

            File.WriteAllLines(outDir.FullName + "TexturesList.txt", TexturesList);

            string ext = "*.dds";
            if (eUncookExtension == EUncookExtension.png)
                ext = "*.png";
            if (eUncookExtension == EUncookExtension.bmp)
                ext = "*.bmp";
            if (eUncookExtension == EUncookExtension.jpeg)
                ext = "*.jpeg";
            if (eUncookExtension == EUncookExtension.jpg)
                ext = "*.jpg";
            if (eUncookExtension == EUncookExtension.tga)
                ext = "*.tga";

            string[] files = Directory.GetFiles(cacheDir, ext, SearchOption.AllDirectories);

            for (int i = 0; i < files.Length; i++)
            {
                string path = outDir.FullName + files[i].Replace(cacheDir, string.Empty);
                Directory.CreateDirectory(path.Replace(Path.GetFileName(files[i]), string.Empty));
                File.Move(files[i], path, true);
            }
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
            int index = 0;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "CMesh")
                {
                    index = i;
                }
            }

            int Count = (cr2w.Chunks[index].Data as CMesh).LocalMaterialBuffer.RawDataHeaders.Count;
            if(Count == 0)
            {
                throw new Exception("Provided .mesh doesn't contain any local material buffer");
            }
            else
            {
                byte[] bytes = GetMaterialStream(meshStream, cr2w).ToArray();
                List<string> names = new List<string>();
                for(int i = 0; i < (cr2w.Chunks[index].Data as CMesh).MaterialEntries.Count; i++)
                {
                    if((cr2w.Chunks[index].Data as CMesh).MaterialEntries[i].IsLocalInstance.Value)
                    {
                        names.Add((cr2w.Chunks[index].Data as CMesh).MaterialEntries[i].Name.Value);
                    }
                }
                for (int i = 0; i < Count; i++)
                {
                    UInt32 offset = (cr2w.Chunks[index].Data as CMesh).LocalMaterialBuffer.RawDataHeaders[i].Offset.Value;
                    UInt32 size = (cr2w.Chunks[index].Data as CMesh).LocalMaterialBuffer.RawDataHeaders[i].Size.Value;
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
            int index = 0;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "CMesh")
                {
                    index = i;
                }
            }

            int Count = (cr2w.Chunks[index].Data as CMesh).LocalMaterialBuffer.RawDataHeaders.Count;
            if (Count == 0)
            {
                throw new Exception("Provided .mesh doesn't contain any local material buffer");
            }
            else
            {
                List<string> names = new List<string>();
                for (int i = 0; i < (cr2w.Chunks[index].Data as CMesh).MaterialEntries.Count; i++)
                {
                    if ((cr2w.Chunks[index].Data as CMesh).MaterialEntries[i].IsLocalInstance.Value)
                    {
                        names.Add((cr2w.Chunks[index].Data as CMesh).MaterialEntries[i].Name.Value);
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
                            (cr2w.Chunks[index].Data as CMesh).LocalMaterialBuffer.RawDataHeaders[i].Offset.Value = Convert.ToUInt32(buffer.Length);
                            byte[] bytes = File.ReadAllBytes(mifiles[e]);
                            writer.Write(bytes);
                            (cr2w.Chunks[index].Data as CMesh).LocalMaterialBuffer.RawDataHeaders[i].Size.Value = Convert.ToUInt32(bytes.Length);

                        }
                    }
                    if (notfound)
                    {
                        throw new Exception("One or more names of .mi files doesn't match the names of material enteries in provided mesh file");
                    }
                }

                UInt16 p = ((cr2w.Chunks[index].Data as CMesh).LocalMaterialBuffer.RawData.Buffer.Value);

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
