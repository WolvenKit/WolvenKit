using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Archive.Buffer;

public class CollisionBuffer : IParseableBuffer
{
    public IRedType? Data => null;

    public CArray<CollisionActor> Actors { get; set; } = new();
}

public class CollisionActor : IRedClass
{
    public WorldPosition Position { get; set; } = new();
    public Quaternion Orientation { get; set; } = new();
    public CArray<CollisionShape> Shapes { get; set; } = new();
    public Vector3 Scale { get; set; } = new();
    public CInt16 Uk1 { get; set; }
    public CUInt64 Uk2 { get; set; }
}

public abstract class CollisionShape : IRedClass
{
    public CEnum<physicsShapeType> ShapeType { get; set; }
    public Vector3 Position { get; set; } = new();
    public Quaternion Rotation { get; set; } = new();
    public CName Preset { get; set; }
    public CEnum<physicsProxyType> ProxyType { get; set; }
    public CArray<CName> Materials { get; set; } = new();

    public CInt16 Uk1 { get; set; }
    public CUInt16 Uk2 { get; set; }
    public CUInt32 Uk3 { get; set; }
}

public class CollisionShapeSimple : CollisionShape
{
    public Vector3 Size { get; set; } = new();
}

public class CollisionShapeMesh : CollisionShape
{
    public CUInt64 Hash { get; set; }
}