using System;
using System.Diagnostics;

namespace WolvenKit.RED4.Types
{
    public static class CEnum
    {
        public static CEnum<T> Parse<T>(string value) where T : struct, Enum
        {
            if (Enum.TryParse<T>(value, out var result))
            {
                return result;
            }

            return new CEnum<T>(value);
        }
    }


    public class CEnum<T> : IRedEnum<T>, IEquatable<CEnum<T>> where T : struct, Enum
    {
        public T? Value { get; set; } = null;
        public string StringValue { get; set; } = null;

        public void SetValue(string str)
        {
            Value = CEnum.Parse<T>(str).Value;
            StringValue = str;
        }

        public CEnum()
        {
            Value = default(T);
        }

        private CEnum(T value)
        {
            Value = value;
        }

        internal CEnum(string value)
        {
            StringValue = value;
        }

        public static implicit operator CEnum<T>(T value) => new(value);
        public static implicit operator CEnum<T>(Enum value) => new((T)value);

        public string ToEnumString()
        {
            if (Value != null)
            {
                return Value.ToString();
            }

            return StringValue;
        }

        public Type GetInnerType()
        {
            return typeof(T);
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
