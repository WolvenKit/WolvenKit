using System.Numerics;
using System.Reflection;


namespace WolvenKit.RED4.Types;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
abstract public class DisplayAsEnumAttribute : Attribute
{
    public abstract Type EnumType();
}

public class DisplayAsEnumAttribute<T> : DisplayAsEnumAttribute where T : struct, Enum
{
    internal DisplayAsEnumAttribute() { }

    public override Type EnumType() { return typeof(T); }

    public string? ToString(T enumValue) => Enum.GetName<T>(enumValue);

    public T? ToEnumValue<I>(I val) where I : IBinaryInteger<I> => (T)Enum.ToObject(typeof(T), val);
}
