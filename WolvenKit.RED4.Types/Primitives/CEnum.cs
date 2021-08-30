using System;

namespace WolvenKit.RED4.Types
{
    public class CEnum<T> : IRedEnum<T> where T : Enum
    {
        public T Value { get; set; }

        public Enum GetValue() => Value;
        public void SetValue(object value) => Value = (T)value;

        public static implicit operator CEnum<T>(T value) => new() { Value = value };
        public static implicit operator Enum(CEnum<T> value) => value.Value;
    }
}
