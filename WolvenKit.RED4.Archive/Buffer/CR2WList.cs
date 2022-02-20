using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer
{
    public class CR2WList : Red4File, IParseableBuffer
    {
        public IRedType Data
        {
            get
            {
                var a = new CArray<RedBaseClass>();
                Files.ForEach(x => a.Add(x.RootChunk));
                return a;
            }
        }

        public List<CR2WFile> Files { get; set; }

        public CR2WList()
        {
            Files = new List<CR2WFile>();
        }
    }
}
