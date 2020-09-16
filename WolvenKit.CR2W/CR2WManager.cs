using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using WolvenKit.Common.Services;
using WolvenKit.Common.Tools;
using WolvenKit.CR2W.Reflection;

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
        private static Dictionary<String, Type> m_types;


        public static Type GetTypeByName(string typeName)
        {
            m_types.TryGetValue(typeName, out Type type);
            return type;
        }

        public static bool TypeExists(string typeName) => m_types.ContainsKey(typeName);

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
        public static void ReloadAssembly()
        {
            if (m_projectinfo != null && m_projectinfo.Exists)
            {
                m_assembly = CSharpCompilerTools.CompileAssemblyFromStrings(InterpretScriptClasses(), m_assembly);
                if (m_assembly != null)
                {
                    m_logger.LogString($"Successfully compiled custom assembly {m_assembly.GetName()}", Logtype.Success);
                    LoadTypes();
                }
                else
                    m_logger.LogString($"Custom class assembly could not be compiled. An error occured", Logtype.Error);
            }
        }


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

        private static string InterpretScriptClasses()
        {
            List<string> importedClases = new List<string>();
            string output = "";

            using (StringWriter sw = new StringWriter())
            {
                // usings and namespace
                sw.WriteLine(header);

                FileInfo[] projectScriptFiles = m_projectinfo.GetFiles("*.ws", SearchOption.AllDirectories);
                // all classes
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
                                if (importedClases.Contains(classname))
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
                                string intline = InterpretVarLine(line, varcounter);
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
                                importedClases.Add(classname);
                            }
                        }
                    }
                }

                // namespace end
                sw.WriteLine("}");
                output = sw.ToString();
            }

            if (importedClases.Count > 0)
                if (m_logger != null) m_logger.LogString($"Sucessfully parsed {importedClases.Count} custom classes: " +
                $"{string.Join(", ", importedClases)}", Logtype.Success);
            return output;
        }


        private static string InterpretVarLine(string input, int counter)
        {
            string csline = "";

            var regvar = new Regex(@"(?:.*)var\s+(?<VARNAME>.+?)\s*:\s*(?<VARTYPE>[^=]*).*;");
            var matchIsVar = regvar.Match(input);
            if (matchIsVar.Success)
            {
                string redtype = matchIsVar.Groups["VARTYPE"].Value;
                // support generic types (e.g. array<string>)
                string vartype = GetCsTypeRecursive(redtype);


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

        private static string GetCsTypeRecursive(string input)
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
                    returntype = $"CArray<{GetCsTypeRecursive(typename)}>";
                }
                else
                {
                    
                }
                return returntype;
            }
            else
            {
                input = input.Trim(' ');
                if (AssemblyDictionary.EnumExists(input))
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



        public static void Init(string projectpath, LoggerService logger)
        {
            m_logger = logger;
            m_projectinfo = new DirectoryInfo(projectpath);

            ReloadAssembly();
        }

    }
}
