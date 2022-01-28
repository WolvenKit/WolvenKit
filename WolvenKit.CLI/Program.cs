using System;
using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Hosting;
using System.CommandLine.Parsing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CP77Tools.Commands;
using WolvenKit.Common.Tools.Oodle;

namespace WolvenKit.CLI
{
    internal class Program
    {

        [STAThread]
        public static void Main(string[] args)
        {
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
            };

            var parser = new CommandLineBuilder(rootCommand)
                .UseDefaults()
                .UseHost(GenericHost.CreateHostBuilder)
                .Build();

            parser.Invoke(args);
        }

        private delegate void StrDelegate(string value);
    }
}
