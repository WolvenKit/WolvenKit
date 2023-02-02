namespace WolvenKit.RED4.Types;

public class CArrayFixedSize<T> : CArrayBase<T?>, IRedArrayFixedSize<T?> where T : IRedType
{
    public CArrayFixedSize(int size) : base(size)
    {
        IsReadOnly = true;
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