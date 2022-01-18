using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Archive.CR2W;

namespace WolvenKit.Common.Conversion;

public class CR2WFileDto
{
    public CR2WFileDto(CR2WFile cr2w)
    {
        //RootChunk = new RedClassDto(cr2w.RootChunk);
        EmbeddedFiles = cr2w.EmbeddedFiles.Select((s, i) => new { s, i }).ToDictionary(x => x.i, x => new RedEmbeddedDto(x.s));
    }

    public RedClassDto RootChunk { get; }
    public Dictionary<int, RedEmbeddedDto> EmbeddedFiles { get; }
}
