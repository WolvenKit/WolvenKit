using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeActionDynamicMoveToDefinition : AICTreeNodeActionDefinition
	{
		[Ordinal(0)]  [RED("keepDistance")] public CBool KeepDistance { get; set; }
		[Ordinal(1)]  [RED("moveType")] public CEnum<moveMovementType> MoveType { get; set; }
		[Ordinal(2)]  [RED("target")] public CName Target { get; set; }
		[Ordinal(3)]  [RED("tolerance")] public CFloat Tolerance { get; set; }

		public AICTreeNodeActionDynamicMoveToDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
