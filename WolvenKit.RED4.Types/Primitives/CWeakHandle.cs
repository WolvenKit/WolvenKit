using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace WolvenKit.RED4.Types
{
    [RED("whandle")]
    public class CWeakHandle<T> : IRedWeakHandle<T>, IEquatable<CWeakHandle<T>> where T : IRedClass
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public Red4File File { get; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int Pointer { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public T Chunk
        {
            get => (T)File._handleManager.Get(Pointer);
            set => SetChunk(value);
        }

        internal CWeakHandle(Red4File file, int pointer)
        {
            File = file;
            Pointer = pointer;
        }

        private void SetChunk(T chunk)
        {
            var index = File.Chunks.IndexOf(chunk);
            if (index == -1)
            {
                File.Chunks.Add(chunk);
                index = File.Chunks.Count - 1;
            }

            Pointer = index;
        }

        public void Remove()
        {
            File._handleManager.RemoveHandle(this);
        }

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
