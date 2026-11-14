using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
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
/// Saving the Project Explorer folder expansion state
/// (<see href="https://github.com/WolvenKit/WolvenKit/issues/3291">#3291</see>).
/// </summary>
[Collection(ProjectLoadHeartbeatCollection.Name)]
public class ProjectExplorerExpansionStateTests : IDisposable
{
    private static readonly TimeSpan s_timeout = TimeSpan.FromSeconds(10);

    private readonly string _tempRoot;
    private readonly ProjectExplorerViewModel _pe;
    private readonly Cp77Project _project;

    public ProjectExplorerExpansionStateTests()
    {
        _tempRoot = Path.Combine(Path.GetTempPath(), "PEExpansionStateTests_" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_tempRoot);

        _project = CreateProject("ExpansionMod");
        Directory.CreateDirectory(Path.Combine(_project.FileDirectory, "archive", "base", "test"));
        File.WriteAllText(Path.Combine(_project.FileDirectory, "archive", "base", "test", "a.json"), "{}");

        _pe = TestProjectExplorer.Create(new ProjectEvents(), new Mock<ILoggerService>().Object);
        _pe.ActiveProject = _project;
    }

    public void Dispose()
    {
        try
        {
            _pe.UnwatchProject(_pe.ActiveProject);
        }
        catch (Exception)
        {
            // the watcher may never have been started
        }

        TempProjectDirectory.Delete(_tempRoot);
    }

    [Fact]
    public void LockedTreeStateFile_SaveDoesNotThrow_AndIsRetried()
    {
        var statePath = _project.InterfaceProjectTreeStatePath;
        Directory.CreateDirectory(Path.GetDirectoryName(statePath)!);
        File.WriteAllText(statePath, "{}");

        _pe.SaveNodeExpansionState(@"archive\base", true);

        // Locked by another process (OneDrive, antivirus...): the autosave must not throw.
        using (new FileStream(statePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
        {
            var exception = Record.Exception(SaveIfDirty);
            Assert.Null(exception);
        }

        // Once the file is free again, the state that couldn't be written is still saved.
        SaveIfDirty();
        Assert.True(ReadState().TryGetValue(@"archive\base", out var expanded) && expanded,
            "state not saved after the lock was released: " + File.ReadAllText(statePath));
    }

    [Fact]
    public void FolderExpandedForANewFile_IsSaved()
    {
        _pe.ResumeFileWatcher();
        Assert.True(WaitUntil(() => HasFile(@"archive\base\test\a.json")), "initial file not in the tree");

        // A new file in a new folder: its parents are expanded so the file is visible...
        Directory.CreateDirectory(Path.Combine(_project.FileDirectory, "archive", "base", "newdir"));
        File.WriteAllText(Path.Combine(_project.FileDirectory, "archive", "base", "newdir", "c.json"), "{}");
        Assert.True(WaitUntil(() => HasFile(@"archive\base\newdir\c.json")), "new file not in the tree");

        // ...and that expansion must be saved, not only kept in memory.
        SaveIfDirty();
        var state = ReadState();
        Assert.True(state.TryGetValue(@"archive\base\newdir", out var expanded) && expanded,
            "the auto-expanded folder is not in the saved state: " + string.Join(", ", state.Keys));
    }

    // ---------------- helpers ----------------

    /// <summary>The 10 s autosave / on-close save of the view model.</summary>
    private void SaveIfDirty()
    {
        var save = typeof(ProjectExplorerViewModel).GetMethod(
            "SaveProjectExplorerExpansionStateIfDirty",
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
            Type.EmptyTypes);
        Assert.NotNull(save);

        try
        {
            save!.Invoke(_pe, null);
        }
        catch (TargetInvocationException e) when (e.InnerException is not null)
        {
            throw e.InnerException;
        }
    }

    private Dictionary<string, bool> ReadState()
    {
        var statePath = _project.InterfaceProjectTreeStatePath;
        Assert.True(File.Exists(statePath), "no tree state file was written");
        return JsonSerializer.Deserialize<Dictionary<string, bool>>(File.ReadAllText(statePath)) ?? [];
    }

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
