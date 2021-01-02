using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;
using WolvenKit.Common.Model;

namespace WolvenKit.CR2W.Types
{


    [REDMeta]
    public class Multilayer_LayerTemplateOverridesColor : CVariable
    {
        [Ordinal(1)] [RED("n")] public CName N { get; set; }
        [Ordinal(2)] [RED("v", 2)] public CArrayFixedSize<CFloat> V { get; set; }

        public Multilayer_LayerTemplateOverridesColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class Multilayer_LayerTemplateOverridesLevels : CVariable
    {
        [Ordinal(1)] [RED("n")] public CName N { get; set; }
        [Ordinal(2)] [RED("v", 2)] public CArrayFixedSize<CFloat> V { get; set; }

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