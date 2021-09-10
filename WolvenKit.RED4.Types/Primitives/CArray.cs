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
