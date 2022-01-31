using System.Collections.Generic;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer
{
    public class CR2WList : Red4File, IParseableBuffer
    {
        public List<CR2WFile> Files { get; set; }

        public CR2WList()
        {
            Files = new List<CR2WFile>();
        }
    }
}
