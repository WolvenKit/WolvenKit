using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Catel.IoC;
using CP77.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;

namespace CP77.CR2W.Types
{
    /// <summary>
    /// The reflection magic happens mostly here, with System.Activator.
    /// A class is instantiated from its type and the properties are deserialized from
    /// cr2w later, in CVariable.Read and CR2WFile.ReadVariable
    /// </summary>
    public static class CR2WTypeManager
    {
        #region Properties

        public static IEnumerable<string> AvailableTypes => AvailableVanillaTypes;

        public static IEnumerable<string> AvailableVanillaTypes
        {
            get
            {
                const string nspace = "CP77.CR2W.Types";

                var cr2wassembly = Assembly.GetExecutingAssembly();
                var vanillaclassNames = cr2wassembly.GetTypes()
                    .Where(_ => _.IsClass && _.Namespace == nspace)
                    .Select(_ => _.Name);

                return vanillaclassNames;
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// The instantiation step of the RedEngine-4 reflection.
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
                    object instance = System.Activator.CreateInstance(type, cr2w, parentVariable, varname);
                    return instance as CVariable;
                }
            }

            // check for enum types
            if (AssemblyDictionary.EnumExists(typename))
            {
                Enum e = (Enum)System.Activator.CreateInstance(AssemblyDictionary.GetEnumByName(typename));
                var cenum = MakeGenericEnumType(typeof(CEnum<>), e);
                return cenum;
            }
            else if (CR2WManager.EnumExists(typename))
            {
                Enum e = (Enum)System.Activator.CreateInstance(CR2WManager.GetEnumByName(typename));
                var cenum = MakeGenericEnumType(typeof(CEnum<>), e);
                return cenum;
            }
            // check for generic type
            else if (typename.StartsWith('['))
            {
                var idx = typename.IndexOf(']');

                string generictype = typename[(idx + 1)..];
                var arrayacc = MakeArray(typeof(CArrayFixedSize<>), generictype);
                var flagstr = typename[1..idx];
                arrayacc.Flags = new List<int>() { int.Parse(flagstr) };
                arrayacc.Elementtype = generictype;
                return arrayacc as CVariable;
            }
            else if (typename.Contains(':'))
            {
                #region GENERIC TYPES

                var splits = typename.Split(':');
                var generictype = splits.First();
                var innertype = string.Join(":", splits.Skip(1));
                // e.g. handle:CEntityTemplate
                switch (generictype)
                {
                    case "CHandle":
                    case "handle":
                    {
                        return MakeGenericType(typeof(CHandle<>), innertype);
                    }
                    case "wCHandle":
                    case "whandle":
                    {
                        return MakeGenericType(typeof(wCHandle<>), innertype);
                    }
                    case "curveData":
                    {
                        var obj = MakeGenericType(typeof(curveData<>), innertype);
                        (obj as ICurveDataAccessor).Elementtype = innertype;
                        return obj;
                    }
                    case "multiChannelCurve":
                    {
                        var obj = MakeGenericType(typeof(multiChannelCurve<>), innertype);
                        (obj as ICurveDataAccessor).Elementtype = innertype;
                        return obj;
                    }
                    case "CrRef":
                    case "rRef":
                    {
                        return MakeGenericType(typeof(rRef<>), innertype);
                    }
                    case "CraRef":
                    case "raRef":
                    {
                        return MakeGenericType(typeof(raRef<>), innertype);
                    }
                    case "array":
                    {
                        // match pattern e.g.
                        // array:            (array:)Float
                        // array of array:   (array:)handle:meshMeshAppearance

                        var arrayacc = MakeArray(typeof(CArray<>), innertype);
                        arrayacc.Elementtype = innertype;
                        return arrayacc as CVariable;
                    }
                    case "CArrayVLQInt32":
                    {
                        var arrayacc = MakeArray(typeof(CArrayVLQInt32<>), innertype);
                        arrayacc.Elementtype = innertype;
                        return arrayacc as CVariable;
                    }
                    case "CArrayCompressed":
                    {
                        var arrayacc = MakeArray(typeof(CArrayCompressed<>), innertype);
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
                            var arrayacc = MakeArray(typeof(CStatic<>), matchArrayType.Groups[2].Value);
                            arrayacc.Flags = new List<int>() { int.Parse(matchArrayType.Groups[1].Value) };
                            arrayacc.Elementtype = matchArrayType.Groups[2].Value;
                            return arrayacc as CVariable;
                        }
                        else
                        {
                            throw new InvalidParsingException($"Invalid static type format: typename: {typename}.");
                        }
                    }
                    case "CEnum":
                    {
                        Enum innerobject = CreateEnum(innertype);
                        return MakeGenericEnumType(typeof(CEnum<>), innerobject);
                    }
                    default:
                    {
                        throw new MissingTypeException(generictype);
                    }
                }

                #endregion GENERIC TYPES
            }
            else
            {
                // check if custom type
                if (CR2WManager.TypeExists(typename))
                {
                    var type = CR2WManager.GetTypeByName(typename);
                    object instance = System.Activator.CreateInstance(type, cr2w, parentVariable, varname);
                    return instance as CVariable;
                }

                // this should never happen

                if (!cr2w.UnknownTypes.Contains(fullname))
                    cr2w.UnknownTypes.Add(fullname);

                var Logger = ServiceLocator.Default.ResolveType<ILoggerService>();
                Logger.LogString($"UNKNOWN:{typename}:{varname}", Logtype.Error);

                if (readUnknownAsBytes)
                {
                    return new CBytes(cr2w, parentVariable, $"UNKNOWN:{typename}:{varname}");
                }
                else
                    return null;
            }

            #region LOCAL FUNCTIONS

            IArrayAccessor MakeArray(Type arraytype, string innertypename)
            {
                Type elementType;
                var generictype = GetGenericType(innertypename, cr2w);

                if (arraytype == typeof(CStatic<>))
                {
                    elementType = typeof(CStatic<>).MakeGenericType(generictype);
                }
                else if (arraytype == typeof(CArrayFixedSize<>))
                {
                    elementType = typeof(CArrayFixedSize<>).MakeGenericType(generictype);
                }
                else if (arraytype == typeof(CArray<>))
                {
                    elementType = typeof(CArray<>).MakeGenericType(generictype);
                }
                else if (arraytype == typeof(CArrayVLQInt32<>))
                {
                    elementType = typeof(CArrayVLQInt32<>).MakeGenericType(generictype);
                }
                else if (arraytype == typeof(CArrayCompressed<>))
                {
                    elementType = typeof(CArrayCompressed<>).MakeGenericType(generictype);
                }
                else
                {
                    throw new InvalidParsingException($"Could not create array type for {arraytype.Name}");
                }

                var array = System.Activator.CreateInstance(elementType, cr2w, parentVariable, varname) as CVariable;

                return array as IArrayAccessor;
            }

            CVariable MakeGenericType(Type gentype, string innertypename)
            {
                var typ = GetGenericType(innertypename, cr2w);
                Type elementType = gentype.MakeGenericType(typ);
                CVariable handle = System.Activator.CreateInstance(elementType, cr2w, parentVariable, varname) as CVariable;
                return handle;
            }

            CVariable MakeGenericEnumType(Type gentype, Enum innerobject)
            {
                if (innerobject != null)
                {
                    Type elementType = gentype.MakeGenericType(innerobject.GetType());
                    CVariable handle = System.Activator.CreateInstance(elementType, cr2w, parentVariable, varname) as CVariable;
                    return handle;
                }
                else
                {
                    throw new Exception();
                }
            }

            #endregion LOCAL FUNCTIONS
        }

        private static Type GetGenericType(string redtypename, CR2WFile cr2w)
        {
            var typename = REDReflection.GetWKitBaseTypeFromREDBaseType(redtypename);
            var typ = AssemblyDictionary.GetTypeByName(typename);
            if (typ == null)
            {
                var innerobject = Create(typename, "", cr2w, null);
                typ = innerobject.GetType();
            }

            return typ;
        }


        private static Enum CreateEnum(string value)
        {
            if (AssemblyDictionary.EnumExists(value))
            {
                var type = AssemblyDictionary.GetEnumByName(value);
                Enum e = (Enum)System.Activator.CreateInstance(type);

                return e;
            }
            else if (CR2WManager.EnumExists(value))
            {
                var type = CR2WManager.GetEnumByName(value);
                Enum e = (Enum)System.Activator.CreateInstance(type);

                return e;
            }

            return null;
        }

        #endregion Methods
    }
}
