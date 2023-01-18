using System;
using System.Collections.Generic;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    [RED("static")]
    public class CStatic<T> : CArrayBase<T>, IRedStatic<T> where T : IRedType
    {
        public CStatic() { }
        public CStatic(int size) : base(size) { }
        public override object DeepCopy()
        {
            var other = new CStatic<T>(_internalList.Count);

            for (int i = 0; i < _internalList.Count; i++)
            {
                if (_internalList[i] is IRedCloneable cl)
                {
                    other[i] = (T)cl.DeepCopy();
                }
                else
                {
                    other[i] = _internalList[i];
                }
            }

            return other;
        }
    }
}
