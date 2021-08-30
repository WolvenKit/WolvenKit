using System;

namespace WolvenKit.RED4.Types
{
    public class CHandle<T> : IRedHandle<T>, IEquatable<CHandle<T>> where T : IRedClass
    {
        public int Pointer { get; set; }

        public int GetValue() => Pointer;
        public void SetValue(int value) => Pointer = value;


        public override bool Equals(object obj)
        {
            if (obj is CHandle<T> cObj)
            {
                return Equals(obj);
            }

            return false;
        }

        public bool Equals(CHandle<T> other)
        {
            if (other == null)
            {
                return false;
            }

            return Pointer.Equals(other.Pointer);
        }
    }
}
