using System;
using System.IO;
using System.Numerics;

namespace WolvenKit.Modkit.RED4.Tools.MeshHandler.Extras;

public class VertexAttributeReader : BinaryReader
{
    public VertexAttributeReader(Stream input) : base(input)
    {
    }

    public Vector4 ReadShortN4()
    {
        return new Vector4
        {
            X = ReadInt16() * (1f / 32767.0f),
            Y = ReadInt16() * (1f / 32767.0f),
            Z = ReadInt16() * (1f / 32767.0f),
            W = ReadInt16() * (1f / 32767.0f)
        };
    }

    public Vector4 ReadWKitShortN4()
    {
        return new Vector4
        {
            X = ReadInt16(),
            Y = ReadInt16(),
            Z = ReadInt16(),
            W = ReadInt16()
        };
    }

    public Vector4 ReadHalf2()
    {
        return new Vector4
        {
            X = (float)ReadHalf(),
            Y = (float)ReadHalf(),
            Z = 0,
            W = 0
        };
    }

    public Vector2 ReadWkitHalf2()
    {
        return new Vector2
        {
            X = (float)ReadHalf(),
            Y = (float)ReadHalf()
        };
    }

    public Vector4 ReadColor()
    {
        var u32 = ReadUInt32();

        return new Vector4
        {
            X = (float)((u32 >> 16) & 0xFF) / 255.0f,
            Y = (float)((u32 >> 8) & 0xFF) / 255.0f,
            Z = (float)((u32 >> 0) & 0xFF) / 255.0f,
            W = (float)((u32 >> 24) & 0xFF) / 255.0f
        };
    }

    public Vector4 ReadWkitColor()
    {
        return new Vector4
        {
            X = ReadByte(),
            Y = ReadByte(),
            Z = ReadByte(),
            W = ReadByte()
        };
    }

    public Vector4 ReadFloat4()
    {
        return new Vector4
        {
            X = ReadSingle(),
            Y = ReadSingle(),
            Z = ReadSingle(),
            W = ReadSingle()
        };
    }

    public Vector4 ReadUByte4()
    {
        return new Vector4
        {
            X = ReadByte(),
            Y = ReadByte(),
            Z = ReadByte(),
            W = ReadByte()
        };
    }

    public Vector4 ReadUByteN4()
    {
        return new Vector4
        {
            X = ReadByte() / 255.0f,
            Y = ReadByte() / 255.0f,
            Z = ReadByte() / 255.0f,
            W = ReadByte() / 255.0f
        };
    }

    public Vector4 ReadWkitUByteN4()
    {
        return new Vector4
        {
            X = ReadByte(),
            Y = ReadByte(),
            Z = ReadByte(),
            W = ReadByte()
        };
    }

    public Vector4 ReadUShort2()
    {
        return new Vector4
        {
            X = ReadUInt16(),
            Y = ReadUInt16(),
            Z = 0,
            W = 0
        };
    }

    public Vector4 ReadFloat()
    {
        return new Vector4
        {
            X = ReadSingle(),
            Y = 0,
            Z = 0,
            W = 0
        };
    }

    public Vector4 ReadHalf4()
    {
        return new Vector4
        {
            X = (float)ReadHalf(),
            Y = (float)ReadHalf(),
            Z = (float)ReadHalf(),
            W = (float)ReadHalf()
        };
    }

    public Vector4 ReadUInt()
    {
        return new Vector4
        {
            X = (float)ReadUInt32(),
            Y = 0,
            Z = 0,
            W = 0
        };
    }

    public uint ReadWkitUInt()
    {
        return ReadUInt32();
    }

    public Vector4 ReadDec4()
    {
        var u32 = ReadUInt32();

        Vector4 v;
        uint element;
        uint[] signExtend = [0x00000000, 0xFFFFFC00];
        uint[] signExtendW = [0x00000000, 0xFFFFFFFC];

        element = u32 & 0x3FF;
        v.X = (float)(short)(element | signExtend[element >> 9]);
        element = (u32 >> 10) & 0x3FF;
        v.Y = (float)(short)(element | signExtend[element >> 9]);
        element = (u32 >> 20) & 0x3FF;
        v.Z = (float)(short)(element | signExtend[element >> 9]);
        element = u32 >> 30;
        v.W = (float)(short)(element | signExtendW[element >> 9]);

        return v;
    }

    public Vector4 ReadWKitDec4()
    {
        var u32 = ReadUInt32();

        u32 ^= 0b1010_0000_0000_1000_0000_0010_0000_0000;

        Vector4 v;
        uint element;
        uint[] signExtend = [0x00000000, 0xFFFFFC00];
        uint[] signExtendW = [0x00000000, 0xFFFFFFFC];

        element = u32 & 0x3FF;
        v.X = (float)(short)(element | signExtend[element >> 9]);
        element = (u32 >> 10) & 0x3FF;
        v.Y = (float)(short)(element | signExtend[element >> 9]);
        element = (u32 >> 20) & 0x3FF;
        v.Z = (float)(short)(element | signExtend[element >> 9]);
        element = u32 >> 30;
        v.W = (float)(short)(element | signExtendW[element >> 9]);

        return v;
    }

    public Vector4 ReadUDec4()
    {
        var u32 = ReadUInt32();

        Vector4 v;
        uint element;

        element = u32 & 0x3FF;
        v.X = (int)(element & 0x1FF);
        if ((element & 0x200) == 0)
        {
            v.X = (short)(element | 0xFFFFFE00);
        }
        v.X /= 511f;

        element = (u32 >> 10) & 0x3FF;
        v.Y = (int)(element & 0x1FF);
        if ((element & 0x200) == 0)
        {
            v.Y = (short)(element | 0xFFFFFE00);
        }
        v.Y /= 511f;

        element = (u32 >> 20) & 0x3FF;
        v.Z = (int)(element & 0x1FF);
        if ((element & 0x200) == 0)
        {
            v.Z = (short)(element | 0xFFFFFE00);
        }
        v.Z /= 511f;

        element = (u32 >> 30) & 0x3;
        v.W = (int)(element & 0x1);
        if ((element & 0x2) == 0)
        {
            v.W = (short)(element | 0xFFFFFFFE);
        }
        v.W /= 1f;

        return v;
    }

    public Vector4 ReadWKitDec4Old()
    {
        var u32 = ReadUInt32();

        var dequant = 1f / 1023f;

        var x3 = Convert.ToSingle(u32 & 0x3ff);
        var y3 = Convert.ToSingle((u32 >> 10) & 0x3ff);
        var z3 = Convert.ToSingle((u32 >> 20) & 0x3ff);
        var w3 = (u32 >> 30) switch
        {
            0 => 1f,
            3 => -1f,
            _ => 0f // just for normals, doesn't matter there
        };

        return new Vector4
        {
            X = (x3 * 2 * dequant) - 1f,
            Y = (y3 * 2 * dequant) - 1f,
            Z = (z3 * 2 * dequant) - 1f,
            W = w3
        };
    }
}
