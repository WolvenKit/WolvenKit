using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using FastMember;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types
{
    public static class RedReflection
    {
        private const bool PreBuildCache = true;

        private static readonly Dictionary<string, Type> _classCache = new();
        private static readonly Dictionary<Type, List<ExtendedPropertyInfo>> _propertyCache = new();

        private static bool _cacheBuild;

        public static ExtendedPropertyInfo GetProperty(string redTypeName, string redPropertyName)
        {
            var type = GetType(redTypeName);
            if (type != null)
            {
                return GetProperty(type, redPropertyName);
            }

            return null;
        }

        public static bool IsDefault(Type clsType, string redPropertyName, object? value)
        {
            var extendedPropertyInfo = GetProperty(clsType, redPropertyName);
            if (extendedPropertyInfo == null)
            {
                throw new MissingRTTIException(redPropertyName, "???", clsType.Name);
            }

            return object.Equals(extendedPropertyInfo.DefaultValue, value);
        }

        public static ExtendedPropertyInfo GetProperty(Type type, string redPropertyName)
        {
            if (_propertyCache.ContainsKey(type))
                return _propertyCache[type].FirstOrDefault(p => p.RedName == redPropertyName);
            return null;
        }

        public static Type GetType(string redTypeName)
        {
            if (_classCache.ContainsKey(redTypeName))
                return _classCache[redTypeName];
            return null;
        }

        public static string GetRedTypeName(Type type)
        {
            if (_classCache.ContainsValue(type))
                return _classCache.FirstOrDefault(p => p.Value == type).Key;
            return null;
        }

        public static void BuildCache()
        {
            if (_cacheBuild)
                return;

            var baseType = typeof(IRedClass);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => p.Namespace != null && p.Namespace.StartsWith("WolvenKit.RED4.Types") && baseType.IsAssignableFrom(p) && p.IsClass);

            foreach (var type in types)
            {
                _classCache.Add(type.Name, type);

                var instance = System.Activator.CreateInstance(type);
                var propertyList = new List<ExtendedPropertyInfo>();

                foreach (var propertyInfo in type.GetProperties())
                {
                    var extendedPropertyInfo = new ExtendedPropertyInfo(propertyInfo);

                    if (instance != null)
                    {
                        extendedPropertyInfo.DefaultValue = propertyInfo.GetValue(instance);
                    }

                    propertyList.Add(extendedPropertyInfo);
                }

                propertyList = propertyList.OrderBy(p => p.Ordinal).ToList();
                _propertyCache.Add(type, propertyList);
            }

            _cacheBuild = true;
        }

        static RedReflection()
        {
            /*if (PreBuildCache)
            {
                var sw = new Stopwatch();
                sw.Start();
                BuildCache();
                sw.Stop();
            }*/
        }

        public class ExtendedPropertyInfo
        {
            public int Ordinal { get; set; } = -1;
            public string Name { get; set; }
            public string RedName { get; set; }
            public int[] Flags { get; set; }
            public bool IsIgnored { get; set; }

            public Type Type { get; set; }
            public object DefaultValue { get; set; }

            public object GetValue(object instance)
            {
                return TypeAccessor.Create(instance.GetType())[instance, Name];
            }

            public void SetValue(object instance, object value)
            {
                TypeAccessor.Create(instance.GetType())[instance, Name] = value;
            }

            public ExtendedPropertyInfo(PropertyInfo propertyInfo)
            {
                Name = propertyInfo.Name;
                Type = propertyInfo.PropertyType;

                var attrs = propertyInfo.GetCustomAttributes();
                foreach (var attribute in attrs)
                {
                    if (attribute is OrdinalAttribute ordinalAttribute)
                    {
                        Ordinal = ordinalAttribute.Ordinal;
                    }

                    if (attribute is REDAttribute redAttribute)
                    {
                        RedName = redAttribute.Name;
                        Flags = redAttribute.Flags;
                    }

                    if (attribute is REDBufferAttribute redBufferAttribute)
                    {
                        IsIgnored = redBufferAttribute.IsIgnored;
                    }
                }
            }
        }
    }
}
