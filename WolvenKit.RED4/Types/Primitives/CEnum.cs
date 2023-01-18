using System;
using System.Diagnostics;
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
            var success = TryParse(value, out T result);
            Debug.Assert(success);
            return result;
        }

        public static bool TryParse<T>(string value, out T result) where T : struct, Enum
        {
            var typeInfo = RedReflection.GetEnumTypeInfo(typeof(T));
            value = typeInfo.GetCSNameFromRedName(value);

            if (Enum.TryParse(value, out result))
            {
                return true;
            }

            return false;
        }
    }

    [DebuggerDisplay("{_value}")]
    public readonly struct CEnum<T> : IRedEnum<T>, IEquatable<CEnum<T>> where T : struct, Enum
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly T _value;

        public CEnum()
        {
            _value = default;
        }

        internal CEnum(T value)
        {
            _value = value;
        }

        public static implicit operator CEnum<T>(T value) => new(value);
        public static implicit operator T(CEnum<T> value) => value._value;

        public static implicit operator CEnum<T>(Enum value) => new((T)value);
        public static implicit operator Enum(CEnum<T> value) => value._value;

        public Type GetInnerType() => typeof(T);

        public override string ToString() => _value.ToString();
        public string ToEnumString() => _value.ToString();
        public object GetEnumValue() => _value;

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

            return Equals((CEnum<T>)obj);
        }

        public bool Equals(CEnum<T> other) => Equals(_value, other._value);

        public override int GetHashCode() => _value.GetHashCode();
    }
}
