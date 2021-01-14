using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AITrafficExternalWorkspotDefinition : worldTrafficSpotDefinition
	{
		[Ordinal(0)]  [RED("globalWorkspotNodeRef")] public NodeRef GlobalWorkspotNodeRef { get; set; }
		[Ordinal(1)]  [RED("nearestPointEntry")] public CBool NearestPointEntry { get; set; }

		public AITrafficExternalWorkspotDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
