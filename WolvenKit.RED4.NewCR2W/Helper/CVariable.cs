using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.NewCR2W
{
    public class CVariable : IEditableVariable
    {
        public bool IsSerialized { get; set; }
        public int VarChunkIndex { get; set; }

        public void Read(Red4ReaderExt file, uint size)
        {

        }

        private ushort _redFlags;
        public void SetREDFlags(ushort flag) => _redFlags = flag;
    }
}
