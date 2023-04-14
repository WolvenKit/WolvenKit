namespace WolvenKit.RED4.Types;

[RED("static")]
public class CStatic<T> : CArrayBase<T>, IRedStatic<T> where T : IRedType
{
    public CStatic(int size) => MaxSize = size;

    public CStatic(Flags flags)
    {
        MaxSize = flags.Current;

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