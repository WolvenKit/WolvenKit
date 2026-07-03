using WolvenKit.Common.Model.Arguments;

namespace WolvenKit.App.Helpers;

/// <summary>
/// Wrapper for use with Syncfusions property grid
/// </summary>
public class ExportArgsWrapper
{
    public GeneralExportArgs? General { get; set; }
    public CommonExportArgs? Common { get; set; }
    public MorphTargetExportArgs? MorphTarget { get; set; }
    public MlmaskExportArgs? Mlmask { get; set; }
    public XbmExportArgs? Xbm { get; set; }
    public MeshExportArgs? Mesh { get; set; }
    public AnimationExportArgs? Animation { get; set; }
    public WemExportArgs? Wem { get; set; }
    public OpusExportArgs? Opus { get; set; }
    public EntityExportArgs? Entity { get; set; }
    public InkAtlasExportArgs? InkAtlas { get; set; }
    public FntExportArgs? Fnt { get; set; }

    public static ExportArgsWrapper From(GlobalExportArgs args) => new()
    {
        General    = args.Get<GeneralExportArgs>(),
        Common     = args.Get<CommonExportArgs>(),
        MorphTarget = args.Get<MorphTargetExportArgs>(),
        Mlmask     = args.Get<MlmaskExportArgs>(),
        Xbm        = args.Get<XbmExportArgs>(),
        Mesh       = args.Get<MeshExportArgs>(),
        Animation  = args.Get<AnimationExportArgs>(),
        Wem        = args.Get<WemExportArgs>(),
        Opus       = args.Get<OpusExportArgs>(),
        Entity     = args.Get<EntityExportArgs>(),
        InkAtlas   = args.Get<InkAtlasExportArgs>(),
        Fnt        = args.Get<FntExportArgs>(),
    };
}
