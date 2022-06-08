using System;
using System.Windows;
using System.Windows.Threading;

namespace WolvenKit.App.Helpers
{
    //Assembly: HandyControl, Version=3.2.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b
    public static class DispatcherHelper
    {
        public static void RunOnMainThread(Action action) => Application.Current.RunOnUIThread(action);

        public static void RunOnUIThread(this DispatcherObject d, Action action)
        {
            var dispatcher = d?.Dispatcher;
            if (dispatcher == null)
            {
                return;
            }

            if (dispatcher.CheckAccess())
            {
                action();
            }
            else
            {
                _ = dispatcher.BeginInvoke(action, Array.Empty<object>());
            }
        }
    }
}
