using System.Collections;
using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    public interface IRedArray : IRedPrimitive
    {
    }

    public interface IRedArray<T> : IRedArray, IRedGenericType<T>
    {
    }

    public interface IRedArrayFixedSize : IRedPrimitive
    {
    }

    public interface IRedArrayFixedSize<T> : IRedArrayFixedSize, IRedGenericType<T>
    {
    }

    public interface IRedStatic : IRedPrimitive
    {
    }

    public interface IRedStatic<T> : IRedStatic, IRedGenericType<T>
    {
    }
}
