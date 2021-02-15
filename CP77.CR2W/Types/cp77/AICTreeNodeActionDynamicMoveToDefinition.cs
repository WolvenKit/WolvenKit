using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeActionDynamicMoveToDefinition : AICTreeNodeActionDefinition
	{
		[Ordinal(1)] [RED("moveType")] public CEnum<moveMovementType> MoveType { get; set; }
		[Ordinal(2)] [RED("tolerance")] public CFloat Tolerance { get; set; }
		[Ordinal(3)] [RED("target")] public CName Target { get; set; }
		[Ordinal(4)] [RED("keepDistance")] public CBool KeepDistance { get; set; }

		public AICTreeNodeActionDynamicMoveToDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
