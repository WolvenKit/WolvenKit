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
            Console.CancelKeyPress += new ConsoleCancelEventHandler(CancelHandler);

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
                new ExportCommand(),
                new PackCommand(),

                new ConvertCommand(),
                new ConflictsCommand(),

                new HashCommand(),
                new OodleCommand(),

                new SettingsCommand(),

                new WwiseCommand(),
            };

#pragma warning disable CS0618 // Type or member is obsolete
            rootCommand.AddCommand(new CR2WCommand());
#pragma warning restore CS0618 // Type or member is obsolete

            var parser = new CommandLineBuilder(rootCommand)
                .UseDefaults()
                .UseHost(GenericHost.CreateHostBuilder)
                .Build();

            ImportExportArgs.IsCLI = true;

            parser.Invoke(args);
        }

        protected static void CancelHandler(object sender, ConsoleCancelEventArgs args) => Environment.FailFast("Ctrl-C was triggered");
    }
}
