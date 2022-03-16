using System.Collections.Generic;

namespace WolvenKit.RED4.Types;

public interface ICacheList<T>
{
    public ushort Count { get; }

    public ushort Add(T value);
    public void AddRange(IList<T> collection);
    public bool Remove(T item);
    public ushort IndexOf(T value);
    public void Clear();
    public List<T> ToList();
}
