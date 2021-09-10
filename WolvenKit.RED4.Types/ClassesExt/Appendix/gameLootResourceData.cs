using System.IO;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class gameLootResourceData : IRedAppendix
    {
        public object Appendix { get; set; }

        public void Read(Red4Reader reader, uint size)
        {
            var result = new gameLootResourceData_Appendix();


            var startPos = reader.BaseReader.BaseStream.Position;

            result.Unk1 = new ulong[reader.ReadVLQ()];
            for (int i = 0; i < result.Unk1.Length; i++)
            {
                result.Unk1[i] = reader.BaseReader.ReadUInt64();
            }

            var bytesRead = reader.BaseReader.BaseStream.Position - startPos;
            result.Buffer = reader.BaseReader.ReadBytes((int)(size - bytesRead));

            Appendix = result;
        }

        public void Write(Red4Writer writer) => throw new System.NotImplementedException();
    }

    public class gameLootResourceData_Appendix
    {
        public ulong[] Unk1 { get; set; }
        public byte[] Buffer { get; set; }
    }
}
