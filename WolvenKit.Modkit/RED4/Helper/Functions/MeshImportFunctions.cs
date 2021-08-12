using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using WolvenKit.Modkit.RED4.GeneralStructs;
using SharpGLTF.Schema2;
using SharpGLTF.IO;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.RED4.CR2W;
using SharpGLTF.Validation;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.Modkit.RED4
{
    using Vec4 = System.Numerics.Vector4;
    using Vec2 = System.Numerics.Vector2;
    using Vec3 = System.Numerics.Vector3;
    public partial class ModTools
    {
        public bool ImportMesh(FileInfo inGltfFile, Stream inmeshStream, ValidationMode vmode = ValidationMode.Strict, bool importMaterialOnly = false, Stream outStream = null)
        {
            var cr2w = _wolvenkitFileService.TryReadRED4File(inmeshStream);
            if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any() || !cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
            {
                return false;
            }

            if (File.Exists(Path.ChangeExtension(inGltfFile.FullName, ".Material.json")))
            {
                WriteMatToMesh(ref cr2w, File.ReadAllText(Path.ChangeExtension(inGltfFile.FullName, ".Material.json")));
                if (importMaterialOnly)
                {
                    MemoryStream matOnlyStream = new MemoryStream();
                    cr2w.Write(new BinaryWriter(matOnlyStream));
                    matOnlyStream.Seek(0, SeekOrigin.Begin);
                    if (outStream != null)
                    {
                        matOnlyStream.CopyTo(outStream);
                    }
                    else
                    {
                        inmeshStream.SetLength(0);
                        matOnlyStream.CopyTo(inmeshStream);
                    }
                    return true;
                }

            }

            var model = ModelRoot.Load(inGltfFile.FullName, new ReadSettings(vmode));

            VerifyGLTF(model);
            List<RawMeshContainer> Meshes = new List<RawMeshContainer>();

            for (int i = 0; i < model.LogicalMeshes.Count; i++)
            {
                Meshes.Add(GltfMeshToRawContainer(model.LogicalMeshes[i]));
            }
            Vec3 max = new Vec3(Meshes[0].vertices[0].X, Meshes[0].vertices[0].Y, Meshes[0].vertices[0].Z);
            Vec3 min = new Vec3(Meshes[0].vertices[0].X, Meshes[0].vertices[0].Y, Meshes[0].vertices[0].Z);

            for (int e = 0; e < Meshes.Count; e++)
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
            (cr2w.Chunks[Index].Data as CMesh).BoundingBox.Min.X.Value = min.X;
            (cr2w.Chunks[Index].Data as CMesh).BoundingBox.Min.Y.Value = min.Y;
            (cr2w.Chunks[Index].Data as CMesh).BoundingBox.Min.Z.Value = min.Z;
            (cr2w.Chunks[Index].Data as CMesh).BoundingBox.Max.X.Value = max.X;
            (cr2w.Chunks[Index].Data as CMesh).BoundingBox.Max.Y.Value = max.Y;
            (cr2w.Chunks[Index].Data as CMesh).BoundingBox.Max.Z.Value = max.Z;
            // bounding box updated

            Vec4 QuantScale = new Vec4((max.X - min.X) / 2, (max.Y - min.Y) / 2, (max.Z - min.Z) / 2, 0);
            Vec4 QuantTrans = new Vec4((max.X + min.X) / 2, (max.Y + min.Y) / 2, (max.Z + min.Z) / 2, 1);

            if(model.LogicalSkins.Count != 0)
            {
                string[] bones = new string[model.LogicalSkins[0].JointsCount];

                for (int i = 0; i < model.LogicalSkins[0].JointsCount; i++)
                    bones[i] = model.LogicalSkins[0].GetJoint(i).Joint.Name;

                string[] meshbones = RIG.GetboneNames(cr2w);

                // reset vertex joint indices according to original
                for (int i = 0; i < Meshes.Count; i++)
                    for (int e = 0; e < Meshes[i].vertices.Length; e++)
                        for (int eye = 0; eye < Meshes[i].weightcount; eye++)
                        {
                            if (Meshes[i].weights[e, eye] != 0)
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
                                if (Meshes[i].boneindices[e, eye] > (meshbones.Length - 1))
                                {
                                    Meshes[i].boneindices[e, eye] = 0;
                                }
                            }
                        }

            }
            UpdateSkinningParamCloth(ref Meshes, ref cr2w);

            List<Re4MeshContainer> expMeshes = new List<Re4MeshContainer>();

            for (int i = 0; i < Meshes.Count; i++)
                expMeshes.Add(RawMeshToRE4Mesh(Meshes[i], QuantScale, QuantTrans));

            MemoryStream meshBuffer = new MemoryStream();
            MeshesInfo meshesInfo = BufferWriter(expMeshes, ref meshBuffer);

            meshesInfo.qScale = QuantScale;
            meshesInfo.qTrans = QuantTrans;

            MemoryStream ms = GetEditedCr2wFile(cr2w, meshesInfo, meshBuffer);
            ms.Seek(0, SeekOrigin.Begin);
            if (outStream != null)
            {
                ms.CopyTo(outStream);
            }
            else
            {
                inmeshStream.SetLength(0);
                ms.CopyTo(inmeshStream);
            }
            return true;
        }
        static RawMeshContainer GltfMeshToRawContainer(Mesh mesh)
        {

            List<string> accessors = mesh.Primitives[0].VertexAccessors.Keys.ToList();

            List<uint> indicesList = mesh.Primitives[0].GetIndices().ToList();

            uint[] indices = new uint[indicesList.Count];

            // ReSwapping the faces
            for (int i = 0; i < indicesList.Count; i += 3)
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

            Vec4[] colors0 = new Vec4[vertCount];
            if (accessors.Contains("COLOR_0"))
                colors0 = mesh.Primitives[0].GetVertices("COLOR_0").AsVector4Array().ToArray();

            Vec4[] colors1 = new Vec4[vertCount];
            if (accessors.Contains("COLOR_1"))
                colors1 = mesh.Primitives[0].GetVertices("COLOR_1").AsVector4Array().ToArray();

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
            if (mesh.Primitives[0].MorphTargetsCount > 0)
            {
                extraExist = true;
            }
            if (extraExist)
            {
                int idx = mesh.Primitives[0].GetMorphTargetAccessors(0).Keys.ToList().IndexOf("POSITION");
                List<Vec3> extraDataList = mesh.Primitives[0].GetMorphTargetAccessors(0).Values.ToList()[idx].AsVector3Array().ToList();

                for (int i = 0; i < extraDataList.Count; i++)
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
                colors0 = colors0,
                colors1 = colors1,
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

            for (int i = 0; i < mesh.tx0coords.Length; i++)
            {
                uv0s[i, 0] = Converters.converthf(mesh.tx0coords[i].X);
                uv0s[i, 1] = Converters.converthf(mesh.tx0coords[i].Y);
            }

            UInt16[,] uv1s = new UInt16[vertCount, 2];

            for (int i = 0; i < mesh.tx1coords.Length; i++)
            {
                uv1s[i, 0] = Converters.converthf(mesh.tx1coords[i].X);
                uv1s[i, 1] = Converters.converthf(mesh.tx1coords[i].Y);
            }

            Byte[,] colors = new byte[vertCount, 4];

            for (int i = 0; i < mesh.colors0.Length; i++)
            {
                colors[i, 0] = Convert.ToByte(mesh.colors0[i].X * 255);
                colors[i, 1] = Convert.ToByte(mesh.colors0[i].Y * 255);
                colors[i, 2] = Convert.ToByte(mesh.colors0[i].Z * 255);
                colors[i, 3] = Convert.ToByte(mesh.colors0[i].W * 255);
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
            if (extraExist)
            {
                for (int i = 0; i < vertCount; i++)
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
                if (extraExists[i])
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

                    if (extraExists[i])
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
            for (int i = 0; i < expMeshes.Count; i++)
            {
                int indCount = expMeshes[i].indices.Length;
                indCounts[i] = (UInt32)indCount;

                indicesOffsets[i] = (UInt32)ms.Position;
                for (int e = 0; e < indCount; e++)
                    bw.Write(expMeshes[i].indices[e]);
            }
            indexBufferSize = (UInt32)ms.Length - indexBufferOffset;


            for (int i = 0; i < meshC; i++)
            {
                if (expMeshes[i].name.Contains("LOD"))
                {
                    int idx = expMeshes[i].name.IndexOf("LOD_");
                    if (idx < expMeshes[i].name.Length - 1)
                    {
                        LODLvl[i] = Convert.ToUInt32(expMeshes[i].name.Substring(idx + 4, 1));
                    }
                }
                else
                {
                    LODLvl[i] = 1;
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
            var blob = cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().First();
            // removing BS topology data which causes a lot of issues with improved facial lighting geomerty, vertex colors uroborus and what not
            int Count = blob.Header.Topology.Count;
            
            for (int i = 0; i < Count; i++)
            {
                blob.Header.Topology.Remove(blob.Header.Topology[0]);
            }
            for (int i = 0; i < info.meshC; i++)
            {
                blob.Header.Topology.Add(new rendTopologyData(cr2w, blob.Header.Topology, Convert.ToString(i)) { IsSerialized = true, IsNulled = false });
            }
            
            //dependent RenderLOD's removal and addition
            Count = blob.Header.RenderLODs.Count;
            if (Count > 1)
            {
                for (int i = 0; i < Count; i++)
                {
                    blob.Header.RenderLODs.Remove(blob.Header.RenderLODs[0]);
                }
                blob.Header.RenderLODs.Add(new CFloat(cr2w, blob.Header.RenderLODs, "0") { IsSerialized = true, IsNulled = false, Value = 0f });
                if (info.LODLvl.ToList().Contains(2))
                {
                    blob.Header.RenderLODs.Add(new CFloat(cr2w, blob.Header.RenderLODs, "1") { IsSerialized = true, IsNulled = false, Value = 3f });
                }
                if (info.LODLvl.ToList().Contains(4))
                {
                    blob.Header.RenderLODs.Add(new CFloat(cr2w, blob.Header.RenderLODs, "2") { IsSerialized = true, IsNulled = false, Value = 6f });
                }
                if (info.LODLvl.ToList().Contains(8))
                {
                    blob.Header.RenderLODs.Add(new CFloat(cr2w, blob.Header.RenderLODs, "3") { IsSerialized = true, IsNulled = false, Value = 9f });
                }
            }
            if(cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any())
            {
                var cmeshblob = cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().First();
                Count = cmeshblob.LodLevelInfo.Count;
                if (Count > 1)
                {
                    for (int i = 0; i < Count; i++)
                    {
                        cmeshblob.LodLevelInfo.Remove(cmeshblob.LodLevelInfo[0]);
                    }
                    cmeshblob.LodLevelInfo.Add(new CFloat(cr2w, cmeshblob.LodLevelInfo, "0") { IsSerialized = true, IsNulled = false, Value = 0f });
                    if (info.LODLvl.ToList().Contains(2))
                    {
                        cmeshblob.LodLevelInfo.Add(new CFloat(cr2w, cmeshblob.LodLevelInfo, "1") { IsSerialized = true, IsNulled = false, Value = 3f });
                    }
                    if (info.LODLvl.ToList().Contains(4))
                    {
                        cmeshblob.LodLevelInfo.Add(new CFloat(cr2w, cmeshblob.LodLevelInfo, "2") { IsSerialized = true, IsNulled = false, Value = 6f });
                    }
                    if (info.LODLvl.ToList().Contains(8))
                    {
                        cmeshblob.LodLevelInfo.Add(new CFloat(cr2w, cmeshblob.LodLevelInfo, "3") { IsSerialized = true, IsNulled = false, Value = 9f });
                    }
                }
            }
            // removing existing rendChunks
            Count = blob.Header.RenderChunkInfos.Count;
            for (int i = 0; i < Count; i++)
            {
                blob.Header.RenderChunkInfos.Remove(blob.Header.RenderChunkInfos[0]);
            }

            // adding new rendChunks
            for (int i = 0; i < info.meshC; i++)
            {
                rendChunk chunk = new rendChunk(cr2w, blob.Header.RenderChunkInfos, Convert.ToString(i)) { IsSerialized = true, IsNulled = false };

                chunk.LodMask = new CUInt8(cr2w, chunk, "lodMask") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(info.LODLvl[i]) };

                chunk.RenderMask = new CEnum<Enums.EMeshChunkFlags>(cr2w, chunk, "renderMask") { IsSerialized = true, IsNulled = false, Value = Enums.EMeshChunkFlags.MCF_RenderInScene };
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
                if (info.unknownOffsets[i] == 0)
                {
                    chunk.ChunkVertices.VertexLayout.SlotStrides.Add(new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.SlotStrides, "4") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) });
                }
                else
                {
                    chunk.ChunkVertices.VertexLayout.SlotStrides.Add(new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.SlotStrides, "4") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(4) });
                }
                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.SlotStrides, "5") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) });
                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(new CUInt8(cr2w, chunk.ChunkVertices.VertexLayout.SlotStrides, "6") { IsSerialized = true, IsNulled = false, Value = Convert.ToByte(0) });
                if (info.weightcounts[i] == 0)
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
                if (info.extraExists[i])
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
                for (int e = 0; e < 3; e++)
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
                if (info.weightcounts[i] > 0)
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
                if (info.unknownOffsets[i] != 0)
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
                blob.Header.RenderChunkInfos.Add(chunk);
            }

            blob.Header.QuantizationScale.X.Value = info.qScale.X;
            blob.Header.QuantizationScale.Y.Value = info.qScale.Y;
            blob.Header.QuantizationScale.Z.Value = info.qScale.Z;
            blob.Header.QuantizationOffset.X.Value = info.qTrans.X;
            blob.Header.QuantizationOffset.Y.Value = info.qTrans.Y;
            blob.Header.QuantizationOffset.Z.Value = info.qTrans.Z;

            blob.Header.VertexBufferSize.Value = info.vertBufferSize;
            blob.Header.IndexBufferSize.Value = info.indexBufferSize;
            blob.Header.IndexBufferOffset.Value = info.indexBufferOffset;


            UInt16 p = (blob.RenderBuffer.Buffer.Value);

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
            if (model.LogicalMeshes.Count == 0)
            {
                throw new Exception("Provided GLTF doesn't contain any 3D Geomerty");
            }
            List<UInt32> LODs = new List<UInt32>();
            for (int i = 0; i < model.LogicalMeshes.Count; i++)
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
                if (model.LogicalMeshes[i].Primitives[0].GetIndices().ToList().Count < 3)
                {
                    throw new Exception("One or more Geometry in provided GLTF doesn't contain any Triangle primitives");
                }
                string name = model.LogicalMeshes[i].Name;
                UInt32 LOD = 0;

                if(name.Contains("LOD"))
                {
                    try
                    {
                        int idx = name.IndexOf("LOD_");
                        if(idx < name.Length - 1)
                        {
                            LOD = Convert.ToUInt32(name.Substring(idx + 4,1));
                            LODs.Add(LOD);
                        }
                    }
                    catch
                    {
                        throw new Exception("Invalid Geometry/sub mesh name: " + name + " , Character after \"LOD_\" should be 1 or 2 or 4 or 8, Representing the Level of Detail (LOD) of the submesh.");
                    }
                    if (LOD != 1 && LOD != 2 && LOD != 4 && LOD != 8)
                    {
                        throw new Exception("Invalid Geometry/sub mesh name: " + name + " , Character after \"LOD_\"  should be 1 or 2 or 4 or 8, Representing the Level of Detail (LOD) of the submesh.");
                    }
                }
                else
                {
                    LODs.Add(1);
                }
            }
            if (!LODs.Contains(1))
            {
                throw new Exception("None of the Geometry/sub meshes are of 1 Level of Detail or (LOD 1) in provided GLTF");
            }
        }
        private static void UpdateSkinningParamCloth(ref List<RawMeshContainer> meshes,ref CR2WFile cr2w)
        {
            var LODLvl = new UInt32[meshes.Count];
            for (int i = 0; i < meshes.Count; i++)
            {
                if (meshes[i].name.Contains("LOD"))
                {
                    int idx = meshes[i].name.IndexOf("LOD_");
                    if (idx < meshes[i].name.Length - 1)
                    {
                        LODLvl[i] = Convert.ToUInt32(meshes[i].name.Substring(idx + 4, 1));
                    }
                }
                else
                {
                    LODLvl[i] = 1;
                }

            }

            int meshBufferIdx = cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().First().RenderBuffer.Buffer.Value - 1;
            int materialBufferIdx = cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().First().LocalMaterialBuffer.RawData.Buffer.Value - 1;
            if (!cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().First().LocalMaterialBuffer.RawData.IsSerialized)
                materialBufferIdx = int.MaxValue;

            int buffCount = cr2w.Buffers.Count;

            for (int i = 0, idx = 0; i < buffCount; i++, idx++)
            {
                if (idx != meshBufferIdx && idx != materialBufferIdx)
                {
                    cr2w.Buffers.Remove(cr2w.Buffers[idx]);
                    if (idx < meshBufferIdx)
                        meshBufferIdx--;
                    if (idx < materialBufferIdx)
                        materialBufferIdx--;
                    idx--;
                }
            }
            if (!cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().First().LocalMaterialBuffer.RawData.IsSerialized)
                materialBufferIdx = 0;

            cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().First().RenderBuffer.Buffer.Value = Convert.ToUInt16(meshBufferIdx + 1);
            cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().First().LocalMaterialBuffer.RawData.Buffer.Value = Convert.ToUInt16(materialBufferIdx + 1);


            if (cr2w.Chunks.Select(_ => _.Data).OfType<meshMeshParamCloth>().Any())
            {
                var blob = cr2w.Chunks.Select(_ => _.Data).OfType<meshMeshParamCloth>().First();
                blob.Chunks = new CArray<meshPhxClothChunkData>(cr2w, blob, "chunks") { IsSerialized = true };
                for (int i = 0; i < meshes.Count;i++)
                {
                    var chunk = new meshPhxClothChunkData(cr2w, blob.Chunks,Convert.ToString(i)) { IsSerialized = true};
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for(int e = 0; e < meshes[i].vertices.Length; e++)
                        {
                            bw.Write(meshes[i].vertices[e].X);
                            bw.Write(meshes[i].vertices[e].Y);
                            bw.Write(meshes[i].vertices[e].Z);
                        }
                        var compressed = new MemoryStream();
                        using var buff = new BinaryWriter(compressed);
                        var (zsize, crc) = buff.CompressAndWrite(buffer.ToArray());

                        chunk.Positions = new DataBuffer(cr2w, chunk,"positions") { IsSerialized = true };
                        chunk.Positions.Buffer = new CUInt16(cr2w, chunk.Positions, "Buffer") { Value = (UInt16)(cr2w.Buffers.Count + 1), IsSerialized = true };

                        uint idx = (uint)cr2w.Buffers.Count;
                        cr2w.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()
                        {
                            flags = 0,
                            index = idx,
                            offset = 0,
                            diskSize = zsize,
                            memSize = (UInt32)buffer.Length,
                            crc32 = crc
                        }));

                        cr2w.Buffers[(int)idx].ReadData(new BinaryReader(compressed));
                        cr2w.Buffers[(int)idx].Offset = cr2w.Buffers[(int)idx - 1].Offset + cr2w.Buffers[(int)idx - 1].DiskSize;
                    }
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].indices.Length; e++)
                        {
                            bw.Write(Convert.ToUInt16(meshes[i].indices[e]));
                        }
                        var compressed = new MemoryStream();
                        using var buff = new BinaryWriter(compressed);
                        var (zsize, crc) = buff.CompressAndWrite(buffer.ToArray());

                        chunk.Indices = new DataBuffer(cr2w, chunk, "indices") { IsSerialized = true };
                        chunk.Indices.Buffer = new CUInt16(cr2w, chunk.Indices, "Buffer") { Value = (UInt16)(cr2w.Buffers.Count + 1), IsSerialized = true };

                        uint idx = (uint)cr2w.Buffers.Count;
                        cr2w.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()
                        {
                            flags = 0,
                            index = idx,
                            offset = 0,
                            diskSize = zsize,
                            memSize = (UInt32)buffer.Length,
                            crc32 = crc
                        }));

                        cr2w.Buffers[(int)idx].ReadData(new BinaryReader(compressed));
                        cr2w.Buffers[(int)idx].Offset = cr2w.Buffers[(int)idx - 1].Offset + cr2w.Buffers[(int)idx - 1].DiskSize;
                    }
                    if (meshes[i].weightcount > 0)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].vertices.Length; e++)
                        {
                            bw.Write(meshes[i].weights[e, 0]);
                            bw.Write(meshes[i].weights[e, 1]);
                            bw.Write(meshes[i].weights[e, 2]);
                            bw.Write(meshes[i].weights[e, 3]);
                        }
                        var compressed = new MemoryStream();
                        using var buff = new BinaryWriter(compressed);
                        var (zsize, crc) = buff.CompressAndWrite(buffer.ToArray());

                        chunk.SkinWeights = new DataBuffer(cr2w, chunk, "skinWeights") { IsSerialized = true };
                        chunk.SkinWeights.Buffer = new CUInt16(cr2w, chunk.SkinWeights, "Buffer") { Value = (UInt16)(cr2w.Buffers.Count + 1), IsSerialized = true };

                        uint idx = (uint)cr2w.Buffers.Count;
                        cr2w.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()
                        {
                            flags = 0,
                            index = idx,
                            offset = 0,
                            diskSize = zsize,
                            memSize = (UInt32)buffer.Length,
                            crc32 = crc
                        }));

                        cr2w.Buffers[(int)idx].ReadData(new BinaryReader(compressed));
                        cr2w.Buffers[(int)idx].Offset = cr2w.Buffers[(int)idx - 1].Offset + cr2w.Buffers[(int)idx - 1].DiskSize;
                    }
                    if (meshes[i].weightcount > 0)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].vertices.Length; e++)
                        {
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 0]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 1]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 2]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 3]));
                        }
                        var compressed = new MemoryStream();
                        using var buff = new BinaryWriter(compressed);
                        var (zsize, crc) = buff.CompressAndWrite(buffer.ToArray());

                        chunk.SkinIndices = new DataBuffer(cr2w, chunk, "skinIndices") { IsSerialized = true };
                        chunk.SkinIndices.Buffer = new CUInt16(cr2w, chunk.SkinIndices, "Buffer") { Value = (UInt16)(cr2w.Buffers.Count + 1), IsSerialized = true };

                        uint idx = (uint)cr2w.Buffers.Count;
                        cr2w.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()
                        {
                            flags = 0,
                            index = idx,
                            offset = 0,
                            diskSize = zsize,
                            memSize = (UInt32)buffer.Length,
                            crc32 = crc
                        }));

                        cr2w.Buffers[(int)idx].ReadData(new BinaryReader(compressed));
                        cr2w.Buffers[(int)idx].Offset = cr2w.Buffers[(int)idx - 1].Offset + cr2w.Buffers[(int)idx - 1].DiskSize;
                    }
                    if (meshes[i].weightcount > 4)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].vertices.Length; e++)
                        {
                            bw.Write(meshes[i].weights[e, 4]);
                            bw.Write(meshes[i].weights[e, 5]);
                            bw.Write(meshes[i].weights[e, 6]);
                            bw.Write(meshes[i].weights[e, 7]);
                        }
                        var compressed = new MemoryStream();
                        using var buff = new BinaryWriter(compressed);
                        var (zsize, crc) = buff.CompressAndWrite(buffer.ToArray());

                        chunk.SkinWeightsExt = new DataBuffer(cr2w, chunk, "skinWeightsExt") { IsSerialized = true };
                        chunk.SkinWeightsExt.Buffer = new CUInt16(cr2w, chunk.SkinWeightsExt, "Buffer") { Value = (UInt16)(cr2w.Buffers.Count + 1), IsSerialized = true };

                        uint idx = (uint)cr2w.Buffers.Count;
                        cr2w.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()
                        {
                            flags = 0,
                            index = idx,
                            offset = 0,
                            diskSize = zsize,
                            memSize = (UInt32)buffer.Length,
                            crc32 = crc
                        }));

                        cr2w.Buffers[(int)idx].ReadData(new BinaryReader(compressed));
                        cr2w.Buffers[(int)idx].Offset = cr2w.Buffers[(int)idx - 1].Offset + cr2w.Buffers[(int)idx - 1].DiskSize;
                    }
                    if (meshes[i].weightcount > 4)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].vertices.Length; e++)
                        {
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 4]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 5]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 6]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 7]));
                        }
                        var compressed = new MemoryStream();
                        using var buff = new BinaryWriter(compressed);
                        var (zsize, crc) = buff.CompressAndWrite(buffer.ToArray());

                        chunk.SkinIndicesExt = new DataBuffer(cr2w, chunk, "skinIndicesExt") { IsSerialized = true };
                        chunk.SkinIndicesExt.Buffer = new CUInt16(cr2w, chunk.SkinIndicesExt, "Buffer") { Value = (UInt16)(cr2w.Buffers.Count + 1), IsSerialized = true };

                        uint idx = (uint)cr2w.Buffers.Count;
                        cr2w.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()
                        {
                            flags = 0,
                            index = idx,
                            offset = 0,
                            diskSize = zsize,
                            memSize = (UInt32)buffer.Length,
                            crc32 = crc
                        }));

                        cr2w.Buffers[(int)idx].ReadData(new BinaryReader(compressed));
                        cr2w.Buffers[(int)idx].Offset = cr2w.Buffers[(int)idx - 1].Offset + cr2w.Buffers[(int)idx - 1].DiskSize;
                    }
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].normals.Length; e++)
                        {
                            bw.Write(meshes[i].normals[e].X);
                            bw.Write(meshes[i].normals[e].Y);
                            bw.Write(meshes[i].normals[e].Z);
                        }
                        var compressed = new MemoryStream();
                        using var buff = new BinaryWriter(compressed);
                        var (zsize, crc) = buff.CompressAndWrite(buffer.ToArray());

                        chunk.Normals = new DataBuffer(cr2w, chunk,"normals") { IsSerialized = true };
                        chunk.Normals.Buffer = new CUInt16(cr2w, chunk.Normals, "Buffer") { Value = (UInt16)(cr2w.Buffers.Count + 1), IsSerialized = true };

                        uint idx = (uint)cr2w.Buffers.Count;
                        cr2w.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()
                        {
                            flags = 0,
                            index = idx,
                            offset = 0,
                            diskSize = zsize,
                            memSize = (UInt32)buffer.Length,
                            crc32 = crc
                        }));

                        cr2w.Buffers[(int)idx].ReadData(new BinaryReader(compressed));
                        cr2w.Buffers[(int)idx].Offset = cr2w.Buffers[(int)idx - 1].Offset + cr2w.Buffers[(int)idx - 1].DiskSize;
                    }
                    blob.Chunks.Add(chunk);
                    meshes[i].weightcount = 0;
                }
                blob.LodChunkIndices = new CArray<CArray<CUInt16>>(cr2w, blob, "lodChunkIndices") { IsSerialized = true };
                blob.LodChunkIndices.Add(new CArray<CUInt16>(cr2w, blob.LodChunkIndices, "0") { IsSerialized = true });
                if (LODLvl.Contains(2U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>(cr2w, blob.LodChunkIndices, "1") { IsSerialized = true });
                }
                if (LODLvl.Contains(4U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>(cr2w, blob.LodChunkIndices, "3") { IsSerialized = true });
                }
                if (LODLvl.Contains(8U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>(cr2w, blob.LodChunkIndices, "4") { IsSerialized = true });
                }
                for(ushort i = 0; i < LODLvl.Length; i++)
                {
                    if(LODLvl[i] == 1)
                    {
                        blob.LodChunkIndices[0].Add(new CUInt16(cr2w, blob.LodChunkIndices[0], Convert.ToString(blob.LodChunkIndices[0].Count)) { IsSerialized = true, Value = i });
                    }
                    if (LODLvl[i] == 2)
                    {
                        blob.LodChunkIndices[1].Add(new CUInt16(cr2w, blob.LodChunkIndices[1], Convert.ToString(blob.LodChunkIndices[1].Count)) { IsSerialized = true, Value = i });
                    }
                    if (LODLvl[i] == 4)
                    {
                        blob.LodChunkIndices[2].Add(new CUInt16(cr2w, blob.LodChunkIndices[2], Convert.ToString(blob.LodChunkIndices[2].Count)) { IsSerialized = true, Value = i });
                    }
                    if (LODLvl[i] == 8)
                    {
                        blob.LodChunkIndices[3].Add(new CUInt16(cr2w, blob.LodChunkIndices[3], Convert.ToString(blob.LodChunkIndices[3].Count)) { IsSerialized = true, Value = i });
                    }
                }
            }
            if (cr2w.Chunks.Select(_ => _.Data).OfType<meshMeshParamCloth_Graphical>().Any())
            {
                var blob = cr2w.Chunks.Select(_ => _.Data).OfType<meshMeshParamCloth_Graphical>().First();
                blob.Chunks = new CArray<meshGfxClothChunkData>(cr2w, blob, "chunks") { IsSerialized = true };
                for (int i = 0; i < meshes.Count; i++)
                {
                    var chunk = new meshGfxClothChunkData(cr2w, blob.Chunks, Convert.ToString(i)) { IsSerialized = true };
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].vertices.Length; e++)
                        {
                            bw.Write(meshes[i].vertices[e].X);
                            bw.Write(meshes[i].vertices[e].Y);
                            bw.Write(meshes[i].vertices[e].Z);
                        }
                        var compressed = new MemoryStream();
                        using var buff = new BinaryWriter(compressed);
                        var (zsize, crc) = buff.CompressAndWrite(buffer.ToArray());

                        chunk.Positions = new DataBuffer(cr2w, chunk, "positions") { IsSerialized = true };
                        chunk.Positions.Buffer = new CUInt16(cr2w, chunk.Positions, "Buffer") { Value = (UInt16)(cr2w.Buffers.Count + 1), IsSerialized = true };

                        uint idx = (uint)cr2w.Buffers.Count;
                        cr2w.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()
                        {
                            flags = 0,
                            index = idx,
                            offset = 0,
                            diskSize = zsize,
                            memSize = (UInt32)buffer.Length,
                            crc32 = crc
                        }));

                        cr2w.Buffers[(int)idx].ReadData(new BinaryReader(compressed));
                        cr2w.Buffers[(int)idx].Offset = cr2w.Buffers[(int)idx - 1].Offset + cr2w.Buffers[(int)idx - 1].DiskSize;
                    }
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].indices.Length; e++)
                        {
                            bw.Write(Convert.ToUInt16(meshes[i].indices[e]));
                        }
                        var compressed = new MemoryStream();
                        using var buff = new BinaryWriter(compressed);
                        var (zsize, crc) = buff.CompressAndWrite(buffer.ToArray());

                        chunk.Indices = new DataBuffer(cr2w, chunk, "indices") { IsSerialized = true };
                        chunk.Indices.Buffer = new CUInt16(cr2w, chunk.Indices, "Buffer") { Value = (UInt16)(cr2w.Buffers.Count + 1), IsSerialized = true };

                        uint idx = (uint)cr2w.Buffers.Count;
                        cr2w.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()
                        {
                            flags = 0,
                            index = idx,
                            offset = 0,
                            diskSize = zsize,
                            memSize = (UInt32)buffer.Length,
                            crc32 = crc
                        }));

                        cr2w.Buffers[(int)idx].ReadData(new BinaryReader(compressed));
                        cr2w.Buffers[(int)idx].Offset = cr2w.Buffers[(int)idx - 1].Offset + cr2w.Buffers[(int)idx - 1].DiskSize;
                    }
                    if (meshes[i].weightcount > 0)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].vertices.Length; e++)
                        {
                            bw.Write(meshes[i].weights[e, 0]);
                            bw.Write(meshes[i].weights[e, 1]);
                            bw.Write(meshes[i].weights[e, 2]);
                            bw.Write(meshes[i].weights[e, 3]);
                        }
                        var compressed = new MemoryStream();
                        using var buff = new BinaryWriter(compressed);
                        var (zsize, crc) = buff.CompressAndWrite(buffer.ToArray());

                        chunk.SkinWeights = new DataBuffer(cr2w, chunk, "skinWeights") { IsSerialized = true };
                        chunk.SkinWeights.Buffer = new CUInt16(cr2w, chunk.SkinWeights, "Buffer") { Value = (UInt16)(cr2w.Buffers.Count + 1), IsSerialized = true };

                        uint idx = (uint)cr2w.Buffers.Count;
                        cr2w.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()
                        {
                            flags = 0,
                            index = idx,
                            offset = 0,
                            diskSize = zsize,
                            memSize = (UInt32)buffer.Length,
                            crc32 = crc
                        }));

                        cr2w.Buffers[(int)idx].ReadData(new BinaryReader(compressed));
                        cr2w.Buffers[(int)idx].Offset = cr2w.Buffers[(int)idx - 1].Offset + cr2w.Buffers[(int)idx - 1].DiskSize;
                    }
                    if (meshes[i].weightcount > 0)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].vertices.Length; e++)
                        {
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 0]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 1]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 2]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 3]));
                        }
                        var compressed = new MemoryStream();
                        using var buff = new BinaryWriter(compressed);
                        var (zsize, crc) = buff.CompressAndWrite(buffer.ToArray());

                        chunk.SkinIndices = new DataBuffer(cr2w, chunk, "skinIndices") { IsSerialized = true };
                        chunk.SkinIndices.Buffer = new CUInt16(cr2w, chunk.SkinIndices, "Buffer") { Value = (UInt16)(cr2w.Buffers.Count + 1), IsSerialized = true };

                        uint idx = (uint)cr2w.Buffers.Count;
                        cr2w.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()
                        {
                            flags = 0,
                            index = idx,
                            offset = 0,
                            diskSize = zsize,
                            memSize = (UInt32)buffer.Length,
                            crc32 = crc
                        }));

                        cr2w.Buffers[(int)idx].ReadData(new BinaryReader(compressed));
                        cr2w.Buffers[(int)idx].Offset = cr2w.Buffers[(int)idx - 1].Offset + cr2w.Buffers[(int)idx - 1].DiskSize;
                    }
                    if (meshes[i].weightcount > 4)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].vertices.Length; e++)
                        {
                            bw.Write(meshes[i].weights[e, 4]);
                            bw.Write(meshes[i].weights[e, 5]);
                            bw.Write(meshes[i].weights[e, 6]);
                            bw.Write(meshes[i].weights[e, 7]);
                        }
                        var compressed = new MemoryStream();
                        using var buff = new BinaryWriter(compressed);
                        var (zsize, crc) = buff.CompressAndWrite(buffer.ToArray());

                        chunk.SkinWeightsExt = new DataBuffer(cr2w, chunk, "skinWeightsExt") { IsSerialized = true };
                        chunk.SkinWeightsExt.Buffer = new CUInt16(cr2w, chunk.SkinWeightsExt, "Buffer") { Value = (UInt16)(cr2w.Buffers.Count + 1), IsSerialized = true };

                        uint idx = (uint)cr2w.Buffers.Count;
                        cr2w.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()
                        {
                            flags = 0,
                            index = idx,
                            offset = 0,
                            diskSize = zsize,
                            memSize = (UInt32)buffer.Length,
                            crc32 = crc
                        }));

                        cr2w.Buffers[(int)idx].ReadData(new BinaryReader(compressed));
                        cr2w.Buffers[(int)idx].Offset = cr2w.Buffers[(int)idx - 1].Offset + cr2w.Buffers[(int)idx - 1].DiskSize;
                    }
                    if (meshes[i].weightcount > 4)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].vertices.Length; e++)
                        {
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 4]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 5]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 6]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 7]));
                        }
                        var compressed = new MemoryStream();
                        using var buff = new BinaryWriter(compressed);
                        var (zsize, crc) = buff.CompressAndWrite(buffer.ToArray());

                        chunk.SkinIndicesExt = new DataBuffer(cr2w, chunk, "skinIndicesExt") { IsSerialized = true };
                        chunk.SkinIndicesExt.Buffer = new CUInt16(cr2w, chunk.SkinIndicesExt, "Buffer") { Value = (UInt16)(cr2w.Buffers.Count + 1), IsSerialized = true };

                        uint idx = (uint)cr2w.Buffers.Count;
                        cr2w.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()
                        {
                            flags = 0,
                            index = idx,
                            offset = 0,
                            diskSize = zsize,
                            memSize = (UInt32)buffer.Length,
                            crc32 = crc
                        }));

                        cr2w.Buffers[(int)idx].ReadData(new BinaryReader(compressed));
                        cr2w.Buffers[(int)idx].Offset = cr2w.Buffers[(int)idx - 1].Offset + cr2w.Buffers[(int)idx - 1].DiskSize;
                    }
                    {
                        chunk.Simulation = new CArray<CUInt16>(cr2w, chunk, "simulation") { IsSerialized = true };
                        int z = 0;
                        for (ushort e = 0; e < meshes[i].colors1.Length; e++)
                        {
                            if(meshes[i].colors1[e].X > 0.01f)
                            {
                                var val = new CUInt16(cr2w, chunk.Simulation, Convert.ToString(z)) { IsSerialized = true, Value = e };
                                chunk.Simulation.Add(val);
                                z++;
                            }
                        }
                    }
                    blob.Chunks.Add(chunk);
                    meshes[i].weightcount = 0;
                }
                blob.LodChunkIndices = new CArray<CArray<CUInt16>>(cr2w, blob, "lodChunkIndices") { IsSerialized = true };
                blob.LodChunkIndices.Add(new CArray<CUInt16>(cr2w, blob.LodChunkIndices, "0") { IsSerialized = true });
                if (LODLvl.Contains(2U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>(cr2w, blob.LodChunkIndices, "1") { IsSerialized = true });
                }
                if (LODLvl.Contains(4U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>(cr2w, blob.LodChunkIndices, "3") { IsSerialized = true });
                }
                if (LODLvl.Contains(8U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>(cr2w, blob.LodChunkIndices, "4") { IsSerialized = true });
                }
                for (ushort i = 0; i < LODLvl.Length; i++)
                {
                    if (LODLvl[i] == 1)
                    {
                        blob.LodChunkIndices[0].Add(new CUInt16(cr2w, blob.LodChunkIndices[0], Convert.ToString(blob.LodChunkIndices[0].Count)) { IsSerialized = true, Value = i });
                    }
                    if (LODLvl[i] == 2)
                    {
                        blob.LodChunkIndices[1].Add(new CUInt16(cr2w, blob.LodChunkIndices[1], Convert.ToString(blob.LodChunkIndices[1].Count)) { IsSerialized = true, Value = i });
                    }
                    if (LODLvl[i] == 4)
                    {
                        blob.LodChunkIndices[2].Add(new CUInt16(cr2w, blob.LodChunkIndices[2], Convert.ToString(blob.LodChunkIndices[2].Count)) { IsSerialized = true, Value = i });
                    }
                    if (LODLvl[i] == 8)
                    {
                        blob.LodChunkIndices[3].Add(new CUInt16(cr2w, blob.LodChunkIndices[3], Convert.ToString(blob.LodChunkIndices[3].Count)) { IsSerialized = true, Value = i });
                    }
                }
            }
        }
    }
}
