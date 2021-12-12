using System.IO;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    [REDClass(ChildLevel = 1)]
    public partial class CPhysicsDecorationResource : IRedAppendix
    {
        public void Read(Red4Reader reader, uint size)
        {
            Unk1 = reader.BaseReader.ReadInt32();
            var _ = reader.BaseReader.ReadInt16();
            var buffer_index = reader.BaseReader.ReadUInt16();
            Unk2 = reader.ReadDataBuffer((uint)(buffer_index - 1));
        }

        public void Write(Red4Writer writer)
        {
            writer.BaseWriter.Write(Unk1);
            writer.Write(Unk2);
        }

        [REDAttribute("unk1")]
        [REDProperty(IsIgnored = true)]
        public CInt32 Unk1
        {
            get => GetPropertyValue<CInt32>();
            set => SetPropertyValue<CInt32>(value);
        }

        [REDAttribute("unk2")]
        [REDProperty(IsIgnored = true)]
        public DataBuffer Unk2
        {
            get => GetPropertyValue<DataBuffer>();
            set => SetPropertyValue<DataBuffer>(value);
        }
    }
}
