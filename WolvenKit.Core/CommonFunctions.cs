using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Microsoft.Win32;
using Semver;
using WolvenKit.Core.Extensions;

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

        public static SemVersion GetAssemblyVersion(Assembly? assembly)
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
            try
            {
                var runtimeAssemblies = Directory.GetFiles(RuntimeEnvironment.GetRuntimeDirectory(), "*.dll");
                var paths = new List<string>(runtimeAssemblies);
                string fullAssemblyPath = assemblyName;

                if (!Path.IsPathRooted(assemblyName))
                {
                    var searchDirs = new[]
                    {
                        AppContext.BaseDirectory,
                        Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "",
                        RuntimeEnvironment.GetRuntimeDirectory()
                    };

                    foreach (var dir in searchDirs.Distinct())
                    {
                        if (string.IsNullOrEmpty(dir)) continue;

                        var candidate = Path.Combine(dir, assemblyName);
                        if (File.Exists(candidate))
                        {
                            fullAssemblyPath = candidate;
                            break;
                        }
                    }
                }

                try
                {
                    var targetDir = Path.GetDirectoryName(fullAssemblyPath);
                    if (!string.IsNullOrEmpty(targetDir) && Directory.Exists(targetDir))
                    {
                        foreach (var dll in Directory.GetFiles(targetDir, "*.dll", SearchOption.TopDirectoryOnly))
                        {
                            if (!paths.Contains(dll))
                                paths.Add(dll);
                        }
                    }
                }
                catch { /* best effort */ }

                if (paths.Count == 0)
                {
                    return SemVersion.Parse("1.0.0", SemVersionStyles.Strict);
                }

                return _GetAssemblyVersion(paths.First(s => s == fullAssemblyPath));
            }
            catch (Exception ex)
            {
                // Completely defensive fallback for integration tests and environments
                // where MetadataLoadContext can't resolve all WPF assemblies.
                Console.WriteLine($"[GetAssemblyVersion] Failed to read version metadata for '{assemblyName}': {ex.Message}");
                return SemVersion.Parse("1.0.0", SemVersionStyles.Strict);
            }
        }

        private static SemVersion _GetAssemblyVersion(string assemblyPath)
        {
            try
            {
                if (!Path.IsPathRooted(assemblyPath))
                {
                    var searchDirs = new[]
                    {
                        AppContext.BaseDirectory,
                        Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ""
                    };

                    foreach (var dir in searchDirs.Distinct())
                    {
                        if (string.IsNullOrEmpty(dir))
                            continue;

                        var candidate = Path.Combine(dir, assemblyPath);

                        if (File.Exists(candidate))
                        {
                            assemblyPath = candidate;
                            break;
                        }
                    }
                }

                if (!File.Exists(assemblyPath))
                {
                    return SemVersion.Parse("1.0.0", SemVersionStyles.Strict);
                }

                var assemblyName = AssemblyName.GetAssemblyName(assemblyPath);

                if (assemblyName.Version is { } version)
                {
                    return SemVersion.Parse(
                        $"{version.Major}.{version.Minor}.{version.Build}",
                        SemVersionStyles.Strict);
                }

                return SemVersion.Parse("1.0.0", SemVersionStyles.Strict);
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"[GetAssemblyVersion] Failed to read version metadata for '{assemblyPath}': {ex.Message}");

                return SemVersion.Parse("1.0.0", SemVersionStyles.Strict);
            }
        }

        //public static string GetDepotPathFromHash(UInt64 hash)
        //{
        //    var hashService = Locator.Current.GetService<IHashService>();
        //    return hashService.Get(hash);
        //}

        public static (string, long) HashFileSHA512(string filepath)
        {
            using var shaM = SHA512.Create();
            using var fileStream = File.OpenRead(filepath);
            var hash1 = shaM.ComputeHash(fileStream);
            var hashStr = BitConverter.ToString(hash1).Replace("-", "").ToLowerInvariant();
            return (hashStr, fileStream.Length);
        }

        // Display a byte array in a readable format.
        public static string PrettyByteArray(IEnumerable<byte> array) => array.Aggregate("", (current, t) => current + $"{t:X2}");

        public static bool AreLongPathsEnabled()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\FileSystem", "LongPathsEnabled", 0) is 1;
            }
            return true;
        }
    }
}
