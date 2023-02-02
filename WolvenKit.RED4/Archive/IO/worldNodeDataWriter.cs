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
            ArgumentNullException.ThrowIfNull(t);

            _writer.Write(t.Position.X);
            _writer.Write(t.Position.Y);
            _writer.Write(t.Position.Z);
            _writer.Write(t.Position.W);

            _writer.Write(t.Orientation.I);
            _writer.Write(t.Orientation.J);
            _writer.Write(t.Orientation.K);
            _writer.Write(t.Orientation.R);

            _writer.Write(t.Scale.X);
            _writer.Write(t.Scale.Y);
            _writer.Write(t.Scale.Z);

            _writer.Write(t.Pivot.X);
            _writer.Write(t.Pivot.Y);
            _writer.Write(t.Pivot.Z);

            _writer.Write(t.Bounds.Min.X);
            _writer.Write(t.Bounds.Min.Y);
            _writer.Write(t.Bounds.Min.Z);

            _writer.Write(t.Bounds.Max.X);
            _writer.Write(t.Bounds.Max.Y);
            _writer.Write(t.Bounds.Max.Z);

            _writer.Write(t.Id);

            _writer.Write((ulong)t.QuestPrefabRefHash);
            _writer.Write((ulong)t.UkHash1);
            _writer.Write((ulong)t.CookedPrefabData.DepotPath.GetRedHash());

            _writer.Write(t.MaxStreamingDistance);
            _writer.Write(t.UkFloat1);

            _writer.Write(t.NodeIndex);
            _writer.Write(t.Uk10);
            _writer.Write(t.Uk11);
            _writer.Write(t.Uk12);
        }
    }
}