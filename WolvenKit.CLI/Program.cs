using System;
using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Hosting;
using System.CommandLine.Parsing;
using CP77Tools.Commands;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Compression;

namespace WolvenKit.CLI
{
    internal class Program
    {

        [STAThread]
        public static void Main(string[] args)
        {
            if (!Oodle.Load())
            {
                Console.Error.WriteLine("Failed to load any oodle libraries. Aborting");
                return;
            }

            var rootCommand = new RootCommand
            {
                new ArchiveCommand(),

                new UnbundleCommand(),
                new UncookCommand(),
                new ImportCommand(),
                new PackCommand(),
                new ExportCommand(),

                new DumpCommand(),
                new CR2WCommand(),

                new HashCommand(),
                new OodleCommand(),

                new TweakCommand(),

                new SettingsCommand(),

                new WwiseCommand(),
            };

            var parser = new CommandLineBuilder(rootCommand)
                .UseDefaults()
                .UseHost(GenericHost.CreateHostBuilder)
                .Build();

            ImportExportArgs.IsCLI = true;

            parser.Invoke(args);
        }
    }
}
