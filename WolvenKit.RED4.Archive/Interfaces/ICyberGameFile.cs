using System.IO;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.RED4.Archive;

public interface ICyberGameFile : IGameFile
{
    public uint SegmentsStart { get; set; }
    public uint SegmentsEnd { get; set; }

    public string FileName { get; }

    public void Extract(Stream output, bool decompressBuffers);
}
