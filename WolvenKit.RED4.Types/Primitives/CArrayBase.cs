using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    public class CArrayBase<T> : List<T>, IEquatable<CArrayBase<T>>
    {
        public CArrayBase(){}
        public CArrayBase(int size) : base(new T[size]){}

        public new void Add(T item)
        {
            if (IsReadOnly)
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

            foreach (var item in this)
            {
                if (item is IRedRemoveable obj)
                {
                    obj.Remove();
                }
            }
            base.Clear();
        }

        public new bool Remove(T item)
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }

            var result = base.Remove(item);
            if (result && item is IRedRemoveable obj)
            {
                obj.Remove();
            }
            return result;
        }

        public bool IsReadOnly { get; set; }

        public new void Insert(int index, T item)
        {
            if (IsReadOnly)
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

            if (this[index] is IRedRemoveable obj)
            {
                obj.Remove();
            }
            base.RemoveAt(index);
        }

        public new T this[int index]
        {
            get => base[index];
            set
            {
                if (value == null && base[index] is IRedBaseHandle d)
                {
                    d.Remove();
                }
                base[index] = value;
            }
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
