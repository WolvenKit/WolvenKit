using System.Collections.Concurrent;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Helpers;

namespace WolvenKit.RED4.Types.Pools;

public static class NodeRefPool
{
    private static readonly BasePool s_pool;

    static NodeRefPool()
    {
        s_pool = new BasePool(null, s => FNV1A64HashAlgorithm.HashStringWithoutAliases(s));
    }

    private static readonly ConcurrentDictionary<ReadOnlyMemory<char>, ReadOnlyMemory<char>> s_poolAliases = new(MemorySequenceEqualComparator.Instance);

    public static string? ResolveHash(ulong hash) => s_pool.ResolveHash(hash);

    public static bool IsNative(string value) => s_pool.IsNative(value);
    public static bool IsNative(ulong value) => s_pool.IsNative(value);

    public static bool IsRuntime(string value) => s_pool.IsRuntime(value);
    public static bool IsRuntime(ulong value) => s_pool.IsRuntime(value);

    public static ulong AddOrGetHash(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return 0;
        }

        var (newRuntime, hash) = s_pool.AddOrGetHash(value);
        if (newRuntime)
        {
            CacheAliases(value);
        }

        return hash;
    }

    public static void SetNative(LookupTable lookupTable)
    {
        s_pool.SetNative(lookupTable);
        foreach (var (_, value) in lookupTable)
        {
            CacheAliases(value);
        }
    }

    #region Alias

    public static ReadOnlyMemory<char>? ResolveAliasToMemory(ReadOnlyMemory<char> aliasName) =>
        s_poolAliases.GetValueOrDefault(aliasName, null);

    public static string? ResolveAliasToString(ReadOnlyMemory<char> aliasName)
    {
        var memory = ResolveAliasToMemory(aliasName);
        return memory != null ? new string(memory.Value.Span) : null;
    }

    public static ulong? ResolveAliasToHash(ReadOnlyMemory<char> aliasName)
    {
        var memory = ResolveAliasToMemory(aliasName);
        return memory != null ? FNV1A64HashAlgorithm.HashStringWithoutAliases(memory.Value.Span) : null;
    }

    private static void CacheAliases(string value)
    {
        if (value[0] != '$' || !value.Contains('#'))
        {
            return;
        }

        var nextAliasPos = value.IndexOf('#');

        if (nextAliasPos == 0)
        {
            throw new InvalidOperationException("Alias shouldn't be first in the string!");
        }

        while (nextAliasPos != -1)
        {
            // We have to handle 2 cases:
            // $/test/#important/123/456 - simple syntax
            // $/test/important;#alias/123/456 - semicolon syntax (named alias)

            var semicolonSyntax = value[nextAliasPos - 1] == ';';

            var (aliasName, aliasPath) = !semicolonSyntax ?
                HandleSimpleAlias(value, nextAliasPos) :
                HandleSemicolonAlias(value, nextAliasPos);

            s_poolAliases.TryAdd(aliasName, aliasPath);

            nextAliasPos = value.IndexOf('#', nextAliasPos + 1);
        }
    }

    private static (ReadOnlyMemory<char> Name, ReadOnlyMemory<char> Path) HandleSimpleAlias(string value, int aliasPosition)
    {
        // Handling simple syntax
        // $/test/#important/123/456

        var memory = value.AsMemory();

        var indexOfSlash = value.IndexOf('/', aliasPosition);
        var nameEndPosition = indexOfSlash != -1 ? indexOfSlash : value.Length;

        var name = memory[(aliasPosition + 1)..nameEndPosition];
        var path = memory[..nameEndPosition];

        return (name, path);
    }

    private static (ReadOnlyMemory<char> Name, ReadOnlyMemory<char> Path) HandleSemicolonAlias(string value, int aliasPosition)
    {
        // Handling semicolon syntax
        // $/test/important;#alias/123/456

        var memory = value.AsMemory();

        var indexOfSlash = value.IndexOf('/', aliasPosition);
        var nameEndPosition = indexOfSlash != -1 ? indexOfSlash : value.Length;

        var name = memory[(aliasPosition + 1)..nameEndPosition];
        var path = memory[..(aliasPosition - 1)];

        return (name, path);
    }

    #endregion Alias
}