using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITrafficExternalWorkspotDefinition : worldTrafficSpotDefinition
	{
		[Ordinal(2)] [RED("nearestPointEntry")] public CBool NearestPointEntry { get; set; }
		[Ordinal(3)] [RED("globalWorkspotNodeRef")] public NodeRef GlobalWorkspotNodeRef { get; set; }

		public AITrafficExternalWorkspotDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
