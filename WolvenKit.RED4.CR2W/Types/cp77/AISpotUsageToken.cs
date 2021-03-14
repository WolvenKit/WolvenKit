using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISpotUsageToken : CVariable
	{
		[Ordinal(0)] [RED("usedSpotId")] public worldGlobalNodeID UsedSpotId { get; set; }
		[Ordinal(1)] [RED("spotUserId")] public entEntityID SpotUserId { get; set; }

		public AISpotUsageToken(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
