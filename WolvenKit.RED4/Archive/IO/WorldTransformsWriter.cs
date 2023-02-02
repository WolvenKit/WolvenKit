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
            ArgumentNullException.ThrowIfNull(wnt);

            _writer.Write((int)(wnt.Translation.X / 0.0000076293945F));
            _writer.Write((int)(wnt.Translation.Y / 0.0000076293945F));
            _writer.Write((int)(wnt.Translation.Z / 0.0000076293945F));

            _writer.Write(0);

            _writer.Write(wnt.Rotation.I);
            _writer.Write(wnt.Rotation.J);
            _writer.Write(wnt.Rotation.K);
            _writer.Write(wnt.Rotation.R);

            _writer.Write(wnt.Scale.X);
            _writer.Write(wnt.Scale.Y);
            _writer.Write(wnt.Scale.Z);
            _writer.Write(0);
        }
    }
}