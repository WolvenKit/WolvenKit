using System;

namespace WolvenKit.RED4.Types
{
    [RED("rRef")]
    public class CResourceReference<T> : IRedResourceReference<T>, IEquatable<CResourceReference<T>> where T : IRedType
    {
        public string DepotPath { get; set; }
        public InternalEnums.EImportFlags Flags { get; set; }


        public bool Equals(CResourceReference<T> other)
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

            return Equals((CResourceReference<T>)obj);
        }

        public override int GetHashCode() => HashCode.Combine(DepotPath, (int)Flags);
    }
}
