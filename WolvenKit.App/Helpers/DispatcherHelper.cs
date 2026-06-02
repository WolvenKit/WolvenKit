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

    public static void RunOnMainThread(Action action, DispatcherPriority priority = DispatcherPriority.Normal) => Application.Current.RunOnUIThread(action, priority);

    private static void RunOnUIThread(this DispatcherObject? d, Action action, DispatcherPriority priority = DispatcherPriority.Normal)
    {
        if (d is not { Dispatcher: { } dispatcher})
        {
            return;
        }
        if (dispatcher.CheckAccess())
        {
            action();
        }        else
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

    public static Task WaitUntilCancelled(CancellationToken token, Action onCancelled)
    {
        if (token.IsCancellationRequested)
        {
            onCancelled?.Invoke();
            return;
        }

        // Use a low-priority dispatcher operation that re-queues itself
        var dispatcher = Dispatcher.CurrentDispatcher;   // or Application.Current.Dispatcher

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