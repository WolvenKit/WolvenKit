using System;
using System.Reflection;

namespace WolvenKit.RED4.Types
{
    public static class CEnum
    {
        public static IRedEnum Parse(Type enumType, string value)
        {
            var method = typeof(CEnum).GetMethod(nameof(Parse), BindingFlags.Public | BindingFlags.Static, null, new[] { typeof(string) }, null);
            var generic = method.MakeGenericMethod(enumType);

            return (IRedEnum)generic.Invoke(null, new object[] { value });
        }

        public static CEnum<T> Parse<T>(string value) where T : struct, Enum
        {
            if (Enum.TryParse<T>(value, out var result))
            {
                return result;
            }

            return new CEnum<T>(value);
        }
    }

    [REDType(IsValueType = true)]
    public class CEnum<T> : IRedEnum<T>, IEquatable<CEnum<T>> where T : struct, Enum
    {
        public T? Value { get; init; }
        public string StringValue { get; init; }

        public CEnum()
        {
            Value = default(T);
            StringValue = null;
        }

        internal CEnum(T value)
        {
            Value = value;
            StringValue = null;
        }

        internal CEnum(string value)
        {
            Value = null;
            StringValue = value;
        }

        public static implicit operator CEnum<T>(T value) => new(value);
        public static implicit operator CEnum<T>(Enum value) => new((T)value);

        public Type GetInnerType() => typeof(T);

        public string ToEnumString()
        {
            if (Value != null)
            {
                return Value.ToString();
            }

            return StringValue;
        }

        public bool Equals(CEnum<T> other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Nullable.Equals(Value, other.Value) && StringValue == other.StringValue;
        }

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

            return Equals((CEnum<T>)obj);
        }

        public override int GetHashCode() => HashCode.Combine(Value, StringValue);
    }
}
