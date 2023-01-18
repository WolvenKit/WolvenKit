using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class TilesReader : Red4Reader, IBufferReader
{
    public TilesReader(MemoryStream ms) : base(ms)
    {

    }

    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        var tiles = new TilesBuffer();

        var header = _reader.BaseStream.ReadStruct<TilesBufferHeader>();

        tiles.Uk1.X = _reader.ReadSingle();
        tiles.Uk1.Y = _reader.ReadSingle();
        tiles.Uk1.Z = _reader.ReadSingle();

        tiles.Min.X = _reader.ReadSingle();
        tiles.Min.Y = _reader.ReadSingle();
        tiles.Min.Z = _reader.ReadSingle();

        tiles.Max.X = _reader.ReadSingle();
        tiles.Max.Y = _reader.ReadSingle();
        tiles.Max.Z = _reader.ReadSingle();

        tiles.Uk2 = _reader.ReadSingle();

        for (int i = 0; i < header.count2; i++)
        {
            var v = new Vector3();
            v.X = _reader.ReadSingle();
            v.Y = _reader.ReadSingle();
            v.Z = _reader.ReadSingle();
            tiles.Vertices.Add(v);
        }

        for (int i = 0; i < header.count1; i++)
        {
            var u = new TileFaceInfo();
            u.Zero = _reader.ReadUInt32();
            for (int j = 0; j < 3; j++)
            {
                u.Indices.Add(_reader.ReadUInt16());
            }
            for (int j = 0; j < 3; j++)
            {
                u.ConnectedFaces.Add(new TileConnectedFace(_reader.ReadUInt16()));
            }
            u.Three = _reader.ReadUInt16();
            u.NumIndices = _reader.ReadByte();
            u.Bits = _reader.ReadByte();
            tiles.FaceInfo.Add(u);
        }

        for (int i = 0; i < header.count3; i++)
        {
            var u = new TilesBufferUk2();
            u.Uk1 = _reader.ReadUInt64();
            u.Uk2 = _reader.ReadUInt64();
            tiles.Zeros.Add(u);
        }

        for (int i = 0; i < header.count4; i++)
        {
            var u = new TilesBufferUk3();
            u.Uk1 = _reader.ReadUInt32();
            u.Index = _reader.ReadUInt32();
            u.Uk2 = _reader.ReadUInt32();
            tiles.Indices.Add(u);
        }

        for (int i = 0; i < header.count4; i++)
        {
            tiles.Flags.Add(_reader.ReadUInt32());
        }

        for (int i = 0; i < header.count6; i++)
        {
            var u = new TilesBufferUk4();
            for (int j = 0; j < 6; j++)
            {
                u.Uk1.Add(new TilesBufferUk4_1()
                {
                    Value = _reader.ReadSByte(),
                    Flag = _reader.ReadSByte()
                });
            }
            u.Uk2 = _reader.ReadUInt32();
            tiles.Info.Add(u);
        }

        buffer.Data = tiles;

        return EFileReadErrorCodes.NoError;
    }
}