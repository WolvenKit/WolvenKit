using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types;

public static class RedReflection
{
    private static readonly ConcurrentDictionary<Type, object?> s_defaultValueCache = new();
    private static readonly Dictionary<string, Type> s_redTypeCache = new();
    private static readonly Dictionary<Type, string> s_redTypeCacheReverse = new();

    private static readonly Dictionary<string, ExtendedEnumInfo> s_redEnumCache = new();
    private static readonly Dictionary<Type, ExtendedEnumInfo> s_enumInfoCache = new();

    private static readonly ConcurrentDictionary<Type, ExtendedTypeInfo> s_typeInfoCache = new();
    private static readonly ConcurrentDictionary<string, ExtendedTypeInfo> s_dynamicTypeInfoCache = new();

    private static readonly ConcurrentDictionary<int, string> s_csTypeCache = new();
    private static readonly ConcurrentDictionary<string, (Type, Flags)> s_csTypeCache2 = new();


    static RedReflection()
    {
        foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
        {
            var res = AddRedType(type);
        }

        foreach (var type in typeof(Enums).GetNestedTypes())
        {
            var res = AddEnumType(type);
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

    public static ExtendedPropertyInfo? GetNativePropertyInfo(Type classType, string propertyName) =>
        GetTypeInfo(classType).GetNativePropertyInfoByName(propertyName);

    public static object? GetClassDefaultValue(Type classType, ExtendedPropertyInfo propertyInfo) =>
        propertyInfo.RedName != null ? RedTypeManager.Create(classType).GetProperty(propertyInfo.RedName) : null;

    public static object? GetDefaultValue(Type type)
    {
        if (s_defaultValueCache.TryGetValue(type, out var value))
        {
            return value;
        }

        object? result = null;
        if (type.IsValueType)
        {
            result = System.Activator.CreateInstance(type);
        }

        s_defaultValueCache.TryAdd(type, result);

        return result;
    }

    public static ExtendedPropertyInfo? GetPropertyByRedName(Type? type, string redPropertyName)
    {
        if (type is null)
        {
            return null;
        }

        var typeInfo = GetTypeInfo(type);

        return typeInfo.PropertyInfos.FirstOrDefault(p => p.RedName == redPropertyName);
    }

    public static bool IsDefault(Type clsType, string redPropertyName, object? value)
    {
        var extendedPropertyInfo = GetPropertyByRedName(clsType, redPropertyName);
        if (extendedPropertyInfo == null)
        {
            throw new MissingRTTIException(redPropertyName, "???", clsType.Name);
        }

        return extendedPropertyInfo.IsDefault(value);
    }

    public static string? GetTypeRedName(Type type)
    {
        if (s_redTypeCacheReverse.TryGetValue(type, out var result))
        {
            return result;
        }
        return null;
    }

    public static ExtendedEnumInfo GetEnumTypeInfo(Type type) =>
        s_enumInfoCache.TryGetValue(type, out var info) ? info : throw new NotSupportedException(type.Name);

    public static string GetEnumRedName(Type type) => GetEnumTypeInfo(type).RedName;

    public static (Type type, Flags flags) GetCSTypeFromRedType(string redTypeName)
    {
        if (s_csTypeCache2.TryGetValue(redTypeName, out var tuple))
        {
            return (tuple.Item1, tuple.Item2.Clone());
        }

        Type? type = null;
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
                var strVal = subType[1..subType.IndexOf(']')];
                flagValues.Add(int.Parse(strVal));
                subType = subType[(strVal.Length + 2)..];
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

        if (type == null)
        {
            throw new TypeNotFoundException(redTypeName);
        }

        flagValues.Reverse();
        var flags = new Flags(flagValues.ToArray());

        s_csTypeCache2.TryAdd(redTypeName, (type, flags.Clone()));

        return (type, flags);
    }

    public static string GetRedTypeFromCSType(Type type, Flags? flags = null)
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
        // hack skipping custom types derived from IRedType
        if (type.FullName.StartsWith("WolvenKit.RED4.Archive.Buffer"))
        {
            return false;
        }

        if (typeof(IRedType).IsAssignableFrom(type))
        {
            var redAttr = type.GetCustomAttribute<REDAttribute>();
            if (redAttr != null)
            {
                if (s_redTypeCache.ContainsKey(redAttr.Name))
                {
                    Debugger.Break();
                }
                if (s_redTypeCacheReverse.ContainsKey(type))
                {
                    Debugger.Break();
                }

                s_redTypeCache.TryAdd(redAttr.Name, type);
                s_redTypeCacheReverse.TryAdd(type, redAttr.Name);
            }
            else
            {
                if (s_redTypeCache.ContainsKey(type.Name))
                {
                    Debugger.Break();
                }
                if (s_redTypeCacheReverse.ContainsKey(type))
                {
                    Debugger.Break();
                }

                s_redTypeCache.TryAdd(type.Name, type);
                s_redTypeCacheReverse.TryAdd(type, type.Name);
            }

            BuildTypeCache(type);
            return true;
        }

        return false;

        static void BuildTypeCache(Type innerType)
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
            var enumInfo = new ExtendedEnumInfo(type);
            return s_redEnumCache.TryAdd(enumInfo.RedName, enumInfo) && s_enumInfoCache.TryAdd(type, enumInfo);
        }

        return false;
    }

    #region TypeInfo

    public static Type GetFullType(List<RedTypeInfo> redTypeInfos)
    {
        Type? result = null;

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
                    ArgumentNullException.ThrowIfNull(redTypeInfos[i].MappedType);

                    result = redTypeInfos[i].MappedType!.MakeGenericType(redTypeInfos[i].RedObjectType);
                }
                else
                {
                    ArgumentNullException.ThrowIfNull(redTypeInfos[i].MappedType);

                    result = redTypeInfos[i].MappedType!;
                }
            }
            else
            {
                ArgumentNullException.ThrowIfNull(redTypeInfos[i].MappedType);

                result = redTypeInfos[i].MappedType!.MakeGenericType(result);
            }
        }

        if (result == null)
        {
            throw new TypeNotFoundException("");
        }

        return result;
    }

    public static List<RedTypeInfo> GetRedTypeInfos(Type type, Flags? flags = null) =>
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