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
using System.Threading;
using System.Threading.Tasks;

namespace WolvenManager.Installer.Commands
{
    public class InstallCommand : Command
    {
        private new const string Description = "Installs a zip to a given directory.";
        private new const string Name = "install";

        public InstallCommand() : base(Name, Description)
        {
            AddOption(new Option<FileInfo>(new[] { "--input", "-i" }, "Input file")
            {
                IsRequired = true
            });
            AddOption(new Option<DirectoryInfo>(new[] { "--outpath", "-o" }, "Output path"){
                IsRequired = true
            });
            AddOption(new Option<string>(new[] { "--restart", "-r" }, "restart exe with given name"));



            Handler = CommandHandler.Create<FileInfo, DirectoryInfo, string>(Action);
        }

        public static void Action(FileInfo input, DirectoryInfo outpath, string restart)
        {
            var isrestart = !string.IsNullOrEmpty(restart);
            if (!input.Exists)
            {
                throw new FileNotFoundException(input.FullName);
            }
            if (!outpath.Exists)
            {
                throw new DirectoryNotFoundException(outpath.FullName);
            }
            if (isrestart && !Path.GetExtension(restart).Equals(".exe"))
            {
                throw new FileNotFoundException(restart);
            }

            Thread.Sleep(2000);

            var pname = Path.GetFileNameWithoutExtension(restart);
            var p = Process.GetProcessesByName(pname).FirstOrDefault();
            if (p == null)
            {
                Console.WriteLine($"{pname} is null");
                Console.WriteLine($"Waiting...");

                Thread.Sleep(2000);
                try
                {
                    Console.WriteLine($"Try unzipping");
                    ZipFile.ExtractToDirectory(input.FullName, outpath.FullName, true);
                    Console.WriteLine($"{input.FullName} ----> {outpath.FullName}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            else
            {
                if (p.WaitForExit(5000))
                {
                    Console.WriteLine($"{pname} Has exited");

                    var p2 = Process.GetProcessesByName(pname).FirstOrDefault();
                    Console.WriteLine(p2 != null ? "???" : "Okay");

                    // unzip to directory
                    try
                    {
                        ZipFile.ExtractToDirectory(input.FullName, outpath.FullName, true);
                        Console.WriteLine($"{input.FullName} ----> {outpath.FullName}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }
                else
                {
                    Console.WriteLine("Timeout");
                }
            }
            // restart app
            if (isrestart)
            {
                Console.WriteLine("Restarting ...");
                Process.Start(restart);
            }
        }
    }
}
