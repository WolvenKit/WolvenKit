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
    //[DebuggerTypeProxy(typeof(RedBaseClassDebugView))]
    public class RedBaseClass : DynamicObject, IRedClass, IEquatable<RedBaseClass>
    {
        public string RedTypeName;

        public RedBaseClass()
        {
        }

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
                _properties[redPropertyName] = null;
                if (typeof(IRedPrimitive).IsAssignableFrom(type))
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
                }
            }

            return _properties[redPropertyName];
        }

        void IRedClass.InternalSetPropertyValue(string redPropertyName, object value, bool native)
        {
            _properties[redPropertyName] = value;

            if (!native)
            {
                _customProperties[redPropertyName] = value;
            }
        }

        public IDictionary<string, object> GetCustomProperties()
        {
            return _customProperties;
        }

        #region DynamicObject

        //[DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly IDictionary<string, object> _properties = new Dictionary<string, object>();
        private readonly IDictionary<string, object> _customProperties = new Dictionary<string, object>();

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            _properties[binder.Name] = value;
            return true;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            return base.TryGetMember(binder, out result);
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
                if (!property.Value.Equals(other._properties[property.Key]))
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode() => base.GetHashCode();
    }
}
