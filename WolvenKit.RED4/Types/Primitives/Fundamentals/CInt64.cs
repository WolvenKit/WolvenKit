using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace WolvenKit.RED4.Types
{
    [RED("Int64")]
    [DebuggerDisplay("{_value,nq}", Type = "CInt64")]
    public readonly struct CInt64 : IRedPrimitive<long>, IEquatable<CInt64>, IRedInteger
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly long _value;

        private CInt64(long value)
        {
            _value = value;
        }

        public static implicit operator CInt64(long value) => new(value);
        public static implicit operator long(CInt64 value) => value._value;

        public static CInt64 operator +(CInt64 objA, CInt64 objB) => new(objA._value + objB._value);
        public static CInt64 operator -(CInt64 objA, CInt64 objB) => new(objA._value - objB._value);
        public static CInt64 operator *(CInt64 objA, CInt64 objB) => new(objA._value * objB._value);
        public static CInt64 operator /(CInt64 objA, CInt64 objB) => new(objA._value / objB._value);


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

            return Equals((CInt64)obj);
        }

        public bool Equals(CInt64 other) => Equals(_value, other._value);

        public override string ToString() => _value.ToString();
        public string ToString(CultureInfo cultureInfo) => _value.ToString(cultureInfo);
    }
}
