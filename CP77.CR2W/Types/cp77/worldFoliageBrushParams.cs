using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldFoliageBrushParams : CVariable
	{
		[Ordinal(0)]  [RED("Proximity")] public CFloat Proximity { get; set; }
		[Ordinal(1)]  [RED("Scale")] public CFloat Scale { get; set; }
		[Ordinal(2)]  [RED("ScaleVariation")] public CFloat ScaleVariation { get; set; }

		public worldFoliageBrushParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
