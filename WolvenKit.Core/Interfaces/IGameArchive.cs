using System.Collections.Generic;
using ProtoBuf;
using WolvenKit.Common;

namespace WolvenKit.Core.Interfaces;

[ProtoContract]
public interface IGameArchive
{
    #region Properties

    public string ArchiveAbsolutePath { get; set; }
    public string ArchiveRelativePath { get; set; }

    public Dictionary<ulong, IGameFile> Files { get; }
    public string Name { get; }
    EArchiveType TypeName { get; }


    #endregion Properties
}
