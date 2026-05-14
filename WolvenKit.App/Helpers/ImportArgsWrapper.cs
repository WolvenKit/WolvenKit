using WolvenKit.Common.Model.Arguments;

namespace WolvenKit.App.Helpers;

/// <summary>
/// Wrapper for use with Syncfusions property grid
/// </summary>
public class ImportArgsWrapper
{
    public CommonImportArgs? Common { get; set; }
    public XbmImportArgs? Xbm { get; set; }
    public GltfImportArgs? Gltf { get; set; }
    public OpusImportArgs? Opus { get; set; }
    public MlmaskImportArgs? Mlmask { get; set; }
    public ReImportArgs? Re { get; set; }
    public FntImportArgs? Fnt { get; set; }

    public static ImportArgsWrapper From(GlobalImportArgs args) => new()
    {
        Common  = args.Get<CommonImportArgs>(),
        Xbm     = args.Get<XbmImportArgs>(),
        Gltf    = args.Get<GltfImportArgs>(),
        Opus    = args.Get<OpusImportArgs>(),
        Mlmask  = args.Get<MlmaskImportArgs>(),
        Re      = args.Get<ReImportArgs>(),
        Fnt     = args.Get<FntImportArgs>(),
    };
}
