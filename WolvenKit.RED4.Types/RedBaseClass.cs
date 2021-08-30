using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace WolvenKit.RED4.Types
{
    [DebuggerTypeProxy(typeof(RedBaseClassDebugView))]
    public class RedBaseClass : IRedClass, IEquatable<RedBaseClass>
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


        public override bool Equals(object obj)
        {
            if (obj is RedBaseClass cObj)
            {
                return Equals(obj);
            }

            return false;
        }

        public bool Equals(RedBaseClass other)
        {
            if (other == null)
            {
                return false;
            }

            return GetHashCode().Equals(other.GetHashCode());
        }
    }
}
