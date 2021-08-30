using System;

namespace WolvenKit.RED4.Types
{
    public class CResourceAsyncReference<T> : IRedResourceReference<T>, IEquatable<CResourceAsyncReference<T>> where T : IRedType
    {
        public ushort Value { get; set; }

        public ushort GetValue() => Value;
        public void SetValue(ushort value) => Value = value;


        public override bool Equals(object obj)
        {
            if (obj is CResourceAsyncReference<T> cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(CResourceAsyncReference<T> other)
        {
            if (other == null)
            {
                return false;
            }

            return Value.Equals(other.Value);
        }
    }
}
