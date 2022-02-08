using System.Collections.Generic;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    public class CacheList<T>
    {
        private readonly HashSet<T> _valueList = new();
        private readonly Dictionary<T, ushort> _keyValueList = new();
        private ushort _index;

        public ushort Count => _index;

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

        public ushort IndexOf(T value)
        {
            if (_valueList.Contains(value))
            {
                return _keyValueList[value];
            }
            return ushort.MaxValue;
        }

        public void Clear()
        {
            _valueList.Clear();
            _keyValueList.Clear();
            _index = 0;
        }

        public Dictionary<T, ushort> ToDictionary(IEqualityComparer<T> comparer = null)
        {
            return new Dictionary<T, ushort>(_keyValueList, comparer);
        }

        public List<T> ToList()
        {
            return _keyValueList.Keys.ToList();
        }
    }
}
