using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using SharpGLTF.Schema2;
using WolvenKit.Common.Conversion;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        public bool GetStreamFromResourcePath(ResourcePath resourcePath, [NotNullWhen(true)] out Stream? stream)
        {
            var file = _archiveManager.Lookup(resourcePath.GetRedHash());
            if (file.HasValue && file.Value is FileEntry fe)
            {
                stream = new MemoryStream();
                fe.Extract(stream);

                return true;
            }

            stream = null;
            return false;

        }

        public bool GetFileFromResourcePath(ResourcePath resourcePath, [NotNullWhen(true)] out CR2WFile? cr2w)
        {
            if (GetStreamFromResourcePath(resourcePath, out var stream) && _parserService.TryReadRed4File(stream, out cr2w))
            {
                return true;
            }

            cr2w = null;
            return false;
        }

        public bool ExportEntity(Stream entStream, CName appearance, FileInfo outfile)
        {
            if (_parserService.TryReadRed4File(entStream, out var cr2w))
            {
                return ExportEntity(cr2w, appearance, outfile);
            }

            return false;
        }

        public bool ExportEntity(CR2WFile entFile, CName appearance, FileInfo outfile)
        {
            if (entFile.RootChunk is not entEntityTemplate eet)
            {
                return false;
            }

            if (eet.CompiledData.Data is not RedPackage entPkg)
            {
                return false;
            }

            CR2WFile? animsFile = null;
            var rigs = new Dictionary<string, List<string>>();
            var slots = new Dictionary<string, Dictionary<string, string>>();
            var slotParents = new Dictionary<string, string>();

            foreach (var component in entPkg.Chunks)
            {
                if (component is entAnimatedComponent eac)
                {
                    if (GetFileFromResourcePath(eac.Rig.DepotPath, out var rigFile) && rigFile.RootChunk is animRig rig)
                    {
                        NotResolvableException.ThrowIfNotResolvable(eac.Name);

                        rigs[eac.Name!] = new List<string>();
                        foreach (var name in rig.BoneNames)
                        {
                            NotResolvableException.ThrowIfNotResolvable(name);

                            rigs[eac.Name!].Add(name!);
                        }
                    }

                    foreach (var entry in eac.Animations.Gameplay)
                    {
                        if (entry is not animAnimSetupEntry aase)
                        {
                            continue;
                        }

                        if (!GetFileFromResourcePath(aase.AnimSet.DepotPath, out animsFile))
                        {
                            continue;
                        }
                    }
                }

                if (component is entSlotComponent esc)
                {
                    NotResolvableException.ThrowIfNotResolvable(esc.Name);

                    if (esc.ParentTransform != null && esc.ParentTransform.GetValue() is entHardTransformBinding ehtb)
                    {
                        NotResolvableException.ThrowIfNotResolvable(ehtb.BindName);

                        slotParents[esc.Name!] = ehtb.BindName!;
                    }
                    slots[esc.Name!] = new Dictionary<string, string>();
                    foreach (var slot in esc.Slots)
                    {
                        ArgumentNullException.ThrowIfNull(slot);
                        NotResolvableException.ThrowIfNotResolvable(slot.SlotName);
                        NotResolvableException.ThrowIfNotResolvable(slot.BoneName);

                        slots[esc.Name!][slot.SlotName!] = slot.BoneName!;
                    }
                }
            }

            if (animsFile is null)
            {
                throw new InvalidParsingException(nameof(animsFile));
            }

            if (animsFile.RootChunk is not animAnimSet anims)
            {
                throw new InvalidParsingException(nameof(animsFile));
            }

            foreach (var app in eet.Appearances)
            {
                ArgumentNullException.ThrowIfNull(app);

                if (app.AppearanceName != appearance && appearance != "default")
                {
                    continue;
                }

                if (!GetFileFromResourcePath(app.AppearanceResource.DepotPath, out var appFile))
                {
                    continue;
                }

                if (appFile.RootChunk is not appearanceAppearanceResource aar)
                {
                    continue;
                }

                foreach (var appApp in aar.Appearances)
                {
                    ArgumentNullException.ThrowIfNull(appApp);

                    if (appApp.GetValue() is not appearanceAppearanceDefinition aad || (aad.Name != appearance && appearance != "default") || aad.CompiledData.Data is not RedPackage appPkg)
                    {
                        continue;
                    }

                    var root = ModelRoot.CreateModel();

                    if (animsFile is not null && GetFileFromResourcePath(anims.Rig.DepotPath, out var rigFile))
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
                            NotResolvableException.ThrowIfNotResolvable(mc.Name);

                            var transform = (entHardTransformBinding)mc.ParentTransform.GetValue();

                            NotResolvableException.ThrowIfNotResolvable(transform.BindName);
                            NotResolvableException.ThrowIfNotResolvable(transform.SlotName);

                            Node? node = null;

                            if (slots.ContainsKey(transform.BindName!))
                            {
                                if (slots[transform.BindName!].ContainsKey(transform.SlotName!))
                                {
                                    var boneName = slots[transform.BindName!][transform.SlotName!];
                                    if (rigs.ContainsKey(slotParents[transform.BindName!]))
                                    {
                                        if (rigs[slotParents[transform.BindName!]].Contains(boneName))
                                        {
                                            node = root.LogicalSkins[0].GetJoint(rigs[slotParents[transform.BindName!]].IndexOf(boneName)).Joint.CreateNode(mc.Name);
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
                            nodes.Add(mc.Name!, node);

                            if (!GetFileFromResourcePath(mc.Mesh.DepotPath, out var meshFile))
                            {
                                continue;
                            }

                            MeshTools.AddMeshToModel(meshFile, root, root.LogicalSkins[0], node, true, mc.ChunkMask, materials);

                            foreach (var child in node.VisualChildren)
                            {
                                child.Name = mc.Name! + "_" + child.Name;
                            }
                        }
                    }

                    foreach (var component in unhandleChunks)
                    {
                        if (component is IRedMeshComponent mc)
                        {
                            NotResolvableException.ThrowIfNotResolvable(mc.Name);

                            if (!GetFileFromResourcePath(mc.Mesh.DepotPath, out var meshFile))
                            {
                                continue;
                            }

                            Node? node = null;

                            var transform = (entHardTransformBinding)mc.ParentTransform.GetValue();

                            NotResolvableException.ThrowIfNotResolvable(transform.BindName);

                            if (nodes.ContainsKey(transform.BindName!))
                            {
                                node = nodes[transform.BindName!].CreateNode(mc.Name);
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
                            nodes.Add(mc.Name!, node);

                            MeshTools.AddMeshToModel(meshFile, root, root.LogicalSkins[0], node, true, mc.ChunkMask, materials);

                            foreach (var child in node.VisualChildren)
                            {
                                child.Name = mc.Name! + "_" + child.Name;
                            }
                        }
                    }

                    root.SaveGLB(outfile.FullName);
                    return true;
                }
            }
            return false;
        }

        public static System.Numerics.Vector3 ToVector3(WolvenKit.RED4.Types.Vector3 v) => new(v.X, v.Z, v.Y);

        public static System.Numerics.Quaternion ToQuaternion(WolvenKit.RED4.Types.Quaternion q) => new(q.I, q.K, -q.J, q.R);

        public static System.Numerics.Vector3 ToVector3(WolvenKit.RED4.Types.WorldPosition p) => new(p.X, p.Z, -p.Y);
    }
}
