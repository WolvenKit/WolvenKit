namespace WolvenKit.RED4.Types;

public class CArrayFixedSize<T> : CArrayBase<T>, IRedArrayFixedSize<T> where T : IRedType
{
    public CArrayFixedSize(int size) : base(size)
    {
        IsReadOnly = true;

        for (var i = 0; i < size; i++)
        {
            this[i] = System.Activator.CreateInstance<T>();
        }
    }

    public CArrayFixedSize(Flags flags) : base(flags.Current)
    {
        IsReadOnly = true;

        var hasNext = flags.MoveNext();
        for (var i = 0; i < Count; i++)
        {
            if (hasNext)
            {
                this[i] = (T)RedTypeManager.CreateRedType(typeof(T), flags.Clone());
            }
            else
            {
                this[i] = (T)RedTypeManager.CreateRedType(typeof(T));
            }
        }
    }

    // TODO [CArrayFixedSize]: Find a better way to do this (just for `worldStaticCollisionShapeCategories_CollisionNode`)
    public CArrayFixedSize(int size1, int size2) : base(size1)
    {
        IsReadOnly = true;

        for (var i = 0; i < size1; i++)
        {
            this[i] = (T)RedTypeManager.CreateRedType(typeof(T), size2);
        }
    }

    public override object DeepCopy()
    {
        var other = new CArrayFixedSize<T>(_internalList.Count);

        for (var i = 0; i < _internalList.Count; i++)
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