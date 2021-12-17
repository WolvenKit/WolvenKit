using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace WolvenKit.RED4.Types
{
    [REDMeta]
    public class RedBaseClass : DynamicObject, IRedClass
    {
        public int Chunk;

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

        object IRedClass.InternalGetPropertyValue(Type type, string redPropertyName, Flags flags)
        {
            if (!_properties.ContainsKey(redPropertyName))
            {
                if (type.IsValueType)
                {
                    if (flags.Equals(Flags.Empty))
                    {
                        _properties[redPropertyName] = System.Activator.CreateInstance(type);
                    }
                    else
                    {
                        var size = flags.MoveNext() ? flags.Current : 0;
                        _properties[redPropertyName] = System.Activator.CreateInstance(type, size);
                    }

                    //if (typeof(IRedEnum).IsAssignableFrom(type) || typeof(IRedBitField).IsAssignableFrom(type))
                    //{
                    //    _properties[redPropertyName] = System.Activator.CreateInstance(type);
                    //    return _properties[redPropertyName];
                    //}

                    return _properties[redPropertyName];
                }

                if (typeof(IRedEnum).IsAssignableFrom(type) ||
                    typeof(IRedBitField).IsAssignableFrom(type) ||
                    typeof(IRedRef).IsAssignableFrom(type) ||
                    typeof(IRedString).IsAssignableFrom(type))
                {
                    _properties[redPropertyName] = System.Activator.CreateInstance(type);
                    return _properties[redPropertyName];
                }

                return null;
            }

            return _properties[redPropertyName];
        }

        void IRedClass.InternalSetPropertyValue(string redPropertyName, object value, bool native)
        {
            if (value == null && _properties.ContainsKey(redPropertyName) && _properties[redPropertyName] is IRedBaseHandle d)
            {
                d.Remove();
            }

            //OnObjectChanged(redPropertyName, value);
            _properties[redPropertyName] = value;
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
