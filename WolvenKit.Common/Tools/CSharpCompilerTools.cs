using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using System.Runtime;
using WolvenKit.Common.Services;

namespace WolvenKit.Common.Tools
{
    public static class CSharpCompilerTools
    {
        /// <summary>
        /// Compiles a source string with Roslyn
        /// </summary>
        /// <param name="sourceString"></param>
        /// <returns></returns>
        public static Assembly CompileAssemblyFromStrings(string sourceString, Assembly currentCustomAssembly, ILoggerService logger  = null)
        {
            var syntaxTree = CSharpSyntaxTree.ParseText(sourceString);
            string assemblyName = Guid.NewGuid().ToString();
            
            var references = GetAssemblyReferences(currentCustomAssembly);

            var compilation = CSharpCompilation.Create(
                assemblyName,
                new[] { syntaxTree },
                references,
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

            Assembly assembly = null;
            try
            {
                assembly = CompileAndLoadAssembly(compilation);
            }
            catch (Exception ex)
            {
                logger?.LogString(ex.ToString(), Logtype.Error);
            }

            return assembly;
        }

        private static IEnumerable<MetadataReference> GetAssemblyReferences(Assembly currentCustomAssembly)
        {
            var assemblies = AppDomain.CurrentDomain
                .GetAssemblies()
                .Where(a => !a.IsDynamic)
                .Where(a => !string.IsNullOrEmpty(a.Location))
                .Select(a => MetadataReference.CreateFromFile(a.Location));

            return assemblies;
        }

        //https://gist.github.com/GeorgDangl/4a9982a3b520f056a9e890635b3695e0
        private static Assembly CompileAndLoadAssembly(CSharpCompilation _compilation)
        {
            using (var ms = new MemoryStream())
            {
                var result = _compilation.Emit(ms);
                ThrowExceptionIfCompilationFailure(result);
                ms.Seek(0, SeekOrigin.Begin);

                return Assembly.Load(ms.ToArray());
            }
        }


        //https://gist.github.com/GeorgDangl/4a9982a3b520f056a9e890635b3695e0
        private static void ThrowExceptionIfCompilationFailure(EmitResult result)
        {
            if (!result.Success)
            {
                var compilationErrors = result.Diagnostics.Where(diagnostic =>
                        diagnostic.IsWarningAsError ||
                        diagnostic.Severity == DiagnosticSeverity.Error)
                    .ToList();
                if (compilationErrors.Any())
                {
                    var firstError = compilationErrors.First();
                    var errorNumber = firstError.Id;
                    var errorDescription = firstError.GetMessage();
                    var firstErrorMessage = $"{errorNumber}: {errorDescription};";
                    throw new Exception($"Compilation failed, first error is: {firstErrorMessage}");
                }
            }
        }



        /// <summary>
        /// Compiles a .cs file into a dll with CodeDom. Deprecated up until c#5
        /// </summary>
        /// <param name="sourceName"></param>
        /// <returns></returns>
        public static Assembly CompileAssemblyFromStringsCodeDom(params string[] sourceStrings)
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
                    //return null;
                    ex.ToString();
                }
            }


            //bool compileOk = false;
            var provider = new Microsoft.CSharp.CSharpCodeProvider();
            CompilerParameters cp = new CompilerParameters
            {
                GenerateExecutable = false,
                GenerateInMemory = true,
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
                //compileOk = false;
                return null;
            }
            else
            {
                //compileOk = true;
                return cr.CompiledAssembly;
            }
        }
    }
}
