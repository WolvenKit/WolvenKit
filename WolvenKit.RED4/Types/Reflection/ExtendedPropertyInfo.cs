using System.Reflection;

namespace WolvenKit.RED4.Types;

public class ExtendedPropertyInfo
{
    private Flags _flags = Flags.Empty;
    internal bool _isDefaultSet;

    public ExtendedPropertyInfo(ExtendedTypeInfo containingType, string name, string type)
    {
        IsDynamic = true;

        ContainingTypeInfo = containingType;

        RedName = name;
        RedType = type;
    }

    public ExtendedPropertyInfo(ExtendedTypeInfo containingType, PropertyInfo propertyInfo)
    {
        IsDynamic = false;

        ContainingTypeInfo = containingType;

        Name = propertyInfo.Name;
        Type = propertyInfo.PropertyType;
        if (Type.IsGenericType)
        {
            GenericType = Type.GetGenericTypeDefinition();
        }

        var attrs = propertyInfo.GetCustomAttributes();
        foreach (var attribute in attrs)
        {
            ProcessAttribute(attribute);
        }

        var propName = $"{ContainingTypeInfo.Type.Name}.{Name}";
        if (Patches.AttributePatches.TryGetValue(propName, out var patches))
        {
            foreach (var attribute in patches)
            {
                ProcessAttribute(attribute);
            }
        }
    }

    public int Ordinal { get; private set; } = -1;
    public int Before { get; private set; } = -1;
    public int After { get; private set; } = -1;

    public ExtendedTypeInfo ContainingTypeInfo { get; private set; }

    public string Name { get; }
    public string? RedName { get; private set; }
    public string RedType { get; }
    public Flags Flags => _flags.Clone();
    public bool IsIgnored { get; internal set; }

    public bool IsDynamic { get; }

    public Type Type { get; }
    public Type? GenericType { get; }

    public bool SerializeDefault { get; private set; }
    public object? DefaultValue { get; internal set; }

    private void ProcessAttribute(Attribute attribute)
    {
        if (attribute is OrdinalAttribute ordinalAttribute)
        {
            Ordinal = ordinalAttribute.Ordinal;
        }

        if (attribute is OrdinalOverrideAttribute ordinalOverrideAttribute)
        {
            Before = ordinalOverrideAttribute.Before;
            After = ordinalOverrideAttribute.After;
        }

        if (attribute is REDAttribute redAttribute)
        {
            RedName = redAttribute.Name;
            _flags = new Flags(redAttribute.Flags);
        }

        if (attribute is REDBufferAttribute redBufferAttribute)
        {
            IsIgnored = redBufferAttribute.IsIgnored;
        }

        if (attribute is REDPropertyAttribute redPropertyAttribute)
        {
            SerializeDefault = redPropertyAttribute.SerializeDefault;
            IsIgnored = redPropertyAttribute.IsIgnored;
        }
    }

    public bool IsDefault(object? value)
    {
        if (!_isDefaultSet)
        {
            DefaultValue = RedReflection.GetClassDefaultValue(ContainingTypeInfo.Type, this);
            _isDefaultSet = true;
        }

        return Equals(DefaultValue, value);
    }
}