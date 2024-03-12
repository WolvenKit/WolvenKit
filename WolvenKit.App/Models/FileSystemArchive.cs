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
        var modDirectory = Project.ModDirectory;
        foreach (var filePath in Directory.EnumerateFiles(modDirectory, "*", SearchOption.AllDirectories))
        {
            var tHash = FNV1A64HashAlgorithm.HashString(ResourcePath.SanitizePath(filePath[(modDirectory.Length + 1)..]));
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

        var modDirectory = Project.ModDirectory;
        foreach (var filePath in Directory.EnumerateFiles(modDirectory, "*", SearchOption.AllDirectories))
        {
            var hash = FNV1A64HashAlgorithm.HashString(ResourcePath.SanitizePath(filePath[(modDirectory.Length + 1)..]));

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
        if (string.IsNullOrEmpty(project.ModDirectory) || !Directory.Exists(project.ModDirectory))
        {
            throw new ArgumentException(nameof(project.ModDirectory));
        }

        _hashService = hashService;

        Project = project;

        ArchiveAbsolutePath = $"<virtual FileSystemArchive>";
        ArchiveRelativePath = $"<virtual FileSystemArchive>";
        Name = $"<{Project.Name}>";
    }
}
