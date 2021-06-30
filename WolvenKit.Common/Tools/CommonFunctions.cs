using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Tools
{
    public static class CommonFunctions
    {
        public static Version GetAssemblyVersion(string assemblyName)
        {
            var runtimeAssemblies = Directory.GetFiles(RuntimeEnvironment.GetRuntimeDirectory(), "*.dll");
            var paths = new List<string>(runtimeAssemblies);
            var resolver = new PathAssemblyResolver(paths);
            var mlc = new MetadataLoadContext(resolver);

            using (mlc)
            {
                // Load assembly into MetadataLoadContext.
                var assembly = mlc.LoadFromAssemblyPath(assemblyName);
                var name = assembly.GetName();
                return name.Version;
            }
        }
    }
}
