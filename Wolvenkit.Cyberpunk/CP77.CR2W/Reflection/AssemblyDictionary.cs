using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W.Reflection
{
    /// <summary>
    /// Provides methods to get runtime types withtin the current assembly by name.
    /// </summary>
    public static class AssemblyDictionary
    {
        private static Dictionary<string, Type> m_types;
        private static Dictionary<string, Type> m_enums;

        static AssemblyDictionary()
        {
            LoadTypes();
            LoadEnums();
        }

        #region Types
        public static Type GetTypeByName(string typeName)
        {
            m_types.TryGetValue(typeName, out Type type);
            return type;
        }

        public static IEnumerable<Type> GetSubClassesOf(Type type) => m_types?.Values.Where(_ => _.IsSubclassOf(type)).ToList();

        public static bool TypeExists(string typeName) => m_types.ContainsKey(typeName);

        private static void LoadTypes()
        {
            m_types = new Dictionary<string, Type>();
            Assembly lib = Assembly.GetExecutingAssembly();

            #region .NET Types
            m_types.Add("Uint8",   typeof(System.Byte));
            m_types.Add("Uint16",  typeof(System.UInt16));
            m_types.Add("Uint32",  typeof(System.UInt32));
            m_types.Add("Uint64",  typeof(System.UInt64));
            m_types.Add("Int8",    typeof(System.SByte));
            m_types.Add("Int16",   typeof(System.Int16));
            m_types.Add("Int32",   typeof(System.Int32));
            m_types.Add("Int64",   typeof(System.Int64));
            m_types.Add("Bool",    typeof(System.Boolean));
            m_types.Add("Float",   typeof(System.Single));
            m_types.Add("Double",  typeof(System.Double));
            m_types.Add("String",  typeof(System.String));
            #endregion

            foreach (Type type in lib.GetTypes())
            {
                if (!type.IsPublic)
                    continue;

                if (m_types.ContainsKey(type.Name))
                    continue;

                m_types.Add(type.Name, type);
            }
        }
        #endregion

        #region Enums
        private static void LoadEnums()
        {
            m_enums = new Dictionary<string, Type>();

            foreach (Type type in typeof(Enums).GetNestedTypes())
            {
                if (!type.IsEnum)
                    continue;

                if (m_enums.ContainsKey(type.Name))
                    continue;

                m_enums.Add(type.Name, type);
            }
        }

        public static Type GetEnumByName(string typeName)
        {
            m_enums.TryGetValue(typeName, out Type type);
            return type;
        }

        public static bool EnumExists(string typeName) => m_enums.ContainsKey(typeName);
        #endregion


        public static void Reload()
        {
            m_types.Clear();
            m_enums.Clear();
            LoadTypes();
            LoadEnums();
        }
    }
}