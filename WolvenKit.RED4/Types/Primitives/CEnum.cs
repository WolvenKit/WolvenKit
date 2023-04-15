using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace WolvenKit.RED4.Types;

public static class CEnum
{
    public static IRedEnum Parse(Type enumType, string value)
    {
        var method = typeof(CEnum).GetMethod(nameof(Parse), BindingFlags.Public | BindingFlags.Static, null, new[] { typeof(string) }, null);
        if (method == null)
        {
            throw new MissingMethodException(nameof(CBitField), nameof(Parse));
        }

        var generic = method.MakeGenericMethod(enumType);
        if (generic.Invoke(null, new object[] { value }) is not IRedEnum result)
        {
            throw new Exception();
        }

        return result;
    }

    public static CEnum<T> Parse<T>(string value) where T : struct, Enum
    {
        if (!TryParse(value, out T? result))
        {
            if (value == "0")
            {
                return default(T);
            }

            throw new Exception();
        }
        return result;
    }

    public static bool TryParse<T>(string value, [NotNullWhen(true)] out T? result) where T : struct, Enum
    {
        result = null;

        var typeInfo = RedReflection.GetEnumTypeInfo(typeof(T));
        var csName = typeInfo.GetCSNameFromRedName(value);
        if (csName == null)
        {
            return false;
        }

        if (Enum.TryParse(csName, out T result1))
        {
            result = result1;
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

    public override bool Equals(object? obj)
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