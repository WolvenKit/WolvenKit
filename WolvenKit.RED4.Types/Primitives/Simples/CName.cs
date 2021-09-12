using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.RED4.Types
{
    [RED("CName")]
    [DebuggerDisplay("{_value}", Type = "CName")]
    public sealed class CName : IRedPrimitive<string>, IEquatable<CName>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly string _value;

        public CName() { }
        private CName(string value)
        {
            _value = value;
        }

        public int Length => _value.Length;

        public uint GetRedHash()
        {
            if (string.IsNullOrEmpty(_value))
            {
                return 0;
            }

            var buffer = Encoding.UTF8.GetBytes(_value);
            var sBuffer = Array.ConvertAll(buffer, b => b != 0x80 ? (byte)Math.Abs((sbyte)b) : (byte)0x80);
            var hash64 = FNV1A64HashAlgorithm.HashReadOnlySpan(sBuffer);

            return (uint)((hash64 >> 32) ^ (uint)hash64);
        }

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
