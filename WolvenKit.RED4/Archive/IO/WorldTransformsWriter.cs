using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Archive.IO;

public class WorldTransformsWriter : Red4Writer
{
    public WorldTransformsWriter(MemoryStream ms) : base(ms)
    {

    }

    public void WriteBuffer(WorldTransformsBuffer wtb)
    {
        foreach (var wnt in wtb.Transforms)
        {
            _writer.Write(wnt.Transform.Position.X.Bits);
            _writer.Write(wnt.Transform.Position.Y.Bits);
            _writer.Write(wnt.Transform.Position.Z.Bits);

            _writer.Write(0);

            _writer.Write(wnt.Transform.Orientation.I);
            _writer.Write(wnt.Transform.Orientation.J);
            _writer.Write(wnt.Transform.Orientation.K);
            _writer.Write(wnt.Transform.Orientation.R);

            _writer.Write(wnt.Scale.X);
            _writer.Write(wnt.Scale.Y);
            _writer.Write(wnt.Scale.Z);

            _writer.Write(0);
        }
    }
}
