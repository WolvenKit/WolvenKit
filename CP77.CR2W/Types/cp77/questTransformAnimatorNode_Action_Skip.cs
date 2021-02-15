using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questTransformAnimatorNode_Action_Skip : questTransformAnimatorNode_ActionType
	{
		[Ordinal(0)] [RED("skipTo")] public CFloat SkipTo { get; set; }
		[Ordinal(1)] [RED("skipToEnd")] public CBool SkipToEnd { get; set; }

		public questTransformAnimatorNode_Action_Skip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
