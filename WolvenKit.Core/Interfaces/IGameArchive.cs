using System.Collections.Generic;
using WolvenKit.Common;

namespace WolvenKit.Core.Interfaces;

public interface IGameArchive
{
    public string ArchiveAbsolutePath { get; set; }
    public string ArchiveRelativePath { get; set; }

    public Dictionary<ulong, IGameFile> Files { get; }
    public string Name { get; }
    EArchiveType TypeName { get; }
}
