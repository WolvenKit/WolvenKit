using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace WolvenKit.RED4.Types
{
    [RED("String")]
    [REDType(IsValueType = true)]
    [DebuggerDisplay("{_value}", Type = "CString")]
    public sealed class CString : IRedPrimitive<string>, IEquatable<CString>, IRedString, IComparable<CString>, IComparable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _value;

        public CString() { }

        private CString(string value)
        {
            _value = value;
        }

        public static implicit operator CString(string value) => new(value);
        public static implicit operator string(CString value) => value?._value ?? null;

        public static bool operator ==(CString a, CString b) => Equals(a, b);
        public static bool operator !=(CString a, CString b) => !(a == b);

        public override int GetHashCode() => _value.GetHashCode();

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

            return Equals((CString)obj);
        }

        public bool Equals(CString other) => Equals(_value, other._value);

        public string GetValue() => this;

        public void SetValue(string value) => _value = value;

        public override string ToString() => GetValue();

        public int CompareTo(object? obj)
        {
            if (obj is CString cs)
            {
                return CompareTo(cs);
            }
            return _value.CompareTo(obj);
        }

        public int CompareTo(CString? obj)
        {
            return _value.CompareTo(obj.ToString());
        }
    }
}
