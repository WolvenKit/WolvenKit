using System.Collections.Generic;
using System.IO;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class CMaterialInstance : IRedAppendix
    {
        public object Appendix { get; set; }

        public void Read(Red4Reader reader, uint size)
        {
            var result = new CMaterialInstance_Appendix();

            var entryCount = reader.BaseReader.ReadInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var valueSize = reader.BaseReader.ReadInt32() - 8;
                var name = reader.ReadCName();
                var typename = reader.ReadCName();

                var (type, flags) = RedReflection.GetCSTypeFromRedType(typename);
                var value = reader.Read(type, (uint)valueSize, flags);

                result.Values.Add(new KeyValuePair<CName, IRedType>(name, value));
            }

            Appendix = result;
        }

        public void Write(Red4Writer writer)
        {
            var value = (CMaterialInstance_Appendix)Appendix;

            writer.BaseWriter.Write(value.Values.Count);
            foreach (var entry in value.Values)
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

    public class CMaterialInstance_Appendix
    {
        public List<KeyValuePair<CName, IRedType>> Values { get; set; } = new();
    }
}
