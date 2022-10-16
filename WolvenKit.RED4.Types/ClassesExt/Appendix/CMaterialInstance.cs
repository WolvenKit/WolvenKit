using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class CMaterialInstance : IRedAppendix
    {
        [RED("values")]
        [REDProperty(IsIgnored = true)]
        public CArray<CKeyValuePair> Values
        {
            get => GetPropertyValue<CArray<CKeyValuePair>>();
            set => SetPropertyValue<CArray<CKeyValuePair>>(value);
        }

        public void Read(Red4Reader reader, uint size)
        {
            var entryCount = reader.BaseReader.ReadInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var valueSize = reader.BaseReader.ReadInt32() - 8;
                var name = reader.ReadCName();
                var typename = reader.ReadCName();
                
                var redTypeInfos = RedReflection.GetRedTypeInfos(typename);
                reader.CheckRedTypeInfos(ref redTypeInfos);

                var value = reader.Read(redTypeInfos, (uint)valueSize);

                Values.Add(new CKeyValuePair(name, value));
            }
        }

        public void Write(Red4Writer writer)
        {
            writer.BaseWriter.Write(Values.Count);
            foreach (var kvp in Values)
            {
                var startPos = writer.BaseStream.Position;

                var redTypeName = (CName)RedReflection.GetRedTypeFromCSType(kvp.Value.GetType(), Flags.Empty);

                writer.BaseWriter.Write(0);
                writer.Write(kvp.Key);
                writer.Write(redTypeName);
                writer.Write(kvp.Value);

                var endPos = writer.BaseStream.Position;
                var innerSize = endPos - startPos;
                writer.BaseStream.Position = startPos;
                writer.BaseWriter.Write((uint)innerSize);
                writer.BaseStream.Position = endPos;
            }
        }

        partial void PostConstruct()
        {
            Values = new CArray<CKeyValuePair>();
        }
    }
}
