using System.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class C2dArray : IRedAppendix
    {
        [RED("compiledHeaders")]
        [REDProperty(IsIgnored = true)]
        public CArray<CString> CompiledHeaders
        {
            get => GetPropertyValue<CArray<CString>>();
            set => SetPropertyValue<CArray<CString>>(value);
        }

        [RED("compiledData")]
        [REDProperty(IsIgnored = true)]
        public CArray<CArray<CString>> CompiledData
        {
            get => GetPropertyValue<CArray<CArray<CString>>>();
            set => SetPropertyValue<CArray<CArray<CString>>>(value);
        }

        public void Read(Red4Reader reader, uint size)
        {
            var cnt1 = reader.BaseReader.ReadVLQInt32();
            for (int i = 0; i < cnt1; i++)
            {
                CompiledHeaders.Add(reader.ReadCString());
            }

            cnt1 = reader.BaseReader.ReadVLQInt32();
            for (int i = 0; i < cnt1; i++)
            {
                var row = new CArray<CString>();

                var cnt2 = reader.BaseReader.ReadVLQInt32();
                for (int j = 0; j < cnt2; j++)
                {
                    row.Add(reader.ReadCString());
                }

                CompiledData.Add(row);
            }
        }

        public void Write(Red4Writer writer)
        {
            writer.WriteVLQ(CompiledHeaders.Count);
            foreach (var entry in CompiledHeaders)
            {
                writer.Write(entry);
            }

            writer.WriteVLQ(CompiledData.Count);
            foreach (var row in CompiledData)
            {
                writer.WriteVLQ(row.Count);
                foreach (var entry in row)
                {
                    writer.Write(entry);
                }
            }
        }

        partial void PostConstruct()
        {
            CompiledHeaders = new CArray<CString>();
            CompiledData = new CArray<CArray<CString>>();
        }
    }
}
