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
        public WFR RunCommand(WCC_Command cmd)
        {
            string args = cmd.Arguments;
            return RunCommand(cmd.Name, args);
        }

        /// <summary>
        /// Runs wcc_lite with specified arguments
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public WFR RunCommand(string cmdName, string args)
        {
            //string wccPath = Config.GetConfigSetting("WCC_Path");
            string wccPath = _wccPath;
            var proc = new ProcessStartInfo(wccPath) { WorkingDirectory = Path.GetDirectoryName(wccPath) };

            try
            {
                _logger.LogString($"-----------------------------------------------------");
                _logger.LogString($"WCC_TASK: {args}");

                proc.Arguments = args;
                proc.UseShellExecute = false;
                proc.RedirectStandardOutput = true;
                proc.WindowStyle = ProcessWindowStyle.Hidden;
                proc.CreateNoWindow = true;

                using (var process = Process.Start(proc))
                {
                    using (var reader = process.StandardOutput)
                    {
                        while (true)
                        {
                            string result = reader.ReadLine();

                            _logger.LogString(result);
                            _logger.LogExtended(SystemLogFlag.SLF_Interpretable, ToolFlag.TLF_Wcc, cmdName, $"{result}");

                            if (reader.EndOfStream)
                                break;
                        }
                    }
                }

                //Handle Errors
                if (_logger.ExtendedLog.Any(x => x.Flag == LogFlag.WLF_Error))
                {
                    _logger.LogString("Finished with Errors.");
                    return WFR.WFR_Error;
                }
                else if (_logger.ExtendedLog.Any(x => x.Flag == LogFlag.WLF_Error))
                {
                    _logger.LogString("Finished with Warnings.");
                    return WFR.WFR_Finished;
                }
                else
                {
                    _logger.LogString("Finished without Errors or Warnings.");
                    return WFR.WFR_Finished;
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
