using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Semver;

namespace WolvenKit.Core
{
    public static class CommonFunctions
    {
        public static Assembly GetAssembly(string assemblyName)
        {
            var runtimeAssemblies = Directory.GetFiles(RuntimeEnvironment.GetRuntimeDirectory(), "*.dll");
            var paths = new List<string>(runtimeAssemblies);
            var resolver = new PathAssemblyResolver(paths);
            var mlc = new MetadataLoadContext(resolver);

            using (mlc)
            {
                var a = mlc.LoadFromAssemblyPath(assemblyName);
                return a;
            }
        }

        public static SemVersion GetAssemblyVersion(string assemblyName)
        {
            var runtimeAssemblies = Directory.GetFiles(RuntimeEnvironment.GetRuntimeDirectory(), "*.dll");
            var paths = new List<string>(runtimeAssemblies);
            var resolver = new PathAssemblyResolver(paths);
            var mlc = new MetadataLoadContext(resolver);

            using (mlc)
            {
                var assembly = mlc.LoadFromAssemblyPath(assemblyName);
                var productVersion = "1.0.0";

                var attributes = assembly.CustomAttributes.ToList();
                for (int i = 0; i < attributes.Count; i++)
                {
                    var a = attributes[i];

                    try
                    {
                        var t = a.AttributeType.Name;


                        if (t == nameof(AssemblyInformationalVersionAttribute))
                        {
                            productVersion = (string)a.ConstructorArguments.First().Value;
                            break;
                        }
                    }
                    catch (FileNotFoundException ex)
                    {
                        // We are missing the required dependency assembly.
                        Console.WriteLine($"Error while getting attribute type: {ex.Message}");
                    }


                }


                //var attr = assembly
                //    .CustomAttributes.First(_ => _.AttributeType.Name.Equals(nameof(AssemblyInformationalVersionAttribute)));
                //var productVersion = "8.2.2"; /*(string)attr.ConstructorArguments.First().Value;*/

                //var productVersion = FileVersionInfo.GetVersionInfo(assembly.Location).ProductVersion;

                var version = SemVersion.Parse(productVersion);
                return version;
            }

            //var name = GetAssembly(assemblyName)?.GetName();
            //return name?.Version;

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
