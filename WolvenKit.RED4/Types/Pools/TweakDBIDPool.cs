﻿using WolvenKit.Core.Helpers;

namespace WolvenKit.RED4.Types.Pools;

public static class TweakDBIDPool
{
    private static readonly BasePool s_pool;

    static TweakDBIDPool()
    {
        s_pool = new BasePool(null, TweakDBID.CalculateHash);
    }

    public static string? ResolveHash(ulong hash) => s_pool.ResolveHash(hash);

    public static bool IsNative(string value) => s_pool.IsNative(value);
    public static bool IsNative(ulong value) => s_pool.IsNative(value);

    public static bool IsRuntime(string value) => s_pool.IsRuntime(value);
    public static bool IsRuntime(ulong value) => s_pool.IsRuntime(value);

    public static ulong AddOrGetHash(string value)
    {
        var (_, hash) = s_pool.AddOrGetHash(value);
        return hash;
    }

    public static void SetNative(LookupTable lookupTable) => s_pool.SetNative(lookupTable);
}