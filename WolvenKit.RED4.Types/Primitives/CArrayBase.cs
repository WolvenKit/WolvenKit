using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WolvenKit.RED4.Types
{
    public class CArrayBase<T> : IRedArray<T>, IRedNotifyObjectChanged, IEquatable<CArrayBase<T>>
    {
        public int MaxSize { get; set; } = -1;

        public event ObjectChangedEventHandler ObjectChanged;


        private readonly List<T> _internalList;


        public CArrayBase()
        {
            _internalList = new List<T>();
        }

        public CArrayBase(int size)
        {
            _internalList = new List<T>(new T[size]);

            var propTypeInfo = RedReflection.GetTypeInfo(typeof(T));
            if (propTypeInfo.IsValueType)
            {
                for (var i = 0; i < Count; i++)
                {
                    this[i] = System.Activator.CreateInstance<T>();
                }
            }
        }
        public Type InnerType => typeof(T);

        #region Event

        private readonly Dictionary<object, ObjectChangedEventHandler> _delegateCache = new();

        private void AddEventHandler(object item)
        {
            if (item is IRedNotifyObjectChanged notify)
            {
                if (!_delegateCache.ContainsKey(item))
                {
                    _delegateCache.Add(item, delegate (object sender, ObjectChangedEventArgs args)
                    {
                        if (args._callStack.Contains(this))
                        {
                            return;
                        }
                        args._callStack.Add(this);

                        var index = ((IList)_internalList).IndexOf(item);
                        if (sender != null)
                        {
                            args.RedPath = $":{index}.{args.RedPath}";

                            ObjectChanged?.Invoke(sender, args);
                        }
                        else
                        {
                            args.RedPath = $":{index}";

                            ObjectChanged?.Invoke(this, args);
                        }
                    });
                }

                notify.ObjectChanged += _delegateCache[item];
            }
        }

        private void RemoveEventHandler(object item)
        {
            if (!_delegateCache.ContainsKey(item))
            {
                return;
            }

            if (item is IRedNotifyObjectChanged notify)
            {
                notify.ObjectChanged -= _delegateCache[item];
            }
        }

        private void OnObjectChanged(ObjectChangedType type, int index, object oldValue, object newValue)
        {
            if (ObjectChanged != null)
            {
                var args = new ObjectChangedEventArgs(type, $":{index}", null, oldValue, newValue);
                args._callStack.Add(this);

                ObjectChanged.Invoke(this, args);
            }
        }

        #endregion

        #region IList<>, ILits Methods

        public int Count => _internalList.Count;
        public bool IsFixedSize => ((IList)_internalList).IsFixedSize;
        public bool IsReadOnly { get; set; }
        public bool IsSynchronized => ((ICollection)_internalList).IsSynchronized;
        public object SyncRoot => ((ICollection)_internalList).IsSynchronized;

        private int AddItem(object value)
        {
            if (value is not T castedValue)
            {
                return -1;
            }

            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }

            if (Count == MaxSize)
            {
                throw new NotSupportedException();
            }

            _internalList.Add(castedValue);

            AddEventHandler(castedValue);

            var index = _internalList.Count - 1;
            OnObjectChanged(ObjectChangedType.Added, index, null, castedValue);

            return index;
        }

        private void SetItem(int index, object value)
        {
            if (!Equals(_internalList[index], value))
            {
                var oldValue = _internalList[index];

                if (_internalList[index] != null)
                {
                    RemoveEventHandler(_internalList[index]);
                }
                
                _internalList[index] = (T)value;

                if (_internalList[index] != null)
                {
                    AddEventHandler(_internalList[index]);
                }

                var typeInfo = RedReflection.GetTypeInfo(_internalList[index].GetType());
                if (_internalList[index].GetType().IsValueType || typeInfo.IsValueType)
                {
                    OnObjectChanged(ObjectChangedType.Modified, index, oldValue, _internalList[index]);
                }
            }
        }
        
        public T this[int index]
        {
            get => _internalList[index];
            set => SetItem(index, value);
        }

        object IList.this[int index]
        {
            get => _internalList[index];
            set => SetItem(index, value);
        }

        public void Add(T item) => AddItem(item);

        public int Add(object item) => AddItem(item);

        public void CopyTo(Array array, int index) => throw new NotImplementedException();

        public void Clear()
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }

            for (int i = 0; i < _internalList.Count; i++)
            {
                if (_internalList[i] != null)
                {
                    RemoveEventHandler(_internalList[i]);
                }

                OnObjectChanged(ObjectChangedType.Deleted, i, _internalList[i], null);
            }

            _internalList.Clear();
        }

        public bool Contains(T item) => _internalList.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => throw new NotImplementedException();

        public bool Contains(object value) => ((IList)_internalList).Contains(value);

        public int IndexOf(object value) => ((IList)_internalList).IndexOf(value);

        public void Insert(int index, object value)
        {
            OnObjectChanged(ObjectChangedType.Added, index, null, value);

            ((IList)_internalList).Insert(index, value);
        }

        public void Remove(object value)
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }

            var index = ((IList)_internalList).IndexOf(value);
            OnObjectChanged(ObjectChangedType.Deleted, index, value, null);

            ((IList)_internalList).Remove(value);
        }

        public bool Remove(T item)
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }

            var index = _internalList.IndexOf(item);
            OnObjectChanged(ObjectChangedType.Deleted, index, item, null);

            return _internalList.Remove(item);
        }

        public int IndexOf(T item) => _internalList.IndexOf(item);

        public void Insert(int index, T item)
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }

            if (Count == MaxSize)
            {
                throw new NotSupportedException();
            }

            OnObjectChanged(ObjectChangedType.Added, index, null, item);

            _internalList.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }

            OnObjectChanged(ObjectChangedType.Deleted, index, _internalList[index], null);

            _internalList.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public IEnumerator<T> GetEnumerator() => _internalList.GetEnumerator();

        #endregion IList<>, ILits Methods

        #region IEquatable

        public override bool Equals(object obj)
        {
            if (obj is CArrayBase<T> cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(CArrayBase<T> other)
        {
            if (other == null)
            {
                return false;
            }

            return this.SequenceEqual(other);
        }

        public override int GetHashCode() => base.GetHashCode();

        #endregion IEquatable
    }
}
