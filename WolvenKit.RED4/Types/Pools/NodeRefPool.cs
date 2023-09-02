﻿using System.Collections.Concurrent;
using System.Text;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.RED4.Types;

public static class NodeRefPool
{
    //public static ILoggerService? Logger;

    private static readonly ConcurrentDictionary<string, ulong> s_pool = new();
    private static readonly ConcurrentDictionary<ulong, string> s_poolReverse = new();

    private static readonly ConcurrentDictionary<string, ulong> s_aliasLookup = new();

    public static string? ResolveHash(ulong hash)
    {
        if (s_poolReverse.TryGetValue(hash, out var value))
        {
            return value;
        }

        return null;
    }

    public static ulong AddOrGetHash(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return 0;
        }

        ulong hash;
        if (value[0] == '$')
        {
            if (!s_pool.TryGetValue(value.Replace("#", ""), out hash))
            {
                var tmpFull = "$";
                var tmpHash = "$";

                var parts = value.Split('/');
                for (var i = 1; i < parts.Length; i++)
                {
                    var part = parts[i];

                    string? alias = null;
                    if (part.Contains(';'))
                    {
                        var tmp = part.Split(';');

                        part = tmp[0];
                        alias = tmp[1][1..];
                    }

                    tmpFull += $"/{part}";

                    if (part[0] == '#')
                    {
                        part = part[1..];
                        alias = part;
                    }

                    tmpHash += $"/{part}";
                    hash = FNV1A64HashAlgorithm.HashString(tmpHash, Encoding.UTF8, false, true);

                    s_pool.TryAdd(tmpFull, hash);
                    s_poolReverse.TryAdd(hash, tmpFull);

                    if (alias != null)
                    {
                        s_aliasLookup.AddOrUpdate(alias, hash, (_, _) => hash);
                    }
                }
            }
        }
        //else if (value[0] == '#')
        //{
        //    if (!s_aliasLookup.TryGetValue(value.Substring(1), out hash))
        //    {
        //        Logger?.Warning($"Couldn't resolve NodeRef for alias \"{value}\"");
        //    }
        //}
        else if (!s_pool.TryGetValue(value, out hash))
        {
            hash = FNV1A64HashAlgorithm.HashString(value, Encoding.UTF8, false, true);

            s_pool.TryAdd(value, hash);
            s_poolReverse.TryAdd(hash, value);
        }

        return hash;
    }

    //public static bool IsAlias(string text)
    //{
    //    if (text.StartsWith('#'))
    //    {
    //        text = text.Substring(1);
    //    }
    //
    //    return s_aliasLookup.ContainsKey(text);
    //}
    //
    //public static string? ResolveAlias(string? text)
    //{
    //    if (text == null || !s_aliasLookup.TryGetValue(text, out var value))
    //    {
    //        return null;
    //    }
    //
    //    return s_poolReverse[value];
    //}
}