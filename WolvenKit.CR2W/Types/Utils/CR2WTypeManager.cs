using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    public class CR2WTypeDefinition
    {
        public string name;
        public CVariable var;

        public CR2WTypeDefinition(string name, CVariable var)
        {
            this.name = name;
            this.var = var;
        }
    }

    /// <summary>
    /// The reflection magic happens mostly here, with System.Activator.
    /// A class is instantiated from its type and the properties are deserialized from 
    /// cr2w later, in CVariable.Read and CR2WFile.ReadVariable
    /// </summary>
    public static class CR2WTypeManager
    {
        public static List<string> AvailableTypes
        {
            get
            {
                // class names
                string nspace = "WolvenKit.CR2W.Types";
                List<string> classNames = new List<string>();

                var q = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.IsClass && t.Namespace == nspace
                        select t;
                q.ToList().ForEach(t => classNames.Add(t.Name));

                // enum names
                List<string> enumNames = new List<string>();
                foreach (var enm in typeof(Enums).GetNestedTypes())
                {
                    enumNames.Add(enm.Name);
                }

                return classNames.Concat(enumNames).ToList();
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
            
            
            typename = REDReflection.GetWKitTypeFromREDType(typename);

            // first try to create instance of type
            #region W3 TYPES 
            try
            {


                var type = Type.GetType($"WolvenKit.CR2W.Types.{typename}", false);
                // if succesful return as CVariable
                if (type != null)
                {
                    //var instance = type.GetMethod("Create").Invoke(type, new object[]{ cr2w, parentVariable, varname });

                    object instance = Activator.CreateInstance(type, cr2w, parentVariable, varname);
                    return instance as CVariable;
                }
            }
            catch (System.IO.FileLoadException)
            {

            }
            #endregion

            var fullname = typename;
            // check for enum
            if (typeof(Enums).GetNestedTypes().Select(_ => _.Name).Contains(typename))
            {
                Enum e = (Enum)Activator.CreateInstance(typeof(Enums).GetNestedTypes().FirstOrDefault(_ => _.Name == typename));

                if (e.GetType().IsDefined(typeof(FlagsAttribute), false))
                {
                    typename = REDReflection.GetWKitTypeFromREDType(typename);
                    var etype = Type.GetType($"WolvenKit.CR2W.Types.{typename}");
                    object einstance = Activator.CreateInstance(etype, cr2w, parentVariable, varname);
                    return einstance as CVariable;
                }

                var cenum = MakeGenericEnumType(typeof(CEnum<>), e);
                return cenum;
            }
            // finally, check for generic type
            else if (typename.Contains(':'))
            {
                try
                {
                    #region GENERIC TYPES
                    // match pattern e.g. 
                    // (handle):(CGenericGrassMask) or 
                    // (array):(2,0,handle:CBitmapTexture)
                    var reg = new Regex(@"^(\w+):(.+)$");
                    var match = reg.Match(typename);
                    if (match.Success)
                    {
                        switch (match.Groups[1].Value)
                        {
                            case "CHandle":
                            case "handle":
                                {
                                    CVariable innerobject = Create(match.Groups[2].Value, "", cr2w, null);
                                    return MakeGenericType(typeof(CHandle<>), innerobject);
                                }
                            case "CPtr":
                            case "ptr":
                                {
                                    CVariable innerobject = Create(match.Groups[2].Value, "", cr2w, null);
                                    return MakeGenericType(typeof(CPtr<>), innerobject);
                                }
                            case "CSoft":
                            case "soft":
                                {
                                    CVariable innerobject = Create(match.Groups[2].Value, "", cr2w, null);
                                    return MakeGenericType(typeof(CSoft<>), innerobject);
                                }
                            case "array":
                                {
                                    typename = match.Groups[1].Value;

                                    // match pattern e.g. 
                                    // array:            Array: (2),(0),(handle:CBitmapTexture)
                                    // array:            Array: (2),(0),(Int32)
                                    // array of array:   Array: (2),(0),(Array:133,0,EngineQsTransform)
                                    var regArrayType = new Regex(@"(\d+),(\d+),(.+)");
                                    var matchArrayType = regArrayType.Match(fullname);
                                    if (matchArrayType.Success)
                                    {
                                        //byte arrays, these can be huge, using ordinary arrays is just too slow.
                                        if (matchArrayType.Groups[3].Value == "Uint8" || matchArrayType.Groups[3].Value == "Int8")
                                        {
                                            var bytearray = new CByteArray(cr2w, parentVariable, varname);
                                            bytearray.InternalType = fullname;
                                            return bytearray;
                                        }

                                        

                                        CVariable innerobject = Create(matchArrayType.Groups[3].Value, "", cr2w, null);
                                        IArrayAccessor arrayacc = MakeArray(typeof(CArray<>), innerobject.GetType());
                                        arrayacc.Flags = new List<int>() { int.Parse(matchArrayType.Groups[1].Value), int.Parse(matchArrayType.Groups[2].Value) };
                                        if (innerobject is IArrayAccessor accessor && accessor.Flags != null)
                                        {
                                            arrayacc.Flags.AddRange(accessor.Flags);
                                        }


                                        arrayacc.Elementtype = matchArrayType.Groups[3].Value;

                                        return arrayacc as CVariable;
                                    }
                                    // for CArrays of other types
                                    else
                                    {
                                        //throw new InvalidParsingException($"Invalid array type format: typename: {typename}.");
                                        CVariable innerobject = Create(match.Groups[2].Value, "", cr2w, null);
                                        IArrayAccessor arrayacc = MakeArray(typeof(CArray<>), innerobject.GetType());
                                        arrayacc.Elementtype = matchArrayType.Groups[3].Value;
                                        return arrayacc as CVariable;
                                    }
                                }
                            case "static":
                                {
                                    typename = match.Groups[1].Value;

                                    // match pattern e.g. 
                                    // static:  (4),(Uint32)
                                    var regArrayType = new Regex(@"(\d+),(.+)");
                                    var matchArrayType = regArrayType.Match(fullname);
                                    if (matchArrayType.Success)
                                    {
                                        CVariable innerobject = Create(matchArrayType.Groups[2].Value, "", cr2w, null);
                                        var arrayacc = MakeArray(typeof(CStatic<>), innerobject.GetType());
                                        arrayacc.Flags = new List<int>() { int.Parse(matchArrayType.Groups[1].Value) };
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
                                    CVariable innerobject = Create(match.Groups[2].Value, "", cr2w, null);
                                    return MakeGenericType(typeof(CBufferUInt16<>), innerobject);
                                }
                            case "CBufferUInt32":
                                {
                                    CVariable innerobject = Create(match.Groups[2].Value, "", cr2w, null);
                                    return MakeGenericType(typeof(CBufferUInt32<>), innerobject);
                                }
                            case "CBufferVLQ":
                                {
                                    CVariable innerobject = Create(match.Groups[2].Value, "", cr2w, null);
                                    return MakeGenericType(typeof(CBufferVLQ<>), innerobject);
                                }
                            case "CBufferVLQInt32":
                                {
                                    CVariable innerobject = Create(match.Groups[2].Value, "", cr2w, null);
                                    return MakeGenericType(typeof(CBufferVLQInt32<>), innerobject);
                                }
                            case "CCompressedBuffer":
                                {
                                    CVariable innerobject = Create(match.Groups[2].Value, "", cr2w, null);
                                    return MakeGenericType(typeof(CCompressedBuffer<>), innerobject);
                                }
                            case "CPaddedBuffer":
                                {
                                    CVariable innerobject = Create(match.Groups[2].Value, "", cr2w, null);
                                    return MakeGenericType(typeof(CPaddedBuffer<>), innerobject);
                                }
                            case "CEnum":
                                {
                                    Enum innerobject = CreateEnum(match.Groups[2].Value);
                                    return MakeGenericEnumType(typeof(CEnum<>), innerobject);
                                }
                            default:
                                {
                                    typename = match.Groups[1].Value;

                                    throw new NotImplementedException();

                                    break;
                                }

                        }
                    }
                    else
                        throw new NotImplementedException();
                    #endregion
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            else
            {
                #region FIXED SIZE ARRAYS
                // match pattern e.g. 
                // [(1)](Bezier2dHandle)
                var regFixedSizeArray = new Regex(@"^\[(\d+)\](.+)$");
                var matchFixedSizeArray = regFixedSizeArray.Match(typename);
                if (matchFixedSizeArray.Success)
                {
                    CVariable innerobject = Create(matchFixedSizeArray.Groups[2].Value, "", cr2w, null);
                    var arrayacc = MakeArray(typeof(CArrayFixedSize<>), innerobject.GetType());
                    arrayacc.Flags = new List<int>() { int.Parse(matchFixedSizeArray.Groups[1].Value) };
                    arrayacc.Elementtype = matchFixedSizeArray.Groups[2].Value;
                    return arrayacc as CVariable;
                }
                #endregion
                
                if (fullname.Contains("@SItem"))
                {
                    cr2w.UnknownTypes.Add($"Congratulations! You have found one of the hidden e3 files! These files are special." +
                        $" If you edited this file and are experiencing errors, please contact a member of the Wkit Team. ErrorCode: {fullname}");
                    return new SItem(cr2w, parentVariable, varname);
                }
                else if (fullname.Contains("#CEnvironmentDefinition"))
                {
                    cr2w.UnknownTypes.Add($"Congratulations! You have found one of the hidden e3 files! These files are special." +
                        $" If you edited this file and are experiencing errors, please contact a member of the Wkit Team. ErrorCode: {fullname}");
                    return new CHandle<CEnvironmentDefinition>(cr2w, parentVariable, varname);
                }
                else
                {
                    if (!cr2w.UnknownTypes.Contains(fullname))
                        cr2w.UnknownTypes.Add(fullname);

                    // this should never happen

                    if (readUnknownAsBytes)
                    {
                        return new CBytes(cr2w, parentVariable, "unknownBytes");
                    }
                    else
                        return null;
                }
                
            }            
                

            #region LOCAL FUNCTIONS


            IArrayAccessor MakeArray(Type arraytype, Type generictype)
            {
                Type elementType = typeof(CArray<>);

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
            Enum e = (Enum)Activator.CreateInstance(typeof(Enums).GetNestedTypes().FirstOrDefault(_ => _.Name == value));

            if (e.GetType().IsDefined(typeof(FlagsAttribute), false))
            {
                throw new NotImplementedException(); 
            }

            return e;
        }
    }
}