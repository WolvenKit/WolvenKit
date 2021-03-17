using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using WolvenKit.RED4.CR2W.Types;
using DotNetHelper.FastMember.Extension.Extension;
using FastMember;

namespace WolvenKit.RED4.CR2W.Reflection
{
    /// <summary>
    /// Provides static methods for reading .NET runtime information
    /// and converting to redengine compatible representations.
    /// </summary>
    public static class REDReflection
    {
        #region Fields

        private static readonly ConcurrentDictionary<Type, Lazy<MemberSet>> MembersCache = new();
        private static readonly ConcurrentDictionary<Member, Lazy<object[]>> AttributeCache = new();

        #endregion Fields

        #region Methods

        public static CVariable GetPropertyByREDName(this CVariable cvar, string propertyName)
        {
            foreach (var member in GetMembers(cvar))
            {
                if (member.GetMemberInfo().MemberType != MemberTypes.Property)
                {
                    continue;
                }

                var attr = GetREDAttribute(member);
                if (attr == null || attr.Name != propertyName)
                {
                    continue;
                }

                return (CVariable)cvar.accessor[cvar, member.Name];
            }

            return null;
        }

        public static IEnumerable<Member> GetREDBuffers(this CVariable cvar) =>
            GetMembers(cvar)
                .Where(p => GetREDAttribute(p) is REDBufferAttribute)
                .OrderBy(GetOrdinal);

        public static IEnumerable<Member> GetREDMembers(this CVariable cvar, bool includeBuffers) =>
            GetMembers(cvar)
                .Where(p =>
                {
                    var attr = GetREDAttribute(p);
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
                .OrderBy(GetOrdinal);

        public static string GetREDNameString(Member item)
        {
            var attribute = GetREDAttribute(item);
            if (attribute is null || string.IsNullOrWhiteSpace(attribute.Name))
            {
                return item.Name;
            }
            return attribute.Name;
        }

        public static string GetREDTypeString(Type type, params int[] flags) => GetREDTypeString(type, flags.AsEnumerable().GetEnumerator());

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

        public static MemberSet GetMembers(CVariable cvar) =>
            MembersCache.GetOrAdd(cvar.GetType(), new Lazy<MemberSet>(() => cvar.accessor.GetMembers())).Value;

        private static REDAttribute GetREDAttribute(Member member)
        {
            var attrs = GetMemberAttributes(member);
            for (int i = 0; i < attrs.Length; i++)
            {
                if (attrs[i] is REDAttribute red)
                {
                    return red;
                }
            }

            return null;
        }

        private static int GetOrdinal(Member member)
        {
            var attrs = GetMemberAttributes(member);
            for (int i = 0; i < attrs.Length; i++)
            {
                if (attrs[i] is OrdinalAttribute ord)
                {
                    return ord.Ordinal;
                }
            }

            return -1;
        }

        private static object[] GetMemberAttributes(Member member) =>
            AttributeCache.GetOrAdd(member, new Lazy<object[]>(() => member.GetMemberInfo().GetCustomAttributes(false))).Value;

        private static string GetREDTypeFromWkitType(string typename) =>
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
                if (gentype == typeof(curveData<>))
                {
                    return $"curveData:{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(multiChannelCurve<>))
                {
                    return $"multiChannelCurve:{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(CEnum<>))
                {
                    return GetREDTypeString(genprop, flags);
                }

                return type.GetPrettyGenericTypes();
            }
            else
            {
                return GetREDTypeFromWkitType(type.Name);
            }
        }

        #endregion Methods
    }
}
