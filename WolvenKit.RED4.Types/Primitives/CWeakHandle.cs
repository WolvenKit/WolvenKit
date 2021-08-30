using System;

namespace WolvenKit.RED4.Types
{
    public class CWeakHandle<T> : IRedHandle<T>, IEquatable<CWeakHandle<T>> where T : IRedClass
    {
        public int Pointer { get; set; }

        public int GetValue() => Pointer;
        public void SetValue(int value) => Pointer = value;


        public override bool Equals(object obj)
        {
            if (obj is CWeakHandle<T> cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(CWeakHandle<T> other)
        {
            if (other == null)
            {
                return false;
            }

            return Pointer.Equals(other.Pointer);
        }
    }
}
