using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Serilog.Debugging;

namespace WolvenKit.App.Helpers;

//Assembly: HandyControl, Version=3.2.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b
public static class DispatcherHelper
{
    public static void RunOnMainThread(Action action, DispatcherPriority priority = DispatcherPriority.Normal) => Application.Current.RunOnUIThread(action, priority);

    private static void RunOnUIThread(this DispatcherObject? d, Action action, DispatcherPriority priority = DispatcherPriority.Normal)
    {
        // In a unit test / headless context there is no WPF Application and no Dispatcher.
        // Run the action synchronously so code paths that rely on DispatcherHelper
        // (DispatchedObservableCollection, etc.) continue to work.
        if (d == null && Application.Current == null)
        {
            action();
            return;
        }

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
}
