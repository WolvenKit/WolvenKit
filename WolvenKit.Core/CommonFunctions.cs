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
            return ParseInformationalVersion(infoAttr?.InformationalVersion);
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
                            productVersion = a.ConstructorArguments.First().Value as string;
                            break;
                        }
                    }
                    catch (FileNotFoundException ex)
                    {
                        // We are missing the required dependency assembly.
                        Console.WriteLine($"Error while getting attribute type: {ex.Message}");
                    }
                }

                return ParseInformationalVersion(productVersion);
            }
        }

        /// <summary>
        /// Parses an assembly informational version into a SemVersion.
        /// Handles common .NET stamps that are not strict SemVer, e.g. four-part
        /// versions with SourceLink metadata: "2.16.1.112+abc123" (test hosts / some deps).
        /// </summary>
        public static SemVersion ParseInformationalVersion(string? informationalVersion)
        {
            if (string.IsNullOrWhiteSpace(informationalVersion))
            {
                return SemVersion.Parse("1.0.0", SemVersionStyles.Strict);
            }

            if (SemVersion.TryParse(informationalVersion, SemVersionStyles.Strict, out var strict))
            {
                return strict;
            }

            // Strip +build metadata, then optional -prerelease, then collapse a.b.c.d -> a.b.c.
            var plusIndex = informationalVersion.IndexOf('+');
            var build = plusIndex >= 0 ? informationalVersion[(plusIndex + 1)..] : null;
            var coreAndPre = plusIndex >= 0 ? informationalVersion[..plusIndex] : informationalVersion;

            var dashIndex = coreAndPre.IndexOf('-');
            var core = dashIndex >= 0 ? coreAndPre[..dashIndex] : coreAndPre;
            var prerelease = dashIndex >= 0 ? coreAndPre[(dashIndex + 1)..] : null;

            var parts = core.Split('.');
            if (parts.Length >= 3
                && int.TryParse(parts[0], out var major)
                && int.TryParse(parts[1], out var minor)
                && int.TryParse(parts[2], out var patch))
            {
                // Rebuild a strict SemVer string: major.minor.patch[-pre][+build]
                var rebuilt = $"{major}.{minor}.{patch}";
                if (!string.IsNullOrEmpty(prerelease))
                {
                    rebuilt += $"-{prerelease}";
                }

                if (!string.IsNullOrEmpty(build))
                {
                    rebuilt += $"+{build}";
                }

                if (SemVersion.TryParse(rebuilt, SemVersionStyles.Strict, out var collapsed))
                {
                    return collapsed;
                }

                // Build metadata can contain characters SemVer rejects; keep major.minor.patch only.
                if (SemVersion.TryParse($"{major}.{minor}.{patch}", SemVersionStyles.Strict, out collapsed))
                {
                    return collapsed;
                }
            }

            return SemVersion.Parse("1.0.0", SemVersionStyles.Strict);
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
