using WolvenKit.RED4.Archive.IO;

namespace WolvenKit.RED4.Archive
{
    public class CVariable : IEditableVariable
    {
        public bool IsSerialized { get; set; }
        public int VarChunkIndex { get; set; }

        public void Read(CR2WReader file, uint size)
        {

        }

        private ushort _redFlags;
        public void SetREDFlags(ushort flag) => _redFlags = flag;
    }
}
