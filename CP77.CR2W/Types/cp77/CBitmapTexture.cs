using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;
using WolvenKit.Common.Model;

namespace WolvenKit.CR2W.Types
{
    [REDMeta]
    public class CBitmapTexture : CVariable
    {
        [Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
        [Ordinal(1)] [RED("width")] public CUInt32 Width { get; set; }
        [Ordinal(2)] [RED("height")] public CUInt32 Height { get; set; }
        [Ordinal(3)] [RED("setup")] public STextureGroupSetup Setup { get; set; }
        [Ordinal(4)] [RED("renderTextureResource")] public rendRenderTextureResource RenderTextureResource { get; set; }
        public CBitmapTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
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