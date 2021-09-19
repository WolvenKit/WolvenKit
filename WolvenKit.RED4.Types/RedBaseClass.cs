using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace WolvenKit.RED4.Types
{
    [REDMeta]
    public class RedBaseClass : DynamicObject, IRedClass
    {
        private string GetRedName(string propertyName)
        {
            var property = RedReflection.GetPropertyByName(this.GetType(), propertyName);

            return property.RedName;
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

                    return _properties[redPropertyName];
                }

                return null;
            }

            return _properties[redPropertyName];
        }

        void IRedClass.InternalSetPropertyValue(string redPropertyName, object value, bool native)
        {
            if (value == null && _properties[redPropertyName] is IRedBaseHandle d)
            {
                d.Remove();
            }

            _properties[redPropertyName] = value;
        }

        #region DynamicObject

        private readonly IDictionary<string, object> _properties = new Dictionary<string, object>();

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
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
