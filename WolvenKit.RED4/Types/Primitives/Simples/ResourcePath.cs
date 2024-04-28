using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.Types.Pools;

namespace WolvenKit.RED4.Types;

[RED("ResourcePath")]
[DebuggerDisplay("{GetResolvedText()}", Type = "ResourcePath")]
public readonly struct ResourcePath : IRedString, IRedPrimitive<string>, IEquatable<ResourcePath>, IComparable<ResourcePath>, IComparable
{
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

    public static string SanitizePath(string? text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return "";
        }

        var strResult = new StringBuilder();

        // strip all leading and trailing slashes and quotes
        char[] trimChars = { '\'', '"', '/', '\\', ' ', '\n', '\r' };
        text = text.Trim(trimChars);

        // append all remaining characters except repeated slashes
        for (var i = 0; i < text.Length; i++)
        {
            if (strResult.Length == 0)
            {
                strResult.Append(text[i]);
                continue;
            }

            if (text[i] == '\\' || text[i] == '/')
            {
                if (strResult[strResult.Length - 1] != '\\')
                {
                    strResult.Append('\\');
                }
                continue;
            }

            strResult.Append(text[i]);
        }
        return strResult.ToString().ToLowerInvariant();
    }

    public static ulong CalculateHash(string resourcePath) =>
        FNV1A64HashAlgorithm.HashString(SanitizePath(resourcePath));

    public string? GetString() => this;
    public override string? ToString() => GetResolvedText();
    public static bool IsNullOrEmpty([NotNullWhen(false)] ResourcePath path) => path == ResourcePath.Empty ? true : string.IsNullOrEmpty(path.ToString());
}