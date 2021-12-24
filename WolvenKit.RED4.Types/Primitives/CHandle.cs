using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace WolvenKit.RED4.Types
{
    [RED("handle")]
    public class CHandle<T> : IRedHandle<T>, IEquatable<CHandle<T>> where T : IRedClass
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public T Chunk { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public Type InnerType => typeof(T);


        public IRedClass GetValue() => Chunk;
        public void SetValue(IRedClass cls) => Chunk = (T)cls;


        public CHandle(){}

        public CHandle(T chunk)
        {
            Chunk = chunk;
        }


        public static implicit operator CHandle<T>(T value) => new(value);
        public static implicit operator T(CHandle<T> value) => value.Chunk;


        public bool Equals(CHandle<T> other)
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

            return Equals((CHandle<T>)obj);
        }

        public override int GetHashCode() => EqualityComparer<T>.Default.GetHashCode((T)Chunk);
    }
}
