using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace WolvenKit.RED4.Types
{
    [RED("whandle")]
    public class CWeakHandle<T> : IRedWeakHandle<T>, IEquatable<CWeakHandle<T>> where T : RedBaseClass
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public T Chunk { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public Type InnerType => typeof(T);


        public RedBaseClass GetValue() => Chunk;
        public void SetValue(RedBaseClass cls) => Chunk = (T)cls;


        public bool Equals(CWeakHandle<T> other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return EqualityComparer<T>.Default.Equals((T)Chunk, (T)other.Chunk);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((CWeakHandle<T>)obj);
        }

        public override int GetHashCode() => EqualityComparer<T>.Default.GetHashCode((T)Chunk);
    }
}
