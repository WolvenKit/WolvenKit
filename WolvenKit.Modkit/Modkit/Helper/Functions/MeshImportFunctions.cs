using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using WolvenKit.RED4.GeneralStructs;
using SharpGLTF.Schema2;
using SharpGLTF.IO;
using WolvenKit.RED4.RigFile;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.RED4.CR2W;
using CP77.CR2W;

namespace WolvenKit.RED4.MeshFile
{
    using Vec4 = System.Numerics.Vector4;
    using Vec2 = System.Numerics.Vector2;
    using Vec3 = System.Numerics.Vector3;
    public class MESHIMPORTER
    {
        public static void Import(FileInfo inGltfFile, Stream inmeshStream, FileInfo outMeshFile)
        {
            var model = ModelRoot.Load(inGltfFile.FullName);

            VerifyGLTF(model);

            var cr2w = CP77.CR2W.ModTools.TryReadCr2WFile(inmeshStream);
            List<RawMeshContainer> Meshes = new List<RawMeshContainer>();

            for (int i = 0; i < model.LogicalMeshes.Count; i++)
            {
                Meshes.Add(GltfMeshToRawContainer(model.LogicalMeshes[i]));
            }
            Vec3 max = new Vec3(Meshes[0].vertices[0].X, Meshes[0].vertices[0].Y, Meshes[0].vertices[0].Z);
            Vec3 min = new Vec3(Meshes[0].vertices[0].X, Meshes[0].vertices[0].Y, Meshes[0].vertices[0].Z);

            for(int e = 0; e < Meshes.Count; e++)
                for (int i = 0; i < Meshes[e].vertices.Length; i++)
                {
                    if (Meshes[e].vertices[i].X >= max.X)
                        max.X = Meshes[e].vertices[i].X;
                    if (Meshes[e].vertices[i].Y >= max.Y)
                        max.Y = Meshes[e].vertices[i].Y;
                    if (Meshes[e].vertices[i].Z >= max.Z)
                        max.Z = Meshes[e].vertices[i].Z;
                    if (Meshes[e].vertices[i].X <= min.X)
                        min.X = Meshes[e].vertices[i].X;
                    if (Meshes[e].vertices[i].Y <= min.Y)
                        min.Y = Meshes[e].vertices[i].Y;
                    if (Meshes[e].vertices[i].Z <= min.Z)
                        min.Z = Meshes[e].vertices[i].Z;
                }


            // updating bounding box
            int Index = 0;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "CMesh")
                {
                    Index = i;
                }

            }
            (cr2w.Chunks[Index].data as CMesh).BoundingBox.Min.X.Value = min.X;
            (cr2w.Chunks[Index].data as CMesh).BoundingBox.Min.Y.Value = min.Y;
            (cr2w.Chunks[Index].data as CMesh).BoundingBox.Min.Z.Value = min.Z;
            (cr2w.Chunks[Index].data as CMesh).BoundingBox.Max.X.Value = max.X;
            (cr2w.Chunks[Index].data as CMesh).BoundingBox.Max.Y.Value = max.Y;
            (cr2w.Chunks[Index].data as CMesh).BoundingBox.Max.Z.Value = max.Z;
            // bounding box updated

            Vec4 QuantScale = new Vec4((max.X - min.X) / 2, (max.Y - min.Y) / 2, (max.Z - min.Z) / 2, 0);
            Vec4 QuantTrans = new Vec4((max.X + min.X) / 2, (max.Y + min.Y) / 2, (max.Z + min.Z) / 2, 1);

            string[] bones = new string[model.LogicalSkins[0].JointsCount];
            for (int i = 0; i < model.LogicalSkins[0].JointsCount; i++)
                bones[i] = model.LogicalSkins[0].GetJoint(i).Joint.Name;

            string[] meshbones = RIG.GetboneNames(cr2w, "CMesh");

            // reset vertex joint indices according to original
            for (int i = 0; i < Meshes.Count; i++)
                for(int e = 0; e < Meshes[i].vertices.Length; e++)
                    for(int eye = 0; eye < Meshes[i].weightcount; eye++)
                    {
                        if(Meshes[i].weights[e, eye] != 0)
                        {
                            bool existsInMeshBones = false;
                            string name = bones[Meshes[i].boneindices[e, eye]];
                            for (UInt16 t = 0; t < meshbones.Length; t++)
                            {
                                if (name == meshbones[t])
                                {
                                    Meshes[i].boneindices[e, eye] = t;
                                    existsInMeshBones = true;
                                }
                            }
                            if (!existsInMeshBones)
                            {
                                throw new Exception("One or more vertices in submesh: " + Meshes[i].name + " was weight Painted to bone: " + name + " Which Doesn't Exist in the provided .mesh file");
                            }
                        }
                        else
                        {
                            if(Meshes[i].boneindices[e, eye] > 255)
                            {
                                Meshes[i].boneindices[e, eye] = 0;
                            }
                        }
                    }

            List<Re4MeshContainer> expMeshes = new List<Re4MeshContainer>();

            for (int i = 0; i < Meshes.Count; i++)
                expMeshes.Add(RawMeshToRE4Mesh(Meshes[i],QuantScale,QuantTrans));

            MemoryStream meshBuffer = new MemoryStream();
            MeshesInfo meshesInfo = BufferWriter(expMeshes, ref meshBuffer);

            meshesInfo.qScale = QuantScale;
            meshesInfo.qTrans = QuantTrans;

            MemoryStream ms = GetEditedCr2wFile(cr2w, meshesInfo, meshBuffer);
            File.WriteAllBytes(outMeshFile.FullName, ms.ToArray());

            inmeshStream.Dispose();
            inmeshStream.Close();
        }
        static RawMeshContainer GltfMeshToRawContainer(Mesh mesh)
        {

            List<string> accessors = mesh.Primitives[0].VertexAccessors.Keys.ToList();

            List<uint> indicesList = mesh.Primitives[0].GetIndices().ToList();

            uint[] indices = new uint[indicesList.Count];

            // ReSwapping the faces
            for(int i = 0; i < indicesList.Count; i+= 3)
            {
                indices[i] = indicesList[i + 1];
                indices[i + 1] = indicesList[i];
                indices[i + 2] = indicesList[i + 2];
            }

            List<Vec3> verticesList = mesh.Primitives[0].GetVertices("POSITION").AsVector3Array().ToList();
            List<Vec3> normalsList = mesh.Primitives[0].GetVertices("NORMAL").AsVector3Array().ToList();
            List<Vec4> tangentsList = mesh.Primitives[0].GetVertices("TANGENT").AsVector4Array().ToList();

            int vertCount = verticesList.Count;
            Vec3[] vertices = new Vec3[verticesList.Count];
            Vec3[] normals = new Vec3[normalsList.Count];
            Vec4[] tangents = new Vec4[tangentsList.Count];

            // changing orientation of geomerty, Y+ Z+ RHS-LHS BS
            for (int i = 0; i < vertCount; i++)
            {
                vertices[i] = new Vec3(verticesList[i].X, -verticesList[i].Z, verticesList[i].Y);
                normals[i] = new Vec3(normalsList[i].X, -normalsList[i].Z, normalsList[i].Y);
                tangents[i] = new Vec4(tangentsList[i].X, -tangentsList[i].Z, tangentsList[i].Y, tangentsList[i].W);
            }

            Vec4[] colors = new Vec4[vertCount];
            if (accessors.Contains("COLOR_0"))
                colors = mesh.Primitives[0].GetVertices("COLOR_0").AsVector4Array().ToArray();

            Vec2[] tx0coords = new Vec2[vertCount];
            if (accessors.Contains("TEXCOORD_0"))
                tx0coords = mesh.Primitives[0].GetVertices("TEXCOORD_0").AsVector2Array().ToArray();

            Vec2[] tx1coords = new Vec2[vertCount];
            if (accessors.Contains("TEXCOORD_1"))
                tx1coords = mesh.Primitives[0].GetVertices("TEXCOORD_1").AsVector2Array().ToArray();

            List<Vec4> joints0 = new List<Vec4>();
            if (accessors.Contains("JOINTS_0"))
                joints0 = mesh.Primitives[0].GetVertices("JOINTS_0").AsVector4Array().ToList();

            List<Vec4> joints1 = new List<Vec4>();
            if (accessors.Contains("JOINTS_1"))
                joints1 = mesh.Primitives[0].GetVertices("JOINTS_1").AsVector4Array().ToList();

            List<Vec4> weights0 = new List<Vec4>();
            if (accessors.Contains("WEIGHTS_0"))
                weights0 = mesh.Primitives[0].GetVertices("WEIGHTS_0").AsVector4Array().ToList();

            List<Vec4> weights1 = new List<Vec4>();
            if (accessors.Contains("WEIGHTS_1"))
                weights1 = mesh.Primitives[0].GetVertices("WEIGHTS_1").AsVector4Array().ToList();

            UInt32 weightcount = 0;

            if (joints0.Count != 0)
                weightcount += 4;
            if (joints1.Count != 0)
                weightcount += 4;


            UInt16[,] boneindices = new UInt16[vertCount, weightcount];
            float[,] weights = new float[vertCount, weightcount];

            for (int i = 0; i < vertCount; i++)
            {
                if (joints0.Count != 0)
                {
                    boneindices[i, 0] = (UInt16)joints0[i].X;
                    boneindices[i, 1] = (UInt16)joints0[i].Y;
                    boneindices[i, 2] = (UInt16)joints0[i].Z;
                    boneindices[i, 3] = (UInt16)joints0[i].W;

                    weights[i, 0] = weights0[i].X;
                    weights[i, 1] = weights0[i].Y;
                    weights[i, 2] = weights0[i].Z;
                    weights[i, 3] = weights0[i].W;
                }
                if (joints1.Count != 0)
                {
                    boneindices[i, 4] = (UInt16)joints1[i].X;
                    boneindices[i, 5] = (UInt16)joints1[i].Y;
                    boneindices[i, 6] = (UInt16)joints1[i].Z;
                    boneindices[i, 7] = (UInt16)joints1[i].W;

                    weights[i, 4] = weights1[i].X;
                    weights[i, 5] = weights1[i].Y;
                    weights[i, 6] = weights1[i].Z;
                    weights[i, 7] = weights1[i].W;
                }
            }

            Vec3[] extraData = new Vec3[vertCount];
            bool extraExist = false;
            if(mesh.Primitives[0].MorphTargetsCount > 0)
            {
                extraExist = true;
            }
            if(extraExist)
            {
                int idx = mesh.Primitives[0].GetMorphTargetAccessors(0).Keys.ToList().IndexOf("POSITION");
                List<Vec3> extraDataList = mesh.Primitives[0].GetMorphTargetAccessors(0).Values.ToList()[idx].AsVector3Array().ToList();

                for(int i = 0; i < extraDataList.Count; i++)
                {
                    extraData[i] = new Vec3(extraDataList[i].X, -extraDataList[i].Z, extraDataList[i].Y);
                }
            }
            RawMeshContainer rawMeshContainer = new RawMeshContainer()
            {
                vertices = vertices,
                indices = indices,
                tx0coords = tx0coords,
                tx1coords = tx1coords,
                normals = normals,
                tangents = tangents,
                colors = colors,
                boneindices = boneindices,
                weights = weights,
                weightcount = weightcount,
                extraExist = extraExist,
                extradata = extraData,
                name = mesh.Name
            };

            return rawMeshContainer;
        }
        static Re4MeshContainer RawMeshToRE4Mesh(RawMeshContainer mesh, Vec4 qScale, Vec4 qTrans)
        {
            int vertCount = mesh.vertices.Length;
            Int16[,] ExpVerts = new Int16[vertCount, 3];
            UInt32[] Nor32s = new UInt32[vertCount];
            UInt32[] Tan32s = new UInt32[vertCount];

            for (int i = 0; i < vertCount; i++)
            {
                float x = (mesh.vertices[i].X - qTrans.X) / qScale.X;
                float y = (mesh.vertices[i].Y - qTrans.Y) / qScale.Y;
                float z = (mesh.vertices[i].Z - qTrans.Z) / qScale.Z;
                ExpVerts[i, 0] = Convert.ToInt16(x * 32767);
                ExpVerts[i, 1] = Convert.ToInt16(y * 32767);
                ExpVerts[i, 2] = Convert.ToInt16(z * 32767);
            }

            // managing normals
            for (int i = 0; i < vertCount; i++)
            {
                Vec4 v = new Vec4(mesh.normals[i], 0); // for normal w == 0
                Nor32s[i] = Converters.Vec4ToU32(v);
            }
            // managing tangents

            for (int i = 0; i < vertCount; i++)
            {
                Vec4 v = mesh.tangents[i]; // for tangents w == 1 or -1
                Tan32s[i] = Converters.Vec4ToU32(v);
            }

            UInt16[,] uv0s = new UInt16[vertCount, 2];

            for(int i = 0; i < mesh.tx0coords.Length; i++)
            {
                uv0s[i, 0] = Converters.converthf(mesh.tx0coords[i].X);
                uv0s[i, 1] = Converters.converthf(mesh.tx0coords[i].Y);
            }

            UInt16[,] uv1s = new UInt16[vertCount, 2];

            for (int i = 0; i < mesh.tx0coords.Length; i++)
            {
                uv1s[i, 0] = Converters.converthf(mesh.tx1coords[i].X);
                uv1s[i, 1] = Converters.converthf(mesh.tx1coords[i].Y);
            }

            Byte[,] colors = new byte[vertCount, 4];

            for(int i = 0; i < mesh.colors.Length; i++)
            {
                colors[i, 0] = Convert.ToByte(mesh.colors[i].X * 255);
                colors[i, 1] = Convert.ToByte(mesh.colors[i].Y * 255);
                colors[i, 2] = Convert.ToByte(mesh.colors[i].Z * 255);
                colors[i, 3] = Convert.ToByte(mesh.colors[i].W * 255);
            }
            UInt32 weightcount = mesh.weightcount;

            Byte[,] boneindices = new byte[vertCount, weightcount];
            for (int i = 0; i < vertCount; i++)
                for (int e = 0; e < weightcount; e++)
                    boneindices[i, e] = Convert.ToByte(mesh.boneindices[i, e]); // mesh.boneindices are supposed to be processed
                                                                                // (updated according to the mesh bones rather than rig bones) before putting here

            Byte[,] weights = new byte[vertCount, weightcount];
            for (int i = 0; i < vertCount; i++)
            {
                for (int e = 0; e < weightcount; e++)
                {
                    weights[i, e] = Convert.ToByte(mesh.weights[i, e] * 255);
                }
                // weight summing can cause problems here, sometimes sum >= 256, idk how to fix them yet
            }
            // extradata/ morphoffsetbs
            UInt16[,] extraData = new UInt16[vertCount, 3];
            bool extraExist = mesh.extraExist;
            if(extraExist)
            {
                for(int i = 0; i < vertCount; i++)
                {
                    extraData[i, 0] = Converters.converthf(mesh.extradata[i].X);
                    extraData[i, 1] = Converters.converthf(mesh.extradata[i].Y);
                    extraData[i, 2] = Converters.converthf(mesh.extradata[i].Z);
                }
            }

            UInt16[] indices = new UInt16[mesh.indices.Length];
            for (int i = 0; i < mesh.indices.Length; i++)
                indices[i] = Convert.ToUInt16(mesh.indices[i]);

            Re4MeshContainer Re4Mesh = new Re4MeshContainer()
            {
                ExpVerts = ExpVerts,
                Nor32s = Nor32s,
                Tan32s = Tan32s,
                uv0s = uv0s,
                uv1s = uv1s,
                colors = colors,
                boneindices = boneindices,
                weights = weights,
                weightcount = weightcount,
                indices = indices,
                name = mesh.name,
                extraExist = extraExist,
                extraData = extraData
            };
            return Re4Mesh;
        }
        static MeshesInfo BufferWriter(List<Re4MeshContainer> expMeshes, ref MemoryStream ms)
        {
            int meshC = expMeshes.Count;

            UInt32[] vertCounts = new UInt32[meshC];
            UInt32[] indCounts = new UInt32[meshC];
            UInt32[] vertOffsets = new UInt32[meshC];
            UInt32[] tx0Offsets = new UInt32[meshC];
            UInt32[] normalOffsets = new UInt32[meshC];
            UInt32[] colorOffsets = new UInt32[meshC];
            UInt32[] unknownOffsets = new UInt32[meshC];
            UInt32[] indicesOffsets = new UInt32[meshC];
            UInt32[] vpStrides = new UInt32[meshC];
            UInt32[] weightcounts = new UInt32[meshC];
            UInt32[] LODLvl = new UInt32[meshC];
            bool[] extraExists = new bool[meshC];

            UInt32 vertBufferSize = 0;
            UInt32 indexBufferSize = 0;
            UInt32 indexBufferOffset = 0;


            BinaryWriter bw = new BinaryWriter(ms);
            for (int i = 0; i < expMeshes.Count; i++)
            {
                int vertCount = expMeshes[i].ExpVerts.Length / 3;

                vertCounts[i] = (UInt32)vertCount;
                vertOffsets[i] = (UInt32)ms.Position;

                vpStrides[i] = expMeshes[i].weightcount * 2 + 8;
                weightcounts[i] = expMeshes[i].weightcount;

                extraExists[i] = expMeshes[i].extraExist;
                if(extraExists[i])
                {
                    vpStrides[i] += 8;
                }

                for (int e = 0; e < vertCount; e++)
                {
                    bw.Write(expMeshes[i].ExpVerts[e, 0]);
                    bw.Write(expMeshes[i].ExpVerts[e, 1]);
                    bw.Write(expMeshes[i].ExpVerts[e, 2]);
                    bw.Write((Int16)32767);
                    for (int eye = 0; eye < expMeshes[i].weightcount; eye++)
                        bw.Write(expMeshes[i].boneindices[e, eye]);

                    for (int eye = 0; eye < expMeshes[i].weightcount; eye++)
                        bw.Write(expMeshes[i].weights[e, eye]);

                    if(extraExists[i])
                    {
                        bw.Write(expMeshes[i].extraData[e, 0]);
                        bw.Write(expMeshes[i].extraData[e, 1]);
                        bw.Write(expMeshes[i].extraData[e, 2]);
                        bw.Write((UInt16)0);
                    }
                }

                // padding writer betwwen vertexBlock and uv0, if required
                if (((UInt64)ms.Length % 16) != 0)
                {
                    int zeroesCount = (int)((((UInt64)ms.Length / 16) + 1) * 16 - (UInt64)ms.Length);
                    Byte[] bytes = new Byte[zeroesCount];
                    bw.Write(bytes);
                }

                // writing tx0s
                tx0Offsets[i] = (UInt32)ms.Position;
                for (int e = 0; e < vertCount; e++)
                {
                    bw.Write(expMeshes[i].uv0s[e, 0]);
                    bw.Write(expMeshes[i].uv0s[e, 1]);
                }

                // padding writer betwwen uv0 and normals, if required
                if (((UInt64)ms.Length % 16) != 0)
                {
                    int zeroesCount = (int)((((UInt64)ms.Length / 16) + 1) * 16 - (UInt64)ms.Length);
                    Byte[] bytes = new Byte[zeroesCount];
                    bw.Write(bytes);
                }
                
                // writing normals and tangents
                normalOffsets[i] = (UInt32)ms.Position;
                for (int e = 0; e < vertCount; e++)
                {
                    bw.Write(expMeshes[i].Nor32s[e]);
                    bw.Write(expMeshes[i].Tan32s[e]);
                }

                // padding writer betwwen nors/tans and colors/uv1s, if required
                if (((UInt64)ms.Length % 16) != 0)
                {
                    int zeroesCount = (int)((((UInt64)ms.Length / 16) + 1) * 16 - (UInt64)ms.Length);
                    Byte[] bytes = new Byte[zeroesCount];
                    bw.Write(bytes);
                }
                
                // writing colors and tx1s
                colorOffsets[i] = (UInt32)ms.Position;
                for (int e = 0; e < vertCount; e++)
                {
                    
                    bw.Write(expMeshes[i].colors[e, 0]);
                    bw.Write(expMeshes[i].colors[e, 1]);
                    bw.Write(expMeshes[i].colors[e, 2]);
                    bw.Write(expMeshes[i].colors[e, 3]);
                    

                    // Temp fix for improved lighting geomertry
                    /*
                    bw.Write((byte)0);
                    bw.Write((byte)0);
                    bw.Write((byte)0);
                    bw.Write((byte)0);
                    */
                    bw.Write(expMeshes[i].uv1s[e, 0]);
                    bw.Write(expMeshes[i].uv1s[e, 1]);
                }

                // padding writer if necessary
                if (((UInt64)ms.Length % 16) != 0)
                {
                    int zeroesCount = (int)((((UInt64)ms.Length / 16) + 1) * 16 - (UInt64)ms.Length);
                    Byte[] bytes = new Byte[zeroesCount];
                    bw.Write(bytes);
                }

                // for the unusual lightblocker data
                /*
                unknownOffsets[i] = (UInt32)ms.Position;

                for (int e = 0; e < vertCount; e++)
                {
                    bw.Write((float)0f);
                }
                */
                vertBufferSize = (UInt32)ms.Length;

                // this padding writer if that unusual lightblocker data is written
                /*
                // padding writer if necessary
                if (((UInt64)ms.Length % 16) != 0)
                {
                    int zeroesCount = (int)((((UInt64)ms.Length / 16) + 1) * 16 - (UInt64)ms.Length);
                    Byte[] bytes = new Byte[zeroesCount];
                    bw.Write(bytes);
                }
                */
            }

            indexBufferOffset = (UInt32)ms.Position;
            for(int i = 0; i < expMeshes.Count; i++)
            {
                int indCount = expMeshes[i].indices.Length;
                indCounts[i] = (UInt32)indCount;

                indicesOffsets[i] = (UInt32)ms.Position;
                for (int e = 0; e < indCount; e++)
                    bw.Write(expMeshes[i].indices[e]);
            }
            indexBufferSize = (UInt32)ms.Length - indexBufferOffset;


            for(int i = 0; i < meshC; i++)
            {
                LODLvl[i] = Convert.ToUInt32(expMeshes[i].name.Substring(expMeshes[i].name.Length - 1));
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
                meshC = meshC,
                vertBufferSize = vertBufferSize,
                indexBufferOffset = indexBufferOffset,
                indexBufferSize = indexBufferSize,
                extraExists = extraExists
            };

            return meshesInfo;
        }
        static MemoryStream GetEditedCr2wFile(CR2WFile cr2w, MeshesInfo info, MemoryStream buffer)
        {
            int Index = 0;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "rendRenderMeshBlob")
                {
                    Index = i;
                }

            }

            // removing BS topology data which causes a lot of issues with improved facial lighting geomerty, vertex colors uroborus and what not
            int Count = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.Topology.Count;
            for (int i = 0; i < Count; i++)
            {
                (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.Topology.Remove((cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.Topology[0]);
            }
            for (int i = 0; i < info.meshC; i++)
            {
                (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.Topology.Add(new rendTopologyData(cr2w, (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.Topology, Convert.ToString(i)) { IsSerialized = true, IsNulled = false });
            }

            //dependent RenderLOD's removal and addition
            Count = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderLODs.Count;
            if (Count > 1)
            {
                for(int i = 0; i < Count; i++)
                {
                    (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderLODs.Remove((cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderLODs[0]);
                }
                (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderLODs.Add(new CFloat(cr2w, (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderLODs, "0") { IsSerialized = true, IsNulled = false, Value = 0f });

                if (info.LODLvl.ToList().Contains(2))
                {
                    (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderLODs.Add(new CFloat(cr2w, (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderLODs, "1") { IsSerialized = true, IsNulled = false, Value = 3f });
                }
                if (info.LODLvl.ToList().Contains(4))
                {
                    (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderLODs.Add(new CFloat(cr2w, (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderLODs, "2") { IsSerialized = true, IsNulled = false, Value = 6f });
                }
                if (info.LODLvl.ToList().Contains(8))
                {
                    (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderLODs.Add(new CFloat(cr2w, (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderLODs, "3") { IsSerialized = true, IsNulled = false, Value = 9f });
                }
            }
            // depended CMesh LODLevelInfo removal and addition has not been implemented yet, implementation depends if it will cause any issue

            // removing existing rendChunks
            Count = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos.Count;
            for (int i = 0; i < Count; i++)
            {
                (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos.Remove((cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[0]);
            }

            // adding new rendChunks
            for (int i = 0; i < info.meshC; i++)
            {
                rendChunk chunk = new rendChunk(cr2w, (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos, Convert.ToString(i)) { IsSerialized = true, IsNulled = false };

                chunk.LodMask = new CUInt8(cr2w, chunk, "lodMask") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(info.LODLvl[i]) };

                chunk.RenderMask = new CEnum<Enums.EMeshChunkFlags>(cr2w, chunk, "renderMask") { IsSerialized = true, IsNulled = false, Value = Enums.EMeshChunkFlags.MCF_RenderInScene};
                chunk.RenderMask.EnumValueList.Add("MCF_RenderInScene");
                chunk.RenderMask.EnumValueList.Add("MCF_RenderInShadows");

                // vertexfactory is really important to be taken care of properly
                // based upon VertexBlock, subject to change, incremental will be good, for weightcount ++ etc
                chunk.VertexFactory = new CUInt8(cr2w, chunk, "vertexFactory") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(2) };

                chunk.NumIndices = new CUInt32(cr2w, chunk, "numIndices") { IsSerialized = true, IsNulled = false, Value = info.indCounts[i] };
                chunk.NumVertices = new CUInt16(cr2w, chunk, "numVertices") { IsSerialized = true, IsNulled = false, Value = Convert.ToUInt16(info.vertCounts[i]) };

                chunk.ChunkIndices = new rendIndexBufferChunk(cr2w, chunk, "chunkIndices") { IsSerialized = true, IsNulled = false };
                chunk.ChunkIndices.Pe = new CEnum<Enums.GpuWrapApieIndexBufferChunkType>(cr2w, chunk.ChunkIndices, "pe") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApieIndexBufferChunkType.IBCT_IndexUShort };
                chunk.ChunkIndices.Pe.EnumValueList.Add("IBCT_IndexUShort");
                chunk.ChunkIndices.TeOffset = new CUInt32(cr2w, chunk.ChunkIndices, "teOffset") { IsSerialized = true, IsNulled = false, Value = info.indicesOffsets[i] - info.indexBufferOffset };


                chunk.ChunkVertices = new rendVertexBufferChunk(cr2w, chunk, "chunkVertices") { IsSerialized = true, IsNulled = false };
                chunk.ChunkVertices.ByteOffsets.IsSerialized = true;
                chunk.ChunkVertices.ByteOffsets.Add(new CUInt32(cr2w, chunk.ChunkVertices.ByteOffsets, "0") { IsSerialized = true, IsNulled = false, Value = info.vertOffsets[i] });
                chunk.ChunkVertices.ByteOffsets.Add(new CUInt32(cr2w, chunk.ChunkVertices.ByteOffsets, "1") { IsSerialized = true, IsNulled = false, Value = info.tx0Offsets[i] });
                chunk.ChunkVertices.ByteOffsets.Add(new CUInt32(cr2w, chunk.ChunkVertices.ByteOffsets, "2") { IsSerialized = true, IsNulled = false, Value = info.normalOffsets[i] });
                chunk.ChunkVertices.ByteOffsets.Add(new CUInt32(cr2w, chunk.ChunkVertices.ByteOffsets, "3") { IsSerialized = true, IsNulled = false, Value = info.colorOffsets[i] });
                chunk.ChunkVertices.ByteOffsets.Add(new CUInt32(cr2w, chunk.ChunkVertices.ByteOffsets, "4") { IsSerialized = true, IsNulled = false, Value = info.unknownOffsets[i] });

                chunk.ChunkVertices.VertexLayout = new GpuWrapApiVertexLayoutDesc(cr2w, chunk.ChunkVertices, "vertexLayout") { IsSerialized = true, IsNulled = false };

                // fishy hash and slotmask, subject to change
                chunk.ChunkVertices.VertexLayout.Hash = new CUInt32(cr2w, chunk.ChunkVertices.VertexLayout, "hash") { IsSerialized = true, IsNulled = false, Value = 0 };
                chunk.ChunkVertices.VertexLayout.SlotMask = new CUInt32(cr2w, chunk.ChunkVertices.VertexLayout, "slotMask") { IsSerialized = true, IsNulled = false, Value = 0 };

                chunk.ChunkVertices.VertexLayout.SlotStrides.IsSerialized = true;
                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.SlotStrides, "0") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(info.vpStrides[i]) });
                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.SlotStrides, "1") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(4) });
                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.SlotStrides, "2") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(8) });
                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.SlotStrides, "3") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(8) });
                if(info.unknownOffsets[i] == 0)
                {
                    chunk.ChunkVertices.VertexLayout.SlotStrides.Add(new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.SlotStrides, "4") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) });
                }
                else
                {
                    chunk.ChunkVertices.VertexLayout.SlotStrides.Add(new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.SlotStrides, "4") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(4) });
                }
                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.SlotStrides, "5") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) });
                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.SlotStrides, "6") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) });
                if(info.weightcounts[i] == 0)
                {
                    chunk.ChunkVertices.VertexLayout.SlotStrides.Add(new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.SlotStrides, "7") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(48) });
                }
                else
                {
                    chunk.ChunkVertices.VertexLayout.SlotStrides.Add(new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.SlotStrides, "7") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(64) });
                }
                chunk.ChunkVertices.VertexLayout.Elements.IsSerialized = true;


                int elementCount = 0;

                // Position                                                                                                                              // bs way of setting up index names
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement(cr2w, chunk.ChunkVertices.VertexLayout.Elements, Convert.ToString(elementCount)) { IsSerialized = true, IsNulled = false });
                // fishy
                //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "streamIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usageIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = new CEnum<Enums.GpuWrapApiVertexPackingePackingUsage>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usage") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingUsage.PS_Position };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage.EnumValueList.Add("PS_Position");
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = new CEnum<Enums.GpuWrapApiVertexPackingePackingType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "type") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingType.PT_Short4N };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type.EnumValueList.Add("PT_Short4N");
                elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                // Joint0
                if (info.weightcounts[i] > 0)
                {
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement(cr2w, chunk.ChunkVertices.VertexLayout.Elements, Convert.ToString(elementCount)) { IsSerialized = true, IsNulled = false });
                    // fishy
                    //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "streamIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usageIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = new CEnum<Enums.GpuWrapApiVertexPackingePackingUsage>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usage") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingUsage.PS_SkinIndices };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage.EnumValueList.Add("PS_SkinIndices");
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = new CEnum<Enums.GpuWrapApiVertexPackingePackingType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "type") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingType.PT_UByte4 };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type.EnumValueList.Add("PT_UByte4");
                    elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                    // subject to change, maybe, vertfactory is weird
                    chunk.VertexFactory.Value++;
                }
                // joint1
                if (info.weightcounts[i] > 4)
                {
                    // bs way of setting up index names
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement(cr2w, chunk.ChunkVertices.VertexLayout.Elements, Convert.ToString(elementCount)) { IsSerialized = true, IsNulled = false });
                    // fishy
                    //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "streamIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usageIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(1) };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = new CEnum<Enums.GpuWrapApiVertexPackingePackingUsage>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usage") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingUsage.PS_SkinIndices };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage.EnumValueList.Add("PS_SkinIndices");
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = new CEnum<Enums.GpuWrapApiVertexPackingePackingType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "type") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingType.PT_UByte4 };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type.EnumValueList.Add("PT_UByte4");
                    elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                    // subject to change, maybe, vertfactory is weird
                    chunk.VertexFactory.Value++;
                }

                // weight0
                if (info.weightcounts[i] > 0)
                {
                    // bs way of setting up index names
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement(cr2w, chunk.ChunkVertices.VertexLayout.Elements, Convert.ToString(elementCount)) { IsSerialized = true, IsNulled = false });
                    // fishy
                    //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "streamIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usageIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = new CEnum<Enums.GpuWrapApiVertexPackingePackingUsage>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usage") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingUsage.PS_SkinWeights };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage.EnumValueList.Add("PS_SkinWeights");
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = new CEnum<Enums.GpuWrapApiVertexPackingePackingType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "type") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingType.PT_UByte4N };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type.EnumValueList.Add("PT_UByte4N");
                    elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;
                }
                // weight1
                if (info.weightcounts[i] > 4)
                {
                    // bs way of setting up index names
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement(cr2w, chunk.ChunkVertices.VertexLayout.Elements, Convert.ToString(elementCount)) { IsSerialized = true, IsNulled = false });
                    // fishy
                    //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "streamIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usageIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(1) };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = new CEnum<Enums.GpuWrapApiVertexPackingePackingUsage>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usage") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingUsage.PS_SkinWeights };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage.EnumValueList.Add("PS_SkinWeights");
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = new CEnum<Enums.GpuWrapApiVertexPackingePackingType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "type") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingType.PT_UByte4N };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type.EnumValueList.Add("PT_UByte4N");
                    elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;
                }

                // tx0coords
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement(cr2w, chunk.ChunkVertices.VertexLayout.Elements, Convert.ToString(elementCount)) { IsSerialized = true, IsNulled = false });
                // fishy
                //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "streamIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(1) };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usageIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = new CEnum<Enums.GpuWrapApiVertexPackingePackingUsage>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usage") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingUsage.PS_TexCoord };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage.EnumValueList.Add("PS_TexCoord");
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = new CEnum<Enums.GpuWrapApiVertexPackingePackingType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "type") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingType.PT_Float16_2 };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type.EnumValueList.Add("PT_Float16_2");
                elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                // normals
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement(cr2w, chunk.ChunkVertices.VertexLayout.Elements, Convert.ToString(elementCount)) { IsSerialized = true, IsNulled = false });
                // fishy
                //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "streamIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(2) };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usageIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = new CEnum<Enums.GpuWrapApiVertexPackingePackingUsage>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usage") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingUsage.PS_Normal };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage.EnumValueList.Add("PS_Normal");
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = new CEnum<Enums.GpuWrapApiVertexPackingePackingType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "type") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingType.PT_Dec4 };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type.EnumValueList.Add("PT_Dec4");
                elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                // tangents
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement(cr2w, chunk.ChunkVertices.VertexLayout.Elements, Convert.ToString(elementCount)) { IsSerialized = true, IsNulled = false });
                // fishy
                //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "streamIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(2) };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usageIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = new CEnum<Enums.GpuWrapApiVertexPackingePackingUsage>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usage") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingUsage.PS_Tangent };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage.EnumValueList.Add("PS_Tangent");
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = new CEnum<Enums.GpuWrapApiVertexPackingePackingType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "type") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingType.PT_Dec4 };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type.EnumValueList.Add("PT_Dec4");
                elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                // color
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement(cr2w, chunk.ChunkVertices.VertexLayout.Elements, Convert.ToString(elementCount)) { IsSerialized = true, IsNulled = false });
                // fishy
                //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "streamIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(3) };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usageIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = new CEnum<Enums.GpuWrapApiVertexPackingePackingUsage>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usage") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingUsage.PS_Color };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage.EnumValueList.Add("PS_Color");
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = new CEnum<Enums.GpuWrapApiVertexPackingePackingType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "type") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingType.PT_Color };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type.EnumValueList.Add("PT_Color");
                elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                // tx1coords
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement(cr2w, chunk.ChunkVertices.VertexLayout.Elements, Convert.ToString(elementCount)) { IsSerialized = true, IsNulled = false });
                // fishy
                //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "streamIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(3) };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usageIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(1) };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = new CEnum<Enums.GpuWrapApiVertexPackingePackingUsage>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usage") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingUsage.PS_TexCoord };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage.EnumValueList.Add("PS_TexCoord");
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = new CEnum<Enums.GpuWrapApiVertexPackingePackingType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "type") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingType.PT_Float16_2 };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type.EnumValueList.Add("PT_Float16_2");
                elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                // extra data/ morphoffsets
                if(info.extraExists[i])
                {
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement(cr2w, chunk.ChunkVertices.VertexLayout.Elements, Convert.ToString(elementCount)) { IsSerialized = true, IsNulled = false });
                    // fishy
                    //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "streamIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usageIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = new CEnum<Enums.GpuWrapApiVertexPackingePackingUsage>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usage") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingUsage.PS_ExtraData };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage.EnumValueList.Add("PS_ExtraData");
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = new CEnum<Enums.GpuWrapApiVertexPackingePackingType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "type") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingType.PT_Float16_4 };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type.EnumValueList.Add("PT_Float16_4");
                    elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                    // subject to change, maybe, vertfactory is weird, extra data ads 2 to this
                    chunk.VertexFactory.Value += 2;
                }

                // instanceTransforms
                for(int e = 0; e < 3; e++)
                {
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement(cr2w, chunk.ChunkVertices.VertexLayout.Elements, Convert.ToString(elementCount)) { IsSerialized = true, IsNulled = false });
                    // fishy
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerInstance };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "streamIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(7) };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usageIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(e) };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = new CEnum<Enums.GpuWrapApiVertexPackingePackingUsage>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usage") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingUsage.PS_InstanceTransform };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage.EnumValueList.Add("PS_InstanceTransform");
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = new CEnum<Enums.GpuWrapApiVertexPackingePackingType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "type") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingType.PT_Float4 };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type.EnumValueList.Add("PT_Float4");
                    elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;
                }

                // instanceSkinningDatas
                if(info.weightcounts[i] > 0)
                {
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement(cr2w, chunk.ChunkVertices.VertexLayout.Elements, Convert.ToString(elementCount)) { IsSerialized = true, IsNulled = false });
                    // fishy
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerInstance };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "streamIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(7) };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usageIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = new CEnum<Enums.GpuWrapApiVertexPackingePackingUsage>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usage") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingUsage.PS_InstanceSkinningData };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage.EnumValueList.Add("PS_InstanceSkinningData");
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = new CEnum<Enums.GpuWrapApiVertexPackingePackingType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "type") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingType.PT_UInt4 };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type.EnumValueList.Add("PT_UInt4");
                    elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;
                }

                // LightBlockerIntensity
                if(info.unknownOffsets[i] != 0)
                {
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement(cr2w, chunk.ChunkVertices.VertexLayout.Elements, Convert.ToString(elementCount)) { IsSerialized = true, IsNulled = false });
                    // fishy
                    //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "streamIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(4) };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usageIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = new CEnum<Enums.GpuWrapApiVertexPackingePackingUsage>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usage") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingUsage.PS_LightBlockerIntensity };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage.EnumValueList.Add("PS_LightBlockerIntensity");
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = new CEnum<Enums.GpuWrapApiVertexPackingePackingType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "type") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingType.PT_Float1 };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type.EnumValueList.Add("PT_Float1");
                    elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                    // for lightblocker its 24, after testing some files, somtimes unknownoffsets[4] is used for destruction indices and some paint instead of lightblocker, so this needs to be taken care of
                    chunk.VertexFactory.Value += 24;
                }
                
                
                // Invalid, Required
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement(cr2w, chunk.ChunkVertices.VertexLayout.Elements, Convert.ToString(elementCount)) { IsSerialized = true, IsNulled = false });
                // fishy
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType.IsSerialized = true;
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType.Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_Invalid;
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType.EnumValueList.Add("ST_Invalid");
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "streamIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usageIndex") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = new CEnum<Enums.GpuWrapApiVertexPackingePackingUsage>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "usage") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingUsage.PS_Invalid };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage.EnumValueList.Add("PS_Invalid");
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = new CEnum<Enums.GpuWrapApiVertexPackingePackingType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[elementCount], "type") { IsSerialized = true, IsNulled = false, Value = Enums.GpuWrapApiVertexPackingePackingType.PT_Invalid };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type.EnumValueList.Add("PT_Invalid");
                elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                // Adding Chunk
                (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos.Add(chunk);
            }

            (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.QuantizationScale.X.Value = info.qScale.X;
            (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.QuantizationScale.Y.Value = info.qScale.Y;
            (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.QuantizationScale.Z.Value = info.qScale.Z;
            (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.QuantizationOffset.X.Value = info.qTrans.X;
            (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.QuantizationOffset.Y.Value = info.qTrans.Y;
            (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.QuantizationOffset.Z.Value = info.qTrans.Z;

            (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.VertexBufferSize.Value = info.vertBufferSize;
            (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.IndexBufferSize.Value = info.indexBufferSize;
            (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.IndexBufferOffset.Value = info.indexBufferOffset;


            UInt16 p = BitConverter.ToUInt16((cr2w.Chunks[Index].data as rendRenderMeshBlob).RenderBuffer.Buffer.Bytes);

            var compressed = new MemoryStream();
            using var buff = new BinaryWriter(compressed);
            var (zsize, crc) = buff.CompressAndWrite(buffer.ToArray());

            cr2w.Buffers[p - 1].DiskSize = zsize;
            cr2w.Buffers[p - 1].Crc32 = crc;
            cr2w.Buffers[p - 1].MemSize = (UInt32)buffer.Length;
            var off = cr2w.Buffers[p - 1].Offset;
            cr2w.Buffers[p - 1].Offset = 0;
            cr2w.Buffers[p - 1].ReadData(new BinaryReader(compressed));
            cr2w.Buffers[p - 1].Offset = off;


            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);
            cr2w.Write(bw);
            return ms;
        }
        static void VerifyGLTF(ModelRoot model)
        {
            if(model.LogicalMeshes.Count == 0)
            {
                throw new Exception("Provided GLTF doesn't contain any 3D Geomerty");
            }
            List<UInt32> LODs = new List<UInt32>();
            for(int i = 0; i < model.LogicalMeshes.Count; i++)
            {
                List<string> accessors = model.LogicalMeshes[i].Primitives[0].VertexAccessors.Keys.ToList();

                if (!accessors.Contains("POSITION"))
                {
                    throw new Exception("One or more Geometry in provided GLTF doesn't contain Vertices");
                }
                if (!accessors.Contains("NORMAL"))
                {
                    throw new Exception("One or more Geometry in provided GLTF doesn't contain Normals data");
                }
                if (!accessors.Contains("TANGENT"))
                {
                    throw new Exception("One or more Geometry in provided GLTF doesn't contain Tangents data");
                }
                if(model.LogicalMeshes[i].Primitives[0].GetIndices().ToList().Count < 3)
                {
                    throw new Exception("One or more Geometry in provided GLTF doesn't contain any Triangle primitives");
                }
                string name = model.LogicalMeshes[i].Name;
                UInt32 LOD = 0;
                try
                {
                    LOD = Convert.ToUInt32(name.Substring(name.Length - 1));
                    LODs.Add(LOD);
                }
                catch
                {
                    throw new Exception("Invalid Geometry/sub mesh name: " + name + " , Last character of the name should be 1 or 2 or 4 or 8, Representing the Level of Detail (LOD) of the submesh.");
                }
                if(LOD != 1 && LOD != 2 && LOD != 4 && LOD != 8)
                {
                    throw new Exception("Invalid Geometry/sub mesh name: " + name + " , Last character of the name should be 1 or 2 or 4 or 8, Representing the Level of Detail (LOD) of the submesh.");
                }
            }
            if(!LODs.Contains(1))
            {
                throw new Exception("None of the Geometry/sub meshes are of 1 Level of Detail or (LOD 1) in provided GLTF");
            }
        }
    }
}
