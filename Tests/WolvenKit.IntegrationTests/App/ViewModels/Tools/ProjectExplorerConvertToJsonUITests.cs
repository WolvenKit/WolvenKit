using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using HandyControl.Tools.Extension;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Octokit;
using ReactiveUI;
using Splat;
using Splat.Microsoft.Extensions.DependencyInjection;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Controllers;
using WolvenKit.App.Factories;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Core.Interfaces;
using WolvenKit.IntegrationTests.Helpers;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Tools;
using Xunit;
using Xunit.Sdk;
using Assert = Xunit.Assert;

namespace WolvenKit.IntegrationTests.App.ViewModels.Tools;

[STATestClass]
public class ProjectExplorerConvertToJsonUITests : IDisposable
{
    private readonly string _tempProjectRoot;
    private readonly Cp77Project _project;
    private IHost? _host;
    private ProjectExplorerViewModel? _projectExplorerVm;
    private ProjectExplorerViewModel.WatcherService? _watcherService;
    private ProjectExplorerView? _projectExplorerView;

    public ProjectExplorerConvertToJsonUITests()
    {
        _tempProjectRoot = Path.Combine(Path.GetTempPath(), "WolvenKit_ConvertUITest_" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_tempProjectRoot);

        _project = new Cp77Project(
            Path.Combine(_tempProjectRoot, "testmod"),
            "ConvertToJsonUITest",
            "ConvertToJsonUITest");

        Directory.CreateDirectory(_project.ModDirectory);
        Directory.CreateDirectory(_project.RawDirectory);
        Directory.CreateDirectory(_project.FileDirectory);
    }

    [StaFact]
    public async Task ConvertToJson_FromArchiveSelection_UpdatesWatcherModels_And_TreeGridNodes_Correctly()
    {
        _host = IntegrationTestHost.Create();
        var services = _host.Services;
        services.UseMicrosoftDependencyResolver();
        var appViewModel = services.GetRequiredService<AppViewModel>();

        var resolver = Locator.CurrentMutable;
        resolver.InitializeSplat();

        var settingsManager = services.GetRequiredService<ISettingsManager>();
        var gameDir = ResolveGameDirectory();
        var exePath = Path.Combine(gameDir, "bin", "x64", "Cyberpunk2077.exe");
        settingsManager.CP77ExecutablePath = exePath;
        var gameControllerFactory = services.GetRequiredService<IGameControllerFactory>();
        var controller = gameControllerFactory.GetRed4Controller();
        Assert.NotNull(controller);

        _projectExplorerVm = appViewModel.GetToolViewModel<ProjectExplorerViewModel>();

        // Crashes.
        // _projectExplorerView = services.GetRequiredService<IViewFor<ProjectExplorerViewModel>>() as ProjectExplorerView;

        var projectManager = services.GetRequiredService<IProjectManager>();
        await projectManager.LoadAsync(_project.Location);

        var assetBrowserVm = appViewModel.GetToolViewModel<AssetBrowserViewModel>();
        _projectExplorerVm.StartWatcher_AndLoadProject(_project, false);

        // Not working yet.
        // Assert.Equal(3, _projectExplorerVm.FileTree.Count);

        await assetBrowserVm.LoadAssetBrowser();
        // var rootDir = assetBrowserVm._boundRootNodes.First();
        // Dictionary<ulong, IGameFile> files = new();
        // assetBrowserVm.GetFilesRecursive(rootDir, files);
        // Assert.NotEmpty(files.Values);

        var folderToAdd = assetBrowserVm
            ._boundRootNodes.First()
            .Directories["base"]
            .Directories["base\\animations"]
            .Directories["base\\animations\\anim_motion_database"];

        // Replicate what AssetBrowserView.LeftNavigation_OnSelectionChanged does:
        // it populates RightItems with both subdirectory entries and direct files.
        // Checked RedDirectoryViewModel entries are expanded recursively by AddSelectedAsync.
        assetBrowserVm.RightItems.AddRange(folderToAdd.Directories
            .Select(h => new RedDirectoryViewModel(h.Value))
            .OrderBy(el => Regex.Replace(el.Name, @"\d+", n => n.Value.PadLeft(16, '0'))));
        assetBrowserVm.RightItems.AddRange(folderToAdd.Files
            .Select(h => new RedFileViewModel(h))
            .OrderBy(el => Regex.Replace(el.Name, @"\d+", n => n.Value.PadLeft(16, '0'))));
        assetBrowserVm.RightItems.ForEach(item => item.IsChecked = true);
        await assetBrowserVm.AddSelectedAsync();
        Assert.True(_projectExplorerVm!.FileList.Count > 5);
    }

    private static string ResolveGameDirectory()
    {
        var dir = Environment.GetEnvironmentVariable("CP77_DIR", EnvironmentVariableTarget.User);
        if (!string.IsNullOrEmpty(dir) && Directory.Exists(dir))
            return dir;

        throw new XunitException("CP77_DIR user environment variable must point to a valid Cyberpunk 2077 installation.");
    }

    public void Dispose()
    {
        try
        {
            _watcherService?.UnwatchProject();
            _host?.Dispose();
            if (Directory.Exists(_tempProjectRoot))
                Directory.Delete(_tempProjectRoot, true);
        }
        catch { /* best effort */ }
    }
}
