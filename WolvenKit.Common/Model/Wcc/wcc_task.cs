using System;
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
    /// Closed-source program published by CDPR in the official Witcher 3 modkit.
    /// Provides a wide range of utilities, mainly cooking/uncooking,
    /// but can also monitor in-game performance...
    /// </summary>
    public class WccLite
    {
        private ILoggerService _logger { get; set; }
        private string _wccPath;

        public WccLite(string path, ILoggerService loggerService)
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
        private int RunCommand(string cmdName, string args)
        {
            string wccPath = _wccPath;
            EWccStatus status = EWccStatus.NotRun;
            using (Process process = new Process())
            {
                try
                {
                    _logger.LogString($"-----------------------------------------------------", Logtype.Important);
                    _logger.LogString($"WCC_TASK: {args}", Logtype.Important);

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
                                if (_logger.ErrorLog.Any(x => x.Flag == WccLogFlag.WLF_Error) && 
                                    _logger.ErrorLog.Any(x => x.Value.Contains("WCC operation failed.")))
                                {
                                    _logger.LogString("Did not complete.\r\n", Logtype.Error);
                                    status = EWccStatus.NotRun;
                                }
                                else if (_logger.ErrorLog.Any(x => x.Flag == WccLogFlag.WLF_Error))
                                {
                                    _logger.LogString("Finished with errors.\r\n", Logtype.Error);
                                    status = EWccStatus.Error;
                                }
                                else if (_logger.ErrorLog.Any(x => x.Flag == WccLogFlag.WLF_Warning))
                                {
                                    _logger.LogString("Finished with warnings.\r\n", Logtype.Important);
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
                    if (status != EWccStatus.NotRun)
                        return 1;
                    else
                        return 0;

                }
                catch (Exception ex)
                {
                    _logger.LogString(ex.ToString(), Logtype.Error);
                    throw;
                }
            }
        }

        public void UpdatePath(string wccLite) => _wccPath = wccLite;
    }
}
