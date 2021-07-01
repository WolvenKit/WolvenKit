using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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

        public static string HashFile(FileInfo fInfo, SHA256 mySha256)
        {
            var hashStr = "";
            if (!fInfo.Exists)
            {
                Console.WriteLine($"Tried to hash {fInfo.FullName} but no such file exists");
                return "";
            }

            try
            {
                var fileStream = fInfo.Open(FileMode.Open);
                fileStream.Position = 0;

                var hashValue = mySha256.ComputeHash(fileStream);

                hashStr = PrettyByteArray(hashValue);

                fileStream.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine($"I/O Exception: {e.Message}");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine($"Access Exception: {e.Message}");
            }

            return hashStr;
        }

        // Display a byte array in a readable format.
        public static string PrettyByteArray(IEnumerable<byte> array) => array.Aggregate("", (current, t) => current + $"{t:X2}");
    }
}
