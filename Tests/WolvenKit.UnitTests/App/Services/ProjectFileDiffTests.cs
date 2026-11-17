using System;
using System.Collections.Generic;
using Moq;
using WolvenKit.App.Services;
using Xunit;

namespace Wolvenkit.Test.App.Services;

/// <summary>
/// Tests the snapshot-diff reconciliation used to announce derived, multi-file outputs (e.g. a script
/// export producing a .glb + textures) to the project explorer without knowing the paths up front.
/// </summary>
public class ProjectFileDiffTests
{
    // Mirrors ProjectFileDiff.Snapshot's comparer so Contains() behaves the same as in production.
    private static IReadOnlySet<string> Set(params string[] paths) =>
        new HashSet<string>(paths, StringComparer.OrdinalIgnoreCase);

    [Fact]
    public void Publish_NewFiles_AreAnnouncedAsImports()
    {
        var events = new Mock<IProjectEvents>();
        var before = Set(@"C:\proj\raw\a.glb");
        var after = Set(@"C:\proj\raw\a.glb", @"C:\proj\raw\b.glb", @"C:\proj\raw\tex\b.png");

        ProjectFileDiff.Publish(before, after, events.Object);

        events.Verify(e => e.PublishFileImported(@"C:\proj\raw\b.glb"), Times.Once);
        events.Verify(e => e.PublishFileImported(@"C:\proj\raw\tex\b.png"), Times.Once);
        events.Verify(e => e.PublishFileImported(It.IsAny<string>()), Times.Exactly(2));
        events.Verify(e => e.PublishFileDeleted(It.IsAny<string>()), Times.Never);
    }

    [Fact]
    public void Publish_RemovedFiles_AreAnnouncedAsDeletes()
    {
        var events = new Mock<IProjectEvents>();
        var before = Set(@"C:\proj\raw\a.glb", @"C:\proj\raw\old.glb");
        var after = Set(@"C:\proj\raw\a.glb");

        ProjectFileDiff.Publish(before, after, events.Object);

        events.Verify(e => e.PublishFileDeleted(@"C:\proj\raw\old.glb"), Times.Once);
        events.Verify(e => e.PublishFileDeleted(It.IsAny<string>()), Times.Exactly(1));
        events.Verify(e => e.PublishFileImported(It.IsAny<string>()), Times.Never);
    }

    [Fact]
    public void Publish_UnchangedOrOverwrittenInPlace_PublishNothing()
    {
        var events = new Mock<IProjectEvents>();
        var same = Set(@"C:\proj\raw\a.glb", @"C:\proj\raw\b.glb");

        ProjectFileDiff.Publish(same, same, events.Object);

        events.Verify(e => e.PublishFileImported(It.IsAny<string>()), Times.Never);
        events.Verify(e => e.PublishFileDeleted(It.IsAny<string>()), Times.Never);
    }

    [Fact]
    public void Publish_Mixed_PublishesBothAddsAndDeletes()
    {
        var events = new Mock<IProjectEvents>();
        var before = Set(@"C:\proj\raw\keep.glb", @"C:\proj\raw\gone.glb");
        var after = Set(@"C:\proj\raw\keep.glb", @"C:\proj\raw\new.glb");

        ProjectFileDiff.Publish(before, after, events.Object);

        events.Verify(e => e.PublishFileImported(@"C:\proj\raw\new.glb"), Times.Once);
        events.Verify(e => e.PublishFileDeleted(@"C:\proj\raw\gone.glb"), Times.Once);
        events.Verify(e => e.PublishFileImported(It.IsAny<string>()), Times.Exactly(1));
        events.Verify(e => e.PublishFileDeleted(It.IsAny<string>()), Times.Exactly(1));
    }

    [Fact]
    public void Publish_CaseInsensitive_TreatsSamePathAsUnchanged()
    {
        var events = new Mock<IProjectEvents>();
        var before = Set(@"C:\proj\raw\Model.glb");
        var after = Set(@"C:\proj\raw\model.GLB");

        ProjectFileDiff.Publish(before, after, events.Object);

        events.Verify(e => e.PublishFileImported(It.IsAny<string>()), Times.Never);
        events.Verify(e => e.PublishFileDeleted(It.IsAny<string>()), Times.Never);
    }

    [Fact]
    public void Snapshot_NullOrMissingDirectory_ReturnsEmpty()
    {
        Assert.Empty(ProjectFileDiff.Snapshot(null));
        Assert.Empty(ProjectFileDiff.Snapshot(@"C:\does\not\exist\" + Guid.NewGuid().ToString("N")));
    }

    [Fact]
    public void Snapshot_ExistingDirectory_ReturnsAllFilesRecursively()
    {
        var root = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "ProjectFileDiffTests_" + Guid.NewGuid().ToString("N"));
        try
        {
            var nested = System.IO.Path.Combine(root, "sub");
            System.IO.Directory.CreateDirectory(nested);
            var f1 = System.IO.Path.Combine(root, "a.glb");
            var f2 = System.IO.Path.Combine(nested, "b.png");
            System.IO.File.WriteAllText(f1, "x");
            System.IO.File.WriteAllText(f2, "y");

            var snap = ProjectFileDiff.Snapshot(root);

            Assert.Equal(2, snap.Count);
            Assert.Contains(f1, snap);
            Assert.Contains(f2, snap);
        }
        finally
        {
            if (System.IO.Directory.Exists(root))
            {
                System.IO.Directory.Delete(root, recursive: true);
            }
        }
    }
}
