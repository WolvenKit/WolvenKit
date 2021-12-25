using System.Collections.Generic;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer
{
    public class Package04 : Red4File, IParseableBuffer
    {
        public ushort Version = 4;
        public ushort Sections = 7;

        public IList<CRUID> Cruids;

        
        public IList<IRedClass> Chunks { get; set; }
        public IRedClass RootChunk => Chunks[0];

        public Package04()
        {
            Cruids = new List<CRUID>();
        }
    }
}
