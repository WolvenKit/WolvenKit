using System;
using System.Collections.Generic;
using System.IO;
using SharpDX;
using WolvenKit.Core.Extensions;

namespace WolvenKit.Common.PhysX;

public class ConvexHullData
{
    public List<Vector3> HullVertices { get; } = new();
    public List<HullPolygonData> Polygons { get; } = new();
    public Bounds3 AABB { get; set; }
    public Vector3 CenterOfMass { get; set; }
    public InternalObjectsData Internal { get; set; }

    public byte[] VertexData8 { get; set; } = Array.Empty<byte>();
    public byte[] FacesByEdges8 { get; set; } = Array.Empty<byte>();
    public byte[] FacesByVertices8 { get; set; } = Array.Empty<byte>();

    public bool Load(BinaryReader reader)
    {
        bool mismatch;

        var header = PhysXHelper.ReadHeader(reader);
        if (header.Type1 != "ICE" && header.Type2 != "CLHL")
        {
            throw new Exception();
        }
        mismatch = header.Mismatch;

        if (header.Version <= 8)
        {
            var header2 = PhysXHelper.ReadHeader(reader);
            if (header2.Type1 != "ICE" && header2.Type2 != "CVHL")
            {
                throw new Exception();
            }
            mismatch = header2.Mismatch;
        }

        var nbHullVertices = (byte)reader.ReadUInt32();
        var nbEdges = (ushort)reader.ReadUInt32();
        var nbPolygons = (byte)reader.ReadUInt32();
        var nb = reader.ReadUInt32();

        for (var i = 0; i < nbHullVertices; i++)
        {
            HullVertices.Add(reader.BaseStream.ReadStruct<Vector3>());
        }

        for (var i = 0; i < nbPolygons; i++)
        {
            Polygons.Add(reader.BaseStream.ReadStruct<HullPolygonData>());
        }

        VertexData8 = reader.ReadBytes((int)nb);
        FacesByEdges8 = reader.ReadBytes(nbEdges * 2);
        FacesByVertices8 = reader.ReadBytes(nbHullVertices * 3);

        if ((nbEdges & 0x8000) != 0)
        {
            throw new Exception();
        }

        return true;
    }
}