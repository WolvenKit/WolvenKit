using System;
using System.IO;
using WolvenKit.App;
using WolvenKit.App.Models;
using WolvenKit.RED4.Types;
using Xunit;

namespace Wolvenkit.Test.App.Models;

/// <summary>
/// Coverage for FileSystemModel path metadata used by Project Explorer bindings
/// (FullName, GameRelativePath, Hash under archive / raw / resources).
/// </summary>
public class FileSystemModelTests : IDisposable
{
    private readonly string _tempDir;

    public FileSystemModelTests()
    {
        _tempDir = Path.Combine(Path.GetTempPath(), "FileSystemModelTests_" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_tempDir);
    }

    public void Dispose()
    {
        try
        {
            if (Directory.Exists(_tempDir))
            {
                Directory.Delete(_tempDir, recursive: true);
            }
        }
        catch
        {
            // best-effort cleanup
        }
    }

    [Fact]
    public void ArchiveTree_ComputesFullNameGameRelativePathAndHash()
    {
        var projectDir = Path.GetFullPath(_tempDir);
        var meshRelUnderArchive = Path.Combine("base", "meshes", "test.mesh");
        var meshFull = Path.Combine(projectDir, "archive", meshRelUnderArchive);
        Directory.CreateDirectory(Path.GetDirectoryName(meshFull)!);
        File.WriteAllText(meshFull, "mesh");

        var root = new FileSystemModel(null, FileSystemModel.ProjectDirName, projectDir, isDirectory: true);
        var archive = new FileSystemModel(root, "archive", "archive", isDirectory: true);
        var baseDir = new FileSystemModel(archive, "base", Path.Combine("archive", "base"), isDirectory: true);
        var meshes = new FileSystemModel(baseDir, "meshes", Path.Combine("archive", "base", "meshes"), isDirectory: true);
        var mesh = new FileSystemModel(meshes, "test.mesh", Path.Combine("archive", meshRelUnderArchive), isDirectory: false);

        Assert.Equal(Constants.ModDirectoryTop, archive.Extension);
        Assert.Equal(string.Empty, archive.GameRelativePath);

        Assert.Equal(Constants.ModDirectoryTop, baseDir.Extension);
        Assert.Equal("base", baseDir.GameRelativePath);
        Assert.Equal(Path.Combine(projectDir, "archive", "base"), baseDir.FullName);

        Assert.Equal(Path.Combine("base", "meshes"), meshes.GameRelativePath);
        Assert.Equal(Path.Combine(projectDir, "archive", "base", "meshes"), meshes.FullName);

        Assert.Equal("mesh", mesh.Extension);
        Assert.Equal(Path.Combine("base", "meshes", "test.mesh"), mesh.GameRelativePath);
        Assert.Equal(meshFull, mesh.FullName);
        Assert.Equal(ResourcePath.CalculateHash(mesh.GameRelativePath), mesh.Hash);
        Assert.Equal(mesh.Hash.ToString(), mesh.HashStr);
    }

    [Fact]
    public void RawTree_StripsRawPrefixFromGameRelativePath()
    {
        var projectDir = Path.GetFullPath(_tempDir);
        var jsonFull = Path.Combine(projectDir, "raw", "base", "foo.mesh.json");
        Directory.CreateDirectory(Path.GetDirectoryName(jsonFull)!);
        File.WriteAllText(jsonFull, "{}");

        var root = new FileSystemModel(null, FileSystemModel.ProjectDirName, projectDir, isDirectory: true);
        var raw = new FileSystemModel(root, "raw", "raw", isDirectory: true);
        var baseDir = new FileSystemModel(raw, "base", Path.Combine("raw", "base"), isDirectory: true);
        var json = new FileSystemModel(baseDir, "foo.mesh.json", Path.Combine("raw", "base", "foo.mesh.json"),
            isDirectory: false);

        Assert.Equal(Constants.RawDirectoryTop, raw.Extension);
        Assert.Equal(string.Empty, raw.GameRelativePath);
        Assert.Equal("base", baseDir.GameRelativePath);
        Assert.Equal(Path.Combine("base", "foo.mesh.json"), json.GameRelativePath);
        Assert.Equal(jsonFull, json.FullName);
        // Hash is only non-zero under the archive (ModDirectoryTop) branch.
        Assert.Equal(0ul, json.Hash);
    }

    [Fact]
    public void ResourcesTree_StripsResourcesPrefixFromGameRelativePath()
    {
        var projectDir = Path.GetFullPath(_tempDir);
        var resFull = Path.Combine(projectDir, "resources", "replacements", "icon.inkatlas");
        Directory.CreateDirectory(Path.GetDirectoryName(resFull)!);
        File.WriteAllText(resFull, "x");

        var root = new FileSystemModel(null, FileSystemModel.ProjectDirName, projectDir, isDirectory: true);
        var resources = new FileSystemModel(root, "resources", "resources", isDirectory: true);
        var replacements = new FileSystemModel(resources, "replacements",
            Path.Combine("resources", "replacements"), isDirectory: true);
        var file = new FileSystemModel(replacements, "icon.inkatlas",
            Path.Combine("resources", "replacements", "icon.inkatlas"), isDirectory: false);

        Assert.Equal(Constants.ResourceDirectoryTop, resources.Extension);
        Assert.Equal(string.Empty, resources.GameRelativePath);
        Assert.Equal("replacements", replacements.GameRelativePath);
        Assert.Equal(Path.Combine("replacements", "icon.inkatlas"), file.GameRelativePath);
        Assert.Equal(resFull, file.FullName);
        Assert.Equal(0ul, file.Hash);
    }

    [Fact]
    public void Rename_UpdatesFullNameAndGameRelativePath_ForArchiveFile()
    {
        var projectDir = Path.GetFullPath(_tempDir);
        var originalFull = Path.Combine(projectDir, "archive", "base", "old.mesh");
        var renamedFull = Path.Combine(projectDir, "archive", "base", "new.mesh");
        Directory.CreateDirectory(Path.GetDirectoryName(originalFull)!);
        File.WriteAllText(originalFull, "mesh");

        var root = new FileSystemModel(null, FileSystemModel.ProjectDirName, projectDir, isDirectory: true);
        var archive = new FileSystemModel(root, "archive", "archive", isDirectory: true);
        var baseDir = new FileSystemModel(archive, "base", Path.Combine("archive", "base"), isDirectory: true);
        var mesh = new FileSystemModel(baseDir, "old.mesh", Path.Combine("archive", "base", "old.mesh"),
            isDirectory: false);

        // Disk rename first so UpdateFileInfo during Rename can read the new path.
        File.Move(originalFull, renamedFull);
        mesh.Rename("new.mesh");

        Assert.Equal("new.mesh", mesh.Name);
        Assert.Equal(Path.Combine("archive", "base", "new.mesh"), mesh.RawRelativePath);
        Assert.Equal(Path.Combine("base", "new.mesh"), mesh.GameRelativePath);
        Assert.Equal(renamedFull, mesh.FullName);
        Assert.Equal(ResourcePath.CalculateHash(mesh.GameRelativePath), mesh.Hash);
    }
}
