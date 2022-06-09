using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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

        public static SemVersion GetAssemblyVersion(Assembly assembly)
        {
            if (assembly == null)
            {
                throw new ArgumentNullException(nameof(assembly));
            }

            var infoAttr = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();

            return infoAttr != null ? SemVersion.Parse(infoAttr.InformationalVersion, SemVersionStyles.Strict) : SemVersion.Parse("1.0.0", SemVersionStyles.Strict);
        }

        public static SemVersion GetAssemblyVersion(string assemblyName)
        {
            var runtimeAssemblies = Directory.GetFiles(RuntimeEnvironment.GetRuntimeDirectory(), "*.dll");
            var paths = new List<string>(runtimeAssemblies);
            if (paths == null)
            {
                return SemVersion.Parse("1.0.0", SemVersionStyles.Strict);
            }
            var resolver = new PathAssemblyResolver(paths);
            var mlc = new MetadataLoadContext(resolver);

            using (mlc)
            {
                var assembly = mlc.LoadFromAssemblyPath(assemblyName);
                var productVersion = "1.0.0";

                var attributes = assembly.CustomAttributes.ToList();
                for (var i = 0; i < attributes.Count; i++)
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

                var version = SemVersion.Parse(productVersion, SemVersionStyles.Strict);
                return version;
            }
        }

        //public static string GetDepotPathFromHash(UInt64 hash)
        //{
        //    var hashService = Locator.Current.GetService<IHashService>();
        //    return hashService.Get(hash);
        //}

        public static (string, long) HashFileSHA512(string filepath)
        {
            using (var shaM = SHA512.Create())
            {
                using var fileStream = File.OpenRead(filepath);
                var hash1 = shaM.ComputeHash(fileStream);
                var hashStr = BitConverter.ToString(hash1).Replace("-", "").ToLowerInvariant();
                return (hashStr, fileStream.Length);
            }
        }

        // Display a byte array in a readable format.
        public static string PrettyByteArray(IEnumerable<byte> array) => array.Aggregate("", (current, t) => current + $"{t:X2}");


    }
}
