using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Invocation;
using System.CommandLine.IO;
using System.CommandLine.Parsing;
using System.Globalization;
using System.IO;
using CP77Tools.Model;
using CP77Tools.Services;
using CsvHelper;
using WolvenKit.Common.Services;

namespace CP77Tools
{
    class Program
    {
        [STAThread]
        public static async Task Main(string[] args)
        {
            ServiceLocator.Default.RegisterType<ILoggerService, LoggerService>();
            ServiceLocator.Default.RegisterType<IMainController, MainController>();

            // get csv data
            Console.WriteLine("Loading Hashes...");
            Loadhashes(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/archivehashes.csv"));
            Console.WriteLine("Loaded Hashes 1...");
            Loadhashes(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/archivehashes2.csv"));
            Console.WriteLine("Loaded Hashes 2...");

            #region commands

            var rootCommand = new RootCommand();

            //archiveTask(string path, bool extract, bool dump)
            var archive = new Command("archive", "Target an archive to extract files or dump information.")
            {
                new Option<string>(new []{"--path", "-p"}, "Input path to .archive."),
                new Option<string>(new []{ "--outpath", "-o"}, "Output directory to extract files to."),
                new Option<bool>(new []{ "--extract", "-e"}, "Extract files from archive."),
                new Option<bool>(new []{ "--dump", "-d"}, "Dump archive information."),
                new Option<bool>(new []{ "--list", "-l"}, "List contents of archive."),
                new Option<bool>(new []{ "--uncook", "-u"}, "Uncooks textures from archive."),
            };
            rootCommand.Add(archive);
            archive.Handler = CommandHandler.Create<string, string, bool, bool, bool, bool>(ConsoleFunctions.ArchiveTask);

            //DumpTask(string path, bool all, bool strings, bool imports, bool buffers, bool chunks)
            var dump = new Command("dump", "Target an archive or a directory to dump archive information.")
            {
                new Option<string>(new []{"--path", "-p"}, "Input path to .archive or to a directory (runs over all archives in directory)."),
                new Option<bool>(new []{ "--imports", "-i"}, "Dump all imports (all filenames that are referenced by all files in the archive)."),
                new Option<bool>(new []{ "--missinghashes", "-m"}, "List all missing hashes of all input archives."),
            };
            rootCommand.Add(dump);
            dump.Handler = CommandHandler.Create<string, bool, bool>(ConsoleFunctions.DumpTask);

            //Cr2wTask(string path, bool all, bool strings, bool imports, bool buffers, bool chunks)
            var cr2w = new Command("cr2w", "Target a specific cr2w (extracted) file and dumps file information.")
            {
                new Option<string>(new []{"--path", "-p"}, "Input path to a cr2w file."),
                new Option<bool>(new []{ "--all", "-a"}, "Dump all information."),
                new Option<bool>(new []{ "--chunks", "-c"}, "Dump all class information of file."),
            };
            rootCommand.Add(cr2w);

            
            
            cr2w.Handler = CommandHandler.Create<string, bool, bool>(ConsoleFunctions.Cr2wTask);

            #endregion


            // Run
            if (args == null || args.Length == 0)
            {
                // write welcome message
                rootCommand.InvokeAsync("-h").Wait();

                while (true)
                {
                    string line = System.Console.ReadLine();
                    var parsed = CommandLineExtensions.ParseText(line, ' ', '"');
                    rootCommand.InvokeAsync(parsed.ToArray()).Wait();
                }

            }
            else
            {
                rootCommand.InvokeAsync(args).Wait();
            }
        }


        private static void Loadhashes(string path)
        {
            var _maincontroller = ServiceLocator.Default.ResolveType<IMainController>();

            using (var fr = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (var sr = new StreamReader(fr))
            using (var csv = new CsvReader(sr, CultureInfo.InvariantCulture))
            {
                var records1 = csv.GetRecords<HashObject>();
                var Hashdict = _maincontroller.Hashdict;

                foreach (var record in records1)
                {
                    ulong hash = ulong.Parse(record.Hash);
                    if (!Hashdict.ContainsKey(hash))
                        Hashdict.Add(hash, record.String);
                }
            }
        }


        
    }
}
