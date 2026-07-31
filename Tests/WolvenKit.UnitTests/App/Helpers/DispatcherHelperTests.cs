using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WolvenKit.App.Helpers;
using WolvenKit.Core.Exceptions;
using Xunit;

namespace Wolvenkit.Test.App.Helpers;

/// <summary>
/// Covers DispatcherHelper repeating-action purpose uniqueness (review issue 6)
/// and stop/restart lifecycle used by project / archive loading heartbeats.
/// </summary>
[Collection(DispatcherTimerTestCollection.Name)]
public class DispatcherHelperTests
{
    private static string UniquePurpose() => "test-purpose-" + Guid.NewGuid().ToString("N");

    [Fact]
    public void StartRepeatingAction_SamePurpose_Throws()
    {
        var purpose = UniquePurpose();
        var first = DispatcherHelper.StartRepeatingAction(purpose, () => { }, TimeSpan.FromHours(1));

        try
        {
            Assert.True(DispatcherHelper.IsRepeatingActionRunning(purpose));
            Assert.True(DispatcherHelper.TryGetRepeatingAction(purpose, out var existing));
            Assert.Equal(first, existing);

            var ex = Assert.Throws<WolvenKitException>(() =>
                DispatcherHelper.StartRepeatingAction(purpose, () => { }, TimeSpan.FromHours(1)));
            Assert.Contains(purpose, ex.Message, StringComparison.Ordinal);
        }
        finally
        {
            DispatcherHelper.StopRepeatingAction(first);
        }

        Assert.False(DispatcherHelper.IsRepeatingActionRunning(purpose));
    }

    [Fact]
    public void StopRepeatingAction_AllowsRestartWithSamePurpose()
    {
        var purpose = UniquePurpose();
        var first = DispatcherHelper.StartRepeatingAction(purpose, () => { }, TimeSpan.FromHours(1));
        DispatcherHelper.StopRepeatingAction(first);

        Assert.False(DispatcherHelper.IsRepeatingActionRunning(purpose));

        var second = DispatcherHelper.StartRepeatingAction(purpose, () => { }, TimeSpan.FromHours(1));
        try
        {
            Assert.NotEqual(first, second);
            Assert.True(DispatcherHelper.IsRepeatingActionRunning(purpose));
        }
        finally
        {
            DispatcherHelper.StopRepeatingAction(second);
        }
    }

    [Fact]
    public void StopRepeatingAction_EmptyGuid_IsNoOp()
    {
        DispatcherHelper.StopRepeatingAction(Guid.Empty);
    }

    [Fact]
    public void StopRepeatingAction_InvokesOnCancelledOnce()
    {
        var purpose = UniquePurpose();
        var calls = 0;
        var guid = DispatcherHelper.StartRepeatingAction(
            purpose,
            () => { },
            TimeSpan.FromHours(1),
            onCancelled: () => Interlocked.Increment(ref calls));

        DispatcherHelper.StopRepeatingAction(guid);
        DispatcherHelper.StopRepeatingAction(guid); // second stop is no-op

        Assert.Equal(1, calls);
        Assert.False(DispatcherHelper.IsRepeatingActionRunning(purpose));
    }

    [Fact]
    public void StartRepeatingAction_DifferentPurposes_CanRunConcurrently()
    {
        var a = UniquePurpose();
        var b = UniquePurpose();
        var ga = DispatcherHelper.StartRepeatingAction(a, () => { }, TimeSpan.FromHours(1));
        var gb = DispatcherHelper.StartRepeatingAction(b, () => { }, TimeSpan.FromHours(1));

        try
        {
            Assert.True(DispatcherHelper.IsRepeatingActionRunning(a));
            Assert.True(DispatcherHelper.IsRepeatingActionRunning(b));
            Assert.NotEqual(ga, gb);
        }
        finally
        {
            DispatcherHelper.StopRepeatingAction(ga);
            DispatcherHelper.StopRepeatingAction(gb);
        }
    }

    [Fact]
    public async Task StartRepeatingAction_ConcurrentSamePurpose_OnlyOneWins()
    {
        var purpose = UniquePurpose();
        var winners = 0;
        var losers = 0;
        var guids = new List<Guid>();
        var lockObj = new object();

        var tasks = new Task[8];
        for (var i = 0; i < tasks.Length; i++)
        {
            tasks[i] = Task.Run(() =>
            {
                try
                {
                    var g = DispatcherHelper.StartRepeatingAction(purpose, () => { }, TimeSpan.FromHours(1));
                    Interlocked.Increment(ref winners);
                    lock (lockObj)
                    {
                        guids.Add(g);
                    }
                }
                catch (WolvenKitException)
                {
                    Interlocked.Increment(ref losers);
                }
            });
        }

        await Task.WhenAll(tasks);

        Assert.Equal(1, winners);
        Assert.Equal(tasks.Length - 1, losers);
        Assert.Single(guids);
        Assert.True(DispatcherHelper.IsRepeatingActionRunning(purpose));

        DispatcherHelper.StopRepeatingAction(guids[0]);
        Assert.False(DispatcherHelper.IsRepeatingActionRunning(purpose));
    }
}
