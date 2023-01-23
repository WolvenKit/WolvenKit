using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Serilog;
using WolvenKit.Core.Services;

namespace WolvenKit.Helpers;

public static class ProcessUtil
{
    /// <summary>
    /// runs a process async and returns if completed successfully
    /// </summary>
    /// <param name="fileName"></param>
    /// <param name="arguments"></param>
    /// <returns>true if exit code is 0</returns>
    public static async Task<bool> RunProcessAsync(string fileName, string arguments, string? workingDir = null)
    {
        Process p;
        var eventHandled = new TaskCompletionSource<bool>();

        using (p = new Process())
        {
            try
            {
                p.StartInfo.FileName = fileName;
                p.StartInfo.Arguments = arguments;
                if (!string.IsNullOrEmpty(workingDir))
                {
                    p.StartInfo.WorkingDirectory = workingDir;
                }

                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;

                p.EnableRaisingEvents = true;

                p.OutputDataReceived += (s, e) =>
                {
                    if (e.Data is not null)
                    {
                        Log.Information(e.Data);
                    }
                };
                p.ErrorDataReceived += (s, e) =>
                {
                    if (e.Data is not null)
                    {
                        Log.Error(e.Data);
                    }
                };

                //p.Exited += new EventHandler(myProcess_Exited);
                p.Exited += (s, e) =>
                {
                    var exitCode = p.ExitCode;
                    Log.Information(
                        $"Exit time    : {p.ExitTime}\n" +
                        $"Exit code    : {exitCode}\n" +
                        $"Elapsed time : {Math.Round((p.ExitTime - p.StartTime).TotalMilliseconds)}");
                    eventHandled.TrySetResult(true);
                };

                p.Start();
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred:\n{ex.Message}");
                return false;
            }

            // Wait for Exited event, but not more than 30 seconds.
            await await Task.WhenAny(eventHandled.Task, Task.Delay(30000));
            return p.ExitCode == 0;
        }
    }

    /// <summary>
    /// runs a process async and returns if completed successfully
    /// </summary>
    /// <param name="fileName"></param>
    /// <param name="arguments"></param>
    /// <returns>true if exit code is 0</returns>
    public static async Task<bool> RunRedmodAsync(string fileName, string arguments, string workingDir = "", IProgressService<double>? progress = null)
    {
        Process p;
        var eventHandled = new TaskCompletionSource<bool>();

        using (p = new Process())
        {
            try
            {
                p.StartInfo.FileName = fileName;
                p.StartInfo.Arguments = arguments;
                if (!string.IsNullOrEmpty(workingDir))
                {
                    p.StartInfo.WorkingDirectory = workingDir;
                }

                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;

                p.EnableRaisingEvents = true;

                p.OutputDataReceived += (s, e) =>
                {
                    var str = e.Data;
                    if (progress is not null && str is not null && str.Contains("[DEPLOY] Stage "))
                    {
                        var stage = str["[DEPLOY] Stage ".Length].ToString();
                        if (double.TryParse(stage, out var stageInt))
                        {
                            progress.Report(stageInt / 5);
                        }
                    }
                    if (!string.IsNullOrEmpty(str))
                    {
                        Log.Information(str);
                    }
                };
                p.ErrorDataReceived += (s, e) =>
                {
                    if (e.Data is not null)
                    {
                        Log.Error(e.Data);
                    }
                };

                //p.Exited += new EventHandler(myProcess_Exited);
                p.Exited += (s, e) =>
                {
                    var exitCode = p.ExitCode;
                    Log.Information(
                        $"Exit time    : {p.ExitTime}\n" +
                        $"Exit code    : {exitCode}\n" +
                        $"Elapsed time : {Math.Round((p.ExitTime - p.StartTime).TotalMilliseconds)}");
                    eventHandled.TrySetResult(true);
                };

                p.Start();
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred:\n{ex.Message}");
                return false;
            }

            // Wait for Exited event, but not more than 30 seconds.
            await await Task.WhenAny(eventHandled.Task, Task.Delay(30000));
            return p.ExitCode == 0;
        }
    }
}
