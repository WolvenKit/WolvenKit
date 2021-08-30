using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    public class CArrayFixedSize<T> : List<T>, IRedArray<T>, IEquatable<CArrayFixedSize<T>> where T : IRedType
    {
        public bool IsFixedSize => true;

        public int Add(object value) => throw new NotSupportedException();
        public new void Add(T item) => throw new NotSupportedException();
        public new void Clear() => throw new NotSupportedException();
        public new void Insert(int index, T item) => throw new NotSupportedException();
        public void Insert(int index, object value) => throw new NotSupportedException();
        public new bool Remove(T item) => throw new NotSupportedException();
        public void Remove(object value) => throw new NotSupportedException();
        public new void RemoveAt(int index) => throw new NotSupportedException();


        public override bool Equals(object obj)
        {
            if (obj is CArrayFixedSize<T> cObj)
            {
                return Equals(obj);
            }

            return false;
        }

        public bool Equals(CArrayFixedSize<T> other)
        {
            if (other == null)
            {
                return false;
            }

            return this.SequenceEqual(other);
        }
    }
}
