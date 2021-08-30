using System;
using System.Collections.Generic;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    public class CStatic<T> : List<T>, IRedArray<T>, IEquatable<CStatic<T>> where T : IRedType
    {
        public override bool Equals(object obj)
        {
            if (obj is CStatic<T> cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(CStatic<T> other)
        {
            if (other == null)
            {
                return false;
            }

            return this.SequenceEqual(other);
        }
    }
}
