using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Moq;
using WolvenKit.App.Controllers;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.Core.Services;
using Wolvenkit.Test.App.Helpers;
using Xunit;

namespace Wolvenkit.Test.App.Controllers;

/// <summary>
/// Covers the RED4Controller archive-loading heartbeat.
///
/// RED4Controller is registered transient, so the app view model, asset browser and materials
/// dialog each own an instance and can load archives concurrently. These tests pin the sharing
/// contract between those instances, which the previous depth-counter implementation got wrong.
///
/// Every scope is held with <c>using</c> so a failed assertion cannot leak a claim on the shared
/// purpose into the next test in this collection.
/// </summary>
[Collection(ArchiveLoadHeartbeatCollection.Name)]
public class Red4ControllerLoadingModeTests
{
    private const string Purpose = IArchiveManagerLoader.ArchiveLoadingPurpose;

    [Fact]
    public void BeginLoadingIndicator_ArmsHeartbeat_AndReleasesOnDispose()
    {
        var controller = CreateUninitializedController(out var progress);

        using (var scope = BeginLoadingIndicator(controller))
        {
            Assert.True(DispatcherHelper.IsRepeatingActionRunning(Purpose));
        }

        Assert.False(DispatcherHelper.IsRepeatingActionRunning(Purpose));
        Assert.Equal(EStatus.Ready, progress.Object.Status);
        Assert.False(progress.Object.IsIndeterminate);
    }

    [Fact]
    public void BeginLoadingIndicator_NestedOnSameController_StaysArmedUntilOuterScopeCloses()
    {
        var controller = CreateUninitializedController(out _);

        using var outer = BeginLoadingIndicator(controller);
        using (var inner = BeginLoadingIndicator(controller))
        {
            Assert.Equal(2, DispatcherHelper.GetRepeatingActionRefCount(Purpose));
        }

        Assert.True(DispatcherHelper.IsRepeatingActionRunning(Purpose));
        Assert.Equal(1, DispatcherHelper.GetRepeatingActionRefCount(Purpose));
    }

    [Fact]
    public void BeginLoadingIndicator_SecondControllerFinishingFirst_DoesNotStopTheFirstControllersHeartbeat()
    {
        var first = CreateUninitializedController(out var firstProgress);
        var second = CreateUninitializedController(out _);

        using (var firstScope = BeginLoadingIndicator(first))
        {
            using (var secondScope = BeginLoadingIndicator(second))
            {
                Assert.Equal(2, DispatcherHelper.GetRepeatingActionRefCount(Purpose));
            }

            Assert.True(DispatcherHelper.IsRepeatingActionRunning(Purpose));
            Assert.NotEqual(EStatus.Ready, firstProgress.Object.Status);
        }

        Assert.False(DispatcherHelper.IsRepeatingActionRunning(Purpose));
        Assert.Equal(EStatus.Ready, firstProgress.Object.Status);
    }

    [Fact]
    public void BeginLoadingIndicator_ScopeDisposeIsIdempotent()
    {
        var controller = CreateUninitializedController(out _);

        using var scope = BeginLoadingIndicator(controller);
        scope.Dispose();
        scope.Dispose();

        Assert.False(DispatcherHelper.IsRepeatingActionRunning(Purpose));
        Assert.Equal(0, DispatcherHelper.GetRepeatingActionRefCount(Purpose));
    }

    private static IDisposable BeginLoadingIndicator(RED4Controller controller)
    {
        var method = typeof(RED4Controller).GetMethod(
            "BeginLoadingIndicator",
            BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.NotNull(method);

        var scope = method!.Invoke(controller, null) as IDisposable;
        Assert.NotNull(scope);
        return scope!;
    }

    private static RED4Controller CreateUninitializedController(out Mock<IProgressService<double>> progress)
    {
        progress = new Mock<IProgressService<double>>();
        progress.SetupAllProperties();

        var controller = (RED4Controller)RuntimeHelpers.GetUninitializedObject(typeof(RED4Controller));
        SetField(controller, "_progressService", progress.Object);
        return controller;
    }

    private static void SetField(object target, string name, object? value)
    {
        var field = target.GetType().GetField(name, BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.NotNull(field);
        field!.SetValue(target, value);
    }
}
