using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using WolvenKit.Common;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W.Reflection
{
    /// <summary>
    /// Provides static methods for reading .NET runtime information 
    /// and converting to redengine compatible representations.
    /// </summary>
    public static class REDReflection
    {
        //public static ulong ComputeFieldInfoHash(FieldInfo info)
        //{
        //    var fieldName     = GetREDNameString(info);
        //    var declaringName = info.DeclaringType.Name;

        //    var fnv = new FNV1A64HashAlgorithm();

        //    fnv.AppendString(declaringName, true);
        //    fnv.AppendString(fieldName, true);

        //    return fnv.HashUInt64;
        //}

        //public static (string name, string type) GetREDNameTypePair(FieldInfo field)
        //{
        //    var attribute = field.GetCustomAttribute<REDAttribute>();
        //    if(attribute is null)
        //    {
        //        return (null, null);
        //    }
        //    var flags = attribute.Flags.AsEnumerable().GetEnumerator();
        //    if (String.IsNullOrWhiteSpace(attribute.Name))
        //    {
        //        return (field.Name, GetREDTypeString(field.FieldType, flags));
        //    }
        //    return (attribute.Name, GetREDTypeString(field.FieldType, flags));
        //}

        //public static string GetREDNameString(FieldInfo field)
        //{
        //    var attribute = field.GetCustomAttribute<REDAttribute>();
        //    if (attribute is null || String.IsNullOrWhiteSpace(attribute.Name))
        //    {
        //        return field.Name;
        //    }
        //    return attribute.Name;
        //}
        public static string GetREDNameString(PropertyInfo prop)
        {
            var attribute = prop.GetCustomAttribute<REDAttribute>();
            if (attribute is null || String.IsNullOrWhiteSpace(attribute.Name))
            {
                return prop.Name;
            }
            return attribute.Name;
        }

        //public static string GetREDTypeString(FieldInfo field)
        //{
        //    var attribute = field.GetCustomAttribute<REDAttribute>();
        //    if(attribute is null)
        //    {
        //        return null;
        //    }
        //    var flags = attribute.Flags.AsEnumerable().GetEnumerator();
        //    return GetREDTypeString(field.FieldType, flags);
        //}
        public static string GetREDTypeString(Type type, params int[] flags)
        {
            return GetREDTypeString(type, flags.AsEnumerable().GetEnumerator());
        }
        public static string GetREDTypeString(Type type, IEnumerator<int> flags)
        {
            // FIXME wkit doesn't support .NET types right now

            
            // Handles .Net types that have different names.
            // Types such as Double, Int32, or Int16 are the same.
            //switch (Type.GetTypeCode(type))
            //{
            //    case TypeCode.Byte:    return "Uint8";
            //    case TypeCode.UInt16:  return "Uint16";
            //    case TypeCode.UInt32:  return "Uint32";
            //    case TypeCode.UInt64:  return "Uint64";
            //    case TypeCode.SByte:   return "Int8";
            //    case TypeCode.Boolean: return "Bool";
            //    case TypeCode.Single:  return "Float";
            //}

            //// Handles arrays, such as [5]Float, in C++ these would be defined fixed arrays.
            //// Here the size will be defined in the attribute, as C# can't define fixed arrays in classes like C++
            //if (type.IsArray)
            //{
            //    var arrProp = type.GetElementType();
            //    var size = flags.MoveNext() ? flags.Current : 0;
            //    return $"[{size}]{GetREDTypeString(arrProp, flags)}";
            //}

            // Handles the 5 generic types: array:2,0,Int8, ptr:CObject, 
            // static:4,Int32, handle:ISerializable and soft:CResource.
            if (type.IsGenericType)
            {
                var genprop = type.GetTypeInfo().GenericTypeArguments[0];
                var gentype = type.GetGenericTypeDefinition();
                if (gentype == typeof(CArray<>))
                {
                    var v1 = flags.MoveNext() ? flags.Current : 0;
                    var v2 = flags.MoveNext() ? flags.Current : 0;
                    return $"array:{v1},{v2},{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(CArrayFixedSize<>))
                {
                    var v1 = flags.MoveNext() ? flags.Current : 0;
                    return $"[{v1}]{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(CPtr<>))
                {
                    return $"ptr:{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(CSoft<>))
                {
                    return $"soft:{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(CHandle<>))
                {
                    return $"handle:{GetREDTypeString(genprop, flags)}";
                }
                /*if (gentype == typeof(Static<>))
                {
                    var v1 = flags.MoveNext() ? flags.Current : 0;
                    return $"static:{v1},{GetREDTypeString(genprop, flags)}";
                }*/

                return type.GetPrettyGenericTypes();
            }
            else
            {
                return GetREDTypeFroWkitType(type.Name);
                
            }
        }

        public static string GetWKitTypeFromREDType(string typename)
        {
            switch (typename)
            {
                case "Uint8": return "CUInt8";
                case "Int8": return "CInt8";
                case "Uint16": return "CUInt16";
                case "Int16": return "CInt16";
                case "Uint32": return "CUInt32";
                case "Int32": return "CInt32";
                case "Uint64": return "CUInt64";
                case "Int64": return "CInt64";
                case "Bool": return "CBool";
                case "Float": return "CFloat";
                case "String": return "CString";
                case "Color": return "CColor";
                case "Matrix": return "CMatrix";
                default:
                    return typename;
            }
        }

        public static string GetREDTypeFroWkitType(string typename)
        {
            switch (typename)
            {
                case "CUInt8": return "Uint8";
                case "CInt8": return "Int8";
                case "CUInt16": return "Uint16";
                case "CInt16": return "Int16";
                case "CUInt32": return "Uint32";
                case "CInt32": return "Int32";
                case "CUInt64": return "Uint64";
                case "CInt64": return "Int64";
                case "CBool": return "Bool";
                case "CFloat": return "Float";
                case "CString": return "String";
                case "CColor": return "Color";
                case "CMatrix": return "Matrix";
                default:
                    return typename;
            }
        }

        #region Property
        #endregion
        public static IEnumerable<PropertyInfo> GetREDProperties(Type type)
        {
            var allprops = type.GetProperties( BindingFlags.Instance | BindingFlags.Public);
            return allprops.Where(prop => prop.IsDefined(typeof(REDAttribute))).ToList();
        }
        public static IEnumerable<PropertyInfo> GetREDProperties(Type type, BindingFlags flags)
        {
            var allprops = type.GetProperties(flags);
            return allprops.Where(prop => prop.IsDefined(typeof(REDAttribute))).ToList();
        }

        public static PropertyInfo GetREDProperty(Type classType, string name, string type)
        {
            foreach (var p in GetREDProperties(classType))
            {
                var attribute = p.GetCustomAttribute<REDAttribute>();
                var flags = attribute.Flags.AsEnumerable().GetEnumerator();
                var n = attribute.Name;
                if (String.IsNullOrWhiteSpace(n))
                {
                    n = p.Name;
                }
                if (n == name && GetREDTypeString(p.PropertyType, flags) == type)
                    return p;
            }
            return null;
        }

        public static PropertyInfo GetREDProperty(Type classType, string type)
        {
            foreach (var prop in GetREDProperties(classType))
            {
                var attribute = prop.GetCustomAttribute<REDAttribute>();
                var flags = attribute.Flags.AsEnumerable().GetEnumerator();

                if (GetREDTypeString(prop.PropertyType, flags) == type)
                    return prop;
            }
            return null;
        }





        public static IEnumerable<PropertyInfo> GetREDProperties<T>(Type type) where T : Attribute
        {
            return type
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(prop => prop.IsDefined(typeof(T))).ToList();
        }
        public static PropertyInfo GetREDProperty<T>(Type classType, string name, string type) where T : Attribute
        {
            return GetREDProperties<T>(classType)
                .Where(prop => prop.Name == name && GetREDTypeString(prop.PropertyType) == type)
                .FirstOrDefault();
        }
    }
}
