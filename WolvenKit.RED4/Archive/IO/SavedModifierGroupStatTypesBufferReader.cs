using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Save;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class SavedModifierGroupStatTypesBufferReader : Red4Reader, IBufferReader
{
    public SavedModifierGroupStatTypesBufferReader(Stream input) : base(input)
    {
    }

    public EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        var data = new SavedModifierGroupStatTypesBuffer();

        try
        {
            while (_reader.BaseStream.Position < _reader.BaseStream.Length)
            {
                var entry = new SavedModifierGroupStatTypesBuffer_Entry { ModifierGroupHash = _reader.ReadUInt32() };

                var cnt = _reader.ReadUInt32();
                for (var i = 0; i < cnt; i++)
                {
                    entry.StatTypes.Add(SaveHashHelper.GetStatType(_reader.ReadUInt64()));
                }

                data.Entries.Add(entry);
            }
        }
        catch (Exception)
        {
            data.IsParsed = false;
        }

        buffer.Data = data;

        return EFileReadErrorCodes.NoError;
    }
}