using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.CR2W
{
    public class CR2WPackage : Red4File
    {
        public ushort Version;

        public IList<CRUID> Cruids;

        public CR2WPackage() : base()
        {
            Cruids = new List<CRUID>();
        }

        public void AddChunk(IRedClass chunk)
        {
            _chunks.Add(chunk);
        }

    }
}
