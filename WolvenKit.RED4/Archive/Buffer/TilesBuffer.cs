using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer;

public class TilesBuffer : IParseableBuffer, IRedType
{
    public IRedType? Data => null;

    public TilesMetadata Metadata { get; set; } = new();

    public Vector3 Uk1 { get; set; } = new();

    public Vector3 Min { get; set; } = new();

    public Vector3 Max { get; set; } = new();

    public CFloat Uk2 { get; set; } = new();

    public CArray<Vector3> Vertices { get; set; } = new();

    public CArray<TileFaceInfo> FaceInfo { get; set; } = new();

    public CArray<TilesBufferUk2> Zeros { get; set; } = new();

    public CArray<TilesBufferUk3> Indices { get; set; } = new();

    public CArray<Vector3> Uk3 { get; set; } = new();

    public CArray<CUInt32> Flags { get; set; } = new();

    public CArray<TilesBufferUk4> Info { get; set; } = new();

    public CArray<TilesBufferUk5> Uk4 { get; set; } = new();

    public TilesBuffer()
    {

    }
}

public class TileConnectedFace : IRedType
{
    public CUInt16 Index { get; set; }

    public CBool Bit { get; set; }

    public TileConnectedFace(CUInt16 raw)
    {
        Index = (CUInt16)(raw & 0x7FFF);
        Bit = (raw & 0x8000) > 0 ? true : false;
    }
}

public class TileFaceInfo : IRedType
{
    public CUInt32 Zero;

    public CArray<CUInt16> Indices { get; set; } = new();

    public CArray<TileConnectedFace> ConnectedFaces { get; set; } = new();

    public CUInt16 Three { get; set; }

    public CUInt8 NumIndices { get; set; }

    public CUInt8 Bits { get; set; }
}

public class TilesBufferUk2 : IRedType
{
    public CUInt64 Uk1 { get; set; }

    public CUInt64 Uk2 { get; set; }
}

public class TilesBufferUk3 : IRedType
{
    public CUInt32 Uk1 { get; set; }

    public CUInt32 Index { get; set; }

    public CUInt32 Uk2 { get; set; }
}

public class TilesBufferUk4 : IRedType
{
    public CArray<TilesBufferUk4_1> Uk1 { get; set; } = new();

    public CUInt32 Uk2 { get; set; }
}

public class TilesBufferUk4_1 : IRedType
{
    public CInt8 Value { get; set; }

    public CInt8 Flag { get; set; }
}

public class TilesBufferUk5 : IRedType
{
    public Vector3 Uk1 { get; set; } = new();

    public Vector3 Uk2 { get; set; } = new();

    public CFloat Uk3 { get; set; }

    public CUInt32 Uk4 { get; set; }
    
    public CUInt32 Uk5 { get; set; }
    
    public CUInt32 Uk6 { get; set; }
}

public class TilesMetadata : IRedType
{
    public CUInt32 Uk1 { get; set; }
    
    public CUInt32 TileX { get; set; }
    
    public CUInt32 TileY { get; set; }
    
    public CUInt32 Uk2 { get; set; }
    
    public CUInt32 Uk3 { get; set; }
    
    public CUInt32 Uk4 { get; set; }
}