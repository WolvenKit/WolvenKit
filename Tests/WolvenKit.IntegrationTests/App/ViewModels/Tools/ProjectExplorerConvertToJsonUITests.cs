using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
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
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;
using Xunit;
using Xunit.Abstractions;
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
    private readonly ITestOutputHelper _output;
    private readonly string _tempProjectRoot;
    private readonly Cp77Project _project;
    private IHost? _host;
    private ProjectExplorerViewModel? _projectExplorerVm;

    public ProjectExplorerConvertToJsonIntegrationTests()
    {
        _tempProjectRoot = Path.Combine(Path.GetTempPath(), "WolvenKit_ConvertUITest_" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_tempProjectRoot);
    }

    private CancellationTokenSource _cts = new();

    [StaFact]
    public async Task WhenAnimsDbSelectedAssetBrowserRightViewHasRightItems()
    {
        var expectedNumberOfItems = 27;
        var numberOfFolders = 5;

        // Setup Host
        _host = IntegrationTestHost.Create();

        // Setup Services
        var services = _host.Services;
        services.UseMicrosoftDependencyResolver();

        // Setup DI Resolver
        var resolver = Locator.CurrentMutable;
        resolver.InitializeSplat();

        // Setup Hash Services (needed for archives to load properly)
        var hashService = services.GetRequiredService<IHashService>();
        hashService.Load();

        // Setup the Settings Manager & Game Directory
        var gameDir = ResolveGameDirectory();
        var settingsManager = services.GetRequiredService<ISettingsManager>();
        var exePath = Path.Combine(gameDir, "bin", "x64", "Cyberpunk2077.exe");
        settingsManager.CP77ExecutablePath = exePath;

        // Grab the App View Model
        var appViewModel = services.GetRequiredService<AppViewModel>();

        // Grab the GameController
        var gameControllerFactory = services.GetRequiredService<IGameControllerFactory>();
        var controller = gameControllerFactory.GetRed4Controller();
        Assert.NotNull(controller);

        // Grab the Project Manager
        var projectManager = services.GetRequiredService<IProjectManager>();

        // Grab the Project Explorer
        _projectExplorerVm = appViewModel.GetToolViewModel<ProjectExplorerViewModel>();

        // Create a new Project & Add it to AppViewModel
        var projectWizard = services.GetRequiredService<ProjectWizardViewModel>();
        projectWizard.Author = "FF:06:B5";
        projectWizard.ModName = "Cyberpunk2077";
        projectWizard.ProjectName = "Make Misty Hot";
        projectWizard.ProjectPath = _tempProjectRoot;
        await appViewModel.NewProjectTask(projectWizard);

        // Verify the project propagated to the right places
        Assert.NotNull(projectManager.ActiveProject);
        Assert.NotNull(_projectExplorerVm.ActiveProject);

        // Grab the AssetBrowserViewModel
        var vm = appViewModel.GetToolViewModel<AssetBrowserViewModel>();

        // Grab the ProgressService
        var progress = services.GetRequiredService<IProgressService<double>>();
        var state = progress.Status;

        // Wait until the Archives have loaded
        while (state != EStatus.Ready)
        {
            state = progress.Status;
            await Task.Delay(100);
        }

        // Grab the Archives and add them to the AssetBrowser
        var archives = vm._boundRootNodes.First();
        AddDirs(archives, vm);

        // Navigate to the anim_motion_db folder
        NavigateToAnimMotionDbFolder(vm);

        // Verify the correct number of items are in the RightItems
        Assert.Equal(expectedNumberOfItems, vm.RightItems.Count);

        // Set all the RightItems to Checked so they can be added to ProjectManager
        vm.RightItems.ToList().ForEach(item => item.IsChecked = true);

        // Add the files to the mod project
        await vm.AddSelectedAsync();

        Assert.Equal(expectedNumberOfItems, _projectExplorerVm.FileList.Count - numberOfFolders);
    }

    private void NavigateToAnimMotionDbFolder(AssetBrowserViewModel vm)
    {
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

    private void AddDirs(RedFileSystemModel model,
        AssetBrowserViewModel vm)
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
