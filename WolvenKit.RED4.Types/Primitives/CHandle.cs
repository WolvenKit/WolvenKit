using System;
using System.Collections;
using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    [RED("handle")]
    public class CHandle<T> : IRedHandle<T>, IEquatable<CHandle<T>> where T : IRedClass
    {
        private IList<IRedClass> _referenceList;

        public int Pointer { get; set; }

        public T Reference
        {
            get
            {
                if (_referenceList == null)
                    return default;
                return (T)_referenceList[Pointer - 1];
            }
        }

        public int GetValue() => Pointer;
        public void SetValue(int value) => Pointer = value;

        public void SetReferenceList(IList<IRedClass> referenceList)
        {
            _referenceList = referenceList;
        }

        public bool Equals(CHandle<T> other)
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

            return Equals((CHandle<T>)obj);
        }

        public override int GetHashCode() => Pointer;
    }
}
