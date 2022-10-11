using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands
{
    public class SettingsCommand : Command
    {
        private new const string Description = "App settings";
        private new const string Name = "settings";

        public SettingsCommand() : base(Name, Description) => Handler = CommandHandler.Create<IHost>(Action);

        private void Action(IHost host)
        {
            var basedir = AppDomain.CurrentDomain.BaseDirectory;
            var settingsPath = Path.Combine(basedir, "appsettings.json");
            Console.WriteLine($"Opening {settingsPath}");
            new Process
            {
                StartInfo = new ProcessStartInfo(settingsPath)
                {
                    UseShellExecute = true
                }
            }.Start();
        }
    }
}
