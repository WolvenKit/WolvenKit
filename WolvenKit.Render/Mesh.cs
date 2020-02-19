using IrrlichtLime.Core;
using IrrlichtLime.Scene;
using IrrlichtLime.Video;
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Render
{
    public class Mesh
    {
        public CommonData CData { get; set; }

        private List<Vector3Df> bonePositions = new List<Vector3Df>();

        public Mesh(CommonData cdata)
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
            foreach (var chunk in meshFile.chunks)
            {
                if (chunk.Type == "CMesh")
                {
                    List<SVertexBufferInfos> vertexBufferInfos = new List<SVertexBufferInfos>();
                    var cookedDatas = chunk.GetVariableByName("cookedData") as CVector;
                    foreach (var cookedData in cookedDatas.variables)
                    {
                        switch (cookedData.Name)
                        {
                            case "renderChunks":
                                {
                                    var bytes = ((CByteArray)cookedData).Bytes;
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
                                            br.BaseStream.Position += 3; // Unknown
                                            buffInfo.lod = br.ReadByte(); // lod ?

                                            vertexBufferInfos.Add(buffInfo);
                                        }
                                    }
                                    break;
                                }
                            case "indexBufferOffset":
                                {
                                    bufferInfos.indexBufferOffset = uint.Parse(cookedData.ToString());
                                    break;
                                }
                            case "indexBufferSize":
                                {
                                    bufferInfos.indexBufferSize = uint.Parse(cookedData.ToString());
                                    break;
                                }
                            case "vertexBufferOffset":
                                {
                                    bufferInfos.vertexBufferOffset = uint.Parse(cookedData.ToString());
                                    break;
                                }
                            case "vertexBufferSize":
                                {
                                    bufferInfos.vertexBufferSize = uint.Parse(cookedData.ToString());
                                    break;
                                }
                            case "quantizationOffset":
                                {
                                    bufferInfos.quantizationOffset.X = float.Parse((cookedData as CVector).variables[0].ToString());
                                    bufferInfos.quantizationOffset.Y = float.Parse((cookedData as CVector).variables[1].ToString());
                                    bufferInfos.quantizationOffset.Z = float.Parse((cookedData as CVector).variables[2].ToString());
                                    break;
                                }
                            case "quantizationScale":
                                {
                                    bufferInfos.quantizationScale.X = float.Parse((cookedData as CVector).variables[0].ToString());
                                    bufferInfos.quantizationScale.Y = float.Parse((cookedData as CVector).variables[1].ToString());
                                    bufferInfos.quantizationScale.Z = float.Parse((cookedData as CVector).variables[2].ToString());
                                    break;
                                }
                            case "bonePositions":
                                {
                                    foreach (CVector item in cookedData as CArray)
                                    {
                                        if (item.variables.Count == 4)
                                        {
                                            Vector3Df pos = new Vector3Df();
                                            pos.X = (item.variables[0] as CFloat).val;
                                            pos.Y = (item.variables[1] as CFloat).val;
                                            pos.Z = (item.variables[2] as CFloat).val;
                                            bonePositions.Add(pos);
                                        }
                                    }
                                    break;
                                }
                        }
                    }
                    bufferInfos.verticesBuffer = vertexBufferInfos;
                    var meshChunks = chunk.GetVariableByName("chunks") as CArray;
                    foreach (var meshChunk in meshChunks.array)
                    {
                        SMeshInfos meshInfo = new SMeshInfos();
                        foreach (var meshinfo in (meshChunk as CVector).variables)
                        {
                            switch (meshinfo.Name)
                            {
                                case "numVertices":
                                    {
                                        meshInfo.numVertices = uint.Parse(meshinfo.ToString());
                                        break;
                                    }
                                case "numIndices":
                                    {
                                        meshInfo.numIndices = uint.Parse(meshinfo.ToString());
                                        break;
                                    }
                                case "numBonesPerVertex":
                                    {
                                        meshInfo.numBonesPerVertex = uint.Parse(meshinfo.ToString());
                                        break;
                                    }
                                case "firstVertex":
                                    {
                                        meshInfo.firstVertex = uint.Parse(meshinfo.ToString());
                                        break;
                                    }
                                case "firstIndex":
                                    {
                                        meshInfo.firstIndex = uint.Parse(meshinfo.ToString());
                                        break;
                                    }
                                case "vertexType":
                                    {
                                        if ((meshinfo as CName).Value == "MVT_StaticMesh")
                                            meshInfo.vertexType = SMeshInfos.EMeshVertexType.EMVT_STATIC;
                                        else if ((meshinfo as CName).Value == "MVT_SkinnedMesh")
                                            meshInfo.vertexType = SMeshInfos.EMeshVertexType.EMVT_SKINNED;
                                        break;
                                    }
                                case "materialID":
                                    {
                                        meshInfo.materialID = uint.Parse(meshinfo.ToString());
                                        break;
                                    }
                            }
                        }
                        CData.meshInfos.Add(meshInfo);
                    }

                    // TODO: Create a more reliable solution
                    var unknownBytes = chunk.unknownBytes.Bytes;
                    using (var ms = new MemoryStream(unknownBytes))
                    using (var br = new BinaryReader(ms))
                    {
                        long prevPos = 0;
                        bool correctPos = false;
                        do
                        {
                            prevPos = br.BaseStream.Position;
                            CData.boneData.nbBones = (uint)br.ReadBit6();

                            if (CData.boneData.nbBones == bonePositions.Count)
                            {
                                var backPos = br.BaseStream.Position;
                                correctPos = true;
                                for (int i = 0; i < CData.boneData.nbBones; i++)
                                {
                                    var stringIdx = br.ReadUInt16();
                                    if (stringIdx == 0 || stringIdx >= meshFile.names.Count)
                                    {
                                        CData.boneData.nbBones = 0;
                                        correctPos = false;
                                        break;
                                    }
                                }
                                br.BaseStream.Position = backPos;
                            }
                        } while (CData.boneData.nbBones != bonePositions.Count && br.BaseStream.Position < unknownBytes.Length && !correctPos);

                        if (br.BaseStream.Position < unknownBytes.Length)
                        {
                            br.BaseStream.Position = prevPos;
                            CData.boneData.nbBones = (uint)br.ReadBit6();
                            for (uint i = 0; i < CData.boneData.nbBones; i++)
                            {
                                var stringIdx = br.ReadUInt16();
                                CData.boneData.jointNames.Add(meshFile.names[stringIdx].str);
                            }
                            br.ReadBit6();
                            for (uint i = 0; i < CData.boneData.nbBones; i++)
                            {
                                Matrix matrix = new Matrix();
                                for (int j = 0; j < 16; j++)
                                {
                                    var value = br.ReadSingle();
                                    matrix.SetElement(j, value);
                                }
                                CData.boneData.boneMatrices.Add(matrix);
                            }
                        }
                    }
                }
                else if (chunk.Type == "CMaterialInstance")
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
                        CData.staticMesh.AddMeshBuffer(meshBuff);
                        meshBuff.Append(vertex3DCoords, indices);
                        meshBuff.RecalculateBoundingBox();
                        meshBuff.Drop();
                    }
                }
            }
        }
    }
}
