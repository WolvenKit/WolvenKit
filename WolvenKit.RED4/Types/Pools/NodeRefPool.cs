using System.Collections.Concurrent;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.RED4.Types;

public static class NodeRefPool
{
    private static readonly ConcurrentDictionary<ulong, string> s_poolReverse = new();
    private static readonly ConcurrentDictionary<ReadOnlyMemory<char>, ReadOnlyMemory<char>> s_poolAliases = new(MemorySequenceEqualComparator.Instance);
    
    public static string? ResolveHash(ulong hash) => s_poolReverse.GetValueOrDefault(hash);

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

    public static ulong AddOrGetHash(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return 0;
        }

        var hash = FNV1A64HashAlgorithm.HashStringWithoutAliases(value);

        // Backwards resolving is already cached
        if (s_poolReverse.ContainsKey(hash))
            return hash;

        CacheBackwardsHash(value, hash);
        CacheAliases(value);

        return hash;
    }

    private static void CacheBackwardsHash(string value, ulong hash) => s_poolReverse.TryAdd(hash, value);
    
    private static void CacheAliases(string value)
    {
        if (!value.Contains('#'))
            return;

        var nextAliasPos = value.IndexOf('#');

        if (nextAliasPos == 0)
            throw new InvalidOperationException("Alias shouldn't be first in the string!");
        
        while(nextAliasPos != -1)
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

        var name = memory[(aliasPosition+1)..nameEndPosition];
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

        var name = memory[(aliasPosition+1)..nameEndPosition];
        var path = memory[..(aliasPosition - 1)]; 

        return (name, path);
    }
}