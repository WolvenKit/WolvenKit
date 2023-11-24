using System;
using System.Collections.Generic;
using System.IO;
using SharpDX;
using WolvenKit.Core.Extensions;

namespace WolvenKit.App.PhysX;

public class BV4Tree
{
    public LocalBounds LocalBounds { get; private set; }
    public uint InitData { get; private set; }

    // PT: dequantization coeff, either for Center or Min (depending on AABB format)
    public Vector3 CenterOrMinCoeff { get; private set; }

    // PT: dequantization coeff, either for Extents or Max (depending on AABB format)
    public Vector3 ExtentsOrMaxCoeff { get; private set; }

    public bool Quantized { get; set; }

    public List<PackedQuantizedAABB> Nodes { get; } = new();

    public bool Load(BinaryReader reader)
    {
        var type = new string(reader.ReadChars(4));
        if (type != "BV4 ")
        {
            throw new NotSupportedException();
        }

        var version = reader.ReadUInt32();
        if (version != 2)
        {
            throw new NotSupportedException();
        }

        LocalBounds = reader.BaseStream.ReadStruct<LocalBounds>();
        InitData = reader.ReadUInt32();
        CenterOrMinCoeff = reader.BaseStream.ReadStruct<Vector3>();
        ExtentsOrMaxCoeff = reader.BaseStream.ReadStruct<Vector3>();

        if (version < 3)
        {
            Quantized = true;
        }

        var nbNodes = reader.ReadUInt32();
        for (var i = 0; i < nbNodes; i++)
        {
            Nodes.Add(reader.BaseStream.ReadStruct<PackedQuantizedAABB>());
        }

        return true;
    }
}