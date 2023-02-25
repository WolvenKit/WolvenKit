using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools : IModTools
    {
        private readonly ILoggerService _loggerService;
        private readonly IProgressService<double> _progressService;
        private readonly IHashService _hashService;
        private readonly Red4ParserService _parserService;
        private readonly IArchiveManager _archiveManager;

        public ModTools(
            ILoggerService loggerService,
            IProgressService<double> progressService,
            IHashService hashService,
            Red4ParserService parserService,
            IArchiveManager archiveManager
        )
        {
            _loggerService = loggerService;
            _progressService = progressService;
            _hashService = hashService;
            _parserService = parserService;
            _archiveManager = archiveManager;
        }
    }
}
