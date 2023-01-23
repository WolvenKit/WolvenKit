using System.Reflection;

namespace WolvenKit.RED4.Types;

public class ExtendedPropertyInfo
{
    private Flags _flags;
    internal bool _isDefaultSet;

    public ExtendedPropertyInfo(string name, string type)
    {
        IsDynamic = true;

        RedName = name;
        RedType = type;
    }

    public ExtendedPropertyInfo(Type parent, PropertyInfo propertyInfo)
    {
        IsDynamic = false;

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

        var propName = $"{parent.Name}.{Name}";
        if (Patches.AttributePatches.ContainsKey(propName))
        {
            foreach (var attribute in Patches.AttributePatches[propName])
            {
                ProcessAttribute(attribute);
            }
        }
    }

    public int Ordinal { get; private set; } = -1;
    public int Before { get; private set; } = -1;
    public int After { get; private set; } = -1;

    public string Name { get; }
    public string RedName { get; private set; }
    public string RedType { get; }
    public Flags Flags => _flags != null ? _flags.Clone() : Flags.Empty;
    public bool IsIgnored { get; internal set; }

    public bool IsDynamic { get; }

    public Type Type { get; }
    public Type GenericType { get; }

    public bool SerializeDefault { get; private set; }
    public object DefaultValue { get; internal set; }

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
}