using System.Reflection.Metadata;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Archive.IO;

public class worldNodeDataWriter : Red4Writer
{
    public worldNodeDataWriter(Stream ms) : base(ms)
    {

    }

    public void WriteBuffer(worldNodeDataBuffer ssb)
    {
        foreach (var t in ssb)
        {
            _writer.Write(t.Transform.Position.X);
            _writer.Write(t.Transform.Position.Y);
            _writer.Write(t.Transform.Position.Z);
            _writer.Write(t.Transform.Position.W);

            _writer.Write(t.Transform.Orientation.I);
            _writer.Write(t.Transform.Orientation.J);
            _writer.Write(t.Transform.Orientation.K);
            _writer.Write(t.Transform.Orientation.R);

            _writer.Write(t.Scale.X);
            _writer.Write(t.Scale.Y);
            _writer.Write(t.Scale.Z);

            _writer.Write(t.SecondaryRefPointPosition.X);
            _writer.Write(t.SecondaryRefPointPosition.Y);
            _writer.Write(t.SecondaryRefPointPosition.Z);

            _writer.Write(t.StreamingRefPoint.X);
            _writer.Write(t.StreamingRefPoint.Y);
            _writer.Write(t.StreamingRefPoint.Z);

            _writer.Write(t.Uk08.X);
            _writer.Write(t.Uk08.Y);
            _writer.Write(t.Uk08.Z);

            _writer.Write(t.Id);

            _writer.Write((ulong)t.GlobalNodeId.Hash);
            _writer.Write((ulong)t.Uk09);
            _writer.Write((ulong)t.CookedPrefabData.DepotPath.GetRedHash());

            _writer.Write(t.SecondaryRefPointDistance);
            _writer.Write(t.StreamingDistance);

            _writer.Write(t.NodeIndex);
            _writer.Write(t.Uk10);
            _writer.Write(t.Uk11);
            _writer.Write(t.Uk12);

            _writer.Write(t.Uk13);
            _writer.Write(t.Uk14);
        }
    }
}