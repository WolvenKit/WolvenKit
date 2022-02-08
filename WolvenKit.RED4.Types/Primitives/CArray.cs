using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    [RED("array")]
    public class CArray<T> : CArrayBase<T>, IRedArray<T> where T : IRedType
    {
        
    }
}
