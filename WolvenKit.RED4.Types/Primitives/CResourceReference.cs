using System;

namespace WolvenKit.RED4.Types
{
    public class CResourceReference<T> : IRedResourceReference<T>, IEquatable<CResourceReference<T>> where T : IRedType
    {
        public ushort Value { get; set; }

        public ushort GetValue() => Value;
        public void SetValue(ushort value) => Value = value;


        public override bool Equals(object obj)
        {
            if (obj is CResourceReference<T> cObj)
            {
                return Equals(obj);
            }

            return false;
        }

        public bool Equals(CResourceReference<T> other)
        {
            if (other == null)
            {
                return false;
            }

            return Value.Equals(other.Value);
        }
    }
}
