using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AICombatGuardAreaConnectedCommunity : CVariable
	{
		[Ordinal(0)] [RED("communityArea")] public gameEntityReference CommunityArea { get; set; }
		[Ordinal(1)] [RED("conditions")] public CArray<CHandle<AIICombatGuardAreaCondition>> Conditions { get; set; }

		public AICombatGuardAreaConnectedCommunity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
