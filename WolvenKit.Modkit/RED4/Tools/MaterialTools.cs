using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using SharpGLTF.Schema2;
using SharpGLTF.Validation;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.Core.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Arguments;
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
        // Unused?
        /*
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

            var cr2w = _parserService.ReadRed4File(meshStream);
            if (cr2w == null || cr2w.RootChunk is not CMesh cMesh || cMesh.RenderResourceBlob == null || cMesh.RenderResourceBlob.Chunk is not rendRenderMeshBlob rendblob)
            {
                return false;
            }

            using var ms = new MemoryStream(rendblob.RenderBuffer.Buffer.GetBytes());

            var meshesinfo = MeshTools.GetMeshesinfo(rendblob, cr2w.RootChunk as CMesh);

            var expMeshes = MeshTools.ContainRawMesh(ms, meshesinfo, LodFilter);
            MeshTools.UpdateSkinningParamCloth(ref expMeshes, meshStream, cr2w);
            MeshTools.WriteGarmentParametersToMesh(ref expMeshes, cMesh, meshArgs.ExportGarmentSupport);

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
        */
        private void GetMaterialEntries(CR2WFile cr2w, Stream meshStream, ref List<string> primaryDependencies, ref List<string> materialEntryNames, ref List<CMaterialInstance> materialEntries, List<ICyberGameArchive> archives)
        {
            if (cr2w.RootChunk is not CMesh cmesh)
            {
                throw new ArgumentException(nameof(cr2w));
            }

            var externalMaterial = new List<CMaterialInstance>();

            foreach (var material in cmesh.ExternalMaterials)
            {
                var path = material.DepotPath;
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
                        externalMaterial.Add(mi);
                    }
                    else
                    {
                        // The external materials can also directly reference MaterialTemplates. To keep it easier for the exporter we can expose these as material instances
                        var fakeMaterialInstance = new CMaterialInstance
                        {
                            BaseMaterial = new CResourceReference<IMaterial>(path),
                            Values = new CArray<CKeyValuePair>()
                        };

                        externalMaterial.Add(fakeMaterialInstance);
                    }


                    foreach (var import in result.Imports)
                    {
                        if (!primaryDependencies.Contains(import.DepotPath.ToString().NotNull()))
                        {
                            primaryDependencies.Add(import.DepotPath.ToString().NotNull());
                        }
                    }
                }
                else if (findStatus == FindFileResult.NoCR2W)
                {
                    throw new InvalidParsingException("Error while parsing a file");
                }
                else
                {
                    throw new InvalidParsingException($"Error while finding the file: {path}");
                }
            }

            foreach (var material in cmesh.PreloadExternalMaterials)
            {
                var path = material.DepotPath;
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
                        externalMaterial.Add(mi);
                    }
                    else
                    {
                        // The external materials can also directly reference MaterialTemplates. To keep it easier for the exporter we can expose these as material instances
                        var fakeMaterialInstance = new CMaterialInstance
                        {
                            BaseMaterial = new CResourceReference<IMaterial>(path),
                            Values = new CArray<CKeyValuePair>()
                        };

                        externalMaterial.Add(fakeMaterialInstance);
                    }

                    foreach (var import in result.Imports)
                    {
                        if (!primaryDependencies.Contains(import.DepotPath.ToString().NotNull()))
                        {
                            primaryDependencies.Add(import.DepotPath.ToString().NotNull());
                        }
                    }
                }
                else if (findStatus == FindFileResult.NoCR2W)
                {
                    throw new InvalidParsingException("Error while parsing a file");
                }
            }

            var localMaterial = new List<CMaterialInstance>();

            if (cmesh.LocalMaterialBuffer.RawDataHeaders.Count != 0)
            {
                var materialStream = GetMaterialStream(meshStream, cr2w);
                var bytes = materialStream.ToArray();
                foreach (var rawDataHeader in cmesh.LocalMaterialBuffer.RawDataHeaders)
                {
                    var header = rawDataHeader.NotNull();
                    uint offset = header.Offset;
                    uint size = header.Size;

                    var ms = new MemoryStream(bytes, (int)offset, (int)size);

                    var isResource = _parserService.IsCR2WFile(ms);
                    if (!isResource)
                    {
                        throw new InvalidParsingException("not a cr2w file");
                    }

                    using var reader = new CR2WReader(ms);
                    reader.ParsingError += args => args is InvalidDefaultValueEventArgs;

                    _ = reader.ReadFile(out var mi, false);

                    ArgumentNullException.ThrowIfNull(mi);

                    foreach (var import in reader.ImportsList)
                    {
                        if (!primaryDependencies.Contains(import.DepotPath.ToString().NotNull()))
                        {
                            primaryDependencies.Add(import.DepotPath.ToString().NotNull());
                        }
                    }

                    var instance = (mi.RootChunk as CMaterialInstance).NotNull();
                    localMaterial.Add(instance);
                }
            }
            else
            {
                foreach (var handle in cmesh.PreloadLocalMaterialInstances)
                {
                    if (handle.NotNull().Chunk is CMaterialInstance mi1)
                    {
                        localMaterial.Add(mi1);
                    }
                }

                foreach (var import in cr2w.Info.GetImports())
                {
                    if (!primaryDependencies.Contains(import.ToString().NotNull()))
                    {
                        primaryDependencies.Add(import.ToString().NotNull());
                    }
                }
            }

            var count = cmesh.MaterialEntries.Count;
            for (var i = 0; i < count; i++)
            {
                var entry = cmesh.MaterialEntries[i].NotNull();
                materialEntryNames.Add(entry.Name.ToString().NotNull());
                if (entry.IsLocalInstance)
                {
                    materialEntries.Add(localMaterial[entry.Index]);
                }
                else
                {
                    materialEntries.Add(externalMaterial[entry.Index]);
                }
            }
            foreach (var p in materialEntries.Select(m => m.BaseMaterial.DepotPath).Where(path => path != 0))
            {
                var path = p;
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
                                if (!primaryDependencies.Contains(import.DepotPath.ToString().NotNull()))
                                {
                                    primaryDependencies.Add(import.DepotPath.ToString().NotNull());
                                }
                            }
                        }
                        else if (result.File.RootChunk is CMaterialTemplate mt)
                        {
                            foreach (var import in result.Imports)
                            {
                                if (!primaryDependencies.Contains(import.DepotPath.ToString().NotNull()))
                                {
                                    primaryDependencies.Add(import.DepotPath.ToString().NotNull());
                                }
                            }
                            break;
                        }
                        else
                        {
                            throw new InvalidParsingException($"Unexpected class found: {path}");
                        }
                    }
                    else if (findStatus == FindFileResult.NoCR2W)
                    {
                        throw new InvalidParsingException("Error while parsing a file");
                    }
                    else
                    {
                        throw new InvalidParsingException($"Error while finding the file: {path}");
                    }
                }
            }
        }

        private MatData SetupMaterial(CR2WFile cr2w, Stream meshStream, List<ICyberGameArchive> archives, string matRepo, MeshesInfo info, EUncookExtension eUncookExtension = EUncookExtension.dds, bool experimentUseNewMeshExporter = false)
        {
            var primaryDependencies = new List<string>();

            var materialEntryNames = new List<string>();
            var materialEntries = new List<CMaterialInstance>();

            GetMaterialEntries(cr2w, meshStream, ref primaryDependencies, ref materialEntryNames, ref materialEntries, archives);

            var mlSetupNames = new List<string>();

            var mlTemplateNames = new List<string>();

            var hairProfileNames = new List<string>();

            var texturesList = new List<string>();

            var exportArgs =
                new GlobalExportArgs().Register(
                    new XbmExportArgs() { UncookExtension = eUncookExtension },
                    new MlmaskExportArgs() { UncookExtension = eUncookExtension }
                );

            if (experimentUseNewMeshExporter)
            {
                _loggerService.Info($"SetupMaterial: skipping all .mi or .mt material entries");
            }

            foreach (var path in primaryDependencies)
            {
                ExtractFile(path);
            }

            var usedMts = GetEmbeddedMaterialTemplates(ref cr2w);
            var rawMaterials = materialEntries.Select((t, i) => ContainRawMaterial(t, materialEntryNames[i], archives, ref usedMts)).ToList();

            var matTemplates = new List<RawMaterial>();
            {
                var keys = usedMts.Keys.ToList();
                foreach (var key in keys)
                {
                    var rawMat = new RawMaterial
                    {
                        Name = key,
                        Data = new Dictionary<string, object?>()
                    };

                    foreach (var item in usedMts[key].Parameters[2].NotNull())
                    {
                        rawMat.Data.Add(item.NotNull().Chunk.NotNull().ParameterName.ToString().NotNull(), GetSerializableValue(item.Chunk.NotNull()));
                    }

                    matTemplates.Add(rawMat);
                }
            }

            var matData = new MatData(matRepo, rawMaterials, texturesList, matTemplates, info.appearances);

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
                        break;
                }

                // params must be renamed from path to avoid overwriting of outer variable
                void ExtractXBM(string extractionPath)
                {
                    if (!texturesList.Contains(extractionPath))
                    {
                        texturesList.Add(extractionPath);
                    }

                    var destFileName = Path.Combine(matRepo, Path.ChangeExtension(extractionPath, "." + exportArgs.Get<XbmExportArgs>().UncookExtension));
                    if (!File.Exists(destFileName))
                    {
                        UncookFile(archives, extractionPath, matRepo, exportArgs);
                    }
                }

                void ExtractMlMask(string extractionPath)
                {
                    if (!texturesList.Contains(extractionPath))
                    {
                        texturesList.Add(extractionPath);
                    }

                    var destFileName = Path.Combine(matRepo, extractionPath.Replace(".mlmask", $"_0.{exportArgs.Get<XbmExportArgs>().UncookExtension}"));
                    if (!File.Exists(destFileName))
                    {
                        exportArgs.Get<MlmaskExportArgs>().AsList = false;
                        UncookFile(archives, extractionPath, matRepo, exportArgs);
                    }
                }

                void ExtractHP(string extractionPath)
                {
                    if (hairProfileNames.Contains(extractionPath))
                    {
                        return;
                    }

                    hairProfileNames.Add(extractionPath);

                    var fi = new FileInfo(Path.Combine(matRepo, Path.ChangeExtension(extractionPath, ".hp.json")));
                    if (!fi.Exists)
                    {
                        var findStatus = TryFindFile(archives, extractionPath, out var result);
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

                void ExtractMlSetup(string extractionPath)
                {
                    if (mlSetupNames.Contains(path))
                    {
                        return;
                    }

                    mlSetupNames.Add(extractionPath);

                    var fi = new FileInfo(Path.Combine(matRepo, Path.ChangeExtension(extractionPath, ".mlsetup.json")));
                    if (!fi.Exists)
                    {
                        var findStatus = TryFindFile(archives, extractionPath, out var result);
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
                                ExtractFile(import.DepotPath.ToString().NotNull());
                            }
                        }
                        else if (findStatus == FindFileResult.NoCR2W)
                        {
                            throw new InvalidParsingException("Error while parsing a file");
                        }
                    }
                }

                void ExtractMlTemplate(string extractionPath)
                {
                    if (mlTemplateNames.Contains(extractionPath))
                    {
                        return;
                    }

                    mlTemplateNames.Add(extractionPath);

                    var fi = new FileInfo(Path.Combine(matRepo, Path.ChangeExtension(extractionPath, ".mltemplate.json")));
                    if (!fi.Exists)
                    {
                        var findStatus = TryFindFile(archives, extractionPath, out var result);
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
                                ExtractFile(import.DepotPath.ToString().NotNull());
                            }

                            var mlTemplateMats = result.File.RootChunk.FindType(typeof(CResourceReference<CBitmapTexture>));
                            foreach (var mat in mlTemplateMats.Select(mlTemplateMat => (CResourceReference<CBitmapTexture>)mlTemplateMat.Value))
                            {
                                ExtractXBM(mat.DepotPath.ToString().NotNull());
                            }
                        }
                        else if (findStatus == FindFileResult.NoCR2W)
                        {
                            throw new InvalidParsingException("Error while parsing a file");
                        }
                    }
                }

                void ExtractGradient(string extractionPath)
                {
                    if (texturesList.Contains(extractionPath))
                    {
                        return;
                    }

                    texturesList.Add(extractionPath);

                    var fi = new FileInfo(Path.Combine(matRepo, Path.ChangeExtension(extractionPath, ".gradient.json")));
                    if (!fi.Exists)
                    {
                        var findStatus = TryFindFile(archives, extractionPath, out var result);
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
                    consMatData.Appearances.TryAdd(app.Key, app.Value);
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

            var hairProfileNames = new List<string>();

            var texturesList = new List<string>();

            var exportArgs =
                new GlobalExportArgs().Register(
                    new XbmExportArgs() { UncookExtension = eUncookExtension },
                    new MlmaskExportArgs() { UncookExtension = eUncookExtension }
                );

            foreach (var p in primaryDependencies)
            {
                ExtractFile(p);
            }

            var usedMts = GetEmbeddedMaterialTemplates(ref cr2w);
            var rawMaterials = materialEntries.Select((t, i) => ContainRawMaterial(t, materialEntryNames[i], archives, ref usedMts)).ToList();

            var matTemplates = new List<RawMaterial>();
            {
                var keys = usedMts.Keys.ToList();
                foreach (var key in keys)
                {
                    var rawMat = new RawMaterial
                    {
                        Name = key,
                        Data = new Dictionary<string, object?>()
                    };

                    foreach (var item in usedMts[key].Parameters[2].NotNull())
                    {
                        rawMat.Data.Add(item.NotNull().Chunk.NotNull().ParameterName.ToString().NotNull(), GetSerializableValue(item.Chunk.NotNull()));
                    }

                    matTemplates.Add(rawMat);
                }
            }

            var matData = new MatData(matRepo, rawMaterials, texturesList, matTemplates, info.appearances);

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

                void ExtractXBM(string extractionPath)
                {
                    if (!texturesList.Contains(extractionPath))
                    {
                        texturesList.Add(extractionPath);
                    }

                    var destFileName = Path.Combine(matRepo, Path.ChangeExtension(extractionPath, "." + exportArgs.Get<XbmExportArgs>().UncookExtension));
                    if (!File.Exists(destFileName))
                    {
                        UncookFile(archives, extractionPath, matRepo, exportArgs);
                    }
                }

                void ExtractMlMask(string extractionPath)
                {
                    if (!texturesList.Contains(extractionPath))
                    {
                        texturesList.Add(extractionPath);
                    }

                    var destFileName = Path.Combine(matRepo, extractionPath.Replace(".mlmask", $"_0.{exportArgs.Get<XbmExportArgs>().UncookExtension}"));
                    if (!File.Exists(destFileName))
                    {
                        exportArgs.Get<MlmaskExportArgs>().AsList = false;
                        UncookFile(archives, extractionPath, matRepo, exportArgs);
                    }
                }

                void ExtractHP(string extractionPath)
                {
                    if (hairProfileNames.Contains(extractionPath))
                    {
                        return;
                    }

                    hairProfileNames.Add(extractionPath);

                    var fi = new FileInfo(Path.Combine(matRepo, Path.ChangeExtension(extractionPath, ".hp.json")));
                    if (!fi.Exists)
                    {
                        var findStatus = TryFindFile(archives, extractionPath, out var result);
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

                void ExtractMlSetup(string extractionPath)
                {
                    if (mlSetupNames.Contains(extractionPath))
                    {
                        return;
                    }

                    mlSetupNames.Add(extractionPath);

                    var fi = new FileInfo(Path.Combine(matRepo, Path.ChangeExtension(extractionPath, ".mlsetup.json")));
                    if (!fi.Exists)
                    {
                        var findStatus = TryFindFile(archives, extractionPath, out var result);
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
                                ExtractFile(import.DepotPath.ToString().NotNull());
                            }
                        }
                        else if (findStatus == FindFileResult.NoCR2W)
                        {
                            throw new InvalidParsingException("Error while parsing a file");
                        }
                    }
                }

                void ExtractMlTemplate(string extractionPath)
                {
                    if (mlTemplateNames.Contains(extractionPath))
                    {
                        return;
                    }

                    mlTemplateNames.Add(extractionPath);

                    var fi = new FileInfo(Path.Combine(matRepo, Path.ChangeExtension(extractionPath, ".mltemplate.json")));
                    if (!fi.Exists)
                    {
                        var findStatus = TryFindFile(archives, extractionPath, out var result);
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
                                ExtractFile(import.DepotPath.ToString().NotNull());
                            }

                            var mlTemplateMats = result.File.RootChunk.FindType(typeof(CResourceReference<CBitmapTexture>));
                            foreach (var mat in mlTemplateMats.Select(mlTemplateMat => (CResourceReference<CBitmapTexture>)mlTemplateMat.Value))
                            {
                                ExtractXBM(mat.DepotPath.ToString().NotNull());
                            }
                        }
                        else if (findStatus == FindFileResult.NoCR2W)
                        {
                            throw new InvalidParsingException("Error while parsing a file");
                        }
                    }
                }

                void ExtractGradient(string extractionPath)
                {
                    if (texturesList.Contains(extractionPath))
                    {
                        return;
                    }

                    texturesList.Add(extractionPath);

                    var fi = new FileInfo(Path.Combine(matRepo, Path.ChangeExtension(extractionPath, ".gradient.json")));
                    if (!fi.Exists)
                    {
                        var findStatus = TryFindFile(archives, extractionPath, out var result);
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

                    if (!_parserService.TryReadRed4File(ms, out var file))
                    {
                        throw new Exception("Invalid CR2W file");
                    }

                    return file;
                }
            }

            throw new FileNotFoundException(path);
        }

        private (string? materialTemplate, Dictionary<string, object?> valueDict, bool enableMask) GetMaterialChain(CMaterialInstance cMaterialInstance, List<ICyberGameArchive> archives, ref Dictionary<string, CMaterialTemplate> mts)
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

                var file = LoadFile(path.ToString().NotNull(), archives);
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
                var file = LoadFile(spath, archives);
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

        private RawMaterial ContainRawMaterial(CMaterialInstance cMaterialInstance, string name, List<ICyberGameArchive> archives, ref Dictionary<string, CMaterialTemplate> mts)
        {
            var (materialTemplatePath, valueDict, enableMask) = GetMaterialChain(cMaterialInstance, archives, ref mts);
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
                        materialTemplates.Add(file.FileName, mt);
                    }
                }
            }

            return materialTemplates;
        }

        public bool WriteMatToMesh(ref CR2WFile cr2w, string _matData, List<ICyberGameArchive> archives)
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
                    foreach (var ar in archives)
                    {
                        if (ar.Files.TryGetValue(hash, out var gameFile))
                        {
                            var ms = new MemoryStream();
                            gameFile.Extract(ms);
                            ms.Seek(0, SeekOrigin.Begin);

                            if (_parserService.TryReadRed4File(ms, out var f) && f.RootChunk is CMaterialTemplate _mt)
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
                var (materialTemplate, valueDict, enableMask) = GetMaterialChain(fakeMaterialInstance, archives, ref mts);

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
