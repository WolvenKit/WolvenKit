using System;
using System.Windows.Forms;
using System.Threading;
using IrrlichtLime;
using IrrlichtLime.Core;
using IrrlichtLime.Video;
using IrrlichtLime.Scene;
using IrrlichtLime.GUI;
using System.IO;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Cache;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using System.Collections.Generic;

namespace WolvenKit.Render
{
    public partial class frmRender : DockContent
    {
        private CR2WFile meshFile;
        private CR2WFile rigFile;
        private CR2WFile animFile;

        /// <summary>
        /// The delegate to load a document.
        /// </summary>
        public delegate CR2WFile LoadDocumentAndGetFile(string filename);
        /// <summary>
        /// The frmMain load document function.
        /// </summary>
        public LoadDocumentAndGetFile LoadDocument;

        /// <summary>
        /// Form constructor.
        /// </summary>
        public frmRender()
        {
            // Required for Windows Form Designer support
            InitializeComponent();
        }

        /// <summary>
        /// Witcher file containing mesh data.
        /// </summary>
        public CR2WFile MeshFile
        {
            get { return meshFile; }
            set
            {
                try
                {
                    meshFile = value;
                    loadMeshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "MeshFile error:" + ex.Message);
                }
            }
        }
        /// <summary>
        /// Witcher file containing rig data.
        /// </summary>
        public CR2WFile RigFile
        {
            get { return rigFile; }
            set
            {
                try
                {
                    rigFile = value;
                    loadRigData();
                    RestartIrrThread();
                    loadAnimToolStripMenuItem.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "RigFile error:" + ex.Message);
                }
            }
        }
        /// <summary>
        /// Witcher file containing animation data.
        /// </summary>
        public CR2WFile AnimFile
        {
            get { return animFile; }
            set
            {
                try
                {
                    animFile = value;
                    loadAnimsData();
                    RestartIrrThread();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "AnimFile error:" + ex.Message);
                }
            }
        }

        /// <summary>
        /// Read mesh chunk and buffer infos.
        /// </summary>
        private void loadMeshData()
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
                                    var nbBuffers = bytes[0];
                                    int curr = 1;
                                    for (uint i = 0; i < nbBuffers; i++)
                                    {
                                        SVertexBufferInfos buffInfo = new SVertexBufferInfos();

                                        curr += 1; // Unknown
                                        buffInfo.verticesCoordsOffset = bytes.SubArray(ref curr, 4).GetUint();
                                        buffInfo.uvOffset = bytes.SubArray(ref curr, 4).GetUint();
                                        buffInfo.normalsOffset = bytes.SubArray(ref curr, 4).GetUint();

                                        curr += 9; // Unknown
                                        buffInfo.indicesOffset = bytes.SubArray(ref curr, 4).GetUint();
                                        curr += 1; // 0x1D

                                        buffInfo.nbVertices = bytes.SubArray(ref curr, 2).GetUshort();
                                        buffInfo.nbIndices = bytes.SubArray(ref curr, 4).GetUint();
                                        curr += 3; // Unknown
                                        buffInfo.lod = bytes.SubArray(ref curr, 1).GetByte(); // lod ?

                                        vertexBufferInfos.Add(buffInfo);
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
                        // TODO: Fix read in meshtype...
                        meshInfos.Clear();
                        meshInfos.Add(meshInfo);
                    }

                    // TODO: Create a more reliable solution
                    var unknownBytes = chunk.unknownBytes.Bytes;
                    int currPos = 0, prevPos = 0;
                    bool correctPos = false;
                    do
                    {
                        prevPos = currPos;
                        boneData.nbBones = unknownBytes.SubArray(ref currPos, 1).GetByte();
                        if (boneData.nbBones == bonePositions.Count)
                        {
                            int backPos = currPos;
                            correctPos = true;
                            for (int i = 0; i < boneData.nbBones; i++)
                            {
                                var stringIdx = unknownBytes.SubArray(ref currPos, 2).GetUshort();
                                if (stringIdx == 0 || stringIdx >= MeshFile.strings.Count)
                                {
                                    boneData.nbBones = 0;
                                    correctPos = false;
                                    break;
                                }
                            }
                            currPos = backPos;
                        }
                    } while (boneData.nbBones != bonePositions.Count && currPos < unknownBytes.Length && !correctPos);

                    if (currPos < unknownBytes.Length)
                    {
                        currPos = prevPos;
                        boneData.nbBones = unknownBytes.SubArray(ref currPos, 1).GetByte();
                        for (uint i = 0; i < boneData.nbBones; i++)
                        {
                            var stringIdx = unknownBytes.SubArray(ref currPos, 2).GetUshort();
                            boneData.jointNames.Add(MeshFile.strings[stringIdx].str);
                        }
                        currPos++;
                        for (uint i = 0; i < boneData.nbBones; i++)
                        {
                            Matrix matrix = new Matrix();
                            for (int j = 0; j < 16; j++)
                            {
                                var value = unknownBytes.SubArray(ref currPos, 4).GetFloat();
                                matrix.SetElement(j, value);
                            }
                            boneData.boneMatrices.Add(matrix);
                        }
                    }
                }
                else if (chunk.Type == "CMaterialInstance")
                {
                    materialInstances.Add(chunk.data as CMaterialInstance);
                }
            }

            // *************** READ MESH BUFFER INFOS ***************
            foreach (var meshInfo in meshInfos)
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

                using (StreamReader sr = new StreamReader(meshFile.FileName + ".1.buffer"))
                {
                    uint vertexSize = 8;
                    if (meshInfo.vertexType == SMeshInfos.EMeshVertexType.EMVT_SKINNED)
                        vertexSize += meshInfo.numBonesPerVertex * 2;

                    sr.BaseStream.Seek(vBufferInf.verticesCoordsOffset + firstVertexOffset * vertexSize, SeekOrigin.Begin);

                    List<Vertex3D> vertex3DCoords = new List<Vertex3D>();
                    Color defaultColor = new Color(255, 255, 255, 255);
                    for (uint i = 0; i < meshInfo.numVertices; i++)
                    {
                        ushort x, y, z, w;

                        byte[] buff = new byte[2];
                        sr.BaseStream.Read(buff, 0, 2);
                        x = buff.GetUshort();
                        sr.BaseStream.Read(buff, 0, 2);
                        y = buff.GetUshort();
                        sr.BaseStream.Read(buff, 0, 2);
                        z = buff.GetUshort();
                        sr.BaseStream.Read(buff, 0, 2);
                        w = buff.GetUshort();

                        if (meshInfo.vertexType == SMeshInfos.EMeshVertexType.EMVT_SKINNED)
                        {
                            //sr.BaseStream.Seek(meshInfo.numBonesPerVertex * 2, SeekOrigin.Current);
                            byte[] skinningData = new byte[meshInfo.numBonesPerVertex * 2];
                            sr.BaseStream.Read(skinningData, 0, (int)meshInfo.numBonesPerVertex * 2);

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
                                    w3_DataCache.vertices.Add(vertexSkinningEntry);
                                }
                            }
                        }

                        Vertex3D vertex3DCoord = new Vertex3D();
                        vertex3DCoord.Position = new Vector3Df(x, y, z) / 65535f * bufferInfos.quantizationScale + bufferInfos.quantizationOffset;
                        vertex3DCoord.Color = defaultColor;
                        vertex3DCoords.Add(vertex3DCoord);
                    }

                    sr.BaseStream.Seek(vBufferInf.uvOffset + firstVertexOffset * 4, SeekOrigin.Begin);

                    for (int i = 0; i < meshInfo.numVertices; i++)
                    {
                        ushort u, v;

                        byte[] buff = new byte[2];
                        sr.BaseStream.Read(buff, 0, 2);
                        u = buff.GetUshort();
                        sr.BaseStream.Read(buff, 0, 2);
                        v = buff.GetUshort();

                        float uf = u.ToFloat();
                        float vf = v.ToFloat();

                        Vertex3D vertex3DCoord = vertex3DCoords[i];
                        vertex3DCoord.TCoords = new Vector2Df(uf, vf);
                        vertex3DCoords[i] = vertex3DCoord;
                    }

                    // Indices -------------------------------------------------------------------
                    sr.BaseStream.Seek(bufferInfos.indexBufferOffset + vBufferInf.indicesOffset + firstIndiceOffset * 2, SeekOrigin.Begin);

                    List<ushort> indices = new List<ushort>();
                    for (int i = 0; i < meshInfo.numIndices; i++)
                        indices.Add(0);

                    for (int i = 0; i < meshInfo.numIndices; i++)
                    {
                        ushort index;

                        byte[] buff = new byte[2];
                        sr.BaseStream.Read(buff, 0, 2);
                        index = buff.GetUshort();

                        // Indice need to be inversed for the normals
                        if (i % 3 == 0)
                            indices[i] = index;
                        else if (i % 3 == 1)
                            indices[i + 1] = index;
                        else if (i % 3 == 2)
                            indices[i - 1] = index;
                    }

                    MeshBuffer meshBuff = MeshBuffer.Create(VertexType.Standard, IndexType._16Bit);
                    staticMesh.AddMeshBuffer(meshBuff);
                    meshBuff.Append(vertex3DCoords, indices);
                    meshBuff.RecalculateBoundingBox();
                    meshBuff.Drop();
                }
            }
        }

        /// <summary>
        /// Read rig data.
        /// </summary>
        private void loadRigData()
        {
            // *************** READ RIG DATA ***************
            if (RigFile != null)
            foreach (var chunk in RigFile.chunks)
            {
                if (chunk.Type == "CSkeleton")
                {
                    var bones = chunk.GetVariableByName("bones") as CArray;
                    meshSkeleton.nbBones = (uint)bones.array.Count;
                    foreach (CVector bone in bones)
                    {
                        var boneName = bone.variables.GetVariableByName("nameAsCName") as CName;
                        meshSkeleton.names.Add(boneName.Value);
                    }
                    var parentIndices = chunk.GetVariableByName("parentIndices") as CArray;
                    foreach (CVariable parentIndex in parentIndices)
                    {
                        meshSkeleton.parentIdx.Add(short.Parse(parentIndex.ToString()));
                    }

                    var unknownBytes = chunk.unknownBytes.Bytes;
                    int currPos = 0;
                    for (uint i = 0; i < meshSkeleton.nbBones; i++)
                    {
                        Vector3Df position = new Vector3Df();
                        position.X = unknownBytes.SubArray(ref currPos, 4).GetFloat();
                        position.Y = unknownBytes.SubArray(ref currPos, 4).GetFloat();
                        position.Z = unknownBytes.SubArray(ref currPos, 4).GetFloat();
                        unknownBytes.SubArray(ref currPos, 4).GetFloat(); // the w component

                        Quaternion orientation = new Quaternion();
                        orientation.X = unknownBytes.SubArray(ref currPos, 4).GetFloat();
                        orientation.Y = unknownBytes.SubArray(ref currPos, 4).GetFloat();
                        orientation.Z = unknownBytes.SubArray(ref currPos, 4).GetFloat();
                        orientation.W = unknownBytes.SubArray(ref currPos, 4).GetFloat();

                        Vector3Df scale;
                        scale.X = unknownBytes.SubArray(ref currPos, 4).GetFloat();
                        scale.Y = unknownBytes.SubArray(ref currPos, 4).GetFloat();
                        scale.Z = unknownBytes.SubArray(ref currPos, 4).GetFloat();
                        unknownBytes.SubArray(ref currPos, 4).GetFloat(); // the w component

                        Matrix posMat = new Matrix();
                        posMat.Translation = position;

                        Matrix rotMat = new Matrix();
                        Vector3Df euler = orientation.ToEuler();
                        // chechNaNErrors(euler);

                        rotMat.SetRotationRadians(euler);

                        Matrix scaleMat = new Matrix();
                        scaleMat.Scale = scale;

                        Matrix localTransform = posMat * rotMat * scaleMat;
                        orientation = orientation.MakeInverse();
                        meshSkeleton.matrix.Add(localTransform);
                        meshSkeleton.positions.Add(position);
                        meshSkeleton.rotations.Add(orientation);
                        meshSkeleton.scales.Add(scale);
                    }
                }
            }
        }

        /// <summary>
        /// Read animations and animbuffers data.
        /// </summary>
        private void loadAnimsData()
        {
            // *************** READ ANIMATION DATA ***************
            if (AnimFile != null)
            foreach (var chunk in AnimFile.chunks)
            {
                if (chunk.Type == "CAnimationBufferBitwiseCompressed")
                {
                    uint numFrames = (chunk.GetVariableByName("numFrames") as CUInt32).val;
                    float animDuration = (chunk.GetVariableByName("duration") as CFloat).val;
                    animationSpeed = numFrames / animDuration;
                    uint keyFrame = 0;
                    // var deferredData = chunk.GetVariableByName("deferredData") as CFloat;
                    // if (deferredData != null)
                    //byte[] data = System.IO.File.ReadAllBytes(AnimFile.FileName + "." + deferredData.val + ".buffer");
                    // else
                    byte[] data = (chunk.GetVariableByName("data") as CByteArray).Bytes;
                    foreach (CVector bone in (chunk.GetVariableByName("bones") as CArray).array)
                    {
                        List<uint> currkeyframe = new List<uint>();
                        List<Quaternion> currorient = new List<Quaternion>();

                        int dataAddr = (int)((bone.GetVariableByName("orientation") as CVector).GetVariableByName("dataAddr") as CUInt32).val;
                        int orientNumFrames = ((bone.GetVariableByName("orientation") as CVector).GetVariableByName("numFrames") as CUInt16).val;
                        for (uint idx = 0; idx < orientNumFrames; idx++)
                        {
                            keyFrame = idx;
                            //keyFrame += numFrames;
                            currkeyframe.Add(keyFrame);
                            //bone.GetVariableByName("position");
                            byte[] odata = data.SubArray(ref dataAddr, 6);
                            ulong bits = (ulong)odata[0] << 40 | (ulong)odata[1] << 32 | (ulong)odata[2] << 24 | (ulong)odata[3] << 16 | (ulong)odata[4] << 8 | odata[5];

                            ushort[] orients = new ushort[4];
                            float[] quart = new float[4];
                            orients[0] = (ushort)((bits & 0x0000FFF000000000) >> 36);
                            orients[1] = (ushort)((bits & 0x0000000FFF000000) >> 24);
                            orients[2] = (ushort)((bits & 0x0000000000FFF000) >> 12);
                            orients[3] = (ushort)((bits & 0x0000000000000FFF));

                            for (int i = 0; i < orients.Length; i++)
                            {
                                float fVal = (2047.0f - orients[i]) * (1 / 2048.0f);
                                quart[i] = fVal;
                            }
                            quart[3] = -quart[3];

                            currorient.Add(new Quaternion(quart[0], quart[1], quart[2], quart[3]));
                        }

                        orientKeyframes.Add(currkeyframe);
                        orientations.Add(currorient);

                        // TODO: Refactor
                        List<Vector3Df> currposition = new List<Vector3Df>();
                        currkeyframe = new List<uint>();
                        int compression = 0;
                        var compr = (bone.GetVariableByName("position") as CVector).GetVariableByName("compression") as CInt8;
                        if (compr != null)
                            compression = compr.val;
                        var addr = (bone.GetVariableByName("position") as CVector).GetVariableByName("dataAddr") as CUInt32;
                        if (addr != null)
                            dataAddr = (int)addr.val;
                        else
                            dataAddr = 0;
                        var posNumFrames = ((bone.GetVariableByName("position") as CVector).GetVariableByName("numFrames") as CUInt16).val;
                        for (uint idx = 0; idx < posNumFrames; idx++)
                        {
                            keyFrame = idx;
                            //keyFrame += numFrames;
                            currkeyframe.Add(keyFrame);
                            Vector3Df pos = new Vector3Df();
                            if (compression == 0)
                            {
                                pos.X = data.SubArray(ref dataAddr, 4).GetFloat();
                                pos.Y = data.SubArray(ref dataAddr, 4).GetFloat();
                                pos.Z = data.SubArray(ref dataAddr, 4).GetFloat();
                            }
                            else if (compression == 1)
                            {
                                var bitsx = data.SubArray(ref dataAddr, 2).GetByte() << 16 | data.SubArray(ref dataAddr, 2).GetByte() << 8;
                                var bitsy = data.SubArray(ref dataAddr, 2).GetByte() << 16 | data.SubArray(ref dataAddr, 2).GetByte() << 8;
                                var bitsz = data.SubArray(ref dataAddr, 2).GetByte() << 16 | data.SubArray(ref dataAddr, 2).GetByte() << 8;
                                pos.X = BitConverter.ToSingle(BitConverter.GetBytes(bitsx), 0);
                                pos.Y = BitConverter.ToSingle(BitConverter.GetBytes(bitsy), 0);
                                pos.Z = BitConverter.ToSingle(BitConverter.GetBytes(bitsz), 0);
                            }
                            else if (compression == 2)
                            {
                                var bitsx = data.SubArray(ref dataAddr, 2).GetUshort() << 16;
                                var bitsy = data.SubArray(ref dataAddr, 2).GetUshort() << 16;
                                var bitsz = data.SubArray(ref dataAddr, 2).GetUshort() << 16;
                                pos.X = BitConverter.ToSingle(BitConverter.GetBytes(bitsx), 0);
                                pos.Y = BitConverter.ToSingle(BitConverter.GetBytes(bitsy), 0);
                                pos.Z = BitConverter.ToSingle(BitConverter.GetBytes(bitsz), 0);
                            }
                            currposition.Add(pos);
                        }
                        positionsKeyframes.Add(currkeyframe);
                        positions.Add(currposition);

                        List<Vector3Df> currscale = new List<Vector3Df>();
                        currkeyframe = new List<uint>();
                        compression = 0;
                        compr = (bone.GetVariableByName("scale") as CVector).GetVariableByName("compression") as CInt8;
                        if (compr != null)
                            compression = compr.val;
                        addr = (bone.GetVariableByName("scale") as CVector).GetVariableByName("dataAddr") as CUInt32;
                        if (addr != null)
                            dataAddr = (int)addr.val;
                        else
                            dataAddr = 0;
                        var scaleNumFrames = ((bone.GetVariableByName("scale") as CVector).GetVariableByName("numFrames") as CUInt16).val;
                        for (uint idx = 0; idx < scaleNumFrames; idx++)
                        {
                            keyFrame = idx;
                            //keyFrame += numFrames;
                            currkeyframe.Add(keyFrame);
                            Vector3Df scale = new Vector3Df();
                            if (compression == 0)
                            {
                                scale.X = data.SubArray(ref dataAddr, 4).GetFloat();
                                scale.Y = data.SubArray(ref dataAddr, 4).GetFloat();
                                scale.Z = data.SubArray(ref dataAddr, 4).GetFloat();
                            }
                            else if (compression == 1)
                            {
                                var bitsx = data.SubArray(ref dataAddr, 2).GetByte() << 16 | data.SubArray(ref dataAddr, 2).GetByte() << 8;
                                var bitsy = data.SubArray(ref dataAddr, 2).GetByte() << 16 | data.SubArray(ref dataAddr, 2).GetByte() << 8;
                                var bitsz = data.SubArray(ref dataAddr, 2).GetByte() << 16 | data.SubArray(ref dataAddr, 2).GetByte() << 8;
                                scale.X = BitConverter.ToSingle(BitConverter.GetBytes(bitsx), 0);
                                scale.Y = BitConverter.ToSingle(BitConverter.GetBytes(bitsy), 0);
                                scale.Z = BitConverter.ToSingle(BitConverter.GetBytes(bitsz), 0);
                            }
                            else if (compression == 2)
                            {
                                var bitsx = data.SubArray(ref dataAddr, 2).GetUshort() << 16;
                                var bitsy = data.SubArray(ref dataAddr, 2).GetUshort() << 16;
                                var bitsz = data.SubArray(ref dataAddr, 2).GetUshort() << 16;
                                scale.X = BitConverter.ToSingle(BitConverter.GetBytes(bitsx), 0);
                                scale.Y = BitConverter.ToSingle(BitConverter.GetBytes(bitsy), 0);
                                scale.Z = BitConverter.ToSingle(BitConverter.GetBytes(bitsz), 0);
                            }
                            currscale.Add(scale);
                        }
                        scalesKeyframes.Add(currkeyframe);
                        scales.Add(currscale);
                    }
                    break;
                }
            }
        }

        /// <summary>
        /// Thread variable for irrlicht thread.
        /// </summary>
        private Thread irrThread;

        /// <summary>
        /// Starts an irrlicht thread.
        /// </summary>
        private void StartIrrThread()
        {
            ThreadStart irrThreadStart = new ThreadStart(StartIrr);
            irrThread = new Thread(irrThreadStart);
            irrThread.IsBackground = true;
            irrThread.Start();
        }

        /// <summary>
        /// Restarts an irrlicht thread.
        /// </summary>
        private void RestartIrrThread()
        {
            irrThread.Abort();
            // restart an irrlicht thread
            StartIrrThread();
        }

        /// <summary>
        /// The irrlicht thread for rendering.
        /// </summary>
        private void StartIrr()
        {
            try
            {
                IrrlichtCreationParameters irrparam = new IrrlichtCreationParameters();
                if (irrlichtPanel.IsDisposed)
                    throw new Exception("Form closed!");
                if (irrlichtPanel.InvokeRequired)
                    irrlichtPanel.Invoke(new MethodInvoker(delegate { irrparam.WindowID = irrlichtPanel.Handle; }));
                irrparam.DriverType = DriverType.Direct3D9;
                irrparam.BitsPerPixel = 16;

                device = IrrlichtDevice.CreateDevice(irrparam);

                if (device == null) throw new NullReferenceException("Could not create device for engine!");

                driver = device.VideoDriver;
                smgr   = device.SceneManager;
                gui    = device.GUIEnvironment;

                var mPositionText = gui.AddStaticText("", new Recti(0, this.ClientSize.Height - 70, 100, this.ClientSize.Height - 60));
                var mRotationText = gui.AddStaticText("", new Recti(0, this.ClientSize.Height - 60, 100, this.ClientSize.Height - 50));
                var fpsText       = gui.AddStaticText("", new Recti(0, this.ClientSize.Height - 50, 100, this.ClientSize.Height - 40));
                var infoText      = gui.AddStaticText("[Space] - Reset\n[LMouse] - Rotate\n[MMouse] - Move\n[Wheel] - Zoom", new Recti(0, this.ClientSize.Height - 40, 100, this.ClientSize.Height));
                mPositionText.OverrideColor   = mRotationText.OverrideColor   = fpsText.OverrideColor   = infoText.OverrideColor   = new Color(255, 255, 255);
                mPositionText.BackgroundColor = mRotationText.BackgroundColor = fpsText.BackgroundColor = infoText.BackgroundColor = new Color(0, 0, 0);

                SkinnedMesh skinnedMesh = smgr.CreateSkinnedMesh();
                foreach (var meshBuffer in staticMesh.MeshBuffers)
                    skinnedMesh.AddMeshBuffer(meshBuffer);
                smgr.MeshManipulator.RecalculateNormals(skinnedMesh);
                if (RigFile != null)
                {
                    ApplySkeletonToModel(skinnedMesh);
                    if (AnimFile != null)
                    {
                        ApplyAnimationToModel(skinnedMesh);
                        modelAngle = new Vector3Df(startModelAngleWithAnim.X, startModelAngleWithAnim.Y, startModelAngle.Z);
                    }
                }
                skinnedMesh.SetDirty(HardwareBufferType.VertexAndIndex);
                skinnedMesh.FinalizeMeshPopulation();
                AnimatedMeshSceneNode node = smgr.AddAnimatedMeshSceneNode(skinnedMesh);

                if (node == null) throw new Exception("Could not load file!");

                node.Scale = new Vector3Df(3.0f);
                node.SetMaterialFlag(MaterialFlag.Lighting, false);
                SetMaterials(driver, node);

                CameraSceneNode camera = smgr.AddCameraSceneNode(null, new Vector3Df(node.BoundingBox.Radius*8, node.BoundingBox.Radius, 0), new Vector3Df(0, node.BoundingBox.Radius, 0));
                camera.NearValue = 0.001f;
                camera.FOV = 45 * PI_OVER_180;
                scaleMul = node.BoundingBox.Radius / 4;

                var viewPort = driver.ViewPort;
                var lineMat = new Material();
                lineMat.Lighting = false;

                while (device.Run())
                {
                    driver.ViewPort = viewPort;
                    driver.BeginScene(ClearBufferFlag.All, new Color(100, 101, 140));

                    node.Position = modelPosition;
                    node.Rotation = modelAngle;
                    node.DebugDataVisible = DebugSceneType.Skeleton | DebugSceneType.BBox;
                    mPositionText.Text = $"X: {modelPosition.X.ToString("F2")} Y: {modelPosition.Y.ToString("F2")} Z: {modelPosition.Z.ToString("F2")}";
                    mRotationText.Text = $"Yaw: {modelAngle.Y.ToString("F2")} Roll: {modelAngle.Z.ToString("F2")}";
                    fpsText.Text = $"FPS: {driver.FPS}";

                    smgr.DrawAll();
                    gui.DrawAll();

                    driver.ViewPort = new Recti(this.ClientSize.Width - 100, this.ClientSize.Height - 80, this.ClientSize.Width, this.ClientSize.Height);
                    //driver.ClearBuffers(ClearBufferFlag.None);

                    driver.SetMaterial(lineMat);
                    var matrix = new Matrix(new Vector3Df(0, 0, 0), modelAngle);
                    driver.SetTransform(TransformationState.World, matrix);
                    matrix = matrix.BuildProjectionMatrixOrthoLH(100, 80, camera.NearValue, camera.FarValue);
                    driver.SetTransform(TransformationState.Projection, matrix);
                    matrix = matrix.BuildCameraLookAtMatrixLH(new Vector3Df(50, 0, 0), new Vector3Df(0, 0, 0), new Vector3Df(0, 1f, 0));
                    driver.SetTransform(TransformationState.View, matrix);
                    driver.Draw3DLine(0, 0, 0, 30f, 0, 0, Color.OpaqueGreen);
                    driver.Draw3DLine(0, 0, 0, 0, 30f, 0, Color.OpaqueBlue);
                    driver.Draw3DLine(0, 0, 0, 0, 0, 30f, Color.OpaqueRed);

                    driver.EndScene();
                }

                device.Drop();
            }
            catch (ThreadAbortException) { }
            catch (NullReferenceException) { }
            catch (Exception ex)
            {
                if (!this.IsDisposed)
                {
                    MessageBox.Show(ex.Message);
                    //this.Invoke(new MethodInvoker(delegate { this.Close(); }));
                }
            }
        }

        /// <summary>
        /// Sets the material textures for the mesh.
        /// </summary>
        private void SetMaterials(VideoDriver driver, AnimatedMeshSceneNode node)
        {
            List<Material> materials = new List<Material>();
            //mat.Type = MaterialType.Solid;
            foreach (var materialInstance in materialInstances)
            {
                Material mat = new Material();
                foreach (var material in materialInstance.instanceParameters)
                {
                    switch (material.Name)
                    {
                        case "Diffuse":
                            Texture diffTexture = GetTexture(driver, (material as CHandle).Handle);
                            mat.SetTexture(0, diffTexture);
                            break;
                        case "Normal":
                            Texture normTexture = GetTexture(driver, (material as CHandle).Handle);
                            mat.SetTexture(1, normTexture);
                            //mat.Type = MaterialType.NormalMapSolid;
                            break;
                    }
                }
                materials.Add(mat);
            }
            for (int i = 0; i < meshInfos.Count; i++)
            {
                if (meshInfos[i].materialID < materials.Count)
                {
                    Material mat = materials[(int)meshInfos[i].materialID];
                    node.SetMaterialTexture(i, mat.GetTexture(i));
                }
            }
        }

        private bool suppressTextureWarning = false;

        /// <summary>
        /// Try to get the texture file.
        /// </summary>
        private Texture GetTexture(VideoDriver driver, string handleFilename)
        {
            string texturePath = Path.GetDirectoryName(meshFile.FileName) + @"\" + Path.GetFileNameWithoutExtension(handleFilename);
            string[] textureFileExtensions = { ".dds", ".bmp", ".tga", ".jpg", ".jpeg", ".png", ".xbm" };
            Texture texture = null;
            foreach (var textureFileExtension in textureFileExtensions)
            {
                texture = driver.GetTexture(texturePath + textureFileExtension);
                if (texture != null) break;
            }
            //ImageUtility.Xbm2Dds();
            if (texture == null && !suppressTextureWarning)
            {
                suppressTextureWarning = true;
                MessageBox.Show("Have you extracted texture files properly?" + "\n\n" + "Could not parse texture: " + texturePath, "Missing texture!");
            }
            return texture;
        }

        /// <summary>
        /// Try to apply skeleton to model.
        /// </summary>
        private void ApplySkeletonToModel(SkinnedMesh skinnedMesh)
        {
            // Create the bones
            for (int i = 0; i < meshSkeleton.nbBones; i++)
            {
                string boneName = meshSkeleton.names[i];
                if (skinnedMesh.GetJointIndex(boneName) == -1)
                {
                    var joint = skinnedMesh.AddJoint();
                    joint.Name = boneName;
                }
            }

            // Set the hierarchy
            for (int i = 0; i < meshSkeleton.nbBones; i++)
            {
                short parent = meshSkeleton.parentIdx[i];
                if (parent != -1) // root
                {
                    var parentJoint = CSkeleton.GetJointByName(skinnedMesh, meshSkeleton.names[parent]);
                    if (parentJoint != null)
                        parentJoint.AddChildren(skinnedMesh.GetAllJoints()[i]);
                }
            }

            // Set the transformations
            for (int i = 0; i < meshSkeleton.nbBones; i++)
            {
                string boneName = meshSkeleton.names[i];

                var joint = CSkeleton.GetJointByName(skinnedMesh, boneName);
                if (joint == null)
                    continue;

                joint.LocalMatrix = meshSkeleton.matrix[i];

                joint.Animatedposition = meshSkeleton.positions[i];
                joint.Animatedrotation = meshSkeleton.rotations[i];
                joint.Animatedscale = meshSkeleton.scales[i];
            }

            // Compute the global matrix
            List<SJoint> roots = CSkeleton.GetRootJoints(skinnedMesh);
            for (int i = 0; i < roots.Count; ++i)
            {
                CSkeleton.ComputeGlobal(skinnedMesh, roots[i]);
            }

            // The matrix of the bones
            for (int i = 0; i < boneData.nbBones; i++)
            {
                var jointIdx = skinnedMesh.GetJointIndex(boneData.jointNames[i]);
                SJoint joint = skinnedMesh.GetAllJoints()[jointIdx];

                Matrix matrix = boneData.boneMatrices[i];

                Vector3Df position = matrix.Translation;
                Matrix invRot = matrix.GetInverse();
                //invRot.rotateVect(position);

                Vector3Df rotation = invRot.GetRotationDegrees(invRot.Scale);
                //rotation = core::vector3df(0, 0, 0);
                position = -position;
                Vector3Df scale = matrix.Scale;

                if (joint != null)
                {
                    // Build GlobalMatrix:
                    Matrix positionMatrix = new Matrix();
                    positionMatrix.Translation = position;
                    Matrix scaleMatrix = new Matrix();
                    scaleMatrix.Scale = scale;
                    Matrix rotationMatrix = new Matrix();
                    rotationMatrix.SetRotationRadians(rotation * PI_OVER_180);

                    //joint.GlobalMatrix = scaleMatrix * rotationMatrix * positionMatrix;
                    //joint.LocalMatrix = joint.GlobalMatrix;

                    //joint.Animatedposition = joint.LocalMatrix.Translation;
                    //joint.Animatedrotation = new Quaternion(joint.LocalMatrix.GetRotationDegrees(joint.LocalMatrix.Scale)).MakeInverse();
                    //joint.Animatedscale = joint.LocalMatrix.Scale;

                    var bone = new W3_DataCache.BoneEntry();
                    bone.name = joint.Name;
                    bone.offsetMatrix = matrix;
                    w3_DataCache.bones.Add(bone);
                }
            }

            // Apply skin
            for (int i = 0; i < w3_DataCache.vertices.Count; i++)
            {
                var entry = w3_DataCache.vertices[i];

                // Check if it's a valid entry
                if (entry.boneId >= w3_DataCache.bones.Count
                    || entry.meshBufferId >= skinnedMesh.MeshBufferCount
                    || entry.vertexId >= skinnedMesh.GetMeshBuffer(entry.meshBufferId).VertexCount)
                {
                    // Console.WriteLine("Fail to skin : the vertex entry is not valid.");
                    continue;
                }


                int jointID = skinnedMesh.GetJointIndex(w3_DataCache.bones[(int)entry.boneId].name);
                if (jointID == -1)
                {
                    // Console.WriteLine("Fail to skin : joint not found." );
                    continue;
                }

                SJoint joint = skinnedMesh.GetAllJoints()[jointID];
                SWeight weight = skinnedMesh.AddWeight(joint);
                weight.BufferId = entry.meshBufferId;
                weight.VertexId = entry.vertexId;
                weight.Strength = entry.strength;
            }

            // Add weights
            /*for (int i = 0; i < w3_DataCache.vertices.Count; i++)
            {
                uint boneId = w3_DataCache.vertices[i].boneId;
                ushort bufferId = w3_DataCache.vertices[i].meshBufferId;
                uint vertexId = w3_DataCache.vertices[i].vertexId;
                float fweight = w3_DataCache.vertices[i].strength;

                if (boneId >= skinnedMesh.GetAllJoints().Count) // If bone doesnt exist
                    continue;

                SJoint joint = skinnedMesh.GetAllJoints()[(int)boneId];

                SWeight w = skinnedMesh.AddWeight(joint);
                w.BufferId = bufferId;
                w.Strength = fweight;
                w.VertexId = vertexId;
            }*/
        }
        
        /// <summary>
        /// Try to apply animation to model.
        /// </summary>
        private void ApplyAnimationToModel(SkinnedMesh skinnedMesh)
        {
            skinnedMesh.AnimationSpeed = animationSpeed;
            for (int i = 0; i < orientations.Count; i++)
            {
                SJoint joint = skinnedMesh.GetAllJoints()[i];
                for (int j = 0; j < positions[i].Count; j++)
                {
                    var poskey = skinnedMesh.AddPositionKey(joint);
                    poskey.Position = positions[i][j];
                    poskey.Frame = positionsKeyframes[i][j];
                }

                for (int j = 0; j < orientations[i].Count; j++)
                {
                    var rotkey = skinnedMesh.AddRotationKey(joint);
                    rotkey.Rotation = orientations[i][j];
                    rotkey.Frame = orientKeyframes[i][j];
                }

                for (int j = 0; j < scales[i].Count; j++)
                {
                    var scalekey = skinnedMesh.AddScaleKey(joint);
                    scalekey.Scale = scales[i][j];
                    scalekey.Frame = scalesKeyframes[i][j];
                }
            }
        }

        #region Common Data

        //private string modelPath = "";
        private StaticMesh staticMesh = StaticMesh.Create();
        private List<CMaterialInstance> materialInstances = new List<CMaterialInstance>();
        private List<SMeshInfos> meshInfos = new List<SMeshInfos>();
        private CSkeleton meshSkeleton = new CSkeleton();
        private BoneData boneData = new BoneData();
        private List<Vector3Df> bonePositions = new List<Vector3Df>();
        private W3_DataCache w3_DataCache = new W3_DataCache();

        private float animationSpeed = 0;
        private List<List<uint>> positionsKeyframes = new List<List<uint>>();
        private List<List<uint>> orientKeyframes = new List<List<uint>>();
        private List<List<uint>> scalesKeyframes = new List<List<uint>>();
        private List<List<Vector3Df>> positions = new List<List<Vector3Df>>();
        private List<List<Quaternion>> orientations = new List<List<Quaternion>>();
        private List<List<Vector3Df>> scales = new List<List<Vector3Df>>();

        //private static Quaternion modelAngle = new Quaternion(new Vertex3f(), 0);
        private Vector3Df modelPosition = new Vector3Df(0.0f);
        private Vector3Df startModelAngle = new Vector3Df(270.0f, 270.0f, 0.0f);
        private Vector3Df startModelAngleWithAnim = new Vector3Df(180.0f, 270.0f, 0.0f);
        private Vector3Df modelAngle = new Vector3Df(270.0f, 270.0f, 0.0f);
        private float scaleMul = 1;

        private IrrlichtDevice device;
        private VideoDriver driver;
        private SceneManager smgr;
        private GUIEnvironment gui;

        private bool modelAutorotating = true;
        //private static float angle_autorotate = 0;
        //private static float angle_autorotate_rad;
        private const float PI_OVER_180 = (float)Math.PI / 180.0f;

        #endregion

        /// <summary>
        /// Timer ticks for auto rotation.
        /// </summary>
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Change camera rotation
            if (modelAutorotating)
                modelAngle.Y = (modelAngle.Y + 1f) % 360.0f;
            //angle_autorotate_rad = angle_autorotate * PI_OVER_180;

            // Issue a new frame after this render
            // irrlichtPanel.Invalidate();
        }

        #region event handlers
        private bool firstrun = true;
        private System.Windows.Forms.Timer resizeTimer = new System.Windows.Forms.Timer();

        private void Bithack3D_Load(object sender, EventArgs e)
        {
            // OpenFileDialog for importing 3D models
            /*OpenFileDialog open3dModel = new OpenFileDialog();
            open3dModel.InitialDirectory = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\Models"));
            // If dir not found then use exe dir
            if (Directory.Exists(open3dModel.InitialDirectory) == false)
            {
                open3dModel.InitialDirectory = Environment.CurrentDirectory;
            }

            if (open3dModel.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    modelPath = Path.GetFullPath(open3dModel.FileName).Replace(@"\", "/");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error: Could not read file from disk. Original error: " + ex.Message);
                    this.BeginInvoke(new MethodInvoker(Close));
                }
            }
            else
            {
                MessageBox.Show(this, "No file selected!");
                this.BeginInvoke(new MethodInvoker(Close));
            }*/

            resizeTimer.Tick += ResizeTimer;
            resizeTimer.Interval = 1000;

            // start an irrlicht thread
            StartIrrThread();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (firstrun == false)
                resizeTimer.Start();
            else
                firstrun = false;
        }

        private void ResizeTimer(object sender, EventArgs e)
        {
            resizeTimer.Stop();
            if (irrThread != null)
            {
                RestartIrrThread();
            }
        }

        private static bool renderStarted = true;
        private static float currCursorPosX = 0;
        private static float currCursorPosY = 0;

        private void irrlichtPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (renderStarted && e.Button == MouseButtons.Left)
            {
                modelAutorotating = false;
                // Around Y axis
                float deltaDirection = currCursorPosX - e.X;
                modelAngle.Y = (modelAngle.Y + deltaDirection / 4.0f) % 360.0f;
                if (modelAngle.Y < 0)
                    modelAngle.Y = 360.0f + modelAngle.Y;

                // Around Z axis
                deltaDirection = currCursorPosY - e.Y;
                modelAngle.Z = (modelAngle.Z + deltaDirection / 20.0f) % 360.0f;
                if (modelAngle.Z < 0)
                    modelAngle.Z = 360.0f + modelAngle.Z;
            }
            else if (renderStarted && e.Button == MouseButtons.Middle)
            {
                modelAutorotating = false;
                float deltaDirection = currCursorPosX - e.X;
                modelPosition.Z = modelPosition.Z - deltaDirection * scaleMul / 100;

                deltaDirection = currCursorPosY - e.Y;
                modelPosition.Y = modelPosition.Y + deltaDirection * scaleMul / 100;
            }
            currCursorPosX = e.X;
            currCursorPosY = e.Y;

            // This method should only work when the mouse is captured by the Form.
            // For instance, when the left mouse button is pressed:
            // It traps the mouse to be able to scroll infinitely
            /*if (!(e.Button == MouseButtons.Left || e.Button == MouseButtons.Right))
                return;

            Point p = PointToScreen(e.Location);
            int x = p.X;
            int y = p.Y;
            Rectangle bounds = this.Bounds;

            if (x <= bounds.Left + 1)
                x = bounds.Right - 10;
            else if (x >= bounds.Right - 9)
                x = bounds.Left + 2;

            if (y <= bounds.Top + 8)
                y = bounds.Bottom - 2;
            else if (y >= bounds.Bottom - 1)
                y = bounds.Top + 9;

            if (x != p.X || y != p.Y)
            {
                Cursor.Position = new Point(x, y);
                currentPosX = x - (bounds.Left + 1);
                currentPosY = y - (bounds.Top + 1);
            }*/
        }

        private void Bithack3D_MouseWheel(object sender, MouseEventArgs e)
        {
            if (renderStarted)
                modelPosition.X = modelPosition.X + (float)e.Delta / 1000.0f;
        }

        private void Bithack3D_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // Restart autorotation
                modelAutorotating = true;
                if (AnimFile == null)
                    modelAngle = new Vector3Df(startModelAngle.X, startModelAngle.Y, startModelAngle.Z);
                else
                    modelAngle = new Vector3Df(startModelAngleWithAnim.X, startModelAngleWithAnim.Y, startModelAngleWithAnim.Z);
                modelPosition = new Vector3Df(0.0f);
            }
        }
        #endregion

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sf = new SaveFileDialog())
            {
                sf.Filter = "Irrlicht mesh | *.irrm | Collada mesh | *.coll | STL Mesh | *.stl | OBJ Mesh | *.obj | PLY Mesh | *.ply | B3D Mesh | *.b3d";
                if(sf.ShowDialog() == DialogResult.OK)
                {
                    MeshWriterType mwt = MeshWriterType.Obj;
                    switch(Path.GetExtension(sf.FileName))
                    {
                        case "irrm":
                            mwt = MeshWriterType.IrrMesh;
                            break;
                        case "coll":
                            mwt = MeshWriterType.Collada;
                            break;
                        case "obj":
                            mwt = MeshWriterType.Obj;
                            break;
                        case "stl":
                            mwt = MeshWriterType.Stl;
                            break;
                        case "ply":
                            mwt = MeshWriterType.Ply;
                            break;
                        case "b3d":
                            mwt = MeshWriterType.B3d;
                            break;
                    }
                    var mw = smgr.CreateMeshWriter(mwt);
                    if(mw.WriteMesh(device.FileSystem.CreateWriteFile(sf.FileName), staticMesh, MeshWriterFlag.None))
                        MessageBox.Show(this,"Sucessfully wrote file!","WolvenKit",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    else
                        MessageBox.Show(this, "Failed to write file!", "WolvenKit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loadRigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // HACK: Hacky (shit) solution for automatic path finding
            /*var basePath = doc.File.FileName.Split(new string[] { "characters" }, StringSplitOptions.None)[0];
            var modelName = Path.GetFileName(doc.File.FileName).Split('_', '.')[3];
            var rigPath = $@"{basePath}characters\base_entities\{modelName}_base\{modelName}_base.w2rig";*/
            if (MessageBox.Show("Could not find .w2rig for model!\nWould you like to search for the rig manually?", "Rig not found!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var ofd = new OpenFileDialog();
                ofd.Filter = "Rig file|*.w2rig";
                if (ofd.ShowDialog() == DialogResult.OK)
                    RigFile = LoadDocument(ofd.FileName);
            }
        }

        private void loadAnimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Could not find .w2anims for model!\nWould you like to search for the animation manually (highly experimental)?", "Animation not found!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var ofd = new OpenFileDialog();
                ofd.Filter = "Animation file|*.w2anims";
                if (ofd.ShowDialog() == DialogResult.OK)
                    AnimFile = LoadDocument(ofd.FileName);
            }
        }
    }
}
