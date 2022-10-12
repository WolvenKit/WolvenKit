using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Threading.Tasks;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.Core.Interfaces;

namespace CP77Tools.Commands
{
    public class ConflictsCommand : Command
    {
        private new const string Description = "Lists all mod conflicts in your mods.";
        private new const string Name = "conflicts";

        public ConflictsCommand() : base(Name, Description)
        {
            AddArgument(new Argument<DirectoryInfo>("path", () => null, "Path to your Cyberpunk 2077 game folder (if left empty it will use the current working directory)."));

            AddOption(new Option<bool>(new[] { "--structured", "-s" }, "Print structured output (json)."));

            Handler = CommandHandler.Create<DirectoryInfo, bool, IHost>(Action);
        }

        private void Action(DirectoryInfo path, bool structured, IHost host)
        {
            var serviceProvider = host.Services;
            var logger = serviceProvider.GetRequiredService<ILoggerService>();

            if (!path.Exists)
            {
                logger.Error("Incorrect input path: Directory does not exist");
                return;
            }

            // check if game dir
            if (!path.Name.Equals("Cyberpunk 2077"))
            {
                logger.Error("Incorrect input path: Not game folder");
                return;
            }
            var gameExe = new FileInfo(Path.Combine(path.FullName, "bin", "x64", "Cyberpunk2077.exe"));
            if (!gameExe.Exists)
            {
                logger.Error("Incorrect input path: Not game folder");
                return;
            }


            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.ConflictsTask(path, structured);
        }
    }
}
