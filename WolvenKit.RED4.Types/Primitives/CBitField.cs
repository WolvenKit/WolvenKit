using System;
using System.Diagnostics;

namespace WolvenKit.RED4.Types
{
    [REDType(IsValueType = true)]
    [DebuggerDisplay("{Value}")]
    public class CBitField<T> : IRedBitField<T>, IEquatable<CBitField<T>> where T : struct, Enum
    {
        public T Value { get; set; }

        public CBitField() { }

        private CBitField(T value)
        {
            Value = value;
        }

        public static implicit operator CBitField<T>(T value) => new(value);
        public static implicit operator T(CBitField<T> value) => value.Value;

        public static implicit operator CBitField<T>(Enum value) => new((T)value);
        public static implicit operator Enum(CBitField<T> value) => (Enum)value.Value;

        public string ToBitFieldString()
        {
            return Value.ToString();
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj is CBitField<T> cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(CBitField<T> other) => Equals(Value, other.Value);
    }
}
