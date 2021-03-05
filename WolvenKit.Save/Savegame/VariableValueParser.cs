using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;
using WolvenKit.W3SavegameEditor.Core.Savegame.Variables;

namespace WolvenKit.W3SavegameEditor.Core.Savegame
{
    public class VariableValueParser
    {
        #region Fields

        private readonly Dictionary<string, Func<Stack<Variable>, object>> _factories;

        #endregion Fields

        #region Constructors

        public VariableValueParser()
        {
            _factories = new Dictionary<string, Func<Stack<Variable>, object>>();

            foreach (var serializableType in GetSerializableTypes())
            {
                var type = serializableType;
                Func<Stack<Variable>, object> deserializationFunction = v => Deserialize(type.Key, type.Value, v);
                _factories.Add(serializableType.Key, deserializationFunction);
            }
        }

        #endregion Constructors

        #region Methods

        public object Parse(string type, Stack<Variable> variables)
        {
            return _factories[type](variables);
        }

        public T Parse<T>(Stack<Variable> variables)
        {
            return (T)Deserialize(null, typeof(T), variables);
        }

        private static CSerializableAttribute GetCSerializableAttribute(Type type)
        {
            return type.GetCustomAttributes(typeof(CSerializableAttribute), true).SingleOrDefault() as CSerializableAttribute;
        }

        private static IEnumerable<VariablePropertyInfo> GetNamedOrArrayProperties(Type serializableType)
        {
            // TODO: Add an order attribute
            foreach (var property in serializableType.GetProperties())
            {
                var cNameAttribute = property.GetCustomAttributes(typeof(CNameAttribute), true).SingleOrDefault() as CNameAttribute;
                var cArrayAttribute = property.GetCustomAttributes(typeof(CArrayAttribute), true).SingleOrDefault() as CArrayAttribute;
                var cArrayElementType = cArrayAttribute != null ? GetCSerializableAttribute(property.PropertyType.GetElementType()) : null;
                var cSerializableAttribute = GetCSerializableAttribute(property.PropertyType);
                if (cNameAttribute != null || cArrayAttribute != null)
                {
                    yield return new VariablePropertyInfo
                    {
                        CName = cNameAttribute != null ? cNameAttribute.Name : null,
                        CType = cSerializableAttribute != null ? cSerializableAttribute.TypeName : null,
                        IsArray = cArrayAttribute != null,
                        ArrayCountName = cArrayAttribute != null ? cArrayAttribute.CountName : null,
                        ArrayElementName = cArrayAttribute != null ? cArrayAttribute.ElementName : null,
                        ArrayElementType = cArrayAttribute != null ? property.PropertyType.GetElementType() : null,
                        ArrayElementCType = cArrayElementType != null ? cArrayElementType.TypeName : null,
                        Info = property
                    };
                }
            }
        }

        private static IEnumerable<KeyValuePair<string, Type>> GetSerializableTypes()
        {
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
                var cSerializableAttribute = GetCSerializableAttribute(type);
                if (cSerializableAttribute != null)
                {
                    yield return new KeyValuePair<string, Type>(cSerializableAttribute.TypeName, type);
                }
            }
        }

        private static void SkipName(Stack<Variable> variables, string name)
        {
            var variable = variables.Peek() as BsVariable;
            if (variable != null && variable.Name == name)
            {
                variables.Pop();
            }
        }

        private object Deserialize(string typeName, Type type, Stack<Variable> variables)
        {
            var instance = Activator.CreateInstance(type);
            SkipName(variables, typeName);

            foreach (var serializableProperty in GetNamedOrArrayProperties(type))
            {
                object propertyValue = null;
                if (serializableProperty.CType != null)
                {
                    SkipName(variables, serializableProperty.CName);

                    propertyValue = _factories[serializableProperty.CType](variables);
                }
                else
                {
                    var typedVariable = variables.Peek() as TypedVariable;
                    if (typedVariable == null)
                    {
                        continue;
                    }

                    if (serializableProperty.IsArray && typedVariable.Name == serializableProperty.ArrayCountName)
                    {
                        variables.Pop();
                        uint count = (uint)typedVariable.Value.Object;
                        var array = Array.CreateInstance(serializableProperty.ArrayElementType, count);
                        for (int i = 0; i < count; i++)
                        {
                            object element;
                            if (serializableProperty.ArrayElementCType == null)
                            {
                                // TODO: Check the element type name (e.g. CGUID)
                                element = ((TypedVariable)variables.Pop()).Value.Object;
                            }
                            else
                            {
                                SkipName(variables, serializableProperty.ArrayElementName);
                                element = Deserialize(serializableProperty.ArrayElementCType, serializableProperty.ArrayElementType, variables);
                            }

                            array.SetValue(element, i);
                        }
                        propertyValue = array;
                    }
                    else if (typedVariable.Name == serializableProperty.CName)
                    {
                        variables.Pop();
                        propertyValue = typedVariable.Value.Object;
                    }
                }

                serializableProperty.Info.SetValue(instance, propertyValue);
            }
            return instance;
        }

        #endregion Methods

        #region Classes

        private class VariablePropertyInfo
        {
            #region Properties

            public string ArrayCountName { get; set; }
            public string ArrayElementCType { get; set; }
            public string ArrayElementName { get; set; }
            public Type ArrayElementType { get; set; }
            public string CName { get; set; }
            public string CType { get; set; }

            public PropertyInfo Info { get; set; }
            public bool IsArray { get; set; }

            #endregion Properties
        }

        #endregion Classes
    }
}
