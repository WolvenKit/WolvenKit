using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace WolvenKit.Modkit.RED4.GeneralStructs
{
    public class RawArmature
    {
        public string[]? Names;

        public short[]? Parent;
        public int BoneCount;
        public Vector3[]? LocalPosn;
        public Quaternion[]? LocalRot;
        public Vector3[]? LocalScale;

        public bool AposeMSExits;
        public Vector3[]? AposeMSTrans;
        public Quaternion[]? AposeMSRot;
        public Vector3[]? AposeMSScale;

        public bool AposeLSExits;
        public Vector3[]? AposeLSTrans;
        public Quaternion[]? AposeLSRot;
        public Vector3[]? AposeLSScale;
        public int baseTendencyCount;
    }
    public class MeshesInfo
    {
        public uint[] vertCounts { get; set; }
        public uint[] indCounts { get; set; }
        public uint[] posnOffsets { get; set; }
        public uint[] tex0Offsets { get; set; }
        public uint[] normalOffsets { get; set; }
        public uint[] tangentOffsets { get; set; }
        public uint[] colorOffsets { get; set; }
        public uint[] tex1Offsets { get; set; }
        public uint[] unknownOffsets { get; set; }
        public uint[] indicesOffsets { get; set; }
        public uint[] vpStrides { get; set; }
        public uint[] weightCounts { get; set; }
        public bool[] garmentSupportExists { get; set; }
        public Vector4 quantTrans { get; set; }
        public Vector4 quantScale { get; set; }
        public int meshCount { get; set; }
        public uint[] LODLvl { get; set; }
        public Dictionary<string, string[]> appearances { get; set; } = new();
        public uint vertBufferSize { get; set; }
        public uint indexBufferSize { get; set; }
        public uint indexBufferOffset { get; set; }

        //public MeshesInfo() { }
        public MeshesInfo(int meshCount)
        {
            this.meshCount = meshCount;

            vertCounts = new uint[meshCount];
            indCounts = new uint[meshCount];
            posnOffsets = new uint[meshCount];
            tex0Offsets = new uint[meshCount];
            normalOffsets = new uint[meshCount];
            tangentOffsets = new uint[meshCount];
            colorOffsets = new uint[meshCount];
            tex1Offsets = new uint[meshCount];
            unknownOffsets = new uint[meshCount];
            indicesOffsets = new uint[meshCount];
            vpStrides = new uint[meshCount];
            weightCounts = new uint[meshCount];
            garmentSupportExists = new bool[meshCount];
            LODLvl = new uint[meshCount];

        }
    }
    public class RawMeshContainer
    {
        public Vector3[]? positions { get; set; }
        public uint[]? indices { get; set; }
        public Vector2[]? texCoords0 { get; set; }
        public Vector2[]? texCoords1 { get; set; }
        public Vector3[]? normals { get; set; }
        public Vector4[]? tangents { get; set; }
        public Vector4[]? colors0 { get; set; }
        public Vector4[]? colors1 { get; set; }
        public float[,]? weights { get; set; }
        public ushort[,]? boneindices { get; set; }
        public Vector3[]? garmentMorph { get; set; }
        public string? name { get; set; }
        public Vector4[]? garmentSupportWeight { get; set; }
        public Vector4[]? garmentSupportCap { get; set; }
        public uint weightCount { get; set; }
        public string[]? materialNames { get; set; }
        public uint lod { get; set; }
    }
    public class Re4MeshContainer
    {
        public short[,]? ExpVerts { get; set; }
        public uint[]? Nor32s { get; set; }
        public uint[]? Tan32s { get; set; }
        public ushort[]? indices { get; set; }
        public ushort[,]? uv0s { get; set; }
        public ushort[,]? uv1s { get; set; }
        public byte[,]? colors { get; set; }
        public byte[,]? weights { get; set; }
        public byte[,]? boneindices { get; set; }
        public string? name { get; set; }
        public uint weightcount { get; set; }
        public ushort[,]? garmentMorph { get; set; }
    }

    public class RawTargetContainer
    {
        public TargetVec3[]? vertexDelta { get; set; }
        public Vector3[]? normalDelta { get; set; }
        public Vector3[]? tangentDelta { get; set; }
        public ushort[]? vertexMapping { get; set; }
        public uint diffsCount { get; set; }
    }
    public class TargetsInfo
    {
        public uint[,]? NumVertexDiffsInEachChunk { get; set; }
        public uint NumDiffs { get; set; }
        public uint NumDiffsMapping { get; set; }
        public uint[,]? NumVertexDiffsMappingInEachChunk { get; set; }
        public uint[]? TargetStartsInVertexDiffs { get; set; }
        public uint[]? TargetStartsInVertexDiffsMapping { get; set; }
        public Vector4[]? TargetPositionDiffOffset { get; set; }
        public Vector4[]? TargetPositionDiffScale { get; set; }
        public string[]? Names { get; set; }
        public string[]? RegionNames { get; set; }
        public uint NumTargets { get; set; }
        public string? BaseMesh { get; set; }
        public string? BaseTexture { get; set; }
    }

    public struct TargetVec3
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

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
        public float W { get; set; }

        [MethodImpl(MethodImplOptions.NoOptimization)]
        public TargetVec4(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
    }
    public record MatData(string MaterialRepo, List<RawMaterial> Materials, List<string> TexturesList, List<RawMaterial> MaterialTemplates, Dictionary<string, string[]> Appearances);

    public class RawMaterial
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? Name { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? BaseMaterial { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? MaterialTemplate { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Dictionary<string, object>? Data { get; set; }
    }

    public class MaterialValueWrapper
    {
        public string? Type { get; set; }
        public object? Value { get; set; }
    }
}
