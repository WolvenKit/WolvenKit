using System;
using System.Numerics;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace WolvenKit.Modkit.RED4.GeneralStructs
{
    public class RawArmature
    {
        public string[] Names;

        public Int16[] Parent;
        public int BoneCount;
        public Vector3[] LocalPosn;
        public Quaternion[] LocalRot;
        public Vector3[] LocalScale;

        public bool AposeMSExits;
        public Vector3[] AposeMSTrans;
        public Quaternion[] AposeMSRot;
        public Vector3[] AposeMSScale;

        public bool AposeLSExits;
        public Vector3[] AposeLSTrans;
        public Quaternion[] AposeLSRot;
        public Vector3[] AposeLSScale;
        public int baseTendencyCount;
    }
    public class MeshesInfo
    {
        public UInt32[] vertCounts { get; set; }
        public UInt32[] indCounts { get; set; }
        public UInt32[] posnOffsets { get; set; }
        public UInt32[] tex0Offsets { get; set; }
        public UInt32[] normalOffsets { get; set; }
        public UInt32[] tangentOffsets { get; set; }
        public UInt32[] colorOffsets { get; set; }
        public UInt32[] tex1Offsets { get; set; }
        public UInt32[] unknownOffsets { get; set; }
        public UInt32[] indicesOffsets { get; set; }
        public UInt32[] vpStrides { get; set; }
        public UInt32[] weightCounts { get; set; }
        public bool[] garmentSupportExists { get; set; }
        public Vector4 quantTrans { get; set; }
        public Vector4 quantScale { get; set; }
        public int meshCount { get; set; }
        public UInt32[] LODLvl { get; set; }
        public Dictionary<string, string[]> appearances { get; set; }
        public UInt32 vertBufferSize { get; set; }
        public UInt32 indexBufferSize { get; set; }
        public UInt32 indexBufferOffset { get; set; }

        public MeshesInfo() { }
        public MeshesInfo(int meshCount)
        {
            this.meshCount = meshCount;

            vertCounts = new UInt32[meshCount];
            indCounts = new UInt32[meshCount];
            posnOffsets = new UInt32[meshCount];
            tex0Offsets = new UInt32[meshCount];
            normalOffsets = new UInt32[meshCount];
            tangentOffsets = new UInt32[meshCount];
            colorOffsets = new UInt32[meshCount];
            tex1Offsets = new UInt32[meshCount];
            unknownOffsets = new UInt32[meshCount];
            indicesOffsets = new UInt32[meshCount];
            vpStrides = new UInt32[meshCount];
            weightCounts = new UInt32[meshCount];
            garmentSupportExists = new bool[meshCount];
            LODLvl = new UInt32[meshCount];

        }
    }
    public class RawMeshContainer
    {
        public Vector3[] positions { get; set; }
        public uint[] indices { get; set; }
        public Vector2[] texCoords0 { get; set; }
        public Vector2[] texCoords1 { get; set; }
        public Vector3[] normals { get; set; }
        public Vector4[] tangents { get; set; }
        public Vector4[] colors0 { get; set; }
        public Vector4[] colors1 { get; set; }
        public float[,] weights { get; set; }
        public UInt16[,] boneindices { get; set; }
        public Vector3[] garmentMorph { get; set; }
        public string name { get; set; }
        public UInt32 weightCount { get; set; }
        public string[] materialNames { get; set; }
    }
    public class Re4MeshContainer
    {
        public Int16[,] ExpVerts { get; set; }
        public UInt32[] Nor32s { get; set; }
        public UInt32[] Tan32s { get; set; }
        public UInt16[] indices { get; set; }
        public UInt16[,] uv0s { get; set; }
        public UInt16[,] uv1s { get; set; }
        public Byte[,] colors { get; set; }
        public Byte[,] weights { get; set; }
        public Byte[,] boneindices { get; set; }
        public string name { get; set; }
        public UInt32 weightcount { get; set; }
        public UInt16[,] garmentMorph { get; set; }
    }

    public class RawTargetContainer
    {
        public TargetVec3[] vertexDelta { get; set; }
        public Vector3[] normalDelta { get; set; }
        public Vector3[] tangentDelta { get; set; }
        public UInt16[] vertexMapping { get; set; }
        public UInt32 diffsCount { get; set; }
    }
    public class TargetsInfo
    {
        public UInt32[,] NumVertexDiffsInEachChunk { get; set; }
        public UInt32 NumDiffs { get; set; }
        public UInt32 NumDiffsMapping { get; set; }
        public UInt32[,] NumVertexDiffsMappingInEachChunk { get; set; }
        public UInt32[] TargetStartsInVertexDiffs { get; set; }
        public UInt32[] TargetStartsInVertexDiffsMapping { get; set; }
        public Vector4[] TargetPositionDiffOffset { get; set; }
        public Vector4[] TargetPositionDiffScale { get; set; }
        public string[] Names { get; set; }
        public string[] RegionNames { get; set; }
        public UInt32 NumTargets { get; set; }
        public string BaseMesh { get; set; }
        public string BaseTexture { get; set; }
    }

    public struct TargetVec3
    {
        public float X { get; set; }
        public float Y {  get; set; }
        public float Z {  get; set; }

        [MethodImpl(MethodImplOptions.NoOptimization)]
        public TargetVec3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

    public struct TargetVec4
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float W {  get; set; }

        [MethodImpl(MethodImplOptions.NoOptimization)]
        public TargetVec4(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
    }
    public class RawMaterial
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string BaseMaterial { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string MaterialTemplate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Data { get; set; }
    }
}
