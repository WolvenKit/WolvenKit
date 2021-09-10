using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.RED4.Types
{
    [RED("CName")]
    [DebuggerDisplay("{_value}", Type = "CName")]
    public readonly struct CName : IRedPrimitive<string>, IEquatable<CName>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly string _value;

        private CName(string value)
        {
            _value = value;
        }

        public int Length => _value.Length;

        public uint GetRedHash()
        {
            var hash64 = string.IsNullOrEmpty(_value) ? 0 : FNV1A64HashAlgorithm.HashString(_value, Encoding.GetEncoding("iso-8859-1"), false, true);

            return (uint)((hash64 >> 32) ^ (uint)hash64);
        }

        [Obsolete("Use GetRedHash instead")]
        public uint GetOldRedHash()
        {
            var hash64 = string.IsNullOrEmpty(_value) ? 0 : FNV1A64HashAlgorithm.HashString(_value, Encoding.GetEncoding("iso-8859-1"), false, true);

            return (uint)(hash64 & 0xFFFFFFFF);
        }

        public static implicit operator CName(string value) => new(value);
        public static implicit operator string(CName value) => value._value;

        public override int GetHashCode() => _value.GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj is CName cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(CName other) => Equals(_value, other._value);
    }
}
