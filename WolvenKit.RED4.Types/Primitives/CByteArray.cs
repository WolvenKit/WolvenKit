using System;
using System.Diagnostics;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    [DebuggerDisplay("{_value,nq}", Type = "CByteArray")]
    public readonly struct CByteArray : IRedPrimitive<byte[]>, IEquatable<CByteArray>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly byte[] _value;

        private CByteArray(byte[] data)
        {
            _value = data;
        }

        public static implicit operator CByteArray(byte[] value) => new(value);
        public static implicit operator byte[](CByteArray value) => value._value;

        public bool Equals(CByteArray other) => _value.Length == other._value.Length && _value.SequenceEqual(other._value);

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

            return Equals((CByteArray)obj);
        }

        public override int GetHashCode() => (_value != null ? _value.GetHashCode() : 0);
    }
}
