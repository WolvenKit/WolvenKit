using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.Common.Oodle;
using WolvenKit.RED4.GeneralStructs;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Materials;
using SharpGLTF.Scenes;
using SharpGLTF.Schema2;
using WolvenKit.RED4.RigFile;

namespace WolvenKit.RED4.MeshFile
{
    using Vec4 = System.Numerics.Vector4;
    using Vec3 = System.Numerics.Vector3;
    using Vec2 = System.Numerics.Vector2;

    using SKINNEDVERTEX = VertexBuilder<VertexPositionNormalTangent, VertexColor1Texture2, VertexJoints8>;
    using SKINNEDMESH = MeshBuilder<VertexPositionNormalTangent, VertexColor1Texture2, VertexJoints8>;
    using RIGIDVERTEX = VertexBuilder<VertexPositionNormalTangent, VertexColor1Texture2, VertexEmpty>;
    using RIGIDMESH = MeshBuilder<VertexPositionNormalTangent, VertexColor1Texture2, VertexEmpty>;
    using VPNT = VertexPositionNormalTangent;
    using VCT = VertexColor1Texture2;
    using VJ = VertexJoints8;

    public class MESH
    {
        public static void ExportMeshWithoutRig(Stream meshStream, string _meshName, string outfile, bool LodFilter = true, bool isGLBinary = true)
        {
            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();
            var cr2w = CP77.CR2W.ModTools.TryReadCr2WFile(meshStream);

            MemoryStream ms = GetMeshBufferStream(meshStream,cr2w);
            MeshesInfo meshinfo = GetMeshesinfo(cr2w);
            for(int i = 0; i < meshinfo.meshC; i ++)
            {
                if (meshinfo.LODLvl[i] != 1 && LodFilter)
                    continue;
                RawMeshContainer mesh = ContainRawMesh(ms, meshinfo.vertCounts[i], meshinfo.indCounts[i], meshinfo.vertOffsets[i], meshinfo.tx0Offsets[i], meshinfo.normalOffsets[i], meshinfo.colorOffsets[i], meshinfo.unknownOffsets[i], meshinfo.indicesOffsets[i], meshinfo.vpStrides[i], meshinfo.qScale, meshinfo.qTrans, meshinfo.weightcounts[i]);
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
            ModelRoot model = RawRigidMeshesToGLTF(expMeshes);
            if(isGLBinary)
                model.SaveGLB(outfile);
            else
                model.SaveGLTF(outfile);
        }
        public static void ExportMultiMeshWithoutRig(List<Stream> meshStreamS, List<string> _meshNameS, string outfile, bool LodFilter = true, bool isGLBinary = true)
        {
            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();

            for(int m = 0; m < meshStreamS.Count; m++)
            {
                var cr2w = CP77.CR2W.ModTools.TryReadCr2WFile(meshStreamS[m]);

                MemoryStream ms = GetMeshBufferStream(meshStreamS[m], cr2w);
                MeshesInfo meshinfo = GetMeshesinfo(cr2w);
                for (int i = 0; i < meshinfo.meshC; i++)
                {
                    if (meshinfo.LODLvl[i] != 1 && LodFilter)
                        continue;
                    RawMeshContainer mesh = ContainRawMesh(ms, meshinfo.vertCounts[i], meshinfo.indCounts[i], meshinfo.vertOffsets[i], meshinfo.tx0Offsets[i], meshinfo.normalOffsets[i], meshinfo.colorOffsets[i], meshinfo.unknownOffsets[i], meshinfo.indicesOffsets[i], meshinfo.vpStrides[i], meshinfo.qScale, meshinfo.qTrans, meshinfo.weightcounts[i]);
                    mesh.name = _meshNameS[m] + "_" + i;

                    mesh.appNames = new string[meshinfo.appearances.Count];
                    mesh.materialNames = new string[meshinfo.appearances.Count];
                    for (int e = 0; e < meshinfo.appearances.Count; e++)
                    {
                        mesh.appNames[e] = meshinfo.appearances[e].Name;
                        mesh.materialNames[e] = meshinfo.appearances[e].MaterialNames[i];
                    }
                    expMeshes.Add(mesh);
                }
            }
            ModelRoot model = RawRigidMeshesToGLTF(expMeshes);
            if (isGLBinary)
                model.SaveGLB(outfile);
            else
                model.SaveGLTF(outfile);
        }
        public static void ExportMeshWithRig(Stream meshMstream, Stream rigMStream,string _meshName,string outfile, bool LodFilter = true, bool isGLBinary = true)
        {
            RawArmature Rig = RIG.ProcessRig(rigMStream);

            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();

            var cr2w = CP77.CR2W.ModTools.TryReadCr2WFile(meshMstream);

            MemoryStream ms = GetMeshBufferStream(meshMstream, cr2w);
            MeshesInfo meshinfo = GetMeshesinfo(cr2w);

            MeshBones bones = new MeshBones();

            int last = 0;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "CMesh")
                {
                    last = i;
                }
            }
            if ((cr2w.Chunks[last].data as CMesh).BoneNames.Count != 0)    // for rigid meshes
            {
                bones.Names = RIG.GetboneNames(cr2w, "CMesh");
                bones.WorldPosn = GetMeshBonesPosn(cr2w);
            }

            for (int i = 0; i < meshinfo.meshC; i++)
            {
                if (meshinfo.LODLvl[i] != 1 && LodFilter)
                    continue;
                RawMeshContainer mesh = ContainRawMesh(ms, meshinfo.vertCounts[i], meshinfo.indCounts[i], meshinfo.vertOffsets[i], meshinfo.tx0Offsets[i], meshinfo.normalOffsets[i], meshinfo.colorOffsets[i], meshinfo.unknownOffsets[i], meshinfo.indicesOffsets[i], meshinfo.vpStrides[i], meshinfo.qScale, meshinfo.qTrans, meshinfo.weightcounts[i]);
                mesh.name = _meshName + "_" + i;
                UpdateMeshJoints(ref mesh, Rig, bones);

                mesh.appNames = new string[meshinfo.appearances.Count];
                mesh.materialNames = new string[meshinfo.appearances.Count];
                for (int e = 0; e < meshinfo.appearances.Count; e++)
                {
                    mesh.appNames[e] = meshinfo.appearances[e].Name;
                    mesh.materialNames[e] = meshinfo.appearances[e].MaterialNames[i];
                }
                expMeshes.Add(mesh);
            }

            ModelRoot model = RawSkinnedMeshesToGLTF(expMeshes,Rig);
            if (isGLBinary)
                model.SaveGLB(outfile);
            else
                model.SaveGLTF(outfile);
        }
        public static void ExportMultiMeshWithRig(List<Stream> meshStreamS, List<Stream> rigStreamS, List<string> _meshNameS,string outfile, bool LodFilter = true, bool isGLBinary = true)
        {
            List<RawArmature> Rigs = new List<RawArmature>();
            rigStreamS = rigStreamS.OrderByDescending(r => r.Length).ToList();  // not so smart hacky method to get bodybase rigs on top/ orderby descending
            for (int r = 0; r < rigStreamS.Count; r++)
            {
                RawArmature Rig = RIG.ProcessRig(rigStreamS[r]);
                Rigs.Add(Rig);
            }
            RawArmature expRig = RIG.CombineRigs(Rigs);

            List <RawMeshContainer> expMeshes = new List<RawMeshContainer>();

            for (int m = 0; m < meshStreamS.Count; m++)
            {
                BinaryReader br = new BinaryReader(meshStreamS[m]);

                var cr2w = CP77.CR2W.ModTools.TryReadCr2WFile(meshStreamS[m]);

                MemoryStream ms = GetMeshBufferStream(meshStreamS[m], cr2w);
                MeshesInfo meshinfo = GetMeshesinfo(cr2w);

                MeshBones bones = new MeshBones();

                int last = 0;
                for (int i = 0; i < cr2w.Chunks.Count; i++)
                {
                    if (cr2w.Chunks[i].REDType == "CMesh")
                    {
                        last = i;
                    }
                }
                if ((cr2w.Chunks[last].data as CMesh).BoneNames.Count != 0)    // for rigid meshes
                {
                    bones.Names = RIG.GetboneNames(cr2w, "CMesh");
                    bones.WorldPosn = GetMeshBonesPosn(cr2w);
                }

                for (int i = 0; i < meshinfo.meshC; i++)
                {
                    if (meshinfo.LODLvl[i] != 1 && LodFilter)
                        continue;
                    RawMeshContainer mesh = ContainRawMesh(ms, meshinfo.vertCounts[i], meshinfo.indCounts[i], meshinfo.vertOffsets[i], meshinfo.tx0Offsets[i], meshinfo.normalOffsets[i], meshinfo.colorOffsets[i], meshinfo.unknownOffsets[i], meshinfo.indicesOffsets[i], meshinfo.vpStrides[i], meshinfo.qScale, meshinfo.qTrans, meshinfo.weightcounts[i]);
                    mesh.name = _meshNameS[m] + "_" + i;
                    if (meshinfo.weightcounts[0] != 0)   // for static meshes
                        UpdateMeshJoints(ref mesh, expRig, bones);

                    mesh.appNames = new string[meshinfo.appearances.Count];
                    mesh.materialNames = new string[meshinfo.appearances.Count];
                    for (int e = 0; e < meshinfo.appearances.Count; e++)
                    {
                        mesh.appNames[e] = meshinfo.appearances[e].Name;
                        mesh.materialNames[e] = meshinfo.appearances[e].MaterialNames[i];
                    }
                    expMeshes.Add(mesh);
                }
            }
            ModelRoot model = RawSkinnedMeshesToGLTF(expMeshes, expRig);
            if (isGLBinary)
                model.SaveGLB(outfile);
            else
                model.SaveGLTF(outfile);
        }
        static Vec3[] GetMeshBonesPosn(CR2WFile cr2w)
        {
            int Index = 0;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "rendRenderMeshBlob")
                {
                    Index = i;
                }
            }
            int boneCount = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.BonePositions.Count;
            Vec3[] posn = new Vec3[boneCount];
            float x, y, z = 0;
            for (int i = 0; i < boneCount; i++)
            {
                x = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.BonePositions[i].X.Value;
                y = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.BonePositions[i].Y.Value;
                z = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.BonePositions[i].Z.Value;
                posn[i] = new Vec3(x, y, z);
            }
            return posn;
        }
        public static MeshesInfo GetMeshesinfo(CR2WFile cr2w)
        {
            int Index = 0;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "rendRenderMeshBlob")
                {
                    Index = i;
                }
            }
            int meshC = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos.Count;

            UInt32[] vertCounts = new UInt32[meshC];
            UInt32[] indCounts = new UInt32[meshC];
            UInt32[] vertOffsets = new UInt32[meshC];
            UInt32[] tx0Offsets = new UInt32[meshC];
            UInt32[] normalOffsets = new UInt32[meshC];
            UInt32[] colorOffsets = new UInt32[meshC];
            UInt32[] unknownOffsets = new UInt32[meshC];
            UInt32[] indicesOffsets = new UInt32[meshC];
            UInt32[] vpStrides = new UInt32[meshC];
            UInt32[] LODLvl = new UInt32[meshC];
            for (int i = 0; i < meshC; i++)
            {
                vertCounts[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].NumVertices.Value;
                indCounts[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].NumIndices.Value;
                vertOffsets[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[0].Value;
                tx0Offsets[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[1].Value;
                normalOffsets[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[2].Value;
                colorOffsets[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[3].Value;
                unknownOffsets[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[4].Value;

                if ((cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkIndices.TeOffset == null)
                {
                    indicesOffsets[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.IndexBufferOffset.Value;
                }
                else
                {
                    indicesOffsets[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.IndexBufferOffset.Value + (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkIndices.TeOffset.Value;
                }
                vpStrides[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.SlotStrides[0].Value;
                LODLvl[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].LodMask.Value;
            }
            Vector4 qSc = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.QuantizationScale;
            Vector4 qTr = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.QuantizationOffset;

            Vec4 qScale = new Vec4(qSc.X.Value, qSc.Y.Value, qSc.Z.Value, qSc.W.Value);
            Vec4 qTrans = new Vec4(qTr.X.Value, qTr.Y.Value, qTr.Z.Value, qTr.W.Value);

            // getting number of weights for the meshes
            UInt32[] weightcounts = new UInt32[meshC];
            int count = 0;
            UInt32 counter = 0;
            string checker = string.Empty;
            for (int i = 0; i < meshC; i++)
            {
                count = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements.Count;
                counter = 0;
                for (int e = 0; e < count; e++)
                {
                    checker = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements[e].Usage.EnumValueList[0];
                    if (checker == "PS_SkinIndices")
                        counter++;
                }
                weightcounts[i] = counter * 4;
            }

            List<Appearance> appearances = new List<Appearance>();
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "meshMeshAppearance")
                {
                    Appearance appearance = new Appearance();
                    appearance.Name = (cr2w.Chunks[i].data as meshMeshAppearance).Name.Value;
                    if(appearance.Name == string.Empty)
                        appearance.Name = "DEFAULT";
                    int mtCount = (cr2w.Chunks[i].data as meshMeshAppearance).ChunkMaterials.Count;
                    appearance.MaterialNames = new string[mtCount];
                    for(int e = 0; e < mtCount; e++)
                    {
                        appearance.MaterialNames[e] = (cr2w.Chunks[i].data as meshMeshAppearance).ChunkMaterials[e].Value;
                    }
                    appearances.Add(appearance);
                }
            }
            MeshesInfo meshesInfo = new MeshesInfo()
            {
                vertCounts = vertCounts,
                indCounts = indCounts,
                vertOffsets = vertOffsets,
                tx0Offsets = tx0Offsets,
                normalOffsets = normalOffsets,
                colorOffsets = colorOffsets,
                unknownOffsets = unknownOffsets,
                indicesOffsets = indicesOffsets,
                vpStrides = vpStrides,
                weightcounts = weightcounts,
                LODLvl = LODLvl,
                qScale = qScale,
                qTrans = qTrans,
                meshC = meshC,
                appearances = appearances
            };
            return meshesInfo;
        }
        public static RawMeshContainer ContainRawMesh(MemoryStream gfs, UInt32 vertCount, UInt32 indCount, UInt32 vertOffset, UInt32 tx0Offset, UInt32 normalOffset, UInt32 colorOffset, UInt32 unknownOffset, UInt32 indOffset, UInt32 vpStride, Vec4 qScale, Vec4 qTrans, UInt32 weightcount)
        {
            BinaryReader gbr = new BinaryReader(gfs);

            Vec3[] vertices = new Vec3[vertCount];
            uint[] indices = new uint[indCount];
            Vec2[] tx0coords = new Vec2[vertCount];
            Vec3[] normals = new Vec3[vertCount];
            Vec4[] tangents = new Vec4[vertCount];
            Vec4[] colors = new Vec4[vertCount];
            Vec2[] tx1coords = new Vec2[vertCount];
            float[,] weights = new float[vertCount, weightcount];
            UInt16[,] boneindices = new UInt16[vertCount, weightcount];

            // geting vertices
            for (int i = 0; i < vertCount; i++)
            {
                gfs.Position = vertOffset + i * vpStride;

                float x = (gbr.ReadInt16() / 32767f) * qScale.X + qTrans.X;
                float y = (gbr.ReadInt16() / 32767f) * qScale.Y + qTrans.Y;
                float z = (gbr.ReadInt16() / 32767f) * qScale.Z + qTrans.Z;
                vertices[i] = new Vec3(x, y, z);
            }
            // got vertices

            float[] values = new float[vertCount * 2];

            if (tx0Offset != 0)
            {
                // getting texturecoord0 as half floats
                gfs.Position = tx0Offset;
                for (int i = 0; i < vertCount * 2; i++)
                {
                    UInt16 read = gbr.ReadUInt16();
                    values[i] = Converters.hfconvert(read);
                }
                for (int i = 0; i < vertCount; i++)
                {
                    tx0coords[i] = new Vec2(values[2 * i], values[2 * i + 1]);
                }
                // got texturecoord0 as half floats
            }

            UInt32 NorRead32;
            // getting 10bit normals
            for (int i = 0; i < vertCount; i++)
            {
                gfs.Position = normalOffset + 8 * i;
                NorRead32 = gbr.ReadUInt32();
                Vec4 tempv = Converters.TenBitShifted(NorRead32);
                normals[i] = new Vec3(tempv.X, tempv.Y, tempv.Z);
            }
            // got 10bit normals

            // getting 10bit tangents
            for (int i = 0; i < vertCount; i++)
            {
                gfs.Position = normalOffset + 4 + 8 * i;
                NorRead32 = gbr.ReadUInt32();
                Vec4 tempv = Converters.TenBitShifted(NorRead32);
                tangents[i] = new Vec4(tempv.X, tempv.Y, tempv.Z, 1f);
            }


            if (colorOffset != 0)
            {
                gfs.Position = colorOffset + 4;
                // getting texturecoord1 as half floats
                for (int i = 0; i < vertCount * 2; i++)
                {
                    UInt16 read = gbr.ReadUInt16();
                    values[i] = Converters.hfconvert(read);
                    if (i % 2 != 0)
                        gfs.Position += 4;
                }
                for (int i = 0; i < vertCount; i++)
                {
                    tx1coords[i] = new Vec2(values[2 * i], values[2 * i + 1]);
                }
                // got texturecoord1 as half floats
            }

            if (colorOffset != 0)
            {
                // getting vert colors, not sure of the format TBH RN,just a hush, may not work, lulz
                for (int i = 0; i < vertCount; i++)
                {
                    gfs.Position = colorOffset + i * 8;
                    Vec4 tempv = new Vec4(gbr.ReadByte() / 255f, gbr.ReadByte() / 255f, gbr.ReadByte() / 255f, gbr.ReadByte() / 255f);
                    colors[i] = new Vec4(tempv.X, tempv.Y, tempv.Z, tempv.W);
                }
                // got vert colors
            }

            // getting bone indices
            for (int i = 0; i < vertCount; i++)
            {
                gfs.Position = vertOffset + i * vpStride + 8;
                for (int e = 0; e < weightcount; e++)
                {
                    boneindices[i, e] = gbr.ReadByte();
                }
            }
            // got bone indexes

            // getting weights
            for (int i = 0; i < vertCount; i++)
            {
                gfs.Position = vertOffset + i * vpStride + 8 + weightcount;
                for (int e = 0; e < weightcount; e++)
                {
                    weights[i, e] = gbr.ReadByte() / 255f;
                }
            }
            // got weights

            // getting uint16 faces/indices
            gfs.Position = indOffset;
            for (int i = 0; i < indCount; i++)
            {
                indices[i] = gbr.ReadUInt16();
            }
            // got uint16 faces/indices

            RawMeshContainer mesh = new RawMeshContainer()
            {
                vertices = vertices,
                indices = indices,
                tx0coords = tx0coords,
                normals = normals,
                tangents = tangents,
                colors = colors,
                tx1coords = tx1coords,
                boneindices = boneindices,
                weights = weights,
                weightcount = weightcount
            };
            return mesh;
        }

        static void UpdateMeshJoints(ref RawMeshContainer Mesh, RawArmature Rig, MeshBones Bones)
        {
            // updating mesh bone indexes
            for (int e = 0; e < Mesh.vertices.Length; e++)
            {
                for (int eye = 0; eye < Mesh.weightcount; eye++)
                {
                    for (UInt16 r = 0; r < Rig.BoneCount; r++)
                    {
                        if (Rig.Names[r] == Bones.Names[Mesh.boneindices[e, eye]])
                        {
                            Mesh.boneindices[e, eye] = r;
                            break;
                        }
                    }
                }
            }

        }
        public static MemoryStream GetMeshBufferStream(Stream ms, CR2WFile cr2w)
        {
            MemoryStream meshstream = new MemoryStream();
            var buffers = cr2w.Buffers;
            for (var i = 0; i < buffers.Count; i++)
            {
                var b = buffers[i];
                ms.Seek(b.Offset, SeekOrigin.Begin);

                MemoryStream outstream = new MemoryStream();
                // copy to some outstream
                ms.DecompressAndCopySegment(outstream, b.DiskSize, b.MemSize);

                BinaryReader outreader = new BinaryReader(outstream);
                outstream.Position = 6;
                if (outreader.ReadInt16() == Int16.MaxValue)
                {
                    meshstream = outstream;
                    break;
                }
            }
            return meshstream;
        }
        static ModelRoot RawSkinnedMeshesToGLTF(List<RawMeshContainer> meshes,RawArmature Rig)
        {
            var scene = new SceneBuilder();

            var bones = RIG.ExportNodes(Rig);
            var rootbone = bones.Values.Where(n => n.Parent == null).FirstOrDefault();

            foreach (var mesh in meshes)
            {
                long indCount = mesh.indices.Length;
                var expmesh = new SKINNEDMESH(mesh.name);

                var prim = expmesh.UsePrimitive(new MaterialBuilder("Default"));
                for (int i = 0; i < indCount; i += 3)
                {
                    uint idx0 = mesh.indices[i + 1];
                    uint idx1 = mesh.indices[i];
                    uint idx2 = mesh.indices[i + 2];

                    //VPNT
                    Vec3 p_0 = new Vec3(mesh.vertices[idx0].X, mesh.vertices[idx0].Y, mesh.vertices[idx0].Z);
                    Vec3 n_0 = new Vec3(mesh.normals[idx0].X, mesh.normals[idx0].Y, mesh.normals[idx0].Z);
                    Vec4 t_0 = new Vec4(mesh.tangents[idx0].X, mesh.tangents[idx0].Y, mesh.tangents[idx0].Z, mesh.tangents[idx0].W);

                    Vec3 p_1 = new Vec3(mesh.vertices[idx1].X, mesh.vertices[idx1].Y, mesh.vertices[idx1].Z);
                    Vec3 n_1 = new Vec3(mesh.normals[idx1].X, mesh.normals[idx1].Y, mesh.normals[idx1].Z);
                    Vec4 t_1 = new Vec4(mesh.tangents[idx1].X, mesh.tangents[idx1].Y, mesh.tangents[idx1].Z, mesh.tangents[idx1].W);

                    Vec3 p_2 = new Vec3(mesh.vertices[idx2].X, mesh.vertices[idx2].Y, mesh.vertices[idx2].Z);
                    Vec3 n_2 = new Vec3(mesh.normals[idx2].X, mesh.normals[idx2].Y, mesh.normals[idx2].Z);
                    Vec4 t_2 = new Vec4(mesh.tangents[idx2].X, mesh.tangents[idx2].Y, mesh.tangents[idx2].Z, mesh.tangents[idx2].W);

                    //VCT
                    Vec2 tx0_0 = new Vec2(mesh.tx0coords[idx0].X, mesh.tx0coords[idx0].Y);
                    Vec2 tx1_0 = new Vec2(mesh.tx1coords[idx0].X, mesh.tx1coords[idx0].Y);

                    Vec2 tx0_1 = new Vec2(mesh.tx0coords[idx1].X, mesh.tx0coords[idx1].Y);
                    Vec2 tx1_1 = new Vec2(mesh.tx1coords[idx1].X, mesh.tx1coords[idx1].Y);

                    Vec2 tx0_2 = new Vec2(mesh.tx0coords[idx2].X, mesh.tx0coords[idx2].Y);
                    Vec2 tx1_2 = new Vec2(mesh.tx1coords[idx2].X, mesh.tx1coords[idx2].Y);

                    Vec4 col_0 = new Vec4(mesh.colors[idx0].X, mesh.colors[idx0].Y, mesh.colors[idx0].Z, mesh.colors[idx0].W);
                    Vec4 col_1 = new Vec4(mesh.colors[idx1].X, mesh.colors[idx1].Y, mesh.colors[idx1].Z, mesh.colors[idx1].W);
                    Vec4 col_2 = new Vec4(mesh.colors[idx2].X, mesh.colors[idx2].Y, mesh.colors[idx2].Z, mesh.colors[idx2].W);

                    
                    (int, float)[] bind0 = new (int, float)[8];
                    (int, float)[] bind1 = new (int, float)[8];
                    (int, float)[] bind2 = new (int, float)[8];

                    if(mesh.weightcount == 0)   // for rigid meshes
                    {
                        bind0[0].Item2 = 1f;
                        bind1[0].Item2 = 1f;
                        bind2[0].Item2 = 1f;
                    }

                    for (int w = 0; w < mesh.weightcount ; w++)
                    {
                        bind0[w].Item1 = mesh.boneindices[idx0, w];
                        bind0[w].Item2 = mesh.weights[idx0, w];
                        bind1[w].Item1 = mesh.boneindices[idx1, w];
                        bind1[w].Item2 = mesh.weights[idx1, w];
                        bind2[w].Item1 = mesh.boneindices[idx2, w];
                        bind2[w].Item2 = mesh.weights[idx2, w];
                    }
                    // vertex build
                    var v0 = new SKINNEDVERTEX(new VPNT(p_0, n_0, t_0), new VCT(col_0, tx0_0, tx1_0), new VJ(bind0));
                    var v1 = new SKINNEDVERTEX(new VPNT(p_1, n_1, t_1), new VCT(col_1, tx0_1, tx1_1), new VJ(bind1));
                    var v2 = new SKINNEDVERTEX(new VPNT(p_2, n_2, t_2), new VCT(col_2, tx0_2, tx1_2), new VJ(bind2));
                    // triangle build
                    prim.AddTriangle(v0, v1, v2);
                }
                scene.AddSkinnedMesh(expmesh,rootbone.WorldMatrix, bones.Values.ToArray());
            }
            var model = scene.ToGltf2();

            return model;
        }
        static ModelRoot RawRigidMeshesToGLTF(List<RawMeshContainer> meshes)
        {
            var scene = new SceneBuilder();

            foreach (var mesh in meshes)
            {
                long indCount = mesh.indices.Length;
                var expmesh = new RIGIDMESH(mesh.name);

                var prim = expmesh.UsePrimitive(new MaterialBuilder("Default"));
                for (int i = 0; i < indCount; i += 3)
                {
                    uint idx0 = mesh.indices[i + 1];
                    uint idx1 = mesh.indices[i];
                    uint idx2 = mesh.indices[i + 2];

                    //VPNT
                    Vec3 p_0 = new Vec3(mesh.vertices[idx0].X, mesh.vertices[idx0].Y, mesh.vertices[idx0].Z);
                    Vec3 n_0 = new Vec3(mesh.normals[idx0].X, mesh.normals[idx0].Y, mesh.normals[idx0].Z);
                    Vec4 t_0 = new Vec4(mesh.tangents[idx0].X, mesh.tangents[idx0].Y, mesh.tangents[idx0].Z, mesh.tangents[idx0].W);

                    Vec3 p_1 = new Vec3(mesh.vertices[idx1].X, mesh.vertices[idx1].Y, mesh.vertices[idx1].Z);
                    Vec3 n_1 = new Vec3(mesh.normals[idx1].X, mesh.normals[idx1].Y, mesh.normals[idx1].Z);
                    Vec4 t_1 = new Vec4(mesh.tangents[idx1].X, mesh.tangents[idx1].Y, mesh.tangents[idx1].Z, mesh.tangents[idx1].W);

                    Vec3 p_2 = new Vec3(mesh.vertices[idx2].X, mesh.vertices[idx2].Y, mesh.vertices[idx2].Z);
                    Vec3 n_2 = new Vec3(mesh.normals[idx2].X, mesh.normals[idx2].Y, mesh.normals[idx2].Z);
                    Vec4 t_2 = new Vec4(mesh.tangents[idx2].X, mesh.tangents[idx2].Y, mesh.tangents[idx2].Z, mesh.tangents[idx2].W);

                    //VCT
                    Vec2 tx0_0 = new Vec2(mesh.tx0coords[idx0].X, mesh.tx0coords[idx0].Y);
                    Vec2 tx1_0 = new Vec2(mesh.tx1coords[idx0].X, mesh.tx1coords[idx0].Y);

                    Vec2 tx0_1 = new Vec2(mesh.tx0coords[idx1].X, mesh.tx0coords[idx1].Y);
                    Vec2 tx1_1 = new Vec2(mesh.tx1coords[idx1].X, mesh.tx1coords[idx1].Y);

                    Vec2 tx0_2 = new Vec2(mesh.tx0coords[idx2].X, mesh.tx0coords[idx2].Y);
                    Vec2 tx1_2 = new Vec2(mesh.tx1coords[idx2].X, mesh.tx1coords[idx2].Y);

                    Vec4 col_0 = new Vec4(mesh.colors[idx0].X, mesh.colors[idx0].Y, mesh.colors[idx0].Z, mesh.colors[idx0].W);
                    Vec4 col_1 = new Vec4(mesh.colors[idx1].X, mesh.colors[idx1].Y, mesh.colors[idx1].Z, mesh.colors[idx1].W);
                    Vec4 col_2 = new Vec4(mesh.colors[idx2].X, mesh.colors[idx2].Y, mesh.colors[idx2].Z, mesh.colors[idx2].W);

                    // vertex build
                    var v0 = new RIGIDVERTEX(new VPNT(p_0, n_0, t_0), new VCT(col_0, tx0_0, tx1_0));
                    var v1 = new RIGIDVERTEX(new VPNT(p_1, n_1, t_1), new VCT(col_1, tx0_1, tx1_1));
                    var v2 = new RIGIDVERTEX(new VPNT(p_2, n_2, t_2), new VCT(col_2, tx0_2, tx1_2));
                    // triangle build
                    prim.AddTriangle(v0, v1, v2);
                }
                scene.AddRigidMesh(expmesh, System.Numerics.Matrix4x4.CreateFromQuaternion(new System.Numerics.Quaternion((float)-0.707107, 0, 0, (float)0.707107))); // to rotate mesh +Z up in blender
            }
            var model = scene.ToGltf2();
            return model;
        }

        class MeshBones
        {
            public string[] Names;
            public Vec3[] WorldPosn;
        }
    }
}
