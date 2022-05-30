using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types
{
    public partial class RedBaseClass : IRedType, IRedCloneable, IEquatable<RedBaseClass>
    {
        public RedBaseClass()
        {
            InternalInitClass();
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

                var propTypeInfo = RedReflection.GetTypeInfo(propertyInfo.Type);
                if (propertyInfo.Type.IsValueType || propTypeInfo.IsValueType)
                {
                    if (propertyInfo.Flags.Equals(Flags.Empty))
                    {
                        InternalSetPropertyValue(propertyInfo.RedName, (IRedType)System.Activator.CreateInstance(propertyInfo.Type));
                    }
                    else
                    {
                        var flags = propertyInfo.Flags;
                        InternalSetPropertyValue(propertyInfo.RedName, (IRedType)System.Activator.CreateInstance(propertyInfo.Type, flags.MoveNext() ? flags.Current : 0));
                    }
                }
            }
        }

        internal void InternalSetPropertyValue(string propertyName, IRedType value, bool onlyNative = true)
        {
            var propertyInfo = RedReflection.GetNativePropertyInfo(GetType(), propertyName);
            if (propertyInfo != null)
            {
                propertyName = propertyInfo.RedName;

                if (propertyInfo.GenericType != null)
                {
                    if (propertyInfo.GenericType == typeof(CArrayFixedSize<>) && !Equals(RedReflection.GetDefaultValue(propertyInfo.Type), value))
                    {
                        var flags = propertyInfo.Flags;
                        var size = flags.MoveNext() ? flags.Current : 0;

                        if (((IRedArray)value).Count > size)
                        {
                            throw new ArgumentException();
                        }
                    }

                    if (propertyInfo.GenericType == typeof(CStatic<>) && !Equals(RedReflection.GetDefaultValue(propertyInfo.Type), value))
                    {
                        var flags = propertyInfo.Flags;
                        var maxSize = flags.MoveNext() ? flags.Current : 0;

                        ((IRedArray)value).MaxSize = maxSize;
                    }
                }
            }
            else
            {
                if (onlyNative)
                {
                    throw new ArgumentException($"Native prop '{propertyName}' could not be found!");
                }

                if (!_dynamicProperties.Contains(propertyName))
                {
                    _dynamicProperties.Add(propertyName);
                }
            }

            _properties[propertyName] = value;
        }

        #region Properties

        private readonly IDictionary<string, IRedType> _properties = new Dictionary<string, IRedType>();
        private readonly IList<string> _dynamicProperties = new List<string>();


        /// <summary>
        /// Used only for native properties
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="callerName"></param>
        /// <returns></returns>
        protected T GetPropertyValue<T>([CallerMemberName] string callerName = "") where T : IRedType
        {
            var propertyInfo = RedReflection.GetNativePropertyInfo(GetType(), callerName);
            if (propertyInfo != null && _properties.ContainsKey(propertyInfo.RedName))
            {
                return (T)_properties[propertyInfo.RedName];
            }
            return (T)RedReflection.GetDefaultValue(typeof(T));
        }

        /// <summary>
        /// Used only for native properties
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="callerName"></param>
        protected void SetPropertyValue<T>(T value, [CallerMemberName] string callerName = "") where T : IRedType
            => InternalSetPropertyValue(callerName, value);

        public bool HasProperty(string propertyName) => _properties.ContainsKey(propertyName) || RedReflection.GetNativePropertyInfo(GetType(), propertyName) != null;

        public void SetProperty(string propertyName, IRedType value) => InternalSetPropertyValue(propertyName, value, false);

        public IRedType GetProperty(string propertyName)
        {
            if (_dynamicProperties.Contains(propertyName))
            {
                return _properties[propertyName];
            }

            var propertyInfo = RedReflection.GetNativePropertyInfo(GetType(), propertyName);
            if (propertyInfo != null)
            {
                if (_properties.ContainsKey(propertyInfo.RedName))
                {
                    return _properties[propertyInfo.RedName];
                }

                return (IRedType)RedReflection.GetDefaultValue(propertyInfo.Type);
            }

            throw new PropertyNotFoundException();
        }

        public bool ResetProperty(string name)
        {
            var propertyInfo = RedReflection.GetNativePropertyInfo(GetType(), name);
            if (propertyInfo != null)
            {
                SetProperty(propertyInfo.RedName, (IRedType)RedReflection.GetDefaultValue(propertyInfo.Type));
                return true;
            }

            if (_dynamicProperties.Contains(name))
            {
                _dynamicProperties.Remove(name);
                _properties.Remove(name);

                return true;
            }

            return false;
        }

        public List<string> GetPropertyNames() => new(_properties.Keys);
        public List<string> GetDynamicPropertyNames() => new(_dynamicProperties);

        #endregion Properties

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

            return Equals((RedBaseClass)obj);
        }

        public bool Equals(RedBaseClass other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (_properties.Count != other._properties.Count)
            {
                return false;
            }

            foreach (var property in _properties)
            {
                if (!other._properties.ContainsKey(property.Key))
                {
                    return false;
                }

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
