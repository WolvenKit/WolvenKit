using System;
using System.Reflection;
using System.Collections.Generic;
using System.Diagnostics;

namespace WolvenKit.RED4.Types
{
    public static class CHandle
    {
        public static IRedBaseHandle Parse(Type handleType, RedBaseClass value)
        {
            var method = typeof(CHandle).GetMethod(nameof(Parse), BindingFlags.Public | BindingFlags.Static, null, new[] { typeof(RedBaseClass) }, null);
            var generic = method.MakeGenericMethod(handleType);

            return (IRedBaseHandle)generic.Invoke(null, new object[] { value });
        }

        public static CHandle<T> Parse<T>(RedBaseClass value) where T : RedBaseClass
        {
            return new CHandle<T>((T)value);
        }
    }

    [RED("handle")]
    public class CHandle<T> : IRedHandle<T>, /*IRedNotifyObjectChanged, */IEquatable<CHandle<T>>, IRedCloneable where T : RedBaseClass
    {
        // public event ObjectChangedEventHandler ObjectChanged;

        private T _chunk;

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public T Chunk {
            get => _chunk;
            set
            {
                _chunk = value;

                //if (!Equals(_chunk, value))
                //{
                //    if (_chunk != null)
                //    {
                //        _chunk.ObjectChanged -= OnObjectChanged;
                //    }
                //
                //    var oldChunk = _chunk;
                //    _chunk = value;
                //
                //    if (_chunk != null)
                //    {
                //        _chunk.ObjectChanged += OnObjectChanged;
                //    }
                //
                //    var args = new ObjectChangedEventArgs(ObjectChangedType.Modified, null, oldChunk, _chunk);
                //    args._callStack.Add(this);
                //
                //    ObjectChanged?.Invoke(null, args);
                //}
            }
        }

        //private void OnObjectChanged(object sender, ObjectChangedEventArgs e)
        //{
        //    if (e._callStack.Contains(this))
        //    {
        //        return;
        //    }
        //    e._callStack.Add(this);
        //
        //    ObjectChanged?.Invoke(sender, e);
        //}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public Type InnerType => typeof(T);


        public RedBaseClass GetValue() => Chunk;
        public void SetValue(RedBaseClass cls)
        {
            if (cls is DynamicBaseClass dbc)
            {
                Chunk = dbc.Convert<T>();
            }
            else
            {
                Chunk = (T)cls;
            }
        }


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

            if (!Equals(Chunk, other.Chunk))
            {
                return false;
            }

            return true;
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

        public object ShallowCopy()
        {
            return MemberwiseClone();
        }

        public object DeepCopy()
        {
            return CHandle.Parse(InnerType, (RedBaseClass)_chunk.DeepCopy());
        }
    }
}
