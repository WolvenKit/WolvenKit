using System.Collections.Concurrent;

namespace WolvenKit.RED4.Types;

public static class TweakDBIDPool
{
    private static ConcurrentDictionary<string, ulong> s_nativePool = new();
    private static ConcurrentDictionary<ulong, string> s_nativePoolReverse = new();

    private static readonly ConcurrentDictionary<string, ulong> s_pool = new();
    private static readonly ConcurrentDictionary<ulong, string> s_poolReverse = new();

    public static string? ResolveHash(ulong hash)
    {
        if (s_nativePoolReverse.TryGetValue(hash, out var value))
        {
            return value;
        }

        if (s_poolReverse.TryGetValue(hash, out value))
        {
            return value;
        }

        return ResolveHashHandler?.Invoke(hash);
    }

    public static bool IsNative(string value) => s_nativePool.ContainsKey(value);

    public static void AddNativeString(string value)
    {
        var hash = TweakDBID.CalculateHash(value);

        s_nativePool.TryAdd(value, hash);
        s_nativePoolReverse.TryAdd(hash, value);
    }

    public static ulong AddOrGetHash(string value)
    {
        if (s_nativePool.TryGetValue(value, out var hash))
        {
            return hash;
        }

        if (s_pool.TryGetValue(value, out hash))
        {
            return hash;
        }

        hash = TweakDBID.CalculateHash(value);

        s_pool.TryAdd(value, hash);
        s_poolReverse.TryAdd(hash, value);

        return hash;
    }

    public static void SetNative(Dictionary<ulong, string> dict)
    {
        s_nativePoolReverse = new ConcurrentDictionary<ulong, string>(dict);
        s_nativePool = new ConcurrentDictionary<string, ulong>(dict.ToDictionary(x => x.Value, x => x.Key));
    }

    public delegate string? ExtResolveHash(ulong hash);
    public static ExtResolveHash? ResolveHashHandler;
}