using System.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class C2dArray : IRedAppendix
    {
        [RED("customHeaders")]
        [REDProperty(IsIgnored = true)]
        public CArray<CString> CustomHeaders
        {
            get => GetPropertyValue<CArray<CString>>();
            set => SetPropertyValue<CArray<CString>>(value);
        }

        [RED("customRows")]
        [REDProperty(IsIgnored = true)]
        public CArray<CArray<CString>> CustomRows
        {
            get => GetPropertyValue<CArray<CArray<CString>>>();
            set => SetPropertyValue<CArray<CArray<CString>>>(value);
        }

        public void Read(Red4Reader reader, uint size)
        {
            CustomHeaders = new CArray<CString>();
            CustomRows = new CArray<CArray<CString>>();
            
            var cnt1 = reader.BaseReader.ReadVLQInt32();
            for (int i = 0; i < cnt1; i++)
            {
                CustomHeaders.Add(reader.ReadCString());
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

                CustomRows.Add(row);
            }
        }

        public void Write(Red4Writer writer)
        {
            writer.WriteVLQ(CustomHeaders.Count);
            foreach (var entry in CustomHeaders)
            {
                writer.Write(entry);
            }

            writer.WriteVLQ(CustomRows.Count);
            foreach (var row in CustomRows)
            {
                writer.WriteVLQ(row.Count);
                foreach (var entry in row)
                {
                    writer.Write(entry);
                }
            }
        }
    }
}
