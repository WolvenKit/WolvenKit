using System.IO;
using WolvenKit.RED4.IO;
using System.ComponentModel;

namespace WolvenKit.RED4.Types;

public partial class worldInstancedMeshNode : IRedAppendix
{
    [RED("buffer")]
    [REDProperty(IsIgnored = true)]
    [Browsable(false)]
    public worldInstancedMeshNode_Buffer Buffer
    {
        get => GetPropertyValue<worldInstancedMeshNode_Buffer>();
        set => SetPropertyValue<worldInstancedMeshNode_Buffer>(value);
    }

    partial void PostConstruct()
    {
        Buffer = new worldInstancedMeshNode_Buffer();
    }

    public void Read(Red4Reader reader, uint size)
    {
        if (size == 0)
        {
            return;
        }

        var length = reader.BaseReader.ReadByte(); // Could be something else, in base files its always 1
        for (var i = 0; i < length; i++)
        {
            Buffer.Unknown1.Add(new Box
            {
                Min = new Vector4 { X = reader.ReadCFloat(), Y = reader.ReadCFloat(), Z = reader.ReadCFloat(), W = reader.ReadCFloat() },
                Max = new Vector4 { X = reader.ReadCFloat(), Y = reader.ReadCFloat(), Z = reader.ReadCFloat(), W = reader.ReadCFloat() }
            });
        }

        length = reader.BaseReader.ReadByte(); // Could be something else, in base files its always 1
        for (var i = 0; i < length; i++)
        {
            Buffer.Unknown2.Add(reader.ReadCFloat());
        }

        length = reader.BaseReader.ReadByte(); // Could be something else, in base files its always 1
        for (var i = 0; i < length; i++)
        {
            Buffer.Unknown3.Add(reader.ReadCUInt32());
        }
    }

    public void Write(Red4Writer writer)
    {
        // TODO: Check for empty buffers. Nothing written vs length 0

        writer.BaseWriter.Write((byte)Buffer.Unknown1.Count); // Could be something else, in base files its always 1
        foreach (var box in Buffer.Unknown1)
        {
            writer.Write(box.Min.X);
            writer.Write(box.Min.Y);
            writer.Write(box.Min.Z);
            writer.Write(box.Min.W);

            writer.Write(box.Max.X);
            writer.Write(box.Max.Y);
            writer.Write(box.Max.Z);
            writer.Write(box.Max.W);
        }

        writer.BaseWriter.Write((byte)Buffer.Unknown2.Count); // Could be something else, in base files its always 1
        foreach (var val in Buffer.Unknown2)
        {
            writer.Write(val);
        }

        writer.BaseWriter.Write((byte)Buffer.Unknown3.Count); // Could be something else, in base files its always 1
        foreach (var val in Buffer.Unknown3)
        {
            writer.Write(val);
        }
    }
}

public class worldInstancedMeshNode_Buffer : IRedClass
{
    public CArray<Box> Unknown1 { get; set; } = new(); // some kind of boundingBox for worldInstancedMeshNode.worldTransformBuffer elements
    public CArray<CFloat> Unknown2 { get; set; } = new(); // ???
    public CArray<CUInt32> Unknown3 { get; set; } = new(); // same as worldInstancedMeshNode.worldTransformBuffer.numElements
}