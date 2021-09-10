using System.IO;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public partial class worldTrafficPersistentLaneConnectionsResource : IRedAppendix
    {
        public object Appendix { get; set; }

        public void Read(Red4Reader reader, uint size)
        {
            Appendix = new BaseAppendix { Buffer = reader.BaseReader.ReadBytes((int)size) };
        }

        public void Write(Red4Writer writer) => throw new System.NotImplementedException();
    }
}
