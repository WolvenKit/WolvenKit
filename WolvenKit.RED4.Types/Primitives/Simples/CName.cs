using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Text;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.RED4.Types
{
    [RED("CName")]
    [REDType(IsValueType = true)]
    [DebuggerDisplay("{_value}", Type = "CName")]
    public sealed class CName : BaseStringType, IEquatable<CName>
    {
        private static readonly ConcurrentDictionary<string, ulong> s_cNameCache = new();

        public delegate string ResolveHash(ulong hash);
        public static ResolveHash ResolveHashHandler;

        private readonly ulong _hash;

        public CName() { }

        private CName(string value) : base(value)
        {
            _hash = CalculateHash();
        }

        private CName(ulong value)
        {
            _hash = value;
        }

        public string GetResolvedText() => !string.IsNullOrEmpty(_value) ? _value : ResolveHashHandler?.Invoke(_hash);
        private ulong CalculateHash()
        {
            if (string.IsNullOrEmpty(_value))
            {
                return 0;
            }

            if (!s_cNameCache.ContainsKey(_value))
            {
                s_cNameCache.TryAdd(_value, FNV1A64HashAlgorithm.HashString(_value, Encoding.UTF8, false, true));
            }

            return s_cNameCache[_value];
        }

        public ulong GetRedHash() => _hash;
        public uint GetShortRedHash() => (uint)((_hash >> 32) ^ (uint)_hash);

        [Obsolete("Use GetRedHash instead")]
        public uint GetOldRedHash() => (uint)(_hash & 0xFFFFFFFF);

        public static implicit operator CName(string value) => new(value);
        public static implicit operator string(CName value) => value?._value; 

        public static implicit operator CName(ulong value) => new(value);
        public static implicit operator ulong(CName value) => value?._hash ?? 0;

        public static bool operator ==(CName a, CName b) => Equals(a, b);
        public static bool operator !=(CName a, CName b) => !(a == b);

        public override int GetHashCode() => _hash.GetHashCode();

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((CName)obj);
        }

        public bool Equals(CName other)
        {
            if (!Equals(GetRedHash(), other?.GetRedHash()))
            {
                return false;
            }

            return true;
        }

        public override string ToString() => GetResolvedText();
    }
}
