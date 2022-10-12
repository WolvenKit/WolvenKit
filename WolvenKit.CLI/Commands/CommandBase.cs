using System.CommandLine;
using System.CommandLine.Hosting;
using System.CommandLine.Invocation;
using Microsoft.Build.Framework;
using Microsoft.Extensions.DependencyInjection;
using WolvenKit.Core.Interfaces;

namespace CP77Tools.Commands;

internal abstract class CommandBase : Command
{
    private ICommandHandler _commandHandler;

    private readonly Option<LoggerVerbosity> _verbosityOption = new(new[] { "--verbosity", "-v" }, () => LoggerVerbosity.Normal, "Sets the verbosity level of the command");

    public CommandBase(string name, string description) : base(name, description) => this.SetHandler(ActionBase);

    protected void ActionBase(InvocationContext context)
    {
        var host = context.GetHost();
        var logger = host.Services.GetRequiredService<ILoggerService>();

        var verbosityOptionValue = context.ParseResult.GetValueForOption(_verbosityOption);
        logger.SetLoggerVerbosity(verbosityOptionValue);

        _commandHandler?.Invoke(context);
    }

    internal void SetHandler(ICommandHandler commandHandler) => _commandHandler = commandHandler;
}
