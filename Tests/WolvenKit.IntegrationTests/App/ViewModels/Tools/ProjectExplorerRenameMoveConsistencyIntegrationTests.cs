using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DynamicData;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Splat;
using Splat.Microsoft.Extensions.DependencyInjection;
using WolvenKit.App.Controllers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;
using WolvenKit.IntegrationTests.Helpers;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;
using Assert = Xunit.Assert;

namespace WolvenKit.IntegrationTests.App.ViewModels.Tools;

/// <summary>
/// End-to-end consistency test for the rename/move reconciliation pipeline (IProjectEvents ->
/// MainThreadInlineScheduler -> WatcherService -> GridGuard) that the deferred-refresh race exposed.
///
/// Drives a real project + asset browser through: import a file, rename it, rename it back, rename it
/// again, move it to its parent folder, import it again, move the first one back into the child folder,
/// then rename the newer one onto the first one's name (an overwrite). The whole shuffle must collapse to
/// exactly ONE file on disk and ONE file node in the tree.
///
/// Renames and cross-folder moves both go through <see cref="ProjectExplorerViewModel.RenameFileCommand"/>
/// (which calls MoveAndRefactorAsync under the hood); we choose the destination by overriding
/// <see cref="Interactions.RenameAndRefactor"/> per step, and answer the overwrite prompt via
/// <see cref="Interactions.ShowQuestionYesNo"/>.
/// </summary>
public class ProjectExplorerRenameMoveConsistencyIntegrationTests : IDisposable
{
    private readonly string _tempProjectRoot;
    private readonly ITestOutputHelper _output;
    private IHost? _host;
    private ProjectExplorerViewModel? _pe;
    private AssetBrowserViewModel? _ab;

    public ProjectExplorerRenameMoveConsistencyIntegrationTests(ITestOutputHelper output)
    {
        _output = output;
        _tempProjectRoot = Path.Combine(Path.GetTempPath(), "WolvenKit_RenameMoveTest_" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_tempProjectRoot);
    }

    [StaFact]
    public async Task ImportRenameMoveReimportOverwrite_CollapsesToSingleFile_OnDiskAndInTree()
    {
        await LoadANewProject();
        Assert.NotNull(_pe);
        Assert.NotNull(_ab);

        // No real Syncfusion grid in the test: run the deferred-refresh task straight through. The tree we
        // assert on is the GridGuard's FileList, which the WatcherService handlers keep in sync.
        _pe!.BeginDeferredRefreshContext = (task) => task();

        // Always confirm overwrite prompts (the final collision step relies on this).
        Interactions.ShowQuestionYesNo = _ => true;

        // All paths below are GAME-relative (relative to the archive/raw/resources dir, i.e. NO leading
        // "archive\" segment). The rename/move APIs (RenameAndRefactor, MoveAndRefactorAsync) expect
        // game-relative paths; passing raw-relative ones would get double-prefixed into archive\archive\...

        // 1) Import a single file from the asset browser.
        var gameFoo = await ImportOneFileFromAssetBrowser();
        DumpTree("after import #1");
        AssertSingleFile("after first import");

        var childDir = Path.GetDirectoryName(gameFoo)!;   // base\animations\anim_motion_database
        var parentDir = Path.GetDirectoryName(childDir)!; // base\animations
        var ext = Path.GetExtension(gameFoo);
        var gameA = Path.Combine(childDir, "wk_rename_a" + ext);
        var gameB = Path.Combine(childDir, "wk_rename_b" + ext);
        var gameParentB = Path.Combine(parentDir, "wk_rename_b" + ext);

        // 2) rename foo -> A
        await RenameVia(gameFoo, gameA);
        AssertSingleFile("after rename foo->A");

        // 3) rename A -> foo (back)
        await RenameVia(gameA, gameFoo);
        AssertSingleFile("after rename A->foo");

        // 4) rename foo -> B
        await RenameVia(gameFoo, gameB);
        AssertSingleFile("after rename foo->B");

        // 5) move B into the parent directory
        await RenameVia(gameB, gameParentB);
        AssertSingleFile("after move B->parent");

        // 6) import the same file again -> a second file appears at the original child path
        await ImportOneFileFromAssetBrowser();
        DumpTree("after import #2");
        AssertFileCounts("after second import", 2);

        // 7) move the first file back into the child directory (now two distinct names live there)
        await RenameVia(gameParentB, gameB);
        AssertFileCounts("after moving first back to child", 2);

        // 8) rename the newer file onto the first one's name -> overwrite collapses to one file
        await RenameVia(gameFoo, gameB);
        DumpTree("after overwrite rename");
        AssertSingleFile("after final overwrite");
    }

    // ---------------- helpers ----------------

    private async Task RenameVia(string fromGameRel, string toGameRel)
    {
        var model = FindFileModel(fromGameRel);
        Assert.True(model is not null, $"No file node found for game-relative '{fromGameRel}'. Tree:\n{TreeDump()}");

        _pe!.SelectedItem = model;
        // RenameAndRefactor receives/returns a GAME-relative path (see RenameFile); return the destination.
        Interactions.RenameAndRefactor = _ => new Tuple<string, bool>(toGameRel, false);

        await _pe.RenameFileCommand.ExecuteAsync(null);
        PumpDispatcher();
    }

    private FileSystemModel? FindFileModel(string gameRelativePath) =>
        _pe!.FileList.FirstOrDefault(m =>
            !m.IsDirectory && string.Equals(ToGameRel(m.RawRelativePath), gameRelativePath, StringComparison.OrdinalIgnoreCase));

    // Game-relative path = RawRelativePath ("archive\base\...\foo") minus its leading extension segment.
    private static string ToGameRel(string rawRelativePath)
    {
        var sep = rawRelativePath.IndexOf(Path.DirectorySeparatorChar);
        return sep >= 0 ? rawRelativePath[(sep + 1)..] : rawRelativePath;
    }

    private int FilesInTree() => _pe!.FileList.Count(m => !m.IsDirectory);

    private int FilesOnDisk()
    {
        var mod = _pe!.ActiveProject!.ModDirectory;
        return Directory.Exists(mod)
            ? Directory.EnumerateFiles(mod, "*", SearchOption.AllDirectories).Count()
            : 0;
    }

    private void AssertSingleFile(string when) => AssertFileCounts(when, 1);

    private void AssertFileCounts(string when, int expected)
    {
        var onDisk = FilesOnDisk();
        var inTree = FilesInTree();
        Assert.True(expected == onDisk, $"[{when}] expected {expected} file(s) on disk, found {onDisk}.\n{TreeDump()}");
        Assert.True(expected == inTree, $"[{when}] expected {expected} file node(s) in tree, found {inTree}.\n{TreeDump()}");
    }

    private string TreeDump() =>
        "FileList files: " + string.Join(", ",
            _pe!.FileList.Where(m => !m.IsDirectory).Select(m => m.RawRelativePath));

    private void DumpTree(string label) => _output.WriteLine($"{label}: {TreeDump()}");

    /// <summary>
    /// Navigates the asset browser to a folder with real files and imports exactly one of them.
    /// Returns the imported file's GAME-relative path (no leading "archive\" segment).
    /// </summary>
    private async Task<string> ImportOneFileFromAssetBrowser()
    {
        NavigateToAnimMotionDbFolder(_ab!);

        var fileItem = _ab!.RightItems.OfType<RedFileViewModel>().FirstOrDefault();
        Assert.True(fileItem is not null, "Expected at least one file in the anim_motion_database folder.");

        _ab.RightItems.ToList().ForEach(i => i.IsChecked = false);
        fileItem!.IsChecked = true;

        await _ab.AddSelectedAsync();
        PumpDispatcher();

        // The freshly imported file is the child-folder node under anim_motion_database.
        var imported = _pe!.FileList
            .Where(m => !m.IsDirectory && m.RawRelativePath.Contains("anim_motion_database"))
            .OrderByDescending(m => m.RawRelativePath.Length)
            .First();
        return ToGameRel(imported.RawRelativePath);
    }

    // ---------------- asset browser navigation (mirrors ProjectExplorerConvertToJson test) ----------------

    private static class Const
    {
        public const string BaseDirName = "base";
        public const string AnimationsName = "base\\animations";
        public const string AnimMotionDbName = "base\\animations\\anim_motion_database";
    }

    private void NavigateToAnimMotionDbFolder(AssetBrowserViewModel vm)
    {
        var archives = vm._boundRootNodes.First();
        AddDirs(archives, vm);

        var baseDir = vm.LeftItems.First().Directories[Const.BaseDirName];
        AddDirs(baseDir, vm);

        var animations = vm.LeftItems.First()
            .Directories[Const.BaseDirName]
            .Directories[Const.AnimationsName];
        AddDirs(animations, vm);

        var animMotionDb = vm.LeftItems.First()
            .Directories[Const.BaseDirName]
            .Directories[Const.AnimationsName]
            .Directories[Const.AnimMotionDbName];
        AddDirs(animMotionDb, vm);
    }

    private void AddDirs(RedFileSystemModel model, AssetBrowserViewModel vm)
    {
        vm.RightItems.Clear();

        vm.RightItems.AddRange(model.Directories
            .Select(h => new RedDirectoryViewModel(h.Value))
            .OrderBy(el => Regex.Replace(el.Name, @"\d+", n => n.Value.PadLeft(16, '0'))));
        vm.RightItems.AddRange(model.Files
            .Select(h => new RedFileViewModel(h))
            .OrderBy(el => Regex.Replace(el.Name, @"\d+", n => n.Value.PadLeft(16, '0'))));
    }

    // ---------------- host / project bootstrap (mirrors ProjectExplorerConvertToJson test) ----------------

    private static string ResolveGameDirectory()
    {
        var dir = Environment.GetEnvironmentVariable("CP77_DIR", EnvironmentVariableTarget.User);
        if (!string.IsNullOrEmpty(dir) && Directory.Exists(dir))
        {
            return dir;
        }

        throw new XunitException("CP77_DIR user environment variable must point to a valid Cyberpunk 2077 installation.");
    }

    private async Task LoadANewProject()
    {
        _host = IntegrationTestHost.Create();

        var services = _host.Services;
        services.UseMicrosoftDependencyResolver();
        Locator.CurrentMutable.InitializeSplat();

        services.GetRequiredService<IHashService>().Load();

        var gameDir = ResolveGameDirectory();
        var settingsManager = services.GetRequiredService<ISettingsManager>();
        settingsManager.CP77ExecutablePath = Path.Combine(gameDir, "bin", "x64", "Cyberpunk2077.exe");

        var appViewModel = services.GetRequiredService<AppViewModel>();

        var controller = services.GetRequiredService<IGameControllerFactory>().GetRed4Controller();
        Assert.NotNull(controller);

        var projectManager = services.GetRequiredService<IProjectManager>();

        _pe = appViewModel.GetToolViewModel<ProjectExplorerViewModel>();
        _ab = _host.Services.GetRequiredService<AssetBrowserViewModel>();

        var projectWizard = services.GetRequiredService<ProjectWizardViewModel>();
        projectWizard.Author = "FF:06:B5";
        projectWizard.ModName = "Cyberpunk2077";
        projectWizard.ProjectName = "RenameMoveConsistency";
        projectWizard.ProjectPath = _tempProjectRoot;
        await appViewModel.NewProjectTask(projectWizard);

        Assert.NotNull(projectManager.ActiveProject);
        Assert.NotNull(_pe!.ActiveProject);

        var progress = _host.Services.GetRequiredService<IProgressService<double>>();
        var state = progress.Status;
        while (state != EStatus.Ready)
        {
            state = progress.Status;
            await Task.Delay(100);
        }
    }

    private static void PumpDispatcher()
    {
        try
        {
            System.Windows.Application.Current?.Dispatcher?.Invoke(
                () => { }, System.Windows.Threading.DispatcherPriority.ContextIdle);
        }
        catch { /* best effort in test env */ }
    }

    public void Dispose()
    {
        try
        {
            _host?.Dispose();
            if (Directory.Exists(_tempProjectRoot))
            {
                Directory.Delete(_tempProjectRoot, true);
            }
        }
        catch { /* best effort */ }
    }
}
