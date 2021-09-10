using System;
using System.Diagnostics;

namespace WolvenKit.RED4.Types
{
    [RED("Bool")]
    [DebuggerDisplay("{_value,nq}", Type = "CBool")]
    public readonly struct CBool : IRedPrimitive<bool>, IEquatable<CBool>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly bool _value;

        private CBool(bool value)
        {
            _value = value;
        }

        public static implicit operator CBool(bool value) => new(value);
        public static implicit operator bool(CBool value) => value._value;

        public bool Equals(CBool other) => _value == other._value;

        public override bool Equals(object obj) => obj is CBool other && Equals(other);

        public override int GetHashCode() => _value.GetHashCode();
    }
}
