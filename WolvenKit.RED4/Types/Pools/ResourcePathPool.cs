using System.Collections.Concurrent;
using System.Text;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.RED4.Types.Pools;

public static class ResourcePathPool
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
    public static bool IsNative(ulong value) => s_nativePoolReverse.ContainsKey(value);

    public static bool IsRuntime(string value) => s_pool.ContainsKey(value);
    public static bool IsRuntime(ulong value) => s_poolReverse.ContainsKey(value);

    public static void AddNativeString(string value)
    {
        var hash = ResourcePath.CalculateHash(value);

        s_nativePool.TryAdd(value, hash);
        s_nativePoolReverse.TryAdd(hash, value);
    }

    public static ulong AddOrGetHash(string value)
    {
        var sanitizedValue = ResourcePath.SanitizePath(value);

        if (s_nativePool.TryGetValue(sanitizedValue, out var hash))
        {
            return hash;
        }

        if (s_pool.TryGetValue(sanitizedValue, out hash))
        {
            return hash;
        }

        hash = FNV1A64HashAlgorithm.HashString(sanitizedValue, Encoding.UTF8, false, true);

        s_pool.TryAdd(sanitizedValue, hash);
        s_poolReverse.TryAdd(hash, sanitizedValue);

        return hash;
    }

    public static void SetNative(ConcurrentDictionary<ulong, string> dict)
    {
        s_nativePoolReverse = dict;
        s_nativePool = new ConcurrentDictionary<string, ulong>();

        foreach (var (key, value) in dict)
        {
            s_nativePool.GetOrAdd(value, key);
        }
    }

    public delegate string? ExtResolveHash(ulong hash);
    public static ExtResolveHash? ResolveHashHandler;
}