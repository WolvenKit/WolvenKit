using IrrlichtLime.Core;
using IrrlichtLime.Scene;
using IrrlichtLime.Video;
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using IrrlichtLime;

namespace WolvenKit.Render
{
    public class WKMesh // renamed to not mess with Irrlicht Mesh
    {
        public CommonData CData { get; set; }

        private List<Vector3Df> bonePositions = new List<Vector3Df>();
        private IrrlichtLime.Video.Image dudImage;

        public WKMesh(CommonData cdata)
        {
            CData = cdata;
        }

        private void HandleMaterial(ref Material mat, string path, IrrlichtDevice dev, string texType)
        {
            Texture tex = dev.VideoDriver.AddTexture(path, dudImage);
            tex.Grab();

            mat.Type = IrrlichtLime.Video.MaterialType.NormalMapSolid;

            switch (texType)
            {
                case "Diffuse":
                    mat.SetTexture(0, tex);
                    break;
                case "Normal":
                    mat.SetTexture(1, tex);
                    break;
                default:
                    break;
            }
            tex.Drop();
        }

        private void HandleW2MIMaterial(ref Material mat, string basePath, string root, IrrlichtDevice dev)
        {
            CR2WFile cr2w;
            using (var fs = new FileStream(basePath, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader(fs))
            {
                cr2w = new CR2WFile();
                cr2w.Read(reader);
                fs.Close();
            }

            // it could be a CMaterialGraph, if so use a default
            // set the materialInstances to the texture references
            if (cr2w.chunks[0].data.REDType == "CMaterialInstance")
            {
                CMaterialInstance mi = cr2w.chunks[0].data as CMaterialInstance;
                if (mi.InstanceParameters != null)
                {
                    if (mi.InstanceParameters.Count > 0)
                    {
                        foreach (var material in mi.InstanceParameters)
                        {
                            if (material.Variant.REDType == "handle:ITexture")
                            {
                                string path = root + ((WolvenKit.CR2W.Types.CHandle<WolvenKit.CR2W.Types.ITexture>)material.Variant).DepotPath;
                                HandleMaterial(ref mat, path, dev, ((WolvenKit.CR2W.Types.CHandle<WolvenKit.CR2W.Types.ITexture>)material.Variant).REDName);
                            }
                            else if (material.Variant.REDType == "Color")
                            {
                                CColor solid = (CColor)material.Variant;
                                IrrlichtLime.Video.Color val = new IrrlichtLime.Video.Color(solid.Red.val, solid.Green.val, solid.Blue.val, solid.Alpha.val);
                                switch (material.Variant.REDName)
                                {
                                    case "VarianceColor":
                                        mat.DiffuseColor = val;
                                        break;
                                    case "SpecularColor":
                                        mat.SpecularColor = val;
                                        break;
                                    default:
                                        mat.DiffuseColor = val;
                                        break;
                                }
                            }
                        }
                    }
                    else
                    {
                        // check for a base material
                        string path = root + ((WolvenKit.CR2W.Types.CHandle<WolvenKit.CR2W.Types.IMaterial>)mi.BaseMaterial).DepotPath;
                        HandleW2MIMaterial(ref mat, path, root, dev);
                    }
                }
            }
            else if(cr2w.chunks[0].data.REDType == "CMaterialGraph")
            {
                //TODO
                CMaterialGraph mg = cr2w.chunks[0].data as CMaterialGraph;
            }
        }

        /// <summary>
        /// Read mesh chunk and buffer infos.
        /// </summary>

        public void LoadData(CR2WFile meshFile)
        {
            // IMPLEMENTED FROM jlouis' witcherconverter
            // http://jlouisb.users.sourceforge.net/
            // https://bitbucket.org/jlouis/witcherconverter

            string root = Path.GetDirectoryName(meshFile.FileName);
            root = root.Substring(0, root.IndexOf("r4data") + 7);

            IrrlichtCreationParameters irrparam = new IrrlichtCreationParameters();
            irrparam.DriverType = DriverType.Null;
            irrparam.BitsPerPixel = 8;
            irrparam.WindowSize.Height = 8;
            irrparam.WindowSize.Width = 8;
            irrparam.Fullscreen = false;
            IrrlichtDevice dev = IrrlichtDevice.CreateDevice(irrparam);

            dudImage = dev.VideoDriver.CreateImage(ColorFormat.A8R8G8B8, new Dimension2Di(4,4));

            SBufferInfos bufferInfos = new SBufferInfos();

            // *************** READ CHUNK INFOS ***************
            foreach (var chunk in meshFile.chunks)
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

                    // if static, no bones
                    if (meshCookedData.BonePositions != null)
                    {
                        foreach (var item in meshCookedData.BonePositions)
                        {
                            Vector3Df pos = new Vector3Df();
                            pos.X = item.X.val;
                            pos.Y = item.Y.val;
                            pos.Z = item.Z.val;
                            bonePositions.Add(pos);
                        }
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

                        if (meshChunk.VertexType == null || meshChunk.VertexType.WrappedEnum == Enums.EMeshVertexType.MVT_StaticMesh)
                            meshInfo.vertexType = SMeshInfos.EMeshVertexType.EMVT_STATIC;
                        else if (meshChunk.VertexType.WrappedEnum == Enums.EMeshVertexType.MVT_SkinnedMesh)
                            meshInfo.vertexType = SMeshInfos.EMeshVertexType.EMVT_SKINNED;

                        CData.meshInfos.Add(meshInfo);
                    }

                    // bone names and matrices
                    CBufferVLQInt32<CName> boneNames = cmesh.BoneNames;
                    CBufferVLQInt32<CMatrix4x4> bonematrices = cmesh.Bonematrices;
                    CData.boneData.nbBones = (uint)boneNames.elements.Count;
                    for (int i = 0; i < CData.boneData.nbBones; i++)
                    {
                        CName name = boneNames.elements[i];
                        CData.boneData.jointNames.Add(name.Value);

                        CMatrix4x4 cmatrix = bonematrices.elements[i];
                        Matrix matrix = new Matrix();
                        for (int j = 0; j < 16; j++)
                        {
                            float value = (cmatrix.fields[j] as CFloat).val;
                            matrix.SetElement(j, value);
                        }
                        CData.boneData.boneMatrices.Add(matrix);
                    }


                    // create material instances from the external materials
                    for (int i=0; i < cmesh.Materials.Count; ++i)
                    {
                        string path = cmesh.Materials[i].DepotPath;
                        if(path == null)
                        {
                            path = "local";
                            CMaterialInstance mi = new CMaterialInstance(null, null, path);
                            CData.materialInstances.Add(mi);
                        }
                        else
                        {
                            // load the wsmi file and get any texture references
                            CR2WFile cr2w;
                            string fullPath = root + path;
                            
                            using (var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                            using (var reader = new BinaryReader(fs))
                            {
                                cr2w = new CR2WFile();
                                cr2w.Read(reader);
                                fs.Close();
                            }

                            // it could be a CMaterialGraph, if so use a default
                            // set the materialInstances to the texture references
                            CMaterialInstance mi = cr2w.chunks[0].data as CMaterialInstance;
                            if(mi == null)
                            {
                                // TODO: handle the material graph properly
                                mi = new CMaterialInstance(null, null, null);
                                // can me lots of chunks too!
                                foreach(var matChunk in cr2w.chunks)
                                {
                                    if(matChunk.data.REDType == "CMaterialParameterColor")
                                    {
                                        CMaterialParameterColor mpc = (CMaterialParameterColor)matChunk.data;
                                        // set mi color here
                                        if(mi.InstanceParameters == null)
                                        {
                                            mi.InstanceParameters = new CArray<CVariantSizeNameType>(null, null, "Colors");
                                        }
                                        CVariantSizeNameType val = (CVariantSizeNameType)CVariantSizeNameType.Create(cr2w, mi, "Diffuse");
                                        val.Variant = new CColor(cr2w, null, "Color");
                                        CColor solid = (CColor)val.Variant;
                                        solid.Alpha = mpc.Color.Alpha;
                                        solid.Red = mpc.Color.Red;
                                        solid.Green = mpc.Color.Green;
                                        solid.Blue = mpc.Color.Blue;
                                        mi.InstanceParameters.AddVariable(val);
                                    }
                                }
                            }
                            CData.materialInstances.Add(mi);
                        }
                    }
                }
                else if (chunk.REDType == "CMaterialInstance")
                {
                    int i = 0;
                    while(i < CData.materialInstances.Count)
                    {
                        if(CData.materialInstances[i].GetFullName() == "local")
                        {
                            CData.materialInstances[i] = chunk.data as CMaterialInstance;
                            break;
                        }
                        ++i;
                    }
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
                        IrrlichtLime.Video.Color defaultColor = new IrrlichtLime.Video.Color(255, 255, 255, 255);
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

                            // Indices need to be inversed for the normals
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

                        dev.SceneManager.MeshManipulator.RecalculateNormals(meshBuff);

                        CMaterialInstance mi = CData.materialInstances[(int)meshInfo.materialID];
                       
                        Material mat = new Material();

                        if (mi.InstanceParameters != null)
                        {
                            if (mi.InstanceParameters.Count > 0)
                            {
                                foreach (var material in mi.InstanceParameters)
                                {
                                    if (material.Variant.REDType == "handle:ITexture")
                                    {
                                        if (((WolvenKit.CR2W.Types.CHandle<WolvenKit.CR2W.Types.ITexture>)material.Variant).DepotPath != null)
                                        {
                                            string path = root + ((WolvenKit.CR2W.Types.CHandle<WolvenKit.CR2W.Types.ITexture>)material.Variant).DepotPath;
                                            HandleMaterial(ref mat, path, dev, ((WolvenKit.CR2W.Types.CHandle<WolvenKit.CR2W.Types.ITexture>)material.Variant).REDName);
                                        }
                                    }
                                    else if (material.Variant.REDType == "Color")
                                    {
                                        CColor solid = (CColor)material.Variant;
                                        IrrlichtLime.Video.Color val = new IrrlichtLime.Video.Color(solid.Red.val, solid.Green.val, solid.Blue.val, solid.Alpha.val);
                                        mat.DiffuseColor = val;
                                    }
                                }
                            }
                            else
                            {
                                // check for a base material
                                if ((WolvenKit.CR2W.Types.CHandle<WolvenKit.CR2W.Types.IMaterial>)mi.BaseMaterial != null)
                                {
                                    string path = root + ((WolvenKit.CR2W.Types.CHandle<WolvenKit.CR2W.Types.IMaterial>)mi.BaseMaterial).DepotPath;
                                    HandleW2MIMaterial(ref mat, path, root, dev);
                                }
                            }
                        }
                        meshBuff.SetMaterial(mat);

                        CData.staticMesh.AddMeshBuffer(meshBuff);
                        meshBuff.Drop();
                    }
                }

            }

            dev.Close();
            dev.Dispose();
            dev.Drop();
        }
    }
}
