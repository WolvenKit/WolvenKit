using DotNetHelper.FastMember.Extension.Extension;
using FastMember;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
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
        public static string GetREDNameString(Member item)
        {
            var attribute = item.GetMemberAttribute<REDAttribute>();
            if (attribute is null || String.IsNullOrWhiteSpace(attribute.Name))
            {
                return item.Name;
            }
            return attribute.Name;
        }

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
                if (gentype == typeof(CStatic<>))
                {
                    var v1 = flags.MoveNext() ? flags.Current : 0;
                    return $"static:{v1},{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(CEnum<>))
                {
                    
                }

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
                case "int": return "CInt32";
                case "Int32": return "CInt32";
                case "Uint64": return "CUInt64";
                case "Int64": return "CInt64";
                case "Bool": return "CBool";
                case "bool": return "CBool";
                case "Float": return "CFloat";
                case "float": return "CFloat";
                case "String": return "CString";
                case "string": return "CString";
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


        /// https://stackoverflow.com/questions/14734374/c-sharp-reflection-property-order
        public static IEnumerable<Member> GetREDMembers(this CVariable cvar, bool getBuffers)
        {
            Type type = cvar.GetType();
            Dictionary<Type, int> lookup = new Dictionary<Type, int>();

            // get hierarchical list of types
            int count = 0;
            lookup[type] = count++;
            Type parent = type.BaseType;
            while (parent != null)
            {
                lookup[parent] = count;
                count++;
                parent = parent.BaseType;
            }

            return cvar.GetREDMembersInternal(getBuffers)
                .OrderByDescending(prop => lookup[prop.GetMemberInfo().DeclaringType]);
        }

        public static IEnumerable<Member> GetREDBuffers(this CVariable cvar)
        {
            Type type = cvar.GetType();
            Dictionary<Type, int> lookup = new Dictionary<Type, int>();

            int count = 0;
            lookup[type] = count++;
            Type parent = type.BaseType;
            while (parent != null)
            {
                lookup[parent] = count;
                count++;
                parent = parent.BaseType;
            }

            return cvar.GetREDBuffersInternal()
                .OrderByDescending(prop => lookup[prop.GetMemberInfo().DeclaringType]);
        }


        private static IEnumerable<Member> GetREDBuffersInternal(this CVariable cvar)
        {
            // get only REDBuffers
            var redproperties = cvar.accessor.GetMembers()
                    .OrderBy(p => p.Ordinal)
                    .Where(_ => _.GetMemberAttribute<REDBufferAttribute>() != null);

            return redproperties;
        }

        private static IEnumerable<Member> GetREDMembersInternal(this CVariable cvar, bool getBuffers)
        {
            var a = cvar.accessor.GetMembers().OrderBy(p => p.Ordinal);

            var redproperties = cvar.accessor.GetMembers()
                    .OrderBy(p => p.Ordinal)
                    .Where(_ => _.GetMemberAttribute<REDAttribute>() != null);

            // get RED and REDBuffers
            if (getBuffers)
            {
                return redproperties;
            }
            // get only RED
            else
            {
                return redproperties.Where(z => !(z.GetMemberAttribute<REDAttribute>() is REDBufferAttribute)); ;
            }
        }
    }
}
