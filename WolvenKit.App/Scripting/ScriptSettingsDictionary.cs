using Microsoft.ClearScript;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System;
using System.Linq;
using System.Numerics;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Scripting;

public class ScriptSettingsDictionary : Dictionary<string, object?>, ICustomTypeDescriptor
{
    private ILoggerService? _loggerService;

    public void SetLoggerService(ILoggerService? loggerService) => _loggerService = loggerService;

    #region ICustomTypeDescriptor Members

    public AttributeCollection GetAttributes() => TypeDescriptor.GetAttributes(this, true);

    public string? GetClassName() => TypeDescriptor.GetClassName(this, true);

    public string? GetComponentName() => TypeDescriptor.GetComponentName(this, true);

    public TypeConverter GetConverter() => TypeDescriptor.GetConverter(this, true);

    public EventDescriptor? GetDefaultEvent() => TypeDescriptor.GetDefaultEvent(this, true);

    public PropertyDescriptor? GetDefaultProperty() => TypeDescriptor.GetDefaultProperty(this, true);

    public object? GetEditor(Type editorBaseType) => TypeDescriptor.GetEditor(this, editorBaseType, true);

    public EventDescriptorCollection GetEvents() => TypeDescriptor.GetEvents(this, true);

    public EventDescriptorCollection GetEvents(Attribute[]? attributes) => TypeDescriptor.GetEvents(this, attributes, true);

    public PropertyDescriptorCollection GetProperties()
    {
        var entries = this.Select(element =>
        {
            var type = element.Value?.GetType() ?? typeof(object);

            return new ScriptSettingsPropertyDescriptor(this, element.Key, element.Key, type, []);
        });
        return new PropertyDescriptorCollection(entries.ToArray());
    }

    public PropertyDescriptorCollection GetProperties(Attribute[]? attributes)
    {
        var propList = new ArrayList();
        var propCollection = (PropertyDescriptor[])propList.ToArray(typeof(PropertyDescriptor));
        return new PropertyDescriptorCollection(propCollection);
    }

    public object GetPropertyOwner(PropertyDescriptor? pd) => this;

    #endregion

    #region Converter

    public static ScriptSettingsDictionary? FromScriptObject(ScriptObject scriptObject, ILoggerService? loggerService = null)
    {
        if (ConvertValue(scriptObject) is ScriptSettingsDictionary val)
        {
            val.SetLoggerService(loggerService);

            return val;
        }

        return null;
    }

    private static object? ConvertValue(object? scriptObject)
    {
        switch (scriptObject)
        {
            case IList array:
            {
                var list = new List<object?>();
                foreach (var item in array)
                {
                    list.Add(ConvertValue(item));
                }
                return list;
            }

            case ScriptObject childScriptObject:
            {
                var childTarget = new ScriptSettingsDictionary();
                foreach (var propertyName in childScriptObject.PropertyNames)
                {
                    childTarget.Add(propertyName, ConvertValue(childScriptObject[propertyName]));
                }
                return childTarget;
            }

            case bool:
            case double:
            case float:
            case int:
            case string:
            case BigInteger:
                return scriptObject;

            default:
                throw new NotSupportedException($"Settings type \"{scriptObject?.GetType()}\" is not supported");
        }
    }

    public void ToScriptObject(ScriptObject scriptObject)
    {
        foreach (var propertyName in scriptObject.PropertyNames)
        {
            if (!TryGetValue(propertyName, out var newValue))
            {
                continue;
            }

            switch (scriptObject[propertyName])
            {
                case IList array:
                {
                    if (newValue is not IList newList)
                    {
                        throw new Exception();
                    }

                    array.Clear();
                    foreach (var item in newList)
                    {
                        array.Add(item);
                    }
                    break;
                }

                case ScriptObject childScriptObject:
                {
                    if (newValue is not ScriptSettingsDictionary newChild)
                    {
                        throw new Exception();
                    }

                    newChild.ToScriptObject(childScriptObject);
                    continue;
                }

                case bool:
                case double:
                case float:
                case int:
                case string:
                case BigInteger:
                    if (scriptObject[propertyName].GetType() != newValue?.GetType())
                    {
                        throw new Exception();
                    }

                    scriptObject[propertyName] = newValue;
                    break;

                default:
                    throw new NotSupportedException($"Settings type \"{scriptObject?.GetType()}\" is not supported");
            }
        }
    }

    #endregion
}

public class ScriptSettingsPropertyDescriptor : PropertyDescriptor
{
    private readonly ScriptSettingsDictionary _parent;

    public ScriptSettingsPropertyDescriptor(ScriptSettingsDictionary parent, string propertyName, string propertyDisplayName, Type propertyType, Attribute[] propertyAttributes) : base(propertyName, propertyAttributes)
    {
        _parent = parent;

        PropertyType = propertyType;
        DisplayName = propertyDisplayName;
    }

    #region Properties

    public override Type ComponentType => typeof(ScriptSettingsDictionary);

    public override string DisplayName { get; }

    public override bool IsReadOnly => false;

    public override Type PropertyType { get; }

    #endregion

    #region Override members

    public override bool CanResetValue(object component) => true;

    public override object? GetValue(object? component) => _parent[base.Name];

    public override void ResetValue(object component)
    {
    }

    public override void SetValue(object? component, object? value) => _parent[Name] = value;

    public override bool ShouldSerializeValue(object component) => false;

    #endregion
}