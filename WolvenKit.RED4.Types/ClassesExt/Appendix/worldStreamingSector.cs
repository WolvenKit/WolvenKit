using System.IO;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class worldStreamingSector : IRedAppendix
    {
        public object Appendix { get; set; }

        public void Read(Red4Reader reader, uint size)
        {
            var result = new worldStreamingSector_Appendix();

            result.Unk1 = reader.BaseReader.ReadInt32(); // 0x3C
            var innerSize = reader.BaseReader.ReadInt32();
            result.Buffer = reader.BaseReader.ReadBytes(innerSize - 4);

            Appendix = result;
        }

        public void Write(Red4Writer writer)
        {
            var appendix = (worldStreamingSector_Appendix)Appendix;

            writer.BaseWriter.Write(appendix.Unk1);
            writer.BaseWriter.Write(appendix.Buffer.Length + 4);
            writer.BaseWriter.Write(appendix.Buffer);
        }
    }

    public class worldStreamingSector_Appendix
    {
        public int Unk1 { get; set; }
        public byte[] Buffer { get; set; }
    }
}
