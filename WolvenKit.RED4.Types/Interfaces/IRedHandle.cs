using System.Collections;
using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    public interface IRedHandle : IRedType
    {
        public int Pointer { get; set; }

        public int GetValue();
        public void SetValue(int value);

        public void SetReferenceList(IList<IRedClass> referenceList);
    }

    public interface IRedHandle<T> : IRedHandle, IRedGenericType<T>
    {
    }
}
