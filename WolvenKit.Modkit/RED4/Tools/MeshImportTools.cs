using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CP77.CR2W;
using SharpGLTF.Schema2;
using SharpGLTF.Validation;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.RED4;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4
{
    using Vec2 = System.Numerics.Vector2;
    using Vec3 = System.Numerics.Vector3;
    using Vec4 = System.Numerics.Vector4;
    public partial class ModTools
    {
        public bool ImportMesh(FileInfo inGltfFile, Stream inmeshStream, List<Archive> archives = null, ValidationMode vmode = ValidationMode.Strict, bool importMaterialOnly = false, Stream outStream = null)
        {
            var cr2w = _wolvenkitFileService.TryReadRed4File(inmeshStream);

            if (cr2w == null || !cr2w.Chunks.OfType<CMesh>().Any() || !cr2w.Chunks.OfType<rendRenderMeshBlob>().Any())
            {
                return false;
            }

            var meshBlob = cr2w.Chunks.OfType<CMesh>().First();
            var rendBlob = cr2w.Chunks.OfType<rendRenderMeshBlob>().First();

            if (File.Exists(Path.ChangeExtension(inGltfFile.FullName, ".Material.json")))
            {
                if (archives != null)
                {
                    WriteMatToMesh(ref cr2w, File.ReadAllText(Path.ChangeExtension(inGltfFile.FullName, ".Material.json")), archives);
                }
                if (importMaterialOnly)
                {
                    MemoryStream matOnlyStream = new MemoryStream();

                    //cr2w.Write(new BinaryWriter(matOnlyStream));
                    using var writer = new CR2WWriter(matOnlyStream);
                    writer.WriteFile(cr2w);


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
            Vec3 max = new Vec3(Meshes[0].positions[0].X, Meshes[0].positions[0].Y, Meshes[0].positions[0].Z);
            Vec3 min = new Vec3(Meshes[0].positions[0].X, Meshes[0].positions[0].Y, Meshes[0].positions[0].Z);

            for (int e = 0; e < Meshes.Count; e++)
            {
                for (int i = 0; i < Meshes[e].positions.Length; i++)
                {
                    if (Meshes[e].positions[i].X >= max.X)
                        max.X = Meshes[e].positions[i].X;
                    if (Meshes[e].positions[i].Y >= max.Y)
                        max.Y = Meshes[e].positions[i].Y;
                    if (Meshes[e].positions[i].Z >= max.Z)
                        max.Z = Meshes[e].positions[i].Z;
                    if (Meshes[e].positions[i].X <= min.X)
                        min.X = Meshes[e].positions[i].X;
                    if (Meshes[e].positions[i].Y <= min.Y)
                        min.Y = Meshes[e].positions[i].Y;
                    if (Meshes[e].positions[i].Z <= min.Z)
                        min.Z = Meshes[e].positions[i].Z;
                }
            }

            // updating bounding box
            meshBlob.BoundingBox.Min.X = min.X;
            meshBlob.BoundingBox.Min.Y = min.Y;
            meshBlob.BoundingBox.Min.Z = min.Z;
            meshBlob.BoundingBox.Max.X = max.X;
            meshBlob.BoundingBox.Max.Y = max.Y;
            meshBlob.BoundingBox.Max.Z = max.Z;

            Vec4 QuantScale = new Vec4((max.X - min.X) / 2, (max.Y - min.Y) / 2, (max.Z - min.Z) / 2, 0);
            Vec4 QuantTrans = new Vec4((max.X + min.X) / 2, (max.Y + min.Y) / 2, (max.Z + min.Z) / 2, 1);


            RawArmature newRig = MeshTools.GetOrphanRig(cr2w.Chunks.OfType<rendRenderMeshBlob>().First(), cr2w);
            RawArmature oldRig = null;
            if (model.LogicalSkins.Count != 0)
            {
                oldRig = new RawArmature();
                oldRig.BoneCount = model.LogicalSkins[0].JointsCount;
                oldRig.Names = new string[oldRig.BoneCount];

                for (int i = 0; i < model.LogicalSkins[0].JointsCount; i++)
                {
                    oldRig.Names[i] = model.LogicalSkins[0].GetJoint(i).Joint.Name;
                }
            }
            MeshTools.UpdateMeshJoints(ref Meshes, newRig, oldRig);

            UpdateSkinningParamCloth(ref Meshes, ref cr2w);

            List<Re4MeshContainer> expMeshes = new List<Re4MeshContainer>();

            for (int i = 0; i < Meshes.Count; i++)
            {
                expMeshes.Add(RawMeshToRE4Mesh(Meshes[i], QuantScale, QuantTrans));
            }

            MemoryStream meshBuffer = new MemoryStream();
            MeshesInfo meshesInfo = BufferWriter(expMeshes, ref meshBuffer);

            meshesInfo.quantScale = QuantScale;
            meshesInfo.quantTrans = QuantTrans;

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
            RawMeshContainer meshContainer = new RawMeshContainer();
            meshContainer.name = mesh.Name;

            List<string> accessors = mesh.Primitives[0].VertexAccessors.Keys.ToList();

            List<uint> indicesList = mesh.Primitives[0].GetIndices().ToList();

            if (mesh.Name.ToLower().Contains("double"))
            {
                meshContainer.indices = new uint[indicesList.Count * 2];
                for (int i = 0; i < indicesList.Count; i += 3)
                {
                    // RHS to LHS face orientations
                    meshContainer.indices[i] = indicesList[i + 1];
                    meshContainer.indices[i + 1] = indicesList[i];
                    meshContainer.indices[i + 2] = indicesList[i + 2];

                    meshContainer.indices[indicesList.Count + i] = indicesList[i];
                    meshContainer.indices[indicesList.Count + i + 1] = indicesList[i + 1];
                    meshContainer.indices[indicesList.Count + i + 2] = indicesList[i + 2];
                }
            }
            else
            {
                meshContainer.indices = new uint[indicesList.Count];
                for (int i = 0; i < indicesList.Count; i += 3)
                {
                    // RHS to LHS face orientations
                    meshContainer.indices[i] = indicesList[i + 1];
                    meshContainer.indices[i + 1] = indicesList[i];
                    meshContainer.indices[i + 2] = indicesList[i + 2];
                }
            }


            List<Vec3> verticesList = mesh.Primitives[0].GetVertices("POSITION").AsVector3Array().ToList();
            List<Vec3> normalsList = mesh.Primitives[0].GetVertices("NORMAL").AsVector3Array().ToList();
            List<Vec4> tangentsList = mesh.Primitives[0].GetVertices("TANGENT").AsVector4Array().ToList();

            int vertCount = verticesList.Count;
            meshContainer.positions = new Vec3[verticesList.Count];
            meshContainer.normals = new Vec3[normalsList.Count];
            meshContainer.tangents = new Vec4[tangentsList.Count];

            // changing orientation of geomerty, Y+ Z+ RHS-LHS BS
            for (int i = 0; i < vertCount; i++)
            {
                meshContainer.positions[i] = new Vec3(verticesList[i].X, -verticesList[i].Z, verticesList[i].Y);
                meshContainer.normals[i] = new Vec3(normalsList[i].X, -normalsList[i].Z, normalsList[i].Y);
                meshContainer.tangents[i] = new Vec4(tangentsList[i].X, -tangentsList[i].Z, tangentsList[i].Y, tangentsList[i].W);
            }

            meshContainer.colors0 = new Vec4[vertCount];
            if (accessors.Contains("COLOR_0"))
                meshContainer.colors0 = mesh.Primitives[0].GetVertices("COLOR_0").AsVector4Array().ToArray();

            meshContainer.colors1 = new Vec4[vertCount];
            if (accessors.Contains("COLOR_1"))
                meshContainer.colors1 = mesh.Primitives[0].GetVertices("COLOR_1").AsVector4Array().ToArray();

            meshContainer.texCoords0 = new Vec2[vertCount];
            if (accessors.Contains("TEXCOORD_0"))
                meshContainer.texCoords0 = mesh.Primitives[0].GetVertices("TEXCOORD_0").AsVector2Array().ToArray();

            meshContainer.texCoords1 = new Vec2[vertCount];
            if (accessors.Contains("TEXCOORD_1"))
                meshContainer.texCoords1 = mesh.Primitives[0].GetVertices("TEXCOORD_1").AsVector2Array().ToArray();

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

            meshContainer.weightCount = 0;

            if (joints0.Count != 0)
                meshContainer.weightCount += 4;
            if (joints1.Count != 0)
                meshContainer.weightCount += 4;


            meshContainer.boneindices = new UInt16[vertCount, meshContainer.weightCount];
            meshContainer.weights = new float[vertCount, meshContainer.weightCount];

            for (int i = 0; i < vertCount; i++)
            {
                if (joints0.Count != 0)
                {
                    meshContainer.boneindices[i, 0] = (UInt16)joints0[i].X;
                    meshContainer.boneindices[i, 1] = (UInt16)joints0[i].Y;
                    meshContainer.boneindices[i, 2] = (UInt16)joints0[i].Z;
                    meshContainer.boneindices[i, 3] = (UInt16)joints0[i].W;

                    meshContainer.weights[i, 0] = weights0[i].X;
                    meshContainer.weights[i, 1] = weights0[i].Y;
                    meshContainer.weights[i, 2] = weights0[i].Z;
                    meshContainer.weights[i, 3] = weights0[i].W;
                }
                if (joints1.Count != 0)
                {
                    meshContainer.boneindices[i, 4] = (UInt16)joints1[i].X;
                    meshContainer.boneindices[i, 5] = (UInt16)joints1[i].Y;
                    meshContainer.boneindices[i, 6] = (UInt16)joints1[i].Z;
                    meshContainer.boneindices[i, 7] = (UInt16)joints1[i].W;

                    meshContainer.weights[i, 4] = weights1[i].X;
                    meshContainer.weights[i, 5] = weights1[i].Y;
                    meshContainer.weights[i, 6] = weights1[i].Z;
                    meshContainer.weights[i, 7] = weights1[i].W;
                }
            }

            meshContainer.garmentMorph = new Vec3[0];
            if (mesh.Primitives[0].MorphTargetsCount > 0)
            {
                meshContainer.garmentMorph = new Vec3[vertCount];
                int idx = mesh.Primitives[0].GetMorphTargetAccessors(0).Keys.ToList().IndexOf("POSITION");
                List<Vec3> extraDataList = mesh.Primitives[0].GetMorphTargetAccessors(0).Values.ToList()[idx].AsVector3Array().ToList();

                for (int i = 0; i < extraDataList.Count; i++)
                {
                    meshContainer.garmentMorph[i] = new Vec3(extraDataList[i].X, -extraDataList[i].Z, extraDataList[i].Y);
                }
            }

            return meshContainer;
        }
        static Re4MeshContainer RawMeshToRE4Mesh(RawMeshContainer mesh, Vec4 qScale, Vec4 qTrans)
        {
            Re4MeshContainer Re4Mesh = new Re4MeshContainer();
            Re4Mesh.name = mesh.name;

            int vertCount = mesh.positions.Length;
            Re4Mesh.ExpVerts = new Int16[vertCount, 3];

            for (int i = 0; i < vertCount; i++)
            {
                float x = (mesh.positions[i].X - qTrans.X) / qScale.X;
                float y = (mesh.positions[i].Y - qTrans.Y) / qScale.Y;
                float z = (mesh.positions[i].Z - qTrans.Z) / qScale.Z;
                Re4Mesh.ExpVerts[i, 0] = Convert.ToInt16(x * 32767);
                Re4Mesh.ExpVerts[i, 1] = Convert.ToInt16(y * 32767);
                Re4Mesh.ExpVerts[i, 2] = Convert.ToInt16(z * 32767);
            }

            // managing normals
            Re4Mesh.Nor32s = new UInt32[vertCount];
            for (int i = 0; i < vertCount; i++)
            {
                Vec4 v = new Vec4(mesh.normals[i], 0); // for normal w == 0
                Re4Mesh.Nor32s[i] = Converters.Vec4ToU32(v);
            }

            // managing tangents
            Re4Mesh.Tan32s = new UInt32[vertCount];
            for (int i = 0; i < vertCount; i++)
            {
                Vec4 v = mesh.tangents[i]; // for tangents w == 1 or -1
                Re4Mesh.Tan32s[i] = Converters.Vec4ToU32(v);
            }

            Re4Mesh.uv0s = new UInt16[vertCount, 2];
            for (int i = 0; i < mesh.texCoords0.Length; i++)
            {
                Re4Mesh.uv0s[i, 0] = Converters.converthf(mesh.texCoords0[i].X);
                Re4Mesh.uv0s[i, 1] = Converters.converthf(mesh.texCoords0[i].Y);
            }

            Re4Mesh.uv1s = new UInt16[vertCount, 2];
            for (int i = 0; i < mesh.texCoords1.Length; i++)
            {
                Re4Mesh.uv1s[i, 0] = Converters.converthf(mesh.texCoords1[i].X);
                Re4Mesh.uv1s[i, 1] = Converters.converthf(mesh.texCoords1[i].Y);
            }

            Re4Mesh.colors = new byte[vertCount, 4];
            for (int i = 0; i < mesh.colors0.Length; i++)
            {
                Re4Mesh.colors[i, 0] = Convert.ToByte(mesh.colors0[i].X * 255);
                Re4Mesh.colors[i, 1] = Convert.ToByte(mesh.colors0[i].Y * 255);
                Re4Mesh.colors[i, 2] = Convert.ToByte(mesh.colors0[i].Z * 255);
                Re4Mesh.colors[i, 3] = Convert.ToByte(mesh.colors0[i].W * 255);
            }

            Re4Mesh.weightcount = mesh.weightCount;

            Re4Mesh.boneindices = new byte[vertCount, Re4Mesh.weightcount];
            for (int i = 0; i < vertCount; i++)
                for (int e = 0; e < Re4Mesh.weightcount; e++)
                    Re4Mesh.boneindices[i, e] = Convert.ToByte(mesh.boneindices[i, e]); // mesh.boneindices are supposed to be processed
                                                                                        // (updated according to the mesh bones rather than rig bones) before putting here

            Re4Mesh.weights = new byte[vertCount, Re4Mesh.weightcount];
            for (int i = 0; i < vertCount; i++)
            {
                for (int e = 0; e < Re4Mesh.weightcount; e++)
                {
                    Re4Mesh.weights[i, e] = Convert.ToByte(mesh.weights[i, e] * 255);
                }
                // weight summing can cause problems here, sometimes sum >= 256, idk how to fix them yet
            }

            // extradata/ morphoffsetbs
            Re4Mesh.garmentMorph = new UInt16[0, 0];
            if (mesh.garmentMorph.Length > 0)
            {
                Re4Mesh.garmentMorph = new UInt16[vertCount, 3];
                for (int i = 0; i < vertCount; i++)
                {
                    Re4Mesh.garmentMorph[i, 0] = Converters.converthf(mesh.garmentMorph[i].X);
                    Re4Mesh.garmentMorph[i, 1] = Converters.converthf(mesh.garmentMorph[i].Y);
                    Re4Mesh.garmentMorph[i, 2] = Converters.converthf(mesh.garmentMorph[i].Z);
                }
            }

            Re4Mesh.indices = new UInt16[mesh.indices.Length];
            for (int i = 0; i < mesh.indices.Length; i++)
                Re4Mesh.indices[i] = Convert.ToUInt16(mesh.indices[i]);

            return Re4Mesh;
        }
        static MeshesInfo BufferWriter(List<Re4MeshContainer> expMeshes, ref MemoryStream ms)
        {
            MeshesInfo meshesInfo = new MeshesInfo(expMeshes.Count);

            BinaryWriter bw = new BinaryWriter(ms);
            for (int i = 0; i < expMeshes.Count; i++)
            {
                int vertCount = expMeshes[i].ExpVerts.Length / 3;

                meshesInfo.vertCounts[i] = (UInt32)vertCount;
                meshesInfo.posnOffsets[i] = (UInt32)ms.Position;

                meshesInfo.vpStrides[i] = expMeshes[i].weightcount * 2 + 8;
                meshesInfo.weightCounts[i] = expMeshes[i].weightcount;

                if (expMeshes[i].garmentMorph.Length > 0)
                {
                    meshesInfo.garmentSupportExists[i] = true;
                    meshesInfo.vpStrides[i] += 8;
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

                    if (meshesInfo.garmentSupportExists[i])
                    {
                        bw.Write(expMeshes[i].garmentMorph[e, 0]);
                        bw.Write(expMeshes[i].garmentMorph[e, 1]);
                        bw.Write(expMeshes[i].garmentMorph[e, 2]);
                        bw.Write((UInt16)0);
                    }
                }

                long paddingLen = 0;

                // 16 bytes Padding between vertexBlock and uv0, if required
                paddingLen = ((ms.Length + 15U) & (~15)) - ms.Length;
                bw.Write(new Byte[paddingLen]);

                // writing tx0s
                meshesInfo.tex0Offsets[i] = (UInt32)ms.Position;
                for (int e = 0; e < vertCount; e++)
                {
                    bw.Write(expMeshes[i].uv0s[e, 0]);
                    bw.Write(expMeshes[i].uv0s[e, 1]);
                }

                // 16 bytes Padding between uv0 and normals, if required
                paddingLen = ((ms.Length + 15U) & (~15)) - ms.Length;
                bw.Write(new Byte[paddingLen]);

                // writing normals and tangents
                meshesInfo.normalOffsets[i] = (UInt32)ms.Position;
                for (int e = 0; e < vertCount; e++)
                {
                    bw.Write(expMeshes[i].Nor32s[e]);
                    bw.Write(expMeshes[i].Tan32s[e]);
                }

                // 16 bytes Padding between nors/tans and colors/uv1s, if required
                paddingLen = ((ms.Length + 15U) & (~15)) - ms.Length;
                bw.Write(new Byte[paddingLen]);

                // writing colors and tx1s
                meshesInfo.colorOffsets[i] = (UInt32)ms.Position;
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

                // 16 bytes Padding if necessary
                paddingLen = ((ms.Length + 15U) & (~15)) - ms.Length;
                bw.Write(new Byte[paddingLen]);

                // for the unusual lightblocker data
                /*
                unknownOffsets[i] = (UInt32)ms.Position;

                for (int e = 0; e < vertCount; e++)
                {
                    bw.Write((float)0f);
                }
                */
                meshesInfo.vertBufferSize = (UInt32)ms.Length;

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

            meshesInfo.indexBufferOffset = (UInt32)ms.Position;
            for (int i = 0; i < expMeshes.Count; i++)
            {
                int indCount = expMeshes[i].indices.Length;
                meshesInfo.indCounts[i] = (UInt32)indCount;

                meshesInfo.indicesOffsets[i] = (UInt32)ms.Position;
                for (int e = 0; e < indCount; e++)
                    bw.Write(expMeshes[i].indices[e]);
            }
            meshesInfo.indexBufferSize = (UInt32)ms.Length - meshesInfo.indexBufferOffset;


            for (int i = 0; i < meshesInfo.meshCount; i++)
            {
                if (expMeshes[i].name.Contains("LOD"))
                {
                    int idx = expMeshes[i].name.IndexOf("LOD_");
                    if (idx < expMeshes[i].name.Length - 1)
                    {
                        meshesInfo.LODLvl[i] = Convert.ToUInt32(expMeshes[i].name.Substring(idx + 4, 1));
                    }
                }
                else
                {
                    meshesInfo.LODLvl[i] = 1;
                }

            }

            return meshesInfo;
        }
        static MemoryStream GetEditedCr2wFile(CR2WFile cr2w, MeshesInfo info, MemoryStream buffer)
        {
            var blob = cr2w.Chunks.OfType<rendRenderMeshBlob>().First();
            // removing BS topology data which causes a lot of issues with improved facial lighting geomerty, vertex colors uroborus and what not
            int Count = blob.Header.Topology.Count;

            for (int i = 0; i < Count; i++)
            {
                blob.Header.Topology.Remove(blob.Header.Topology[0]);
            }
            for (int i = 0; i < info.meshCount; i++)
            {
                blob.Header.Topology.Add(new rendTopologyData() );
            }

            //dependent RenderLOD's removal and addition
            Count = blob.Header.RenderLODs.Count;
            if (Count > 1)
            {
                for (int i = 0; i < Count; i++)
                {
                    blob.Header.RenderLODs.Remove(blob.Header.RenderLODs[0]);
                }
                blob.Header.RenderLODs.Add(0f);
                if (info.LODLvl.ToList().Contains(2))
                {
                    blob.Header.RenderLODs.Add(3f);
                }
                if (info.LODLvl.ToList().Contains(4))
                {
                    blob.Header.RenderLODs.Add(6f);
                }
                if (info.LODLvl.ToList().Contains(8))
                {
                    blob.Header.RenderLODs.Add(9f);
                }
            }
            if (cr2w.Chunks.OfType<CMesh>().Any())
            {
                var cmeshblob = cr2w.Chunks.OfType<CMesh>().First();
                Count = cmeshblob.LodLevelInfo.Count;
                if (Count > 1)
                {
                    for (int i = 0; i < Count; i++)
                    {
                        cmeshblob.LodLevelInfo.Remove(cmeshblob.LodLevelInfo[0]);
                    }
                    cmeshblob.LodLevelInfo.Add(0f);
                    if (info.LODLvl.ToList().Contains(2))
                    {
                        cmeshblob.LodLevelInfo.Add(3f);
                    }
                    if (info.LODLvl.ToList().Contains(4))
                    {
                        cmeshblob.LodLevelInfo.Add(6f);
                    }
                    if (info.LODLvl.ToList().Contains(8))
                    {
                        cmeshblob.LodLevelInfo.Add(9f);
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
            for (int i = 0; i < info.meshCount; i++)
            {
                rendChunk chunk = new rendChunk() ;

                chunk.LodMask = Convert.ToByte(info.LODLvl[i]);

                chunk.RenderMask = Enums.EMeshChunkFlags.MCF_RenderInScene | Enums.EMeshChunkFlags.MCF_RenderInShadows;

                // vertexfactory is really important to be taken care of properly
                // based upon VertexBlock, subject to change, incremental will be good, for weightcount ++ etc
                chunk.VertexFactory = Convert.ToByte(2);

                chunk.NumIndices = info.indCounts[i];
                chunk.NumVertices = Convert.ToUInt16(info.vertCounts[i]);

                chunk.ChunkIndices = new rendIndexBufferChunk() ;
                chunk.ChunkIndices.Pe = Enums.GpuWrapApieIndexBufferChunkType.IBCT_IndexUShort;
                chunk.ChunkIndices.TeOffset = info.indicesOffsets[i] - info.indexBufferOffset;


                chunk.ChunkVertices = new rendVertexBufferChunk();
                chunk.ChunkVertices.ByteOffsets.Add(info.posnOffsets[i]);
                chunk.ChunkVertices.ByteOffsets.Add(info.tex0Offsets[i]);
                chunk.ChunkVertices.ByteOffsets.Add(info.normalOffsets[i]);
                chunk.ChunkVertices.ByteOffsets.Add(info.colorOffsets[i]);
                chunk.ChunkVertices.ByteOffsets.Add(info.unknownOffsets[i]);

                chunk.ChunkVertices.VertexLayout = new GpuWrapApiVertexLayoutDesc() ;

                // fishy hash and slotmask, subject to change
                chunk.ChunkVertices.VertexLayout.Hash =  0;
                chunk.ChunkVertices.VertexLayout.SlotMask = 0;

                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(Convert.ToByte(info.vpStrides[i]));
                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(Convert.ToByte(4));
                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(Convert.ToByte(8));
                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(Convert.ToByte(8));
                if (info.unknownOffsets[i] == 0)
                {
                    chunk.ChunkVertices.VertexLayout.SlotStrides.Add(Convert.ToByte(0));
                }
                else
                {
                    chunk.ChunkVertices.VertexLayout.SlotStrides.Add(Convert.ToByte(4));
                }
                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(Convert.ToByte(0));
                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(Convert.ToByte(0));
                if (info.weightCounts[i] == 0)
                {
                    chunk.ChunkVertices.VertexLayout.SlotStrides.Add( Convert.ToByte(48));
                }
                else
                {
                    chunk.ChunkVertices.VertexLayout.SlotStrides.Add(Convert.ToByte(64));
                }


                int elementCount = 0;

                // Position                                                                                                                              // bs way of setting up index names
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement() );
                // fishy
                //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = Convert.ToByte(0);
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = Convert.ToByte(0);
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_Position;
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Short4N;
                elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                // Joint0
                if (info.weightCounts[i] > 0)
                {
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement() );
                    // fishy
                    //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = Convert.ToByte(0);
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = Convert.ToByte(0);
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_SkinIndices;
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = Enums.GpuWrapApiVertexPackingePackingType.PT_UByte4;
                    elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                    // subject to change, maybe, vertfactory is weird
                    chunk.VertexFactory++;
                }
                // joint1
                if (info.weightCounts[i] > 4)
                {
                    // bs way of setting up index names
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement() );
                    // fishy
                    //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = Convert.ToByte(0);
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = Convert.ToByte(1);
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_SkinIndices;
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = Enums.GpuWrapApiVertexPackingePackingType.PT_UByte4;
                    elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                    // subject to change, maybe, vertfactory is weird
                    chunk.VertexFactory++;
                }

                // weight0
                if (info.weightCounts[i] > 0)
                {
                    // bs way of setting up index names
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement() );
                    // fishy
                    //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = Convert.ToByte(0);
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = Convert.ToByte(0);
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_SkinWeights;
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = Enums.GpuWrapApiVertexPackingePackingType.PT_UByte4N;
                    elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;
                }
                // weight1
                if (info.weightCounts[i] > 4)
                {
                    // bs way of setting up index names
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement() );
                    // fishy
                    //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = Convert.ToByte(0);
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = Convert.ToByte(1);
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_SkinWeights;
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = Enums.GpuWrapApiVertexPackingePackingType.PT_UByte4N;
                    elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;
                }

                // tx0coords
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement() );
                // fishy
                //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = Convert.ToByte(1);
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = Convert.ToByte(0);
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_TexCoord;
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Float16_2;
                elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                // normals
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement() );
                // fishy
                //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = Convert.ToByte(2);
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = Convert.ToByte(0);
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_Normal;
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Dec4;
                elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                // tangents
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement() );
                // fishy
                //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = Convert.ToByte(2);
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = Convert.ToByte(0);
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_Tangent;
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Dec4;
                elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                // color
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement() );
                // fishy
                //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = Convert.ToByte(3);
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = Convert.ToByte(0);
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_Color;
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Color;
                elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                // tx1coords
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement() );
                // fishy
                //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = Convert.ToByte(3);
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = Convert.ToByte(1);
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_TexCoord;
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Float16_2;
                elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                // extra data/ morphoffsets
                if (info.garmentSupportExists[i])
                {
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement() );
                    // fishy
                    //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = Convert.ToByte(0);
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = Convert.ToByte(0);
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_ExtraData;
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Float16_4;
                    elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                    // subject to change, maybe, vertfactory is weird, extra data ads 2 to this
                    chunk.VertexFactory += 2;
                }

                // instanceTransforms
                for (int e = 0; e < 3; e++)
                {
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement() );
                    // fishy
                    //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new Enums.GpuWrapApiVertexPackingEStreamType.;
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = Convert.ToByte(7);
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = Convert.ToByte(e);
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_InstanceTransform;
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Float4;
                    elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;
                }

                // instanceSkinningDatas
                if (info.weightCounts[i] > 0)
                {
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement() );
                    // fishy
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerInstance;
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = Convert.ToByte(7);
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = Convert.ToByte(0);
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_InstanceSkinningData;
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = Enums.GpuWrapApiVertexPackingePackingType.PT_UInt4;
                    elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;
                }

                // LightBlockerIntensity
                if (info.unknownOffsets[i] != 0)
                {
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement() );
                    // fishy
                    //chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = new CEnum<Enums.GpuWrapApiVertexPackingEStreamType>(cr2w, chunk.ChunkVertices.VertexLayout.Elements[0], "streamType") { Value = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex };
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = Convert.ToByte(4);
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = Convert.ToByte(0);
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_LightBlockerIntensity;
                    chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Float1;
                    elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                    // for lightblocker its 24, after testing some files, somtimes unknownoffsets[4] is used for destruction indices and some paint instead of lightblocker, so this needs to be taken care of
                    chunk.VertexFactory += 24;
                }


                // Invalid, Required
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement() );
                // fishy
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamType = Enums.GpuWrapApiVertexPackingEStreamType.ST_Invalid;
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].StreamIndex = Convert.ToByte(0);
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].UsageIndex = Convert.ToByte(0);
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_Invalid;
                chunk.ChunkVertices.VertexLayout.Elements[elementCount].Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Invalid;
                elementCount = chunk.ChunkVertices.VertexLayout.Elements.Count;

                // Adding Chunk
                blob.Header.RenderChunkInfos.Add(chunk);
            }

            blob.Header.QuantizationScale.X = info.quantScale.X;
            blob.Header.QuantizationScale.Y = info.quantScale.Y;
            blob.Header.QuantizationScale.Z = info.quantScale.Z;
            blob.Header.QuantizationOffset.X = info.quantTrans.X;
            blob.Header.QuantizationOffset.Y = info.quantTrans.Y;
            blob.Header.QuantizationOffset.Z = info.quantTrans.Z;

            blob.Header.VertexBufferSize = info.vertBufferSize;
            blob.Header.IndexBufferSize = info.indexBufferSize;
            blob.Header.IndexBufferOffset = info.indexBufferOffset;


            UInt16 p = (UInt16)(blob.RenderBuffer.Pointer - 1);

            var compressed = new MemoryStream();
            using var buff = new BinaryWriter(compressed);
            var (zsize, crc) = buff.CompressAndWrite(buffer.ToArray());

            cr2w.Buffers[p].Data = compressed.ToArray();

            //cr2w.Buffers[p].DiskSize = zsize;
            //cr2w.Buffers[p].Crc32 = crc;
            //cr2w.Buffers[p].MemSize = (UInt32)buffer.Length;
            //var off = cr2w.Buffers[p].Offset;
            //cr2w.Buffers[p].Offset = 0;
            //cr2w.Buffers[p].ReadData(new BinaryReader(compressed));
            //cr2w.Buffers[p].Offset = off;

            MemoryStream ms = new MemoryStream();
            using var writer = new CR2WWriter(ms);
            writer.WriteFile(cr2w);

            return ms;
        }
        static void VerifyGLTF(ModelRoot model)
        {
            if (model.LogicalMeshes.Count == 0)
            {
                throw new Exception("Provided GLTF doesn't contain any 3D Geomerty");
            }
            if (model.LogicalSkins.Count > 1)
            {
                throw new Exception($"Armature Count: {model.LogicalSkins.Count}, Only 1 Armature is allowed");
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

                if (name.Contains("LOD"))
                {
                    try
                    {
                        int idx = name.IndexOf("LOD_");
                        if (idx < name.Length - 1)
                        {
                            LOD = Convert.ToUInt32(name.Substring(idx + 4, 1));
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
        private static void UpdateSkinningParamCloth(ref List<RawMeshContainer> meshes, ref CR2WFile cr2w)
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

            int meshBufferIdx = cr2w.Chunks.OfType<rendRenderMeshBlob>().First().RenderBuffer.Pointer - 1;
            int materialBufferIdx = cr2w.Chunks.OfType<CMesh>().First().LocalMaterialBuffer.RawData.Pointer - 1;
            if (cr2w.Chunks.OfType<CMesh>().First().LocalMaterialBuffer.RawData.Data.Length == 0)
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
            if (cr2w.Chunks.OfType<CMesh>().First().LocalMaterialBuffer.RawData.Data.Length == 0)
                materialBufferIdx = 0;

            cr2w.Chunks.OfType<rendRenderMeshBlob>().First().RenderBuffer.Pointer = meshBufferIdx + 1;
            cr2w.Chunks.OfType<CMesh>().First().LocalMaterialBuffer.RawData.Pointer = materialBufferIdx + 1;


            if (cr2w.Chunks.OfType<meshMeshParamCloth>().Any())
            {
                var blob = cr2w.Chunks.OfType<meshMeshParamCloth>().First();
                blob.Chunks = new CArray<meshPhxClothChunkData>();
                for (int i = 0; i < meshes.Count; i++)
                {
                    var chunk = new meshPhxClothChunkData();
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(meshes[i].positions[e].X);
                            bw.Write(meshes[i].positions[e].Y);
                            bw.Write(meshes[i].positions[e].Z);
                        }

                        chunk.Positions = cr2w.BufferHandler.CreateDataBuffer(0, buffer.ToArray());
                    }
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].indices.Length; e++)
                        {
                            bw.Write(Convert.ToUInt16(meshes[i].indices[e]));
                        }

                        chunk.Indices = cr2w.BufferHandler.CreateDataBuffer(0, buffer.ToArray());
                    }
                    if (meshes[i].weightCount > 0)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(meshes[i].weights[e, 0]);
                            bw.Write(meshes[i].weights[e, 1]);
                            bw.Write(meshes[i].weights[e, 2]);
                            bw.Write(meshes[i].weights[e, 3]);
                        }

                        chunk.SkinWeights = cr2w.BufferHandler.CreateDataBuffer(0, buffer.ToArray());
                    }
                    if (meshes[i].weightCount > 0)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 0]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 1]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 2]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 3]));
                        }

                        chunk.SkinIndices = cr2w.BufferHandler.CreateDataBuffer(0, buffer.ToArray());
                    }
                    if (meshes[i].weightCount > 4)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(meshes[i].weights[e, 4]);
                            bw.Write(meshes[i].weights[e, 5]);
                            bw.Write(meshes[i].weights[e, 6]);
                            bw.Write(meshes[i].weights[e, 7]);
                        }

                        chunk.SkinWeightsExt = cr2w.BufferHandler.CreateDataBuffer(0, buffer.ToArray());
                    }
                    if (meshes[i].weightCount > 4)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 4]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 5]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 6]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 7]));
                        }

                        chunk.SkinIndicesExt = cr2w.BufferHandler.CreateDataBuffer(0, buffer.ToArray());
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

                        chunk.Normals = cr2w.BufferHandler.CreateDataBuffer(0, buffer.ToArray());
                    }
                    blob.Chunks.Add(chunk);
                    meshes[i].weightCount = 0;
                }
                blob.LodChunkIndices = new CArray<CArray<CUInt16>>();
                blob.LodChunkIndices.Add(new CArray<CUInt16>());
                if (LODLvl.Contains(2U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>());
                }
                if (LODLvl.Contains(4U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>());
                }
                if (LODLvl.Contains(8U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>());
                }
                for (ushort i = 0; i < LODLvl.Length; i++)
                {
                    if (LODLvl[i] == 1)
                    {
                        blob.LodChunkIndices[0].Add(i);
                    }
                    if (LODLvl[i] == 2)
                    {
                        blob.LodChunkIndices[1].Add(i);
                    }
                    if (LODLvl[i] == 4)
                    {
                        blob.LodChunkIndices[2].Add(i);
                    }
                    if (LODLvl[i] == 8)
                    {
                        blob.LodChunkIndices[3].Add(i);
                    }
                }
            }
            if (cr2w.Chunks.OfType<meshMeshParamCloth_Graphical>().Any())
            {
                var blob = cr2w.Chunks.OfType<meshMeshParamCloth_Graphical>().First();
                blob.Chunks = new CArray<meshGfxClothChunkData>();
                for (int i = 0; i < meshes.Count; i++)
                {
                    var chunk = new meshGfxClothChunkData();
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(meshes[i].positions[e].X);
                            bw.Write(meshes[i].positions[e].Y);
                            bw.Write(meshes[i].positions[e].Z);
                        }

                        chunk.Positions = cr2w.BufferHandler.CreateDataBuffer(0, buffer.ToArray());
                    }
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].indices.Length; e++)
                        {
                            bw.Write(Convert.ToUInt16(meshes[i].indices[e]));
                        }

                        chunk.Indices = cr2w.BufferHandler.CreateDataBuffer(0, buffer.ToArray());
                    }
                    if (meshes[i].weightCount > 0)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(meshes[i].weights[e, 0]);
                            bw.Write(meshes[i].weights[e, 1]);
                            bw.Write(meshes[i].weights[e, 2]);
                            bw.Write(meshes[i].weights[e, 3]);
                        }

                        chunk.SkinWeights = cr2w.BufferHandler.CreateDataBuffer(0, buffer.ToArray());
                    }
                    if (meshes[i].weightCount > 0)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 0]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 1]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 2]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 3]));
                        }

                        chunk.SkinIndices = cr2w.BufferHandler.CreateDataBuffer(0, buffer.ToArray());
                    }
                    if (meshes[i].weightCount > 4)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(meshes[i].weights[e, 4]);
                            bw.Write(meshes[i].weights[e, 5]);
                            bw.Write(meshes[i].weights[e, 6]);
                            bw.Write(meshes[i].weights[e, 7]);
                        }

                        chunk.SkinWeightsExt = cr2w.BufferHandler.CreateDataBuffer(0, buffer.ToArray());
                    }
                    if (meshes[i].weightCount > 4)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 4]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 5]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 6]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 7]));
                        }

                        chunk.SkinIndicesExt = cr2w.BufferHandler.CreateDataBuffer(0, buffer.ToArray());
                    }
                    {
                        chunk.Simulation = new CArray<CUInt16>();
                        int z = 0;
                        for (ushort e = 0; e < meshes[i].colors1.Length; e++)
                        {
                            if (meshes[i].colors1[e].X > 0.01f)
                            {
                                var val =  e ;
                                chunk.Simulation.Add(val);
                                z++;
                            }
                        }
                    }
                    blob.Chunks.Add(chunk);
                    meshes[i].weightCount = 0;
                }
                blob.LodChunkIndices = new CArray<CArray<CUInt16>>();
                blob.LodChunkIndices.Add(new CArray<CUInt16>());
                if (LODLvl.Contains(2U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>());
                }
                if (LODLvl.Contains(4U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>());
                }
                if (LODLvl.Contains(8U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>());
                }
                for (ushort i = 0; i < LODLvl.Length; i++)
                {
                    if (LODLvl[i] == 1)
                    {
                        blob.LodChunkIndices[0].Add(i);
                    }
                    if (LODLvl[i] == 2)
                    {
                        blob.LodChunkIndices[1].Add(i);
                    }
                    if (LODLvl[i] == 4)
                    {
                        blob.LodChunkIndices[2].Add(i);
                    }
                    if (LODLvl[i] == 8)
                    {
                        blob.LodChunkIndices[3].Add(i);
                    }
                }
            }
        }
    }
}
