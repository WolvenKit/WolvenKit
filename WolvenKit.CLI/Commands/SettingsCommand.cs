using System;
using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Hosting;

namespace CP77Tools.Commands;

internal class SettingsCommand : CommandBase
{
    private const string s_description = "App settings";
    private const string s_name = "settings";

    public SettingsCommand() : base(s_name, s_description) => SetInternalHandler(CommandHandler.Create<IHost>(Action));

    private void Action(IHost host)
    {
        var basedir = AppDomain.CurrentDomain.BaseDirectory;
        var settingsPath = Path.Combine(basedir, "appsettings.json");
        Console.WriteLine($"Opening {settingsPath}");
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
            new Process
            {
                StartInfo = new ProcessStartInfo(settingsPath)
                {
                    UseShellExecute = true
                }
            }.Start();
        } else {
            var editorCommand = System.Environment.GetEnvironmentVariable("EDITOR");
            ProcessStartInfo psInfo;
            if (editorCommand == null) {
                Console.WriteLine("$EDITOR not set, please set it if you would like to open the settings in a CLI text editor.");
                psInfo = new ProcessStartInfo(settingsPath)
                {
                    UseShellExecute = false,
                };
            } else {
                psInfo = new ProcessStartInfo(settingsPath)
                {
                    UseShellExecute = false,
                    FileName = editorCommand,
                    Arguments = $"\"{settingsPath}\"",
                    CreateNoWindow = true,
                };
            }
            var proc = new Process
            {
                StartInfo = psInfo
            };
            proc.Start();
            proc.WaitForExit();
        }
    }
}
