using System;
using System.Numerics;
using System.Collections.Generic;
using WolvenKit.RED4.MeshFile.Materials.MaterialTypes;

namespace WolvenKit.RED4.GeneralStructs
{
    public class RawArmature
    {
        public string[] Names;

        public Int16[] Parent;
        public int BoneCount;
        public bool Rig;
        public Vector3[] LocalPosn;
        public Quaternion[] LocalRot;
        public Vector3[] LocalScale;
        public Matrix4x4[] WorldMat;
        public Matrix4x4[] IBWorldMat;

        // temp, to be depreciated after fixing IBM mumbo jumbo
        public bool AposeMSExits;
        public Vector3[] AposeMSTrans;
        public Quaternion[] AposeMSRot;
        public Vector3[] AposeMSScale;
        public Matrix4x4[] AposeMSMat;
        public Matrix4x4[] IBAposeMat;
        // temp, to be depreciated after fixing IBM mumbo jumbo
        public bool AposeLSExits;
        public Vector3[] AposeLSTrans;
        public Quaternion[] AposeLSRot;
        public Vector3[] AposeLSScale;
        public Matrix4x4[] AposeLSMat;
    }
    public class MeshesInfo
    {
        public UInt32[] vertCounts { get; set; }
        public UInt32[] indCounts { get; set; }
        public UInt32[] vertOffsets { get; set; }
        public UInt32[] tx0Offsets { get; set; }
        public UInt32[] normalOffsets { get; set; }
        public UInt32[] colorOffsets { get; set; }
        public UInt32[] unknownOffsets { get; set; }
        public UInt32[] indicesOffsets { get; set; }
        public UInt32[] vpStrides { get; set; }

        public UInt32[] weightcounts { get; set; }
        public Vector4 qTrans { get; set; }
        public Vector4 qScale { get; set; }
        public int meshC { get; set; }
        public UInt32[] LODLvl { get; set; }
        public List<Appearance> appearances { get; set; }
    }
    public class RawMeshContainer
    {
        public Vector3[] vertices { get; set; }
        public uint[] indices { get; set; }
        public Vector2[] tx0coords { get; set; }
        public Vector2[] tx1coords { get; set; }
        public Vector3[] normals { get; set; }
        public Vector4[] tangents { get; set; }
        public Vector4[] colors { get; set; }
        public float[,] weights { get; set; }
        public UInt16[,] boneindices { get; set; }
        public string name;
        public UInt32 weightcount { get; set; }
        public string[] appNames { get; set; }
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
        public string name;
        public UInt32 weightcount { get; set; }
    }
    
    public class RawTargetContainer
    {
        public Vector3[] vertexDelta { get; set; }
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

    public class Appearance
    {
        public string Name;
        public string[] MaterialNames;
    }
    public class RawMaterial
    {
        public string Name { get; set; }
        public string BaseMaterial { get; set; }
        public MaterialType MaterialType { get; set; }
        public HumanSkin HumanSkin { get; set; }
        public MeshDecal MeshDecal { get; set; }
        public MultiLayered MultiLayered { get; set; }
    }
}
