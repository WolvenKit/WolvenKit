using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
