using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types
{
    public static class RedReflection
    {
        private static readonly ConcurrentDictionary<Type, object> s_defaultValueCache = new();
        private static readonly Dictionary<string, Type> _redTypeCache = new();
        private static Dictionary<Type, string> _redTypeCacheReverse = new();

        private static readonly Dictionary<string, ExtendedEnumInfo> _redEnumCache = new();

        private static readonly ConcurrentDictionary<Type, ExtendedTypeInfo> s_typeInfoCache = new();
        private static readonly ConcurrentDictionary<string, ExtendedTypeInfo> s_dynamicTypeInfoCache = new();

        public static ExtendedTypeInfo GetTypeInfo(IRedType value)
        {
            if (value is DynamicBaseClass dbc)
            {
                if (!s_dynamicTypeInfoCache.TryGetValue(dbc.ClassName, out var result))
                {
                    result = new ExtendedTypeInfo();
                    s_dynamicTypeInfoCache.TryAdd(dbc.ClassName, result);
                }

                return result;
            }
            else
            {
                var type = value.GetType();

                if (!s_typeInfoCache.TryGetValue(type, out var result))
                {
                    result = new ExtendedTypeInfo(type);
                    s_typeInfoCache.TryAdd(type, result);
                }

                return result;
            }
        }

        public static ExtendedTypeInfo GetTypeInfo(Type type)
        {
            if (!s_typeInfoCache.TryGetValue(type, out var result))
            {
                result = new ExtendedTypeInfo(type);
                s_typeInfoCache.TryAdd(type, result);
            }

            return result;
        }

        public static Dictionary<string, Type> GetTypes() => new(_redTypeCache);

        public static IEnumerable<Type> GetSubClassesOf(Type type) => _redTypeCache?.Values.Where(_ => _.IsSubclassOf(type)).ToList();

        public static ExtendedPropertyInfo GetPropertyByName(Type type, string propertyName)
        {
            var typeInfo = GetTypeInfo(type);

            return typeInfo.PropertyInfos.FirstOrDefault(p => p.Name == propertyName);
        }

        public static ExtendedPropertyInfo GetNativePropertyInfo(Type classType, string propertyName) =>
            GetTypeInfo(classType).GetNativePropertyInfoByName(propertyName);

        public static object GetClassDefaultValue(Type classType, string propertyName)
        {
            var propertyInfo = GetNativePropertyInfo(classType, propertyName);
            if (propertyInfo == null)
            {
                throw new PropertyNotFoundException($"{classType.Name}.{propertyName}");
            }

            return GetClassDefaultValue(classType, propertyInfo);
        }

        public static object GetClassDefaultValue(Type classType, ExtendedPropertyInfo propertyInfo)
        {
            return RedTypeManager.Create(classType).GetProperty(propertyInfo.RedName);
        }

        public static object GetDefaultValue(Type type)
        {
            if (s_defaultValueCache.TryGetValue(type, out var value))
            {
                return value;
            }

            object result = null;
            if (type.IsValueType)
            {
                result = System.Activator.CreateInstance(type);
            }

            var typeInfo = GetTypeInfo(type);
            if (typeInfo is { IsValueType: true })
            {
                result = System.Activator.CreateInstance(type);
            }

            s_defaultValueCache.TryAdd(type, result);

            return result;
        }

        public static ExtendedPropertyInfo GetPropertyByRedName(Type type, string redPropertyName)
        {
            var typeInfo = GetTypeInfo(type);

            return typeInfo.PropertyInfos.FirstOrDefault(p => p.RedName == redPropertyName);
        }

        public static ExtendedPropertyInfo GetPropertyByRedName(ExtendedTypeInfo typeInfo, string redPropertyName)
        {
            return typeInfo.PropertyInfos.FirstOrDefault(p => p.RedName == redPropertyName);
        }

        public static bool IsDefault(Type clsType, string redPropertyName, object value)
        {
            var extendedPropertyInfo = GetPropertyByRedName(clsType, redPropertyName);
            if (extendedPropertyInfo == null)
            {
                throw new MissingRTTIException(redPropertyName, "???", clsType.Name);
            }

            return IsDefault(clsType, extendedPropertyInfo, value);
        }

        public static bool IsDefault(Type clsType, ExtendedPropertyInfo extendedPropertyInfo, object value)
        {
            if (!extendedPropertyInfo._isDefaultSet)
            {
                extendedPropertyInfo.DefaultValue = GetClassDefaultValue(clsType, extendedPropertyInfo);
                extendedPropertyInfo._isDefaultSet = true;
            }

            return object.Equals(extendedPropertyInfo.DefaultValue, value);
        }

        public static string GetTypeRedName(Type type)
        {
            return _redTypeCacheReverse.ContainsKey(type) ? _redTypeCacheReverse[type] : null;
        }

        public static string GetEnumRedName(Type type)
        {
            return _redEnumCache.FirstOrDefault(t => t.Value.Type == type).Key;
        }

        public static ExtendedEnumInfo GetEnumTypeInfo(Type type)
        {
            return _redEnumCache.FirstOrDefault(t => t.Value.Type == type).Value;
        }

        private static readonly ConcurrentDictionary<string, (Type, Flags)> _csTypeCache2 = new();

        public static (Type type, Flags flags) GetCSTypeFromRedType(string redTypeName)
        {
            if (_csTypeCache2.TryGetValue(redTypeName, out var tuple))
            {
                return (tuple.Item1, tuple.Item2.Clone());
            }

            Type type = null;
            List<int> flagValues = new();

            var subTypes = redTypeName.Split(':');
            for (int i = subTypes.Length - 1; i >= 0; i--)
            {
                var subType = subTypes[i];

                var meta = subType.Split(',');
                if (meta.Length > 1)
                {
                    flagValues.Add(int.Parse(meta[0]));
                    subType = meta[1];
                }

                var isFixedArray = subType[0] == '[';
                while (subType[0] == '[')
                {
                    var strVal = subType.Substring(1, subType.IndexOf(']') - 1);
                    flagValues.Add(int.Parse(strVal));
                    subType = subType.Substring(strVal.Length + 2);
                }

                if (_redTypeCache.TryGetValue(subType, out var tType))
                {
                    if (type == null)
                    {
                        type = tType;
                    }
                    else
                    {
                        type = tType.MakeGenericType(type);
                    }

                    if (isFixedArray)
                    {
                        for (int j = 0; j < flagValues.Count; j++)
                        {
                            type = typeof(CArrayFixedSize<>).MakeGenericType(type);
                        }
                    }

                    continue;
                }

                if (_redEnumCache.TryGetValue(subType, out var eType))
                {
                    if (type == null)
                    {
                        if (eType.IsBitfield)
                        {
                            type = typeof(CBitField<>).MakeGenericType(eType.Type);
                        }
                        else
                        {
                            type = typeof(CEnum<>).MakeGenericType(eType.Type);
                        }
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }

                    if (isFixedArray)
                    {
                        for (int j = 0; j < flagValues.Count; j++)
                        {
                            type = typeof(CArrayFixedSize<>).MakeGenericType(type);
                        }
                    }

                    continue;
                }

                if (type == null)
                {
                    type = typeof(DynamicBaseClass);
                }
                else
                {
                    throw new NotSupportedException();
                }

                if (isFixedArray)
                {
                    for (int j = 0; j < flagValues.Count; j++)
                    {
                        type = typeof(CArrayFixedSize<>).MakeGenericType(type);
                    }
                }
            }

            flagValues.Reverse();
            var flags = new Flags(flagValues.ToArray());

            _csTypeCache2.TryAdd(redTypeName, (type, flags.Clone()));

            return (type, flags);
        }

        private static readonly ConcurrentDictionary<int, string> _csTypeCache = new();

        public static string GetRedTypeFromCSType(Type type, Flags flags = null)
        {
            flags ??= Flags.Empty;

            var hash = HashCode.Combine(type, flags);
            if (_csTypeCache.TryGetValue(hash, out var result))
            {
                return result;
            }

            var tType = type;

            while (true)
            {
                if (!tType.IsGenericType)
                {
                    result += GetTypeRedName(tType);
                    break;
                }
                else
                {
                    var genericType = tType.GetGenericTypeDefinition();
                    var innerType = tType.GetGenericArguments()[0];

                    if (genericType == typeof(CEnum<>) || genericType == typeof(CBitField<>))
                    {
                        result += GetEnumRedName(innerType);
                        break;
                    }

                    

                    if (genericType == typeof(CArrayFixedSize<>))
                    {
                        result += $"[{(flags.MoveNext() ? flags.Current : 0)}]";
                    }
                    else
                    {
                        result += GetTypeRedName(genericType) + ":";
                    }

                    if (genericType == typeof(CStatic<>))
                    {
                        result +=  (flags.MoveNext() ? flags.Current : 0) + ",";
                    }

                    tType = innerType;
                }
            }

            _csTypeCache.TryAdd(hash, result);

            return result;
        }

        private static void PreBuildReadTypeCache()
        {
            var baseType = typeof(IRedType);

            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (!baseType.IsAssignableFrom(type))
                {
                    continue;
                }

                var redAttr = type.GetCustomAttribute<REDAttribute>();
                if (redAttr != null)
                {
                    _redTypeCache.Add(redAttr.Name, type);
                }
                else
                {
                    _redTypeCache.Add(type.Name, type);
                }

                BuildTypeCache(type);
            }

            _redTypeCacheReverse = _redTypeCache.ToDictionary(x => x.Value, x => x.Key);

            var types = typeof(Enums).GetNestedTypes();
            foreach (var type in types)
            {
                _redEnumCache.Add(type.Name, new ExtendedEnumInfo(type));
            }

            void BuildTypeCache(Type type)
            {
                if (s_typeInfoCache.ContainsKey(type))
                {
                    return;
                }

                var typeInfo = new ExtendedTypeInfo(type);
                s_typeInfoCache.TryAdd(type, typeInfo);
                foreach (var propertyInfo in typeInfo.PropertyInfos)
                {
                    BuildTypeCache(propertyInfo.Type);
                }
            }
        }

        static RedReflection()
        {
            PreBuildReadTypeCache();
        }

        public class ExtendedEnumInfo
        {
            public Type Type { get; set; }
            public bool IsBitfield { get; set; }

            public Dictionary<string, string> RedNames { get; set; } = new();

            public ExtendedEnumInfo(Type type)
            {
                Type = type;
                IsBitfield = type.GetCustomAttribute<FlagsAttribute>() != null;

                var valueNames = Enum.GetNames(Type);
                foreach (var valueName in valueNames)
                {
                    var member = Type.GetMember(valueName);

                    var redAttr = member[0].GetCustomAttribute<REDAttribute>();
                    if (redAttr != null)
                    {
                        RedNames.Add(redAttr.Name, valueName);
                    }
                }
            }

            public string GetCSNameFromRedName(string valueName)
            {
                if (RedNames.ContainsKey(valueName))
                {
                    return RedNames[valueName];
                }

                return valueName;
            }

            public string GetRedNameFromCSName(string valueName)
            {
                if (RedNames.ContainsValue(valueName))
                {
                    return RedNames.FirstOrDefault(x => x.Value == valueName).Key;
                }

                return valueName;
            }
        }

        public class ExtendedTypeInfo
        {
            private readonly Dictionary<string, int> _nameIndex = new();
            private readonly Dictionary<string, int> _redNameIndex = new();

            public Type? BaseType { get; }
            public bool SerializeDefault { get; }
            public int ChildLevel { get; }

            public bool IsDynamicType { get; }

            public bool IsValueType { get; }
            public ImmutableList<ExtendedPropertyInfo> PropertyInfos { get; } = ImmutableList<ExtendedPropertyInfo>.Empty;
            public List<ExtendedPropertyInfo> DynamicPropertyInfos { get; } = new();

            public ExtendedTypeInfo()
            {
                IsDynamicType = true;
            }

            public ExtendedTypeInfo(Type type)
            {
                IsDynamicType = false;

                BaseType = type.BaseType;

                var attrs = type.GetCustomAttributes(false);
                foreach (var attribute in attrs)
                {
                    if (attribute is REDClassAttribute clsAttr)
                    {
                        SerializeDefault = clsAttr.SerializeDefault;
                        ChildLevel = clsAttr.ChildLevel;
                    }

                    if (attribute is REDTypeAttribute typeAttr)
                    {
                        IsValueType = typeAttr.IsValueType;
                    }
                }

                var properties = new List<ExtendedPropertyInfo>();
                var cusProps = new List<ExtendedPropertyInfo>();
                foreach (var propertyInfo in type.GetProperties())
                {
                    var extendedInfo = new ExtendedPropertyInfo(type, propertyInfo);

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
                        _redNameIndex.Add(PropertyInfos[i].RedName, i);
                    }
                }
            }

            public ExtendedPropertyInfo GetNativePropertyInfoByName(string name)
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

            public ExtendedPropertyInfo GetPropertyInfoByName(string name)
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

            public ExtendedPropertyInfo GetPropertyInfoByCsName(string name)
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

            public ExtendedPropertyInfo GetPropertyInfoByRedName(string name)
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

                var propertyInfo = new ExtendedPropertyInfo(varName, typeName);

                DynamicPropertyInfos.Add(propertyInfo);

                return propertyInfo;
            }
        }

        public class ExtendedPropertyInfo
        {
            private Flags _flags;
            internal bool _isDefaultSet;

            public int Ordinal { get; private set; } = -1;
            public int Before { get; private set; } = -1;
            public int After { get; private set; } = -1;

            public string Name { get; }
            public string RedName { get; private set; }
            public string RedType { get; private set; }
            public Flags Flags => _flags != null ? _flags.Clone() : Flags.Empty;
            public bool IsIgnored { get; internal set; }

            public bool IsDynamic { get; }

            public Type Type { get; }
            public Type GenericType { get; }

            public bool SerializeDefault { get; private set; }
            public object DefaultValue { get; internal set; }

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
    }
}
