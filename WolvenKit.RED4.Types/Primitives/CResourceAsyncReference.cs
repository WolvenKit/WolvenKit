using System;
using System.Collections;

namespace WolvenKit.RED4.Types
{
    [RED("raRef")]
    public class CResourceAsyncReference<T> : IRedResourceAsyncReference<T>, IEquatable<CResourceAsyncReference<T>> where T : IRedType
    {
        public string DepotPath { get; set; }
        public InternalEnums.EImportFlags Flags { get; set; }


        public bool Equals(CResourceAsyncReference<T> other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return DepotPath == other.DepotPath && Flags == other.Flags;
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

            return Equals((CResourceAsyncReference<T>)obj);
        }

        public override int GetHashCode() => HashCode.Combine(DepotPath, (int)Flags);
    }
}
