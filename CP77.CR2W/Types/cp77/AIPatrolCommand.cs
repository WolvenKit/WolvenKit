using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIPatrolCommand : AIMoveCommand
	{
		[Ordinal(7)] [RED("pathParams")] public CHandle<AIPatrolPathParameters> PathParams { get; set; }
		[Ordinal(8)] [RED("alertedPathParams")] public CHandle<AIPatrolPathParameters> AlertedPathParams { get; set; }
		[Ordinal(9)] [RED("alertedRadius")] public CFloat AlertedRadius { get; set; }
		[Ordinal(10)] [RED("alertedSpots")] public CArray<NodeRef> AlertedSpots { get; set; }
		[Ordinal(11)] [RED("patrolWithWeapon")] public CBool PatrolWithWeapon { get; set; }
		[Ordinal(12)] [RED("patrolAction")] public TweakDBID PatrolAction { get; set; }

		public AIPatrolCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
