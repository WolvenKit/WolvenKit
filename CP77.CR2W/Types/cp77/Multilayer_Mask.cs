using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;
using WolvenKit.Common.Model;

namespace WolvenKit.CR2W.Types
{
    [REDMeta]
    public class Multilayer_Mask : CVariable
    {
        [Ordinal(1000)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
        [Ordinal(1001)] [RED("renderResourceBlob")] public rendRenderMultilayerMaskResource RenderResourceBlob { get; set; }

        public Multilayer_Mask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class rendRenderMultilayerMaskResource : CVariable
    {
        [Ordinal(1)] [RED("renderResourceBlobPC")] public CHandle<IRenderResourceBlob> RenderResourceBlobPC { get; set; }

        public rendRenderMultilayerMaskResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class rendRenderMultilayerMaskBlobPC : IRenderResourceBlob
    {
        [Ordinal(1)] [RED("header")] public rendRenderMultilayerMaskBlobHeader Header { get; set; }
        [Ordinal(2)] [RED("atlasData")] public serializationDeferredDataBuffer AtlasData { get; set; }
        [Ordinal(3)] [RED("tilesData")] public serializationDeferredDataBuffer TilesData { get; set; }

        public rendRenderMultilayerMaskBlobPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class rendRenderMultilayerMaskBlobHeader : CVariable
    {
        [Ordinal(1)] [RED("version")] public CUInt32 Version { get; set; }
        [Ordinal(2)] [RED("atlasWidth")] public CUInt32 AtlasWidth { get; set; }
        [Ordinal(3)] [RED("atlasHeight")] public CUInt32 AtlasHeight { get; set; }
        [Ordinal(4)] [RED("numLayers")] public CUInt32 NumLayers { get; set; }
        [Ordinal(5)] [RED("maskWidth")] public CUInt32 MaskWidth { get; set; }
        [Ordinal(6)] [RED("maskHeight")] public CUInt32 MaskHeight { get; set; }
        [Ordinal(7)] [RED("maskWidthLow")] public CUInt32 MaskWidthLow { get; set; }
        [Ordinal(8)] [RED("maskHeightLow")] public CUInt32 MaskHeightLow { get; set; }
        [Ordinal(9)] [RED("maskTileSize")] public CUInt32 MaskTileSize { get; set; }
        [Ordinal(10)] [RED("flags")] public CUInt32 Flags { get; set; }

        public rendRenderMultilayerMaskBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}