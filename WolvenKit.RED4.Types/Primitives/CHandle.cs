using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace WolvenKit.RED4.Types
{
    [RED("handle")]
    public class CHandle<T> : IRedHandle<T>, IRedNotifyObjectChanged, IEquatable<CHandle<T>> where T : RedBaseClass
    {
        public event ObjectChangedEventHandler ObjectChanged;

        private T _chunk;

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public T Chunk {
            get => _chunk;
            set
            {
                if (!Equals(_chunk, value))
                {
                    if (_chunk != null)
                    {
                        _chunk.ObjectChanged -= OnObjectChanged;
                    }

                    var oldChunk = _chunk;
                    _chunk = value;

                    if (_chunk != null)
                    {
                        _chunk.ObjectChanged += OnObjectChanged;
                    }

                    ObjectChanged?.Invoke(null, new ObjectChangedEventArgs(ObjectChangedType.Modified, null, null, oldChunk, _chunk));
                }
            }
        }

        private void OnObjectChanged(object sender, ObjectChangedEventArgs e)
        {
            ObjectChanged?.Invoke(sender, e);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public Type InnerType => typeof(T);


        public RedBaseClass GetValue() => Chunk;
        public void SetValue(RedBaseClass cls) => Chunk = (T)cls;


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
