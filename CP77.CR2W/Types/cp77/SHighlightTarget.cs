using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SHighlightTarget : CVariable
	{
		[Ordinal(0)] [RED("targetID")] public entEntityID TargetID { get; set; }
		[Ordinal(1)] [RED("highlightType")] public CEnum<EFocusForcedHighlightType> HighlightType { get; set; }

		public SHighlightTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
