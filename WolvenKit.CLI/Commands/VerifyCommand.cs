using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands
{
    public class VerifyCommand : Command
    {
        #region Fields

        private new const string Description = "Some helper functions related to CR2W files.";
        private new const string Name = "verify";

        #endregion Fields

        #region Constructors

        public VerifyCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] { "--path", "-p" }, "inpaths"));
            AddOption(new Option<ulong[]>(new[] { "--hashes", "-i" }, "inhashes"));

            Handler = CommandHandler.Create<string[], ulong[], IHost>(Action);
        }

        private void Action(string[] path, ulong[] hashes, IHost host)
        {
            var serviceProvider = host.Services;
            var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
            consoleFunctions.VerifyTask(path, hashes);
        }

        #endregion Constructors
    }
}
