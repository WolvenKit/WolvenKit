using System;
using System.IO;
using System.Collections.Generic;
using WolvenKit.RED4.CR2W.Types;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Materials;
using WolvenKit.RED4.CR2W;

namespace CP77.CR2W.Uncooker
{
    using Vec4 = System.Numerics.Vector4;
    using Vec3 = System.Numerics.Vector3;
    using Vec2 = System.Numerics.Vector2;
    using VERTEX = VertexBuilder<VertexPositionNormalTangent, VertexColor1Texture2, VertexEmpty>;
    using MESH = MeshBuilder<VertexPositionNormalTangent, VertexColor1Texture2, VertexEmpty>;
    using VPNT = VertexPositionNormalTangent;
    using VCT = VertexColor1Texture2;

    public static class Mesh
    {
        public static void ParseMesh(CR2WFile cr2w, List<byte[]> buffers, FileInfo outfile)
        {
            int meshbufferindex = Getmeshbufferindex(buffers);
            MeshesInfo meshesInfo = GetMeshesinfo(cr2w);
            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();
            MemoryStream gms = new MemoryStream(buffers[meshbufferindex]);

            for(int i = 0; i < meshesInfo.meshC; i++)
            {
                if(meshesInfo.LODLvl[i] == 1)
                expMeshes.Add(ContainRawMesh(gms, meshesInfo.vertCounts[i], meshesInfo.indCounts[i], meshesInfo.vertOffsets[i], meshesInfo.tx0Offsets[i], meshesInfo.normalOffsets[i], meshesInfo.colorOffsets[i], meshesInfo.tx1Offsets[i], meshesInfo.indicesOffsets[i], meshesInfo.vpStrides[i], meshesInfo.qScale, meshesInfo.qTrans));
            }
            ContainedMeshToGLTF(expMeshes, outfile);
        }
        
        private static int Getmeshbufferindex(List<byte[]> buffers)
        {
            int meshbufferindex = int.MaxValue;
            for (int i = 0; i < buffers.Count; i++)
            {
                MemoryStream bms = new MemoryStream(buffers[i]);
                BinaryReader bbr = new BinaryReader(bms);
                bms.Position = 6;

                if (bbr.ReadInt16() == Int16.MaxValue)
                {
                    meshbufferindex = i;
                    break;
                }
            }
            return meshbufferindex;
        }
        private static MeshesInfo GetMeshesinfo(CR2WFile cr2w)
        {
            int Index = int.MaxValue;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "rendRenderMeshBlob")
                {
                    Index = i;
                }
            }
            int meshC = (cr2w.Chunks[Index].Data as rendRenderMeshBlob).Header.RenderChunkInfos.Count;

            UInt32[] vertCounts = new UInt32[meshC];
            UInt32[] indCounts = new UInt32[meshC];
            UInt32[] vertOffsets = new UInt32[meshC];
            UInt32[] tx0Offsets = new UInt32[meshC];
            UInt32[] normalOffsets = new UInt32[meshC];
            UInt32[] colorOffsets = new UInt32[meshC];
            UInt32[] tx1Offsets = new UInt32[meshC];
            UInt32[] indicesOffsets = new UInt32[meshC];
            UInt32[] vpStrides = new UInt32[meshC];
            UInt32[] LODLvl = new UInt32[meshC];
            for (int i = 0; i < meshC; i++)
            {
                vertCounts[i] = (cr2w.Chunks[Index].Data as rendRenderMeshBlob).Header.RenderChunkInfos[i].NumVertices.Value;
                indCounts[i] = (cr2w.Chunks[Index].Data as rendRenderMeshBlob).Header.RenderChunkInfos[i].NumIndices.Value;
                vertOffsets[i] = (cr2w.Chunks[Index].Data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[0].Value;
                tx0Offsets[i] = (cr2w.Chunks[Index].Data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[1].Value;
                normalOffsets[i] = (cr2w.Chunks[Index].Data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[2].Value;
                colorOffsets[i] = (cr2w.Chunks[Index].Data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[3].Value;
                tx1Offsets[i] = (cr2w.Chunks[Index].Data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[4].Value;

                if ((cr2w.Chunks[Index].Data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkIndices.TeOffset == null)
                {
                    indicesOffsets[i] = (cr2w.Chunks[Index].Data as rendRenderMeshBlob).Header.IndexBufferOffset.Value;
                }
                else
                {
                    indicesOffsets[i] = (cr2w.Chunks[Index].Data as rendRenderMeshBlob).Header.IndexBufferOffset.Value + (cr2w.Chunks[Index].Data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkIndices.TeOffset.Value;
                }
                vpStrides[i] = (cr2w.Chunks[Index].Data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.SlotStrides[0].Value;
                LODLvl[i] = (cr2w.Chunks[Index].Data as rendRenderMeshBlob).Header.RenderChunkInfos[i].LodMask.Value;
            }
            Vector4 qScale = (cr2w.Chunks[Index].Data as rendRenderMeshBlob).Header.QuantizationScale;
            Vector4 qTrans = (cr2w.Chunks[Index].Data as rendRenderMeshBlob).Header.QuantizationOffset;

            MeshesInfo meshesInfo = new MeshesInfo()
            {
                vertCounts = vertCounts,
                indCounts = indCounts,
                vertOffsets = vertOffsets,
                tx0Offsets = tx0Offsets,
                normalOffsets = normalOffsets,
                colorOffsets = colorOffsets,
                tx1Offsets = tx1Offsets,
                indicesOffsets = indicesOffsets,
                vpStrides = vpStrides,
                LODLvl = LODLvl,
                qScale = qScale,
                qTrans = qTrans,
                meshC = meshC
            };
            return meshesInfo;
        }
        private static RawMeshContainer ContainRawMesh(MemoryStream gfs, UInt32 vertCount, UInt32 indCount, UInt32 vertOffset, UInt32 tx0Offset, UInt32 normalOffset, UInt32 colorOffset, UInt32 tx1Offset, UInt32 indOffset, UInt32 vpStride, Vector4 qScale, Vector4 qTrans)
        {
            BinaryReader gbr = new BinaryReader(gfs);

            Vec3[] vertices = new Vec3[vertCount];
            uint[] indices = new uint[indCount];
            Vec2[] tx0coords = new Vec2[vertCount];
            Vec3[] normals = new Vec3[vertCount];
            Vec4[] tangents = new Vec4[vertCount];
            Vec4[] colors = new Vec4[vertCount];
            Vec2[] tx1coords = new Vec2[vertCount];

            // geting vertices
            for (int i = 0; i < vertCount; i++)
            {
                gfs.Position = vertOffset + i * vpStride;

                float x = (gbr.ReadInt16() / 32767f) * qScale.X.Value + qTrans.X.Value;
                float y = (gbr.ReadInt16() / 32767f) * qScale.Y.Value + qTrans.Y.Value;
                float z = (gbr.ReadInt16() / 32767f) * qScale.Z.Value + qTrans.Z.Value;
                vertices[i] = new Vec3(x, y, z);
            }
            // got vertices

            Converters converter = new Converters(); // contains methods for halffloats
            float[] values = new float[vertCount * 2];

            if (tx0Offset != 0)
            {
                // getting texturecoord0 as half floats
                gfs.Position = tx0Offset;
                for (int i = 0; i < vertCount * 2; i++)
                {
                    UInt16 read = gbr.ReadUInt16();
                    values[i] = converter.hfconvert(read);
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
                Vec4 tempv = converter.U32toVec4(NorRead32);
                normals[i] = new Vec3(tempv.X,tempv.Y,tempv.Z);
            }
            // got 10bit normals

            // getting 10bit tangents
            for (int i = 0; i < vertCount; i++)
            {
                gfs.Position = normalOffset + 4 + 8 * i;
                NorRead32 = gbr.ReadUInt32();
                Vec4 tempv = converter.U32toVec4(NorRead32);
                tangents[i] = new Vec4(tempv.X, tempv.Y, tempv.Z, 1f);
            }


            if (tx1Offset != 0)
            {
                // getting texturecoord1 as half floats
                gfs.Position = tx1Offset;
                for (int i = 0; i < vertCount * 2; i++)
                {
                    UInt16 read = gbr.ReadUInt16();
                    values[i] = converter.hfconvert(read);
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
                    gfs.Position = colorOffset + i*8;
                    Vec4 tempv = new Vec4(gbr.ReadUInt16()/65535f, gbr.ReadUInt16()/65535f, gbr.ReadUInt16()/65535f, gbr.ReadUInt16()/65535f);
                    colors[i] = new Vec4(tempv.Y, tempv.Z, tempv.W,tempv.X);
                }
                // got vert colors
            }

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
                tx1coords = tx1coords
            };
            return mesh;
        }
        private static void ContainedMeshToGLTF(List<RawMeshContainer> meshes, FileInfo outfile)
        {
            var scene = new SharpGLTF.Scenes.SceneBuilder();

            int mIndex = -1;
            foreach (var mesh in meshes)
            {
                ++mIndex;
                long indCount = mesh.indices.Length;
                var expmesh = new MESH(string.Format(Path.GetFileNameWithoutExtension(outfile.FullName) + "_mesh_{0}",mIndex));

                var prim = expmesh.UsePrimitive(new MaterialBuilder("Default"));
                for (long i = 0; i < indCount; i += 3)
                {
                    uint idx0 = mesh.indices[i + 1];
                    uint idx1 = mesh.indices[i];
                    uint idx2 = mesh.indices[i + 2];

                    //VPNT
                    Vec3 p_0 = new Vec3(mesh.vertices[idx0].X, mesh.vertices[idx0].Y, mesh.vertices[idx0].Z);
                    Vec3 n_0 = new Vec3(mesh.normals[idx0].X, mesh.normals[idx0].Y, mesh.normals[idx0].Z);
                    Vec4 t_0 = new Vec4(new Vec3(mesh.tangents[idx0].X, mesh.tangents[idx0].Y, mesh.tangents[idx0].Z), 1);

                    Vec3 p_1 = new Vec3(mesh.vertices[idx1].X, mesh.vertices[idx1].Y, mesh.vertices[idx1].Z);
                    Vec3 n_1 = new Vec3(mesh.normals[idx1].X, mesh.normals[idx1].Y, mesh.normals[idx1].Z);
                    Vec4 t_1 = new Vec4(new Vec3(mesh.tangents[idx1].X, mesh.tangents[idx1].Y, mesh.tangents[idx1].Z), 1);

                    Vec3 p_2 = new Vec3(mesh.vertices[idx2].X, mesh.vertices[idx2].Y, mesh.vertices[idx2].Z);
                    Vec3 n_2 = new Vec3(mesh.normals[idx2].X, mesh.normals[idx2].Y, mesh.normals[idx2].Z);
                    Vec4 t_2 = new Vec4(new Vec3(mesh.tangents[idx2].X, mesh.tangents[idx2].Y, mesh.tangents[idx2].Z), 1);

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
                    var v0 = new VERTEX(new VPNT(p_0, n_0, t_0),new VCT(col_0,tx0_0,tx1_0));
                    var v1 = new VERTEX(new VPNT(p_1, n_1, t_1), new VCT(col_1, tx0_1, tx1_1));
                    var v2 = new VERTEX(new VPNT(p_2, n_2, t_2), new VCT(col_2, tx0_2, tx1_2));
                    
                    // triangle build
                    prim.AddTriangle(v0, v1, v2);
                }
                scene.AddRigidMesh(expmesh,System.Numerics.Matrix4x4.Identity);
            }

            var model = scene.ToGltf2();
            model.SaveGLB(Path.GetFullPath(outfile.FullName).Replace(".mesh", ".glb"));
        }
        class RawMeshContainer
        {
            public Vec3[] vertices { get; set; }
            public uint[] indices { get; set; }
            public Vec2[] tx0coords { get; set; }
            public Vec2[] tx1coords { get; set; }
            public Vec3[] normals { get; set; }
            public Vec4[] tangents { get; set; }
            public Vec4[] colors { get; set; }
        }
        class MeshesInfo
        {
            public UInt32[] vertCounts { get; set; }
            public UInt32[] indCounts { get; set; }
            public UInt32[] vertOffsets { get; set; }
            public UInt32[] tx0Offsets { get; set; }
            public UInt32[] normalOffsets { get; set; }
            public UInt32[] colorOffsets { get; set; }
            public UInt32[] tx1Offsets { get; set; }
            public UInt32[] indicesOffsets { get; set; }
            public UInt32[] vpStrides { get; set; }
            public Vector4 qTrans { get; set; }
            public Vector4 qScale { get; set; }
            public int meshC { get; set; }
            public UInt32[] LODLvl { get; set; }
        }
        
    }
    public class Converters
    {
        public float hfconvert(UInt16 read)// for converting ushort representation of a Half float to a float32
        {
            String bin = Convert.ToString(read, 2).PadLeft(16, '0');
            UInt16 sp = Convert.ToUInt16(bin.Substring(6, 10), 2);
            UInt16 pow = Convert.ToUInt16(bin.Substring(1, 5), 2);
            UInt16 sign = Convert.ToUInt16(bin.Substring(0, 1));

            float value = 0f;
            if (pow == 0)
            {
                value = Convert.ToSingle(Math.Pow(2, -14)) * (sp / 1024f);
            }
            else if (pow == 31)
            {
                if (sp == 0)
                    value = float.PositiveInfinity;
                else
                    value = float.NaN;
            }
            else
            {
                value = Convert.ToSingle(Math.Pow(2, pow - 15)) * (1 + sp / 1024f);
            }

            if (sign == 1)
            {
                value = (-1) * value;
            }

            return value;
        }
        public UInt16 converthf(float value) // a floating point to halffloat uint16 equivalent representation -65504 <= value <= 65504
        {
            UInt16 sign = 0;
            UInt16 sp = 0;
            UInt16 pow = 0;
            if (float.IsNegative(value) && !float.IsNaN(value))
            {
                sign = 32768;
                value = -1 * value;
            }
            if (value > 65504)
            {
                value = 65504;      // if number provided is > Half.Max or < Half.Min then normalized
            }
            if (value >= 0 && value <= (float)0.000060975552)
            {
                pow = 0;
                sp = Convert.ToUInt16(value * 1024 * Math.Pow(2, 14));
            }
            else if (float.IsNaN(value) || float.IsPositiveInfinity(value))
            {
                sp = 0;
                pow = 31744;
                if (float.IsNaN(value))
                    sp = 55; // sp can be anything in this case i randomly put 55
            }
            else if (value >= (float)0.00006103515625 && value <= (float)65504)
            {
                Int16 temp1 = 14;
                UInt64 temp2 = Convert.ToUInt64((value * Math.Pow(2, temp1) - 1) * 1024);
                for (; temp2 > 1023; temp1--)
                {
                    temp2 = Convert.ToUInt64((value * Math.Pow(2, temp1 - 1) - 1) * 1024);
                }
                sp = Convert.ToUInt16(temp2);
                UInt16 temp3 = Convert.ToUInt16((-1 * temp1) + 15);
                pow = Convert.ToUInt16(temp3 << 10);
            }
            UInt16 U16 = Convert.ToUInt16(sign | sp | pow);
            return U16;
        }
        public Vec4 U32toVec4(UInt32 U32)
        {
            Int16 X = Convert.ToInt16(U32 & 0x3ff);
            Int16 Y = Convert.ToInt16((U32 >> 10) & 0x3ff);
            Int16 Z = Convert.ToInt16((U32 >> 20) & 0x3ff);
            byte W = Convert.ToByte((U32) >> 30);
            return new Vec4((X - 512) / 512f, (Y - 512) / 512f, (Z - 512) / 512f, W/3f);
        }
    }
}
