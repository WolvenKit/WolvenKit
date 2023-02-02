using System.Collections.Concurrent;
using System.Text;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.RED4.Types;

public static class NodeRefPool
{
    private static readonly ConcurrentDictionary<string, ulong> s_pool = new();
    private static readonly ConcurrentDictionary<ulong, string> s_poolReverse = new();

    public static string? ResolveHash(ulong hash)
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
            hash = FNV1A64HashAlgorithm.HashString(value, Encoding.UTF8, false, true);

            s_pool.TryAdd(value, hash);
            s_poolReverse.TryAdd(hash, value);
        }

        return hash;
    }

    public delegate string? ExtResolveHash(ulong hash);
    public static ExtResolveHash? ResolveHashHandler;
}