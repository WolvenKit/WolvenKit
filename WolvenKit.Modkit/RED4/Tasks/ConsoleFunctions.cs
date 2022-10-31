using Microsoft.Extensions.Options;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.CR2W;

namespace CP77Tools.Tasks;

public partial class ConsoleFunctions : IConsoleFunctions
{
    public const int ERROR_GENERAL_ERROR = 0x1;
    public const int ERROR_COMPLETED_WITH_WARNINGS = 0x2;
    public const int ERROR_COMPLETED_WITH_ERRORS = 0x3;
    public const int ERROR_BAD_ARGUMENTS = 0xA0;
    public const int ERROR_INVALID_COMMAND_LINE = 0x667;

    private readonly ILoggerService _loggerService;
    private readonly IModTools _modTools;
    private readonly IHashService _hashService;
    private readonly IProgressService<double> _progressService;
    private readonly Red4ParserService _wolvenkitFileService;
    private readonly IArchiveManager _archiveManager;

    private readonly IOptions<CommonImportArgs> _commonImportArgs;
    private readonly IOptions<XbmImportArgs> _xbmImportArgs;
    private readonly IOptions<GltfImportArgs> _gltfImportArgs;
    private readonly IOptions<XbmExportArgs> _xbmExportArgs;
    private readonly IOptions<MeshExportArgs> _meshExportArgs;
    private readonly IOptions<MorphTargetExportArgs> _morphTargetExportArgs;
    private readonly IOptions<MlmaskExportArgs> _mlmaskExportArgs;
    private readonly IOptions<WemExportArgs> _wemExportArgs;
    private readonly IOptions<AnimationExportArgs> _animationExportArgs;


    public ConsoleFunctions(
        ILoggerService loggerService,
        IHashService hashService,
        IProgressService<double> progress,
        Red4ParserService wolvenkitFileService,
        IModTools modTools,
        IArchiveManager archiveManager,

        IOptions<CommonImportArgs> commonImportArgs,
        IOptions<XbmImportArgs> xbmImportArgs,
        IOptions<GltfImportArgs> gltfImportArgs,
        IOptions<XbmExportArgs> xbmExportArgs,
        IOptions<MeshExportArgs> meshExportArgs,
        IOptions<MorphTargetExportArgs> morphTargetExportArgs,
        IOptions<MlmaskExportArgs> mlmaskExportArgs,
        IOptions<WemExportArgs> wemExportArgs,
        IOptions<AnimationExportArgs> animationExportArgs
    )
    {
        _loggerService = loggerService;
        _modTools = modTools;
        _progressService = progress;
        _hashService = hashService;
        _archiveManager = archiveManager;

        _commonImportArgs = commonImportArgs;
        _xbmImportArgs = xbmImportArgs;
        _gltfImportArgs = gltfImportArgs;
        _wolvenkitFileService = wolvenkitFileService;
        _xbmExportArgs = xbmExportArgs;
        _meshExportArgs = meshExportArgs;
        _morphTargetExportArgs = morphTargetExportArgs;
        _mlmaskExportArgs = mlmaskExportArgs;
        _wemExportArgs = wemExportArgs;
        _animationExportArgs = animationExportArgs;
    }


}
