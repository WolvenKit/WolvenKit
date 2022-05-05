using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace WolvenKit.RED4.Types
{
    [RED("Float")]
    [DebuggerDisplay("{_value,nq}", Type = "CFloat")]
    public readonly struct CFloat : IRedPrimitive<float>, IEquatable<CFloat>, IRedInteger
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly float _value;

        private CFloat(float value)
        {
            _value = value;
        }

        public static implicit operator CFloat(float value) => new(value);
        public static implicit operator float(CFloat value) => value._value;

        public static CFloat operator +(CFloat objA, CFloat objB) => new(objA._value + objB._value);
        public static CFloat operator -(CFloat objA, CFloat objB) => new(objA._value - objB._value);
        public static CFloat operator *(CFloat objA, CFloat objB) => new(objA._value * objB._value);
        public static CFloat operator /(CFloat objA, CFloat objB) => new(objA._value / objB._value);


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

            return Equals((CFloat)obj);
        }

        public bool Equals(CFloat other) => Equals(BitConverter.SingleToInt32Bits(_value), BitConverter.SingleToInt32Bits(other._value));

        public override string ToString() => _value.ToString("G9");
        public string ToString(CultureInfo cultureInfo) => _value.ToString("G9", cultureInfo);
    }
}
