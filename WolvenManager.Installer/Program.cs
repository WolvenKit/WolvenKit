using System.CommandLine;
using WolvenManager.Installer.Commands;

namespace WolvenManager.Installer
{
    internal static class Program
    {
        private static int Main(string[] args)
        {
            var rootCommand = new RootCommand
            {
                new CreateCommand(),
                new ManifestCommand(),
                new InstallCommand(),

            };
            return rootCommand.InvokeAsync(args).Result;
        }
    }

    


    



}
