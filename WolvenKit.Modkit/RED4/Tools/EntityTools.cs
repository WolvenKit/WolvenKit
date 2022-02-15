using System.Collections.Generic;
using System.IO;
using CP77.CR2W;
using SharpGLTF.Schema2;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.RED4.Compiled;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        public static bool GetStreamFromCName(CName cname, List<Archive> archives, out Stream stream)
        {
            var hash = cname.GetRedHash();
            foreach (var ar in archives)
            {
                if (ar.Files.ContainsKey(hash))
                {
                    stream = new MemoryStream();
                    ExtractSingleToStream(ar, hash, stream);
                    return true;
                }
            }
            stream = null;
            return false;
        }

        public bool GetFileFromCName(CName cname, List<Archive> archives, out CR2WFile cr2w)
        {
            cr2w = null;
            return GetStreamFromCName(cname, archives, out var stream) &&
                _wolvenkitFileService.TryReadRed4File(stream, out cr2w);
        }

        public bool ExportEntity(CR2WFile entFile, CName appearance, List<Archive> archives, FileInfo outfile)
        {
            if (entFile.RootChunk is not entEntityTemplate eet)
            {
                return false;
            }

            if (eet.CompiledData.Data is not Package04 entPkg)
            {
                return false;
            }

            CR2WFile animsFile = null;

            foreach (var component in entPkg.Chunks)
            {
                if (component is entAnimatedComponent eac)
                {
                    foreach (var entry in eac.Animations.Gameplay)
                    {
                        if (entry is not animAnimSetupEntry aase)
                        {
                            continue;
                        }

                        if (!GetFileFromCName(aase.AnimSet.DepotPath, archives, out animsFile))
                        {
                            continue;
                        }
                    }
                }
            }

            var anims = animsFile.RootChunk as animAnimSet;

            foreach (var app in eet.Appearances)
            {
                if (app.Name != appearance)
                {
                    continue;
                }

                if (!GetFileFromCName(app.AppearanceResource.DepotPath, archives, out var appFile))
                {
                    return false;
                }

                if (appFile.RootChunk is not appearanceAppearanceResource aar)
                {
                    return false;
                }

                foreach (var appApp in aar.Appearances)
                {
                    if (appApp.GetValue() is not appearanceAppearanceDefinition aad || aad.Name != appearance || aad.CompiledData.Data is not Package04 appPkg)
                    {
                        continue;
                    }

                    var root = ModelRoot.CreateModel();

                    if (animsFile is not null && GetFileFromCName(anims.Rig.DepotPath, archives, out var rigFile))
                    {
                        GetAnimation(animsFile, rigFile, ref root, true);
                    }

                    foreach (var component in appPkg.Chunks)
                    {
                        if (component is entPhysicalMeshComponent epmc)
                        {
                            if (!GetFileFromCName(epmc.Mesh.DepotPath, archives, out var meshFile))
                            {
                                continue;
                            }
                            var model = MeshTools.GetModel(meshFile, true, true, epmc.ChunkMask);

                            foreach (var mesh in model.LogicalMeshes)
                            {
                                var node = root.LogicalNodes[0].CreateNode();
                                node.Mesh = mesh;
                                node.Skin = root.LogicalSkins[0];
                            }
                            // TODO
                        }
                    }

                    // TODO

                    root.SaveGLB(outfile.FullName);
                    return true;
                }
            }
            return false;
        }

        public bool DumpEntityPackageAsJson(Stream entStream, FileInfo outfile)
        {
            var outpath = Path.ChangeExtension(outfile.FullName, ".json");
            if (!_wolvenkitFileService.TryReadRed4File(entStream, out var cr2w))
            {
                return false;
            }
            if (cr2w.RootChunk is entEntityTemplate)
            {
                return DumpEntPackage(cr2w, entStream, outpath);
            }
            if (cr2w.RootChunk is appearanceAppearanceResource)
            {
                return DumpAppPackage(cr2w, entStream, outpath);
            }
            return false;
        }

        private bool DumpEntPackage(CR2WFile cr2w, Stream entStream, string outfile)
        {
            var blob = cr2w.RootChunk as entEntityTemplate;

            if (blob.CompiledData.Buffer.MemSize > 0)
            {
                var packageStream = new MemoryStream();
                packageStream.Write(blob.CompiledData.Buffer.GetBytes());

                var package = new CompiledPackage(_hashService);
                packageStream.Seek(0, SeekOrigin.Begin);
                package.Read(new BinaryReader(packageStream));
                var data = RedJsonSerializer.Serialize(new RedFileDto(cr2w));
                File.WriteAllText(outfile, data);
                return true;
            }
            return false;
        }

        private bool DumpAppPackage(CR2WFile cr2w, Stream appStream, string outfile)
        {
            var blob = cr2w.RootChunk as appearanceAppearanceResource;

            var datas = new List<RedFileDto>();
            foreach (var appearance in blob.Appearances)
            {
                if (appearance.Chunk.CompiledData.Buffer.MemSize > 0)
                {
                    var packageStream = new MemoryStream();
                    packageStream.Write(appearance.Chunk.CompiledData.Buffer.GetBytes());

                    var package = new CompiledPackage(_hashService);
                    packageStream.Seek(0, SeekOrigin.Begin);
                    package.Read(new BinaryReader(packageStream));
                    datas.Add(new RedFileDto(cr2w));
                }
            }
            if (datas.Count > 1)
            {
                var data = RedJsonSerializer.Serialize(datas);
                File.WriteAllText(outfile, data);
                return true;
            }
            return false;
        }

    }
}
