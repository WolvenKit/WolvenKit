using System;
using System.Diagnostics;
using System.IO;

namespace WolvenKit.RED4.Types
{
    [RED("Int16")]
    [DebuggerDisplay("{_value,nq}", Type = "CInt16")]
    public readonly struct CInt16 : IRedPrimitive<short>, IEquatable<CInt16>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly short _value;

        private CInt16(short value)
        {
            _value = value;
        }

        public static implicit operator CInt16(short value) => new(value);
        public static implicit operator short(CInt16 value) => value._value;

        public static CInt16 operator +(CInt16 objA, CInt16 objB) => new((short)(objA._value + objB._value));
        public static CInt16 operator -(CInt16 objA, CInt16 objB) => new((short)(objA._value - objB._value));
        public static CInt16 operator *(CInt16 objA, CInt16 objB) => new((short)(objA._value * objB._value));
        public static CInt16 operator /(CInt16 objA, CInt16 objB) => new((short)(objA._value / objB._value));


        public override int GetHashCode() => _value.GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj is CInt16 cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(CInt16 other) => Equals(_value, other._value);
    }
}
