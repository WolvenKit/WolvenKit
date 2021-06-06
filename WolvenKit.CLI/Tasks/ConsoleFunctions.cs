using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP77.CR2W;
using WolvenKit.Common.Services;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        private readonly ILoggerService _loggerService;
        private readonly ModTools _modTools;
        private readonly IHashService _hashService;
        private readonly IProgress<double> _progressService;








        public ConsoleFunctions(
            ILoggerService loggerService,
            IHashService hashService,
            IProgress<double> progress,
            ModTools modTools
            )
        {
            _loggerService = loggerService;
            _modTools = modTools;
            _progressService = progress;
            _hashService = hashService;

        }


    }
}
