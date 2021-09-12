using System.IO;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    [REDClass(ChildLevel = 1)]
    public partial class CPhysicsDecorationResource : IRedAppendix
    {
        public object Appendix { get; set; }

        public void Read(Red4Reader reader, uint size)
        {
            var result = new CPhysicsDecorationResource_Appendix();

            result.Unk1 = reader.BaseReader.ReadInt32();
            result.Unk2 = reader.ReadDataBuffer(0);

            Appendix = result;
        }

        public void Write(Red4Writer writer)
        {
            var appendix = (CPhysicsDecorationResource_Appendix)Appendix;

            writer.BaseWriter.Write(appendix.Unk1);
            writer.Write(appendix.Unk2);
        }
    }

    public class CPhysicsDecorationResource_Appendix
    {
        public int Unk1 { get; set; }
        public DataBuffer Unk2 { get; set; }
    }
}
