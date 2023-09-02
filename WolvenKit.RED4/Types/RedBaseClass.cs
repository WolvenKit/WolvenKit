using System.Runtime.CompilerServices;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types;

public partial class RedBaseClass : IRedClass, IRedCloneable, IEquatable<RedBaseClass>
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

            if (propertyInfo.Type.IsValueType)
            {
                if (propertyInfo.Type.IsAssignableTo(typeof(IRedEnum)))
                {
                    var innerType = propertyInfo.Type.GetGenericArguments()[0];
                    var innerTypeInfo = RedReflection.GetEnumTypeInfo(innerType);
                    if (innerTypeInfo.DefaultValue != null)
                    {
                        InternalSetPropertyValue(propertyInfo.RedName, CEnum.Parse(innerType, innerTypeInfo.DefaultValue));
                        continue;
                    }
                }

                if (propertyInfo.Flags.Equals(Flags.Empty))
                {
                    if (System.Activator.CreateInstance(propertyInfo.Type) is not IRedType result)
                    {
                        throw new Exception();
                    }

                    InternalSetPropertyValue(propertyInfo.RedName, result);
                }
                else
                {
                    var flags = propertyInfo.Flags;
                    if (System.Activator.CreateInstance(propertyInfo.Type, flags.MoveNext() ? flags.Current : 0) is not IRedType result)
                    {
                        throw new Exception();
                    }

                    InternalSetPropertyValue(propertyInfo.RedName, result);
                }
            }
        }
    }

    internal void InternalSetPropertyValue(string propertyName, IRedType? value, bool onlyNative = true)
    {
        var propertyInfo = RedReflection.GetNativePropertyInfo(GetType(), propertyName);
        if (propertyInfo != null)
        {
            ArgumentNullException.ThrowIfNull(propertyInfo.RedName);
            propertyName = propertyInfo.RedName;

            if (propertyInfo.GenericType != null)
            {
                if (propertyInfo.GenericType == typeof(CArrayFixedSize<>) && !Equals(RedReflection.GetDefaultValue(propertyInfo.Type), value))
                {
                    var flags = propertyInfo.Flags;
                    var size = flags.MoveNext() ? flags.Current : 0;

                    if (value == null || ((IRedArray)value).Count > size)
                    {
                        throw new ArgumentException();
                    }
                }

                if (propertyInfo.GenericType == typeof(CStatic<>) && !Equals(RedReflection.GetDefaultValue(propertyInfo.Type), value))
                {
                    var flags = propertyInfo.Flags;
                    var maxSize = flags.MoveNext() ? flags.Current : 0;

                    ((IRedArray)value!).MaxSize = maxSize;
                }
            }
        }
        else
        {
            if (onlyNative)
            {
                throw new ArgumentException($"Native prop '{propertyName}' could not be found!");
            }

            if (!_dynamicProperties.ContainsKey(propertyName))
            {
                throw new ArgumentException($"Dynamic prop '{propertyName}' could not be found!");
            }
        }

        _properties[propertyName] = value;
    }

    #region Properties

    private readonly IDictionary<string, IRedType?> _properties = new Dictionary<string, IRedType?>();
    // private readonly IList<string> _dynamicProperties = new List<string>();


    /// <summary>
    /// Used only for native properties
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="callerName"></param>
    /// <returns></returns>
    protected T? GetPropertyValue<T>([CallerMemberName] string callerName = "") where T : IRedType
    {
        var propertyInfo = RedReflection.GetNativePropertyInfo(GetType(), callerName);

        ArgumentNullException.ThrowIfNull(propertyInfo?.RedName);

        if (_properties.ContainsKey(propertyInfo.RedName))
        {
            return (T?)_properties[propertyInfo.RedName];
        }
        return (T?)RedReflection.GetDefaultValue(typeof(T));
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

    public void SetProperty(string propertyName, IRedType? value) => InternalSetPropertyValue(propertyName, value, false);

    public IRedType? GetProperty(string propertyName)
    {
        if (_dynamicProperties.ContainsKey(propertyName))
        {
            return _properties[propertyName];
        }

        var propertyInfo = RedReflection.GetNativePropertyInfo(GetType(), propertyName);
        if (propertyInfo != null)
        {
            if ( propertyInfo.RedName is null)
            {
                throw new PropertyNotFoundException(" RedName is null ");
            }

            if (_properties.ContainsKey(propertyInfo.RedName))
            {
                return _properties[propertyInfo.RedName];
            }

            return (IRedType?)RedReflection.GetDefaultValue(propertyInfo.Type);
        }

        throw new PropertyNotFoundException();
    }

    public IRedType? GetPropertyDefaultValue(string name)
    {
        var propertyInfo = RedReflection.GetNativePropertyInfo(GetType(), name);
        if (propertyInfo == null)
        {
            return null;
        }

        ArgumentNullException.ThrowIfNull(propertyInfo.RedName);
        return (IRedType?)RedReflection.GetClassDefaultValue(propertyInfo.ContainingTypeInfo.Type, propertyInfo);
    }

    public bool ResetProperty(string name)
    {
        var propertyInfo = RedReflection.GetNativePropertyInfo(GetType(), name);
        if (propertyInfo != null)
        {
            ArgumentNullException.ThrowIfNull(propertyInfo.RedName);
            SetProperty(propertyInfo.RedName, (IRedType?)RedReflection.GetClassDefaultValue(propertyInfo.ContainingTypeInfo.Type, propertyInfo));
            return true;
        }

        if (_dynamicProperties.TryGetValue(name, out propertyInfo))
        {
            ArgumentNullException.ThrowIfNull(propertyInfo.RedName);
            SetProperty(propertyInfo.RedName, (IRedType?)RedReflection.GetClassDefaultValue(propertyInfo.ContainingTypeInfo.Type, propertyInfo));
            return true;
        }

        return false;
    }

    public List<string> GetPropertyNames() => new(_properties.Keys);
    

    #endregion Properties

    #region Dynamic Properties

    private readonly Dictionary<string, ExtendedPropertyInfo> _dynamicProperties = new();

    public ExtendedPropertyInfo AddDynamicProperty(string redName, Type type)
    {
        if (_dynamicProperties.ContainsKey(redName))
        {
            throw new TodoException("Property already defined");
        }

        var property = new ExtendedPropertyInfo(RedReflection.GetTypeInfo(GetType()), redName, type);

        _dynamicProperties.Add(redName , property);

        return property;
    }

    public IEnumerable<ExtendedPropertyInfo> GetWritableProperties()
    {
        foreach (var extendedPropertyInfo in RedReflection.GetTypeInfo(GetType()).GetWritableProperties())
        {
            yield return extendedPropertyInfo;
        }

        foreach (var extendedPropertyInfo in GetDynamicProperties())
        {
            yield return extendedPropertyInfo;
        }
    }

    public IEnumerable<ExtendedPropertyInfo> GetDynamicProperties()
    {
        foreach (var (name, info) in _dynamicProperties)
        {
            yield return info;
        }
    }

    public List<string> GetDynamicPropertyNames() => _dynamicProperties.Keys.ToList();

    #endregion

    #region IEquatable

    public override bool Equals(object? obj)
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

    public bool Equals(RedBaseClass? other)
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

    #endregion IEquatable
}