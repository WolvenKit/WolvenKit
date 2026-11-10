using System.Diagnostics;
using System.Reflection;

namespace WolvenKit.RED4.Types;

public class RedTypeCache
{
    private readonly Dictionary<string, List<(int Version, Type Type)>> _cache = new();
    private readonly Dictionary<Type, string> _cacheReverse = new();

    public void Add(Type type)
    {
        if (type.FullName is null
            || type.FullName.StartsWith("WolvenKit.RED4.Archive.Buffer") // hack: skip custom types derived f. IRedType
            || !typeof(IRedType).IsAssignableFrom(type))
        {
            return;
        }

        var name = type.Name;
        var version = (int)Enums.gameGameVersion.Current;

        var redAttr = type.GetCustomAttribute<REDAttribute>();
        if (redAttr != null)
        {
            name = redAttr.Name;
            version = (int)redAttr.GameVersion;
        }

        if (!_cache.TryGetValue(name, out var list))
        {
            _cache[name] = list = [];
            _cache[name].Add((version, type));
        }
        else
        {
            if (list.Any(x => x.Version == version))
            {
                Debugger.Break();
            }

            list.Add((version, type));
            list.Sort((a, b) => a.Version.CompareTo(b.Version));
        }

        if (!_cacheReverse.TryAdd(type, name))
        {
            Debugger.Break();
        }
    }

    public string? GetKey(Type type) => _cacheReverse.GetValueOrDefault(type);

    public Type? GetValue(string name, int version)
    {
        if (!_cache.TryGetValue(name, out var list) || list.Count == 0)
        {
            return null;
        }

        if (list.Count == 1)
        {
            return list[0].Type;
        }

        for (var i = list.Count - 1; i >= 0; i--)
        {
            if (list[i].Version <= version)
            {
                return list[i].Type;
            }
        }

        return list[^1].Type;
    }

    public Dictionary<string, Type> GetTypes()
    {
        var result = new Dictionary<string, Type>(_cache.Count);

        foreach (var (name, list) in _cache)
        {
            if (list.Count == 0)
            {
                throw new Exception();
            }

            result[name] = list[^1].Type;
        }

        return result;
    }
}
