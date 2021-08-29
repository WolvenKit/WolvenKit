using System;

namespace WolvenKit.RED4.Types
{
    public class CBitField<T> : IRedEnum<T> where T : Enum
    {
        public T Value { get; set; }

        public void SetValue(object value) => Value = (T)value;

        public static implicit operator CBitField<T>(T value) => new() { Value = value };
        public static implicit operator Enum(CBitField<T> value) => value.Value;
    }
}
