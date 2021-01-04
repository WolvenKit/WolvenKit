using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AgentMovingHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(0)]  [RED("isMoving")] public CBool IsMoving { get; set; }
		[Ordinal(1)]  [RED("object")] public CName Object { get; set; }

		public AgentMovingHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
