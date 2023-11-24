using System;
using System.Collections.Generic;
using System.IO;

namespace WolvenKit.App.PhysX;

public class BigConvexData
{
    public ushort Subdiv { get; private set; }
    public ushort NbSamples { get; private set; }
    public byte[] Samples { get; set; } = Array.Empty<byte>();

    public uint NbVerts { get; set; }
    public uint NbAdjVerts { get; set; }
    public List<Valency> Valencies { get; } = new();
    public List<byte> AdjacentVerts { get; } = new();

    public bool Load(BinaryReader reader)
    {
        bool mismatch;

        var header = PhysXHelper.ReadHeader(reader);
        if (header.Type1 != "ICE" && header.Type2 != "SUPM")
        {
            throw new Exception();
        }
        mismatch = header.Mismatch;

        var header2 = PhysXHelper.ReadHeader(reader);
        if (header2.Type1 != "ICE" && header2.Type2 != "GAUS")
        {
            throw new Exception();
        }
        mismatch = header2.Mismatch;

        Subdiv = (ushort)reader.ReadUInt32();
        NbSamples = (ushort)reader.ReadUInt32();

        Samples = reader.ReadBytes(NbSamples * 2);

        return VLoad(reader);
    }

    public bool VLoad(BinaryReader reader)
    {
        bool mismatch;

        var header = PhysXHelper.ReadHeader(reader);
        if (header.Type1 != "ICE" && header.Type2 != "VALE")
        {
            throw new Exception();
        }
        mismatch = header.Mismatch;

        NbVerts = reader.ReadUInt32();
        NbAdjVerts = reader.ReadUInt32();

        if (header.Version != 2)
        {
            throw new Exception();
        }

        var indices = new List<ushort>();

        var maxIndex = reader.ReadUInt32();
        if (maxIndex <= 0xFF)
        {
            for (var i = 0; i < NbVerts; i++)
            {
                indices.Add(reader.ReadByte());
            }
        }
        else
        {
            for (var i = 0; i < NbVerts; i++)
            {
                indices.Add(reader.ReadUInt16());
            }
        }

        for (var i = 0; i < NbAdjVerts; i++)
        {
            AdjacentVerts.Add(reader.ReadByte());
        }

        return true;
    }
}