using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP77.CR2W;
using WolvenKit.Common.Services;
using WolvenKit.RED4.CR2W;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        private readonly ILoggerService _loggerService;
        private readonly ModTools _modTools;
        private readonly IHashService _hashService;
        private readonly IProgress<double> _progressService;
        private readonly Red4ParserService _wolvenkitFileService;







        public ConsoleFunctions(
            ILoggerService loggerService,
            IHashService hashService,
            IProgress<double> progress,
            Red4ParserService wolvenkitFileService,
            ModTools modTools
            )
        {
            _loggerService = loggerService;
            _modTools = modTools;
            _progressService = progress;
            _hashService = hashService;
            _wolvenkitFileService = wolvenkitFileService;
        }


    }
}
