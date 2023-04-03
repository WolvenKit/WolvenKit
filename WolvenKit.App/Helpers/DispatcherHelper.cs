using System;
using System.Windows;
using System.Windows.Threading;

namespace WolvenKit.App.Helpers;

//Assembly: HandyControl, Version=3.2.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b
public static class DispatcherHelper
{
    public static void RunOnMainThread(Action action, DispatcherPriority priority = DispatcherPriority.Normal) => Application.Current.RunOnUIThread(action, priority);

    public static void RunOnUIThread(this DispatcherObject d, Action action, DispatcherPriority priority = DispatcherPriority.Normal)
    {
        if (d is not { Dispatcher: { } dispatcher})
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
}