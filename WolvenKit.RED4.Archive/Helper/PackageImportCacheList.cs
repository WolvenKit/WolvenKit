using System.Collections.Generic;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive;

public class PackageImportCacheList : ICacheList<ImportEntry>
{
    private readonly List<ImportEntry> _valueList;
    private ushort _index;

    public ushort Count => _index;

    public PackageImportCacheList()
    {
        _valueList = new();
    }

    public ushort Add(ImportEntry value)
    {
        var found = false;
        foreach (var importEntry in _valueList)
        {
            if (Equals(importEntry.DepotPath, value.DepotPath))
            {
                found = true;

                // one is 0, one is 1, force 1
                if (!Equals(importEntry.Flag, value.Flag))
                {
                    importEntry.Flag = 1;
                }
            }
        }

        if (!found)
        {
            _valueList.Add(value);
            return (ushort)(_valueList.Count - 1);
        }
        return ushort.MaxValue;
    }

    public void AddRange(IList<ImportEntry> values)
    {
        foreach (var str in values)
        {
            Add(str);
        }
    }

    public bool Remove(ImportEntry item)
    {
        return _valueList.Remove(item);
    }

    public ushort IndexOf(ImportEntry value)
    {
        for (ushort i = 0; i < _valueList.Count; i++)
        {
            if (Equals(_valueList[i].DepotPath, value.DepotPath))
            {
                return i;
            }
        }

        return ushort.MaxValue;
    }

    public void Clear()
    {
        _valueList.Clear();
        _index = 0;
    }
    public List<ImportEntry> ToList()
    {
        return new List<ImportEntry>(_valueList);
    }
}
