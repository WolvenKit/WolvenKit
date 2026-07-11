using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.CR2W;
using Xunit;
using Assert = Xunit.Assert;

namespace WolvenKit.IntegrationTests.App.Helpers;

/// <summary>
/// Guards the game-relative path handling that <c>TemplateFileTools.MoveMesh</c> (GeneratePropItem's
/// "move meshes to folder") relies on: a mesh under <c>archive</c> is relocated into a sibling folder by
/// deriving <c>(root, sourceGameRel, destGameRel)</c> exactly the way MoveMesh does, then calling
/// <see cref="ProjectResourceTools.MoveAndRefactorAsync"/>.
///
/// The file must land at the intended target — NOT at a double-prefixed <c>archive\archive\...</c> path,
/// which is what feeding a raw-relative path into the game-relative API used to produce. This is a
/// filesystem-backed test (real move) but needs no game install: the archive manager is mocked and
/// <c>refactor: false</c> keeps it off the Cr2W/reference-rewriting path.
/// </summary>
public sealed class MeshMovePathHandlingIntegrationTests : IDisposable
{
    private readonly string _tempRoot;
    private readonly Cp77Project _project;
    private readonly ProjectResourceTools _tools;
    private readonly Mock<IProjectEvents> _events = new();

    public MeshMovePathHandlingIntegrationTests()
    {
        _tempRoot = Path.Combine(Path.GetTempPath(), "WolvenKit_MeshMoveTest_" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_tempRoot);

        _project = new Cp77Project(Path.Combine(_tempRoot, "TestMod.cpmodproj"), "TestMod", "TestMod");
        _ = _project.ModDirectory; // materialize source/archive on disk

        var logger = new Mock<ILoggerService>().Object;
        var hash = new Mock<IHashService>().Object;
        var hook = new Mock<IHookService>().Object;

        var projectManager = new Mock<IProjectManager>();
        projectManager.Setup(m => m.ActiveProject).Returns(_project);

        // Cr2WTools is unused on the refactor:false move path, but the ctor needs a non-null instance.
        var cr2wTools = new Cr2WTools(logger, hash, new Red4ParserService(hash, logger, hook));

        _tools = new ProjectResourceTools(
            projectManager.Object,
            new Mock<IArchiveManager>().Object,
            logger,
            new Mock<ISettingsManager>().Object,
            cr2wTools,
            _events.Object);
    }

    public void Dispose()
    {
        try
        {
            if (Directory.Exists(_tempRoot))
            {
                Directory.Delete(_tempRoot, recursive: true);
            }
        }
        catch { /* best effort */ }
    }

    [Fact]
    public async Task MoveMesh_DerivesGameRelativePaths_MovesFileToTargetFolder_NoDoubleArchivePrefix()
    {
        // A mesh sitting in archive\base\props\old on disk (paths are game-relative, as prop.MeshFileN).
        const string meshFile = @"base\props\old\mymesh.mesh";
        const string parentFolder = @"base\props\new"; // prop.ParentFolder
        var meshFileName = Path.GetFileName(meshFile);

        var sourceAbsPath = _project.GetAbsolutePath(meshFile);
        Directory.CreateDirectory(Path.GetDirectoryName(sourceAbsPath)!);
        File.WriteAllText(sourceAbsPath, "dummy mesh");

        // ---- exactly what TemplateFileTools.MoveMesh does ----
        var meshFilePath = Path.Combine(parentFolder, meshFileName);
        var destAbsPath = _project.GetAbsolutePath(meshFilePath);
        var (root, sourceGameRelPath) = _project.SplitFilePathIntoAbsoluteAndGameRelativePaths(sourceAbsPath);
        var destGameRelPath = _project.GetGameRelativePath(destAbsPath);
        await _tools.MoveAndRefactorAsync(sourceGameRelPath, destGameRelPath, root, false);
        // -------------------------------------------------------

        // Landed at the intended target, gone from the source.
        Assert.True(File.Exists(destAbsPath), $"Expected mesh at {destAbsPath}");
        Assert.False(File.Exists(sourceAbsPath), $"Source {sourceAbsPath} should have been moved away");

        // The double-prefix bug (raw-relative fed into the game-relative API) would have produced
        // ...\source\archive\archive\... — assert that nested archive folder does not exist.
        Assert.False(Directory.Exists(Path.Combine(_project.ModDirectory, "archive")),
            "A nested archive\\archive folder indicates a raw-vs-game path double-prefix regression.");

        // Exactly one mesh under the archive dir, and it is the target file.
        var filesUnderArchive = Directory
            .EnumerateFiles(_project.ModDirectory, "*", SearchOption.AllDirectories)
            .ToList();
        Assert.Single(filesUnderArchive);
        Assert.Equal(destAbsPath, filesUnderArchive[0]);

        // The move was announced authoritatively as absolute source -> absolute dest.
        _events.Verify(e => e.PublishFilesMoved(
                It.Is<FilesMovedMessage>(m => m.Moves.Any(mv =>
                    string.Equals(mv.From, sourceAbsPath, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(mv.To, destAbsPath, StringComparison.OrdinalIgnoreCase)))),
            Times.Once);
    }
}
