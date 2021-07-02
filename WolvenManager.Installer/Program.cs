using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading;

namespace WolvenManager.Installer
{
    internal static class Program
    {
        private static int Main(string[] args)
        {
            var rootCommand = new RootCommand
            {
                new CreateCommand(),
                new ManifestCommand()

            };
            return rootCommand.InvokeAsync(args).Result;
        }
    }

    public class CreateCommand : Command
    {

        private new const string Description = "Create publish file from an assemby.";

        private new const string Name = "create";



        public CreateCommand() : base(Name, Description)
        {
            AddOption(new Option<FileInfo>(new[] {"--assembly", "-a"}, "Input Assembly.") {IsRequired = true});

            AddOption(new Option<DirectoryInfo>(new[] {"--outpath", "-o"}, "Output path."));

            AddOption(new Option<string>(new[] { "--version", "-v" }, "Version number."));

            Handler = CommandHandler.Create<FileInfo, DirectoryInfo, string>(Action);
        }

        private void Action(FileInfo assembly, DirectoryInfo outpath, string version)
        {
            Console.WriteLine($"Starting ...");

            if (assembly is not { Exists: true })
            {
                throw new FileNotFoundException(assembly.FullName);
            }

            var finalOutdir = System.Environment.CurrentDirectory;
            if (outpath != null)
            {
                Directory.CreateDirectory(outpath.FullName);
                if (!outpath.Exists)
                {
                    throw new DirectoryNotFoundException(outpath.FullName);
                }
                finalOutdir = outpath.FullName;
            }

            // get assemblyversion
            var fvi = FileVersionInfo.GetVersionInfo(assembly.FullName);
            var assemblyversion = fvi.FileVersion;
            var manifestversion = new Version(assemblyversion ?? throw new InvalidOperationException());

            // get version
            if (!string.IsNullOrEmpty(version))
            {
                try
                {
                    manifestversion = new Version(version);
                }
                catch (Exception)
                {
                    throw new VersionNotFoundException(version);
                }
            }
            Console.WriteLine($"Assembly data found: {fvi.ProductName}-{manifestversion}");

            // zip assembly folder
            if (assembly.Directory == null)
            {
                throw new DirectoryNotFoundException(assembly.FullName);
            }

            var portableZip = new FileInfo(Path.Combine(finalOutdir, $"{fvi.ProductName}-{manifestversion}.zip"));
            try
            {
                if (portableZip.Exists)
                {
                    portableZip.Delete();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            void CreatZip()
            {
                Console.WriteLine($"Zipping source {assembly.Directory.FullName} into target {portableZip.FullName} ...");
                ZipFile.CreateFromDirectory(assembly.Directory.FullName, portableZip.FullName);
            }

            CreatZip();
        }
    }


    public class ManifestCommand : Command
    {
        #region Fields

        private new const string Description = "Create a manifest file from an assemby and optionally hash additional files.";
        private new const string Name = "manifest";

        #endregion Fields

        #region Constructors

        public ManifestCommand() : base(Name, Description)
        {
            AddOption(new Option<FileInfo>(new[] { "--assembly", "-a" }, "Input Assembly.")
            {
                IsRequired = true
            });

            AddOption(new Option<DirectoryInfo>(new[] { "--outpath", "-o" }, "Output path."));

            AddOption(new Option<DirectoryInfo>(new[] { "--installer", "-i" }, "Installer directory."));

            AddOption(new Option<string>(new[] { "--version", "-v" }, "Version number."));
            AddOption(new Option<FileInfo[]>(new[] { "--files", "-f" }, "Additional files to hash."));


            Handler = CommandHandler.Create<FileInfo, DirectoryInfo, DirectoryInfo, string, FileInfo[]> (Action);
        }

        private void Action(FileInfo assembly, DirectoryInfo installer, DirectoryInfo outpath, string version, FileInfo[] files)
        {
            Console.WriteLine($"Starting ...");

            if (assembly is not {Exists: true})
            {
                throw new FileNotFoundException(assembly.FullName);
            }

            var finalOutdir = System.Environment.CurrentDirectory;
            if (outpath != null)
            {
                Directory.CreateDirectory(outpath.FullName);
                if (!outpath.Exists)
                {
                    throw new DirectoryNotFoundException(outpath.FullName);
                }
                finalOutdir = outpath.FullName;
            }

            // get assemblyversion
            var fvi = FileVersionInfo.GetVersionInfo(assembly.FullName);
            var assemblyversion = fvi.FileVersion;
            var manifestversion = new Version(assemblyversion ?? throw new InvalidOperationException());

            // get version
            if (!string.IsNullOrEmpty(version))
            {
                try
                {
                    manifestversion = new Version(version);
                }
                catch (Exception)
                {
                    throw new VersionNotFoundException(version);
                }
            }
            Console.WriteLine($"Assembly data found: {fvi.ProductName}-{manifestversion}");

            // zip assembly folder
            if (assembly.Directory == null)
            {
                throw new DirectoryNotFoundException(assembly.FullName);
            }

            var manifest = new Manifest()
            {
                Version = manifestversion.ToString(),
                AssemblyName = fvi.ProductName

            };

            // SHA hashes
            //var fileHashes = new Dictionary<string, string>();
            using (var mySha256 = SHA256.Create())
            {
                // installer hash
                if (installer is {Exists: true})
                {
                    // create installer pattern name
                    //TODO auomate this properly
                    var installername = $"{fvi.ProductName}-installer-{manifestversion}.exe";
                    var installerPath = new FileInfo(Path.Combine(installer.FullName, installername));
                    if (!installerPath.Exists)
                    {
                        Console.WriteLine($"Could not find {installerPath.FullName} to hash.");
                    }

                    var installerHash = HashFile(installerPath, mySha256);
                    manifest.Installer = new KeyValuePair<string, string>(installerPath.Name, installerHash);
                }
                else
                {
                    Console.WriteLine($"Could not find installer to hash.");
                }

                // hash additional files
                //if (files != null)
                //{
                //    Console.WriteLine($"Found {files.Length} to hash.");
                //    foreach (var fInfo in files)
                //    {
                //        if (!fInfo.Exists)
                //        {
                //            Console.WriteLine($"Could not find {fInfo.FullName} to hash.");
                //            continue;
                //        }

                //        var hashStr = HashFile(fInfo, mySha256);
                //        var key = fInfo.Name;
                //        if (!fileHashes.ContainsKey(key))
                //        {
                //            fileHashes.Add(key, hashStr);
                //        }
                //    }
                //}

                // portable zip hash
                var portableZip = new FileInfo(Path.Combine(finalOutdir, $"{fvi.ProductName}-{manifestversion}.zip"));
                if (!portableZip.Exists)
                {
                    throw new FileNotFoundException(portableZip.Name);
                }
                var portableHash = HashFile(portableZip, mySha256);
                manifest.Portable = new KeyValuePair<string, string>(portableZip.Name, portableHash);
            }

            // write manifest
            Console.WriteLine($"Writing data to {finalOutdir} ...");
            

            var jsonString = JsonSerializer.Serialize(manifest, new JsonSerializerOptions()
            {
                WriteIndented = true
            });
            File.WriteAllText(Path.Combine(finalOutdir, "manifest.json"), jsonString);


            // Display a byte array in a readable format.
            static string PrettyByteArray(IReadOnlyList<byte> array)
            {
                return array.Aggregate("", (current, t) => current + $"{t:X2}");
            }

            static string HashFile(FileInfo fInfo, SHA256 mySha256)
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
        }

        #endregion Constructors
    }



}
