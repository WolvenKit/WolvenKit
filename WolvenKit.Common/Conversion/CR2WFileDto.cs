using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Archive.CR2W;

namespace WolvenKit.Common.Conversion;

public class CR2WFileDto
{
    public CR2WFileDto()
    {

    }

    public CR2WFileDto(CR2WFile cr2w)
    {
        Data = cr2w;
        ArchiveFileName = cr2w.MetaData.FileName;
    }

    public string WolvenKitVersion { get; set; } = "8.5.0";
    public string WKitJsonVersion { get; set; } = "0.0.1";
    public string ExportedDateTime { get; set; } = DateTime.UtcNow.ToString("o");
    public string ArchiveFileName { get; set; }

    public CR2WFile Data { get; set; }
}
