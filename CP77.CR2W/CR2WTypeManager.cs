using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    /// <summary>
    /// The reflection magic happens mostly here, with System.Activator.
    /// A class is instantiated from its type and the properties are deserialized from 
    /// cr2w later, in CVariable.Read and CR2WFile.ReadVariable
    /// </summary>
    public static class CR2WTypeManager
    {

        public static IEnumerable<string> AvailableTypes => AvailableVanillaTypes;

        public static IEnumerable<string> AvailableVanillaTypes
        {
            get
            {
                const string nspace = "WolvenKit.CR2W.Types";

                var cr2wassembly = Assembly.GetExecutingAssembly();
                var vanillaclassNames = cr2wassembly.GetTypes()
                    .Where(_ => _.IsClass && _.Namespace == nspace)
                    .Select(_ => _.Name);

                return vanillaclassNames;
            }
        }

        /// <summary>
        /// The instantiation step of the RedEngine-3 reflection.
        /// </summary>
        /// <param name="typename">Can be either a generic type such as CUint32 - then converted with GetWKitTypeFromREDType, or a complex type like a
        /// pointer to a class, a handle to an import file, an array, a soft reference, a static reference, various buffers, an enum.</param>
        /// <param name="varname">The variable name</param>
        /// <param name="cr2w">The cr2w base file</param>
        /// <param name="parentVariable">The class owning this attribute</param>
        /// <param name="readUnknownAsBytes"></param>
        /// <returns></returns>
        public static CVariable Create(string typename, string varname, CR2WFile cr2w, CVariable parentVariable, bool readUnknownAsBytes = true)
        {
            typename = REDReflection.GetWKitBaseTypeFromREDBaseType(typename);
            var fullname = typename;

            // check for normal type
            if (AssemblyDictionary.TypeExists(typename))
            {
                var type = AssemblyDictionary.GetTypeByName(typename);
                if (type != null)
                {
                    object instance = Activator.CreateInstance(type, cr2w, parentVariable, varname);
                    return instance as CVariable;
                }
            }

            // check for enum types
            if (AssemblyDictionary.EnumExists(typename))
            {
                Enum e = (Enum)Activator.CreateInstance(AssemblyDictionary.GetEnumByName(typename));
                var cenum = MakeGenericEnumType(typeof(CEnum<>), e);
                return cenum;
            }
            else if (CR2WManager.EnumExists(typename))
            {
                Enum e = (Enum)Activator.CreateInstance(CR2WManager.GetEnumByName(typename));
                var cenum = MakeGenericEnumType(typeof(CEnum<>), e);
                return cenum;
            }
            // check for generic type
            else if (typename.StartsWith('['))
            {
                string generictype = typename.Substring(3);
                CVariable innerobject = Create(generictype, "", cr2w, null);
                var arrayacc = MakeArray(typeof(CArrayFixedSize<>), innerobject.GetType());
                //arrayacc.Flags = new List<int>() { int.Parse(matchArrayType.Groups[1].Value) };
                arrayacc.Elementtype = generictype;
                return arrayacc as CVariable;
            }
            else if (typename.Contains(':'))
            {
                #region GENERIC TYPES
                string[] splits = typename.Split(':');
                string generictype = splits.First();
                string innertype = string.Join(":", splits.Skip(1));
                // e.g. handle:CEntityTemplate
                switch (generictype)
                {
                    case "CHandle":
                    case "handle":
                        {
                            CVariable innerobject = Create(innertype, "", cr2w, null);
                            return MakeGenericType(typeof(CHandle<>), innerobject);
                        }
                    case "CPtr":
                    case "ptr":
                        {
                            CVariable innerobject = Create(innertype, "", cr2w, null);
                            return MakeGenericType(typeof(CPtr<>), innerobject);
                        }
                    case "CSoft":
                    case "soft":
                        {
                            CVariable innerobject = Create(innertype, "", cr2w, null);
                            return MakeGenericType(typeof(CSoft<>), innerobject);
                        }
                    case "CrRef":
                    case "rRef":
                    {
                        CVariable innerobject = Create(innertype, "", cr2w, null);
                        return MakeGenericType(typeof(rRef<>), innerobject);
                    }
                    case "CraRef":
                    case "raRef":
                    {
                        CVariable innerobject = Create(innertype, "", cr2w, null);
                        return MakeGenericType(typeof(raRef<>), innerobject);
                    }
                    case "array":
                        {
                            // match pattern e.g. 
                            // array:            (array:)Float
                            // array of array:   (array:)handle:meshMeshAppearance


                            CVariable innerobject = Create(innertype, "", cr2w, null);
                            IArrayAccessor arrayacc = MakeArray(typeof(CArray<>), innerobject.GetType());
                            arrayacc.Elementtype = innertype;
                            return arrayacc as CVariable;
                        }
                    case "static":
                        {
                            typename = generictype;

                            // match pattern e.g. 
                            // static:  (4),(Uint32)
                            var regArrayType = new Regex(@"(\d+),(.+)");
                            var matchArrayType = regArrayType.Match(fullname);
                            if (matchArrayType.Success)
                            {
                                CVariable innerobject = Create(matchArrayType.Groups[2].Value, "", cr2w, null);
                                var arrayacc = MakeArray(typeof(CStatic<>), innerobject.GetType());
                                //arrayacc.Flags = new List<int>() { int.Parse(matchArrayType.Groups[1].Value) };
                                arrayacc.Elementtype = matchArrayType.Groups[2].Value;
                                return arrayacc as CVariable;
                            }
                            else
                            {
                                throw new InvalidParsingException($"Invalid static type format: typename: {typename}.");
                            }
                        }
                    case "CBufferUInt16":
                        {
                            CVariable innerobject = Create(innertype, "", cr2w, null);
                            return MakeGenericType(typeof(CBufferUInt16<>), innerobject);
                        }
                    case "CBufferUInt32":
                        {
                            CVariable innerobject = Create(innertype, "", cr2w, null);
                            return MakeGenericType(typeof(CBufferUInt32<>), innerobject);
                        }
                    case "CBufferVLQInt32":
                        {
                            CVariable innerobject = Create(innertype, "", cr2w, null);
                            return MakeGenericType(typeof(CBufferVLQInt32<>), innerobject);
                        }
                    case "CCompressedBuffer":
                        {
                            CVariable innerobject = Create(innertype, "", cr2w, null);
                            return MakeGenericType(typeof(CCompressedBuffer<>), innerobject);
                        }
                    case "CPaddedBuffer":
                        {
                            CVariable innerobject = Create(innertype, "", cr2w, null);
                            return MakeGenericType(typeof(CPaddedBuffer<>), innerobject);
                        }
                    case "CEnum":
                        {
                            Enum innerobject = CreateEnum(innertype);
                            return MakeGenericEnumType(typeof(CEnum<>), innerobject);
                        }
                    default:
                        {
                            throw new NotImplementedException();
                        }
                }
                #endregion
            }
            else
            {

                // check if custom type
                if (CR2WManager.TypeExists(typename))
                {
                    var type = CR2WManager.GetTypeByName(typename);
                    object instance = Activator.CreateInstance(type, cr2w, parentVariable, varname);
                    return instance as CVariable;
                }


                // this should never happen

                if (!cr2w.UnknownTypes.Contains(fullname))
                    cr2w.UnknownTypes.Add(fullname);

                if (readUnknownAsBytes)
                {
                    return new CBytes(cr2w, parentVariable, $"UNKNOWN:{typename}:{varname}");
                }
                else
                    return null;

            }            
                

            #region LOCAL FUNCTIONS


            IArrayAccessor MakeArray(Type arraytype, Type generictype)
            {
                Type elementType;

                if (arraytype == typeof(CStatic<>))
                    elementType = typeof(CStatic<>).MakeGenericType(generictype);
                else if (arraytype == typeof(CArrayFixedSize<>))
                    elementType = typeof(CArrayFixedSize<>).MakeGenericType(generictype);
                else if (arraytype == typeof(CArray<>))
                    elementType = typeof(CArray<>).MakeGenericType(generictype);
                else
                {
                    throw new NotImplementedException();
                }
                

                var array = Activator.CreateInstance(elementType, cr2w, parentVariable, varname) as CVariable;

                return array as IArrayAccessor;
            }


            CVariable MakeGenericType(Type gentype, CVariable innerobject)
            {
                if (innerobject != null)
                {
                    Type elementType = gentype.MakeGenericType(innerobject.GetType());
                    CVariable handle = Activator.CreateInstance(elementType, cr2w, parentVariable, varname) as CVariable;
                    return handle;
                }
                else
                {
                    throw new Exception();
                }
            }

            CVariable MakeGenericEnumType(Type gentype, Enum innerobject)
            {
                if (innerobject != null)
                {
                    Type elementType = gentype.MakeGenericType(innerobject.GetType());
                    CVariable handle = Activator.CreateInstance(elementType, cr2w, parentVariable, varname) as CVariable;
                    return handle;
                }
                else
                {
                    throw new Exception();
                }
            }
            #endregion
        }

        private static Enum CreateEnum(string value)
        {
            if (AssemblyDictionary.EnumExists(value))
            {
                var type = AssemblyDictionary.GetEnumByName(value);
                Enum e = (Enum) Activator.CreateInstance(type);

                return e;
            }
            else if (CR2WManager.EnumExists(value))
            {
                var type = CR2WManager.GetEnumByName(value);
                Enum e = (Enum)Activator.CreateInstance(type);

                return e;
            }

            return null;
        }
    }
}