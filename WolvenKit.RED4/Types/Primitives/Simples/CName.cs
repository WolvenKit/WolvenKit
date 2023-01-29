using System.Diagnostics;
using System.Text;
using WolvenKit.RED4.Types.Pools;

namespace WolvenKit.RED4.Types;

[RED("CName")]
[DebuggerDisplay("{GetResolvedText()}", Type = "CName")]
public readonly struct CName : IRedString, IRedPrimitive<string>, IEquatable<CName>, IComparable<CName>, IComparable
{
    public static CName Empty = 0;

    private readonly ulong _hash;


    private CName(ulong value) => _hash = value;

    public int Length => GetResolvedText()?.Length ?? -1;

    public string GetResolvedText() => CNamePool.ResolveHash(_hash);
    public bool IsResolvable => CNamePool.ResolveHash(_hash) != null;

    public ulong GetRedHash() => _hash;
    public uint GetShortRedHash() => (uint)((_hash >> 32) ^ (uint)_hash);

    [Obsolete("Use GetRedHash instead")]
    public uint GetOldRedHash() => (uint)(_hash & 0xFFFFFFFF);

    public static implicit operator CName(string value) => new(CNamePool.AddOrGetHash(value));
    public static implicit operator string(CName value) => value.GetResolvedText();

    public static implicit operator CName(ulong value) => new(value);
    public static implicit operator ulong(CName value) => value._hash;

    public static bool operator ==(CName a, CName b) => Equals(a, b);
    public static bool operator !=(CName a, CName b) => !(a == b);

    // used to sanitize resource paths
    public static CName GetHashSanitized(string text)
    {
        if (string.IsNullOrEmpty(text) || text == "None")
        {
            return 0;
        }

        var strResult = new StringBuilder();

        // replace all forward slashes with backslash
        text = text.Replace('/', '\\');

        // strip all leading and trailing slashes and quotes
        while ("\"'\\".Contains(text[0]))
        {
            text = text.Substring(1, text.Length - 1);
        }

        while ("\"'\\".Contains(text[text.Length - 1]))
        {
            text = text.Substring(0, text.Length - 1);
        }

        // append all remaining characters except repeated slashes
        foreach (var element in text.ToCharArray())
        {
            if (strResult.Length == 0)
            {
                strResult.Append(element);
                continue;
            }

            if (element == '\\')
            {
                if (strResult[strResult.Length - 1] != '\\')
                {
                    strResult.Append('\\');
                }
                continue;
            }

            strResult.Append(element);
        }
        return strResult.ToString().ToLowerInvariant();
    }


    public int CompareTo(object value)
    {
        if (value == null)
        {
            return 1;
        }

        if (value is not CName other)
        {
            throw new ArgumentException();
        }

        return CompareTo(other);
    }

    public int CompareTo(CName other)
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

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (obj.GetType() != GetType())
        {
            return false;
        }

        return Equals((CName)obj);
    }

    public bool Equals(CName other)
    {
        if (!Equals(GetRedHash(), other.GetRedHash()))
        {
            return false;
        }

        return true;
    }

    public string GetString() => this;
    public override string ToString() => GetResolvedText();
}