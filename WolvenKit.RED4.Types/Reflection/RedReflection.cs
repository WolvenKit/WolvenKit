using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types
{
    public static class RedReflection
    {
        private static readonly Dictionary<string, Type> _redTypeCache = new();
        private static Dictionary<Type, string> _redTypeCacheReverse = new();

        private static readonly Dictionary<string, ExtendedEnumInfo> _redEnumCache = new();
        private static readonly ConcurrentDictionary<Type, Lazy<ExtendedTypeInfo>> _typeInfoCache = new();

        public static void AddDynamicProperty(RedBaseClass cls, string propertyName, IRedType propertyValue)
        {
            cls.InternalSetPropertyValue(propertyName, propertyValue, false);
        }

        public static ExtendedTypeInfo GetTypeInfo(Type type)
        {
            return _typeInfoCache.GetOrAdd(type, new Lazy<ExtendedTypeInfo>(() => new ExtendedTypeInfo(type))).Value;
        }
        public static IEnumerable<Type> GetSubClassesOf(Type type) => _redTypeCache?.Values.Where(_ => _.IsSubclassOf(type)).ToList();

        public static ExtendedPropertyInfo GetPropertyByName(Type type, string propertyName)
        {
            var typeInfo = GetTypeInfo(type);

            return typeInfo.PropertyInfos.FirstOrDefault(p => p.Name == propertyName);
        }

        public static ExtendedPropertyInfo GetPropertyByRedName(Type type, string redPropertyName)
        {
            var typeInfo = GetTypeInfo(type);

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
                extendedPropertyInfo.DefaultValue = extendedPropertyInfo.GetValue(RedTypeManager.Create(clsType));
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
                    type = typeof(RedBaseClass);
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
            }

            _redTypeCacheReverse = _redTypeCache.ToDictionary(x => x.Value, x => x.Key);

            /*foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                if (assembly == Assembly.GetExecutingAssembly())
                {
                    continue;
                }

                foreach (var type in assembly.GetTypes())
                {
                    if (!baseType.IsAssignableFrom(type))
                    {
                        continue;
                    }

                    var redAttr = type.GetCustomAttribute<REDAttribute>();
                    if (redAttr != null)
                    {
                        _redTypeCache[redAttr.Name] = type;
                    }
                }
            }*/

            var types = typeof(Enums).GetNestedTypes();
            foreach (var type in types)
            {
                _redEnumCache.Add(type.Name, new ExtendedEnumInfo(type));
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

            public ExtendedEnumInfo(Type type)
            {
                Type = type;
                IsBitfield = type.GetCustomAttribute<FlagsAttribute>() != null;
            }
        }

        public class ExtendedTypeInfo
        {
            public bool SerializeDefault { get; }
            public int ChildLevel { get; }

            public bool IsValueType { get; set; }

            public List<ExtendedPropertyInfo> PropertyInfos { get; } = new();

            public ExtendedTypeInfo(Type type)
            {
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
                        PropertyInfos.Add(extendedInfo);
                    }
                    else
                    {
                        cusProps.Add(extendedInfo);
                    }
                }

                PropertyInfos = PropertyInfos.OrderBy(p => p.Ordinal).ToList();
                var clone = new List<ExtendedPropertyInfo>(PropertyInfos);
                foreach (var extendedInfo in cusProps)
                {
                    if (extendedInfo.Before != -1)
                    {
                        var index = PropertyInfos.IndexOf(clone[extendedInfo.Before]);
                        PropertyInfos.Insert(index, extendedInfo);
                        continue;
                    }

                    if (extendedInfo.After != -1)
                    {
                        var index = PropertyInfos.IndexOf(clone[extendedInfo.After]);
                        PropertyInfos.Insert(index + 1, extendedInfo);
                        continue;
                    }

                    PropertyInfos.Add(extendedInfo);
                }
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
            }
        }

        public class ExtendedPropertyInfo
        {
            private Flags _flags;
            internal bool _isDefaultSet;

            public int Ordinal { get; set; } = -1;
            public int Before { get; set; } = -1;
            public int After { get; set; } = -1;

            public string Name { get; set; }
            public string RedName { get; set; }
            public Flags Flags => _flags != null ? _flags.Clone() : Flags.Empty;
            public bool IsIgnored { get; set; }

            public Type Type { get; set; }

            public bool SerializeDefault { get; set; }
            public object DefaultValue { get; internal set; }

            public object GetValue(RedBaseClass instance) => instance.InternalGetPropertyValue(Type, RedName, Flags);
            public void SetValue(RedBaseClass instance, IRedType value)
            {
                instance.InternalForceSetPropertyValue(RedName, value, true);
                instance._writtenProperties.Add(RedName);
            }


            public ExtendedPropertyInfo(Type parent, PropertyInfo propertyInfo)
            {
                Name = propertyInfo.Name;
                Type = propertyInfo.PropertyType;

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
