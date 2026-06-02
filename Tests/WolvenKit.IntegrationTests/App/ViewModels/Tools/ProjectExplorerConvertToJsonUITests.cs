using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using DynamicData;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Splat;
using Splat.Microsoft.Extensions.DependencyInjection;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Controllers;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.IntegrationTests.Helpers;
using HandyControl.Tools;
using WolvenKit.App.Models;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;
using Xunit;
using Xunit.Sdk;
using Assert = Xunit.Assert;

namespace WolvenKit.IntegrationTests.App.ViewModels.Tools;

static class Const
{
    public static string BaseDirName = "base";
    public static string AnimationsName = "base\\animations";
    public static string AnimMotionDbName = "base\\animations\\anim_motion_database";
}

public class ProjectExplorerConvertToJsonIntegrationTests : IDisposable
{
    private readonly string _tempProjectRoot;
    private readonly Cp77Project _project;
    private IHost? _host;
    private ProjectExplorerViewModel? _projectExplorerVm;

    public ProjectExplorerConvertToJsonIntegrationTests()
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

    private CancellationTokenSource _cts = new();

    [StaFact]
    public async Task WhenAnimsDbSelectedAssetBrowserRightViewHasRightItems()
    {
        var expectedNumberOfItems = 27;

        _host = IntegrationTestHost.Create();
        var services = _host.Services;
        services.UseMicrosoftDependencyResolver();
        var appViewModel = services.GetRequiredService<AppViewModel>();

        var resolver = Locator.CurrentMutable;
        resolver.InitializeSplat();

        var hashService = services.GetRequiredService<IHashService>();
        hashService.Load();

        var settingsManager = services.GetRequiredService<ISettingsManager>();
        var gameDir = ResolveGameDirectory();
        var exePath = Path.Combine(gameDir, "bin", "x64", "Cyberpunk2077.exe");
        settingsManager.CP77ExecutablePath = exePath;
        var gameControllerFactory = services.GetRequiredService<IGameControllerFactory>();
        var controller = gameControllerFactory.GetRed4Controller();
        Assert.NotNull(controller);

        _projectExplorerVm = appViewModel.GetToolViewModel<ProjectExplorerViewModel>();

        var projectManager = services.GetRequiredService<IProjectManager>();
        await projectManager.LoadAsync(_project.Location);

        Assert.NotNull(_projectExplorerVm.ActiveProject);

        var vm = appViewModel.GetToolViewModel<AssetBrowserViewModel>();
        var progress = services.GetRequiredService<IProgressService<double>>();
        var state = progress.Status;
        await vm.LoadAssetBrowser();

        while (state != EStatus.Ready)
        {
            state = progress.Status;
            await Task.Delay(100);
        }

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

        var rightItems = vm.RightItems;
        Assert.Equal(expectedNumberOfItems, rightItems.Count);

        vm.RightItems.ToList().ForEach(item => item.IsChecked = true);
   }

    private void AddDirs(RedFileSystemModel model,
        AssetBrowserViewModel vm)
    {
        vm.SetLeftSelectedItem(model.Name);
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
            return dir;

        throw new XunitException("CP77_DIR user environment variable must point to a valid Cyberpunk 2077 installation.");
    }

    public void Dispose()
    {
        try
        {
            _host?.Dispose();
            if (Directory.Exists(_tempProjectRoot))
                Directory.Delete(_tempProjectRoot, true);
        }
        catch { /* best effort */ }
    }
}
