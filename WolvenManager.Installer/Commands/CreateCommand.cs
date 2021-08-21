using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenManager.Installer.Commands
{
    public class CreateCommand : Command
    {
        private new const string Description = "Create publish file from an assemby.";
        private new const string Name = "create";

        public CreateCommand() : base(Name, Description)
        {
            AddOption(new Option<FileInfo>(new[] { "--assembly", "-a" }, "Input Assembly.") { IsRequired = true });
            AddOption(new Option<DirectoryInfo>(new[] { "--outpath", "-o" }, "Output path."));
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
            var assemblyversion = fvi.ProductVersion;
            var manifestversion = assemblyversion ?? throw new InvalidOperationException();

            // get version
            if (!string.IsNullOrEmpty(version))
            {
                try
                {
                    manifestversion = version;
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
}
