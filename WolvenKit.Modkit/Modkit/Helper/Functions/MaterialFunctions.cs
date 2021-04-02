using System;
using System.IO;
using CP77.CR2W;
using WolvenKit.RED4.GeneralStructs;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.Common.Oodle;
using System.Collections.Generic;
using SharpGLTF.Schema2;
using WolvenKit.RED4.MeshFile;
using WolvenKit.RED4.MeshFile.Materials.MaterialTypes;
using WolvenKit.Common.DDS;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.MaterialSetupFile;
using SharpGLTF.IO;

namespace WolvenKit.RED4.MeshFile.Materials
{
    public class MATERIAL
    {
        static string cacheDir = Path.GetTempPath() + "WolvenKit\\Material\\Temp\\";
        public static List<Archive> archives;
        public void ExportMeshWithMaterialsUsingAssetLib(Stream meshStream, DirectoryInfo assetLib, string _meshName, FileInfo outfile, bool isGLBinary = true,bool copyTextures = false,EUncookExtension eUncookExtension = EUncookExtension.dds , bool LodFilter = true)
        {
            Directory.CreateDirectory(cacheDir);

            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();
            var mesh_cr2w = CP77.CR2W.ModTools.TryReadCr2WFile(meshStream);

            MemoryStream ms = MESH.GetMeshBufferStream(meshStream, mesh_cr2w);
            MeshesInfo meshinfo = MESH.GetMeshesinfo(mesh_cr2w);
            for (int i = 0; i < meshinfo.meshC; i++)
            {
                if (meshinfo.LODLvl[i] != 1 && LodFilter)
                    continue;
                RawMeshContainer mesh = MESH.ContainRawMesh(ms, meshinfo.vertCounts[i], meshinfo.indCounts[i], meshinfo.vertOffsets[i], meshinfo.tx0Offsets[i], meshinfo.normalOffsets[i], meshinfo.colorOffsets[i], meshinfo.unknownOffsets[i], meshinfo.indicesOffsets[i], meshinfo.vpStrides[i], meshinfo.qScale, meshinfo.qTrans, meshinfo.weightcounts[i]);
                mesh.name = _meshName + "_" + i;

                mesh.appNames = new string[meshinfo.appearances.Count];
                mesh.materialNames = new string[meshinfo.appearances.Count];
                for (int e = 0; e < meshinfo.appearances.Count; e++)
                {
                    mesh.appNames[e] = meshinfo.appearances[e].Name;
                    mesh.materialNames[e] = meshinfo.appearances[e].MaterialNames[i];
                }
                expMeshes.Add(mesh);
            }
            ModelRoot model = MESH.RawRigidMeshesToGLTF(expMeshes);

            DirectoryInfo outDir = new DirectoryInfo(outfile.DirectoryName + "\\" + Path.GetFileNameWithoutExtension(outfile.FullName) + "_Textures\\");
            Directory.CreateDirectory(outDir.FullName);

            ParseMaterialsUsingAssetLib(meshStream, ref model, outDir, assetLib, copyTextures, eUncookExtension);

            if (isGLBinary)
                model.SaveGLB(outfile.FullName);
            else
                model.SaveGLTF(outfile.FullName);

            Directory.Delete(cacheDir, true);
        }
        public void ExportMeshWithMaterialsUsingArchives(Stream meshStream, string _meshName, FileInfo outfile, bool isGLBinary = true, EUncookExtension eUncookExtension = EUncookExtension.dds, bool LodFilter = true)
        {
            Directory.CreateDirectory(cacheDir);

            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();
            var mesh_cr2w = CP77.CR2W.ModTools.TryReadCr2WFile(meshStream);

            MemoryStream ms = MESH.GetMeshBufferStream(meshStream, mesh_cr2w);
            MeshesInfo meshinfo = MESH.GetMeshesinfo(mesh_cr2w);
            for (int i = 0; i < meshinfo.meshC; i++)
            {
                if (meshinfo.LODLvl[i] != 1 && LodFilter)
                    continue;
                RawMeshContainer mesh = MESH.ContainRawMesh(ms, meshinfo.vertCounts[i], meshinfo.indCounts[i], meshinfo.vertOffsets[i], meshinfo.tx0Offsets[i], meshinfo.normalOffsets[i], meshinfo.colorOffsets[i], meshinfo.unknownOffsets[i], meshinfo.indicesOffsets[i], meshinfo.vpStrides[i], meshinfo.qScale, meshinfo.qTrans, meshinfo.weightcounts[i]);
                mesh.name = _meshName + "_" + i;

                mesh.appNames = new string[meshinfo.appearances.Count];
                mesh.materialNames = new string[meshinfo.appearances.Count];
                for (int e = 0; e < meshinfo.appearances.Count; e++)
                {
                    mesh.appNames[e] = meshinfo.appearances[e].Name;
                    mesh.materialNames[e] = meshinfo.appearances[e].MaterialNames[i];
                }
                expMeshes.Add(mesh);
            }
            ModelRoot model = MESH.RawRigidMeshesToGLTF(expMeshes);

            DirectoryInfo outDir = new DirectoryInfo(outfile.DirectoryName + "\\" + Path.GetFileNameWithoutExtension(outfile.FullName) + "_Textures\\");
            Directory.CreateDirectory(outDir.FullName);

            ParseMaterialsUsingArchives(meshStream, ref model, outDir, eUncookExtension);

            if (isGLBinary)
                model.SaveGLB(outfile.FullName);
            else
                model.SaveGLTF(outfile.FullName);

            Directory.Delete(cacheDir, true);
        }
        static void GetMateriaEntries(Stream meshStream, ref List<string> primaryDependencies,ref List<string> materialEntryNames, ref List<CMaterialInstance> materialEntries, DirectoryInfo assetLib, bool useAssetLib)
        {
            var cr2w = ModTools.TryReadCr2WFile(meshStream);

            int index = 0;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "CMesh")
                {
                    index = i;
                }
            }

            List<CMaterialInstance> ExternalMaterial = new List<CMaterialInstance>();
            for (int i = 0; i < (cr2w.Chunks[index].data as CMesh).ExternalMaterials.Count; i++)
            {
                if(useAssetLib)
                {
                    string path = assetLib.FullName + (cr2w.Chunks[index].data as CMesh).ExternalMaterials[i].DepotPath;
                    if(File.Exists(path))
                    {
                        FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                        var micr2w = ModTools.TryReadCr2WFile(fs);
                        ExternalMaterial.Add(micr2w.Chunks[0].data as CMaterialInstance);

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
                    string path = (cr2w.Chunks[index].data as CMesh).ExternalMaterials[i].DepotPath;

                    ulong hash = FNV1A64HashAlgorithm.HashString(path);
                    foreach (Archive ar in archives)
                        ModTools.ExtractSingle(ar, hash, new DirectoryInfo(cacheDir));

                    path = cacheDir + (cr2w.Chunks[index].data as CMesh).ExternalMaterials[i].DepotPath;

                    if (File.Exists(path))
                    {
                        FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                        var micr2w = ModTools.TryReadCr2WFile(fs);
                        ExternalMaterial.Add(micr2w.Chunks[0].data as CMaterialInstance);

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
            if ((cr2w.Chunks[index].data as CMesh).LocalMaterialBuffer.RawDataHeaders.Count == 0)
                isbuffered = false;

            if (isbuffered)
            {
                MemoryStream materialStream = GetMaterialStream(meshStream, cr2w);
                byte[] bytes = materialStream.ToArray();
                for (int i = 0; i < (cr2w.Chunks[index].data as CMesh).LocalMaterialBuffer.RawDataHeaders.Count; i++)
                {
                    UInt32 offset = (cr2w.Chunks[index].data as CMesh).LocalMaterialBuffer.RawDataHeaders[i].Offset.Value;
                    UInt32 size = (cr2w.Chunks[index].data as CMesh).LocalMaterialBuffer.RawDataHeaders[i].Size.Value;

                    MemoryStream ms = new MemoryStream(bytes, (int)offset, (int)size);
                    var mtcr2w = ModTools.TryReadCr2WFile(ms);

                    string path = (mtcr2w.Chunks[0].data as CMaterialInstance).BaseMaterial.DepotPath;

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

                    LocalMaterial.Add(mtcr2w.Chunks[0].data as CMaterialInstance);
                }
            }
            else
            {
                for (int i = 0; i < cr2w.Chunks.Count; i++)
                {
                    if (cr2w.Chunks[i].REDType == "CMaterialInstance")
                    {
                        LocalMaterial.Add(cr2w.Chunks[i].data as CMaterialInstance);
                    }
                }
                for(int i = 0; i < cr2w.Imports.Count; i++)
                {
                    bool notFound = true;
                    for(int e = 0; e < primaryDependencies.Count; e++)
                    {
                        if (primaryDependencies[e] == cr2w.Imports[i].DepotPathStr)
                            notFound = false;
                    }
                    if (notFound)
                        primaryDependencies.Add(cr2w.Imports[i].DepotPathStr);
                }
            }

            int Count = (cr2w.Chunks[index].data as CMesh).MaterialEntries.Count;
            for (int i = 0; i < Count; i++)
            {
                var Entry = (cr2w.Chunks[index].data as CMesh).MaterialEntries[i];
                materialEntryNames.Add(Entry.Name.Value);
                if (Entry.IsLocalInstance.Value)
                    materialEntries.Add(LocalMaterial[Entry.Index.Value]);
                else
                    materialEntries.Add(ExternalMaterial[Entry.Index.Value]);
            }
        }
        static void ParseMaterialsUsingAssetLib(Stream meshStream, ref ModelRoot model,DirectoryInfo outDir, DirectoryInfo AssetLib, bool CopyTextures = false, EUncookExtension eUncookExtension = EUncookExtension.dds)
        {
            List<string> primaryDependencies = new List<string>();

            List<string> materialEntryNames = new List<string>();
            List<CMaterialInstance> materialEntries = new List<CMaterialInstance>();

            GetMateriaEntries(meshStream, ref primaryDependencies, ref materialEntryNames, ref materialEntries,AssetLib,true);

            List<string> mlSetupNames = new List<string>();
            List<Multilayer_Setup> mlSetups = new List<Multilayer_Setup>();

            List<string> mlTemplateNames = new List<string>();
            List<Multilayer_LayerTemplate> mlTemplates = new List<Multilayer_LayerTemplate>();

            List<string> TexturesList = new List<string>();

            for (int i = 0; i < primaryDependencies.Count; i++)
            {

                if (Path.GetExtension(primaryDependencies[i]) == ".xbm")
                {
                    TexturesList.Add(primaryDependencies[i]);
                    if (File.Exists(AssetLib.FullName + primaryDependencies[i]))
                    {
                        if (CopyTextures)
                        {
                            File.Copy(AssetLib.FullName + primaryDependencies[i], cacheDir + Path.GetFileName(primaryDependencies[i]), true);
                            ModTools.Export(new FileInfo(cacheDir + Path.GetFileName(primaryDependencies[i])), eUncookExtension);
                        }
                    }
                }
                if (Path.GetExtension(primaryDependencies[i]) == ".mlmask")
                {
                    TexturesList.Add(primaryDependencies[i]);
                    if (File.Exists(AssetLib.FullName + primaryDependencies[i]))
                    {
                        if (CopyTextures)
                        {
                            File.Copy(AssetLib.FullName + primaryDependencies[i], cacheDir + Path.GetFileName(primaryDependencies[i]), true);
                            ModTools.Export(new FileInfo(cacheDir + Path.GetFileName(primaryDependencies[i])), eUncookExtension);
                        }
                    }
                }

                if (Path.GetExtension(primaryDependencies[i]) == ".mlsetup")
                    if (File.Exists(AssetLib.FullName + primaryDependencies[i]))
                    {
                        FileStream setupFs = new FileStream((AssetLib.FullName + primaryDependencies[i]), FileMode.Open, FileAccess.Read);
                        var cr2w = ModTools.TryReadCr2WFile(setupFs);
                        mlSetupNames.Add(Path.GetFileName(primaryDependencies[i]));
                        mlSetups.Add(cr2w.Chunks[0].data as Multilayer_Setup);

                        setupFs.Dispose();
                        setupFs.Close();
                        for (int e = 0; e < cr2w.Imports.Count; e++)
                        {
                            if (Path.GetExtension(cr2w.Imports[e].DepotPathStr) == ".xbm")
                            {
                                TexturesList.Add(cr2w.Imports[e].DepotPathStr);
                                if (File.Exists(AssetLib.FullName + cr2w.Imports[e].DepotPathStr))
                                {
                                    if (CopyTextures)
                                    {
                                        File.Copy(AssetLib.FullName + cr2w.Imports[e].DepotPathStr, cacheDir + Path.GetFileName(cr2w.Imports[e].DepotPathStr), true);
                                        ModTools.Export(new FileInfo(cacheDir + Path.GetFileName(cr2w.Imports[e].DepotPathStr)), eUncookExtension);
                                    }
                                }
                            }
                            if (Path.GetExtension(cr2w.Imports[e].DepotPathStr) == ".mltemplate")
                            {
                                if (File.Exists(AssetLib.FullName + cr2w.Imports[e].DepotPathStr))
                                {
                                    FileStream templateFs = new FileStream((AssetLib.FullName + cr2w.Imports[e].DepotPathStr), FileMode.Open, FileAccess.Read);
                                    var mlTempcr2w = ModTools.TryReadCr2WFile(templateFs);
                                    mlTemplateNames.Add(Path.GetFileName(cr2w.Imports[e].DepotPathStr));
                                    mlTemplates.Add(mlTempcr2w.Chunks[0].data as Multilayer_LayerTemplate);

                                    templateFs.Dispose();
                                    templateFs.Close();
                                    for (int eye = 0; eye < mlTempcr2w.Imports.Count; eye++)
                                    {
                                        TexturesList.Add(mlTempcr2w.Imports[eye].DepotPathStr);
                                        if (File.Exists(AssetLib.FullName + mlTempcr2w.Imports[eye].DepotPathStr))
                                        {
                                            if (CopyTextures)
                                            {
                                                File.Copy(AssetLib.FullName + mlTempcr2w.Imports[eye].DepotPathStr, cacheDir + Path.GetFileName(mlTempcr2w.Imports[eye].DepotPathStr), true);
                                                ModTools.Export(new FileInfo(cacheDir + Path.GetFileName(mlTempcr2w.Imports[eye].DepotPathStr)), eUncookExtension);
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
            }

            try
            {

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

                if(RawMaterials.Count > 0)
                {
                    if(MaterialSetups.Count > 0)
                    {
                        if(MaterialTemplates.Count > 0)
                        {
                            var obj = new { AssetLib = AssetLib.FullName, CopyTextures, ValueToBeIgnored = 9999, RawMaterials, MaterialSetups, MaterialTemplates};
                            model.Extras = JsonContent.Serialize(obj);
                            File.WriteAllText(outDir.FullName + "Material.json", JsonContent.Serialize(obj).ToJson());
                        }
                        else
                        {
                            var obj = new { AssetLib = AssetLib.FullName, CopyTextures, ValueToBeIgnored = 9999, RawMaterials, MaterialSetups};
                            model.Extras = JsonContent.Serialize(obj);
                            File.WriteAllText(outDir.FullName + "Material.json", JsonContent.Serialize(obj).ToJson());
                        }
                    }
                    else
                    {
                        var obj = new { AssetLib = AssetLib.FullName, CopyTextures, ValueToBeIgnored = 9999, RawMaterials};
                        model.Extras = JsonContent.Serialize(obj);
                        File.WriteAllText(outDir.FullName + "Material.json", JsonContent.Serialize(obj).ToJson());
                    }
                }

            }
            catch { }

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

            string[] files = Directory.GetFiles(cacheDir, ext);
            for (int i = 0; i < files.Length; i++)
                File.Move(files[i], outDir.FullName + Path.GetFileName(files[i]),true);
        }
        static void ParseMaterialsUsingArchives(Stream meshStream, ref ModelRoot model, DirectoryInfo outDir, EUncookExtension eUncookExtension = EUncookExtension.dds)
        {
            List<string> primaryDependencies = new List<string>();

            List<string> materialEntryNames = new List<string>();
            List<CMaterialInstance> materialEntries = new List<CMaterialInstance>();

            GetMateriaEntries(meshStream, ref primaryDependencies, ref materialEntryNames, ref materialEntries,new DirectoryInfo(cacheDir), false);

            List<string> mlSetupNames = new List<string>();
            List<Multilayer_Setup> mlSetups = new List<Multilayer_Setup>();

            List<string> mlTemplateNames = new List<string>();
            List<Multilayer_LayerTemplate> mlTemplates = new List<Multilayer_LayerTemplate>();

            List<string> TexturesList = new List<string>();

            for (int i = 0; i < primaryDependencies.Count; i++)
            {

                if (Path.GetExtension(primaryDependencies[i]) == ".xbm")
                {
                    TexturesList.Add(primaryDependencies[i]);

                    ulong hash = FNV1A64HashAlgorithm.HashString(primaryDependencies[i]);
                    foreach (Archive ar in archives)
                        ModTools.UncookSingle(ar, hash, new DirectoryInfo(cacheDir), eUncookExtension);
                }
                if (Path.GetExtension(primaryDependencies[i]) == ".mlmask")
                {
                    TexturesList.Add(primaryDependencies[i]);
                    ulong hash = FNV1A64HashAlgorithm.HashString(primaryDependencies[i]);
                    foreach (Archive ar in archives)
                        ModTools.UncookSingle(ar, hash, new DirectoryInfo(cacheDir), eUncookExtension);
                    
                }

                if (Path.GetExtension(primaryDependencies[i]) == ".mlsetup")
                {
                    ulong hash = FNV1A64HashAlgorithm.HashString(primaryDependencies[i]);
                    foreach (Archive ar in archives)
                        ModTools.ExtractSingle(ar, hash, new DirectoryInfo(cacheDir));

                    if (File.Exists(cacheDir + primaryDependencies[i]))
                    {
                        FileStream setupFs = new FileStream((cacheDir + primaryDependencies[i]), FileMode.Open, FileAccess.Read);
                        var cr2w = ModTools.TryReadCr2WFile(setupFs);
                        mlSetupNames.Add(Path.GetFileName(primaryDependencies[i]));
                        mlSetups.Add(cr2w.Chunks[0].data as Multilayer_Setup);

                        setupFs.Dispose();
                        setupFs.Close();

                        for (int e = 0; e < cr2w.Imports.Count; e++)
                        {
                            if (Path.GetExtension(cr2w.Imports[e].DepotPathStr) == ".xbm")
                            {
                                TexturesList.Add(cr2w.Imports[e].DepotPathStr);

                                ulong hash1 = FNV1A64HashAlgorithm.HashString(cr2w.Imports[e].DepotPathStr);
                                foreach (Archive ar in archives)
                                    ModTools.UncookSingle(ar, hash1, new DirectoryInfo(cacheDir), eUncookExtension);
                            }
                            if (Path.GetExtension(cr2w.Imports[e].DepotPathStr) == ".mltemplate")
                            {
                                ulong hash2 = FNV1A64HashAlgorithm.HashString(cr2w.Imports[e].DepotPathStr);
                                foreach (Archive ar in archives)
                                    ModTools.ExtractSingle(ar, hash2, new DirectoryInfo(cacheDir));

                                if (File.Exists(cacheDir + cr2w.Imports[e].DepotPathStr))
                                {
                                    FileStream templateFs = new FileStream((cacheDir + cr2w.Imports[e].DepotPathStr), FileMode.Open, FileAccess.Read);
                                    var mlTempcr2w = ModTools.TryReadCr2WFile(templateFs);
                                    mlTemplateNames.Add(Path.GetFileName(cr2w.Imports[e].DepotPathStr));
                                    mlTemplates.Add(mlTempcr2w.Chunks[0].data as Multilayer_LayerTemplate);

                                    templateFs.Dispose();
                                    templateFs.Close();

                                    for (int eye = 0; eye < mlTempcr2w.Imports.Count; eye++)
                                    {
                                        TexturesList.Add(mlTempcr2w.Imports[eye].DepotPathStr);

                                        ulong hash3 = FNV1A64HashAlgorithm.HashString(mlTempcr2w.Imports[eye].DepotPathStr);
                                        foreach (Archive ar in archives)
                                            ModTools.UncookSingle(ar, hash3, new DirectoryInfo(cacheDir), eUncookExtension);
                                    }
                                }
                            }

                        }
                    }
                }
            }

            try
            {

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

            }
            catch { }
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

            string[] files = Directory.GetFiles(cacheDir, ext,SearchOption.AllDirectories);

            for (int i = 0; i < files.Length; i++)
                File.Move(files[i], outDir.FullName + Path.GetFileName(files[i]), true);
        }
        static RawMaterial ContainRawMaterial(CMaterialInstance cMaterialInstance, string Name)
        {
            RawMaterial rawMaterial = new RawMaterial();

            rawMaterial.Name = Name;
            rawMaterial.BaseMaterial = cMaterialInstance.BaseMaterial.DepotPath;

            if (Path.GetFileNameWithoutExtension(cMaterialInstance.BaseMaterial.DepotPath) == "mesh_decal")
            {
                rawMaterial.MaterialType = MaterialType.MeshDecal;

                MeshDecal MeshDecal = new MeshDecal(cMaterialInstance);
                rawMaterial.MeshDecal = MeshDecal;

            }
            if (Path.GetFileNameWithoutExtension(cMaterialInstance.BaseMaterial.DepotPath) == "multilayered")
            {
                rawMaterial.MaterialType = MaterialType.MultiLayered;

                MultiLayered multiLayered = new MultiLayered(cMaterialInstance);
                rawMaterial.MultiLayered = multiLayered;

            }
            if (cMaterialInstance.BaseMaterial.DepotPath.Contains("skin"))
            {
                rawMaterial.MaterialType = MaterialType.HumanSkin;

                HumanSkin HumanSkin = new HumanSkin(cMaterialInstance);
                rawMaterial.HumanSkin = HumanSkin;
            }

            return rawMaterial;
        }
        static MemoryStream GetMaterialStream(Stream ms,CR2WFile cr2w)
        {
            MemoryStream materialStream = new MemoryStream();

            var buffers = cr2w.Buffers;
            for (var i = 0; i < buffers.Count; i++)
            {
                var b = buffers[i];
                ms.Seek(b.Offset, SeekOrigin.Begin);

                MemoryStream outstream = new MemoryStream();
                // copy to some outstream
                ms.DecompressAndCopySegment(outstream, b.DiskSize, b.MemSize);
                BinaryReader outreader = new BinaryReader(outstream);
                outstream.Position = 161;
                if (new string(BitConverter.ToString(outreader.ReadBytes(17))) == "43-4D-61-74-65-72-69-61-6C-49-6E-73-74-61-6E-63-65") // CMaterialInstance
                {
                    materialStream = outstream;
                    break;
                }
            }
            return materialStream;
        }
        public MATERIAL(List<Archive> Archives)
        {
            archives = Archives;
        }
        public MATERIAL()
        {

        }
    }
}
