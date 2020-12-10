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
using WolvenKit.Common.Services;

namespace CP77Tools
{
    class Program
    {
        [STAThread]
        public static async Task Main(string[] args)
        {
            ServiceLocator.Default.RegisterType<ILoggerService, LoggerService>();


            #region commands

            var rootCommand = new RootCommand();

            //archiveTask(string path, bool extract, bool dump)
            var archive = new Command("archive")
            {
                new Option<string>(new []{"--path", "-p"}),
                new Option<bool>(new []{ "--extract", "-e"}),
                new Option<bool>(new []{ "--dump", "-d"}),
            };
            rootCommand.Add(archive);

            //DumpTask(string path, bool all, bool strings, bool imports, bool buffers, bool chunks)
            var dump = new Command("dump")
            {
                new Option<string>(new []{"--path", "-p"}),
                new Option<bool>(new []{ "--all", "-a"}),
                new Option<bool>(new []{ "--strings", "-s"}),
                new Option<bool>(new []{ "--imports", "-i"}),
                new Option<bool>(new []{ "--buffers", "-b"}),
                new Option<bool>(new []{ "--chunks", "-c"}),
            };
            rootCommand.Add(dump);

            //Cr2wTask(string path, bool all, bool strings, bool imports, bool buffers, bool chunks)
            var cr2w = new Command("cr2w")
            {
                new Option<string>(new []{"--path", "-p"}),
                new Option<bool>(new []{ "--all", "-a"}),
                new Option<bool>(new []{ "--strings", "-s"}),
                new Option<bool>(new []{ "--imports", "-i"}),
                new Option<bool>(new []{ "--buffers", "-b"}),
                new Option<bool>(new []{ "--chunks", "-c"}),
            };
            rootCommand.Add(cr2w);

            archive.Handler = CommandHandler.Create<string, bool, bool>(ConsoleFunctions.ArchiveTask);
            dump.Handler = CommandHandler.Create<string, bool, bool, bool, bool, bool>(ConsoleFunctions.DumpTask);
            cr2w.Handler = CommandHandler.Create<string, bool, bool, bool, bool, bool>(ConsoleFunctions.Cr2wTask);

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


        


        
    }
}
