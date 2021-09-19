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
        private static readonly Dictionary<string, Type> _redEnumCache = new();
        private static readonly ConcurrentDictionary<Type, Lazy<ExtendedTypeInfo>> _typeInfoCache = new();

        public static void AddDynamicProperty(IRedClass cls, string propertyName, object propertyValue)
        {
            cls.InternalSetPropertyValue(propertyName, propertyValue, false);
        }

        public static ExtendedTypeInfo GetTypeInfo(Type type)
        {
            return _typeInfoCache.GetOrAdd(type, new Lazy<ExtendedTypeInfo>(() => new ExtendedTypeInfo(type))).Value;
        }

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
            return _redTypeCache.FirstOrDefault(t => t.Value == type).Key;
        }

        public static string GetEnumRedName(Type type)
        {
            return _redEnumCache.FirstOrDefault(t => t.Value == type).Key;
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
                if (isFixedArray)
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
                        type = typeof(CArrayFixedSize<>).MakeGenericType(type);
                    }

                    continue;
                }

                if (_redEnumCache.TryGetValue(subType, out var eType))
                {
                    if (type == null)
                    {
                        type = typeof(CEnum<>).MakeGenericType(eType);
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }

                    if (isFixedArray)
                    {
                        type = typeof(CArrayFixedSize<>).MakeGenericType(type);
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
                    type = typeof(CArrayFixedSize<>).MakeGenericType(type);
                }
            }

            flagValues.Reverse();
            var flags = new Flags(flagValues.ToArray());

            _csTypeCache2.TryAdd(redTypeName, (type, flags.Clone()));

            return (type, flags);
        }

        private static readonly ConcurrentDictionary<int, string> _csTypeCache = new();

        public static string GetRedTypeFromCSType(Type type, Flags flags)
        {
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
                        result += (flags.MoveNext() ? flags.Current : 0) + ",";
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
                _redEnumCache.Add(type.Name, type);
            }
        }

        static RedReflection()
        {
            PreBuildReadTypeCache();
        }

        public class ExtendedTypeInfo
        {
            public bool SerializeDefault { get; }
            public int ChildLevel { get; }

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
                }

                foreach (var propertyInfo in type.GetProperties())
                {
                    if (typeof(IRedAppendix).IsAssignableFrom(type) && propertyInfo.Name == "Appendix")
                    {
                        continue;
                    }

                    var extendedInfo = new ExtendedPropertyInfo(propertyInfo);
                    if (extendedInfo.IsIgnored)
                    {
                        continue;
                    }

                    PropertyInfos.Add(extendedInfo);
                }

                PropertyInfos = PropertyInfos.OrderBy(p => p.Ordinal).ToList();
            }
        }

        public class ExtendedPropertyInfo
        {
            internal bool _isDefaultSet;

            public int Ordinal { get; set; } = -1;
            public string Name { get; set; }
            public string RedName { get; set; }
            public Flags Flags { get; set; }
            public bool IsIgnored { get; set; }

            public Type Type { get; set; }
            public object DefaultValue { get; internal set; }

            public object GetValue(IRedClass instance) => instance.InternalGetPropertyValue(Type, RedName, Flags.Clone());
            public void SetValue(IRedClass instance, object value) => instance.InternalSetPropertyValue(RedName, value);


            public ExtendedPropertyInfo(PropertyInfo propertyInfo)
            {
                Name = propertyInfo.Name;
                Type = propertyInfo.PropertyType;

                var attrs = propertyInfo.GetCustomAttributes();
                foreach (var attribute in attrs)
                {
                    if (attribute is OrdinalAttribute ordinalAttribute)
                    {
                        Ordinal = ordinalAttribute.Ordinal;
                    }

                    if (attribute is REDAttribute redAttribute)
                    {
                        RedName = redAttribute.Name;
                        Flags = new Flags(redAttribute.Flags);
                    }

                    if (attribute is REDBufferAttribute redBufferAttribute)
                    {
                        IsIgnored = redBufferAttribute.IsIgnored;
                    }

                    if (attribute is REDPropertyAttribute redPropertyAttribute)
                    {
                        IsIgnored = redPropertyAttribute.IsIgnored;
                    }
                }
            }
        }
    }
}
