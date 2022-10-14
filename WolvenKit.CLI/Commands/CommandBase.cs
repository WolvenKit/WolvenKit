using System.CommandLine;
using System.CommandLine.Hosting;
using System.CommandLine.Invocation;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using WolvenKit.CLI;
using WolvenKit.Core.Interfaces;

namespace CP77Tools.Commands;

internal abstract class CommandBase : Command
{
    private ICommandHandler _commandHandler;

    public CommandBase(string name, string description) : base(name, description) =>
        this.SetHandler(ActionBase);

    protected Task<int> ActionBase(InvocationContext context)
    {
        var host = context.GetHost();
        var logger = host.Services.GetRequiredService<ILoggerService>();

        var verbosityOptionValue = context.ParseResult.GetValueForOption(Program.VerbosityOption);
        logger.SetLoggerVerbosity(verbosityOptionValue);

        return Task.FromResult(_commandHandler.Invoke(context));
    }

    internal void SetInternalHandler(ICommandHandler commandHandler) => _commandHandler = commandHandler;
}
