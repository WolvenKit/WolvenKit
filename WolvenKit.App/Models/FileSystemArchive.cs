using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Models;

public class FileSystemArchive : ICyberGameArchive
{
    private readonly Dictionary<ulong, string> _filePaths = new();

    public string ArchiveAbsolutePath { get; set; }
    public string ArchiveRelativePath { get; set; }
    public Dictionary<ulong, IGameFile> Files { get; set; } = new();
    public string Name { get; }
    public EArchiveSource Source => EArchiveSource.Project;
    public EArchiveType TypeName { get; set; }
    public Cp77Project Project { get; }

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

    public FileSystemArchive(Cp77Project project, IHashService hashService)
    {
        Project = project;

        ArchiveAbsolutePath = $"<virtual FileSystemArchive>";
        ArchiveRelativePath = $"<virtual FileSystemArchive>";
        Name = $"<{Project.Name}>";

        var modDirectory = Project.ModDirectory;

        if (string.IsNullOrEmpty(modDirectory) || !Directory.Exists(modDirectory))
        {
            throw new ArgumentException(nameof(modDirectory));
        }

        foreach (var filePath in Directory.EnumerateFiles(modDirectory, "*", SearchOption.AllDirectories))
        {
            var hash = FNV1A64HashAlgorithm.HashString(ResourcePath.SanitizePath(filePath[(modDirectory.Length + 1)..]));

            _filePaths.Add(hash, filePath);
            Files.Add(hash, new FileEntry(hashService)
            {
                Archive = this,
                NameHash64 = hash
            });
        }
    }
}
