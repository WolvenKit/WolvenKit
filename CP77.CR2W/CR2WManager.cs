using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using WolvenKit.Common.Services;
using WolvenKit.Common.Tools;
using WolvenKit.CR2W.Reflection;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W
{
    public sealed class CR2WManager
    {
        private static readonly CR2WManager instance = new CR2WManager();
        static CR2WManager() { }

        private CR2WManager()
        {
            
        }

        public static CR2WManager Instance => instance;

        private static Assembly m_assembly;
        private static LoggerService m_logger;
        private static DirectoryInfo m_projectinfo;
        private static Dictionary<string, Type> m_types;
        private static Dictionary<string, Type> m_enums;

        /// <summary>
        /// Gets all available types, custom and vanilla for a given typename
        /// </summary>
        /// <param name="typename"></param>
        /// <returns></returns>
        public static IEnumerable<Type> GetAvailableTypes(string typename)
        {
            var availableTypes = new List<Type>();

            if (AssemblyDictionary.TypeExists(typename))
            {
                availableTypes.Add(AssemblyDictionary.GetTypeByName(typename));
                var subclasses = AssemblyDictionary.GetSubClassesOf(AssemblyDictionary.GetTypeByName(typename));
                if (subclasses != null)
                    availableTypes.AddRange(subclasses);

                // check if subclasses exist in custom assemblies
                var ssubclasses = CR2WManager.GetSubClassesOf(AssemblyDictionary.GetTypeByName(typename));
                if (ssubclasses != null)
                    availableTypes.AddRange(ssubclasses);
            }
            else if (CR2WManager.TypeExists(typename))
            {
                availableTypes.Add(CR2WManager.GetTypeByName(typename));
                var subclasses = CR2WManager.GetSubClassesOf(CR2WManager.GetTypeByName(typename));
                if (subclasses != null)
                    availableTypes.AddRange(subclasses);

                // check if subclasses exist in main assembly
                var ssubclasses = AssemblyDictionary.GetSubClassesOf(CR2WManager.GetTypeByName(typename));
                if (ssubclasses != null)
                    availableTypes.AddRange(ssubclasses);
            }
            else
            {
                //MainController.LogString(
                //    "No such type exists. Make sure you have all custom types in a .ws file inside the modproject.",
                //    Logtype.Error);
                return null;
            }

            return availableTypes.Distinct();
        }

        private static List<Type> GetSubClassesOf(Type type) => m_types?.Values.Where(_ => _.IsSubclassOf(type)).ToList();

        public static Type GetTypeByName(string typeName)
        {
            m_types.TryGetValue(typeName, out Type type);
            return type;
        }

        public static bool TypeExists(string typeName) => m_types?.ContainsKey(typeName) ?? false;

        private static void LoadTypes()
        {
            m_types = new Dictionary<string, Type>();

            foreach (Type type in m_assembly.GetTypes())
            {
                if (!type.IsPublic)
                    continue;

                if (m_types.ContainsKey(type.Name))
                    continue;

                m_types.Add(type.Name, type);
            }
        }

        /// <summary>
        /// Completely reloads a custom assembly
        /// from .ws scripts and compiles all classes
        /// </summary>
        public static void ReloadAssembly(ILoggerService logger = null)
        {
            if (m_projectinfo != null && m_projectinfo.Exists)
            {

                var (count, csharpstring) = InterpretScriptClasses();
                if (count <= 0) return;
                m_assembly = CSharpCompilerTools.CompileAssemblyFromStrings(csharpstring, m_assembly, logger);
                if (m_assembly != null)
                {
                    m_logger.LogString($"Successfully compiled custom assembly {m_assembly.GetName()}", Logtype.Success);
                    LoadTypes();
                    LoadEnums();
                }
                else
                    m_logger.LogString($"Custom class assembly could not be compiled. An error occured", Logtype.Error);
            }
        }

        #region Enums
        private static void LoadEnums()
        {
            m_enums = new Dictionary<string, Type>();

            if (!m_types.ContainsKey("Enums"))
                return;


            foreach (Type type in CR2WManager.GetTypeByName("Enums").GetNestedTypes())
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

        public static bool EnumExists(string typeName) => m_enums?.ContainsKey(typeName) ?? false;
        #endregion










        private const string header = @"
using System.IO;
using FastMember;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
";

        private const string footer = @"
		public override void Read(BinaryReader file, uint size)
		{
			base.Read(file, size);
		}

		public override void Write(BinaryWriter file)
		{
			base.Write(file);
		}
	}

";

        private static readonly Func<string, string> funcCtor = (x) => $"\t\tpublic {x}(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)\r\n\t\t{{\r\n\t\t}}\r\n";

        private static (int, string) InterpretScriptClasses()
        {
            List<string> importedClasses = new List<string>();
            List<string> importedEnums = new List<string>();
            string output = "";

            using (StringWriter sw = new StringWriter())
            {
                // usings and namespace
                sw.WriteLine(header);

                FileInfo[] projectScriptFiles = m_projectinfo.GetFiles("*.ws", SearchOption.AllDirectories);


                sw.WriteLine("\tpublic static partial class Enums");
                sw.WriteLine("\t{\r\n");
                // interpret enums
                #region Enums
                foreach (var file in projectScriptFiles)
                {
                    int depth = 0;
                    bool isReading = false;
                    string enumname = "";
                    string enumstring = "";

                    var lines = File.ReadLines(file.FullName);
                    foreach (var line in lines)
                    {
                        // check if should start reading
                        if (line.Contains("enum "))
                        {

                            // interpret line
                            string intline = InterpretEnumLine(line, ref enumname);
                            if (!string.IsNullOrEmpty(intline))
                            {
                                // check if enum is vanilla
                                if (AssemblyDictionary.EnumExists(enumname))
                                    continue;
                                if (importedEnums.Contains(enumname))
                                    continue;

                                enumstring += $"\t{intline}\r\n";

                                isReading = true;
                            }

                            // increment or decrement the depth
                            depth += line.Count(_ => _ == '{');
                            depth -= line.Count(_ => _ == '}');
                            continue;
                        }

                        // if reading, interpret results
                        if (isReading)
                        {
                            // increment or decrement the depth
                            depth += line.Count(_ => _ == '{');
                            depth -= line.Count(_ => _ == '}');

                            // only interpret variables at depth 1 (from the class depth)
                            if (depth == 1)
                            {
                                if (!string.IsNullOrEmpty(line))
                                {
                                    var iline = InterpretEnumVarLine(line);
                                    if (!string.IsNullOrEmpty(iline))
                                    {
                                        enumstring += $"\t\t\t{iline}\r\n";
                                    }
                                }
                            }

                            // if depth is 0 again, stop reading and write to output
                            if (depth == 0)
                            {
                                sw.WriteLine(enumstring);
                                sw.WriteLine("\t\t}");

                                isReading = false;
                                enumstring = "";
                                importedEnums.Add(enumname);
                            }
                        }
                    }
                }
                #endregion
                sw.WriteLine("\t}\r\n");

                // interpret classes
                #region Classes
                foreach (var file in projectScriptFiles)
                {
                    int depth = 0;
                    bool isReading = false;
                    int varcounter = 0;
                    string classname = "";
                    string classstring = "";

                    var lines = File.ReadLines(file.FullName);
                    foreach (var line in lines)
                    {
                        // check if should start reading
                        if (line.Contains("class "))
                        {

                            // interpret line
                            string intline = InterpretClassLine(line, ref classname);
                            if (!string.IsNullOrEmpty(intline))
                            {
                                // check if class is vanilla
                                if (AssemblyDictionary.TypeExists(classname))
                                    continue;
                                if (importedClasses.Contains(classname))
                                    continue;

                                classstring += $"{intline}\r\n";

                                isReading = true;
                            }

                            // increment or decrement the depth
                            depth += line.Count(_ => _ == '{');
                            depth -= line.Count(_ => _ == '}');
                            continue;
                        }

                        // if reading, interpret results
                        if (isReading)
                        {
                            // increment or decrement the depth
                            depth += line.Count(_ => _ == '{');
                            depth -= line.Count(_ => _ == '}');

                            // only interpret variables at depth 1 (from the class depth)
                            if (depth == 1)
                            {
                                string intline = InterpretVarLine(line, varcounter, importedEnums);
                                if (!string.IsNullOrEmpty(intline))
                                {
                                    classstring += $"{intline}";
                                    varcounter++;
                                }
                            }

                            // if depth is 0 again, stop reading and write to output
                            if (depth == 0)
                            {
                                sw.WriteLine(classstring);
                                sw.WriteLine(funcCtor(classname));
                                sw.WriteLine(footer);

                                varcounter = 0;
                                isReading = false;
                                classstring = "";
                                importedClasses.Add(classname);
                            }
                        }
                    }
                }
                #endregion


                // namespace end
                sw.WriteLine("}");
                output = sw.ToString();
            }

            if (importedClasses.Count > 0)
                if (m_logger != null) m_logger.LogString($"Sucessfully parsed {importedClasses.Count} custom classes: " +
                $"{string.Join(", ", importedClasses)}", Logtype.Success);
            return (importedClasses.Count, output);
        }


        private static string InterpretVarLine(string input, int counter, List<string> customenums)
        {
            string csline = "";

            var regvar = new Regex(@"(?:.*)var\s+(?<VARNAME>.+?)\s*:\s*(?<VARTYPE>[^=]*).*;");
            var matchIsVar = regvar.Match(input);
            if (matchIsVar.Success)
            {
                string redtype = matchIsVar.Groups["VARTYPE"].Value;
                // support generic types (e.g. array<string>)
                string vartype = GetCsTypeRecursive(redtype, customenums);

                string varname = matchIsVar.Groups["VARNAME"].Value;
                // support multiple var declarations in one line (e.g. var i, j, size : int;)
                if (varname.Contains(","))
                {
                    var splits = varname.Split(',');
                    foreach (var split in splits)
                    {
                        var tsplit = split.Trim(' ');
                        csline += $"\t\t[Ordinal({counter})] [RED]\tpublic {vartype} {tsplit} {{get; set;}}\r\n";
                    }
                }
                else
                {
                    csline += $"\t\t[Ordinal({counter})] [RED]\tpublic {vartype} {varname} {{get; set;}}\r\n";
                }
            }
            else
            {
                
            }

            return csline;
        }

        private static string InterpretEnumVarLine(string input)
        {
            string csline = "";
            var regvar = new Regex(@"\.*(?<VARNAME>\w+)\.*");
            var matchIsVar = regvar.Match(input);
            if (matchIsVar.Success)
            {
                csline = $"{matchIsVar.Groups["VARNAME"].Value},";
            }

            return csline;
        }

        private static string GetCsTypeRecursive(string input, List<string> customenums)
        {
            if (input.Contains("array")) // TODO: support for more generics?
            {
                string returntype = input;

                // array types
                // [Ordinal(18)] [RED("editorCachedIkEffectorsID", 2, 0)] public CArray<CInt32> EditorCachedIkEffectorsID { get; set; }
                var regarray = new Regex(@"(?:.*)array\s*<\s*(?<TYPE>\w+)\s*>.*");
                var matchIsArray = regarray.Match(input);
                if (matchIsArray.Success)
                {
                    var typename = matchIsArray.Groups["TYPE"].Value;
                    returntype = $"CArray<{GetCsTypeRecursive(typename, customenums)}>";
                }
                else
                {
                    
                }
                return returntype;
            }
            else
            {
                input = input.Trim(' ');
                if (AssemblyDictionary.EnumExists(input) || customenums.Contains(input))
                    input = $"CEnum<{input}>";
                return REDReflection.GetWKitBaseTypeFromREDBaseType(input);
            }
        }

        private static string InterpretClassLine(string input, ref string classname)
        {
            string csline = "";

            // check if class
            var regClass = new Regex(@"(.*)class\s+(\w+)(.*)");
            var matchIsClass = regClass.Match(input);
            if (matchIsClass.Success)
            {
                csline += "\t[REDMeta]\r\n";
                classname = matchIsClass.Groups[2].Value;

                // check if class extends
                string rest = matchIsClass.Groups[3].Value;
                var regExtends = new Regex(@"(.*)extends\s+(\w+)(.*)");
                var matchExtends = regExtends.Match(rest);
                if (matchExtends.Success)
                {
                    string parentclassname = matchExtends.Groups[2].Value;
                    csline += $"\tpublic class {classname} : {parentclassname}\r\n\t{{";

                    //// interpret the rest
                    //rest = matchExtends.Groups[3].Value;
                    //csline += InterpretLine(rest);
                }
                else
                {
                    csline += $"\tpublic class {classname}\r\n\t\t{{";
                }
            }
            else
            {

            }


            return csline;
        }

        private static string InterpretEnumLine(string input, ref string enumname)
        {
            string csline = "";

            // check if class
            var regClass = new Regex(@"(.*)enum\s+(\w+)(.*)");
            var matchIsClass = regClass.Match(input);
            if (matchIsClass.Success)
            {
                enumname = matchIsClass.Groups[2].Value;
                csline += $"\tpublic enum {enumname}\r\n\t\t{{";
            }

            return csline;
        }

        public static void Init(string projectpath, LoggerService logger)
        {
            m_logger = logger;
            m_projectinfo = new DirectoryInfo(projectpath);

            ReloadAssembly(logger);
        }

    }
}
