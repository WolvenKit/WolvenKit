using System;
using System.Collections.Generic;
using System.IO;
using SharpDX;
using WolvenKit.Core.Extensions;

namespace WolvenKit.Common.PhysX;

[Flags]
internal enum InternalMeshSerialFlag : uint
{
    IMSF_MATERIALS = (1 << 0),  //!< if set, the cooked mesh file contains per-triangle material indices
    IMSF_FACE_REMAP = (1 << 1), //!< if set, the cooked mesh file contains a remap table
    IMSF_8BIT_INDICES = (1 << 2),   //!< if set, the cooked mesh file contains 8bit indices (topology)
    IMSF_16BIT_INDICES = (1 << 3),  //!< if set, the cooked mesh file contains 16bit indices (topology)
    IMSF_ADJACENCIES = (1 << 4),    //!< if set, the cooked mesh file contains adjacency structures
    IMSF_GRB_DATA = (1 << 5),   //!< if set, the cooked mesh file contains GRB data structures
    IMSF_SDF = (1 << 6),    //!< if set, the cooked mesh file contains SDF data structures
    IMSF_VERT_MAPPING = (1 << 7), //!< if set, the cooked mesh file contains vertex mapping information
    IMSF_GRB_INV_REMAP = (1 << 8),  //!< if set, the cooked mesh file contains vertex inv mapping information. Required for cloth
    IMSF_INERTIA = (1 << 9) //!< if set, the cooked mesh file contains inertia tensor for the mesh
};

public class BV4TriangleMesh : PhysXMesh
{
    // MeshDataBase
    public uint NbVertices { get; set; }
    public List<Vector3> Vertices { get; } = new();
    public Bounds3 AABB { get; set; }
    public float GeomEpsilon { get; set; }

    // TriangleMeshData
    public uint NbTriangles { get; set; }
    public List<List<uint>> Triangles { get; } = new();
    public byte[] ExtraTrigData { get; set; } = Array.Empty<byte>();

    // BV4TriangleData
    public BV4Tree BV4Tree { get; } = new();

    public bool Load(BinaryReader reader, PhysXHeader header)
    {
        if (header.Type1 != "NXS" || header.Type2 != "MESH")
        {
            throw new Exception();
        }

        if (header.Version != 15)
        {
            throw new NotSupportedException();
        }

        var midphaseID = reader.ReadUInt32();
        var serialFlags = (InternalMeshSerialFlag)reader.ReadUInt32();

        if (midphaseID != 1) // eBVH34
        {
            throw new NotSupportedException();
        }

        NbVertices = reader.ReadUInt32();
        NbTriangles = reader.ReadUInt32();

        for (var i = 0; i < NbVertices; i++)
        {
            Vertices.Add(reader.BaseStream.ReadStruct<Vector3>());
        }

        for (var i = 0; i < NbTriangles; i++)
        {
            var ra = new List<uint>();
            if (serialFlags.HasFlag(InternalMeshSerialFlag.IMSF_8BIT_INDICES))
            {
                ra.Add(reader.ReadByte());
                ra.Add(reader.ReadByte());
                ra.Add(reader.ReadByte());
            }
            else if (serialFlags.HasFlag(InternalMeshSerialFlag.IMSF_16BIT_INDICES))
            {
                ra.Add(reader.ReadUInt16());
                ra.Add(reader.ReadUInt16());
                ra.Add(reader.ReadUInt16());
            }
            else
            {
                ra.Add(reader.ReadUInt32());
                ra.Add(reader.ReadUInt32());
                ra.Add(reader.ReadUInt32());
            }
            Triangles.Add(ra);
        }

        if (serialFlags.HasFlag(InternalMeshSerialFlag.IMSF_MATERIALS))
        {
            reader.BaseStream.Position += NbTriangles * 2;
        }
        BV4Tree.Load(reader);

        GeomEpsilon = reader.ReadSingle();
        AABB = reader.BaseStream.ReadStruct<Bounds3>();

        var nb = reader.ReadUInt32();
        ExtraTrigData = reader.ReadBytes((int)nb);

        return true;
    }
}