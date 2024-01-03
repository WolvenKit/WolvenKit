using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
    private readonly IHashService _hashService;

    public string ArchiveAbsolutePath { get; set; }
    public string ArchiveRelativePath { get; set; }
    public Dictionary<ulong, IGameFile> Files => GetFiles();
    public string Name { get; }
    public EArchiveSource Source => EArchiveSource.Project;
    public EArchiveType TypeName { get; set; }
    public Cp77Project Project { get; }

    public bool CanUncook(ulong hash) => throw new System.NotImplementedException();

    public void CopyFileToStream(Stream stream, ulong hash, bool decompressBuffers)
    {
        if (!TryGetFile(hash, out var filePath))
        {
            return;
        }

        using var fs = File.OpenRead(filePath);
        fs.CopyTo(stream);
    }

    public async Task CopyFileToStreamAsync(Stream stream, ulong hash, bool decompressBuffers)
    {
        if (!TryGetFile(hash, out var filePath))
        {
            return;
        }

        await using var fs = File.OpenRead(filePath);
        await fs.CopyToAsync(stream);
    }

    private bool TryGetFile(ulong hash, [NotNullWhen(true)] out string? path)
    {
        foreach (var filePath in Directory.EnumerateFiles(Project.ModDirectory, "*", SearchOption.AllDirectories))
        {
            var tHash = FNV1A64HashAlgorithm.HashString(ResourcePath.SanitizePath(filePath[(Project.ModDirectory.Length + 1)..]));
            if (tHash == hash)
            {
                path = filePath;
                return true;
            }
        }

        path = null;
        return false;
    }

    private Dictionary<ulong, IGameFile> GetFiles()
    {
        var result = new Dictionary<ulong, IGameFile>();

        foreach (var filePath in Directory.EnumerateFiles(Project.ModDirectory, "*", SearchOption.AllDirectories))
        {
            var hash = FNV1A64HashAlgorithm.HashString(ResourcePath.SanitizePath(filePath[(Project.ModDirectory.Length + 1)..]));

            result.Add(hash, new FileEntry(_hashService)
            {
                Archive = this,
                NameHash64 = hash
            });
        }

        return result;
    }

    public FileSystemArchive(Cp77Project project, IHashService hashService)
    {
        _hashService = hashService;

        Project = project;

        ArchiveAbsolutePath = $"<virtual FileSystemArchive>";
        ArchiveRelativePath = $"<virtual FileSystemArchive>";
        Name = $"<{Project.Name}>";

        if (string.IsNullOrEmpty(Project.ModDirectory) || !Directory.Exists(Project.ModDirectory))
        {
            throw new ArgumentException(nameof(Project.ModDirectory));
        }
    }
}
