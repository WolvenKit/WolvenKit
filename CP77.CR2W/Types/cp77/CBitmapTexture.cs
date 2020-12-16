using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;
using WolvenKit.Common.Model;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public partial class CBitmapTexture : ITexture
    {
        [Ordinal(1)] [RED("width")] public CUInt32 Width { get; set; }

        [Ordinal(2)] [RED("height")] public CUInt32 Height { get; set; }

        [Ordinal(3)] [RED("format")] public CEnum<ETextureRawFormat> Format { get; set; }

        [Ordinal(4)] [RED("compression")] public CEnum<ETextureCompression> Compression { get; set; }

        [Ordinal(5)] [RED("sourceData")] public CHandle<CSourceTexture> SourceData { get; set; }

        [Ordinal(6)] [RED("textureGroup")] public CName TextureGroup { get; set; }

        [Ordinal(7)] [RED("pcDownscaleBias")] public CInt32 PcDownscaleBias { get; set; }

        [Ordinal(8)] [RED("xboneDownscaleBias")] public CInt32 XboneDownscaleBias { get; set; }

        [Ordinal(9)] [RED("ps4DownscaleBias")] public CInt32 Ps4DownscaleBias { get; set; }

        [Ordinal(10)] [RED("residentMipIndex")] public CUInt8 ResidentMipIndex { get; set; }

        [Ordinal(11)] [RED("textureCacheKey")] public CUInt32 TextureCacheKey { get; set; }

        //cp 77
        [Ordinal(1000)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
        [Ordinal(1001)] [RED("setup")] public STextureGroupSetup Setup { get; set; }
        [Ordinal(1002)] [RED("renderTextureResource")] public rendRenderTextureResource RenderTextureResource { get; set; }

        public CBitmapTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class rendRenderTextureResource : CVariable
    {
        [Ordinal(1)] [RED("renderResourceBlobPC")] public CHandle<IRenderResourceBlob> RenderResourceBlobPC { get; set; }

        public rendRenderTextureResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class IRenderResourceBlob : CVariable
    {
        public IRenderResourceBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class STextureGroupSetup : CVariable
    {
        [Ordinal(2)] [RED("group")] public CEnum<GpuWrapApieTextureGroup> Group { get; set; }
        [Ordinal(3)] [RED("rawFormat")] public CEnum<ETextureRawFormat> RawFormat { get; set; }
        [Ordinal(4)] [RED("compression")] public CEnum<ETextureCompression> Compression { get; set; }
        [Ordinal(5)] [RED("isGamma")] public CBool IsGamma { get; set; }

        public STextureGroupSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }


}