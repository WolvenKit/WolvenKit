using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace WolvenKit.RED4.Types
{
    [REDMeta]
    public class RedBaseClass : DynamicObject, IRedType, IRedNotifyObjectChanged, IRedCloneable, IEquatable<RedBaseClass>
    {
        #region Events

        public event ObjectChangedEventHandler ObjectChanged;

        private readonly Dictionary<string, ObjectChangedEventHandler> _delegateCache = new();


        private void AddEventHandler(string redPropertyName)
        {
            if (!_delegateCache.ContainsKey(redPropertyName))
            {
                _delegateCache.Add(redPropertyName, delegate (object sender, ObjectChangedEventArgs args)
                {
                    var path = $"{redPropertyName}.{args.RedPath}";
                    if (args.RedPath.StartsWith(':'))
                    {
                        path = $"{redPropertyName}{args.RedPath}";
                    }
                    ObjectChanged?.Invoke(sender, new ObjectChangedEventArgs(args.ChangeType, path, args.RedName, args.OldValue, args.NewValue));
                });
            }

            if (_properties[redPropertyName] is IRedNotifyObjectChanged notify)
            {
                notify.ObjectChanged += _delegateCache[redPropertyName];
            }
        }

        private void RemoveEventHandler(string redPropertyName)
        {
            if (!_delegateCache.ContainsKey(redPropertyName))
            {
                return;
            }

            if (_properties[redPropertyName] is IRedNotifyObjectChanged notify)
            {
                notify.ObjectChanged -= _delegateCache[redPropertyName];
            }
        }

        private void OnObjectChanged(string redPropertyName, object oldValue, object newValue)
        {
            ObjectChanged?.Invoke(this, new ObjectChangedEventArgs(ObjectChangedType.Modified, redPropertyName, redPropertyName, oldValue, newValue));
        }

        #endregion

        private string GetRedName(string propertyName)
        {
            var property = RedReflection.GetPropertyByName(this.GetType(), propertyName);

            return property?.RedName ?? propertyName;
        }

        protected T GetPropertyValue<T>([CallerMemberName] string callerName = "") where T : IRedType
        {
            var propertyInfo = RedReflection.GetPropertyByName(this.GetType(), callerName);
            return (T)InternalGetPropertyValue(typeof(T), propertyInfo.RedName, propertyInfo.Flags);
        }

        protected void SetPropertyValue<T>(T value, [CallerMemberName] string callerName = "") where T : IRedType
        {
            var redName = GetRedName(callerName);
            InternalSetPropertyValue(redName, value, true);
        }

        internal void InternalInitClass()
        {
            var info = RedReflection.GetTypeInfo(GetType());
            foreach (var propertyInfo in info.PropertyInfos)
            {
                if (string.IsNullOrEmpty(propertyInfo.RedName))
                {
                    continue;
                }

                if (!_properties.ContainsKey(propertyInfo.RedName))
                {
                    var propTypeInfo = RedReflection.GetTypeInfo(propertyInfo.Type);
                    if (propertyInfo.Type.IsValueType || propTypeInfo.IsValueType)
                    {
                        if (propertyInfo.Flags.Equals(Flags.Empty))
                        {
                            _properties[propertyInfo.RedName] = System.Activator.CreateInstance(propertyInfo.Type);
                        }
                        else
                        {
                            var size = propertyInfo.Flags.MoveNext() ? propertyInfo.Flags.Current : 0;
                            _properties[propertyInfo.RedName] = System.Activator.CreateInstance(propertyInfo.Type, size);
                        }
                    }
                }

                if (_properties.ContainsKey(propertyInfo.RedName))
                {
                    if (propertyInfo.Type.IsGenericType && propertyInfo.Type.GetGenericTypeDefinition() == typeof(CStatic<>))
                    {
                        var flags = propertyInfo.Flags.Clone();
                        ((IRedArray)_properties[propertyInfo.RedName]).MaxSize = flags.MoveNext() ? flags.Current : 0;
                    }

                    if (typeof(RedBaseClass).IsAssignableFrom(propertyInfo.Type))
                    {
                        ((RedBaseClass)_properties[propertyInfo.RedName]).InternalInitClass();
                    }
                }
            }
        }

        internal object InternalGetPropertyValue(Type type, string redPropertyName, Flags flags)
        {
            if (!_properties.ContainsKey(redPropertyName))
            {
                _properties[redPropertyName] = null;
            }

            return _properties[redPropertyName];
        }

        internal void InternalSetPropertyValue(string redPropertyName, object value, bool native)
        {
            object oldValue = null;
            if (_properties.ContainsKey(redPropertyName))
            {
                oldValue = _properties[redPropertyName];
            }

            if (!Equals(oldValue, value))
            {
                RemoveEventHandler(redPropertyName);

                _properties[redPropertyName] = value;

                AddEventHandler(redPropertyName);

                OnObjectChanged(redPropertyName, oldValue, value);
            }
        }

        public IRedType GetObjectByRedName(string redName)
        {
            if (_properties.ContainsKey(redName))
            {
                return (IRedType)_properties[redName];
            }

            return null;
        }

        public Dictionary<string, object> ToDictionary(bool clone = true)
        {
            if (clone)
            {
                var copy = (RedBaseClass)DeepCopy();
                return copy.ToDictionary(false);
            }

            var dict = new Dictionary<string, object>();
            foreach (var property in _properties)
            {
                if (property.Value is RedBaseClass rbc)
                {
                    dict.Add(property.Key, rbc.ToDictionary(false));
                }
                else
                {
                    dict.Add(property.Key, property.Value);
                }
            }

            return dict;
        }

        public IEnumerable<(string propPath, object value)> GetEnumerator(string rootName = "root")
        {
            var queue = new Queue<(RedBaseClass, string)>();
            var visited = new List<RedBaseClass>();

            foreach (var tuple in InternalFindType(this))
            {
                yield return tuple;
            }

            IEnumerable<(string propPath, object value)> InternalFindType(RedBaseClass cls)
            {
                queue.Enqueue((cls, rootName));
                while (queue.Count != 0)
                {
                    var (cls1, path) = queue.Dequeue();

                    if (visited.Contains(cls1))
                    {
                        continue;
                    }

                    foreach (var entry in cls1._properties)
                    {
                        var propPath = $"{path}.{entry.Key}";

                        foreach (var tuple in ProcessValue(propPath, entry.Value))
                        {
                            yield return tuple;
                        }
                    }

                    visited.Add(cls1);
                }
            }

            IEnumerable<(string propPath, object value)> ProcessValue(string propPath, object value)
            {
                if (value == null)
                {
                    yield break;
                }

                yield return (propPath, value);

                if (value is IList lst)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        var arrPath = $"{propPath}:{i}";
                        foreach (var tuple in ProcessValue(arrPath, lst[i]))
                        {
                            yield return tuple;
                        }
                    }
                }

                if (value is RedBaseClass subCls)
                {
                    queue.Enqueue((subCls, propPath));
                }

                if (value is IRedBaseHandle handle)
                {
                    queue.Enqueue((handle.GetValue(), propPath));
                }
            }
        }

        public List<string> FindType(Type targetType, string rootName = "root")
        {
            var result = new List<string>();
            foreach (var tuple in GetEnumerator(rootName))
            {
                if (tuple.value.GetType() == targetType)
                {
                    result.Add(tuple.propPath);
                }
            }

            return result;
        }

        public (bool, object) GetFromXPath(string xPath)
        {
            return GetFromXPath(xPath.Split('.'));
        }

        public (bool, object) GetFromXPath(string[] xPath)
        {
            object result = null;
            var currentProps = _properties;
            foreach (var part in xPath)
            {
                if (currentProps == null)
                {
                    return (false, null);
                }

                var arrPath = part.Split(':');
                if (currentProps.ContainsKey(arrPath[0]))
                {
                    result = currentProps[arrPath[0]];

                    currentProps = null;

                    if (result is IList lst)
                    {
                        if (arrPath.Length == 2 && int.TryParse(arrPath[1], out var index))
                        {
                            if (index >= lst.Count)
                            {
                                return (false, null);
                            }

                            result = lst[index];
                        }
                    }

                    if (result is RedBaseClass subCls)
                    {
                        currentProps = subCls._properties;
                    }

                    if (result is IRedBaseHandle handle)
                    {
                        var cCls = handle.GetValue();
                        currentProps = ((RedBaseClass)cCls)._properties;
                    }

                    continue;
                }

                return (false, null);
            }

            return (true, result);
        }

        public object ShallowCopy()
        {
            return MemberwiseClone();
        }

        public object DeepCopy()
        {
            var other = (RedBaseClass)MemberwiseClone();

            foreach (var property in _properties)
            {
                if (property.Value is IRedCloneable cl)
                {
                    other._properties[property.Key] = cl.DeepCopy();
                }
            }

            return other;
        }

        #region DynamicObject

        private readonly IDictionary<string, object> _properties = new Dictionary<string, object>();

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            InternalSetPropertyValue(binder.Name, value, false);

            return true;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            return _properties.TryGetValue(binder.Name, out result);
        }

        #endregion DynamicObject

        public override bool Equals(object obj)
        {
            if (obj is RedBaseClass cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(RedBaseClass other)
        {
            var tmp1 = _properties.Count;
            var tmp2 = other._properties.Count;

            if (_properties.Count != other._properties.Count)
            {
                return false;
            }
            if (_properties.Keys.Except(other._properties.Keys).Any())
            {
                return false;
            }
            if (other._properties.Keys.Except(_properties.Keys).Any())
            {
                return false;
            }

            foreach (var property in _properties)
            {
                if (!Equals(property.Value, other._properties[property.Key]))
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode() => base.GetHashCode();
    }
}
