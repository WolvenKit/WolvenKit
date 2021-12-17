using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.RED4.Types
{
    [RED("rRef")]
    public class CResourceReference<T> : IRedResourceReference<T>, IEquatable<CResourceReference<T>> where T : IRedType
    {
        public CName DepotPath { get; set; }
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

        public uint GetPersistentHash()
        {
            using (var fnv = new FNV1A32HashAlgorithm())
            {
                fnv.AppendString(DepotPath);
                fnv.AppendString(Flags.ToString());

                return fnv.HashUInt32;
            }
        }

        public override string ToString() => DepotPath;
    }
}
