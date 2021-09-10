using System;
using System.Diagnostics;
using System.IO;

namespace WolvenKit.RED4.Types
{
    [RED("Double")]
    [DebuggerDisplay("{_value,nq}", Type = "CDouble")]
    public readonly struct CDouble : IRedPrimitive<double>, IEquatable<CDouble>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly double _value;

        private CDouble(double value)
        {
            _value = value;
        }

        public static implicit operator CDouble(double value) => new(value);
        public static implicit operator double(CDouble value) => value._value;

        public static CDouble operator +(CDouble objA, CDouble objB) => new(objA._value + objB._value);
        public static CDouble operator -(CDouble objA, CDouble objB) => new(objA._value + objB._value);
        public static CDouble operator *(CDouble objA, CDouble objB) => new(objA._value + objB._value);
        public static CDouble operator /(CDouble objA, CDouble objB) => new(objA._value + objB._value);


        public override int GetHashCode() => _value.GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj is CDouble cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(CDouble other) => Equals(_value, other._value);
    }
}
