// MIT License
//Copyright(c) 2018 LaughingLeader

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WolvenKit.Common.Services;

namespace WolvenKit.MVVM.Model
{
    public static class ProcessHelper
    {
        public static int RunCommandLine(string workingDirectory = "", params string[] commands) => RunProcess(Path.Combine(Environment.SystemDirectory, "cmd.exe"), workingDirectory, commands);

        public static async Task<int> RunCommandLineAsync(ILoggerService loggerService, string workingDirectory = "", params string[] commands) => await RunProcessAsync(loggerService,
                    Path.Combine(Environment.SystemDirectory, "cmd.exe"),
                    workingDirectory,
                    commands)
                .ConfigureAwait(false);

        public static int RunProcess(string filePath, string workingDirectory = "", params string[] commands)
        {
            using var process = new Process
            {
                EnableRaisingEvents = true,
                StartInfo =
                {
                    FileName = filePath,
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    WorkingDirectory = workingDirectory
                }
            };
            return RunProcess(process, commands);
        }

        /// <summary>
        /// Waits asynchronously for the process to exit.
        /// </summary>
        /// <param name="process">The process to wait for cancellation.</param>
        /// <param name="cancellationToken">A cancellation token. If invoked, the task will return
        /// immediately as canceled.</param>
        /// <returns>A Task representing waiting for the process to end.</returns>
        public static Task WaitForExitAsync(this Process process, CancellationToken cancellationToken = default(CancellationToken))
        {
            var tcs = new TaskCompletionSource<object>();
            process.EnableRaisingEvents = true;
            process.Exited += (sender, args) => tcs.TrySetResult(null);
            if (cancellationToken != default(CancellationToken))
            {
                cancellationToken.Register(tcs.SetCanceled);
            }

            return tcs.Task;
        }

        private static int RunProcess(Process process, params string[] commands)
        {
            var started = process.Start();
            if (!started)
            {
                //you may allow for the process to be re-used (started = false)
                //but I'm not sure about the guarantees of the Exited event in such a case
                throw new InvalidOperationException("Could not start process: " + process);
            }
            else
            {
                if (commands != null && commands.Length > 0)
                {
                    var stream = process.StandardInput;

                    for (var i = 0; i < commands.Length; i++)
                    {
                        stream.WriteLine(commands[i]);
                    }

                    stream.Close();
                }

                var fiveMinutes = new TimeSpan(0, 5, 0);
                process.WaitForExit(fiveMinutes.Milliseconds);
                return process.ExitCode;
            }
        }

        private static async Task<int> RunProcessAsync(ILoggerService loggerService, Process process, params string[] commands)
        {
            var result = -1;
            //process.OutputDataReceived += (s, ea) => Console.WriteLine(ea.Data);
            //process.ErrorDataReceived += (s, ea) => Console.WriteLine("ERR: " + ea.Data);
            var errorLog = new List<string>();
            process.ErrorDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    errorLog.Add(e.Data);
                    loggerService.Error($"ERR: {e.Data}");
                }
            };
            //process.OutputDataReceived += (sender, e) =>
            //    { loggerService.LogString($"O: {e.Data}", Logtype.Normal); };

            var started = process.Start();
            if (!started)
            {
                //you may allow for the process to be re-used (started = false)
                //but I'm not sure about the guarantees of the Exited event in such a case
                throw new InvalidOperationException("Could not start process: " + process);
            }
            else
            {
                process.BeginErrorReadLine();
                //process.BeginOutputReadLine();

                if (commands != null && commands.Length > 0)
                {
                    var stream = process.StandardInput;

                    for (var i = 0; i < commands.Length; i++)
                    {
                        stream.WriteLine(commands[i]);

                        await Task.Delay(10).ConfigureAwait(false);
                    }

                    stream.Close();
                }

                process.WaitForExit();
                result = process.ExitCode;
                if (errorLog.Any())
                {
                    result = 1;
                }
                //loggerService.LogString($"Process exited with code {result}", Logtype.Important);
                //await process.WaitForExitAsync();
            }

            //process.BeginOutputReadLine();
            //process.BeginErrorReadLine();

            return result;
        }

        private static Task<int> RunProcessAsync(ILoggerService loggerService, string filePath, string workingDirectory = "", params string[] commands)
        {
            using var process = new Process
            {
                EnableRaisingEvents = true,
                StartInfo =
                {
                    FileName = filePath,
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    WorkingDirectory = workingDirectory,
                    RedirectStandardError = true,
					//RedirectStandardOutput = true
		}
            };
            return RunProcessAsync(loggerService, process, commands);
        }
    }
}
