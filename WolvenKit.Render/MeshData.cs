using System.Collections.Generic;
using IrrlichtLime.Core;

namespace WolvenKit.Render
{
    public class SBufferInfos
    {
        public uint vertexBufferOffset = 0;
        public uint vertexBufferSize = 0;

        public uint indexBufferOffset = 0;
        public uint indexBufferSize = 0;

        public Vector3Df quantizationScale = new Vector3Df(1, 1, 1);
        public Vector3Df quantizationOffset = new Vector3Df(0, 0, 0);

        public List<SVertexBufferInfos> verticesBuffer = new List<SVertexBufferInfos>();
    }

    // Informations about the .buffer file
    public class SVertexBufferInfos
    {
        public uint verticesCoordsOffset = 0;
        public uint uvOffset = 0;
        public uint normalsOffset = 0;

        public uint indicesOffset = 0;

        public ushort nbVertices = 0;
        public uint nbIndices = 0;
        
        public byte materialID = 0;

        public byte lod = 1;
    }

    // Information to load a mesh from the buffer
    public class SMeshInfos
    {
        public enum EMeshVertexType
        {
            EMVT_STATIC,
            EMVT_SKINNED
        };

        public uint numVertices = 0;
        public uint numIndices = 0;
        public uint numBonesPerVertex = 4;

        public uint firstVertex = 0;
        public uint firstIndex = 0;

        public EMeshVertexType vertexType = EMeshVertexType.EMVT_STATIC;

        public uint materialID = 0;
    }

    public class W3_DataCache
    {
        public class VertexSkinningEntry
        {
            public uint boneId = 0;
            public ushort meshBufferId = 0;
            public uint vertexId = 0;
            public float strength = 0;
        }

        public class BoneEntry
        {
            public string name = "";
            public Matrix offsetMatrix = new Matrix();
        }

        public List<VertexSkinningEntry> vertices = new List<VertexSkinningEntry>();
        public List<BoneEntry> bones = new List<BoneEntry>();
    }

    public class BoneData
    {
        public uint nbBones = 0;

        public List<string> jointNames = new List<string>();
        public List<Matrix> boneMatrices = new List<Matrix>();
    }
}