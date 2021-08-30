using System.Collections;
using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    public interface IRedArray : IList
    {
    }

    public interface IRedArray<T> : IList<T>, IRedPrimitive<T>, IRedArray
    {
    }
}
