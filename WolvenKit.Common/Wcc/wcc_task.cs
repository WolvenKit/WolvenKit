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
        public async Task<int> RunCommand(WCC_Command cmd)
        {
            _logger.Clear();
            string args = cmd.Arguments;
            return await Task.Run(() => RunCommand(cmd.Name, args));
        }

        /// <summary>
        /// Runs wcc_lite with specified arguments
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<int> RunCommand(string cmdName, string args)
        {
            string wccPath = _wccPath;
            EWccStatus status = EWccStatus.NotRun;
            using (Process process = new Process())
            {
                try
                {
                    _logger.LogString($"-----------------------------------------------------", Logtype.Wcc);
                    _logger.LogString($"WCC_TASK: {args}", Logtype.Wcc);

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
                                if (_logger.ErrorLog.Any(x => x.Flag == WccLogFlag.WLF_Error))
                                {
                                    _logger.LogString("Finished with Errors.\r\n", Logtype.Error);
                                    status = EWccStatus.Error;
                                }
                                else if (_logger.ErrorLog.Any(x => x.Flag == WccLogFlag.WLF_Warning))
                                {
                                    _logger.LogString("Finished with Warnings.\r\n", Logtype.Important);
                                    status = EWccStatus.Finished;
                                }
                                else
                                {
                                    _logger.LogString("Finished succesfully.\r\n", Logtype.Success);
                                    status = EWccStatus.Finished;
                                }
                            }
                            else
                            {
                                _logger.LogExtended(SystemLogFlag.SLF_Interpretable, ToolLogFlag.TLF_Wcc, cmdName, $"{e.Data}");
                                
                                Logtype wkitflag = Logtype.Wcc;
                                if (_logger.ErrorLog.Count > 0)
                                {
                                    var flag = _logger.ErrorLog.Last().Flag;
                                    switch (flag)
                                    {
                                        case WccLogFlag.WLF_Error: wkitflag = Logtype.Error;
                                            break;
                                        case WccLogFlag.WLF_Warning: wkitflag = Logtype.Important;
                                            break;
                                        case WccLogFlag.WLF_Default: 
                                        case WccLogFlag.WLF_Info:
                                        default:
                                            break;
                                    }
                                }
                                
                                _logger.LogString(e.Data, wkitflag);
                            }
                        };

                        process.Start();
                        process.BeginOutputReadLine();
                        process.WaitForExit();
                    }
                    if (status == EWccStatus.Finished)
                        return 1;
                    else
                        return 0;
                    
                }
                catch (Exception ex)
                {
                    _logger.LogString(ex.ToString(), Logtype.Error);
                    throw ex;

                }
            }
        }
    }
}
