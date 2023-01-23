using System.Collections;

namespace WolvenKit.RED4.Types;

public interface IRedArray : IRedPrimitive, IList
{
    public int MaxSize { get; set; }

    public Type InnerType { get; }

    public void AddRange(ICollection collection);
}

public interface IRedArray<T> : IRedArray, IRedGenericType<T>, IList<T>
{
}

public interface IRedArrayFixedSize : IRedPrimitive, IList
{
}

public interface IRedArrayFixedSize<T> : IRedArrayFixedSize, IRedGenericType<T>, IList<T>
{
}

public interface IRedStatic : IRedPrimitive, IList
{
}

public interface IRedStatic<T> : IRedStatic, IRedGenericType<T>, IList<T>
{
}