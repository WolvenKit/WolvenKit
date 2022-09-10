using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Serilog;

namespace WolvenKit.Helpers;

public static class ProcessUtil
{
    /// <summary>
    /// runs a process async and returns if completed successfully
    /// </summary>
    /// <param name="fileName"></param>
    /// <param name="arguments"></param>
    /// <returns>true if exit code is 0</returns>
    public static async Task<bool> RunProcessAsync(string fileName, params string[] arguments)
    {
        Process p;
        var eventHandled = new TaskCompletionSource<bool>();

        using (p = new Process())
        {
            try
            {
                p.StartInfo.FileName = fileName;
                p.StartInfo.Arguments = string.Join(' ', arguments);

                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;

                p.EnableRaisingEvents = true;

                p.OutputDataReceived += (s, e) =>
                {
                    Log.Information(e.Data);
                };
                p.ErrorDataReceived += (s, e) =>
                {
                    Log.Error(e.Data);
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
