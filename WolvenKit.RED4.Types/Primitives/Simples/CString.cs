using System;
using System.Diagnostics;
using System.IO;

namespace WolvenKit.RED4.Types
{
    [RED("String")]
    [DebuggerDisplay("{_value}", Type = "CString")]
    public sealed class CString : IRedPrimitive<string>, IEquatable<CString>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly string _value;

        public CString() { }

        private CString(string value)
        {
            _value = value;
        }

        public static implicit operator CString(string value) => new(value);
        public static implicit operator string(CString value) => value._value;


        public override int GetHashCode() => _value.GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj is CString cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(CString other) => Equals(_value, other._value);
    }
}
