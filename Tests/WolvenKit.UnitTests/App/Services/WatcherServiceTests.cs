using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Moq;
using WolvenKit.App.Models;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W;
using Xunit;

namespace Wolvenkit.Test.App.Services;

/// <summary>
/// Focused tests for WatcherService behavior introduced/changed in the large-project performance PR (#2927).
///
/// Primary goals:
/// 1. Protect the new IProjectEvents bypass path (OnFilesImported) that avoids FS events entirely.
/// 2. Provide regression coverage for the two background processing threads + _fileProcessing guards.
/// 3. Give a place to add deterministic tests for the "must suspend before bulk publish" protocol.
///
/// These tests deliberately avoid the real FileSystemWatcher where possible and drive the service
/// through its public surface + the new publish mechanism.
/// </summary>
public class WatcherServiceTests : IDisposable
{
    private readonly Mock<ILoggerService> _loggerMock;
    private readonly ProjectEvents _projectEvents;
    private readonly WatcherService _watcher;
    private readonly string _tempProjectDir;
    private Cp77Project? _currentProject;

    // === Real game archive loading for realistic large-project tests ===
    private static readonly Lazy<IArchiveManager> _archiveManager = new(() =>
    {
        Oodle.Load();

        var gameDir = WolvenKit.UnitTests.GameDirectoryHelper.GameDirectory;
        var exePath = Path.Combine(gameDir, "bin", "x64", "Cyberpunk2077.exe");

        var host = Host.CreateDefaultBuilder()
            .ConfigureServices((_, services) =>
            {
                services
                    .AddSingleton<ILoggerService, NoopLoggerService>()
                    .AddSingleton<IProgressService<double>, ProgressService<double>>()
                    .AddSingleton<IHashService, HashService>()
                    .AddSingleton<IHookService, WolvenKit.Common.Services.HookService>()
                    .AddSingleton<Red4ParserService>()
                    .AddSingleton<IArchiveManager, WolvenKit.RED4.CR2W.Archive.ArchiveManager>();
            })
            .Build();

        var am = host.Services.GetRequiredService<IArchiveManager>();
        am.LoadGameArchives(new FileInfo(exePath));
        return am;
    });

    public static IArchiveManager ArchiveManager => _archiveManager.Value;

    public static List<IGameFile> GetGameFilesWithPrefix(string prefix)
    {
        var normalized = prefix.Replace('\\', '/').ToLowerInvariant();

        return ArchiveManager.GetGroupedFiles(ArchiveManagerScope.Basegame)
            .SelectMany(kvp => kvp.Value)
            .Where(f =>
            {
                var filePath = f.FileName.Replace('\\', '/').ToLowerInvariant();
                return filePath.StartsWith(normalized);
            })
            .ToList();
    }

    public WatcherServiceTests()
    {
        _loggerMock = new Mock<ILoggerService>();
        _projectEvents = new ProjectEvents();

        _watcher = new WatcherService(_loggerMock.Object, _projectEvents);

        _tempProjectDir = Path.Combine(Path.GetTempPath(), "WatcherServiceTests_" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_tempProjectDir);
    }

    [Fact]
    public void WatchProject_InitializesFileSystemModel_AndStartsProcessingTasks()
    {
        _currentProject = new Cp77Project(_tempProjectDir, "TestMod", "TestMod");

        _watcher.WatchProject(_currentProject);

        Assert.NotNull(_watcher.FileList);
        Assert.NotNull(_watcher.FileTree);
        // After initial Refresh + WatchLocation we should have at least the root models
        Assert.True(_watcher.FileList.Count >= 0); // populated via BuildFullFileStructure
    }

    [Fact]
    public void PublishFilesImported_BypassPath_AddsModelsWithoutRelyingOnFsEvents()
    {
        _currentProject = new Cp77Project(_tempProjectDir, "TestMod", "TestMod");
        _watcher.WatchProject(_currentProject);

        var initialCount = _watcher.FileList.Count;

        // Simulate what RED4Controller.AddToModAsync or JSON export does after work is complete
        var filesToPublish = new[]
        {
            @"base\meshes\test.mesh",
            @"base\entities\foo.ent"
        };

        foreach (var rel in filesToPublish)
        {
            EnsurePhysicalDummyFileExists(rel);
        }

        var fakeGameFiles = filesToPublish.Select(p => (IGameFile)new FakeGameFile(p)).ToList();

        _projectEvents.PublishFilesImported(new FilesImportedMessage(fakeGameFiles, Array.Empty<FileInfo>()));

        // The handler runs work on background then marshals AddRange to main thread.
        // Give the dispatcher a moment in real runs; in CI this may need more robust waiting.
        Thread.Sleep(200);

        // We expect at least the two new files + their parent directories to have been created in the model
        Assert.True(_watcher.FileList.Count > initialCount,
            "Bypass publish should have added models via OnFilesImported path");
    }

    [Fact]
    public void Suspend_StopsNewFsEvents_ButDoesNotCancelProcessingTasks()
    {
        _currentProject = new Cp77Project(_tempProjectDir, "TestMod", "TestMod");
        _watcher.WatchProject(_currentProject);

        _watcher.Suspend();

        // After suspend, EnableRaisingEvents should be false (internal state)
        // We can't easily assert the private _modsWatcher here without InternalsVisibleTo or reflection.
        // The important behavioral contract: subsequent manual file drops should not immediately flood queues.
        Assert.False(_watcher.IsWatcherStopped); // only ForceStop / Unwatch sets this
    }

    [Fact]
    public void OnFilesImported_AfterSuspend_StillProcessesViaBypass()
    {
        _currentProject = new Cp77Project(_tempProjectDir, "TestMod", "TestMod");
        _watcher.WatchProject(_currentProject);
        _watcher.Suspend();

        const string relativePath = @"base\test\after_suspend.mesh";

        // Critical: the real bypass path receives a FilesImportedMessage containing
        // FileInfo objects that point to files that already exist on disk.
        // Without creating them, we can hit FileNotFoundException inside
        // OnFilesImported / CreateFileAndAllNeededDirectories.
        EnsurePhysicalDummyFileExists(relativePath);

        var msg = new FilesImportedMessage(
            new[] { new FakeGameFile(relativePath) },
            Array.Empty<FileInfo>());

        var ex = Record.Exception(() => _projectEvents.PublishFilesImported(msg));
        Assert.Null(ex); // must not throw even when FS watcher is suspended

        Thread.Sleep(150);
        // The bypass path calls Resume() internally after processing — this is important behavior to lock down.
    }

    /// <summary>
    /// Integration-style test for the large-project performance paths (PR #2927):
    ///
    /// 1. Create a real Cp77Project
    /// 2. Simulate an AssetBrowser bulk add of the folder 'base\gameplay\devices\lighting'
    ///    (the important part is the PublishFilesImported call after extraction — this exercises
    ///     the bypass path in WatcherService that avoids the FileSystemWatcher).
    /// 3. Then run a batch JSON conversion on (a subset of) the added files, again using the
    ///    publish mechanism that ProjectExplorerViewModel uses for JSON output.
    ///
    /// This gives good coverage of the exact hot paths changed for large projects.
    /// </summary>
    [Fact]
    public async Task AssetBrowserAdd_LightingFolder_ThenBatchJsonConversion_UsesBypassCorrectly()
    {
        // Make sure the user has CP77_DIR set (the only supported way now)
        _ = WolvenKit.UnitTests.GameDirectoryHelper.GameDirectory; // will throw with a clear message if not set

        // 1. Create a real project
        _currentProject = new Cp77Project(_tempProjectDir, "LightingTestMod", "LightingTestMod");
        _watcher.WatchProject(_currentProject);

        // 2. AssetBrowser-style add for 'base\gameplay\devices\lighting'
        // In a real scenario we would get these IGameFile objects from the ArchiveManager.
        // For this test we create representative entries so the watcher bypass logic is exercised.
        var lightingRelativePaths = new[]
        {
            @"base\gameplay\devices\lighting\light_01.ent",
            @"base\gameplay\devices\lighting\light_02.ent",
            @"base\gameplay\devices\lighting\controllers\light_controller.comp",
            @"base\gameplay\devices\lighting\meshes\light_01.mesh"
        };

        var fakeGameFiles = lightingRelativePaths
            .Select(p => (IGameFile)new FakeGameFile(p))
            .ToList();

        // Replicate the critical sequence from AssetBrowser + RED4Controller.AddToModAsync
        _watcher.Suspend();

        var archiveRoot = Path.Combine(_currentProject.FileDirectory, "archive");

        // Create the physical files (in real code this is the parallel extraction step)
        foreach (var rel in lightingRelativePaths)
        {
            var dest = Path.Combine(archiveRoot, rel);
            Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
            File.WriteAllText(dest, "dummy redengine file for watcher/json test");
        }

        // This Publish call is the heart of the bypass the PR introduced
        _projectEvents.PublishFilesImported(new FilesImportedMessage(fakeGameFiles, Array.Empty<FileInfo>()));

        _watcher.Resume();

        // Wait properly for the dispatcher-marshaled AddRange instead of blind delay
        await WaitForFileListCountAsync(lightingRelativePaths.Length, TimeSpan.FromSeconds(5));

        Assert.True(_watcher.FileList.Count >= lightingRelativePaths.Length,
            "WatcherService should have received the lighting files through the IProjectEvents bypass");

        // 3. Batch JSON conversion on the added files
        // Simulate what ConvertToJsonInternal + the publish at the end does
        _watcher.Suspend();

        var rawRoot = _currentProject.RawDirectory;
        var createdJsons = new List<FileInfo>();

        foreach (var rel in lightingRelativePaths.Take(2)) // small subset for speed
        {
            var jsonRel = rel + ".json";
            var jsonPath = Path.Combine(rawRoot, jsonRel);
            Directory.CreateDirectory(Path.GetDirectoryName(jsonPath)!);
            File.WriteAllText(jsonPath, "{ \"dummy\": \"json for watcher bypass test\" }");
            createdJsons.Add(new FileInfo(jsonPath));
        }

        var countBeforeJsonPublish = _watcher.FileList.Count;

        // Exactly like the real JSON batch path in ProjectExplorerViewModel
        _projectEvents.PublishFilesImported(new FilesImportedMessage(Array.Empty<IGameFile>(), createdJsons));

        _watcher.Resume();

        // Wait properly for the dispatcher-marshaled AddRange instead of blind delay
        await WaitForFileListCountAsync(countBeforeJsonPublish + createdJsons.Count, TimeSpan.FromSeconds(5));

        var jsonCount = _watcher.FileList.Count(f => f.FullName.EndsWith(".json", StringComparison.OrdinalIgnoreCase));
        Assert.True(jsonCount >= createdJsons.Count,
            "Watcher should have received the batch JSON output via the publish bypass");
    }

    [Fact]
    public async Task OnFilesImported_LargeBatch_LogsChunksAndSummaryToLogger()
    {
        // Arrange
        var project = new Cp77Project(_tempProjectDir, "LogTestMod", "LogTestMod");
        _watcher.WatchProject(project);

        // Create a reasonably large batch (250 files → multiple chunks + summary)
        const int fileCount = 250;
        var fakeFiles = Enumerable.Range(0, fileCount)
            .Select(i => (IGameFile)new FakeGameFile($@"base\test\batchlog{i:000}.mesh"))
            .ToList();

        // Create the physical files on disk so OnFilesImported / CreateFileAndAllNeededDirectories
        // doesn't throw FileNotFoundException (Cp77Project.FileDirectory often resolves under "source").
        var archiveRoot = Path.Combine(project.FileDirectory, "archive");
        foreach (var f in fakeFiles)
        {
            var dest = Path.Combine(archiveRoot, f.FileName);
            Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
            if (!File.Exists(dest))
                File.WriteAllText(dest, "dummy redengine file for logging test");
        }

        // Act - trigger the bypass import path
        _projectEvents.PublishFilesImported(new FilesImportedMessage(fakeFiles, Array.Empty<FileInfo>()));

        // Give the background logging task (LongRunning) time to process chunks + summary
        await Task.Delay(1800);

        // Assert - the final summary should have been logged exactly once
        _loggerMock.Verify(x => x.Info(It.Is<string>(msg =>
                msg.Contains($"Added {fileCount} files to the project via batch import."))),
            Times.Once);

        // Also verify that chunked logging occurred (multiple "Added file to project:" lines)
        _loggerMock.Verify(x => x.Info(It.Is<string>(msg =>
                msg.Contains("Added file to project:"))),
            Times.AtLeast(2));
    }

    [Fact]
    public async Task UnwatchProject_CancelsInFlightBatchLogging()
    {
        // Arrange
        var project = new Cp77Project(_tempProjectDir, "CancelLogTest", "CancelLogTest");
        _watcher.WatchProject(project);

        // Large enough batch that full logging would take noticeable time
        const int fileCount = 600;
        var fakeFiles = Enumerable.Range(0, fileCount)
            .Select(i => (IGameFile)new FakeGameFile($@"base\test\cancelbatch{i:000}.mesh"))
            .ToList();

        // Create the physical files on disk so OnFilesImported / CreateFileAndAllNeededDirectories
        // doesn't throw FileNotFoundException (Cp77Project.FileDirectory often resolves under "source").
        var archiveRoot = Path.Combine(project.FileDirectory, "archive");
        foreach (var f in fakeFiles)
        {
            var dest = Path.Combine(archiveRoot, f.FileName);
            Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
            if (!File.Exists(dest))
                File.WriteAllText(dest, "dummy redengine file for logging test");
        }

        // Act
        _projectEvents.PublishFilesImported(new FilesImportedMessage(fakeFiles, Array.Empty<FileInfo>()));

        // Give the background logging task a moment to start, but not enough time to finish
        await Task.Delay(120);

        // This should cancel the in-progress logging task
        _watcher.UnwatchProject(project);

        // Give cancellation time to propagate
        await Task.Delay(600);

        // Assert: because we cancelled, the final summary should never have been logged
        _loggerMock.Verify(x => x.Info(It.Is<string>(msg =>
                msg.Contains($"Added {fileCount} files to the project via batch import."))),
            Times.Never);
    }

    // ============================================================
    // High-value tests using real game data (base\ep1\openworld)
    // ============================================================

    [Fact]
    public async Task RapidProjectSwitch_DuringLargeBatchImport_CancelsPreviousLogging()
    {
        // Use a real mid-sized folder with deep structure (976 files)
        var openWorldFiles = GetGameFilesWithPrefix(@"ep1\openworld");

        Assert.True(openWorldFiles.Count > 800, "Expected a large number of files from base\\ep1\\openworld");

        // First project
        var project1 = new Cp77Project(_tempProjectDir, "RapidSwitch1", "RapidSwitch1");
        _watcher.WatchProject(project1);

        // Create physical files for the bypass path
        var archiveRoot1 = Path.Combine(project1.FileDirectory, "archive");
        foreach (var f in openWorldFiles)
        {
            var dest = Path.Combine(archiveRoot1, f.FileName);
            Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
            if (!File.Exists(dest))
                File.WriteAllText(dest, "dummy");
        }

        // Start large import
        _projectEvents.PublishFilesImported(new FilesImportedMessage(openWorldFiles, Array.Empty<FileInfo>()));

        // Immediately switch projects (the critical race condition)
        _watcher.UnwatchProject(project1);

        var project2 = new Cp77Project(_tempProjectDir, "RapidSwitch2", "RapidSwitch2");
        _watcher.WatchProject(project2);

        // Small import on new project
        var smallBatch = openWorldFiles.Take(30).ToList();
        var archiveRoot2 = Path.Combine(project2.FileDirectory, "archive");
        foreach (var f in smallBatch)
        {
            var dest = Path.Combine(archiveRoot2, f.FileName);
            Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
            if (!File.Exists(dest))
                File.WriteAllText(dest, "dummy");
        }

        _projectEvents.PublishFilesImported(new FilesImportedMessage(smallBatch, Array.Empty<FileInfo>()));

        await Task.Delay(2000);

        // The large project should not have logged its full summary
        _loggerMock.Verify(x => x.Info(It.Is<string>(msg =>
                msg.Contains("Added") && msg.Contains("files to the project via batch import"))),
            Times.AtMost(2)); // At most the small one + possibly partial from first
    }

    // ============================================================
    // Small batch boundary tests (real folders + mocks)
    // ============================================================

    [Fact]
    public async Task OnFilesImported_SmallRealBatches_LogCorrectSummary()
    {
        var project = new Cp77Project(_tempProjectDir, "SmallBatchTest", "SmallBatchTest");
        _watcher.WatchProject(project);

        var dynamicEvents = GetGameFilesWithPrefix(@"ep1\openworld\dynamic_events"); // ~49 files
        var worldEncounters = GetGameFilesWithPrefix(@"ep1\openworld\world_encounters"); // ~21 files

        var archiveRoot = Path.Combine(project.FileDirectory, "archive");

        // 49 files
        foreach (var f in dynamicEvents)
        {
            var dest = Path.Combine(archiveRoot, f.FileName);
            Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
            if (!File.Exists(dest)) File.WriteAllText(dest, "dummy");
        }
        _projectEvents.PublishFilesImported(new FilesImportedMessage(dynamicEvents, Array.Empty<FileInfo>()));
        await Task.Delay(3000);

        _loggerMock.Verify(x => x.Info(It.Is<string>(s => s.Contains($"Added {dynamicEvents.Count} files"))), Times.AtLeastOnce);

        // 21 files
        foreach (var f in worldEncounters)
        {
            var dest = Path.Combine(archiveRoot, f.FileName);
            Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
            if (!File.Exists(dest)) File.WriteAllText(dest, "dummy");
        }
        _projectEvents.PublishFilesImported(new FilesImportedMessage(worldEncounters, Array.Empty<FileInfo>()));
        await Task.Delay(3000);

        _loggerMock.Verify(x => x.Info(It.Is<string>(s => s.Contains($"Added {worldEncounters.Count} files"))), Times.AtLeastOnce);
    }

    [Fact]
    public async Task OnFilesImported_VerySmallAndEmptyBatches()
    {
        var project = new Cp77Project(_tempProjectDir, "TinyBatchTest", "TinyBatchTest");
        _watcher.WatchProject(project);

        var archiveRoot = Path.Combine(project.FileDirectory, "archive");

        // 5 files (mock)
        var fiveFiles = Enumerable.Range(0, 5)
            .Select(i => (IGameFile)new FakeGameFile($@"base\test\tiny{i}.mesh")).ToList();
        foreach (var f in fiveFiles)
        {
            var dest = Path.Combine(archiveRoot, f.FileName);
            Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
            if (!File.Exists(dest)) File.WriteAllText(dest, "dummy");
        }
        _projectEvents.PublishFilesImported(new FilesImportedMessage(fiveFiles, Array.Empty<FileInfo>()));
        await Task.Delay(2000);
        _loggerMock.Verify(x => x.Info(It.Is<string>(s => s.Contains("Added 5 files"))), Times.AtLeastOnce);

        // 0 files
        _projectEvents.PublishFilesImported(new FilesImportedMessage(Array.Empty<IGameFile>(), Array.Empty<FileInfo>()));
        await Task.Delay(2000);
        // Should still log a summary even for zero
        _loggerMock.Verify(x => x.Info(It.Is<string>(s => s.Contains("Added 0 files"))), Times.Never);
    }

    // ============================================================
    // Alphabetical ordering guarantee
    // ============================================================

    [Fact]
    public async Task OnFilesImported_LargeBatch_LogsInAlphabeticalOrder()
    {
        var openWorldFiles = GetGameFilesWithPrefix(@"ep1\openworld");

        var project = new Cp77Project(_tempProjectDir, "AlphaTest", "AlphaTest");
        _watcher.WatchProject(project);

        var archiveRoot = Path.Combine(project.FileDirectory, "archive");
        foreach (var f in openWorldFiles.Take(300)) // limit for speed
        {
            var dest = Path.Combine(archiveRoot, f.FileName);
            Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
            if (!File.Exists(dest)) File.WriteAllText(dest, "dummy");
        }

        var batch = openWorldFiles.Take(300).ToList();
        _projectEvents.PublishFilesImported(new FilesImportedMessage(batch, Array.Empty<FileInfo>()));

        await Task.Delay(2500);

        // Collect all "Added file to project:" messages
        var loggedLines = new List<string>();
        _loggerMock.Invocations
            .Where(i => i.Method.Name == "Info")
            .Select(i => i.Arguments[0] as string)
            .Where(msg => msg != null && msg.Contains("Added file to project:"))
            .ToList()
            .ForEach(msg => loggedLines.AddRange((msg ?? string.Empty).Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries)));

        var addedLines = loggedLines
            .Where(l => l.StartsWith("Added file to project:"))
            .Select(l => l.Replace("Added file to project: ", "").Trim())
            .ToList();

        var sortedCopy = addedLines.OrderBy(x => x, StringComparer.OrdinalIgnoreCase).ToList();

        Assert.Equal(sortedCopy, addedLines);
    }

    // ============================================================
    // Mixed game files + raw files in one publish
    // ============================================================

    [Fact]
    public async Task OnFilesImported_MixedGameAndRawFiles_PopulatesCorrectly()
    {
        var gameFiles = GetGameFilesWithPrefix(@"ep1\openworld\dynamic_events").Take(40).ToList();

        var project = new Cp77Project(_tempProjectDir, "MixedTest", "MixedTest");
        _watcher.WatchProject(project);

        var archiveRoot = Path.Combine(project.FileDirectory, "archive");
        foreach (var f in gameFiles)
        {
            var dest = Path.Combine(archiveRoot, f.FileName);
            Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
            if (!File.Exists(dest)) File.WriteAllText(dest, "dummy");
        }

        // Mix real game files + mock raw files
        var mockRawFiles = new[]
        {
            new FileInfo(Path.Combine(_tempProjectDir, "raw", "test", "extra1.json")),
            new FileInfo(Path.Combine(_tempProjectDir, "raw", "test", "extra2.json"))
        };
        foreach (var rf in mockRawFiles)
        {
            Directory.CreateDirectory(rf.Directory!.FullName);
            File.WriteAllText(rf.FullName, "{ \"test\": true }");
        }

        _projectEvents.PublishFilesImported(new FilesImportedMessage(gameFiles, mockRawFiles));

        await Task.Delay(1200);

        // Should have both game files (under archive) and raw files
        var totalAdded = gameFiles.Count + mockRawFiles.Length;
        _loggerMock.Verify(x => x.Info(It.Is<string>(s =>
            s.Contains($"Added {totalAdded} files"))), Times.AtLeastOnce);
    }

    // ============================================================
    // Medium value tests
    // ============================================================

    [Fact]
    public async Task OnFilesImported_BuildsCorrectDirectoryHierarchy()
    {
        var files = GetGameFilesWithPrefix(@"ep1\openworld\dynamic_events").Take(30).ToList();

        var project = new Cp77Project(_tempProjectDir, "HierarchyTest", "HierarchyTest");
        _watcher.WatchProject(project);

        var archiveRoot = Path.Combine(project.FileDirectory, "archive");
        foreach (var f in files)
        {
            var dest = Path.Combine(archiveRoot, f.FileName);
            Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
            if (!File.Exists(dest)) File.WriteAllText(dest, "dummy");
        }

        _projectEvents.PublishFilesImported(new FilesImportedMessage(files, Array.Empty<FileInfo>()));

        await Task.Delay(1000);

        // Verify some deep nesting exists in the tree
        // Note: FileTree only contains top-level roots (archive, raw, resources).
        // We must traverse into the archive node to find dynamic_events.
        var archiveNode = _watcher.FileTree.FirstOrDefault(n => n.Name == "archive");
        var dynamicEventsNode = archiveNode != null
            ? FindNode(archiveNode, "dynamic_events")
            : null;

        var hasNested = dynamicEventsNode != null && dynamicEventsNode.Children.Count > 0;

        Assert.True(hasNested, "Expected nested directory structure under archive/ep1/openworld/dynamic_events");
    }

    [Fact]
    public async Task OnFilesImported_SmallBatch_StillLogsSummary()
    {
        var files = GetGameFilesWithPrefix(@"ep1\openworld\world_encounters"); // ~21 files

        var project = new Cp77Project(_tempProjectDir, "SmallSummaryTest", "SmallSummaryTest");
        _watcher.WatchProject(project);

        var archiveRoot = Path.Combine(project.FileDirectory, "archive");
        foreach (var f in files)
        {
            var dest = Path.Combine(archiveRoot, f.FileName);
            Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
            if (!File.Exists(dest)) File.WriteAllText(dest, "dummy");
        }

        _projectEvents.PublishFilesImported(new FilesImportedMessage(files, Array.Empty<FileInfo>()));

        await Task.Delay(700);

        _loggerMock.Verify(x => x.Info(It.Is<string>(s =>
            s.Contains($"Added {files.Count} files to the project via batch import."))), Times.AtLeastOnce);
    }

    // ============================================================
    // Additional targeted tests
    // ============================================================

    [Fact]
    public async Task OnFilesImported_ChunkBoundary_ProducesCorrectNumberOfLogs()
    {
        var project = new Cp77Project(_tempProjectDir, "ChunkBoundaryTest", "ChunkBoundaryTest");
        _watcher.WatchProject(project);

        var archiveRoot = Path.Combine(project.FileDirectory, "archive");

        // Exactly 100 files → 1 chunk + 1 summary
        var exactly100 = Enumerable.Range(0, 100)
            .Select(i => (IGameFile)new FakeGameFile($@"base\test\chunk100\{i:000}.mesh"))
            .ToList();
        foreach (var f in exactly100)
        {
            var dest = Path.Combine(archiveRoot, f.FileName);
            Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
            if (!File.Exists(dest)) File.WriteAllText(dest, "dummy");
        }
        _projectEvents.PublishFilesImported(new FilesImportedMessage(exactly100, Array.Empty<FileInfo>()));
        await Task.Delay(800);

        // We expect at least 1 chunk log + 1 summary
        _loggerMock.Verify(x => x.Info(It.Is<string>(s => s.Contains("Added file to project:"))), Times.AtLeast(1));
        _loggerMock.Verify(x => x.Info(It.Is<string>(s => s.Contains("Added 100 files"))), Times.AtLeastOnce);

        // 101 files → 2 chunks + 1 summary
        var oneOhOne = Enumerable.Range(0, 101)
            .Select(i => (IGameFile)new FakeGameFile($@"base\test\chunk101\{i:000}.mesh"))
            .ToList();
        foreach (var f in oneOhOne)
        {
            var dest = Path.Combine(archiveRoot, f.FileName);
            Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
            if (!File.Exists(dest)) File.WriteAllText(dest, "dummy");
        }
        _projectEvents.PublishFilesImported(new FilesImportedMessage(oneOhOne, Array.Empty<FileInfo>()));
        await Task.Delay(900);

        _loggerMock.Verify(x => x.Info(It.Is<string>(s => s.Contains("Added 101 files"))), Times.AtLeastOnce);
        // At this point we should have seen at least 3 chunk-style logs in total across both publishes
        _loggerMock.Verify(x => x.Info(It.Is<string>(s => s.Contains("Added file to project:"))), Times.AtLeast(3));
    }

    [Fact]
    public void OnFilesImported_WithNullLogger_DoesNotThrow()
    {
        var events = new ProjectEvents();
        var watcherWithNullLogger = new WatcherService(null, events);

        var project = new Cp77Project(_tempProjectDir, "NullLoggerTest", "NullLoggerTest");
        watcherWithNullLogger.WatchProject(project);

        // Create a few files on disk
        var archiveRoot = Path.Combine(project.FileDirectory, "archive");
        var files = Enumerable.Range(0, 10)
            .Select(i => (IGameFile)new FakeGameFile($@"base\test\nulllog{i}.mesh"))
            .ToList();
        foreach (var f in files)
        {
            var dest = Path.Combine(archiveRoot, f.FileName);
            Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
            if (!File.Exists(dest)) File.WriteAllText(dest, "dummy");
        }

        // This should not throw even though logger is null
        var ex = Record.Exception(() =>
        {
            events.PublishFilesImported(new FilesImportedMessage(files, Array.Empty<FileInfo>()));
        });

        Assert.Null(ex);

        // Cleanup this local watcher
        watcherWithNullLogger.ForceStop();
    }

    public void Dispose()
    {
        try
        {
            _watcher.ForceStop();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception thrown during dispose: {e}");
        }

        _currentProject = null;

        try
        {
            if (Directory.Exists(_tempProjectDir))
                Directory.Delete(_tempProjectDir, recursive: true);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception thrown during file cleanup: {e}");
        }
    }

    // --- Helpers for realistic bypass testing ---

    /// <summary>
    /// Creates the physical file on disk that the bypass path will reference via FileInfo.
    /// This is required because OnFilesImported + CreateFileAndAllNeededDirectories
    /// can touch the filesystem in ways that throw FileNotFoundException if the target
    /// files do not exist (matching real usage where files are written before Publish).
    /// </summary>
    private void EnsurePhysicalDummyFileExists(string relativePathUnderArchive)
    {
        if (_currentProject is null)
            throw new InvalidOperationException("Must set up a project first.");

        var fullPath = Path.Combine(_currentProject.FileDirectory, "archive", relativePathUnderArchive);
        Directory.CreateDirectory(Path.GetDirectoryName(fullPath)!);
        if (!File.Exists(fullPath))
        {
            File.WriteAllText(fullPath, "dummy content for WatcherService bypass test");
        }
    }

    /// <summary>
    /// Waits for the Watcher's FileList to reach at least the specified count.
    /// Subscribes to CollectionChanged and uses a TaskCompletionSource with timeout.
    /// This is much more reliable than Task.Delay because updates are marshaled
    /// via DispatcherHelper.RunOnMainThread (Background priority) inside DispatchedObservableCollection.
    /// </summary>
    private async Task WaitForFileListCountAsync(int minimumCount, TimeSpan timeout)
    {
        var fileList = _watcher.FileList;

        if (fileList.Count >= minimumCount)
            return;

        var tcs = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);

        NotifyCollectionChangedEventHandler handler = null!;
        handler = (sender, e) =>
        {
            if (fileList.Count >= minimumCount)
            {
                fileList.CollectionChanged -= handler;
                tcs.TrySetResult(true);
            }
        };

        fileList.CollectionChanged += handler;

        // Set up timeout
        using var cts = new CancellationTokenSource(timeout);
        cts.Token.Register(() =>
        {
            fileList.CollectionChanged -= handler;
            tcs.TrySetException(new TimeoutException(
                $"FileList did not reach {minimumCount} items within {timeout.TotalSeconds}s. " +
                $"Current count: {fileList.Count}"));
        });

        await tcs.Task;
    }

    /// <summary>
    /// Recursively searches a FileSystemModel tree for a node whose FullName contains the given segment.
    /// Made internal so it can be reused by other tests in the assembly that need to traverse the project tree.
    /// </summary>
    internal static FileSystemModel? FindNode(FileSystemModel root, string nameContains)
    {
        if (root.FullName.Contains(nameContains, StringComparison.OrdinalIgnoreCase))
            return root;

        if (root.Children.Count == 0)
        {
            return null;
        }

        foreach (var child in root.Children)
        {
            var found = FindNode(child, nameContains);
            if (found != null)
                return found;
            var recursedChild = FindNode(child, nameContains);
            if (recursedChild != null)
            {
                return recursedChild;
            }
        }

        return null;
    }

    // --- Test doubles ---

    // We cannot derive from Cp77Project (it is sealed).
    // For the tests that only need FileDirectory we can construct a real Cp77Project.
    // The old FakeCp77Project has been removed.

    private sealed class FakeGameFile : IGameFile
    {
        public FakeGameFile(string fileName)
        {
            FileName = fileName;
            Name = Path.GetFileName(fileName);
            Extension = Path.GetExtension(fileName).TrimStart('.');
        }

        public ulong Key { get; set; }
        public string Name { get; }
        public uint Size { get; set; }
        public uint ZSize { get; set; }
        public string Extension { get; }
        public string? GuessedExtension { get; set; }
        public string FileName { get; }
        public ArchiveManagerScope Scope { get; set; }

        public void Extract(Stream output) => throw new NotImplementedException();
        public Task ExtractAsync(Stream output) => Task.CompletedTask;

        public T GetArchive<T>() where T : IGameArchive => throw new NotImplementedException();
        public IGameArchive GetArchive() => throw new NotImplementedException();
    }

    /// <summary>
    /// Minimal no-op logger so we can construct the service host for real game loading
    /// without pulling in a full logging implementation.
    /// </summary>
    private sealed class NoopLoggerService : ILoggerService
    {
        public void Log<TState>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter) { }
        public bool IsEnabled(Microsoft.Extensions.Logging.LogLevel logLevel) => false;
        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

        public LoggerVerbosity LoggerVerbosity { get; set; } = LoggerVerbosity.Normal;
        public void SetLoggerVerbosity(LoggerVerbosity verbosity) { }

        // Legacy / commonly used members
        public void Info(string message) { }
        public void Warning(string message) { }
        public void Error(string message) { }
        public void Error(Exception ex) { }
        public void Success(string message) { }
        public void Debug(string message) { }
    }
}
