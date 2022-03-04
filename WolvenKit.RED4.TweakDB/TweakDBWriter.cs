using System.IO;
using System.Text;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;
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

    public override void WriteClass(RedBaseClass instance)
    {
        BaseWriter.Write((byte)0x00); // Garbage, it is read but not used when "Unserialized" is called.

        var typeInfo = RedReflection.GetTypeInfo(instance.GetType());
        foreach (var propertyInfo in typeInfo.GetWritableProperties())
        {
            BaseWriter.WriteLengthPrefixedString(propertyInfo.RedName);

            var redTypeName = RedReflection.GetRedTypeFromCSType(propertyInfo.Type, propertyInfo.Flags.Clone());
            BaseWriter.WriteLengthPrefixedString(redTypeName);

            var currOffset = BaseStream.Position;

            // Skip next offset for now.
            BaseWriter.Seek(sizeof(uint), SeekOrigin.Current);

            // Serialize the type.
            Write((IRedType)propertyInfo.GetValue(instance));
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
}
