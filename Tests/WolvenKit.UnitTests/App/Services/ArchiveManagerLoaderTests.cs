using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Moq;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.Core.Services;
using Wolvenkit.Test.App.Helpers;
using Xunit;

namespace Wolvenkit.Test.App.Services;

/// <summary>
/// Covers the archive-loading heartbeat, which lives on <see cref="ArchiveManagerLoader"/>.
///
/// The loader is registered transient, so the app view model, asset browser and materials dialog
/// each own an instance and can load archives concurrently. These tests pin the sharing contract
/// between those instances, which the previous depth-counter implementation got wrong.
///
/// Every scope is held with <c>using</c> so a failed assertion cannot leak a claim on the shared
/// purpose into the next test in this collection.
/// </summary>
[Collection(ArchiveLoadHeartbeatCollection.Name)]
public class ArchiveManagerLoaderTests
{
    private const string Purpose = IArchiveManagerLoader.ArchiveLoadingPurpose;

    [Fact]
    public void BeginLoadingIndicator_ArmsHeartbeat_AndReleasesOnDispose()
    {
        var loader = CreateUninitializedLoader(out var progress);

        using (var scope = BeginLoadingIndicator(loader))
        {
            Assert.True(DispatcherHelper.IsRepeatingActionRunning(Purpose));
        }

        Assert.False(DispatcherHelper.IsRepeatingActionRunning(Purpose));
        Assert.Equal(EStatus.Ready, progress.Object.Status);
        Assert.False(progress.Object.IsIndeterminate);
    }

    [Fact]
    public void BeginLoadingIndicator_NestedOnSameLoader_StaysArmedUntilOuterScopeCloses()
    {
        var loader = CreateUninitializedLoader(out _);

        using var outer = BeginLoadingIndicator(loader);
        using (var inner = BeginLoadingIndicator(loader))
        {
            Assert.Equal(2, DispatcherHelper.GetRepeatingActionRefCount(Purpose));
        }

        Assert.True(DispatcherHelper.IsRepeatingActionRunning(Purpose));
        Assert.Equal(1, DispatcherHelper.GetRepeatingActionRefCount(Purpose));
    }

    [Fact]
    public void BeginLoadingIndicator_SecondLoaderFinishingFirst_DoesNotStopTheFirstLoadersHeartbeat()
    {
        var first = CreateUninitializedLoader(out var firstProgress);
        var second = CreateUninitializedLoader(out _);

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
        var loader = CreateUninitializedLoader(out _);

        using var scope = BeginLoadingIndicator(loader);
        scope.Dispose();
        scope.Dispose();

        Assert.False(DispatcherHelper.IsRepeatingActionRunning(Purpose));
        Assert.Equal(0, DispatcherHelper.GetRepeatingActionRefCount(Purpose));
    }

    private static IDisposable BeginLoadingIndicator(ArchiveManagerLoader loader)
    {
        var method = typeof(ArchiveManagerLoader).GetMethod(
            "BeginLoadingIndicator",
            BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.NotNull(method);

        var scope = method!.Invoke(loader, null) as IDisposable;
        Assert.NotNull(scope);
        return scope!;
    }

    /// <summary>
    /// Built without running the constructor: the heartbeat only reads _progressService, and the
    /// real constructor would drag in the archive manager and parser for no benefit here.
    /// </summary>
    private static ArchiveManagerLoader CreateUninitializedLoader(out Mock<IProgressService<double>> progress)
    {
        progress = new Mock<IProgressService<double>>();
        progress.SetupAllProperties();

        var loader = (ArchiveManagerLoader)RuntimeHelpers.GetUninitializedObject(typeof(ArchiveManagerLoader));
        SetField(loader, "_progressService", progress.Object);
        return loader;
    }

    private static void SetField(object target, string name, object? value)
    {
        var field = target.GetType().GetField(name, BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.NotNull(field);
        field!.SetValue(target, value);
    }
}
