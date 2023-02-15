using System.Collections.Immutable;

namespace WolvenKit.RED4.Types;

public class ExtendedTypeInfo
{
    private readonly Dictionary<string, int> _nameIndex = new();
    private readonly Dictionary<string, int> _redNameIndex = new();

    public ExtendedTypeInfo()
    {
        IsDynamicType = true;

        Type = typeof(DynamicBaseClass);
    }

    public ExtendedTypeInfo(Type type)
    {
        IsDynamicType = false;

        Type = type;
        BaseType = type.BaseType;

        var attrs = type.GetCustomAttributes(false);
        foreach (var attribute in attrs)
        {
            if (attribute is REDClassAttribute clsAttr)
            {
                SerializeDefault = clsAttr.SerializeDefault;
                ChildLevel = clsAttr.ChildLevel;
            }
        }

        var properties = new List<ExtendedPropertyInfo>();
        var cusProps = new List<ExtendedPropertyInfo>();
        foreach (var propertyInfo in type.GetProperties())
        {
            var extendedInfo = new ExtendedPropertyInfo(this, propertyInfo);

            if (typeof(IRedAppendix).IsAssignableFrom(type) && propertyInfo.Name == "Appendix")
            {
                extendedInfo.IsIgnored = true;
            }

            if (extendedInfo.Ordinal != -1)
            {
                properties.Add(extendedInfo);
            }
            else
            {
                cusProps.Add(extendedInfo);
            }
        }

        properties = properties.OrderBy(p => p.Ordinal).ToList();
        var clone = new List<ExtendedPropertyInfo>(properties);
        foreach (var extendedInfo in cusProps)
        {
            if (extendedInfo.Before != -1)
            {
                var index = properties.IndexOf(clone[extendedInfo.Before]);
                properties.Insert(index, extendedInfo);
                continue;
            }

            if (extendedInfo.After != -1)
            {
                var index = properties.IndexOf(clone[extendedInfo.After]);
                properties.Insert(index + 1, extendedInfo);
                continue;
            }

            properties.Add(extendedInfo);
        }

        PropertyInfos = PropertyInfos.AddRange(properties);
        for (var i = 0; i < PropertyInfos.Count; i++)
        {
            _nameIndex.Add(PropertyInfos[i].Name, i);

            if (!string.IsNullOrEmpty(PropertyInfos[i].RedName))
            {
                _redNameIndex.Add(PropertyInfos[i].RedName!, i);
            }
        }
    }

    public Type Type { get; }
    public Type? BaseType { get; }
    public bool SerializeDefault { get; }
    public int ChildLevel { get; }

    public bool IsDynamicType { get; }

    public ImmutableList<ExtendedPropertyInfo> PropertyInfos { get; } =
        ImmutableList<ExtendedPropertyInfo>.Empty;

    public List<ExtendedPropertyInfo> DynamicPropertyInfos { get; } = new();

    public ExtendedPropertyInfo? GetNativePropertyInfoByName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException(nameof(name));
        }

        if (_redNameIndex.TryGetValue(name, out var i1))
        {
            return PropertyInfos[i1];
        }

        if (_nameIndex.TryGetValue(name, out var i2))
        {
            return PropertyInfos[i2];
        }

        return null;
    }

    public ExtendedPropertyInfo? GetPropertyInfoByName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException(nameof(name));
        }

        var propInfo = GetPropertyInfoByRedName(name);
        if (propInfo != null)
        {
            return propInfo;
        }

        propInfo = GetPropertyInfoByCsName(name);
        if (propInfo != null)
        {
            return propInfo;
        }

        return null;
    }

    public IEnumerable<ExtendedPropertyInfo> GetWritableProperties()
    {
        foreach (var propertyInfo in PropertyInfos)
        {
            if (!propertyInfo.IsIgnored)
            {
                yield return propertyInfo;
            }
        }

        foreach (var propertyInfo in DynamicPropertyInfos)
        {
            if (!propertyInfo.IsIgnored)
            {
                yield return propertyInfo;
            }
        }
    }

    public ExtendedPropertyInfo? GetPropertyInfoByCsName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException(nameof(name));
        }

        if (!IsDynamicType)
        {
            if (_nameIndex.TryGetValue(name, out var i))
            {
                return PropertyInfos[i];
            }
        }

        foreach (var propertyInfo in DynamicPropertyInfos)
        {
            if (propertyInfo.Name == name)
            {
                return propertyInfo;
            }
        }

        return null;
    }

    public ExtendedPropertyInfo? GetPropertyInfoByRedName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException(nameof(name));
        }

        if (!IsDynamicType)
        {
            if (_redNameIndex.TryGetValue(name, out var i))
            {
                return PropertyInfos[i];
            }
        }

        foreach (var propertyInfo in DynamicPropertyInfos)
        {
            if (propertyInfo.RedName == name)
            {
                return propertyInfo;
            }
        }

        return null;
    }

    public ExtendedPropertyInfo AddDynamicProperty(string varName, string typeName)
    {
        foreach (var oldPropertyInfo in DynamicPropertyInfos)
        {
            if (oldPropertyInfo.RedName == varName)
            {
                if (oldPropertyInfo.RedType == typeName)
                {
                    return oldPropertyInfo;
                }

                throw new ArgumentException($"A dynamic property with the name '{varName}' already exists!");
            }
        }

        var propertyInfo = new ExtendedPropertyInfo(this, varName, typeName);

        DynamicPropertyInfos.Add(propertyInfo);

        return propertyInfo;
    }
}