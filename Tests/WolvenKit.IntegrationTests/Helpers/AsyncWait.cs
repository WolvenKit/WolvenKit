using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace WolvenKit.IntegrationTests.Helpers;

/// <summary>
/// Polling helpers for state that settles on deferred callbacks rather than on the awaited call.
/// </summary>
internal static class AsyncWait
{
    /// <summary>
    /// Polls <paramref name="condition"/> until it holds, or gives up after <paramref name="timeout"/>.
    /// </summary>
    /// <remarks>
    /// Project loading does not finish when the call that started it returns. LoadProjectFromPathAsync
    /// hands its tail to DispatcherHelper.DelayOnMainThread, which later raises OnInitialProjectLoaded,
    /// which in turn posts StartWatcher_AndLoadProject onto the dispatcher - only then does the project
    /// explorer have an ActiveProject. Awaiting NewProjectTask therefore proves nothing; the awaits in
    /// here are what let those queued callbacks run.
    /// </remarks>
    /// <returns>True if the condition held before the timeout.</returns>
    public static async Task<bool> UntilAsync(Func<bool> condition, TimeSpan timeout)
    {
        var stopwatch = Stopwatch.StartNew();

        while (!condition())
        {
            if (stopwatch.Elapsed > timeout)
            {
                return false;
            }

            await Task.Delay(25);
        }

        return true;
    }
}
