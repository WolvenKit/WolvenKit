using System;

namespace WolvenKit.RED4.Types
{
    [RED("whandle")]
    public class CWeakHandle<T> : IRedWeakHandle<T>, IEquatable<CWeakHandle<T>> where T : IRedClass
    {
        public int Pointer { get; set; }

        public int GetValue() => Pointer;
        public void SetValue(int value) => Pointer = value;

        public bool Equals(CWeakHandle<T> other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Pointer == other.Pointer;
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

            return Equals((CWeakHandle<T>)obj);
        }

        public override int GetHashCode() => Pointer;
    }
}
