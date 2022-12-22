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

        public MeshTools(Red4ParserService red4ParserService)
        {
            _red4ParserService = red4ParserService;
        }

        public bool ExportMesh(Stream meshStream, FileInfo outfile, MeshExportArgs meshExportArgs, ValidationMode vmode = ValidationMode.TryFix)
        {
            var cr2w = _red4ParserService.ReadRed4File(meshStream);
            return ExportMesh(cr2w, outfile, meshExportArgs, vmode);
        }

        public static bool ExportMesh(CR2WFile cr2w, FileInfo outfile, MeshExportArgs meshExportArgs, ValidationMode vmode = ValidationMode.TryFix)
        {
            var model = GetModel(cr2w, meshExportArgs.LodFilter, mergeMeshes: meshExportArgs.ExperimentalMergedExport);

            if (model == null)
            {
                return false;
            }

            if (WolvenTesting.IsTesting)
            {
                model.WriteGLB(new WriteSettings(vmode));
                return true;
            }

            if (meshExportArgs.isGLBinary)
            {
                model.SaveGLB(outfile.FullName, new WriteSettings(vmode));
            }
            else
            {
                model.SaveGLTF(outfile.FullName, new WriteSettings(vmode));
            }

            return true;
        }

        public static ModelRoot GetModel(CR2WFile cr2w, bool lodFilter = true, bool includeRig = true, ulong chunkMask = ulong.MaxValue, bool mergeMeshes = false)
        {
            if (cr2w == null || cr2w.RootChunk is not CMesh cMesh || cMesh.RenderResourceBlob == null || cMesh.RenderResourceBlob.Chunk is not rendRenderMeshBlob rendblob)
            {
                return null;
            }

            RawArmature rig = null;

            if (includeRig)
            {
                rig = GetOrphanRig(cMesh);
            }

            using var ms = new MemoryStream(rendblob.RenderBuffer.Buffer.GetBytes());

            var meshesinfo = GetMeshesinfo(rendblob, cr2w.RootChunk as CMesh);

            var expMeshes = ContainRawMesh(ms, meshesinfo, lodFilter, chunkMask, mergeMeshes);

            if (includeRig)
            {
                UpdateSkinningParamCloth(ref expMeshes, cr2w);
            }

            var model = RawMeshesToGLTF(expMeshes, rig, mergeMeshes);

            return model;
        }

        public static void AddMeshToModel(CR2WFile cr2w, ModelRoot model, Skin skin, IVisualNodeContainer node, bool lodFilter = true, ulong chunkMask = ulong.MaxValue, Dictionary<string, Material> materials = null)
        {
            if (cr2w == null || cr2w.RootChunk is not CMesh cMesh || cMesh.RenderResourceBlob == null || cMesh.RenderResourceBlob.Chunk is not rendRenderMeshBlob rendblob)
            {
                return;
            }

            using var ms = new MemoryStream(rendblob.RenderBuffer.Buffer.GetBytes());

            var meshesinfo = GetMeshesinfo(rendblob, cr2w.RootChunk as CMesh);

            var expMeshes = ContainRawMesh(ms, meshesinfo, lodFilter, chunkMask);

            //if (skin != null)
            //{
            //    UpdateSkinningParamCloth(ref expMeshes, cr2w);
            //}


            if (expMeshes.Count > 0)
            {
                foreach (var mesh in expMeshes)
                {
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
                //var rig = GetOrphanRig(rendblob, cr2w);
                //Skin skin2 = null;
                //if (rig != null)
                //{
                //    skin2 = model.CreateSkin();
                //    skin2.BindJoints(RIG.ExportNodes(ref model, rig).Values.ToArray());
                //}
                AddSubmeshesToModel(expMeshes, skin, ref model, node, materials);
            }
        }

        public bool ExportMeshWithoutRig(Stream meshStream, FileInfo outfile, bool lodFilter = true, bool isGLBinary = true, ValidationMode vmode = ValidationMode.TryFix)
        {
            var cr2w = _red4ParserService.ReadRed4File(meshStream);
            return ExportMeshWithoutRig(cr2w, outfile, lodFilter, isGLBinary, vmode);
        }

        public static bool ExportMeshWithoutRig(CR2WFile cr2w, FileInfo outfile, bool lodFilter = true, bool isGLBinary = true, ValidationMode vmode = ValidationMode.TryFix)
        {
            var model = GetModel(cr2w, lodFilter, false);

            if (model == null)
            {
                return false;
            }

            if (WolvenTesting.IsTesting)
            {
                model.WriteGLB(new WriteSettings(vmode));
                return true;
            }
            if (isGLBinary)
            {
                model.SaveGLB(outfile.FullName, new WriteSettings(vmode));
            }
            else
            {
                model.SaveGLTF(outfile.FullName, new WriteSettings(vmode));
            }

            return true;
        }

        public bool ExportMultiMeshWithoutRig(List<Stream> meshStreamS, FileInfo outfile, bool lodFilter = true, bool isGLBinary = true, ValidationMode vmode = ValidationMode.TryFix)
        {
            var expMeshes = new List<RawMeshContainer>();

            foreach (var meshStream in meshStreamS)
            {
                var cr2w = _red4ParserService.ReadRed4File(meshStream);

                if (cr2w == null || cr2w.RootChunk is not CMesh cMesh || cMesh.RenderResourceBlob == null || cMesh.RenderResourceBlob.Chunk is not rendRenderMeshBlob rendblob)
                {
                    continue;
                }

                using var ms = new MemoryStream(rendblob.RenderBuffer.Buffer.GetBytes());

                var meshesinfo = GetMeshesinfo(rendblob, cr2w.RootChunk as CMesh);

                var Meshes = ContainRawMesh(ms, meshesinfo, lodFilter);

                expMeshes.AddRange(Meshes);

                meshStream.Dispose();
                meshStream.Close();
            }

            var model = RawMeshesToGLTF(expMeshes, null);

            if (WolvenTesting.IsTesting)
            {
                model.WriteGLB(new WriteSettings(vmode));
                return true;
            }

            if (isGLBinary)
            {
                model.SaveGLB(outfile.FullName, new WriteSettings(vmode));
            }
            else
            {
                model.SaveGLTF(outfile.FullName, new WriteSettings(vmode));
            }

            return true;
        }
        public bool ExportMeshWithRig(Stream meshStream, Stream rigStream, FileInfo outfile, bool lodFilter = true, bool isGLBinary = true, ValidationMode vmode = ValidationMode.TryFix)
        {
            var cr2w = _red4ParserService.ReadRed4File(meshStream);

            if (cr2w == null || cr2w.RootChunk is not CMesh cMesh || cMesh.RenderResourceBlob == null || cMesh.RenderResourceBlob.Chunk is not rendRenderMeshBlob rendblob)
            {
                return false;
            }

            using var ms = new MemoryStream(rendblob.RenderBuffer.Buffer.GetBytes());

            var meshesinfo = GetMeshesinfo(rendblob, cr2w.RootChunk as CMesh);

            var expMeshes = ContainRawMesh(ms, meshesinfo, lodFilter);
            UpdateSkinningParamCloth(ref expMeshes, meshStream, cr2w);

            var meshRig = GetOrphanRig(cMesh);

            var Rig = RIG.ProcessRig(_red4ParserService.ReadRed4File(rigStream));

            UpdateMeshJoints(ref expMeshes, Rig, meshRig);

            var model = RawMeshesToGLTF(expMeshes, Rig);


            if (WolvenTesting.IsTesting)
            {
                model.WriteGLB(new WriteSettings(vmode));
                return true;
            }

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
            rigStream.Dispose();
            rigStream.Close();

            return true;
        }
        public bool ExportMultiMeshWithRig(List<Stream> meshStreamS, List<Stream> rigStreamS, FileInfo outfile, bool lodFilter = true, bool isGLBinary = true, ValidationMode vmode = ValidationMode.TryFix)
        {
            var Rigs = new List<RawArmature>();
            foreach (var rigStream in rigStreamS)
            {
                var Rig = RIG.ProcessRig(_red4ParserService.ReadRed4File(rigStream));
                Rigs.Add(Rig);

                rigStream.Dispose();
                rigStream.Close();
            }
            var expRig = RIG.CombineRigs(Rigs);

            var expMeshes = new List<RawMeshContainer>();

            foreach (var meshStream in meshStreamS)
            {
                var cr2w = _red4ParserService.ReadRed4File(meshStream);
                if (cr2w == null || cr2w.RootChunk is not CMesh cMesh || cMesh.RenderResourceBlob == null || cMesh.RenderResourceBlob.Chunk is not rendRenderMeshBlob rendblob)
                {
                    continue;
                }

                using var ms = new MemoryStream(rendblob.RenderBuffer.Buffer.GetBytes());

                var meshesinfo = GetMeshesinfo(rendblob, cr2w.RootChunk as CMesh);

                var Meshes = ContainRawMesh(ms, meshesinfo, lodFilter);
                UpdateSkinningParamCloth(ref Meshes, meshStream, cr2w);

                var meshRig = GetOrphanRig(cMesh);

                UpdateMeshJoints(ref Meshes, expRig, meshRig);

                expMeshes.AddRange(Meshes);

                meshStream.Dispose();
                meshStream.Close();
            }
            var model = RawMeshesToGLTF(expMeshes, expRig);

            if (WolvenTesting.IsTesting)
            {
                model.WriteGLB(new WriteSettings(vmode));
                return true;
            }

            if (isGLBinary)
            {
                model.SaveGLB(outfile.FullName, new WriteSettings(vmode));
            }
            else
            {
                model.SaveGLTF(outfile.FullName, new WriteSettings(vmode));
            }

            return true;
        }
        public static MeshesInfo GetMeshesinfo(rendRenderMeshBlob rendmeshblob, CMesh cMesh = null)
        {
            var meshesInfo = new MeshesInfo(rendmeshblob.Header.RenderChunkInfos.Count);
            var redquantScale = rendmeshblob.Header.QuantizationScale;
            var redquantTrans = rendmeshblob.Header.QuantizationOffset;

            meshesInfo.quantScale = new Vec4(redquantScale.X, redquantScale.Y, redquantScale.Z, redquantScale.W);
            meshesInfo.quantTrans = new Vec4(redquantTrans.X, redquantTrans.Y, redquantTrans.Z, redquantTrans.W);

            meshesInfo.vertBufferSize = rendmeshblob.Header.VertexBufferSize;
            meshesInfo.indexBufferOffset = rendmeshblob.Header.IndexBufferOffset;
            meshesInfo.indexBufferSize = rendmeshblob.Header.IndexBufferSize;

            for (var i = 0; i < meshesInfo.meshCount; i++)
            {
                meshesInfo.vertCounts[i] = rendmeshblob.Header.RenderChunkInfos[i].NumVertices;
                meshesInfo.indCounts[i] = rendmeshblob.Header.RenderChunkInfos[i].NumIndices;
                meshesInfo.posnOffsets[i] = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[0];
                meshesInfo.unknownOffsets[i] = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[4];

                var cv = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices;
                for (var e = 0; e < cv.VertexLayout.Elements.Count; e++)
                {
                    if (cv.VertexLayout.Elements[e] == null)
                    {
                        break;
                    }

                    if (cv.VertexLayout.Elements[e].Usage == GpuWrapApiVertexPackingePackingUsage.PS_Normal)
                    {
                        meshesInfo.normalOffsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex];
                    }
                    if (cv.VertexLayout.Elements[e].Usage == GpuWrapApiVertexPackingePackingUsage.PS_Tangent)
                    {
                        meshesInfo.tangentOffsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex];
                    }
                    if (cv.VertexLayout.Elements[e].Usage == GpuWrapApiVertexPackingePackingUsage.PS_Color)
                    {
                        meshesInfo.colorOffsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex];
                    }
                    if (cv.VertexLayout.Elements[e].Usage == GpuWrapApiVertexPackingePackingUsage.PS_TexCoord)
                    {
                        if (meshesInfo.tex0Offsets[i] == 0)
                        {
                            meshesInfo.tex0Offsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex];
                        }
                        else
                        {
                            meshesInfo.tex1Offsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex];
                        }
                    }
                }

                if (rendmeshblob.Header.RenderChunkInfos[i].ChunkIndices.TeOffset == 0)
                {
                    meshesInfo.indicesOffsets[i] = rendmeshblob.Header.IndexBufferOffset;
                }
                else
                {
                    meshesInfo.indicesOffsets[i] = rendmeshblob.Header.IndexBufferOffset + rendmeshblob.Header.RenderChunkInfos[i].ChunkIndices.TeOffset;
                }
                meshesInfo.vpStrides[i] = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.SlotStrides[0];
                meshesInfo.LODLvl[i] = rendmeshblob.Header.RenderChunkInfos[i].LodMask;
            }

            var count = 0;
            uint counter = 0;
            // getting number of weights for the meshes
            for (var i = 0; i < meshesInfo.meshCount; i++)
            {
                count = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements.Count;
                counter = 0;
                for (var e = 0; e < count; e++)
                {
                    if (rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements[e] != null)
                    {
                        if (rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements[e].Usage == GpuWrapApiVertexPackingePackingUsage.PS_SkinIndices)
                        {
                            counter++;
                        }
                    }
                }
                meshesInfo.weightCounts[i] = counter * 4;
            }

            for (var i = 0; i < meshesInfo.meshCount; i++)
            {
                meshesInfo.garmentSupportExists[i] = false;
                count = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements.Count;

                for (var e = 0; e < count; e++)
                {
                    if (rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements[e] != null)
                    {
                        if (rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements[e].Usage == GpuWrapApiVertexPackingePackingUsage.PS_ExtraData)
                        {
                            if (rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements[e].StreamIndex == 0)
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

            meshesInfo.appearances = new Dictionary<string, string[]>();

            if (cMesh != null)
            {
                for (var i = 0; i < cMesh.Appearances.Count; i++)
                {
                    var app = cMesh.Appearances[i].Chunk;

                    var materialNames = new string[app.ChunkMaterials.Count];
                    for (var e = 0; e < app.ChunkMaterials.Count; e++)
                    {
                        materialNames[e] = app.ChunkMaterials[e];
                    }
                    meshesInfo.appearances.Add(app.Name + $"{i}", materialNames);
                }
            }

            return meshesInfo;
        }
        public static List<RawMeshContainer> ContainRawMesh(MemoryStream gfs, MeshesInfo info, bool lodFilter, ulong chunkMask = ulong.MaxValue, bool mergeMeshes = false)
        {
            var gbr = new BinaryReader(gfs);

            var expMeshes = new List<RawMeshContainer>();

            for (var index = 0; index < info.meshCount; index++)
            {
                if (info.LODLvl[index] != 1 && lodFilter || ((chunkMask & 1UL << index) == 0))
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
                    gfs.Position = info.posnOffsets[index] + i * info.vpStrides[index];

                    var x = gbr.ReadInt16() / 32767f * info.quantScale.X + info.quantTrans.X;
                    var y = gbr.ReadInt16() / 32767f * info.quantScale.Y + info.quantTrans.Y;
                    var z = gbr.ReadInt16() / 32767f * info.quantScale.Z + info.quantTrans.Z;

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
                        gfs.Position = info.tex0Offsets[index] + i * 4;
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
                        gfs.Position = info.normalOffsets[index] + stride * i;
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
                        gfs.Position = info.tangentOffsets[index] + stride * i + off;
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
                        gfs.Position = info.tex1Offsets[index] + i * stride + off;

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
                        gfs.Position = info.colorOffsets[index] + i * stride;
                        meshContainer.colors0[i] = new Vec4(gbr.ReadByte() / 255f, gbr.ReadByte() / 255f, gbr.ReadByte() / 255f, gbr.ReadByte() / 255f);
                    }
                }

                // getting bone indices
                meshContainer.boneindices = new ushort[info.vertCounts[index], info.weightCounts[index]];
                for (var i = 0; i < info.vertCounts[index]; i++)
                {
                    gfs.Position = info.posnOffsets[index] + i * info.vpStrides[index] + 8;
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
                    gfs.Position = info.posnOffsets[index] + i * info.vpStrides[index] + 8 + meshContainer.weightCount;
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
                        gfs.Position = info.posnOffsets[index] + i * info.vpStrides[index] + 8 + 2 * meshContainer.weightCount;
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


                meshContainer.name = mergeMeshes ?
                    info.appearances.Keys.FirstOrDefault("default") :
                    "submesh_" + Convert.ToString(index).PadLeft(2, '0') + "_LOD_" + info.LODLvl[index];

                meshContainer.materialNames = new string[info.appearances.Count];
                var apps = info.appearances.Keys.ToList();
                for (var e = 0; e < apps.Count; e++)
                {
                    // Null-proof materials
                    info.appearances[apps[e]] = InitializeDefaultMaterial(info.meshCount, info.appearances[apps[e]]);
                    meshContainer.materialNames[e] = info.appearances[apps[e]][index];
                }

                meshContainer.colors1 = Array.Empty<Vec4>();
                expMeshes.Add(meshContainer);
            }
            RemoveDoubleFaces(ref expMeshes);
            return expMeshes;
        }

        private static string FindNextInSequence(IReadOnlyList<string> sequence, string current)
        {
            for (var i = 0; i < sequence.Count - 1; i++)
            {
                if (sequence[i] != current || sequence[i + 1] == current)
                {
                    continue;
                }
                return sequence[i + 1];
            }
            return null;
        }

        private static string[] InitializeDefaultMaterial(int numTotalSubmeshes, string[] meshAppearances)
        {
            List<string> ret = meshAppearances.ToList();;
            // If the array is empty: initialize it with "default" material
            if (ret.Count == 0)
            {
                ret.Add("default");
            }

            // append all missing appearance names
            for (var e = ret.Count; e < numTotalSubmeshes; e++)
            {
                // get last item from array, which is never falsy because of the above statement 
                var lastUsedString = ret[^1];

                var nextUsedString = FindNextInSequence(ret, lastUsedString) ?? lastUsedString;
                
                ret.Add(nextUsedString);
            }

            return ret.ToArray();

        }
        
        public static void UpdateMeshJoints(ref List<RawMeshContainer> meshes, RawArmature newRig, RawArmature oldRig)
        {
            // updating mesh bone indices
            if (newRig != null && newRig.BoneCount > 0 && oldRig != null && oldRig.BoneCount > 0)
            {
                for (var i = 0; i < meshes.Count; i++)
                {
                    for (var e = 0; e < meshes[i].positions.Length; e++)
                    {
                        for (var eye = 0; eye < meshes[i].weightCount; eye++)
                        {

                            if (meshes[i].boneindices[e, eye] >= oldRig.BoneCount)// && meshes[i].weights[e, eye] == 0)
                            {
                                meshes[i].boneindices[e, eye] = 0;
                            }

                            var found = false;
                            for (ushort r = 0; r < newRig.BoneCount; r++)
                            {
                                if (newRig.Names[r] == oldRig.Names[meshes[i].boneindices[e, eye]])
                                {
                                    meshes[i].boneindices[e, eye] = r;
                                    found = true;
                                    break;
                                }
                            }
                            if (!found)
                            {
                                throw new Exception($"Bone: {oldRig.Names[meshes[i].boneindices[e, eye]]} not present in export Rig(s)/Import Mesh");
                            }
                        }
                    }
                }
            }
            else
            {
                for (var i = 0; i < meshes.Count; i++)
                {
                    for (var e = 0; e < meshes[i].weightCount; e++)
                    {
                        meshes[i].weightCount = 0;
                    }
                }
            }
        }

        public static void AddSubmeshesToModel(List<RawMeshContainer> meshes, Skin skin, ref ModelRoot model, IVisualNodeContainer parent, Dictionary<string, Material> materials = null, bool mergeMeshes = false)
        {
            var mat = model.CreateMaterial("Default");
            mat.WithPBRMetallicRoughness().WithDefault();
            mat.DoubleSided = true;

            var ms = new MemoryStream();
            var bw = new BinaryWriter(ms);
            foreach (var mesh in meshes)
            {
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
                for (var i = 0; i < mesh.texCoords0.Length; i++)
                {
                    bw.Write(mesh.texCoords0[i].X);
                    bw.Write(mesh.texCoords0[i].Y * -1 + 1);
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
            var BuffViewoffset = 0;

            var nodes = new Dictionary<uint, Node>();
            foreach (var mesh in meshes)
            {
                Mesh mes = null;
                Node node = null;
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
                    node = parent.CreateNode(mesh.name);
                    mes = model.CreateMesh(mesh.name);
                }
                var prim = mes.CreatePrimitive();
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
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.positions.Length * 12);
                    acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("POSITION", acc);
                    BuffViewoffset += mesh.positions.Length * 12;
                }
                if (mesh.normals.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.normals.Length * 12);
                    acc.SetData(buff, 0, mesh.normals.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("NORMAL", acc);
                    BuffViewoffset += mesh.normals.Length * 12;
                }
                if (mesh.tangents.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.tangents.Length * 16);
                    acc.SetData(buff, 0, mesh.tangents.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("TANGENT", acc);
                    BuffViewoffset += mesh.tangents.Length * 16;
                }
                if (mesh.colors0.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.colors0.Length * 16);
                    acc.SetData(buff, 0, mesh.colors0.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("COLOR_0", acc);
                    BuffViewoffset += mesh.colors0.Length * 16;
                }
                if (mesh.colors1.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.colors1.Length * 16);
                    acc.SetData(buff, 0, mesh.colors1.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("COLOR_1", acc);
                    BuffViewoffset += mesh.colors1.Length * 16;
                }
                if (mesh.texCoords0.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.texCoords0.Length * 8);
                    acc.SetData(buff, 0, mesh.texCoords0.Length, DimensionType.VEC2, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("TEXCOORD_0", acc);
                    BuffViewoffset += mesh.texCoords0.Length * 8;
                }
                if (mesh.texCoords1.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.texCoords1.Length * 8);
                    acc.SetData(buff, 0, mesh.texCoords1.Length, DimensionType.VEC2, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("TEXCOORD_1", acc);
                    BuffViewoffset += mesh.texCoords1.Length * 8;
                }
                if (mesh.weightCount > 0)
                {
                    //if (skin != null)
                    //{
                    {
                        var acc = model.CreateAccessor();
                        var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.positions.Length * 8);
                        acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC4, EncodingType.UNSIGNED_SHORT, false);
                        prim.SetVertexAccessor("JOINTS_0", acc);
                        BuffViewoffset += mesh.positions.Length * 8;
                    }
                    {
                        var acc = model.CreateAccessor();
                        var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.positions.Length * 16);
                        acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                        prim.SetVertexAccessor("WEIGHTS_0", acc);
                        BuffViewoffset += mesh.positions.Length * 16;
                    }
                    if (mesh.weightCount > 4)
                    {
                        {
                            var acc = model.CreateAccessor();
                            var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.positions.Length * 8);
                            acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC4, EncodingType.UNSIGNED_SHORT, false);
                            prim.SetVertexAccessor("JOINTS_1", acc);
                            BuffViewoffset += mesh.positions.Length * 8;
                        }
                        {
                            var acc = model.CreateAccessor();
                            var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.positions.Length * 16);
                            acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                            prim.SetVertexAccessor("WEIGHTS_1", acc);
                            BuffViewoffset += mesh.positions.Length * 16;
                        }
                    }
                    //}
                }
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.indices.Length * 2);
                    acc.SetData(buff, 0, mesh.indices.Length, DimensionType.SCALAR, EncodingType.UNSIGNED_SHORT, false);
                    prim.SetIndexAccessor(acc);
                    BuffViewoffset += mesh.indices.Length * 2;
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
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.garmentMorph.Length * 12);
                    acc.SetData(buff, 0, mesh.garmentMorph.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                    var dict = new Dictionary<string, Accessor>
                    {
                        { "POSITION", acc }
                    };
                    prim.SetMorphTargetAccessors(0, dict);
                    BuffViewoffset += mesh.garmentMorph.Length * 12;
                }

            }
        }

        public static ModelRoot RawMeshesToGLTF(List<RawMeshContainer> meshes, RawArmature rig, bool mergeMeshes = false)
        {
            var model = ModelRoot.CreateModel();
            model.Extras = SharpGLTF.IO.JsonContent.Serialize(new { ExperimentalMergedMeshes = mergeMeshes });

            Skin skin = null;
            if (rig != null)
            {
                skin = model.CreateSkin();
                skin.BindJoints(RIG.ExportNodes(ref model, rig).Values.ToArray());
            }

            Dictionary<string, Material> materials = null;

            if (mergeMeshes)
            {
                materials = new Dictionary<string, Material>();

                foreach (var mesh in meshes)
                {
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

            AddSubmeshesToModel(meshes, skin, ref model, model.UseScene(0), materials, mergeMeshes);

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
                long indCount = mesh.indices.Length;
                var expmesh = new MeshBuilder<VertexPosition, VertexEmpty, VertexEmpty>(mesh.name);

                var prim = expmesh.UsePrimitive(new MaterialBuilder("Default").WithDoubleSide(true));
                for (var i = 0; i < indCount; i += 3)
                {
                    var idx0 = mesh.indices[i + 1];
                    var idx1 = mesh.indices[i];
                    var idx2 = mesh.indices[i + 2];

                    //VPNT
                    var p_0 = new Vec3(mesh.positions[idx0].X, mesh.positions[idx0].Y, mesh.positions[idx0].Z);
                    var p_1 = new Vec3(mesh.positions[idx1].X, mesh.positions[idx1].Y, mesh.positions[idx1].Z);
                    var p_2 = new Vec3(mesh.positions[idx2].X, mesh.positions[idx2].Y, mesh.positions[idx2].Z);

                    // vertex build
                    var v0 = new VertexBuilder<VertexPosition, VertexEmpty, VertexEmpty>(new VertexPosition(p_0));
                    var v1 = new VertexBuilder<VertexPosition, VertexEmpty, VertexEmpty>(new VertexPosition(p_1));
                    var v2 = new VertexBuilder<VertexPosition, VertexEmpty, VertexEmpty>(new VertexPosition(p_2));
                    // triangle build
                    prim.AddTriangle(v0, v1, v2);
                }
                scene.AddRigidMesh(expmesh, System.Numerics.Matrix4x4.Identity);
            }
            var model = scene.ToGltf2();
            return model;
        }
        public static RawArmature GetOrphanRig(CMesh meshBlob)
        {
            var rendmeshblob = meshBlob.RenderResourceBlob.Chunk as rendRenderMeshBlob;
            if (rendmeshblob.Header.BonePositions.Count != 0)
            {
                var boneCount = rendmeshblob.Header.BonePositions.Count;
                var Rig = new RawArmature
                {
                    BoneCount = boneCount,
                    LocalPosn = rendmeshblob.Header.BonePositions.Select(p => new Vec3(p.X, p.Z, -p.Y)).ToArray(),
                    LocalRot = Enumerable.Repeat(System.Numerics.Quaternion.Identity, boneCount).ToArray(),
                    LocalScale = Enumerable.Repeat(Vec3.One, boneCount).ToArray(),
                    Parent = Enumerable.Repeat<short>(-1, boneCount).ToArray(),
                    Names = meshBlob.BoneNames.Select(x => x.GetResolvedText()).ToArray()
                };
                return Rig;
            }
            return null;
        }

        public static RawArmature GetOrphanRig(ModelRoot model)
        {
            if (model.LogicalSkins.Count > 0 && model.LogicalSkins[0].JointsCount > 0)
            {
                var boneCount = model.LogicalSkins[0].JointsCount;
                var Rig = new RawArmature
                {
                    BoneCount = boneCount,
                    LocalPosn = Enumerable.Range(0, boneCount).Select(_ => model.LogicalSkins[0].GetJoint(_).Joint.LocalTransform.Translation).ToArray(),
                    LocalRot = Enumerable.Range(0, boneCount).Select(_ => model.LogicalSkins[0].GetJoint(_).Joint.LocalTransform.Rotation).ToArray(),
                    LocalScale = Enumerable.Range(0, boneCount).Select(_ => model.LogicalSkins[0].GetJoint(_).Joint.LocalTransform.Scale).ToArray(),
                    Parent = Enumerable.Repeat<short>(-1, boneCount).ToArray(),
                    //Parent       = Enumerable.Range(0, boneCount).Select(_ => (short)model.LogicalSkins[0].GetJoint(_).Joint.VisualParent.LogicalIndex).ToArray(),
                    Names = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_ => model.LogicalSkins[0].GetJoint(_).Joint.Name).ToArray()
                };
                return Rig;
            }
            return null;
        }

        private static void RemoveDoubleFaces(ref List<RawMeshContainer> meshes)
        {
            for (var i = 0; i < meshes.Count; i++)
            {
                if (meshes[i].indices.Length > 0)
                {
                    var idx0 = meshes[i].indices[0];
                    var idx1 = meshes[i].indices[1];
                    var idx2 = meshes[i].indices[2];

                    var doubled = false;
                    for (var j = 3; j < meshes[i].indices.Length; j += 3)
                    {
                        var bool0 = idx0 == meshes[i].indices[j] || idx0 == meshes[i].indices[j + 1] || idx0 == meshes[i].indices[j + 2];
                        var bool1 = idx1 == meshes[i].indices[j] || idx1 == meshes[i].indices[j + 1] || idx1 == meshes[i].indices[j + 2];
                        var bool2 = idx2 == meshes[i].indices[j] || idx2 == meshes[i].indices[j + 1] || idx2 == meshes[i].indices[j + 2];

                        doubled = bool0 && bool1 && bool2;
                        if (doubled)
                        {
                            break;
                        }
                    }
                    if (doubled && meshes[i].normals.Length > 0)
                    {
                        var indices = new List<uint>();
                        for (var j = 0; j < meshes[i].indices.Length; j += 3)
                        {
                            var v0 = meshes[i].positions[meshes[i].indices[j]];
                            var v1 = meshes[i].positions[meshes[i].indices[j + 1]];
                            var v2 = meshes[i].positions[meshes[i].indices[j + 2]];
                            var cross = Vec3.Normalize(Vec3.Cross(new Vec3(v1.X - v0.X, v1.Y - v0.Y, v1.Z - v0.Z), new Vec3(v2.X - v1.X, v2.Y - v1.Y, v2.Z - v1.Z)));

                            var n0 = meshes[i].normals[meshes[i].indices[j]];
                            var n1 = meshes[i].normals[meshes[i].indices[j + 1]];
                            var n2 = meshes[i].normals[meshes[i].indices[j + 2]];
                            var avg = Vec3.Normalize(new Vec3((n0.X + n1.X + n2.X) / 3, (n0.Y + n1.Y + n2.Y) / 3, (n0.Z + n1.Z + n2.Z) / 3));

                            if (Vec3.Dot(cross, avg) <= 0)
                            {
                                indices.Add(meshes[i].indices[j]);
                                indices.Add(meshes[i].indices[j + 1]);
                                indices.Add(meshes[i].indices[j + 2]);
                            }
                        }
                        meshes[i].indices = indices.ToArray();
                        meshes[i].name += "_doubled";
                    }
                }
            }
        }

        public static void UpdateSkinningParamCloth(ref List<RawMeshContainer> meshes, Stream ms, CR2WFile cr2w)
        {
            UpdateSkinningParamCloth(ref meshes, cr2w);
        }

        public static void UpdateSkinningParamCloth(ref List<RawMeshContainer> meshes, CR2WFile cr2w)
        {
            var clothBLob = ((CMesh)cr2w.RootChunk).Parameters.FirstOrDefault(x => x.Chunk is meshMeshParamCloth);
            if (clothBLob != null)
            {
                var blob = (meshMeshParamCloth)clothBLob.Chunk;

                for (var i = 0; i < blob.Chunks.Count && i < meshes.Count; i++)
                {
                    if (blob.Chunks[i].SkinIndices is { Buffer.MemSize: > 0 } && blob.Chunks[i].SkinWeights is { Buffer.MemSize: > 0 })
                    {
                        meshes[i].weightCount = 4;
                    }
                    if (blob.Chunks[i].SkinIndicesExt is { Buffer.MemSize: > 0 } && blob.Chunks[i].SkinWeightsExt is { Buffer.MemSize: > 0 })
                    {
                        meshes[i].weightCount += 4;
                    }
                    meshes[i].boneindices = new ushort[meshes[i].positions.Length, meshes[i].weightCount];
                    meshes[i].weights = new float[meshes[i].positions.Length, meshes[i].weightCount];
                    if (blob.Chunks[i].SkinIndices is { Buffer.MemSize: > 0 })
                    {
                        var stream = new MemoryStream(blob.Chunks[i].SkinWeights.Buffer.GetBytes());

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (var e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].boneindices[e, 0] = br.ReadByte();
                            meshes[i].boneindices[e, 1] = br.ReadByte();
                            meshes[i].boneindices[e, 2] = br.ReadByte();
                            meshes[i].boneindices[e, 3] = br.ReadByte();
                        }
                    }
                    if (blob.Chunks[i].SkinWeights is { Buffer.MemSize: > 0 })
                    {
                        var stream = new MemoryStream(blob.Chunks[i].SkinWeights.Buffer.GetBytes());

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (var e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].weights[e, 0] = br.ReadSingle();
                            meshes[i].weights[e, 1] = br.ReadSingle();
                            meshes[i].weights[e, 2] = br.ReadSingle();
                            meshes[i].weights[e, 3] = br.ReadSingle();
                        }
                    }
                    if (blob.Chunks[i].SkinIndicesExt is { Buffer.MemSize: > 0 })
                    {
                        var stream = new MemoryStream(blob.Chunks[i].SkinIndicesExt.Buffer.GetBytes());

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (var e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].boneindices[e, 4] = br.ReadByte();
                            meshes[i].boneindices[e, 5] = br.ReadByte();
                            meshes[i].boneindices[e, 6] = br.ReadByte();
                            meshes[i].boneindices[e, 7] = br.ReadByte();
                        }
                    }
                    if (blob.Chunks[i].SkinWeightsExt is { Buffer.MemSize: > 0 })
                    {
                        var stream = new MemoryStream(blob.Chunks[i].SkinWeightsExt.Buffer.GetBytes());

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (var e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].weights[e, 4] = br.ReadSingle();
                            meshes[i].weights[e, 5] = br.ReadSingle();
                            meshes[i].weights[e, 6] = br.ReadSingle();
                            meshes[i].weights[e, 7] = br.ReadSingle();
                        }
                    }
                    for (var e = 0; e < meshes[i].positions.Length; e++)
                    {
                        float sum = 0;
                        for (var y = 0; y < meshes[i].weightCount; y++)
                        {
                            sum += meshes[i].weights[e, y];
                        }
                        if (sum == 0 && meshes[i].weightCount > 0)
                        {
                            meshes[i].boneindices[e, 0] = 0;
                            meshes[i].weights[e, 0] = 1f;
                            sum = 1;
                        }
                        for (var y = 0; y < meshes[i].weightCount; y++)
                        {
                            meshes[i].weights[e, y] *= 1f / sum;
                        }
                    }
                }
            }

            var clothGraphicalBLob = ((CMesh)cr2w.RootChunk).Parameters.FirstOrDefault(x => x.Chunk is meshMeshParamCloth_Graphical);
            if (clothGraphicalBLob != null)
            {
                var blob = (meshMeshParamCloth_Graphical)clothGraphicalBLob.Chunk;

                for (var i = 0; i < blob.Chunks.Count && i < meshes.Count; i++)
                {
                    if (blob.Chunks[i].Simulation.Count > 0 && meshes[i].colors1.Length != meshes[i].positions.Length)
                    {
                        meshes[i].colors1 = new Vec4[meshes[i].positions.Length];
                    }

                    for (var e = 0; e < meshes[i].colors1.Length; e++)
                    {
                        meshes[i].colors1[e] = Vec4.Zero;
                    }
                    for (var e = 0; e < blob.Chunks[i].Simulation.Count; e++)
                    {
                        meshes[i].colors1[blob.Chunks[i].Simulation[e]].X = 1f;
                    }
                    if (blob.Chunks[i].SkinIndices is { Buffer.MemSize: > 0 } && blob.Chunks[i].SkinWeights is { Buffer.MemSize: > 0 })
                    {
                        meshes[i].weightCount = 4;
                    }
                    if (blob.Chunks[i].SkinIndicesExt is { Buffer.MemSize: > 0 } && blob.Chunks[i].SkinWeightsExt is { Buffer.MemSize: > 0 })
                    {
                        meshes[i].weightCount += 4;
                    }
                    meshes[i].boneindices = new ushort[meshes[i].positions.Length, meshes[i].weightCount];
                    meshes[i].weights = new float[meshes[i].positions.Length, meshes[i].weightCount];
                    if (blob.Chunks[i].SkinIndices is { Buffer.MemSize: > 0 })
                    {
                        var stream = new MemoryStream(blob.Chunks[i].SkinIndices.Buffer.GetBytes());

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (var e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].boneindices[e, 0] = br.ReadByte();
                            meshes[i].boneindices[e, 1] = br.ReadByte();
                            meshes[i].boneindices[e, 2] = br.ReadByte();
                            meshes[i].boneindices[e, 3] = br.ReadByte();
                        }
                    }
                    if (blob.Chunks[i].SkinWeights is { Buffer.MemSize: > 0 })
                    {
                        var stream = new MemoryStream(blob.Chunks[i].SkinWeights.Buffer.GetBytes());

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (var e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].weights[e, 0] = br.ReadSingle();
                            meshes[i].weights[e, 1] = br.ReadSingle();
                            meshes[i].weights[e, 2] = br.ReadSingle();
                            meshes[i].weights[e, 3] = br.ReadSingle();
                        }
                    }
                    if (blob.Chunks[i].SkinIndicesExt is { Buffer.MemSize: > 0 })
                    {
                        var stream = new MemoryStream(blob.Chunks[i].SkinIndicesExt.Buffer.GetBytes());

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (var e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].boneindices[e, 4] = br.ReadByte();
                            meshes[i].boneindices[e, 5] = br.ReadByte();
                            meshes[i].boneindices[e, 6] = br.ReadByte();
                            meshes[i].boneindices[e, 7] = br.ReadByte();
                        }
                    }
                    if (blob.Chunks[i].SkinWeightsExt is { Buffer.MemSize: > 0 })
                    {
                        var stream = new MemoryStream(blob.Chunks[i].SkinWeightsExt.Buffer.GetBytes());

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (var e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].weights[e, 4] = br.ReadSingle();
                            meshes[i].weights[e, 5] = br.ReadSingle();
                            meshes[i].weights[e, 6] = br.ReadSingle();
                            meshes[i].weights[e, 7] = br.ReadSingle();
                        }
                    }
                    for (var e = 0; e < meshes[i].positions.Length; e++)
                    {
                        float sum = 0;
                        for (var y = 0; y < meshes[i].weightCount; y++)
                        {
                            sum += meshes[i].weights[e, y];
                        }
                        if (sum == 0 && meshes[i].weightCount > 0)
                        {
                            meshes[i].boneindices[e, 0] = 0;
                            meshes[i].weights[e, 0] = 1f;
                            sum = 1;
                        }
                        for (var y = 0; y < meshes[i].weightCount; y++)
                        {
                            meshes[i].weights[e, y] *= 1f / sum;
                        }
                    }
                }
            }
        }
    }
}
