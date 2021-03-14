using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIGuardAreaConnectedCommunity : CVariable
	{
		[Ordinal(0)] [RED("communityArea")] public gameEntityReference CommunityArea { get; set; }
		[Ordinal(1)] [RED("isPrimary")] public CBool IsPrimary { get; set; }

		public AIGuardAreaConnectedCommunity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
