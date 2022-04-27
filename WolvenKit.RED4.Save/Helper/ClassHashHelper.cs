using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class ClassHashHelper
{
    private static readonly Dictionary<ulong, Type> _classHashes = new();
    private static Dictionary<Type, ulong> _classHashesReverse = new();

    private static readonly Dictionary<ulong, RedReflection.ExtendedPropertyInfo> _propertyHashes = new();
    private static readonly Dictionary<Type, ulong> _typeHashes = new();


    private static void GenerateClassHashes()
    {
        foreach (var redType in RedReflection.GetTypes())
        {
            _classHashes.Add(FNV1A64HashAlgorithm.HashString(redType.Key), redType.Value);
        }

        _classHashesReverse = _classHashes.ToDictionary(x => x.Value, x => x.Key);
    }

    public static Type? GetTypeFromHash(ulong hash)
    {
        if (_classHashes.Count == 0)
        {
            GenerateClassHashes();
        }

        return _classHashes[hash];
    }

    public static ulong GetHashFromType(Type type)
    {
        if (_classHashesReverse.Count == 0)
        {
            GenerateClassHashes();
        }

        return _classHashesReverse[type];
    }

    public static RedReflection.ExtendedPropertyInfo? GetPropertyInfo(Type clsType, ulong propHash)
    {
        //if (_propertyHashes.ContainsKey(propHash))
        //{
        //    return _propertyHashes[propHash];
        //}

        var result = InternalGetProperty(clsType, propHash);
        if (result == null)
        {
            return null;
        }

        return result;


        RedReflection.ExtendedPropertyInfo? InternalGetProperty(Type clsType, ulong propertyHash)
        {
            var typeInfo = RedReflection.GetTypeInfo(clsType);
            foreach (var propertyInfo in typeInfo.PropertyInfos)
            {
                if (string.IsNullOrEmpty(propertyInfo.RedName))
                {
                    continue;
                }

                var hash = FNV1A64HashAlgorithm.HashString(propertyInfo.RedName);
                //if (!_propertyHashes.ContainsKey(hash))
                //{
                //    _propertyHashes.Add(hash, propertyInfo);
                //}
                
                if (propHash == hash)
                {
                    return propertyInfo;
                }
            }

            if (typeInfo.BaseType != typeof(RedBaseClass))
            {
                return InternalGetProperty(typeInfo.BaseType, propertyHash);
            }

            return null;
        }
    }

    public static ulong GetRedTypeHash(RedReflection.ExtendedPropertyInfo propertyInfo)
    {
        //if (_typeHashes.ContainsKey(type))
        //{
        //    return _typeHashes[type];
        //}

        var hash = FNV1A64HashAlgorithm.HashString(RedReflection.GetRedTypeFromCSType(propertyInfo.Type, propertyInfo.Flags));
        //_typeHashes.Add(type, hash);

        return hash;
    }
}
