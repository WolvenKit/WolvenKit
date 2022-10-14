using System;
using System.Diagnostics;

namespace WolvenKit.RED4.Types
{
    [RED("String")]
    [DebuggerDisplay("{Value}", Type = "CString")]
    public readonly struct CString : IRedString, IRedPrimitive<CString>, IEquatable<CString>, IComparable<CString>, IComparable
    {
        public static CString Empty = "\0";


        private readonly string _value;

        private string Value => _value ?? "\0";


        private CString(string value) => _value = value;

        public static implicit operator CString(string value) => new(value);
        public static implicit operator string(CString value) => value.Value;

        public static bool operator ==(CString a, CString b) => Equals(a, b);
        public static bool operator !=(CString a, CString b) => !(a == b);

        public string GetString() => this;
        public override string ToString() => this;


        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }

            if (value is not CString other)
            {
                throw new ArgumentException();
            }

            return CompareTo(other);
        }

        public int CompareTo(CString other) => string.Compare(this, other);


        public bool Equals(CString other) => string.Equals(Value, other.Value);

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

            return Equals((CString)obj);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}