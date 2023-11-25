using System.Runtime.InteropServices;
using SharpDX;

namespace WolvenKit.App.PhysX;

[StructLayout(LayoutKind.Sequential)]
public struct Bounds3
{
    public Vector3 Minimum;
    public Vector3 Maximum;
}

[StructLayout(LayoutKind.Sequential)]
public struct Plane
{
    public Vector3 N;
    public float D;
}

[StructLayout(LayoutKind.Sequential)]
public struct HullPolygonData
{
    public Plane Plane;
    public ushort VRef8;
    public byte NbVerts;
    public byte MinIndex;
}

[StructLayout(LayoutKind.Sequential)]
public struct InternalObjectsData
{
    public float Radius;

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public float[] Extents;
}

[StructLayout(LayoutKind.Sequential)]
public struct Valency
{
    public ushort Count;
    public ushort Offset;
}

[StructLayout(LayoutKind.Sequential)]
public struct LocalBounds
{
    public Vector3 Center;
    public float ExtentsMagnitude;
}

[StructLayout(LayoutKind.Sequential)]
public struct QuantizedAABB
{
    public struct DataStruct
    {
        public ushort Extents;
        public short Center;
    };

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public DataStruct[] Data;
}

[StructLayout(LayoutKind.Sequential)]
public struct PackedQuantizedAABB
{
    public QuantizedAABB AABB;
    public uint Data;
}