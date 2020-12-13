using IrrlichtLime.Core;
using IrrlichtLime.Scene;
using IrrlichtLime.Video;
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using System.Linq;
using System;

namespace WolvenKit.Render
{
    public class WKMesh // renamed to not mess with Irrlicht Mesh
    {
        public CommonData CData { get; set; }

        private List<Vector3Df> bonePositions = new List<Vector3Df>();

        public WKMesh(CommonData cdata)
        {
            CData = cdata;
        }

        /// <summary>
        /// Read mesh chunk and buffer infos.
        /// </summary>
        public void LoadData(CR2WFile meshFile)
        {
            // IMPLEMENTED FROM jlouis' witcherconverter
            // http://jlouisb.users.sourceforge.net/
            // https://bitbucket.org/jlouis/witcherconverter

            SBufferInfos bufferInfos = new SBufferInfos();

            // *************** READ CHUNK INFOS ***************
            foreach (var chunk in meshFile.Chunks)
            {
                if (chunk.REDType == "CMesh" && chunk.data is CMesh cmesh)
                {
                    List<SVertexBufferInfos> vertexBufferInfos = new List<SVertexBufferInfos>();
                    SMeshCookedData meshCookedData = cmesh.CookedData;


                    var bytes = meshCookedData.RenderChunks.Bytes;
                    using (MemoryStream ms = new MemoryStream(bytes))
                    using (BinaryReader br = new BinaryReader(ms))
                    {
                        var nbBuffers = br.ReadByte();
                        for (uint i = 0; i < nbBuffers; i++)
                        {
                            SVertexBufferInfos buffInfo = new SVertexBufferInfos();

                            br.BaseStream.Position += 1; // Unknown
                            buffInfo.verticesCoordsOffset = br.ReadUInt32();
                            buffInfo.uvOffset = br.ReadUInt32();
                            buffInfo.normalsOffset = br.ReadUInt32();

                            br.BaseStream.Position += 9; // Unknown
                            buffInfo.indicesOffset = br.ReadUInt32();
                            br.BaseStream.Position += 1; // 0x1D

                            buffInfo.nbVertices = br.ReadUInt16();
                            buffInfo.nbIndices = br.ReadUInt32();
                            buffInfo.materialID = br.ReadByte();
                            br.BaseStream.Position += 2; // Unknown
                            buffInfo.lod = br.ReadByte(); // lod ?

                            vertexBufferInfos.Add(buffInfo);
                        }
                    }

                    bufferInfos.indexBufferOffset = meshCookedData.IndexBufferOffset.val;
                    bufferInfos.indexBufferSize = meshCookedData.IndexBufferSize.val;
                    //bufferInfos.vertexBufferOffset = meshCookedData.vertexBufferOffset.val; //FIXME
                    bufferInfos.vertexBufferSize = meshCookedData.VertexBufferSize.val;
                    bufferInfos.quantizationOffset.X = meshCookedData.QuantizationOffset.X.val;
                    bufferInfos.quantizationOffset.Y = meshCookedData.QuantizationOffset.Y.val;
                    bufferInfos.quantizationOffset.Z = meshCookedData.QuantizationOffset.Z.val;
                    bufferInfos.quantizationScale.X = meshCookedData.QuantizationScale.X.val;
                    bufferInfos.quantizationScale.Y = meshCookedData.QuantizationScale.Y.val;
                    bufferInfos.quantizationScale.Z = meshCookedData.QuantizationScale.Z.val;

                    if (meshCookedData.BonePositions != null)
                        foreach (var item in meshCookedData.BonePositions)
                        {
                            Vector3Df pos = new Vector3Df();
                            pos.X = item.X.val;
                            pos.Y = item.Y.val;
                            pos.Z = item.Z.val;
                            bonePositions.Add(pos);
                        }


                    bufferInfos.verticesBuffer = vertexBufferInfos;
                    CArray<SMeshChunkPacked> meshChunks = cmesh.Chunks;
                    foreach (SMeshChunkPacked meshChunk in meshChunks.Elements)
                    {
                        SMeshInfos meshInfo = new SMeshInfos();

                        meshInfo.numVertices = meshChunk.NumVertices == null ? 0 : meshChunk.NumVertices.val;
                        meshInfo.numIndices = meshChunk.NumIndices == null ? 0 : meshChunk.NumIndices.val;
                        meshInfo.numBonesPerVertex = meshChunk.NumBonesPerVertex == null ? (uint)0 : meshChunk.NumBonesPerVertex.val;
                        meshInfo.firstVertex = meshChunk.FirstVertex == null ? 0 : meshChunk.FirstVertex.val;
                        meshInfo.firstIndex = meshChunk.FirstIndex == null ? 0 : meshChunk.FirstIndex.val;
                        meshInfo.materialID = meshChunk.MaterialID == null ? 0 : meshChunk.MaterialID.val;

                        if (meshChunk.VertexType != null)
                        {
                            if (meshChunk.VertexType.WrappedEnum == Enums.EMeshVertexType.MVT_StaticMesh)
                                meshInfo.vertexType = SMeshInfos.EMeshVertexType.EMVT_STATIC;
                            else if (meshChunk.VertexType.WrappedEnum == Enums.EMeshVertexType.MVT_SkinnedMesh)
                                meshInfo.vertexType = SMeshInfos.EMeshVertexType.EMVT_SKINNED;
                        }

                        CData.meshInfos.Add(meshInfo);
                    }

                    // bone names and matrices
                    // TODO: fixup cp77

                    CR2W.Types.CArray<CName> boneNames = cmesh.BoneNames;
                    CArray<CMatrix> bonematrices = cmesh.BoneRigMatrices;
                    CData.boneData.nbBones = (uint)boneNames.Count;
                    for (int i = 0; i < CData.boneData.nbBones; i++)
                    {
                        CName name = boneNames[i];
                        CData.boneData.jointNames.Add(name.Value);

                        CMatrix cmatrix = bonematrices[i];
                        Matrix matrix = new Matrix();
                        // TODO: fixup cp77
                        for (int j = 0; j < 16; j++)
                        {
                            //float value = (cmatrix.fields[j] as CFloat).val;
                            //matrix.SetElement(j, value);
                        }
                        CData.boneData.boneMatrices.Add(matrix);
                    }
                }

                else if (chunk.REDType == "CMaterialInstance")
                {
                    CData.materialInstances.Add(chunk.data as CMaterialInstance);
                }
            }

            // *************** READ MESH BUFFER INFOS ***************
            foreach (var meshInfo in CData.meshInfos)
            {
                SVertexBufferInfos vBufferInf = new SVertexBufferInfos();
                uint nbVertices = 0;
                uint firstVertexOffset = 0;
                uint nbIndices = 0;
                uint firstIndiceOffset = 0;
                for (int i = 0; i < bufferInfos.verticesBuffer.Count; i++)
                {
                    nbVertices += bufferInfos.verticesBuffer[i].nbVertices;
                    if (nbVertices > meshInfo.firstVertex)
                    {
                        vBufferInf = bufferInfos.verticesBuffer[i];
                        // the index of the first vertex in the buffer
                        firstVertexOffset = meshInfo.firstVertex - (nbVertices - vBufferInf.nbVertices);
                        break;
                    }
                }
                for (int i = 0; i < bufferInfos.verticesBuffer.Count; i++)
                {
                    nbIndices += bufferInfos.verticesBuffer[i].nbIndices;
                    if (nbIndices > meshInfo.firstIndex)
                    {
                        vBufferInf = bufferInfos.verticesBuffer[i];
                        firstIndiceOffset = meshInfo.firstIndex - (nbIndices - vBufferInf.nbIndices);
                        break;
                    }
                }

                // Load only best LOD
                if (vBufferInf.lod == 1)
                {
                    using (BinaryReader br = new BinaryReader(File.Open(meshFile.FileName + ".1.buffer", FileMode.Open)))
                    {
                        uint vertexSize = 8;
                        if (meshInfo.vertexType == SMeshInfos.EMeshVertexType.EMVT_SKINNED)
                            vertexSize += meshInfo.numBonesPerVertex * 2;

                        br.BaseStream.Seek(vBufferInf.verticesCoordsOffset + firstVertexOffset * vertexSize, SeekOrigin.Begin);

                        List<Vertex3D> vertex3DCoords = new List<Vertex3D>();
                        Color defaultColor = new Color(255, 255, 255, 255);
                        for (uint i = 0; i < meshInfo.numVertices; i++)
                        {
                            ushort x = br.ReadUInt16();
                            ushort y = br.ReadUInt16();
                            ushort z = br.ReadUInt16();
                            ushort w = br.ReadUInt16();

                            if (meshInfo.vertexType == SMeshInfos.EMeshVertexType.EMVT_SKINNED)
                            {
                                //sr.BaseStream.Seek(meshInfo.numBonesPerVertex * 2, SeekOrigin.Current);
                                byte[] skinningData = new byte[meshInfo.numBonesPerVertex * 2];
                                br.BaseStream.Read(skinningData, 0, (int)meshInfo.numBonesPerVertex * 2);

                                for (uint j = 0; j < meshInfo.numBonesPerVertex; ++j)
                                {
                                    uint boneId = skinningData[j];
                                    uint weight = skinningData[j + meshInfo.numBonesPerVertex];
                                    float fweight = weight / 255.0f;

                                    if (weight != 0)
                                    {
                                        var vertexSkinningEntry = new W3_DataCache.VertexSkinningEntry();
                                        vertexSkinningEntry.boneId = boneId;
                                        vertexSkinningEntry.meshBufferId = 0;
                                        vertexSkinningEntry.vertexId = i;
                                        vertexSkinningEntry.strength = fweight;
                                        CData.w3_DataCache.vertices.Add(vertexSkinningEntry);
                                    }
                                }
                            }

                            Vertex3D vertex3DCoord = new Vertex3D();
                            vertex3DCoord.Position = new Vector3Df(x, y, z) / 65535f * bufferInfos.quantizationScale + bufferInfos.quantizationOffset;
                            vertex3DCoord.Color = defaultColor;
                            vertex3DCoords.Add(vertex3DCoord);
                        }

                        br.BaseStream.Seek(vBufferInf.uvOffset + firstVertexOffset * 4, SeekOrigin.Begin);

                        for (int i = 0; i < meshInfo.numVertices; i++)
                        {
                            float uf = br.ReadHalfFloat();
                            float vf = br.ReadHalfFloat();

                            Vertex3D vertex3DCoord = vertex3DCoords[i];
                            vertex3DCoord.TCoords = new Vector2Df(uf, vf);
                            vertex3DCoords[i] = vertex3DCoord;
                        }

                        // Indices -------------------------------------------------------------------
                        br.BaseStream.Seek(bufferInfos.indexBufferOffset + vBufferInf.indicesOffset + firstIndiceOffset * 2, SeekOrigin.Begin);

                        List<ushort> indices = new List<ushort>();
                        for (int i = 0; i < meshInfo.numIndices; i++)
                            indices.Add(0);

                        for (int i = 0; i < meshInfo.numIndices; i++)
                        {
                            ushort index = br.ReadUInt16();

                            // Indice need to be inversed for the normals
                            if (i % 3 == 0)
                                indices[i] = index;
                            else if (i % 3 == 1)
                                indices[i + 1] = index;
                            else if (i % 3 == 2)
                                indices[i - 1] = index;
                        }

                        MeshBuffer meshBuff = MeshBuffer.Create(VertexType.Standard, IndexType._16Bit);
                        meshBuff.Append(vertex3DCoords.ToArray(), indices.ToArray());
                        meshBuff.RecalculateBoundingBox();
                        CData.staticMesh.AddMeshBuffer(meshBuff);
                        meshBuff.Drop();
                    }
                }
            }
        }
    }
}
