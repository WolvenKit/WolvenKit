using System.IO;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class worldTrafficPersistentLanePolygonResource : IRedAppendix
    {
        public object Appendix { get; set; }

        public void Read(Red4Reader reader, uint size)
        {
            Appendix = new worldTrafficPersistentLanePolygonResource_Appendix { Buffer = reader.BaseReader.ReadBytes((int)size) };
        }

        public void Write(Red4Writer writer) => throw new System.NotImplementedException();
    }

    public class worldTrafficPersistentLanePolygonResource_Appendix
    {
        public byte[] Buffer { get; set; }
    }
}
