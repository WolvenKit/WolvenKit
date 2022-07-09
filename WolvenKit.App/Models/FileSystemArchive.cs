using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive;

namespace WolvenKit.App.Models;

public class FileSystemArchive : ICyberGameArchive
{
    private readonly Dictionary<ulong, string> _filePaths = new();

    public string ArchiveAbsolutePath { get; set; }
    public Dictionary<ulong, IGameFile> Files { get; set; } = new();
    public string Name { get; set; }
    public EArchiveType TypeName { get; set; }
    public bool CanUncook(ulong hash) => throw new System.NotImplementedException();

    public void CopyFileToStream(Stream stream, ulong hash, bool decompressBuffers)
    {
        if (!_filePaths.TryGetValue(hash, out var filePath))
        {
            return;
        }

        using var fs = File.OpenRead(filePath);
        fs.CopyTo(stream);
    }

    public async Task CopyFileToStreamAsync(Stream stream, ulong hash, bool decompressBuffers)
    {
        if (!_filePaths.TryGetValue(hash, out var filePath))
        {
            return;
        }

        await using var fs = File.OpenRead(filePath);
        await fs.CopyToAsync(stream);
    }

    public FileSystemArchive(string modDirectory)
    {
        if (string.IsNullOrEmpty(modDirectory) || !Directory.Exists(modDirectory))
        {
            throw new ArgumentException(nameof(modDirectory));
        }

        foreach (var filePath in Directory.EnumerateFiles(modDirectory, "*", SearchOption.AllDirectories))
        {
            var hash = FNV1A64HashAlgorithm.HashString(filePath[(modDirectory.Length + 1)..]);

            _filePaths.Add(hash, filePath);
            Files.Add(hash, new FileEntry
            {
                Archive = this,
                NameHash64 = hash
            });
        }
    }
}
