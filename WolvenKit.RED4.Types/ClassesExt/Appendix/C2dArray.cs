using System.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class C2dArray : IRedAppendix
    {
        public object Appendix { get; set; }

        public void Read(Red4Reader reader, uint size)
        {
            var result = new C2dArray_Appendix();

            result.Headers = new string[reader.BaseReader.ReadVLQInt32()];
            for (int i = 0; i < result.Headers.Length; i++)
            {
                result.Headers[i] = reader.ReadCString();
            }

            result.Rows = new string[reader.BaseReader.ReadVLQInt32()][];
            for (int i = 0; i < result.Rows.Length; i++)
            {
                var row = new string[reader.BaseReader.ReadVLQInt32()];
                for (int j = 0; j < row.Length; j++)
                {
                    row[j] = reader.ReadCString();
                }

                result.Rows[i] = row;
            }

            Appendix = result;
        }

        public void Write(Red4Writer writer)
        {
            var value = (C2dArray_Appendix)Appendix;

            writer.WriteVLQ(value.Headers.Length);
            foreach (var entry in value.Headers)
            {
                writer.Write((CString)entry);
            }

            writer.WriteVLQ(value.Rows.Length);
            foreach (var row in value.Rows)
            {
                writer.WriteVLQ(row.Length);
                foreach (var entry in row)
                {
                    writer.Write((CString)entry);
                }
            }
        }
    }

    public class C2dArray_Appendix
    {
        public string[] Headers { get; set; }
        public string[][] Rows { get; set; }
    }
}
