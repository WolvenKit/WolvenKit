using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Materials;
using SharpGLTF.Scenes;
using SharpGLTF.Schema2;
using SharpGLTF.Validation;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;
using Vec2 = System.Numerics.Vector2;
using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;

namespace WolvenKit.Modkit.RED4.Tools
{
    public class MeshTools
    {
        private readonly Red4ParserService _red4ParserService;

        public MeshTools(Red4ParserService red4ParserService) => _red4ParserService = red4ParserService;

        public static bool ExportMesh(CR2WFile cr2w, FileInfo outfile, MeshExportArgs meshExportArgs, ValidationMode vMode = ValidationMode.TryFix)
        {
            var model = GetModel(cr2w, meshExportArgs.LodFilter, mergeMeshes: meshExportArgs.ExperimentalMergedExport, exportGarmentSupport: meshExportArgs.ExportGarmentSupport);

            if (model == null)
            {
                return false;
            }

            if (WolvenTesting.IsTesting)
            {
                model.WriteGLB(new WriteSettings(vMode));
                return true;
            }

            if (meshExportArgs.isGLBinary)
            {
                model.SaveGLB(outfile.FullName, new WriteSettings(vMode));
            }
            else
            {
                model.SaveGLTF(outfile.FullName, new WriteSettings(vMode));
            }

            return true;
        }

        public static ModelRoot? GetModel(CR2WFile cr2w, bool lodFilter = true, bool includeRig = true, ulong chunkMask = ulong.MaxValue, bool mergeMeshes = false, bool exportGarmentSupport = false)
        {
            if (cr2w.RootChunk is not CMesh { RenderResourceBlob.Chunk: rendRenderMeshBlob rendBlob } cMesh)
            {
                return null;
            }

            RawArmature? rig = null;

            if (includeRig)
            {
                rig = GetOrphanRig(cMesh);
            }

            using var ms = new MemoryStream(rendBlob.RenderBuffer.Buffer.GetBytes());

            var meshesInfo = GetMeshesinfo(rendBlob, cMesh);

            var expMeshes = ContainRawMesh(ms, meshesInfo, lodFilter, chunkMask, mergeMeshes);

            if (includeRig)
            {
                UpdateSkinningParamCloth(ref expMeshes, cr2w);
            }

            WriteGarmentParametersToMesh(ref expMeshes, cMesh, exportGarmentSupport);

            var model = RawMeshesToGLTF(expMeshes, rig, mergeMeshes);

            return model;
        }

        public static void AddMeshToModel(CR2WFile cr2w, ModelRoot model, Skin skin, IVisualNodeContainer node, bool lodFilter = true, ulong chunkMask = ulong.MaxValue, Dictionary<string, Material>? materials = null)
        {
            if (cr2w.RootChunk is not CMesh { RenderResourceBlob.Chunk: rendRenderMeshBlob rendBlob } cMesh)
            {
                return;
            }

            using var ms = new MemoryStream(rendBlob.RenderBuffer.Buffer.GetBytes());

            var meshesInfo = GetMeshesinfo(rendBlob, cMesh);

            var expMeshes = ContainRawMesh(ms, meshesInfo, lodFilter, chunkMask);

            //if (skin != null)
            //{
            //    UpdateSkinningParamCloth(ref expMeshes, cr2w);
            //}


            if (expMeshes.Count > 0)
            {
                foreach (var mesh in expMeshes)
                {
                    ArgumentNullException.ThrowIfNull(mesh.materialNames, nameof(mesh.materialNames));

                    foreach (var material in mesh.materialNames)
                    {
                        if (materials is not null && !materials.ContainsKey(material))
                        {
                            materials[material] = model.CreateMaterial(material);
                            materials[material].WithPBRMetallicRoughness();
                            materials[material].DoubleSided = true;
                        }
                    }
                }
                //var rig = GetOrphanRig(rendblob, cr2w);
                //Skin skin2 = null;
                //if (rig != null)
                //{
                //    skin2 = model.CreateSkin();
                //    skin2.BindJoints(RIG.ExportNodes(ref model, rig).Values.ToArray());
                //}
                AddSubMeshesToModel(expMeshes, skin, ref model, node, materials);
            }
        }

        public bool ExportMeshWithoutRig(Stream meshStream, FileInfo outfile, bool lodFilter = true, bool isGLBinary = true, ValidationMode vMode = ValidationMode.TryFix)
        {
            var cr2w = _red4ParserService.ReadRed4File(meshStream);
            return cr2w != null && ExportMeshWithoutRig(cr2w, outfile, lodFilter, isGLBinary, vMode);
        }

        public static bool ExportMeshWithoutRig(CR2WFile cr2w, FileInfo outfile, bool lodFilter = true, bool isGLBinary = true, ValidationMode vMode = ValidationMode.TryFix)
        {
            var model = GetModel(cr2w, lodFilter, false);

            if (model == null)
            {
                return false;
            }

            if (WolvenTesting.IsTesting)
            {
                model.WriteGLB(new WriteSettings(vMode));
                return true;
            }
            if (isGLBinary)
            {
                model.SaveGLB(outfile.FullName, new WriteSettings(vMode));
            }
            else
            {
                model.SaveGLTF(outfile.FullName, new WriteSettings(vMode));
            }

            return true;
        }

        public bool ExportMultiMeshWithoutRig(List<Stream> meshStreamS, FileInfo outfile, bool lodFilter = true, bool isGLBinary = true, ValidationMode vMode = ValidationMode.TryFix)
        {
            var expMeshes = new List<RawMeshContainer>();

            foreach (var meshStream in meshStreamS)
            {
                var cr2w = _red4ParserService.ReadRed4File(meshStream);

                if (cr2w is not { RootChunk: CMesh { RenderResourceBlob.Chunk: rendRenderMeshBlob rendBlob } cMesh })
                {
                    continue;
                }

                using var ms = new MemoryStream(rendBlob.RenderBuffer.Buffer.GetBytes());

                var meshesInfo = GetMeshesinfo(rendBlob, cMesh);

                var meshes = ContainRawMesh(ms, meshesInfo, lodFilter);

                WriteGarmentParametersToMesh(ref meshes, cMesh);

                expMeshes.AddRange(meshes);

                meshStream.Dispose();
                meshStream.Close();
            }

            var model = RawMeshesToGLTF(expMeshes, null);

            if (WolvenTesting.IsTesting)
            {
                model.WriteGLB(new WriteSettings(vMode));
                return true;
            }

            if (isGLBinary)
            {
                model.SaveGLB(outfile.FullName, new WriteSettings(vMode));
            }
            else
            {
                model.SaveGLTF(outfile.FullName, new WriteSettings(vMode));
            }

            return true;
        }

        public static MeshesInfo GetMeshesinfo(rendRenderMeshBlob rendMeshBlob, CMesh? cMesh = null)
        {
            var meshesInfo = new MeshesInfo(rendMeshBlob.Header.RenderChunkInfos.Count);
            var redQuantScale = rendMeshBlob.Header.QuantizationScale;
            var redQuantTrans = rendMeshBlob.Header.QuantizationOffset;

            meshesInfo.quantScale = new Vec4(redQuantScale.X, redQuantScale.Y, redQuantScale.Z, redQuantScale.W);
            meshesInfo.quantTrans = new Vec4(redQuantTrans.X, redQuantTrans.Y, redQuantTrans.Z, redQuantTrans.W);

            meshesInfo.vertBufferSize = rendMeshBlob.Header.VertexBufferSize;
            meshesInfo.indexBufferOffset = rendMeshBlob.Header.IndexBufferOffset;
            meshesInfo.indexBufferSize = rendMeshBlob.Header.IndexBufferSize;

            for (var i = 0; i < meshesInfo.meshCount; i++)
            {
                var info = rendMeshBlob.Header.RenderChunkInfos[i];

                meshesInfo.vertCounts[i] = info.NumVertices;
                meshesInfo.indCounts[i] = info.NumIndices;
                meshesInfo.posnOffsets[i] = info.ChunkVertices.ByteOffsets[0];
                meshesInfo.unknownOffsets[i] = info.ChunkVertices.ByteOffsets[4];

                var cv = info.ChunkVertices;
                foreach (var element in cv.VertexLayout.Elements)
                {
                    if (element is null)
                    {
                        break;
                    }

                    if (element.Usage == GpuWrapApiVertexPackingePackingUsage.PS_Normal)
                    {
                        meshesInfo.normalOffsets[i] = cv.ByteOffsets[element.StreamIndex];
                    }
                    if (element.Usage == GpuWrapApiVertexPackingePackingUsage.PS_Tangent)
                    {
                        meshesInfo.tangentOffsets[i] = cv.ByteOffsets[element.StreamIndex];
                    }
                    if (element.Usage == GpuWrapApiVertexPackingePackingUsage.PS_Color)
                    {
                        meshesInfo.colorOffsets[i] = cv.ByteOffsets[element.StreamIndex];
                    }
                    if (element.Usage == GpuWrapApiVertexPackingePackingUsage.PS_TexCoord)
                    {
                        if (meshesInfo.tex0Offsets[i] == 0)
                        {
                            meshesInfo.tex0Offsets[i] = cv.ByteOffsets[element.StreamIndex];
                        }
                        else
                        {
                            meshesInfo.tex1Offsets[i] = cv.ByteOffsets[element.StreamIndex];
                        }
                    }
                }

                if (info.ChunkIndices.TeOffset == 0)
                {
                    meshesInfo.indicesOffsets[i] = rendMeshBlob.Header.IndexBufferOffset;
                }
                else
                {
                    meshesInfo.indicesOffsets[i] = rendMeshBlob.Header.IndexBufferOffset + info.ChunkIndices.TeOffset;
                }
                meshesInfo.vpStrides[i] = info.ChunkVertices.VertexLayout.SlotStrides[0];
                meshesInfo.LODLvl[i] = info.LodMask;
            }

            var count = 0;
            // getting number of weights for the meshes
            for (var i = 0; i < meshesInfo.meshCount; i++)
            {
                var info = rendMeshBlob.Header.RenderChunkInfos[i];

                count = info.ChunkVertices.VertexLayout.Elements.Count;
                uint counter = 0;
                for (var e = 0; e < count; e++)
                {
                    var element = info.ChunkVertices.VertexLayout.Elements[e];
                    if (element != null)
                    {
                        if (element.Usage == GpuWrapApiVertexPackingePackingUsage.PS_SkinIndices)
                        {
                            counter++;
                        }
                    }
                }
                meshesInfo.weightCounts[i] = counter * 4;
            }

            for (var i = 0; i < meshesInfo.meshCount; i++)
            {
                var info = rendMeshBlob.Header.RenderChunkInfos[i];

                meshesInfo.garmentSupportExists[i] = false;
                count = info.ChunkVertices.VertexLayout.Elements.Count;

                for (var e = 0; e < count; e++)
                {
                    var element = info.ChunkVertices.VertexLayout.Elements[e];

                    if (element != null)
                    {
                        if (element.Usage == GpuWrapApiVertexPackingePackingUsage.PS_ExtraData)
                        {
                            if (element.StreamIndex == 0)
                            {
                                meshesInfo.garmentSupportExists[i] = true;
                            }
                        }
                    }
                }

                if (cMesh != null)
                {
                    if (!cMesh.Parameters.Select(x => x.Chunk).OfType<meshMeshParamGarmentSupport>().Any())
                    {
                        meshesInfo.garmentSupportExists[i] = false;
                    }
                }
            }

            meshesInfo.appearances = new();

            if (cMesh != null)
            {
                for (var i = 0; i < cMesh.Appearances.Count; i++)
                {
                    var app = cMesh.Appearances[i].NotNull().Chunk.NotNull();

                    var materialNames = new string[app.ChunkMaterials.Count];
                    for (var e = 0; e < app.ChunkMaterials.Count; e++)
                    {
                        var m = app.ChunkMaterials[e].ToString();
                        ArgumentNullException.ThrowIfNull(m);
                        materialNames[e] = m;
                    }
                    meshesInfo.appearances.Add(app.Name + $"{i}", materialNames);
                }
            }

            return meshesInfo;
        }
        public static List<RawMeshContainer> ContainRawMesh(MemoryStream gfs, MeshesInfo info, bool lodFilter, ulong chunkMask = ulong.MaxValue, bool mergeMeshes = false, string meshname="")
        {
            ArgumentNullException.ThrowIfNull(info.appearances, nameof(info));


            var gbr = new BinaryReader(gfs);

            var expMeshes = new List<RawMeshContainer>();

            for (var index = 0; index < info.meshCount; index++)
            {
                if ((info.LODLvl[index] != 1 && lodFilter) || ((chunkMask & (1UL << index)) == 0))
                {
                    continue;
                }

                var meshContainer = new RawMeshContainer
                {
                    positions = new Vec3[info.vertCounts[index]],
                    lod = info.LODLvl[index]
                };

                // getting positions
                for (var i = 0; i < info.vertCounts[index]; i++)
                {
                    gfs.Position = info.posnOffsets[index] + (i * info.vpStrides[index]);

                    var x = (gbr.ReadInt16() / 32767f * info.quantScale.X) + info.quantTrans.X;
                    var y = (gbr.ReadInt16() / 32767f * info.quantScale.Y) + info.quantTrans.Y;
                    var z = (gbr.ReadInt16() / 32767f * info.quantScale.Z) + info.quantTrans.Z;

                    // Z up to Y up and LHCS to RHCS
                    meshContainer.positions[i] = new Vec3(x, z, -y);
                }

                // getting uvcoordinates0 from half floats
                meshContainer.texCoords0 = Array.Empty<Vec2>();
                if (info.tex0Offsets[index] != 0)
                {
                    meshContainer.texCoords0 = new Vec2[info.vertCounts[index]];
                    for (var i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.tex0Offsets[index] + (i * 4);
                        meshContainer.texCoords0[i] = new Vec2(Converters.hfconvert(gbr.ReadUInt16()), Converters.hfconvert(gbr.ReadUInt16()));
                    }
                }

                // getting float normals from 10bits
                meshContainer.normals = Array.Empty<Vec3>();
                if (info.normalOffsets[index] != 0)
                {
                    meshContainer.normals = new Vec3[info.vertCounts[index]];

                    uint stride = 4;
                    if (info.tangentOffsets[index] != 0)
                    {
                        stride += 4;
                    }

                    for (var i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.normalOffsets[index] + (stride * i);
                        var read = gbr.ReadUInt32();
                        var vec = Converters.TenBitShifted(read);

                        // Z up to Y up and LHCS to RHCS
                        meshContainer.normals[i] = new Vec3(vec.X, vec.Z, -vec.Y);
                        meshContainer.normals[i] = Vec3.Normalize(meshContainer.normals[i]);
                    }
                }

                // getting float tangents from 10bits
                meshContainer.tangents = Array.Empty<Vec4>();
                if (info.tangentOffsets[index] != 0)
                {
                    meshContainer.tangents = new Vec4[info.vertCounts[index]];

                    uint stride = 4;
                    uint off = 0;
                    if (info.normalOffsets[index] != 0)
                    {
                        off = 4;
                        stride += 4;
                    }
                    for (var i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.tangentOffsets[index] + (stride * i) + off;
                        var read = gbr.ReadUInt32();
                        var vec0 = Converters.TenBitShifted(read);

                        // Z up to Y up and LHCS to RHCS
                        var vec1 = Vec3.Normalize(new Vec3(vec0.X, vec0.Z, -vec0.Y));
                        meshContainer.tangents[i] = new Vec4(vec1.X, vec1.Y, vec1.Z, 1f);
                    }
                }

                // getting uvcoordinates1 from half floats
                meshContainer.texCoords1 = Array.Empty<Vec2>();
                if (info.tex1Offsets[index] != 0)
                {
                    meshContainer.texCoords1 = new Vec2[info.vertCounts[index]];

                    uint stride = 4;
                    uint off = 0;
                    if (info.colorOffsets[index] != 0)
                    {
                        off = 4;
                        stride += 4;
                    }

                    for (var i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.tex1Offsets[index] + (i * stride) + off;

                        meshContainer.texCoords1[i] = new Vec2(Converters.hfconvert(gbr.ReadUInt16()), Converters.hfconvert(gbr.ReadUInt16()));
                    }
                }

                // getting colors from Byte
                meshContainer.colors0 = Array.Empty<Vec4>();
                if (info.colorOffsets[index] != 0)
                {
                    meshContainer.colors0 = new Vec4[info.vertCounts[index]];

                    uint stride = 4;
                    if (info.tex1Offsets[index] != 0)
                    {
                        stride += 4;
                    }

                    for (var i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.colorOffsets[index] + (i * stride);
                        meshContainer.colors0[i] = new Vec4(gbr.ReadByte() / 255f, gbr.ReadByte() / 255f, gbr.ReadByte() / 255f, gbr.ReadByte() / 255f);
                    }
                }

                // getting bone indices
                meshContainer.boneindices = new ushort[info.vertCounts[index], info.weightCounts[index]];
                for (var i = 0; i < info.vertCounts[index]; i++)
                {
                    gfs.Position = info.posnOffsets[index] + (i * info.vpStrides[index]) + 8;
                    for (var e = 0; e < info.weightCounts[index]; e++)
                    {
                        meshContainer.boneindices[i, e] = gbr.ReadByte();
                    }
                }

                // getting weights
                meshContainer.weightCount = info.weightCounts[index];
                meshContainer.weights = new float[info.vertCounts[index], info.weightCounts[index]];
                for (var i = 0; i < info.vertCounts[index]; i++)
                {
                    float sum = 0;
                    gfs.Position = info.posnOffsets[index] + (i * info.vpStrides[index]) + 8 + meshContainer.weightCount;
                    for (var e = 0; e < meshContainer.weightCount; e++)
                    {
                        meshContainer.weights[i, e] = gbr.ReadByte() / 255f;
                        sum += meshContainer.weights[i, e];
                    }
                    if (sum == 0 && meshContainer.weightCount > 0)
                    {
                        meshContainer.boneindices[i, 0] = 0;
                        meshContainer.weights[i, 0] = 1f;
                        sum = 1;
                    }
                    for (var e = 0; e < meshContainer.weightCount; e++)
                    {
                        meshContainer.weights[i, e] *= 1f / sum;
                    }
                }

                // getting garment morphs
                meshContainer.garmentMorph = Array.Empty<Vec3>();
                if (info.garmentSupportExists[index])
                {
                    meshContainer.garmentMorph = new Vec3[info.vertCounts[index]];
                    for (var i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.posnOffsets[index] + (i * info.vpStrides[index]) + 8 + (2 * meshContainer.weightCount);
                        var x = Converters.hfconvert(gbr.ReadUInt16());
                        var y = Converters.hfconvert(gbr.ReadUInt16());
                        var z = Converters.hfconvert(gbr.ReadUInt16());
                        meshContainer.garmentMorph[i] = new Vec3(x, z, -y);
                    }
                }

                // getting uint16 face indices
                meshContainer.indices = new uint[info.indCounts[index]];
                gfs.Position = info.indicesOffsets[index];
                for (var i = 0; i < info.indCounts[index]; i++)
                {
                    meshContainer.indices[i] = gbr.ReadUInt16();
                }

                if (meshname.Length>0)
                {
                    meshContainer.name = mergeMeshes ?
                                        info.appearances.Keys.FirstOrDefault("default") :
                                        Path.GetFileNameWithoutExtension(meshname)+"_submesh_" + Convert.ToString(index).PadLeft(2, '0') + "_LOD_" + info.LODLvl[index];

                }
                else
                {
                    meshContainer.name = mergeMeshes ?
                                        info.appearances.Keys.FirstOrDefault("default") :
                                        "submesh_" + Convert.ToString(index).PadLeft(2, '0') + "_LOD_" + info.LODLvl[index];
                }
                

                meshContainer.materialNames = new string[info.appearances.Count];

                
                var Mesh_apps = info.appearances.Keys.Select(key => Path.GetFileNameWithoutExtension(meshname)+'_' + key).ToList();

                var apps = info.appearances.Keys.ToList();

                for (var e = 0; e < apps.Count; e++)
                {
                    // Null-proof materials
                    var d = info.appearances[apps[e]];
                    info.appearances[Mesh_apps[e]] = InitializeDefaultMaterial(info.meshCount, d.NotNull());
                    meshContainer.materialNames[e] = d[index];
                }

                meshContainer.colors1 = Array.Empty<Vec4>();
                expMeshes.Add(meshContainer);
            }
            RemoveDoubleFaces(ref expMeshes);
            return expMeshes;
        }

        private static string[] InitializeDefaultMaterial(int numTotalSubMeshes, string[] meshAppearances)
        {
            var ret = meshAppearances.ToList();

            // make sure it has at least one item
            if (ret.Count == 0)
            {
                ret.Add("default");
            }

            // check if there's a sequence
            var startIndex = ret.IndexOf(ret[^1]) + 1;

            if (startIndex >= ret.Count)
            {
                startIndex = 0;
            }

            // append all missing appearance names
            for (var e = ret.Count; e < numTotalSubMeshes; e++)
            {
                // get next-item-in-sequence, which might just be the same item as before
                var lastUsedString = ret[startIndex++];
                ret.Add(lastUsedString);
            }

            return ret.ToArray();

        }

        public static void UpdateMeshJoints(ref List<RawMeshContainer> meshes, RawArmature? newRig, RawArmature? oldRig, string fileName = "")
        {
            // updating mesh bone indices
            if (newRig is { BoneCount: > 0 } && oldRig is { BoneCount: > 0 })
            {
                ArgumentNullException.ThrowIfNull(newRig.Names);
                ArgumentNullException.ThrowIfNull(oldRig.Names);

                foreach (var mesh in meshes)
                {
                    ArgumentNullException.ThrowIfNull(mesh.positions);
                    ArgumentNullException.ThrowIfNull(mesh.boneindices);

                    for (var e = 0; e < mesh.positions.Length; e++)
                    {
                        for (var eye = 0; eye < mesh.weightCount; eye++)
                        {

                            if (mesh.boneindices[e, eye] >= oldRig.BoneCount)// && meshes[i].weights[e, eye] == 0)
                            {
                                mesh.boneindices[e, eye] = 0;
                            }

                            var found = false;
                            for (ushort r = 0; r < newRig.BoneCount; r++)
                            {
                                if (newRig.Names[r] == oldRig.Names[mesh.boneindices[e, eye]])
                                {
                                    mesh.boneindices[e, eye] = r;
                                    found = true;
                                    break;
                                }
                            }
                            if (!found)
                            {
                                throw new Exception($"Bone: {oldRig.Names[mesh.boneindices[e, eye]]} not present in export Rig(s)/Import Mesh {(!fileName.Equals("") ? string.Format("({0})", fileName) : "")}");
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (var mesh in meshes)
                {
                    for (var e = 0; e < mesh.weightCount; e++)
                    {
                        mesh.weightCount = 0;
                    }
                }
            }
        }

        public static void AddSubMeshesToModel(List<RawMeshContainer> meshes, Skin? skin, ref ModelRoot model, IVisualNodeContainer parent, Dictionary<string, Material>? materials = null, bool mergeMeshes = false, bool withMaterials = false)
        {
            var mat = model.CreateMaterial("Default");
            mat.WithPBRMetallicRoughness().WithDefault();
            mat.DoubleSided = true;

            var ms = new MemoryStream();
            var bw = new BinaryWriter(ms);
            foreach (var mesh in meshes)
            {
                ArgumentNullException.ThrowIfNull(mesh.positions);
                ArgumentNullException.ThrowIfNull(mesh.normals);
                ArgumentNullException.ThrowIfNull(mesh.tangents);
                ArgumentNullException.ThrowIfNull(mesh.colors0);
                ArgumentNullException.ThrowIfNull(mesh.colors1);
                ArgumentNullException.ThrowIfNull(mesh.texCoords0);
                ArgumentNullException.ThrowIfNull(mesh.texCoords1);
                ArgumentNullException.ThrowIfNull(mesh.boneindices);
                ArgumentNullException.ThrowIfNull(mesh.weights);
                ArgumentNullException.ThrowIfNull(mesh.indices);
                ArgumentNullException.ThrowIfNull(mesh.garmentMorph);

                for (var i = 0; i < mesh.positions.Length; i++)
                {
                    bw.Write(mesh.positions[i].X);
                    bw.Write(mesh.positions[i].Y);
                    bw.Write(mesh.positions[i].Z);
                }
                for (var i = 0; i < mesh.normals.Length; i++)
                {
                    bw.Write(mesh.normals[i].X);
                    bw.Write(mesh.normals[i].Y);
                    bw.Write(mesh.normals[i].Z);
                }
                for (var i = 0; i < mesh.tangents.Length; i++)
                {
                    bw.Write(mesh.tangents[i].X);
                    bw.Write(mesh.tangents[i].Y);
                    bw.Write(mesh.tangents[i].Z);
                    bw.Write(mesh.tangents[i].W);
                }
                for (var i = 0; i < mesh.colors0.Length; i++)
                {
                    bw.Write(mesh.colors0[i].X);
                    bw.Write(mesh.colors0[i].Y);
                    bw.Write(mesh.colors0[i].Z);
                    bw.Write(mesh.colors0[i].W);
                }
                for (var i = 0; i < mesh.colors1.Length; i++)
                {
                    bw.Write(mesh.colors1[i].X);
                    bw.Write(mesh.colors1[i].Y);
                    bw.Write(mesh.colors1[i].Z);
                    bw.Write(mesh.colors1[i].W);
                }
                if (mesh.garmentSupportWeight != null)
                {
                    for (var i = 0; i < mesh.garmentSupportWeight.Length; i++)
                    {
                        bw.Write(mesh.garmentSupportWeight[i].X);
                        bw.Write(mesh.garmentSupportWeight[i].Y);
                        bw.Write(mesh.garmentSupportWeight[i].Z);
                        bw.Write(mesh.garmentSupportWeight[i].W);
                    }
                }
                if (mesh.garmentSupportCap != null)
                {
                    for (var i = 0; i < mesh.garmentSupportCap.Length; i++)
                    {
                        bw.Write(mesh.garmentSupportCap[i].X);
                        bw.Write(mesh.garmentSupportCap[i].Y);
                        bw.Write(mesh.garmentSupportCap[i].Z);
                        bw.Write(mesh.garmentSupportCap[i].W);
                    }
                }
                for (var i = 0; i < mesh.texCoords0.Length; i++)
                {
                    bw.Write(mesh.texCoords0[i].X);
                    bw.Write((mesh.texCoords0[i].Y * -1) + 1);
                }
                for (var i = 0; i < mesh.texCoords1.Length; i++)
                {
                    bw.Write(mesh.texCoords1[i].X);
                    bw.Write(mesh.texCoords1[i].Y);
                }

                if (mesh.weightCount > 0)
                {
                    //if (skin != null)
                    //{
                    for (var i = 0; i < mesh.positions.Length; i++)
                    {
                        bw.Write(mesh.boneindices[i, 0]);
                        bw.Write(mesh.boneindices[i, 1]);
                        bw.Write(mesh.boneindices[i, 2]);
                        bw.Write(mesh.boneindices[i, 3]);
                    }
                    for (var i = 0; i < mesh.positions.Length; i++)
                    {
                        bw.Write(mesh.weights[i, 0]);
                        bw.Write(mesh.weights[i, 1]);
                        bw.Write(mesh.weights[i, 2]);
                        bw.Write(mesh.weights[i, 3]);
                    }
                    if (mesh.weightCount > 4)
                    {
                        for (var i = 0; i < mesh.positions.Length; i++)
                        {
                            bw.Write(mesh.boneindices[i, 4]);
                            bw.Write(mesh.boneindices[i, 5]);
                            bw.Write(mesh.boneindices[i, 6]);
                            bw.Write(mesh.boneindices[i, 7]);
                        }
                        for (var i = 0; i < mesh.positions.Length; i++)
                        {
                            bw.Write(mesh.weights[i, 4]);
                            bw.Write(mesh.weights[i, 5]);
                            bw.Write(mesh.weights[i, 6]);
                            bw.Write(mesh.weights[i, 7]);
                        }
                    }
                    //}
                }
                for (var i = 0; i < mesh.indices.Length; i += 3)
                {
                    bw.Write(Convert.ToUInt16(mesh.indices[i + 1]));
                    bw.Write(Convert.ToUInt16(mesh.indices[i + 0]));
                    bw.Write(Convert.ToUInt16(mesh.indices[i + 2]));
                }
                if (mesh.garmentMorph.Length > 0)
                {
                    for (var i = 0; i < mesh.positions.Length; i++)
                    {
                        bw.Write(mesh.garmentMorph[i].X);
                        bw.Write(mesh.garmentMorph[i].Y);
                        bw.Write(mesh.garmentMorph[i].Z);
                    }
                }
            }
            var buffer = model.UseBuffer(ms.ToArray());
            var buffViewOffset = 0;

            var nodes = new Dictionary<uint, Node>();
            var meshCounter = 0;
            foreach (var mesh in meshes)
            {
                ArgumentNullException.ThrowIfNull(mesh.positions);
                ArgumentNullException.ThrowIfNull(mesh.normals);
                ArgumentNullException.ThrowIfNull(mesh.tangents);
                ArgumentNullException.ThrowIfNull(mesh.colors0);
                ArgumentNullException.ThrowIfNull(mesh.colors1);
                ArgumentNullException.ThrowIfNull(mesh.texCoords0);
                ArgumentNullException.ThrowIfNull(mesh.texCoords1);
                ArgumentNullException.ThrowIfNull(mesh.boneindices);
                ArgumentNullException.ThrowIfNull(mesh.weights);
                ArgumentNullException.ThrowIfNull(mesh.indices);
                ArgumentNullException.ThrowIfNull(mesh.garmentMorph);
                

                Mesh? mes;
                Node? node;
                if (mergeMeshes)
                {
                    if (!nodes.ContainsKey(mesh.lod))
                    {
                        nodes[mesh.lod] = parent.CreateNode();
                        nodes[mesh.lod].Mesh = model.CreateMesh($"{mesh.name}_LOD{mesh.lod}");
                    }
                    node = nodes[mesh.lod];
                    mes = nodes[mesh.lod].Mesh;
                }
                else
                {
                    var name = withMaterials ? $"{meshCounter}_{mesh.name}" : mesh.name;
                    node = parent.CreateNode(name);
                    mes = model.CreateMesh(name);
                }
                var prim = mes.CreatePrimitive();
                ArgumentNullException.ThrowIfNull(mesh.materialNames, nameof(mesh.materialNames));
                if (materials != null && materials.ContainsKey(mesh.materialNames[0]))
                {
                    prim.Material = materials[mesh.materialNames[0]];
                }
                else
                {
                    prim.Material = mat;
                }
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, buffViewOffset, mesh.positions.Length * 12);
                    acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("POSITION", acc);
                    buffViewOffset += mesh.positions.Length * 12;
                }
                if (mesh.normals.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, buffViewOffset, mesh.normals.Length * 12);
                    acc.SetData(buff, 0, mesh.normals.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("NORMAL", acc);
                    buffViewOffset += mesh.normals.Length * 12;
                }
                if (mesh.tangents.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, buffViewOffset, mesh.tangents.Length * 16);
                    acc.SetData(buff, 0, mesh.tangents.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("TANGENT", acc);
                    buffViewOffset += mesh.tangents.Length * 16;
                }
                if (mesh.colors0.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, buffViewOffset, mesh.colors0.Length * 16);
                    acc.SetData(buff, 0, mesh.colors0.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("COLOR_0", acc);
                    buffViewOffset += mesh.colors0.Length * 16;
                }
                if (mesh.colors1.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, buffViewOffset, mesh.colors1.Length * 16);
                    acc.SetData(buff, 0, mesh.colors1.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("COLOR_1", acc);
                    buffViewOffset += mesh.colors1.Length * 16;
                }

                if (mesh.garmentSupportWeight != null)
                {
                    if (mesh.garmentSupportWeight.Length > 0)
                    {
                        var acc = model.CreateAccessor();
                        var buff = model.UseBufferView(buffer, buffViewOffset, mesh.garmentSupportWeight.Length * 16);
                        acc.SetData(buff, 0, mesh.garmentSupportWeight.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                        prim.SetVertexAccessor("_GARMENTSUPPORTWEIGHT", acc);
                        buffViewOffset += mesh.garmentSupportWeight.Length * 16;
                    }
                }
                if (mesh.garmentSupportCap != null)
                {
                    if (mesh.garmentSupportCap.Length > 0)
                    {
                        var acc = model.CreateAccessor();
                        var buff = model.UseBufferView(buffer, buffViewOffset, mesh.garmentSupportCap.Length * 16);
                        acc.SetData(buff, 0, mesh.garmentSupportCap.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                        prim.SetVertexAccessor("_GARMENTSUPPORTCAP", acc);
                        buffViewOffset += mesh.garmentSupportCap.Length * 16;
                    }
                }

                if (mesh.texCoords0.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, buffViewOffset, mesh.texCoords0.Length * 8);
                    acc.SetData(buff, 0, mesh.texCoords0.Length, DimensionType.VEC2, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("TEXCOORD_0", acc);
                    buffViewOffset += mesh.texCoords0.Length * 8;
                }
                if (mesh.texCoords1.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, buffViewOffset, mesh.texCoords1.Length * 8);
                    acc.SetData(buff, 0, mesh.texCoords1.Length, DimensionType.VEC2, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("TEXCOORD_1", acc);
                    buffViewOffset += mesh.texCoords1.Length * 8;
                }
                if (mesh.weightCount > 0)
                {
                    //if (skin != null)
                    //{
                    {
                        var acc = model.CreateAccessor();
                        var buff = model.UseBufferView(buffer, buffViewOffset, mesh.positions.Length * 8);
                        acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC4, EncodingType.UNSIGNED_SHORT, false);
                        prim.SetVertexAccessor("JOINTS_0", acc);
                        buffViewOffset += mesh.positions.Length * 8;
                    }
                    {
                        var acc = model.CreateAccessor();
                        var buff = model.UseBufferView(buffer, buffViewOffset, mesh.positions.Length * 16);
                        acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                        prim.SetVertexAccessor("WEIGHTS_0", acc);
                        buffViewOffset += mesh.positions.Length * 16;
                    }
                    if (mesh.weightCount > 4)
                    {
                        {
                            var acc = model.CreateAccessor();
                            var buff = model.UseBufferView(buffer, buffViewOffset, mesh.positions.Length * 8);
                            acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC4, EncodingType.UNSIGNED_SHORT, false);
                            prim.SetVertexAccessor("JOINTS_1", acc);
                            buffViewOffset += mesh.positions.Length * 8;
                        }
                        {
                            var acc = model.CreateAccessor();
                            var buff = model.UseBufferView(buffer, buffViewOffset, mesh.positions.Length * 16);
                            acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                            prim.SetVertexAccessor("WEIGHTS_1", acc);
                            buffViewOffset += mesh.positions.Length * 16;
                        }
                    }
                    //}
                }
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, buffViewOffset, mesh.indices.Length * 2);
                    acc.SetData(buff, 0, mesh.indices.Length, DimensionType.SCALAR, EncodingType.UNSIGNED_SHORT, false);
                    prim.SetIndexAccessor(acc);
                    buffViewOffset += mesh.indices.Length * 2;
                }
                node.Mesh = mes;
                if (skin != null && mesh.weightCount > 0)
                {
                    node.Skin = skin;
                }

                if (mesh.garmentMorph.Length > 0)
                {
                    string[] arr = { "GarmentSupport" };
                    var obj = new { mesh.materialNames, targetNames = arr };
                    mes.Extras = SharpGLTF.IO.JsonContent.Serialize(obj);
                }
                else
                {
                    var obj = new { mesh.materialNames };
                    mes.Extras = SharpGLTF.IO.JsonContent.Serialize(obj);
                }
                if (mesh.garmentMorph.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, buffViewOffset, mesh.garmentMorph.Length * 12);
                    acc.SetData(buff, 0, mesh.garmentMorph.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                    var dict = new Dictionary<string, Accessor>
                    {
                        { "POSITION", acc }
                    };
                    prim.SetMorphTargetAccessors(0, dict);
                    buffViewOffset += mesh.garmentMorph.Length * 12;
                }
                meshCounter++;
            }
        }

        public static ModelRoot RawMeshesToGLTF(List<RawMeshContainer> meshes, RawArmature? rig, bool mergeMeshes = false, bool withMaterials = false)
        {
            var model = ModelRoot.CreateModel();
            model.Extras = SharpGLTF.IO.JsonContent.Serialize(new { ExperimentalMergedMeshes = mergeMeshes });

            Skin? skin = null;
            if (rig is { BoneCount: > 0 })
            {
                skin = model.CreateSkin();

                var actualJointNodesOnly = RIG.ExportNodes(ref model, rig).Values.ToArray();

                if (actualJointNodesOnly.Length == 1)
                {
                    var parentArmature = actualJointNodesOnly[0].VisualParent;
                    skin.BindJoints(parentArmature.WorldMatrix, actualJointNodesOnly);
                }
                else
                {
                    skin.BindJoints(actualJointNodesOnly);
                }
            }

            Dictionary<string, Material>? materials = null;

            if (mergeMeshes)
            {
                materials = new Dictionary<string, Material>();

                foreach (var mesh in meshes)
                {
                    ArgumentNullException.ThrowIfNull(mesh.materialNames, nameof(mesh.materialNames));

                    foreach (var material in mesh.materialNames)
                    {
                        if (!materials.ContainsKey(material))
                        {
                            materials[material] = model.CreateMaterial(material);
                            materials[material].WithPBRMetallicRoughness();
                            materials[material].DoubleSided = true;
                        }
                    }
                }
            }

            AddSubMeshesToModel(meshes, skin, ref model, model.UseScene(0), materials, mergeMeshes, withMaterials);

            model.UseScene(0).Name = "Scene";
            model.DefaultScene = model.UseScene(0);
            model.MergeBuffers();
            return model;
        }

        private static ModelRoot RawMeshesToMinimalGLTF(List<RawMeshContainer> meshes)
        {
            var scene = new SceneBuilder();

            foreach (var mesh in meshes)
            {
                ArgumentNullException.ThrowIfNull(mesh.positions);
                ArgumentNullException.ThrowIfNull(mesh.indices);

                long indCount = mesh.indices.Length;
                var expMesh = new MeshBuilder<VertexPosition, VertexEmpty, VertexEmpty>(mesh.name);

                var prim = expMesh.UsePrimitive(new MaterialBuilder("Default").WithDoubleSide(true));
                for (var i = 0; i < indCount; i += 3)
                {
                    var idx0 = mesh.indices[i + 1];
                    var idx1 = mesh.indices[i];
                    var idx2 = mesh.indices[i + 2];

                    // VPNT
                    var p0 = new Vec3(mesh.positions[idx0].X, mesh.positions[idx0].Y, mesh.positions[idx0].Z);
                    var p1 = new Vec3(mesh.positions[idx1].X, mesh.positions[idx1].Y, mesh.positions[idx1].Z);
                    var p2 = new Vec3(mesh.positions[idx2].X, mesh.positions[idx2].Y, mesh.positions[idx2].Z);

                    // vertex build
                    var v0 = new VertexBuilder<VertexPosition, VertexEmpty, VertexEmpty>(new VertexPosition(p0));
                    var v1 = new VertexBuilder<VertexPosition, VertexEmpty, VertexEmpty>(new VertexPosition(p1));
                    var v2 = new VertexBuilder<VertexPosition, VertexEmpty, VertexEmpty>(new VertexPosition(p2));
                    // triangle build
                    prim.AddTriangle(v0, v1, v2);
                }
                scene.AddRigidMesh(expMesh, System.Numerics.Matrix4x4.Identity);
            }
            var model = scene.ToGltf2();
            return model;
        }
        public static RawArmature? GetOrphanRig(CMesh meshBlob)
        {
            if (meshBlob.RenderResourceBlob.Chunk is rendRenderMeshBlob rendMeshBlob)
            {
                if (rendMeshBlob.Header.BonePositions.Count != 0)
                {
                    var boneCount = rendMeshBlob.Header.BonePositions.Count;
                    var rig = new RawArmature
                    {
                        BoneCount = boneCount,
                        LocalPosn = rendMeshBlob.Header.BonePositions.Select(p => new Vec3(p.X, p.Z, -p.Y)).ToArray(),
                        LocalRot = Enumerable.Repeat(System.Numerics.Quaternion.Identity, boneCount).ToArray(),
                        LocalScale = Enumerable.Repeat(Vec3.One, boneCount).ToArray(),
                        Parent = Enumerable.Repeat<short>(-1, boneCount).ToArray(),
                        Names = meshBlob.BoneNames.Select(x => x.GetResolvedText().NotNull()).ToArray()
                    };
                    return rig;
                }
            }

            return null;
        }

        public static RawArmature? GetOrphanRig(ModelRoot model)
        {
            if (model.LogicalSkins.Count > 0 && model.LogicalSkins[0].JointsCount > 0)
            {
                var boneCount = model.LogicalSkins[0].JointsCount;
                var rig = new RawArmature
                {
                    BoneCount = boneCount,
                    LocalPosn = Enumerable.Range(0, boneCount).Select(_ => model.LogicalSkins[0].GetJoint(_).Joint.LocalTransform.Translation).ToArray(),
                    LocalRot = Enumerable.Range(0, boneCount).Select(_ => model.LogicalSkins[0].GetJoint(_).Joint.LocalTransform.Rotation).ToArray(),
                    LocalScale = Enumerable.Range(0, boneCount).Select(_ => model.LogicalSkins[0].GetJoint(_).Joint.LocalTransform.Scale).ToArray(),
                    Parent = Enumerable.Repeat<short>(-1, boneCount).ToArray(),
                    //Parent       = Enumerable.Range(0, boneCount).Select(_ => (short)model.LogicalSkins[0].GetJoint(_).Joint.VisualParent.LogicalIndex).ToArray(),
                    Names = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_ => model.LogicalSkins[0].GetJoint(_).Joint.Name).ToArray()
                };
                return rig;
            }
            return null;
        }

        private static void RemoveDoubleFaces(ref List<RawMeshContainer> meshes)
        {
            foreach (var mesh in meshes)
            {
                ArgumentNullException.ThrowIfNull(mesh.indices, nameof(mesh));
                ArgumentNullException.ThrowIfNull(mesh.normals, nameof(mesh));
                ArgumentNullException.ThrowIfNull(mesh.positions, nameof(mesh));

                if (mesh.indices.Length > 0)
                {
                    var idx0 = mesh.indices[0];
                    var idx1 = mesh.indices[1];
                    var idx2 = mesh.indices[2];

                    var doubled = false;
                    for (var j = 3; j < mesh.indices.Length; j += 3)
                    {
                        var bool0 = idx0 == mesh.indices[j] || idx0 == mesh.indices[j + 1] || idx0 == mesh.indices[j + 2];
                        var bool1 = idx1 == mesh.indices[j] || idx1 == mesh.indices[j + 1] || idx1 == mesh.indices[j + 2];
                        var bool2 = idx2 == mesh.indices[j] || idx2 == mesh.indices[j + 1] || idx2 == mesh.indices[j + 2];

                        doubled = bool0 && bool1 && bool2;
                        if (doubled)
                        {
                            break;
                        }
                    }
                    if (doubled && mesh.normals.Length > 0)
                    {
                        var indices = new List<uint>();
                        for (var j = 0; j < mesh.indices.Length; j += 3)
                        {
                            var v0 = mesh.positions[mesh.indices[j]];
                            var v1 = mesh.positions[mesh.indices[j + 1]];
                            var v2 = mesh.positions[mesh.indices[j + 2]];
                            var cross = Vec3.Normalize(Vec3.Cross(new Vec3(v1.X - v0.X, v1.Y - v0.Y, v1.Z - v0.Z), new Vec3(v2.X - v1.X, v2.Y - v1.Y, v2.Z - v1.Z)));

                            var n0 = mesh.normals[mesh.indices[j]];
                            var n1 = mesh.normals[mesh.indices[j + 1]];
                            var n2 = mesh.normals[mesh.indices[j + 2]];
                            var avg = Vec3.Normalize(new Vec3((n0.X + n1.X + n2.X) / 3, (n0.Y + n1.Y + n2.Y) / 3, (n0.Z + n1.Z + n2.Z) / 3));

                            if (Vec3.Dot(cross, avg) <= 0)
                            {
                                indices.Add(mesh.indices[j]);
                                indices.Add(mesh.indices[j + 1]);
                                indices.Add(mesh.indices[j + 2]);
                            }
                        }
                        mesh.indices = indices.ToArray();
                        mesh.name += "_doubled";
                    }
                }
            }
        }

        public static void UpdateSkinningParamCloth(ref List<RawMeshContainer> meshes, Stream ms, CR2WFile cr2w) => UpdateSkinningParamCloth(ref meshes, cr2w);

        public static void UpdateSkinningParamCloth(ref List<RawMeshContainer> meshes, CR2WFile cr2w)
        {
            var clothBLob = ((CMesh)cr2w.RootChunk).Parameters.FirstOrDefault(x => x.Chunk is meshMeshParamCloth);
            if (clothBLob != null)
            {
                var blob = (meshMeshParamCloth)clothBLob.Chunk.NotNull();

                for (var i = 0; i < blob.Chunks.Count && i < meshes.Count; i++)
                {
                    var mesh = meshes[i];
                    var chunk = blob.Chunks[i];

                    ArgumentNullException.ThrowIfNull(mesh.indices, nameof(mesh));
                    ArgumentNullException.ThrowIfNull(mesh.normals, nameof(mesh));
                    ArgumentNullException.ThrowIfNull(mesh.positions, nameof(mesh));

                    if (chunk.SkinIndices is { Buffer.MemSize: > 0 } && chunk.SkinWeights is { Buffer.MemSize: > 0 })
                    {
                        mesh.weightCount = 4;
                    }
                    if (chunk.SkinIndicesExt is { Buffer.MemSize: > 0 } && chunk.SkinWeightsExt is { Buffer.MemSize: > 0 })
                    {
                        mesh.weightCount += 4;
                    }
                    mesh.boneindices = new ushort[mesh.positions.Length, mesh.weightCount];
                    mesh.weights = new float[mesh.positions.Length, mesh.weightCount];
                    if (chunk.SkinIndices is { Buffer.MemSize: > 0 })
                    {
                        var stream = new MemoryStream(chunk.SkinWeights.Buffer.GetBytes());

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            mesh.boneindices[e, 0] = br.ReadByte();
                            mesh.boneindices[e, 1] = br.ReadByte();
                            mesh.boneindices[e, 2] = br.ReadByte();
                            mesh.boneindices[e, 3] = br.ReadByte();
                        }
                    }
                    if (chunk.SkinWeights is { Buffer.MemSize: > 0 })
                    {
                        var stream = new MemoryStream(chunk.SkinWeights.Buffer.GetBytes());

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            mesh.weights[e, 0] = br.ReadSingle();
                            mesh.weights[e, 1] = br.ReadSingle();
                            mesh.weights[e, 2] = br.ReadSingle();
                            mesh.weights[e, 3] = br.ReadSingle();
                        }
                    }
                    if (chunk.SkinIndicesExt is { Buffer.MemSize: > 0 })
                    {
                        var stream = new MemoryStream(chunk.SkinIndicesExt.Buffer.GetBytes());

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            mesh.boneindices[e, 4] = br.ReadByte();
                            mesh.boneindices[e, 5] = br.ReadByte();
                            mesh.boneindices[e, 6] = br.ReadByte();
                            mesh.boneindices[e, 7] = br.ReadByte();
                        }
                    }
                    if (chunk.SkinWeightsExt is { Buffer.MemSize: > 0 })
                    {
                        var stream = new MemoryStream(chunk.SkinWeightsExt.Buffer.GetBytes());

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            mesh.weights[e, 4] = br.ReadSingle();
                            mesh.weights[e, 5] = br.ReadSingle();
                            mesh.weights[e, 6] = br.ReadSingle();
                            mesh.weights[e, 7] = br.ReadSingle();
                        }
                    }
                    for (var e = 0; e < mesh.positions.Length; e++)
                    {
                        float sum = 0;
                        for (var y = 0; y < mesh.weightCount; y++)
                        {
                            sum += mesh.weights[e, y];
                        }
                        if (sum == 0 && mesh.weightCount > 0)
                        {
                            mesh.boneindices[e, 0] = 0;
                            mesh.weights[e, 0] = 1f;
                            sum = 1;
                        }
                        for (var y = 0; y < mesh.weightCount; y++)
                        {
                            mesh.weights[e, y] *= 1f / sum;
                        }
                    }
                }
            }

            var clothGraphicalBLob = ((CMesh)cr2w.RootChunk).Parameters.FirstOrDefault(x =>
            {
                ArgumentNullException.ThrowIfNull(x);
                return x.Chunk is meshMeshParamCloth_Graphical;
            });
            if (clothGraphicalBLob != null)
            {
                var blob = (meshMeshParamCloth_Graphical)clothGraphicalBLob.Chunk.NotNull();

                for (var i = 0; i < blob.Chunks.Count && i < meshes.Count; i++)
                {
                    var mesh = meshes[i];
                    var chunk = blob.Chunks[i];

                    ArgumentNullException.ThrowIfNull(mesh.colors1, nameof(mesh));
                    ArgumentNullException.ThrowIfNull(mesh.positions, nameof(mesh));
                    ArgumentNullException.ThrowIfNull(mesh.boneindices, nameof(mesh));

                    if (chunk.Simulation.Count > 0 && mesh.colors1.Length != mesh.positions.Length)
                    {
                        mesh.colors1 = new Vec4[mesh.positions.Length];
                    }

                    for (var e = 0; e < mesh.colors1.Length; e++)
                    {
                        mesh.colors1[e] = Vec4.Zero;
                    }
                    foreach (var e in chunk.Simulation)
                    {
                        mesh.colors1[e].X = 1f;
                    }
                    if (chunk is { SkinIndices.Buffer.MemSize: > 0, SkinWeights.Buffer.MemSize: > 0 })
                    {
                        mesh.weightCount = 4;
                    }
                    if (chunk is { SkinIndicesExt: { Buffer.MemSize: > 0 }, SkinWeightsExt.Buffer.MemSize: > 0 })
                    {
                        mesh.weightCount += 4;
                    }
                    mesh.boneindices = new ushort[mesh.positions.Length, mesh.weightCount];
                    mesh.weights = new float[mesh.positions.Length, mesh.weightCount];
                    if (chunk.SkinIndices is { Buffer.MemSize: > 0 })
                    {
                        var stream = new MemoryStream(chunk.SkinIndices.Buffer.GetBytes());

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            mesh.boneindices[e, 0] = br.ReadByte();
                            mesh.boneindices[e, 1] = br.ReadByte();
                            mesh.boneindices[e, 2] = br.ReadByte();
                            mesh.boneindices[e, 3] = br.ReadByte();
                        }
                    }
                    if (chunk.SkinWeights is { Buffer.MemSize: > 0 })
                    {
                        var stream = new MemoryStream(chunk.SkinWeights.Buffer.GetBytes());

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            mesh.weights[e, 0] = br.ReadSingle();
                            mesh.weights[e, 1] = br.ReadSingle();
                            mesh.weights[e, 2] = br.ReadSingle();
                            mesh.weights[e, 3] = br.ReadSingle();
                        }
                    }
                    if (chunk.SkinIndicesExt is { Buffer.MemSize: > 0 })
                    {
                        var stream = new MemoryStream(chunk.SkinIndicesExt.Buffer.GetBytes());

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            mesh.boneindices[e, 4] = br.ReadByte();
                            mesh.boneindices[e, 5] = br.ReadByte();
                            mesh.boneindices[e, 6] = br.ReadByte();
                            mesh.boneindices[e, 7] = br.ReadByte();
                        }
                    }
                    if (chunk.SkinWeightsExt is { Buffer.MemSize: > 0 })
                    {
                        var stream = new MemoryStream(chunk.SkinWeightsExt.Buffer.GetBytes());

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            mesh.weights[e, 4] = br.ReadSingle();
                            mesh.weights[e, 5] = br.ReadSingle();
                            mesh.weights[e, 6] = br.ReadSingle();
                            mesh.weights[e, 7] = br.ReadSingle();
                        }
                    }
                    for (var e = 0; e < mesh.positions.Length; e++)
                    {
                        float sum = 0;
                        for (var y = 0; y < mesh.weightCount; y++)
                        {
                            sum += mesh.weights[e, y];
                        }
                        if (sum == 0 && mesh.weightCount > 0)
                        {
                            mesh.boneindices[e, 0] = 0;
                            mesh.weights[e, 0] = 1f;
                            sum = 1;
                        }
                        for (var y = 0; y < mesh.weightCount; y++)
                        {
                            mesh.weights[e, y] *= 1f / sum;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Check if cMesh has a garmentMeshParamGarment parameter; if it does then for each submesh in the mesh with a garmentFlags buffer of size greater than 0, then write to the GarmentSupport attributes.
        /// These attributes will be imported into Blender as color attributes, with the values stored in the red channel.
        /// </summary>
        /// <param name="meshes"></param>
        /// <param name="cMesh"></param>
        /// <param name="exportGarmentSupport"></param>
        public static void WriteGarmentParametersToMesh(ref List<RawMeshContainer> meshes, CMesh cMesh, bool exportGarmentSupport = false)
        {
            var garmentBlob = cMesh.Parameters.FirstOrDefault(x => x.Chunk is garmentMeshParamGarment);
            if (garmentBlob != null && exportGarmentSupport)
            {
                var garmentBlobChunk = (garmentMeshParamGarment)garmentBlob.Chunk.NotNull();

                for (var i = 0; i < garmentBlobChunk.Chunks.Count && i < meshes.Count; i++)
                {
                    var mesh = meshes[i];
                    var chunk = garmentBlobChunk.Chunks[i];

                    ArgumentNullException.ThrowIfNull(mesh.positions, nameof(mesh));

                    if (chunk.GarmentFlags is { Buffer.MemSize: > 0 })
                    {
                        meshes[i].garmentSupportWeight = new Vec4[mesh.positions.Length];
                        meshes[i].garmentSupportCap = new Vec4[mesh.positions.Length];

                        var stream = new MemoryStream(chunk.GarmentFlags.Buffer.GetBytes());
                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);

                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            if (mesh.garmentSupportWeight != null)
                            {
                                mesh.garmentSupportWeight[e] = PrepareGarmentVertexWeight(br.ReadByte());
                            }

                            if (mesh.garmentSupportCap != null)
                            {
                                mesh.garmentSupportCap[e] = PrepareGarmentVertexCap(br.ReadByte());
                            }

                            br.ReadByte();
                            br.ReadByte();
                        }
                    }
                }
            }
        }

        private static Vec4 PrepareGarmentVertexWeight(byte vertexWeightData) => new() { X = vertexWeightData / 255f, Y = 0f, Z = 0f, W = 1f };
        private static Vec4 PrepareGarmentVertexCap(byte vertexCapData) => new() { X = vertexCapData * 1f, Y = 0f, Z = 0f, W = 1f };
    }
}
