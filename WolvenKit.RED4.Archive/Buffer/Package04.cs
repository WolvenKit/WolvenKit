using System.Collections.Generic;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer
{
    public class Package04 : Red4File, IParseableBuffer
    {
        public ushort Version = 4;
        public ushort Sections = 7;

        public short CruidIndex;
        public IList<CRUID> RootCruids;

        
        public IList<RedBaseClass> Chunks { get; set; }
        public RedBaseClass RootChunk => Chunks[0];

        public Package04()
        {
            RootCruids = new List<CRUID>();
        }
    }
}
