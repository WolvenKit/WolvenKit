using System.IO;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class physicsMaterialLibraryResource : IRedAppendix
    {
        public object Appendix { get; set; }

        public void Read(Red4Reader reader, uint size)
        {
            var result = new physicsMaterialLibraryResource_Appendix();

            var cnt = reader.ReadVLQ();

            result.Unk1 = new ushort[cnt];
            for (int i = 0; i < result.Unk1.Length; i++)
            {
                result.Unk1[i] = reader.BaseReader.ReadUInt16();
            }

            result.Unk2 = new uint[cnt];
            for (int i = 0; i < result.Unk2.Length; i++)
            {
                result.Unk2[i] = reader.BaseReader.ReadUInt32();
            }

            Appendix = result;
        }

        public void Write(Red4Writer writer) => throw new System.NotImplementedException();
    }

    public class physicsMaterialLibraryResource_Appendix
    {
        public ushort[] Unk1 { get; set; }
        public uint[] Unk2 { get; set; }
    }
}
