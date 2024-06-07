using System.Buffers;
using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Text;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.Types.Helpers;

namespace WolvenKit.RED4.Types;

public static class NodeRefPool
{
    private static readonly ConcurrentDictionary<UInt128, ulong> s_pool = new();
    private static readonly ConcurrentDictionary<ulong, StringPart> s_poolReverse = new();

    public static string? ResolveHash(ulong hash) => s_poolReverse.GetValueOrDefault(hash)?.Materialize();

    public static ulong AddOrGetHash(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return 0;
        }
        
        // Handling non-path strings. Those, that does not begin with $
        if(value[0] != '$')
        {
            return AddOrGetHashNonPath(value);
        }

        // Since some of the path parts can contain character '#' to specify an alias -
        // we need to remove said characters before hashing the path
        using var hashRemover = new PathHashRemover(value);
        var valueSpan = hashRemover.Span;
        var valueMemory = hashRemover.Memory;
        
        // Checking if value was already cached
        if (s_pool.TryGetValue(CreateStringHash(valueSpan), out var existingHash))
        {
            // It does exist. Returning it's hash.
            return existingHash;
        }

        // Hash does not exist yet and we deal with path-looking string
        // First we generate hash for full string
        // $/03_night_city/#c_city_center/corpo_plaza/path/to/somewhere
        var result = AddHash(hashRemover.Memory);
        
        // Now we split and generate a hash for each part of the path
        // Like this:
        // $/03_night_city/
        // $/03_night_city/#c_city_center/
        // <...>

        const char splitter = '/';
        
        var start = 0;
        var currentSearchIndex = valueSpan.IndexOf(splitter);

        while (currentSearchIndex != -1)
        {
            // Extract the substring from the start to the current index + 1
            var part = valueMemory[..(currentSearchIndex + 1)];

            if (part.Length != 2)
            {
                // Skip hashing of $/
                AddHash(part);
            }

            // Move the start to the current index + 1 for the next iteration
            start = currentSearchIndex + 1;

            // Find the next occurrence of the splitter
            currentSearchIndex = valueSpan[start..].IndexOf(splitter);

            if (currentSearchIndex != -1)
            {
                currentSearchIndex += start; // Adjust index relative to the original span
            }
        }

        // Handle the final part after the last splitter, if any
        if (start < valueSpan.Length)
        {
            AddHash(valueMemory);
        }
        
        return result;
    }
    
    private static ulong AddHash(ReadOnlyMemory<char> value)
    {
        var span = value.Span;
        var hash = FNV1A64HashAlgorithm.HashString(span, Encoding.UTF8, false, true);
        
        s_pool.TryAdd(CreateStringHash(span), hash);
        s_poolReverse.TryAdd(hash, new StringPart(value));

        return hash;
    }

    private static ulong AddOrGetHashNonPath(string value)
    {
        var key = CreateStringHash(value);
        
        if (!s_pool.TryGetValue(key, out var hash))
        {
            hash = FNV1A64HashAlgorithm.HashString(value, Encoding.UTF8, false, true);

            s_pool.TryAdd(key, hash);
            s_poolReverse.TryAdd(hash, new StringPart(value, 0, value.Length));
        }

        return hash;
    }

    private static unsafe UInt128 CreateStringHash(ReadOnlySpan<char> value)
    {
        // Two buffers, for both serialized string and generated hash
        var strBuffer = ArrayPool<byte>.Shared.Rent(value.Length);
        var hashBuffer = ArrayPool<byte>.Shared.Rent(16);
        
        try
        {
            // Serializing string as ASCII, since we don't actually have any UTF-8 characters in string.
            Encoding.ASCII.GetBytes(value, strBuffer);

            // Hashing serialized string
            MD5.HashData(strBuffer, hashBuffer);

            fixed (byte* hashPtr = &hashBuffer[0])
            {
                return *(UInt128*)&hashPtr;
            }
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(strBuffer);
            ArrayPool<byte>.Shared.Return(hashBuffer);
        }
    }
}