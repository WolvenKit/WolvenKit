using WolvenKit.Core.Interfaces;

namespace WolvenKit.RED4.Archive;

public interface Cp77GameFile : IGameFile
{
    public uint SegmentsStart { get; set; }
    public uint SegmentsEnd { get; set; }

    public string FileName { get; }
}
