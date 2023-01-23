using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text.Json;
using Semver;
using SharpDX;
using SharpGLTF.Schema2;
using SharpGLTF.Validation;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
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
        public bool ExportMeshWithMaterials(Stream meshStream, FileInfo outfile, MeshExportArgs meshArgs, ValidationMode vmode = ValidationMode.TryFix)
        {
            var archives = meshArgs.Archives;
            var matRepo = meshArgs.MaterialRepo;
            var eUncookExtension = meshArgs.MaterialUncookExtension;
            var isGLBinary = meshArgs.isGLBinary;
            var LodFilter = meshArgs.LodFilter;
            var mergeMeshes = meshArgs.ExperimentalMergedExport;

            if (matRepo == null)
            {
                throw new Exception("Depot path is not set: Choose a Depot location within Settings for generating materials.");
            }

            var cr2w = _wolvenkitFileService.ReadRed4File(meshStream);
            if (cr2w == null || cr2w.RootChunk is not CMesh cMesh || cMesh.RenderResourceBlob == null || cMesh.RenderResourceBlob.Chunk is not rendRenderMeshBlob rendblob)
            {
                return false;
            }

            using var ms = new MemoryStream(rendblob.RenderBuffer.Buffer.GetBytes());

            var meshesinfo = MeshTools.GetMeshesinfo(rendblob, cr2w.RootChunk as CMesh);

            var expMeshes = MeshTools.ContainRawMesh(ms, meshesinfo, LodFilter);
            MeshTools.UpdateSkinningParamCloth(ref expMeshes, meshStream, cr2w);

            var Rig = MeshTools.GetOrphanRig(cMesh);

            var model = MeshTools.RawMeshesToGLTF(expMeshes, Rig, mergeMeshes);

            ParseMaterials(cr2w, meshStream, outfile, archives, matRepo, meshesinfo, eUncookExtension);

            if (isGLBinary)
            {
                model.SaveGLB(outfile.FullName, new WriteSettings(vmode));
            }
            else
            {
                model.SaveGLTF(outfile.FullName, new WriteSettings(vmode));
            }

            meshStream.Dispose();
            meshStream.Close();

            return true;
        }
        private void GetMaterialEntries(CR2WFile cr2w, Stream meshStream, ref List<string> primaryDependencies, ref List<string> materialEntryNames, ref List<CMaterialInstance> materialEntries, List<ICyberGameArchive> archives)
        {
            if (cr2w.RootChunk is not CMesh cmesh)
            {
                throw new ArgumentException(nameof(cr2w));
            }

            var ExternalMaterial = new List<CMaterialInstance>();

            for (var i = 0; i < cmesh.ExternalMaterials.Count; i++)
            {
                var path = cmesh.ExternalMaterials[i].DepotPath;
                if (path == 0)
                {
                    continue;
                }

                var findStatus = TryFindFile(archives, path, out var result);
                if (findStatus == FindFileResult.NoError)
                {
                    ArgumentNullException.ThrowIfNull(result, nameof(result));
                    if (result.File.RootChunk is CMaterialInstance mi)
                    {
                        ExternalMaterial.Add(mi);
                    }
                    else
                    {
                        // The external materials can also directly reference MaterialTemplates. To keep it easier for the exporter we can expose these as material instances
                        var fakeMaterialInstance = new CMaterialInstance
                        {
                            BaseMaterial = new CResourceReference<IMaterial>(path),
                            Values = new CArray<CKeyValuePair>()
                        };

                        ExternalMaterial.Add(fakeMaterialInstance);
                    }


                    foreach (var import in result.Imports)
                    {
                        if (!primaryDependencies.Contains(import.DepotPath))
                        {
                            primaryDependencies.Add(import.DepotPath);
                        }
                    }
                }
                else if (findStatus == FindFileResult.NoCR2W)
                {
                    throw new InvalidParsingException("Error while parsing a file");
                }
                else
                {
                    throw new InvalidParsingException($"Error while finding the file: {(string)path}");
                }
            }

            for (var i = 0; i < cmesh.PreloadExternalMaterials.Count; i++)
            {
                var path = cmesh.PreloadExternalMaterials[i].DepotPath;
                if (path == 0)
                {
                    continue;
                }

                var findStatus = TryFindFile(archives, path, out var result);
                if (findStatus == FindFileResult.NoError)
                {
                    ArgumentNullException.ThrowIfNull(result, nameof(result));
                    var instance = (result.File.RootChunk as CMaterialInstance).NotNull();

                    ExternalMaterial.Add(instance);

                    foreach (var import in result.Imports)
                    {
                        if (!primaryDependencies.Contains(import.DepotPath))
                        {
                            primaryDependencies.Add(import.DepotPath);
                        }
                    }
                }
                else if (findStatus == FindFileResult.NoCR2W)
                {
                    throw new InvalidParsingException("Error while parsing a file");
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
                    reader.ParsingError += args => args is InvalidDefaultValueEventArgs;

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

                    var instance = (mi.RootChunk as CMaterialInstance).NotNull();
                    LocalMaterial.Add(instance);
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
                var path = m.BaseMaterial.DepotPath;
                if (path == 0)
                {
                    continue;
                }

                while (true)
                {
                    var findStatus = TryFindFile(archives, path, out var result);
                    if (findStatus == FindFileResult.NoError)
                    {
                        ArgumentNullException.ThrowIfNull(result, nameof(result));
                        if (result.File.RootChunk is CMaterialInstance mi)
                        {
                            path = mi.BaseMaterial.DepotPath;

                            foreach (var import in result.Imports)
                            {
                                if (!primaryDependencies.Contains(import.DepotPath))
                                {
                                    primaryDependencies.Add(import.DepotPath);
                                }
                            }
                        }
                        else if (result.File.RootChunk is CMaterialTemplate mt)
                        {
                            foreach (var import in result.Imports)
                            {
                                if (!primaryDependencies.Contains(import.DepotPath))
                                {
                                    primaryDependencies.Add(import.DepotPath);
                                }
                            }
                            break;
                        }
                        else
                        {
                            throw new InvalidParsingException($"Unexpected class found: {(string)path}");
                        }
                    }
                    else if (findStatus == FindFileResult.NoCR2W)
                    {
                        throw new InvalidParsingException("Error while parsing a file");
                    }
                    else
                    {
                        throw new InvalidParsingException($"Error while finding the file: {(string)path}");
                    }
                }
            }
        }

        private MatData SetupMaterial(CR2WFile cr2w, Stream meshStream, List<ICyberGameArchive> archives, string matRepo, MeshesInfo info, EUncookExtension eUncookExtension = EUncookExtension.dds)
        {
            var primaryDependencies = new List<string>();

            var materialEntryNames = new List<string>();
            var materialEntries = new List<CMaterialInstance>();

            GetMaterialEntries(cr2w, meshStream, ref primaryDependencies, ref materialEntryNames, ref materialEntries, archives);

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
                ExtractFile(primaryDependencies[i]);
            }

            var RawMaterials = new List<RawMaterial>();
            var usedMts = GetEmbeddedMaterialTemplates(ref cr2w);
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

            var matData = new MatData(matRepo, RawMaterials, TexturesList, matTemplates, info.appearances);

            return matData;
            void ExtractFile(string path)
            {
                if (string.IsNullOrEmpty(path))
                {
                    return;
                }
                var extension = Path.GetExtension(path)?.ToLower();
                ArgumentNullException.ThrowIfNull(extension);

                switch (extension)
                {
                    case ".xbm":
                        ExtractXBM(path);
                        break;

                    case ".mlmask":
                        ExtractMlMask(path);
                        break;

                    case ".hp":
                        ExtractHP(path);
                        break;

                    case ".mlsetup":
                        ExtractMlSetup(path);
                        break;

                    case ".mltemplate":
                        ExtractMlTemplate(path);
                        break;

                    case ".gradient":
                        ExtractGradient(path);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                void ExtractXBM(string path)
                {
                    if (!TexturesList.Contains(path))
                    {
                        TexturesList.Add(path);
                    }

                    var destFileName = Path.Combine(matRepo, Path.ChangeExtension(path, "." + exportArgs.Get<XbmExportArgs>().UncookExtension));
                    if (!File.Exists(destFileName))
                    {
                        UncookFile(archives, path, matRepo, exportArgs);
                    }
                }

                void ExtractMlMask(string path)
                {
                    if (!TexturesList.Contains(path))
                    {
                        TexturesList.Add(path);
                    }

                    var destFileName = Path.Combine(matRepo, path.Replace(".mlmask", $"_0.{exportArgs.Get<XbmExportArgs>().UncookExtension}"));
                    if (!File.Exists(destFileName))
                    {
                        exportArgs.Get<MlmaskExportArgs>().AsList = false;
                        UncookFile(archives, path, matRepo, exportArgs);
                    }
                }

                void ExtractHP(string path)
                {
                    if (HairProfileNames.Contains(path))
                    {
                        return;
                    }

                    HairProfileNames.Add(path);

                    var fi = new FileInfo(Path.Combine(matRepo, Path.ChangeExtension(path, ".hp.json")));
                    if (!fi.Exists)
                    {
                        var findStatus = TryFindFile(archives, path, out var result);
                        if (findStatus == FindFileResult.NoError)
                        {
                            ArgumentNullException.ThrowIfNull(result, "result");
                            if (!fi.Directory.NotNull().Exists)
                            {
                                fi.Directory.Create();
                            }

                            var dto = new RedFileDto(result.File);
                            var doc = RedJsonSerializer.Serialize(dto);
                            File.WriteAllText(fi.FullName, doc);
                        }
                        else if (findStatus == FindFileResult.NoCR2W)
                        {
                            throw new InvalidParsingException("Error while parsing a file");
                        }
                    }
                }

                void ExtractMlSetup(string path)
                {
                    if (mlSetupNames.Contains(path))
                    {
                        return;
                    }

                    mlSetupNames.Add(path);

                    var fi = new FileInfo(Path.Combine(matRepo, Path.ChangeExtension(path, ".mlsetup.json")));
                    if (!fi.Exists)
                    {
                        var findStatus = TryFindFile(archives, path, out var result);
                        if (findStatus == FindFileResult.NoError)
                        {
                            ArgumentNullException.ThrowIfNull(result, "result");
                            if (!fi.Directory.NotNull().Exists)
                            {
                                fi.Directory.Create();
                            }

                            var dto = new RedFileDto(result.File);
                            var doc = RedJsonSerializer.Serialize(dto);
                            File.WriteAllText(fi.FullName, doc);

                            foreach (var import in result.Imports)
                            {
                                ExtractFile(import.DepotPath);
                            }
                        }
                        else if (findStatus == FindFileResult.NoCR2W)
                        {
                            throw new InvalidParsingException("Error while parsing a file");
                        }
                    }
                }

                void ExtractMlTemplate(string path)
                {
                    if (mlTemplateNames.Contains(path))
                    {
                        return;
                    }

                    mlTemplateNames.Add(path);

                    var fi = new FileInfo(Path.Combine(matRepo, Path.ChangeExtension(path, ".mltemplate.json")));
                    if (!fi.Exists)
                    {
                        var findStatus = TryFindFile(archives, path, out var result);
                        if (findStatus == FindFileResult.NoError)
                        {
                            ArgumentNullException.ThrowIfNull(result, "result");
                            if (!fi.Directory.NotNull().Exists)
                            {
                                fi.Directory.Create();
                            }

                            var dto = new RedFileDto(result.File);
                            var doc = RedJsonSerializer.Serialize(dto);
                            File.WriteAllText(fi.FullName, doc);

                            foreach (var import in result.Imports)
                            {
                                ExtractFile(import.DepotPath);
                            }

                            var mlTemplateMats = result.File.RootChunk.FindType(typeof(CResourceReference<CBitmapTexture>));
                            foreach (var mlTemplateMat in mlTemplateMats)
                            {
                                var mat = (CResourceReference<CBitmapTexture>)mlTemplateMat.Value;
                                ExtractXBM(mat.DepotPath);
                            }
                        }
                        else if (findStatus == FindFileResult.NoCR2W)
                        {
                            throw new InvalidParsingException("Error while parsing a file");
                        }
                    }
                }

                void ExtractGradient(string path)
                {
                    if (TexturesList.Contains(path))
                    {
                        return;
                    }

                    TexturesList.Add(path);

                    var fi = new FileInfo(Path.Combine(matRepo, Path.ChangeExtension(path, ".gradient.json")));
                    if (!fi.Exists)
                    {
                        var findStatus = TryFindFile(archives, path, out var result);
                        if (findStatus == FindFileResult.NoError)
                        {
                            ArgumentNullException.ThrowIfNull(result, "result");
                            if (!fi.Directory.NotNull().Exists)
                            {
                                fi.Directory.Create();
                            }

                            var dto = new RedFileDto(result.File);
                            var doc = RedJsonSerializer.Serialize(dto);
                            File.WriteAllText(fi.FullName, doc);
                        }
                        else if (findStatus == FindFileResult.NoCR2W)
                        {
                            throw new InvalidParsingException("Error while parsing a file");
                        }
                    }
                }
            }
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
                    if (!consMatData.Appearances.ContainsKey(app.Key))
                    {
                        consMatData.Appearances.Add(app.Key, app.Value);
                    }
                }
            }

            var str = RedJsonSerializer.Serialize(consMatData);

            File.WriteAllText(Path.ChangeExtension(outfile.FullName, ".Material.json"), str);

        }

        private void ParseMaterials(CR2WFile cr2w, Stream meshStream, FileInfo outfile, List<ICyberGameArchive> archives, string matRepo, MeshesInfo info, EUncookExtension eUncookExtension = EUncookExtension.dds)
        {
            var primaryDependencies = new List<string>();

            var materialEntryNames = new List<string>();
            var materialEntries = new List<CMaterialInstance>();

            GetMaterialEntries(cr2w, meshStream, ref primaryDependencies, ref materialEntryNames, ref materialEntries, archives);

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
                ExtractFile(primaryDependencies[i]);
            }

            var RawMaterials = new List<RawMaterial>();
            var usedMts = GetEmbeddedMaterialTemplates(ref cr2w);
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

            var matData = new MatData(matRepo, RawMaterials, TexturesList, matTemplates, info.appearances);

            var str = RedJsonSerializer.Serialize(matData);

            File.WriteAllText(Path.ChangeExtension(outfile.FullName, ".Material.json"), str);

            void ExtractFile(string path)
            {
                var extension = Path.GetExtension(path).ToLower();

                switch (extension)
                {
                    case ".xbm":
                        ExtractXBM(path);
                        break;

                    case ".mlmask":
                        ExtractMlMask(path);
                        break;

                    case ".hp":
                        ExtractHP(path);
                        break;

                    case ".mlsetup":
                        ExtractMlSetup(path);
                        break;

                    case ".mltemplate":
                        ExtractMlTemplate(path);
                        break;

                    case ".gradient":
                        ExtractGradient(path);
                        break;
                    default:
                        break;
                }

                void ExtractXBM(string path)
                {
                    if (!TexturesList.Contains(path))
                    {
                        TexturesList.Add(path);
                    }

                    var destFileName = Path.Combine(matRepo, Path.ChangeExtension(path, "." + exportArgs.Get<XbmExportArgs>().UncookExtension));
                    if (!File.Exists(destFileName))
                    {
                        UncookFile(archives, path, matRepo, exportArgs);
                    }
                }

                void ExtractMlMask(string path)
                {
                    if (!TexturesList.Contains(path))
                    {
                        TexturesList.Add(path);
                    }

                    var destFileName = Path.Combine(matRepo, path.Replace(".mlmask", $"_0.{exportArgs.Get<XbmExportArgs>().UncookExtension}"));
                    if (!File.Exists(destFileName))
                    {
                        exportArgs.Get<MlmaskExportArgs>().AsList = false;
                        UncookFile(archives, path, matRepo, exportArgs);
                    }
                }

                void ExtractHP(string path)
                {
                    if (HairProfileNames.Contains(path))
                    {
                        return;
                    }

                    HairProfileNames.Add(path);

                    var fi = new FileInfo(Path.Combine(matRepo, Path.ChangeExtension(path, ".hp.json")));
                    if (!fi.Exists)
                    {
                        var findStatus = TryFindFile(archives, path, out var result);
                        if (findStatus == FindFileResult.NoError)
                        {
                            if (fi.Directory is not null && !fi.Directory.Exists)
                            {
                                fi.Directory.Create();
                            }

                            ArgumentNullException.ThrowIfNull(result, nameof(result));
                            var dto = new RedFileDto(result.File);
                            var doc = RedJsonSerializer.Serialize(dto);
                            File.WriteAllText(fi.FullName, doc);
                        }
                        else if (findStatus == FindFileResult.NoCR2W)
                        {
                            throw new InvalidParsingException("Error while parsing a file");
                        }
                    }
                }

                void ExtractMlSetup(string path)
                {
                    if (mlSetupNames.Contains(path))
                    {
                        return;
                    }

                    mlSetupNames.Add(path);

                    var fi = new FileInfo(Path.Combine(matRepo, Path.ChangeExtension(path, ".mlsetup.json")));
                    if (!fi.Exists)
                    {
                        var findStatus = TryFindFile(archives, path, out var result);
                        if (findStatus == FindFileResult.NoError)
                        {
                            ArgumentNullException.ThrowIfNull(result, nameof(result));
                            if (fi.Directory is not null && !fi.Directory.Exists)
                            {
                                fi.Directory.Create();
                            }

                            var dto = new RedFileDto(result.File);
                            var doc = RedJsonSerializer.Serialize(dto);
                            File.WriteAllText(fi.FullName, doc);

                            foreach (var import in result.Imports)
                            {
                                ExtractFile(import.DepotPath);
                            }
                        }
                        else if (findStatus == FindFileResult.NoCR2W)
                        {
                            throw new InvalidParsingException("Error while parsing a file");
                        }
                    }
                }

                void ExtractMlTemplate(string path)
                {
                    if (mlTemplateNames.Contains(path))
                    {
                        return;
                    }

                    mlTemplateNames.Add(path);

                    var fi = new FileInfo(Path.Combine(matRepo, Path.ChangeExtension(path, ".mltemplate.json")));
                    if (!fi.Exists)
                    {
                        var findStatus = TryFindFile(archives, path, out var result);
                        if (findStatus == FindFileResult.NoError)
                        {
                            ArgumentNullException.ThrowIfNull(result, nameof(result));
                            if (fi.Directory is not null && !fi.Directory.Exists)
                            {
                                fi.Directory.Create();
                            }

                            var dto = new RedFileDto(result.File);
                            var doc = RedJsonSerializer.Serialize(dto);
                            File.WriteAllText(fi.FullName, doc);

                            foreach (var import in result.Imports)
                            {
                                ExtractFile(import.DepotPath);
                            }

                            var mlTemplateMats = result.File.RootChunk.FindType(typeof(CResourceReference<CBitmapTexture>));
                            foreach (var mlTemplateMat in mlTemplateMats)
                            {
                                var mat = (CResourceReference<CBitmapTexture>)mlTemplateMat.Value;
                                ExtractXBM(mat.DepotPath);
                            }
                        }
                        else if (findStatus == FindFileResult.NoCR2W)
                        {
                            throw new InvalidParsingException("Error while parsing a file");
                        }
                    }
                }

                void ExtractGradient(string path)
                {
                    if (TexturesList.Contains(path))
                    {
                        return;
                    }

                    TexturesList.Add(path);

                    var fi = new FileInfo(Path.Combine(matRepo, Path.ChangeExtension(path, ".gradient.json")));
                    if (!fi.Exists)
                    {
                        var findStatus = TryFindFile(archives, path, out var result);
                        if (findStatus == FindFileResult.NoError)
                        {
                            ArgumentNullException.ThrowIfNull(result, nameof(result));
                            if (fi.Directory is not null && !fi.Directory.Exists)
                            {
                                fi.Directory.Create();
                            }

                            var dto = new RedFileDto(result.File);
                            var doc = RedJsonSerializer.Serialize(dto);
                            File.WriteAllText(fi.FullName, doc);
                        }
                        else if (findStatus == FindFileResult.NoCR2W)
                        {
                            throw new InvalidParsingException("Error while parsing a file");
                        }
                    }
                }
            }
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

                return (CName)value.GetString();
            }

            if (materialParameterType == typeof(CMaterialParameterCube))
            {
                string? path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<ITexture>(path);
            }

            if (materialParameterType == typeof(CMaterialParameterFoliageParameters))
            {
                string? path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<CFoliageProfile>(path);
            }

            if (materialParameterType == typeof(CMaterialParameterGradient))
            {
                string? path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<CGradient>(path);
            }

            if (materialParameterType == typeof(CMaterialParameterHairParameters))
            {
                string? path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<CHairProfile>(path);
            }

            if (materialParameterType == typeof(CMaterialParameterMultilayerMask))
            {
                string? path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<Multilayer_Mask>(path);
            }

            if (materialParameterType == typeof(CMaterialParameterMultilayerSetup))
            {
                string? path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<Multilayer_Setup>(path);
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
                string? path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<CSkinProfile>(path);
            }

            if (materialParameterType == typeof(CMaterialParameterStructBuffer))
            {
                return null;
            }

            if (materialParameterType == typeof(CMaterialParameterTerrainSetup))
            {
                string? path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<CTerrainSetup>(path);
            }

            if (materialParameterType == typeof(CMaterialParameterTexture))
            {
                string? path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<ITexture>(path);
            }

            if (materialParameterType == typeof(CMaterialParameterTextureArray))
            {
                string? path = null;
                if (obj is JsonElement value)
                {
                    path = value.GetString();
                }

                return new CResourceReference<ITexture>(path);
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
                //return null;
                throw new NotImplementedException();
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
                //return null;
                throw new NotImplementedException();
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

        private CR2WFile LoadFile(string path, List<ICyberGameArchive> archives)
        {
            var hash = FNV1A64HashAlgorithm.HashString(path);
            foreach (var archive in archives)
            {
                if (archive.Files.TryGetValue(hash, out var gameFile))
                {
                    var ms = new MemoryStream();
                    gameFile.Extract(ms);
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

        private (string? materialTemplate, Dictionary<string, object> valueDict) GetMaterialChain(CMaterialInstance cMaterialInstance, List<ICyberGameArchive> archives, ref Dictionary<string, CMaterialTemplate> mts)
        {
            var resultDict = new Dictionary<string, object>();

            var baseMaterials = new List<CMaterialInstance>();

            var path = cMaterialInstance.BaseMaterial.DepotPath;
            while (!Path.GetExtension(path).Contains("mt"))
            {
                if (path == CName.Empty)
                {
                    return (null, resultDict);
                }

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
                    object? value = null;
                    foreach (var handle in mt.Parameters[2])
                    {
                        if (Equals(handle.Chunk.ParameterName, kvp.Key))
                        {
                            value = kvp.Value;
                        }
                    }

                    value ??= new MaterialValueWrapper { Type = kvp.Value.RedType, Value = kvp.Value };

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

        private RawMaterial ContainRawMaterial(CMaterialInstance cMaterialInstance, string name, List<ICyberGameArchive> archives, ref Dictionary<string, CMaterialTemplate> mts)
        {
            var (materialTemplatePath, valueDict) = GetMaterialChain(cMaterialInstance, archives, ref mts);
            if (materialTemplatePath == null)
            {
                _loggerService.Warning($"Missing path in \"{name}\"");
            }

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

        private static Dictionary<string, CMaterialTemplate> GetEmbeddedMaterialTemplates(ref CR2WFile cr2w)
        {
            var materialTemplates = new Dictionary<string, CMaterialTemplate>();
            foreach (var file in cr2w.EmbeddedFiles)
            {
                if (Path.GetExtension(file.FileName).Contains("mt"))
                {
                    if (file.Content is CMaterialTemplate mt)
                    {
                        materialTemplates.Add(file.FileName, mt);
                    }
                }
            }

            return materialTemplates;
        }

        public bool WriteMatToMesh(ref CR2WFile cr2w, string _matData, List<ICyberGameArchive> archives)
        {
            if (cr2w == null || cr2w.RootChunk is not CMesh cMesh || cMesh.RenderResourceBlob == null || cMesh.RenderResourceBlob.Chunk is not rendRenderMeshBlob)
            {
                return false;
            }

            var matData = RedJsonSerializer.Deserialize<MatData>(_matData).NotNull();

            var materialbuffer = new MemoryStream();
            var offsets = new List<uint>();
            var sizes = new List<uint>();
            var names = new List<string>();

            ArgumentNullException.ThrowIfNull(matData.Materials);


            if (matData.Materials.Count < 1)
            {
                return false;
            }

            var mts = new Dictionary<string, CMaterialTemplate>();
            for (var i = 0; i < matData.Materials.Count; i++)
            {
                var mat = matData.Materials[i];

                ArgumentNullException.ThrowIfNull(mat.Name);
                ArgumentNullException.ThrowIfNull(mat.MaterialTemplate);

                names.Add(mat.Name);
                var mi = new CR2WFile();
                {
                    var chunk = new CMaterialInstance
                    {
                        CookingPlatform = Enums.ECookingPlatform.PLATFORM_PC,
                        EnableMask = true,
                        ResourceVersion = 4,
                        BaseMaterial = new CResourceReference<IMaterial>(mat.BaseMaterial),
                        Values = new CArray<CKeyValuePair>()
                    };

                    CMaterialTemplate? mt = null;
                    if (mts.ContainsKey(mat.MaterialTemplate))
                    {
                        mt = mts[mat.MaterialTemplate];
                    }
                    else
                    {
                        var hash = FNV1A64HashAlgorithm.HashString(mat.MaterialTemplate);
                        foreach (var ar in archives)
                        {
                            if (ar.Files.TryGetValue(hash, out var gameFile))
                            {
                                var ms = new MemoryStream();
                                gameFile.Extract(ms);
                                ms.Seek(0, SeekOrigin.Begin);

                                if (_wolvenkitFileService.TryReadRed4File(ms, out var f) && f.RootChunk is CMaterialTemplate _mt)
                                {
                                    mt = _mt;
                                    mts.Add(mat.MaterialTemplate, mt);
                                    break;
                                }
                            }
                        }
                    }

                    var fakeMaterialInstance = new CMaterialInstance()
                    {
                        BaseMaterial = new CResourceReference<IMaterial>(mat.BaseMaterial),
                        Values = new CArray<CKeyValuePair>()
                    };
                    var (materialTemplate, valueDict) = GetMaterialChain(fakeMaterialInstance, archives, ref mts);

                    if (mt != null)
                    {
                        var list = matData.Materials[i].Data;
                        if (list is not null)
                        {
                            foreach (var (key, value) in list)
                            {
                                var found = false;

                                for (var k = 0; k < mt.Parameters[2].Count; k++)
                                {
                                    var refer = mt.Parameters[2][k].Chunk;

                                    if (refer.ParameterName == key)
                                    {
                                        found = true;

                                        var convValue = GetMaterialParameterValue(refer.GetType(), value);
                                        if (valueDict.ContainsKey(refer.ParameterName) && !Equals(valueDict[refer.ParameterName], convValue))
                                        {
                                            chunk.Values.Add(new CKeyValuePair(refer.ParameterName, convValue));
                                        }
                                    }
                                }

                                if (!found)
                                {
                                    var wrapper = ((JsonElement)value).Deserialize<MaterialValueWrapper>().NotNull();
                                    var (type, _) = RedReflection.GetCSTypeFromRedType(wrapper.Type);

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
                blob.MaterialEntries.Add(new CMeshMaterialEntry
                {
                    IsLocalInstance = true,
                    Name = names[i],
                    Index = (ushort)i
                });

                blob.LocalMaterialBuffer.RawDataHeaders.Add(new meshLocalMaterialHeader
                {
                    Offset = offsets[i],
                    Size = sizes[i]
                });
            }

            if (blob.LocalMaterialBuffer.RawData == null)
            {
                blob.LocalMaterialBuffer.RawData = new WolvenKit.RED4.Types.DataBuffer(materialbuffer.ToArray());
            }
            else
            {
                // Forcing the data to null, so it doesn't generate a new byte array on write
                // TODO: Should be handled better
                blob.LocalMaterialBuffer.RawData.Buffer.Data = null;
                blob.LocalMaterialBuffer.RawData.Buffer.SetBytes(materialbuffer.ToArray());
            }

            return true;
        }
    }
}
