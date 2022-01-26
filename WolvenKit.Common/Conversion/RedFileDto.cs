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

    public RedFileDto(Red4File red4File)
    {
        Data = red4File;

        if (Data is CR2WFile cr2w)
        {
            Header.ArchiveFileName = cr2w.MetaData.FileName;
        }
    }

    public JsonHeader Header { get; set; } = new();
    public Red4File Data { get; set; }
}
