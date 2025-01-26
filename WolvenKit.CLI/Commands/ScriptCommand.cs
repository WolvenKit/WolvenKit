using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.Scripting;
using WolvenKit.RED4.CR2W;

namespace CP77Tools.Commands;

internal class ScriptCommand : CommandBase
{
    private const string s_description = "Runs given WScript script.";
    private const string s_name = "script";

    public ScriptCommand() : base(s_name, s_description)
    {
        AddArgument(new Argument<string>("path", "Path to the script to run."));

        SetInternalHandler(CommandHandler.Create<string, IHost>(Action));
    }

    private async Task<int> Action(string path, IHost host)
    {
        var serviceProvider = host.Services;
        var scriptService = serviceProvider.GetRequiredService<ScriptService>();
        var code = await File.ReadAllTextAsync(path);

        var functions = new ScriptFunctions(
            serviceProvider.GetRequiredService<ILoggerService>(),
            serviceProvider.GetRequiredService<IArchiveManager>(),
            serviceProvider.GetRequiredService<Red4ParserService>()
        );

        await scriptService.ExecuteAsync(code, new() { { "wkit", functions } });
        return 0;
    }
}
