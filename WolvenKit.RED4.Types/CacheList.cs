using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public class CacheList<T> : ICacheList<T>
    {
        private readonly HashSet<T> _valueList;
        private readonly Dictionary<T, ushort> _keyValueList;
        private ushort _index;
        private IEqualityComparer<T> _comparer;

        public ushort Count => _index;

        public CacheList() : this(EqualityComparer<T>.Default) {}

        public CacheList(IEqualityComparer<T> comparer)
        {
            _comparer = comparer;

            _valueList = new HashSet<T>(_comparer);
            _keyValueList = new Dictionary<T, ushort>(_comparer);
        }

        public ushort Add(T value)
        {
            if (_valueList.Add(value))
            {
                _keyValueList.Add(value, _index);
                return _index++;
            }
            return ushort.MaxValue;
        }

        public void AddRange(IList<T> values)
        {
            foreach (var str in values)
            {
                Add(str);
            }
        }

        public bool Remove(T item)
        {
            return _valueList.Remove(item) && _keyValueList.Remove(item);
        }

        public ushort IndexOf(T value)
        {
            if (_keyValueList.TryGetValue(value, out var index))
            {
                return index;
            }

            return ushort.MaxValue;
        }

        public void Clear()
        {
            _valueList.Clear();
            _keyValueList.Clear();
            _index = 0;
        }
        public List<T> ToList()
        {
            return _keyValueList.Keys.ToList();
        }
    }
}
