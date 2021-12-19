using System.Collections.Generic;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer
{
    public class Package04 : Red4File, IParseableBuffer
    {
        public ushort Version = 4;

        public IList<CRUID> Cruids;

        public Package04()
        {
            Cruids = new List<CRUID>();
        }

        public void SetChunks(IList<IRedClass> chunks)
        {
            _chunks = chunks;
        }
    }
}
