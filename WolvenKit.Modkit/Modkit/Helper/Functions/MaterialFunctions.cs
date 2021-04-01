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

namespace WolvenKit.RED4.MeshFile.Materials
{
    public class MATERIAL
    {
        public static void ExporMeshWithMaterials(Stream meshStream, string depotDir, string _meshName, string outfile, bool isGLBinary = true, bool useAssetLib = true,bool copyTextures = false,EUncookExtension eUncookExtension = EUncookExtension.dds , bool LodFilter = true)
        {
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

            string outDir = Path.GetDirectoryName(outfile) + "\\" + Path.GetFileNameWithoutExtension(outfile) + "_Textures\\";
            Directory.CreateDirectory(outDir);

            if (useAssetLib)
                ParseMaterialsAsAssetLib(meshStream, ref model, outDir, depotDir, copyTextures,eUncookExtension);

            if (isGLBinary)
                model.SaveGLB(outfile);
            else
                model.SaveGLTF(outfile);
        }
        static void GetMateriaEntries(Stream meshStream, ref List<string> primaryDependencies,ref List<string> materialEntryNames, ref List<CMaterialInstance> materialEntries)
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

            int count = (cr2w.Chunks[index].data as CMesh).MaterialEntries.Count;
            
            for (int i = 0; i < count; i++)
            {
                materialEntryNames.Add((cr2w.Chunks[index].data as CMesh).MaterialEntries[i].Name.Value);
            }

            bool isbuffered = true;
            if ((cr2w.Chunks[index].data as CMesh).LocalMaterialBuffer.RawDataHeaders.Count == 0)
                isbuffered = false;

            if (isbuffered)
            {
                MemoryStream materialStream = GetMaterialStream(meshStream, cr2w);
                byte[] bytes = materialStream.ToArray();
                for (int i = 0; i < count; i++)
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

                    materialEntries.Add(mtcr2w.Chunks[0].data as CMaterialInstance);
                }
            }
            else
            {
                for (int i = 0; i < cr2w.Chunks.Count; i++)
                {
                    if (cr2w.Chunks[i].REDType == "CMaterialInstance")
                    {
                        materialEntries.Add(cr2w.Chunks[i].data as CMaterialInstance);
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
        }
        static void ParseMaterialsAsAssetLib(Stream meshStream, ref ModelRoot model,string outDir, string assetLib, bool copyTextures = false, EUncookExtension eUncookExtension = EUncookExtension.dds)
        {
            string cacheDir = Path.GetTempPath() + "WolvenKit\\Material\\TempImages\\";

            List<string> primaryDependencies = new List<string>();

            List<string> materialEntryNames = new List<string>();
            List<CMaterialInstance> materialEntries = new List<CMaterialInstance>();

            GetMateriaEntries(meshStream, ref primaryDependencies, ref materialEntryNames, ref materialEntries);

            List<string> mlSetupNames = new List<string>();
            List<Multilayer_Setup> mlSetups = new List<Multilayer_Setup>();

            List<string> mlTemplateNames = new List<string>();
            List<Multilayer_LayerTemplate> mlTemplates = new List<Multilayer_LayerTemplate>();

            Directory.CreateDirectory(cacheDir);
            for (int i = 0; i < primaryDependencies.Count; i++)
            {

                if (Path.GetExtension(primaryDependencies[i]) == ".xbm")
                    if (File.Exists(assetLib + primaryDependencies[i]))
                    {
                        if(copyTextures)
                        {
                            File.Copy(assetLib + primaryDependencies[i], cacheDir + Path.GetFileName(primaryDependencies[i]), true);
                            CP77.CR2W.ModTools.Export(new FileInfo(cacheDir + Path.GetFileName(primaryDependencies[i])), eUncookExtension);
                        }
                    }
                if (Path.GetExtension(primaryDependencies[i]) == ".mlmask")
                    if (File.Exists(assetLib + primaryDependencies[i]))
                    {
                        if (copyTextures)
                        {
                            File.Copy(assetLib + primaryDependencies[i], cacheDir + Path.GetFileName(primaryDependencies[i]), true);
                            // mlmask uncook is broken RN
                            //CP77.CR2W.ModTools.Export(new FileInfo(cacheDir + Path.GetFileName(primaryDependencies[i])), eUncookExtension);
                        }
                    }

                if (Path.GetExtension(primaryDependencies[i]) == ".mlsetup")
                    if (File.Exists(assetLib + primaryDependencies[i]))
                    {
                        var cr2w = CP77.CR2W.ModTools.TryReadCr2WFile(new FileStream((assetLib + primaryDependencies[i]), FileMode.Open, FileAccess.Read));
                        mlSetupNames.Add(Path.GetFileNameWithoutExtension(primaryDependencies[i]));
                        mlSetups.Add(cr2w.Chunks[0].data as Multilayer_Setup);

                        for (int e = 0; e < cr2w.Imports.Count; e++)
                        {
                            if (Path.GetExtension(cr2w.Imports[e].DepotPathStr) == ".xbm")
                                if (File.Exists(assetLib + cr2w.Imports[e].DepotPathStr))
                                {
                                    if (copyTextures)
                                    {
                                        File.Copy(assetLib + cr2w.Imports[e].DepotPathStr, cacheDir + Path.GetFileName(cr2w.Imports[e].DepotPathStr), true);
                                        CP77.CR2W.ModTools.Export(new FileInfo(cacheDir + Path.GetFileName(cr2w.Imports[e].DepotPathStr)), eUncookExtension);
                                    }
                                }
                            if (Path.GetExtension(cr2w.Imports[e].DepotPathStr) == ".mltemplate")
                                if (File.Exists(assetLib + cr2w.Imports[e].DepotPathStr))
                                {
                                    var mlTempcr2w = CP77.CR2W.ModTools.TryReadCr2WFile(new FileStream((assetLib + cr2w.Imports[e].DepotPathStr), FileMode.Open, FileAccess.Read));


                                    mlTemplateNames.Add(Path.GetFileNameWithoutExtension(cr2w.Imports[e].DepotPathStr));

                                    mlTemplates.Add(mlTempcr2w.Chunks[0].data as Multilayer_LayerTemplate);

                                    for (int eye = 0; eye < mlTempcr2w.Imports.Count; eye++)
                                    {
                                        if (File.Exists(assetLib + mlTempcr2w.Imports[eye].DepotPathStr))
                                        {
                                            if (copyTextures)
                                            {
                                                File.Copy(assetLib + mlTempcr2w.Imports[eye].DepotPathStr, cacheDir + Path.GetFileName(mlTempcr2w.Imports[eye].DepotPathStr), true);
                                                CP77.CR2W.ModTools.Export(new FileInfo(cacheDir + Path.GetFileName(mlTempcr2w.Imports[eye].DepotPathStr)),eUncookExtension);
                                            }
                                        }
                                    }
                                }
                        }

                    }
            }

            List<RawMaterial> rawMaterials = new List<RawMaterial>();
            for (int i = 0; i < materialEntries.Count; i++)
            { 
                rawMaterials.Add(ContainRawMaterial(materialEntries[i], materialEntryNames[i]));
            }

            var obj = new { assetLib,copyTextures, rawMaterials };
            model.Extras = SharpGLTF.IO.JsonContent.Serialize(obj);

            File.WriteAllText(outDir + "Material.json", SharpGLTF.IO.JsonContent.Serialize(obj).ToJson());

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
                File.Copy(files[i], outDir + Path.GetFileName(files[i]),true);

            Directory.Delete(cacheDir,true);
        }
        static RawMaterial ContainRawMaterial(CMaterialInstance cMaterialInstance, string name)
        {
            RawMaterial rawMaterial = new RawMaterial();

            rawMaterial.Name = name;

            if (Path.GetExtension(cMaterialInstance.BaseMaterial.DepotPath) == ".mi")
                rawMaterial.extInstanced = true;


            if (Path.GetFileNameWithoutExtension(cMaterialInstance.BaseMaterial.DepotPath) == "mesh_decal")
            {
                rawMaterial.materialType = MaterialType.MeshDecal;

                MeshDecal meshDecal = new MeshDecal(cMaterialInstance);
                rawMaterial.meshDecal = meshDecal;

            }
            if (Path.GetFileNameWithoutExtension(cMaterialInstance.BaseMaterial.DepotPath) == "multilayered")
            {
                rawMaterial.materialType = MaterialType.MultiLayered;

                MultiLayered multiLayered = new MultiLayered(cMaterialInstance);
                rawMaterial.multiLayered = multiLayered;

            }
            if (cMaterialInstance.BaseMaterial.DepotPath.Contains("skin"))
            {
                rawMaterial.materialType = MaterialType.HoomanSkin;

                HumanSkin humanSkin = new HumanSkin(cMaterialInstance);
                rawMaterial.humanSkin = humanSkin;
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
                if (new string(outreader.ReadChars(17)) == "CMaterialInstance")
                {
                    materialStream = outstream;
                    break;
                }
            }

            return materialStream;
        }
    }
}
