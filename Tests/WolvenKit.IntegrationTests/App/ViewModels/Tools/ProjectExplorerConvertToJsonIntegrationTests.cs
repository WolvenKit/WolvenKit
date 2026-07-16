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
    public static string GameplayName = "base\\gameplay";
    public static string DevicesName = "base\\gameplay\\devices";
}

public class ProjectExplorerConvertToJsonIntegrationTests : IDisposable
{
    private readonly string _tempProjectRoot;
    private IHost? _host;
    private ProjectExplorerViewModel? _projectExplorerVm;

    public ProjectExplorerConvertToJsonIntegrationTests()
    {
        _tempProjectRoot = Path.Combine(Path.GetTempPath(), "WolvenKit_ConvertUITest_" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_tempProjectRoot);
    }

    [StaFact]
    public async Task WhenAnimsDbSelectedAssetBrowserRightViewHasRightItems()
    {
        await LoadANewProject();

        var expectedNumberOfItems = 27;
        var numberOfFolders = 6;

        Assert.NotNull(_host);

        var vm = _host.Services.GetRequiredService<AssetBrowserViewModel>();

        // Grab the Archives and add them to the AssetBrowser
        var archives = vm._boundRootNodes.First();
        AddDirs(archives, vm);

        // Navigate to the anim_motion_db folder
        NavigateToAnimMotionDbFolder(vm);

        // Verify the correct number of items are in the RightItems
        Assert.Equal(expectedNumberOfItems, vm.RightItems.Count);

        await AddRightItemsToProject(vm);

        // Pump dispatcher to ensure any posted projections (ProjectAdd via import publish) have landed
        // in the GridGuard's FileList before we assert counts (shim isolation + ObserveOn + dispatch can queue).
        PumpDispatcher();

        Assert.Equal(expectedNumberOfItems, _projectExplorerVm.FileList.Count - numberOfFolders);
    }

    [StaFact]
    public async Task WhenFirstFileOfManyIsConvertedToJsonThenItAppearsInFlatFileList()
    {
        await LoadANewProject();

        Assert.NotNull(_host);

        var assetBrowser = _host.Services.GetRequiredService<AssetBrowserViewModel>();

        NavigateToDevicesFolder(assetBrowser);
        await AddRightItemsToProject(assetBrowser);

        Assert.NotNull(_projectExplorerVm);
        Assert.True(_projectExplorerVm.FileList.Count > 3600);

        _projectExplorerVm.IsFlatModeEnabled = true;
        var list = _projectExplorerVm.FileList.Where(model => !model.IsDirectory).ToList();
            ;
        list.Sort(Comparison);
        var priorCount = list.Count;

        Assert.NotNull(_projectExplorerVm.SelectedItems);

        _projectExplorerVm.SelectedItems.Add(list.First());
        await _projectExplorerVm.ConvertArchiveFile();
        PumpDispatcher();
        list = _projectExplorerVm.FileList.Where(model => !model.IsDirectory).ToList();

        var count = list.Count;
        Assert.True(count - priorCount == 1);
    }

    private int Comparison(FileSystemModel x, FileSystemModel y)
        => string.Compare(x.GameRelativePath, y.GameRelativePath, StringComparison.Ordinal);

    private async Task AddRightItemsToProject(AssetBrowserViewModel vm)
    {
        // Set all the RightItems to Checked so they can be added to ProjectManager
        vm.RightItems.ToList().ForEach(item => item.IsChecked = true);

        // Add the files to the mod project
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

    private void NavigateToDevicesFolder(AssetBrowserViewModel vm)
    {
        NavigateToBaseDir(vm);

        var gameplay = vm.LeftItems.First()
            .Directories[Const.BaseDirName]
            .Directories[Const.GameplayName];
        AddDirs(gameplay, vm);

        var devices = vm.LeftItems.First()
            .Directories[Const.BaseDirName]
            .Directories[Const.GameplayName]
            .Directories[Const.DevicesName];
        AddDirs(devices, vm);
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

    private static void PumpDispatcher()
    {
        try
        {
            var disp = System.Windows.Application.Current?.Dispatcher;
            disp?.Invoke(() => { }, System.Windows.Threading.DispatcherPriority.ContextIdle);
        }
        catch { /* best effort in test env */ }
    }

    private async Task LoadANewProject()
    {
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

        // Grab the ProgressService
        var progress = _host?.Services.GetRequiredService<IProgressService<double>>();

        Assert.NotNull(progress);

        var state = progress.Status;

        // Wait until the Archives have loaded
        while (state != EStatus.Ready)
        {
            state = progress.Status;
            await Task.Delay(100);
        }
    }
}
