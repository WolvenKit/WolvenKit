using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorInfluenceExcludeObstaclePointTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
		[Ordinal(1)]  [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }

		public AIbehaviorInfluenceExcludeObstaclePointTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
