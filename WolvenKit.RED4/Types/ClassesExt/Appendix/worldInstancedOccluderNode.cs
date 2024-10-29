using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public partial class worldInstancedOccluderNode : IRedAppendix
{
    [RED("buffer")]
    [REDProperty(IsIgnored = true)]
    public CArray<worldInstancedOccluderNode_Buffer> Buffer
    {
        get => GetPropertyValue<CArray<worldInstancedOccluderNode_Buffer>>();
        set => SetPropertyValue<CArray<worldInstancedOccluderNode_Buffer>>(value);
    }

    partial void PostConstruct()
    {
        Buffer = new CArray<worldInstancedOccluderNode_Buffer>();
    }

    public void Read(Red4Reader reader, uint size)
    {
        if (size == 0)
        {
            return;
        }

        var length = reader.BaseReader.ReadByte(); // Could be VLQ, didn't find any with > 128 so couldn't confirm
        for (var i = 0; i < length; i++)
        {
            Buffer.Add(new worldInstancedOccluderNode_Buffer
            {
                Unknown1 = new Vector4 { X = reader.ReadCFloat(), Y = reader.ReadCFloat(), Z = reader.ReadCFloat(), W = reader.ReadCFloat() },
                Unknown2 = new Vector4 { X = reader.ReadCFloat(), Y = reader.ReadCFloat(), Z = reader.ReadCFloat(), W = reader.ReadCFloat() },
                Unknown3 = new Vector4 { X = reader.ReadCFloat(), Y = reader.ReadCFloat(), Z = reader.ReadCFloat(), W = reader.ReadCFloat() },
                Unknown4 = new Vector4 { X = reader.ReadCFloat(), Y = reader.ReadCFloat(), Z = reader.ReadCFloat(), W = reader.ReadCFloat() }
            });
        }
    }

    public void Write(Red4Writer writer)
    {
        // TODO: Check if 0 is not written at all or the length 0 is written
        if (Buffer.Count == 0)
        {
            return;
        }

        writer.BaseWriter.Write((byte)Buffer.Count);
        foreach (var worldInstancedOccluderNodeBuffer in Buffer)
        {
            writer.Write(worldInstancedOccluderNodeBuffer.Unknown1.X);
            writer.Write(worldInstancedOccluderNodeBuffer.Unknown1.Y);
            writer.Write(worldInstancedOccluderNodeBuffer.Unknown1.Z);
            writer.Write(worldInstancedOccluderNodeBuffer.Unknown1.W);

            writer.Write(worldInstancedOccluderNodeBuffer.Unknown2.X);
            writer.Write(worldInstancedOccluderNodeBuffer.Unknown2.Y);
            writer.Write(worldInstancedOccluderNodeBuffer.Unknown2.Z);
            writer.Write(worldInstancedOccluderNodeBuffer.Unknown2.W);

            writer.Write(worldInstancedOccluderNodeBuffer.Unknown3.X);
            writer.Write(worldInstancedOccluderNodeBuffer.Unknown3.Y);
            writer.Write(worldInstancedOccluderNodeBuffer.Unknown3.Z);
            writer.Write(worldInstancedOccluderNodeBuffer.Unknown3.W);

            writer.Write(worldInstancedOccluderNodeBuffer.Unknown4.X);
            writer.Write(worldInstancedOccluderNodeBuffer.Unknown4.Y);
            writer.Write(worldInstancedOccluderNodeBuffer.Unknown4.Z);
            writer.Write(worldInstancedOccluderNodeBuffer.Unknown4.W);
        }
    }
}

public class worldInstancedOccluderNode_Buffer : IRedClass
{
    public Vector4 Unknown1 { get; set; }
    public Vector4 Unknown2 { get; set; }
    public Vector4 Unknown3 { get; set; }
    public Vector4 Unknown4 { get; set; }
}