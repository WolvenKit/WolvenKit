using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class CGIDataReader : Red4Reader, IBufferReader
{
    public CGIDataReader(MemoryStream ms) : base(ms)
    {

    }

    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        var data = new CGIDataBuffer();

        var fileId = _reader.ReadChars(4);

        if (fileId[0] != 'z' || fileId[1] != 'p' || fileId[2] != 'I' || fileId[3] != 'G')
        {
            return EFileReadErrorCodes.UnsupportedVersion;
        }

        data.Uk1 = _reader.ReadUInt32();
        data.Uk2 = _reader.ReadUInt32();
        data.Uk3 = _reader.ReadUInt32();
        var numBrck = _reader.ReadUInt32();
        var numSurf = _reader.ReadUInt32();
        var numProb = _reader.ReadUInt32();
        var numFact = _reader.ReadUInt32();
        var numTetr = _reader.ReadUInt32();
        data.Uk4 = _reader.ReadUInt32();
        data.Uk5 = _reader.ReadUInt32();
        data.Uk6 = _reader.ReadUInt32();

        data.Bounds.Min.X = _reader.ReadSingle();
        data.Bounds.Min.Y = _reader.ReadSingle();
        data.Bounds.Min.Z = _reader.ReadSingle();

        data.Bounds.Max.X = _reader.ReadSingle();
        data.Bounds.Max.Y = _reader.ReadSingle();
        data.Bounds.Max.Z = _reader.ReadSingle();

        var brck = _reader.ReadChars(4);

        for (int i = 0; i < numBrck; i++)
        {
            var chunk = _reader.ReadUInt32();

            data.Brcks.Add(new CGIBrck()
            {
                Offset = chunk & 0b0000000000011111111111111111111,
                Length = (ushort)((chunk & 0b1111111111100000000000000000000) >> 21),
                Uk1 = _reader.ReadByte(),
                Uk2 = _reader.ReadByte(),
                Uk3 = _reader.ReadByte(),
                Uk4 = _reader.ReadByte()
            });
        }

        var surf = _reader.ReadChars(4);

        for (int i = 0; i < numSurf; i++)
        {
            data.Surfs.Add(new CGISurf()
            {
                Uk1 = _reader.ReadUInt16(),
                Uk2 = _reader.ReadByte(),
                Uk3 = _reader.ReadByte()
            });
        }

        var numColors = _reader.ReadUInt32();

        for (int i = 0; i < numColors; i++)
        {
            data.Colors.Add(new CColor()
            {
                Red = _reader.ReadByte(),
                Green = _reader.ReadByte(),
                Blue = _reader.ReadByte(),
                Alpha = 255
            });
        }

        for (int i = 0; i < numBrck; i++)
        {
            var count = _reader.ReadByte();
            var ra = new CArray<CGIUkBrckItem>();
            for (int j = 0; j < count; j++)
            {
                ra.Add(new CGIUkBrckItem()
                {
                    Uk1 = _reader.ReadByte(),
                    Uk2 = _reader.ReadByte(),
                    Uk3 = _reader.ReadByte()
                });
            }
            data.UkBrckItems.Add(ra);
        }

        for (int i = 0; i < 255; i++)
        {
            var count = _reader.ReadUInt16();
            var ra = new CArray<CGIUkColorItem>();
            for (int j = 0; j < count; j++)
            {
                ra.Add(new CGIUkColorItem()
                {
                    Uk1 = _reader.ReadUInt16(),
                    Uk2 = _reader.ReadByte(),
                    Uk3 = _reader.ReadByte()
                });
            }
            data.UkColorItems.Add(ra);
        }

        var prob = _reader.ReadChars(4);

        for (int i = 0; i < numProb; i++)
        {
            data.Probs.Add(new CGIProb()
            {
                Uk1 = _reader.ReadUInt16(),
                Uk2 = _reader.ReadUInt16(),
                Uk3 = _reader.ReadUInt16(),
                Uk4 = _reader.ReadUInt16(),
                Uk5 = _reader.ReadUInt16(),
                Uk6 = _reader.ReadUInt16(),
                Uk7 = _reader.ReadUInt16(),
                Uk8 = _reader.ReadUInt16(),
                Uk9 = _reader.ReadUInt16(),
                Uk10 = _reader.ReadUInt16(),
                Uk11 = _reader.ReadUInt16(),
                Uk12 = _reader.ReadUInt16(),
                Uk13 = _reader.ReadUInt16(),
                Uk14 = _reader.ReadUInt16(),
                Uk15 = _reader.ReadUInt16(),
                Uk16 = _reader.ReadUInt16(),
                Uk17 = _reader.ReadUInt64(),
                Uk18 = _reader.ReadUInt32()
            });
        }

        var fact = _reader.ReadChars(4);

        for (int i = 0; i < numFact; i++)
        {
            data.Facts.Add(new CGIFact()
            {
                Uk1 = _reader.ReadUInt16(),
                Uk2 = _reader.ReadByte(),
                Uk3 = _reader.ReadByte()
            });
        }

        var tetr = _reader.ReadChars(4);

        for (int i = 0; i < numTetr; i++)
        {
            var masks = new CArray<CInt64>();
            for (int j = 0; j < 8; j++)
            {
                masks.Add(_reader.ReadInt64());
            }
            data.Tetrs.Add(new CGITetr()
            {
                Masks = masks,
                Uk1 = _reader.ReadInt16(),
                Uk2 = _reader.ReadInt16(),
                Uk3 = _reader.ReadInt16(),
                Uk4 = _reader.ReadInt16(),
                Uk5 = _reader.ReadInt32(),
                Uk6 = _reader.ReadInt32(),
                Uk7 = _reader.ReadInt32(),
                Uk8 = _reader.ReadInt32()
            });
        }

        var volt = _reader.ReadChars(4);

        for (int i = 0; i < 32768; i++)
        {
            data.Volts.Add(new CGIVolt()
            {
                Uk1 = _reader.ReadUInt32(),
                Uk2 = _reader.ReadUInt32()
            });
        }

        var endf = _reader.ReadChars(4);

        buffer.Data = data;

        return EFileReadErrorCodes.NoError;
    }
}