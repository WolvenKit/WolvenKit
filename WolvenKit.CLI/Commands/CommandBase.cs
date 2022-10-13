using System.CommandLine;
using System.CommandLine.Hosting;
using System.CommandLine.Invocation;
using System.Threading.Tasks;
using Microsoft.Build.Framework;
using Microsoft.Extensions.DependencyInjection;
using WolvenKit.Core.Interfaces;

namespace CP77Tools.Commands;

internal abstract class CommandBase : Command
{
    private ICommandHandler _commandHandler;

    public Option<LoggerVerbosity> VerbosityOption = new(new[] { "--verbosity", "-v" }, () => LoggerVerbosity.Normal, "Sets the verbosity level of the command");

    public CommandBase(string name, string description) : base(name, description)
    {
        AddOption(VerbosityOption);

        this.SetHandler(ActionBase);
    }

    protected Task<int> ActionBase(InvocationContext context)
    {
        var host = context.GetHost();
        var logger = host.Services.GetRequiredService<ILoggerService>();

        var verbosityOptionValue = context.ParseResult.GetValueForOption(VerbosityOption);
        logger.SetLoggerVerbosity(verbosityOptionValue);

        return Task.FromResult(_commandHandler.Invoke(context));
    }

    internal void SetInternalHandler(ICommandHandler commandHandler) => _commandHandler = commandHandler;
}
