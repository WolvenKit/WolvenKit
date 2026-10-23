using System.Buffers;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.Types.Pools;

namespace WolvenKit.RED4.Types;

[RED("ResourcePath")]
[DebuggerDisplay("{GetResolvedText()}", Type = "ResourcePath")]
public readonly struct ResourcePath : IRedString, IRedPrimitive<string>, IEquatable<ResourcePath>, IComparable<ResourcePath>, IComparable, IRedHashHolder
{
    public static readonly char DirectorySeparatorChar = '\\';

    public static ResourcePath Empty = 0;

    private readonly ulong _hash;


    private ResourcePath(ulong value) => _hash = value;

    public int Length => GetResolvedText()?.Length ?? -1;

    public string? GetResolvedText() => ResourcePathPool.ResolveHash(_hash);
    public bool IsResolvable => ResourcePathPool.ResolveHash(_hash) != null;

    public bool TryGetResolvedText([NotNullWhen(true)]out string? result)
    {
        result = ResourcePathPool.ResolveHash(_hash);
        return result != null;
    }

    public ulong GetRedHash() => _hash;
    public uint GetShortRedHash() => (uint)((_hash >> 32) ^ (uint)_hash);

    [Obsolete("Use GetRedHash instead")]
    public uint GetOldRedHash() => (uint)(_hash & 0xFFFFFFFF);

    public static implicit operator ResourcePath(string value) => new(ResourcePathPool.AddOrGetHash(value));
    public static implicit operator string?(ResourcePath value) => value.GetResolvedText();

    public static implicit operator ResourcePath(ulong value) => new(value);
    public static implicit operator ulong(ResourcePath value) => value._hash;

    public static bool operator ==(ResourcePath a, ResourcePath b) => Equals(a, b);
    public static bool operator !=(ResourcePath a, ResourcePath b) => !(a == b);


    public int CompareTo(object? value)
    {
        if (value == null)
        {
            return 1;
        }

        if (value is not ResourcePath other)
        {
            throw new ArgumentException();
        }

        return CompareTo(other);
    }

    public int CompareTo(ResourcePath other)
    {
        var strA = GetResolvedText();
        var strB = other.GetResolvedText();

        if (strA != null && strB != null)
        {
            return string.Compare(strA, strB, StringComparison.InvariantCulture);
        }

        return _hash.CompareTo(other._hash);
    }

    public override int GetHashCode() => _hash.GetHashCode();

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (obj.GetType() != GetType())
        {
            return false;
        }

        return Equals((ResourcePath)obj);
    }

    public bool Equals(ResourcePath other)
    {
        if (!Equals(GetRedHash(), other.GetRedHash()))
        {
            return false;
        }

        return true;
    }

    /// <summary>Leading/trailing characters stripped before normalizing. A literal span, so no array is allocated.</summary>
    private static ReadOnlySpan<char> TrimChars => ['\'', '"', '/', '\\', ' ', '\n', '\r'];

    /// <summary>
    /// Trims quotes/slashes/whitespace, collapses runs of separators into a single
    /// <see cref="DirectorySeparatorChar"/>, and lowercases the result.
    /// </summary>
    public static string SanitizePath(string? text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return "";
        }

        var trimmed = text.AsSpan().Trim(TrimChars);
        if (trimmed.IsEmpty)
        {
            return "";
        }

        // Nothing to change? Hand back the instance we were given.
        if (trimmed.Length == text.Length && IsAlreadySanitized(trimmed))
        {
            return text;
        }

        char[]? rented = null;
        Span<char> buffer = trimmed.Length <= 256
            ? stackalloc char[256]
            : (rented = ArrayPool<char>.Shared.Rent(trimmed.Length)).AsSpan();

        try
        {
            buffer = buffer[..trimmed.Length];

            // Lowercase first, then collapse in place.
            trimmed.ToLowerInvariant(buffer);

            // The first character is always copied verbatim
            // ... after trimming it can never be a separator.
            var written = 1;
            for (var i = 1; i < buffer.Length; i++)
            {
                var c = buffer[i];

                if (c == '\\' || c == '/')
                {
                    if (buffer[written - 1] != DirectorySeparatorChar)
                    {
                        buffer[written++] = DirectorySeparatorChar;
                    }

                    continue;
                }

                // written <= i always
                // so this never clears a chara we have not read yet
                buffer[written++] = c;
            }

            return new string(buffer[..written]);
        }
        finally
        {
            if (rented is not null)
            {
                ArrayPool<char>.Shared.Return(rented);
            }
        }
    }

    /// <summary>
    /// Deliberately bails out on any non-ASCII character so
    /// that casing decisions are always left to the exact <see cref="MemoryExtensions.ToLowerInvariant"/> path.
    /// </summary>
    private static bool IsAlreadySanitized(ReadOnlySpan<char> value)
    {
        var previousWasSeparator = false;

        foreach (var c in value)
        {
            if (c > 0x7F || c == '/' || c is >= 'A' and <= 'Z')
            {
                return false;
            }

            var isSeparator = c == DirectorySeparatorChar;
            if (isSeparator && previousWasSeparator)
            {
                return false;
            }

            previousWasSeparator = isSeparator;
        }

        return true;
    }

    public static ulong CalculateHash(string resourcePath, bool sanitize = true) =>
        FNV1A64HashAlgorithm.HashString(sanitize ? SanitizePath(resourcePath) : resourcePath);

    /// <summary>
    /// Hashes an already-sanitized resource path straight from its UTF-8 bytes, allocating nothing.
    /// Equivalent to <c>CalculateHash(text, sanitize: false)</c>.
    /// </summary>
    public static ulong CalculateHashUtf8(ReadOnlySpan<byte> utf8) =>
        Ascii.IsValid(utf8)
            ? FNV1A64HashAlgorithm.HashReadOnlySpan(utf8)
            : CalculateHash(Encoding.UTF8.GetString(utf8), false);

    public string? GetString() => this;
    public override string? ToString() => GetResolvedText();
    public static bool IsNullOrEmpty([NotNullWhen(false)] ResourcePath path) => path == ResourcePath.Empty ? true : string.IsNullOrEmpty(path.GetResolvedText());
}
