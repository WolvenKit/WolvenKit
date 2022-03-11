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

        public bool Remove(T item)
        {
            return _valueList.Remove(item) && _keyValueList.Remove(item);
        }

        public ushort IndexOf(T value, IEqualityComparer<T> comparer = null)
        {
            comparer ??= EqualityComparer<T>.Default;

            foreach (var (element, index) in _keyValueList)
            {
                if (comparer.Equals(element, value))
                {
                    return index;
                }
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
