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
        #region Fields

        private new const string Description = "Some helper functions related to hashes.";
        private new const string Name = "hash";

        #endregion Fields

        #region Constructors

        public HashCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] { "--input", "-i" }, "Create FNV1A hash of a given string."));
            AddOption(new Option<DirectoryInfo>(new[] { "--missing", "-m" }, "List missing hashes."));

            Handler = CommandHandler.Create<string[], DirectoryInfo, IHost>(Action);
        }

        private void Action(string[] input, DirectoryInfo missing, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.HashTask(input, missing);
        }

        #endregion Constructors
    }
}
