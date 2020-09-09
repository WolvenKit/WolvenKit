using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Tools
{
    public static class CSharpCompilerTools
    {
        /// <summary>
        /// Compiles a .cs file into a dll
        /// </summary>
        /// <param name="sourceName"></param>
        /// <returns></returns>
        public static Assembly CompileAssemblyFromStrings(params string[] sourceStrings)
        {
            // try deleting the old assembly
            var path = Path.GetFullPath("CustomCr2w.dll");
            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
                }
                catch (Exception ex)
                {
                    return null;
                }
            }


            bool compileOk = false;
            var provider = new Microsoft.CSharp.CSharpCodeProvider(new Dictionary<String, String> { { "CompilerVersion", "v3.5" } });
            CompilerParameters cp = new CompilerParameters
            {
                GenerateExecutable = false,
                GenerateInMemory = false,
                TreatWarningsAsErrors = false,
                OutputAssembly = "CustomCr2w.dll"
            };

            var assemblies = AppDomain.CurrentDomain
                       .GetAssemblies()
                       .Where(a => !a.IsDynamic)
                       .Where(a => !cp.ReferencedAssemblies.Contains(a.Location))
                       .Select(a => a.Location);
            assemblies = assemblies.Skip(1);
            cp.ReferencedAssemblies.AddRange(assemblies.ToArray());

            CompilerResults cr = provider.CompileAssemblyFromSource(cp, sourceStrings);

            if (cr.Errors.Count > 0)
            {
                // Display compilation errors.
                Console.WriteLine($"Errors building {cr.PathToAssembly}");
                foreach (CompilerError ce in cr.Errors)
                {
                    Console.WriteLine("  {0}", ce.ToString());
                    Console.WriteLine();
                }
            }
            else
            {
                // Display a successful compilation message.
                Console.WriteLine($"Source built into {cr.PathToAssembly} successfully.");
            }

            // Return the results of the compilation.
            if (cr.Errors.Count > 0)
            {
                compileOk = false;
                return null;
            }
            else
            {
                compileOk = true;
                return cr.CompiledAssembly;
            }
        }
    }
}
