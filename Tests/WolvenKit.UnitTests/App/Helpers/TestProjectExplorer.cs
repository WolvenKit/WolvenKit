using System.Runtime.CompilerServices;
using Moq;
using WolvenKit.App.Controllers;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Modkit.RED4;

namespace Wolvenkit.Test.App.Helpers;

/// <summary>
/// Builds a <see cref="ProjectExplorerViewModel"/> backed by mocks.
///
/// The file watching logic lives on the view model itself, so tests that exercise it have to
/// construct one. Everything the watcher needs is created here; the heavy collaborators that it
/// never touches are uninitialized instances, which keeps the DI graph out of unit tests.
/// </summary>
public static class TestProjectExplorer
{
    public static ProjectExplorerViewModel Create(
        IProjectEvents projectEvents,
        ILoggerService? logger = null,
        IProjectManager? projectManager = null,
        IProgressService<double>? progress = null,
        AppViewModel? appViewModel = null)
    {
        return new ProjectExplorerViewModel(
            appViewModel ?? (AppViewModel)RuntimeHelpers.GetUninitializedObject(typeof(AppViewModel)),
            projectManager ?? new Mock<IProjectManager>().Object,
            logger ?? new Mock<ILoggerService>().Object,
            new Mock<INotificationService>().Object,
            progress ?? new Mock<IProgressService<double>>().Object,
            new Mock<IModTools>().Object,
            new Mock<IGameControllerFactory>().Object,
            new Mock<IPluginService>().Object,
            new Mock<ISettingsManager>().Object,
            new Mock<IModifierViewStateService>().Object,
            new Mock<IArchiveManager>().Object,
            (ProjectResourceTools)RuntimeHelpers.GetUninitializedObject(typeof(ProjectResourceTools)),
            (ImportExportHelper)RuntimeHelpers.GetUninitializedObject(typeof(ImportExportHelper)),
            projectEvents);
    }
}
