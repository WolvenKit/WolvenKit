using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public partial class WorldSharedDataBufferReader
{
    public EFileReadErrorCodes ReadWorldTransformsBuffer(RedBuffer buffer)
    {
        var data = new WorldTransformsBuffer();
        while (_reader.BaseStream.Position < _reader.BaseStream.Length)
        {
            var t = new worldNodeTransform();

            t.Translation.X = _reader.ReadInt32() * 0.0000076293945F;
            t.Translation.Y = _reader.ReadInt32() * 0.0000076293945F;
            t.Translation.Z = _reader.ReadInt32() * 0.0000076293945F;

            _reader.ReadInt32();

            t.Rotation.I = _reader.ReadSingle();
            t.Rotation.J = _reader.ReadSingle();
            t.Rotation.K = _reader.ReadSingle();
            t.Rotation.R = _reader.ReadSingle();

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