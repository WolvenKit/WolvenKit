using System.Collections;
using System.Diagnostics;

namespace WolvenKit.RED4.Types;

[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
public abstract class CArrayBase<T> : IRedArray<T>, IRedCloneable, /*IRedNotifyObjectChanged, */IEquatable<CArrayBase<T>>
{
    private int _maxSize = -1;

    public int MaxSize
    {
        get
        {
            return _maxSize;
        }
        set
        {
            if (value < Count)
            {
                throw new ArgumentException(nameof(MaxSize));
            }

            _maxSize = value;
        }
    }

    // public event ObjectChangedEventHandler ObjectChanged;


    protected readonly List<T> _internalList;


    protected CArrayBase()
    {
        _internalList = new List<T>();
    }

    protected CArrayBase(int size)
    {
        _internalList = new List<T>(new T[size]);
    }

    protected CArrayBase(List<T> list)
    {
        _internalList = list;
    }

    public Type InnerType => typeof(T);

    public object ShallowCopy()
    {
        return MemberwiseClone();
    }

    public abstract object DeepCopy();

    #region Event
    /*
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

                    if (sender != null)
                    {
                        ObjectChanged?.Invoke(sender, args);
                    }
                    else
                    {
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

    private void OnObjectChanged(ObjectChangedType type, object oldValue, object newValue)
    {
        if (ObjectChanged != null)
        {
            var args = new ObjectChangedEventArgs(type, null, oldValue, newValue);
            args._callStack.Add(this);

            ObjectChanged.Invoke(this, args);
        }
    }
    */
    #endregion

    #region IList<>, ILits Methods

    public int Count => _internalList.Count;
    public bool IsFixedSize => ((IList)_internalList).IsFixedSize;
    public bool IsReadOnly { get; set; }
    public bool IsSynchronized => ((ICollection)_internalList).IsSynchronized;
    public object SyncRoot => ((ICollection)_internalList).IsSynchronized;

    private int AddItem(object value)
    {
        if (value != null && value is not T)
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

        var castedValue = (T)value;

        _internalList.Add(castedValue);

        //if (castedValue != null)
        //{
        //    AddEventHandler(castedValue);
        //    OnObjectChanged(ObjectChangedType.Added, null, castedValue);
        //}

        return _internalList.Count - 1;
    }

    private void SetItem(int index, object value)
    {
        _internalList[index] = (T)value;

        //if (!Equals(_internalList[index], value))
        //{
        //    var oldValue = _internalList[index];
        //
        //    if (_internalList[index] != null)
        //    {
        //        RemoveEventHandler(_internalList[index]);
        //    }
        //
        //    _internalList[index] = (T)value;
        //
        //    if (_internalList[index] != null)
        //    {
        //        AddEventHandler(_internalList[index]);
        //    }
        //
        //    var typeInfo = RedReflection.GetTypeInfo(_internalList[index].GetType());
        //    if (_internalList[index].GetType().IsValueType || typeInfo.IsValueType)
        //    {
        //        OnObjectChanged(ObjectChangedType.Modified, oldValue, _internalList[index]);
        //    }
        //}
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

    public void AddRange(ICollection collection)
    {
        if (IsReadOnly)
        {
            throw new NotSupportedException();
        }

        if ((collection.Count + Count) > MaxSize)
        {
            throw new NotSupportedException();
        }

        InsertRange(Count, collection);
    }

    public void AddRange(ICollection<T> collection)
    {
        if (IsReadOnly)
        {
            throw new NotSupportedException();
        }

        if ((collection.Count + Count) > MaxSize)
        {
            throw new NotSupportedException();
        }

        InsertRange(Count, collection);
    }

    public void CopyTo(Array array, int index) => throw new NotImplementedException();

    public void Clear()
    {
        if (IsReadOnly)
        {
            throw new NotSupportedException();
        }

        //foreach (var element in _internalList)
        //{
        //    if (element != null)
        //    {
        //        RemoveEventHandler(element);
        //    }
        //
        //    OnObjectChanged(ObjectChangedType.Deleted, element, null);
        //}

        _internalList.Clear();
    }

    public bool Contains(T item) => _internalList.Contains(item);

    public void CopyTo(T[] array, int arrayIndex) => ((IList)_internalList).CopyTo(array, arrayIndex);

    public bool Contains(object value) => ((IList)_internalList).Contains(value);

    public int IndexOf(object value) => ((IList)_internalList).IndexOf(value);

    public void Insert(int index, object value)
    {
        //OnObjectChanged(ObjectChangedType.Added, null, value);

        ((IList)_internalList).Insert(index, value);
    }

    public void InsertRange(int index, ICollection collection)
    {
        foreach (var item in collection)
        {
            Insert(index++, item);
        }
    }

    public void InsertRange(int index, ICollection<T> collection)
    {
        foreach (var item in collection)
        {
            Insert(index++, item);
        }
    }

    public void Remove(object value)
    {
        if (IsReadOnly)
        {
            throw new NotSupportedException();
        }

        //var index = ((IList)_internalList).IndexOf(value);
        //OnObjectChanged(ObjectChangedType.Deleted, value, null);

        ((IList)_internalList).Remove(value);
    }

    public bool Remove(T item)
    {
        if (IsReadOnly)
        {
            throw new NotSupportedException();
        }

        //var index = _internalList.IndexOf(item);
        //OnObjectChanged(ObjectChangedType.Deleted, item, null);

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

        //OnObjectChanged(ObjectChangedType.Added, null, item);

        _internalList.Insert(index, item);
    }

    public void RemoveAt(int index)
    {
        if (IsReadOnly)
        {
            throw new NotSupportedException();
        }

        //OnObjectChanged(ObjectChangedType.Deleted, _internalList[index], null);

        _internalList.RemoveAt(index);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    public IEnumerator<T> GetEnumerator() => _internalList.GetEnumerator();

    #endregion IList<>, ILits Methods

    #region IEquatable

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj.GetType() != this.GetType())
        {
            return false;
        }

        return Equals((CArrayBase<T>)obj);
    }

    public bool Equals(CArrayBase<T> other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        if (!Equals(Count, other.Count))
        {
            return false;
        }

        for (int i = 0; i < Count; i++)
        {
            if (!Equals(this[i], other[i]))
            {
                return false;
            }
        }

        return true;
    }

    public override int GetHashCode() => base.GetHashCode();

    #endregion IEquatable
}