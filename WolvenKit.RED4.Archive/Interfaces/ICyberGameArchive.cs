using System.IO;
using System.IO.MemoryMappedFiles;
using System.Threading.Tasks;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.RED4.Archive;

public interface ICyberGameArchive : IGameArchive
{
    public bool CanUncook(ulong hash);

    public void CopyFileToStream(Stream stream, ulong hash, bool decompressBuffers, MemoryMappedFile mmf = null);
    public Task CopyFileToStreamAsync(Stream stream, ulong hash, bool decompressBuffers, MemoryMappedFile mmf = null);
}
