using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace WolvenKit.Common.Wcc
{
    using Services;
    using System.Text;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    public class WCC_Task
    {
        private ILoggerService _logger { get; set; }
        private readonly string _wccPath;

        public WCC_Task(string path, ILoggerService loggerService)
        {
            _wccPath = path;
            _logger = loggerService;
        }

        /// <summary>
        /// runs wcc_lite with specified command
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public async Task RunCommand(WCC_Command cmd)
        {
            string args = cmd.Arguments;
            await RunCommand(cmd.Name, args);
        }

        /// <summary>
        /// Runs wcc_lite with specified arguments
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task RunCommand(string cmdName, string args)
        {
            string wccPath = _wccPath;
            using (Process process = new Process())
            {
                try
                {
                    _logger.LogString($"-----------------------------------------------------");
                    _logger.LogString($"WCC_TASK: {args}");

                    process.StartInfo.FileName = wccPath;
                    process.StartInfo.WorkingDirectory = Path.GetDirectoryName(wccPath);
                    process.StartInfo.Arguments = args;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.CreateNoWindow = true;

                    using (AutoResetEvent outputWaitHandle = new AutoResetEvent(false))
                    {
                        process.OutputDataReceived += (sender, e) =>
                        {
                            if (e.Data == null)
                            {
                                outputWaitHandle.Close();
                                //Handle Errors
                                if (_logger.ExtendedLog.Any(x => x.Flag == LogFlag.WLF_Error))
                                {
                                    _logger.LogString("Finished with Errors.");
                                    //return EWccStatus.Error;
                                }
                                else if (_logger.ExtendedLog.Any(x => x.Flag == LogFlag.WLF_Error))
                                {
                                    _logger.LogString("Finished with Warnings.");
                                    //return EWccStatus.Finished;
                                }
                                else
                                {
                                    _logger.LogString("Finished succesfully.");
                                    //return EWccStatus.Finished;
                                }
                            }
                            else
                            {
                                _logger.LogString(e.Data);
                            }
                        };

                        process.Start();
                        process.BeginOutputReadLine();
                    }

                    
                }
                catch (Exception ex)
                {
                    _logger.LogString(ex.ToString());
                    throw ex;

                }
            }
        }
    }
}
