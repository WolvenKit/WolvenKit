using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFindAlertedWorkspotTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("outWorkspotData")] public CHandle<AIArgumentMapping> OutWorkspotData { get; set; }
		[Ordinal(1)]  [RED("radius")] public CHandle<AIArgumentMapping> Radius { get; set; }
		[Ordinal(2)]  [RED("spots")] public CHandle<AIArgumentMapping> Spots { get; set; }
		[Ordinal(3)]  [RED("usedTokens")] public CHandle<AIArgumentMapping> UsedTokens { get; set; }

		public AIbehaviorFindAlertedWorkspotTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
