using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Conversion;

public class RedFileDto
{
    public RedFileDto()
    {

    }

    public RedFileDto(CR2WFile cr2w)
    {
        Data = cr2w;
        Header.ArchiveFileName = cr2w.MetaData.FileName;
    }

    public JsonHeader Header { get; set; } = new();
    public CR2WFile Data { get; set; }
}
