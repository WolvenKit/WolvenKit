using System;
using System.Diagnostics;
using System.IO;

namespace WolvenKit.RED4.Types
{
    [RED("Int8")]
    [DebuggerDisplay("{_value,nq}", Type = "CInt8")]
    public readonly struct CInt8 : IRedPrimitive<sbyte>, IEquatable<CInt8>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly sbyte _value;

        private CInt8(sbyte value)
        {
            _value = value;
        }

        public static implicit operator CInt8(sbyte value) => new(value);
        public static implicit operator sbyte(CInt8 value) => value._value;

        public static CInt8 operator +(CInt8 objA, CInt8 objB) => new((sbyte)(objA._value + objB._value));
        public static CInt8 operator -(CInt8 objA, CInt8 objB) => new((sbyte)(objA._value - objB._value));
        public static CInt8 operator *(CInt8 objA, CInt8 objB) => new((sbyte)(objA._value * objB._value));
        public static CInt8 operator /(CInt8 objA, CInt8 objB) => new((sbyte)(objA._value / objB._value));


        public override int GetHashCode() => _value.GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj is CInt8 cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(CInt8 other) => Equals(_value, other._value);
    }
}
