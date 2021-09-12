using System.IO;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    [REDClass(ChildLevel = 1)]
    public partial class CMaterialTemplate : IRedAppendix
    {
        public object Appendix { get; set; }

        public void Read(Red4Reader reader, uint size)
        {
            Appendix = new BaseAppendix { Buffer = reader.BaseReader.ReadBytes((int)size) };
        }

        public void Write(Red4Writer writer) => writer.BaseWriter.Write(((BaseAppendix)Appendix).Buffer);
    }
}
