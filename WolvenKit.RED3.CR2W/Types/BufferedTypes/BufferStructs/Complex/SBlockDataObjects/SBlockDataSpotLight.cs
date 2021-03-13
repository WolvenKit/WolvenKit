using System.Collections.Generic;
using System.IO;

using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    class SBlockDataSpotLight : CVariable
    {
        [Ordinal(0)] [RED] public CUInt32 color { get; set; } //TODO: Check why this works an CColor doesn't?
        [Ordinal(1)] [RED] public CFloat radius { get; set; }
        [Ordinal(2)] [RED] public CFloat brightness { get; set; }
        [Ordinal(3)] [RED] public CFloat attenuation { get; set; }
        [Ordinal(4)] [RED] public CFloat autoHideRange { get; set; }
        [Ordinal(5)] [RED] public CFloat shadowFadeDistance { get; set; }
        [Ordinal(6)] [RED] public CFloat shadowFadeRange { get; set; }
        [Ordinal(7)] [RED] public CFloat shadowFadeBlendFactor { get; set; }
        [Ordinal(8)] [RED] public SVector3D lightFlickering { get; set; }
        [Ordinal(9)] [RED] public CUInt8 shadowCastingMode { get; set; }
        [Ordinal(10)] [RED] public CUInt8 dynamicShadowsFaceMask { get; set; }
        [Ordinal(11)] [RED] public CUInt8 envColorGroup { get; set; }
        [Ordinal(12)] [RED] public CUInt8 padding { get; set; }
        [Ordinal(13)] [RED] public CUInt32 lightUsageMask { get; set; }
        [Ordinal(14)] [RED] public CFloat innerAngle { get; set; }
        [Ordinal(15)] [RED] public CFloat outerAngle { get; set; }
        [Ordinal(16)] [RED] public CFloat softness { get; set; }
        [Ordinal(17)] [RED] public CFloat projectionTextureAngle { get; set; }
        [Ordinal(18)] [RED] public CFloat projectionTexureUBias { get; set; }
        [Ordinal(19)] [RED] public CFloat projectionTexureVBias { get; set; }
        [Ordinal(19)] [RED] public CUInt16 projectionTexture { get; set; }
        [Ordinal(19)] [RED] public CUInt16 padding2 { get; set; }

        public SBlockDataSpotLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
