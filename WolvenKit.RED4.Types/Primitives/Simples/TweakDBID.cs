using System;
using System.Diagnostics;
using System.Globalization;
using WolvenKit.Core.CRC;

namespace WolvenKit.RED4.Types
{
    [RED("TweakDBID")]
    [REDType(IsValueType = true)]
    [DebuggerDisplay("{_value}", Type = "TweakDBID")]
    public sealed class TweakDBID : IRedPrimitive<ulong>, IEquatable<TweakDBID>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _value;

        private ulong _hash;


        // TODO: Just to support current rtti classes, will be removed in the future
        internal ulong Value
        {
            set
            {
                _value = null;
                _hash = value;
            }
        }

        public TweakDBID() { }

        private TweakDBID(string val)
        {
            _value = val;
            _hash = CalculateHash();
        }

        private TweakDBID(ulong value)
        {
            _value = null;
            _hash = value;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int Length => _value?.Length ?? 0;

        private ulong CalculateHash() => Crc32Algorithm.Compute(_value) + ((ulong)_value.Length << 32);


        public static implicit operator TweakDBID(string value) => new(value);
        public static implicit operator string(TweakDBID value) => value._value;

        public static implicit operator TweakDBID(ulong value) => new(value);
        public static implicit operator ulong(TweakDBID value) => value._hash;

        public static bool operator ==(TweakDBID a, TweakDBID b) => Equals(a, b);
        public static bool operator !=(TweakDBID a, TweakDBID b) => !(a == b);

        public bool Equals(TweakDBID other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Equals(_value, other._value) && Equals(_hash, other._hash);
        }

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

            return Equals((TweakDBID)obj);
        }

        public override int GetHashCode() => HashCode.Combine(_value.GetHashCode(), _hash.GetHashCode());

        public override string ToString() => $"{_value} <TweakDBID 0x{_hash:X8}:0x{Length:X2} / {_hash}:{Length}>";
    }
}
