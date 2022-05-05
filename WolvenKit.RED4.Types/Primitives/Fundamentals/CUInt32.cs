using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace WolvenKit.RED4.Types
{
    [RED("Uint32")]
    [DebuggerDisplay("{_value,nq}", Type = "CUInt32")]
    public readonly struct CUInt32 : IRedPrimitive<uint>, IEquatable<CUInt32>, IRedInteger
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly uint _value;

        private CUInt32(uint value)
        {
            _value = value;
        }

        public static implicit operator CUInt32(uint value) => new(value);
        public static implicit operator uint(CUInt32 value) => value._value;

        public static CUInt32 operator +(CUInt32 objA, CUInt32 objB) => new(objA._value + objB._value);
        public static CUInt32 operator -(CUInt32 objA, CUInt32 objB) => new(objA._value - objB._value);
        public static CUInt32 operator *(CUInt32 objA, CUInt32 objB) => new(objA._value * objB._value);
        public static CUInt32 operator /(CUInt32 objA, CUInt32 objB) => new(objA._value / objB._value);


        public override int GetHashCode() => _value.GetHashCode();

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((CUInt32)obj);
        }

        public bool Equals(CUInt32 other) => Equals(_value, other._value);

        public override string ToString() => _value.ToString();
        public string ToString(CultureInfo cultureInfo) => _value.ToString(cultureInfo);
    }
}
