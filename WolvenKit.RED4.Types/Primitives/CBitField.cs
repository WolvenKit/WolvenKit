using System;
using System.Diagnostics;
using System.Reflection;

namespace WolvenKit.RED4.Types
{

    public static class CBitField
    {
        public static IRedBitField Parse(Type enumType, string value)
        {
            var method = typeof(CBitField).GetMethod(nameof(Parse), BindingFlags.Public | BindingFlags.Static, null, new[] { typeof(string) }, null);
            var generic = method.MakeGenericMethod(enumType);

            return (IRedBitField)generic.Invoke(null, new object[] { value });
        }

        public static CBitField<T> Parse<T>(string value) where T : struct, Enum
        {
            if (Enum.TryParse<T>(value, out var result))
            {
                return result;
            }

            return null;
            //return new CBitField<T>(value);
        }
    }

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

        public Type GetInnerType() => typeof(T);

        public string ToBitFieldString()
        {
            return Value.ToString();
        }

        public override int GetHashCode() => Value.GetHashCode();

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

            return Equals((CBitField<T>)obj);
        }

        public bool Equals(CBitField<T> other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Equals(Value, other.Value);
        }
    }
}
