using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.TweakDB.Helper;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.TweakDB;

public class TweakDBWriter : Red4Writer
{
    public TweakDBWriter(Stream output) : base(output)
    {
    }

    public TweakDBWriter(Stream output, Encoding encoding) : base(output, encoding)
    {
    }

    public TweakDBWriter(Stream output, Encoding encoding, bool leaveOpen) : base(output, encoding, leaveOpen)
    {
    }

    public void WriteFile(TweakDB tweakDb)
    {
        var header = new FileHeader
        {
            Magic = TweakDB.Magic,
            BlobVersion = TweakDB.BlobVersion,
            ParserVersion = TweakDB.ParserVersion
        };

        // Skip the header for now, it will be written last when we know all offsets.
        BaseWriter.Seek(Marshal.SizeOf(typeof(FileHeader)), SeekOrigin.Begin);

        // Save flats.
        header.Offsets.Flats = (uint)BaseStream.Position;
        WriteFlats(tweakDb.Flats);

        // Save records.
        header.Offsets.Records = (uint)BaseStream.Position;
        WriteRecords(tweakDb.Records);

        // Save queries.
        header.Offsets.Queries = (uint)BaseStream.Position;
        WriteQueries(tweakDb.Queries);

        // Save group tags.
        header.Offsets.GroupTags = (uint)BaseStream.Position;
        WriteGroupTags(tweakDb.GroupTags);

        // Now the header should be written.
        BaseStream.Position = 0;
        BaseWriter.Write(header);
    }

    private void WriteFlats(FlatsPool flats)
    {
        var flatTypeValues = new Dictionary<Type, FlatValueCache>();
        var flatIndexDict = new Dictionary<Type, Dictionary<TweakDBID, int>> ();

        foreach (var (id, value) in flats)
        {
            var type = value.GetType();

            if (!flatTypeValues.ContainsKey(type))
            {
                flatTypeValues.Add(type, new FlatValueCache());
                flatIndexDict.Add(type, new Dictionary<TweakDBID, int>());
            }

            flatIndexDict[type].Add(id, flatTypeValues[type].GetIndex(value));
        }

        BaseWriter.Write(flatTypeValues.Count);
        foreach (var (type, values) in flatTypeValues)
        {
            var redType = RedReflection.GetRedTypeFromCSType(type);
            var hash = FNV1A64HashAlgorithm.HashString(redType);

            BaseWriter.Write(hash);
            BaseWriter.Write(values.Count);
        }

        foreach (var (type, values) in flatTypeValues)
        {
            BaseWriter.Write(values.Count);
            foreach (var value in values)
            {
                Write(value);
            }

            var refList = flatIndexDict[type];
            BaseWriter.Write(refList.Count);
            foreach (var (id, index) in refList)
            {
                Write(id);
                BaseWriter.Write(index);
            }
        }
    }

    private void WriteRecords(RecordsPool tweakDbRecords)
    {
        var gameDataRegex = new Regex("gamedata(.*)_Record");

        BaseWriter.Write(tweakDbRecords.Count);
        foreach (var (id, type) in tweakDbRecords)
        {
            var redType = RedReflection.GetRedTypeFromCSType(type);
            var match = gameDataRegex.Match(redType);
            if (!match.Success)
            {
                throw new NotSupportedException();
            }

            var hash = Core.Murmur3.Murmur32.Hash(match.Groups[1].Value, TweakDB.RecordsSeed);

            Write(id);
            BaseWriter.Write(hash);
        }
    }

    private void WriteQueries(QueriesPool tweakDbQueries)
    {
        BaseWriter.Write(tweakDbQueries.Count);
        foreach (var (id, values) in tweakDbQueries)
        {
            Write(id);
            BaseWriter.Write(values.Count);
            foreach (var tweakDbid in values)
            {
                Write(tweakDbid);
            }
        }
    }

    private void WriteGroupTags(GroupTagsPool tweakDbGroupTags)
    {
        BaseWriter.Write(tweakDbGroupTags.Count);
        foreach (var (id, value) in tweakDbGroupTags)
        {
            Write(id);
            BaseWriter.Write(value);
        }
    }

    public override void WriteClass(RedBaseClass instance)
    {
        BaseWriter.Write((byte)0x00); // Garbage, it is read but not used when "Unserialized" is called.

        var typeInfo = RedReflection.GetTypeInfo(instance);
        foreach (var propertyInfo in typeInfo.GetWritableProperties())
        {
            BaseWriter.WriteLengthPrefixedString(propertyInfo.RedName);

            var redTypeName = RedReflection.GetRedTypeFromCSType(propertyInfo.Type, propertyInfo.Flags.Clone());
            BaseWriter.WriteLengthPrefixedString(redTypeName);

            var currOffset = BaseStream.Position;

            // Skip next offset for now.
            BaseWriter.Seek(sizeof(uint), SeekOrigin.Current);

            // Serialize the type.
            Write(instance.GetProperty(propertyInfo.RedName));
            var endOffset = BaseStream.Position;

            // Now let's calculate the next variable offset.
            var nextOffset = (uint)(endOffset - currOffset);

            // Move cursor back to size offset and write it.
            BaseWriter.Seek((int)currOffset, SeekOrigin.Begin);
            BaseWriter.Write(nextOffset);

            // Move cursor to the correct offset to continue writing.
            BaseWriter.Seek((int)endOffset, SeekOrigin.Begin);
        }

        // This seems to always be "None", need more reversing. Seems to mark the end of properties.
        BaseWriter.WriteLengthPrefixedString("None");
    }

    public override void Write(CName val) => BaseWriter.WriteLengthPrefixedString(val);
    public override void Write(IRedResourceAsyncReference instance) => BaseWriter.Write((ulong)instance.DepotPath);
    public override void Write<T>(CArray<T> instance)
    {
        BaseWriter.Write(instance.Count);
        foreach (var value in instance)
        {
            Write(value);
        }
    }
}
