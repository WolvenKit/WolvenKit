using Wolvenkit.CR2W.Types;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Wolvenkit.CR2W
{
    public static class REDReflection
    {
        public static PropertyInfo GetREDProperty(this Type parent, string name, string type)
        {
            var props = parent.GetProperties().Where(prop =>
            {
                if (prop.IsDefined(typeof(REDPropAttribute)))
                {
                    var attribute = (REDPropAttribute)prop.GetCustomAttribute(typeof(REDPropAttribute));
                    if (attribute.Name != name)
                    {
                        return false;
                    }
                    var flags = new Stack<byte>(attribute.Flags.Reverse());
                    return prop.PropertyType.GetREDString(flags) == type;
                }
                else
                {
                    return false;
                }
            });
            if (props.Any())
            {
                return props.First();
            }
            return null;
        }

        public static PropertyInfo[] GetREDProperties(this Type type)
        {
            return type.GetProperties().Where(prop => prop.IsDefined(typeof(REDPropAttribute))).ToArray();
        }

        public static (string name, string type) GetREDTypeNamePair(this PropertyInfo prop)
        {
            var attribute = (REDPropAttribute)prop.GetCustomAttribute(typeof(REDPropAttribute));
            var flags = new Stack<byte>(attribute.Flags.Reverse());
            return (attribute.Name, GetREDString(prop.PropertyType, flags));
        }

        public static string GetREDString(this Type type, Stack<byte> flags)
        {
            switch (type.Name)
            {
                case "Byte":    return "Uint8";
                case "UInt16":  return "Uint16";
                case "UInt32":  return "Uint32";
                case "UInt64":  return "Uint64";
                case "SByte":   return "Int8";
                case "Boolean": return "Bool";
                case "Single":  return "Float";
            }
            if (type.IsGenericType)
            {
                var genprop = type.GetTypeInfo().GenericTypeArguments[0];
                if (type.GetGenericTypeDefinition() == typeof(Array<>))
                {
                    return $"array:{flags.SafePop()},{flags.SafePop()},{GetREDString(genprop, flags)}";
                }
                else if (type.GetGenericTypeDefinition() == typeof(Ptr<>))
                {
                    return $"ptr:{GetREDString(genprop, flags)}";
                }
                else if (type.GetGenericTypeDefinition() == typeof(Soft<>))
                {
                    return $"soft:{GetREDString(genprop, flags)}";
                }
                else if (type.GetGenericTypeDefinition() == typeof(Handle<>))
                {
                    return $"handle:{GetREDString(genprop, flags)}";
                }
                else if (type.GetGenericTypeDefinition() == typeof(Static<>))
                {
                    return $"static:{flags.SafePop()},{GetREDString(genprop, flags)}";
                }
            }
            return type.Name;
        }

        public static T SafePop<T>(this Stack<T> value) where T : new()
        {
            if (value.Count == 0)
            {
                return new T();
            }
            return value.Pop();
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = true)]
    class REDClassAttribute : Attribute
    {
        public REDClassAttribute() { }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class REDPropAttribute : Attribute
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public byte[] Flags { get; private set; }

        public REDPropAttribute(string name, params byte[] flags)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("[REDAttribute] Name property cannot be NULL or empty.");
            }
            Name = name;
            Flags = flags;
        }

        public REDPropAttribute(string name, string description, params byte[] flags) : this(name, flags)
        {
            if (String.IsNullOrEmpty(description))
            {
                throw new ArgumentNullException("[REDAttribute] Description property cannot be NULL or empty.");
            }
            Description = description;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class REDSizeAttribute : Attribute
    {
        public byte Size { get; private set; }
        public REDSizeAttribute(byte size)
        {
            this.Size = size;
        }
    }

    [AttributeUsage(AttributeTargets.Struct)]
    public class REDPrimitive : Attribute
    {
        public REDPrimitive()
        {

        }
    }


    public enum REDTypeCode
    {
        Empty = 0,
        Int8 = 1,
        Uint8 = 2,
        Int16 = 3,
        Uint16 = 4,
        Int32 = 5,
        Uint32 = 6,
        Int64 = 7,
        Uint64 = 8,
        Bool = 9,
        Float = 10,
        String = 11,
        StringAnsi = 12,
        CName = 13,
        CGUID = 14,
        IdTag = 15,
        TagList = 16,
        CDateTime = 17,
        EngineTransform = 18,
        EngineQsTransform = 19,
        LocalizedString = 20,
        EntityHandle = 21,
        DataBuffer = 22,
        SharedDataBuffer = 23,
        DeferredDataBuffer = 24,
    }
}
