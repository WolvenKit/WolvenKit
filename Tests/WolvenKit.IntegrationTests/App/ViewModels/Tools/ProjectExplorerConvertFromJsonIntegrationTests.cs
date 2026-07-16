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
using WolvenKit.App.Models;
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
using Xunit.Sdk;
using Assert = Xunit.Assert;

namespace WolvenKit.IntegrationTests.App.ViewModels.Tools;

/// <summary>
/// Integration tests for Project Explorer convert-from-JSON (raw -> archive), pairing with
/// <see cref="ProjectExplorerConvertToJsonIntegrationTests"/>.
/// Round-trips real game files: convert archive -> JSON, then JSON -> archive.
/// Requires CP77_DIR (user env) pointing at a Cyberpunk 2077 install.
/// </summary>
public class ProjectExplorerConvertFromJsonIntegrationTests : IDisposable
{
    private readonly string _tempProjectRoot;
    private IHost? _host;
    private ProjectExplorerViewModel? _projectExplorerVm;

    public ProjectExplorerConvertFromJsonIntegrationTests()
    {
        _tempProjectRoot = Path.Combine(Path.GetTempPath(), "WolvenKit_ConvertFromJsonUITest_" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_tempProjectRoot);
    }

    [StaFact]
    public async Task WhenFirstFileRoundTrippedThroughJson_ThenArchiveFileStillExists()
    {
        await LoadANewProject();
        Assert.NotNull(_host);
        Assert.NotNull(_projectExplorerVm);

        var assetBrowser = _host.Services.GetRequiredService<AssetBrowserViewModel>();
        NavigateToAnimMotionDbFolder(assetBrowser);
        await AddRightItemsToProject(assetBrowser);
        PumpDispatcher();

        _projectExplorerVm.IsFlatModeEnabled = true;

        var archiveFile = GetArchiveFilesOrdered().FirstOrDefault();
        Assert.NotNull(archiveFile);

        var archivePath = archiveFile.FullName;
        Assert.True(File.Exists(archivePath));

        // archive -> json
        _projectExplorerVm.SelectedItems!.Clear();
        _projectExplorerVm.SelectedItems.Add(archiveFile);
        await _projectExplorerVm.ConvertArchiveFile();
        PumpDispatcher();

        var jsonPath = GetExpectedJsonPath(archivePath);
        Assert.True(File.Exists(jsonPath), $"Expected JSON at {jsonPath}");

        var jsonModel = FindFileModel(jsonPath);
        Assert.NotNull(jsonModel);

        // json -> archive (overwrite existing)
        _projectExplorerVm.SelectedItems.Clear();
        _projectExplorerVm.SelectedItems.Add(jsonModel);
        await _projectExplorerVm.ConvertRawFile();
        PumpDispatcher();

        Assert.True(File.Exists(archivePath), "Archive file should still exist after convert-from-json overwrite.");
        Assert.True(new FileInfo(archivePath).Length > 0);
        Assert.True(File.Exists(jsonPath), "Source JSON should remain after convert-from-json.");
    }

    [StaFact]
    public async Task WhenJsonConvertedAfterArchiveDeleted_ThenArchiveFileIsRestored()
    {
        await LoadANewProject();
        Assert.NotNull(_host);
        Assert.NotNull(_projectExplorerVm);

        var assetBrowser = _host.Services.GetRequiredService<AssetBrowserViewModel>();
        NavigateToAnimMotionDbFolder(assetBrowser);
        await AddRightItemsToProject(assetBrowser);
        PumpDispatcher();

        _projectExplorerVm.IsFlatModeEnabled = true;

        var archiveFile = GetArchiveFilesOrdered().FirstOrDefault();
        Assert.NotNull(archiveFile);

        var archivePath = archiveFile.FullName;

        _projectExplorerVm.SelectedItems!.Clear();
        _projectExplorerVm.SelectedItems.Add(archiveFile);
        await _projectExplorerVm.ConvertArchiveFile();
        PumpDispatcher();

        var jsonPath = GetExpectedJsonPath(archivePath);
        Assert.True(File.Exists(jsonPath));

        var jsonModel = FindFileModel(jsonPath);
        Assert.NotNull(jsonModel);

        File.Delete(archivePath);
        Assert.False(File.Exists(archivePath));
        PumpDispatcher();

        _projectExplorerVm.SelectedItems.Clear();
        _projectExplorerVm.SelectedItems.Add(jsonModel);
        await _projectExplorerVm.ConvertRawFile();
        PumpDispatcher();

        Assert.True(File.Exists(archivePath), "Convert-from-json should recreate the deleted archive file.");
        Assert.True(new FileInfo(archivePath).Length > 0);

        // Restored file should be visible in the project explorer file list.
        var restored = FindFileModel(archivePath);
        Assert.NotNull(restored);
    }

    [StaFact]
    public async Task WhenMultipleFilesRoundTrippedThroughJson_ThenAllArchivesAreRestored()
    {
        await LoadANewProject();
        Assert.NotNull(_host);
        Assert.NotNull(_projectExplorerVm);

        var assetBrowser = _host.Services.GetRequiredService<AssetBrowserViewModel>();
        NavigateToAnimMotionDbFolder(assetBrowser);
        await AddRightItemsToProject(assetBrowser);
        PumpDispatcher();

        _projectExplorerVm.IsFlatModeEnabled = true;

        // Take a small batch from anim_motion_database (folder is small and early in the archive tree).
        var archiveFiles = GetArchiveFilesOrdered().Take(5).ToList();
        Assert.True(archiveFiles.Count >= 1, "Expected at least one archive file from anim_motion_database.");

        var archivePaths = archiveFiles.Select(f => f.FullName).ToList();

        // Convert all selected archive files to JSON.
        _projectExplorerVm.SelectedItems!.Clear();
        foreach (var file in archiveFiles)
        {
            _projectExplorerVm.SelectedItems.Add(file);
        }

        await _projectExplorerVm.ConvertArchiveFile();
        PumpDispatcher();

        var jsonPaths = archivePaths.Select(GetExpectedJsonPath).ToList();
        foreach (var jsonPath in jsonPaths)
        {
            Assert.True(File.Exists(jsonPath), $"Expected JSON at {jsonPath}");
        }

        // Delete originals so convert-from-json must recreate them.
        foreach (var archivePath in archivePaths)
        {
            File.Delete(archivePath);
            Assert.False(File.Exists(archivePath));
        }

        PumpDispatcher();

        var jsonModels = jsonPaths.Select(FindFileModel).ToList();
        Assert.All(jsonModels, m => Assert.NotNull(m));

        _projectExplorerVm.SelectedItems.Clear();
        foreach (var model in jsonModels)
        {
            _projectExplorerVm.SelectedItems.Add(model!);
        }

        await _projectExplorerVm.ConvertRawFile();
        PumpDispatcher();

        foreach (var archivePath in archivePaths)
        {
            Assert.True(File.Exists(archivePath), $"Expected restored archive at {archivePath}");
            Assert.True(new FileInfo(archivePath).Length > 0);
        }
    }

    private string GetExpectedJsonPath(string archiveFullPath)
    {
        Assert.NotNull(_projectExplorerVm?.ActiveProject);
        return Path.Combine(
                   _projectExplorerVm.ActiveProject.RawDirectory,
                   _projectExplorerVm.ActiveProject.GetGameRelativePath(archiveFullPath))
               + ".json";
    }

    private FileSystemModel? FindFileModel(string fullPath) =>
        _projectExplorerVm!.FileList.FirstOrDefault(m =>
            !m.IsDirectory && m.FullName.Equals(fullPath, StringComparison.OrdinalIgnoreCase));

    private System.Collections.Generic.List<FileSystemModel> GetArchiveFilesOrdered()
    {
        Assert.NotNull(_projectExplorerVm?.ActiveProject);
        var modDir = _projectExplorerVm.ActiveProject.ModDirectory;

        return _projectExplorerVm.FileList
            .Where(m => !m.IsDirectory
                        && m.FullName.StartsWith(modDir, StringComparison.OrdinalIgnoreCase))
            .OrderBy(m => m.GameRelativePath, StringComparer.Ordinal)
            .ToList();
    }

    private async Task AddRightItemsToProject(AssetBrowserViewModel vm)
    {
        vm.RightItems.ToList().ForEach(item => item.IsChecked = true);
        await vm.AddSelectedAsync();
    }

    private void NavigateToBaseDir(AssetBrowserViewModel vm)
    {
        var archives = vm._boundRootNodes.First();
        AddDirs(archives, vm);

        var baseDir = vm.LeftItems.First().Directories[Const.BaseDirName];
        AddDirs(baseDir, vm);
    }

    private void NavigateToAnimMotionDbFolder(AssetBrowserViewModel vm)
    {
        NavigateToBaseDir(vm);

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

    private static string ResolveGameDirectory()
    {
        var dir = Environment.GetEnvironmentVariable("CP77_DIR", EnvironmentVariableTarget.User);
        if (!string.IsNullOrEmpty(dir) && Directory.Exists(dir))
        {
            return dir;
        }

        throw new XunitException("CP77_DIR user environment variable must point to a valid Cyberpunk 2077 installation.");
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
        catch
        {
            /* best effort */
        }
    }

    private static void PumpDispatcher()
    {
        try
        {
            var disp = System.Windows.Application.Current?.Dispatcher;
            disp?.Invoke(() => { }, System.Windows.Threading.DispatcherPriority.ContextIdle);
        }
        catch
        {
            /* best effort in test env */
        }
    }

    private async Task LoadANewProject()
    {
        _host = IntegrationTestHost.Create();

        var services = _host.Services;
        services.UseMicrosoftDependencyResolver();

        var resolver = Locator.CurrentMutable;
        resolver.InitializeSplat();

        var hashService = services.GetRequiredService<IHashService>();
        hashService.Load();

        var gameDir = ResolveGameDirectory();
        var settingsManager = services.GetRequiredService<ISettingsManager>();
        var exePath = Path.Combine(gameDir, "bin", "x64", "Cyberpunk2077.exe");
        settingsManager.CP77ExecutablePath = exePath;

        var appViewModel = services.GetRequiredService<AppViewModel>();

        var gameControllerFactory = services.GetRequiredService<IGameControllerFactory>();
        var controller = gameControllerFactory.GetRed4Controller();
        Assert.NotNull(controller);

        var projectManager = services.GetRequiredService<IProjectManager>();

        _projectExplorerVm = appViewModel.GetToolViewModel<ProjectExplorerViewModel>();

        var projectWizard = services.GetRequiredService<ProjectWizardViewModel>();
        projectWizard.Author = "FF:06:B5";
        projectWizard.ModName = "Cyberpunk2077";
        projectWizard.ProjectName = "ConvertFromJsonRoundtrip";
        projectWizard.ProjectPath = _tempProjectRoot;
        await appViewModel.NewProjectTask(projectWizard);

        Assert.NotNull(projectManager.ActiveProject);
        Assert.NotNull(_projectExplorerVm.ActiveProject);

        var progress = _host.Services.GetRequiredService<IProgressService<double>>();
        var state = progress.Status;

        while (state != EStatus.Ready)
        {
            state = progress.Status;
            await Task.Delay(100);
        }
    }
}
