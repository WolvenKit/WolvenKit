using System;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.RED4.Types
{
    [RED("raRef")]
    [REDType(IsValueType = true)]
    public class CResourceAsyncReference<T> : IRedResourceAsyncReference<T>, IEquatable<CResourceAsyncReference<T>>, IRedCloneable where T : CResource
    {
        public CName DepotPath { get; set; } = new();
        public InternalEnums.EImportFlags Flags { get; set; }

        #region IRedCloneable

        public object ShallowCopy() => MemberwiseClone();

        public object DeepCopy() => new CResourceAsyncReference<T> { DepotPath = (CName)DepotPath.DeepCopy(), Flags = Flags };

        #endregion IRedCloneable


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

            if (!Equals(DepotPath, other.DepotPath))
            {
                return false;
            }

            if (!Equals(Flags, other.Flags))
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

            return Equals((CResourceAsyncReference<T>)obj);
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

        public override string ToString() => $"{DepotPath} <{RedReflection.GetRedTypeFromCSType(GetType())} 0x{DepotPath.GetRedHash():X} / {DepotPath.GetRedHash()}>";
    }
}
