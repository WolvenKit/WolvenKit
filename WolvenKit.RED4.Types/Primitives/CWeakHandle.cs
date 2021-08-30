using System;

namespace WolvenKit.RED4.Types
{
    public class CWeakHandle<T> : IRedHandle<T>, IComparable, IComparable<CWeakHandle<T>>, IEquatable<CWeakHandle<T>> where T : IRedClass
    {
        public int Pointer { get; set; }

        public int GetValue() => Pointer;
        public void SetValue(int value) => Pointer = value;


        public int CompareTo(object obj)
        {
            if (obj.GetType() != GetType())
            {
                return -1;
            }

            return CompareTo(obj as CWeakHandle<T>);
        }

        public int CompareTo(CWeakHandle<T> other) => Pointer.CompareTo(other.Pointer);

        public override bool Equals(object obj)
        {
            if (obj is CWeakHandle<T> cObj)
            {
                return Equals(obj);
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
