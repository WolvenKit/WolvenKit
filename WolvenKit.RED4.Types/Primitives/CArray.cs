using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    [RED("array")]
    public class CArray<T> : List<T>, IRedArray<T>, IEquatable<CArray<T>> where T : IRedType
    {
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

        public new void RemoveAt(int index)
        {
            if (this[index] is IRedBaseHandle d)
            {
                d.Remove();
            }
            base.RemoveAt(index);
        }

        public override bool Equals(object obj)
        {
            if (obj is CArray<T> cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(CArray<T> other)
        {
            if (other == null)
            {
                return false;
            }

            return this.SequenceEqual(other);
        }

        public override int GetHashCode() => ((List<T>)this).GetHashCode();
    }
}
