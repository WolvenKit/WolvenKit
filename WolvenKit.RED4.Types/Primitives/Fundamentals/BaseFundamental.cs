using System;
using System.Diagnostics;
using System.IO;

namespace WolvenKit.RED4.Types
{
    [DebuggerDisplay("{Value,nq}")]
    public abstract class BaseFundamental<T> : IRedPrimitive, IEquatable<BaseFundamental<T>> where T : struct, IEquatable<T>
    {
        public T Value { get; set; }


        public override bool Equals(object obj)
        {
            if (obj is BaseFundamental<T> cObj)
            {
                return Equals(obj);
            }

            return false;
        }

        public bool Equals(BaseFundamental<T> other)
        {
            if (other == null)
            {
                return false;
            }

            return Value.Equals(other.Value);
        }
    }
}
