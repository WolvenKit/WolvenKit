using System.Collections.Concurrent;
using WolvenKit.Core.CRC;

namespace WolvenKit.RED4.Types;

public static class TweakDBIDPool
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
        if (!s_pool.TryGetValue(value, out var hash))
        {
            hash = Crc32Algorithm.Compute(value) + ((ulong)value.Length << 32);

            s_pool.TryAdd(value, hash);
            s_poolReverse.TryAdd(hash, value);
        }

        return hash;
    }

    public delegate string ExtResolveHash(ulong hash);
    public static ExtResolveHash ResolveHashHandler;
}