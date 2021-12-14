using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.RED4.Types
{
    [RED("CName")]
    [DebuggerDisplay("{_value}", Type = "CName")]
    public sealed class CName : IRedPrimitive<string>, IEquatable<CName>, IRedString
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly string _value;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ulong _hash;

        public CName() { }

        private CName(string value)
        {
            _value = value;
            _hash = CalculateHash();
        }

        private CName(ulong value)
        {
            _value = null;
            _hash = value;
        }

        public int Length => _value?.Length ?? -1;

        private ulong CalculateHash()
        {
            if (_value == "")
            {
                return 0;
            }

            var buffer = Encoding.UTF8.GetBytes(_value);
            var sBuffer = Array.ConvertAll(buffer, b => b != 0x80 ? (byte)Math.Abs((sbyte)b) : (byte)0x80);
            return FNV1A64HashAlgorithm.HashReadOnlySpan(sBuffer);
        }

        public ulong GetRedHash() => _hash;
        public uint GetShortRedHash() => (uint)((_hash >> 32) ^ (uint)_hash);

        [Obsolete("Use GetRedHash instead")]
        public uint GetOldRedHash()
        {
            if (string.IsNullOrEmpty(_value))
            {
                return 0;
            }

            var buffer = Encoding.UTF8.GetBytes(_value);
            var sBuffer = Array.ConvertAll(buffer, b => b != 0x80 ? (byte)Math.Abs((sbyte)b) : (byte)0x80);
            var hash64 = FNV1A64HashAlgorithm.HashReadOnlySpan(sBuffer);

            return (uint)(hash64 & 0xFFFFFFFF);
        }

        public static implicit operator CName(string value) => new(value);
        public static implicit operator string(CName value) => value._value;

        public static implicit operator CName(ulong value) => new(value);
        public static implicit operator ulong(CName value) => value._hash;

        public override int GetHashCode() => _hash.GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj is CName cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(CName other) => Equals(GetRedHash(), other.GetRedHash());

        public string GetValue() => (string)this;
    }
}
