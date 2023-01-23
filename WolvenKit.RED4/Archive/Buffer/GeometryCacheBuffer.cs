using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer;

public class GeometryCacheBuffer : IParseableBuffer
{
    public IRedType Data => null;

    public CArray<GeometryCacheEntry> Entries { get; set; } = new();

    public GeometryCacheBuffer()
    {

    }
}

public class GeometryCacheEntry : IRedType
{
    public CArray<CUInt8> ID { get; set; } = new();

    public GeometryCacheEntry()
    {

    }
}

public class CVXMCacheEntry : GeometryCacheEntry
{
    public CArray<Vector3> Vertices { get; set; } = new();

    public CArray<CVXMCacheFaceData> FaceData { get; set; } = new();

    public CArray<CArray<CUInt8>> Faces { get; set; } = new();

    // 2 CUInt8
    public CArray<CArray<CUInt8>> Edges { get; set; } = new();

    // 3 CUInt8
    public CArray<CArray<CUInt8>> Triangles { get; set; } = new();

    public Box Bounds { get; set; } = new();

    public CFloat Mass { get; set; }

    // 6 CUInt64
    public CArray<CUInt64> Hashes { get; set; } = new();

    public CFloat Uk1 { get; set; }

    // if Uk1 < 0

    public Vector4 Uk2 { get; set; } = new();

    // else if Uk1 > 0

    // 2 CInt8
    public CArray<CArray<CInt8>> Uk3 { get; set; } = new();

    public CUInt32 Uk4 { get; set; }

    public CArray<CUInt8> Uk5 { get; set; } = new();

    // 16 CUInt8
    public CArray<CUInt8> Uk6 { get; set; } = new();

    public CArray<CUInt8> Uk7 { get; set; } = new();

    public CVXMCacheEntry() : base()
    {

    }
}

public class CVXMCacheFaceData : IRedType
{
    public Vector3 Normal { get; set; }

    public CFloat Uk1 { get; set; }

    // 2 bits
    public CUInt8 Uk2 { get; set; }

    // 14 bits
    public CUInt16 Id { get; set; }

    public CUInt8 VertexCount { get; set; }

    public CUInt8 Uk3 { get; set; }
}

public class MeshCacheEntry : GeometryCacheEntry
{
    public CUInt32 Flags { get; set; }

    public CArray<Vector3> Vertices { get; set; } = new();

    // CUInt16 when Flags & 0b1000, else CUInt8
    public CArray<CArray<CUInt16>> Faces { get; set; } = new();

    // if Flags & 0b1
    public CArray<CUInt16> Materials { get; set; } = new();

    public CUInt32 Uk1;

    public Vector3 CenterOfMass { get; set; } = new();

    public CFloat Mass { get; set; }

    public CUInt32 Uk2;

    // 6 CFloats
    public CArray<CFloat> Uk3 { get; set; } = new();

    // 4 CArrays of 2 CFloats
    public CArray<CArray<CArray<CFloat>>> Uvs { get; set; } = new();

    public CUInt32 Uk4 { get; set; }

    public Box Bounds { get; set; } = new();

    public CArray<CUInt8> FaceFlags { get; set; } = new();

    public MeshCacheEntry() : base()
    {

    }
}