using System.Collections.Generic;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer
{
    public class Package04 : Red4File, IParseableBuffer, IRedCloneable
    {
        public ushort Version = 4;
        public ushort Sections = 7;

        public short CruidIndex;
        public IList<CRUID> RootCruids;

        public IRedType Data => RootChunk;

        public IList<RedBaseClass> Chunks { get; set; }
        public RedBaseClass RootChunk => Chunks[0];

        public Package04()
        {
            RootCruids = new List<CRUID>();
        }

        public object ShallowCopy()
        {
            return MemberwiseClone();
        }

        public object DeepCopy()
        {
            var pkg = new Package04();
            pkg.RootCruids = RootCruids;
            pkg.Chunks = new List<RedBaseClass>();
            foreach (var chunk in Chunks)
            {
                pkg.Chunks.Add((RedBaseClass)chunk.DeepCopy());
            }
            return pkg;
        }
    }
}
