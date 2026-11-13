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

/// <summary>
/// The project's archive folder seen as an archive. The list of its files (hash -> path) is
/// built once and kept until a file or folder in it is created, deleted or renamed: listing
/// and hashing the whole folder on every lookup and every extract made reading project files
/// slow in big projects (thousands of files: seconds for a sector preview).
/// </summary>
public class FileSystemArchive : ICyberGameArchive, IDisposable
{
    private readonly object _lock = new();
    private readonly FileSystemWatcher? _watcher;
    private Dictionary<ulong, string>? _paths;
    private Dictionary<ulong, IGameFile>? _files;
    private volatile bool _dirty = true;

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
        EnsureListed();
        lock (_lock)
        {
            if (_paths!.TryGetValue(hash, out path) && File.Exists(path))
            {
                return true;
            }
        }

        // Moved or deleted since it was listed (the change event may still be on its way).
        _dirty = true;
        EnsureListed();
        lock (_lock)
        {
            return _paths!.TryGetValue(hash, out path);
        }
    }

    private Dictionary<ulong, IGameFile> GetFiles()
    {
        EnsureListed();
        lock (_lock)
        {
            return _files!;
        }
    }

    private void EnsureListed()
    {
        if (!_dirty && _paths != null && _watcher != null)
        {
            return;
        }

        lock (_lock)
        {
            if (!_dirty && _paths != null && _watcher != null)
            {
                return;
            }

            // Cleared before listing: a change during the listing marks it dirty again.
            _dirty = false;

            var paths = new Dictionary<ulong, string>();
            var files = new Dictionary<ulong, IGameFile>();
            var modDirectory = Project.ModDirectory;
            if (Directory.Exists(modDirectory))
            {
                foreach (var filePath in Directory.EnumerateFiles(modDirectory, "*", SearchOption.AllDirectories))
                {
                    // the full relative path after "archive\", e.g. "base\characters..."
                    var hash = ResourcePath.CalculateHash(filePath[(modDirectory.Length + 1)..]);
                    if (paths.TryAdd(hash, filePath))
                    {
                        files.Add(hash, new FileEntry
                        {
                            Archive = this,
                            NameHash64 = hash
                        });
                    }
                }
            }

            _paths = paths;
            _files = files;
        }
    }

    private void Invalidate(object sender, EventArgs e) => _dirty = true;

    public FileSystemArchive(Cp77Project project)
    {
        if (string.IsNullOrEmpty(project.ModDirectory) || !Directory.Exists(project.ModDirectory))
        {
            throw new ArgumentException(nameof(project.ModDirectory));
        }

        Project = project;

        ArchiveAbsolutePath = $"<virtual FileSystemArchive>";
        ArchiveRelativePath = $"<virtual FileSystemArchive>";
        Name = $"<{Project.Name}>";

        try
        {
            // Contents of existing files do not change the list: names only.
            _watcher = new FileSystemWatcher(project.ModDirectory)
            {
                IncludeSubdirectories = true,
                NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName,
                InternalBufferSize = 64 * 1024
            };
            _watcher.Created += Invalidate;
            _watcher.Deleted += Invalidate;
            _watcher.Renamed += Invalidate;
            _watcher.Error += Invalidate; // events lost: list again
            _watcher.EnableRaisingEvents = true;
        }
        catch
        {
            // No watcher (network drive...): list the folder on every use, as before.
            _watcher?.Dispose();
            _watcher = null;
        }
    }

    public void Dispose()
    {
        _watcher?.Dispose();
        GC.SuppressFinalize(this);
    }
}
