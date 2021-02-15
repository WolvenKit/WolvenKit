using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Multilayer_LayerOverrideSelection : CVariable
	{
		[Ordinal(0)] [RED("colorScale")] public CName ColorScale { get; set; }
		[Ordinal(1)] [RED("normalStrength")] public CName NormalStrength { get; set; }
		[Ordinal(2)] [RED("roughLevelsIn")] public CName RoughLevelsIn { get; set; }
		[Ordinal(3)] [RED("roughLevelsOut")] public CName RoughLevelsOut { get; set; }
		[Ordinal(4)] [RED("metalLevelsIn")] public CName MetalLevelsIn { get; set; }
		[Ordinal(5)] [RED("metalLevelsOut")] public CName MetalLevelsOut { get; set; }

		public Multilayer_LayerOverrideSelection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
