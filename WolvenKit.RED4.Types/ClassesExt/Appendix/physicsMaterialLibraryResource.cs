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

            result.Unk1 = new CName[cnt];
            for (int i = 0; i < result.Unk1.Length; i++)
            {
                result.Unk1[i] = reader.ReadCName();
            }

            result.Unk2 = new CHandle<physicsMaterialResource>[cnt];
            for (int i = 0; i < result.Unk2.Length; i++)
            {
                result.Unk2[i] = (CHandle<physicsMaterialResource>)reader.ReadCHandle<physicsMaterialResource>();
            }

            Appendix = result;
        }

        public void Write(Red4Writer writer)
        {
            var appendix = (physicsMaterialLibraryResource_Appendix)Appendix;

            writer.WriteVLQ(appendix.Unk1.Length);
            foreach (var unk in appendix.Unk1)
            {
                writer.Write(unk);
            }

            foreach (var unk in appendix.Unk2)
            {
                writer.Write(unk);
            }
        }
    }

    public class physicsMaterialLibraryResource_Appendix
    {
        public CName[] Unk1 { get; set; }
        public CHandle<physicsMaterialResource>[] Unk2 { get; set; }
    }
}
