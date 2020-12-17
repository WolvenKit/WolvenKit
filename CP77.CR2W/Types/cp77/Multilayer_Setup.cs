using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;
using WolvenKit.Common.Model;

namespace WolvenKit.CR2W.Types
{


    [REDMeta]
    public class Multilayer_Layer : CVariable
    {
        [Ordinal(0)] [RED("matTile")] public CFloat MatTile { get; set; }
        [Ordinal(1)] [RED("microblend")] public rRef<CBitmapTexture> Microblend { get; set; }
        [Ordinal(1)] [RED("microblendContrast")] public CFloat MicroblendContrast { get; set; }
        [Ordinal(1)] [RED("microblendNormalStrength")] public CFloat microblendNormalStrength { get; set; }
        [Ordinal(1)] [RED("opacity")] public CFloat opacity { get; set; }
        [Ordinal(1)] [RED("material")] public rRef<Multilayer_LayerTemplate> material { get; set; }
        [Ordinal(1)] [RED("colorScale")] public CName colorScale { get; set; }
        [Ordinal(1)] [RED("normalStrength")] public CName normalStrength { get; set; }
        [Ordinal(1)] [RED("roughLevelsIn")] public CName roughLevelsIn { get; set; }
        [Ordinal(1)] [RED("roughLevelsOut")] public CName roughLevelsOut { get; set; }
        [Ordinal(1)] [RED("metalLevelsIn")] public CName metalLevelsIn { get; set; }
        [Ordinal(1)] [RED("metalLevelsOut")] public CName metalLevelsOut { get; set; }


        public Multilayer_Layer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}