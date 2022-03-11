using System.Diagnostics;

namespace WolvenKit.RED4.Types
{
    [RED("String")]
    [REDType(IsValueType = true)]
    [DebuggerDisplay("{_value}", Type = "CString")]
    public sealed class CString : BaseStringType
    {
        public CString() { }
        private CString(string value) : base(value) { }

        public static implicit operator CString(string value) => new(value);
        public static implicit operator string(CString value) => value?._value ?? null;

        public static bool operator ==(CString a, CString b) => Equals(a, b);
        public static bool operator !=(CString a, CString b) => !(a == b);

        public override string ToString() => this;
    }
}
