using System.Diagnostics;

namespace WolvenKit.RED4.Types
{
    [RED("String")]
    [REDType(IsValueType = true)]
    public sealed class CString : BaseStringType, IRedCloneable
    {
        public CString() { }
        private CString(string value) : base(value) { }

        public static implicit operator CString(string value) => new(value);
        public static implicit operator string(CString value) => value?._value ?? null;

        public static bool operator ==(CString a, CString b) => Equals(a, b);
        public static bool operator !=(CString a, CString b) => !(a == b);

        #region IRedCloneable

        public object ShallowCopy() => MemberwiseClone();

        public object DeepCopy() => new CString(_value);

        #endregion IRedCloneable

        public override string ToString() => this;

        private bool Equals(CString other) => string.Equals(_value, other?._value);

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

        public override int GetHashCode() => _value != null ? _value.GetHashCode() : 0;
    }
}
