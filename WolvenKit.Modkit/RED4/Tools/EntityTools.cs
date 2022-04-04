using System.Collections.Generic;
using System.IO;
using SharpGLTF.Schema2;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.RED4.Compiled;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        public bool GetStreamFromCName(CName cname, out Stream stream)
        {
            var file = _archiveManager.Lookup(cname.GetRedHash());
            if (file.HasValue && file.Value is FileEntry fe)
            {
                stream = new MemoryStream();
                fe.Extract(stream);

                return true;
            }
            stream = null;
            return false;

        }

        public bool GetFileFromCName(CName cname, out CR2WFile cr2w)
        {
            cr2w = null;
            return GetStreamFromCName(cname, out var stream) &&
                _wolvenkitFileService.TryReadRed4File(stream, out cr2w);
        }

        public bool ExportEntity(Stream entStream, CName appearance, FileInfo outfile)
        {
            _wolvenkitFileService.TryReadRed4File(entStream, out var cr2w);
            return ExportEntity(cr2w, appearance, outfile);
        }

        public bool ExportEntity(CR2WFile entFile, CName appearance, FileInfo outfile)
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
            animAnimSet anims = null;
            var rigs = new Dictionary<string, List<string>>();
            var slots = new Dictionary<string, Dictionary<string, string>>();
            var slotParents = new Dictionary<string, string>();

            foreach (var component in entPkg.Chunks)
            {
                if (component is entAnimatedComponent eac)
                {
                    if (GetFileFromCName(eac.Rig.DepotPath, out var rigFile) && rigFile.RootChunk is animRig rig)
                    {
                        rigs[eac.Name] = new List<string>();
                        foreach (var name in rig.BoneNames)
                        {
                            rigs[eac.Name].Add(name);
                        }
                    }

                    foreach (var entry in eac.Animations.Gameplay)
                    {
                        if (entry is not animAnimSetupEntry aase)
                        {
                            continue;
                        }

                        if (!GetFileFromCName(aase.AnimSet.DepotPath, out animsFile))
                        {
                            continue;
                        }
                    }
                }

                if (component is entSlotComponent esc)
                {
                    if (esc.ParentTransform != null && esc.ParentTransform.GetValue() is entHardTransformBinding ehtb)
                    {
                        slotParents[esc.Name] = ehtb.BindName;
                    }
                    slots[esc.Name] = new Dictionary<string, string>();
                    foreach (var slot in esc.Slots)
                    {
                        slots[esc.Name][slot.SlotName] = slot.BoneName;
                    }
                }
            }

            if (animsFile != null)
            {
                anims = animsFile.RootChunk as animAnimSet;
            }

            foreach (var app in eet.Appearances)
            {
                if (app.AppearanceName != appearance && appearance != "default")
                {
                    continue;
                }

                if (!GetFileFromCName(app.AppearanceResource.DepotPath, out var appFile))
                {
                    continue;
                }

                if (appFile.RootChunk is not appearanceAppearanceResource aar)
                {
                    continue;
                }

                foreach (var appApp in aar.Appearances)
                {
                    if (appApp.GetValue() is not appearanceAppearanceDefinition aad || (aad.Name != appearance && appearance != "default") || aad.CompiledData.Data is not Package04 appPkg)
                    {
                        continue;
                    }

                    var root = ModelRoot.CreateModel();

                    if (animsFile is not null && GetFileFromCName(anims.Rig.DepotPath, out var rigFile))
                    {
                        GetAnimation(animsFile, rigFile, ref root, true);
                    }

                    var nodes = new Dictionary<string, Node>();

                    var unhandleChunks = new List<RedBaseClass>();

                    var materials = new Dictionary<string, Material>();

                    foreach (var component in appPkg.Chunks)
                    {
                        if (component is IRedMeshComponent mc && mc.ParentTransform != null)
                        {
                            var transform = (entHardTransformBinding)mc.ParentTransform.GetValue();

                            Node node = null;

                            if (slots.ContainsKey(transform.BindName))
                            {
                                if (slots[transform.BindName].ContainsKey(transform.SlotName))
                                {
                                    var boneName = slots[transform.BindName][transform.SlotName];
                                    if (rigs.ContainsKey(slotParents[transform.BindName]))
                                    {
                                        if (rigs[slotParents[transform.BindName]].Contains(boneName))
                                        {
                                            node = root.LogicalSkins[0].GetJoint(rigs[slotParents[transform.BindName]].IndexOf(boneName)).Joint.CreateNode(mc.Name);
                                        }
                                    }
                                }
                            }

                            if (node == null)
                            {
                                unhandleChunks.Add((RedBaseClass)mc);
                                continue;
                            }
                            if (component is entMeshComponent emc)
                            {
                                node.LocalTransform = new SharpGLTF.Transforms.AffineTransform(ToVector3(emc.VisualScale), ToQuaternion(mc.LocalTransform.Orientation), ToVector3(mc.LocalTransform.Position));
                            }
                            else
                            {
                                node.LocalTransform = new SharpGLTF.Transforms.AffineTransform(new System.Numerics.Vector3(1f, 1f, 1f), ToQuaternion(mc.LocalTransform.Orientation), ToVector3(mc.LocalTransform.Position));
                            }
                            nodes.Add(mc.Name, node);

                            if (!GetFileFromCName(mc.Mesh.DepotPath, out var meshFile))
                            {
                                continue;
                            }

                            MeshTools.AddMeshToModel(meshFile, root, root.LogicalSkins[0], node, true, mc.ChunkMask, materials);

                            foreach (var child in node.VisualChildren)
                            {
                                child.Name = mc.Name + "_" + child.Name;
                            }
                        }
                    }

                    foreach (var component in unhandleChunks)
                    {
                        if (component is IRedMeshComponent mc)
                        {
                            if (!GetFileFromCName(mc.Mesh.DepotPath, out var meshFile))
                            {
                                continue;
                            }

                            Node node = null;

                            var transform = (entHardTransformBinding)mc.ParentTransform.GetValue();
                            if (nodes.ContainsKey(transform.BindName))
                            {
                                node = nodes[transform.BindName].CreateNode(mc.Name);
                            }
                            else
                            {
                                node = root.LogicalSkins[0].GetJoint(0).Joint.CreateNode(mc.Name);
                            }

                            if (component is entMeshComponent emc)
                            {
                                node.LocalTransform = new SharpGLTF.Transforms.AffineTransform(ToVector3(emc.VisualScale), ToQuaternion(mc.LocalTransform.Orientation), ToVector3(mc.LocalTransform.Position));
                            }
                            else
                            {
                                node.LocalTransform = new SharpGLTF.Transforms.AffineTransform(new System.Numerics.Vector3(1f, 1f, 1f), ToQuaternion(mc.LocalTransform.Orientation), ToVector3(mc.LocalTransform.Position));
                            }
                            nodes.Add(mc.Name, node);

                            MeshTools.AddMeshToModel(meshFile, root, root.LogicalSkins[0], node, true, mc.ChunkMask, materials);

                            foreach (var child in node.VisualChildren)
                            {
                                child.Name = mc.Name + "_" + child.Name;
                            }
                        }
                    }

                    root.SaveGLB(outfile.FullName);
                    return true;
                }
            }
            return false;
        }

        public static System.Numerics.Vector3 ToVector3(WolvenKit.RED4.Types.Vector3 v) => new System.Numerics.Vector3(v.X, v.Z, v.Y);

        public static System.Numerics.Quaternion ToQuaternion(WolvenKit.RED4.Types.Quaternion q) => new System.Numerics.Quaternion(q.I, q.K, -q.J, q.R);

        public static System.Numerics.Vector3 ToVector3(WolvenKit.RED4.Types.WorldPosition p) => new System.Numerics.Vector3(p.X, p.Z, -p.Y);

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
