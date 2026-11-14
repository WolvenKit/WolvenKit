using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using Moq;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Core.Interfaces;
using Wolvenkit.Test.App.Helpers;
using Xunit;

namespace Wolvenkit.Test.App.ViewModels.Tools;

/// <summary>
/// The Project Explorer file watcher, driven by real file system changes in a temp project
/// (<see href="https://github.com/WolvenKit/WolvenKit/issues/3289">#3289</see>).
///
/// Renames and moves are done with <see cref="Directory.Move"/> / <see cref="File.Move"/>, like
/// Windows Explorer does them: the watcher gets a Renamed event (or Deleted + Created for a move
/// into another folder) and has to bring the tree in line.
/// </summary>
[Collection(ProjectLoadHeartbeatCollection.Name)]
public class ProjectExplorerWatcherTests : IDisposable
{
    private static readonly TimeSpan s_timeout = TimeSpan.FromSeconds(10);

    private readonly string _tempRoot;
    private readonly ProjectExplorerViewModel _pe;
    private readonly Cp77Project _project;

    public ProjectExplorerWatcherTests()
    {
        _tempRoot = Path.Combine(Path.GetTempPath(), "PEWatcherTests_" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_tempRoot);

        _project = CreateProject("WatcherMod");
        Directory.CreateDirectory(Path.Combine(_project.FileDirectory, "archive", "base", "test"));
        Directory.CreateDirectory(Path.Combine(_project.FileDirectory, "archive", "base", "other"));
        File.WriteAllText(Path.Combine(_project.FileDirectory, "archive", "base", "test", "a.json"), "{}");
        File.WriteAllText(Path.Combine(_project.FileDirectory, "archive", "base", "test", "b.json"), "{}");

        _pe = TestProjectExplorer.Create(new ProjectEvents(), new Mock<ILoggerService>().Object);
        _pe.ActiveProject = _project;
        _pe.ResumeFileWatcher();

        Assert.True(WaitUntil(() => HasFile(@"archive\base\test\a.json") && HasFile(@"archive\base\test\b.json")),
            "initial files not in the tree: " + Dump());
    }

    public void Dispose()
    {
        try
        {
            _pe.UnwatchProject(_pe.ActiveProject);
        }
        catch (Exception)
        {
            // already stopped
        }

        TempProjectDirectory.Delete(_tempRoot);
    }

    [Fact]
    public void FolderRenamedOutside_TreeShowsNewNameAndPaths()
    {
        Directory.Move(Archive(@"base\test"), Archive(@"base\test2"));

        Assert.True(WaitUntil(() => HasFile(@"archive\base\test2\a.json") && HasFile(@"archive\base\test2\b.json")),
            "files not under the new folder name: " + Dump());
        Assert.False(_pe.FileList.Any(m => m.RawRelativePath.StartsWith(@"archive\base\test\", StringComparison.OrdinalIgnoreCase)),
            "files still under the old folder name: " + Dump());

        // The nodes point to files that exist.
        Assert.All(_pe.FileList.ToList().Where(m => !m.IsDirectory), m => Assert.True(File.Exists(m.FullName), m.FullName));
    }

    [Fact]
    public void FileRenamedOutside_StaysInTreeWithNewName()
    {
        File.Move(Archive(@"base\test\a.json"), Archive(@"base\test\renamed.json"));

        Assert.True(WaitUntil(() => HasFile(@"archive\base\test\renamed.json") && !HasFile(@"archive\base\test\a.json")),
            "renamed file missing or old name still there: " + Dump());
    }

    [Fact]
    public void FileMovedToAnotherFolderOutside_ShowsUpThere()
    {
        File.Move(Archive(@"base\test\a.json"), Archive(@"base\other\a.json"));

        Assert.True(WaitUntil(() => HasFile(@"archive\base\other\a.json") && !HasFile(@"archive\base\test\a.json")),
            "moved file not at its new place: " + Dump());
    }

    [Fact]
    public void CreateEventForFileThatNeverExists_IsDroppedAfterRetries()
    {
        // A tool wrote a file and removed it before the watcher got to it: the create event
        // points to nothing. It is retried a few times (100 ms apart) and then dropped.
        var onChanged = typeof(ProjectExplorerViewModel).GetMethod("OnChanged", BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.NotNull(onChanged);
        onChanged!.Invoke(_pe, [null, new FileSystemEventArgs(WatcherChangeTypes.Created, _project.FileDirectory, @"archive\base\test\ghost.json")]);

        // 10 retries 100 ms apart take about a second. While an event is retried, the watcher
        // thread keeps taking it out of the queue and putting it back, so the queue is only empty
        // for good once the event was dropped: it has to stay empty, not just be empty once.
        Thread.Sleep(2500);
        Assert.True(StaysTrue(() => PendingFileChanges() == 0, TimeSpan.FromSeconds(1)),
            "the create event keeps coming back to the queue: it is retried forever");
        Assert.False(HasFile(@"archive\base\test\ghost.json"));
    }

    // ---------------- helpers ----------------

    private Cp77Project CreateProject(string name)
    {
        var dir = Path.Combine(_tempRoot, name);
        Directory.CreateDirectory(dir);
        var projectFile = Path.Combine(dir, name + Cp77Project.ProjectFileExtension);
        File.WriteAllText(projectFile, "<!-- test -->");
        var project = new Cp77Project(projectFile, name, name);
        project.CreateDefaultDirectories();
        return project;
    }

    private string Archive(string relativePath) => Path.Combine(_project.FileDirectory, "archive", relativePath);

    private bool HasFile(string rawRelativePath)
    {
        try
        {
            return _pe.FileList.ToList().Any(m => !m.IsDirectory && string.Equals(m.RawRelativePath, rawRelativePath, StringComparison.OrdinalIgnoreCase));
        }
        catch (InvalidOperationException)
        {
            return false; // the watcher thread changed the list while we read it
        }
    }

    private int PendingFileChanges()
    {
        var field = typeof(ProjectExplorerViewModel).GetField("_fileChanges", BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.NotNull(field);
        return ((ICollection)field!.GetValue(_pe)!).Count;
    }

    private string Dump() => string.Join(", ", _pe.FileList.ToList().Select(m => m.RawRelativePath));

    private static bool StaysTrue(Func<bool> condition, TimeSpan duration)
    {
        var until = DateTime.UtcNow + duration;
        while (DateTime.UtcNow < until)
        {
            if (!condition())
            {
                return false;
            }

            Thread.Sleep(5);
        }

        return true;
    }

    private static bool WaitUntil(Func<bool> condition)
    {
        var until = DateTime.UtcNow + s_timeout;
        while (DateTime.UtcNow < until)
        {
            if (condition())
            {
                return true;
            }

            Thread.Sleep(50);
        }

        return condition();
    }
}
