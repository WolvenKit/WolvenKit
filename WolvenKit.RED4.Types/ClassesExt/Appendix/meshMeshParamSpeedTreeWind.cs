using System.IO;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class meshMeshParamSpeedTreeWind : IRedAppendix
    {
        public object Appendix { get; set; }

        public void Read(Red4Reader reader, uint size)
        {
            // int(cnt) * 0x3DC?
            Appendix = new BaseAppendix { Buffer = reader.BaseReader.ReadBytes((int)size) };
        }

        public void Write(Red4Writer writer) => writer.BaseWriter.Write(((BaseAppendix)Appendix).Buffer);
    }
}
