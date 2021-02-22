using DotNetHelper.FastMember.Extension.Extension;
using FastMember;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CP77.CR2W.Types;

namespace CP77.CR2W.Reflection
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
            if (attribute is null || string.IsNullOrWhiteSpace(attribute.Name))
            {
                return item.Name;
            }
            return attribute.Name;
        }

        public static string GetREDTypeString(Type type, params int[] flags) => GetREDTypeString(type, flags.AsEnumerable().GetEnumerator());

        private static string GetREDTypeString(Type type, IEnumerator<int> flags)
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
                    return $"array:{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(CArrayFixedSize<>))
                {
                    var v1 = flags.MoveNext() ? flags.Current : 0;
                    return $"[{v1}]{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(CHandle<>))
                {
                    return $"handle:{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(wCHandle<>))
                {
                    return $"whandle:{GetREDTypeString(genprop, flags)}";
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

        public static string GetWKitBaseTypeFromREDBaseType(string typename) =>
            typename switch
            {
                "Uint8" => "CUInt8",
                "Int8" => "CInt8",
                "Uint16" => "CUInt16",
                "Int16" => "CInt16",
                "Uint32" => "CUInt32",
                "int" => "CInt32",
                "Int32" => "CInt32",
                "Uint64" => "CUInt64",
                "Int64" => "CInt64",
                "Bool" => "CBool",
                "bool" => "CBool",
                "Float" => "CFloat",
                "float" => "CFloat",
                "String" => "CString",
                "string" => "CString",
                "Color" => "CColor",
                "Matrix" => "CMatrix",
                "Variant" => "CVariant",
                _ => typename
            };

        private static string GetREDTypeFroWkitType(string typename) =>
            typename switch
            {
                "CUInt8" => "Uint8",
                "CInt8" => "Int8",
                "CUInt16" => "Uint16",
                "CInt16" => "Int16",
                "CUInt32" => "Uint32",
                "CInt32" => "Int32",
                "CUInt64" => "Uint64",
                "CInt64" => "Int64",
                "CBool" => "Bool",
                "CFloat" => "Float",
                "CString" => "String",
                "CColor" => "Color",
                "CMatrix" => "Matrix",
                _ => typename
            };

        public static IEnumerable<Member> GetREDMembers(this CVariable cvar, bool includeBuffers) =>
            GetMembers(cvar)
                .Where(p =>
                {
                    var attr = p.GetMemberAttribute<REDAttribute>();
                    if (attr is null)
                    {
                        return false;
                    }

                    if (!includeBuffers)
                    {
                        return attr is not REDBufferAttribute;
                    }

                    return true;
                })
                .OrderBy(p => p.Ordinal);

        public static IEnumerable<Member> GetREDBuffers(this CVariable cvar) =>
            GetMembers(cvar)
                .Where(p => p.GetMemberAttribute<REDBufferAttribute>() is not null)
                .OrderBy(p => p.Ordinal);

        private static readonly ConcurrentDictionary<Type, Lazy<IEnumerable<Member>>> MembersCache = new();

        private static IEnumerable<Member> GetMembers(CVariable cvar) =>
            MembersCache.GetOrAdd(cvar.GetType(), new Lazy<IEnumerable<Member>>(() => GetMembersInternal(cvar))).Value;

        private static IEnumerable<Member> GetMembersInternal(CVariable cvar) => cvar.accessor.GetMembers();
    }
}
