using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace WolvenKit.RED4.Types
{
    [DebuggerTypeProxy(typeof(RedBaseClassDebugView))]
    public class RedBaseClass : IRedClass
    {
        protected T GetProperty<T>(ref T backingField, [CallerMemberName] string callerName = "") where T : IRedType
        {
            if (backingField == null && typeof(IRedPrimitive).IsAssignableFrom(typeof(T)))
            {
                backingField = System.Activator.CreateInstance<T>();
            }

            return backingField;
        }

        protected void SetProperty<T>(ref T backingField, T value, [CallerMemberName] string callerName = "") where T : IRedType
        {
            backingField = value;
        }
    }
}
