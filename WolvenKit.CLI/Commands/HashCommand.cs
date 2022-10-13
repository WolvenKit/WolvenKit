using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.IO;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands;

internal class HashCommand : CommandBase
{
    private const string s_description = "Some helper functions related to hashes.";
    private const string s_name = "hash";

    public HashCommand() : base(s_name, s_description)
    {
        AddArgument(new Argument<string[]>("input", "Create FNV1A hash for given strings."));

        SetInternalHandler(CommandHandler.Create<string[], IHost>(Action));
    }

    private int Action(string[] input, IHost host)
    {
        var serviceProvider = host.Services;
        var consoleFunctions = serviceProvider.GetRequiredService<ConsoleFunctions>();
        return consoleFunctions.HashTask(input);
    }
}
