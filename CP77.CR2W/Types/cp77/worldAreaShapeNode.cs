using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldAreaShapeNode : worldNode
	{
		[Ordinal(4)] [RED("color")] public CColor Color { get; set; }
		[Ordinal(5)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }

		public worldAreaShapeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
