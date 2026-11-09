using System;
using System.IO;
using System.Numerics;

namespace WolvenKit.Modkit.RED4.Tools.MeshHandler.Extras;

public class VertexAttributeWriter : BinaryWriter
{
    public VertexAttributeWriter(Stream stream) : base(stream)
    {

    }

    public void WriteShort4N(Vector3 vector)
    {

        Write((Int16)(Math.Round(vector.X * Int16.MaxValue)));
        Write((Int16)(Math.Round(vector.Y * Int16.MaxValue)));
        Write((Int16)(Math.Round(vector.Z * Int16.MaxValue)));
        Write(Int16.MaxValue);
    }

    public void WriteUByte4(Vector4 vector)
    {
        Write((Byte)vector.X);
        Write((Byte)vector.Y);
        Write((Byte)vector.Z);
        Write((Byte)vector.W);
    }

    public void WriteUByte4N(Vector4 vector)
    {
        Write((Byte)(vector.X * Byte.MaxValue));
        Write((Byte)(vector.Y * Byte.MaxValue));
        Write((Byte)(vector.Z * Byte.MaxValue));
        Write((Byte)(vector.W * Byte.MaxValue));
    }

    public void WriteFloat16_2(Vector2 vector)
    {
        Write((Half)vector.X);
        Write((Half)vector.Y);
    }

    public void WriteFloat16_4(Vector3 vector)
    {
        Write((Half)vector.X);
        Write((Half)vector.Y);
        Write((Half)vector.Z);
        Write((Half)0);
    }

    public void WriteDec4(Vector3 vector)
    {
        var quant = 1f / 1023f;

        var x = (UInt16)(Math.Round((vector.X + 1F) / quant / 2));
        var y = (UInt16)(Math.Round((vector.Y + 1F) / quant / 2));
        var z = (UInt16)(Math.Round((vector.Z + 1F) / quant / 2));
        var w = (Byte)1;

        var u32 = (uint)((x & 0x3FF) | (y & 0x3FF) << 10 | (z & 0x3FF) << 20 | (w & 0x3) << 30);

        Write(u32);
    }

    public void WriteDec4(Vector4 vector)
    {
        var quant = 1f / 1023f;

        var x = (UInt16)(Math.Round((vector.X + 1F) / quant / 2));
        var y = (UInt16)(Math.Round((vector.Y + 1F) / quant / 2));
        var z = (UInt16)(Math.Round((vector.Z + 1F) / quant / 2));
        var w = vector.W switch
        {
            1f => 0,
            -1f => 3,
            _ => throw new InvalidOperationException()
        };

        var u32 = (uint)((x & 0x3FF) | (y & 0x3FF) << 10 | (z & 0x3FF) << 20 | (w & 0x3) << 30);

        Write(u32);
    }

    public void WriteWKitDec4(Vector3 vector) => WriteWKitDec4(new Vector4(vector.X, vector.Y, vector.Z, 0F));

    public void WriteWKitDec4(Vector4 vector)
    {
        uint u32 = 0;

        var w = vector.W switch
        {
            -1F => 1,
             0F => 3,
             1F => 2,
            _ => throw new InvalidOperationException()
        };

        u32 |= ((uint)w        & 0x003) << 30;
        u32 |= ((uint)vector.Z & 0x3FF) << 20;
        u32 |= ((uint)vector.Y & 0x3FF) << 10;
        u32 |= ((uint)vector.X & 0x3FF) << 0;

        u32 ^= 0b1010_0000_0000_1000_0000_0010_0000_0000;

        Write(u32);
    }

    public void WriteColor(Vector3 vector)
    {
        Write((Byte)(vector.X * Byte.MaxValue));
        Write((Byte)(vector.Y * Byte.MaxValue));
        Write((Byte)(vector.Z * Byte.MaxValue));
        Write((Byte)1);
    }

    public void WriteColor(Vector4 vector)
    {
        Write((Byte)(vector.X * Byte.MaxValue));
        Write((Byte)(vector.Y * Byte.MaxValue));
        Write((Byte)(vector.Z * Byte.MaxValue));
        Write((Byte)(vector.W * Byte.MaxValue));
    }

    public void WriteFloat4(Vector3 vector)
    {
        Write(vector.X);
        Write(vector.Y);
        Write(vector.Z);
        Write(1F);
    }
}
