using System;
using System.IO;
using Moq;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.IntegrationTests.Helpers;
using Xunit;
using Assert = Xunit.Assert;

namespace WolvenKit.IntegrationTests.App.Helpers;

/// <summary>
/// Filesystem-backed tests for the two shared empty-folder cleanup helpers
/// (<see cref="Cp77Project.DeleteEmptyFolders(ILoggerService, IProjectEvents?)"/> and
/// <see cref="ProjectResourceTools.DeleteEmptyParents(string?, Cp77Project, IProjectEvents?)"/>).
///
/// Both delete directories inside the project on disk; these tests assert they announce every removed
/// directory to <see cref="IProjectEvents"/> so the project explorer prunes the matching nodes rather
/// than leaving them stale — while still honouring their existing safety rules (non-empty folders and
/// folders directly under the project root are never touched).
/// </summary>
public sealed class EmptyFolderCleanupIntegrationTests : IDisposable
{
    private readonly string _tempRoot;
    private readonly Cp77Project _project;
    private readonly Mock<IProjectEvents> _events = new();
    private readonly ILoggerService _logger = new Mock<ILoggerService>().Object;

    public EmptyFolderCleanupIntegrationTests()
    {
        _tempRoot = Path.Combine(Path.GetTempPath(), "WolvenKit_EmptyFolderTest_" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_tempRoot);

        // Location points at a (non-existent) .cpmodproj file; ProjectDirectory resolves to its folder,
        // and FileDirectory (/source) + ModDirectory (/source/archive) are materialized on demand under it.
        _project = new Cp77Project(Path.Combine(_tempRoot, "TestMod.cpmodproj"), "TestMod", "TestMod");
    }

    public void Dispose()
    {
        try
        {
            RecentProjectsTestCleanup.RemoveProjectsUnder(_tempRoot);
            if (Directory.Exists(_tempRoot))
            {
                Directory.Delete(_tempRoot, recursive: true);
            }
        }
        catch { /* best effort */ }
    }

    // ---------- Cp77Project.DeleteEmptyFolders ----------

    [Fact]
    public void DeleteEmptyFolders_RemovesAndAnnouncesEveryEmptyFolder_KeepsNonEmpty()
    {
        var archive = _project.ModDirectory;
        var emptyA = Path.Combine(archive, "emptyA");
        var emptyB = Path.Combine(archive, "emptyB");
        var emptyBNested = Path.Combine(emptyB, "nested");
        var full = Path.Combine(archive, "full");
        Directory.CreateDirectory(emptyA);
        Directory.CreateDirectory(emptyBNested);
        Directory.CreateDirectory(full);
        File.WriteAllText(Path.Combine(full, "keep.txt"), "x");

        _project.DeleteEmptyFolders(_logger, _events.Object);

        // emptyB becomes empty once its only child (nested) is removed, so the whole chain goes.
        Assert.False(Directory.Exists(emptyA));
        Assert.False(Directory.Exists(emptyBNested));
        Assert.False(Directory.Exists(emptyB));
        Assert.True(Directory.Exists(full)); // has a file, preserved

        _events.Verify(e => e.PublishDirectoryDeleted(emptyA), Times.Once);
        _events.Verify(e => e.PublishDirectoryDeleted(emptyBNested), Times.Once);
        _events.Verify(e => e.PublishDirectoryDeleted(emptyB), Times.Once);
        _events.Verify(e => e.PublishDirectoryDeleted(It.IsAny<string>()), Times.Exactly(3));
        _events.Verify(e => e.PublishDirectoryDeleted(full), Times.Never);
    }

    [Fact]
    public void DeleteEmptyFolders_NothingEmpty_PublishesNothing()
    {
        var archive = _project.ModDirectory;
        var full = Path.Combine(archive, "keepme");
        Directory.CreateDirectory(full);
        File.WriteAllText(Path.Combine(full, "a.txt"), "x");

        _project.DeleteEmptyFolders(_logger, _events.Object);

        Assert.True(Directory.Exists(full));
        _events.Verify(e => e.PublishDirectoryDeleted(It.IsAny<string>()), Times.Never);
    }

    [Fact]
    public void DeleteEmptyFolders_NullProjectEvents_StillDeletesWithoutThrowing()
    {
        var archive = _project.ModDirectory;
        var empty = Path.Combine(archive, "empty");
        Directory.CreateDirectory(empty);

        // Backwards-compatible overload: existing callers passing only the logger must keep working.
        _project.DeleteEmptyFolders(_logger);

        Assert.False(Directory.Exists(empty));
    }

    // ---------- ProjectResourceTools.DeleteEmptyParents ----------

    [Fact]
    public void DeleteEmptyParents_RemovesAndAnnouncesEmptyChain_StopsAtProjectRoot()
    {
        // source/archive/a/b/c, all empty. 'archive' sits directly under FileDirectory (source) and must survive.
        var archive = _project.ModDirectory;
        var a = Path.Combine(archive, "a");
        var b = Path.Combine(a, "b");
        var c = Path.Combine(b, "c");
        Directory.CreateDirectory(c);

        // Simulate cleanup after deleting a file that lived in c.
        var deletedFile = Path.Combine(c, "gone.mesh");
        ProjectResourceTools.DeleteEmptyParents(deletedFile, _project, _events.Object);

        Assert.False(Directory.Exists(c));
        Assert.False(Directory.Exists(b));
        Assert.False(Directory.Exists(a));
        Assert.True(Directory.Exists(archive)); // directly under source: never removed

        _events.Verify(e => e.PublishDirectoryDeleted(c), Times.Once);
        _events.Verify(e => e.PublishDirectoryDeleted(b), Times.Once);
        _events.Verify(e => e.PublishDirectoryDeleted(a), Times.Once);
        _events.Verify(e => e.PublishDirectoryDeleted(It.IsAny<string>()), Times.Exactly(3));
        _events.Verify(e => e.PublishDirectoryDeleted(archive), Times.Never);
    }

    [Fact]
    public void DeleteEmptyParents_FolderDirectlyUnderProjectRoot_IsNeverDeleted()
    {
        // A folder one level under FileDirectory (source) is protected even when empty.
        var fileDir = _project.FileDirectory;
        var directChild = Path.Combine(fileDir, "loosefolder");
        Directory.CreateDirectory(directChild);

        ProjectResourceTools.DeleteEmptyParents(Path.Combine(directChild, "x.txt"), _project, _events.Object);

        Assert.True(Directory.Exists(directChild));
        _events.Verify(e => e.PublishDirectoryDeleted(It.IsAny<string>()), Times.Never);
    }

    [Fact]
    public void DeleteEmptyParents_NonEmptyParent_HaltsAndAnnouncesOnlyWhatWasRemoved()
    {
        var archive = _project.ModDirectory;
        var a = Path.Combine(archive, "a");
        var b = Path.Combine(a, "b");
        Directory.CreateDirectory(b);
        File.WriteAllText(Path.Combine(a, "sibling.txt"), "x"); // makes 'a' non-empty

        // b is empty → removed; a still holds sibling.txt → kept, recursion stops there.
        ProjectResourceTools.DeleteEmptyParents(Path.Combine(b, "gone.mesh"), _project, _events.Object);

        Assert.False(Directory.Exists(b));
        Assert.True(Directory.Exists(a));

        _events.Verify(e => e.PublishDirectoryDeleted(b), Times.Once);
        _events.Verify(e => e.PublishDirectoryDeleted(It.IsAny<string>()), Times.Once);
    }
}
