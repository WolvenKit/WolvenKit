using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class CMaterialInstance : IRedAppendix
    {
        [RED("values")]
        [REDProperty(IsIgnored = true)]
        public CMaterialInstance_CustomProps Values
        {
            get => GetPropertyValue<CMaterialInstance_CustomProps>();
            set => SetPropertyValue<CMaterialInstance_CustomProps>(value);
        }

        public void Read(Red4Reader reader, uint size)
        {
            Values = new CMaterialInstance_CustomProps();

            var entryCount = reader.BaseReader.ReadInt32();
            for (int i = 0; i < entryCount; i++)
            {
                var valueSize = reader.BaseReader.ReadInt32() - 8;
                var name = reader.ReadCName();
                var typename = reader.ReadCName();

                var (type, flags) = RedReflection.GetCSTypeFromRedType(typename);
                var value = reader.Read(type, (uint)valueSize, flags);

                Values.InternalSetPropertyValue(name, value, false);
            }
        }

        public void Write(Red4Writer writer)
        {
            var dynProps = GetDynamicPropertyNames();

            writer.BaseWriter.Write(dynProps.Count);
            foreach (var propertyName in dynProps)
            {
                var value = GetObjectByRedName(propertyName);

                var startPos = writer.BaseStream.Position;

                var redTypeName = (CName)RedReflection.GetRedTypeFromCSType(value.GetType(), Flags.Empty);

                writer.BaseWriter.Write(0);
                writer.Write((CName)propertyName);
                writer.Write(redTypeName);
                writer.Write(value);

                var endPos = writer.BaseStream.Position;
                var innerSize = endPos - startPos;
                writer.BaseStream.Position = startPos;
                writer.BaseWriter.Write((uint)innerSize);
                writer.BaseStream.Position = endPos;
            }
        }
    }

    public class CMaterialInstance_CustomProps : RedBaseClass
    {

    }
}
