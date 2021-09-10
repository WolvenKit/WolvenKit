using System.Collections;
using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    public interface IRedArray : IList, IRedPrimitive
    {
    }

    public interface IRedArray<T> : IList<T>, IRedArray, IRedGenericType<T>
    {
    }

    public interface IRedArrayFixedSize : IList, IRedPrimitive
    {
    }

    public interface IRedArrayFixedSize<T> : IList<T>, IRedArrayFixedSize, IRedGenericType<T>
    {
    }

    public interface IRedStatic : IList, IRedPrimitive
    {
    }

    public interface IRedStatic<T> : IList<T>, IRedStatic, IRedGenericType<T>
    {
    }
}
