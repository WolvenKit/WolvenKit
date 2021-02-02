using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLayout : CVariable
	{
		[Ordinal(0)]  [RED("padding")] public inkMargin Padding { get; set; }
		[Ordinal(1)]  [RED("margin")] public inkMargin Margin { get; set; }
		[Ordinal(2)]  [RED("anchorPoint")] public Vector2 AnchorPoint { get; set; }
		[Ordinal(3)]  [RED("sizeCoefficient")] public CFloat SizeCoefficient { get; set; }
		[Ordinal(4)]  [RED("HAlign")] public CEnum<inkEHorizontalAlign> HAlign { get; set; }
		[Ordinal(5)]  [RED("VAlign")] public CEnum<inkEVerticalAlign> VAlign { get; set; }
		[Ordinal(6)]  [RED("anchor")] public CEnum<inkEAnchor> Anchor { get; set; }
		[Ordinal(7)]  [RED("sizeRule")] public CEnum<inkESizeRule> SizeRule { get; set; }

		public inkWidgetLayout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
