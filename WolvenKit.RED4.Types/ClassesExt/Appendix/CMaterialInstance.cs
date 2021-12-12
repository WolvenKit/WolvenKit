using System.Collections.Generic;
using System.IO;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class CMaterialInstance : IRedAppendix
    {
        [RED("values")]
        [REDProperty(IsIgnored = true)]
        public List<KeyValuePair<CName, IRedType>> Values { get; set; } = new();

        public void Read(Red4Reader reader, uint size)
        {
            Values.Clear();

            var entryCount = reader.BaseReader.ReadInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var valueSize = reader.BaseReader.ReadInt32() - 8;
                var name = reader.ReadCName();
                var typename = reader.ReadCName();

                var (type, flags) = RedReflection.GetCSTypeFromRedType(typename);
                var value = reader.Read(type, (uint)valueSize, flags);

                Values.Add(new KeyValuePair<CName, IRedType>(name, value));
            }
        }

        public void Write(Red4Writer writer)
        {
            writer.BaseWriter.Write(Values.Count);
            foreach (var entry in Values)
            {
                var startPos = writer.BaseStream.Position;

                var redTypeName = (CName)RedReflection.GetRedTypeFromCSType(entry.Value.GetType(), Flags.Empty);

                writer.BaseWriter.Write(0);
                writer.Write(entry.Key);
                writer.Write(redTypeName);
                writer.Write(entry.Value);

                var endPos = writer.BaseStream.Position;
                var innerSize = endPos - startPos;
                writer.BaseStream.Position = startPos;
                writer.BaseWriter.Write((uint)innerSize);
                writer.BaseStream.Position = endPos;
            }
        }
    }
}
