using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types
{
    public static class RedReflection
    {
        private static readonly ConcurrentDictionary<Type, object> s_defaultValueCache = new();
        private static readonly Dictionary<string, Type> s_redTypeCache = new();
        private static readonly Dictionary<Type, string> s_redTypeCacheReverse = new();

        private static readonly Dictionary<string, ExtendedEnumInfo> s_redEnumCache = new();

        private static readonly ConcurrentDictionary<Type, ExtendedTypeInfo> s_typeInfoCache = new();
        private static readonly ConcurrentDictionary<string, ExtendedTypeInfo> s_dynamicTypeInfoCache = new();

        private static readonly ConcurrentDictionary<int, string> s_csTypeCache = new();
        private static readonly ConcurrentDictionary<string, (Type, Flags)> s_csTypeCache2 = new();


        static RedReflection()
        {
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
                AddRedType(type);
            }

            foreach (var type in typeof(Enums).GetNestedTypes())
            {
                AddEnumType(type);
            }
        }

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

        public static Dictionary<string, Type> GetTypes() => new(s_redTypeCache);

        public static ExtendedPropertyInfo GetNativePropertyInfo(Type classType, string propertyName) =>
            GetTypeInfo(classType).GetNativePropertyInfoByName(propertyName);

        public static object GetClassDefaultValue(Type classType, ExtendedPropertyInfo propertyInfo) =>
            RedTypeManager.Create(classType).GetProperty(propertyInfo.RedName);

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

            s_defaultValueCache.TryAdd(type, result);

            return result;
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
                extendedPropertyInfo.DefaultValue = GetClassDefaultValue(clsType, extendedPropertyInfo);
                extendedPropertyInfo._isDefaultSet = true;
            }

            return Equals(extendedPropertyInfo.DefaultValue, value);
        }

        public static string GetTypeRedName(Type type) =>
            s_redTypeCacheReverse.ContainsKey(type) ? s_redTypeCacheReverse[type] : null;

        public static string GetEnumRedName(Type type) => s_redEnumCache.FirstOrDefault(t => t.Value.Type == type).Key;

        public static ExtendedEnumInfo GetEnumTypeInfo(Type type) =>
            s_redEnumCache.FirstOrDefault(t => t.Value.Type == type).Value;

        public static (Type type, Flags flags) GetCSTypeFromRedType(string redTypeName)
        {
            if (s_csTypeCache2.TryGetValue(redTypeName, out var tuple))
            {
                return (tuple.Item1, tuple.Item2.Clone());
            }

            Type type = null;
            List<int> flagValues = new();

            var subTypes = redTypeName.Split(':');
            for (var i = subTypes.Length - 1; i >= 0; i--)
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

                if (s_redTypeCache.TryGetValue(subType, out var tType))
                {
                    type = type == null ? tType : tType.MakeGenericType(type);

                    if (isFixedArray)
                    {
                        for (var j = 0; j < flagValues.Count; j++)
                        {
                            type = typeof(CArrayFixedSize<>).MakeGenericType(type);
                        }
                    }

                    continue;
                }

                if (s_redEnumCache.TryGetValue(subType, out var eType))
                {
                    if (type == null)
                    {
                        type = eType.IsBitfield
                            ? typeof(CBitField<>).MakeGenericType(eType.Type)
                            : typeof(CEnum<>).MakeGenericType(eType.Type);
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }

                    if (isFixedArray)
                    {
                        for (var j = 0; j < flagValues.Count; j++)
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
                    for (var j = 0; j < flagValues.Count; j++)
                    {
                        type = typeof(CArrayFixedSize<>).MakeGenericType(type);
                    }
                }
            }

            flagValues.Reverse();
            var flags = new Flags(flagValues.ToArray());

            s_csTypeCache2.TryAdd(redTypeName, (type, flags.Clone()));

            return (type, flags);
        }

        public static string GetRedTypeFromCSType(Type type, Flags flags = null)
        {
            flags ??= Flags.Empty;

            var hash = HashCode.Combine(type, flags);
            if (s_csTypeCache.TryGetValue(hash, out var result))
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

            s_csTypeCache.TryAdd(hash, result);

            return result;
        }

        public static bool AddRedType(Type type)
        {
            if (typeof(IRedType).IsAssignableFrom(type))
            {
                var redAttr = type.GetCustomAttribute<REDAttribute>();
                if (redAttr != null)
                {
                    s_redTypeCache.Add(redAttr.Name, type);
                    s_redTypeCacheReverse.Add(type, redAttr.Name);
                }
                else
                {
                    s_redTypeCache.Add(type.Name, type);
                    s_redTypeCacheReverse.Add(type, type.Name);
                }

                BuildTypeCache(type);
                return true;
            }

            return false;

            void BuildTypeCache(Type innerType)
            {
                if (s_typeInfoCache.ContainsKey(innerType))
                {
                    return;
                }

                var typeInfo = new ExtendedTypeInfo(innerType);
                s_typeInfoCache.TryAdd(innerType, typeInfo);
                foreach (var propertyInfo in typeInfo.PropertyInfos)
                {
                    BuildTypeCache(propertyInfo.Type);
                }
            }
        }

        public static bool AddEnumType(Type type)
        {
            if (type.IsEnum)
            {
                s_redEnumCache.Add(type.Name, new ExtendedEnumInfo(type));
                return true;
            }

            return false;
        }

        #region TypeInfo

        public static Type GetFullType(List<RedTypeInfo> redTypeInfos)
        {
            Type result = null;

            for (var i = redTypeInfos.Count - 1; i >= 0; i--)
            {
                if (result == null)
                {
                    if (redTypeInfos[i].BaseRedType is BaseRedType.Class)
                    {
                        result = redTypeInfos[i].RedObjectType;
                    }
                    else if (redTypeInfos[i].BaseRedType is BaseRedType.Enum or BaseRedType.BitField)
                    {
                        result = redTypeInfos[i].MappedType.MakeGenericType(redTypeInfos[i].RedObjectType);
                    }
                    else
                    {
                        result = redTypeInfos[i].MappedType;
                    }
                }
                else
                {
                    result = redTypeInfos[i].MappedType.MakeGenericType(result);
                }
            }

            return result;
        }

        public static List<RedTypeInfo> GetRedTypeInfos(Type type, Flags flags = null) =>
            GetRedTypeInfos(GetRedTypeFromCSType(type, flags));

        public static List<RedTypeInfo> GetRedTypeInfos(string redTypeName)
        {
            var result = new List<RedTypeInfo>();

            var isFixed = false;
            var isStatic = false;

            var str = "";
            foreach (var c in redTypeName)
            {
                if (c == ':')
                {
                    Temp();
                    continue;
                }

                if (isStatic && c == ',')
                {
                    isStatic = false;

                    result.Add(new RedTypeInfo(BaseRedType.StaticArray, int.Parse(str)));

                    str = "";
                    continue;
                }

                if (c == '[')
                {
                    isFixed = true;
                    continue;
                }

                if (isFixed && c == ']')
                {
                    isFixed = false;

                    result.Add(new RedTypeInfo(BaseRedType.NativeArray, int.Parse(str)));

                    str = "";
                    continue;
                }

                str += c;
            }

            Temp();

            return result;

            void Temp()
            {
                switch (str)
                {
                    case "array":
                        result.Add(new RedTypeInfo(BaseRedType.Array));
                        break;

                    case "static":
                        isStatic = true;
                        break;

                    case "handle":
                        result.Add(new RedTypeInfo(BaseRedType.Handle));
                        break;

                    case "whandle":
                        result.Add(new RedTypeInfo(BaseRedType.WeakHandle));
                        break;

                    case "rRef":
                        result.Add(new RedTypeInfo(BaseRedType.ResourceReference));
                        break;

                    case "raRef":
                        result.Add(new RedTypeInfo(BaseRedType.ResourceAsyncReference));
                        break;

                    case "curveData":
                        result.Add(new RedTypeInfo(BaseRedType.LegacySingleChannelCurve));
                        break;

                    case "CName":
                    case "String":
                    case "LocalizationString":
                    case "TweakDBID":
                    case "DataBuffer":
                    case "serializationDeferredDataBuffer":
                    case "SharedDataBuffer":
                    case "Variant":
                    case "CDateTime":
                    case "CGUID":
                    case "CRUID":
                    case "CRUIDRef":
                    case "EditorObjectID":
                    case "gamedataLocKeyWrapper":
                    case "MessageResourcePath":
                    case "NodeRef":
                    case "RuntimeEntityRef":
                        result.Add(new SimpleRedTypeInfo(Enum.Parse<SimpleRedType>(str)));
                        break;

                    case "Bool":
                    case "Int8":
                    case "Uint8":
                    case "Int16":
                    case "Uint16":
                    case "Int32":
                    case "Uint32":
                    case "Int64":
                    case "Uint64":
                    case "Float":
                    case "Double":
                        result.Add(new FundamentalRedTypeInfo(Enum.Parse<FundamentalRedType>(str)));
                        break;

                    case "multiChannelCurve":
                        result.Add(new SpecialRedTypeInfo(SpecialRedType.MultiChannelCurve, str));
                        break;

                    default:
                        if (s_redTypeCache.TryGetValue(str, out var type1) &&
                            type1.IsAssignableTo(typeof(RedBaseClass)))
                        {
                            result.Add(new RedTypeInfo(BaseRedType.Class, type1));
                            break;
                        }

                        if (s_redEnumCache.TryGetValue(str, out var type2))
                        {
                            result.Add(type2.IsBitfield
                                ? new RedTypeInfo(BaseRedType.BitField, type2.Type)
                                : new RedTypeInfo(BaseRedType.Enum, type2.Type));
                            break;
                        }

                        // could be enum/bitfield/class, just use class for now
                        result.Add(new SpecialRedTypeInfo(SpecialRedType.Mixed, str));
                        break;
                }

                str = "";
            }
        }

        #endregion
    }
}