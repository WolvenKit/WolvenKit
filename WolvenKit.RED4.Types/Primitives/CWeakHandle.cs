using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace WolvenKit.RED4.Types
{
    [RED("whandle")]
    public class CWeakHandle<T> : IRedWeakHandle<T>, /*IRedNotifyObjectChanged,*/ IEquatable<CWeakHandle<T>> where T : RedBaseClass
    {
        //public event ObjectChangedEventHandler ObjectChanged;

        private T _chunk;

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public T Chunk
        {
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

            return Equals((CWeakHandle<T>)obj);
        }

        public override int GetHashCode() => EqualityComparer<T>.Default.GetHashCode((T)Chunk);
    }
}
