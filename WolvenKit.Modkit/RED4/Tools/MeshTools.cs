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
using WolvenKit.Common.Oodle;
using WolvenKit.Common.Services;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace CP77.CR2W
{
    using static WolvenKit.RED4.Types.Enums;
    using Vec2 = System.Numerics.Vector2;
    using Vec3 = System.Numerics.Vector3;
    using Vec4 = System.Numerics.Vector4;

    public class MeshTools
    {
        private readonly Red4ParserService _red4ParserService;

        public MeshTools(Red4ParserService red4ParserService)
        {
            _red4ParserService = red4ParserService;
        }
        public bool ExportMeshPreviewer(Stream meshStream, FileInfo outFile)
        {
            var cr2w = _red4ParserService.TryReadRed4File(meshStream);

            if (cr2w == null || !cr2w.Chunks.OfType<rendRenderMeshBlob>().Any())
            {
                return false;
            }

            var cachedFiles = Directory.GetFiles(outFile.DirectoryName);
            if (cachedFiles.Length > 5)
            {
                foreach (var f in cachedFiles)
                {
                    try
                    {
                        File.Delete(f);
                    }
                    catch
                    {
                    }
                }
            }

            var rendblob = cr2w.Chunks.OfType<rendRenderMeshBlob>().First();

            rendblob.RenderBuffer.Decompress();
            using var ms = new MemoryStream(rendblob.RenderBuffer.Data);

            var meshesinfo = GetMeshesinfo(rendblob, cr2w);

            var expMeshes = ContainRawMesh(ms, meshesinfo, true);

            ModelRoot model = RawMeshesToMinimalGLTF(expMeshes);

            model.SaveGLB(outFile.FullName);

            return true;
        }
        public bool ExportMesh(Stream meshStream, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true, ValidationMode vmode = ValidationMode.TryFix)
        {
            var cr2w = _red4ParserService.TryReadRed4File(meshStream);

            if (cr2w == null || !cr2w.Chunks.OfType<CMesh>().Any() || !cr2w.Chunks.OfType<rendRenderMeshBlob>().Any())
            {
                return false;
            }

            var rendblob = cr2w.Chunks.OfType<rendRenderMeshBlob>().First();

            RawArmature Rig = GetOrphanRig(rendblob, cr2w);

            rendblob.RenderBuffer.Decompress();
            using var ms = new MemoryStream(rendblob.RenderBuffer.Data);

            var meshesinfo = GetMeshesinfo(rendblob, cr2w);

            List<RawMeshContainer> expMeshes = ContainRawMesh(ms, meshesinfo, LodFilter);
            UpdateSkinningParamCloth(ref expMeshes, meshStream, cr2w);

            ModelRoot model = RawMeshesToGLTF(expMeshes, Rig);


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

            return true;
        }
        public bool ExportMeshWithoutRig(Stream meshStream, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true, ValidationMode vmode = ValidationMode.TryFix)
        {
            var cr2w = _red4ParserService.TryReadRed4File(meshStream);

            if (cr2w == null || !cr2w.Chunks.OfType<CMesh>().Any() || !cr2w.Chunks.OfType<rendRenderMeshBlob>().Any())
            {
                return false;
            }

            var rendblob = cr2w.Chunks.OfType<rendRenderMeshBlob>().First();

            rendblob.RenderBuffer.Decompress();
            using var ms = new MemoryStream(rendblob.RenderBuffer.Data);

            var meshesinfo = GetMeshesinfo(rendblob, cr2w);

            List<RawMeshContainer> expMeshes = ContainRawMesh(ms, meshesinfo, LodFilter);

            ModelRoot model = RawMeshesToGLTF(expMeshes, null);

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
            return true;
        }
        public bool ExportMultiMeshWithoutRig(List<Stream> meshStreamS, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true, ValidationMode vmode = ValidationMode.TryFix)
        {
            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();

            foreach (var meshStream in meshStreamS)
            {
                var cr2w = _red4ParserService.TryReadRed4File(meshStream);
                if (cr2w == null || !cr2w.Chunks.OfType<CMesh>().Any() || !cr2w.Chunks.OfType<rendRenderMeshBlob>().Any())
                    continue;

                var rendblob = cr2w.Chunks.OfType<rendRenderMeshBlob>().First();

                rendblob.RenderBuffer.Decompress();
                using var ms = new MemoryStream(rendblob.RenderBuffer.Data);

                var meshesinfo = GetMeshesinfo(rendblob, cr2w);

                var Meshes = ContainRawMesh(ms, meshesinfo, LodFilter);

                expMeshes.AddRange(Meshes);

                meshStream.Dispose();
                meshStream.Close();
            }

            ModelRoot model = RawMeshesToGLTF(expMeshes, null);

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
        public bool ExportMeshWithRig(Stream meshStream, Stream rigStream, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true, ValidationMode vmode = ValidationMode.TryFix)
        {
            var cr2w = _red4ParserService.TryReadRed4File(meshStream);

            if (cr2w == null || !cr2w.Chunks.OfType<CMesh>().Any() || !cr2w.Chunks.OfType<rendRenderMeshBlob>().Any())
            {
                return false;
            }

            var rendblob = cr2w.Chunks.OfType<rendRenderMeshBlob>().First();

            rendblob.RenderBuffer.Decompress();
            using var ms = new MemoryStream(rendblob.RenderBuffer.Data);

            var meshesinfo = GetMeshesinfo(rendblob, cr2w);

            List<RawMeshContainer> expMeshes = ContainRawMesh(ms, meshesinfo, LodFilter);
            UpdateSkinningParamCloth(ref expMeshes, meshStream, cr2w);

            RawArmature meshRig = GetOrphanRig(rendblob, cr2w);
            RawArmature Rig = RIG.ProcessRig(_red4ParserService.TryReadRed4File(rigStream));

            UpdateMeshJoints(ref expMeshes, Rig, meshRig);

            ModelRoot model = RawMeshesToGLTF(expMeshes, Rig);


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
        public bool ExportMultiMeshWithRig(List<Stream> meshStreamS, List<Stream> rigStreamS, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true, ValidationMode vmode = ValidationMode.TryFix)
        {
            List<RawArmature> Rigs = new List<RawArmature>();
            foreach (var rigStream in rigStreamS)
            {
                RawArmature Rig = RIG.ProcessRig(_red4ParserService.TryReadRed4File(rigStream));
                Rigs.Add(Rig);

                rigStream.Dispose();
                rigStream.Close();
            }
            RawArmature expRig = RIG.CombineRigs(Rigs);

            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();

            foreach (var meshStream in meshStreamS)
            {
                var cr2w = _red4ParserService.TryReadRed4File(meshStream);
                if (cr2w == null || !cr2w.Chunks.OfType<CMesh>().Any() || !cr2w.Chunks.OfType<rendRenderMeshBlob>().Any())
                {
                    continue;
                }

                var rendblob = cr2w.Chunks.OfType<rendRenderMeshBlob>().First();

                rendblob.RenderBuffer.Decompress();
                using var ms = new MemoryStream(rendblob.RenderBuffer.Data);

                var meshesinfo = GetMeshesinfo(rendblob, cr2w);

                List<RawMeshContainer> Meshes = ContainRawMesh(ms, meshesinfo, LodFilter);
                UpdateSkinningParamCloth(ref Meshes, meshStream, cr2w);

                RawArmature meshRig = GetOrphanRig(rendblob, cr2w);

                UpdateMeshJoints(ref Meshes, expRig, meshRig);

                expMeshes.AddRange(Meshes);

                meshStream.Dispose();
                meshStream.Close();
            }
            ModelRoot model = RawMeshesToGLTF(expMeshes, expRig);

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
        public static MeshesInfo GetMeshesinfo(rendRenderMeshBlob rendmeshblob, CR2WFile cr2w)
        {
            MeshesInfo meshesInfo = new MeshesInfo(rendmeshblob.Header.RenderChunkInfos.Count);
            Vector4 redquantScale = rendmeshblob.Header.QuantizationScale;
            Vector4 redquantTrans = rendmeshblob.Header.QuantizationOffset;

            meshesInfo.quantScale = new Vec4(redquantScale.X, redquantScale.Y, redquantScale.Z, redquantScale.W);
            meshesInfo.quantTrans = new Vec4(redquantTrans.X, redquantTrans.Y, redquantTrans.Z, redquantTrans.W);

            meshesInfo.vertBufferSize = rendmeshblob.Header.VertexBufferSize;
            meshesInfo.indexBufferOffset = rendmeshblob.Header.IndexBufferOffset;
            meshesInfo.indexBufferSize = rendmeshblob.Header.IndexBufferSize;

            for (int i = 0; i < meshesInfo.meshCount; i++)
            {
                meshesInfo.vertCounts[i] = rendmeshblob.Header.RenderChunkInfos[i].NumVertices;
                meshesInfo.indCounts[i] = rendmeshblob.Header.RenderChunkInfos[i].NumIndices;
                meshesInfo.posnOffsets[i] = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[0];
                meshesInfo.unknownOffsets[i] = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[4];

                var cv = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices;
                for (int e = 0; e < cv.VertexLayout.Elements.Count; e++)
                {
                    if (cv.VertexLayout.Elements[e].Usage.Value == Enums.GpuWrapApiVertexPackingePackingUsage.PS_Normal)
                    {
                        meshesInfo.normalOffsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex];
                    }
                    if (cv.VertexLayout.Elements[e].Usage.Value == Enums.GpuWrapApiVertexPackingePackingUsage.PS_Tangent)
                    {
                        meshesInfo.tangentOffsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex];
                    }
                    if (cv.VertexLayout.Elements[e].Usage.Value == Enums.GpuWrapApiVertexPackingePackingUsage.PS_Color)
                    {
                        meshesInfo.colorOffsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex];
                    }
                    if (cv.VertexLayout.Elements[e].Usage.Value == Enums.GpuWrapApiVertexPackingePackingUsage.PS_TexCoord)
                    {
                        if (meshesInfo.tex0Offsets[i] == 0)
                            meshesInfo.tex0Offsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex];
                        else
                            meshesInfo.tex1Offsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex];
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

            int count = 0;
            UInt32 counter = 0;
            // getting number of weights for the meshes
            for (int i = 0; i < meshesInfo.meshCount; i++)
            {
                count = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements.Count;
                counter = 0;
                for (int e = 0; e < count; e++)
                {
                    if (rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements[e].Usage.Value == GpuWrapApiVertexPackingePackingUsage.PS_SkinIndices)
                        counter++;
                }
                meshesInfo.weightCounts[i] = counter * 4;
            }

            for (int i = 0; i < meshesInfo.meshCount; i++)
            {
                meshesInfo.garmentSupportExists[i] = false;
                count = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements.Count;

                for (int e = 0; e < count; e++)
                {
                    if (rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements[e].Usage.Value == GpuWrapApiVertexPackingePackingUsage.PS_ExtraData)
                    {
                        if (rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements[e].StreamIndex == 0)
                            meshesInfo.garmentSupportExists[i] = true;
                    }
                }
                if (!cr2w.Chunks.OfType<meshMeshParamGarmentSupport>().Any())
                {
                    meshesInfo.garmentSupportExists[i] = false;
                }
            }

            meshesInfo.appearances = new Dictionary<string, string[]>();
            var apps = cr2w.Chunks.OfType<meshMeshAppearance>().ToList();
            for (int i = 0; i < apps.Count; i++)
            {
                string[] materialNames = new string[apps[i].ChunkMaterials.Count];
                for (int e = 0; e < apps[i].ChunkMaterials.Count; e++)
                {
                    materialNames[e] = apps[i].ChunkMaterials[e];
                }
                meshesInfo.appearances.Add(apps[i].Name, materialNames);
            }

            return meshesInfo;
        }
        public static List<RawMeshContainer> ContainRawMesh(MemoryStream gfs, MeshesInfo info, bool LODFilter)
        {
            BinaryReader gbr = new BinaryReader(gfs);

            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();

            for (int index = 0; index < info.meshCount; index++)
            {
                if (info.LODLvl[index] != 1 && LODFilter)
                    continue;

                RawMeshContainer meshContainer = new RawMeshContainer();

                // getting positions
                meshContainer.positions = new Vec3[info.vertCounts[index]];
                for (int i = 0; i < info.vertCounts[index]; i++)
                {
                    gfs.Position = info.posnOffsets[index] + i * info.vpStrides[index];

                    float x = (gbr.ReadInt16() / 32767f) * info.quantScale.X + info.quantTrans.X;
                    float y = (gbr.ReadInt16() / 32767f) * info.quantScale.Y + info.quantTrans.Y;
                    float z = (gbr.ReadInt16() / 32767f) * info.quantScale.Z + info.quantTrans.Z;

                    // Z up to Y up and LHCS to RHCS
                    meshContainer.positions[i] = new Vec3(x, z, -y);
                }

                // getting uvcoordinates0 from half floats
                meshContainer.texCoords0 = new Vec2[0];
                if (info.tex0Offsets[index] != 0)
                {
                    meshContainer.texCoords0 = new Vec2[info.vertCounts[index]];
                    for (int i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.tex0Offsets[index] + i * 4;
                        meshContainer.texCoords0[i] = new Vec2(Converters.hfconvert(gbr.ReadUInt16()), Converters.hfconvert(gbr.ReadUInt16()));
                    }
                }

                // getting float normals from 10bits
                meshContainer.normals = new Vec3[0];
                if (info.normalOffsets[index] != 0)
                {
                    meshContainer.normals = new Vec3[info.vertCounts[index]];

                    UInt32 stride = 4;
                    if (info.tangentOffsets[index] != 0)
                        stride += 4;
                    for (int i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.normalOffsets[index] + stride * i;
                        uint read = gbr.ReadUInt32();
                        Vec4 vec = Converters.TenBitShifted(read);

                        // Z up to Y up and LHCS to RHCS
                        meshContainer.normals[i] = new Vec3(vec.X, vec.Z, -vec.Y);
                        meshContainer.normals[i] = Vec3.Normalize(meshContainer.normals[i]);
                    }
                }

                // getting float tangents from 10bits
                meshContainer.tangents = new Vec4[0];
                if (info.tangentOffsets[index] != 0)
                {
                    meshContainer.tangents = new Vec4[info.vertCounts[index]];

                    UInt32 stride = 4;
                    UInt32 off = 0;
                    if (info.normalOffsets[index] != 0)
                    {
                        off = 4;
                        stride += 4;
                    }
                    for (int i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.tangentOffsets[index] + stride * i + off;
                        uint read = gbr.ReadUInt32();
                        Vec4 vec0 = Converters.TenBitShifted(read);

                        // Z up to Y up and LHCS to RHCS
                        Vec3 vec1 = Vec3.Normalize(new Vec3(vec0.X, vec0.Z, -vec0.Y));
                        meshContainer.tangents[i] = new Vec4(vec1.X, vec1.Y, vec1.Z, 1f);
                    }
                }

                // getting uvcoordinates1 from half floats
                meshContainer.texCoords1 = new Vec2[0];
                if (info.tex1Offsets[index] != 0)
                {
                    meshContainer.texCoords1 = new Vec2[info.vertCounts[index]];

                    UInt32 stride = 4;
                    UInt32 off = 0;
                    if (info.colorOffsets[index] != 0)
                    {
                        off = 4;
                        stride += 4;
                    }

                    for (int i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.tex1Offsets[index] + i * stride + off;

                        meshContainer.texCoords1[i] = new Vec2(Converters.hfconvert(gbr.ReadUInt16()), Converters.hfconvert(gbr.ReadUInt16()));
                    }
                }

                // getting colors from Byte
                meshContainer.colors0 = new Vec4[0];
                if (info.colorOffsets[index] != 0)
                {
                    meshContainer.colors0 = new Vec4[info.vertCounts[index]];

                    UInt32 stride = 4;
                    if (info.tex1Offsets[index] != 0)
                        stride += 4;

                    for (int i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.colorOffsets[index] + i * stride;
                        meshContainer.colors0[i] = new Vec4(gbr.ReadByte() / 255f, gbr.ReadByte() / 255f, gbr.ReadByte() / 255f, gbr.ReadByte() / 255f);
                    }
                }

                // getting bone indices
                meshContainer.boneindices = new ushort[info.vertCounts[index], info.weightCounts[index]];
                for (int i = 0; i < info.vertCounts[index]; i++)
                {
                    gfs.Position = info.posnOffsets[index] + i * info.vpStrides[index] + 8;
                    for (int e = 0; e < info.weightCounts[index]; e++)
                    {
                        meshContainer.boneindices[i, e] = gbr.ReadByte();
                    }
                }

                // getting weights
                meshContainer.weightCount = info.weightCounts[index];
                meshContainer.weights = new float[info.vertCounts[index], info.weightCounts[index]];
                for (int i = 0; i < info.vertCounts[index]; i++)
                {
                    float sum = 0;
                    gfs.Position = info.posnOffsets[index] + i * info.vpStrides[index] + 8 + meshContainer.weightCount;
                    for (int e = 0; e < meshContainer.weightCount; e++)
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
                    for (int e = 0; e < meshContainer.weightCount; e++)
                    {
                        meshContainer.weights[i, e] *= 1f / sum;
                    }
                }

                // getting garment morphs
                meshContainer.garmentMorph = new Vec3[0];
                if (info.garmentSupportExists[index])
                {
                    meshContainer.garmentMorph = new Vec3[info.vertCounts[index]];
                    for (int i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.posnOffsets[index] + i * info.vpStrides[index] + 8 + 2 * meshContainer.weightCount;
                        float x = Converters.hfconvert(gbr.ReadUInt16());
                        float y = Converters.hfconvert(gbr.ReadUInt16());
                        float z = Converters.hfconvert(gbr.ReadUInt16());
                        meshContainer.garmentMorph[i] = new Vec3(x, z, -y);
                    }
                }

                // getting uint16 face indices
                meshContainer.indices = new uint[info.indCounts[index]];
                gfs.Position = info.indicesOffsets[index];
                for (int i = 0; i < info.indCounts[index]; i++)
                {
                    meshContainer.indices[i] = gbr.ReadUInt16();
                }

                meshContainer.name = "submesh_" + Convert.ToString(index).PadLeft(2, '0') + "_LOD_" + info.LODLvl[index];

                meshContainer.materialNames = new string[info.appearances.Count];
                var apps = info.appearances.Keys.ToList();
                for (int e = 0; e < apps.Count; e++)
                {
                    meshContainer.materialNames[e] = info.appearances[apps[e]][index];
                }

                meshContainer.colors1 = new Vec4[0];
                expMeshes.Add(meshContainer);
            }
            RemoveDoubleFaces(ref expMeshes);
            return expMeshes;
        }
        public static void UpdateMeshJoints(ref List<RawMeshContainer> Meshes, RawArmature newRig, RawArmature oldRig)
        {
            // updating mesh bone indices
            if (newRig != null && newRig.BoneCount > 0 && oldRig != null && oldRig.BoneCount > 0)
            {
                for (int i = 0; i < Meshes.Count; i++)
                {
                    for (int e = 0; e < Meshes[i].positions.Length; e++)
                    {
                        for (int eye = 0; eye < Meshes[i].weightCount; eye++)
                        {
                            if (Meshes[i].boneindices[e, eye] >= oldRig.BoneCount && Meshes[i].weights[e, eye] == 0)
                            {
                                Meshes[i].boneindices[e, eye] = 0;
                            }
                            bool found = false;
                            for (UInt16 r = 0; r < newRig.BoneCount; r++)
                            {
                                if (newRig.Names[r] == oldRig.Names[Meshes[i].boneindices[e, eye]])
                                {
                                    Meshes[i].boneindices[e, eye] = r;
                                    found = true;
                                    break;
                                }
                            }
                            if (!found)
                            {
                                throw new Exception($"Bone: {oldRig.Names[Meshes[i].boneindices[e, eye]]} not present in export Rig(s)/Import Mesh");
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < Meshes.Count; i++)
                {
                    for (int e = 0; e < Meshes[i].weightCount; e++)
                    {
                        Meshes[i].weightCount = 0;
                    }
                }
            }
        }
        public static ModelRoot RawMeshesToGLTF(List<RawMeshContainer> meshes, RawArmature Rig)
        {
            var model = ModelRoot.CreateModel();
            var mat = model.CreateMaterial("Default");
            mat.WithPBRMetallicRoughness().WithDefault();
            mat.DoubleSided = true;
            List<Skin> skins = new List<Skin>();
            if (Rig != null)
            {
                var skin = model.CreateSkin();
                skin.BindJoints(RIG.ExportNodes(ref model, Rig).Values.ToArray());
                skins.Add(skin);
            }

            var ms = new MemoryStream();
            var bw = new BinaryWriter(ms);
            foreach (var mesh in meshes)
            {
                for (int i = 0; i < mesh.positions.Length; i++)
                {
                    bw.Write(mesh.positions[i].X);
                    bw.Write(mesh.positions[i].Y);
                    bw.Write(mesh.positions[i].Z);
                }
                for (int i = 0; i < mesh.normals.Length; i++)
                {
                    bw.Write(mesh.normals[i].X);
                    bw.Write(mesh.normals[i].Y);
                    bw.Write(mesh.normals[i].Z);
                }
                for (int i = 0; i < mesh.tangents.Length; i++)
                {
                    bw.Write(mesh.tangents[i].X);
                    bw.Write(mesh.tangents[i].Y);
                    bw.Write(mesh.tangents[i].Z);
                    bw.Write(mesh.tangents[i].W);
                }
                for (int i = 0; i < mesh.colors0.Length; i++)
                {
                    bw.Write(mesh.colors0[i].X);
                    bw.Write(mesh.colors0[i].Y);
                    bw.Write(mesh.colors0[i].Z);
                    bw.Write(mesh.colors0[i].W);
                }
                for (int i = 0; i < mesh.colors1.Length; i++)
                {
                    bw.Write(mesh.colors1[i].X);
                    bw.Write(mesh.colors1[i].Y);
                    bw.Write(mesh.colors1[i].Z);
                    bw.Write(mesh.colors1[i].W);
                }
                for (int i = 0; i < mesh.texCoords0.Length; i++)
                {
                    bw.Write(mesh.texCoords0[i].X);
                    bw.Write(mesh.texCoords0[i].Y);
                }
                for (int i = 0; i < mesh.texCoords1.Length; i++)
                {
                    bw.Write(mesh.texCoords1[i].X);
                    bw.Write(mesh.texCoords1[i].Y);
                }

                if (mesh.weightCount > 0)
                {
                    if (Rig != null)
                    {
                        for (int i = 0; i < mesh.positions.Length; i++)
                        {
                            bw.Write(mesh.boneindices[i, 0]);
                            bw.Write(mesh.boneindices[i, 1]);
                            bw.Write(mesh.boneindices[i, 2]);
                            bw.Write(mesh.boneindices[i, 3]);
                        }
                        for (int i = 0; i < mesh.positions.Length; i++)
                        {
                            bw.Write(mesh.weights[i, 0]);
                            bw.Write(mesh.weights[i, 1]);
                            bw.Write(mesh.weights[i, 2]);
                            bw.Write(mesh.weights[i, 3]);
                        }
                        if (mesh.weightCount > 4)
                        {
                            for (int i = 0; i < mesh.positions.Length; i++)
                            {
                                bw.Write(mesh.boneindices[i, 4]);
                                bw.Write(mesh.boneindices[i, 5]);
                                bw.Write(mesh.boneindices[i, 6]);
                                bw.Write(mesh.boneindices[i, 7]);
                            }
                            for (int i = 0; i < mesh.positions.Length; i++)
                            {
                                bw.Write(mesh.weights[i, 4]);
                                bw.Write(mesh.weights[i, 5]);
                                bw.Write(mesh.weights[i, 6]);
                                bw.Write(mesh.weights[i, 7]);
                            }
                        }
                    }
                }
                for (int i = 0; i < mesh.indices.Length; i += 3)
                {
                    bw.Write(Convert.ToUInt16(mesh.indices[i + 1]));
                    bw.Write(Convert.ToUInt16(mesh.indices[i + 0]));
                    bw.Write(Convert.ToUInt16(mesh.indices[i + 2]));
                }
                if (mesh.garmentMorph.Length > 0)
                {
                    for (int i = 0; i < mesh.positions.Length; i++)
                    {
                        bw.Write(mesh.garmentMorph[i].X);
                        bw.Write(mesh.garmentMorph[i].Y);
                        bw.Write(mesh.garmentMorph[i].Z);
                    }
                }
            }
            var buffer = model.UseBuffer(ms.ToArray());
            int BuffViewoffset = 0;

            foreach (var mesh in meshes)
            {
                var mes = model.CreateMesh(mesh.name);
                var prim = mes.CreatePrimitive();
                prim.Material = mat;
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
                    if (Rig != null)
                    {
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
                    }
                }
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.indices.Length * 2);
                    acc.SetData(buff, 0, mesh.indices.Length, DimensionType.SCALAR, EncodingType.UNSIGNED_SHORT, false);
                    prim.SetIndexAccessor(acc);
                    BuffViewoffset += mesh.indices.Length * 2;
                }
                var nod = model.UseScene(0).CreateNode(mesh.name);
                nod.Mesh = mes;
                if (Rig != null && mesh.weightCount > 0)
                    nod.Skin = skins[0];

                if (mesh.garmentMorph.Length > 0)
                {
                    string[] arr = { "GarmentSupport" };
                    var obj = new { materialNames = mesh.materialNames, targetNames = arr };
                    mes.Extras = SharpGLTF.IO.JsonContent.Serialize(obj);
                }
                else
                {
                    var obj = new { materialNames = mesh.materialNames };
                    mes.Extras = SharpGLTF.IO.JsonContent.Serialize(obj);
                }
                if (mesh.garmentMorph.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.garmentMorph.Length * 12);
                    acc.SetData(buff, 0, mesh.garmentMorph.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                    var dict = new Dictionary<string, Accessor>();
                    dict.Add("POSITION", acc);
                    prim.SetMorphTargetAccessors(0, dict);
                    BuffViewoffset += mesh.garmentMorph.Length * 12;
                }
            }
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
                for (int i = 0; i < indCount; i += 3)
                {
                    uint idx0 = mesh.indices[i + 1];
                    uint idx1 = mesh.indices[i];
                    uint idx2 = mesh.indices[i + 2];

                    //VPNT
                    Vec3 p_0 = new Vec3(mesh.positions[idx0].X, mesh.positions[idx0].Y, mesh.positions[idx0].Z);
                    Vec3 p_1 = new Vec3(mesh.positions[idx1].X, mesh.positions[idx1].Y, mesh.positions[idx1].Z);
                    Vec3 p_2 = new Vec3(mesh.positions[idx2].X, mesh.positions[idx2].Y, mesh.positions[idx2].Z);

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
        public static RawArmature GetOrphanRig(rendRenderMeshBlob rendmeshblob, CR2WFile cr2w)
        {
            if (rendmeshblob.Header.BonePositions.Count != 0)
            {
                RawArmature Rig = new RawArmature();
                Rig.BoneCount = rendmeshblob.Header.BonePositions.Count;
                Rig.LocalPosn = new Vec3[Rig.BoneCount];
                Rig.LocalRot = new System.Numerics.Quaternion[Rig.BoneCount];
                Rig.LocalScale = new Vec3[Rig.BoneCount];
                Rig.Parent = new Int16[Rig.BoneCount];
                Rig.Names = new string[Rig.BoneCount];

                for (int i = 0; i < Rig.BoneCount; i++)
                {
                    var vec = rendmeshblob.Header.BonePositions[i];
                    Rig.LocalPosn[i] = new Vec3(vec.X, vec.Z, -vec.Y);
                    Rig.LocalRot[i] = System.Numerics.Quaternion.Identity;
                    Rig.LocalScale[i] = Vec3.One;
                    Rig.Parent[i] = -1;
                }
                if (cr2w.Chunks.OfType<CMesh>().Any())
                {
                    var meshBlob = cr2w.Chunks.OfType<CMesh>().First();
                    for (int i = 0; i < Rig.BoneCount; i++)
                    {
                        Rig.Names[i] = meshBlob.BoneNames[i];
                    }
                }
                return Rig;
            }
            return null;
        }
        private static void RemoveDoubleFaces(ref List<RawMeshContainer> Meshes)
        {
            for (int i = 0; i < Meshes.Count; i++)
            {
                var idx0 = Meshes[i].indices[0];
                var idx1 = Meshes[i].indices[1];
                var idx2 = Meshes[i].indices[2];

                bool doubled = false;
                for (int j = 3; j < Meshes[i].indices.Length; j += 3)
                {
                    var bool0 = (idx0 == Meshes[i].indices[j]) || (idx0 == Meshes[i].indices[j + 1]) || (idx0 == Meshes[i].indices[j + 2]);
                    var bool1 = (idx1 == Meshes[i].indices[j]) || (idx1 == Meshes[i].indices[j + 1]) || (idx1 == Meshes[i].indices[j + 2]);
                    var bool2 = (idx2 == Meshes[i].indices[j]) || (idx2 == Meshes[i].indices[j + 1]) || (idx2 == Meshes[i].indices[j + 2]);

                    doubled = bool0 && bool1 && bool2;
                    if (doubled)
                    {
                        break;
                    }
                }
                if (doubled)
                {
                    List<uint> indices = new List<uint>();
                    for (int j = 0; j < Meshes[i].indices.Length; j += 3)
                    {
                        var v0 = Meshes[i].positions[Meshes[i].indices[j]];
                        var v1 = Meshes[i].positions[Meshes[i].indices[j + 1]];
                        var v2 = Meshes[i].positions[Meshes[i].indices[j + 2]];
                        var cross = Vec3.Normalize(Vec3.Cross(new Vec3(v1.X - v0.X, v1.Y - v0.Y, v1.Z - v0.Z), new Vec3(v2.X - v1.X, v2.Y - v1.Y, v2.Z - v1.Z)));

                        var n0 = Meshes[i].normals[Meshes[i].indices[j]];
                        var n1 = Meshes[i].normals[Meshes[i].indices[j + 1]];
                        var n2 = Meshes[i].normals[Meshes[i].indices[j + 2]];
                        var avg = Vec3.Normalize(new Vec3((n0.X + n1.X + n2.X) / 3, (n0.Y + n1.Y + n2.Y) / 3, (n0.Z + n1.Z + n2.Z) / 3));

                        if (Vec3.Dot(cross, avg) <= 0)
                        {
                            indices.Add(Meshes[i].indices[j]);
                            indices.Add(Meshes[i].indices[j + 1]);
                            indices.Add(Meshes[i].indices[j + 2]);
                        }
                    }
                    Meshes[i].indices = indices.ToArray();
                    Meshes[i].name += "_doubled";
                }
            }
        }
        public static void UpdateSkinningParamCloth(ref List<RawMeshContainer> meshes, Stream ms, CR2WFile cr2w)
        {
            if (cr2w.Chunks.OfType<meshMeshParamCloth>().Any())
            {
                var blob = cr2w.Chunks.OfType<meshMeshParamCloth>().First();

                for (int i = 0; (i < blob.Chunks.Count) && (i < meshes.Count); i++)
                {
                    if (blob.Chunks[i].SkinIndices.Data.Length > 0 && blob.Chunks[i].SkinWeights.Data.Length > 0)
                    {
                        meshes[i].weightCount = 4;
                    }
                    if (blob.Chunks[i].SkinIndicesExt.Data.Length > 0 && blob.Chunks[i].SkinWeightsExt.Data.Length > 0)
                    {
                        meshes[i].weightCount += 4;
                    }
                    meshes[i].boneindices = new ushort[meshes[i].positions.Length, meshes[i].weightCount];
                    meshes[i].weights = new float[meshes[i].positions.Length, meshes[i].weightCount];
                    if (blob.Chunks[i].SkinIndices.Data.Length > 0)
                    {
                        var db = blob.Chunks[i].SkinWeights;
                        db.Decompress();

                        var stream = new MemoryStream();
                        ms.Write(db.Data);

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].boneindices[e, 0] = br.ReadByte();
                            meshes[i].boneindices[e, 1] = br.ReadByte();
                            meshes[i].boneindices[e, 2] = br.ReadByte();
                            meshes[i].boneindices[e, 3] = br.ReadByte();
                        }
                    }
                    if (blob.Chunks[i].SkinWeights.Data.Length > 0)
                    {
                        var db = blob.Chunks[i].SkinWeights;
                        db.Decompress();

                        var stream = new MemoryStream();
                        ms.Write(db.Data);

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].weights[e, 0] = br.ReadSingle();
                            meshes[i].weights[e, 1] = br.ReadSingle();
                            meshes[i].weights[e, 2] = br.ReadSingle();
                            meshes[i].weights[e, 3] = br.ReadSingle();
                        }
                    }
                    if (blob.Chunks[i].SkinIndicesExt.Data.Length > 0)
                    {
                        var db = blob.Chunks[i].SkinIndicesExt;
                        db.Decompress();

                        var stream = new MemoryStream();
                        ms.Write(db.Data);

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].boneindices[e, 4] = br.ReadByte();
                            meshes[i].boneindices[e, 5] = br.ReadByte();
                            meshes[i].boneindices[e, 6] = br.ReadByte();
                            meshes[i].boneindices[e, 7] = br.ReadByte();
                        }
                    }
                    if (blob.Chunks[i].SkinWeightsExt.Data.Length > 0)
                    {
                        var db = blob.Chunks[i].SkinWeightsExt;
                        db.Decompress();

                        var stream = new MemoryStream();
                        ms.Write(db.Data);

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].weights[e, 4] = br.ReadSingle();
                            meshes[i].weights[e, 5] = br.ReadSingle();
                            meshes[i].weights[e, 6] = br.ReadSingle();
                            meshes[i].weights[e, 7] = br.ReadSingle();
                        }
                    }
                    for (int e = 0; e < meshes[i].positions.Length; e++)
                    {
                        float sum = 0;
                        for (int y = 0; y < meshes[i].weightCount; y++)
                        {
                            sum += meshes[i].weights[e, y];
                        }
                        if (sum == 0 && meshes[i].weightCount > 0)
                        {
                            meshes[i].boneindices[e, 0] = 0;
                            meshes[i].weights[e, 0] = 1f;
                            sum = 1;
                        }
                        for (int y = 0; y < meshes[i].weightCount; y++)
                        {
                            meshes[i].weights[e, y] *= 1f / sum;
                        }
                    }
                }
            }
            if (cr2w.Chunks.OfType<meshMeshParamCloth_Graphical>().Any())
            {
                var blob = cr2w.Chunks.OfType<meshMeshParamCloth_Graphical>().First();

                for (int i = 0; (i < blob.Chunks.Count) && (i < meshes.Count); i++)
                {
                    if (blob.Chunks[i].Simulation.Count > 0 && meshes[i].colors1.Length != meshes[i].positions.Length)
                        meshes[i].colors1 = new Vec4[meshes[i].positions.Length];

                    for (int e = 0; e < meshes[i].colors1.Length; e++)
                    {
                        meshes[i].colors1[e] = Vec4.Zero;
                    }
                    for (int e = 0; e < blob.Chunks[i].Simulation.Count; e++)
                    {
                        meshes[i].colors1[blob.Chunks[i].Simulation[e]].X = 1f;
                    }
                    if (blob.Chunks[i].SkinIndices.Data.Length > 0 && blob.Chunks[i].SkinWeights.Data.Length > 0)
                    {
                        meshes[i].weightCount = 4;
                    }
                    if (blob.Chunks[i].SkinIndicesExt.Data.Length > 0 && blob.Chunks[i].SkinWeightsExt.Data.Length > 0)
                    {
                        meshes[i].weightCount += 4;
                    }
                    meshes[i].boneindices = new ushort[meshes[i].positions.Length, meshes[i].weightCount];
                    meshes[i].weights = new float[meshes[i].positions.Length, meshes[i].weightCount];
                    if (blob.Chunks[i].SkinIndices.Data.Length > 0)
                    {
                        var db = blob.Chunks[i].SkinIndices;
                        db.Decompress();

                        var stream = new MemoryStream();
                        ms.Write(db.Data);

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].boneindices[e, 0] = br.ReadByte();
                            meshes[i].boneindices[e, 1] = br.ReadByte();
                            meshes[i].boneindices[e, 2] = br.ReadByte();
                            meshes[i].boneindices[e, 3] = br.ReadByte();
                        }
                    }
                    if (blob.Chunks[i].SkinWeights.Data.Length > 0)
                    {
                        var db = blob.Chunks[i].SkinWeights;
                        db.Decompress();

                        var stream = new MemoryStream();
                        ms.Write(db.Data);

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].weights[e, 0] = br.ReadSingle();
                            meshes[i].weights[e, 1] = br.ReadSingle();
                            meshes[i].weights[e, 2] = br.ReadSingle();
                            meshes[i].weights[e, 3] = br.ReadSingle();
                        }
                    }
                    if (blob.Chunks[i].SkinIndicesExt.Data.Length > 0)
                    {
                        var db = blob.Chunks[i].SkinIndicesExt;
                        db.Decompress();

                        var stream = new MemoryStream();
                        ms.Write(db.Data);

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].boneindices[e, 4] = br.ReadByte();
                            meshes[i].boneindices[e, 5] = br.ReadByte();
                            meshes[i].boneindices[e, 6] = br.ReadByte();
                            meshes[i].boneindices[e, 7] = br.ReadByte();
                        }
                    }
                    if (blob.Chunks[i].SkinWeightsExt.Data.Length > 0)
                    {
                        var db = blob.Chunks[i].SkinWeightsExt;
                        db.Decompress();

                        var stream = new MemoryStream();
                        ms.Write(db.Data);

                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].weights[e, 4] = br.ReadSingle();
                            meshes[i].weights[e, 5] = br.ReadSingle();
                            meshes[i].weights[e, 6] = br.ReadSingle();
                            meshes[i].weights[e, 7] = br.ReadSingle();
                        }
                    }
                    for (int e = 0; e < meshes[i].positions.Length; e++)
                    {
                        float sum = 0;
                        for (int y = 0; y < meshes[i].weightCount; y++)
                        {
                            sum += meshes[i].weights[e, y];
                        }
                        if (sum == 0 && meshes[i].weightCount > 0)
                        {
                            meshes[i].boneindices[e, 0] = 0;
                            meshes[i].weights[e, 0] = 1f;
                            sum = 1;
                        }
                        for (int y = 0; y < meshes[i].weightCount; y++)
                        {
                            meshes[i].weights[e, y] *= 1f / sum;
                        }
                    }
                }
            }
        }
    }
}
