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
    public class RedBaseClass : DynamicObject, IRedClass, IRedCloneable
    {
        #region Events

        public class ObjectChangedEventArgs : EventArgs
        {
            public string RedName { get; }
            public object OldValue { get; }
            public object NewValue { get; }

            public ObjectChangedEventArgs(string redName, object oldValue, object newValue)
            {
                RedName = redName;
                OldValue = oldValue;
                NewValue = newValue;
            }
        }

        private static ThreadLocal<EventHandlerList> s_listEventDelegates = new(() => new EventHandlerList());

        public delegate void ObjectChangedEventHandler(object sender, ObjectChangedEventArgs e);

        public static bool RegisterEventHandler(Type type, ObjectChangedEventHandler handler)
        {
            if (!typeof(IRedType).IsAssignableFrom(type))
            {
                return false;
            }

            s_listEventDelegates.Value.AddHandler(type, handler);

            return true;
        }

        public static bool RemoveEventHandler(Type type, ObjectChangedEventHandler handler)
        {
            if (!typeof(IRedType).IsAssignableFrom(type))
            {
                return false;
            }

            s_listEventDelegates.Value.RemoveHandler(type, handler);

            return true;
        }

        private void OnObjectChanged(string redPropertyName, object value)
        {
            var exists = _properties.ContainsKey(redPropertyName);
            if ((exists && _properties[redPropertyName] != null) || value != null)
            {
                var oldValue = exists ? _properties[redPropertyName] : null;

                var type = value != null ? value.GetType() : oldValue.GetType();
                if (type.IsGenericType)
                {
                    type = type.GetGenericTypeDefinition();
                }

                if (s_listEventDelegates.Value[type] is ObjectChangedEventHandler del)
                {
                    if (!Equals(oldValue, value))
                    {
                        del.Invoke(this, new ObjectChangedEventArgs(redPropertyName, oldValue, value));
                    }
                }

            }
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
            return (T)((IRedClass)this).InternalGetPropertyValue(typeof(T), propertyInfo.RedName, propertyInfo.Flags.Clone());
        }

        protected void SetPropertyValue<T>(T value, [CallerMemberName] string callerName = "") where T : IRedType
        {
            var redName = GetRedName(callerName);
            ((IRedClass)this).InternalSetPropertyValue(redName, value);
        }

        void IRedClass.InternalInitClass()
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

                    if (typeof(IRedClass).IsAssignableFrom(propertyInfo.Type))
                    {
                        ((IRedClass)_properties[propertyInfo.RedName]).InternalInitClass();
                    }
                }
            }
        }

        object IRedClass.InternalGetPropertyValue(Type type, string redPropertyName, Flags flags)
        {
            if (!_properties.ContainsKey(redPropertyName))
            {
                _properties[redPropertyName] = null;
            }

            return _properties[redPropertyName];
        }

        void IRedClass.InternalSetPropertyValue(string redPropertyName, object value, bool native)
        {
            //OnObjectChanged(redPropertyName, value);
            _properties[redPropertyName] = value;
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

        public List<string> FindType(Type targetType, string rootName = "root")
        {
            var queue = new Queue<(RedBaseClass, string)>();
            var visited = new List<RedBaseClass>();
            var result = new List<string>();

            InternalFindType(this);

            return result;

            void InternalFindType(RedBaseClass cls)
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

                        ProcessValue(propPath, entry.Value);
                    }

                    visited.Add(cls1);
                }
            }

            void ProcessValue(string propPath, object value)
            {
                if (value == null)
                {
                    return;
                }

                if (value.GetType() == targetType)
                {
                    result.Add(propPath);
                }

                if (value is IList lst)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        var arrPath = $"{propPath}:{i}";
                        ProcessValue(arrPath, lst[i]);
                    }
                }

                if (value is RedBaseClass subCls)
                {
                    queue.Enqueue((subCls, propPath));
                }

                if (value is IRedBaseHandle handle)
                {
                    queue.Enqueue(((RedBaseClass)handle.GetValue(), propPath));
                }
            }
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
            //OnObjectChanged(binder.Name, value);
            _properties[binder.Name] = value;

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
