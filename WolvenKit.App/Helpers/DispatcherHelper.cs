using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace WolvenKit.App.Helpers;

//Assembly: HandyControl, Version=3.2.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b
public static class DispatcherHelper
{
    private static ConcurrentDictionary<Guid, DispatcherTimer> _dispatcherTimers = new();

    public static void RunOnMainThread(Action action, DispatcherPriority priority = DispatcherPriority.Normal) =>
        Application.Current.RunOnUIThread(action, priority);

    private static void RunOnUIThread(this DispatcherObject? d, Action action,
        DispatcherPriority priority = DispatcherPriority.Normal)
    {
        if (d is not { Dispatcher: { } dispatcher })
        {
            return;
        }

        if (dispatcher.CheckAccess())
        {
            action();
        }
        else
        {
            try
            {
                dispatcher.InvokeAsync(action, priority);
            }
            catch (Exception)
            {
                // TODO: Add logger here?
                throw;
            }
        }
    }

    /// <summary>
    /// Runs `action` on the main thread after specified delay, without blocking.
    /// </summary>
    /// <param name="action"></param>
    /// <param name="millisecondsDelay"></param>
    public static void DelayOnMainThread(Action action, int millisecondsDelay)
    {
        Task.Delay(millisecondsDelay)
            .ContinueWith(_ => RunOnMainThread(action), TaskScheduler.Default);
    }

    public static void WaitUntilCancelled(CancellationToken token, Action onCancelled)
    {
        if (token.IsCancellationRequested)
        {
            onCancelled?.Invoke();
            return;
        }

        // Use a low-priority dispatcher operation that re-queues itself
        var dispatcher = Dispatcher.CurrentDispatcher; // or Application.Current.Dispatcher

        void CheckCancellation()
        {
            if (token.IsCancellationRequested)
            {
                onCancelled?.Invoke();
            }
            else
            {
                // Re-queue itself with low priority so other UI work can run
                dispatcher.BeginInvoke(CheckCancellation, DispatcherPriority.Background);
            }
        }

        // Start the polling loop
        dispatcher.BeginInvoke(CheckCancellation, DispatcherPriority.Background);
    }

    /// <summary>
    /// Repeats action every interval TimeSpan until the timer is
    /// stopped by passing the returned guid to StopRepeatingAction.
    ///
    /// Returns a Guid to call StopRepeatingSetter(guid) with, to stop it.
    ///
    /// </summary>
    /// <param name="action"></param>
    /// <param name="interval"></param>
    /// <param name="onCancelled"></param>
    /// <returns>Guid</returns>
    public static Guid StartRepeatingAction(
        Action action,
        TimeSpan interval,
        Action? onCancelled = null)
    {
        var guid = Guid.NewGuid();
        DispatcherTimer timer = new()
        {
            Interval = interval,
            Tag = onCancelled
        };

        _dispatcherTimers.TryAdd(guid, timer);

        timer.Tick += (sender, e) =>
        {
            if (sender is DispatcherTimer timer)
            {
                action();
            }
        };

        timer.Start();

        return guid;
    }

    /// <summary>
    /// Call with a guid to cancel a repeating setter timer.
    /// </summary>
    /// <param name="guid"></param>
    public static void StopRepeatingAction(Guid guid)
    {
        if (_dispatcherTimers.TryRemove(guid, out DispatcherTimer? timer))
        {
            var onCancelled = timer.Tag as Action;
            timer.Stop();
            onCancelled?.Invoke();
        }
    }
}
