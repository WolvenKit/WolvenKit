using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class WorldTransformsReader : Red4Reader, IBufferReader
{
    public WorldTransformsReader(MemoryStream ms) : base(ms)
    {

    }

    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        if (buffer.Parent is not worldInstancedMeshNode node)
        {
            throw new Exception();
        }

        var data = new WorldTransformsBuffer();
        while (_reader.BaseStream.Position < _reader.BaseStream.Length)
        {
            var t = new RenderProxyTransform();

            t.Transform.Position.X.Bits = _reader.ReadInt32();
            t.Transform.Position.Y.Bits = _reader.ReadInt32();
            t.Transform.Position.Z.Bits = _reader.ReadInt32();
            _reader.ReadInt32();

            t.Transform.Orientation.I = _reader.ReadSingle();
            t.Transform.Orientation.J = _reader.ReadSingle();
            t.Transform.Orientation.K = _reader.ReadSingle();
            t.Transform.Orientation.R = _reader.ReadSingle();

            t.Scale.X = _reader.ReadSingle();
            t.Scale.Y = _reader.ReadSingle();
            t.Scale.Z = _reader.ReadSingle();

            _reader.ReadInt32();

            data.Transforms.Add(t);
        }

        buffer.Data = data;

        return EFileReadErrorCodes.NoError;
    }
}
