using System;
using System.Collections.Generic;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    public class CArrayBase<T> : List<T>, IEquatable<CArrayBase<T>>, IRedArray
    {
        public int MaxSize { get; set; } = -1;

        public CArrayBase(){}

        public CArrayBase(int size) : base(new T[size])
        {
            var propTypeInfo = RedReflection.GetTypeInfo(typeof(T));
            if (propTypeInfo.IsValueType)
            {
                for (var i = 0; i < Count; i++)
                {
                    this[i] = System.Activator.CreateInstance<T>();
                }
            }
        }
        public Type InnerType => typeof(T);

        public new void Add(T item)
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }

            if (Count == MaxSize)
            {
                throw new NotSupportedException();
            }

            base.Add(item);
        }

        public new void Clear()
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }

            base.Clear();
        }

        public new bool Remove(T item)
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }
            
            return base.Remove(item);
        }

        public bool IsReadOnly { get; set; }

        public new void Insert(int index, T item)
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }

            if (Count == MaxSize)
            {
                throw new NotSupportedException();
            }

            base.Insert(index, item);
        }

        public new void RemoveAt(int index)
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }

            base.RemoveAt(index);
        }

        public new T this[int index]
        {
            get => base[index];
            set => base[index] = value;
        }

        public override bool Equals(object obj)
        {
            if (obj is CArrayBase<T> cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(CArrayBase<T> other)
        {
            if (other == null)
            {
                return false;
            }

            return this.SequenceEqual(other);
        }

        public override int GetHashCode() => base.GetHashCode();
    }
}
