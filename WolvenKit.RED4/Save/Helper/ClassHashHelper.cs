using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class ClassHashHelper
{
    private static readonly Dictionary<ulong, Type> s_classHashes = new();
    private static Dictionary<Type, ulong> s_classHashesReverse = new();


    private static void GenerateClassHashes()
    {
        foreach (var redType in RedReflection.GetTypes())
        {
            s_classHashes.Add(FNV1A64HashAlgorithm.HashString(redType.Key), redType.Value);
        }

        s_classHashesReverse = s_classHashes.ToDictionary(x => x.Value, x => x.Key);
    }

    public static Type? GetTypeFromHash(ulong hash)
    {
        if (s_classHashes.Count == 0)
        {
            GenerateClassHashes();
        }

        return s_classHashes.TryGetValue(hash, out var result) ? result : null;
    }

    public static ulong GetHashFromType(Type type)
    {
        if (s_classHashesReverse.Count == 0)
        {
            GenerateClassHashes();
        }

        return s_classHashesReverse[type];
    }

    public static ExtendedPropertyInfo? GetPropertyInfo(Type clsType, ulong propHash)
    {
        var typeInfo = RedReflection.GetTypeInfo(clsType);
        foreach (var propertyInfo in typeInfo.PropertyInfos)
        {
            if (string.IsNullOrEmpty(propertyInfo.RedName))
            {
                continue;
            }

            if (FNV1A64HashAlgorithm.HashString(propertyInfo.RedName) == propHash)
            {
                return propertyInfo;
            }
        }

        if (typeInfo.BaseType != null && typeInfo.BaseType != typeof(RedBaseClass))
        {
            return GetPropertyInfo(typeInfo.BaseType, propHash);
        }

        return null;
    }

    public static ulong GetRedTypeHash(ExtendedPropertyInfo propertyInfo) =>
        FNV1A64HashAlgorithm.HashString(RedReflection.GetRedTypeFromCSType(propertyInfo.Type, propertyInfo.Flags));
}