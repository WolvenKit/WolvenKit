using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands
{
    public class HashCommand : Command
    {
        private new const string Description = "Some helper functions related to hashes.";
        private new const string Name = "hash";

        public HashCommand() : base(Name, Description)
        {
            AddArgument(new Argument<string[]>("input", "Create FNV1A hash for given strings."));

            Handler = CommandHandler.Create<string[], IHost>(Action);
        }

        private void Action(string[] input, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.HashTask(input);
        }
    }
}
