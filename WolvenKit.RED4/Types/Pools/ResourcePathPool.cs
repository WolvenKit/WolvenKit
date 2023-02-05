using System.Collections.Concurrent;
using System.Text;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.RED4.Types.Pools;

public static class ResourcePathPool
{
    private static readonly ConcurrentDictionary<string, ulong> s_pool = new();
    private static readonly ConcurrentDictionary<ulong, string> s_poolReverse = new();

    public static string ResolveHash(ulong hash)
    {
        if (s_poolReverse.TryGetValue(hash, out var value))
        {
            return value;
        }

        return ResolveHashHandler?.Invoke(hash);
    }

    public static ulong AddOrGetHash(string value)
    {
        var sanitizedValue = ResourcePath.SanitizePath(value);

        if (!s_pool.TryGetValue(sanitizedValue, out var hash))
        {
            hash = FNV1A64HashAlgorithm.HashString(sanitizedValue, Encoding.UTF8, false, true);

            s_pool.TryAdd(sanitizedValue, hash);
            s_poolReverse.TryAdd(hash, sanitizedValue);
        }

        return hash;
    }

    public delegate string ExtResolveHash(ulong hash);
    public static ExtResolveHash ResolveHashHandler;
}