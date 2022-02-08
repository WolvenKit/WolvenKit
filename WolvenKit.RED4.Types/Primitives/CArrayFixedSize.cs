using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    public class CArrayFixedSize<T> : CArrayBase<T>, IRedArrayFixedSize<T> where T : IRedType
    {
        public CArrayFixedSize(int size) : base(size)
        {
            IsReadOnly = true;
        }
    }
}
