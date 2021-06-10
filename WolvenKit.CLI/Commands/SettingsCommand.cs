using System.CommandLine;
using System.CommandLine.Invocation;
using System.Diagnostics;
using CP77Tools.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands
{
    public class SettingsCommand : Command
    {
        #region Fields

        private new const string Description = "App settings";
        private new const string Name = "settings";

        #endregion Fields

        #region Constructors

        public SettingsCommand() : base(Name, Description)
        {
            Handler = CommandHandler.Create<IHost>(Action);
        }

        private void Action(IHost host) =>
            new Process
            {
                StartInfo = new ProcessStartInfo(@"appsettings.json")
                {
                    UseShellExecute = true
                }
            }.Start();

        #endregion Constructors
    }
}
