using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIPatrolRole : AIRole
	{
        [Ordinal(0)] [RED("alertedPathParams")] public CHandle<AIPatrolPathParameters> AlertedPathParams { get; set; }
        [Ordinal(1)] [RED("alertedRadius")] public CFloat AlertedRadius { get; set; }
        [Ordinal(2)] [RED("alertedSpots")] public CHandle<AIbehaviorWorkspotList> AlertedSpots { get; set; }
        [Ordinal(3)] [RED("forceAlerted")] public CBool ForceAlerted { get; set; }
        [Ordinal(4)] [RED("pathParams")] public CHandle<AIPatrolPathParameters> PathParams { get; set; }

		public AIPatrolRole(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
