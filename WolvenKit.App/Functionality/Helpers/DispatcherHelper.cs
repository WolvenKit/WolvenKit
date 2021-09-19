using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace WolvenKit.Functionality.Helpers
{
    //Assembly: HandyControl, Version=3.2.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b
    public static class DispatcherHelper
    {
        public static void RunOnMainThread(Action action) => Application.Current.RunOnUIThread(action);

        public static void RunOnUIThread(this DispatcherObject d, Action action)
        {
            Dispatcher dispatcher = d?.Dispatcher;
            if (dispatcher == null)
                return;
            if (dispatcher.CheckAccess())
                action();
            else
                dispatcher.BeginInvoke((Delegate)action, Array.Empty<object>());
        }
    }
}
