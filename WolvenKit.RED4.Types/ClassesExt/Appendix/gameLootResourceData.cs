using System.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class gameLootResourceData : IRedAppendix
    {
        [RED("unk1")]
        [REDProperty(IsIgnored = true)]
        public CArray<CUInt64> Unk1
        {
            get => GetPropertyValue<CArray<CUInt64>>();
            set => SetPropertyValue<CArray<CUInt64>>(value);
        }

        [RED("buffer")]
        [REDProperty(IsIgnored = true)]
        public CByteArray Buffer
        {
            get => GetPropertyValue<CByteArray>();
            set => SetPropertyValue<CByteArray>(value);
        }

        public void Read(Red4Reader reader, uint size)
        {
            Unk1 = new CArray<CUInt64>();

            var startPos = reader.BaseReader.BaseStream.Position;

            var cnt = reader.BaseReader.ReadVLQInt32();
            for (int i = 0; i < cnt; i++)
            {
                Unk1.Add(reader.ReadCUInt64());
            }

            var bytesRead = reader.BaseReader.BaseStream.Position - startPos;
            Buffer = reader.BaseReader.ReadBytes((int)(size - bytesRead));
        }

        public void Write(Red4Writer writer)
        {
            writer.WriteVLQ(Unk1.Count);
            foreach (var entry in Unk1)
            {
                writer.Write(entry);
            }
            writer.BaseWriter.Write(Buffer);
        }
    }
}
