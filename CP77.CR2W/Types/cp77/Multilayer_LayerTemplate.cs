using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;
using WolvenKit.Common.Model;

namespace WolvenKit.CR2W.Types
{
    [REDMeta]
    public class Multilayer_LayerTemplate : CVariable
    {
        [Ordinal(1)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
        [Ordinal(2)] [RED("overrides")] public Multilayer_LayerTemplateOverrides Overrides { get; set; }
        [Ordinal(3)] [RED("colorTexture")] public rRef<CBitmapTexture> ColorTexture { get; set; }
        [Ordinal(4)] [RED("normalTexture")] public rRef<CBitmapTexture> NormalTexture { get; set; }
        [Ordinal(5)] [RED("roughnessTexture")] public rRef<CBitmapTexture> RoughnessTexture { get; set; }
        [Ordinal(6)] [RED("metalnessTexture")] public rRef<CBitmapTexture> MetalnessTexture { get; set; }
        [Ordinal(7)] [RED("tilingMultiplier")] public CFloat TilingMultiplier { get; set; }
        [Ordinal(8)] [RED("colorMaskLevelsIn", 2)] public CStatic<CFloat> ColorMaskLevelsIn { get; set; }
        [Ordinal(9)] [RED("colorMaskLevelsOut", 2)] public CStatic<CFloat> ColorMaskLevelsOut { get; set; }

        public Multilayer_LayerTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class Multilayer_LayerTemplateOverrides : CVariable
    {
        [Ordinal(1)] [RED("colorScale")] public CArray<Multilayer_LayerTemplateOverridesColor> ColorScale { get; set; }
        [Ordinal(2)] [RED("roughLevelsIn")] public CArray<Multilayer_LayerTemplateOverridesLevels> RoughLevelsIn { get; set; }
        [Ordinal(3)] [RED("metalLevelsIn")] public CArray<Multilayer_LayerTemplateOverridesLevels> MetalLevelsIn { get; set; }
        [Ordinal(4)] [RED("metalLevelsOut")] public CArray<Multilayer_LayerTemplateOverridesLevels> MetalLevelsOut { get; set; }
        [Ordinal(5)] [RED("normalStrength")] public CArray<Multilayer_LayerTemplateOverridesNormalStrength> NormalStrength { get; set; }
        

        public Multilayer_LayerTemplateOverrides(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class Multilayer_LayerTemplateOverridesColor : CVariable
    {
        [Ordinal(1)] [RED("n")] public CName N { get; set; }
        [Ordinal(2)] [RED("v", 2)] public CStatic<CFloat> V { get; set; }

        public Multilayer_LayerTemplateOverridesColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class Multilayer_LayerTemplateOverridesLevels : CVariable
    {
        [Ordinal(1)] [RED("n")] public CName N { get; set; }
        [Ordinal(2)] [RED("v", 2)] public CStatic<CFloat> V { get; set; }

        public Multilayer_LayerTemplateOverridesLevels(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class Multilayer_LayerTemplateOverridesNormalStrength : CVariable
    {
        [Ordinal(1)] [RED("n")] public CName N { get; set; }
        [Ordinal(2)] [RED("v", 2)] public CFloat V { get; set; }

        public Multilayer_LayerTemplateOverridesNormalStrength(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}