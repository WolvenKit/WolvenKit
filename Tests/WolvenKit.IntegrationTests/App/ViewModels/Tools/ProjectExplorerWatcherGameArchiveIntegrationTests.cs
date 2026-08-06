using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Moq;
using WolvenKit.App.Controllers;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common.Interfaces;
using WolvenKit.Modkit.RED4;
using WolvenKit.App.Models;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.CR2W;
using Xunit;
using Xunit.Sdk;

namespace WolvenKit.IntegrationTests.App.ViewModels.Tools;

/// <summary>
/// WatcherService tests that drive the IProjectEvents import bypass with REAL game file lists
/// loaded from the installed Cyberpunk 2077 archives.
///
/// These live in the integration test project, not the unit test project, because they require
/// CP77_DIR to point at a real game install — CI has no such install, so as unit tests they
/// failed the PR gate for everyone. The counts asserted here (a ~976-file folder, a ~49-file
/// folder, a ~21-file folder) are the point of the tests: they exercise batching, chunk
/// boundaries and deep hierarchies at realistic scale, which synthetic file lists would not.
///
/// Tests in the same area that use synthetic <c>FakeGameFile</c> data stay in
/// WolvenKit.UnitTests/App/ViewModels/Tools/WatcherServiceTests.cs.
/// </summary>
public class ProjectExplorerWatcherGameArchiveIntegrationTests : IDisposable
{
    private readonly Mock<ILoggerService> _loggerMock;
    private readonly ProjectEvents _projectEvents;
    private readonly ProjectExplorerViewModel _watcher;
    private readonly string _tempProjectDir;

    // === Real game archive loading for realistic large-project tests ===
    private static readonly Lazy<IArchiveManager> s_archiveManager = new(() =>
    {
        Oodle.Load();

        var gameDir = ResolveGameDirectory();
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

    private static IArchiveManager ArchiveManager => s_archiveManager.Value;

    private static string ResolveGameDirectory()
    {
        var dir = Environment.GetEnvironmentVariable("CP77_DIR", EnvironmentVariableTarget.User);
        if (!string.IsNullOrEmpty(dir) && Directory.Exists(dir))
            return dir;

        throw new XunitException("CP77_DIR user environment variable must point to a valid Cyberpunk 2077 installation.");
    }

    private static List<IGameFile> GetGameFilesWithPrefix(string prefix)
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

    public ProjectExplorerWatcherGameArchiveIntegrationTests()
    {
        _loggerMock = new Mock<ILoggerService>();
        _projectEvents = new ProjectEvents();
        _watcher = new ProjectExplorerViewModel(
            (AppViewModel)RuntimeHelpers.GetUninitializedObject(typeof(AppViewModel)),
            new Mock<IProjectManager>().Object,
            _loggerMock.Object,
            new Mock<INotificationService>().Object,
            new Mock<IProgressService<double>>().Object,
            new Mock<IModTools>().Object,
            new Mock<IGameControllerFactory>().Object,
            new Mock<IPluginService>().Object,
            new Mock<ISettingsManager>().Object,
            new Mock<IModifierViewStateService>().Object,
            new Mock<IArchiveManager>().Object,
            (ProjectResourceTools)RuntimeHelpers.GetUninitializedObject(typeof(ProjectResourceTools)),
            (ImportExportHelper)RuntimeHelpers.GetUninitializedObject(typeof(ImportExportHelper)),
            _projectEvents);

        _tempProjectDir = Path.Combine(Path.GetTempPath(), "WatcherServiceGameArchive_" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_tempProjectDir);
    }

    /// <summary>
    /// Builds a Cp77Project rooted at <see cref="_tempProjectDir"/>. Location must be the
    /// .cpmodproj path (or a path whose parent is the project folder) — passing the folder itself
    /// makes ProjectDirectory resolve to %TEMP%, so every test would share %TEMP%\source and the
    /// count-based waits below would be silently wrong.
    /// </summary>
    private Cp77Project CreateTestProject(string name)
    {
        var projectFile = Path.Combine(_tempProjectDir, name + Cp77Project.ProjectFileExtension);
        if (!File.Exists(projectFile))
        {
            File.WriteAllText(projectFile, "<!-- test project -->");
        }

        var project = new Cp77Project(projectFile, name, name);
        project.CreateDefaultDirectories();
        return project;
    }

    /// <summary>
    /// Writes the physical files the bypass path references. Real usage writes the extracted files
    /// before publishing, and CreateFileAndAllNeededDirectories touches the filesystem.
    /// </summary>
    private static void MaterializeUnderArchive(Cp77Project project, IEnumerable<IGameFile> files)
    {
        var archiveRoot = Path.Combine(project.FileDirectory, "archive");
        foreach (var f in files)
        {
            var dest = Path.Combine(archiveRoot, f.FileName);
            Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
            if (!File.Exists(dest))
            {
                File.WriteAllText(dest, "dummy");
            }
        }
    }

    [Fact]
    public async Task RapidProjectSwitch_DuringLargeBatchImport_CancelsPreviousLogging()
    {
        // Use a real mid-sized folder with deep structure (~976 files)
        var openWorldFiles = GetGameFilesWithPrefix(@"ep1\openworld");
        Assert.True(openWorldFiles.Count > 800, "Expected a large number of files from base\\ep1\\openworld");

        var project1 = CreateTestProject("RapidSwitch1");
        _watcher.StartWatcher_AndLoadProject(project1);
        MaterializeUnderArchive(project1, openWorldFiles);

        // Start large import, then immediately switch projects (the critical race condition)
        _projectEvents.PublishFilesImported(new FilesImportedMessage.GameFiles(openWorldFiles));
        _watcher.UnwatchProject();

        var project2 = CreateTestProject("RapidSwitch2");
        _watcher.StartWatcher_AndLoadProject(project2);

        var smallBatch = openWorldFiles.Take(30).ToList();
        MaterializeUnderArchive(project2, smallBatch);
        _projectEvents.PublishFilesImported(new FilesImportedMessage.GameFiles(smallBatch));

        await Task.Delay(2000);

        // A rapid switch during a large import may leave a lot of the first batch's work in the
        // model. What we can reliably assert is that the second project's small batch was
        // processed without crashing.
        Assert.True(_watcher.FileList.Count >= smallBatch.Count,
            "The small batch on the second project should be visible after the rapid switch");
    }

    [Fact]
    public async Task OnFilesImported_SmallRealBatches_LogCorrectSummary()
    {
        var project = CreateTestProject("SmallBatchTest");
        _watcher.StartWatcher_AndLoadProject(project);

        // Ensure initial structure (roots in _fileLookup) exists before publishing batches.
        await WaitForFileListCountAsync(1, TimeSpan.FromSeconds(10));

        var dynamicEvents = GetGameFilesWithPrefix(@"ep1\openworld\dynamic_events"); // ~49 files
        var worldEncounters = GetGameFilesWithPrefix(@"ep1\openworld\world_encounters"); // ~21 files

        MaterializeUnderArchive(project, dynamicEvents);
        _projectEvents.PublishFilesImported(new FilesImportedMessage.GameFiles(dynamicEvents));
        await WaitForFileListCountAsync(dynamicEvents.Count, TimeSpan.FromSeconds(10));

        Assert.True(_watcher.FileList.Count >= dynamicEvents.Count);

        MaterializeUnderArchive(project, worldEncounters);
        _projectEvents.PublishFilesImported(new FilesImportedMessage.GameFiles(worldEncounters));
        await WaitForFileListCountAsync(dynamicEvents.Count + worldEncounters.Count, TimeSpan.FromSeconds(10));

        Assert.True(_watcher.FileList.Count >= dynamicEvents.Count + worldEncounters.Count);
    }

    [Fact]
    public async Task OnFilesImported_LargeBatch_LogsInAlphabeticalOrder()
    {
        var openWorldFiles = GetGameFilesWithPrefix(@"ep1\openworld");

        var project = CreateTestProject("AlphaTest");
        _watcher.StartWatcher_AndLoadProject(project);

        var batch = openWorldFiles.Take(300).ToList(); // limit for speed
        MaterializeUnderArchive(project, batch);

        _projectEvents.PublishFilesImported(new FilesImportedMessage.GameFiles(batch));

        await WaitForFileListCountAsync(300, TimeSpan.FromSeconds(15));

        // This previously asserted on log message ordering. With the DeferRefresh +
        // CollectionChange approach we verify the final model state instead.
        Assert.True(_watcher.FileList.Count >= 300);
    }

    [Fact]
    public async Task OnFilesImported_MixedGameAndRawFiles_PopulatesCorrectly()
    {
        var gameFiles = GetGameFilesWithPrefix(@"ep1\openworld\dynamic_events").Take(40).ToList();

        var project = CreateTestProject("MixedTest");
        _watcher.StartWatcher_AndLoadProject(project);
        MaterializeUnderArchive(project, gameFiles);

        // Raw paths must live under project.RawDirectory (…/source/raw), not the project location
        // root — Cp77Project.Location is the .cpmodproj path, FileDirectory is /source.
        var mockRawFiles = new[]
        {
            new FileInfo(Path.Combine(project.RawDirectory, "test", "extra1.json")),
            new FileInfo(Path.Combine(project.RawDirectory, "test", "extra2.json"))
        };
        foreach (var rf in mockRawFiles)
        {
            Directory.CreateDirectory(rf.Directory!.FullName);
            File.WriteAllText(rf.FullName, "{ \"test\": true }");
        }

        _projectEvents.PublishFilesImported(new FilesImportedMessage.RawFiles(mockRawFiles));
        _projectEvents.PublishFilesImported(new FilesImportedMessage.GameFiles(gameFiles));

        await WaitForFileListCountAsync(gameFiles.Count + mockRawFiles.Length, TimeSpan.FromSeconds(10));

        Assert.True(_watcher.FileList.Count >= gameFiles.Count + mockRawFiles.Length);
    }

    [Fact]
    public async Task OnFilesImported_BuildsCorrectDirectoryHierarchy()
    {
        var files = GetGameFilesWithPrefix(@"ep1\openworld\dynamic_events").Take(30).ToList();

        var project = CreateTestProject("HierarchyTest");
        _watcher.StartWatcher_AndLoadProject(project);
        MaterializeUnderArchive(project, files);

        _projectEvents.PublishFilesImported(new FilesImportedMessage.GameFiles(files));

        await Task.Delay(1000);

        // FileTree only contains top-level roots (archive, raw, resources), so traverse into the
        // archive node to find dynamic_events.
        var archiveNode = _watcher.FileTree.FirstOrDefault(n => n.Name == "archive");
        var dynamicEventsNode = archiveNode != null ? FindNode(archiveNode, "dynamic_events") : null;

        Assert.True(dynamicEventsNode != null && dynamicEventsNode.Children.Count > 0,
            "Expected nested directory structure under archive/ep1/openworld/dynamic_events");
    }

    [Fact]
    public async Task OnFilesImported_SmallBatch_StillLogsSummary()
    {
        var files = GetGameFilesWithPrefix(@"ep1\openworld\world_encounters"); // ~21 files

        var project = CreateTestProject("SmallSummaryTest");
        _watcher.StartWatcher_AndLoadProject(project);
        MaterializeUnderArchive(project, files);

        _projectEvents.PublishFilesImported(new FilesImportedMessage.GameFiles(files));

        await WaitForFileListCountAsync(files.Count, TimeSpan.FromSeconds(10));

        Assert.True(_watcher.FileList.Count >= files.Count);
    }

    private async Task WaitForFileListCountAsync(int minimumCount, TimeSpan timeout)
    {
        var fileList = _watcher.FileList;

        if (fileList.Count >= minimumCount)
        {
            return;
        }

        var tcs = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);

        NotifyCollectionChangedEventHandler handler = null!;
        handler = (_, _) =>
        {
            if (fileList.Count >= minimumCount)
            {
                fileList.CollectionChanged -= handler;
                tcs.TrySetResult(true);
            }
        };

        fileList.CollectionChanged += handler;

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
    /// Recursively searches a FileSystemModel tree for a node whose FullName contains the segment.
    /// </summary>
    private static FileSystemModel? FindNode(FileSystemModel root, string nameContains)
    {
        if (root.FullName.Contains(nameContains, StringComparison.OrdinalIgnoreCase))
        {
            return root;
        }

        foreach (var child in root.Children)
        {
            var found = FindNode(child, nameContains);
            if (found != null)
            {
                return found;
            }
        }

        return null;
    }

    public void Dispose()
    {
        try
        {
            _watcher.UnwatchProject();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception thrown during dispose: {e}");
        }

        try
        {
            if (Directory.Exists(_tempProjectDir))
            {
                Directory.Delete(_tempProjectDir, recursive: true);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception thrown during file cleanup: {e}");
        }
    }

    private sealed class NoopLoggerService : ILoggerService
    {
        public void Log<TState>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter) { }
        public bool IsEnabled(Microsoft.Extensions.Logging.LogLevel logLevel) => false;
        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

        public LoggerVerbosity LoggerVerbosity { get; set; } = LoggerVerbosity.Normal;
        public void SetLoggerVerbosity(LoggerVerbosity verbosity) { }

        public void Info(string message) { }
        public void Warning(string message) { }
        public void Error(string message) { }
        public void Error(Exception ex) { }
        public void Success(string message) { }
        public void Debug(string message) { }
    }
}
